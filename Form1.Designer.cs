namespace Xtractor
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.augmentCheckBox = new System.Windows.Forms.CheckBox();
            this.moveCheckBox = new System.Windows.Forms.CheckBox();
            this.overwriteCheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.showReportCheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set source";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Set destination";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // augmentCheckBox
            // 
            this.augmentCheckBox.AutoSize = true;
            this.augmentCheckBox.Checked = true;
            this.augmentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.augmentCheckBox.Location = new System.Drawing.Point(24, 180);
            this.augmentCheckBox.Name = "augmentCheckBox";
            this.augmentCheckBox.Size = new System.Drawing.Size(520, 21);
            this.augmentCheckBox.TabIndex = 4;
            this.augmentCheckBox.Text = "Augment folder name to filename ( folder01/file01.jpg --> folder01__file01.jpg)";
            this.augmentCheckBox.UseVisualStyleBackColor = true;
            this.augmentCheckBox.CheckedChanged += new System.EventHandler(this.augmentCheckBox_CheckedChanged);
            // 
            // moveCheckBox
            // 
            this.moveCheckBox.AutoSize = true;
            this.moveCheckBox.Checked = true;
            this.moveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moveCheckBox.Location = new System.Drawing.Point(24, 153);
            this.moveCheckBox.Name = "moveCheckBox";
            this.moveCheckBox.Size = new System.Drawing.Size(241, 21);
            this.moveCheckBox.TabIndex = 5;
            this.moveCheckBox.Text = "Keep the original folders and files";
            this.moveCheckBox.UseVisualStyleBackColor = true;
            // 
            // overwriteCheckBox
            // 
            this.overwriteCheckBox.AutoSize = true;
            this.overwriteCheckBox.Enabled = false;
            this.overwriteCheckBox.Location = new System.Drawing.Point(51, 207);
            this.overwriteCheckBox.Name = "overwriteCheckBox";
            this.overwriteCheckBox.Size = new System.Drawing.Size(231, 21);
            this.overwriteCheckBox.TabIndex = 6;
            this.overwriteCheckBox.Text = "Overwrite files with same names";
            this.overwriteCheckBox.UseVisualStyleBackColor = true;
            this.overwriteCheckBox.CheckedChanged += new System.EventHandler(this.overwriteCheckBox_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(536, 72);
            this.button3.TabIndex = 7;
            this.button3.Text = "START";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // showReportCheckBox
            // 
            this.showReportCheckBox.AutoSize = true;
            this.showReportCheckBox.Location = new System.Drawing.Point(24, 235);
            this.showReportCheckBox.Name = "showReportCheckBox";
            this.showReportCheckBox.Size = new System.Drawing.Size(260, 21);
            this.showReportCheckBox.TabIndex = 9;
            this.showReportCheckBox.Text = "List all filenames after process ends.";
            this.showReportCheckBox.UseVisualStyleBackColor = true;
            this.showReportCheckBox.CheckedChanged += new System.EventHandler(this.showReportCheckBox_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 349);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(536, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(416, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Source -";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(416, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Destination -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 430);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.showReportCheckBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.overwriteCheckBox);
            this.Controls.Add(this.moveCheckBox);
            this.Controls.Add(this.augmentCheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "FoFi-Removes Folders, Retains Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox augmentCheckBox;
        private System.Windows.Forms.CheckBox moveCheckBox;
        private System.Windows.Forms.CheckBox overwriteCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox showReportCheckBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

