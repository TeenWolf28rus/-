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
    public partial class FreePlaceByDate : Form
    {
        public FreePlaceByDate()
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

            var query = "select * from [Рекламное место] as rm where rm.[Дата окончания аренды] BETWEEN '"+firstDate+"' and '"+secondDate+"'";
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
    }
}
