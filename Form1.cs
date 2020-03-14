using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public string empid, empfn, empln, empos;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = id_fld.Text;
            string b = fn_fld.Text;
            string c = ln_fld.Text;
            string d = pos_fld.Text;
            if (a.Equals("") || b.Equals("") || c.Equals("") || d.Equals(""))
            {
                MessageBox.Show("All fields must be filled!!!");
            }
            else
            {
                employee(empid, empfn,empln,empos);
                id_fld.Text = "";
                fn_fld.Text = "";
                ln_fld.Text = "";
                pos_fld.Text = "";
                MessageBox.Show("Employee Added Successfully!!!");
            }
        }

        public void employee(string empid, string empfn, string empln, string empos)
        {
            empid = id_fld.Text;
            empfn = fn_fld.Text;
            empln = ln_fld.Text;
            empos = pos_fld.Text;

            listBox1.Items.Add(empid);
            listBox2.Items.Add(empfn);
            listBox3.Items.Add(empln);
            listBox4.Items.Add(empos);

        }
    }
}
