using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    public class IngredientesOpcionData
    {
        private static readonly ApplicationDbContext _context;

        public static DbSet<IngredientesOpcion> GetIngredientesOpcion()
        {
            ApplicationDbContext context = _context;
            return _context.ingredientesOpciones;
        }

        public static void AgregarIngredientesOpcion(IngredientesOpcion ingredientesOpcionNuevo)
        {
            _context.ingredientesOpciones.Add(ingredientesOpcionNuevo);
            _context.SaveChanges();
        }

        public static void EliminarIngredientesOpcion(int id)
        {
            var IngredientesOpcionEncontrado = _context.ingredientesOpciones.Find(id);
            if (IngredientesOpcionEncontrado != null)
            {
                _context.ingredientesOpciones.Remove(IngredientesOpcionEncontrado);
                _context.SaveChanges();
            }
        }

        //NO SE HACE MODIFICACION EN LAS CLASES INTERMEDIAS, SOLO SE AGREGA Y ELIMINA, EN CASO DE EQUIVOVARSE
        //QUE SE ELIMINE.
    }
}
