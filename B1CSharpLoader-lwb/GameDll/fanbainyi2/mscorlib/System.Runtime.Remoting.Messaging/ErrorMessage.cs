using System.Collections;
using System.Reflection;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
{
	private string m_URI = "Exception";

	private string m_MethodName = "Unknown";

	private string m_TypeName = "Unknown";

	private object m_MethodSignature;

	private int m_ArgCount;

	private string m_ArgName = "Unknown";

	public IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	public string Uri
	{
		[SecurityCritical]
		get
		{
			return m_URI;
		}
	}

	public string MethodName
	{
		[SecurityCritical]
		get
		{
			return m_MethodName;
		}
	}

	public string TypeName
	{
		[SecurityCritical]
		get
		{
			return m_TypeName;
		}
	}

	public object MethodSignature
	{
		[SecurityCritical]
		get
		{
			return m_MethodSignature;
		}
	}

	public MethodBase MethodBase
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	public int ArgCount
	{
		[SecurityCritical]
		get
		{
			return m_ArgCount;
		}
	}

	public object[] Args
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	public bool HasVarArgs
	{
		[SecurityCritical]
		get
		{
			return false;
		}
	}

	public int InArgCount
	{
		[SecurityCritical]
		get
		{
			return m_ArgCount;
		}
	}

	public object[] InArgs
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	public LogicalCallContext LogicalCallContext
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	[SecurityCritical]
	public string GetArgName(int index)
	{
		return m_ArgName;
	}

	[SecurityCritical]
	public object GetArg(int argNum)
	{
		return null;
	}

	[SecurityCritical]
	public string GetInArgName(int index)
	{
		return null;
	}

	[SecurityCritical]
	public object GetInArg(int argNum)
	{
		return null;
	}
}
