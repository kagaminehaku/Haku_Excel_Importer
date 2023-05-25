namespace Haku_Excel_Importer
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectfile = new System.Windows.Forms.Button();
            this.adddata = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bday2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectfile
            // 
            this.selectfile.BackColor = System.Drawing.Color.Transparent;
            this.selectfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectfile.BackgroundImage")));
            this.selectfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectfile.Location = new System.Drawing.Point(12, 41);
            this.selectfile.Name = "selectfile";
            this.selectfile.Size = new System.Drawing.Size(128, 104);
            this.selectfile.TabIndex = 0;
            this.selectfile.UseVisualStyleBackColor = false;
            this.selectfile.Click += new System.EventHandler(this.selectfile_Click);
            // 
            // adddata
            // 
            this.adddata.BackColor = System.Drawing.Color.Transparent;
            this.adddata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adddata.BackgroundImage")));
            this.adddata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adddata.Location = new System.Drawing.Point(12, 151);
            this.adddata.Name = "adddata";
            this.adddata.Size = new System.Drawing.Size(128, 104);
            this.adddata.TabIndex = 1;
            this.adddata.UseVisualStyleBackColor = false;
            this.adddata.Click += new System.EventHandler(this.adddata_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(923, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.BDay,
            this.gender});
            this.dgv1.Location = new System.Drawing.Point(146, 41);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(344, 104);
            this.dgv1.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // BDay
            // 
            this.BDay.HeaderText = "B-Day";
            this.BDay.Name = "BDay";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name2,
            this.bday2,
            this.gender2});
            this.dgv2.Location = new System.Drawing.Point(146, 151);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(344, 104);
            this.dgv2.TabIndex = 4;
            // 
            // name2
            // 
            this.name2.HeaderText = "Name";
            this.name2.Name = "name2";
            // 
            // bday2
            // 
            this.bday2.HeaderText = "B-Day";
            this.bday2.Name = "bday2";
            // 
            // gender2
            // 
            this.gender2.HeaderText = "Gender";
            this.gender2.Name = "gender2";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 421);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.adddata);
            this.Controls.Add(this.selectfile);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Haku Excel Importer To SQL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectfile;
        private System.Windows.Forms.Button adddata;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bday2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender2;
    }
}

