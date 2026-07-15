using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.MenuDgv1 = new System.Windows.Forms.DataGridView();
            this.MenuDgv2 = new System.Windows.Forms.DataGridView();
            this.MenuDgv3 = new System.Windows.Forms.DataGridView();
            this.FavoriteCntBtn = new System.Windows.Forms.Button();
            this.TodayLbl = new System.Windows.Forms.Label();
            this.TitlePicture = new System.Windows.Forms.PictureBox();
            this.StorePicture3 = new System.Windows.Forms.PictureBox();
            this.StorePicture2 = new System.Windows.Forms.PictureBox();
            this.StorePicture1 = new System.Windows.Forms.PictureBox();
            this.HomeLbl = new System.Windows.Forms.Label();
            this.ManagerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // WeekLbl
            // 
            this.WeekLbl.AutoSize = true;
            this.WeekLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeekLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.WeekLbl.Location = new System.Drawing.Point(71, 230);
            this.WeekLbl.Name = "WeekLbl";
            this.WeekLbl.Size = new System.Drawing.Size(64, 25);
            this.WeekLbl.TabIndex = 1;
            this.WeekLbl.Text = "曜日";
            // 
            // StoreLbl
            // 
            this.StoreLbl.AutoSize = true;
            this.StoreLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.StoreLbl.Location = new System.Drawing.Point(71, 291);
            this.StoreLbl.Name = "StoreLbl";
            this.StoreLbl.Size = new System.Drawing.Size(64, 25);
            this.StoreLbl.TabIndex = 2;
            this.StoreLbl.Text = "店名";
            // 
            // MenuLbl
            // 
            this.MenuLbl.AutoSize = true;
            this.MenuLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MenuLbl.Location = new System.Drawing.Point(71, 352);
            this.MenuLbl.Name = "MenuLbl";
            this.MenuLbl.Size = new System.Drawing.Size(116, 25);
            this.MenuLbl.TabIndex = 3;
            this.MenuLbl.Text = "メニュー";
            // 
            // WeekCbx
            // 
            this.WeekCbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeekCbx.FormattingEnabled = true;
            this.WeekCbx.Items.AddRange(new object[] {
            "月",
            "火",
            "水",
            "木",
            "金"});
            this.WeekCbx.Location = new System.Drawing.Point(215, 230);
            this.WeekCbx.Name = "WeekCbx";
            this.WeekCbx.Size = new System.Drawing.Size(103, 28);
            this.WeekCbx.TabIndex = 4;
            // 
            // StoreCbx
            // 
            this.StoreCbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreCbx.FormattingEnabled = true;
            this.StoreCbx.Items.AddRange(new object[] {
            "スマイルバーガー号",
            "からあげ太郎",
            "スパイス工房",
            "クレープスマイル",
            "たこ丸キッチン",
            "ソウルキッチン号"});
            this.StoreCbx.Location = new System.Drawing.Point(215, 288);
            this.StoreCbx.Name = "StoreCbx";
            this.StoreCbx.Size = new System.Drawing.Size(203, 28);
            this.StoreCbx.TabIndex = 5;
            // 
            // MenuTbx
            // 
            this.MenuTbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuTbx.Location = new System.Drawing.Point(215, 353);
            this.MenuTbx.Name = "MenuTbx";
            this.MenuTbx.Size = new System.Drawing.Size(203, 27);
            this.MenuTbx.TabIndex = 6;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.OldLace;
            this.SearchBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SearchBtn.Location = new System.Drawing.Point(309, 410);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(109, 47);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "検索";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // FavoriteBtn
            // 
            this.FavoriteBtn.BackColor = System.Drawing.Color.OldLace;
            this.FavoriteBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FavoriteBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FavoriteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoriteBtn.Location = new System.Drawing.Point(37, 534);
            this.FavoriteBtn.Name = "FavoriteBtn";
            this.FavoriteBtn.Size = new System.Drawing.Size(345, 55);
            this.FavoriteBtn.TabIndex = 10;
            this.FavoriteBtn.Text = "お気に入り・ランキング";
            this.FavoriteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavoriteBtn.UseVisualStyleBackColor = false;
            this.FavoriteBtn.Click += new System.EventHandler(this.FavoriteBtn_Click);
            // 
            // StoreLbl1
            // 
            this.StoreLbl1.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.StoreLbl1.Location = new System.Drawing.Point(536, 318);
            this.StoreLbl1.Name = "StoreLbl1";
            this.StoreLbl1.Size = new System.Drawing.Size(370, 30);
            this.StoreLbl1.TabIndex = 11;
            this.StoreLbl1.Text = "店名";
            this.StoreLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreLbl2
            // 
            this.StoreLbl2.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.StoreLbl2.Location = new System.Drawing.Point(988, 315);
            this.StoreLbl2.Name = "StoreLbl2";
            this.StoreLbl2.Size = new System.Drawing.Size(370, 33);
            this.StoreLbl2.TabIndex = 12;
            this.StoreLbl2.Text = "店名";
            this.StoreLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreLbl3
            // 
            this.StoreLbl3.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.StoreLbl3.Location = new System.Drawing.Point(1440, 315);
            this.StoreLbl3.Name = "StoreLbl3";
            this.StoreLbl3.Size = new System.Drawing.Size(363, 33);
            this.StoreLbl3.TabIndex = 13;
            this.StoreLbl3.Text = "店名";
            this.StoreLbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuDgv1
            // 
            this.MenuDgv1.AllowUserToAddRows = false;
            this.MenuDgv1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.MenuDgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuDgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MenuDgv1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MenuDgv1.DefaultCellStyle = dataGridViewCellStyle8;
            this.MenuDgv1.Location = new System.Drawing.Point(533, 614);
            this.MenuDgv1.Name = "MenuDgv1";
            this.MenuDgv1.RowHeadersVisible = false;
            this.MenuDgv1.RowHeadersWidth = 51;
            this.MenuDgv1.RowTemplate.Height = 24;
            this.MenuDgv1.Size = new System.Drawing.Size(373, 243);
            this.MenuDgv1.TabIndex = 18;
            // 
            // MenuDgv2
            // 
            this.MenuDgv2.AllowUserToAddRows = false;
            this.MenuDgv2.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.MenuDgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuDgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.MenuDgv2.ColumnHeadersHeight = 25;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MenuDgv2.DefaultCellStyle = dataGridViewCellStyle10;
            this.MenuDgv2.Location = new System.Drawing.Point(993, 614);
            this.MenuDgv2.Name = "MenuDgv2";
            this.MenuDgv2.RowHeadersVisible = false;
            this.MenuDgv2.RowHeadersWidth = 51;
            this.MenuDgv2.RowTemplate.Height = 24;
            this.MenuDgv2.Size = new System.Drawing.Size(365, 243);
            this.MenuDgv2.TabIndex = 19;
            // 
            // MenuDgv3
            // 
            this.MenuDgv3.AllowUserToAddRows = false;
            this.MenuDgv3.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.MenuDgv3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuDgv3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.MenuDgv3.ColumnHeadersHeight = 25;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MenuDgv3.DefaultCellStyle = dataGridViewCellStyle12;
            this.MenuDgv3.Location = new System.Drawing.Point(1445, 614);
            this.MenuDgv3.Name = "MenuDgv3";
            this.MenuDgv3.RowHeadersVisible = false;
            this.MenuDgv3.RowHeadersWidth = 51;
            this.MenuDgv3.RowTemplate.Height = 24;
            this.MenuDgv3.Size = new System.Drawing.Size(358, 243);
            this.MenuDgv3.TabIndex = 20;
            // 
            // FavoriteCntBtn
            // 
            this.FavoriteCntBtn.BackColor = System.Drawing.Color.OldLace;
            this.FavoriteCntBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FavoriteCntBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FavoriteCntBtn.Location = new System.Drawing.Point(1572, 894);
            this.FavoriteCntBtn.Name = "FavoriteCntBtn";
            this.FavoriteCntBtn.Size = new System.Drawing.Size(259, 62);
            this.FavoriteCntBtn.TabIndex = 21;
            this.FavoriteCntBtn.Text = "☆お気に入り追加";
            this.FavoriteCntBtn.UseVisualStyleBackColor = false;
            this.FavoriteCntBtn.Click += new System.EventHandler(this.FavoriteCntBtn_Click);
            // 
            // TodayLbl
            // 
            this.TodayLbl.AutoSize = true;
            this.TodayLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TodayLbl.ForeColor = System.Drawing.Color.LightCoral;
            this.TodayLbl.Location = new System.Drawing.Point(955, 242);
            this.TodayLbl.Name = "TodayLbl";
            this.TodayLbl.Size = new System.Drawing.Size(422, 35);
            this.TodayLbl.TabIndex = 22;
            this.TodayLbl.Text = "＜～本日の出店店舗～＞";
            // 
            // TitlePicture
            // 
            this.TitlePicture.BackColor = System.Drawing.Color.Transparent;
            this.TitlePicture.Image = global::teamH.Properties.Resources.kichinavi_logo_textonly;
            this.TitlePicture.Location = new System.Drawing.Point(755, -114);
            this.TitlePicture.Name = "TitlePicture";
            this.TitlePicture.Size = new System.Drawing.Size(804, 424);
            this.TitlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlePicture.TabIndex = 23;
            this.TitlePicture.TabStop = false;
            // 
            // StorePicture3
            // 
            this.StorePicture3.Image = global::teamH.Properties.Resources.store4;
            this.StorePicture3.Location = new System.Drawing.Point(1445, 365);
            this.StorePicture3.Name = "StorePicture3";
            this.StorePicture3.Size = new System.Drawing.Size(358, 224);
            this.StorePicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorePicture3.TabIndex = 17;
            this.StorePicture3.TabStop = false;
            // 
            // StorePicture2
            // 
            this.StorePicture2.Image = global::teamH.Properties.Resources.store2;
            this.StorePicture2.Location = new System.Drawing.Point(993, 365);
            this.StorePicture2.Name = "StorePicture2";
            this.StorePicture2.Size = new System.Drawing.Size(365, 224);
            this.StorePicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorePicture2.TabIndex = 16;
            this.StorePicture2.TabStop = false;
            // 
            // StorePicture1
            // 
            this.StorePicture1.Image = global::teamH.Properties.Resources.store5;
            this.StorePicture1.Location = new System.Drawing.Point(536, 367);
            this.StorePicture1.Name = "StorePicture1";
            this.StorePicture1.Size = new System.Drawing.Size(370, 222);
            this.StorePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorePicture1.TabIndex = 15;
            this.StorePicture1.TabStop = false;
            // 
            // HomeLbl
            // 
            this.HomeLbl.AutoSize = true;
            this.HomeLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HomeLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.HomeLbl.Location = new System.Drawing.Point(48, 70);
            this.HomeLbl.Name = "HomeLbl";
            this.HomeLbl.Size = new System.Drawing.Size(101, 40);
            this.HomeLbl.TabIndex = 24;
            this.HomeLbl.Text = "Home";
            // 
            // ManagerBtn
            // 
            this.ManagerBtn.BackColor = System.Drawing.Color.OldLace;
            this.ManagerBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ManagerBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ManagerBtn.Location = new System.Drawing.Point(37, 745);
            this.ManagerBtn.Name = "ManagerBtn";
            this.ManagerBtn.Size = new System.Drawing.Size(150, 55);
            this.ManagerBtn.TabIndex = 25;
            this.ManagerBtn.Text = "管理者";
            this.ManagerBtn.UseVisualStyleBackColor = false;
            this.ManagerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1803, 1031);
            this.Controls.Add(this.ManagerBtn);
            this.Controls.Add(this.HomeLbl);
            this.Controls.Add(this.TitlePicture);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDgv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorePicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox TitlePicture;
        private System.Windows.Forms.Label HomeLbl;
        private Button ManagerBtn;
    }
}

