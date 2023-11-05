namespace Lab3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.SphereTxt = new System.Windows.Forms.TextBox();
            this.DiameterLabel = new System.Windows.Forms.Label();
            this.DiameterOutputLabel = new System.Windows.Forms.Label();
            this.SurfaceOutputLabel = new System.Windows.Forms.Label();
            this.VolumeOutputLabel = new System.Windows.Forms.Label();
            this.SphereDiagramOne = new System.Windows.Forms.PictureBox();
            this.SphereDiagramTwo = new System.Windows.Forms.PictureBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DiameterOutputLbl = new System.Windows.Forms.Label();
            this.SurfaceOutputLbl = new System.Windows.Forms.Label();
            this.VolumeOutputLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SphereDiagramOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereDiagramTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(163, 71);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(90, 13);
            this.RadiusLabel.TabIndex = 0;
            this.RadiusLabel.Text = "Radius of sphere:";
            // 
            // SphereTxt
            // 
            this.SphereTxt.Location = new System.Drawing.Point(259, 64);
            this.SphereTxt.Name = "SphereTxt";
            this.SphereTxt.Size = new System.Drawing.Size(100, 20);
            this.SphereTxt.TabIndex = 1;
            // 
            // DiameterLabel
            // 
            this.DiameterLabel.AutoSize = true;
            this.DiameterLabel.Location = new System.Drawing.Point(25, 217);
            this.DiameterLabel.Name = "DiameterLabel";
            this.DiameterLabel.Size = new System.Drawing.Size(49, 13);
            this.DiameterLabel.TabIndex = 2;
            this.DiameterLabel.Text = "Diameter";
            // 
            // DiameterOutputLabel
            // 
            this.DiameterOutputLabel.AutoSize = true;
            this.DiameterOutputLabel.Location = new System.Drawing.Point(96, 217);
            this.DiameterOutputLabel.Name = "DiameterOutputLabel";
            this.DiameterOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.DiameterOutputLabel.TabIndex = 3;
            // 
            // SurfaceOutputLabel
            // 
            this.SurfaceOutputLabel.AutoSize = true;
            this.SurfaceOutputLabel.Location = new System.Drawing.Point(5, 248);
            this.SurfaceOutputLabel.Name = "SurfaceOutputLabel";
            this.SurfaceOutputLabel.Size = new System.Drawing.Size(69, 13);
            this.SurfaceOutputLabel.TabIndex = 4;
            this.SurfaceOutputLabel.Text = "Surface Area";
            // 
            // VolumeOutputLabel
            // 
            this.VolumeOutputLabel.AutoSize = true;
            this.VolumeOutputLabel.Location = new System.Drawing.Point(32, 285);
            this.VolumeOutputLabel.Name = "VolumeOutputLabel";
            this.VolumeOutputLabel.Size = new System.Drawing.Size(42, 13);
            this.VolumeOutputLabel.TabIndex = 5;
            this.VolumeOutputLabel.Text = "Volume";
            // 
            // SphereDiagramOne
            // 
            this.SphereDiagramOne.Image = ((System.Drawing.Image)(resources.GetObject("SphereDiagramOne.Image")));
            this.SphereDiagramOne.Location = new System.Drawing.Point(12, 12);
            this.SphereDiagramOne.Name = "SphereDiagramOne";
            this.SphereDiagramOne.Size = new System.Drawing.Size(150, 150);
            this.SphereDiagramOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SphereDiagramOne.TabIndex = 6;
            this.SphereDiagramOne.TabStop = false;
            // 
            // SphereDiagramTwo
            // 
            this.SphereDiagramTwo.Image = ((System.Drawing.Image)(resources.GetObject("SphereDiagramTwo.Image")));
            this.SphereDiagramTwo.Location = new System.Drawing.Point(209, 188);
            this.SphereDiagramTwo.Name = "SphereDiagramTwo";
            this.SphereDiagramTwo.Size = new System.Drawing.Size(150, 150);
            this.SphereDiagramTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SphereDiagramTwo.TabIndex = 7;
            this.SphereDiagramTwo.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(272, 105);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DiameterOutputLbl
            // 
            this.DiameterOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiameterOutputLbl.Location = new System.Drawing.Point(80, 216);
            this.DiameterOutputLbl.Name = "DiameterOutputLbl";
            this.DiameterOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.DiameterOutputLbl.TabIndex = 9;
            // 
            // SurfaceOutputLbl
            // 
            this.SurfaceOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurfaceOutputLbl.Location = new System.Drawing.Point(80, 248);
            this.SurfaceOutputLbl.Name = "SurfaceOutputLbl";
            this.SurfaceOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.SurfaceOutputLbl.TabIndex = 10;
            // 
            // VolumeOutputLbl
            // 
            this.VolumeOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VolumeOutputLbl.Location = new System.Drawing.Point(80, 285);
            this.VolumeOutputLbl.Name = "VolumeOutputLbl";
            this.VolumeOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.VolumeOutputLbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.VolumeOutputLbl);
            this.Controls.Add(this.SurfaceOutputLbl);
            this.Controls.Add(this.DiameterOutputLbl);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SphereDiagramTwo);
            this.Controls.Add(this.SphereDiagramOne);
            this.Controls.Add(this.VolumeOutputLabel);
            this.Controls.Add(this.SurfaceOutputLabel);
            this.Controls.Add(this.DiameterOutputLabel);
            this.Controls.Add(this.DiameterLabel);
            this.Controls.Add(this.SphereTxt);
            this.Controls.Add(this.RadiusLabel);
            this.Name = "Form1";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.SphereDiagramOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereDiagramTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox SphereTxt;
        private System.Windows.Forms.Label DiameterLabel;
        private System.Windows.Forms.Label DiameterOutputLabel;
        private System.Windows.Forms.Label SurfaceOutputLabel;
        private System.Windows.Forms.Label VolumeOutputLabel;
        private System.Windows.Forms.PictureBox SphereDiagramOne;
        private System.Windows.Forms.PictureBox SphereDiagramTwo;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label DiameterOutputLbl;
        private System.Windows.Forms.Label SurfaceOutputLbl;
        private System.Windows.Forms.Label VolumeOutputLbl;
    }
}

