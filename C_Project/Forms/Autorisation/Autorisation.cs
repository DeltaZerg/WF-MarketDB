using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Autorisation : Form
    {
        DB db = new DB();
        public Autorisation()
        {
            InitializeComponent();
            db.Customers.Load();
            db.Products.Load();
            db.Goods.Load();
            db.Managers.Load();
            db.Orders.Load();
            db.Users.Load();
            label3.Hide();
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string password = PasswordTB.Text;
            string login = LoginTB.Text;
            bool isUserFound = false;
           foreach(var user in db.Users)
           {
                if (user.UserName == login && user.Password == password)
                {
                    isUserFound = true;
                    break;
                }
                
            }
            if (isUserFound)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                label3.Show();
                label3.Text = "Введен неверный логин или пароль";
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            new AutorisationFP().Show();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            new AutorisationCU().Show();
        }
    }
}
