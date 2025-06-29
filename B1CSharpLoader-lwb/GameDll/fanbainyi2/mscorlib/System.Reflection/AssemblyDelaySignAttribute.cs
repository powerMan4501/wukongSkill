using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyDelaySignAttribute : Attribute
{
	private bool m_delaySign;

	[__DynamicallyInvokable]
	public bool DelaySign
	{
		[__DynamicallyInvokable]
		get
		{
			return m_delaySign;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyDelaySignAttribute(bool delaySign)
	{
		m_delaySign = delaySign;
	}
}
