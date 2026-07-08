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
            this.StoreLbl1 = new System.Windows.Forms.Label();
            this.StoreLbl2 = new System.Windows.Forms.Label();
            this.StoreLbl3 = new System.Windows.Forms.Label();
            this.StorePicture1 = new System.Windows.Forms.PictureBox();
            this.StorePicture2 = new System.Windows.Forms.PictureBox();
            this.StorePicture3 = new System.Windows.Forms.PictureBox();
            this.MenuDgv1 = new System.Windows.Forms.DataGridView();
            this.MenuDgv2 = new System.Windows.Forms.DataGridView();
            this.MenuDgv3 = new System.Windows.Forms.DataGridView();
            this.FavoriteCntBtn = new System.Windows.Forms.Button();
            this.TodayLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HomeBtn.Location = new System.Drawing.Point(37, 33);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(124, 54);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            // 
            // WeekLbl
            // 
            this.WeekLbl.AutoSize = true;
            this.WeekLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeekLbl.Location = new System.Drawing.Point(72, 110);
            this.WeekLbl.Name = "WeekLbl";
            this.WeekLbl.Size = new System.Drawing.Size(49, 20);
            this.WeekLbl.TabIndex = 1;
            this.WeekLbl.Text = "曜日";
            // 
            // StoreLbl
            // 
            this.StoreLbl.AutoSize = true;
            this.StoreLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl.Location = new System.Drawing.Point(72, 166);
            this.StoreLbl.Name = "StoreLbl";
            this.StoreLbl.Size = new System.Drawing.Size(49, 20);
            this.StoreLbl.TabIndex = 2;
            this.StoreLbl.Text = "店名";
            // 
            // MenuLbl
            // 
            this.MenuLbl.AutoSize = true;
            this.MenuLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuLbl.Location = new System.Drawing.Point(72, 228);
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
            this.WeekCbx.Location = new System.Drawing.Point(173, 110);
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
            this.StoreCbx.Location = new System.Drawing.Point(173, 163);
            this.StoreCbx.Name = "StoreCbx";
            this.StoreCbx.Size = new System.Drawing.Size(121, 23);
            this.StoreCbx.TabIndex = 5;
            // 
            // MenuTbx
            // 
            this.MenuTbx.Location = new System.Drawing.Point(173, 229);
            this.MenuTbx.Name = "MenuTbx";
            this.MenuTbx.Size = new System.Drawing.Size(121, 22);
            this.MenuTbx.TabIndex = 6;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchBtn.Location = new System.Drawing.Point(220, 274);
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
            this.FavoriteBtn.Location = new System.Drawing.Point(37, 383);
            this.FavoriteBtn.Name = "FavoriteBtn";
            this.FavoriteBtn.Size = new System.Drawing.Size(345, 55);
            this.FavoriteBtn.TabIndex = 10;
            this.FavoriteBtn.Text = "お気に入り・ランキング";
            this.FavoriteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoriteBtn.UseVisualStyleBackColor = true;
            this.FavoriteBtn.Click += new System.EventHandler(this.FavoriteBtn_Click);
            // 
            // StoreLbl1
            // 
            this.StoreLbl1.AutoSize = true;
            this.StoreLbl1.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl1.Location = new System.Drawing.Point(531, 181);
            this.StoreLbl1.Name = "StoreLbl1";
            this.StoreLbl1.Size = new System.Drawing.Size(75, 30);
            this.StoreLbl1.TabIndex = 11;
            this.StoreLbl1.Text = "店名";
            this.StoreLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreLbl2
            // 
            this.StoreLbl2.AutoSize = true;
            this.StoreLbl2.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl2.Location = new System.Drawing.Point(942, 181);
            this.StoreLbl2.Name = "StoreLbl2";
            this.StoreLbl2.Size = new System.Drawing.Size(75, 30);
            this.StoreLbl2.TabIndex = 12;
            this.StoreLbl2.Text = "店名";
            this.StoreLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreLbl3
            // 
            this.StoreLbl3.AutoSize = true;
            this.StoreLbl3.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl3.Location = new System.Drawing.Point(1342, 181);
            this.StoreLbl3.Name = "StoreLbl3";
            this.StoreLbl3.Size = new System.Drawing.Size(75, 30);
            this.StoreLbl3.TabIndex = 13;
            this.StoreLbl3.Text = "店名";
            this.StoreLbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StorePicture1
            // 
            this.StorePicture1.Image = global::teamH.Properties.Resources.store5;
            this.StorePicture1.Location = new System.Drawing.Point(423, 228);
            this.StorePicture1.Name = "StorePicture1";
            this.StorePicture1.Size = new System.Drawing.Size(331, 208);
            this.StorePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorePicture1.TabIndex = 15;
            this.StorePicture1.TabStop = false;
            // 
            // StorePicture2
            // 
            this.StorePicture2.Image = global::teamH.Properties.Resources.store2;
            this.StorePicture2.Location = new System.Drawing.Point(828, 230);
            this.StorePicture2.Name = "StorePicture2";
            this.StorePicture2.Size = new System.Drawing.Size(322, 208);
            this.StorePicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorePicture2.TabIndex = 16;
            this.StorePicture2.TabStop = false;
            // 
            // StorePicture3
            // 
            this.StorePicture3.Image = global::teamH.Properties.Resources.store4;
            this.StorePicture3.Location = new System.Drawing.Point(1224, 230);
            this.StorePicture3.Name = "StorePicture3";
            this.StorePicture3.Size = new System.Drawing.Size(322, 208);
            this.StorePicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorePicture3.TabIndex = 17;
            this.StorePicture3.TabStop = false;
            // 
            // MenuDgv1
            // 
            this.MenuDgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDgv1.Location = new System.Drawing.Point(423, 469);
            this.MenuDgv1.Name = "MenuDgv1";
            this.MenuDgv1.RowHeadersWidth = 51;
            this.MenuDgv1.RowTemplate.Height = 24;
            this.MenuDgv1.Size = new System.Drawing.Size(331, 274);
            this.MenuDgv1.TabIndex = 18;
            // 
            // MenuDgv2
            // 
            this.MenuDgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDgv2.Location = new System.Drawing.Point(828, 469);
            this.MenuDgv2.Name = "MenuDgv2";
            this.MenuDgv2.RowHeadersWidth = 51;
            this.MenuDgv2.RowTemplate.Height = 24;
            this.MenuDgv2.Size = new System.Drawing.Size(322, 274);
            this.MenuDgv2.TabIndex = 19;
            // 
            // MenuDgv3
            // 
            this.MenuDgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDgv3.Location = new System.Drawing.Point(1224, 469);
            this.MenuDgv3.Name = "MenuDgv3";
            this.MenuDgv3.RowHeadersWidth = 51;
            this.MenuDgv3.RowTemplate.Height = 24;
            this.MenuDgv3.Size = new System.Drawing.Size(322, 274);
            this.MenuDgv3.TabIndex = 20;
            // 
            // FavoriteCntBtn
            // 
            this.FavoriteCntBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FavoriteCntBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FavoriteCntBtn.Location = new System.Drawing.Point(1376, 776);
            this.FavoriteCntBtn.Name = "FavoriteCntBtn";
            this.FavoriteCntBtn.Size = new System.Drawing.Size(235, 74);
            this.FavoriteCntBtn.TabIndex = 21;
            this.FavoriteCntBtn.Text = "お気に入り追加";
            this.FavoriteCntBtn.UseVisualStyleBackColor = false;
            this.FavoriteCntBtn.Click += new System.EventHandler(this.FavoriteCntBtn_Click);
            // 
            // TodayLbl
            // 
            this.TodayLbl.AutoSize = true;
            this.TodayLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TodayLbl.ForeColor = System.Drawing.Color.LightCoral;
            this.TodayLbl.Location = new System.Drawing.Point(786, 127);
            this.TodayLbl.Name = "TodayLbl";
            this.TodayLbl.Size = new System.Drawing.Size(400, 34);
            this.TodayLbl.TabIndex = 22;
            this.TodayLbl.Text = "＜～本日の出店店舗～＞";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleLbl.Location = new System.Drawing.Point(413, 25);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(181, 40);
            this.TitleLbl.TabIndex = 23;
            this.TitleLbl.Text = "キチナビ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1705, 896);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.TodayLbl);
            this.Controls.Add(this.FavoriteCntBtn);
            this.Controls.Add(this.MenuDgv3);
            this.Controls.Add(this.MenuDgv2);
            this.Controls.Add(this.MenuDgv1);
            this.Controls.Add(this.StorePicture3);
            this.Controls.Add(this.StorePicture2);
            this.Controls.Add(this.StorePicture1);
            this.Controls.Add(this.StoreLbl3);
            this.Controls.Add(this.StoreLbl2);
            this.Controls.Add(this.StoreLbl1);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture3)).EndInit();
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
        private System.Windows.Forms.Label StoreLbl1;
        private System.Windows.Forms.Label StoreLbl2;
        private System.Windows.Forms.Label StoreLbl3;
        private System.Windows.Forms.PictureBox StorePicture1;
        private System.Windows.Forms.PictureBox StorePicture2;
        private System.Windows.Forms.PictureBox StorePicture3;
        private System.Windows.Forms.DataGridView MenuDgv1;
        private System.Windows.Forms.DataGridView MenuDgv2;
        private System.Windows.Forms.DataGridView MenuDgv3;
        private System.Windows.Forms.Button FavoriteCntBtn;
        private System.Windows.Forms.Label TodayLbl;
        private System.Windows.Forms.Label TitleLbl;
    }
}

