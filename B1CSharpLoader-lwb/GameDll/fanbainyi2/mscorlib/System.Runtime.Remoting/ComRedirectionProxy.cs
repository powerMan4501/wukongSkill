using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting;

internal class ComRedirectionProxy : MarshalByRefObject, IMessageSink
{
	private MarshalByRefObject _comObject;

	private Type _serverType;

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	internal ComRedirectionProxy(MarshalByRefObject comObject, Type serverType)
	{
		_comObject = comObject;
		_serverType = serverType;
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage msg)
	{
		IMethodCallMessage reqMsg = (IMethodCallMessage)msg;
		IMethodReturnMessage methodReturnMessage = null;
		methodReturnMessage = RemotingServices.ExecuteMessage(_comObject, reqMsg);
		if (methodReturnMessage != null && methodReturnMessage.Exception is COMException ex && (ex._HResult == -2147023174 || ex._HResult == -2147023169))
		{
			_comObject = (MarshalByRefObject)Activator.CreateInstance(_serverType, nonPublic: true);
			methodReturnMessage = RemotingServices.ExecuteMessage(_comObject, reqMsg);
		}
		return methodReturnMessage;
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
