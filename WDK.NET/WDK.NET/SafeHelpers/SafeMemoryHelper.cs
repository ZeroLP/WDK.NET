using WDK.NET.Enums;
using WDK.NET.Kernel;

namespace WDK.NET.SafeHelpers
{
    /// <summary>
    /// Helper class to support safe memory management.
    /// </summary>
    public class SafeMemoryHelper
    {
        /// <summary>
        /// Allocates pool memory of the specified type and returns a pointer to the allocated block
        /// </summary>
        /// <param name="poolType">Specifies the type of pool memory to allocate.</param>
        /// <param name="allocationSize">Specifies the number of bytes to allocate.</param>
        /// <returns>returns NULL if there is insufficient memory in the free pool to satisfy the request. Otherwise the routine returns a pointer to the allocated memory.</returns>
        public static ulong AllocatePoolMemory(PoolType poolType, uint allocationSize)
        {
            return Wdm.ExAllocatePool(poolType, allocationSize);
        }

        /// <summary>
        /// Allocates non-paged pool memory of the specified allocation size.
        /// </summary>
        /// <param name="allocataionSize">Specifies the number of bytes to allocate.</param>
        /// <returns>returns NULL if there is insufficient memory in the free pool to satisfy the request. Otherwise the routine returns a pointer to the allocated memory.</returns>
        public static ulong AllocateNonPagedPoolMemory(uint allocataionSize)
        {
            return AllocatePoolMemory(PoolType.NonPagedPool, allocataionSize);
        }
    }
}
