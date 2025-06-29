using System.Security;
using System.Security.Permissions;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class BStrWrapper
{
	private string m_WrappedObject;

	[__DynamicallyInvokable]
	public string WrappedObject
	{
		[__DynamicallyInvokable]
		get
		{
			return m_WrappedObject;
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public BStrWrapper(string value)
	{
		m_WrappedObject = value;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public BStrWrapper(object value)
	{
		m_WrappedObject = (string)value;
	}
}
