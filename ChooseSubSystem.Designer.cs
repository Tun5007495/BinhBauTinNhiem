namespace BinhBauTinNhiem
{
    partial class ChooseSubSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminSubSys = new System.Windows.Forms.Button();
            this.NguoiDiBauSS = new System.Windows.Forms.Button();
            this.BanToChucBinhBauSS = new System.Windows.Forms.Button();
            this.TruongBanToChucBinhBauSS = new System.Windows.Forms.Button();
            this.ToGiamSatSS = new System.Windows.Forms.Button();
            this.ToLapDSNDB_SS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn phân hệ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AdminSubSys
            // 
            this.AdminSubSys.Location = new System.Drawing.Point(31, 116);
            this.AdminSubSys.Name = "AdminSubSys";
            this.AdminSubSys.Size = new System.Drawing.Size(71, 49);
            this.AdminSubSys.TabIndex = 3;
            this.AdminSubSys.Text = "Admin";
            this.AdminSubSys.UseVisualStyleBackColor = true;
            this.AdminSubSys.Click += new System.EventHandler(this.AdminSubSys_Click);
            // 
            // NguoiDiBauSS
            // 
            this.NguoiDiBauSS.Location = new System.Drawing.Point(108, 116);
            this.NguoiDiBauSS.Name = "NguoiDiBauSS";
            this.NguoiDiBauSS.Size = new System.Drawing.Size(90, 49);
            this.NguoiDiBauSS.TabIndex = 3;
            this.NguoiDiBauSS.Text = "Người đi bầu";
            this.NguoiDiBauSS.UseVisualStyleBackColor = true;
            this.NguoiDiBauSS.Click += new System.EventHandler(this.NguoiDiBauSS_Click);
            // 
            // BanToChucBinhBauSS
            // 
            this.BanToChucBinhBauSS.Location = new System.Drawing.Point(204, 116);
            this.BanToChucBinhBauSS.Name = "BanToChucBinhBauSS";
            this.BanToChucBinhBauSS.Size = new System.Drawing.Size(126, 49);
            this.BanToChucBinhBauSS.TabIndex = 3;
            this.BanToChucBinhBauSS.Text = "Ban tổ chức bình bầu";
            this.BanToChucBinhBauSS.UseVisualStyleBackColor = true;
            // 
            // TruongBanToChucBinhBauSS
            // 
            this.TruongBanToChucBinhBauSS.Location = new System.Drawing.Point(336, 116);
            this.TruongBanToChucBinhBauSS.Name = "TruongBanToChucBinhBauSS";
            this.TruongBanToChucBinhBauSS.Size = new System.Drawing.Size(125, 49);
            this.TruongBanToChucBinhBauSS.TabIndex = 3;
            this.TruongBanToChucBinhBauSS.Text = "Trưởng ban tổ chức bình bầu";
            this.TruongBanToChucBinhBauSS.UseVisualStyleBackColor = true;
            this.TruongBanToChucBinhBauSS.Click += new System.EventHandler(this.TruongBanToChucBinhBauSS_Click);
            // 
            // ToGiamSatSS
            // 
            this.ToGiamSatSS.Location = new System.Drawing.Point(467, 116);
            this.ToGiamSatSS.Name = "ToGiamSatSS";
            this.ToGiamSatSS.Size = new System.Drawing.Size(112, 49);
            this.ToGiamSatSS.TabIndex = 3;
            this.ToGiamSatSS.Text = "Tổ giám sát";
            this.ToGiamSatSS.UseVisualStyleBackColor = true;
            // 
            // ToLapDSNDB_SS
            // 
            this.ToLapDSNDB_SS.Location = new System.Drawing.Point(585, 116);
            this.ToLapDSNDB_SS.Name = "ToLapDSNDB_SS";
            this.ToLapDSNDB_SS.Size = new System.Drawing.Size(112, 49);
            this.ToLapDSNDB_SS.TabIndex = 3;
            this.ToLapDSNDB_SS.Text = "Tổ lập danh sách người đi bầu";
            this.ToLapDSNDB_SS.UseVisualStyleBackColor = true;
            this.ToLapDSNDB_SS.Click += new System.EventHandler(this.ToLapDSNDB_SS_Click);
            // 
            // ChooseSubSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 187);
            this.Controls.Add(this.ToLapDSNDB_SS);
            this.Controls.Add(this.ToGiamSatSS);
            this.Controls.Add(this.TruongBanToChucBinhBauSS);
            this.Controls.Add(this.BanToChucBinhBauSS);
            this.Controls.Add(this.NguoiDiBauSS);
            this.Controls.Add(this.AdminSubSys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChooseSubSystem";
            this.Text = "Chọn phân hệ";
            this.Load += new System.EventHandler(this.ChooseSubSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdminSubSys;
        private System.Windows.Forms.Button NguoiDiBauSS;
        private System.Windows.Forms.Button BanToChucBinhBauSS;
        private System.Windows.Forms.Button TruongBanToChucBinhBauSS;
        private System.Windows.Forms.Button ToGiamSatSS;
        private System.Windows.Forms.Button ToLapDSNDB_SS;
    }
}