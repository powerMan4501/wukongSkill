using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class SafeCapiKeyHandle : SafeCapiHandleBase
{
	private static volatile SafeCapiKeyHandle s_invalidHandle;

	internal static SafeCapiKeyHandle InvalidHandle
	{
		get
		{
			if (s_invalidHandle == null)
			{
				SafeCapiKeyHandle safeCapiKeyHandle = new SafeCapiKeyHandle();
				safeCapiKeyHandle.SetHandle(IntPtr.Zero);
				GC.SuppressFinalize(safeCapiKeyHandle);
				s_invalidHandle = safeCapiKeyHandle;
			}
			return s_invalidHandle;
		}
	}

	private SafeCapiKeyHandle()
	{
	}

	[DllImport("advapi32")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptDestroyKey(IntPtr hKey);

	internal SafeCapiKeyHandle Duplicate()
	{
		SafeCapiKeyHandle phKey = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (!CapiNative.UnsafeNativeMethods.CryptDuplicateKey(this, IntPtr.Zero, 0, out phKey))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
		finally
		{
			if (phKey != null && !phKey.IsInvalid && base.ParentCsp != IntPtr.Zero)
			{
				phKey.ParentCsp = base.ParentCsp;
			}
		}
		return phKey;
	}

	protected override bool ReleaseCapiChildHandle()
	{
		return CryptDestroyKey(handle);
	}
}
