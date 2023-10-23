using Back;
using Back.Clases;
using Back.ClasesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Formulario
{
    public partial class VerPedido : Form
    {
        public VerPedido()
        {
            InitializeComponent();
        }

        public List<OpcionPedido> opcionPedidos = new List<OpcionPedido>();
        public Pedido pedido = new Pedido
        {
      
            Fecha = DateTime.Now,
            Cargado = true,
       
        };
        private void VerPedido_Load(object sender, EventArgs e)
        {
             
             PedidoData.AgregarPedido(pedido);
            

        }

        
    }
}
