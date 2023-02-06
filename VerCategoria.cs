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
    public partial class VerCategoria : Form
    {
        MySqlCommand comando;
        MySqlDataReader ler;
        public VerCategoria()
        {
            InitializeComponent();
        }
        public void leCategoria()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM categoria ORDER BY id";
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
                string query = "SELECT * FROM categoria";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCategoria.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void VerCategoria_Load(object sender, EventArgs e)
        {
            leCategoria();
        }
    }
}
