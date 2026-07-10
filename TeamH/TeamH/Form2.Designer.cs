namespace teamH
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.BHomeBtn = new System.Windows.Forms.Button();
            this.RkMenuDgv = new System.Windows.Forms.DataGridView();
            this.FavoriteLbl = new System.Windows.Forms.Label();
            this.RankingLbl = new System.Windows.Forms.Label();
            this.FvMenuDgv = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RkMenuDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FvMenuDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BHomeBtn
            // 
            this.BHomeBtn.BackColor = System.Drawing.Color.OldLace;
            this.BHomeBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BHomeBtn.Location = new System.Drawing.Point(37, 71);
            this.BHomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BHomeBtn.Name = "BHomeBtn";
            this.BHomeBtn.Size = new System.Drawing.Size(124, 54);
            this.BHomeBtn.TabIndex = 0;
            this.BHomeBtn.Text = "Home";
            this.BHomeBtn.UseVisualStyleBackColor = false;
            this.BHomeBtn.Click += new System.EventHandler(this.BHomeBtn_Click);
            // 
            // RkMenuDgv
            // 
            this.RkMenuDgv.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.RkMenuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RkMenuDgv.Location = new System.Drawing.Point(925, 366);
            this.RkMenuDgv.Margin = new System.Windows.Forms.Padding(2);
            this.RkMenuDgv.Name = "RkMenuDgv";
            this.RkMenuDgv.RowHeadersWidth = 62;
            this.RkMenuDgv.RowTemplate.Height = 27;
            this.RkMenuDgv.Size = new System.Drawing.Size(454, 445);
            this.RkMenuDgv.TabIndex = 2;
            this.RkMenuDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RkMenuDgv_CellContentClick);
            // 
            // FavoriteLbl
            // 
            this.FavoriteLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FavoriteLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FavoriteLbl.Location = new System.Drawing.Point(453, 310);
            this.FavoriteLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FavoriteLbl.MaximumSize = new System.Drawing.Size(500, 500);
            this.FavoriteLbl.Name = "FavoriteLbl";
            this.FavoriteLbl.Size = new System.Drawing.Size(500, 49);
            this.FavoriteLbl.TabIndex = 3;
            this.FavoriteLbl.Text = "お気に入りメニュー";
            // 
            // RankingLbl
            // 
            this.RankingLbl.AutoSize = true;
            this.RankingLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RankingLbl.Location = new System.Drawing.Point(1007, 310);
            this.RankingLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RankingLbl.MaximumSize = new System.Drawing.Size(400, 417);
            this.RankingLbl.Name = "RankingLbl";
            this.RankingLbl.Size = new System.Drawing.Size(260, 34);
            this.RankingLbl.TabIndex = 4;
            this.RankingLbl.Text = "人気ランキング";
            // 
            // FvMenuDgv
            // 
            this.FvMenuDgv.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.FvMenuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FvMenuDgv.GridColor = System.Drawing.Color.FloralWhite;
            this.FvMenuDgv.Location = new System.Drawing.Point(322, 366);
            this.FvMenuDgv.Name = "FvMenuDgv";
            this.FvMenuDgv.RowHeadersWidth = 51;
            this.FvMenuDgv.RowTemplate.Height = 24;
            this.FvMenuDgv.Size = new System.Drawing.Size(598, 442);
            this.FvMenuDgv.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::teamH.Properties.Resources.kichinavi_logo_textonly;
            this.pictureBox1.Location = new System.Drawing.Point(555, -117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1924, 904);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FvMenuDgv);
            this.Controls.Add(this.BHomeBtn);
            this.Controls.Add(this.RkMenuDgv);
            this.Controls.Add(this.FavoriteLbl);
            this.Controls.Add(this.RankingLbl);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.RkMenuDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FvMenuDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BHomeBtn;
        private System.Windows.Forms.DataGridView RkMenuDgv;
        private System.Windows.Forms.Label FavoriteLbl;
        private System.Windows.Forms.Label RankingLbl;
        private System.Windows.Forms.DataGridView FvMenuDgv;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}