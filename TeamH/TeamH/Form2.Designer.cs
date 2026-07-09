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
            this.FvMenuDgv = new System.Windows.Forms.DataGridView();
            this.RkMenuDgv = new System.Windows.Forms.DataGridView();
            this.FavoriteLbl = new System.Windows.Forms.Label();
            this.RankingLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FvMenuDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RkMenuDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BHomeBtn
            // 
            this.BHomeBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BHomeBtn.Location = new System.Drawing.Point(37, 71);
            this.BHomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BHomeBtn.Name = "BHomeBtn";
            this.BHomeBtn.Size = new System.Drawing.Size(150, 49);
            this.BHomeBtn.TabIndex = 0;
            this.BHomeBtn.Text = "Home";
            this.BHomeBtn.UseVisualStyleBackColor = true;
            this.BHomeBtn.Click += new System.EventHandler(this.BHomeBtn_Click);
            // 
            // FvMenuDgv
            // 
            this.FvMenuDgv.BackgroundColor = System.Drawing.Color.OldLace;
            this.FvMenuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FvMenuDgv.Location = new System.Drawing.Point(2, 2);
            this.FvMenuDgv.Margin = new System.Windows.Forms.Padding(2);
            this.FvMenuDgv.Name = "FvMenuDgv";
            this.FvMenuDgv.RowHeadersWidth = 62;
            this.FvMenuDgv.RowTemplate.Height = 27;
            this.FvMenuDgv.Size = new System.Drawing.Size(697, 445);
            this.FvMenuDgv.TabIndex = 1;
            // 
            // RkMenuDgv
            // 
            this.RkMenuDgv.BackgroundColor = System.Drawing.Color.OldLace;
            this.RkMenuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RkMenuDgv.Location = new System.Drawing.Point(963, 218);
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
            this.FavoriteLbl.Location = new System.Drawing.Point(405, 147);
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
            this.RankingLbl.Location = new System.Drawing.Point(1044, 162);
            this.RankingLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RankingLbl.MaximumSize = new System.Drawing.Size(400, 417);
            this.RankingLbl.Name = "RankingLbl";
            this.RankingLbl.Size = new System.Drawing.Size(260, 34);
            this.RankingLbl.TabIndex = 4;
            this.RankingLbl.Text = "人気ランキング";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FvMenuDgv);
            this.panel1.Location = new System.Drawing.Point(259, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 634);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(193, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "選択削除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1648, 904);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BHomeBtn);
            this.Controls.Add(this.RkMenuDgv);
            this.Controls.Add(this.FavoriteLbl);
            this.Controls.Add(this.RankingLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.FvMenuDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RkMenuDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BHomeBtn;
        private System.Windows.Forms.DataGridView FvMenuDgv;
        private System.Windows.Forms.DataGridView RkMenuDgv;
        private System.Windows.Forms.Label FavoriteLbl;
        private System.Windows.Forms.Label RankingLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}