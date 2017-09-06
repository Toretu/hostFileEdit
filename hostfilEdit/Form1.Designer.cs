namespace hostfilEdit
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
            this.editHostfile = new System.Windows.Forms.TextBox();
            this.loadHostFile = new System.Windows.Forms.Button();
            this.BKhost = new System.Windows.Forms.Button();
            this.saveThis = new System.Windows.Forms.Button();
            this.lagretStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editHostfile
            // 
            this.editHostfile.Location = new System.Drawing.Point(29, 41);
            this.editHostfile.Multiline = true;
            this.editHostfile.Name = "editHostfile";
            this.editHostfile.Size = new System.Drawing.Size(574, 392);
            this.editHostfile.TabIndex = 0;
            this.editHostfile.TextChanged += new System.EventHandler(this.editHostfile_TextChanged);
            this.editHostfile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editHostfile_KeyDown);
            // 
            // loadHostFile
            // 
            this.loadHostFile.Location = new System.Drawing.Point(330, 13);
            this.loadHostFile.Name = "loadHostFile";
            this.loadHostFile.Size = new System.Drawing.Size(75, 23);
            this.loadHostFile.TabIndex = 1;
            this.loadHostFile.Text = "last hostfil";
            this.loadHostFile.UseVisualStyleBackColor = true;
            this.loadHostFile.Click += new System.EventHandler(this.loadHostFile_Click);
            // 
            // BKhost
            // 
            this.BKhost.Location = new System.Drawing.Point(412, 13);
            this.BKhost.Name = "BKhost";
            this.BKhost.Size = new System.Drawing.Size(75, 23);
            this.BKhost.TabIndex = 2;
            this.BKhost.Text = "Backup Hostfile";
            this.BKhost.UseVisualStyleBackColor = true;
            this.BKhost.Click += new System.EventHandler(this.BKhost_Click);
            // 
            // saveThis
            // 
            this.saveThis.Location = new System.Drawing.Point(230, 13);
            this.saveThis.Name = "saveThis";
            this.saveThis.Size = new System.Drawing.Size(75, 23);
            this.saveThis.TabIndex = 3;
            this.saveThis.Text = "lagre gjeldene hostfile";
            this.saveThis.UseVisualStyleBackColor = true;
            this.saveThis.Click += new System.EventHandler(this.saveThis_Click);
            // 
            // lagretStatus
            // 
            this.lagretStatus.AutoSize = true;
            this.lagretStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagretStatus.Location = new System.Drawing.Point(522, 13);
            this.lagretStatus.Name = "lagretStatus";
            this.lagretStatus.Size = new System.Drawing.Size(0, 20);
            this.lagretStatus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 445);
            this.Controls.Add(this.lagretStatus);
            this.Controls.Add(this.saveThis);
            this.Controls.Add(this.BKhost);
            this.Controls.Add(this.loadHostFile);
            this.Controls.Add(this.editHostfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editHostfile;
        private System.Windows.Forms.Button loadHostFile;
        private System.Windows.Forms.Button BKhost;
        private System.Windows.Forms.Button saveThis;
        private System.Windows.Forms.Label lagretStatus;
    }
}

