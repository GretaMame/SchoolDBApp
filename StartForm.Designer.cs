namespace DatabaseApplication
{
    partial class StartForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentButton = new System.Windows.Forms.Button();
            this.TeacherButton = new System.Windows.Forms.Button();
            this.AdministrationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentButton);
            this.groupBox1.Controls.Add(this.TeacherButton);
            this.groupBox1.Controls.Add(this.AdministrationButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(92, 169);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(126, 23);
            this.studentButton.TabIndex = 3;
            this.studentButton.Text = "Mokinys";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // TeacherButton
            // 
            this.TeacherButton.Location = new System.Drawing.Point(92, 115);
            this.TeacherButton.Name = "TeacherButton";
            this.TeacherButton.Size = new System.Drawing.Size(126, 23);
            this.TeacherButton.TabIndex = 2;
            this.TeacherButton.Text = "Mokytojas";
            this.TeacherButton.UseVisualStyleBackColor = true;
            this.TeacherButton.Click += new System.EventHandler(this.TeacherButton_Click);
            // 
            // AdministrationButton
            // 
            this.AdministrationButton.Location = new System.Drawing.Point(92, 61);
            this.AdministrationButton.Name = "AdministrationButton";
            this.AdministrationButton.Size = new System.Drawing.Size(126, 23);
            this.AdministrationButton.TabIndex = 1;
            this.AdministrationButton.Text = "Administracija";
            this.AdministrationButton.UseVisualStyleBackColor = true;
            this.AdministrationButton.Click += new System.EventHandler(this.administrationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sveiki prisijungę prie mokyklos virtualios sistemos!";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 258);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mokyklos sistema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AdministrationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TeacherButton;
        private System.Windows.Forms.Button studentButton;
    }
}

