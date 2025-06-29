using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyDescriptionAttribute : Attribute
{
	private string m_description;

	[__DynamicallyInvokable]
	public string Description
	{
		[__DynamicallyInvokable]
		get
		{
			return m_description;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyDescriptionAttribute(string description)
	{
		m_description = description;
	}
}
