# Haukcode.ArtNetIdentity [![NuGet Version](http://img.shields.io/nuget/v/Haukcode.ArtNetIdentity.svg?style=flat)](https://www.nuget.org/packages/Haukcode.ArtNetIdentity/)

Identify devices from ArtNet `ArtPollReply` packets by mapping ESTA manufacturer IDs, OEM codes, and firmware version fields to human-readable values.

## Overview

`Haukcode.ArtNetIdentity` is a small .NET Standard 2.1 library that helps resolve device identity details from ArtNet `ArtPollReply` data. It provides:

- ESTA manufacturer name lookup from manufacturer IDs.
- Model name lookup from manufacturer + OEM codes (when known).
- Firmware version decoding for manufacturers with known version formats.

## Installation

Install the NuGet package:

```bash
dotnet add package Haukcode.ArtNetIdentity
```

## Usage

```csharp
using Haukcode.ArtNetIdentity;

var estaCode = 0x6A6B;
var oem = 0x2BD2;
short firmwareVersion = 0x0104;

var manufacturer = Manufacturer.FromEstaCode(estaCode);
var model = DeviceModel.FromEstaAndOem(estaCode, oem);
var firmware = FirmwareVersionDecoder.GetFirmwareVersion(estaCode, oem, firmwareVersion);
```

All methods return `null` when the value is unknown or unsupported.

## API

### `Manufacturer.FromEstaCode(int estaCode)`

Returns the manufacturer name for the given ESTA manufacturer ID. The list is imported from the official ESTA manufacturer ID registry.

### `DeviceModel.FromEstaAndOem(int estaCode, int oem)`

Returns a model name for the combination of ESTA manufacturer ID and OEM code, when known.

### `FirmwareVersionDecoder.GetFirmwareVersion(int estaCode, int oem, short firmwareVersion)`

Returns a decoded firmware version string for manufacturers with a known firmware schema. Returns `null` when not supported.

## Target framework

- .NET Standard 2.1

## Data sources

- ESTA manufacturer registry: https://tsp.esta.org/tsp/working_groups/CP/mfctrIDs.php

## Contributing

Issues and pull requests are welcome. Please include data sources when adding new manufacturer, model, or firmware mappings.

## License

MIT
