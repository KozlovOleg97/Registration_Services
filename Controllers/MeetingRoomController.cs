using Microsoft.AspNetCore.Mvc;
using System.Runtime;
using System;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace Registration_Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeetingRoomController : Controller
    {
        private readonly MeetingRoomSettings _settings;
        public MeetingRoomController(IOptions<MeetingRoomSettings> options)
        {
            _settings = options.Value;
        }
        [HttpGet]
        public IEnumerable<MeetingRoomSettings> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new MeetingRoomSettings
            {
                DateMeeting = DateTime.Now.AddDays(index),
                MaxPeople = _settings.MaxPeople,
                TimeMeetingMin = _settings.TimeMeetingMin
            }).ToArray();
        }
        public IActionResult Index()
        {
            return new ObjectResult(new MeetingRoomSettings
            {
                MaxPeople = _settings.MaxPeople,
                TimeMeetingMin = _settings.TimeMeetingMin,
                DateMeeting = DateTime.Now.AddDays(0),

            });
        }
    }
}
