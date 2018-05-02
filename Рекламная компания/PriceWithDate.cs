using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Рекламная_компания
{
    public partial class PriceWithDate : Form
    {
        public PriceWithDate()
        {
            InitializeComponent();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            String firstDate = firstDP.Value.ToShortDateString();
            String secondDate = secondDP.Value.ToShortDateString();

            if (firstDP.Value > secondDP.Value)
            {
                MessageBox.Show("Начальная дата не может быть больше или равной конечной", "Ошибка даты");
                return;
            }

            var query = "select (select sum(su.Стоимость) from [Список услуг] as su"
                + " join Заказ as z on su.[Код заказа] = z.[Код заказа] where z.[Дата подписания]"
                + " between '"+firstDate+"' and '" + secondDate + "')+ (select ISNULL(sum(ISNULL((DATEDIFF(DAY, "
                +"rm.[Дата начала аренды], rm.[Дата окончания аренды]) * rm.Стоимость), 0)),0) from "
                +"[Список услуг] as su join Заказ as z on su.[Код заказа] = z.[Код заказа] join"
                +" [Список услуг рекламное место] as surm on su.[Код услуги] = surm.[Код услуги] "
                + "join [Рекламное место] as rm on surm.[Код места] = rm.[Код места] where z.[Дата подписания]"
                + " between '" + firstDate + "' and '" + secondDate + "')+ (select sum(im.[Стоимость материала]) from [Список услуг]"
                +" as su join Заказ as z on su.[Код заказа] = z.[Код заказа] join [Список услуг Используемые материалы]"
                +" as suim on su.[Код услуги] = suim.[Код услуги] join [Используемые материалы]as"
                + " im on suim.[Название материала] = im.[Название материала] where z.[Дата подписания]"
                + " between '" + firstDate + "' and '"+secondDate+"') as 'Сумма'";

            request(query);
        }

        private void request(String query)
        {
            var connection = new SqlConnection("Data Source=DESKTOP-F24NN2L;Initial Catalog=AdvertisingCompaign;Integrated Security=True");

            var dataAdapter = new SqlDataAdapter(query, connection);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void firstDP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void secondDP_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
