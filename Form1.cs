// Grading ID: S5027
// Lab Number: Lab 3
// Due Date: 9/26/2021
// Course Section: CIS 199-50
// Description: This program takes the radius that is input by the user and calculates the diameter, surface area, and volume of a sphere.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        // Calculate and Display Diameter, Surface Area, and Volume
        private void CalculateButton_Click(object sender, EventArgs e)
        {
             // Radius of Sphere that is input by the user
            double diameter;
            double surfacearea;
            double volume;
            double PI = Math.PI;
            
            double radius = double.Parse(SphereTxt.Text); // Takes input from user and converts it into decimal

            // Calculate our Diameter, Surface Area, and Volume
            diameter = 2 * radius;
            surfacearea = 4 * PI * (Math.Pow(radius, 2));
            volume = (4 * PI * (Math.Pow(radius, 3))) / 3;

            // Display Each Variable

            DiameterOutputLbl.Text = $"{diameter:F2}";
            SurfaceOutputLbl.Text = $"{surfacearea:F2}";
            VolumeOutputLbl.Text = $"{volume:F2}";
        }
    }
}
