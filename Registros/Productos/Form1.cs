using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.Dao;
using Productos.Modelos;

namespace Productos
{
    public partial class Form1 : Form
    {
        ProductoDao dao = new ProductoDao();
        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Nombre=tbNombre.Text.ToUpper();
            prod.Precio=double.Parse(tbPrecio.Text);
            prod.Codigo=tbCodigo.Text.ToUpper();
            prod.IVA=checkBox1.Checked;
            dao.Agregar(prod);
            LlenarGrid();
            

        }
        public void LlenarGrid()
        {
            this.dgvRegistro.DataSource= dao.VerCarrito();
            this.dgvRegistro.Refresh();
        }
    }
}
