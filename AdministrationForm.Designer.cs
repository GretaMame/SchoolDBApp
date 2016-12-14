namespace DatabaseApplication
{
    partial class AdministrationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new DatabaseApplication.SchoolDBDataSet();
            this.saveSubjectChangesButton = new System.Windows.Forms.Button();
            this.updateSubjectButton = new System.Windows.Forms.Button();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.deleteSubjectButton = new System.Windows.Forms.Button();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teacherSubjectsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editTeacherButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.editTeacherQualificationTextBox = new System.Windows.Forms.TextBox();
            this.editTeacherEducationTextBox = new System.Windows.Forms.TextBox();
            this.editTeacherSurnamTextBox = new System.Windows.Forms.TextBox();
            this.editTeacherPhoneNumbTextBox = new System.Windows.Forms.TextBox();
            this.editTeacherNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.editTeacherTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherQualificationTextBox = new System.Windows.Forms.TextBox();
            this.teacherEducationTextBox = new System.Windows.Forms.TextBox();
            this.teacherSurnameTextBox = new System.Windows.Forms.TextBox();
            this.teacherPhoneNumbTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addClassButton = new System.Windows.Forms.Button();
            this.classDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new DatabaseApplication.SchoolDBDataSetTableAdapters.ClassTableAdapter();
            this.subjectTableAdapter = new DatabaseApplication.SchoolDBDataSetTableAdapters.SubjectTableAdapter();
            this.qualificationErrorLabel = new System.Windows.Forms.Label();
            this.allSubjectsComboBox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subjectsDataGridView);
            this.groupBox1.Controls.Add(this.saveSubjectChangesButton);
            this.groupBox1.Controls.Add(this.updateSubjectButton);
            this.groupBox1.Controls.Add(this.addSubjectButton);
            this.groupBox1.Controls.Add(this.deleteSubjectButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dalykai";
            // 
            // subjectsDataGridView
            // 
            this.subjectsDataGridView.AutoGenerateColumns = false;
            this.subjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.subjectsDataGridView.DataSource = this.subjectBindingSource1;
            this.subjectsDataGridView.Location = new System.Drawing.Point(151, 18);
            this.subjectsDataGridView.Name = "subjectsDataGridView";
            this.subjectsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectsDataGridView.Size = new System.Drawing.Size(228, 156);
            this.subjectsDataGridView.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Nr";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 43;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataMember = "Subject";
            this.subjectBindingSource1.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveSubjectChangesButton
            // 
            this.saveSubjectChangesButton.Location = new System.Drawing.Point(28, 122);
            this.saveSubjectChangesButton.Name = "saveSubjectChangesButton";
            this.saveSubjectChangesButton.Size = new System.Drawing.Size(75, 35);
            this.saveSubjectChangesButton.TabIndex = 4;
            this.saveSubjectChangesButton.Text = "Išsaugoti pakeitimus";
            this.saveSubjectChangesButton.UseVisualStyleBackColor = true;
            this.saveSubjectChangesButton.Click += new System.EventHandler(this.saveSubjectChangesButton_Click_1);
            // 
            // updateSubjectButton
            // 
            this.updateSubjectButton.Location = new System.Drawing.Point(27, 93);
            this.updateSubjectButton.Name = "updateSubjectButton";
            this.updateSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.updateSubjectButton.TabIndex = 3;
            this.updateSubjectButton.Text = "Keisti";
            this.updateSubjectButton.UseVisualStyleBackColor = true;
            this.updateSubjectButton.Click += new System.EventHandler(this.updateSubjectButton_Click);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(28, 64);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.addSubjectButton.TabIndex = 2;
            this.addSubjectButton.Text = "Pridėti";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.Location = new System.Drawing.Point(28, 35);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSubjectButton.TabIndex = 1;
            this.deleteSubjectButton.Text = "Pašalinti";
            this.deleteSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSubjectButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(26, 525);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(144, 23);
            this.studentsButton.TabIndex = 0;
            this.studentsButton.Text = "Mokiniai";
            this.studentsButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(14, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mokytojai";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Location = new System.Drawing.Point(607, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(209, 218);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Atleisti mokyotoją";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(62, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(62, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Pavardė:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Auklėtiniai:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Vardas:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Įvesite mokytojo numerį:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 39);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(127, 20);
            this.textBox7.TabIndex = 22;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(65, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Atleisti";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.allSubjectsComboBox);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.teacherSubjectsComboBox);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.editTeacherButton);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.editTeacherQualificationTextBox);
            this.groupBox5.Controls.Add(this.editTeacherEducationTextBox);
            this.groupBox5.Controls.Add(this.editTeacherSurnamTextBox);
            this.groupBox5.Controls.Add(this.editTeacherPhoneNumbTextBox);
            this.groupBox5.Controls.Add(this.editTeacherNameTextBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.editTeacherTextBox);
            this.groupBox5.Location = new System.Drawing.Point(295, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(292, 218);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Keisti mokytojo duomenis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Pašalinti pasirinktą dalyką:";
            // 
            // teacherSubjectsComboBox
            // 
            this.teacherSubjectsComboBox.FormattingEnabled = true;
            this.teacherSubjectsComboBox.Location = new System.Drawing.Point(144, 155);
            this.teacherSubjectsComboBox.Name = "teacherSubjectsComboBox";
            this.teacherSubjectsComboBox.Size = new System.Drawing.Size(128, 21);
            this.teacherSubjectsComboBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Pavardė:";
            // 
            // editTeacherButton
            // 
            this.editTeacherButton.Enabled = false;
            this.editTeacherButton.Location = new System.Drawing.Point(109, 182);
            this.editTeacherButton.Name = "editTeacherButton";
            this.editTeacherButton.Size = new System.Drawing.Size(71, 23);
            this.editTeacherButton.TabIndex = 4;
            this.editTeacherButton.Text = "Keisti";
            this.editTeacherButton.UseVisualStyleBackColor = true;
            this.editTeacherButton.Click += new System.EventHandler(this.editTeacherButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Telefono numeris:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Baigta mokslo įstaiga:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Kvalifikacija:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Vardas:";
            // 
            // editTeacherQualificationTextBox
            // 
            this.editTeacherQualificationTextBox.Location = new System.Drawing.Point(144, 116);
            this.editTeacherQualificationTextBox.Name = "editTeacherQualificationTextBox";
            this.editTeacherQualificationTextBox.Size = new System.Drawing.Size(128, 20);
            this.editTeacherQualificationTextBox.TabIndex = 26;
            // 
            // editTeacherEducationTextBox
            // 
            this.editTeacherEducationTextBox.Location = new System.Drawing.Point(144, 74);
            this.editTeacherEducationTextBox.Name = "editTeacherEducationTextBox";
            this.editTeacherEducationTextBox.Size = new System.Drawing.Size(128, 20);
            this.editTeacherEducationTextBox.TabIndex = 25;
            // 
            // editTeacherSurnamTextBox
            // 
            this.editTeacherSurnamTextBox.Location = new System.Drawing.Point(5, 116);
            this.editTeacherSurnamTextBox.Name = "editTeacherSurnamTextBox";
            this.editTeacherSurnamTextBox.Size = new System.Drawing.Size(128, 20);
            this.editTeacherSurnamTextBox.TabIndex = 24;
            // 
            // editTeacherPhoneNumbTextBox
            // 
            this.editTeacherPhoneNumbTextBox.Location = new System.Drawing.Point(144, 36);
            this.editTeacherPhoneNumbTextBox.Name = "editTeacherPhoneNumbTextBox";
            this.editTeacherPhoneNumbTextBox.Size = new System.Drawing.Size(127, 20);
            this.editTeacherPhoneNumbTextBox.TabIndex = 23;
            // 
            // editTeacherNameTextBox
            // 
            this.editTeacherNameTextBox.Location = new System.Drawing.Point(6, 77);
            this.editTeacherNameTextBox.Name = "editTeacherNameTextBox";
            this.editTeacherNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.editTeacherNameTextBox.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Įvesite mokytojo numerį:";
            // 
            // editTeacherTextBox
            // 
            this.editTeacherTextBox.Location = new System.Drawing.Point(6, 38);
            this.editTeacherTextBox.Name = "editTeacherTextBox";
            this.editTeacherTextBox.Size = new System.Drawing.Size(127, 20);
            this.editTeacherTextBox.TabIndex = 20;
            this.editTeacherTextBox.TextChanged += new System.EventHandler(this.editTeacherTextBox_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.qualificationErrorLabel);
            this.groupBox4.Controls.Add(this.ErrorLabel);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.idTextBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.subjectsComboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.teacherQualificationTextBox);
            this.groupBox4.Controls.Add(this.teacherEducationTextBox);
            this.groupBox4.Controls.Add(this.teacherSurnameTextBox);
            this.groupBox4.Controls.Add(this.teacherPhoneNumbTextBox);
            this.groupBox4.Controls.Add(this.teacherNameTextBox);
            this.groupBox4.Controls.Add(this.addTeacherButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 218);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pridėti mokytoją";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(145, 147);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(135, 26);
            this.ErrorLabel.TabIndex = 14;
            this.ErrorLabel.Text = "Mokytojas su tokiu numeriu\njau egzistuoja!";
            this.ErrorLabel.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Numeris:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(6, 36);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(127, 20);
            this.idTextBox.TabIndex = 12;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Visi dėstomi dalykai:";
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Location = new System.Drawing.Point(144, 117);
            this.subjectsComboBox.MaxDropDownItems = 15;
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(128, 21);
            this.subjectsComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pavardė:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono numeris:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Baigta mokslo įstaiga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kvalifikacija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vardas:";
            // 
            // teacherQualificationTextBox
            // 
            this.teacherQualificationTextBox.Location = new System.Drawing.Point(144, 78);
            this.teacherQualificationTextBox.Name = "teacherQualificationTextBox";
            this.teacherQualificationTextBox.Size = new System.Drawing.Size(128, 20);
            this.teacherQualificationTextBox.TabIndex = 4;
            this.teacherQualificationTextBox.TextChanged += new System.EventHandler(this.teacherQualificationTextBox_TextChanged);
            // 
            // teacherEducationTextBox
            // 
            this.teacherEducationTextBox.Location = new System.Drawing.Point(144, 36);
            this.teacherEducationTextBox.Name = "teacherEducationTextBox";
            this.teacherEducationTextBox.Size = new System.Drawing.Size(128, 20);
            this.teacherEducationTextBox.TabIndex = 3;
            // 
            // teacherSurnameTextBox
            // 
            this.teacherSurnameTextBox.Location = new System.Drawing.Point(5, 116);
            this.teacherSurnameTextBox.Name = "teacherSurnameTextBox";
            this.teacherSurnameTextBox.Size = new System.Drawing.Size(128, 20);
            this.teacherSurnameTextBox.TabIndex = 2;
            // 
            // teacherPhoneNumbTextBox
            // 
            this.teacherPhoneNumbTextBox.Location = new System.Drawing.Point(6, 152);
            this.teacherPhoneNumbTextBox.Name = "teacherPhoneNumbTextBox";
            this.teacherPhoneNumbTextBox.Size = new System.Drawing.Size(127, 20);
            this.teacherPhoneNumbTextBox.TabIndex = 1;
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.Location = new System.Drawing.Point(6, 77);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.teacherNameTextBox.TabIndex = 0;
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Enabled = false;
            this.addTeacherButton.Location = new System.Drawing.Point(95, 178);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(77, 23);
            this.addTeacherButton.TabIndex = 0;
            this.addTeacherButton.Text = "Pridėti";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addClassButton);
            this.groupBox3.Controls.Add(this.classDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(418, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Klasės";
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(27, 36);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(93, 23);
            this.addClassButton.TabIndex = 3;
            this.addClassButton.Text = "Pridėti";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // classDataGridView
            // 
            this.classDataGridView.AutoGenerateColumns = false;
            this.classDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.tutorDataGridViewTextBoxColumn});
            this.classDataGridView.DataSource = this.classBindingSource;
            this.classDataGridView.Location = new System.Drawing.Point(163, 19);
            this.classDataGridView.Name = "classDataGridView";
            this.classDataGridView.ReadOnly = true;
            this.classDataGridView.Size = new System.Drawing.Size(240, 156);
            this.classDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Klasė";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 58;
            // 
            // tutorDataGridViewTextBoxColumn
            // 
            this.tutorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tutorDataGridViewTextBoxColumn.DataPropertyName = "Tutor";
            this.tutorDataGridViewTextBoxColumn.HeaderText = "Auklėtojo nr.";
            this.tutorDataGridViewTextBoxColumn.Name = "tutorDataGridViewTextBoxColumn";
            this.tutorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // qualificationErrorLabel
            // 
            this.qualificationErrorLabel.AutoSize = true;
            this.qualificationErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.qualificationErrorLabel.Location = new System.Drawing.Point(145, 149);
            this.qualificationErrorLabel.Name = "qualificationErrorLabel";
            this.qualificationErrorLabel.Size = new System.Drawing.Size(117, 13);
            this.qualificationErrorLabel.TabIndex = 15;
            this.qualificationErrorLabel.Text = "Neteisinga kvalifijkacija";
            this.qualificationErrorLabel.Visible = false;
            // 
            // allSubjectsComboBox
            // 
            this.allSubjectsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allSubjectsComboBox.FormattingEnabled = true;
            this.allSubjectsComboBox.Location = new System.Drawing.Point(5, 155);
            this.allSubjectsComboBox.MaxDropDownItems = 15;
            this.allSubjectsComboBox.Name = "allSubjectsComboBox";
            this.allSubjectsComboBox.Size = new System.Drawing.Size(128, 21);
            this.allSubjectsComboBox.TabIndex = 34;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 139);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "Pridėti  pasirinktą dalyką";
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 569);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AdministrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button editTeacherButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private SchoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private SchoolDBDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox teacherSurnameTextBox;
        private System.Windows.Forms.TextBox teacherPhoneNumbTextBox;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacherQualificationTextBox;
        private System.Windows.Forms.TextBox teacherEducationTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox teacherSubjectsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox editTeacherQualificationTextBox;
        private System.Windows.Forms.TextBox editTeacherEducationTextBox;
        private System.Windows.Forms.TextBox editTeacherSurnamTextBox;
        private System.Windows.Forms.TextBox editTeacherPhoneNumbTextBox;
        private System.Windows.Forms.TextBox editTeacherNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox editTeacherTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox subjectsComboBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private SchoolDBDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.Button updateSubjectButton;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.Button deleteSubjectButton;
        private System.Windows.Forms.Button saveSubjectChangesButton;
        private System.Windows.Forms.DataGridView subjectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.DataGridView classDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label qualificationErrorLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox allSubjectsComboBox;
    }
}