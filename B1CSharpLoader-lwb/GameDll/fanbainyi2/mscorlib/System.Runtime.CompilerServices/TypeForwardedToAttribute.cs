using System.Reflection;
using System.Security;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
[__DynamicallyInvokable]
public sealed class TypeForwardedToAttribute : Attribute
{
	private Type _destination;

	[__DynamicallyInvokable]
	public Type Destination
	{
		[__DynamicallyInvokable]
		get
		{
			return _destination;
		}
	}

	[__DynamicallyInvokable]
	public TypeForwardedToAttribute(Type destination)
	{
		_destination = destination;
	}

	[SecurityCritical]
	internal static TypeForwardedToAttribute[] GetCustomAttribute(RuntimeAssembly assembly)
	{
		Type[] o = null;
		RuntimeAssembly.GetForwardedTypes(assembly.GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		TypeForwardedToAttribute[] array = new TypeForwardedToAttribute[o.Length];
		for (int i = 0; i < o.Length; i++)
		{
			array[i] = new TypeForwardedToAttribute(o[i]);
		}
		return array;
	}
}
