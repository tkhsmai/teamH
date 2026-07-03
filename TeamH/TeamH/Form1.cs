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
            Console.WriteLine("Form1_Load");        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void FavoriteBtn_Click(object sender, EventArgs e)
        {



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
