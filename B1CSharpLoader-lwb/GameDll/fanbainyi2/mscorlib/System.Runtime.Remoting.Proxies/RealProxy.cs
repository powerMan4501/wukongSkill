using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

namespace System.Runtime.Remoting.Proxies;

[SecurityCritical]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public abstract class RealProxy
{
	private object _tp;

	private object _identity;

	private MarshalByRefObject _serverObject;

	private RealProxyFlags _flags;

	internal GCHandle _srvIdentity;

	internal int _optFlags;

	internal int _domainID;

	private static IntPtr _defaultStub;

	private static IntPtr _defaultStubValue;

	private static object _defaultStubData;

	internal bool Initialized
	{
		get
		{
			return (_flags & RealProxyFlags.Initialized) == RealProxyFlags.Initialized;
		}
		set
		{
			if (value)
			{
				_flags |= RealProxyFlags.Initialized;
			}
			else
			{
				_flags &= ~RealProxyFlags.Initialized;
			}
		}
	}

	internal MarshalByRefObject UnwrappedServerObject => _serverObject;

	internal virtual Identity IdentityObject
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return (Identity)_identity;
		}
		set
		{
			_identity = value;
		}
	}

	[SecuritySafeCritical]
	static RealProxy()
	{
		_defaultStub = GetDefaultStub();
		_defaultStubValue = new IntPtr(-1);
		_defaultStubData = _defaultStubValue;
	}

	[SecurityCritical]
	protected RealProxy(Type classToProxy)
		: this(classToProxy, (IntPtr)0, null)
	{
	}

	[SecurityCritical]
	protected RealProxy(Type classToProxy, IntPtr stub, object stubData)
	{
		if (!classToProxy.IsMarshalByRef && !classToProxy.IsInterface)
		{
			throw new ArgumentException(Environment.GetResourceString("Remoting_Proxy_ProxyTypeIsNotMBR"));
		}
		if ((IntPtr)0 == stub)
		{
			stub = _defaultStub;
			stubData = _defaultStubData;
		}
		_tp = null;
		if (stubData == null)
		{
			throw new ArgumentNullException("stubdata");
		}
		_tp = RemotingServices.CreateTransparentProxy(this, classToProxy, stub, stubData);
		if (this is RemotingProxy)
		{
			_flags |= RealProxyFlags.RemotingProxy;
		}
	}

	internal bool IsRemotingProxy()
	{
		return (_flags & RealProxyFlags.RemotingProxy) == RealProxyFlags.RemotingProxy;
	}

	[SecurityCritical]
	[ComVisible(true)]
	public IConstructionReturnMessage InitializeServerObject(IConstructionCallMessage ctorMsg)
	{
		IConstructionReturnMessage result = null;
		if (_serverObject == null)
		{
			Type proxiedType = GetProxiedType();
			if (ctorMsg != null && ctorMsg.ActivationType != proxiedType)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Proxy_BadTypeForActivation"), proxiedType.FullName, ctorMsg.ActivationType));
			}
			_serverObject = RemotingServices.AllocateUninitializedObject(proxiedType);
			SetContextForDefaultStub();
			MarshalByRefObject marshalByRefObject = (MarshalByRefObject)GetTransparentProxy();
			IMethodReturnMessage methodReturnMessage = null;
			Exception ex = null;
			if (ctorMsg != null)
			{
				methodReturnMessage = RemotingServices.ExecuteMessage(marshalByRefObject, ctorMsg);
				ex = methodReturnMessage.Exception;
			}
			else
			{
				try
				{
					RemotingServices.CallDefaultCtor(marshalByRefObject);
				}
				catch (Exception ex2)
				{
					ex = ex2;
				}
			}
			if (ex == null)
			{
				object[] array = methodReturnMessage?.OutArgs;
				int outArgsCount = ((array != null) ? array.Length : 0);
				LogicalCallContext callCtx = methodReturnMessage?.LogicalCallContext;
				result = new ConstructorReturnMessage(marshalByRefObject, array, outArgsCount, callCtx, ctorMsg);
				SetupIdentity();
				if (IsRemotingProxy())
				{
					((RemotingProxy)this).Initialized = true;
				}
			}
			else
			{
				result = new ConstructorReturnMessage(ex, ctorMsg);
			}
		}
		return result;
	}

	[SecurityCritical]
	protected MarshalByRefObject GetUnwrappedServer()
	{
		return UnwrappedServerObject;
	}

	[SecurityCritical]
	protected MarshalByRefObject DetachServer()
	{
		object transparentProxy = GetTransparentProxy();
		if (transparentProxy != null)
		{
			RemotingServices.ResetInterfaceCache(transparentProxy);
		}
		MarshalByRefObject serverObject = _serverObject;
		_serverObject = null;
		serverObject.__ResetServerIdentity();
		return serverObject;
	}

	[SecurityCritical]
	protected void AttachServer(MarshalByRefObject s)
	{
		object transparentProxy = GetTransparentProxy();
		if (transparentProxy != null)
		{
			RemotingServices.ResetInterfaceCache(transparentProxy);
		}
		AttachServerHelper(s);
	}

	[SecurityCritical]
	private void SetupIdentity()
	{
		if (_identity == null)
		{
			_identity = IdentityHolder.FindOrCreateServerIdentity(_serverObject, null, 0);
			((Identity)_identity).RaceSetTransparentProxy(GetTransparentProxy());
		}
	}

	[SecurityCritical]
	private void SetContextForDefaultStub()
	{
		if (GetStub() == _defaultStub && GetStubData(this) is IntPtr intPtr && intPtr.Equals(_defaultStubValue))
		{
			SetStubData(this, Thread.CurrentContext.InternalContextID);
		}
	}

	[SecurityCritical]
	internal bool DoContextsMatch()
	{
		bool result = false;
		if (GetStub() == _defaultStub && GetStubData(this) is IntPtr intPtr && intPtr.Equals(Thread.CurrentContext.InternalContextID))
		{
			result = true;
		}
		return result;
	}

	[SecurityCritical]
	internal void AttachServerHelper(MarshalByRefObject s)
	{
		if (s == null || _serverObject != null)
		{
			throw new ArgumentException(Environment.GetResourceString("ArgumentNull_Generic"), "s");
		}
		_serverObject = s;
		SetupIdentity();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private extern IntPtr GetStub();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern void SetStubData(RealProxy rp, object stubData);

	internal void SetSrvInfo(GCHandle srvIdentity, int domainID)
	{
		_srvIdentity = srvIdentity;
		_domainID = domainID;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern object GetStubData(RealProxy rp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern IntPtr GetDefaultStub();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public extern Type GetProxiedType();

	public abstract IMessage Invoke(IMessage msg);

	[SecurityCritical]
	public virtual ObjRef CreateObjRef(Type requestedType)
	{
		if (_identity == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_NoIdentityEntry"));
		}
		return new ObjRef((MarshalByRefObject)GetTransparentProxy(), requestedType);
	}

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		object transparentProxy = GetTransparentProxy();
		RemotingServices.GetObjectData(transparentProxy, info, context);
	}

	[SecurityCritical]
	private static void HandleReturnMessage(IMessage reqMsg, IMessage retMsg)
	{
		IMethodReturnMessage methodReturnMessage = retMsg as IMethodReturnMessage;
		if (retMsg == null || methodReturnMessage == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadType"));
		}
		Exception exception = methodReturnMessage.Exception;
		if (exception != null)
		{
			throw exception.PrepForRemoting();
		}
		if (!(retMsg is StackBasedReturnMessage))
		{
			if (reqMsg is Message)
			{
				PropagateOutParameters(reqMsg, methodReturnMessage.Args, methodReturnMessage.ReturnValue);
			}
			else if (reqMsg is ConstructorCallMessage)
			{
				PropagateOutParameters(reqMsg, methodReturnMessage.Args, null);
			}
		}
	}

	[SecurityCritical]
	internal static void PropagateOutParameters(IMessage msg, object[] outArgs, object returnValue)
	{
		Message message = msg as Message;
		if (message == null && msg is ConstructorCallMessage constructorCallMessage)
		{
			message = constructorCallMessage.GetMessage();
		}
		if (message == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Remoting_Proxy_ExpectedOriginalMessage"));
		}
		MethodBase methodBase = message.GetMethodBase();
		RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(methodBase);
		if (outArgs != null && outArgs.Length != 0)
		{
			object[] args = message.Args;
			ParameterInfo[] parameters = reflectionCachedData.Parameters;
			int[] marshalRequestArgMap = reflectionCachedData.MarshalRequestArgMap;
			foreach (int num in marshalRequestArgMap)
			{
				ParameterInfo parameterInfo = parameters[num];
				if (parameterInfo.IsIn && parameterInfo.ParameterType.IsByRef && !parameterInfo.IsOut)
				{
					outArgs[num] = args[num];
				}
			}
			if (reflectionCachedData.NonRefOutArgMap.Length != 0)
			{
				int[] nonRefOutArgMap = reflectionCachedData.NonRefOutArgMap;
				foreach (int num2 in nonRefOutArgMap)
				{
					if (args[num2] is Array array)
					{
						Array.Copy((Array)outArgs[num2], array, array.Length);
					}
				}
			}
			int[] outRefArgMap = reflectionCachedData.OutRefArgMap;
			if (outRefArgMap.Length != 0)
			{
				int[] array2 = outRefArgMap;
				foreach (int num3 in array2)
				{
					ValidateReturnArg(outArgs[num3], parameters[num3].ParameterType);
				}
			}
		}
		int callType = message.GetCallType();
		if ((callType & 0xF) != 1)
		{
			Type returnType = reflectionCachedData.ReturnType;
			if (returnType != null)
			{
				ValidateReturnArg(returnValue, returnType);
			}
		}
		message.PropagateOutParameters(outArgs, returnValue);
	}

	private static void ValidateReturnArg(object arg, Type paramType)
	{
		if (paramType.IsByRef)
		{
			paramType = paramType.GetElementType();
		}
		if (paramType.IsValueType)
		{
			if (arg == null)
			{
				if (!paramType.IsGenericType || !(paramType.GetGenericTypeDefinition() == typeof(Nullable<>)))
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_Proxy_ReturnValueTypeCannotBeNull"));
				}
			}
			else if (!paramType.IsInstanceOfType(arg))
			{
				throw new InvalidCastException(Environment.GetResourceString("Remoting_Proxy_BadReturnType"));
			}
		}
		else if (arg != null && !paramType.IsInstanceOfType(arg))
		{
			throw new InvalidCastException(Environment.GetResourceString("Remoting_Proxy_BadReturnType"));
		}
	}

	[SecurityCritical]
	internal static IMessage EndInvokeHelper(Message reqMsg, bool bProxyCase)
	{
		AsyncResult asyncResult = reqMsg.GetAsyncResult() as AsyncResult;
		IMessage result = null;
		if (asyncResult == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Message_BadAsyncResult"));
		}
		if (asyncResult.AsyncDelegate != reqMsg.GetThisPtr())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_MismatchedAsyncResult"));
		}
		if (!asyncResult.IsCompleted)
		{
			asyncResult.AsyncWaitHandle.WaitOne(-1, Thread.CurrentContext.IsThreadPoolAware);
		}
		lock (asyncResult)
		{
			if (asyncResult.EndInvokeCalled)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EndInvokeCalledMultiple"));
			}
			asyncResult.EndInvokeCalled = true;
			IMethodReturnMessage methodReturnMessage = (IMethodReturnMessage)asyncResult.GetReplyMessage();
			if (!bProxyCase)
			{
				Exception exception = methodReturnMessage.Exception;
				if (exception != null)
				{
					throw exception.PrepForRemoting();
				}
				reqMsg.PropagateOutParameters(methodReturnMessage.Args, methodReturnMessage.ReturnValue);
			}
			else
			{
				result = methodReturnMessage;
			}
			Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext.Merge(methodReturnMessage.LogicalCallContext);
			return result;
		}
	}

	[SecurityCritical]
	public virtual IntPtr GetCOMIUnknown(bool fIsMarshalled)
	{
		return MarshalByRefObject.GetComIUnknown((MarshalByRefObject)GetTransparentProxy());
	}

	public virtual void SetCOMIUnknown(IntPtr i)
	{
	}

	public virtual IntPtr SupportsInterface(ref Guid iid)
	{
		return IntPtr.Zero;
	}

	public virtual object GetTransparentProxy()
	{
		return _tp;
	}

	[SecurityCritical]
	private void PrivateInvoke(ref MessageData msgData, int type)
	{
		IMessage message = null;
		IMessage message2 = null;
		int num = -1;
		RemotingProxy remotingProxy = null;
		if (1 == type)
		{
			Message message3 = new Message();
			message3.InitFields(msgData);
			message = message3;
			num = message3.GetCallType();
		}
		else if (2 == type)
		{
			num = 0;
			remotingProxy = this as RemotingProxy;
			ConstructorCallMessage constructorCallMessage = null;
			bool flag = false;
			if (!IsRemotingProxy())
			{
				constructorCallMessage = new ConstructorCallMessage(null, null, null, (RuntimeType)GetProxiedType());
			}
			else
			{
				constructorCallMessage = remotingProxy.ConstructorMessage;
				Identity identityObject = remotingProxy.IdentityObject;
				if (identityObject != null)
				{
					flag = identityObject.IsWellKnown();
				}
			}
			if (constructorCallMessage == null || flag)
			{
				constructorCallMessage = new ConstructorCallMessage(null, null, null, (RuntimeType)GetProxiedType());
				constructorCallMessage.SetFrame(msgData);
				message = constructorCallMessage;
				if (flag)
				{
					remotingProxy.ConstructorMessage = null;
					if (constructorCallMessage.ArgCount != 0)
					{
						throw new RemotingException(Environment.GetResourceString("Remoting_Activation_WellKnownCTOR"));
					}
				}
				message2 = new ConstructorReturnMessage((MarshalByRefObject)GetTransparentProxy(), null, 0, null, constructorCallMessage);
			}
			else
			{
				constructorCallMessage.SetFrame(msgData);
				message = constructorCallMessage;
			}
		}
		ChannelServices.IncrementRemoteCalls();
		if (!IsRemotingProxy() && (num & 2) == 2)
		{
			Message reqMsg = message as Message;
			message2 = EndInvokeHelper(reqMsg, bProxyCase: true);
		}
		if (message2 == null)
		{
			LogicalCallContext logicalCallContext = null;
			Thread currentThread = Thread.CurrentThread;
			logicalCallContext = currentThread.GetMutableExecutionContext().LogicalCallContext;
			SetCallContextInMessage(message, num, logicalCallContext);
			logicalCallContext.PropagateOutgoingHeadersToMessage(message);
			message2 = Invoke(message);
			ReturnCallContextToThread(currentThread, message2, num, logicalCallContext);
			Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext.PropagateIncomingHeadersToCallContext(message2);
		}
		if (!IsRemotingProxy() && (num & 1) == 1)
		{
			Message message4 = message as Message;
			AsyncResult asyncResult = new AsyncResult(message4);
			asyncResult.SyncProcessMessage(message2);
			message2 = new ReturnMessage(asyncResult, null, 0, null, message4);
		}
		HandleReturnMessage(message, message2);
		if (2 != type)
		{
			return;
		}
		MarshalByRefObject marshalByRefObject = null;
		if (!(message2 is IConstructionReturnMessage constructionReturnMessage))
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Proxy_BadReturnTypeForActivation"));
		}
		if (constructionReturnMessage is ConstructorReturnMessage constructorReturnMessage)
		{
			marshalByRefObject = (MarshalByRefObject)constructorReturnMessage.GetObject();
			if (marshalByRefObject == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_Activation_NullReturnValue"));
			}
		}
		else
		{
			marshalByRefObject = (MarshalByRefObject)RemotingServices.InternalUnmarshal((ObjRef)constructionReturnMessage.ReturnValue, GetTransparentProxy(), fRefine: true);
			if (marshalByRefObject == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_Activation_NullFromInternalUnmarshal"));
			}
		}
		if (marshalByRefObject != (MarshalByRefObject)GetTransparentProxy())
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Activation_InconsistentState"));
		}
		if (IsRemotingProxy())
		{
			remotingProxy.ConstructorMessage = null;
		}
	}

	private void SetCallContextInMessage(IMessage reqMsg, int msgFlags, LogicalCallContext cctx)
	{
		Message message = reqMsg as Message;
		if (msgFlags == 0)
		{
			if (message != null)
			{
				message.SetLogicalCallContext(cctx);
			}
			else
			{
				((ConstructorCallMessage)reqMsg).SetLogicalCallContext(cctx);
			}
		}
	}

	[SecurityCritical]
	private void ReturnCallContextToThread(Thread currentThread, IMessage retMsg, int msgFlags, LogicalCallContext currCtx)
	{
		if (msgFlags != 0 || retMsg == null || !(retMsg is IMethodReturnMessage { LogicalCallContext: var logicalCallContext } methodReturnMessage))
		{
			return;
		}
		if (logicalCallContext == null)
		{
			currentThread.GetMutableExecutionContext().LogicalCallContext = currCtx;
		}
		else
		{
			if (methodReturnMessage is StackBasedReturnMessage)
			{
				return;
			}
			ExecutionContext mutableExecutionContext = currentThread.GetMutableExecutionContext();
			LogicalCallContext logicalCallContext2 = mutableExecutionContext.LogicalCallContext;
			mutableExecutionContext.LogicalCallContext = logicalCallContext;
			if (logicalCallContext2 != logicalCallContext)
			{
				IPrincipal principal = logicalCallContext2.Principal;
				if (principal != null)
				{
					logicalCallContext.Principal = principal;
				}
			}
		}
	}

	[SecurityCritical]
	internal virtual void Wrap()
	{
		if (_identity is ServerIdentity serverIdentity && this is RemotingProxy)
		{
			SetStubData(this, serverIdentity.ServerContext.InternalContextID);
		}
	}

	protected RealProxy()
	{
	}
}
