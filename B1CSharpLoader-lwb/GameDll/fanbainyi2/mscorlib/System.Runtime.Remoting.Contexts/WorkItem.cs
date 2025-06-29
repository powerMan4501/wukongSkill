using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Contexts;

internal class WorkItem
{
	private const int FLG_WAITING = 1;

	private const int FLG_SIGNALED = 2;

	private const int FLG_ASYNC = 4;

	private const int FLG_DUMMY = 8;

	internal int _flags;

	internal IMessage _reqMsg;

	internal IMessageSink _nextSink;

	internal IMessageSink _replySink;

	internal IMessage _replyMsg;

	internal Context _ctx;

	[SecurityCritical]
	internal LogicalCallContext _callCtx;

	internal static InternalCrossContextDelegate _xctxDel;

	internal virtual IMessage ReplyMessage => _replyMsg;

	[SecuritySafeCritical]
	static WorkItem()
	{
		_xctxDel = ExecuteCallback;
	}

	[SecurityCritical]
	internal WorkItem(IMessage reqMsg, IMessageSink nextSink, IMessageSink replySink)
	{
		_reqMsg = reqMsg;
		_replyMsg = null;
		_nextSink = nextSink;
		_replySink = replySink;
		_ctx = Thread.CurrentContext;
		_callCtx = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
	}

	internal virtual void SetWaiting()
	{
		_flags |= 1;
	}

	internal virtual bool IsWaiting()
	{
		return (_flags & 1) == 1;
	}

	internal virtual void SetSignaled()
	{
		_flags |= 2;
	}

	internal virtual bool IsSignaled()
	{
		return (_flags & 2) == 2;
	}

	internal virtual void SetAsync()
	{
		_flags |= 4;
	}

	internal virtual bool IsAsync()
	{
		return (_flags & 4) == 4;
	}

	internal virtual void SetDummy()
	{
		_flags |= 8;
	}

	internal virtual bool IsDummy()
	{
		return (_flags & 8) == 8;
	}

	[SecurityCritical]
	internal static object ExecuteCallback(object[] args)
	{
		WorkItem workItem = (WorkItem)args[0];
		if (workItem.IsAsync())
		{
			workItem._nextSink.AsyncProcessMessage(workItem._reqMsg, workItem._replySink);
		}
		else if (workItem._nextSink != null)
		{
			workItem._replyMsg = workItem._nextSink.SyncProcessMessage(workItem._reqMsg);
		}
		return null;
	}

	[SecurityCritical]
	internal virtual void Execute()
	{
		Thread.CurrentThread.InternalCrossContextCallback(_ctx, _xctxDel, new object[1] { this });
	}
}
