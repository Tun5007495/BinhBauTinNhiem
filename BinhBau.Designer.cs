namespace BinhBauTinNhiem
{
    partial class BinhBau
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uv1_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uv2_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uv3_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bau_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ứng viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uv1_cb
            // 
            this.uv1_cb.FormattingEnabled = true;
            this.uv1_cb.Location = new System.Drawing.Point(15, 298);
            this.uv1_cb.Name = "uv1_cb";
            this.uv1_cb.Size = new System.Drawing.Size(121, 21);
            this.uv1_cb.TabIndex = 2;
            this.uv1_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ứng viên 1";
            // 
            // uv2_cb
            // 
            this.uv2_cb.FormattingEnabled = true;
            this.uv2_cb.Location = new System.Drawing.Point(303, 298);
            this.uv2_cb.Name = "uv2_cb";
            this.uv2_cb.Size = new System.Drawing.Size(121, 21);
            this.uv2_cb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ứng viên 2";
            // 
            // uv3_cb
            // 
            this.uv3_cb.FormattingEnabled = true;
            this.uv3_cb.Location = new System.Drawing.Point(612, 298);
            this.uv3_cb.Name = "uv3_cb";
            this.uv3_cb.Size = new System.Drawing.Size(121, 21);
            this.uv3_cb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ứng viên 3";
            // 
            // bau_btn
            // 
            this.bau_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bau_btn.Location = new System.Drawing.Point(542, 415);
            this.bau_btn.Name = "bau_btn";
            this.bau_btn.Size = new System.Drawing.Size(75, 23);
            this.bau_btn.TabIndex = 4;
            this.bau_btn.Text = "Bầu";
            this.bau_btn.UseVisualStyleBackColor = true;
            this.bau_btn.Click += new System.EventHandler(this.bau_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lưu ý: Phiếu bầu phải chọn đủ 3 ứng viên khác nhau mới được tính là hợp lệ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BinhBau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bau_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uv3_cb);
            this.Controls.Add(this.uv2_cb);
            this.Controls.Add(this.uv1_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BinhBau";
            this.Text = "Bình bầu";
            this.Load += new System.EventHandler(this.BinhBau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uv1_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uv2_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uv3_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bau_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}