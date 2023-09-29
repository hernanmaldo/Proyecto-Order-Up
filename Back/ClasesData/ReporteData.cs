using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    public class ReporteData
    {

        private static readonly ApplicationDbContext _context;

        public static DbSet<Reporte> GetReporte()
        {
            ApplicationDbContext context = _context;
            return _context.reporte;
        }

        public static void AgregarReporte(Reporte reporteNuevo)
        {
            _context.reporte.Add (reporteNuevo);
            _context.SaveChanges();
        }

        public static void EliminarReporte(int IdReporte)
        {
            var ReporteEncontrado = _context.reporte.Find (IdReporte);
            if (ReporteEncontrado != null)
            {
                _context.reporte.Remove (ReporteEncontrado);
                _context.SaveChanges ();
            }
        }

        //public void ModificarReporte(Reporte ReporteModificado)
        //{
        //    var IngredienteEncontrado = _context.ingredientes.Find(ReporteModificado.IdReporte);
        //    if (IngredienteEncontrado != null)
        //    {
        //        IngredienteEncontrado.Precio = ReporteModificado.IdReporte;
        //        _context.SaveChanges();
        //    }
        //}
    }
}
