using System.Security;

namespace System.Threading;

internal class _IOCompletionCallback
{
	[SecurityCritical]
	private IOCompletionCallback _ioCompletionCallback;

	private ExecutionContext _executionContext;

	private uint _errorCode;

	private uint _numBytes;

	[SecurityCritical]
	private unsafe NativeOverlapped* _pOVERLAP;

	internal static ContextCallback _ccb;

	[SecuritySafeCritical]
	static _IOCompletionCallback()
	{
		_ccb = IOCompletionCallback_Context;
	}

	[SecurityCritical]
	internal _IOCompletionCallback(IOCompletionCallback ioCompletionCallback, ref StackCrawlMark stackMark)
	{
		_ioCompletionCallback = ioCompletionCallback;
		_executionContext = ExecutionContext.Capture(ref stackMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx | ExecutionContext.CaptureOptions.OptimizeDefaultCase);
	}

	[SecurityCritical]
	internal unsafe static void IOCompletionCallback_Context(object state)
	{
		_IOCompletionCallback iOCompletionCallback = (_IOCompletionCallback)state;
		iOCompletionCallback._ioCompletionCallback(iOCompletionCallback._errorCode, iOCompletionCallback._numBytes, iOCompletionCallback._pOVERLAP);
	}

	[SecurityCritical]
	internal unsafe static void PerformIOCompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* pOVERLAP)
	{
		do
		{
			Overlapped overlapped = OverlappedData.GetOverlappedFromNative(pOVERLAP).m_overlapped;
			_IOCompletionCallback iocbHelper = overlapped.iocbHelper;
			if (iocbHelper == null || iocbHelper._executionContext == null || iocbHelper._executionContext.IsDefaultFTContext(ignoreSyncCtx: true))
			{
				IOCompletionCallback userCallback = overlapped.UserCallback;
				userCallback(errorCode, numBytes, pOVERLAP);
			}
			else
			{
				iocbHelper._errorCode = errorCode;
				iocbHelper._numBytes = numBytes;
				iocbHelper._pOVERLAP = pOVERLAP;
				using ExecutionContext executionContext = iocbHelper._executionContext.CreateCopy();
				ExecutionContext.Run(executionContext, _ccb, iocbHelper, preserveSyncCtx: true);
			}
			OverlappedData.CheckVMForIOPacket(out pOVERLAP, out errorCode, out numBytes);
		}
		while (pOVERLAP != null);
	}
}
