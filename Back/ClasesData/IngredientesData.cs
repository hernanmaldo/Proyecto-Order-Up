using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    public class IngredientesData
    {
        public static ApplicationDbContext _context = Principal.context;

        public static DbSet<Ingredientes> GetIngredientes()
        {
            ApplicationDbContext context = _context;
            return _context.ingredientes;
        }

        public static void AgregarIngrediente(Ingredientes ingredienteNuevo)
        {
            _context.ingredientes.Add (ingredienteNuevo);
            _context.SaveChanges ();
        }

        public static void EliminarIngrediente(int id)
        {
            var IngredienteEncontrado = _context.ingredientes.Find (id);
            if (IngredienteEncontrado != null)
            {
                _context.ingredientes.Remove (IngredienteEncontrado);
                _context.SaveChanges ();
            }
        }

        public static void ModificarIngrediente(Ingredientes ingredienteModificado)
        {
            var IngredienteEncontrado = _context.ingredientes.Find (ingredienteModificado.IdIngredientes);
            if (IngredienteEncontrado != null)
            {
                IngredienteEncontrado.Precio = ingredienteModificado.Precio;
                _context.SaveChanges ();
            }
        }
    }
}
