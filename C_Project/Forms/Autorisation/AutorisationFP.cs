using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class AutorisationFP : Form
    {
        DB db = new DB();
        User user;
        public AutorisationFP()
        {
            InitializeComponent();
        }

        private void ReductButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                user = db.Users.First(p => p.UserName == textBox1.Text);
                MessageBox.Show("Пароль:" + user.Password);
                this.Close();
            }
            catch (InvalidOperationException)
            {

                MessageBox.Show("Такого пользователя не существует!");
            }                         
        }
    }
}
