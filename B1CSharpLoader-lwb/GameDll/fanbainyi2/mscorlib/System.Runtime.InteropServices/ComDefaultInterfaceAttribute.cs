namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class ComDefaultInterfaceAttribute : Attribute
{
	internal Type _val;

	[__DynamicallyInvokable]
	public Type Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[__DynamicallyInvokable]
	public ComDefaultInterfaceAttribute(Type defaultInterface)
	{
		_val = defaultInterface;
	}
}
