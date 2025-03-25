using APITrafficSign.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITrafficSign.Controllers
{
    [Route("api/traffic-signs")]
    [ApiController]
    public class TrafficSignController : ControllerBase
    {
        private readonly ITrafficSignService _trafficSignService;

        public TrafficSignController(ITrafficSignService trafficSignService)
        {
            _trafficSignService = trafficSignService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrafficSignById(string id)
        {
            var sign = await _trafficSignService.getTrafficSignByIdAsync(id);
            if (sign == null) return NotFound("Biển báo không tồn tại");
            return Ok(sign);
        }
    }

}
