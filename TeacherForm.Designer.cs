namespace DatabaseApplication
{
    partial class TeacherForm
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
            this.editGradesButton = new System.Windows.Forms.Button();
            this.insertGradesButton = new System.Windows.Forms.Button();
            this.pupilsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editGradesButton);
            this.groupBox1.Controls.Add(this.insertGradesButton);
            this.groupBox1.Controls.Add(this.pupilsButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // editGradesButton
            // 
            this.editGradesButton.Location = new System.Drawing.Point(58, 117);
            this.editGradesButton.Name = "editGradesButton";
            this.editGradesButton.Size = new System.Drawing.Size(164, 23);
            this.editGradesButton.TabIndex = 2;
            this.editGradesButton.Text = "Redaguoti pažymius";
            this.editGradesButton.UseVisualStyleBackColor = true;
            this.editGradesButton.Click += new System.EventHandler(this.editGradesButton_Click);
            // 
            // insertGradesButton
            // 
            this.insertGradesButton.Location = new System.Drawing.Point(58, 72);
            this.insertGradesButton.Name = "insertGradesButton";
            this.insertGradesButton.Size = new System.Drawing.Size(164, 23);
            this.insertGradesButton.TabIndex = 1;
            this.insertGradesButton.Text = "Įvesti pažymius";
            this.insertGradesButton.UseVisualStyleBackColor = true;
            this.insertGradesButton.Click += new System.EventHandler(this.insertGradesButton_Click);
            // 
            // pupilsButton
            // 
            this.pupilsButton.Location = new System.Drawing.Point(58, 30);
            this.pupilsButton.Name = "pupilsButton";
            this.pupilsButton.Size = new System.Drawing.Size(164, 23);
            this.pupilsButton.TabIndex = 0;
            this.pupilsButton.Text = "Peržiūrėti auklėtinių duomenis";
            this.pupilsButton.UseVisualStyleBackColor = true;
            this.pupilsButton.Click += new System.EventHandler(this.pupilsButton_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mokytojas";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editGradesButton;
        private System.Windows.Forms.Button insertGradesButton;
        private System.Windows.Forms.Button pupilsButton;
    }
}