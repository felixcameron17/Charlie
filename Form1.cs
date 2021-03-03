using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charile_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            comboBox1.Text = "";
            button1.Text = "Select";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if (f2.radioButton1.Checked == true)
                button1.Text = f2.radioButton1.Text;

            else if (f2.radioButton2.Checked == true)
                button1.Text = f2.radioButton2.Text;

            else if (f2.radioButton3.Checked == true)
                button1.Text = f2.radioButton3.Text;

            else if (f2.radioButton4.Checked == true)
                button1.Text = f2.radioButton4.Text;

        }

        private string buttonValue;
        private string hourValue;
        private string minuteValue;
        private string theDate;
        private int num_x;
        
        private void button2_Click(object sender, EventArgs e)
        {
            theDate = dateTimePicker1.Value.ToShortDateString();
            hourValue = Convert.ToString(numericUpDown1.Value);

            if (button1.Text == "Select")
                buttonValue = "";

            else
                buttonValue = button1.Text;

            
            if (numericUpDown2.Value <= 9)
                minuteValue = 0 + Convert.ToString(numericUpDown2.Value);

            else
                minuteValue = Convert.ToString(numericUpDown2.Value);

            if (textBox1.Text == "")
                listBox1.Items.Add("You need to enter a first name");

            else if (textBox2.Text == "")
                listBox1.Items.Add("You need to enter a surname");

            else if (textBox3.Text == "")
                listBox1.Items.Add("You need to enter a phone number");

            else if (int.TryParse(textBox3.Text, out num_x) == false)
            {
                listBox1.Items.Add("You need to enter a valid phone number");
                listBox1.Items.Add("(one with all digits)");
            }

            else if (textBox4.Text == "")
                listBox1.Items.Add("You need to enter an email");

            else if (!textBox4.Text.Contains("@"))
            {
                listBox1.Items.Add("You need to enter a valid email");
                listBox1.Items.Add("(@ symbol required)");
            }

            else if (comboBox1.Text == "")
                listBox1.Items.Add("You need to select a person that you want to have a meeting with");

            else if (button1.Text == "Select")
                listBox1.Items.Add("You need to select a meeting aim");

            else
            {
                listBox1.Items.Add("Meeting of: " + textBox1.Text + " " + textBox2.Text);
                listBox1.Items.Add("Meeting at: " + hourValue + ":" + minuteValue);
                listBox1.Items.Add("Meeting with: " + comboBox1.Text);
                listBox1.Items.Add("Meeting aim: " + button1.Text);
                listBox1.Items.Add("-----------------------------------------------------");
                reset();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
