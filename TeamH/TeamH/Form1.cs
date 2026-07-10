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

        private int[] weekdayIds = new int[3];
        private int[] storeIds = new int[3];




        public Form1()
        {
            InitializeComponent();
            TitlePicture.SendToBack();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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
                        Menu[i].Columns["menu_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        Menu[i].Columns["price"].Width = 55;


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

            // weekday_id は保持してある値を使う
            int weekdayId = weekdayIds[index];
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
                sql.Append("  ,weekday_id ");
                sql.Append("  ,price ");
                sql.Append(" ) ");
                sql.Append(" VALUES ");
                sql.Append(" ( ");
                sql.Append(" @menu_id ");
                sql.Append(" ,@weekday_id ");
                sql.Append("  ,@price ");
                sql.Append(" ) ");
                cmd.CommandText = sql.ToString();


                cmd.Parameters.Add("@menu_id", SqlDbType.Int).Value = menuId;
                cmd.Parameters.Add("@weekday_id", SqlDbType.Int).Value = weekdayId;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("お気に入りに追加しました！");
        }


    }
}
