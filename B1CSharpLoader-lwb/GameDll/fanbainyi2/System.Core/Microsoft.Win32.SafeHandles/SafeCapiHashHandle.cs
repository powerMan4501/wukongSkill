using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class SafeCapiHashHandle : SafeCapiHandleBase
{
	private static volatile SafeCapiHashHandle s_invalidHandle;

	public static SafeCapiHashHandle InvalidHandle
	{
		get
		{
			if (s_invalidHandle == null)
			{
				SafeCapiHashHandle safeCapiHashHandle = new SafeCapiHashHandle();
				safeCapiHashHandle.SetHandle(IntPtr.Zero);
				GC.SuppressFinalize(safeCapiHashHandle);
				s_invalidHandle = safeCapiHashHandle;
			}
			return s_invalidHandle;
		}
	}

	private SafeCapiHashHandle()
	{
	}

	[DllImport("advapi32")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptDestroyHash(IntPtr hHash);

	protected override bool ReleaseCapiChildHandle()
	{
		return CryptDestroyHash(handle);
	}
}
