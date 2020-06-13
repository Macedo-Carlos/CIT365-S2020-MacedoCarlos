using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Team_MegaDesk.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public string Customer { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int Shipping { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int Drawers { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
    }
}
