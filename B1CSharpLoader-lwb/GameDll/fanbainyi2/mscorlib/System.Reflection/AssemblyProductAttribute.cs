using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyProductAttribute : Attribute
{
	private string m_product;

	[__DynamicallyInvokable]
	public string Product
	{
		[__DynamicallyInvokable]
		get
		{
			return m_product;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyProductAttribute(string product)
	{
		m_product = product;
	}
}
