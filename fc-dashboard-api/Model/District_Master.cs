using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fc_dashboard_api.Model
{
    public class District_Master
    {
        [Key]
        public string dist_code { get; set; }
        public string dist_desc { get; set; }
    }
}
