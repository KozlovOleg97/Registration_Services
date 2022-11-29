using Microsoft.Extensions.Options;

namespace Registration_Services
{
    public class ServiceSettings
    {
        private readonly MeetingRoomSettings _settings;
        public ServiceSettings(IOptions<MeetingRoomSettings> options)
        {
            _settings = options.Value;
        }

        public string GetSettings()
        {
            return $"MaxPeople:{_settings.MaxPeople} , TimeMeetingMin {_settings.TimeMeetingMin}";
        }
    }
}
