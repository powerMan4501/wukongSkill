using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace System.Runtime.InteropServices.WindowsRuntime;

[FriendAccessAllowed]
internal static class WindowsRuntimeBufferHelper
{
	[DllImport("QCall")]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private unsafe static extern void StoreOverlappedPtrInCCW(ObjectHandleOnStack windowsRuntimeBuffer, NativeOverlapped* overlapped);

	[FriendAccessAllowed]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void StoreOverlappedInCCW(object windowsRuntimeBuffer, NativeOverlapped* overlapped)
	{
		StoreOverlappedPtrInCCW(JitHelpers.GetObjectHandleOnStack(ref windowsRuntimeBuffer), overlapped);
	}
}
