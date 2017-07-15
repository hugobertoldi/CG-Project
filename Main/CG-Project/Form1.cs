using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Project
{
    public partial class MainWindowsPCG : Form
    {
        public MainWindowsPCG()
        {
            InitializeComponent();
        }

        private void botonAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente nuevaVentana = new AgregarCliente();

            nuevaVentana.Show();
        }

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto nuevaVentana = new AgregarProducto();

            nuevaVentana.Show();
        }
    }
}
