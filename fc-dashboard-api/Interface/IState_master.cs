using fc_dashboard_api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fc_dashboard_api.Interface
{
    public interface IState_master
    {
        Task<List<State_Master>> getState();
        Task<List<District_Master>> GetDistrict();
    }
}
