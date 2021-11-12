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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btSignUp_Click(object sender, EventArgs e)
        {
            
            string username = tbLastName.Text.ToLower();
            string address = tbAddress.Text;
            string password = tbPassword.Text;
            string confirmpassword = tbConfirmPassword.Text;

            if (password != confirmpassword)
            {
                MessageBox.Show("Passwords don't match, please try again");
            }
            else
            {


                var st = new User
                {
                    UserName = username,
                    Address = address,
                    Password = password,
                    ConfirmPassword = confirmpassword,
                };

                db.Users.InsertOnSubmit(st);
                db.SubmitChanges();
                loadData();
                MessageBox.Show("Submitted successfully");
                
                LoginForm frm = new LoginForm();
                frm.Show();
                this.Hide();

                tbLastName.Clear();
                tbAddress.Clear();
                tbPassword.Clear();
                tbConfirmPassword.Clear();
            }
        }

        void loadData()
        {
            var st = from s in db.Users select s;
            usersDataGridView.DataSource = st;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBPlantCareDataSet);

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPlantCareDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dBPlantCareDataSet.Users);

        }


    }
}

