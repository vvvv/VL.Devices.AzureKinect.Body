using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace VL.Devices.AzureKinect.Body
{
    public static class PathHelper
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern void SetDllDirectory(string lpPathName);

        public static void SetRequiredDLLPaths()
        {
            var dllPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var directMLPath = Path.Combine(dllPath, @"..\..\runtimes\win-x64\native");
            SetDllDirectory(directMLPath);

            var cudaPath = Environment.GetEnvironmentVariable("CUDA_PATH");
            cudaPath = Path.Combine(cudaPath, "bin");
            SetDllDirectory(cudaPath);

            var cudnnPath = @"C:\Program Files\Azure Kinect Body Tracking SDK\tools";
            SetDllDirectory(cudnnPath);
        }
    }
}
