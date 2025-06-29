using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyCopyrightAttribute : Attribute
{
	private string m_copyright;

	[__DynamicallyInvokable]
	public string Copyright
	{
		[__DynamicallyInvokable]
		get
		{
			return m_copyright;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyCopyrightAttribute(string copyright)
	{
		m_copyright = copyright;
	}
}
