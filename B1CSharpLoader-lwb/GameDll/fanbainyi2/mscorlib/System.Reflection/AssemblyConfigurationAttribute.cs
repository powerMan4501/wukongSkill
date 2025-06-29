using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyConfigurationAttribute : Attribute
{
	private string m_configuration;

	[__DynamicallyInvokable]
	public string Configuration
	{
		[__DynamicallyInvokable]
		get
		{
			return m_configuration;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyConfigurationAttribute(string configuration)
	{
		m_configuration = configuration;
	}
}
