namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class ClassInterfaceAttribute : Attribute
{
	internal ClassInterfaceType _val;

	[__DynamicallyInvokable]
	public ClassInterfaceType Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[__DynamicallyInvokable]
	public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
	{
		_val = classInterfaceType;
	}

	[__DynamicallyInvokable]
	public ClassInterfaceAttribute(short classInterfaceType)
	{
		_val = (ClassInterfaceType)classInterfaceType;
	}
}
