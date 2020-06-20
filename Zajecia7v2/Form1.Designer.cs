namespace Zajecia7v2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 115);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 290);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(227, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 218);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Czcionka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dodaj postęp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Kolor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Drukuj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(366, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 32);
            this.button5.TabIndex = 10;
            this.button5.Text = "Alert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(480, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 32);
            this.button6.TabIndex = 11;
            this.button6.Text = "Nowe okno";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(595, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(418, 320);
            this.webBrowser1.TabIndex = 12;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 341);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

