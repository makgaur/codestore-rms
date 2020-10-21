using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_rms.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int NumberOfSittings { get; set; }
        public bool IsReserved { get; set; }
    }
}
