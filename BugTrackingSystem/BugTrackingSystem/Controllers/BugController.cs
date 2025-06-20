using BugTrackingSystem.Managers;
using BugTrackingSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BugTrackingSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BugController : ControllerBase
    {
        private readonly ILogger<BugController> _logger;
        private BugManager _manager;

        public BugController(ILogger<BugController> logger)
        {
            _logger = logger;
            _manager = new BugManager();
        }

        [HttpGet(Name = "GetAllBugs")]
        public IEnumerable<BugModel> Get()
        {
           return _manager.GetAllBugs();
        }
    }
}
