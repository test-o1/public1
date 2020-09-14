using Microsoft.AspNetCore.Mvc;
using NugetLibrary;

namespace NugetTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersionController
    {
        [HttpGet]
        public string Get()
        {
            return new TestVersion().GetAssemblyVersion();
        }
    }
}
