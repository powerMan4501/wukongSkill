using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata;
using System.Security;
using System.Security.Principal;
using System.Threading;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class StackBuilderSink : IMessageSink
{
	private object _server;

	private static string sIRemoteDispatch = "System.EnterpriseServices.IRemoteDispatch";

	private static string sIRemoteDispatchAssembly = "System.EnterpriseServices";

	private bool _bStatic;

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	internal object ServerObject => _server;

	public StackBuilderSink(MarshalByRefObject server)
	{
		_server = server;
	}

	public StackBuilderSink(object server)
	{
		_server = server;
		if (_server == null)
		{
			_bStatic = true;
		}
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage msg)
	{
		IMessage message = InternalSink.ValidateMessage(msg);
		if (message != null)
		{
			return message;
		}
		IMethodCallMessage methodCallMessage = msg as IMethodCallMessage;
		LogicalCallContext logicalCallContext = null;
		LogicalCallContext logicalCallContext2 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
		object data = logicalCallContext2.GetData("__xADCall");
		bool flag = false;
		IMessage message2;
		try
		{
			object server = _server;
			VerifyIsOkToCallMethod(server, methodCallMessage);
			LogicalCallContext logicalCallContext3 = null;
			logicalCallContext3 = ((methodCallMessage == null) ? ((LogicalCallContext)msg.Properties["__CallContext"]) : methodCallMessage.LogicalCallContext);
			logicalCallContext = CallContext.SetLogicalCallContext(logicalCallContext3);
			flag = true;
			logicalCallContext3.PropagateIncomingHeadersToCallContext(msg);
			PreserveThreadPrincipalIfNecessary(logicalCallContext3, logicalCallContext);
			if (IsOKToStackBlt(methodCallMessage, server) && ((Message)methodCallMessage).Dispatch(server))
			{
				message2 = new StackBasedReturnMessage();
				((StackBasedReturnMessage)message2).InitFields((Message)methodCallMessage);
				LogicalCallContext logicalCallContext4 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
				logicalCallContext4.PropagateOutgoingHeadersToMessage(message2);
				((StackBasedReturnMessage)message2).SetLogicalCallContext(logicalCallContext4);
			}
			else
			{
				MethodBase methodBase = GetMethodBase(methodCallMessage);
				object[] outArgs = null;
				object obj = null;
				RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(methodBase);
				object[] args = Message.CoerceArgs(methodCallMessage, reflectionCachedData.Parameters);
				obj = PrivateProcessMessage(methodBase.MethodHandle, args, server, out outArgs);
				CopyNonByrefOutArgsFromOriginalArgs(reflectionCachedData, args, ref outArgs);
				LogicalCallContext logicalCallContext5 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
				if (data != null && (bool)data)
				{
					logicalCallContext5?.RemovePrincipalIfNotSerializable();
				}
				message2 = new ReturnMessage(obj, outArgs, (outArgs != null) ? outArgs.Length : 0, logicalCallContext5, methodCallMessage);
				logicalCallContext5.PropagateOutgoingHeadersToMessage(message2);
				CallContext.SetLogicalCallContext(logicalCallContext);
			}
		}
		catch (Exception e)
		{
			message2 = new ReturnMessage(e, methodCallMessage);
			((ReturnMessage)message2).SetLogicalCallContext(methodCallMessage.LogicalCallContext);
			if (flag)
			{
				CallContext.SetLogicalCallContext(logicalCallContext);
			}
		}
		return message2;
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		IMethodCallMessage methodCallMessage = (IMethodCallMessage)msg;
		IMessageCtrl result = null;
		IMessage message = null;
		LogicalCallContext logicalCallContext = null;
		bool flag = false;
		try
		{
			try
			{
				LogicalCallContext logicalCallContext2 = (LogicalCallContext)methodCallMessage.Properties[Message.CallContextKey];
				object server = _server;
				VerifyIsOkToCallMethod(server, methodCallMessage);
				logicalCallContext = CallContext.SetLogicalCallContext(logicalCallContext2);
				flag = true;
				logicalCallContext2.PropagateIncomingHeadersToCallContext(msg);
				PreserveThreadPrincipalIfNecessary(logicalCallContext2, logicalCallContext);
				if (msg.Properties["__SinkStack"] is ServerChannelSinkStack serverChannelSinkStack)
				{
					serverChannelSinkStack.ServerObject = server;
				}
				MethodBase methodBase = GetMethodBase(methodCallMessage);
				object[] outArgs = null;
				object obj = null;
				RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(methodBase);
				object[] args = Message.CoerceArgs(methodCallMessage, reflectionCachedData.Parameters);
				obj = PrivateProcessMessage(methodBase.MethodHandle, args, server, out outArgs);
				CopyNonByrefOutArgsFromOriginalArgs(reflectionCachedData, args, ref outArgs);
				if (replySink != null)
				{
					LogicalCallContext logicalCallContext3 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
					logicalCallContext3?.RemovePrincipalIfNotSerializable();
					message = new ReturnMessage(obj, outArgs, (outArgs != null) ? outArgs.Length : 0, logicalCallContext3, methodCallMessage);
					logicalCallContext3.PropagateOutgoingHeadersToMessage(message);
				}
			}
			catch (Exception e)
			{
				if (replySink != null)
				{
					message = new ReturnMessage(e, methodCallMessage);
					((ReturnMessage)message).SetLogicalCallContext((LogicalCallContext)methodCallMessage.Properties[Message.CallContextKey]);
				}
			}
			finally
			{
				replySink?.SyncProcessMessage(message);
			}
		}
		finally
		{
			if (flag)
			{
				CallContext.SetLogicalCallContext(logicalCallContext);
			}
		}
		return result;
	}

	[SecurityCritical]
	internal bool IsOKToStackBlt(IMethodMessage mcMsg, object server)
	{
		bool result = false;
		if (mcMsg is Message message)
		{
			IInternalMessage internalMessage = message;
			if (message.GetFramePtr() != IntPtr.Zero && message.GetThisPtr() == server && (internalMessage.IdentityObject == null || (internalMessage.IdentityObject != null && internalMessage.IdentityObject == internalMessage.ServerIdentityObject)))
			{
				result = true;
			}
		}
		return result;
	}

	[SecurityCritical]
	private static MethodBase GetMethodBase(IMethodMessage msg)
	{
		MethodBase methodBase = msg.MethodBase;
		if (null == methodBase)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Message_MethodMissing"), msg.MethodName, msg.TypeName));
		}
		return methodBase;
	}

	[SecurityCritical]
	private static void VerifyIsOkToCallMethod(object server, IMethodMessage msg)
	{
		bool flag = false;
		if (!(server is MarshalByRefObject marshalByRefObject))
		{
			return;
		}
		bool fServer;
		Identity identity = MarshalByRefObject.GetIdentity(marshalByRefObject, out fServer);
		if (identity != null && identity is ServerIdentity { MarshaledAsSpecificType: not false, ServerType: var serverType } && serverType != null)
		{
			MethodBase methodBase = GetMethodBase(msg);
			RuntimeType runtimeType = (RuntimeType)methodBase.DeclaringType;
			if (runtimeType != serverType && !runtimeType.IsAssignableFrom(serverType))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_InvalidCallingType"), methodBase.DeclaringType.FullName, serverType.FullName));
			}
			if (runtimeType.IsInterface)
			{
				VerifyNotIRemoteDispatch(runtimeType);
			}
			flag = true;
		}
		if (flag)
		{
			return;
		}
		MethodBase methodBase2 = GetMethodBase(msg);
		RuntimeType runtimeType2 = (RuntimeType)methodBase2.ReflectedType;
		if (!runtimeType2.IsInterface)
		{
			if (!runtimeType2.IsInstanceOfType(marshalByRefObject))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_InvalidCallingType"), runtimeType2.FullName, marshalByRefObject.GetType().FullName));
			}
		}
		else
		{
			VerifyNotIRemoteDispatch(runtimeType2);
		}
	}

	[SecurityCritical]
	private static void VerifyNotIRemoteDispatch(RuntimeType reflectedType)
	{
		if (reflectedType.FullName.Equals(sIRemoteDispatch) && reflectedType.GetRuntimeAssembly().GetSimpleName().Equals(sIRemoteDispatchAssembly))
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_CantInvokeIRemoteDispatch"));
		}
	}

	internal void CopyNonByrefOutArgsFromOriginalArgs(RemotingMethodCachedData methodCache, object[] args, ref object[] marshalResponseArgs)
	{
		int[] nonRefOutArgMap = methodCache.NonRefOutArgMap;
		if (nonRefOutArgMap.Length != 0)
		{
			if (marshalResponseArgs == null)
			{
				marshalResponseArgs = new object[methodCache.Parameters.Length];
			}
			int[] array = nonRefOutArgMap;
			foreach (int num in array)
			{
				marshalResponseArgs[num] = args[num];
			}
		}
	}

	[SecurityCritical]
	internal static void PreserveThreadPrincipalIfNecessary(LogicalCallContext messageCallContext, LogicalCallContext threadCallContext)
	{
		if (threadCallContext != null && messageCallContext.Principal == null)
		{
			IPrincipal principal = threadCallContext.Principal;
			if (principal != null)
			{
				messageCallContext.Principal = principal;
			}
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern object _PrivateProcessMessage(IntPtr md, object[] args, object server, out object[] outArgs);

	[SecurityCritical]
	public object PrivateProcessMessage(RuntimeMethodHandle md, object[] args, object server, out object[] outArgs)
	{
		return _PrivateProcessMessage(md.Value, args, server, out outArgs);
	}
}
