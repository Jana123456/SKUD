using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();


        }

        private void группыДоступаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();

        }

        private void группыДоступаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();

        }

        private void программаУправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
        }

        private void состоявшиесяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Show();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            


            }

        private void button1_Click(object sender, EventArgs e)
        {
            


            }
        }

    }
    
    
    

    

