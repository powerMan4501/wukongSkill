using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.Remoting;

[SecurityCritical]
[ComVisible(true)]
public class InternalRemotingServices
{
	[SecurityCritical]
	[Conditional("_LOGGING")]
	public static void DebugOutChnl(string s)
	{
		Message.OutToUnmanagedDebugger("CHNL:" + s + "\n");
	}

	[Conditional("_LOGGING")]
	public static void RemotingTrace(params object[] messages)
	{
	}

	[Conditional("_DEBUG")]
	public static void RemotingAssert(bool condition, string message)
	{
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	public static void SetServerIdentity(MethodCall m, object srvID)
	{
		((IInternalMessage)m).ServerIdentityObject = (ServerIdentity)srvID;
	}

	internal static RemotingMethodCachedData GetReflectionCachedData(MethodBase mi)
	{
		RuntimeMethodInfo runtimeMethodInfo = null;
		RuntimeConstructorInfo runtimeConstructorInfo = null;
		if ((runtimeMethodInfo = mi as RuntimeMethodInfo) != null)
		{
			return runtimeMethodInfo.RemotingCache;
		}
		if ((runtimeConstructorInfo = mi as RuntimeConstructorInfo) != null)
		{
			return runtimeConstructorInfo.RemotingCache;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeReflectionObject"));
	}

	internal static RemotingTypeCachedData GetReflectionCachedData(RuntimeType type)
	{
		return type.RemotingCache;
	}

	internal static RemotingCachedData GetReflectionCachedData(MemberInfo mi)
	{
		MethodBase methodBase = null;
		RuntimeType runtimeType = null;
		RuntimeFieldInfo runtimeFieldInfo = null;
		SerializationFieldInfo serializationFieldInfo = null;
		if ((methodBase = mi as MethodBase) != null)
		{
			return GetReflectionCachedData(methodBase);
		}
		if ((runtimeType = mi as RuntimeType) != null)
		{
			return GetReflectionCachedData(runtimeType);
		}
		if ((runtimeFieldInfo = mi as RuntimeFieldInfo) != null)
		{
			return runtimeFieldInfo.RemotingCache;
		}
		if ((serializationFieldInfo = mi as SerializationFieldInfo) != null)
		{
			return serializationFieldInfo.RemotingCache;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeReflectionObject"));
	}

	internal static RemotingCachedData GetReflectionCachedData(RuntimeParameterInfo reflectionObject)
	{
		return reflectionObject.RemotingCache;
	}

	[SecurityCritical]
	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject)
	{
		MemberInfo memberInfo = reflectionObject as MemberInfo;
		RuntimeParameterInfo runtimeParameterInfo = reflectionObject as RuntimeParameterInfo;
		if (memberInfo != null)
		{
			return GetReflectionCachedData(memberInfo).GetSoapAttribute();
		}
		if (runtimeParameterInfo != null)
		{
			return GetReflectionCachedData(runtimeParameterInfo).GetSoapAttribute();
		}
		return null;
	}
}
