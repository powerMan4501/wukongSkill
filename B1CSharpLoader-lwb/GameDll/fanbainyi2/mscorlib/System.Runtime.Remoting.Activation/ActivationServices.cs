using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Runtime.Remoting.Activation;

internal static class ActivationServices
{
	private static volatile IActivator activator;

	private static Hashtable _proxyTable;

	private static readonly Type proxyAttributeType;

	[SecurityCritical]
	private static ProxyAttribute _proxyAttribute;

	[ThreadStatic]
	internal static ActivationAttributeStack _attributeStack;

	internal static readonly Assembly s_MscorlibAssembly;

	internal const string ActivationServiceURI = "RemoteActivationService.rem";

	internal const string RemoteActivateKey = "Remote";

	internal const string PermissionKey = "Permission";

	internal const string ConnectKey = "Connect";

	internal static ProxyAttribute DefaultProxyAttribute
	{
		[SecurityCritical]
		get
		{
			return _proxyAttribute;
		}
	}

	[SecuritySafeCritical]
	static ActivationServices()
	{
		activator = null;
		_proxyTable = new Hashtable();
		proxyAttributeType = typeof(ProxyAttribute);
		_proxyAttribute = new ProxyAttribute();
		s_MscorlibAssembly = typeof(object).Assembly;
	}

	[SecurityCritical]
	private static void Startup()
	{
		DomainSpecificRemotingData remotingData = Thread.GetDomain().RemotingData;
		if (remotingData.ActivationInitialized && !remotingData.InitializingActivation)
		{
			return;
		}
		object configLock = remotingData.ConfigLock;
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Monitor.Enter(configLock, ref lockTaken);
			remotingData.InitializingActivation = true;
			if (!remotingData.ActivationInitialized)
			{
				remotingData.LocalActivator = new LocalActivator();
				remotingData.ActivationListener = new ActivationListener();
				remotingData.ActivationInitialized = true;
			}
			remotingData.InitializingActivation = false;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(configLock);
			}
		}
	}

	[SecurityCritical]
	private static void InitActivationServices()
	{
		if (activator == null)
		{
			activator = GetActivator();
			if (activator == null)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_BadInternalState_ActivationFailure")));
			}
		}
	}

	[SecurityCritical]
	private static MarshalByRefObject IsCurrentContextOK(RuntimeType serverType, object[] props, bool bNewObj)
	{
		MarshalByRefObject marshalByRefObject = null;
		InitActivationServices();
		ProxyAttribute proxyAttribute = GetProxyAttribute(serverType);
		if (proxyAttribute == DefaultProxyAttribute)
		{
			marshalByRefObject = proxyAttribute.CreateInstanceInternal(serverType);
		}
		else
		{
			marshalByRefObject = proxyAttribute.CreateInstance(serverType);
			if (marshalByRefObject != null && !RemotingServices.IsTransparentProxy(marshalByRefObject) && !serverType.IsAssignableFrom(marshalByRefObject.GetType()))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Activation_BadObject"), serverType));
			}
		}
		return marshalByRefObject;
	}

	[SecurityCritical]
	private static MarshalByRefObject CreateObjectForCom(RuntimeType serverType, object[] props, bool bNewObj)
	{
		MarshalByRefObject marshalByRefObject = null;
		if (PeekActivationAttributes(serverType) != null)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_ActivForCom"));
		}
		InitActivationServices();
		ProxyAttribute proxyAttribute = GetProxyAttribute(serverType);
		if (proxyAttribute is ICustomFactory)
		{
			return ((ICustomFactory)proxyAttribute).CreateInstance(serverType);
		}
		return (MarshalByRefObject)Activator.CreateInstance(serverType, nonPublic: true);
	}

	[SecurityCritical]
	private static bool IsCurrentContextOK(RuntimeType serverType, object[] props, ref ConstructorCallMessage ctorCallMsg)
	{
		object[] array = PeekActivationAttributes(serverType);
		if (array != null)
		{
			PopActivationAttributes(serverType);
		}
		object[] array2 = new object[1] { GetGlobalAttribute() };
		object[] contextAttributesForType = GetContextAttributesForType(serverType);
		object[] array3 = contextAttributesForType;
		Context currentContext = Thread.CurrentContext;
		ctorCallMsg = new ConstructorCallMessage(array, array2, array3, serverType);
		ctorCallMsg.Activator = new ConstructionLevelActivator();
		bool flag = QueryAttributesIfContextOK(currentContext, ctorCallMsg, array2);
		if (flag)
		{
			flag = QueryAttributesIfContextOK(currentContext, ctorCallMsg, array);
			if (flag)
			{
				flag = QueryAttributesIfContextOK(currentContext, ctorCallMsg, array3);
			}
		}
		return flag;
	}

	[SecurityCritical]
	private static void CheckForInfrastructurePermission(RuntimeAssembly asm)
	{
		if (asm != s_MscorlibAssembly)
		{
			SecurityPermission demand = new SecurityPermission(SecurityPermissionFlag.Infrastructure);
			CodeAccessSecurityEngine.CheckAssembly(asm, demand);
		}
	}

	[SecurityCritical]
	private static bool QueryAttributesIfContextOK(Context ctx, IConstructionCallMessage ctorMsg, object[] attributes)
	{
		bool flag = true;
		if (attributes != null)
		{
			for (int i = 0; i < attributes.Length; i++)
			{
				if (attributes[i] is IContextAttribute contextAttribute)
				{
					RuntimeAssembly asm = (RuntimeAssembly)contextAttribute.GetType().Assembly;
					CheckForInfrastructurePermission(asm);
					flag = contextAttribute.IsContextOK(ctx, ctorMsg);
					if (!flag)
					{
						break;
					}
					continue;
				}
				throw new RemotingException(Environment.GetResourceString("Remoting_Activation_BadAttribute"));
			}
		}
		return flag;
	}

	[SecurityCritical]
	internal static void GetPropertiesFromAttributes(IConstructionCallMessage ctorMsg, object[] attributes)
	{
		if (attributes == null)
		{
			return;
		}
		for (int i = 0; i < attributes.Length; i++)
		{
			if (attributes[i] is IContextAttribute contextAttribute)
			{
				RuntimeAssembly asm = (RuntimeAssembly)contextAttribute.GetType().Assembly;
				CheckForInfrastructurePermission(asm);
				contextAttribute.GetPropertiesForNewContext(ctorMsg);
				continue;
			}
			throw new RemotingException(Environment.GetResourceString("Remoting_Activation_BadAttribute"));
		}
	}

	[SecurityCritical]
	internal static ProxyAttribute GetProxyAttribute(Type serverType)
	{
		if (!serverType.HasProxyAttribute)
		{
			return DefaultProxyAttribute;
		}
		ProxyAttribute proxyAttribute = _proxyTable[serverType] as ProxyAttribute;
		if (proxyAttribute == null)
		{
			object[] customAttributes = Attribute.GetCustomAttributes(serverType, proxyAttributeType, inherit: true);
			object[] array = customAttributes;
			if (array != null && array.Length != 0)
			{
				if (!serverType.IsContextful)
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_Activation_MBR_ProxyAttribute"));
				}
				proxyAttribute = array[0] as ProxyAttribute;
			}
			if (!_proxyTable.Contains(serverType))
			{
				lock (_proxyTable)
				{
					if (!_proxyTable.Contains(serverType))
					{
						_proxyTable.Add(serverType, proxyAttribute);
					}
				}
			}
		}
		return proxyAttribute;
	}

	[SecurityCritical]
	internal static MarshalByRefObject CreateInstance(RuntimeType serverType)
	{
		MarshalByRefObject marshalByRefObject = null;
		ConstructorCallMessage ctorCallMsg = null;
		bool flag = IsCurrentContextOK(serverType, null, ref ctorCallMsg);
		if (flag && !serverType.IsContextful)
		{
			marshalByRefObject = RemotingServices.AllocateUninitializedObject(serverType);
		}
		else
		{
			marshalByRefObject = (MarshalByRefObject)ConnectIfNecessary(ctorCallMsg);
			RemotingProxy remotingProxy;
			if (marshalByRefObject == null)
			{
				remotingProxy = new RemotingProxy(serverType);
				marshalByRefObject = (MarshalByRefObject)remotingProxy.GetTransparentProxy();
			}
			else
			{
				remotingProxy = (RemotingProxy)RemotingServices.GetRealProxy(marshalByRefObject);
			}
			remotingProxy.ConstructorMessage = ctorCallMsg;
			if (!flag)
			{
				ContextLevelActivator contextLevelActivator = new ContextLevelActivator();
				contextLevelActivator.NextActivator = ctorCallMsg.Activator;
				ctorCallMsg.Activator = contextLevelActivator;
			}
			else
			{
				ctorCallMsg.ActivateInContext = true;
			}
		}
		return marshalByRefObject;
	}

	[SecurityCritical]
	internal static IConstructionReturnMessage Activate(RemotingProxy remProxy, IConstructionCallMessage ctorMsg)
	{
		IConstructionReturnMessage constructionReturnMessage = null;
		if (((ConstructorCallMessage)ctorMsg).ActivateInContext)
		{
			constructionReturnMessage = ctorMsg.Activator.Activate(ctorMsg);
			if (constructionReturnMessage.Exception != null)
			{
				throw constructionReturnMessage.Exception;
			}
		}
		else
		{
			GetPropertiesFromAttributes(ctorMsg, ctorMsg.CallSiteActivationAttributes);
			GetPropertiesFromAttributes(ctorMsg, ((ConstructorCallMessage)ctorMsg).GetWOMAttributes());
			GetPropertiesFromAttributes(ctorMsg, ((ConstructorCallMessage)ctorMsg).GetTypeAttributes());
			IMessageSink clientContextChain = Thread.CurrentContext.GetClientContextChain();
			IMethodReturnMessage methodReturnMessage = (IMethodReturnMessage)clientContextChain.SyncProcessMessage(ctorMsg);
			constructionReturnMessage = methodReturnMessage as IConstructionReturnMessage;
			if (methodReturnMessage == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_Activation_Failed"));
			}
			if (methodReturnMessage.Exception != null)
			{
				throw methodReturnMessage.Exception;
			}
		}
		return constructionReturnMessage;
	}

	[SecurityCritical]
	internal static IConstructionReturnMessage DoCrossContextActivation(IConstructionCallMessage reqMsg)
	{
		bool isContextful = reqMsg.ActivationType.IsContextful;
		Context context = null;
		if (isContextful)
		{
			context = new Context();
			ArrayList arrayList = (ArrayList)reqMsg.ContextProperties;
			RuntimeAssembly runtimeAssembly = null;
			for (int i = 0; i < arrayList.Count; i++)
			{
				if (!(arrayList[i] is IContextProperty contextProperty))
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_Activation_BadAttribute"));
				}
				runtimeAssembly = (RuntimeAssembly)contextProperty.GetType().Assembly;
				CheckForInfrastructurePermission(runtimeAssembly);
				if (context.GetProperty(contextProperty.Name) == null)
				{
					context.SetProperty(contextProperty);
				}
			}
			context.Freeze();
			for (int j = 0; j < arrayList.Count; j++)
			{
				if (!((IContextProperty)arrayList[j]).IsNewContextOK(context))
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_Activation_PropertyUnhappy"));
				}
			}
		}
		InternalCrossContextDelegate internalCrossContextDelegate = DoCrossContextActivationCallback;
		object[] args = new object[1] { reqMsg };
		if (isContextful)
		{
			return Thread.CurrentThread.InternalCrossContextCallback(context, internalCrossContextDelegate, args) as IConstructionReturnMessage;
		}
		return internalCrossContextDelegate(args) as IConstructionReturnMessage;
	}

	[SecurityCritical]
	internal static object DoCrossContextActivationCallback(object[] args)
	{
		IConstructionCallMessage constructionCallMessage = (IConstructionCallMessage)args[0];
		IConstructionReturnMessage constructionReturnMessage = null;
		IMethodReturnMessage methodReturnMessage = (IMethodReturnMessage)Thread.CurrentContext.GetServerContextChain().SyncProcessMessage(constructionCallMessage);
		Exception ex = null;
		constructionReturnMessage = methodReturnMessage as IConstructionReturnMessage;
		if (constructionReturnMessage == null)
		{
			ex = ((methodReturnMessage == null) ? new RemotingException(Environment.GetResourceString("Remoting_Activation_Failed")) : methodReturnMessage.Exception);
			constructionReturnMessage = new ConstructorReturnMessage(ex, null);
			((ConstructorReturnMessage)constructionReturnMessage).SetLogicalCallContext((LogicalCallContext)constructionCallMessage.Properties[Message.CallContextKey]);
		}
		return constructionReturnMessage;
	}

	[SecurityCritical]
	internal static IConstructionReturnMessage DoServerContextActivation(IConstructionCallMessage reqMsg)
	{
		Exception e = null;
		Type activationType = reqMsg.ActivationType;
		object serverObj = ActivateWithMessage(activationType, reqMsg, null, out e);
		return SetupConstructionReply(serverObj, reqMsg, e);
	}

	[SecurityCritical]
	internal static IConstructionReturnMessage SetupConstructionReply(object serverObj, IConstructionCallMessage ctorMsg, Exception e)
	{
		IConstructionReturnMessage constructionReturnMessage = null;
		if (e == null)
		{
			constructionReturnMessage = new ConstructorReturnMessage((MarshalByRefObject)serverObj, null, 0, (LogicalCallContext)ctorMsg.Properties[Message.CallContextKey], ctorMsg);
		}
		else
		{
			constructionReturnMessage = new ConstructorReturnMessage(e, null);
			((ConstructorReturnMessage)constructionReturnMessage).SetLogicalCallContext((LogicalCallContext)ctorMsg.Properties[Message.CallContextKey]);
		}
		return constructionReturnMessage;
	}

	[SecurityCritical]
	internal static object ActivateWithMessage(Type serverType, IMessage msg, ServerIdentity srvIdToBind, out Exception e)
	{
		object obj = null;
		e = null;
		obj = RemotingServices.AllocateUninitializedObject(serverType);
		object obj2 = null;
		if (serverType.IsContextful)
		{
			obj2 = RemotingServices.Wrap(proxy: (!(msg is ConstructorCallMessage)) ? null : ((ConstructorCallMessage)msg).GetThisPtr(), obj: (ContextBoundObject)obj, fCreateSinks: false);
		}
		else
		{
			if (Thread.CurrentContext != Context.DefaultContext)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_Activation_Failed"));
			}
			obj2 = obj;
		}
		IMessageSink messageSink = new StackBuilderSink(obj2);
		IMethodReturnMessage methodReturnMessage = (IMethodReturnMessage)messageSink.SyncProcessMessage(msg);
		if (methodReturnMessage.Exception == null)
		{
			if (serverType.IsContextful)
			{
				return RemotingServices.Wrap((ContextBoundObject)obj);
			}
			return obj;
		}
		e = methodReturnMessage.Exception;
		return null;
	}

	[SecurityCritical]
	internal static void StartListeningForRemoteRequests()
	{
		Startup();
		DomainSpecificRemotingData remotingData = Thread.GetDomain().RemotingData;
		if (remotingData.ActivatorListening)
		{
			return;
		}
		object configLock = remotingData.ConfigLock;
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Monitor.Enter(configLock, ref lockTaken);
			if (!remotingData.ActivatorListening)
			{
				RemotingServices.MarshalInternal(Thread.GetDomain().RemotingData.ActivationListener, "RemoteActivationService.rem", typeof(IActivator));
				ServerIdentity serverIdentity = (ServerIdentity)IdentityHolder.ResolveIdentity("RemoteActivationService.rem");
				serverIdentity.SetSingletonObjectMode();
				remotingData.ActivatorListening = true;
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(configLock);
			}
		}
	}

	[SecurityCritical]
	internal static IActivator GetActivator()
	{
		DomainSpecificRemotingData remotingData = Thread.GetDomain().RemotingData;
		if (remotingData.LocalActivator == null)
		{
			Startup();
		}
		return remotingData.LocalActivator;
	}

	[SecurityCritical]
	internal static void Initialize()
	{
		GetActivator();
	}

	[SecurityCritical]
	internal static ContextAttribute GetGlobalAttribute()
	{
		DomainSpecificRemotingData remotingData = Thread.GetDomain().RemotingData;
		if (remotingData.LocalActivator == null)
		{
			Startup();
		}
		return remotingData.LocalActivator;
	}

	[SecurityCritical]
	internal static IContextAttribute[] GetContextAttributesForType(Type serverType)
	{
		if (!typeof(ContextBoundObject).IsAssignableFrom(serverType) || serverType.IsCOMObject)
		{
			return new ContextAttribute[0];
		}
		object[] array = null;
		int num = 8;
		IContextAttribute[] array2 = new IContextAttribute[num];
		int num2 = 0;
		array = serverType.GetCustomAttributes(typeof(IContextAttribute), inherit: true);
		object[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			IContextAttribute contextAttribute = (IContextAttribute)array3[i];
			Type type = contextAttribute.GetType();
			bool flag = false;
			for (int j = 0; j < num2; j++)
			{
				if (type.Equals(array2[j].GetType()))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				num2++;
				if (num2 > num - 1)
				{
					IContextAttribute[] array4 = new IContextAttribute[2 * num];
					Array.Copy(array2, 0, array4, 0, num);
					array2 = array4;
					num *= 2;
				}
				array2[num2 - 1] = contextAttribute;
			}
		}
		IContextAttribute[] array5 = new IContextAttribute[num2];
		Array.Copy(array2, array5, num2);
		return array5;
	}

	[SecurityCritical]
	internal static object ConnectIfNecessary(IConstructionCallMessage ctorMsg)
	{
		string text = (string)ctorMsg.Properties["Connect"];
		object result = null;
		if (text != null)
		{
			result = RemotingServices.Connect(ctorMsg.ActivationType, text);
		}
		return result;
	}

	[SecurityCritical]
	internal static object CheckIfConnected(RemotingProxy proxy, IConstructionCallMessage ctorMsg)
	{
		string text = (string)ctorMsg.Properties["Connect"];
		object result = null;
		if (text != null)
		{
			result = proxy.GetTransparentProxy();
		}
		return result;
	}

	internal static void PushActivationAttributes(Type serverType, object[] attributes)
	{
		if (_attributeStack == null)
		{
			_attributeStack = new ActivationAttributeStack();
		}
		_attributeStack.Push(serverType, attributes);
	}

	internal static object[] PeekActivationAttributes(Type serverType)
	{
		if (_attributeStack == null)
		{
			return null;
		}
		return _attributeStack.Peek(serverType);
	}

	internal static void PopActivationAttributes(Type serverType)
	{
		_attributeStack.Pop(serverType);
	}
}
