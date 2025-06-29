using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class EnvoyTerminatorSink : InternalSink, IMessageSink
{
	private static volatile EnvoyTerminatorSink messageSink;

	private static object staticSyncObject = new object();

	internal static IMessageSink MessageSink
	{
		get
		{
			if (messageSink == null)
			{
				EnvoyTerminatorSink envoyTerminatorSink = new EnvoyTerminatorSink();
				lock (staticSyncObject)
				{
					if (messageSink == null)
					{
						messageSink = envoyTerminatorSink;
					}
				}
			}
			return messageSink;
		}
	}

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage reqMsg)
	{
		IMessage message = InternalSink.ValidateMessage(reqMsg);
		if (message != null)
		{
			return message;
		}
		return Thread.CurrentContext.GetClientContextChain().SyncProcessMessage(reqMsg);
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
	{
		IMessageCtrl result = null;
		IMessage message = InternalSink.ValidateMessage(reqMsg);
		if (message != null)
		{
			replySink?.SyncProcessMessage(message);
		}
		else
		{
			result = Thread.CurrentContext.GetClientContextChain().AsyncProcessMessage(reqMsg, replySink);
		}
		return result;
	}
}
