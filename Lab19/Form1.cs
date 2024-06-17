using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;
            string resultText = RemoveExtraSpaces(inputText);
            lblResult.Text = resultText;
        }

        private string RemoveExtraSpaces(string input)
        {
            return string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
