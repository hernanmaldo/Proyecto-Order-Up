using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    public class ReportePedidosData
    {
        private static readonly ApplicationDbContext _context;

        public static DbSet<ReportePedido> GetReportesPedidos()
        {
            ApplicationDbContext context = _context;
            return _context.reportePedidos;
        }

        public static void AgregarReportePedido(ReportePedido ReportePedidoNuevo)
        {
            _context.reportePedidos.Add(ReportePedidoNuevo);
            _context.SaveChanges();
        }

        public static void EliminarReportePedido(int id)
        {
            var ReportePedidoEncontrado = _context.reportePedidos.Find(id);
            if (ReportePedidoEncontrado != null)
            {
                _context.reportePedidos.Remove(ReportePedidoEncontrado);
                _context.SaveChanges();
            }
        }

        //NO SE HACE MODIFICACION EN LAS CLASES INTERMEDIAS, SOLO SE AGREGA Y ELIMINA, EN CASO DE EQUIVOVARSE
        //QUE SE ELIMINE.
    }
}
