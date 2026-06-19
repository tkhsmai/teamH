namespace teamH
{
    partial class favoriteranking
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
            this.BHomeBtn = new System.Windows.Forms.Button();
            this.FavoriteLbl = new System.Windows.Forms.Label();
            this.FvMenuDgv = new System.Windows.Forms.DataGridView();
            this.RkMenuDgv = new System.Windows.Forms.DataGridView();
            this.RankingLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FvMenuDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RkMenuDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BHomeBtn
            // 
            this.BHomeBtn.Location = new System.Drawing.Point(67, 27);
            this.BHomeBtn.Name = "BHomeBtn";
            this.BHomeBtn.Size = new System.Drawing.Size(151, 45);
            this.BHomeBtn.TabIndex = 0;
            this.BHomeBtn.Text = "HOME";
            this.BHomeBtn.UseVisualStyleBackColor = true;
            this.BHomeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FavoriteLbl
            // 
            this.FavoriteLbl.AutoSize = true;
            this.FavoriteLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FavoriteLbl.Location = new System.Drawing.Point(82, 120);
            this.FavoriteLbl.Name = "FavoriteLbl";
            this.FavoriteLbl.Size = new System.Drawing.Size(138, 20);
            this.FavoriteLbl.TabIndex = 1;
            this.FavoriteLbl.Text = "お気に入りメニュー";
            // 
            // FvMenuDgv
            // 
            this.FvMenuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FvMenuDgv.Location = new System.Drawing.Point(67, 175);
            this.FvMenuDgv.Name = "FvMenuDgv";
            this.FvMenuDgv.RowHeadersWidth = 62;
            this.FvMenuDgv.RowTemplate.Height = 27;
            this.FvMenuDgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FvMenuDgv.Size = new System.Drawing.Size(240, 150);
            this.FvMenuDgv.TabIndex = 2;
            // 
            // RkMenuDgv
            // 
            this.RkMenuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RkMenuDgv.Location = new System.Drawing.Point(487, 175);
            this.RkMenuDgv.Name = "RkMenuDgv";
            this.RkMenuDgv.RowHeadersWidth = 62;
            this.RkMenuDgv.RowTemplate.Height = 27;
            this.RkMenuDgv.Size = new System.Drawing.Size(240, 150);
            this.RkMenuDgv.TabIndex = 3;
            // 
            // RankingLbl
            // 
            this.RankingLbl.AutoSize = true;
            this.RankingLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RankingLbl.Location = new System.Drawing.Point(484, 129);
            this.RankingLbl.Name = "RankingLbl";
            this.RankingLbl.Size = new System.Drawing.Size(113, 20);
            this.RankingLbl.TabIndex = 4;
            this.RankingLbl.Text = "人気ランキング";
            this.RankingLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // favoriteranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RankingLbl);
            this.Controls.Add(this.RkMenuDgv);
            this.Controls.Add(this.FvMenuDgv);
            this.Controls.Add(this.FavoriteLbl);
            this.Controls.Add(this.BHomeBtn);
            this.Name = "favoriteranking";
            this.Text = "favoriteranking";
            ((System.ComponentModel.ISupportInitialize)(this.FvMenuDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RkMenuDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BHomeBtn;
        private System.Windows.Forms.Label FavoriteLbl;
        private System.Windows.Forms.DataGridView FvMenuDgv;
        private System.Windows.Forms.DataGridView RkMenuDgv;
        private System.Windows.Forms.Label RankingLbl;
    }
}