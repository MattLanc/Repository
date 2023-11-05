using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Class_GUI_Launch
{
    public partial class EntryPointForm : Form
    {
        public EntryPointForm()
        {
            InitializeComponent();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            InputForm entryForm = new InputForm(outputTextBox.Text);
            //entryForm.ShowDialog();

            //if (entryForm.DialogResult == DialogResult.OK)
            //{
            //    string theText = entryForm.UserText;
            //    outputTextBox.Text = theText;
            //}
            //else if(entryForm.DialogResult == DialogResult.Cancel) 
            //{
            //    MessageBox.Show("Input operation was cancelled");
            //}

            if (entryForm.ShowDialog() == DialogResult.OK)
            {
                string theText = entryForm.UserText;
                outputTextBox.Text = theText;
            }
            else
            {
                MessageBox.Show("Input operation was cancelled");
            }


            entryForm.Dispose();




        }

        private void saveAction(object sender, EventArgs e)
        {
            string filePath;

            using (SaveFileDialog userSelection = new SaveFileDialog())
            {

                DialogResult outputType = userSelection.ShowDialog();

                if (outputType == DialogResult.OK)
                {
                    filePath = userSelection.FileName;

                    File.WriteAllText(filePath, outputTextBox.Text);
                }


            } //after using is done, file dialogue deallocates. 
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string filePath;

            using (OpenFileDialog userSelection = new OpenFileDialog())
            {
                userSelection.InitialDirectory = "c:\\";
                userSelection.Title = "Select a text file";
                userSelection.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|(*.*)";
                userSelection.FilterIndex = 1;

                DialogResult outputType = userSelection.ShowDialog();

                if (outputType == DialogResult.OK)
                {
                    filePath = userSelection.FileName;

                    string filecontent = File.ReadAllText(filePath);

                    outputTextBox.Text = filecontent;
                }


            } //after using is done, file dialogue deallocates. 
        }
    }
}