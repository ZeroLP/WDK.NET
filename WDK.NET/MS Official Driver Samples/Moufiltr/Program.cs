using System.Runtime;
using System.Runtime.InteropServices;

using WDK.NET;
using WDK.NET.Kernel;
using WDK.NET.Enums;
using WDK.NET.SafeHelpers;
using WDK.NET.CStd;

namespace Moufiltr
{
    internal unsafe class Program
    {
        //Dummy main entrypoint method for CSC
        static void Main() { }

        //Dummy winmain method for linker
        [RuntimeExport("wmainCRTStartup")]
        static void wmainCRTStartup() { }

        [RuntimeExport("DriverEntry")]
        static NTSTATUS DriverEntry()
        {
            return NTSTATUS.Success;
        }
    }
}