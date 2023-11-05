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

namespace Class_GUI_Launch
{
    public partial class InputForm : Form
    {
        public InputForm(string textToDisplay)
        {
            InitializeComponent();
            inputTextBox.Text = textToDisplay;
        }
        public InputForm()
        {
            InitializeComponent();
        }

        private void completionButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                DialogResult = DialogResult.OK;
                Hide();
            }



        }

        private void stringTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length > 10)
            {
                //do not do anything
            }
            else
            {
                inputErrorProvider.SetError(((TextBox)sender), "At least ten characters expected.");
                e.Cancel = true;
            }
        }

        private void stringTextBox_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 10)
            {
                inputErrorProvider.SetError(((TextBox)sender), "");

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        public string UserText
        {
            get
            {
                return inputTextBox.Text;
            }
        }
    }
}
