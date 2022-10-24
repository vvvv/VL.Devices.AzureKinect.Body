# VL.Devices.AzureKinect.Body
Set of nodes to use Azure Kinect BodyTracking with VL

Try it with vvvv, the visual live-programming environment for .NET  
Download: http://visualprogramming.net

## Using the library
In order to use this library with VL you have to install the nuget that is available via nuget.org. For information on how to use nugets with VL, see [Managing Nugets](https://vvvv.gitbooks.io/the-gray-book/content/en/reference/libraries/dependencies.html#_manage_nugets) in the VL documentation. As described there you go to the commandline and then type:

    nuget install VL.Devices.AzureKinect.Body

Once the VL.Devices.AzureKinect.Body nuget is installed and referenced in your VL document you'll see the category "AzureKinect" under "Devices" in the nodebrowser. 

Demos are available via the Help Browser!

## Bodytracking

For better GPU based body tracking, use the latest preview of the nuget, instead of latest stable!
And make sure to install:
- Cuda 11.4
- BodyTracking SDK 1.1.0 (in the default install path)
