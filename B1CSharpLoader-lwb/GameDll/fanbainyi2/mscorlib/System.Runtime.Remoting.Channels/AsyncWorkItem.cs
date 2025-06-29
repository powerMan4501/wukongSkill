using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Channels;

internal class AsyncWorkItem : IMessageSink
{
	private IMessageSink _replySink;

	private ServerIdentity _srvID;

	private Context _oldCtx;

	[SecurityCritical]
	private LogicalCallContext _callCtx;

	private IMessage _reqMsg;

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return _replySink;
		}
	}

	[SecurityCritical]
	internal AsyncWorkItem(IMessageSink replySink, Context oldCtx)
		: this(null, replySink, oldCtx, null)
	{
	}

	[SecurityCritical]
	internal AsyncWorkItem(IMessage reqMsg, IMessageSink replySink, Context oldCtx, ServerIdentity srvID)
	{
		_reqMsg = reqMsg;
		_replySink = replySink;
		_oldCtx = oldCtx;
		_callCtx = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
		_srvID = srvID;
	}

	[SecurityCritical]
	internal static object SyncProcessMessageCallback(object[] args)
	{
		IMessageSink messageSink = (IMessageSink)args[0];
		IMessage msg = (IMessage)args[1];
		return messageSink.SyncProcessMessage(msg);
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage msg)
	{
		IMessage result = null;
		if (_replySink != null)
		{
			Thread.CurrentContext.NotifyDynamicSinks(msg, bCliSide: false, bStart: false, bAsync: true, bNotifyGlobals: true);
			object[] args = new object[2] { _replySink, msg };
			InternalCrossContextDelegate ftnToCall = SyncProcessMessageCallback;
			result = (IMessage)Thread.CurrentThread.InternalCrossContextCallback(_oldCtx, ftnToCall, args);
		}
		return result;
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_Method"));
	}

	[SecurityCritical]
	internal static object FinishAsyncWorkCallback(object[] args)
	{
		AsyncWorkItem asyncWorkItem = (AsyncWorkItem)args[0];
		Context serverContext = asyncWorkItem._srvID.ServerContext;
		LogicalCallContext logicalCallContext = CallContext.SetLogicalCallContext(asyncWorkItem._callCtx);
		serverContext.NotifyDynamicSinks(asyncWorkItem._reqMsg, bCliSide: false, bStart: true, bAsync: true, bNotifyGlobals: true);
		IMessageCtrl messageCtrl = serverContext.GetServerContextChain().AsyncProcessMessage(asyncWorkItem._reqMsg, asyncWorkItem);
		CallContext.SetLogicalCallContext(logicalCallContext);
		return null;
	}

	[SecurityCritical]
	internal virtual void FinishAsyncWork(object stateIgnored)
	{
		InternalCrossContextDelegate ftnToCall = FinishAsyncWorkCallback;
		object[] args = new object[1] { this };
		Thread.CurrentThread.InternalCrossContextCallback(_srvID.ServerContext, ftnToCall, args);
	}
}
