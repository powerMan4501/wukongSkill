using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyCultureAttribute : Attribute
{
	private string m_culture;

	[__DynamicallyInvokable]
	public string Culture
	{
		[__DynamicallyInvokable]
		get
		{
			return m_culture;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyCultureAttribute(string culture)
	{
		m_culture = culture;
	}
}
