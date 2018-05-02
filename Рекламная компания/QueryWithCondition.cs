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
    public partial class QueryWithCondition : Form
    {
        private String query;
        private String formTitle;

        public QueryWithCondition()
        {
            InitializeComponent();
        }

        public QueryWithCondition(String queryText, String formTitleText)
        {
            InitializeComponent();
            this.query = queryText;
            this.formTitle = formTitleText;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            int idForQuery;
            try
            {
                idForQuery = int.Parse(zakazIdTB.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Введите целое число", "Ошибка ввода");
                return;
            }

            var connection = new SqlConnection("Data Source=DESKTOP-F24NN2L;" +
                "Initial Catalog=AdvertisingCompaign;Integrated Security=True");

            var dataAdapter = new SqlDataAdapter(query + idForQuery.ToString(), connection);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            var mainmMenu = new MainMenu();
            mainmMenu.Show();
            this.Close();
        }

        private void QueryWithCondition_Load(object sender, EventArgs e)
        {
            this.Text = formTitle;
        }
    }
}
