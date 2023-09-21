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
        private readonly IDistrict _district;
        public UsersController(IDistrict district)
        {
            _district = district;
        }


        [HttpGet]
        [Route("District")]
        public async Task<ServiceResult<List<District_Master>>> GetDistrict()
        {
            var result = new ServiceResult<List<District_Master>>();
            var dist = await _district.GetDistrict();
            result.SetSuccess(dist);
            return result;
        }
    }
}
