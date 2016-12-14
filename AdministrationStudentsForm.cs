using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApplication
{
    public partial class AdministrationStudentsForm : Form
    {
        public AdministrationStudentsForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void AdministrationStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.schoolDBDataSet.Student);

        }
    }
}
