namespace System
{
    public class Object
    {
#pragma warning disable 169
        // The layout of object is a contract with the compiler.
        private IntPtr m_pMethodTable;
#pragma warning restore 169
    }
    public struct Void { }

    // The layout of primitive types is special cased because it would be recursive.
    // These really don't need any fields to work.
    public struct Boolean { }
    public struct Char { }
    public struct SByte { }
    public struct Byte { }
    public struct Int16 { }
    public struct UInt16 { }
    public struct Int32 { }
    public struct UInt32 { }
    public struct Int64 { }
    public struct UInt64 { }
    public struct IntPtr { }
    public struct UIntPtr { }
    public struct Single { }
    public struct Double { }

    public abstract class Type { }

    public abstract class ValueType { }
    public abstract class Enum : ValueType { }

    public struct Nullable<T> where T : struct { }

    public sealed class String { public readonly int Length; }
    public abstract class Array { }
    public abstract class Delegate { }
    public abstract class MulticastDelegate : Delegate { }

    public struct RuntimeTypeHandle { }
    public struct RuntimeMethodHandle { }
    public struct RuntimeFieldHandle { }

    public class Attribute { }

    public sealed class AttributeUsageAttribute : Attribute
    {
        internal AttributeTargets m_attributeTarget = AttributeTargets.All; // Defaults to all
        internal bool m_allowMultiple = false; // Defaults to false
        internal bool m_inherited = true; // Defaults to true

        internal static AttributeUsageAttribute Default = new AttributeUsageAttribute(AttributeTargets.All);

        //Constructors 
        public AttributeUsageAttribute(AttributeTargets validOn)
        {
            m_attributeTarget = validOn;
        }
        internal AttributeUsageAttribute(AttributeTargets validOn, bool allowMultiple, bool inherited)
        {
            m_attributeTarget = validOn;
            m_allowMultiple = allowMultiple;
            m_inherited = inherited;
        }


        //Properties 
        public AttributeTargets ValidOn
        {
            get { return m_attributeTarget; }
        }

        public bool AllowMultiple
        {
            get { return m_allowMultiple; }
            set { m_allowMultiple = value; }
        }

        public bool Inherited
        {
            get { return m_inherited; }
            set { m_inherited = value; }
        }
    }

    public enum AttributeTargets
    {
        All = 32767,
        Assembly = 1,
        Class = 4,
        Constructor = 32,
        Delegate = 4096,
        Enum = 15,
        Eevent = 512,
        Field = 256,
        GenericParameter = 16384,
        Interface = 1024,
        Method = 64,
        Module = 2,
        Parameter = 2048,
        Property = 128,
        ReturnValue = 8192,
        Struct = 8
    }

    public static partial class AppContext
    {
        public static object? GetData(string name)
        {
            return null;
        }

        public static void SetData(string name, object? data)
        {
            /*if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (s_dataStore == null)
            {
                Interlocked.CompareExchange(ref s_dataStore, new Dictionary<string, object?>(), null);
            }

            lock (s_dataStore)
            {
                s_dataStore[name] = data;
            }*/
        }
    }
}