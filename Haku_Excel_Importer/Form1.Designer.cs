namespace Haku_Excel_Importer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectfile = new System.Windows.Forms.Button();
            this.adddata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectfile
            // 
            this.selectfile.Location = new System.Drawing.Point(147, 69);
            this.selectfile.Name = "selectfile";
            this.selectfile.Size = new System.Drawing.Size(75, 23);
            this.selectfile.TabIndex = 0;
            this.selectfile.Text = "Select File";
            this.selectfile.UseVisualStyleBackColor = true;
            this.selectfile.Click += new System.EventHandler(this.selectfile_Click);
            // 
            // adddata
            // 
            this.adddata.Location = new System.Drawing.Point(497, 69);
            this.adddata.Name = "adddata";
            this.adddata.Size = new System.Drawing.Size(75, 23);
            this.adddata.TabIndex = 1;
            this.adddata.Text = "Add to Database";
            this.adddata.UseVisualStyleBackColor = true;
            this.adddata.Click += new System.EventHandler(this.adddata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adddata);
            this.Controls.Add(this.selectfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectfile;
        private System.Windows.Forms.Button adddata;
    }
}

