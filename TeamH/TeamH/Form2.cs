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
        private bool backToHome = false;

        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!backToHome)
            {
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))
            {
                conn.Open();

                // ===== 左：お気に入りメニュー（重複なし） =====
                string sqlFv =
                @"SELECT DISTINCT
                    s.store_name AS 店名,
                    m.menu_name AS メニュー,
                    m.price AS 価格
                  FROM Favorite f
                  INNER JOIN Menu m
                    ON f.menu_id = m.menu_id
                    AND f.store_id = m.store_id
                  INNER JOIN Store s
                    ON f.store_id = s.store_id";

                SqlDataAdapter daFv = new SqlDataAdapter(sqlFv, conn);
                DataTable dtFv = new DataTable();
                daFv.Fill(dtFv);
                FvMenuDgv.DataSource = dtFv;

                // ===== 右：人気ランキング TOP5 =====
                string sqlRk =
                @"SELECT TOP 5
                    CAST(ROW_NUMBER() OVER (ORDER BY COUNT(*) DESC) AS NVARCHAR) AS 順位,
                    s.store_name AS 店名,
                    m.menu_name AS メニュー,
                    m.price AS 価格,
                    COUNT(*) AS お気に入り回数
                  FROM Favorite f
                  INNER JOIN Menu m
                    ON f.menu_id = m.menu_id
                    AND f.store_id = m.store_id
                  INNER JOIN Store s
                    ON f.store_id = s.store_id
                  GROUP BY
                    s.store_name,
                    m.menu_name,
                    m.price
                  ORDER BY COUNT(*) DESC";

                SqlDataAdapter daRk = new SqlDataAdapter(sqlRk, conn);
                DataTable dtRk = new DataTable();
                daRk.Fill(dtRk);
                RkMenuDgv.DataSource = dtRk;
            }

            // ===== 左DGV スタイル =====
            FvMenuDgv.DefaultCellStyle.Font = new Font("MS UI Gothic", 12);
            FvMenuDgv.DefaultCellStyle.ForeColor = Color.Black;
            FvMenuDgv.DefaultCellStyle.SelectionBackColor = Color.White;
            FvMenuDgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            FvMenuDgv.GridColor = Color.Gray;
            FvMenuDgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            FvMenuDgv.Columns["店名"].Width = 180;
            FvMenuDgv.Columns["メニュー"].Width = 180;
            FvMenuDgv.Columns["価格"].Width = 80;
            FvMenuDgv.RowTemplate.Height = 35;
            foreach (DataGridViewRow row in FvMenuDgv.Rows) // ← 追加
            {
                row.Height = 35;
            }


            // ===== 右DGV スタイル =====
            RkMenuDgv.DefaultCellStyle.Font = new Font("MS UI Gothic", 12);
            RkMenuDgv.DefaultCellStyle.ForeColor = Color.Black;
            RkMenuDgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            RkMenuDgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            RkMenuDgv.Columns["順位"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            RkMenuDgv.Columns["お気に入り回数"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            RkMenuDgv.Columns["順位"].Width = 80;
            RkMenuDgv.Columns["店名"].Width = 130;
            RkMenuDgv.Columns["メニュー"].Width = 150;
            RkMenuDgv.Columns["価格"].Width = 70;
            RkMenuDgv.Columns["お気に入り回数"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RkMenuDgv.RowTemplate.Height = 35;
            RkMenuDgv.AllowUserToAddRows = false;
            RkMenuDgv.RowHeadersVisible = false;
            foreach (DataGridViewRow row in RkMenuDgv.Rows) // ← 追加
            {
                row.Height = 35;
            }


            // 列スタイルのBackColorを強制リセット
            foreach (DataGridViewColumn col in RkMenuDgv.Columns)
            {
                col.DefaultCellStyle.BackColor = Color.Empty;
            }

            // 1〜5位カラー
            for (int i = 0; i < RkMenuDgv.Rows.Count; i++)
            {
                Color rowColor;
                switch (i)
                {
                    case 0: rowColor = Color.FromArgb(220, 220, 220); break; // 1位 薄グレー
                    case 1: rowColor = Color.White; break;                   // 2位 白
                    case 2: rowColor = Color.FromArgb(220, 220, 220); break; // 3位 薄グレー
                    case 3: rowColor = Color.White; break;                   // 4位 白
                    case 4: rowColor = Color.FromArgb(220, 220, 220); break; // 5位 薄グレー
                    default: rowColor = Color.White; break;
                }

                foreach (DataGridViewCell cell in RkMenuDgv.Rows[i].Cells)
                {
                    cell.Style.BackColor = rowColor;
                }
            }
        }

        private void BHomeBtn_Click(object sender, EventArgs e)
        {
            backToHome = true;
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}