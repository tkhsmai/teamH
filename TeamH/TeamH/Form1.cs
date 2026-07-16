using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms.ComponentModel.Com2Interop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace teamH
{
    public partial class Form1 : Form
    {
        private int[] menuIds1;
        private int[] menuIds2;
        private int[] menuIds3;

        private int[] storeIds = new int[3];




        public Form1()
        {
            InitializeComponent();
            TitlePicture.SendToBack();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MenuDgv1.ReadOnly = true;
            MenuDgv2.ReadOnly = true;
            MenuDgv3.ReadOnly = true;

            // 今日の曜日を取得　　todayWeekdayIdはweekday_idと対応
            int todayWeekdayId = (int)DateTime.Today.DayOfWeek;
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    todayWeekdayId = 1;
                    break;
                case DayOfWeek.Tuesday:
                    todayWeekdayId = 2;
                    break;
                case DayOfWeek.Wednesday:
                    todayWeekdayId = 3;
                    break;
                case DayOfWeek.Thursday:
                    todayWeekdayId = 4;
                    break;
                case DayOfWeek.Friday:
                    todayWeekdayId = 5;
                    break;
                default:
                    MessageBox.Show("本日は休日のため、出店はありません。");
                    return;
            }

            Label[] StoreLbl = { StoreLbl1, StoreLbl2, StoreLbl3 };
            PictureBox[] StorePic = { StorePicture1, StorePicture2, StorePicture3 };
            DataGridView[] Menu = { MenuDgv1, MenuDgv2, MenuDgv3 };

            // 曜日ごとに表示する画像を切り替える
            switch (todayWeekdayId)
            {
                case 1:
                    StorePicture1.Image = Properties.Resources.store1;
                    StorePicture2.Image = Properties.Resources.store2;
                    StorePicture3.Image = Properties.Resources.store3;
                    break;
                case 2:
                    StorePicture1.Image = Properties.Resources.store4;
                    StorePicture2.Image = Properties.Resources.store5;
                    StorePicture3.Image = Properties.Resources.store6;
                    break;
                case 3:
                    StorePicture1.Image = Properties.Resources.store1;
                    StorePicture2.Image = Properties.Resources.store2;
                    StorePicture3.Image = Properties.Resources.store3;
                    break;
                case 4:
                    StorePicture1.Image = Properties.Resources.store4;
                    StorePicture2.Image = Properties.Resources.store5;
                    StorePicture3.Image = Properties.Resources.store6;
                    break;
                case 5:
                    StorePicture1.Image = Properties.Resources.store1;
                    StorePicture2.Image = Properties.Resources.store3;
                    StorePicture3.Image = Properties.Resources.store5;
                    break;
            }



            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))

            {
                conn.Open();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT");
                sql.Append("     Store.store_id");
                sql.Append("     ,Store.store_name");
                sql.Append("     , Store.image");
                sql.Append(" FROM");
                sql.Append("     StoreWeekday");
                sql.Append("     INNER JOIN Store");
                sql.Append("         ON StoreWeekday.store_id = Store.store_id");
                sql.Append(" WHERE");
                sql.Append("     StoreWeekday.weekday_id = @weekday");


                DataTable storeDt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
                {
                    cmd.Parameters.Add("@weekday", SqlDbType.Int).Value = todayWeekdayId;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(storeDt);
                }
                for (int i = 0; i < storeDt.Rows.Count && i < 3; i++)
                {
                    DataRow row = storeDt.Rows[i];

                    // 店名をラベルに表示
                    StoreLbl[i].Text = row["store_name"].ToString();
                    int storeId = Convert.ToInt32(row["store_id"]);

                    storeIds[i] = storeId;


                    StringBuilder menusql = new StringBuilder();
                    menusql.Append("SELECT");
                    menusql.Append("    menu_id,");   // ★追加
                    menusql.Append("    menu_name");
                    menusql.Append("    ,price");
                    menusql.Append(" FROM");
                    menusql.Append("    Menu");
                    menusql.Append(" WHERE");
                    menusql.Append("    store_id = @store_id");

                    using (SqlCommand cmd2 = new SqlCommand(menusql.ToString(), conn))
                    {
                        cmd2.Parameters.Add("@store_id", SqlDbType.Int).Value = storeId;
                        SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                        DataTable menuDt = new DataTable();
                        adapter2.Fill(menuDt);

                        // ★配列初期化（必須）
                        if (i == 0) menuIds1 = new int[menuDt.Rows.Count];
                        if (i == 1) menuIds2 = new int[menuDt.Rows.Count];
                        if (i == 2) menuIds3 = new int[menuDt.Rows.Count];

                        Menu[i].DataSource = menuDt;
                        Menu[i].Columns["menu_id"].Visible = false;

                        Menu[i].AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        

                        Menu[i].Columns["menu_name"].HeaderText = "メニュー";
                        Menu[i].Columns["price"].HeaderText = "料金";
                        

                        Menu[i].ClearSelection();

                        for (int r = 0; r < menuDt.Rows.Count; r++)
                        {
                            int menuId = Convert.ToInt32(menuDt.Rows[r]["menu_id"]);

                            if (i == 0) menuIds1[r] = menuId;
                            if (i == 1) menuIds2[r] = menuId;
                            if (i == 2) menuIds3[r] = menuId;
                        }
                        MenuDgv1.CellClick += MenuDgv_CellClick;
                        MenuDgv2.CellClick += MenuDgv_CellClick;
                        MenuDgv3.CellClick += MenuDgv_CellClick;

                        Menu[i].Columns["menu_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        Menu[i].Columns["price"].Width = 70;

                    }

                }
               
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            MenuDgv1.ClearSelection();
            MenuDgv2.ClearSelection();
            MenuDgv3.ClearSelection();
        }
        private void MenuDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView current = sender as DataGridView;

            // 他のグリッドの選択を解除
            if (current != MenuDgv1) MenuDgv1.ClearSelection();
            if (current != MenuDgv2) MenuDgv2.ClearSelection();
            if (current != MenuDgv3) MenuDgv3.ClearSelection();

            // クリックされた行だけ選択
            current.ClearSelection();                 // ← まず全部解除
            current.Rows[e.RowIndex].Selected = true; // ← クリック行だけ青くする
        }

            private void SearchBtn_Click(object sender, EventArgs e)
        {
            Label[] StoreLbl = { StoreLbl1, StoreLbl2, StoreLbl3 };
            PictureBox[] StorePic = { StorePicture1, StorePicture2, StorePicture3 };
            DataGridView[] Menu = { MenuDgv1, MenuDgv2, MenuDgv3 };

            // 初期化
            for (int i = 0; i < 3; i++)
            {
                StoreLbl[i].Text = "";
                StorePic[i].Image = null;
                Menu[i].DataSource = null;
            }

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))
            {
                conn.Open();

                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT DISTINCT ");
                sql.Append(" s.store_id,");
                sql.Append(" s.store_name ");
                sql.Append("FROM Store s ");
                sql.Append("INNER JOIN StoreWeekday sw ");
                sql.Append(" ON s.store_id = sw.store_id ");
                sql.Append("INNER JOIN Weekday w ");
                sql.Append(" ON sw.weekday_id = w.weekday_id ");
                sql.Append("LEFT JOIN Menu m ");
                sql.Append(" ON s.store_id = m.store_id ");
                sql.Append("WHERE 1=1 ");

                if (StoreCbx.Text != "")
                    sql.Append(" AND s.store_name=@store ");

                if (WeekCbx.Text != "")
                    sql.Append(" AND w.weekday=@week ");

                if (MenuTbx.Text != "")
                    sql.Append(" AND m.menu_name LIKE '%' + @menu + '%' ");

                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);

                if (StoreCbx.Text != "")
                    cmd.Parameters.Add("@store", SqlDbType.NVarChar).Value = StoreCbx.Text;

                if (WeekCbx.Text != "")
                    cmd.Parameters.Add("@week", SqlDbType.NChar).Value = WeekCbx.Text;

                if (MenuTbx.Text != "")
                    cmd.Parameters.Add("@menu", SqlDbType.NVarChar).Value = MenuTbx.Text;

                DataTable storeDt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(storeDt);





                if (storeDt.Rows.Count == 0)
                {
                    MessageBox.Show("検索結果がありません。");
                    return;
                }

                for (int i = 0; i < storeDt.Rows.Count && i < 3; i++)
                {
                    int storeId = Convert.ToInt32(storeDt.Rows[i]["store_id"]);
                    storeIds[i] = storeId;

                    StoreLbl[i].Text = storeDt.Rows[i]["store_name"].ToString();

                    // 画像表示
                    switch (storeId)
                    {
                        case 1:
                            StorePic[i].Image = Properties.Resources.store1;
                            break;
                        case 2:
                            StorePic[i].Image = Properties.Resources.store2;
                            break;
                        case 3:
                            StorePic[i].Image = Properties.Resources.store3;
                            break;
                        case 4:
                            StorePic[i].Image = Properties.Resources.store4;
                            break;
                        case 5:
                            StorePic[i].Image = Properties.Resources.store5;
                            break;
                        case 6:
                            StorePic[i].Image = Properties.Resources.store6;
                            break;
                    }

                    // メニュー取得
                    StringBuilder menuSql = new StringBuilder();
                    menuSql.Append("SELECT menu_id, menu_name, price ");
                    menuSql.Append("FROM Menu ");
                    menuSql.Append("WHERE store_id=@store_id ");

                    if (MenuTbx.Text != "")
                        menuSql.Append("AND menu_name LIKE '%' + @menu + '%' ");

                    SqlCommand cmd2 = new SqlCommand(menuSql.ToString(), conn);
                    cmd2.Parameters.Add("@store_id", SqlDbType.Int).Value = storeId;

                    if (MenuTbx.Text != "")
                        cmd2.Parameters.Add("@menu", SqlDbType.NVarChar).Value = MenuTbx.Text;

                    DataTable menuDt = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(menuDt);

                    Menu[i].DataSource = menuDt;
                    Menu[i].Columns["menu_id"].Visible = false;

                    Menu[i].AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    Menu[i].Columns["menu_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    Menu[i].Columns["price"].Width = 70;

                    Menu[i].Columns["menu_name"].HeaderText = "メニュー";
                    Menu[i].Columns["price"].HeaderText = "価格";
                    Menu[i].ClearSelection();
                }
            }
    }
        

        private void FavoriteBtn_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();      
            this.Hide();      



        }

        private void FavoriteCntBtn_Click(object sender, EventArgs e)
        {
            DataGridView trygetGrid = null;

            if (MenuDgv1.CurrentRow != null) trygetGrid = MenuDgv1;
            else if (MenuDgv2.CurrentRow != null) trygetGrid = MenuDgv2;
            else if (MenuDgv3.CurrentRow != null) trygetGrid = MenuDgv3;

            if (trygetGrid == null)
            {
                MessageBox.Show("行が選択されていません");
                return;
            }

            // どのグリッドか判定
            int index = (trygetGrid == MenuDgv1) ? 0 :
                        (trygetGrid == MenuDgv2) ? 1 : 2;

            // 選択された行番号
            int rowIndex = trygetGrid.CurrentRow.Index;

            // ★ menu_id は DataGridView から読まない（別で取得）
            int menuId =
                (trygetGrid == MenuDgv1) ? menuIds1[rowIndex] :
                (trygetGrid == MenuDgv2) ? menuIds2[rowIndex] :
                                           menuIds3[rowIndex];

            // store_id は保持してある値を使う
            int storeId = storeIds[index];
            int price = Convert.ToInt32(trygetGrid.CurrentRow.Cells["price"].Value);
            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ");
                sql.Append(" favorite ( ");
                sql.Append("  menu_id ");
                sql.Append("  ,store_id ");
                sql.Append("  ,price ");
                sql.Append(" ) ");
                sql.Append(" VALUES ");
                sql.Append(" ( ");
                sql.Append(" @menu_id ");
                sql.Append(" ,@store_id ");
                sql.Append("  ,@price ");
                sql.Append(" ) ");
                cmd.CommandText = sql.ToString();


                cmd.Parameters.Add("@menu_id", SqlDbType.Int).Value = menuId;
                cmd.Parameters.Add("@store_id", SqlDbType.Int).Value = storeId;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("お気に入りに追加しました！");
        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
