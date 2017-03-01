# AzureIoTGatewayWrapper
A C# wrapper for the Azure IoT Gateway SDK.

## Usage:
Clone this repo and include the project in your .NET project and reference it to boostrap an Azure IoT Gateway process from JSON.

*Example:*
```
  var gateway = Gateway.CreateFromJson(jsonPath);

  Gateway.Destroy(gateway);
```
