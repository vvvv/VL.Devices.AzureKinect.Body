# VL.Devices.AzureKinect.Body
A package for using Microsoft's Azure Kinect body tracking in VL.

Try it with vvvv, the visual live-programming environment for .NET  
Download: http://visualprogramming.net

## Prerequisites
- [Cuda 11.4](https://developer.nvidia.com/cuda-11-4-0-download-archive)
- [BodyTracking SDK 1.1.0](https://learn.microsoft.com/en-us/azure/kinect-dk/body-sdk-download) (in the default install path)

## Using the library
In order to use this library with VL you have to install the nuget that is available via nuget.org. For information on how to use nugets with VL, see [Managing Nugets](https://vvvv.gitbooks.io/the-gray-book/content/en/reference/libraries/dependencies.html#_manage_nugets) in the VL documentation. As described there you go to the commandline and then type:

    nuget install VL.Devices.AzureKinect.Body

Once the VL.Devices.AzureKinect.Body nuget is installed and referenced in your VL document you'll see the category "AzureKinect" under "Devices" in the nodebrowser. 

Demos are available via the Help Browser!

## Sponsors
Development of this library was partially sponsored by
- [Studio Brüll](https://studiobruell.de)
- [wirmachenbunt](https://wirmachenbunt.de)

For custom development requests, please [get in touch](mailto:devvvvs@vvvv.org).
