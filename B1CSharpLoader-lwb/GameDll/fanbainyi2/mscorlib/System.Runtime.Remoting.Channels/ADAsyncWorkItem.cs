using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Channels;

internal class ADAsyncWorkItem
{
	private IMessageSink _replySink;

	private IMessageSink _nextSink;

	[SecurityCritical]
	private LogicalCallContext _callCtx;

	private IMessage _reqMsg;

	[SecurityCritical]
	internal ADAsyncWorkItem(IMessage reqMsg, IMessageSink nextSink, IMessageSink replySink)
	{
		_reqMsg = reqMsg;
		_nextSink = nextSink;
		_replySink = replySink;
		_callCtx = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
	}

	[SecurityCritical]
	internal virtual void FinishAsyncWork(object stateIgnored)
	{
		LogicalCallContext logicalCallContext = CallContext.SetLogicalCallContext(_callCtx);
		IMessage msg = _nextSink.SyncProcessMessage(_reqMsg);
		if (_replySink != null)
		{
			_replySink.SyncProcessMessage(msg);
		}
		CallContext.SetLogicalCallContext(logicalCallContext);
	}
}
