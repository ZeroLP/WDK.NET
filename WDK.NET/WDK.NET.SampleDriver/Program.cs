using System.Runtime;
using System.Runtime.InteropServices;

using WDK.NET;
using WDK.NET.Kernel;
using WDK.NET.Enums;
using WDK.NET.SafeHelpers;
using WDK.NET.CStd;

namespace SampleDriver
{
    public unsafe class Program
    {
        //Dummy main entrypoint method for CSC
        static void Main() { }

        //Dummy winmain method for linker
        [RuntimeExport("wmainCRTStartup")]
        static void wmainCRTStartup() { }

        [RuntimeExport("DriverEntry")]
        static NTSTATUS DriverEntry()
        {
            var memPool = SafeMemoryHelper.AllocateNonPagedPoolMemory(0x1000);

            Wdm.DbgPrintEx(0, 0,StdString.c_str("Hello World!"), memPool, 0);
            Wdm.ExFreePool(memPool);

            return NTSTATUS.Success;
        }
    }
}