using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class IngredientesOpcion
    {
        [Key]
        public int IdIngrentesOpcion { get; set; }

        [ForeignKey("Opcion")]
        public int IdOpcion { get; set; }

        [ForeignKey("Ingredientes")]
        public int IdIngredientes { get; set; }

        public Opcion opcion { get; set; }  

        public Ingredientes ingredientes { get; set; }  






    }
}
