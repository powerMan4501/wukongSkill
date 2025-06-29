using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class SafeCryptMsgHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeCryptMsgHandle InvalidHandle
	{
		get
		{
			SafeCryptMsgHandle safeCryptMsgHandle = new SafeCryptMsgHandle(IntPtr.Zero);
			GC.SuppressFinalize(safeCryptMsgHandle);
			return safeCryptMsgHandle;
		}
	}

	private SafeCryptMsgHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeCryptMsgHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[DllImport("crypt32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern bool CryptMsgClose(IntPtr handle);

	protected override bool ReleaseHandle()
	{
		return CryptMsgClose(handle);
	}
}
