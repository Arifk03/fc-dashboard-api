using fc_dashboard_api.Interface;
using fc_dashboard_api.Model;
using fc_dashboard_api.Utility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fc_dashboard_api.Service
{
    public class District : IDistrict
    {
        private readonly FC_db_Context _db_Context;
        public District(FC_db_Context fc_db_Context)
        {
            _db_Context = fc_db_Context;
        }

        public async Task<List<District_Master>> GetDistrict()
        {
            try
            {
                var data = await _db_Context.district_Masters.Select(x => new District_Master()
                {
                    dist_code = x.dist_code,
                    dist_desc = x.dist_desc
                }).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<State_Master>> getState()
        {
            try
            {
                var data = await _db_Context.state_Masters.Select(x => new State_Master()
                {
                    stat_code = x.stat_code,
                    stat_desc = x.stat_desc,
                    code = x.code
                }).ToListAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
