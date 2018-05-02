using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Рекламная_компания
{
    public partial class SingIn : Form
    {

        private const String login = "Vladislav";
        private const String password = "aqswdefr123";

        public SingIn()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {//DELETE
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
            /*if (loginTB.Text.Equals(login) && passwordTB.Text.Equals(password))
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не правильно введён логин или пароль");
            }*/
        }

        private void SingIn_Load(object sender, EventArgs e)
        {   
            
        }
    }
}
