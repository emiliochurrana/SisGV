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

namespace SisGV
{
    public partial class VerMarca : Form
    {
        MySqlCommand comando;
        MySqlDataReader ler;
        public VerMarca()
        {
            InitializeComponent();
        }
        public void leMarca()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM marca ORDER BY id";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbId.Items.Clear();
                cbId.Items.Add("");
                while (ler.Read())
                {
                    cbId.Items.Add(ler.GetString("id"));
                }
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            try
            {
                conn.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                DataSet tabel = new DataSet();
                BindingSource bsource = new BindingSource();
                string query = "SELECT * FROM marca";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridMarca.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VerMarca_Load(object sender, EventArgs e)
        {
            leMarca();
        }
    }
}
