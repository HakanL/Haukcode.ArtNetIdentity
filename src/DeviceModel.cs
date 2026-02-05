using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using Haukcode.ArtNetIdentity.Lookup;

namespace Haukcode.ArtNetIdentity
{
    public class DeviceModel
    {
        public string? ProductName { get; set; }

        public string? ModelName { get; set; }

        public string? ModelNumber { get; set; }

        public DeviceModel()
        {
        }

        internal DeviceModel(string productName, string? modelName)
        {
            ProductName = productName;
            ModelName = modelName;
        }

        /// <summary>
        /// Returns the model name for the given ESTA and OEM code.
        /// </summary>
        /// <param name="estaCode">Manufacturer ID</param>
        /// <param name="oem">OEM code</param>
        /// <returns>Device model, or null if one isn't known</returns>
        public static DeviceModel? FromEstaAndOem(int estaCode, int oem)
        {
            return ManufacturerModel.GetDeviceModel(estaCode, oem);
        }
    }
}
