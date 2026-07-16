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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.BHomeBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BHomeBtn.Location = new System.Drawing.Point(60, 60);
            this.BHomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BHomeBtn.Name = "BHomeBtn";
            this.BHomeBtn.Size = new System.Drawing.Size(174, 73);
            this.BHomeBtn.TabIndex = 0;
            this.BHomeBtn.Text = "Home";
            this.BHomeBtn.UseVisualStyleBackColor = false;
            this.BHomeBtn.Click += new System.EventHandler(this.BHomeBtn_Click);
            // 
            // RkMenuDgv
            // 
            this.RkMenuDgv.AllowUserToAddRows = false;
            this.RkMenuDgv.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.RkMenuDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RkMenuDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RkMenuDgv.ColumnHeadersHeight = 50;
            this.RkMenuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RkMenuDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.RkMenuDgv.Location = new System.Drawing.Point(928, 305);
            this.RkMenuDgv.Margin = new System.Windows.Forms.Padding(2);
            this.RkMenuDgv.Name = "RkMenuDgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RkMenuDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RkMenuDgv.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RkMenuDgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RkMenuDgv.RowTemplate.Height = 27;
            this.RkMenuDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RkMenuDgv.ShowCellToolTips = false;
            this.RkMenuDgv.Size = new System.Drawing.Size(964, 353);
            this.RkMenuDgv.TabIndex = 2;
            // 
            // FavoriteLbl
            // 
            this.FavoriteLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FavoriteLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FavoriteLbl.Location = new System.Drawing.Point(399, 258);
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
            this.RankingLbl.Location = new System.Drawing.Point(1243, 260);
            this.RankingLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RankingLbl.MaximumSize = new System.Drawing.Size(400, 417);
            this.RankingLbl.Name = "RankingLbl";
            this.RankingLbl.Size = new System.Drawing.Size(260, 34);
            this.RankingLbl.TabIndex = 4;
            this.RankingLbl.Text = "人気ランキング";
            // 
            // FvMenuDgv
            // 
            this.FvMenuDgv.AllowUserToAddRows = false;
            this.FvMenuDgv.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FvMenuDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.FvMenuDgv.ColumnHeadersHeight = 50;
            this.FvMenuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FvMenuDgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.FvMenuDgv.GridColor = System.Drawing.Color.FloralWhite;
            this.FvMenuDgv.Location = new System.Drawing.Point(146, 305);
            this.FvMenuDgv.Name = "FvMenuDgv";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FvMenuDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.FvMenuDgv.RowHeadersVisible = false;
            this.FvMenuDgv.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FvMenuDgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.FvMenuDgv.RowTemplate.Height = 24;
            this.FvMenuDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FvMenuDgv.Size = new System.Drawing.Size(777, 474);
            this.FvMenuDgv.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(703, -112);
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
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.FvMenuDgv);
            this.Controls.Add(this.BHomeBtn);
            this.Controls.Add(this.RkMenuDgv);
            this.Controls.Add(this.FavoriteLbl);
            this.Controls.Add(this.RankingLbl);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
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