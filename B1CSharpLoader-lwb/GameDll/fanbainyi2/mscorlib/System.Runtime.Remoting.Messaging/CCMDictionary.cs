using System.Collections;
using System.Runtime.Remoting.Activation;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class CCMDictionary : MessageDictionary
{
	public static string[] CCMkeys = new string[11]
	{
		"__Uri", "__MethodName", "__MethodSignature", "__TypeName", "__Args", "__CallContext", "__CallSiteActivationAttributes", "__ActivationType", "__ContextProperties", "__Activator",
		"__ActivationTypeName"
	};

	internal IConstructionCallMessage _ccmsg;

	public CCMDictionary(IConstructionCallMessage msg, IDictionary idict)
		: base(CCMkeys, idict)
	{
		_ccmsg = msg;
	}

	[SecuritySafeCritical]
	internal override object GetMessageValue(int i)
	{
		return i switch
		{
			0 => _ccmsg.Uri, 
			1 => _ccmsg.MethodName, 
			2 => _ccmsg.MethodSignature, 
			3 => _ccmsg.TypeName, 
			4 => _ccmsg.Args, 
			5 => FetchLogicalCallContext(), 
			6 => _ccmsg.CallSiteActivationAttributes, 
			7 => null, 
			8 => _ccmsg.ContextProperties, 
			9 => _ccmsg.Activator, 
			10 => _ccmsg.ActivationTypeName, 
			_ => throw new RemotingException(Environment.GetResourceString("Remoting_Default")), 
		};
	}

	[SecurityCritical]
	private LogicalCallContext FetchLogicalCallContext()
	{
		if (_ccmsg is ConstructorCallMessage constructorCallMessage)
		{
			return constructorCallMessage.GetLogicalCallContext();
		}
		if (_ccmsg is ConstructionCall)
		{
			return ((MethodCall)_ccmsg).GetLogicalCallContext();
		}
		throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadType"));
	}

	[SecurityCritical]
	internal override void SetSpecialKey(int keyNum, object value)
	{
		switch (keyNum)
		{
		case 0:
			((ConstructorCallMessage)_ccmsg).Uri = (string)value;
			break;
		case 1:
			((ConstructorCallMessage)_ccmsg).SetLogicalCallContext((LogicalCallContext)value);
			break;
		default:
			throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
		}
	}
}
