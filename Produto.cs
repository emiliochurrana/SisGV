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
    public partial class Produto : Form
    {
        string quant, descricao, p_compra, p_venda,id_categoria,id_marca;
        int id_Gest;
        MySqlCommand comando;
        MySqlDataReader ler;
        public string cod_get { get; set; }


        public Produto()
        {
            InitializeComponent();
        }
        public void dado()
        {
            quant = txtQuant.Text;
            descricao = txtDescricao.Text;
            id_categoria = cbCategoria.Text;
            id_marca = cbMarca.Text;
            p_compra = txtCompra.Text;
            p_venda = txtVenda.Text;
           // quantidade = Int32.Parse(quant);
           // id_Gest =Int32.Parse(id_gest);
            //id_Cat = Int32.Parse(id_categoria);
            //id_mar = Int32.Parse(id_marca);

        }

        public void leProduto()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();
            try
            {
                conn.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                DataSet tabel = new DataSet();
                BindingSource bsource = new BindingSource();
                string query = "SELECT * FROM produto";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridProduto.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void leCategoria()
        {
            dado();
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM categoria ORDER BY id";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbCategoria.Items.Clear();
                cbCategoria.Items.Add("");
                while (ler.Read())
                {
                    cbCategoria.Items.Add(ler.GetString("id"));
                    //cbCategoria.Items.Add(ler.GetString("nome"));
                }
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            /*try
            {
                conn.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                DataSet tabel = new DataSet();
                BindingSource bsource = new BindingSource();
                string query = "SELECT * FROM produto";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridProduto.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        public void leMarca()
        {
            dado();
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM marca ORDER BY id";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbMarca.Items.Clear();
                cbMarca.Items.Add("");
                while (ler.Read())
                {
                    cbMarca.Items.Add(ler.GetString("id"));
                    //cbMarca.Items.Add(ler.GetString("nome"));
                    
                }
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            /*try
            {
                conn.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                DataSet tabel = new DataSet();
                BindingSource bsource = new BindingSource();
                string query = "SELECT * FROM produto";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridProduto.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        /*public void leGestor()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT  id_gest FROM gestor ORDER BY id_gest";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbCategoria.Items.Clear();
                cbCategoria.Items.Add("");
                while (ler.Read())
                {
                    id_gest.Add(ler.GetString("id_gest"));
                }
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            /*try
            {
                conn.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                DataSet tabel = new DataSet();
                BindingSource bsource = new BindingSource();
                string query = "SELECT * FROM produto";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridProduto.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtQuant_Click(object sender, EventArgs e)
        {
            txtQuant.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            leCategoria();
            leMarca();
            leProduto();
        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            cbCategoria.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
        }
        private void txtDescricao_Click(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
        }

        private void cbMarca_Click(object sender, EventArgs e)
        {
            cbMarca.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;

        }

        private void txtCompra_Click_1(object sender, EventArgs e)
        {
            txtCompra.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
        }

        private void txtVenda_Click_1(object sender, EventArgs e)
        {
            txtVenda.BackColor = Color.White;
            panel8.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dado();
            if (txtQuant.Text == "" || txtDescricao.Text == "" || cbCategoria.Text == ""|| cbMarca.Text==""||txtCompra.Text==""||txtVenda.Text=="")
            {
                MessageBox.Show("Preencha os campos");
            }
            try
            {
                dado();
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO produto (id_categoria,id_marca,quantidade,descricao,preco_compra,preco_venda) VALUES('" + id_categoria + "','" + id_marca + "','" + quant + "','" + descricao + "','" + p_compra + "','" + p_venda + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                //id_Gest = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                string strSQL = "SELECT * FROM produto";
                MySqlDataAdapter da = new MySqlDataAdapter(strSQL, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridProduto.DataSource = dt;
                MessageBox.Show("Cadastro efeituado com sucesso!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtQuant.Text = "";
            txtDescricao.Text = "";
            cbCategoria.Text = "";
            cbMarca.Text = "";
            txtCompra.Text = "";
            txtVenda.Text = "";
            

        }
    }
}
