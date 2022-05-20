using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zachet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ковер");
            comboBox1.Items.Add("Куртка");
            comboBox1.Items.Add("Свитер");

            comboBox2.Items.Add("Стирка");
            comboBox2.Items.Add("Отбеливание");
            comboBox2.Items.Add("Чистка с хим. реактивами");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.textBox1.Text = this.comboBox1.Text;
            form2.textBox2.Text = this.comboBox2.Text;
            form2.textBox3.Text = this.dateTimePicker1.Text;
            if (this.checkBox1.Checked)
            {
                form2.textBox4.Text = "1 уровень";
            }
            if (this.checkBox2.Checked)
            {
                form2.textBox4.Text = "2 уровень";
            }
            if (this.checkBox3.Checked)
            {
                form2.textBox4.Text = "3 уровень";
            }

            if ((string.IsNullOrWhiteSpace(comboBox1.Text)) || (string.IsNullOrWhiteSpace(comboBox2.Text)) || ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false)))
            {
                MessageBox.Show("Не все данные были введены");
            }
            else
            {
                form2.ShowDialog();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.checkBox2.Checked = false;
                this.checkBox3.Checked = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == true)
            {
                this.checkBox1.Checked = false;
                this.checkBox3.Checked = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked == true)
            {
                this.checkBox2.Checked = false;
                this.checkBox1.Checked = false;
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("Нельзя ввести дату меньше текущей");
                dateTimePicker1.Value = DateTime.Today;
            }
            else
            {
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            comboBox1.Items.Add(form3.textBox1.Text);
        }
    }
}
