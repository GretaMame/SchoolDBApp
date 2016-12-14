using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Text.RegularExpressions;

namespace DatabaseApplication
{
    public partial class AdministrationForm : Form
    {
        private bool validID;
        List<String> qualifications;
        private Regex numberRegex = new Regex("[0-9]");
        public AdministrationForm()
        {
            InitializeComponent();
            addTeacherButton.Enabled = false;
            LoadSubjects(subjectsComboBox);
            qualifications = new List<String>{ "Mokytojas", "Vyresnysis mokytojas", "Metodininkas", "Ekspertas"};
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.schoolDBDataSet.Subject);
            this.classTableAdapter.Fill(this.schoolDBDataSet.Class);
        }


        #region Teacher
        //DAR REIKIA PADARYT DATA VALIDATION IR KAD BUTTONO NEGALIMA BUTU CLICKINT JEI NEIVESTAS TEKSTAS
        //gal dar idet ta ratuka kad suktus jei keicia
        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            using (SchoolDBEntities school = new SchoolDBEntities())
            {
                Teacher teacher = new Teacher();
                teacher.Id = Int32.Parse(idTextBox.Text);
                teacher.Name = teacherNameTextBox.Text;
                teacher.Surname = teacherSurnameTextBox.Text;
                teacher.Phone_number = teacherPhoneNumbTextBox.Text;
                teacher.Education = teacherEducationTextBox.Text;
                teacher.Qualification = teacherQualificationTextBox.Text;
                school.Teachers.Add(teacher);
                if (updateDB(school))
                {
                    MessageBox.Show("Mokytojas pridėtas sėkmingai!");
                    clearTextBoxes();
                }
                if (subjectsComboBox.SelectedIndex > -1)
                {
                    addSubject(teacher, subjectsComboBox.SelectedItem.ToString());
                }
            }
        }

        private void addSubject(Teacher teacher, string subjectName)
        {
            using (SchoolDBEntities school = new SchoolDBEntities())
            {
                try
                {
                    Subject subject = school.Subjects.First(s => s.Name == subjectName);
                    subject.Teachers.Add(teacher);
                    school.SaveChanges();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.InnerException.ToString(), "error");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "error");
                }
            }

        }

        private void clearTextBoxes()
        {
            idTextBox.Text = "";
            teacherNameTextBox.Text = "";
            teacherSurnameTextBox.Text = "";
            teacherPhoneNumbTextBox.Text = "";
            teacherEducationTextBox.Text = "";
            teacherQualificationTextBox.Text = "";
        }

        private void LoadSubjects(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            using (SchoolDBEntities school = new SchoolDBEntities())
            {
                var subjects = school.Subjects;
                foreach(Subject s in subjects)
                {
                    comboBox.Items.Add(s.Name);
                }
                
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            using (SchoolDBEntities school = new SchoolDBEntities())
            {
                int id = 0;
                if (idTextBox.Text != "" && numberRegex.IsMatch(idTextBox.Text))
                {
                    id = Int32.Parse(idTextBox.Text);
                }
                if (!school.Teachers.Any(r => r.Id == id))
                {
                    addTeacherButton.Enabled = true;
                    ErrorLabel.Visible = false;
                }
                else
                {
                    ErrorLabel.Visible = true;
                    addTeacherButton.Enabled = false;
                }
            }
        }

        private void teacherQualificationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (qualifications.Any(s => s.Contains(teacherQualificationTextBox.Text)))
            {
                addTeacherButton.Enabled = true;
                qualificationErrorLabel.Visible = false;
            }
            else
            {
                addTeacherButton.Enabled = false;
                qualificationErrorLabel.Visible = true;
            }
        }

        #endregion

        #region Subject
        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            using (SchoolDBEntities school = new SchoolDBEntities())
            {
                Subject subject = new Subject();
                subject.Id = Int32.Parse(getPromptDialogIput("Įveskite dalyko nr.:"));
                subject.Name = getPromptDialogIput("Įveskite dalyko pavadinimą:");
                school.Subjects.Add(subject);
                if (updateDB(school)) MessageBox.Show("Dalykas pridėtas sėkmingai!");
                refreshSubject();
            }
        }

        private void updateSubjectButton_Click(object sender, EventArgs e)
        {
            subjectsDataGridView.ReadOnly = false;
            MessageBox.Show("Pakeiskite norimus duomenis");
        }

        private void saveSubjectChangesButton_Click_1(object sender, EventArgs e)
        {
            subjectsDataGridView.ReadOnly = true;
            subjectTableAdapter.Update(schoolDBDataSet.Subject);
            MessageBox.Show("Pakeitimai iššsaugoti");
            refreshSubject();
        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {
            if (subjectsDataGridView.SelectedRows.Count > 0)
            {
                subjectsDataGridView.Rows.Remove(subjectsDataGridView.SelectedRows[0]);
                subjectTableAdapter.Update(schoolDBDataSet.Subject);
                MessageBox.Show("Duomenys sėkmingai ištrinti");
                refreshSubject();
            }
            else
            {
                MessageBox.Show("Nepasirinkote jokių duomenų!");
            }
        }

        private void refreshSubject()
        {
            this.subjectTableAdapter.Fill(schoolDBDataSet.Subject);
            LoadSubjects(subjectsComboBox);
        }
        #endregion

        #region Class

        private void addClassButton_Click(object sender, EventArgs e)
        {
            using (SchoolDBEntities school = new SchoolDBEntities())
            {
                Class newClass = new Class();
                newClass.Name = getPromptDialogIput("Įveskite klasės pavadinimą:");
                newClass.Tutor = Int32.Parse(getPromptDialogIput("Įveskite mokytojo numerį:"));
                school.Classes.Add(newClass);
                if (updateDB(school)) MessageBox.Show("Klasė pridėta sėkmingai!");
                refreshSubject();
                classDataGridView.Update();
            }
        }

        private void refreshClass()
        {
            this.classTableAdapter.Fill(this.schoolDBDataSet.Class);
        }
        #endregion

        #region Prompts
        private string getPromptDialogIput(string instructions)
        {
            PromptDialog dialog = new PromptDialog(instructions);
            dialog.ShowDialog();
            return dialog.getInput();
        }

        private string getPromptDialogIput(string instructions, string textBox)
        {
            PromptDialog dialog = new PromptDialog(instructions);
            dialog.inputTextBox.Text = textBox;
            dialog.ShowDialog();
            return dialog.getInput();
        }
        #endregion

        private bool updateDB(SchoolDBEntities school)
        {
            try
            {
                school.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "Error");
                return false;
            }
        }

        #region Edit Teacher

        private void editTeacherButton_Click(object sender, EventArgs e)
        {
            using (SchoolDBEntities school = new SchoolDBEntities())
            {
                int id = Int32.Parse(editTeacherTextBox.Text);
                Teacher teacher = school.Teachers.FirstOrDefault(t => t.Id == id);
                removeSubject(teacher);
                if (allSubjectsComboBox.SelectedIndex > -1)
                {
                    addSubject(teacher, allSubjectsComboBox.SelectedItem.ToString());
                }
                teacher.Name = editTeacherNameTextBox.Text;
                teacher.Surname = editTeacherSurnamTextBox.Text;
                teacher.Phone_number = editTeacherPhoneNumbTextBox.Text;
                teacher.Education = editTeacherEducationTextBox.Text;
                teacher.Qualification = editTeacherQualificationTextBox.Text;
                if (updateDB(school))
                {
                    
                    MessageBox.Show("Mokytojo duomenys sėkmnigai pakeisti");
                }
                clearChangeTeacherTextBoxes();
            }

        }

        private void removeSubject(Teacher teacher)
        {
            using (SchoolDBEntities school = new SchoolDBEntities())
            {
                if (teacherSubjectsComboBox.SelectedIndex > -1)
                {
                    foreach(Subject s in teacher.Subjects)
                    {
                        if (s.Name.Equals(teacherSubjectsComboBox.SelectedItem.ToString()))
                        {
                            teacher.Subjects.Remove(s);
                            break;
                        }
                    }
                }
            }
        }

        private void editTeacherTextBox_TextChanged(object sender, EventArgs e)
        {
            clearChangeTeacherTextBoxes();
            if (numberRegex.IsMatch(editTeacherTextBox.Text))
            {
                using (SchoolDBEntities school = new SchoolDBEntities())
                {
                    int id = Int32.Parse(editTeacherTextBox.Text);
                    if (school.Teachers.Any(t => t.Id == id))
                    {
                        Teacher teacher = school.Teachers.FirstOrDefault(t => t.Id == id);
                        editTeacherNameTextBox.Text = teacher.Name;
                        editTeacherSurnamTextBox.Text = teacher.Surname;
                        editTeacherPhoneNumbTextBox.Text = teacher.Phone_number;
                        editTeacherEducationTextBox.Text = teacher.Education;
                        editTeacherQualificationTextBox.Text = teacher.Qualification;
                        editTeacherButton.Enabled = true;
                        getTeacherSubjects(teacher);
                        LoadSubjects(allSubjectsComboBox);
                    }
                    else
                    {
                        editTeacherButton.Enabled = false;
                    }
                }
            }
        }

        private void getTeacherSubjects(Teacher teacher)
        {
            if (teacher.Subjects.Count != 0)
            {
                LoadTeacherSubjects(teacher);
            }
            else
            {
                teacherSubjectsComboBox.Items.Add("-");
            }
        }

        private void clearChangeTeacherTextBoxes()
        {
            editTeacherNameTextBox.Text = "";
            editTeacherSurnamTextBox.Text = "";
            editTeacherPhoneNumbTextBox.Text = "";
            editTeacherEducationTextBox.Text = "";
            editTeacherQualificationTextBox.Text = "";
            teacherSubjectsComboBox.Items.Clear();
        }

        private void LoadTeacherSubjects(Teacher teacher)
        {
            teacherSubjectsComboBox.Items.Clear();
            using (SchoolDBEntities school = new SchoolDBEntities())
            {
                var subjects = teacher.Subjects;
                foreach (Subject s in subjects)
                {
                    teacherSubjectsComboBox.Items.Add(s.Name);
                }

            }
        }
    }
    #endregion
}
