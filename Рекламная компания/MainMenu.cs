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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allClientReqBtn_Click(object sender, EventArgs e)
        {
            var query = "Select* From Клиент";
            var title = "Запрос на всех клиенов";
            var allClient = new QueryForm(query, title);
            allClient.Show();
            this.Close();
        }

        private void FreeAdPlace_Click(object sender, EventArgs e)
        {
            var query = "select * from [Рекламное место] where [Дата окончания аренды] < GETDATE()";
            var title = "Запрос на свободные места";
            var freeAdPlace = new QueryForm(query, title);
            freeAdPlace.Show();
            this.Close();
        }

        private void BusyAdPlace_Click(object sender, EventArgs e)
        {
            var query = "select * from [Рекламное место] where [Дата окончания аренды] > GETDATE()";
            var title = "Запрос на занятые места";
            var busyAdPlace = new QueryForm(query, title);
            busyAdPlace.Show();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void zakazWithZakazId_Click(object sender, EventArgs e)
        {
            var query = "select * from Заказ where [Код заказа] =";
            var title = "Справка по заданному заказу";
            var zakazWithZakazId = new QueryWithCondition(query, title);
            zakazWithZakazId.Show();
            this.Close();
        }

        private void allOrdersByClient_Click(object sender, EventArgs e)
        {
            var query = "Select * from Клиент as c join Заказ as z on c.[Код клиента] = z.[Код клиента] where c.[Код клиента] =";
            var title = "Справка о всех заказах заданного клиента";
            var zakazWithClientId = new QueryWithCondition(query, title);
            zakazWithClientId.Show();
            this.Close();
        }

        private void summOrderById_Click(object sender, EventArgs e)
        {
            var priceWithOrderId = new PriceWithOrderId();
            priceWithOrderId.Show();
            this.Close();
        }

        private void usedMaterial_Click(object sender, EventArgs e)
        {
            var query = "Select * from [Используемые материалы]";
            var title = "Используемые компанией материалы";
            var usedMaterial = new QueryForm(query, title);
            usedMaterial.Show();
            this.Close();
        }

        private void priceDoneOrders_Click(object sender, EventArgs e)
        {
            var query = "select (select sum(su.Стоимость) from [Список услуг] as su"
                + " join Заказ as z on su.[Код заказа] = z.[Код заказа] where z.[Дата окончания]"
                + " <= GETDATE())+ (select isNull(sum(ISNULL((DATEDIFF(DAY, "
                + "rm.[Дата начала аренды], rm.[Дата окончания аренды]) * rm.Стоимость), 0)), 0) from "
                + "[Список услуг] as su join Заказ as z on su.[Код заказа] = z.[Код заказа] join"
                + " [Список услуг рекламное место] as surm on su.[Код услуги] = surm.[Код услуги] "
                + "join [Рекламное место] as rm on surm.[Код места] = rm.[Код места] where z.[Дата окончания]"
                + " <= GETDATE())+ (select sum(im.[Стоимость материала]) from [Список услуг]"
                + " as su join Заказ as z on su.[Код заказа] = z.[Код заказа] join [Список услуг Используемые материалы]"
                + " as suim on su.[Код услуги] = suim.[Код услуги] join [Используемые материалы]as"
                + " im on suim.[Название материала] = im.[Название материала] where z.[Дата окончания]"
                + " <= GETDATE()) as 'Сумма'";

            var title = "Сумма всех выполненных заказов";
            var priceDoneOrder = new QueryForm(query, title);
            priceDoneOrder.Show();
            this.Close();
        }

        private void priceOrderByTime_Click(object sender, EventArgs e)
        {
            var priceOrderByTime = new PriceWithDate();
            priceOrderByTime.Show();
            this.Close();
        }

        private void freePlaceByTime_Click(object sender, EventArgs e)
        {
            var freePlaceByDate = new FreePlaceByDate();
            freePlaceByDate.Show();
            this.Close();
        }

        private void editData_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm();
            editForm.Show();
            this.Close();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            var infoForm = new Info();
            infoForm.Show();
            this.Close();
        }
    }
}
