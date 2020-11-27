using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGam
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        int answer;
        int number;

        public Form1()
        {
            InitializeComponent();

            answer = randGen.Next(1, 100);
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(numberInput.Text);
            if (number == answer)
            {
                outputLabel.Text = $"You Got It!";
            }
            else if (number > answer)
            {
                outputLabel.Text = $"Too High!";
            }
            else
            {
                outputLabel.Text = $"Too Low!!";
            }
        }
    }
}
