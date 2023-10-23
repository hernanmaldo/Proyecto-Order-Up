using Back.Clases;
using Back.ClasesData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class AltaIngredientes : Form
    {
        public AltaIngredientes()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ingredientes ingredientes = new Ingredientes
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.Parse(txtPrecio.Text)
            };

            IngredientesData.AgregarIngrediente(ingredientes);

        }

        private void AltaIngredientes_Load(object sender, EventArgs e)
        {
            IngredientesData.GetIngredientes().Load();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = IngredientesData.GetIngredientes().Local.ToBindingList();

        }



       
    }
}
