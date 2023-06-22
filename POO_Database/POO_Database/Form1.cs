using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POO_Database
{
    public partial class Form1 : Form
    {
        private DataTable dataTable1;
        private DataTable dataTable2;
        public Form1()
        {
            InitializeComponent();
            dataTable1 = new DataTable();
            dataTable2 = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString1 = "Server=localhost;Database=poo;Uid=root;Pwd=;";
            string query1 = "SELECT nr_matricol, nume, prenume, Init_tata, cnp, data_inscriere, profil, medie_inscriere, grupa FROM Student;";

            using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
            {
                MySqlCommand command1 = new MySqlCommand(query1, connection1);
                connection1.Open();

                MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
                dataTable1.Clear();
                adapter1.Fill(dataTable1);

                dataGridView1.DataSource = dataTable1;
            }

            string connectionString2 = "Server=localhost;Database=poo;Uid=root;Pwd=;";
            string query2 = "SELECT nr_matricol, nume, prenume, Init_tata, profil, grupa, disciplina, nota, credite, student_id FROM Note;";

            using (MySqlConnection connection2 = new MySqlConnection(connectionString2))
            {
                MySqlCommand command2 = new MySqlCommand(query2, connection2);
                connection2.Open();

                MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
                dataTable2.Clear();
                adapter2.Fill(dataTable2);

                dataGridView2.DataSource = dataTable2;
            }
        }
        public void UpdateDataGridView1(DataTable newDataTable)
        {
            dataTable1.Clear();
            dataTable1.Merge(newDataTable);
        }

        internal void UpdateDataGridView2(DataTable filteredTable)
        {
            dataGridView2.DataSource = filteredTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2(dataTable1, this);
            form2.Show();
            this.Hide();
        }

    }
}