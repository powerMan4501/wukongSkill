using System.Runtime.CompilerServices;
using System.Security;

namespace System;

internal static class Mda
{
	internal static class StreamWriterBufferedDataLost
	{
		private static volatile int _enabledState;

		private static volatile int _captureAllocatedCallStackState;

		internal static bool Enabled
		{
			[SecuritySafeCritical]
			get
			{
				if (_enabledState == 0)
				{
					if (IsStreamWriterBufferedDataLostEnabled())
					{
						_enabledState = 1;
					}
					else
					{
						_enabledState = 2;
					}
				}
				return _enabledState == 1;
			}
		}

		internal static bool CaptureAllocatedCallStack
		{
			[SecuritySafeCritical]
			get
			{
				if (_captureAllocatedCallStackState == 0)
				{
					if (IsStreamWriterBufferedDataLostCaptureAllocatedCallStack())
					{
						_captureAllocatedCallStackState = 1;
					}
					else
					{
						_captureAllocatedCallStackState = 2;
					}
				}
				return _captureAllocatedCallStackState == 1;
			}
		}

		[SecuritySafeCritical]
		internal static void ReportError(string text)
		{
			ReportStreamWriterBufferedDataLost(text);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void ReportStreamWriterBufferedDataLost(string text);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsStreamWriterBufferedDataLostEnabled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsStreamWriterBufferedDataLostCaptureAllocatedCallStack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void MemberInfoCacheCreation();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void DateTimeInvalidLocalFormat();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsInvalidGCHandleCookieProbeEnabled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void FireInvalidGCHandleCookieProbe(IntPtr cookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void ReportErrorSafeHandleRelease(Exception ex);
}
