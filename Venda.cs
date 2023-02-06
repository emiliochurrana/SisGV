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
    public partial class Venda : Form
    {
        double p_Unit, p_Total;
        string id_produto, descricao, quantidade, p_unitario, p_total, id_cliente, nome, endereco, contacto,quant_prod;
        MySqlCommand comando;
        MySqlDataReader ler;
        public Venda()
        {
            InitializeComponent();
        }
        public void dado()
        {
            id_produto = cbID_Produto.Text;
            descricao = txtDescricao.Text;
            quantidade = txtQuant.Text;
            p_unitario = txtP_Unit.Text;
            p_total = txtP_Total.Text;
            id_cliente = cbID_Cliente.Text;
            nome = txtNome_Cliente.Text;
            endereco = txt_Endereco.Text;
            contacto = txtContacto.Text;
            // quantidade = Int32.Parse(quant);
            // id_Gest =Int32.Parse(id_gest);
            //id_Cat = Int32.Parse(id_categoria);
            //id_mar = Int32.Parse(id_marca);

        }


        private void txtDescricao_Click(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            cbID_Produto.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtP_Unit.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            txtP_Total.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            cbID_Cliente.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtNome_Cliente.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            txt_Endereco.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtContacto.BackColor = SystemColors.ControlText;
        }

        private void txtQuant_Click(object sender, EventArgs e)
        {
            txtQuant.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            cbID_Produto.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtP_Unit.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            txtP_Total.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            cbID_Cliente.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtNome_Cliente.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            txt_Endereco.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtContacto.BackColor = SystemColors.ControlText;
        }

        private void txtP_Unit_Click(object sender, EventArgs e)
        {
            txtP_Unit.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            cbID_Produto.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            txtP_Total.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            cbID_Cliente.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtNome_Cliente.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            txt_Endereco.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtContacto.BackColor = SystemColors.ControlText;
        }

        private void txtP_Total_Click(object sender, EventArgs e)
        {
            txtP_Total.BackColor = Color.White;
            panel6.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtP_Unit.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            cbID_Produto.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            cbID_Cliente.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtNome_Cliente.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            txt_Endereco.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtContacto.BackColor = SystemColors.ControlText;
        }

        public void leVenda()
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
                string query = "SELECT * FROM venda";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridVendas.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbID_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbID_Produto.Text == "")
            {
                txtDescricao.Text = "";
                txtQuant.Text = "";
                txtP_Unit.Text = "";
                txtP_Total.Text = "";

            }
            else
            {
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                comando = conn.CreateCommand();

                try
                {
                    conn.Open();
                    string query = "SELECT * FROM produto where id_prod='" + cbID_Produto.Text + "'";
                    comando = new MySqlCommand(query, conn);
                    ler = comando.ExecuteReader();
                    while (ler.Read())
                    {
                        txtDescricao.Text = ler.GetString("descricao");
                        txtQuant.Text = ler.GetString("quantidade");
                        txtP_Unit.Text = ler.GetString("preco_venda");
                        //txtP_Total.Text = ler.GetString("");

                    }
                    conn.Close();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void cbID_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbID_Cliente.Text == "")
            {
                txtNome_Cliente.Text = "";
                txt_Endereco.Text = "";
                txtContacto.Text = "";

            }
            else
            {
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                comando = conn.CreateCommand();

                try
                {
                    conn.Open();
                    string query = "SELECT * FROM cliente where id_cliente='" + cbID_Cliente.Text + "'";
                    comando = new MySqlCommand(query, conn);
                    ler = comando.ExecuteReader();
                    while (ler.Read())
                    {
                        txtNome_Cliente.Text = ler.GetString("nome_completo");
                        txt_Endereco.Text = ler.GetString("endereco");
                        txtContacto.Text = ler.GetString("telefone");
                        //txtP_Total.Text = ler.GetString("");

                    }
                    conn.Close();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            leVenda();
            leClienteID();
            leProdutoID();
        }

        private void txtNome_Cliente_Click(object sender, EventArgs e)
        {
            txtNome_Cliente.BackColor = Color.White;
            panel8.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtP_Unit.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            txtP_Total.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            cbID_Cliente.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            cbID_Produto.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            txt_Endereco.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtContacto.BackColor = SystemColors.ControlText;
        }

        private void btnGerarTotal_Click(object sender, EventArgs e)
        {
            int quant;
            quant = Int32.Parse(txtQuant.Text);
            p_Unit = Double.Parse(txtP_Unit.Text);
            p_Total = quant * p_Unit;
            txtP_Total.Text = Convert.ToString(p_Total);
        }

        private void txt_Endereco_Click(object sender, EventArgs e)
        {
            txt_Endereco.BackColor = Color.White;
            panel9.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtP_Unit.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            txtP_Total.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            cbID_Cliente.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtNome_Cliente.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            cbID_Produto.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtContacto.BackColor = SystemColors.ControlText;
        }

        private void txtContacto_Click(object sender, EventArgs e)
        {
            txtContacto.BackColor = Color.White;
            panel10.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtP_Unit.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            txtP_Total.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            cbID_Cliente.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtNome_Cliente.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            txt_Endereco.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            cbID_Produto.BackColor = SystemColors.ControlText;
        }

        private void cbID_Produto_Click(object sender, EventArgs e)
        {
            cbID_Produto.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtP_Unit.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            txtP_Total.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            cbID_Cliente.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtNome_Cliente.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            txt_Endereco.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtContacto.BackColor = SystemColors.ControlText;
        }

        private void cbID_Cliente_Click(object sender, EventArgs e)
        {
            cbID_Cliente.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtDescricao.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtQuant.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtP_Unit.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            txtP_Total.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            cbID_Produto.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            txtNome_Cliente.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            txt_Endereco.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtContacto.BackColor = SystemColors.ControlText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void leProdutoID()
        {
            dado();
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM produto ORDER BY id_prod";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbID_Produto.Items.Clear();
                cbID_Produto.Items.Add("");
                while (ler.Read())
                {
                    cbID_Produto.Items.Add(ler.GetString("id_prod"));
                    //cbCategoria.Items.Add(ler.GetString("nome"));
                }
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public void leClienteID()
        {
            dado();
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM cliente ORDER BY id_cliente";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbID_Cliente.Items.Clear();
                cbID_Cliente.Items.Add("");
                while (ler.Read())
                {
                    cbID_Cliente.Items.Add(ler.GetString("id_cliente"));
                }
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        public void leProdutoQuat()
        {
            int quant, quanta, total;
            dado();
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM produto ORDER BY id_prod='"+id_produto+"'";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbID_Produto.Items.Clear();
                cbID_Produto.Items.Add("");
                while (ler.Read())
                {
                    quanta=cbID_Produto.Items.Add(ler.GetString("quantidade"));

                    quant = Int32.Parse(quantidade);
                    quanta= quanta - quant;
                    quant_prod = Convert.ToString(quanta);
                }
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            //quant = Int32.Parse(txtQuant.Text);

            
           
            {
                if (txtQuant.Text == "" || txtDescricao.Text == "" || cbID_Produto.Text == "" || cbID_Cliente.Text == "" || txtNome_Cliente.Text == "" || txt_Endereco.Text == "" || txtContacto.Text == "" || txtP_Unit.Text == "" || txtP_Total.Text == "")
                {
                    MessageBox.Show("Preencha os campos");
                }
                try
                {
                    dado();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "INSERT INTO venda (id_cliente,id_produto,nome_completo,endereco,contacto,descricao,quant,p_unitario,p_total) VALUES('" + id_cliente + "','" + id_produto + "','" + nome + "','" + endereco + "','" + contacto + "','" + descricao + "','" + quantidade + "','" + p_unitario + "','" + p_total + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //id_Gest = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    string strSQL = "SELECT * FROM venda";
                    MySqlDataAdapter da = new MySqlDataAdapter(strSQL, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridVendas.DataSource = dt;
                    MessageBox.Show("Venda efeituada com sucesso!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    leProdutoQuat();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE produto SET  quantidade='" + quant_prod + "'WHERE id_prod='"+id_produto+"'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    //MessageBox.Show("Actualização efectuada com sucesso");
                    //lerdados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           
            cbID_Cliente.Text = "";
                cbID_Produto.Text = "";
                txtNome_Cliente.Text = "";
                txt_Endereco.Text = "";
                txtContacto.Text = "";
                txtDescricao.Text = "";
                txtQuant.Text = "";
                txtP_Unit.Text = "";
                txtP_Total.Text = "";

            }
        }
    }
}
