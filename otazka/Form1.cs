using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otazka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            MessageBox.Show("Dnes je " + dateTimePicker1.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pct = 0;
            foreach (string line in textBox1.Lines) { 
            string text = textBox1.Text;
            var names = text.Split(';');
            
            var firstName = names[0];
            var lastName = names[1];
            var date = names[2];
            
            
            DateTime dt1 = DateTime.Parse(date);
            DateTime dt2 = DateTime.Parse("01.01.9999");
            for(int i = 0; i < textBox1.Lines.Length; i++)
                {
                    if (dt1 < dt2)
                    {
                        dt2 = dt1;
                        pct++;
                    }
                }
            }
            MessageBox.Show("Nejstarší člověk je: " + pct.ToString());
        }
    }
}
