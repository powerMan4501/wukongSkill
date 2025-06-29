using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting.Contexts;

internal class SynchronizedServerContextSink : InternalSink, IMessageSink
{
	internal IMessageSink _nextSink;

	[SecurityCritical]
	internal SynchronizationAttribute _property;

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return _nextSink;
		}
	}

	[SecurityCritical]
	internal SynchronizedServerContextSink(SynchronizationAttribute prop, IMessageSink nextSink)
	{
		_property = prop;
		_nextSink = nextSink;
	}

	[SecuritySafeCritical]
	~SynchronizedServerContextSink()
	{
		_property.Dispose();
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage reqMsg)
	{
		WorkItem workItem = new WorkItem(reqMsg, _nextSink, null);
		_property.HandleWorkRequest(workItem);
		return workItem.ReplyMessage;
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
	{
		WorkItem workItem = new WorkItem(reqMsg, _nextSink, replySink);
		workItem.SetAsync();
		_property.HandleWorkRequest(workItem);
		return null;
	}
}
