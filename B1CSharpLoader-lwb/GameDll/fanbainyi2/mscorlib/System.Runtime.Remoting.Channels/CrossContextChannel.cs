using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Channels;

internal class CrossContextChannel : InternalSink, IMessageSink
{
	private const string _channelName = "XCTX";

	private const int _channelCapability = 0;

	private const string _channelURI = "XCTX_URI";

	private static object staticSyncObject;

	private static InternalCrossContextDelegate s_xctxDel;

	private static CrossContextChannel messageSink
	{
		get
		{
			return Thread.GetDomain().RemotingData.ChannelServicesData.xctxmessageSink;
		}
		set
		{
			Thread.GetDomain().RemotingData.ChannelServicesData.xctxmessageSink = value;
		}
	}

	internal static IMessageSink MessageSink
	{
		get
		{
			if (messageSink == null)
			{
				CrossContextChannel crossContextChannel = new CrossContextChannel();
				lock (staticSyncObject)
				{
					if (messageSink == null)
					{
						messageSink = crossContextChannel;
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

	[SecuritySafeCritical]
	static CrossContextChannel()
	{
		staticSyncObject = new object();
		s_xctxDel = SyncProcessMessageCallback;
	}

	[SecurityCritical]
	internal static object SyncProcessMessageCallback(object[] args)
	{
		IMessage message = args[0] as IMessage;
		Context context = args[1] as Context;
		IMessage message2 = null;
		if (RemotingServices.CORProfilerTrackRemoting())
		{
			Guid id = Guid.Empty;
			if (RemotingServices.CORProfilerTrackRemotingCookie())
			{
				object obj = message.Properties["CORProfilerCookie"];
				if (obj != null)
				{
					id = (Guid)obj;
				}
			}
			RemotingServices.CORProfilerRemotingServerReceivingMessage(id, fIsAsync: false);
		}
		context.NotifyDynamicSinks(message, bCliSide: false, bStart: true, bAsync: false, bNotifyGlobals: true);
		message2 = context.GetServerContextChain().SyncProcessMessage(message);
		context.NotifyDynamicSinks(message2, bCliSide: false, bStart: false, bAsync: false, bNotifyGlobals: true);
		if (RemotingServices.CORProfilerTrackRemoting())
		{
			RemotingServices.CORProfilerRemotingServerSendingReply(out var id2, fIsAsync: false);
			if (RemotingServices.CORProfilerTrackRemotingCookie())
			{
				message2.Properties["CORProfilerCookie"] = id2;
			}
		}
		return message2;
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage reqMsg)
	{
		object[] array = new object[2];
		IMessage message = null;
		try
		{
			IMessage message2 = InternalSink.ValidateMessage(reqMsg);
			if (message2 != null)
			{
				return message2;
			}
			ServerIdentity serverIdentity = InternalSink.GetServerIdentity(reqMsg);
			array[0] = reqMsg;
			array[1] = serverIdentity.ServerContext;
			message = (IMessage)Thread.CurrentThread.InternalCrossContextCallback(serverIdentity.ServerContext, s_xctxDel, array);
		}
		catch (Exception e)
		{
			message = new ReturnMessage(e, (IMethodCallMessage)reqMsg);
			if (reqMsg != null)
			{
				((ReturnMessage)message).SetLogicalCallContext((LogicalCallContext)reqMsg.Properties[Message.CallContextKey]);
			}
		}
		return message;
	}

	[SecurityCritical]
	internal static object AsyncProcessMessageCallback(object[] args)
	{
		AsyncWorkItem replySink = null;
		IMessage msg = (IMessage)args[0];
		IMessageSink messageSink = (IMessageSink)args[1];
		Context oldCtx = (Context)args[2];
		Context context = (Context)args[3];
		IMessageCtrl messageCtrl = null;
		if (messageSink != null)
		{
			replySink = new AsyncWorkItem(messageSink, oldCtx);
		}
		context.NotifyDynamicSinks(msg, bCliSide: false, bStart: true, bAsync: true, bNotifyGlobals: true);
		return context.GetServerContextChain().AsyncProcessMessage(msg, replySink);
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
	{
		IMessage message = InternalSink.ValidateMessage(reqMsg);
		object[] array = new object[4];
		IMessageCtrl result = null;
		if (message != null)
		{
			replySink?.SyncProcessMessage(message);
		}
		else
		{
			ServerIdentity serverIdentity = InternalSink.GetServerIdentity(reqMsg);
			if (RemotingServices.CORProfilerTrackRemotingAsync())
			{
				Guid id = Guid.Empty;
				if (RemotingServices.CORProfilerTrackRemotingCookie())
				{
					object obj = reqMsg.Properties["CORProfilerCookie"];
					if (obj != null)
					{
						id = (Guid)obj;
					}
				}
				RemotingServices.CORProfilerRemotingServerReceivingMessage(id, fIsAsync: true);
				if (replySink != null)
				{
					IMessageSink messageSink = new ServerAsyncReplyTerminatorSink(replySink);
					replySink = messageSink;
				}
			}
			Context serverContext = serverIdentity.ServerContext;
			if (serverContext.IsThreadPoolAware)
			{
				array[0] = reqMsg;
				array[1] = replySink;
				array[2] = Thread.CurrentContext;
				array[3] = serverContext;
				InternalCrossContextDelegate ftnToCall = AsyncProcessMessageCallback;
				result = (IMessageCtrl)Thread.CurrentThread.InternalCrossContextCallback(serverContext, ftnToCall, array);
			}
			else
			{
				AsyncWorkItem asyncWorkItem = null;
				asyncWorkItem = new AsyncWorkItem(reqMsg, replySink, Thread.CurrentContext, serverIdentity);
				WaitCallback callBack = asyncWorkItem.FinishAsyncWork;
				ThreadPool.QueueUserWorkItem(callBack);
			}
		}
		return result;
	}

	[SecurityCritical]
	internal static object DoAsyncDispatchCallback(object[] args)
	{
		AsyncWorkItem replySink = null;
		IMessage msg = (IMessage)args[0];
		IMessageSink messageSink = (IMessageSink)args[1];
		Context oldCtx = (Context)args[2];
		Context context = (Context)args[3];
		IMessageCtrl messageCtrl = null;
		if (messageSink != null)
		{
			replySink = new AsyncWorkItem(messageSink, oldCtx);
		}
		return context.GetServerContextChain().AsyncProcessMessage(msg, replySink);
	}

	[SecurityCritical]
	internal static IMessageCtrl DoAsyncDispatch(IMessage reqMsg, IMessageSink replySink)
	{
		object[] array = new object[4];
		ServerIdentity serverIdentity = InternalSink.GetServerIdentity(reqMsg);
		if (RemotingServices.CORProfilerTrackRemotingAsync())
		{
			Guid id = Guid.Empty;
			if (RemotingServices.CORProfilerTrackRemotingCookie())
			{
				object obj = reqMsg.Properties["CORProfilerCookie"];
				if (obj != null)
				{
					id = (Guid)obj;
				}
			}
			RemotingServices.CORProfilerRemotingServerReceivingMessage(id, fIsAsync: true);
			if (replySink != null)
			{
				IMessageSink messageSink = new ServerAsyncReplyTerminatorSink(replySink);
				replySink = messageSink;
			}
		}
		IMessageCtrl messageCtrl = null;
		Context serverContext = serverIdentity.ServerContext;
		array[0] = reqMsg;
		array[1] = replySink;
		array[2] = Thread.CurrentContext;
		array[3] = serverContext;
		InternalCrossContextDelegate ftnToCall = DoAsyncDispatchCallback;
		return (IMessageCtrl)Thread.CurrentThread.InternalCrossContextCallback(serverContext, ftnToCall, array);
	}
}
