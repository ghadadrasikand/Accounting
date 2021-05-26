using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string DocumentDetail { get; set; }
        public DateTime DocumentDate { get; set; }
        public int DocumentPage { get; set; }
        public bool Flag { get; set; }
        public int Bedehkar { get; set; }
        public int Bestankar { get; set; }
        public int TotalBedehkar { get; set; }
        public int TotalBestankar { get; set; }
        public int MandehHesab { get; set; }
        public int AccountId { get; set; }
        //public string NameHesab { get; set; }

    }
}
