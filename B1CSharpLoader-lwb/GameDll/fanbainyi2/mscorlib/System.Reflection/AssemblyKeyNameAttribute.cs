using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyKeyNameAttribute : Attribute
{
	private string m_keyName;

	[__DynamicallyInvokable]
	public string KeyName
	{
		[__DynamicallyInvokable]
		get
		{
			return m_keyName;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyKeyNameAttribute(string keyName)
	{
		m_keyName = keyName;
	}
}
