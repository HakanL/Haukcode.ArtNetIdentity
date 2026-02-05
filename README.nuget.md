# Haukcode.ArtNetIdentity

A .NET Standard 2.1 library that identifies devices from ArtNet `ArtPollReply` packets by mapping ESTA manufacturer IDs, OEM codes, and firmware version fields to human-readable values.

## What is this package?

`Haukcode.ArtNetIdentity` is a lightweight identification library designed for the ArtNet lighting control protocol. When working with ArtNet networks, devices send `ArtPollReply` packets containing manufacturer and device information encoded as numeric values. This library decodes these values into readable information, making it easier to identify and manage devices on your network.

The library provides three main capabilities:

1. **ESTA Manufacturer Lookup**: Translates ESTA manufacturer IDs (standardized numeric codes) into manufacturer names using the official ESTA manufacturer registry.

2. **Device Model Identification**: Resolves specific device models when both the manufacturer ID and OEM code are known, helping you identify the exact hardware on your network.

3. **Firmware Version Decoding**: Decodes firmware version numbers for manufacturers with known version formats, providing readable version strings instead of raw numeric values.

## Key Features

- Comprehensive ESTA manufacturer ID database imported from the official registry
- Device model mapping for known manufacturer/OEM combinations
- Firmware version decoding for supported manufacturers
- Null-safe API design - all methods return `null` for unknown or unsupported values
- Zero dependencies
- Targets .NET Standard 2.1 for broad compatibility

## Use Cases

This library is ideal for:

- ArtNet monitoring and diagnostic tools
- Lighting control software that displays device information
- Network discovery applications for entertainment lighting systems
- DMX512/RDM integration tools working with ArtNet transport
- Device inventory and management systems

## API Overview

The library provides three static helper classes:

**Manufacturer.FromEstaCode(int estaCode)**  
Looks up manufacturer name from ESTA manufacturer ID.

**DeviceModel.FromEstaAndOem(int estaCode, int oem)**  
Resolves device model from manufacturer ID and OEM code combination.

**FirmwareVersionDecoder.GetFirmwareVersion(int estaCode, int oem, short firmwareVersion)**  
Decodes firmware version for manufacturers with known version formats.

## Data Quality

The ESTA manufacturer ID database is regularly synchronized with the official ESTA registry to ensure accuracy. Device model and firmware decoding data is contributed by the community and verified against manufacturer documentation when available.

## License

This package is released under the MIT License.
