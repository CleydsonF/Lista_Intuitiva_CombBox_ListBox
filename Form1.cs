using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2_WindowsForm_Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object item in listBox1.Items)
            {
                comboBox1.Items.Add(item.ToString());
                
            }
            MessageBox.Show("Lista preenchida");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                MessageBox.Show("O CheckBox está marcado");
            }
            else
            {
                MessageBox.Show("O CheckBox não está marcado");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String dt = textBox4.Text;
                DateTime data = Convert.ToDateTime(dt);
                label1.Text = $"Dia: {data.Day}";
                label2.Text = $"Mês: {data.Month}";
                label3.Text = $"Ano: {data.Year}";
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Formato de data errado!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
