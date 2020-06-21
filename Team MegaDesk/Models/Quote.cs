using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Team_MegaDesk.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public string Customer { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public int Shipping { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Width { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Depth { get; set; }

        public int Drawers { get; set; }

        public string Material { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
