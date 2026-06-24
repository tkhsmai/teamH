namespace teamH
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeBtn = new System.Windows.Forms.Button();
            this.WeekLbl = new System.Windows.Forms.Label();
            this.StoreLbl = new System.Windows.Forms.Label();
            this.MenuLbl = new System.Windows.Forms.Label();
            this.WeekCbx = new System.Windows.Forms.ComboBox();
            this.StoreCbx = new System.Windows.Forms.ComboBox();
            this.MenuTbx = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.FavoriteBtn = new System.Windows.Forms.Button();
            this.Storelbl1 = new System.Windows.Forms.Label();
            this.Storelbl2 = new System.Windows.Forms.Label();
            this.Storelbl3 = new System.Windows.Forms.Label();
            this.Storepicture1 = new System.Windows.Forms.PictureBox();
            this.Storepicture2 = new System.Windows.Forms.PictureBox();
            this.Storepicture3 = new System.Windows.Forms.PictureBox();
            this.MenuDgv1 = new System.Windows.Forms.DataGridView();
            this.MenuDgv2 = new System.Windows.Forms.DataGridView();
            this.MenuDgv3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Storepicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storepicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storepicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HomeBtn.Location = new System.Drawing.Point(72, 28);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(101, 54);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // WeekLbl
            // 
            this.WeekLbl.AutoSize = true;
            this.WeekLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeekLbl.Location = new System.Drawing.Point(124, 110);
            this.WeekLbl.Name = "WeekLbl";
            this.WeekLbl.Size = new System.Drawing.Size(49, 20);
            this.WeekLbl.TabIndex = 1;
            this.WeekLbl.Text = "曜日";
            // 
            // StoreLbl
            // 
            this.StoreLbl.AutoSize = true;
            this.StoreLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl.Location = new System.Drawing.Point(124, 165);
            this.StoreLbl.Name = "StoreLbl";
            this.StoreLbl.Size = new System.Drawing.Size(49, 20);
            this.StoreLbl.TabIndex = 2;
            this.StoreLbl.Text = "店名";
            // 
            // MenuLbl
            // 
            this.MenuLbl.AutoSize = true;
            this.MenuLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuLbl.Location = new System.Drawing.Point(124, 215);
            this.MenuLbl.Name = "MenuLbl";
            this.MenuLbl.Size = new System.Drawing.Size(89, 20);
            this.MenuLbl.TabIndex = 3;
            this.MenuLbl.Text = "メニュー";
            // 
            // WeekCbx
            // 
            this.WeekCbx.FormattingEnabled = true;
            this.WeekCbx.Items.AddRange(new object[] {
            "月",
            "火",
            "水",
            "木",
            "金"});
            this.WeekCbx.Location = new System.Drawing.Point(227, 107);
            this.WeekCbx.Name = "WeekCbx";
            this.WeekCbx.Size = new System.Drawing.Size(121, 23);
            this.WeekCbx.TabIndex = 4;
            // 
            // StoreCbx
            // 
            this.StoreCbx.FormattingEnabled = true;
            this.StoreCbx.Items.AddRange(new object[] {
            "スマイルバーガー号",
            "からあげ太郎",
            "スパイス工房",
            "クレープスマイル",
            "たこ丸キッチン",
            "ソウルキッチン号"});
            this.StoreCbx.Location = new System.Drawing.Point(227, 162);
            this.StoreCbx.Name = "StoreCbx";
            this.StoreCbx.Size = new System.Drawing.Size(121, 23);
            this.StoreCbx.TabIndex = 5;
            // 
            // MenuTbx
            // 
            this.MenuTbx.Location = new System.Drawing.Point(227, 213);
            this.MenuTbx.Name = "MenuTbx";
            this.MenuTbx.Size = new System.Drawing.Size(121, 22);
            this.MenuTbx.TabIndex = 6;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchBtn.Location = new System.Drawing.Point(254, 263);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 44);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "検索";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // FavoriteBtn
            // 
            this.FavoriteBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FavoriteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoriteBtn.Location = new System.Drawing.Point(72, 354);
            this.FavoriteBtn.Name = "FavoriteBtn";
            this.FavoriteBtn.Size = new System.Drawing.Size(307, 55);
            this.FavoriteBtn.TabIndex = 10;
            this.FavoriteBtn.Text = "お気に入り・ランキング";
            this.FavoriteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoriteBtn.UseVisualStyleBackColor = true;
            this.FavoriteBtn.Click += new System.EventHandler(this.FavoriteBtn_Click);
            // 
            // Storelbl1
            // 
            this.Storelbl1.AutoSize = true;
            this.Storelbl1.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Storelbl1.Location = new System.Drawing.Point(676, 82);
            this.Storelbl1.Name = "Storelbl1";
            this.Storelbl1.Size = new System.Drawing.Size(85, 34);
            this.Storelbl1.TabIndex = 11;
            this.Storelbl1.Text = "店名";
            // 
            // Storelbl2
            // 
            this.Storelbl2.AutoSize = true;
            this.Storelbl2.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Storelbl2.Location = new System.Drawing.Point(1085, 83);
            this.Storelbl2.Name = "Storelbl2";
            this.Storelbl2.Size = new System.Drawing.Size(85, 34);
            this.Storelbl2.TabIndex = 12;
            this.Storelbl2.Text = "店名";
            // 
            // Storelbl3
            // 
            this.Storelbl3.AutoSize = true;
            this.Storelbl3.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Storelbl3.Location = new System.Drawing.Point(1536, 82);
            this.Storelbl3.Name = "Storelbl3";
            this.Storelbl3.Size = new System.Drawing.Size(85, 34);
            this.Storelbl3.TabIndex = 13;
            this.Storelbl3.Text = "店名";
            // 
            // Storepicture1
            // 
            this.Storepicture1.Location = new System.Drawing.Point(557, 140);
            this.Storepicture1.Name = "Storepicture1";
            this.Storepicture1.Size = new System.Drawing.Size(355, 208);
            this.Storepicture1.TabIndex = 15;
            this.Storepicture1.TabStop = false;
            this.Storepicture1.Click += new System.EventHandler(this.Storepicture1_Click);
            // 
            // Storepicture2
            // 
            this.Storepicture2.Location = new System.Drawing.Point(991, 140);
            this.Storepicture2.Name = "Storepicture2";
            this.Storepicture2.Size = new System.Drawing.Size(350, 208);
            this.Storepicture2.TabIndex = 16;
            this.Storepicture2.TabStop = false;
            // 
            // Storepicture3
            // 
            this.Storepicture3.Location = new System.Drawing.Point(1404, 140);
            this.Storepicture3.Name = "Storepicture3";
            this.Storepicture3.Size = new System.Drawing.Size(353, 208);
            this.Storepicture3.TabIndex = 17;
            this.Storepicture3.TabStop = false;
            // 
            // MenuDgv1
            // 
            this.MenuDgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDgv1.Location = new System.Drawing.Point(557, 371);
            this.MenuDgv1.Name = "MenuDgv1";
            this.MenuDgv1.RowHeadersWidth = 51;
            this.MenuDgv1.RowTemplate.Height = 24;
            this.MenuDgv1.Size = new System.Drawing.Size(355, 411);
            this.MenuDgv1.TabIndex = 18;
            // 
            // MenuDgv2
            // 
            this.MenuDgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDgv2.Location = new System.Drawing.Point(991, 371);
            this.MenuDgv2.Name = "MenuDgv2";
            this.MenuDgv2.RowHeadersWidth = 51;
            this.MenuDgv2.RowTemplate.Height = 24;
            this.MenuDgv2.Size = new System.Drawing.Size(350, 411);
            this.MenuDgv2.TabIndex = 19;
            // 
            // MenuDgv3
            // 
            this.MenuDgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDgv3.Location = new System.Drawing.Point(1404, 371);
            this.MenuDgv3.Name = "MenuDgv3";
            this.MenuDgv3.RowHeadersWidth = 51;
            this.MenuDgv3.RowTemplate.Height = 24;
            this.MenuDgv3.Size = new System.Drawing.Size(353, 411);
            this.MenuDgv3.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 717);
            this.Controls.Add(this.MenuDgv3);
            this.Controls.Add(this.MenuDgv2);
            this.Controls.Add(this.MenuDgv1);
            this.Controls.Add(this.Storepicture3);
            this.Controls.Add(this.Storepicture2);
            this.Controls.Add(this.Storepicture1);
            this.Controls.Add(this.Storelbl3);
            this.Controls.Add(this.Storelbl2);
            this.Controls.Add(this.Storelbl1);
            this.Controls.Add(this.FavoriteBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.MenuTbx);
            this.Controls.Add(this.StoreCbx);
            this.Controls.Add(this.WeekCbx);
            this.Controls.Add(this.MenuLbl);
            this.Controls.Add(this.StoreLbl);
            this.Controls.Add(this.WeekLbl);
            this.Controls.Add(this.HomeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storepicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storepicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storepicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label WeekLbl;
        private System.Windows.Forms.Label StoreLbl;
        private System.Windows.Forms.Label MenuLbl;
        private System.Windows.Forms.ComboBox WeekCbx;
        private System.Windows.Forms.ComboBox StoreCbx;
        private System.Windows.Forms.TextBox MenuTbx;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button FavoriteBtn;
        private System.Windows.Forms.Label Storelbl1;
        private System.Windows.Forms.Label Storelbl2;
        private System.Windows.Forms.Label Storelbl3;
        private System.Windows.Forms.PictureBox Storepicture1;
        private System.Windows.Forms.PictureBox Storepicture2;
        private System.Windows.Forms.PictureBox Storepicture3;
        private System.Windows.Forms.DataGridView MenuDgv1;
        private System.Windows.Forms.DataGridView MenuDgv2;
        private System.Windows.Forms.DataGridView MenuDgv3;
    }
}

