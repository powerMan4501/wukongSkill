using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyKeyFileAttribute : Attribute
{
	private string m_keyFile;

	[__DynamicallyInvokable]
	public string KeyFile
	{
		[__DynamicallyInvokable]
		get
		{
			return m_keyFile;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyKeyFileAttribute(string keyFile)
	{
		m_keyFile = keyFile;
	}
}
