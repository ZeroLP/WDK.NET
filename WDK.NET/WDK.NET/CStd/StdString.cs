using System;
using WDK.NET.Enums;
using WDK.NET.Kernel;

namespace WDK.NET.CStd
{
    /// <summary>
    /// Standard C++ string class
    /// </summary>
    public unsafe class StdString
    {
        /// <summary>
        /// Converts standard string into c style string.
        /// </summary>
        /// <param name="str">Stanard string to convert</param>
        /// <returns>returns a pointer to an array that contains a null-terminated sequence of characters.</returns>
        public static char* c_str(string str)
        {
            fixed (void* wc = str)
            {
                //Allocate pool for char* taking the null terminator into consideration
                var buf = Wdm.ExAllocatePool(PoolType.NonPagedPool, (ulong)str.Length + 1);

                //convert wchar_t* to char*
                Wdm.wcstombs((char*)buf, wc, (ulong)(str.Length * 2) + 2);
                return (char*)buf;
            }
        }
    }
}
