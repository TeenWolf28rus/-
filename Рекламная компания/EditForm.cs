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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataSet dataSet;

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void executeDBCommand(String query)
        {
            var connection = new SqlConnection("Data Source=DESKTOP-F24NN2L;Initial Catalog=AdvertisingCompaign;Integrated Security=True");

            dataAdapter = new SqlDataAdapter(query, connection);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String comboItemText = comboBox1.GetItemText(comboBox1.SelectedItem);
            executeDBCommand("select * from " + comboItemText);
            dataGridView.Refresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dataSet);
               
                
                MessageBox.Show("Обновлено успешно");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
