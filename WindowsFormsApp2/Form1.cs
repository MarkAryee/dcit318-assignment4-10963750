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
        private List<string> contacts = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = label1.Text;
            string email = label2.Text;
            string phone = label3.Text;
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}", "Address Book Entry");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string allContacts = string.Join(Environment.NewLine, contacts);
            MessageBox.Show(allContacts, "All Contacts");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string phone = textBox3.Text;

            string contact = $"{name} - {email} - {phone}";
            contacts.Add(contact);


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
