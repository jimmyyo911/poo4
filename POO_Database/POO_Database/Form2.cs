using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POO_Database
{
    public partial class Form2 : Form
    {
        private DataTable dataTable2;
        private Form1 form1;
        public Form2(DataTable dataTable, Form1 form1)
        {
            InitializeComponent();
            dataTable2 = dataTable.Copy();
            this.form1 = form1;
        }

        

       

        private void Form2_Load(object sender, EventArgs e)
        {

            string connectionString1 = "Server=localhost;Database=poo;Uid=root;Pwd=;";
            string query1 = "SELECT nr_matricol, nume, prenume, Init_tata, cnp, data_inscriere, profil, medie_inscriere, grupa FROM Student;";

            using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
            {
                MySqlCommand command1 = new MySqlCommand(query1, connection1);
                connection1.Open();

                MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
                DataTable dataTable1 = new DataTable();
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
                dataTable2.Clear(); // Eliminați această linie pentru a menține datele existente
                adapter2.Fill(dataTable2);

                dataGridView2.DataSource = dataTable2;
            }
        }
        public void UpdateDataGridView2(DataTable dataTable)
        {
            dataGridView2.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable filteredTable = dataTable2.Clone();
            filteredTable.Columns.Remove("cnp");
            filteredTable.Columns.Remove("data_inscriere");
            filteredTable.Columns.Remove("medie_inscriere");

            foreach (DataRow row in dataTable2.Rows)
            {
                DataRow newRow = filteredTable.NewRow();
                newRow.ItemArray = row.ItemArray.Take(7).ToArray(); // Selectati primele 7 coloane dorite (nr_matricol, nume, prenume, init_tata, profil, grupa, disciplina)
                filteredTable.Rows.Add(newRow);
            }

            form1.UpdateDataGridView2(filteredTable);
            form1.Show();
            this.Close();
        }
       
    }
}
