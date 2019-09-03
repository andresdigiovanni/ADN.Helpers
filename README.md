# Helpers and Utilities Library for .NET

ADN.Helpers is a cross-platform open-source library which provides helpers classes to .NET developers.

[![Build Status](https://travis-ci.org/andresdigiovanni/ADN.Helpers.svg?branch=master)](https://travis-ci.org/andresdigiovanni/ADN.Helpers)
[![NuGet](https://img.shields.io/nuget/v/ADN.Helpers.svg)](https://www.nuget.org/packages/ADN.Helpers/)
[![BCH compliance](https://bettercodehub.com/edge/badge/andresdigiovanni/ADN.Helpers?branch=master)](https://bettercodehub.com/)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.Helpers&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.Helpers)
[![Quality](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.Helpers&metric=alert_status)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.Helpers)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Basic usage

Example EnumHelper:

```csharp
enum Foo
{
    A, B, C, D
}
var value = "A";
var type = typeof(Foo);
var ignoreCase = true;
var result = EnumHelper.GetEnumValue(type, value, ignoreCase);

/*
 result is Foo.A
 */
```

## Installation

ADN.Helpers runs on Windows, Linux, and macOS.

Once you have an app, you can install the ADN.Helpers NuGet package from the NuGet package manager:

```
Install-Package ADN.Helpers
```

Or alternatively you can add the ADN.Helpers package from within Visual Studio's NuGet package manager.

## Examples

Please find examples and the documentation at the [wiki](https://github.com/andresdigiovanni/ADN.Helpers/wiki) of this repository.

## Contributing

We welcome contributions! Please review our [contribution guide](CONTRIBUTING.md).

## License

ADN.Helpers is licensed under the [MIT license](LICENSE).
