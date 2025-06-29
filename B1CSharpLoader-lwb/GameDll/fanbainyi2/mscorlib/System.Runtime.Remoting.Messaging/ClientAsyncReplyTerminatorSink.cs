using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class ClientAsyncReplyTerminatorSink : IMessageSink
{
	internal IMessageSink _nextSink;

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return _nextSink;
		}
	}

	internal ClientAsyncReplyTerminatorSink(IMessageSink nextSink)
	{
		_nextSink = nextSink;
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage replyMsg)
	{
		Guid id = Guid.Empty;
		if (RemotingServices.CORProfilerTrackRemotingCookie())
		{
			object obj = replyMsg.Properties["CORProfilerCookie"];
			if (obj != null)
			{
				id = (Guid)obj;
			}
		}
		RemotingServices.CORProfilerRemotingClientReceivingReply(id, fIsAsync: true);
		return _nextSink.SyncProcessMessage(replyMsg);
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage replyMsg, IMessageSink replySink)
	{
		return null;
	}
}
