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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            var maiMenu = new MainMenu();
            maiMenu.Show();
            this.Close();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            label1.Text = "Разработал: Богдановский Владислав Александрович \nУченик факультета математики и информатики группы 653 \n"
                +"Приняла работу: Соловцова Любовь Александровна \n\n\n\n"
                +"Данныя программа предназначена для работы с базой данных Рекламная компания, а так же осужествление запросов на вывод данных и изменение."
                +"Данная программа разработана специально для курсовой работы по предмету Базы данных."
                +"Программа содержит 9 форм, некоторые из них используются для разных действий."
                +"В данном программном продукте осуществляется 10 запросов к базе данных и три запроса на обновление данных."
                +"Программа имеет обработчики ошибок, благодаря чему, приложение не закроется, а уведомит об ошибке при вводе данных.";
        }
    }
}
