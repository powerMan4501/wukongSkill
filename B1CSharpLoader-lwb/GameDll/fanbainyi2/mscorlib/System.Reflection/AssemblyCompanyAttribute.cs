using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyCompanyAttribute : Attribute
{
	private string m_company;

	[__DynamicallyInvokable]
	public string Company
	{
		[__DynamicallyInvokable]
		get
		{
			return m_company;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyCompanyAttribute(string company)
	{
		m_company = company;
	}
}
