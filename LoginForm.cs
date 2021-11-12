using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantCare2._0
{
    public partial class LoginForm : Form
    {
        SignUpForm frm = new SignUpForm();


        public LoginForm(SignUpForm frm2)
        {
            InitializeComponent();
            frm = frm2;
        }

        public LoginForm()
        {
            InitializeComponent();
        }
        public static string SetWelcome = "";
        DataClasses1DataContext db = new DataClasses1DataContext();


        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            var query = from s in db.Users
                        where s.UserName == username.ToLower() && s.Password == password.ToLower()
                        select s;

            if (query.Count() != 0)
            {
                // MessageBox.Show("User with name " + username + " found");
                
                SetWelcome = username;
                HomepageForm homepage = new HomepageForm();
                homepage.Show();
                //this.Close();   
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }
    }
}
