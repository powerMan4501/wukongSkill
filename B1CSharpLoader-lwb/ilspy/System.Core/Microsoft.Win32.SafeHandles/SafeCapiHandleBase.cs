using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal abstract class SafeCapiHandleBase : SafeHandleZeroOrMinusOneIsInvalid
{
	private IntPtr m_csp;

	protected IntPtr ParentCsp
	{
		get
		{
			return m_csp;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		set
		{
			int num = 0;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				if (CryptContextAddRef(value, IntPtr.Zero, 0))
				{
					m_csp = value;
				}
				else
				{
					num = Marshal.GetLastWin32Error();
				}
			}
			if (num != 0)
			{
				throw new CryptographicException(num);
			}
		}
	}

	internal SafeCapiHandleBase()
		: base(ownsHandle: true)
	{
	}

	[DllImport("advapi32", SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptContextAddRef(IntPtr hProv, IntPtr pdwReserved, int dwFlags);

	[DllImport("advapi32")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptReleaseContext(IntPtr hProv, int dwFlags);

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal void SetParentCsp(SafeCspHandle parentCsp)
	{
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			parentCsp.DangerousAddRef(ref success);
			IntPtr parentCsp2 = parentCsp.DangerousGetHandle();
			ParentCsp = parentCsp2;
		}
		finally
		{
			if (success)
			{
				parentCsp.DangerousRelease();
			}
		}
	}

	protected abstract bool ReleaseCapiChildHandle();

	protected sealed override bool ReleaseHandle()
	{
		bool flag = ReleaseCapiChildHandle();
		bool flag2 = true;
		if (m_csp != IntPtr.Zero)
		{
			flag2 = CryptReleaseContext(m_csp, 0);
		}
		return flag && flag2;
	}
}
