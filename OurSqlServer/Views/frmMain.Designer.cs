namespace OurSqlServer.Views
{
    partial class frmMain
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Database");
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpPanel = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.rdbHTTP = new System.Windows.Forms.RadioButton();
            this.rdbSQL = new System.Windows.Forms.RadioButton();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpPanel.SuspendLayout();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(615, 84);
            this.textBox1.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(117, 126);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // grpPanel
            // 
            this.grpPanel.BackColor = System.Drawing.Color.White;
            this.grpPanel.Controls.Add(this.treeView1);
            this.grpPanel.Controls.Add(this.rdbHTTP);
            this.grpPanel.Controls.Add(this.rdbSQL);
            this.grpPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPanel.Location = new System.Drawing.Point(0, 0);
            this.grpPanel.Name = "grpPanel";
            this.grpPanel.Size = new System.Drawing.Size(157, 450);
            this.grpPanel.TabIndex = 7;
            this.grpPanel.TabStop = false;
            this.grpPanel.Text = "Panel";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView1.Location = new System.Drawing.Point(3, 105);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "Nodo0";
            treeNode3.Text = "Database";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(151, 342);
            this.treeView1.TabIndex = 5;
            // 
            // rdbHTTP
            // 
            this.rdbHTTP.AutoSize = true;
            this.rdbHTTP.Location = new System.Drawing.Point(12, 62);
            this.rdbHTTP.Name = "rdbHTTP";
            this.rdbHTTP.Size = new System.Drawing.Size(54, 17);
            this.rdbHTTP.TabIndex = 4;
            this.rdbHTTP.TabStop = true;
            this.rdbHTTP.Text = "HTTP";
            this.rdbHTTP.UseVisualStyleBackColor = true;
            // 
            // rdbSQL
            // 
            this.rdbSQL.AutoSize = true;
            this.rdbSQL.Location = new System.Drawing.Point(12, 39);
            this.rdbSQL.Name = "rdbSQL";
            this.rdbSQL.Size = new System.Drawing.Size(46, 17);
            this.rdbSQL.TabIndex = 3;
            this.rdbSQL.TabStop = true;
            this.rdbSQL.Text = "SQL";
            this.rdbSQL.UseVisualStyleBackColor = true;
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnSend);
            this.grpMain.Controls.Add(this.textBox2);
            this.grpMain.Controls.Add(this.textBox1);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpMain.Location = new System.Drawing.Point(179, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(621, 450);
            this.grpMain.TabIndex = 8;
            this.grpMain.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(3, 174);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(615, 273);
            this.textBox2.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpPanel);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpPanel.ResumeLayout(false);
            this.grpPanel.PerformLayout();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox grpPanel;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton rdbHTTP;
        private System.Windows.Forms.RadioButton rdbSQL;
    }
}