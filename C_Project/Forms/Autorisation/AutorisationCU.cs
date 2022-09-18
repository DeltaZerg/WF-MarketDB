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
    public partial class AutorisationCU : Form
    {
        DB db = new DB();
        public AutorisationCU()
        {
            InitializeComponent();
        }

       
        private void ReductButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var user = db.Users.First(p => p.UserName == TB_UN.Text);
                MessageBox.Show("Такого пользователь уже существует!");
            }
            catch (InvalidOperationException)
            {

                db.Users.Add(new User() { UserName = TB_UN.Text, Password = TB_PW.Text });
                MessageBox.Show("Пользователь успешно создан!");
                db.SaveChanges();

                this.Close();
            }

           
        }

       
    }
}
