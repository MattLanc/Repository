namespace Class_GUI_Launch
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            inputTextBox = new TextBox();
            completionButton = new Button();
            inputErrorProvider = new ErrorProvider(components);
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inputErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputTextBox.Location = new Point(12, 27);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.PlaceholderText = "Enter some characters here";
            inputTextBox.Size = new Size(331, 321);
            inputTextBox.TabIndex = 0;
            inputTextBox.Validating += stringTextBox_Validating;
            inputTextBox.Validated += stringTextBox_Validated;
            // 
            // completionButton
            // 
            completionButton.Anchor = AnchorStyles.Bottom;
            completionButton.Location = new Point(57, 354);
            completionButton.Name = "completionButton";
            completionButton.Size = new Size(123, 23);
            completionButton.TabIndex = 1;
            completionButton.Text = "I'm Finished";
            completionButton.UseVisualStyleBackColor = true;
            completionButton.Click += completionButton_Click;
            // 
            // inputErrorProvider
            // 
            inputErrorProvider.ContainerControl = this;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom;
            cancelButton.Location = new Point(186, 354);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(123, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Nevermind";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 389);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(completionButton);
            Controls.Add(inputTextBox);
            Name = "InputForm";
            Text = "InputForm";
            ((System.ComponentModel.ISupportInitialize)inputErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Button completionButton;
        private ErrorProvider inputErrorProvider;
        private Button cancelButton;
    }
}