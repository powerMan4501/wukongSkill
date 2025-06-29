using System.Runtime.InteropServices;

namespace System.Diagnostics;

[Serializable]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class ConditionalAttribute : Attribute
{
	private string m_conditionString;

	[__DynamicallyInvokable]
	public string ConditionString
	{
		[__DynamicallyInvokable]
		get
		{
			return m_conditionString;
		}
	}

	[__DynamicallyInvokable]
	public ConditionalAttribute(string conditionString)
	{
		m_conditionString = conditionString;
	}
}
