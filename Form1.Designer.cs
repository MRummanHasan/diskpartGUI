namespace DiskpartGUI
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
            this.Ok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rescan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diskid = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.directory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showDetails = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sanpolicydetails = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(20, 62);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(100, 35);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Change Volume Name";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(601, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 210);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // rescan
            // 
            this.rescan.Location = new System.Drawing.Point(20, 250);
            this.rescan.Name = "rescan";
            this.rescan.Size = new System.Drawing.Size(100, 35);
            this.rescan.TabIndex = 3;
            this.rescan.Text = "Rescan";
            this.rescan.UseVisualStyleBackColor = true;
            this.rescan.Click += new System.EventHandler(this.Rescan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.showDetails);
            this.panel1.Controls.Add(this.diskid);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(198, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 399);
            this.panel1.TabIndex = 4;
            // 
            // diskid
            // 
            this.diskid.AutoSize = true;
            this.diskid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskid.Location = new System.Drawing.Point(24, 293);
            this.diskid.Name = "diskid";
            this.diskid.Size = new System.Drawing.Size(74, 24);
            this.diskid.TabIndex = 3;
            this.diskid.Text = "Disk ID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 21);
            this.button3.TabIndex = 2;
            this.button3.Text = "Go";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Format";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Disk IDs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "MENU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.directory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Ok);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.rescan);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 441);
            this.panel2.TabIndex = 8;
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(20, 187);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(100, 36);
            this.directory.TabIndex = 9;
            this.directory.Text = "Directory";
            this.directory.UseVisualStyleBackColor = true;
            this.directory.Click += new System.EventHandler(this.Directory_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sanpolicydetails);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(601, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 165);
            this.panel3.TabIndex = 9;
            // 
            // showDetails
            // 
            this.showDetails.Location = new System.Drawing.Point(236, 28);
            this.showDetails.Name = "showDetails";
            this.showDetails.Size = new System.Drawing.Size(107, 23);
            this.showDetails.TabIndex = 4;
            this.showDetails.Text = "Show Details";
            this.showDetails.UseVisualStyleBackColor = true;
            this.showDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Disk Details";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "Policy Check";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "POLICY DETAILS:";
            // 
            // sanpolicydetails
            // 
            this.sanpolicydetails.AutoSize = true;
            this.sanpolicydetails.Location = new System.Drawing.Point(21, 57);
            this.sanpolicydetails.Name = "sanpolicydetails";
            this.sanpolicydetails.Size = new System.Drawing.Size(34, 13);
            this.sanpolicydetails.TabIndex = 1;
            this.sanpolicydetails.Text = "policy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 474);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button rescan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label diskid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button directory;
        private System.Windows.Forms.Button showDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label sanpolicydetails;
        private System.Windows.Forms.Label label4;
    }
}

