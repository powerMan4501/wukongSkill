using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Remoting.Messaging;

[SecurityCritical]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public class MethodReturnMessageWrapper : InternalMessageWrapper, IMethodReturnMessage, IMethodMessage, IMessage
{
	private class MRMWrapperDictionary : Hashtable
	{
		private IMethodReturnMessage _mrmsg;

		private IDictionary _idict;

		public override object this[object key]
		{
			[SecuritySafeCritical]
			get
			{
				return (key as string) switch
				{
					"__Uri" => _mrmsg.Uri, 
					"__MethodName" => _mrmsg.MethodName, 
					"__MethodSignature" => _mrmsg.MethodSignature, 
					"__TypeName" => _mrmsg.TypeName, 
					"__Return" => _mrmsg.ReturnValue, 
					"__OutArgs" => _mrmsg.OutArgs, 
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
				case "__Return":
				case "__OutArgs":
					throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
				}
				_idict[key] = value;
			}
		}

		public MRMWrapperDictionary(IMethodReturnMessage msg, IDictionary idict)
		{
			_mrmsg = msg;
			_idict = idict;
		}
	}

	private IMethodReturnMessage _msg;

	private IDictionary _properties;

	private ArgMapper _argMapper;

	private object[] _args;

	private object _returnValue;

	private Exception _exception;

	public string Uri
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

	public virtual int OutArgCount
	{
		[SecurityCritical]
		get
		{
			if (_argMapper == null)
			{
				_argMapper = new ArgMapper(this, fOut: true);
			}
			return _argMapper.ArgCount;
		}
	}

	public virtual object[] OutArgs
	{
		[SecurityCritical]
		get
		{
			if (_argMapper == null)
			{
				_argMapper = new ArgMapper(this, fOut: true);
			}
			return _argMapper.Args;
		}
	}

	public virtual Exception Exception
	{
		[SecurityCritical]
		get
		{
			return _exception;
		}
		set
		{
			_exception = value;
		}
	}

	public virtual object ReturnValue
	{
		[SecurityCritical]
		get
		{
			return _returnValue;
		}
		set
		{
			_returnValue = value;
		}
	}

	public virtual IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			if (_properties == null)
			{
				_properties = new MRMWrapperDictionary(this, _msg.Properties);
			}
			return _properties;
		}
	}

	public MethodReturnMessageWrapper(IMethodReturnMessage msg)
		: base(msg)
	{
		_msg = msg;
		_args = _msg.Args;
		_returnValue = _msg.ReturnValue;
		_exception = _msg.Exception;
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
	public virtual object GetOutArg(int argNum)
	{
		if (_argMapper == null)
		{
			_argMapper = new ArgMapper(this, fOut: true);
		}
		return _argMapper.GetArg(argNum);
	}

	[SecurityCritical]
	public virtual string GetOutArgName(int index)
	{
		if (_argMapper == null)
		{
			_argMapper = new ArgMapper(this, fOut: true);
		}
		return _argMapper.GetArgName(index);
	}
}
