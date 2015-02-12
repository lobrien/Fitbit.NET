using System;

namespace Fitbit.Models
{
    public class Device
    {
        public string Battery { get; set; }

        public string Id { get; set; }

        public DateTime LastSyncTime { get; set; }

        public DeviceType Type { get; set; }

        public string DeviceVersion { get; set; } // todo: this should be an enum; "Flex|One|Zip|Ultra|Classic|Aria"

        public string Mac { get; set; }
    }
}