using System.Collections;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class MessageSurrogate : ISerializationSurrogate
{
	private static Type _constructionCallType;

	private static Type _methodCallType;

	private static Type _constructionResponseType;

	private static Type _methodResponseType;

	private static Type _exceptionType;

	private static Type _objectType;

	[SecurityCritical]
	private RemotingSurrogateSelector _ss;

	[SecuritySafeCritical]
	static MessageSurrogate()
	{
		_constructionCallType = typeof(ConstructionCall);
		_methodCallType = typeof(MethodCall);
		_constructionResponseType = typeof(ConstructionResponse);
		_methodResponseType = typeof(MethodResponse);
		_exceptionType = typeof(Exception);
		_objectType = typeof(object);
	}

	[SecurityCritical]
	internal MessageSurrogate(RemotingSurrogateSelector ss)
	{
		_ss = ss;
	}

	[SecurityCritical]
	public virtual void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		bool flag = false;
		bool flag2 = false;
		if (obj is IMethodMessage methodMessage)
		{
			IDictionaryEnumerator enumerator = methodMessage.Properties.GetEnumerator();
			if (methodMessage is IMethodCallMessage)
			{
				if (obj is IConstructionCallMessage)
				{
					flag2 = true;
				}
				info.SetType(flag2 ? _constructionCallType : _methodCallType);
			}
			else
			{
				if (!(methodMessage is IMethodReturnMessage))
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_InvalidMsg"));
				}
				flag = true;
				info.SetType((obj is IConstructionReturnMessage) ? _constructionResponseType : _methodResponseType);
				if (((IMethodReturnMessage)methodMessage).Exception != null)
				{
					info.AddValue("__fault", ((IMethodReturnMessage)methodMessage).Exception, _exceptionType);
				}
			}
			while (enumerator.MoveNext())
			{
				if (obj == _ss.GetRootObject() && _ss.Filter != null && _ss.Filter((string)enumerator.Key, enumerator.Value))
				{
					continue;
				}
				if (enumerator.Value != null)
				{
					string text = enumerator.Key.ToString();
					if (text.Equals("__CallContext"))
					{
						LogicalCallContext logicalCallContext = (LogicalCallContext)enumerator.Value;
						if (logicalCallContext.HasInfo)
						{
							info.AddValue(text, logicalCallContext);
						}
						else
						{
							info.AddValue(text, logicalCallContext.RemotingData.LogicalCallID);
						}
					}
					else if (text.Equals("__MethodSignature"))
					{
						if (flag2 || RemotingServices.IsMethodOverloaded(methodMessage))
						{
							info.AddValue(text, enumerator.Value);
						}
					}
					else
					{
						flag = flag;
						info.AddValue(text, enumerator.Value);
					}
				}
				else
				{
					info.AddValue(enumerator.Key.ToString(), enumerator.Value, _objectType);
				}
			}
			return;
		}
		throw new RemotingException(Environment.GetResourceString("Remoting_InvalidMsg"));
	}

	[SecurityCritical]
	public virtual object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_PopulateData"));
	}
}
