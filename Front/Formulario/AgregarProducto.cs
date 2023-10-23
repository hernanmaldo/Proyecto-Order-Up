using Back;
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

namespace Front.Formulario
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }


        public List<Ingredientes> ingredientes = new List<Ingredientes>();



        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            comboBoxingredientes.DataSource = null;
            comboBoxingredientes.DataSource = IngredientesData.GetIngredientes().ToList();

            comboBoxingredientes.DisplayMember = "Nombre";

            listBox1.DataSource = null;
            listBox1.DataSource = ingredientes;
            listBox1.DisplayMember = "Nombre";





        }



        private void button4_Click(object sender, EventArgs e)
        {
            ingredientes.Add((Ingredientes)comboBoxingredientes.SelectedItem);
            listBox1.DataSource = null;
            listBox1.DataSource = ingredientes;
            listBox1.DisplayMember = "Nombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opcion Opcion = new Opcion
            {
                Nombre = txtNombre.Text,
                Descripcion = txtdescripcion.Text,
                Precio = decimal.Parse(txtPrecio.Text),

                Tipo = comboBoxingredientes.Text,

            };

            OpcionData.AgregarOpcion(Opcion);


            foreach (Ingredientes Ingredientes in ingredientes)
            {
                IngredientesOpcion ingredientesOpcion = new IngredientesOpcion
                {

                    ingredientes = Ingredientes,
                    opcion = Opcion
                };
                IngredientesData._context.ingredientesOpciones.Add(ingredientesOpcion);
                IngredientesData._context.SaveChanges();
                Console.WriteLine("Guardado");


            }

            ingredientes = new List<Ingredientes>();

        }

        private void button3_Click(object sender, EventArgs e)
        {
             
           
        }
    }
}


