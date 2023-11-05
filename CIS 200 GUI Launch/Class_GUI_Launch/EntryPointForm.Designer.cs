namespace Class_GUI_Launch
{
    partial class EntryPointForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            launchButton = new Button();
            outputTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            sAveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // launchButton
            // 
            launchButton.Location = new Point(147, 286);
            launchButton.Name = "launchButton";
            launchButton.Size = new Size(106, 50);
            launchButton.TabIndex = 0;
            launchButton.Text = "Launch Editor";
            launchButton.UseVisualStyleBackColor = true;
            launchButton.Click += launchButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(31, 24);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(365, 235);
            outputTextBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sAveToolStripMenuItem, loadToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(435, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // sAveToolStripMenuItem
            // 
            sAveToolStripMenuItem.Name = "sAveToolStripMenuItem";
            sAveToolStripMenuItem.Size = new Size(43, 20);
            sAveToolStripMenuItem.Text = "Save";
            sAveToolStripMenuItem.Click += saveAction;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(45, 20);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // EntryPointForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 371);
            Controls.Add(outputTextBox);
            Controls.Add(launchButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EntryPointForm";
            Text = "Entry Form Text Display";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button launchButton;
        private TextBox outputTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sAveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}