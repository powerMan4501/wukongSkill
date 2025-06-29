using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class ServerContextTerminatorSink : InternalSink, IMessageSink
{
	private static volatile ServerContextTerminatorSink messageSink;

	private static object staticSyncObject = new object();

	internal static IMessageSink MessageSink
	{
		get
		{
			if (messageSink == null)
			{
				ServerContextTerminatorSink serverContextTerminatorSink = new ServerContextTerminatorSink();
				lock (staticSyncObject)
				{
					if (messageSink == null)
					{
						messageSink = serverContextTerminatorSink;
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
		Context currentContext = Thread.CurrentContext;
		IMessage message2;
		if (reqMsg is IConstructionCallMessage)
		{
			message = currentContext.NotifyActivatorProperties(reqMsg, bServerSide: true);
			if (message != null)
			{
				return message;
			}
			message2 = ((IConstructionCallMessage)reqMsg).Activator.Activate((IConstructionCallMessage)reqMsg);
			message = currentContext.NotifyActivatorProperties(message2, bServerSide: true);
			if (message != null)
			{
				return message;
			}
		}
		else
		{
			MarshalByRefObject obj = null;
			try
			{
				message2 = GetObjectChain(reqMsg, out obj).SyncProcessMessage(reqMsg);
			}
			finally
			{
				IDisposable disposable = null;
				if (obj != null && obj is IDisposable disposable2)
				{
					disposable2.Dispose();
				}
			}
		}
		return message2;
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
	{
		IMessageCtrl result = null;
		IMessage message = InternalSink.ValidateMessage(reqMsg);
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
			MarshalByRefObject obj;
			IMessageSink objectChain = GetObjectChain(reqMsg, out obj);
			if (obj != null && obj is IDisposable iDis)
			{
				DisposeSink disposeSink = new DisposeSink(iDis, replySink);
				replySink = disposeSink;
			}
			result = objectChain.AsyncProcessMessage(reqMsg, replySink);
		}
		return result;
	}

	[SecurityCritical]
	internal virtual IMessageSink GetObjectChain(IMessage reqMsg, out MarshalByRefObject obj)
	{
		ServerIdentity serverIdentity = InternalSink.GetServerIdentity(reqMsg);
		return serverIdentity.GetServerObjectChain(out obj);
	}
}
