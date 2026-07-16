namespace teamH
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BHomeBtn2 = new System.Windows.Forms.Button();
            this.PassTbx = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.PassBtn = new System.Windows.Forms.Button();
            this.ManagerPanel = new System.Windows.Forms.Panel();
            this.DeleteAddDgv = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.StoreLbl2 = new System.Windows.Forms.Label();
            this.StoreCbx2 = new System.Windows.Forms.ComboBox();
            this.SearchBtn2 = new System.Windows.Forms.Button();
            this.AddGbx = new System.Windows.Forms.GroupBox();
            this.MenuAddTbx = new System.Windows.Forms.TextBox();
            this.MenuLbl2 = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.PriceAddTbx = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ManagerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAddDgv)).BeginInit();
            this.AddGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // BHomeBtn2
            // 
            this.BHomeBtn2.BackColor = System.Drawing.Color.OldLace;
            this.BHomeBtn2.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BHomeBtn2.Location = new System.Drawing.Point(75, 71);
            this.BHomeBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.BHomeBtn2.Name = "BHomeBtn2";
            this.BHomeBtn2.Size = new System.Drawing.Size(155, 65);
            this.BHomeBtn2.TabIndex = 0;
            this.BHomeBtn2.Text = "Home";
            this.BHomeBtn2.UseVisualStyleBackColor = false;
            this.BHomeBtn2.Click += new System.EventHandler(this.BHomeBtn2_Click);
            // 
            // PassTbx
            // 
            this.PassTbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassTbx.Location = new System.Drawing.Point(419, 122);
            this.PassTbx.Margin = new System.Windows.Forms.Padding(4);
            this.PassTbx.Name = "PassTbx";
            this.PassTbx.Size = new System.Drawing.Size(349, 35);
            this.PassTbx.TabIndex = 9;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassLbl.Location = new System.Drawing.Point(414, 71);
            this.PassLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(404, 27);
            this.PassLbl.TabIndex = 10;
            this.PassLbl.Text = "パスワードを入力してください";
            // 
            // PassBtn
            // 
            this.PassBtn.BackColor = System.Drawing.Color.OldLace;
            this.PassBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassBtn.Location = new System.Drawing.Point(825, 122);
            this.PassBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PassBtn.Name = "PassBtn";
            this.PassBtn.Size = new System.Drawing.Size(79, 36);
            this.PassBtn.TabIndex = 16;
            this.PassBtn.Text = "OK";
            this.PassBtn.UseVisualStyleBackColor = false;
            this.PassBtn.Click += new System.EventHandler(this.PassBtn_Click);
            // 
            // ManagerPanel
            // 
            this.ManagerPanel.Controls.Add(this.AddGbx);
            this.ManagerPanel.Controls.Add(this.SearchBtn2);
            this.ManagerPanel.Controls.Add(this.StoreCbx2);
            this.ManagerPanel.Controls.Add(this.StoreLbl2);
            this.ManagerPanel.Controls.Add(this.DeleteBtn);
            this.ManagerPanel.Controls.Add(this.DeleteAddDgv);
            this.ManagerPanel.Location = new System.Drawing.Point(75, 247);
            this.ManagerPanel.Name = "ManagerPanel";
            this.ManagerPanel.Size = new System.Drawing.Size(1851, 802);
            this.ManagerPanel.TabIndex = 18;
            // 
            // DeleteAddDgv
            // 
            this.DeleteAddDgv.AllowUserToAddRows = false;
            this.DeleteAddDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteAddDgv.Location = new System.Drawing.Point(885, 4);
            this.DeleteAddDgv.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteAddDgv.Name = "DeleteAddDgv";
            this.DeleteAddDgv.RowHeadersVisible = false;
            this.DeleteAddDgv.RowHeadersWidth = 51;
            this.DeleteAddDgv.RowTemplate.Height = 24;
            this.DeleteAddDgv.Size = new System.Drawing.Size(962, 554);
            this.DeleteAddDgv.TabIndex = 19;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.OldLace;
            this.DeleteBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteBtn.Location = new System.Drawing.Point(1335, 670);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(121, 61);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "削除";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // StoreLbl2
            // 
            this.StoreLbl2.AutoSize = true;
            this.StoreLbl2.Font = new System.Drawing.Font("ＭＳ ゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl2.Location = new System.Drawing.Point(99, 36);
            this.StoreLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StoreLbl2.Name = "StoreLbl2";
            this.StoreLbl2.Size = new System.Drawing.Size(73, 30);
            this.StoreLbl2.TabIndex = 19;
            this.StoreLbl2.Text = "店名";
            // 
            // StoreCbx2
            // 
            this.StoreCbx2.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreCbx2.FormattingEnabled = true;
            this.StoreCbx2.Items.AddRange(new object[] {
            "スマイルバーガー号",
            "からあげ太郎",
            "スパイス工房",
            "クレープスマイル",
            "たこ丸キッチン",
            "ソウルキッチン号"});
            this.StoreCbx2.Location = new System.Drawing.Point(271, 30);
            this.StoreCbx2.Margin = new System.Windows.Forms.Padding(4);
            this.StoreCbx2.Name = "StoreCbx2";
            this.StoreCbx2.Size = new System.Drawing.Size(273, 36);
            this.StoreCbx2.TabIndex = 19;
            // 
            // SearchBtn2
            // 
            this.SearchBtn2.BackColor = System.Drawing.Color.OldLace;
            this.SearchBtn2.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchBtn2.Location = new System.Drawing.Point(422, 115);
            this.SearchBtn2.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn2.Name = "SearchBtn2";
            this.SearchBtn2.Size = new System.Drawing.Size(122, 55);
            this.SearchBtn2.TabIndex = 19;
            this.SearchBtn2.Text = "検索";
            this.SearchBtn2.UseVisualStyleBackColor = false;
            // 
            // AddGbx
            // 
            this.AddGbx.Controls.Add(this.MenuAddTbx);
            this.AddGbx.Controls.Add(this.MenuLbl2);
            this.AddGbx.Controls.Add(this.PriceLbl);
            this.AddGbx.Controls.Add(this.PriceAddTbx);
            this.AddGbx.Controls.Add(this.AddBtn);
            this.AddGbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddGbx.Location = new System.Drawing.Point(112, 270);
            this.AddGbx.Margin = new System.Windows.Forms.Padding(4);
            this.AddGbx.Name = "AddGbx";
            this.AddGbx.Padding = new System.Windows.Forms.Padding(4);
            this.AddGbx.Size = new System.Drawing.Size(581, 247);
            this.AddGbx.TabIndex = 19;
            this.AddGbx.TabStop = false;
            this.AddGbx.Text = "メニュー追加";
            // 
            // MenuAddTbx
            // 
            this.MenuAddTbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuAddTbx.Location = new System.Drawing.Point(200, 61);
            this.MenuAddTbx.Margin = new System.Windows.Forms.Padding(4);
            this.MenuAddTbx.Name = "MenuAddTbx";
            this.MenuAddTbx.Size = new System.Drawing.Size(218, 35);
            this.MenuAddTbx.TabIndex = 18;
            // 
            // MenuLbl2
            // 
            this.MenuLbl2.AutoSize = true;
            this.MenuLbl2.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuLbl2.Location = new System.Drawing.Point(32, 68);
            this.MenuLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MenuLbl2.Name = "MenuLbl2";
            this.MenuLbl2.Size = new System.Drawing.Size(124, 28);
            this.MenuLbl2.TabIndex = 17;
            this.MenuLbl2.Text = "メニュー";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PriceLbl.Location = new System.Drawing.Point(32, 170);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(68, 28);
            this.PriceLbl.TabIndex = 16;
            this.PriceLbl.Text = "値段";
            // 
            // PriceAddTbx
            // 
            this.PriceAddTbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PriceAddTbx.Location = new System.Drawing.Point(200, 169);
            this.PriceAddTbx.Margin = new System.Windows.Forms.Padding(4);
            this.PriceAddTbx.Name = "PriceAddTbx";
            this.PriceAddTbx.Size = new System.Drawing.Size(170, 35);
            this.PriceAddTbx.TabIndex = 14;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.OldLace;
            this.AddBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddBtn.Location = new System.Drawing.Point(428, 157);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 58);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "追加";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.PassBtn);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.PassTbx);
            this.Controls.Add(this.BHomeBtn2);
            this.Controls.Add(this.ManagerPanel);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ManagerPanel.ResumeLayout(false);
            this.ManagerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAddDgv)).EndInit();
            this.AddGbx.ResumeLayout(false);
            this.AddGbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BHomeBtn2;
        private System.Windows.Forms.TextBox PassTbx;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Button PassBtn;
        private System.Windows.Forms.Panel ManagerPanel;
        private System.Windows.Forms.GroupBox AddGbx;
        private System.Windows.Forms.TextBox MenuAddTbx;
        private System.Windows.Forms.Label MenuLbl2;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.TextBox PriceAddTbx;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SearchBtn2;
        private System.Windows.Forms.ComboBox StoreCbx2;
        private System.Windows.Forms.Label StoreLbl2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView DeleteAddDgv;
    }
}