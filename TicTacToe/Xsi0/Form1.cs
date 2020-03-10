using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xsi0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ok = true;
        private int nr = 0;

        private void Click(object sender, EventArgs e)
        {
            Button B = new Button();
            B = sender as Button;
            if (ok == true && B.Text == "-")
            {
                B.Text = "X";
                ok = false;
            }
            else
                if (B.Text == "-")
                {
                    B.Text = "0";
                    ok = true;
                }
            nr++;
            if (button1.Text != "-")
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    nr = 0;
                    button1.BackColor = button5.BackColor = button9.BackColor = Color.Red;
                    MessageBox.Show(button1.Text + " a castigat!");
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "-";
                    button1.BackColor = button5.BackColor = button9.BackColor = Color.LightGray;
                }
            if (button1.Text != "-")
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    nr = 0;
                    button1.BackColor = button2.BackColor = button3.BackColor = Color.Red;
                    MessageBox.Show(button1.Text + " a castigat!");
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "-";
                    button1.BackColor = button2.BackColor = button3.BackColor = Color.LightGray;
                }
            if (button1.Text != "-")
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    nr = 0;
                    button1.BackColor = button4.BackColor = button7.BackColor = Color.Red;
                    MessageBox.Show(button1.Text + " a castigat!");
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "-";
                    button1.BackColor = button4.BackColor = button7.BackColor = Color.LightGray;
                }
            if (button2.Text != "-")
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    nr = 0;
                    button2.BackColor = button5.BackColor = button8.BackColor = Color.Red;
                    MessageBox.Show(button2.Text + " a castigat!");
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "-";
                    button2.BackColor = button5.BackColor = button8.BackColor = Color.LightGray;
                }
            if (button3.Text != "-")
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    nr = 0;
                    button3.BackColor = button5.BackColor = button7.BackColor = Color.Red;
                    MessageBox.Show(button3.Text + " a castigat!");
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "-";
                    button3.BackColor = button5.BackColor = button7.BackColor = Color.LightGray;
                }
            if (button3.Text != "-")
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    nr = 0;
                    button3.BackColor = button6.BackColor = button9.BackColor = Color.Red;
                    MessageBox.Show(button3.Text + " a castigat!");
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "-";
                    button3.BackColor = button6.BackColor = button9.BackColor = Color.LightGray;
                }
            if (button4.Text != "-")
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    nr = 0;
                    button4.BackColor = button5.BackColor = button6.BackColor = Color.Red;
                    MessageBox.Show(button4.Text + " a castigat!");
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "-";
                    button4.BackColor = button5.BackColor = button6.BackColor = Color.LightGray;
                }
            if (button7.Text != "-")
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    nr = 0;
                    button7.BackColor = button8.BackColor = button9.BackColor = Color.Red;
                    MessageBox.Show(button7.Text + " a castigat!");
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "-";
                    button7.BackColor = button8.BackColor = button9.BackColor = Color.LightGray;
                }
            if (nr == 9)
            {
                MessageBox.Show("Remiza!");
                button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "-";
                nr = 0;
            }
        }

    }
}
