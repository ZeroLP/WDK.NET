using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WDK.NET.Enums;

namespace WDK.NET.Kernel
{
    public unsafe class Wdm
    {
        /// <summary>
        /// Allocates pool memory of the specified type and returns a pointer to the allocated block
        /// </summary>
        /// <param name="poolType">Specifies the type of pool memory to allocate.</param>
        /// <param name="size">Specifies the number of bytes to allocate.</param>
        /// <returns>returns NULL if there is insufficient memory in the free pool to satisfy the request. Otherwise the routine returns a pointer to the allocated memory.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        [RuntimeImport("ntoskrnl.exe", "ExAllocatePool")]
        public static extern ulong ExAllocatePool(PoolType poolType, ulong size);

        /// <summary>
        /// Deallocates a block of pool memory.
        /// </summary>
        /// <param name="pool">Specifies the address of the block of pool memory being deallocated.</param>
        [MethodImpl(MethodImplOptions.InternalCall)]
        [RuntimeImport("ntoskrnl.exe", "ExAllocatePool")]
        public static extern void ExFreePool(ulong pool);

        /// <summary>
        /// Saves all processor-specific state that must be preserved across an S4 state(hibernation).
        /// </summary>
        /// <param name="state">Supplies the KPROCESSOR_STATE where the current CPU's state is to be saved.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        [RuntimeImport("ntoskrnl.exe", "KeSaveStateForHibernate")]
        public static extern NTSTATUS KeSaveStateForHibernate(void* state);

        /// <summary>
        /// Sends a string to the kernel debugger if the conditions you specify are met.
        /// </summary>
        /// <param name="ComponentId">Specifies the component calling this routine. This must be one of the component name filter IDs defined in the Dpfilter.h header file.</param>
        /// <param name="level">Specifies the severity of the message being sent.</param>
        /// <param name="Format">Specifies a pointer to the format string to print.</param>
        /// <param name="vararg1"></param>
        /// <param name="vararg2"></param>
        /// <returns>If successful, DbgPrintEx returns the NTSTATUS code STATUS_SUCCESS; otherwise, it returns the appropriate error code.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        [RuntimeImport("ntoskrnl.exe", "DbgPrintEx")]
        public static extern ulong DbgPrintEx(uint ComponentId, uint level, char* Format, ulong vararg1, ulong vararg2);

        /// <summary>
        /// Convert wide-character string to multibyte string.
        /// </summary>
        /// <param name="mbstr">Pointer to an array of char elements long enough to contain the resulting sequence (at most, max bytes).</param>
        /// <param name="wcstr">C wide string to be translated.</param>
        /// <param name="count">Maximum number of bytes to be written to dest.</param>
        /// <returns>The number of bytes written to dest, not including the eventual ending null-character.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        [RuntimeImport("ntoskrnl.exe", "wcstombs")]
        public static extern ulong wcstombs(char* mbstr, void* wcstr, ulong count);
    }
}
