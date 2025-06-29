namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class ComEventInterfaceAttribute : Attribute
{
	internal Type _SourceInterface;

	internal Type _EventProvider;

	[__DynamicallyInvokable]
	public Type SourceInterface
	{
		[__DynamicallyInvokable]
		get
		{
			return _SourceInterface;
		}
	}

	[__DynamicallyInvokable]
	public Type EventProvider
	{
		[__DynamicallyInvokable]
		get
		{
			return _EventProvider;
		}
	}

	[__DynamicallyInvokable]
	public ComEventInterfaceAttribute(Type SourceInterface, Type EventProvider)
	{
		_SourceInterface = SourceInterface;
		_EventProvider = EventProvider;
	}
}
