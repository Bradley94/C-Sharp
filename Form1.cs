using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // creating a separate function and calling it within the click function
        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }

        // for use with above function
        private void convertFromFahrenheit()
        {
            float f = 0; 

            try
            {
                f = float.Parse(txt_fahrenheit.Text); // parse converts string representation to number
                float c = 5f / 9 * (f - 32); // only one needs to be made f for correct values to work
                float k = c + 273.15f; 

                // put the result into the relevant text boxes
                txt_celsius.Text = c.ToString();
                txt_kelvin.Text = k.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Try only numbers");
            }
        }

        // last two just writing them within the click function to show different approach
        private void btn_celsius_Click(object sender, EventArgs e)
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_celsius.Text);
                float f = c * (9f / 5) + 32;
                float k = c + 273.15f;

                txt_fahrenheit.Text = f.ToString();
                txt_kelvin.Text = k.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Try only numbers");
            }     
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_kelvin.Text);
                float f = ((k - 273.15f) * 9/5 + 32);
                float c = k - 273.15f;

                txt_fahrenheit.Text = f.ToString();
                txt_celsius.Text = c.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Try only numbers");
            }     
        }

        // when filling in text it will auto complete without the need to click convert
        // doing this just for Fahrenheit again to show different approaches
        private void onTextChange(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }
    }
}
