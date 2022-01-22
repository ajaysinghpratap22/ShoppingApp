using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DataModel.CustomModels;
using Shop.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IWebHostEnvironment env;
        private readonly IAdminService adminService;
        public AdminController(IAdminService _adminService,IWebHostEnvironment _env)
        {
            this.adminService = _adminService;
            this.env = _env;
        }
        [HttpPost]
        [Route("AdminLogin")]
        public IActionResult AdminLogin(LoginModel loginModel)
        {
            var data = adminService.AdminLogin(loginModel);
            return Ok(data);
        }
    }
}
