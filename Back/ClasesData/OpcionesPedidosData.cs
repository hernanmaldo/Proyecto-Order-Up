using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    public class OpcionesPedidosData
    {
        private static readonly ApplicationDbContext _context;

        public static DbSet<OpcionPedido> GetOpcionesPedidos()
        {
            ApplicationDbContext context = _context;
            return _context.opcionesPedidos;
        }

        public static void AgregarOpcionesPedidos(OpcionPedido OpcionPedidoNuevo)
        {
            _context.opcionesPedidos.Add(OpcionPedidoNuevo);
            _context.SaveChanges();
        }

        public static void EliminarOpcionesPedidos(int id)
        {
            var OpcionPedidoEncontrado = _context.opcionesPedidos.Find(id);
            if (OpcionPedidoEncontrado != null)
            {
                _context.opcionesPedidos.Remove(OpcionPedidoEncontrado);
                _context.SaveChanges();
            }
        }

        //NO SE HACE MODIFICACION EN LAS CLASES INTERMEDIAS, SOLO SE AGREGA Y ELIMINA, EN CASO DE EQUIVOVARSE
        //QUE SE ELIMINE.
    }
}
