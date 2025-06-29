using System.Security;
using System.Security.Permissions;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DispatchWrapper
{
	private object m_WrappedObject;

	[__DynamicallyInvokable]
	public object WrappedObject
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
	public DispatchWrapper(object obj)
	{
		if (obj != null)
		{
			IntPtr iDispatchForObject = Marshal.GetIDispatchForObject(obj);
			Marshal.Release(iDispatchForObject);
		}
		m_WrappedObject = obj;
	}
}
