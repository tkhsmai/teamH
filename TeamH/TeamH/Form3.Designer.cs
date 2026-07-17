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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BHomeBtn2 = new System.Windows.Forms.Button();
            this.PassTbx = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.PassBtn = new System.Windows.Forms.Button();
            this.ManagerPanel = new System.Windows.Forms.Panel();
            this.AddGbx = new System.Windows.Forms.GroupBox();
            this.MenuAddTbx = new System.Windows.Forms.TextBox();
            this.MenuLbl2 = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.PriceAddTbx = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchBtn2 = new System.Windows.Forms.Button();
            this.StoreCbx2 = new System.Windows.Forms.ComboBox();
            this.StoreLbl2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.DeleteAddDgv = new System.Windows.Forms.DataGridView();
            this.ManagerPanel.SuspendLayout();
            this.AddGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAddDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BHomeBtn2
            // 
            this.BHomeBtn2.BackColor = System.Drawing.Color.OldLace;
            this.BHomeBtn2.Font = new System.Drawing.Font("ＭＳ ゴシック", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BHomeBtn2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BHomeBtn2.Location = new System.Drawing.Point(60, 59);
            this.BHomeBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.BHomeBtn2.Name = "BHomeBtn2";
            this.BHomeBtn2.Size = new System.Drawing.Size(174, 73);
            this.BHomeBtn2.TabIndex = 0;
            this.BHomeBtn2.Text = "Home";
            this.BHomeBtn2.UseVisualStyleBackColor = false;
            this.BHomeBtn2.Click += new System.EventHandler(this.BHomeBtn2_Click);
            // 
            // PassTbx
            // 
            this.PassTbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassTbx.Location = new System.Drawing.Point(336, 115);
            this.PassTbx.Name = "PassTbx";
            this.PassTbx.Size = new System.Drawing.Size(280, 34);
            this.PassTbx.TabIndex = 9;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PassLbl.Location = new System.Drawing.Point(331, 59);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(432, 28);
            this.PassLbl.TabIndex = 10;
            this.PassLbl.Text = "※パスワードを入力してください";
            // 
            // PassBtn
            // 
            this.PassBtn.BackColor = System.Drawing.Color.OldLace;
            this.PassBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PassBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PassBtn.Location = new System.Drawing.Point(660, 107);
            this.PassBtn.Name = "PassBtn";
            this.PassBtn.Size = new System.Drawing.Size(85, 42);
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
            this.ManagerPanel.Location = new System.Drawing.Point(60, 206);
            this.ManagerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ManagerPanel.Name = "ManagerPanel";
            this.ManagerPanel.Size = new System.Drawing.Size(1481, 668);
            this.ManagerPanel.TabIndex = 18;
            // 
            // AddGbx
            // 
            this.AddGbx.Controls.Add(this.MenuAddTbx);
            this.AddGbx.Controls.Add(this.MenuLbl2);
            this.AddGbx.Controls.Add(this.PriceLbl);
            this.AddGbx.Controls.Add(this.PriceAddTbx);
            this.AddGbx.Controls.Add(this.AddBtn);
            this.AddGbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddGbx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AddGbx.Location = new System.Drawing.Point(84, 242);
            this.AddGbx.Name = "AddGbx";
            this.AddGbx.Size = new System.Drawing.Size(601, 251);
            this.AddGbx.TabIndex = 19;
            this.AddGbx.TabStop = false;
            this.AddGbx.Text = "メニュー追加";
            // 
            // MenuAddTbx
            // 
            this.MenuAddTbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuAddTbx.Location = new System.Drawing.Point(211, 70);
            this.MenuAddTbx.Name = "MenuAddTbx";
            this.MenuAddTbx.Size = new System.Drawing.Size(231, 34);
            this.MenuAddTbx.TabIndex = 18;
            // 
            // MenuLbl2
            // 
            this.MenuLbl2.AutoSize = true;
            this.MenuLbl2.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MenuLbl2.Location = new System.Drawing.Point(25, 70);
            this.MenuLbl2.Name = "MenuLbl2";
            this.MenuLbl2.Size = new System.Drawing.Size(163, 30);
            this.MenuLbl2.TabIndex = 17;
            this.MenuLbl2.Text = "メニュー名";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PriceLbl.Location = new System.Drawing.Point(25, 141);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(73, 30);
            this.PriceLbl.TabIndex = 16;
            this.PriceLbl.Text = "価格";
            // 
            // PriceAddTbx
            // 
            this.PriceAddTbx.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PriceAddTbx.Location = new System.Drawing.Point(211, 141);
            this.PriceAddTbx.Name = "PriceAddTbx";
            this.PriceAddTbx.Size = new System.Drawing.Size(137, 34);
            this.PriceAddTbx.TabIndex = 14;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.OldLace;
            this.AddBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddBtn.Location = new System.Drawing.Point(446, 165);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(97, 55);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "追加";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchBtn2
            // 
            this.SearchBtn2.BackColor = System.Drawing.Color.OldLace;
            this.SearchBtn2.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchBtn2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SearchBtn2.Location = new System.Drawing.Point(458, 104);
            this.SearchBtn2.Name = "SearchBtn2";
            this.SearchBtn2.Size = new System.Drawing.Size(98, 54);
            this.SearchBtn2.TabIndex = 19;
            this.SearchBtn2.Text = "検索";
            this.SearchBtn2.UseVisualStyleBackColor = false;
            this.SearchBtn2.Click += new System.EventHandler(this.SearchBtn2_Click);
            // 
            // StoreCbx2
            // 
            this.StoreCbx2.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreCbx2.FormattingEnabled = true;
            this.StoreCbx2.Items.AddRange(new object[] {
            "スマイルバーガー号",
            "からあげ太郎",
            "スパイス工房",
            "クレープスマイル",
            "たこ丸キッチン",
            "ソウルキッチン号"});
            this.StoreCbx2.Location = new System.Drawing.Point(217, 25);
            this.StoreCbx2.Name = "StoreCbx2";
            this.StoreCbx2.Size = new System.Drawing.Size(339, 35);
            this.StoreCbx2.TabIndex = 19;
            // 
            // StoreLbl2
            // 
            this.StoreLbl2.AutoSize = true;
            this.StoreLbl2.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StoreLbl2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.StoreLbl2.Location = new System.Drawing.Point(79, 30);
            this.StoreLbl2.Name = "StoreLbl2";
            this.StoreLbl2.Size = new System.Drawing.Size(73, 30);
            this.StoreLbl2.TabIndex = 19;
            this.StoreLbl2.Text = "店名";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.OldLace;
            this.DeleteBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DeleteBtn.Location = new System.Drawing.Point(1068, 558);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(100, 61);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "削除";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DeleteAddDgv
            // 
            this.DeleteAddDgv.AllowUserToAddRows = false;
            this.DeleteAddDgv.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteAddDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DeleteAddDgv.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteAddDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteAddDgv.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DeleteAddDgv.Location = new System.Drawing.Point(769, 0);
            this.DeleteAddDgv.Name = "DeleteAddDgv";
            this.DeleteAddDgv.RowHeadersVisible = false;
            this.DeleteAddDgv.RowHeadersWidth = 51;
            this.DeleteAddDgv.RowTemplate.Height = 30;
            this.DeleteAddDgv.Size = new System.Drawing.Size(698, 462);
            this.DeleteAddDgv.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1539, 875);
            this.Controls.Add(this.PassBtn);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.PassTbx);
            this.Controls.Add(this.BHomeBtn2);
            this.Controls.Add(this.ManagerPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ManagerPanel.ResumeLayout(false);
            this.ManagerPanel.PerformLayout();
            this.AddGbx.ResumeLayout(false);
            this.AddGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAddDgv)).EndInit();
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