using System;

namespace Haukcode.ArtNetIdentity
{
    public static class ManufacturerModel
    {
        /// <summary>
        /// Returns the model name for the given ESTA and OEM code.
        /// </summary>
        /// <param name="estaCode">Manufacturer ID</param>
        /// <param name="oem">OEM code</param>
        /// <returns>Name of the device model, or null if one isn't known</returns>
        public static string? GetModelName(int estaCode, int oem)
        {
            switch (estaCode)
            {
                case 0x6A6B:        // JPK Systems Limited
                    switch (oem)
                    {
                        case 0x2BD2:
                            return "LeDMX4 MAX";

                        case 0x2BD3:
                            return "LeDMX2 MAX";
                    }
                    break;
            }

            return null;
        }
    }
}
