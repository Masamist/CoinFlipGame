using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {
        Coin[] coins = new Coin[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            // display the labels
            label1.Text = "";
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i].flipCoin(r);
                label1.Text += coins[i].isHeads + ",";
                
            }

            // set the pictures
            pictureBox1.Image = coins[0].isHeads ? Properties.Resources.heads : Properties.Resources.tails;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.heads : Properties.Resources.tails;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.heads : Properties.Resources.tails;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.heads : Properties.Resources.tails;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.heads : Properties.Resources.tails;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Coin(false);
            }
        }
    }
}
