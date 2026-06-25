using System;

namespace Haukcode.ArtNetIdentity.Lookup
{
    internal static class ManufacturerModel
    {
        internal static DeviceModel? GetDeviceModel(int estaCode, int oem)
        {
            switch (estaCode)
            {
                case 0x454E:        // ENTTEC Pty Ltd
                    switch (oem)
                    {
                        case 400:
                            return new DeviceModel("ENTTEC", "S-PLAY SP1-1");
                    }
                    break;

                case 0x6A6B:        // DMXking / JPK Systems Limited
                    switch (oem)
                    {
                        case 0x0968:
                            return new DeviceModel("DMXking", "eDMX4 PRO");

                        case 0x0969:
                            return new DeviceModel("DMXking", "eDMX2 PRO");

                        case 0x096A:
                            return new DeviceModel("DMXking", "eDMX1 PRO");

                        case 0x096B:
                            return new DeviceModel("DMXking", "eDMX4 PRO DIN");

                        case 0x096C:
                            return new DeviceModel("DMXking", "LeDMX4 PRO");

                        case 0x096D:
                            return new DeviceModel("DMXking", "ultraDMX2 PRO");

                        case 0x096E:
                            return new DeviceModel("DMXking", "eDMX4 PRO ISODIN");

                        case 0x2BD2:
                            return new DeviceModel("DMXking", "LeDMX4 MAX");

                        case 0x2BD3:
                            return new DeviceModel("DMXking", "LeDMX2 MAX");

                        case 0x2BD4:
                            return new DeviceModel("DMXking", "eDMX4 MAX ISODIN22");

                        case 0x2BD5:
                            return new DeviceModel("DMXking", "eDMX4 MAX DIN");

                        case 0x2BD6:
                            return new DeviceModel("DMXking", "ultraDMX MAX");

                        case 0x2BF1:
                            return new DeviceModel("DMXking", "eDMX4 MAX");

                        case 0x2BF2:
                            return new DeviceModel("DMXking", "eDMX2 MAX");

                        case 0x2BF3:
                            return new DeviceModel("DMXking", "eDMX1 MAX");

                        case 0x2BFC:
                            return new DeviceModel("DMXking", "eDMX1 MAX DIN");

                        case 0x2C64:
                            return new DeviceModel("DMXking", "eDMX4 MAX ISODIN");

                        case 0x2C65:
                            return new DeviceModel("DMXking", "eDMX8 MAX");

                        case 0x2C72:
                            return new DeviceModel("DMXking", "eDMX8 MAX DIN");
                    }
                    break;
            }

            return null;
        }
    }
}
