using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SisGV
{
    public partial class MenuCaixa : Form
    {
        public MenuCaixa()
        {
            InitializeComponent();
            CustumaizeDesign();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void CustumaizeDesign()
        {
            panelVendSubMenu.Visible = false;
            panelCompSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelVendSubMenu.Visible == true)
                panelVendSubMenu.Visible = false;

            if (panelCompSubMenu.Visible == true)
                panelCompSubMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;

        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 66)
            {
                panelMenu.Width = 209;
            }
            else
                panelMenu.Width = 66;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            PerfilCaixa p = new PerfilCaixa();
            p.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            PerfilCaixa p = new PerfilCaixa();
            p.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVendSubMenu);
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            openChildForm(new Venda());
            hideSubMenu();
        }

        private void btnVisualizarVenda_Click(object sender, EventArgs e)
        {
            openChildForm(new VerVendas());
            hideSubMenu();
        }

        private void btnEditarVenda_Click(object sender, EventArgs e)
        {
            EditarVenda ed =new EditarVenda();
            ed.Show();
        }
   

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnComprovativo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCompSubMenu);
        }
    }
}
