namespace AA_XML_Parser
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
            this.Results = new System.Windows.Forms.RichTextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.LineCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.Button();
            this.RunParse = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(11, 140);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(406, 193);
            this.Results.TabIndex = 18;
            this.Results.Text = "";
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.Color.White;
            this.FileName.Location = new System.Drawing.Point(15, 29);
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Size = new System.Drawing.Size(334, 22);
            this.FileName.TabIndex = 17;
            // 
            // LineCount
            // 
            this.LineCount.AutoSize = true;
            this.LineCount.Location = new System.Drawing.Point(347, 74);
            this.LineCount.Name = "LineCount";
            this.LineCount.Size = new System.Drawing.Size(0, 17);
            this.LineCount.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Failed Lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Reading Line:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "File Location";
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(355, 9);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(63, 42);
            this.OpenFile.TabIndex = 12;
            this.OpenFile.Text = "Open";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // RunParse
            // 
            this.RunParse.Location = new System.Drawing.Point(15, 57);
            this.RunParse.Name = "RunParse";
            this.RunParse.Size = new System.Drawing.Size(224, 50);
            this.RunParse.TabIndex = 11;
            this.RunParse.Text = "Parse";
            this.RunParse.UseVisualStyleBackColor = true;
            this.RunParse.Click += new System.EventHandler(this.RunParse_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 351);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.LineCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.RunParse);
            this.Name = "Form1";
            this.Text = "Error Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label LineCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button RunParse;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
    }
}

