using System.Runtime.InteropServices;

namespace System;

[Serializable]
[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class CLSCompliantAttribute : Attribute
{
	private bool m_compliant;

	[__DynamicallyInvokable]
	public bool IsCompliant
	{
		[__DynamicallyInvokable]
		get
		{
			return m_compliant;
		}
	}

	[__DynamicallyInvokable]
	public CLSCompliantAttribute(bool isCompliant)
	{
		m_compliant = isCompliant;
	}
}
