using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace teamH
{
    public partial class Form3 : Form
    {
        private bool backToHome = false;
        public Form3()
        {
            InitializeComponent();
            this.FormClosing += Form3_FormClosing;
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            DeleteAddDgv.ReadOnly = true;
            ManagerPanel.Visible = false;


            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))

            {
                conn.Open();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT");
                sql.Append("     store_id");
                sql.Append("     ,store_name");
                sql.Append(" FROM");
                sql.Append("     Store");



                SqlDataAdapter da = new SqlDataAdapter(sql.ToString(), conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                StoreCbx2.DataSource = dt;
                StoreCbx2.DisplayMember = "store_name";
                StoreCbx2.ValueMember = "store_id";
            }
            StoreCbx2.DisplayMember = "store_name";
            StoreCbx2.ValueMember = "store_id";

        }
        // 店舗を選んだらメニュー一覧を表示
        //private void StoreCbx2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    LoadMenuList();
        //}

        // メニュー一覧を読み込む共通メソッド
        private void LoadMenuList()
        {
            if (StoreCbx2.SelectedValue == null) return;

            int storeId = Convert.ToInt32(((DataRowView)StoreCbx2.SelectedItem)["store_id"]);


            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))
            {
                conn.Open();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT");
                sql.Append("     menu_id");
                sql.Append("     ,menu_name AS メニュー名");
                sql.Append("     ,price AS 価格");
                sql.Append(" FROM");
                sql.Append("     Menu");
                sql.Append(" WHERE ");
                sql.Append("     store_id = @store_id");

                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@store_id", storeId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DeleteAddDgv.DataSource = dt;

                if (DeleteAddDgv.Columns.Contains("menu_id"))
                {
                    DeleteAddDgv.Columns["menu_id"].Visible = false;
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MenuAddTbx.Text) ||
        string.IsNullOrWhiteSpace(PriceAddTbx.Text))
            {
                MessageBox.Show("メニュー名と価格を入力してください");
                return;
            }
            // 選択中の店舗IDを取得
            DataRowView drv = (DataRowView)StoreCbx2.SelectedItem;
            int storeId = Convert.ToInt32(drv["store_id"]);

            string name = MenuAddTbx.Text;
            int price = int.Parse(PriceAddTbx.Text);
            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))
            {
                conn.Open();

                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ");
                sql.Append("     Menu (");
                sql.Append("     store_id");
                sql.Append("     ,menu_name");
                sql.Append("     ,price");
                sql.Append("     )");
                sql.Append(" VALUES ");
                sql.Append("     (");
                sql.Append("      @store_id");
                sql.Append("      ,@name");
                sql.Append("      ,@price");
                sql.Append("     )");

                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@store_id", storeId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("メニューを追加しました");
            LoadMenuList();   // 再読み込み
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // 行が選択されていない場合
            if (DeleteAddDgv.CurrentRow == null)
            {
                MessageBox.Show("削除するメニューを選択してください");
                return;
            }
            // 選択された行の menu_id を取得
            int menuId = Convert.ToInt32(DeleteAddDgv.CurrentRow.Cells["menu_id"].Value);
            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))
            {
                conn.Open();

                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE ");
                sql.Append("  FROM ");
                sql.Append("     Menu");
                sql.Append(" WHERE ");
                sql.Append("     menu_id = @menu_id");
                
                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@menu_id", menuId);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("メニューを削除しました");

            // 削除後に一覧を再読み込み
            LoadMenuList();
        }

        private void BHomeBtn2_Click(object sender, EventArgs e)
        {
            backToHome = true;   // ← Home から閉じたことを記録

            Form1 form1 = new Form1();
            form1.Show();
            this.Close();        // ← Form3 を閉じる
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!backToHome)
            {
                Application.Exit();   // ×ボタンで閉じたときだけ終了
            }
        }


        private void PassBtn_Click(object sender, EventArgs e)
        {
            string inputPassword = PassTbx.Text;

            // 正しいパスワード（あなたが決める）
            string correctPassword = "teamH";

            if (inputPassword == correctPassword)
            {
                MessageBox.Show("ログイン成功！");
                // 下のコンソールを表示
                ManagerPanel.Visible = true;

                // パスワード欄をロック
                PassTbx.Enabled = false;
                PassBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("パスワードが違います");
                PassTbx.Clear();
            }
        }

        private void SearchBtn2_Click(object sender, EventArgs e)
        {
            if (StoreCbx2.SelectedValue == null) return;

            int storeId = Convert.ToInt32(((DataRowView)StoreCbx2.SelectedItem)["store_id"]);


            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["teamH"].ConnectionString))
            {
                conn.Open();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT");
                sql.Append("     menu_id");
                sql.Append("     ,menu_name AS メニュー名");
                sql.Append("     ,price AS 価格");
                sql.Append(" FROM");
                sql.Append("     Menu");
                sql.Append(" WHERE ");
                sql.Append("     store_id = @store_id");

                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@store_id", storeId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DeleteAddDgv.DataSource = dt;

                if (DeleteAddDgv.Columns.Contains("menu_id"))
                {
                    DeleteAddDgv.Columns["menu_id"].Visible = false;
                }
            }
        }
    }
}




