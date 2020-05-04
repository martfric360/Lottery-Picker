using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Picker
{
    public partial class Form1 : Form
    {
        Random ranGen = new Random(); 
        const int max = 50;
        int one, two, three, four, five, six; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            one = ranGen.Next(1, 50);
            two = ranGen.Next(1, 50);
            three = ranGen.Next(1, 50);
            four = ranGen.Next(1, 50);
            five = ranGen.Next(1, 50);
            six = ranGen.Next(1, 50);
            while (one == two)
            {
                two = ranGen.Next(1, 50);
            }
            while (one == three | three == two)
            {
                three = ranGen.Next(1, 50);
            }
            while (four == one | four == two | four == three)
            {
                four = ranGen.Next(1, 50);
            }
            while (five == one | five == two | five == three | five == four)
            {
                five = ranGen.Next(1, 50);
            }
            while (six == one | six == two | six == three | six == four | six == five)
            {
                six = ranGen.Next(1, 50);
            }

            outputLabel.Text = " " + one + " " + two + " " + three + " " + four + " " + five + " " + six; 
        }
    }
}
