namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class InterfaceTypeAttribute : Attribute
{
	internal ComInterfaceType _val;

	[__DynamicallyInvokable]
	public ComInterfaceType Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[__DynamicallyInvokable]
	public InterfaceTypeAttribute(ComInterfaceType interfaceType)
	{
		_val = interfaceType;
	}

	[__DynamicallyInvokable]
	public InterfaceTypeAttribute(short interfaceType)
	{
		_val = (ComInterfaceType)interfaceType;
	}
}
