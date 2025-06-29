using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyTrademarkAttribute : Attribute
{
	private string m_trademark;

	[__DynamicallyInvokable]
	public string Trademark
	{
		[__DynamicallyInvokable]
		get
		{
			return m_trademark;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyTrademarkAttribute(string trademark)
	{
		m_trademark = trademark;
	}
}
