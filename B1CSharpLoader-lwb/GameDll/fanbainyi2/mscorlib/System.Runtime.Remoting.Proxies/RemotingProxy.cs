using System.Reflection;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Proxies;

[SecurityCritical]
internal class RemotingProxy : RealProxy, IRemotingTypeInfo
{
	private static MethodInfo _getTypeMethod = typeof(object).GetMethod("GetType");

	private static MethodInfo _getHashCodeMethod = typeof(object).GetMethod("GetHashCode");

	private static RuntimeType s_typeofObject = (RuntimeType)typeof(object);

	private static RuntimeType s_typeofMarshalByRefObject = (RuntimeType)typeof(MarshalByRefObject);

	private ConstructorCallMessage _ccm;

	private int _ctorThread;

	internal int CtorThread
	{
		get
		{
			return _ctorThread;
		}
		set
		{
			_ctorThread = value;
		}
	}

	internal ConstructorCallMessage ConstructorMessage
	{
		get
		{
			return _ccm;
		}
		set
		{
			_ccm = value;
		}
	}

	public string TypeName
	{
		[SecurityCritical]
		get
		{
			return GetProxiedType().FullName;
		}
		[SecurityCritical]
		set
		{
			throw new NotSupportedException();
		}
	}

	public RemotingProxy(Type serverType)
		: base(serverType)
	{
	}

	private RemotingProxy()
	{
	}

	internal static IMessage CallProcessMessage(IMessageSink ms, IMessage reqMsg, ArrayWithSize proxySinks, Thread currentThread, Context currentContext, bool bSkippingContextChain)
	{
		if (proxySinks != null)
		{
			DynamicPropertyHolder.NotifyDynamicSinks(reqMsg, proxySinks, bCliSide: true, bStart: true, bAsync: false);
		}
		bool flag = false;
		if (bSkippingContextChain)
		{
			flag = currentContext.NotifyDynamicSinks(reqMsg, bCliSide: true, bStart: true, bAsync: false, bNotifyGlobals: true);
			ChannelServices.NotifyProfiler(reqMsg, RemotingProfilerEvent.ClientSend);
		}
		if (ms == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Proxy_NoChannelSink"));
		}
		IMessage message = ms.SyncProcessMessage(reqMsg);
		if (bSkippingContextChain)
		{
			ChannelServices.NotifyProfiler(message, RemotingProfilerEvent.ClientReceive);
			if (flag)
			{
				currentContext.NotifyDynamicSinks(message, bCliSide: true, bStart: false, bAsync: false, bNotifyGlobals: true);
			}
		}
		IMethodReturnMessage methodReturnMessage = message as IMethodReturnMessage;
		if (message == null || methodReturnMessage == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadType"));
		}
		if (proxySinks != null)
		{
			DynamicPropertyHolder.NotifyDynamicSinks(message, proxySinks, bCliSide: true, bStart: false, bAsync: false);
		}
		return message;
	}

	[SecurityCritical]
	public override IMessage Invoke(IMessage reqMsg)
	{
		if (reqMsg is IConstructionCallMessage ctorMsg)
		{
			return InternalActivate(ctorMsg);
		}
		if (!base.Initialized)
		{
			if (CtorThread != Thread.CurrentThread.GetHashCode())
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_Proxy_InvalidCall"));
			}
			ServerIdentity serverIdentity = IdentityObject as ServerIdentity;
			RemotingServices.Wrap((ContextBoundObject)base.UnwrappedServerObject);
		}
		int callType = 0;
		if (reqMsg is Message message)
		{
			callType = message.GetCallType();
		}
		return InternalInvoke((IMethodCallMessage)reqMsg, useDispatchMessage: false, callType);
	}

	internal virtual IMessage InternalInvoke(IMethodCallMessage reqMcmMsg, bool useDispatchMessage, int callType)
	{
		Message message = reqMcmMsg as Message;
		if (message == null && callType != 0)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Proxy_InvalidCallType"));
		}
		IMessage result = null;
		Thread currentThread = Thread.CurrentThread;
		LogicalCallContext logicalCallContext = currentThread.GetMutableExecutionContext().LogicalCallContext;
		Identity identityObject = IdentityObject;
		ServerIdentity serverIdentity = identityObject as ServerIdentity;
		if (serverIdentity != null && identityObject.IsFullyDisconnected())
		{
			throw new ArgumentException(Environment.GetResourceString("Remoting_ServerObjectNotFound", reqMcmMsg.Uri));
		}
		MethodBase methodBase = reqMcmMsg.MethodBase;
		if (_getTypeMethod == methodBase)
		{
			Type proxiedType = GetProxiedType();
			return new ReturnMessage(proxiedType, null, 0, logicalCallContext, reqMcmMsg);
		}
		if (_getHashCodeMethod == methodBase)
		{
			int hashCode = identityObject.GetHashCode();
			return new ReturnMessage(hashCode, null, 0, logicalCallContext, reqMcmMsg);
		}
		if (identityObject.ChannelSink == null)
		{
			IMessageSink chnlSink = null;
			IMessageSink envoySink = null;
			if (!identityObject.ObjectRef.IsObjRefLite())
			{
				RemotingServices.CreateEnvoyAndChannelSinks(null, identityObject.ObjectRef, out chnlSink, out envoySink);
			}
			else
			{
				RemotingServices.CreateEnvoyAndChannelSinks(identityObject.ObjURI, null, out chnlSink, out envoySink);
			}
			RemotingServices.SetEnvoyAndChannelSinks(identityObject, chnlSink, envoySink);
			if (identityObject.ChannelSink == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_Proxy_NoChannelSink"));
			}
		}
		IInternalMessage internalMessage = (IInternalMessage)reqMcmMsg;
		internalMessage.IdentityObject = identityObject;
		if (serverIdentity != null)
		{
			internalMessage.ServerIdentityObject = serverIdentity;
		}
		else
		{
			internalMessage.SetURI(identityObject.URI);
		}
		AsyncResult asyncResult = null;
		switch (callType)
		{
		case 0:
		{
			bool bSkippingContextChain = false;
			Context currentContextInternal = currentThread.GetCurrentContextInternal();
			IMessageSink messageSink = identityObject.EnvoyChain;
			if (currentContextInternal.IsDefaultContext && messageSink is EnvoyTerminatorSink)
			{
				bSkippingContextChain = true;
				messageSink = identityObject.ChannelSink;
			}
			result = CallProcessMessage(messageSink, reqMcmMsg, identityObject.ProxySideDynamicSinks, currentThread, currentContextInternal, bSkippingContextChain);
			break;
		}
		case 1:
		case 9:
			logicalCallContext = (LogicalCallContext)logicalCallContext.Clone();
			internalMessage.SetCallContext(logicalCallContext);
			asyncResult = new AsyncResult(message);
			InternalInvokeAsync(asyncResult, message, useDispatchMessage, callType);
			result = new ReturnMessage(asyncResult, null, 0, null, message);
			break;
		case 8:
			logicalCallContext = (LogicalCallContext)logicalCallContext.Clone();
			internalMessage.SetCallContext(logicalCallContext);
			InternalInvokeAsync(null, message, useDispatchMessage, callType);
			result = new ReturnMessage(null, null, 0, null, reqMcmMsg);
			break;
		case 10:
			result = new ReturnMessage(null, null, 0, null, reqMcmMsg);
			break;
		case 2:
			result = RealProxy.EndInvokeHelper(message, bProxyCase: true);
			break;
		}
		return result;
	}

	internal void InternalInvokeAsync(IMessageSink ar, Message reqMsg, bool useDispatchMessage, int callType)
	{
		IMessageCtrl messageCtrl = null;
		Identity identityObject = IdentityObject;
		ServerIdentity serverIdentity = identityObject as ServerIdentity;
		MethodCall methodCall = new MethodCall(reqMsg);
		IInternalMessage internalMessage = methodCall;
		internalMessage.IdentityObject = identityObject;
		if (serverIdentity != null)
		{
			internalMessage.ServerIdentityObject = serverIdentity;
		}
		if (useDispatchMessage)
		{
			messageCtrl = ChannelServices.AsyncDispatchMessage(methodCall, ((callType & 8) != 0) ? null : ar);
		}
		else
		{
			if (identityObject.EnvoyChain == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Remoting_Proxy_InvalidState"));
			}
			messageCtrl = identityObject.EnvoyChain.AsyncProcessMessage(methodCall, ((callType & 8) != 0) ? null : ar);
		}
		if ((callType & 1) != 0 && (callType & 8) != 0)
		{
			ar.SyncProcessMessage(null);
		}
	}

	private IConstructionReturnMessage InternalActivate(IConstructionCallMessage ctorMsg)
	{
		CtorThread = Thread.CurrentThread.GetHashCode();
		IConstructionReturnMessage result = ActivationServices.Activate(this, ctorMsg);
		base.Initialized = true;
		return result;
	}

	private static void Invoke(object NotUsed, ref MessageData msgData)
	{
		Message message = new Message();
		message.InitFields(msgData);
		object thisPtr = message.GetThisPtr();
		if (thisPtr is Delegate obj)
		{
			RemotingProxy remotingProxy = (RemotingProxy)RemotingServices.GetRealProxy(obj.Target);
			if (remotingProxy != null)
			{
				remotingProxy.InternalInvoke(message, useDispatchMessage: true, message.GetCallType());
				return;
			}
			int callType = message.GetCallType();
			if (callType <= 2)
			{
				switch (callType)
				{
				default:
					return;
				case 1:
					break;
				case 2:
					RealProxy.EndInvokeHelper(message, bProxyCase: false);
					return;
				}
			}
			else if (callType != 9)
			{
				_ = 10;
				return;
			}
			message.Properties[Message.CallContextKey] = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext.Clone();
			AsyncResult asyncResult = new AsyncResult(message);
			AgileAsyncWorkerItem state = new AgileAsyncWorkerItem(message, ((callType & 8) != 0) ? null : asyncResult, obj.Target);
			ThreadPool.QueueUserWorkItem(AgileAsyncWorkerItem.ThreadPoolCallBack, state);
			if ((callType & 8) != 0)
			{
				asyncResult.SyncProcessMessage(null);
			}
			message.PropagateOutParameters(null, asyncResult);
			return;
		}
		throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
	}

	[SecurityCritical]
	public override IntPtr GetCOMIUnknown(bool fIsBeingMarshalled)
	{
		IntPtr zero = IntPtr.Zero;
		object transparentProxy = GetTransparentProxy();
		if (RemotingServices.IsObjectOutOfProcess(transparentProxy))
		{
			if (fIsBeingMarshalled)
			{
				return MarshalByRefObject.GetComIUnknown((MarshalByRefObject)transparentProxy);
			}
			return MarshalByRefObject.GetComIUnknown((MarshalByRefObject)transparentProxy);
		}
		if (RemotingServices.IsObjectOutOfAppDomain(transparentProxy))
		{
			return ((MarshalByRefObject)transparentProxy).GetComIUnknown(fIsBeingMarshalled);
		}
		return MarshalByRefObject.GetComIUnknown((MarshalByRefObject)transparentProxy);
	}

	[SecurityCritical]
	public override void SetCOMIUnknown(IntPtr i)
	{
	}

	[SecurityCritical]
	public bool CanCastTo(Type castType, object o)
	{
		if (castType == null)
		{
			throw new ArgumentNullException("castType");
		}
		RuntimeType runtimeType = castType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"));
		}
		bool flag = false;
		if (runtimeType == s_typeofObject || runtimeType == s_typeofMarshalByRefObject)
		{
			return true;
		}
		ObjRef objectRef = IdentityObject.ObjectRef;
		if (objectRef != null)
		{
			object transparentProxy = GetTransparentProxy();
			IRemotingTypeInfo typeInfo = objectRef.TypeInfo;
			if (typeInfo != null)
			{
				flag = typeInfo.CanCastTo(runtimeType, transparentProxy);
				if (!flag && typeInfo.GetType() == typeof(TypeInfo) && objectRef.IsWellKnown())
				{
					flag = CanCastToWK(runtimeType);
				}
			}
			else if (objectRef.IsObjRefLite())
			{
				flag = MarshalByRefObject.CanCastToXmlTypeHelper(runtimeType, (MarshalByRefObject)o);
			}
		}
		else
		{
			flag = CanCastToWK(runtimeType);
		}
		return flag;
	}

	private bool CanCastToWK(Type castType)
	{
		bool result = false;
		if (castType.IsClass)
		{
			result = GetProxiedType().IsAssignableFrom(castType);
		}
		else if (!(IdentityObject is ServerIdentity))
		{
			result = true;
		}
		return result;
	}
}
