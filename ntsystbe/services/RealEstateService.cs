using Newtonsoft.Json;
using ntsystbe.Dto;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ntsystbe.services
{
    public class RealEstateService : IRealEstateService
    {
        public void addToJson(RealEstateDto realEstateDto)
        {
            string json = JsonConvert.SerializeObject(realEstateDto, Formatting.Indented);
            File.WriteAllText(@"c:\Users\Rocky\Desktop\NtProject\ntsystbe\ntsystbe\nt.json", json);
        }
    }
}
