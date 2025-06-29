using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

[SecurityCritical]
[ComVisible(true)]
public class InternalMessageWrapper
{
	protected IMessage WrappedMessage;

	public InternalMessageWrapper(IMessage msg)
	{
		WrappedMessage = msg;
	}

	[SecurityCritical]
	internal object GetIdentityObject()
	{
		if (WrappedMessage is IInternalMessage internalMessage)
		{
			return internalMessage.IdentityObject;
		}
		if (WrappedMessage is InternalMessageWrapper internalMessageWrapper)
		{
			return internalMessageWrapper.GetIdentityObject();
		}
		return null;
	}

	[SecurityCritical]
	internal object GetServerIdentityObject()
	{
		if (WrappedMessage is IInternalMessage internalMessage)
		{
			return internalMessage.ServerIdentityObject;
		}
		if (WrappedMessage is InternalMessageWrapper internalMessageWrapper)
		{
			return internalMessageWrapper.GetServerIdentityObject();
		}
		return null;
	}
}
