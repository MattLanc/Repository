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
    public partial class LaptopForm : Form
    {
        public LaptopForm()
        {
            InitializeComponent();
        }

        private void LaptopManufacturerInput_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 1)
            {
                errorProvider1.SetError(((TextBox)sender), "");
            }
        }
        //This is the validation for the Laptop Form, if the entered amount is not larger than 1 letter then the error is shown below
        private void LaptopManufacturerInput_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length > 1)
            {
                //do nothing
            }
            else
            {
                errorProvider1.SetError(((TextBox)sender), "Enter valid Input");
                e.Cancel = true;
            }
        }
        //This takes the input from the form and then closes the form once the create button is pressed.
        private void LaptopCreateButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }
    }
}
