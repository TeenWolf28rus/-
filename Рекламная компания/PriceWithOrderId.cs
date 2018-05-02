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
    public partial class PriceWithOrderId : Form
    {
        public PriceWithOrderId()
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
            int idForQuery;
            try
            {
                idForQuery = int.Parse(zakazIdTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите целое число", "Ошибка ввода");
                return;
            }
            
            var query = "select isNull((select(DATEDIFF(DAY, rm.[Дата начала аренды], rm.[Дата окончания аренды])"
                +" * rm.Стоимость) from [Список услуг] as su join [Список услуг рекламное место] as surm on su.[Код услуги]"
                +" = surm.[Код услуги] join [Рекламное место] as rm on surm.[Код места] = rm.[Код места] where"
                +" su.[Код заказа] = "+idForQuery.ToString()+"), 0) + (select sum(im.[Стоимость материала]) from [Список услуг] as su"
                +" join [Список услуг Используемые материалы] as suim on su.[Код услуги] = suim.[Код услуги] join"
                +" [Используемые материалы] as im on im.[Название материала] = suim.[Название материала] where "
                +"su.[Код заказа] = "+idForQuery.ToString()+") + (select sum(su.Стоимость) from[Список услуг] as su where su.[Код заказа] = "+idForQuery.ToString()+")"
                +" as 'Сумма заказа'";

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

        private void PriceWithOrderId_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
