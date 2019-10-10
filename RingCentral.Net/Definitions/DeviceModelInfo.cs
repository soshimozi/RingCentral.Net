namespace RingCentral
{
    public class DeviceModelInfo
    {
        /// <summary>
        /// Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier
        /// </summary>
        public string id;

        /// <summary>
        /// Device name
        /// </summary>
        public string name;

        /// <summary>
        /// Addons description
        /// Required
        /// </summary>
        public DeviceAddonInfo[] addons;

        /// <summary>
        /// Device feature or multiple features supported
        /// </summary>
        public string[] features;
    }
}