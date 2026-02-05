using System;

namespace Haukcode.ArtNetIdentity.Lookup
{
    internal static class ManufacturerModel
    {
        internal static DeviceModel? GetDeviceModel(int estaCode, int oem)
        {
            switch (estaCode)
            {
                case 0x6A6B:        // DMXking / JPK Systems Limited
                    switch (oem)
                    {
                        case 0x2BD2:
                            return new DeviceModel("DMXking", "LeDMX4 MAX");

                        case 0x2BD3:
                            return new DeviceModel("DMXking", "LeDMX2 MAX");

                        case 0x2BF3:
                            return new DeviceModel("DMXking", "eDMX1 MAX");

                        case 0x096C:
                            return new DeviceModel("DMXking", "LeDMX4 PRO");

                        case 0x0968:
                            return new DeviceModel("DMXking", "eDMX4 PRO");
                    }
                    break;
            }

            return null;
        }
    }
}
