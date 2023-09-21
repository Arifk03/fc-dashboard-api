using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fc_dashboard_api.Model
{
    public class State_Master
    {
        [Key]

        public string stat_code { get; set; }
        public string stat_desc  { get; set; }
        public int code { get; set; }
    }
}
