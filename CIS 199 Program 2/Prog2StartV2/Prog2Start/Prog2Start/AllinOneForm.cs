using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Start
{
    public partial class AllinOneForm : Form
    {
        public AllinOneForm()
        {
            InitializeComponent();
        }
        //This is the validation for the AllInOneForm, if the entered amount is not larger than 1 letter it will show the error below.
        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 1)
            {
                errorProvider1.SetError(((TextBox)sender), "");
            }

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length > 1)
            {
                //Do Nothing
            }
            else
            {
                errorProvider1.SetError(((TextBox)sender), "");
            }
        }
        //This closes the form once the create button is pressed.
        private void AllInOneFormButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                DialogResult = DialogResult.OK;
                Hide();
            }
        }
    }
}
