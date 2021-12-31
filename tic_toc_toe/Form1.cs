using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_toc_toe
{
   
    public partial class Form1 : Form
    {
        string plr_1_name, plr_2_name;
        bool[] plr_1_value = new bool[9];
        bool[] plr_2_value = new bool[9];
        char plr_1_logo;
        char plr_2_logo;
        bool plr_1=true;
       // bool plr_2=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (plr_1 == true)
            {
                
                if (plr_1_value[0] == true)
                {

                }
                else
                {
                    plr_1_value[0] = true;
                    bt1.Text = "X";
                    plr_1 = false;
                    lb5.Text = "Play By " + plr_2_name;
                    if ((plr_1_value[0]==true && plr_1_value[1] == true && plr_1_value[2] == true)|| (plr_1_value[3] == true && plr_1_value[4] == true && plr_1_value[5] == true)|| (plr_1_value[6] == true && plr_1_value[7] == true && plr_1_value[8] == true)|| (plr_1_value[0] == true && plr_1_value[3] == true && plr_1_value[6] == true)|| (plr_1_value[0] == true && plr_1_value[4] == true && plr_1_value[8] == true)|| (plr_1_value[4] == true && plr_1_value[1] == true && plr_1_value[7] == true)|| (plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true)|| (plr_1_value[5] == true && plr_1_value[8] == true && plr_1_value[2] == true)|| (plr_1_value[6] == true && plr_1_value[4] == true && plr_1_value[2] == true))
                    {
                        MessageBox.Show(plr_1_name + " Win The game");
                    }
                }
            }
            else
            {
                if (plr_1_value[0] == true)
                {

                }
                else
                {
                    plr_1_value[0] = true;
                    bt1.Text = "O";
                    plr_1 = true;
                    lb5.Text = "Play By " + plr_1_name;
                    if ((plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[3] == true && plr_2_value[4] == true && plr_2_value[5] == true) || (plr_2_value[6] == true && plr_2_value[7] == true && plr_2_value[8] == true) || (plr_2_value[0] == true && plr_2_value[3] == true && plr_2_value[6] == true) || (plr_2_value[0] == true && plr_2_value[4] == true && plr_2_value[8] == true) || (plr_2_value[4] == true && plr_2_value[1] == true && plr_2_value[7] == true) || (plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[5] == true && plr_2_value[8] == true && plr_2_value[2] == true) || (plr_2_value[6] == true && plr_2_value[4] == true && plr_2_value[2] == true))
                    {
                        MessageBox.Show(plr_2_name + " Win The game");
                    }
                }
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (plr_1 == true)
            {
                if (plr_1_value[7] == true)
                {

                }
                else
                {
                    plr_1_value[7] = true;
                    bt8.Text = "X";
                    plr_1 = false;
                    lb5.Text = "Play By " + plr_2_name;
                    if ((plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[3] == true && plr_1_value[4] == true && plr_1_value[5] == true) || (plr_1_value[6] == true && plr_1_value[7] == true && plr_1_value[8] == true) || (plr_1_value[0] == true && plr_1_value[3] == true && plr_1_value[6] == true) || (plr_1_value[0] == true && plr_1_value[4] == true && plr_1_value[8] == true) || (plr_1_value[4] == true && plr_1_value[1] == true && plr_1_value[7] == true) || (plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[5] == true && plr_1_value[8] == true && plr_1_value[2] == true) || (plr_1_value[6] == true && plr_1_value[4] == true && plr_1_value[2] == true))
                    {
                        MessageBox.Show(plr_1_name + " Win The game");
                    }
                }
            }
            else
            {
                if (plr_2_value[7] == true)
                {

                }
                else
                {
                    plr_2_value[7] = true;
                    bt8.Text = "O";
                    plr_1 = true;
                    lb5.Text = "Play By " + plr_1_name;
                    if ((plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[3] == true && plr_2_value[4] == true && plr_2_value[5] == true) || (plr_2_value[6] == true && plr_2_value[7] == true && plr_2_value[8] == true) || (plr_2_value[0] == true && plr_2_value[3] == true && plr_2_value[6] == true) || (plr_2_value[0] == true && plr_2_value[4] == true && plr_2_value[8] == true) || (plr_2_value[4] == true && plr_2_value[1] == true && plr_2_value[7] == true) || (plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[5] == true && plr_2_value[8] == true && plr_2_value[2] == true) || (plr_2_value[6] == true && plr_2_value[4] == true && plr_2_value[2] == true))
                    {
                        MessageBox.Show(plr_2_name + " Win The game");
                    }
                }
            }
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            if (plr_1 == true)
            {
                if (plr_1_value[6] == true)
                {

                }
                else
                {
                    plr_1_value[6] = true;
                    bt7.Text = "X";
                    plr_1 = false;
                    lb5.Text = "Play By " + plr_2_name;
                    if ((plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[3] == true && plr_1_value[4] == true && plr_1_value[5] == true) || (plr_1_value[6] == true && plr_1_value[7] == true && plr_1_value[8] == true) || (plr_1_value[0] == true && plr_1_value[3] == true && plr_1_value[6] == true) || (plr_1_value[0] == true && plr_1_value[4] == true && plr_1_value[8] == true) || (plr_1_value[4] == true && plr_1_value[1] == true && plr_1_value[7] == true) || (plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[5] == true && plr_1_value[8] == true && plr_1_value[2] == true) || (plr_1_value[6] == true && plr_1_value[4] == true && plr_1_value[2] == true))
                    {
                        MessageBox.Show(plr_1_name + " Win The game");
                    }
                }
            }
            else
            {
                if (plr_2_value[6] == true)
                {

                }
                else
                {
                    plr_2_value[6] = true;
                    bt7.Text = "O";
                    plr_1 = true;
                    lb5.Text = "Play By " + plr_1_name;
                    if ((plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[3] == true && plr_2_value[4] == true && plr_2_value[5] == true) || (plr_2_value[6] == true && plr_2_value[7] == true && plr_2_value[8] == true) || (plr_2_value[0] == true && plr_2_value[3] == true && plr_2_value[6] == true) || (plr_2_value[0] == true && plr_2_value[4] == true && plr_2_value[8] == true) || (plr_2_value[4] == true && plr_2_value[1] == true && plr_2_value[7] == true) || (plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[5] == true && plr_2_value[8] == true && plr_2_value[2] == true) || (plr_2_value[6] == true && plr_2_value[4] == true && plr_2_value[2] == true))
                    {
                        MessageBox.Show(plr_2_name + " Win The game");
                    }
                }
            }
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            if (plr_1 == true)
            {
                if (plr_1_value[3] == true)
                {

                }
                else
                {
                    plr_1_value[3] = true;
                    bt4.Text = "X";
                    plr_1 = false;
                    lb5.Text = "Play By " + plr_2_name;
                    if ((plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[3] == true && plr_1_value[4] == true && plr_1_value[5] == true) || (plr_1_value[6] == true && plr_1_value[7] == true && plr_1_value[8] == true) || (plr_1_value[0] == true && plr_1_value[3] == true && plr_1_value[6] == true) || (plr_1_value[0] == true && plr_1_value[4] == true && plr_1_value[8] == true) || (plr_1_value[4] == true && plr_1_value[1] == true && plr_1_value[7] == true) || (plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[5] == true && plr_1_value[8] == true && plr_1_value[2] == true) || (plr_1_value[6] == true && plr_1_value[4] == true && plr_1_value[2] == true))
                    {
                        MessageBox.Show(plr_1_name + " Win The game");
                    }
                }
            }
            else
            {
                if (plr_2_value[3] == true)
                {

                }
                else
                {
                    plr_2_value[3] = true;
                    bt4.Text = "O";
                    plr_1 = true;
                    lb5.Text = "Play By " + plr_1_name;
                    if ((plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[3] == true && plr_2_value[4] == true && plr_2_value[5] == true) || (plr_2_value[6] == true && plr_2_value[7] == true && plr_2_value[8] == true) || (plr_2_value[0] == true && plr_2_value[3] == true && plr_2_value[6] == true) || (plr_2_value[0] == true && plr_2_value[4] == true && plr_2_value[8] == true) || (plr_2_value[4] == true && plr_2_value[1] == true && plr_2_value[7] == true) || (plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[5] == true && plr_2_value[8] == true && plr_2_value[2] == true) || (plr_2_value[6] == true && plr_2_value[4] == true && plr_2_value[2] == true))
                    {
                        MessageBox.Show(plr_2_name + " Win The game");
                    }
                }
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
          //  plr_1_name = tb2.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
          //  plr_2_name = tb1.Text;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            plr_1_name = tb2.Text;
            plr_2_name = tb1.Text;
            plr_1_logo = 'X';
            plr_2_logo = 'O';
            //  MessageBox.Show("Player 1 name " + plr_1_name + "\n Player 2 name " + plr_2_name);
            lb5.Text = "First Play By " + plr_1_name;

        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            if (plr_1 == true)
            {
                if (plr_1_value[1] == true)
                {

                }
                else
                {
                    plr_1_value[1] = true;
                    bt2.Text = "X";
                    lb5.Text = "Play By " + plr_2_name;
                    plr_1 = false;
                    if ((plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[3] == true && plr_1_value[4] == true && plr_1_value[5] == true) || (plr_1_value[6] == true && plr_1_value[7] == true && plr_1_value[8] == true) || (plr_1_value[0] == true && plr_1_value[3] == true && plr_1_value[6] == true) || (plr_1_value[0] == true && plr_1_value[4] == true && plr_1_value[8] == true) || (plr_1_value[4] == true && plr_1_value[1] == true && plr_1_value[7] == true) || (plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[5] == true && plr_1_value[8] == true && plr_1_value[2] == true) || (plr_1_value[6] == true && plr_1_value[4] == true && plr_1_value[2] == true))
                    {
                        MessageBox.Show(plr_1_name + " Win The game");
                    }
                }
            }
            else
            {
                if (plr_2_value[1] == true)
                {

                }
                else
                {
                    plr_2_value[1] = true;
                    bt2.Text = "O";
                    plr_1 = true;
                    lb5.Text = "Play By " + plr_1_name;
                    if ((plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[3] == true && plr_2_value[4] == true && plr_2_value[5] == true) || (plr_2_value[6] == true && plr_2_value[7] == true && plr_2_value[8] == true) || (plr_2_value[0] == true && plr_2_value[3] == true && plr_2_value[6] == true) || (plr_2_value[0] == true && plr_2_value[4] == true && plr_2_value[8] == true) || (plr_2_value[4] == true && plr_2_value[1] == true && plr_2_value[7] == true) || (plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[5] == true && plr_2_value[8] == true && plr_2_value[2] == true) || (plr_2_value[6] == true && plr_2_value[4] == true && plr_2_value[2] == true))
                    {
                        MessageBox.Show(plr_2_name + " Win The game");
                    }
                }
            }
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            if (plr_1 == true)
            {
                if (plr_1_value[2] == true)
                {

                }
                else
                {
                    plr_1_value[2] = true;
                    bt3.Text = "X";
                    plr_1 = false;
                    lb5.Text = "Play By " + plr_2_name;
                    if ((plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[3] == true && plr_1_value[4] == true && plr_1_value[5] == true) || (plr_1_value[6] == true && plr_1_value[7] == true && plr_1_value[8] == true) || (plr_1_value[0] == true && plr_1_value[3] == true && plr_1_value[6] == true) || (plr_1_value[0] == true && plr_1_value[4] == true && plr_1_value[8] == true) || (plr_1_value[4] == true && plr_1_value[1] == true && plr_1_value[7] == true) || (plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[5] == true && plr_1_value[8] == true && plr_1_value[2] == true) || (plr_1_value[6] == true && plr_1_value[4] == true && plr_1_value[2] == true))
                    {
                        MessageBox.Show(plr_1_name + " Win The game");
                    }
                }
            }
            else
            {
                if (plr_2_value[2] == true)
                {

                }
                else
                {
                    plr_2_value[2] = true;
                    bt3.Text = "O";
                    plr_1 = true;
                    lb5.Text = "Play By " + plr_1_name;
                    if ((plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[3] == true && plr_2_value[4] == true && plr_2_value[5] == true) || (plr_2_value[6] == true && plr_2_value[7] == true && plr_2_value[8] == true) || (plr_2_value[0] == true && plr_2_value[3] == true && plr_2_value[6] == true) || (plr_2_value[0] == true && plr_2_value[4] == true && plr_2_value[8] == true) || (plr_2_value[4] == true && plr_2_value[1] == true && plr_2_value[7] == true) || (plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[5] == true && plr_2_value[8] == true && plr_2_value[2] == true) || (plr_2_value[6] == true && plr_2_value[4] == true && plr_2_value[2] == true))
                    {
                        MessageBox.Show(plr_2_name + " Win The game");
                    }
                }
            }
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            if (plr_1 == true)
            {
                if (plr_1_value[4] == true)
                {

                }
                else
                {
                    plr_1_value[4] = true;
                    bt5.Text = "X";
                    plr_1 = false;
                    lb5.Text = "Play By " + plr_2_name;
                    if ((plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[3] == true && plr_1_value[4] == true && plr_1_value[5] == true) || (plr_1_value[6] == true && plr_1_value[7] == true && plr_1_value[8] == true) || (plr_1_value[0] == true && plr_1_value[3] == true && plr_1_value[6] == true) || (plr_1_value[0] == true && plr_1_value[4] == true && plr_1_value[8] == true) || (plr_1_value[4] == true && plr_1_value[1] == true && plr_1_value[7] == true) || (plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[5] == true && plr_1_value[8] == true && plr_1_value[2] == true) || (plr_1_value[6] == true && plr_1_value[4] == true && plr_1_value[2] == true))
                    {
                        MessageBox.Show(plr_1_name + " Win The game");
                    }
                }
            }
            else
            {
                if (plr_2_value[4] == true)
                {

                }
                else
                {
                    plr_2_value[4] = true;
                    bt5.Text = "O";
                    plr_1 = true;
                    lb5.Text = "Play By " + plr_1_name;
                    if ((plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[3] == true && plr_2_value[4] == true && plr_2_value[5] == true) || (plr_2_value[6] == true && plr_2_value[7] == true && plr_2_value[8] == true) || (plr_2_value[0] == true && plr_2_value[3] == true && plr_2_value[6] == true) || (plr_2_value[0] == true && plr_2_value[4] == true && plr_2_value[8] == true) || (plr_2_value[4] == true && plr_2_value[1] == true && plr_2_value[7] == true) || (plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[5] == true && plr_2_value[8] == true && plr_2_value[2] == true) || (plr_2_value[6] == true && plr_2_value[4] == true && plr_2_value[2] == true))
                    {
                        MessageBox.Show(plr_2_name + " Win The game");
                    }
                }
            }
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            if (plr_1 == true)
            {
                if (plr_1_value[8] == true)
                {

                }
                else
                {
                    plr_1_value[8] = true;
                    bt9.Text = "X";
                    plr_1 = false;
                    lb5.Text = "Play By " + plr_2_name;
                    if ((plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[3] == true && plr_1_value[4] == true && plr_1_value[5] == true) || (plr_1_value[6] == true && plr_1_value[7] == true && plr_1_value[8] == true) || (plr_1_value[0] == true && plr_1_value[3] == true && plr_1_value[6] == true) || (plr_1_value[0] == true && plr_1_value[4] == true && plr_1_value[8] == true) || (plr_1_value[4] == true && plr_1_value[1] == true && plr_1_value[7] == true) || (plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[5] == true && plr_1_value[8] == true && plr_1_value[2] == true) || (plr_1_value[6] == true && plr_1_value[4] == true && plr_1_value[2] == true))
                    {
                        MessageBox.Show(plr_1_name + " Win The game");
                    }
                }
            }
            else
            {
                if (plr_2_value[8] == true)
                {

                }
                else
                {
                    plr_2_value[8] = true;
                    bt9.Text = "O";
                    plr_1 = true;
                    lb5.Text = "Play By " + plr_1_name;
                    if ((plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[3] == true && plr_2_value[4] == true && plr_2_value[5] == true) || (plr_2_value[6] == true && plr_2_value[7] == true && plr_2_value[8] == true) || (plr_2_value[0] == true && plr_2_value[3] == true && plr_2_value[6] == true) || (plr_2_value[0] == true && plr_2_value[4] == true && plr_2_value[8] == true) || (plr_2_value[4] == true && plr_2_value[1] == true && plr_2_value[7] == true) || (plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[5] == true && plr_2_value[8] == true && plr_2_value[2] == true) || (plr_2_value[6] == true && plr_2_value[4] == true && plr_2_value[2] == true))
                    {
                        MessageBox.Show(plr_2_name + " Win The game");
                    }
                }
            }
        }

        private void Lb5_Click(object sender, EventArgs e)
        {

        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            if (plr_1 == true)
            {
                if (plr_1_value[5] == true)
                {

                }
                else
                {
                    plr_1_value[5] = true;
                    bt6.Text = "X";
                    plr_1 = false;
                    lb5.Text = "Play By " + plr_2_name;
                    if ((plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[3] == true && plr_1_value[4] == true && plr_1_value[5] == true) || (plr_1_value[6] == true && plr_1_value[7] == true && plr_1_value[8] == true) || (plr_1_value[0] == true && plr_1_value[3] == true && plr_1_value[6] == true) || (plr_1_value[0] == true && plr_1_value[4] == true && plr_1_value[8] == true) || (plr_1_value[4] == true && plr_1_value[1] == true && plr_1_value[7] == true) || (plr_1_value[0] == true && plr_1_value[1] == true && plr_1_value[2] == true) || (plr_1_value[5] == true && plr_1_value[8] == true && plr_1_value[2] == true) || (plr_1_value[6] == true && plr_1_value[4] == true && plr_1_value[2] == true))
                    {
                        MessageBox.Show(plr_1_name + " Win The game");
                    }
                }
            }
            else
            {
                if (plr_2_value[5] == true)
                {

                }
                else
                {
                    plr_2_value[5] = true;
                    bt6.Text = "O";
                    plr_1 = true;
                    lb5.Text = "Play By " + plr_2_name;
                    if ((plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[3] == true && plr_2_value[4] == true && plr_2_value[5] == true) || (plr_2_value[6] == true && plr_2_value[7] == true && plr_2_value[8] == true) || (plr_2_value[0] == true && plr_2_value[3] == true && plr_2_value[6] == true) || (plr_2_value[0] == true && plr_2_value[4] == true && plr_2_value[8] == true) || (plr_2_value[4] == true && plr_2_value[1] == true && plr_2_value[7] == true) || (plr_2_value[0] == true && plr_2_value[1] == true && plr_2_value[2] == true) || (plr_2_value[5] == true && plr_2_value[8] == true && plr_2_value[2] == true) || (plr_2_value[6] == true && plr_2_value[4] == true && plr_2_value[2] == true))
                    {
                        MessageBox.Show(plr_2_name + " Win The game");
                    }
                }
            }
        }
    }
}
