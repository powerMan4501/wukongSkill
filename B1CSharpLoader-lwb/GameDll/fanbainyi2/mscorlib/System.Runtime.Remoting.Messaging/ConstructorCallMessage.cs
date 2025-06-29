using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Proxies;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Messaging;

internal class ConstructorCallMessage : IConstructionCallMessage, IMethodCallMessage, IMethodMessage, IMessage
{
	private object[] _callSiteActivationAttributes;

	private object[] _womGlobalAttributes;

	private object[] _typeAttributes;

	[NonSerialized]
	private RuntimeType _activationType;

	private string _activationTypeName;

	private IList _contextProperties;

	private int _iFlags;

	private Message _message;

	private object _properties;

	private ArgMapper _argMapper;

	private IActivator _activator;

	private const int CCM_ACTIVATEINCONTEXT = 1;

	public object[] CallSiteActivationAttributes
	{
		[SecurityCritical]
		get
		{
			return _callSiteActivationAttributes;
		}
	}

	public Type ActivationType
	{
		[SecurityCritical]
		get
		{
			if (_activationType == null && _activationTypeName != null)
			{
				_activationType = RemotingServices.InternalGetTypeFromQualifiedTypeName(_activationTypeName, partialFallback: false);
			}
			return _activationType;
		}
	}

	public string ActivationTypeName
	{
		[SecurityCritical]
		get
		{
			return _activationTypeName;
		}
	}

	public IList ContextProperties
	{
		[SecurityCritical]
		get
		{
			if (_contextProperties == null)
			{
				_contextProperties = new ArrayList();
			}
			return _contextProperties;
		}
	}

	public string Uri
	{
		[SecurityCritical]
		get
		{
			if (_message != null)
			{
				return _message.Uri;
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
		set
		{
			if (_message != null)
			{
				_message.Uri = value;
				return;
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
	}

	public string MethodName
	{
		[SecurityCritical]
		get
		{
			if (_message != null)
			{
				return _message.MethodName;
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
	}

	public string TypeName
	{
		[SecurityCritical]
		get
		{
			if (_message != null)
			{
				return _message.TypeName;
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
	}

	public object MethodSignature
	{
		[SecurityCritical]
		get
		{
			if (_message != null)
			{
				return _message.MethodSignature;
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
	}

	public MethodBase MethodBase
	{
		[SecurityCritical]
		get
		{
			if (_message != null)
			{
				return _message.MethodBase;
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
	}

	public int InArgCount
	{
		[SecurityCritical]
		get
		{
			if (_argMapper == null)
			{
				_argMapper = new ArgMapper(this, fOut: false);
			}
			return _argMapper.ArgCount;
		}
	}

	public object[] InArgs
	{
		[SecurityCritical]
		get
		{
			if (_argMapper == null)
			{
				_argMapper = new ArgMapper(this, fOut: false);
			}
			return _argMapper.Args;
		}
	}

	public int ArgCount
	{
		[SecurityCritical]
		get
		{
			if (_message != null)
			{
				return _message.ArgCount;
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
	}

	public bool HasVarArgs
	{
		[SecurityCritical]
		get
		{
			if (_message != null)
			{
				return _message.HasVarArgs;
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
	}

	public object[] Args
	{
		[SecurityCritical]
		get
		{
			if (_message != null)
			{
				return _message.Args;
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
	}

	public IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			if (_properties == null)
			{
				object value = new CCMDictionary(this, new Hashtable());
				Interlocked.CompareExchange(ref _properties, value, null);
			}
			return (IDictionary)_properties;
		}
	}

	public IActivator Activator
	{
		[SecurityCritical]
		get
		{
			return _activator;
		}
		[SecurityCritical]
		set
		{
			_activator = value;
		}
	}

	public LogicalCallContext LogicalCallContext
	{
		[SecurityCritical]
		get
		{
			return GetLogicalCallContext();
		}
	}

	internal bool ActivateInContext
	{
		get
		{
			return (_iFlags & 1) != 0;
		}
		set
		{
			_iFlags = (value ? (_iFlags | 1) : (_iFlags & -2));
		}
	}

	private ConstructorCallMessage()
	{
	}

	[SecurityCritical]
	internal ConstructorCallMessage(object[] callSiteActivationAttributes, object[] womAttr, object[] typeAttr, RuntimeType serverType)
	{
		_activationType = serverType;
		_activationTypeName = RemotingServices.GetDefaultQualifiedTypeName(_activationType);
		_callSiteActivationAttributes = callSiteActivationAttributes;
		_womGlobalAttributes = womAttr;
		_typeAttributes = typeAttr;
	}

	[SecurityCritical]
	public object GetThisPtr()
	{
		if (_message != null)
		{
			return _message.GetThisPtr();
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
	}

	internal object[] GetWOMAttributes()
	{
		return _womGlobalAttributes;
	}

	internal object[] GetTypeAttributes()
	{
		return _typeAttributes;
	}

	[SecurityCritical]
	public object GetInArg(int argNum)
	{
		if (_argMapper == null)
		{
			_argMapper = new ArgMapper(this, fOut: false);
		}
		return _argMapper.GetArg(argNum);
	}

	[SecurityCritical]
	public string GetInArgName(int index)
	{
		if (_argMapper == null)
		{
			_argMapper = new ArgMapper(this, fOut: false);
		}
		return _argMapper.GetArgName(index);
	}

	[SecurityCritical]
	public object GetArg(int argNum)
	{
		if (_message != null)
		{
			return _message.GetArg(argNum);
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
	}

	[SecurityCritical]
	public string GetArgName(int index)
	{
		if (_message != null)
		{
			return _message.GetArgName(index);
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
	}

	[SecurityCritical]
	internal void SetFrame(MessageData msgData)
	{
		_message = new Message();
		_message.InitFields(msgData);
	}

	[SecurityCritical]
	internal LogicalCallContext GetLogicalCallContext()
	{
		if (_message != null)
		{
			return _message.GetLogicalCallContext();
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
	}

	[SecurityCritical]
	internal LogicalCallContext SetLogicalCallContext(LogicalCallContext ctx)
	{
		if (_message != null)
		{
			return _message.SetLogicalCallContext(ctx);
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
	}

	internal Message GetMessage()
	{
		return _message;
	}
}
