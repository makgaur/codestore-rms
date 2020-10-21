using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_rms.Models
{
    public class ReservationDataTableViewModel
    {
        public int ReservationId { get; set; }
        public string TableName { get; set; }
        public int Size { get; set; }
        public string Timing { get; set; }
    }
}
