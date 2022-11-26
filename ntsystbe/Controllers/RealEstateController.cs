using Microsoft.AspNetCore.Mvc;
using ntsystbe.Dto;
using ntsystbe.services;
using System;

namespace ntsystbe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RealEstateController : ControllerBase
    {
        private readonly IRealEstateService _realEstateService;

        public RealEstateController(IRealEstateService realEstateService)
        {
            _realEstateService = realEstateService;
        }

        [HttpPost]
        public void Get([FromBody] RealEstateDto realEstateDto)
        {
            _realEstateService.addToJson(realEstateDto);
        }

    }
}