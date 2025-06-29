using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyDefaultAliasAttribute : Attribute
{
	private string m_defaultAlias;

	[__DynamicallyInvokable]
	public string DefaultAlias
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultAlias;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyDefaultAliasAttribute(string defaultAlias)
	{
		m_defaultAlias = defaultAlias;
	}
}
