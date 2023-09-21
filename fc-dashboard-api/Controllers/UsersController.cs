using fc_dashboard_api.Interface;
using fc_dashboard_api.Model;
using fc_dashboard_api.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fc_dashboard_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IState_master _state;
        public UsersController(IState_master state_Master)
        {
            _state = state_Master;
        }

        [HttpGet]
        [Route("StateMaster")]
        public async Task<IActionResult> GetState()
        {
            var result = await _state.getState();
            return Ok(result);
        }

        [HttpGet]
        [Route("District")]
        public async Task<ServiceResult<List<District_Master>>> GetDistrict()
        {
            var result = new ServiceResult<List<District_Master>>();
            var dist = await _state.GetDistrict();
            result.SetSuccess(dist);
            return result;
        }
    }
}
