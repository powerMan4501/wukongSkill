using System.Runtime.Remoting.Contexts;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class ServerObjectTerminatorSink : InternalSink, IMessageSink
{
	internal StackBuilderSink _stackBuilderSink;

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	internal ServerObjectTerminatorSink(MarshalByRefObject srvObj)
	{
		_stackBuilderSink = new StackBuilderSink(srvObj);
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage reqMsg)
	{
		IMessage message = InternalSink.ValidateMessage(reqMsg);
		if (message != null)
		{
			return message;
		}
		ServerIdentity serverIdentity = InternalSink.GetServerIdentity(reqMsg);
		ArrayWithSize serverSideDynamicSinks = serverIdentity.ServerSideDynamicSinks;
		if (serverSideDynamicSinks != null)
		{
			DynamicPropertyHolder.NotifyDynamicSinks(reqMsg, serverSideDynamicSinks, bCliSide: false, bStart: true, bAsync: false);
		}
		IMessage message2 = ((!(_stackBuilderSink.ServerObject is IMessageSink messageSink)) ? _stackBuilderSink.SyncProcessMessage(reqMsg) : messageSink.SyncProcessMessage(reqMsg));
		if (serverSideDynamicSinks != null)
		{
			DynamicPropertyHolder.NotifyDynamicSinks(message2, serverSideDynamicSinks, bCliSide: false, bStart: false, bAsync: false);
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
			result = ((!(_stackBuilderSink.ServerObject is IMessageSink messageSink)) ? _stackBuilderSink.AsyncProcessMessage(reqMsg, replySink) : messageSink.AsyncProcessMessage(reqMsg, replySink));
		}
		else
		{
			replySink?.SyncProcessMessage(message);
		}
		return result;
	}
}
