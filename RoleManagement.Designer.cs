namespace BinhBauTinNhiem
{
    partial class RoleManagement
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
            this.Role = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.granted_tables = new System.Windows.Forms.TabPage();
            this.revoke_tab_btn = new System.Windows.Forms.Button();
            this.grant_tabs = new System.Windows.Forms.DataGridView();
            this.granted_cols = new System.Windows.Forms.TabPage();
            this.revoke_col_btn = new System.Windows.Forms.Button();
            this.grant_cols = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grant_btn = new System.Windows.Forms.Button();
            this.unchoose = new System.Windows.Forms.Button();
            this.choose = new System.Windows.Forms.Button();
            this.granted = new System.Windows.Forms.ListBox();
            this.ungranted = new System.Windows.Forms.ListBox();
            this.tab.SuspendLayout();
            this.granted_tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grant_tabs)).BeginInit();
            this.granted_cols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grant_cols)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Role";
            // 
            // Role
            // 
            this.Role.Enabled = false;
            this.Role.Location = new System.Drawing.Point(335, 12);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(136, 20);
            this.Role.TabIndex = 2;
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.granted_tables);
            this.tab.Controls.Add(this.granted_cols);
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Location = new System.Drawing.Point(0, 38);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(744, 443);
            this.tab.TabIndex = 4;
            // 
            // granted_tables
            // 
            this.granted_tables.Controls.Add(this.revoke_tab_btn);
            this.granted_tables.Controls.Add(this.grant_tabs);
            this.granted_tables.Location = new System.Drawing.Point(4, 22);
            this.granted_tables.Name = "granted_tables";
            this.granted_tables.Padding = new System.Windows.Forms.Padding(3);
            this.granted_tables.Size = new System.Drawing.Size(736, 417);
            this.granted_tables.TabIndex = 0;
            this.granted_tables.Text = "Granted table privileges";
            this.granted_tables.UseVisualStyleBackColor = true;
            // 
            // revoke_tab_btn
            // 
            this.revoke_tab_btn.Location = new System.Drawing.Point(20, 16);
            this.revoke_tab_btn.Name = "revoke_tab_btn";
            this.revoke_tab_btn.Size = new System.Drawing.Size(75, 23);
            this.revoke_tab_btn.TabIndex = 1;
            this.revoke_tab_btn.Text = "REVOKE";
            this.revoke_tab_btn.UseVisualStyleBackColor = true;
            this.revoke_tab_btn.Click += new System.EventHandler(this.revoke_tab_btn_Click);
            // 
            // grant_tabs
            // 
            this.grant_tabs.AllowUserToAddRows = false;
            this.grant_tabs.AllowUserToDeleteRows = false;
            this.grant_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grant_tabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grant_tabs.Location = new System.Drawing.Point(120, 0);
            this.grant_tabs.Name = "grant_tabs";
            this.grant_tabs.ReadOnly = true;
            this.grant_tabs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grant_tabs.Size = new System.Drawing.Size(616, 417);
            this.grant_tabs.TabIndex = 0;
            this.grant_tabs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grant_tabs_CellContentClick);
            // 
            // granted_cols
            // 
            this.granted_cols.Controls.Add(this.revoke_col_btn);
            this.granted_cols.Controls.Add(this.grant_cols);
            this.granted_cols.Location = new System.Drawing.Point(4, 22);
            this.granted_cols.Name = "granted_cols";
            this.granted_cols.Padding = new System.Windows.Forms.Padding(3);
            this.granted_cols.Size = new System.Drawing.Size(736, 417);
            this.granted_cols.TabIndex = 1;
            this.granted_cols.Text = "Granted column privileges";
            this.granted_cols.UseVisualStyleBackColor = true;
            // 
            // revoke_col_btn
            // 
            this.revoke_col_btn.Location = new System.Drawing.Point(22, 20);
            this.revoke_col_btn.Name = "revoke_col_btn";
            this.revoke_col_btn.Size = new System.Drawing.Size(75, 23);
            this.revoke_col_btn.TabIndex = 1;
            this.revoke_col_btn.Text = "REVOKE";
            this.revoke_col_btn.UseVisualStyleBackColor = true;
            this.revoke_col_btn.Click += new System.EventHandler(this.revoke_col_btn_Click);
            // 
            // grant_cols
            // 
            this.grant_cols.AllowUserToAddRows = false;
            this.grant_cols.AllowUserToDeleteRows = false;
            this.grant_cols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grant_cols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grant_cols.Location = new System.Drawing.Point(121, 0);
            this.grant_cols.Name = "grant_cols";
            this.grant_cols.ReadOnly = true;
            this.grant_cols.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grant_cols.Size = new System.Drawing.Size(615, 417);
            this.grant_cols.TabIndex = 0;
            this.grant_cols.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grant_cols_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grant_btn);
            this.tabPage1.Controls.Add(this.unchoose);
            this.tabPage1.Controls.Add(this.choose);
            this.tabPage1.Controls.Add(this.granted);
            this.tabPage1.Controls.Add(this.ungranted);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 417);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Grant role to users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grant_btn
            // 
            this.grant_btn.Location = new System.Drawing.Point(577, 377);
            this.grant_btn.Name = "grant_btn";
            this.grant_btn.Size = new System.Drawing.Size(75, 23);
            this.grant_btn.TabIndex = 2;
            this.grant_btn.Text = "GRANT";
            this.grant_btn.UseVisualStyleBackColor = true;
            this.grant_btn.Click += new System.EventHandler(this.grant_btn_Click);
            // 
            // unchoose
            // 
            this.unchoose.Location = new System.Drawing.Point(331, 182);
            this.unchoose.Name = "unchoose";
            this.unchoose.Size = new System.Drawing.Size(75, 23);
            this.unchoose.TabIndex = 1;
            this.unchoose.Text = "< <";
            this.unchoose.UseVisualStyleBackColor = true;
            this.unchoose.Click += new System.EventHandler(this.unchoose_Click);
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(331, 116);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(75, 23);
            this.choose.TabIndex = 1;
            this.choose.Text = "> >";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // granted
            // 
            this.granted.FormattingEnabled = true;
            this.granted.Location = new System.Drawing.Point(442, 60);
            this.granted.Name = "granted";
            this.granted.Size = new System.Drawing.Size(210, 290);
            this.granted.TabIndex = 0;
            // 
            // ungranted
            // 
            this.ungranted.FormattingEnabled = true;
            this.ungranted.Location = new System.Drawing.Point(93, 60);
            this.ungranted.Name = "ungranted";
            this.ungranted.Size = new System.Drawing.Size(210, 290);
            this.ungranted.TabIndex = 0;
            // 
            // RoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 483);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Role);
            this.Name = "RoleManagement";
            this.Text = "Quản lý role";
            this.Load += new System.EventHandler(this.RoleManagement_Load);
            this.Shown += new System.EventHandler(this.RoleManagement_Shown);
            this.tab.ResumeLayout(false);
            this.granted_tables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grant_tabs)).EndInit();
            this.granted_cols.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grant_cols)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Role;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage granted_tables;
        private System.Windows.Forms.DataGridView grant_tabs;
        private System.Windows.Forms.TabPage granted_cols;
        private System.Windows.Forms.DataGridView grant_cols;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox granted;
        private System.Windows.Forms.ListBox ungranted;
        private System.Windows.Forms.Button grant_btn;
        private System.Windows.Forms.Button unchoose;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button revoke_tab_btn;
        private System.Windows.Forms.Button revoke_col_btn;
    }
}