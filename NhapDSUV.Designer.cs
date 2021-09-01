namespace BinhBauTinNhiem
{
    partial class NhapDSUV
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
            this.DSNV_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.unchoosenNV_lb = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.choosenNV_lb = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.choose_btn = new System.Windows.Forms.Button();
            this.unchoose_btn = new System.Windows.Forms.Button();
            this.apply_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSNV_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DSNV_dgv
            // 
            this.DSNV_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DSNV_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSNV_dgv.Location = new System.Drawing.Point(12, 21);
            this.DSNV_dgv.Name = "DSNV_dgv";
            this.DSNV_dgv.Size = new System.Drawing.Size(776, 220);
            this.DSNV_dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // unchoosenNV_lb
            // 
            this.unchoosenNV_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unchoosenNV_lb.FormattingEnabled = true;
            this.unchoosenNV_lb.Location = new System.Drawing.Point(12, 295);
            this.unchoosenNV_lb.Name = "unchoosenNV_lb";
            this.unchoosenNV_lb.Size = new System.Drawing.Size(343, 212);
            this.unchoosenNV_lb.TabIndex = 2;
            this.unchoosenNV_lb.SelectedIndexChanged += new System.EventHandler(this.unchoosenNV_lb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhân viên có thể làm ứng viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // choosenNV_lb
            // 
            this.choosenNV_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.choosenNV_lb.FormattingEnabled = true;
            this.choosenNV_lb.Location = new System.Drawing.Point(445, 295);
            this.choosenNV_lb.Name = "choosenNV_lb";
            this.choosenNV_lb.Size = new System.Drawing.Size(343, 212);
            this.choosenNV_lb.TabIndex = 2;
            this.choosenNV_lb.SelectedIndexChanged += new System.EventHandler(this.choosenNV_lb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ứng viên";
            // 
            // choose_btn
            // 
            this.choose_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_btn.Location = new System.Drawing.Point(362, 346);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(77, 23);
            this.choose_btn.TabIndex = 4;
            this.choose_btn.Text = ">>";
            this.choose_btn.UseVisualStyleBackColor = true;
            this.choose_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // unchoose_btn
            // 
            this.unchoose_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unchoose_btn.Location = new System.Drawing.Point(362, 414);
            this.unchoose_btn.Name = "unchoose_btn";
            this.unchoose_btn.Size = new System.Drawing.Size(77, 23);
            this.unchoose_btn.TabIndex = 4;
            this.unchoose_btn.Text = "<<";
            this.unchoose_btn.UseVisualStyleBackColor = true;
            this.unchoose_btn.Click += new System.EventHandler(this.unchoose_btn_click);
            // 
            // apply_btn
            // 
            this.apply_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_btn.Location = new System.Drawing.Point(616, 533);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 6;
            this.apply_btn.Text = "Xác nhận";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.Location = new System.Drawing.Point(713, 533);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Hủy";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // NhapDSUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.unchoose_btn);
            this.Controls.Add(this.choose_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choosenNV_lb);
            this.Controls.Add(this.unchoosenNV_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DSNV_dgv);
            this.Name = "NhapDSUV";
            this.Text = "Nhập danh sách ứng viên";
            this.Load += new System.EventHandler(this.NhapDSUV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSNV_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DSNV_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox unchoosenNV_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox choosenNV_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.Button unchoose_btn;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}