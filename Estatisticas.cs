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
using System.Collections;

namespace SisGV
{
    public partial class Estatisticas : Form
    {
        static string conex = "Server = localhost; Database = sisgv; Uid = root";
        MySqlConnection conn = new MySqlConnection(conex);
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Estatisticas()
        {
            InitializeComponent();
        }

        private void Estatisticas_Load(object sender, EventArgs e)
        {
           /* GrafCategorias();
            ProdPreferidos();
            DashboardDados();*/
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        /* ArrayList Categoria = new ArrayList();
ArrayList QuantProd = new ArrayList();
ArrayList Produto = new ArrayList();
ArrayList Quant = new ArrayList();
private void GrafCategorias()
{
cmd = new MySqlCommand("ProdPorCategoria", conn);
cmd.CommandType = CommandType.StoredProcedure;
conn.Open();
dr = cmd.ExecuteReader();
while (dr.Read())
{
Categoria.Add(dr.GetString(0));
QuantProd.Add(dr.GetInt32(1));
}
chartProdCategoria.Series[0].Points.DataBindXY(Categoria, QuantProd);
dr.Close();
conn.Close();

}
private void ProdPreferidos()
{
cmd = new MySqlCommand("ProdPreferidos", conn);
cmd.CommandType = CommandType.StoredProcedure;
conn.Open();
dr = cmd.ExecuteReader();
while (dr.Read())
{
Produto.Add(dr.GetString(0));
Quant.Add(dr.GetInt32(1));
}
chartProdPreferidos.Series[0].Points.DataBindXY(Produto, Quant);
dr.Close();
conn.Close();

}
private void DashboardDados()
{
cmd = new MySqlCommand("DashboardDados", conn);
cmd.CommandType = CommandType.StoredProcedure;
MySqlParameter total = new MySqlParameter("@totvendas", 0);total.Direction = ParameterDirection.Output;
MySqlParameter nprod = new MySqlParameter("@nprod", 0); nprod.Direction = ParameterDirection.Output;
MySqlParameter nmarc = new MySqlParameter("@nmarc", 0); nmarc.Direction = ParameterDirection.Output;
MySqlParameter ncateg = new MySqlParameter("@ncateg", 0); ncateg.Direction = ParameterDirection.Output;
MySqlParameter nclient = new MySqlParameter("@nclient", 0); nclient.Direction = ParameterDirection.Output;
MySqlParameter ngest = new MySqlParameter("@ngest", 0); ngest.Direction = ParameterDirection.Output;
MySqlParameter ncaixa = new MySqlParameter("@ncaixa", 0); ncaixa.Direction = ParameterDirection.Output;
MySqlParameter ngerente = new MySqlParameter("@ngerente", 0); ngerente.Direction = ParameterDirection.Output;
cmd.Parameters.Add(total);
cmd.Parameters.Add(nprod);
cmd.Parameters.Add(nmarc);
cmd.Parameters.Add(ncateg);
cmd.Parameters.Add(nclient);
cmd.Parameters.Add(ngest);
cmd.Parameters.Add(ncaixa);
cmd.Parameters.Add(ngerente);
conn.Open();
cmd.ExecuteNonQuery();
lblTotalVendas.Text = cmd.Parameters["@totvendas"].Value.ToString();
lblQuantProduto.Text = cmd.Parameters["@nprod"].Value.ToString();
lblQuantMarca.Text = cmd.Parameters["@nmarc"].Value.ToString();
lblQuantCategoria.Text = cmd.Parameters["@ncateg"].Value.ToString();
lblQuantCliente.Text = cmd.Parameters["@nclient"].Value.ToString();
lblQuantGestor.Text = cmd.Parameters["@ngest"].Value.ToString();
lblQuantCaixa.Text = cmd.Parameters["@ncaixa"].Value.ToString();
lblQuantGerente.Text = cmd.Parameters["@ngerente"].Value.ToString();
conn.Close();
}*/
    }
}
