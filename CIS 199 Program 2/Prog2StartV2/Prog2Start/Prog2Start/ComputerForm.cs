using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Matt Lancaster Student ID: 5372259 Sect: 75
//Unable to finish the rest of the program.
//I completed making all of the forms and adding the validations for all text boxes.
//Each form has validation created and then that is applied to all textboxes or comboboxes in the form.
namespace Prog2Start
{
    public partial class computerViewForm : Form
    {
        public computerViewForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Student ID: 5372259 Class: CIS 200-75-4238";

            MessageBox.Show(message);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void laptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaptopForm laptopForm = new LaptopForm();

            laptopForm.ShowDialog();

        }

        private void allInOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllinOneForm allinOneForm = new AllinOneForm();
            allinOneForm.ShowDialog();
        }

        private void towerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TowerForm towerForm = new TowerForm();
            towerForm.ShowDialog();
        }


    }
      
}

