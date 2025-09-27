using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.Modelos;

namespace Productos.Dao
{
    public class ProductoDao
    {
        
        private Producto[] carrito = new Producto[10];
        private int pos = 0;
        public void Agregar(Producto prod)
        {
            try
            {

            
            carrito[pos++] = prod;
            }catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Tu mama ya anda en bolas por tu culpa", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        } 
        public Producto[] VerCarrito()

        {
            return carrito;
        }

    }
}
