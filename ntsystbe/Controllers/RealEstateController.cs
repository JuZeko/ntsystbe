using Microsoft.AspNetCore.Mvc;
using ntsystbe.Dto;

namespace ntsystbe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RealEstateController : ControllerBase
    {

        [HttpPost]
        public void Get([FromBody] RealEstateDto realEstateDto)
        {
            var smtha = realEstateDto;
        }

    }
}