using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyTitleAttribute : Attribute
{
	private string m_title;

	[__DynamicallyInvokable]
	public string Title
	{
		[__DynamicallyInvokable]
		get
		{
			return m_title;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyTitleAttribute(string title)
	{
		m_title = title;
	}
}
