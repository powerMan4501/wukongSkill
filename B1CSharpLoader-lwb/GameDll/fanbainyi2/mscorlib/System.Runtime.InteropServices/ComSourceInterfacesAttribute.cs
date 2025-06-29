namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Class, Inherited = true)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class ComSourceInterfacesAttribute : Attribute
{
	internal string _val;

	[__DynamicallyInvokable]
	public string Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[__DynamicallyInvokable]
	public ComSourceInterfacesAttribute(string sourceInterfaces)
	{
		_val = sourceInterfaces;
	}

	[__DynamicallyInvokable]
	public ComSourceInterfacesAttribute(Type sourceInterface)
	{
		_val = sourceInterface.FullName;
	}

	[__DynamicallyInvokable]
	public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2)
	{
		_val = sourceInterface1.FullName + "\0" + sourceInterface2.FullName;
	}

	[__DynamicallyInvokable]
	public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3)
	{
		_val = sourceInterface1.FullName + "\0" + sourceInterface2.FullName + "\0" + sourceInterface3.FullName;
	}

	[__DynamicallyInvokable]
	public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3, Type sourceInterface4)
	{
		_val = sourceInterface1.FullName + "\0" + sourceInterface2.FullName + "\0" + sourceInterface3.FullName + "\0" + sourceInterface4.FullName;
	}
}
