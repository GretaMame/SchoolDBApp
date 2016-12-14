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
    public partial class AdministrationClassesForm : Form
    {
        public AdministrationClassesForm()
        {
            InitializeComponent();
        }

        private void AdministrationClassesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.schoolDBDataSet.Class);

        }
    }
}
