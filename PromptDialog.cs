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
    public partial class PromptDialog : Form
    {
        public PromptDialog()
        {
            InitializeComponent();
        }

        public PromptDialog(string instructions)
        {
            InitializeComponent();
            setInstructions(instructions);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setInstructions(string instructions)
        {
            instructionsLabel.Text = instructions;
        }

        public string getInput()
        {
            return inputTextBox.Text;
        }
    }
}
