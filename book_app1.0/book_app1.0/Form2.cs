using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_app1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçirilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text == "elifsel" && textBox2.Text == "3006" || textBox1.Text == "admin" && textBox2.Text == "1")
                {
                    Form1 anaForm = new Form1();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve/veya şifre yanlış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
               {
                    //checkBox işaretli ise
                    if (checkBox1.Checked)
                    {
                        //karakteri göster.
                        textBox2.PasswordChar = '\0';
                    }
                    //değilse karakterlerin yerine * koy.
                    else
                    {
                        textBox2.PasswordChar = '*';
                    }
                }
            
    }

        
    }
    }
