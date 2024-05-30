using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonToCsvConvertor
{
    public partial class Form1 : Form
    {

        private BusinessLogic businessLogic;

        public Form1()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
        }

        private async void RequestButtonClick(object sender, EventArgs e)
        {
            try
            {
                string userInput = textBox3.Text;
                businessLogic.CheckUserInput(userInput);
                string jsonResponse = await businessLogic.GetJsonAsync(userInput);
                textBox1.Text = jsonResponse;
            }
            catch (Exception ex)
            {
                DisplayInvalidInputMessage(ex.Message);
            }
        }

        private void DisplayInvalidInputMessage(string message)
        {
            MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConvertButtonClick(object sender, EventArgs e)
        {
            try
            {
                string csv = businessLogic.GetCsv(textBox1.Text);
                textBox2.Text = csv;
            }
            catch (Exception ex)
            {
                DisplayInvalidInputMessage(ex.Message);
            }
        }

        private void JsonTextBoxTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                button2.Visible = true;
                button2.Enabled = true;
                textBox2.Clear();
            }
        }

        private void CsvTextBoxTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox3.Focus();
                button2.Enabled = false;
            }
        }
    }
}
   
