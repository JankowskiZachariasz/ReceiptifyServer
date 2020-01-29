using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReceiptifyServer.Services;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using ReceiptifyServer.Entities;

namespace ReceiptifyServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        private ICompaniesService _companies;

        public CompaniesController(ICompaniesService companies) { _companies = companies; }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var companies = _companies.getById(id);
            return Ok(companies);
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Companies> companies = _companies.GetAll();
            return Ok(companies);
        }
    }
}




