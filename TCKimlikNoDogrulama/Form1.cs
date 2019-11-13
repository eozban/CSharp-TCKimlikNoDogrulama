/*
 *  Bu örnek Erdal Özban Tarafından kodlanmıştır.
 * 
 * 
 * email: eozban@hotmail.com
 * web  : http://www.esintibilisim.com
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ESinTiBiLiSiM;

namespace TCKimlikNoDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MyTCKontrol.TcDogrula(textBox1.Text));
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = MyTCKontrol.TcTamamla((Int64.Parse(textBox1.Text.Substring(0, 9)) - 1).ToString());
                textBox1.SelectAll();
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = MyTCKontrol.TcTamamla((Int64.Parse(textBox1.Text.Substring(0, 9)) + 1).ToString());
                textBox1.SelectAll();
                textBox1.Focus();
            }
        }
    }
}
