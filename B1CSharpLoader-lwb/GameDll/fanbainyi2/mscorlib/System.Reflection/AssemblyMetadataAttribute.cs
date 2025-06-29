namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
[__DynamicallyInvokable]
public sealed class AssemblyMetadataAttribute : Attribute
{
	private string m_key;

	private string m_value;

	[__DynamicallyInvokable]
	public string Key
	{
		[__DynamicallyInvokable]
		get
		{
			return m_key;
		}
	}

	[__DynamicallyInvokable]
	public string Value
	{
		[__DynamicallyInvokable]
		get
		{
			return m_value;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyMetadataAttribute(string key, string value)
	{
		m_key = key;
		m_value = value;
	}
}
