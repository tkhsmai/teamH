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

            string imagePath = @"\\NI85S-DNHBB-253\Users\User\Desktop\アプリケーション開発\チーム開発\teamH\images\";
            string fileName1 = "";
            string fileName2 = "";
            string fileName3 = "";

            switch (todayWeekdayId)
            {
                case 1:
                    fileName1 = "store1.jpeg";
                    fileName2 = "store2.jpg";
                    fileName3 = "store3.jpg";
                    break;
                case 2:
                    fileName1 = "store4.jpg";
                    fileName2 = "store5.png";
                    fileName3 = "store6.jpg";
                    break;
                case 3:
                    fileName1 = "store1.jpeg";
                    fileName2 = "store2.jpg";
                    fileName3 = "store3.jpg";
                    break;
                case 4:
                    fileName1 = "store4.jpg";
                    fileName2 = "store5.png";
                    fileName3 = "store6.jpg";
                    break;
                case 5:
                    fileName1 = "store1.jpeg";
                    fileName2 = "store3.jpg";
                    fileName3 = "store5.png";
                    break;
            }

            string[] fileNames = { fileName1, fileName2, fileName3 };

            for (int i = 0; i < 3; i++)
            {
                string filePath = imagePath + fileNames[i];
                if (System.IO.File.Exists(filePath) && !string.IsNullOrEmpty(fileNames[i]))
                {
                    StorePic[i].Image = Image.FromFile(filePath);
                    StorePic[i].SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    StorePic[i].Image = null;
                }
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))
            
            {
                conn.Open();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT");
                sql.Append("     Store.store_name");
                sql.Append("     , Store.image");
                sql.Append(" FROM");
                sql.Append("    Store");
                sql.Append("    INNER JOIN Weekday");
                sql.Append("        ON Store.weekday_id = Weekday.weekday_id");
                sql.Append(" WHERE");
                sql.Append("     Weekday.weekday = @weekday");

                DataTable storeDt = new DataTable();
                //using SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
                //{
                //    cmd.Parameters.Add("@weekday", SqlDbType.Int).Value = todayWeekdayId;
                //
                //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //    adapter.Fill(storeDt);
                //}
                //
                //
                //for (int i = 0; i < storeDt.Rows.Count && i < 3; i++)
                //{
                //    DataRow row = storeDt.Rows[i];
                //    int storeId = Convert.ToInt32(row["store_id"]);
                //
                //    StoreLbl[i].Text = row["store_name"].ToString();
                //
                //    StorePic[i].Image = imageList1.Images[ImageIndex];
                //}


            }
            

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
