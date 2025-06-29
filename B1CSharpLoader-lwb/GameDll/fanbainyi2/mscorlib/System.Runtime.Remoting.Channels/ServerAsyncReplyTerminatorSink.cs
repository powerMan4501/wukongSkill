using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting.Channels;

internal class ServerAsyncReplyTerminatorSink : IMessageSink
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

	internal ServerAsyncReplyTerminatorSink(IMessageSink nextSink)
	{
		_nextSink = nextSink;
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage replyMsg)
	{
		RemotingServices.CORProfilerRemotingServerSendingReply(out var id, fIsAsync: true);
		if (RemotingServices.CORProfilerTrackRemotingCookie())
		{
			replyMsg.Properties["CORProfilerCookie"] = id;
		}
		return _nextSink.SyncProcessMessage(replyMsg);
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage replyMsg, IMessageSink replySink)
	{
		return null;
	}
}
