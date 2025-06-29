using System.Collections;
using System.Runtime.Remoting.Activation;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class InternalSink
{
	[SecurityCritical]
	internal static IMessage ValidateMessage(IMessage reqMsg)
	{
		IMessage result = null;
		if (reqMsg == null)
		{
			result = new ReturnMessage(new ArgumentNullException("reqMsg"), null);
		}
		return result;
	}

	[SecurityCritical]
	internal static IMessage DisallowAsyncActivation(IMessage reqMsg)
	{
		if (reqMsg is IConstructionCallMessage)
		{
			return new ReturnMessage(new RemotingException(Environment.GetResourceString("Remoting_Activation_AsyncUnsupported")), null);
		}
		return null;
	}

	[SecurityCritical]
	internal static Identity GetIdentity(IMessage reqMsg)
	{
		Identity identity = null;
		if (reqMsg is IInternalMessage)
		{
			identity = ((IInternalMessage)reqMsg).IdentityObject;
		}
		else if (reqMsg is InternalMessageWrapper)
		{
			identity = (Identity)((InternalMessageWrapper)reqMsg).GetIdentityObject();
		}
		if (identity == null)
		{
			string uRI = GetURI(reqMsg);
			identity = IdentityHolder.ResolveIdentity(uRI);
			if (identity == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Remoting_ServerObjectNotFound", uRI));
			}
		}
		return identity;
	}

	[SecurityCritical]
	internal static ServerIdentity GetServerIdentity(IMessage reqMsg)
	{
		ServerIdentity serverIdentity = null;
		bool flag = false;
		string text = null;
		IInternalMessage internalMessage = reqMsg as IInternalMessage;
		if (internalMessage != null)
		{
			serverIdentity = ((IInternalMessage)reqMsg).ServerIdentityObject;
			flag = true;
		}
		else if (reqMsg is InternalMessageWrapper)
		{
			serverIdentity = (ServerIdentity)((InternalMessageWrapper)reqMsg).GetServerIdentityObject();
		}
		if (serverIdentity == null)
		{
			text = GetURI(reqMsg);
			Identity identity = IdentityHolder.ResolveIdentity(text);
			if (identity is ServerIdentity)
			{
				serverIdentity = (ServerIdentity)identity;
				if (flag)
				{
					internalMessage.ServerIdentityObject = serverIdentity;
				}
			}
		}
		return serverIdentity;
	}

	[SecurityCritical]
	internal static string GetURI(IMessage msg)
	{
		string result = null;
		if (msg is IMethodMessage methodMessage)
		{
			result = methodMessage.Uri;
		}
		else
		{
			IDictionary properties = msg.Properties;
			if (properties != null)
			{
				result = (string)properties["__Uri"];
			}
		}
		return result;
	}
}
