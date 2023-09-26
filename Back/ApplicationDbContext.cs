using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Back.Clases;
using Microsoft.EntityFrameworkCore;

namespace Back
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Ingredientes> ingredientes { get; set; }
        public DbSet<Opcion> opciones { get; set; }
        public DbSet<OpcionPedido> opcionesPedidos { get; set; }
        public DbSet<IngredientesOpcion> ingredientesOpciones { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
        public DbSet<Reporte> reporte { get; set; }
        public DbSet<ReportePedido> reportePedidos { get; set; }
        public DbSet<Usuario> usuarios { get; set; }




    }
}
