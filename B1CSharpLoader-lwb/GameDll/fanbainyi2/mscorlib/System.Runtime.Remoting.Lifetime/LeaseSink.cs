using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting.Lifetime;

internal class LeaseSink : IMessageSink
{
	private Lease lease;

	private IMessageSink nextSink;

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return nextSink;
		}
	}

	public LeaseSink(Lease lease, IMessageSink nextSink)
	{
		this.lease = lease;
		this.nextSink = nextSink;
	}

	[SecurityCritical]
	public IMessage SyncProcessMessage(IMessage msg)
	{
		lease.RenewOnCall();
		return nextSink.SyncProcessMessage(msg);
	}

	[SecurityCritical]
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		lease.RenewOnCall();
		return nextSink.AsyncProcessMessage(msg, replySink);
	}
}
