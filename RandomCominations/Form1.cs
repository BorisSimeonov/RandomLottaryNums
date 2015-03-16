using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCominations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainLabel_MouseEnter(object sender, EventArgs e)
        {
            mainLabel.BackColor = System.Drawing.Color.Orange;
            mainLabel.ForeColor = System.Drawing.Color.Black;
            
        }

        private void mainLabel_MouseLeave(object sender, EventArgs e)
        {
            mainLabel.BackColor = System.Drawing.Color.Black;
            mainLabel.ForeColor = System.Drawing.Color.Orange;
        }

        private void mainLabel_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox[] textBoxArray = { tbOne, tbTwo, tbThree, tbFour, tbFive, tbSix };
            Random rnd = new Random();
            List<int> winningNums = new List<int>();
            int currentNum;
            int index = 0;
            for (int cnt = 0; cnt <= 5; cnt++ )
            {
                currentNum = rnd.Next(1, 48);
                if (!winningNums.Contains(currentNum))
                {
                    textBoxArray[index].Text = currentNum.ToString();
                    winningNums.Add(currentNum);
                    index++;
                }
                else
                {
                    cnt--;
                }
            }
        }
    }
}
