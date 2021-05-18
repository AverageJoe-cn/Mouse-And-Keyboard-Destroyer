using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_And_Keyboard_Destroyer
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int flag = 3;//set its value to set how many times you should click 
        int input_counter = 0;
        string str = "1";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.ControlBox = false;
            this.label1.Text = counter.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            this.label1.Text = counter.ToString();
            if (counter > flag){
                this.label1.Visible = false;
                this.label2.Visible = true;
                this.textBox1.Visible = true;
                this.label2.Text = "input text";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == str)
            {
                this.label2.Text = "Correct!";
                input_counter++;
                this.textBox1.Clear();
            }
            else
            {
                this.label2.Text = "Incorrect!" + (flag - input_counter).ToString() + "to go";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (input_counter == flag)
            {
                Application.Exit();
            }
        }
    }
}
