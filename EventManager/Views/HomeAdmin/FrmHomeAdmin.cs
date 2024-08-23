using EventManager.Views.CrudCidade;
using EventManager.Views.CrudPais;
using EventManager.Views.CrudUf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager.Views.HomeAdmin
{
    public partial class FrmHomeAdmin : Form
    {
        public FrmHomeAdmin()
        {
            InitializeComponent();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            FrmPais frm = new FrmPais();
            frm.Show();
        }

        private void btnUfs_Click(object sender, EventArgs e)
        {
            FrmUf frm = new FrmUf();
            frm.Show();
        }

        private void btnCidades_Click(object sender, EventArgs e)
        {
            FrmCidade frm = new FrmCidade();
            frm.Show();
        }
    }
}
