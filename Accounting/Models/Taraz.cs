using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Models
{
    public class Taraz
    {
        public int Id { get; set; }
        public bool Flag { get; set; }
        public int GardeshBedehkar { get; set; }
        public int GardeshBestankar { get; set; }
        public int MandeBedehkar { get; set; }
        public int MandeBestankar { get; set; }

        public int TotalGardeshBedehkar { get; set; }
        public int TotalGardeshBestankar { get; set; }
        public int TotalMandeBedehkar { get; set; }
        public int TotalMandeBestankar { get; set; }
        public int AccountId { get; set; }
    }
}
