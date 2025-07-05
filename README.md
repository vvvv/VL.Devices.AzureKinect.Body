# VL.Devices.AzureKinect.Body
A package for using Azure Kinect body tracking in VL.  
Based on the [Azure Kinect Body Tracking SDK 1.1.2](https://learn.microsoft.com/en-us/previous-versions/azure/kinect-dk/body-sdk-download).

Try it with vvvv, the visual live-programming environment for .NET  
Download: http://vvvv.org

## Prerequisites
- [BodyTracking SDK 1.1.2](https://learn.microsoft.com/en-us/azure/kinect-dk/body-sdk-download) (in the default install path!)
- [Cuda 11.4](https://developer.nvidia.com/cuda-11-4-0-download-archive) only if wanting to use Cuda instead of DirectML or Gpu as the "Processing Mode"

## Using the library
In order to use this library with VL you have to install the nuget that is available via nuget.org. For information on how to use nugets with VL, see [Managing Nugets](https://thegraybook.vvvv.org/reference/libraries/dependencies.html#manage-nugets) in the VL documentation. As described there you go to the commandline and then type:

    nuget install VL.Devices.AzureKinect.Body

Once the nuget is installed and referenced in your VL document you'll see the category "AzureKinect" under "Devices" in the nodebrowser. 

Demos are available via the Help Browser!

## Sponsors
Development of this library was partially sponsored by
- [Studio Brüll](https://studiobruell.de)
- [wirmachenbunt](https://wirmachenbunt.de)

For custom development requests, please [get in touch](mailto:devvvvs@vvvv.org).