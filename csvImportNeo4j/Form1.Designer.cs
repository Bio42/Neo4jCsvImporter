namespace csvImportNeo4j
{
    partial class Form1
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
            this.Import_btn = new System.Windows.Forms.Button();
            this.CSV_Path_lbl = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_btn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_uri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.log_tb = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Import_btn
            // 
            this.Import_btn.Location = new System.Drawing.Point(286, 308);
            this.Import_btn.Name = "Import_btn";
            this.Import_btn.Size = new System.Drawing.Size(75, 23);
            this.Import_btn.TabIndex = 0;
            this.Import_btn.Text = "Import";
            this.Import_btn.UseVisualStyleBackColor = true;
            this.Import_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CSV_Path_lbl
            // 
            this.CSV_Path_lbl.AutoSize = true;
            this.CSV_Path_lbl.Location = new System.Drawing.Point(3, 3);
            this.CSV_Path_lbl.Name = "CSV_Path_lbl";
            this.CSV_Path_lbl.Size = new System.Drawing.Size(58, 13);
            this.CSV_Path_lbl.TabIndex = 1;
            this.CSV_Path_lbl.Text = "FILEPATH";
            // 
            // fbd_btn
            // 
            this.fbd_btn.Location = new System.Drawing.Point(140, 22);
            this.fbd_btn.Name = "fbd_btn";
            this.fbd_btn.Size = new System.Drawing.Size(75, 23);
            this.fbd_btn.TabIndex = 2;
            this.fbd_btn.Text = "Change Folder";
            this.fbd_btn.UseVisualStyleBackColor = true;
            this.fbd_btn.Click += new System.EventHandler(this.fbd_btn_Click);
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Location = new System.Drawing.Point(6, 19);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(128, 195);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(9, 233);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(164, 20);
            this.tb_Username.TabIndex = 4;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(9, 272);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(164, 20);
            this.tb_pw.TabIndex = 5;
            // 
            // tb_uri
            // 
            this.tb_uri.Location = new System.Drawing.Point(9, 311);
            this.tb_uri.Name = "tb_uri";
            this.tb_uri.Size = new System.Drawing.Size(164, 20);
            this.tb_uri.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Passwort";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(6, 217);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 8;
            this.Username.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(11, 367);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(50, 13);
            this.lbl_status.TabIndex = 11;
            this.lbl_status.Text = "STATUS";
            // 
            // log_tb
            // 
            this.log_tb.Location = new System.Drawing.Point(3, 6);
            this.log_tb.Name = "log_tb";
            this.log_tb.Size = new System.Drawing.Size(895, 497);
            this.log_tb.TabIndex = 12;
            this.log_tb.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 535);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Import_btn);
            this.tabPage1.Controls.Add(this.lbl_status);
            this.tabPage1.Controls.Add(this.tb_uri);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.CSV_Path_lbl);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Username);
            this.tabPage1.Controls.Add(this.listView);
            this.tabPage1.Controls.Add(this.tb_pw);
            this.tabPage1.Controls.Add(this.fbd_btn);
            this.tabPage1.Controls.Add(this.tb_Username);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Import";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.log_tb);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 542);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Import_btn;
        private System.Windows.Forms.Label CSV_Path_lbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button fbd_btn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_uri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.RichTextBox log_tb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

