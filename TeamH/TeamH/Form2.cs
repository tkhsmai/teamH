using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))
            {
                conn.Open();
                string sql =
                @"SELECT
                m.menu_name AS メニュー,
                  m.price AS 価格,
                COUNT(*) AS お気に入り回数
                   FROM Favorite f
                 INNER JOIN Menu m
                ON f.menu_id = m.menu_id
                AND f.store_id = m.store_id
                GROUP BY
                 m.menu_name,
                    m.price
                ORDER BY COUNT(*) DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                FvMenuDgv.DataSource = dt;
            }

            FvMenuDgv.DefaultCellStyle.Font = new Font("MS UI Gothic", 12);

            // 列幅変更
            FvMenuDgv.Columns["メニュー"].Width = 200;
            FvMenuDgv.Columns["価格"].Width = 90;
            FvMenuDgv.Columns["お気に入り回数"].Width = 150;

            // 行の高さ
            FvMenuDgv.RowTemplate.Height = 35;


        }


        private void BHomeBtn_Click(object sender, EventArgs e)
        {

            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
