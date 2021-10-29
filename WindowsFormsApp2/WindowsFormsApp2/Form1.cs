using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        TextFile tx;
        private void Form1_Load(object sender, EventArgs e)
        {
            tx = new TextFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                tx.CreateFile(textBox1.Text);
                MessageBox.Show("Файл создан");
            }
            if (radioButton2.Checked == true)
            {

                tx.CreateDirectory(textBox1.Text);
                MessageBox.Show("Каталог создан");
            }
            textBox1.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                tx.RenameFile(textBox1.Text, textBox3.Text);
            if (radioButton2.Checked == true)
                tx.RenameDirectory(textBox1.Text, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = tx.GetContent(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tx.AddToFile(textBox1.Text, textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                tx.DeleteFile(textBox1.Text);
            if (radioButton2.Checked == true)
                tx.DeleteDirectory(textBox1.Text);
        }
    }
}
