using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Security;

namespace System.Runtime.Remoting;

internal class RedirectionProxy : MarshalByRefObject, IMessageSink
{
	private MarshalByRefObject _proxy;

	[SecurityCritical]
	private RealProxy _realProxy;

	private Type _serverType;

	private WellKnownObjectMode _objectMode;

	public WellKnownObjectMode ObjectMode
	{
		set
		{
			_objectMode = value;
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
	internal RedirectionProxy(MarshalByRefObject proxy, Type serverType)
	{
		_proxy = proxy;
		_realProxy = RemotingServices.GetRealProxy(_proxy);
		_serverType = serverType;
		_objectMode = WellKnownObjectMode.Singleton;
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage msg)
	{
		IMessage message = null;
		try
		{
			msg.Properties["__Uri"] = _realProxy.IdentityObject.URI;
			if (_objectMode == WellKnownObjectMode.Singleton)
			{
				return _realProxy.Invoke(msg);
			}
			MarshalByRefObject proxy = (MarshalByRefObject)Activator.CreateInstance(_serverType, nonPublic: true);
			RealProxy realProxy = RemotingServices.GetRealProxy(proxy);
			return realProxy.Invoke(msg);
		}
		catch (Exception e)
		{
			return new ReturnMessage(e, msg as IMethodCallMessage);
		}
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		IMessage message = null;
		message = SyncProcessMessage(msg);
		replySink?.SyncProcessMessage(message);
		return null;
	}
}
