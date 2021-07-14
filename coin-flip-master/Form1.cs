using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coin_flip
{
    public partial class Form1 : Form
    {

        // array of coins

        Class1[] coins = new Class1[5];


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Class1(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            // labels and stuff
            label1.Text = "";
            for (int i = 0; i < coins.Length; i++)
            {
                label1.Text += coins[i].isHeads + ",";
                coins[i].flipcoin(r);
            }
            // set pictureboxes
            pictureBox1.Image = coins[0].isHeads ? Properties.Resources.front_coin : Properties.Resources.back_coin;
            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.front_coin : Properties.Resources.back_coin;
            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.front_coin : Properties.Resources.back_coin;
            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.front_coin : Properties.Resources.back_coin;
            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.front_coin : Properties.Resources.back_coin;


            
            // label1.Text = coins[0].isHeads + "," + coins[1].isHeads + "," + coins[2].isHeads + "," + coins[3].isHeads + "," + coins[4].isHeads + ",";
        }
    }
}
