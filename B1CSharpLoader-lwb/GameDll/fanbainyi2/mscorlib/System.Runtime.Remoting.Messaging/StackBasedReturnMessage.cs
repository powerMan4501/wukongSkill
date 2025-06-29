using System.Collections;
using System.Reflection;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class StackBasedReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
{
	private Message _m;

	private Hashtable _h;

	private MRMDictionary _d;

	private ArgMapper _argMapper;

	public string Uri
	{
		[SecurityCritical]
		get
		{
			return _m.Uri;
		}
	}

	public string MethodName
	{
		[SecurityCritical]
		get
		{
			return _m.MethodName;
		}
	}

	public string TypeName
	{
		[SecurityCritical]
		get
		{
			return _m.TypeName;
		}
	}

	public object MethodSignature
	{
		[SecurityCritical]
		get
		{
			return _m.MethodSignature;
		}
	}

	public MethodBase MethodBase
	{
		[SecurityCritical]
		get
		{
			return _m.MethodBase;
		}
	}

	public bool HasVarArgs
	{
		[SecurityCritical]
		get
		{
			return _m.HasVarArgs;
		}
	}

	public int ArgCount
	{
		[SecurityCritical]
		get
		{
			return _m.ArgCount;
		}
	}

	public object[] Args
	{
		[SecurityCritical]
		get
		{
			return _m.Args;
		}
	}

	public LogicalCallContext LogicalCallContext
	{
		[SecurityCritical]
		get
		{
			return _m.GetLogicalCallContext();
		}
	}

	public int OutArgCount
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

	public object[] OutArgs
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

	public Exception Exception
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	public object ReturnValue
	{
		[SecurityCritical]
		get
		{
			return _m.GetReturnValue();
		}
	}

	public IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			lock (this)
			{
				if (_h == null)
				{
					_h = new Hashtable();
				}
				if (_d == null)
				{
					_d = new MRMDictionary(this, _h);
				}
				return _d;
			}
		}
	}

	ServerIdentity IInternalMessage.ServerIdentityObject
	{
		[SecurityCritical]
		get
		{
			return null;
		}
		[SecurityCritical]
		set
		{
		}
	}

	Identity IInternalMessage.IdentityObject
	{
		[SecurityCritical]
		get
		{
			return null;
		}
		[SecurityCritical]
		set
		{
		}
	}

	internal StackBasedReturnMessage()
	{
	}

	internal void InitFields(Message m)
	{
		_m = m;
		if (_h != null)
		{
			_h.Clear();
		}
		if (_d != null)
		{
			_d.Clear();
		}
	}

	[SecurityCritical]
	public object GetArg(int argNum)
	{
		return _m.GetArg(argNum);
	}

	[SecurityCritical]
	public string GetArgName(int index)
	{
		return _m.GetArgName(index);
	}

	[SecurityCritical]
	internal LogicalCallContext GetLogicalCallContext()
	{
		return _m.GetLogicalCallContext();
	}

	[SecurityCritical]
	internal LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
	{
		return _m.SetLogicalCallContext(callCtx);
	}

	[SecurityCritical]
	public object GetOutArg(int argNum)
	{
		if (_argMapper == null)
		{
			_argMapper = new ArgMapper(this, fOut: true);
		}
		return _argMapper.GetArg(argNum);
	}

	[SecurityCritical]
	public string GetOutArgName(int index)
	{
		if (_argMapper == null)
		{
			_argMapper = new ArgMapper(this, fOut: true);
		}
		return _argMapper.GetArgName(index);
	}

	[SecurityCritical]
	void IInternalMessage.SetURI(string val)
	{
		_m.Uri = val;
	}

	[SecurityCritical]
	void IInternalMessage.SetCallContext(LogicalCallContext newCallContext)
	{
		_m.SetLogicalCallContext(newCallContext);
	}

	[SecurityCritical]
	bool IInternalMessage.HasProperties()
	{
		return _h != null;
	}
}
