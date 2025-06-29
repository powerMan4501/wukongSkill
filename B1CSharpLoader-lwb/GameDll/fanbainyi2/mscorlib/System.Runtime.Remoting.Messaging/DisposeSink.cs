using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class DisposeSink : IMessageSink
{
	private IDisposable _iDis;

	private IMessageSink _replySink;

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return _replySink;
		}
	}

	internal DisposeSink(IDisposable iDis, IMessageSink replySink)
	{
		_iDis = iDis;
		_replySink = replySink;
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage reqMsg)
	{
		IMessage result = null;
		try
		{
			if (_replySink != null)
			{
				result = _replySink.SyncProcessMessage(reqMsg);
			}
		}
		finally
		{
			_iDis.Dispose();
		}
		return result;
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
	{
		throw new NotSupportedException();
	}
}
