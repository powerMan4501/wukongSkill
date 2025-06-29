using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting.Contexts;

internal class SynchronizedClientContextSink : InternalSink, IMessageSink
{
	internal class AsyncReplySink : IMessageSink
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
		internal AsyncReplySink(IMessageSink nextSink, SynchronizationAttribute prop)
		{
			_nextSink = nextSink;
			_property = prop;
		}

		[SecurityCritical]
		public virtual IMessage SyncProcessMessage(IMessage reqMsg)
		{
			WorkItem workItem = new WorkItem(reqMsg, _nextSink, null);
			_property.HandleWorkRequest(workItem);
			if (!_property.IsReEntrant)
			{
				_property.AsyncCallOutLCIDList.Remove(((LogicalCallContext)reqMsg.Properties[Message.CallContextKey]).RemotingData.LogicalCallID);
			}
			return workItem.ReplyMessage;
		}

		[SecurityCritical]
		public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
		{
			throw new NotSupportedException();
		}
	}

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
	internal SynchronizedClientContextSink(SynchronizationAttribute prop, IMessageSink nextSink)
	{
		_property = prop;
		_nextSink = nextSink;
	}

	[SecuritySafeCritical]
	~SynchronizedClientContextSink()
	{
		_property.Dispose();
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage reqMsg)
	{
		IMessage message;
		if (_property.IsReEntrant)
		{
			_property.HandleThreadExit();
			message = _nextSink.SyncProcessMessage(reqMsg);
			_property.HandleThreadReEntry();
		}
		else
		{
			LogicalCallContext logicalCallContext = (LogicalCallContext)reqMsg.Properties[Message.CallContextKey];
			string text = logicalCallContext.RemotingData.LogicalCallID;
			bool flag = false;
			if (text == null)
			{
				text = Identity.GetNewLogicalCallID();
				logicalCallContext.RemotingData.LogicalCallID = text;
				flag = true;
			}
			bool flag2 = false;
			if (_property.SyncCallOutLCID == null)
			{
				_property.SyncCallOutLCID = text;
				flag2 = true;
			}
			message = _nextSink.SyncProcessMessage(reqMsg);
			if (flag2)
			{
				_property.SyncCallOutLCID = null;
				if (flag)
				{
					LogicalCallContext logicalCallContext2 = (LogicalCallContext)message.Properties[Message.CallContextKey];
					logicalCallContext2.RemotingData.LogicalCallID = null;
				}
			}
		}
		return message;
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
	{
		IMessageCtrl messageCtrl = null;
		if (!_property.IsReEntrant)
		{
			LogicalCallContext logicalCallContext = (LogicalCallContext)reqMsg.Properties[Message.CallContextKey];
			string newLogicalCallID = Identity.GetNewLogicalCallID();
			logicalCallContext.RemotingData.LogicalCallID = newLogicalCallID;
			_property.AsyncCallOutLCIDList.Add(newLogicalCallID);
		}
		AsyncReplySink replySink2 = new AsyncReplySink(replySink, _property);
		return _nextSink.AsyncProcessMessage(reqMsg, replySink2);
	}
}
