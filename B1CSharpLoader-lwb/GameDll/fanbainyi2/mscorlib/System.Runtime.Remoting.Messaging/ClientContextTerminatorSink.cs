using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Messaging;

internal class ClientContextTerminatorSink : InternalSink, IMessageSink
{
	private static volatile ClientContextTerminatorSink messageSink;

	private static object staticSyncObject = new object();

	internal static IMessageSink MessageSink
	{
		get
		{
			if (messageSink == null)
			{
				ClientContextTerminatorSink clientContextTerminatorSink = new ClientContextTerminatorSink();
				lock (staticSyncObject)
				{
					if (messageSink == null)
					{
						messageSink = clientContextTerminatorSink;
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
	internal static object SyncProcessMessageCallback(object[] args)
	{
		IMessage msg = (IMessage)args[0];
		IMessageSink messageSink = (IMessageSink)args[1];
		return messageSink.SyncProcessMessage(msg);
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage reqMsg)
	{
		IMessage message = InternalSink.ValidateMessage(reqMsg);
		if (message != null)
		{
			return message;
		}
		Context currentContext = Thread.CurrentContext;
		bool flag = currentContext.NotifyDynamicSinks(reqMsg, bCliSide: true, bStart: true, bAsync: false, bNotifyGlobals: true);
		IMessage message2;
		if (reqMsg is IConstructionCallMessage)
		{
			message = currentContext.NotifyActivatorProperties(reqMsg, bServerSide: false);
			if (message != null)
			{
				return message;
			}
			message2 = ((IConstructionCallMessage)reqMsg).Activator.Activate((IConstructionCallMessage)reqMsg);
			message = currentContext.NotifyActivatorProperties(message2, bServerSide: false);
			if (message != null)
			{
				return message;
			}
		}
		else
		{
			message2 = null;
			ChannelServices.NotifyProfiler(reqMsg, RemotingProfilerEvent.ClientSend);
			object[] array = new object[2];
			IMessageSink channelSink = GetChannelSink(reqMsg);
			array[0] = reqMsg;
			array[1] = channelSink;
			InternalCrossContextDelegate internalCrossContextDelegate = SyncProcessMessageCallback;
			message2 = ((channelSink == CrossContextChannel.MessageSink) ? ((IMessage)internalCrossContextDelegate(array)) : ((IMessage)Thread.CurrentThread.InternalCrossContextCallback(Context.DefaultContext, internalCrossContextDelegate, array)));
			ChannelServices.NotifyProfiler(message2, RemotingProfilerEvent.ClientReceive);
		}
		if (flag)
		{
			currentContext.NotifyDynamicSinks(reqMsg, bCliSide: true, bStart: false, bAsync: false, bNotifyGlobals: true);
		}
		return message2;
	}

	[SecurityCritical]
	internal static object AsyncProcessMessageCallback(object[] args)
	{
		IMessage msg = (IMessage)args[0];
		IMessageSink replySink = (IMessageSink)args[1];
		IMessageSink messageSink = (IMessageSink)args[2];
		return messageSink.AsyncProcessMessage(msg, replySink);
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
	{
		IMessage message = InternalSink.ValidateMessage(reqMsg);
		IMessageCtrl result = null;
		if (message == null)
		{
			message = InternalSink.DisallowAsyncActivation(reqMsg);
		}
		if (message != null)
		{
			replySink?.SyncProcessMessage(message);
		}
		else
		{
			if (RemotingServices.CORProfilerTrackRemotingAsync())
			{
				RemotingServices.CORProfilerRemotingClientSendingMessage(out var id, fIsAsync: true);
				if (RemotingServices.CORProfilerTrackRemotingCookie())
				{
					reqMsg.Properties["CORProfilerCookie"] = id;
				}
				if (replySink != null)
				{
					IMessageSink messageSink = new ClientAsyncReplyTerminatorSink(replySink);
					replySink = messageSink;
				}
			}
			Context currentContext = Thread.CurrentContext;
			currentContext.NotifyDynamicSinks(reqMsg, bCliSide: true, bStart: true, bAsync: true, bNotifyGlobals: true);
			if (replySink != null)
			{
				replySink = new AsyncReplySink(replySink, currentContext);
			}
			object[] array = new object[3];
			InternalCrossContextDelegate internalCrossContextDelegate = AsyncProcessMessageCallback;
			IMessageSink channelSink = GetChannelSink(reqMsg);
			array[0] = reqMsg;
			array[1] = replySink;
			array[2] = channelSink;
			result = ((channelSink == CrossContextChannel.MessageSink) ? ((IMessageCtrl)internalCrossContextDelegate(array)) : ((IMessageCtrl)Thread.CurrentThread.InternalCrossContextCallback(Context.DefaultContext, internalCrossContextDelegate, array)));
		}
		return result;
	}

	[SecurityCritical]
	private IMessageSink GetChannelSink(IMessage reqMsg)
	{
		Identity identity = InternalSink.GetIdentity(reqMsg);
		return identity.ChannelSink;
	}
}
