using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result = 0;

            result = num1 + num2;
            label3.Text = result.ToString();

            if (result >= 50)
            {
                label3.ForeColor = Color.Green;
            }else
            {
                label3.ForeColor = Color.Red;
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Simple Shope
        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string nameProduct = "";

            //Lenovo
            if (checkBox1.Checked == true)
            {
                sum += Convert.ToInt32(label5.Text);
                nameProduct = checkBox1.Text;
            }
            //HP
            if (checkBox2.Checked == true)
            {
                sum += Convert.ToInt32(label6.Text);
                nameProduct = checkBox2.Text;
            }
            //DELL
            if (checkBox3.Checked == true)
            {
                sum += Convert.ToInt32(label7.Text);
                nameProduct = checkBox3.Text;
            }
            //ASUS
            if (checkBox4.Checked == true)
            {
                sum += Convert.ToInt32(label6.Text);
                nameProduct = checkBox4.Text;
            }

            //Cash
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Payment Type : " + radioButton1.Text +"\n" + "Name : " + nameProduct + "\n" + "Cost = " + sum + "$");
            }
            //Credit Card
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Payment Type : " + radioButton2.Text + "\n" + "Name : " + nameProduct + "\n" + "Cost = " + sum + "$");
            }
        }
        //###################################################################################################################################
        //Combo Box
        private void button4_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("example", "example2", "", ...); ===> This is another way to insert items 
            //this is insert with using for loop
            //comboBox1.Items.Clear(); ===> used to skip the redundant ...
            //for (int i = 0; i < 10; i++)
            //{
            //    comboBox1.Items.Add(i.ToString());
            //}
            //##########################################################


            //This is the default way
            comboBox1.Items.Add(textBox3.Text);
            textBox3.Clear();
            //show last index
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }
        //###################################################################################################################################
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //login form whithout database
        private void button7_Click(object sender, EventArgs e)
        {
            string user = textBox5.Text;
            string pass = textBox4.Text;

            if (user == "saad" && pass == "12345")
            {
                this.Hide();
                Form2 fm = new Form2();
                fm.Show();
            }
            else
            {
                label10.Text = "Oppps".ToString();
                label10.ForeColor = Color.Red;
            }
        }
    }
}
