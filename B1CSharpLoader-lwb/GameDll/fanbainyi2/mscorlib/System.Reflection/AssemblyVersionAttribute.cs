using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyVersionAttribute : Attribute
{
	private string m_version;

	[__DynamicallyInvokable]
	public string Version
	{
		[__DynamicallyInvokable]
		get
		{
			return m_version;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyVersionAttribute(string version)
	{
		m_version = version;
	}
}
