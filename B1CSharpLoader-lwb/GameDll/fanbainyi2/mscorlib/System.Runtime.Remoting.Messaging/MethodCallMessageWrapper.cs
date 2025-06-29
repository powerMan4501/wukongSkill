using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Remoting.Messaging;

[SecurityCritical]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public class MethodCallMessageWrapper : InternalMessageWrapper, IMethodCallMessage, IMethodMessage, IMessage
{
	private class MCMWrapperDictionary : Hashtable
	{
		private IMethodCallMessage _mcmsg;

		private IDictionary _idict;

		public override object this[object key]
		{
			[SecuritySafeCritical]
			get
			{
				return (key as string) switch
				{
					"__Uri" => _mcmsg.Uri, 
					"__MethodName" => _mcmsg.MethodName, 
					"__MethodSignature" => _mcmsg.MethodSignature, 
					"__TypeName" => _mcmsg.TypeName, 
					"__Args" => _mcmsg.Args, 
					_ => _idict[key], 
				};
			}
			[SecuritySafeCritical]
			set
			{
				switch (key as string)
				{
				case "__MethodName":
				case "__MethodSignature":
				case "__TypeName":
				case "__Args":
					throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
				}
				_idict[key] = value;
			}
		}

		public MCMWrapperDictionary(IMethodCallMessage msg, IDictionary idict)
		{
			_mcmsg = msg;
			_idict = idict;
		}
	}

	private IMethodCallMessage _msg;

	private IDictionary _properties;

	private ArgMapper _argMapper;

	private object[] _args;

	public virtual string Uri
	{
		[SecurityCritical]
		get
		{
			return _msg.Uri;
		}
		set
		{
			_msg.Properties[Message.UriKey] = value;
		}
	}

	public virtual string MethodName
	{
		[SecurityCritical]
		get
		{
			return _msg.MethodName;
		}
	}

	public virtual string TypeName
	{
		[SecurityCritical]
		get
		{
			return _msg.TypeName;
		}
	}

	public virtual object MethodSignature
	{
		[SecurityCritical]
		get
		{
			return _msg.MethodSignature;
		}
	}

	public virtual LogicalCallContext LogicalCallContext
	{
		[SecurityCritical]
		get
		{
			return _msg.LogicalCallContext;
		}
	}

	public virtual MethodBase MethodBase
	{
		[SecurityCritical]
		get
		{
			return _msg.MethodBase;
		}
	}

	public virtual int ArgCount
	{
		[SecurityCritical]
		get
		{
			if (_args != null)
			{
				return _args.Length;
			}
			return 0;
		}
	}

	public virtual object[] Args
	{
		[SecurityCritical]
		get
		{
			return _args;
		}
		set
		{
			_args = value;
		}
	}

	public virtual bool HasVarArgs
	{
		[SecurityCritical]
		get
		{
			return _msg.HasVarArgs;
		}
	}

	public virtual int InArgCount
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

	public virtual object[] InArgs
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

	public virtual IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			if (_properties == null)
			{
				_properties = new MCMWrapperDictionary(this, _msg.Properties);
			}
			return _properties;
		}
	}

	public MethodCallMessageWrapper(IMethodCallMessage msg)
		: base(msg)
	{
		_msg = msg;
		_args = _msg.Args;
	}

	[SecurityCritical]
	public virtual string GetArgName(int index)
	{
		return _msg.GetArgName(index);
	}

	[SecurityCritical]
	public virtual object GetArg(int argNum)
	{
		return _args[argNum];
	}

	[SecurityCritical]
	public virtual object GetInArg(int argNum)
	{
		if (_argMapper == null)
		{
			_argMapper = new ArgMapper(this, fOut: false);
		}
		return _argMapper.GetArg(argNum);
	}

	[SecurityCritical]
	public virtual string GetInArgName(int index)
	{
		if (_argMapper == null)
		{
			_argMapper = new ArgMapper(this, fOut: false);
		}
		return _argMapper.GetArgName(index);
	}
}
