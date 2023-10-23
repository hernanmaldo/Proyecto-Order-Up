using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    public class OpcionData
    {
        public static ApplicationDbContext _context = Principal.context;
        public static DbSet<Opcion> GetOpcion()
        {
            ApplicationDbContext context = _context;
            return _context.opciones;
        }

        public static void AgregarOpcion(Opcion opcionNuevo)
        {
            _context.opciones.Add (opcionNuevo);
            _context.SaveChanges();
        }

        public static void EliminarOpcion(int IdOpcion)
        {
            var OpcionEncontrada = _context.opciones.Find (IdOpcion);
            if (OpcionEncontrada != null)
            {
                _context.opciones.Remove (OpcionEncontrada);
                _context.SaveChanges ();
            }
        }

        //public void ModificarOpcion(Opcion OpcionModificada)
        //{
        //    var IngredienteEncontrado = _context.opciones.Find(OpcionModificada.IdOpcion);
        //    if (IngredienteEncontrado != null)
        //    {
        //        IngredienteEncontrado.Precio = OpcionModificada.IdOpcion;
        //        _context.SaveChanges();
        ////    }
    }
}
