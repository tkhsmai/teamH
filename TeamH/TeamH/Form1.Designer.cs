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
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(37, 30);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(75, 23);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            // 
            // WeekLbl
            // 
            this.WeekLbl.AutoSize = true;
            this.WeekLbl.Location = new System.Drawing.Point(37, 91);
            this.WeekLbl.Name = "WeekLbl";
            this.WeekLbl.Size = new System.Drawing.Size(37, 15);
            this.WeekLbl.TabIndex = 1;
            this.WeekLbl.Text = "曜日";
            // 
            // StoreLbl
            // 
            this.StoreLbl.AutoSize = true;
            this.StoreLbl.Location = new System.Drawing.Point(37, 153);
            this.StoreLbl.Name = "StoreLbl";
            this.StoreLbl.Size = new System.Drawing.Size(37, 15);
            this.StoreLbl.TabIndex = 2;
            this.StoreLbl.Text = "店名";
            // 
            // MenuLbl
            // 
            this.MenuLbl.AutoSize = true;
            this.MenuLbl.Location = new System.Drawing.Point(37, 217);
            this.MenuLbl.Name = "MenuLbl";
            this.MenuLbl.Size = new System.Drawing.Size(50, 15);
            this.MenuLbl.TabIndex = 3;
            this.MenuLbl.Text = "メニュー";
            // 
            // WeekCbx
            // 
            this.WeekCbx.FormattingEnabled = true;
            this.WeekCbx.Location = new System.Drawing.Point(123, 83);
            this.WeekCbx.Name = "WeekCbx";
            this.WeekCbx.Size = new System.Drawing.Size(121, 23);
            this.WeekCbx.TabIndex = 4;
            // 
            // StoreCbx
            // 
            this.StoreCbx.FormattingEnabled = true;
            this.StoreCbx.Location = new System.Drawing.Point(123, 145);
            this.StoreCbx.Name = "StoreCbx";
            this.StoreCbx.Size = new System.Drawing.Size(121, 23);
            this.StoreCbx.TabIndex = 5;
            // 
            // MenuTbx
            // 
            this.MenuTbx.Location = new System.Drawing.Point(123, 210);
            this.MenuTbx.Name = "MenuTbx";
            this.MenuTbx.Size = new System.Drawing.Size(100, 22);
            this.MenuTbx.TabIndex = 6;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(186, 273);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "検索";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // FavoriteBtn
            // 
            this.FavoriteBtn.Location = new System.Drawing.Point(37, 343);
            this.FavoriteBtn.Name = "FavoriteBtn";
            this.FavoriteBtn.Size = new System.Drawing.Size(232, 23);
            this.FavoriteBtn.TabIndex = 10;
            this.FavoriteBtn.Text = "お気に入り・ランキング";
            this.FavoriteBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

