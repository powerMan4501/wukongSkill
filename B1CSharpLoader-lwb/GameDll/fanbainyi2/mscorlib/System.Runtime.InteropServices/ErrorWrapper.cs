using System.Security;
using System.Security.Permissions;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class ErrorWrapper
{
	private int m_ErrorCode;

	[__DynamicallyInvokable]
	public int ErrorCode
	{
		[__DynamicallyInvokable]
		get
		{
			return m_ErrorCode;
		}
	}

	[__DynamicallyInvokable]
	public ErrorWrapper(int errorCode)
	{
		m_ErrorCode = errorCode;
	}

	[__DynamicallyInvokable]
	public ErrorWrapper(object errorCode)
	{
		if (!(errorCode is int))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeInt32"), "errorCode");
		}
		m_ErrorCode = (int)errorCode;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public ErrorWrapper(Exception e)
	{
		m_ErrorCode = Marshal.GetHRForException(e);
	}
}
