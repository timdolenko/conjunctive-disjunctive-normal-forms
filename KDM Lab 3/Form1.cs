using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDM_Lab_3
{
    public partial class InputScreen : Form
    {
        public InputScreen()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Back:
                    inputLbl.Text = inputLbl.Text.Length > 0 ? inputLbl.Text.Substring(0, inputLbl.Text.Length - 1) : "";
                    break;
                case Keys.Delete:
                    inputLbl.Text = "";
                    break;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tag = Convert.ToInt32((sender as Button).Tag);
            //! ν ^ = →
            switch (tag)
            {
                case 11:
                    inputLbl.Text += "A";
                    break;
                case 12:
                    inputLbl.Text += "B";
                    break;
                case 13:
                    inputLbl.Text += "C";
                    break;
                case 21:
                    inputLbl.Text += "!";
                    break;
                case 22:
                    inputLbl.Text += "ν";
                    break;
                case 23:
                    inputLbl.Text += "^";
                    break;
                case 24:
                    inputLbl.Text += "~";
                    break;
                case 25:
                    inputLbl.Text += "→";
                    break;
                case 31:
                    inputLbl.Text += "(";
                    break;
                case 32:
                    inputLbl.Text += ")";
                    break;
                default:
                    break;
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            Formula formula = new Formula(inputLbl.Text);
            ResultsScreen rs = new ResultsScreen(formula);
            rs.Show();
        }
    }
}
