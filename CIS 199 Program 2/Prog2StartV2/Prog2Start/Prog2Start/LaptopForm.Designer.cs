namespace Prog2Start
{
    partial class LaptopForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LaptopManufacturerInput = new System.Windows.Forms.TextBox();
            this.LaptopModelInput = new System.Windows.Forms.TextBox();
            this.LaptopFixedTDPInput = new System.Windows.Forms.TextBox();
            this.LaptopCPUManufacturerInput = new System.Windows.Forms.TextBox();
            this.LaptopCPUModelInput = new System.Windows.Forms.TextBox();
            this.LaptopCPUClockSpeedInput = new System.Windows.Forms.TextBox();
            this.LaptopCPUSocketInput = new System.Windows.Forms.TextBox();
            this.LaptopCPUPowerDrawInput = new System.Windows.Forms.TextBox();
            this.LaptopCreateButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laptop Manufactuer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Laptop Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fixed TDP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPU Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manufacturer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Socket:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Clock Speed:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Power Draw:";
            // 
            // LaptopManufacturerInput
            // 
            this.LaptopManufacturerInput.Location = new System.Drawing.Point(109, 24);
            this.LaptopManufacturerInput.Name = "LaptopManufacturerInput";
            this.LaptopManufacturerInput.Size = new System.Drawing.Size(100, 20);
            this.LaptopManufacturerInput.TabIndex = 9;
            this.LaptopManufacturerInput.Validating += new System.ComponentModel.CancelEventHandler(this.LaptopManufacturerInput_Validating);
            this.LaptopManufacturerInput.Validated += new System.EventHandler(this.LaptopManufacturerInput_Validated);
            // 
            // LaptopModelInput
            // 
            this.LaptopModelInput.Location = new System.Drawing.Point(109, 55);
            this.LaptopModelInput.Name = "LaptopModelInput";
            this.LaptopModelInput.Size = new System.Drawing.Size(100, 20);
            this.LaptopModelInput.TabIndex = 10;
            this.LaptopModelInput.Validating += new System.ComponentModel.CancelEventHandler(this.LaptopManufacturerInput_Validating);
            this.LaptopModelInput.Validated += new System.EventHandler(this.LaptopManufacturerInput_Validated);
            // 
            // LaptopFixedTDPInput
            // 
            this.LaptopFixedTDPInput.Location = new System.Drawing.Point(109, 89);
            this.LaptopFixedTDPInput.Name = "LaptopFixedTDPInput";
            this.LaptopFixedTDPInput.Size = new System.Drawing.Size(100, 20);
            this.LaptopFixedTDPInput.TabIndex = 11;
            this.LaptopFixedTDPInput.Validating += new System.ComponentModel.CancelEventHandler(this.LaptopManufacturerInput_Validating);
            this.LaptopFixedTDPInput.Validated += new System.EventHandler(this.LaptopManufacturerInput_Validated);
            // 
            // LaptopCPUManufacturerInput
            // 
            this.LaptopCPUManufacturerInput.Location = new System.Drawing.Point(109, 224);
            this.LaptopCPUManufacturerInput.Name = "LaptopCPUManufacturerInput";
            this.LaptopCPUManufacturerInput.Size = new System.Drawing.Size(100, 20);
            this.LaptopCPUManufacturerInput.TabIndex = 12;
            this.LaptopCPUManufacturerInput.Validating += new System.ComponentModel.CancelEventHandler(this.LaptopManufacturerInput_Validating);
            this.LaptopCPUManufacturerInput.Validated += new System.EventHandler(this.LaptopManufacturerInput_Validated);
            // 
            // LaptopCPUModelInput
            // 
            this.LaptopCPUModelInput.Location = new System.Drawing.Point(109, 256);
            this.LaptopCPUModelInput.Name = "LaptopCPUModelInput";
            this.LaptopCPUModelInput.Size = new System.Drawing.Size(100, 20);
            this.LaptopCPUModelInput.TabIndex = 13;
            this.LaptopCPUModelInput.Validating += new System.ComponentModel.CancelEventHandler(this.LaptopManufacturerInput_Validating);
            this.LaptopCPUModelInput.Validated += new System.EventHandler(this.LaptopManufacturerInput_Validated);
            // 
            // LaptopCPUClockSpeedInput
            // 
            this.LaptopCPUClockSpeedInput.Location = new System.Drawing.Point(109, 286);
            this.LaptopCPUClockSpeedInput.Name = "LaptopCPUClockSpeedInput";
            this.LaptopCPUClockSpeedInput.Size = new System.Drawing.Size(100, 20);
            this.LaptopCPUClockSpeedInput.TabIndex = 14;
            this.LaptopCPUClockSpeedInput.Validating += new System.ComponentModel.CancelEventHandler(this.LaptopManufacturerInput_Validating);
            this.LaptopCPUClockSpeedInput.Validated += new System.EventHandler(this.LaptopManufacturerInput_Validated);
            // 
            // LaptopCPUSocketInput
            // 
            this.LaptopCPUSocketInput.Location = new System.Drawing.Point(109, 315);
            this.LaptopCPUSocketInput.Name = "LaptopCPUSocketInput";
            this.LaptopCPUSocketInput.Size = new System.Drawing.Size(100, 20);
            this.LaptopCPUSocketInput.TabIndex = 15;
            this.LaptopCPUSocketInput.Validating += new System.ComponentModel.CancelEventHandler(this.LaptopManufacturerInput_Validating);
            this.LaptopCPUSocketInput.Validated += new System.EventHandler(this.LaptopManufacturerInput_Validated);
            // 
            // LaptopCPUPowerDrawInput
            // 
            this.LaptopCPUPowerDrawInput.Location = new System.Drawing.Point(109, 343);
            this.LaptopCPUPowerDrawInput.Name = "LaptopCPUPowerDrawInput";
            this.LaptopCPUPowerDrawInput.Size = new System.Drawing.Size(100, 20);
            this.LaptopCPUPowerDrawInput.TabIndex = 16;
            this.LaptopCPUPowerDrawInput.Validating += new System.ComponentModel.CancelEventHandler(this.LaptopManufacturerInput_Validating);
            this.LaptopCPUPowerDrawInput.Validated += new System.EventHandler(this.LaptopManufacturerInput_Validated);
            // 
            // LaptopCreateButton
            // 
            this.LaptopCreateButton.Location = new System.Drawing.Point(87, 398);
            this.LaptopCreateButton.Name = "LaptopCreateButton";
            this.LaptopCreateButton.Size = new System.Drawing.Size(75, 23);
            this.LaptopCreateButton.TabIndex = 17;
            this.LaptopCreateButton.Text = "Create";
            this.LaptopCreateButton.UseVisualStyleBackColor = true;
            this.LaptopCreateButton.Click += new System.EventHandler(this.LaptopCreateButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LaptopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 453);
            this.Controls.Add(this.LaptopCreateButton);
            this.Controls.Add(this.LaptopCPUPowerDrawInput);
            this.Controls.Add(this.LaptopCPUSocketInput);
            this.Controls.Add(this.LaptopCPUClockSpeedInput);
            this.Controls.Add(this.LaptopCPUModelInput);
            this.Controls.Add(this.LaptopCPUManufacturerInput);
            this.Controls.Add(this.LaptopFixedTDPInput);
            this.Controls.Add(this.LaptopModelInput);
            this.Controls.Add(this.LaptopManufacturerInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LaptopForm";
            this.Text = "Laptop Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LaptopManufacturerInput;
        private System.Windows.Forms.TextBox LaptopModelInput;
        private System.Windows.Forms.TextBox LaptopFixedTDPInput;
        private System.Windows.Forms.TextBox LaptopCPUManufacturerInput;
        private System.Windows.Forms.TextBox LaptopCPUModelInput;
        private System.Windows.Forms.TextBox LaptopCPUClockSpeedInput;
        private System.Windows.Forms.TextBox LaptopCPUSocketInput;
        private System.Windows.Forms.TextBox LaptopCPUPowerDrawInput;
        private System.Windows.Forms.Button LaptopCreateButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}