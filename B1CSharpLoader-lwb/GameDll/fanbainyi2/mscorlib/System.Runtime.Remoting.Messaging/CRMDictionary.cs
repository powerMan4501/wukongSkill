using System.Collections;
using System.Runtime.Remoting.Activation;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class CRMDictionary : MessageDictionary
{
	public static string[] CRMkeysFault = new string[5] { "__Uri", "__MethodName", "__MethodSignature", "__TypeName", "__CallContext" };

	public static string[] CRMkeysNoFault = new string[7] { "__Uri", "__MethodName", "__MethodSignature", "__TypeName", "__Return", "__OutArgs", "__CallContext" };

	internal IConstructionReturnMessage _crmsg;

	internal bool fault;

	[SecurityCritical]
	public CRMDictionary(IConstructionReturnMessage msg, IDictionary idict)
		: base((msg.Exception != null) ? CRMkeysFault : CRMkeysNoFault, idict)
	{
		fault = msg.Exception != null;
		_crmsg = msg;
	}

	[SecuritySafeCritical]
	internal override object GetMessageValue(int i)
	{
		switch (i)
		{
		case 0:
			return _crmsg.Uri;
		case 1:
			return _crmsg.MethodName;
		case 2:
			return _crmsg.MethodSignature;
		case 3:
			return _crmsg.TypeName;
		case 4:
			if (!fault)
			{
				return _crmsg.ReturnValue;
			}
			return FetchLogicalCallContext();
		case 5:
			return _crmsg.Args;
		case 6:
			return FetchLogicalCallContext();
		default:
			throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
		}
	}

	[SecurityCritical]
	private LogicalCallContext FetchLogicalCallContext()
	{
		if (_crmsg is ReturnMessage returnMessage)
		{
			return returnMessage.GetLogicalCallContext();
		}
		if (_crmsg is MethodResponse methodResponse)
		{
			return methodResponse.GetLogicalCallContext();
		}
		throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadType"));
	}

	[SecurityCritical]
	internal override void SetSpecialKey(int keyNum, object value)
	{
		ReturnMessage returnMessage = _crmsg as ReturnMessage;
		MethodResponse methodResponse = _crmsg as MethodResponse;
		switch (keyNum)
		{
		case 0:
			if (returnMessage != null)
			{
				returnMessage.Uri = (string)value;
				break;
			}
			if (methodResponse != null)
			{
				methodResponse.Uri = (string)value;
				break;
			}
			throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadType"));
		case 1:
			if (returnMessage != null)
			{
				returnMessage.SetLogicalCallContext((LogicalCallContext)value);
				break;
			}
			if (methodResponse != null)
			{
				methodResponse.SetLogicalCallContext((LogicalCallContext)value);
				break;
			}
			throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadType"));
		default:
			throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
		}
	}
}
