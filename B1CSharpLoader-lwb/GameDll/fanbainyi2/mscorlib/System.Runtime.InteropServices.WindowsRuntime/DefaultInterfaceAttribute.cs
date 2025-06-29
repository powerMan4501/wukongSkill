namespace System.Runtime.InteropServices.WindowsRuntime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
[__DynamicallyInvokable]
public sealed class DefaultInterfaceAttribute : Attribute
{
	private Type m_defaultInterface;

	[__DynamicallyInvokable]
	public Type DefaultInterface
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultInterface;
		}
	}

	[__DynamicallyInvokable]
	public DefaultInterfaceAttribute(Type defaultInterface)
	{
		m_defaultInterface = defaultInterface;
	}
}
