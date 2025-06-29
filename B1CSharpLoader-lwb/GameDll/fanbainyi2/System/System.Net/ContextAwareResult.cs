using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

namespace System.Net;

internal class ContextAwareResult : LazyAsyncResult
{
	[Flags]
	private enum StateFlags
	{
		None = 0,
		CaptureIdentity = 1,
		CaptureContext = 2,
		ThreadSafeContextCopy = 4,
		PostBlockStarted = 8,
		PostBlockFinished = 0x10
	}

	private volatile ExecutionContext _Context;

	private object _Lock;

	private StateFlags _Flags;

	private WindowsIdentity _Wi;

	internal ExecutionContext ContextCopy
	{
		get
		{
			if (base.InternalPeekCompleted)
			{
				throw new InvalidOperationException(SR.GetString("net_completed_result"));
			}
			ExecutionContext context = _Context;
			if (context != null)
			{
				return context.CreateCopy();
			}
			if ((_Flags & StateFlags.PostBlockFinished) == 0)
			{
				lock (_Lock)
				{
				}
			}
			if (base.InternalPeekCompleted)
			{
				throw new InvalidOperationException(SR.GetString("net_completed_result"));
			}
			return _Context?.CreateCopy();
		}
	}

	internal WindowsIdentity Identity
	{
		get
		{
			if (base.InternalPeekCompleted)
			{
				throw new InvalidOperationException(SR.GetString("net_completed_result"));
			}
			if (_Wi != null)
			{
				return _Wi;
			}
			if ((_Flags & StateFlags.PostBlockFinished) == 0)
			{
				lock (_Lock)
				{
				}
			}
			if (base.InternalPeekCompleted)
			{
				throw new InvalidOperationException(SR.GetString("net_completed_result"));
			}
			return _Wi;
		}
	}

	internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack)
		: this(captureIdentity: false, forceCaptureContext: false, myObject, myState, myCallBack)
	{
	}

	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack)
		: this(captureIdentity, forceCaptureContext, threadSafeContextCopy: false, myObject, myState, myCallBack)
	{
	}

	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack)
		: base(myObject, myState, myCallBack)
	{
		if (forceCaptureContext)
		{
			_Flags = StateFlags.CaptureContext;
		}
		if (captureIdentity)
		{
			_Flags |= StateFlags.CaptureIdentity;
		}
		if (threadSafeContextCopy)
		{
			_Flags |= StateFlags.ThreadSafeContextCopy;
		}
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	private void SafeCaptureIdenity()
	{
		_Wi = WindowsIdentity.GetCurrent();
	}

	internal object StartPostingAsyncOp()
	{
		return StartPostingAsyncOp(lockCapture: true);
	}

	internal object StartPostingAsyncOp(bool lockCapture)
	{
		_Lock = (lockCapture ? new object() : null);
		_Flags |= StateFlags.PostBlockStarted;
		return _Lock;
	}

	internal bool FinishPostingAsyncOp()
	{
		if ((_Flags & (StateFlags.PostBlockStarted | StateFlags.PostBlockFinished)) != StateFlags.PostBlockStarted)
		{
			return false;
		}
		_Flags |= StateFlags.PostBlockFinished;
		ExecutionContext cachedContext = null;
		return CaptureOrComplete(ref cachedContext, returnContext: false);
	}

	internal bool FinishPostingAsyncOp(ref CallbackClosure closure)
	{
		if ((_Flags & (StateFlags.PostBlockStarted | StateFlags.PostBlockFinished)) != StateFlags.PostBlockStarted)
		{
			return false;
		}
		_Flags |= StateFlags.PostBlockFinished;
		CallbackClosure callbackClosure = closure;
		ExecutionContext cachedContext;
		if (callbackClosure == null)
		{
			cachedContext = null;
		}
		else if (!callbackClosure.IsCompatible(base.AsyncCallback))
		{
			closure = null;
			cachedContext = null;
		}
		else
		{
			base.AsyncCallback = callbackClosure.AsyncCallback;
			cachedContext = callbackClosure.Context;
		}
		bool result = CaptureOrComplete(ref cachedContext, returnContext: true);
		if (closure == null && base.AsyncCallback != null && cachedContext != null)
		{
			closure = new CallbackClosure(cachedContext, base.AsyncCallback);
		}
		return result;
	}

	protected override void Cleanup()
	{
		base.Cleanup();
		if (_Wi != null)
		{
			_Wi.Dispose();
			_Wi = null;
		}
	}

	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext)
	{
		bool flag = base.AsyncCallback != null || (_Flags & StateFlags.CaptureContext) != 0;
		if ((_Flags & StateFlags.CaptureIdentity) != StateFlags.None && !base.InternalPeekCompleted && (!flag || SecurityContext.IsWindowsIdentityFlowSuppressed()))
		{
			SafeCaptureIdenity();
		}
		if (flag && !base.InternalPeekCompleted)
		{
			if (cachedContext == null)
			{
				cachedContext = ExecutionContext.Capture();
			}
			if (cachedContext != null)
			{
				if (!returnContext)
				{
					_Context = cachedContext;
					cachedContext = null;
				}
				else
				{
					_Context = cachedContext.CreateCopy();
				}
			}
		}
		else
		{
			cachedContext = null;
		}
		if (base.CompletedSynchronously)
		{
			base.Complete(IntPtr.Zero);
			return true;
		}
		return false;
	}

	protected override void Complete(IntPtr userToken)
	{
		if ((_Flags & StateFlags.PostBlockStarted) == 0)
		{
			base.Complete(userToken);
		}
		else if (!base.CompletedSynchronously)
		{
			ExecutionContext context = _Context;
			if (userToken != IntPtr.Zero || context == null)
			{
				base.Complete(userToken);
			}
			else
			{
				ExecutionContext.Run(((_Flags & StateFlags.ThreadSafeContextCopy) != StateFlags.None) ? context.CreateCopy() : context, CompleteCallback, null);
			}
		}
	}

	private void CompleteCallback(object state)
	{
		base.Complete(IntPtr.Zero);
	}
}
