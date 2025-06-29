using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DefaultMemberAttribute : Attribute
{
	private string m_memberName;

	[__DynamicallyInvokable]
	public string MemberName
	{
		[__DynamicallyInvokable]
		get
		{
			return m_memberName;
		}
	}

	[__DynamicallyInvokable]
	public DefaultMemberAttribute(string memberName)
	{
		m_memberName = memberName;
	}
}
