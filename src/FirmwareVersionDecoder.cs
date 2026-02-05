using System;

namespace Haukcode.ArtNetIdentity
{
    public static class FirmwareVersionDecoder
    {
        /// <summary>
        /// Decodes the firmware version for known manufacturers.
        /// </summary>
        /// <param name="estaCode">Manufacturer ID</param>
        /// <param name="oem">OEM code (not relevant for all manufacturers as they may use the same firmware version schema for all their models</param>
        /// <param name="firmwareVersion">The firmware version field in the ArtPollReply packet</param>
        /// <returns>String representation of the firmware version, or null if unsupported/unknown</returns>
        public static string? GetFirmwareVersion(int estaCode, int oem, short firmwareVersion)
        {
            switch (estaCode)
            {
                case 0x6A6B:        // DMXking / JPK Systems Limited
                    return $"{firmwareVersion >> 8}.{firmwareVersion & 0xff}";
            }

            return null;
        }
    }
}
