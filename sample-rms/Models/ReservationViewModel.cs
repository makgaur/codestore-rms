using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sample_rms.Models
{
    public class ReservationViewModel
    {
        public int ReservationId { get; set; }
        public int TableId { get; set; }
        public DateTime Time { get; set; }
    }
}
