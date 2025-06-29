using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Field, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class FieldOffsetAttribute : Attribute
{
	internal int _val;

	[__DynamicallyInvokable]
	public int Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[SecurityCritical]
	internal static Attribute GetCustomAttribute(RuntimeFieldInfo field)
	{
		if (field.DeclaringType != null && field.GetRuntimeModule().MetadataImport.GetFieldOffset(field.DeclaringType.MetadataToken, field.MetadataToken, out var offset))
		{
			return new FieldOffsetAttribute(offset);
		}
		return null;
	}

	[SecurityCritical]
	internal static bool IsDefined(RuntimeFieldInfo field)
	{
		return GetCustomAttribute(field) != null;
	}

	[__DynamicallyInvokable]
	public FieldOffsetAttribute(int offset)
	{
		_val = offset;
	}
}
