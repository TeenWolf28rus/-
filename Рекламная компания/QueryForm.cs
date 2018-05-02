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
    public partial class QueryForm : Form
    {
        private String query;
        private String formTitle;

        public QueryForm()
        {
            InitializeComponent();
        }

        public QueryForm(String queryText, String formTitleText)
        {
            InitializeComponent();
            this.query = queryText;
            this.formTitle = formTitleText;
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            this.Text = formTitle;
            request();
        }

        private void request()
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
