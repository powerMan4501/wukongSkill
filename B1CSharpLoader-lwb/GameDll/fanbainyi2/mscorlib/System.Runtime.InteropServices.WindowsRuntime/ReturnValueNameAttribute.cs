namespace System.Runtime.InteropServices.WindowsRuntime;

[AttributeUsage(AttributeTargets.Delegate | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = false)]
[__DynamicallyInvokable]
public sealed class ReturnValueNameAttribute : Attribute
{
	private string m_Name;

	[__DynamicallyInvokable]
	public string Name
	{
		[__DynamicallyInvokable]
		get
		{
			return m_Name;
		}
	}

	[__DynamicallyInvokable]
	public ReturnValueNameAttribute(string name)
	{
		m_Name = name;
	}
}
