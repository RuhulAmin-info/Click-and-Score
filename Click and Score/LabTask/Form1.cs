using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask
{
    public partial class Form1 : Form
    {
         Timer t;
        public Form1()
        {
            InitializeComponent();
            t = new Timer();
            t.Interval = 1100;
            t.Tick += T_Tick;
            t.Enabled = true;

        }


        
        private void T_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
           int x = rd.Next(1, 10);
           

            if (x == 1)

            { 
               button1.BackColor = Color.Green;
               button2.BackColor = default;
               button3.BackColor = default;
               button4.BackColor = default;
               button5.BackColor = default;
               button6.BackColor = default;
               button7.BackColor = default;
               button8.BackColor = default;
               ButtonN.BackColor = default;
               button10.BackColor = default;
            }
            else if(x==2)
            {
               button2.BackColor = Color.Green;
               button1.BackColor = default;
               button3.BackColor = default;
               button4.BackColor = default;
               button5.BackColor = default;
               button6.BackColor = default;
               button7.BackColor = default;
               button8.BackColor = default;
               ButtonN.BackColor = default;
               button10.BackColor = default;
            }
           else if (x == 3)
           {
               button3.BackColor = Color.Green;
               button1.BackColor = default;
               button2.BackColor = default;
               button4.BackColor = default;
               button5.BackColor = default;
               button6.BackColor = default;
               button7.BackColor = default;
               button8.BackColor = default; 
               ButtonN.BackColor = default;
               button10.BackColor = default;
            }
           else if (x == 4)
           {
               button4.BackColor = Color.Green;
               button2.BackColor = default;
               button3.BackColor = default;
               button1.BackColor = default;
               button5.BackColor = default;
               button6.BackColor = default;
               button7.BackColor = default;
               button8.BackColor = default;
               ButtonN.BackColor = default;
               button10.BackColor = default;
            }
           else if (x == 5)
           {
               button5.BackColor = Color.Green;
               button2.BackColor = default;
               button3.BackColor = default;
               button4.BackColor = default;
               button1.BackColor = default;
               button6.BackColor = default;
               button7.BackColor = default;
               button8.BackColor = default;
               ButtonN.BackColor = default;
               button10.BackColor = default;
            }
           else if (x == 6)
           {
               button6.BackColor = Color.Green;
               button2.BackColor = default;
               button3.BackColor = default;
               button4.BackColor = default;
               button5.BackColor = default;
               button1.BackColor = default;
               button7.BackColor = default;
               button8.BackColor = default;
               ButtonN.BackColor = default;
               button10.BackColor = default;
            }
            else if (x == 7)
            {
                button7.BackColor = Color.Green;
                button2.BackColor = default;
                button3.BackColor = default;
                button4.BackColor = default;
                button5.BackColor = default;
                button1.BackColor = default;
                button6.BackColor = default;
                button8.BackColor = default;
                ButtonN.BackColor = default;
                button10.BackColor = default;
            }
            else if (x == 8)
            {
                button8.BackColor = Color.Green;
                button2.BackColor = default;
                button3.BackColor = default;
                button4.BackColor = default;
                button5.BackColor = default;
                button1.BackColor = default;
                button7.BackColor = default;
                button6.BackColor = default;
                ButtonN.BackColor = default;
                button10.BackColor = default;
            }
            else if (x == 9)
            {
                ButtonN.BackColor = Color.Green;
                button2.BackColor = default;
                button3.BackColor = default;
                button4.BackColor = default;
                button5.BackColor = default;
                button1.BackColor = default;
                button7.BackColor = default;
                button6.BackColor = default;
                button8.BackColor = default;
                button10.BackColor = default;

            }
            else if (x == 10)
            {
                button10.BackColor = Color.Green;
                button2.BackColor = default;
                button3.BackColor = default;
                button4.BackColor = default;
                button5.BackColor = default;
                button1.BackColor = default;
                button7.BackColor = default;
                button6.BackColor = default;
                ButtonN.BackColor = default;
                button8.BackColor = default;
            }

        }

         int score = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            if (button.BackColor == Color.Green)
            {
                score += 1;
                scoreLabel.Text = score.ToString();
            }
            else
            {
                score -= 1;
                scoreLabel.Text = score.ToString();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
