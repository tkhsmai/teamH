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

namespace teamH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                        Menu[i].DataSource = menuDt;

                        // 列設定
                        Menu[i].Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        Menu[i].Columns[1].Width = 55;

                        Menu[i].Columns["menu_name"].HeaderText = "メニュー";
                        Menu[i].Columns["price"].HeaderText = "料金";

                        // 選択解除
                        Menu[i].ClearSelection();


                    }
                }
                MenuDgv1.SelectionChanged += MenuDgv_SelectionChanged;
                MenuDgv2.SelectionChanged += MenuDgv_SelectionChanged;
                MenuDgv3.SelectionChanged += MenuDgv_SelectionChanged;
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            MenuDgv1.ClearSelection();
            MenuDgv2.ClearSelection();
            MenuDgv3.ClearSelection();
        }
        private void MenuDgv_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView current = sender as DataGridView;

            if (!current.Focused)
                return;

            if (current != MenuDgv1)
                MenuDgv1.ClearSelection();

            if (current != MenuDgv2)
                MenuDgv2.ClearSelection();

            if (current != MenuDgv3)
                MenuDgv3.ClearSelection();
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
            //trygetGrid を最初に宣言する
            DataGridView trygetGrid = null;
            //DAtaGridviewの選択行のチェックボックス
            if (MenuDgv1.CurrentRow != null)
            {
                trygetGrid = MenuDgv1;
            }
            else if (MenuDgv2.CurrentRow != null)
            {
                trygetGrid = MenuDgv2;
            }
            else if (MenuDgv3.CurrentRow != null)
            {
                trygetGrid = MenuDgv3;
            }
            //選択されていない場合
            if(trygetGrid == null)
            {
                MessageBox.Show("行が選択されていません");
                return;
            }
            //選択された行の値を取得
            int storeId = Convert.ToInt32(trygetGrid.CurrentRow.Cells["store_id"].Value);
            int menuId = Convert.ToInt32(trygetGrid.CurrentRow.Cells["menu_id"].Value);
            string menuName = trygetGrid.CurrentRow.Cells["menu_name"].Value.ToString();
            string weekdayName = trygetGrid.CurrentRow.Cells["weekday"].Value.ToString();
            int weekdayId = Convert.ToInt32(trygetGrid.CurrentRow.Cells["weekday_id"].Value);
            using (SqlConnection conn = new SqlConnection("Server=NI85S-DNHBB-253\\MSSQLSERVER,1433;Database=teamH;User ID=sa;Password=wiz;TrustServerCertificate=True;"))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                //SQLを作成
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO favorite (");
                sql.Append(" store_id,");
                sql.Append(" menu_id,");
                sql.Append("weekday=id");
                sql.Append(") VALUES (");
                sql.Append(" @store_id,");
                sql.Append(" @menu_id,");
                sql.Append(" @weekday_id,");
                sql.Append(" )");
                cmd.CommandText = sql.ToString();
                //パラメーター追加
                cmd.Parameters.Add("@store_id", SqlDbType.Int).Value = storeId;
                cmd.Parameters.Add("@menu_id", SqlDbType.Int).Value = menuId;
                cmd.Parameters.Add("@weekday_id", SqlDbType.Int).Value = weekdayId;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show($"{menuName}を{weekdayName}の気に入りに追加しました！");
        }

    }
}
