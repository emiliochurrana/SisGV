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
    public partial class EditProduto : Form
    {
        string id,quant, descricao, p_compra, p_venda,id_categoria,id_marca;
        MySqlCommand comando;
        MySqlDataReader ler;
        public EditProduto()
        {
            InitializeComponent();
        }
        public void dado()
        {
            id = cbIdProduto.Text;
            quant = txtQuant.Text;
            descricao = txtDescricao.Text;
            id_categoria = cbCategoria.Text;
            id_marca = cbMarca.Text;
            p_compra = txtCompra.Text;
            p_venda = txtVenda.Text;
        }
        public void leProduto()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM produto ORDER BY id_prod";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbIdProduto.Items.Clear();
                cbIdProduto.Items.Add("");
                while (ler.Read())
                {
                    cbIdProduto.Items.Add(ler.GetString("id_prod"));
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbIdProduto_Click(object sender, EventArgs e)
        {
            cbIdProduto.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
           
        }

        private void txtDescricao_Click(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            cbIdProduto.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
        }

        private void txtQuant_Click(object sender, EventArgs e)
        {
            txtQuant.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            cbIdProduto.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
        }

        private void cbIdProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbId.Text == "")
            {
                cbIdProduto.Text = "";
                txtQuant.Text = "";
                txtDescricao.Text = "";
                cbCategoria.Text = "";
                cbMarca.Text = "";
                txtCompra.Text = "";
                txtVenda.Text = "";

            }
            else
            {
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                comando = conn.CreateCommand();

                try
                {
                    conn.Open();
                    string query = "SELECT * FROM produto where id_prod='" + cbIdProduto.Text + "'";
                    comando = new MySqlCommand(query, conn);
                    ler = comando.ExecuteReader();
                    while (ler.Read())
                    {
                        txtQuant.Text = ler.GetString("quantidade");
                        txtDescricao.Text = ler.GetString("descricao");
                        cbCategoria.Text = ler.GetString("id_categoria");
                        cbMarca.Text = ler.GetString("id_marca");
                        txtCompra.Text = ler.GetString("preco_compra");
                        txtVenda.Text = ler.GetString("preco_venda");

                    }
                    conn.Close();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void EditProduto_Load(object sender, EventArgs e)
        {
            leCategoria();
            leMarca();
            leProduto();
        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            cbCategoria.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            cbIdProduto.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
        }

        private void cbMarca_Click(object sender, EventArgs e)
        {
            cbMarca.BackColor = Color.White;
            panel6.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            cbIdProduto.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
        }

        private void txtCompra_Click(object sender, EventArgs e)
        {
            txtCompra.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            cbIdProduto.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtVenda.BackColor = SystemColors.ControlText;
        }

        private void txtVenda_Click(object sender, EventArgs e)
        {
            txtVenda.BackColor = Color.White;
            panel8.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            cbIdProduto.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            cbMarca.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            txtCompra.BackColor = SystemColors.ControlText;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cbIdProduto.Text == "")
            {

                MessageBox.Show("Preencha os campos");
            }
            else
            {
                try
                {
                    dado();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE produto SET id_categoria='" + id_categoria + "', id_marca='"+id_marca+"',descricao='"+descricao+"',quantidade='"+quant+"',preco_compra='"+p_compra+"',preco_venda='"+p_venda+"'  WHERE id_prod='" + id + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();

                    conn.Close();
                    MessageBox.Show("Actualização efectuada com sucesso");
                    leProduto();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cbIdProduto.Text = "";
            txtQuant.Text = "";
            txtDescricao.Text = "";
            cbCategoria.Text = "";
            cbMarca.Text = "";
            txtCompra.Text = "";
            txtVenda.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbIdProduto.Text == "")
            {

                MessageBox.Show("Preencha o Id");
            }
            try
            {
                dado();
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM produto WHERE id_prod='" + id + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                ler = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Produto removida com sucesso!");
                leProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cbIdProduto.Text = "";
            txtQuant.Text = "";
            txtDescricao.Text = "";
            cbCategoria.Text = "";
            cbMarca.Text = "";
            txtCompra.Text = "";
            txtVenda.Text = "";

        }
    }
}
