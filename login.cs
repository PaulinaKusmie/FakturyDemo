using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZalogujsie_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Paulina" && txtPassword.Text == "12345")
            {
                new form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło - spróbuj ponownie!");
            }
        }
    }
}
