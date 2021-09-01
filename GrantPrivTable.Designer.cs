namespace BinhBauTinNhiem
{
    partial class GrantPrivTable
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            this.label1 = new System.Windows.Forms.Label();
            this.tablename = new System.Windows.Forms.TextBox();
            this.cols_privs = new System.Windows.Forms.DataGridView();
            this.select_btn = new System.Windows.Forms.Button();
            this.unselect_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.insert_check = new System.Windows.Forms.CheckBox();
            this.delete_check = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cols_privs)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 281);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 13);
            label2.TabIndex = 7;
            label2.Text = "Unselect users/roles";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 48);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 13);
            label4.TabIndex = 7;
            label4.Text = "Table privileges";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table";
            // 
            // tablename
            // 
            this.tablename.Enabled = false;
            this.tablename.Location = new System.Drawing.Point(314, 10);
            this.tablename.Name = "tablename";
            this.tablename.Size = new System.Drawing.Size(156, 20);
            this.tablename.TabIndex = 1;
            // 
            // cols_privs
            // 
            this.cols_privs.AllowUserToAddRows = false;
            this.cols_privs.AllowUserToDeleteRows = false;
            this.cols_privs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cols_privs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cols_privs.Location = new System.Drawing.Point(12, 64);
            this.cols_privs.Name = "cols_privs";
            this.cols_privs.Size = new System.Drawing.Size(470, 200);
            this.cols_privs.TabIndex = 2;
            this.cols_privs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cols_privs_CellContentClick);
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(337, 331);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(75, 23);
            this.select_btn.TabIndex = 4;
            this.select_btn.Text = "> >";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // unselect_btn
            // 
            this.unselect_btn.Location = new System.Drawing.Point(338, 389);
            this.unselect_btn.Name = "unselect_btn";
            this.unselect_btn.Size = new System.Drawing.Size(75, 23);
            this.unselect_btn.TabIndex = 4;
            this.unselect_btn.Text = "< <";
            this.unselect_btn.UseVisualStyleBackColor = true;
            this.unselect_btn.Click += new System.EventHandler(this.unselect_btn_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(653, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(534, 514);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Grant";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select users/roles";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 300);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 147);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(420, 300);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(313, 147);
            this.listBox2.TabIndex = 8;
            // 
            // insert_check
            // 
            this.insert_check.AutoSize = true;
            this.insert_check.Location = new System.Drawing.Point(534, 111);
            this.insert_check.Name = "insert_check";
            this.insert_check.Size = new System.Drawing.Size(66, 17);
            this.insert_check.TabIndex = 9;
            this.insert_check.Text = "INSERT";
            this.insert_check.UseVisualStyleBackColor = true;
            // 
            // delete_check
            // 
            this.delete_check.AutoSize = true;
            this.delete_check.Location = new System.Drawing.Point(534, 157);
            this.delete_check.Name = "delete_check";
            this.delete_check.Size = new System.Drawing.Size(68, 17);
            this.delete_check.TabIndex = 9;
            this.delete_check.Text = "DELETE";
            this.delete_check.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(534, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "SELECT";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // GrantPrivTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 549);
            this.Controls.Add(this.delete_check);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.insert_check);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.unselect_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.cols_privs);
            this.Controls.Add(this.tablename);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GrantPrivTable";
            this.Text = "Phân quyền trên bảng";
            this.Load += new System.EventHandler(this.GrantPrivTable_Load);
            this.Shown += new System.EventHandler(this.GrantPrivTable_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cols_privs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tablename;
        private System.Windows.Forms.DataGridView cols_privs;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button unselect_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.CheckBox insert_check;
        private System.Windows.Forms.CheckBox delete_check;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}