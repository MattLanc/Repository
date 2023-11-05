using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prog2Start
{
    public partial class TowerForm : Form
    {


        public TowerForm(string towerInfo)
        {
            InitializeComponent();
            TowerManufacturer.Text = towerInfo;

        }
        public TowerForm()
        {
            InitializeComponent();
        }
        //This will close the form when the create button is pressed.
        private void TowerFormCreateButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                DialogResult = DialogResult.OK;
                Hide();
            }

        }
        //This is the validation for all text boxes in the Tower Form, if less than 1 letter is entered it will show the error wrote below.
        private void TowerManufacturer_Validating(object sender, CancelEventArgs e)
        {
            if(((TextBox)sender).Text.Length > 1)
            {
                //do nothing
            }
            else
            {
                errorProvider1.SetError(((TextBox)sender), "Enter Valid Input");
            }
        }

        private void TowerManufacturer_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 1)
            {
                errorProvider1.SetError(((TextBox)sender), "");
            }
        }

        

    

  
    }
}  

