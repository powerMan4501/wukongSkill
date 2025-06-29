using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyInformationalVersionAttribute : Attribute
{
	private string m_informationalVersion;

	[__DynamicallyInvokable]
	public string InformationalVersion
	{
		[__DynamicallyInvokable]
		get
		{
			return m_informationalVersion;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyInformationalVersionAttribute(string informationalVersion)
	{
		m_informationalVersion = informationalVersion;
	}
}
