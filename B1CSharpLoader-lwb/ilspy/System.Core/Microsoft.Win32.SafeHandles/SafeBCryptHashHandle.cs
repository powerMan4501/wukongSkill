using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class SafeBCryptHashHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private IntPtr m_hashObject;

	internal IntPtr HashObject
	{
		get
		{
			return m_hashObject;
		}
		set
		{
			m_hashObject = value;
		}
	}

	private SafeBCryptHashHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("bcrypt")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern BCryptNative.ErrorCode BCryptDestroyHash(IntPtr hHash);

	protected override bool ReleaseHandle()
	{
		bool result = BCryptDestroyHash(handle) == BCryptNative.ErrorCode.Success;
		if (m_hashObject != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(m_hashObject);
		}
		return result;
	}
}
