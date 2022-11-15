namespace System
{
    namespace Runtime
    {
        public sealed class RuntimeExportAttribute : Attribute
        {
            public RuntimeExportAttribute(string entry) { }
        }

        public sealed class RuntimeImportAttribute : Attribute
        {
            public string DllName { get; }
            public string EntryPoint { get; }

            public RuntimeImportAttribute(string entry)
            {
                EntryPoint = entry;
            }

            public RuntimeImportAttribute(string dllName, string entry)
            {
                EntryPoint = entry;
                DllName = dllName;
            }
        }
    }

    class Array<T> : Array { }
}

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class UnmanagedCallersOnlyAttribute : Attribute
    {
        public string EntryPoint;
        public CallingConvention CallingConvention;
        public Type[] CallConvs;

        public UnmanagedCallersOnlyAttribute() { }
    }

    public enum CallingConvention
    {
        Winapi = 1,
        Cdecl = 2,
        StdCall = 3,
        ThisCall = 4,
        FastCall = 5
    }
}