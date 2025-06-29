using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Services;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Runtime.Remoting;

[ComVisible(true)]
[__DynamicallyInvokable]
public static class RemotingServices
{
	private const BindingFlags LookupAll = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

	private const string FieldGetterName = "FieldGetter";

	private const string FieldSetterName = "FieldSetter";

	private const string IsInstanceOfTypeName = "IsInstanceOfType";

	private const string CanCastToXmlTypeName = "CanCastToXmlType";

	private const string InvokeMemberName = "InvokeMember";

	private static volatile MethodBase s_FieldGetterMB;

	private static volatile MethodBase s_FieldSetterMB;

	private static volatile MethodBase s_IsInstanceOfTypeMB;

	private static volatile MethodBase s_CanCastToXmlTypeMB;

	private static volatile MethodBase s_InvokeMemberMB;

	private static volatile bool s_bRemoteActivationConfigured;

	private static volatile bool s_bRegisteredWellKnownChannels;

	private static bool s_bInProcessOfRegisteringWellKnownChannels;

	private static readonly object s_delayLoadChannelLock = new object();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static extern bool IsTransparentProxy(object proxy);

	[SecuritySafeCritical]
	public static bool IsObjectOutOfContext(object tp)
	{
		if (!IsTransparentProxy(tp))
		{
			return false;
		}
		RealProxy realProxy = GetRealProxy(tp);
		Identity identityObject = realProxy.IdentityObject;
		if (!(identityObject is ServerIdentity serverIdentity) || !(realProxy is RemotingProxy))
		{
			return true;
		}
		return Thread.CurrentContext != serverIdentity.ServerContext;
	}

	[__DynamicallyInvokable]
	public static bool IsObjectOutOfAppDomain(object tp)
	{
		return IsClientProxy(tp);
	}

	internal static bool IsClientProxy(object obj)
	{
		if (!(obj is MarshalByRefObject obj2))
		{
			return false;
		}
		bool result = false;
		bool fServer;
		Identity identity = MarshalByRefObject.GetIdentity(obj2, out fServer);
		if (identity != null && !(identity is ServerIdentity))
		{
			result = true;
		}
		return result;
	}

	[SecurityCritical]
	internal static bool IsObjectOutOfProcess(object tp)
	{
		if (!IsTransparentProxy(tp))
		{
			return false;
		}
		RealProxy realProxy = GetRealProxy(tp);
		Identity identityObject = realProxy.IdentityObject;
		if (identityObject is ServerIdentity)
		{
			return false;
		}
		if (identityObject != null)
		{
			ObjRef objectRef = identityObject.ObjectRef;
			if (objectRef != null && objectRef.IsFromThisProcess())
			{
				return false;
			}
			return true;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static extern RealProxy GetRealProxy(object proxy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object CreateTransparentProxy(RealProxy rp, RuntimeType typeToProxy, IntPtr stub, object stubData);

	[SecurityCritical]
	internal static object CreateTransparentProxy(RealProxy rp, Type typeToProxy, IntPtr stub, object stubData)
	{
		RuntimeType runtimeType = typeToProxy as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_WrongType"), "typeToProxy"));
		}
		return CreateTransparentProxy(rp, runtimeType, stub, stubData);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern MarshalByRefObject AllocateUninitializedObject(RuntimeType objectType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void CallDefaultCtor(object o);

	[SecurityCritical]
	internal static MarshalByRefObject AllocateUninitializedObject(Type objectType)
	{
		RuntimeType runtimeType = objectType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_WrongType"), "objectType"));
		}
		return AllocateUninitializedObject(runtimeType);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern MarshalByRefObject AllocateInitializedObject(RuntimeType objectType);

	[SecurityCritical]
	internal static MarshalByRefObject AllocateInitializedObject(Type objectType)
	{
		RuntimeType runtimeType = objectType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_WrongType"), "objectType"));
		}
		return AllocateInitializedObject(runtimeType);
	}

	[SecurityCritical]
	internal static bool RegisterWellKnownChannels()
	{
		if (!s_bRegisteredWellKnownChannels)
		{
			bool lockTaken = false;
			object configLock = Thread.GetDomain().RemotingData.ConfigLock;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				Monitor.Enter(configLock, ref lockTaken);
				if (!s_bRegisteredWellKnownChannels && !s_bInProcessOfRegisteringWellKnownChannels)
				{
					s_bInProcessOfRegisteringWellKnownChannels = true;
					CrossAppDomainChannel.RegisterChannel();
					s_bRegisteredWellKnownChannels = true;
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
		return true;
	}

	[SecurityCritical]
	internal static void InternalSetRemoteActivationConfigured()
	{
		if (!s_bRemoteActivationConfigured)
		{
			nSetRemoteActivationConfigured();
			s_bRemoteActivationConfigured = true;
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void nSetRemoteActivationConfigured();

	[SecurityCritical]
	public static string GetSessionIdForMethodMessage(IMethodMessage msg)
	{
		return msg.Uri;
	}

	[SecuritySafeCritical]
	public static object GetLifetimeService(MarshalByRefObject obj)
	{
		return obj?.GetLifetimeService();
	}

	[SecurityCritical]
	public static string GetObjectUri(MarshalByRefObject obj)
	{
		bool fServer;
		return MarshalByRefObject.GetIdentity(obj, out fServer)?.URI;
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void SetObjectUriForMarshal(MarshalByRefObject obj, string uri)
	{
		Identity identity = null;
		Identity identity2 = null;
		identity = MarshalByRefObject.GetIdentity(obj, out var _);
		identity2 = identity as ServerIdentity;
		if (identity != null && identity2 == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_SetObjectUriForMarshal__ObjectNeedsToBeLocal"));
		}
		if (identity != null && identity.URI != null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_SetObjectUriForMarshal__UriExists"));
		}
		if (identity == null)
		{
			Context context = null;
			context = Thread.GetDomain().GetDefaultContext();
			ServerIdentity serverIdentity = new ServerIdentity(obj, context, uri);
			identity = obj.__RaceSetServerIdentity(serverIdentity);
			if (identity != serverIdentity)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_SetObjectUriForMarshal__UriExists"));
			}
		}
		else
		{
			identity.SetOrCreateURI(uri, bIdCtor: true);
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static ObjRef Marshal(MarshalByRefObject Obj)
	{
		return MarshalInternal(Obj, null, null);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static ObjRef Marshal(MarshalByRefObject Obj, string URI)
	{
		return MarshalInternal(Obj, URI, null);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
	{
		return MarshalInternal(Obj, ObjURI, RequestedType);
	}

	[SecurityCritical]
	internal static ObjRef MarshalInternal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
	{
		return MarshalInternal(Obj, ObjURI, RequestedType, updateChannelData: true);
	}

	[SecurityCritical]
	internal static ObjRef MarshalInternal(MarshalByRefObject Obj, string ObjURI, Type RequestedType, bool updateChannelData)
	{
		return MarshalInternal(Obj, ObjURI, RequestedType, updateChannelData, isInitializing: false);
	}

	[SecurityCritical]
	internal static ObjRef MarshalInternal(MarshalByRefObject Obj, string ObjURI, Type RequestedType, bool updateChannelData, bool isInitializing)
	{
		if (Obj == null)
		{
			return null;
		}
		ObjRef objRef = null;
		Identity identity = null;
		identity = GetOrCreateIdentity(Obj, ObjURI, isInitializing);
		if (RequestedType != null && identity is ServerIdentity serverIdentity)
		{
			serverIdentity.ServerType = RequestedType;
			serverIdentity.MarshaledAsSpecificType = true;
		}
		objRef = identity.ObjectRef;
		if (objRef == null)
		{
			if (IsTransparentProxy(Obj))
			{
				RealProxy realProxy = GetRealProxy(Obj);
				objRef = realProxy.CreateObjRef(RequestedType);
			}
			else
			{
				objRef = Obj.CreateObjRef(RequestedType);
			}
			if (identity == null || objRef == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidMarshalByRefObject"), "Obj");
			}
			objRef = identity.RaceSetObjRef(objRef);
		}
		if (identity is ServerIdentity serverIdentity2)
		{
			MarshalByRefObject obj = null;
			serverIdentity2.GetServerObjectChain(out obj);
			Lease lease = identity.Lease;
			if (lease != null)
			{
				lock (lease)
				{
					if (lease.CurrentState == LeaseState.Expired)
					{
						lease.ActivateLease();
					}
					else
					{
						lease.RenewInternal(identity.Lease.InitialLeaseTime);
					}
				}
			}
			if (updateChannelData && objRef.ChannelInfo != null)
			{
				object[] currentChannelData = ChannelServices.CurrentChannelData;
				if (!(Obj is AppDomain))
				{
					objRef.ChannelInfo.ChannelData = currentChannelData;
				}
				else
				{
					int num = currentChannelData.Length;
					object[] array = new object[num];
					Array.Copy(currentChannelData, array, num);
					for (int i = 0; i < num; i++)
					{
						if (!(array[i] is CrossAppDomainData))
						{
							array[i] = null;
						}
					}
					objRef.ChannelInfo.ChannelData = array;
				}
			}
		}
		TrackingServices.MarshaledObject(Obj, objRef);
		return objRef;
	}

	[SecurityCritical]
	private static Identity GetOrCreateIdentity(MarshalByRefObject Obj, string ObjURI, bool isInitializing)
	{
		int num = 2;
		if (isInitializing)
		{
			num |= 4;
		}
		Identity identity = null;
		if (IsTransparentProxy(Obj))
		{
			RealProxy realProxy = GetRealProxy(Obj);
			identity = realProxy.IdentityObject;
			if (identity == null)
			{
				identity = IdentityHolder.FindOrCreateServerIdentity(Obj, ObjURI, num);
				identity.RaceSetTransparentProxy(Obj);
			}
			if (identity is ServerIdentity serverIdentity)
			{
				identity = IdentityHolder.FindOrCreateServerIdentity(serverIdentity.TPOrObject, ObjURI, num);
				if (ObjURI != null && ObjURI != Identity.RemoveAppNameOrAppGuidIfNecessary(identity.ObjURI))
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_URIExists"));
				}
			}
			else if (ObjURI != null && ObjURI != identity.ObjURI)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_URIToProxy"));
			}
		}
		else
		{
			identity = IdentityHolder.FindOrCreateServerIdentity(Obj, ObjURI, num);
		}
		return identity;
	}

	[SecurityCritical]
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		ObjRef objRef = MarshalInternal((MarshalByRefObject)obj, null, null);
		objRef.GetObjectData(info, context);
	}

	[SecurityCritical]
	public static object Unmarshal(ObjRef objectRef)
	{
		return InternalUnmarshal(objectRef, null, fRefine: false);
	}

	[SecurityCritical]
	public static object Unmarshal(ObjRef objectRef, bool fRefine)
	{
		return InternalUnmarshal(objectRef, null, fRefine);
	}

	[SecurityCritical]
	[ComVisible(true)]
	public static object Connect(Type classToProxy, string url)
	{
		return Unmarshal(classToProxy, url, null);
	}

	[SecurityCritical]
	[ComVisible(true)]
	public static object Connect(Type classToProxy, string url, object data)
	{
		return Unmarshal(classToProxy, url, data);
	}

	[SecurityCritical]
	public static bool Disconnect(MarshalByRefObject obj)
	{
		return Disconnect(obj, bResetURI: true);
	}

	[SecurityCritical]
	internal static bool Disconnect(MarshalByRefObject obj, bool bResetURI)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		bool fServer;
		Identity identity = MarshalByRefObject.GetIdentity(obj, out fServer);
		bool result = false;
		if (identity != null)
		{
			if (!(identity is ServerIdentity))
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_CantDisconnectClientProxy"));
			}
			if (identity.IsInIDTable())
			{
				IdentityHolder.RemoveIdentity(identity.URI, bResetURI);
				result = true;
			}
			TrackingServices.DisconnectedObject(obj);
		}
		return result;
	}

	[SecurityCritical]
	public static IMessageSink GetEnvoyChainForProxy(MarshalByRefObject obj)
	{
		IMessageSink result = null;
		if (IsObjectOutOfContext(obj))
		{
			RealProxy realProxy = GetRealProxy(obj);
			Identity identityObject = realProxy.IdentityObject;
			if (identityObject != null)
			{
				result = identityObject.EnvoyChain;
			}
		}
		return result;
	}

	[SecurityCritical]
	public static ObjRef GetObjRefForProxy(MarshalByRefObject obj)
	{
		ObjRef result = null;
		if (!IsTransparentProxy(obj))
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Proxy_BadType"));
		}
		RealProxy realProxy = GetRealProxy(obj);
		Identity identityObject = realProxy.IdentityObject;
		if (identityObject != null)
		{
			result = identityObject.ObjectRef;
		}
		return result;
	}

	[SecurityCritical]
	internal static object Unmarshal(Type classToProxy, string url)
	{
		return Unmarshal(classToProxy, url, null);
	}

	[SecurityCritical]
	internal static object Unmarshal(Type classToProxy, string url, object data)
	{
		if (null == classToProxy)
		{
			throw new ArgumentNullException("classToProxy");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (!classToProxy.IsMarshalByRef && !classToProxy.IsInterface)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_NotRemotableByReference"));
		}
		Identity identity = IdentityHolder.ResolveIdentity(url);
		object obj = null;
		if (identity == null || identity.ChannelSink == null || identity.EnvoyChain == null)
		{
			string text = null;
			IMessageSink chnlSink = null;
			IMessageSink envoySink = null;
			text = CreateEnvoyAndChannelSinks(url, data, out chnlSink, out envoySink);
			if (chnlSink == null)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Connect_CantCreateChannelSink"), url));
			}
			if (text == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
			}
			identity = IdentityHolder.FindOrCreateIdentity(text, url, null);
			SetEnvoyAndChannelSinks(identity, chnlSink, envoySink);
		}
		return GetOrCreateProxy(classToProxy, identity);
	}

	[SecurityCritical]
	internal static object Wrap(ContextBoundObject obj)
	{
		return Wrap(obj, null, fCreateSinks: true);
	}

	[SecurityCritical]
	internal static object Wrap(ContextBoundObject obj, object proxy, bool fCreateSinks)
	{
		if (obj != null && !IsTransparentProxy(obj))
		{
			Identity identity = null;
			if (proxy != null)
			{
				RealProxy realProxy = GetRealProxy(proxy);
				if (realProxy.UnwrappedServerObject == null)
				{
					realProxy.AttachServerHelper(obj);
				}
				identity = MarshalByRefObject.GetIdentity(obj);
			}
			else
			{
				identity = IdentityHolder.FindOrCreateServerIdentity(obj, null, 0);
			}
			proxy = GetOrCreateProxy(identity, proxy, fRefine: true);
			GetRealProxy(proxy).Wrap();
			if (fCreateSinks)
			{
				IMessageSink chnlSink = null;
				IMessageSink envoySink = null;
				CreateEnvoyAndChannelSinks((MarshalByRefObject)proxy, null, out chnlSink, out envoySink);
				SetEnvoyAndChannelSinks(identity, chnlSink, envoySink);
			}
			RealProxy realProxy2 = GetRealProxy(proxy);
			if (realProxy2.UnwrappedServerObject == null)
			{
				realProxy2.AttachServerHelper(obj);
			}
			return proxy;
		}
		return obj;
	}

	internal static string GetObjectUriFromFullUri(string fullUri)
	{
		if (fullUri == null)
		{
			return null;
		}
		int num = fullUri.LastIndexOf('/');
		if (num == -1)
		{
			return fullUri;
		}
		return fullUri.Substring(num + 1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object Unwrap(ContextBoundObject obj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object AlwaysUnwrap(ContextBoundObject obj);

	[SecurityCritical]
	internal static object InternalUnmarshal(ObjRef objectRef, object proxy, bool fRefine)
	{
		object obj = null;
		Identity identity = null;
		Context currentContext = Thread.CurrentContext;
		if (!ObjRef.IsWellFormed(objectRef))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_BadObjRef"), "Unmarshal"));
		}
		if (objectRef.IsWellKnown())
		{
			obj = Unmarshal(typeof(MarshalByRefObject), objectRef.URI);
			identity = IdentityHolder.ResolveIdentity(objectRef.URI);
			if (identity.ObjectRef == null)
			{
				identity.RaceSetObjRef(objectRef);
			}
			return obj;
		}
		identity = IdentityHolder.FindOrCreateIdentity(objectRef.URI, null, objectRef);
		currentContext = Thread.CurrentContext;
		if (identity is ServerIdentity serverIdentity)
		{
			currentContext = Thread.CurrentContext;
			if (!serverIdentity.IsContextBound)
			{
				if (proxy != null)
				{
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_BadInternalState_ProxySameAppDomain")));
				}
				obj = serverIdentity.TPOrObject;
			}
			else
			{
				IMessageSink chnlSink = null;
				IMessageSink envoySink = null;
				CreateEnvoyAndChannelSinks(serverIdentity.TPOrObject, null, out chnlSink, out envoySink);
				SetEnvoyAndChannelSinks(identity, chnlSink, envoySink);
				obj = GetOrCreateProxy(identity, proxy, fRefine: true);
			}
		}
		else
		{
			IMessageSink chnlSink2 = null;
			IMessageSink envoySink2 = null;
			if (!objectRef.IsObjRefLite())
			{
				CreateEnvoyAndChannelSinks(null, objectRef, out chnlSink2, out envoySink2);
			}
			else
			{
				CreateEnvoyAndChannelSinks(objectRef.URI, null, out chnlSink2, out envoySink2);
			}
			SetEnvoyAndChannelSinks(identity, chnlSink2, envoySink2);
			if (objectRef.HasProxyAttribute())
			{
				fRefine = true;
			}
			obj = GetOrCreateProxy(identity, proxy, fRefine);
		}
		TrackingServices.UnmarshaledObject(obj, objectRef);
		return obj;
	}

	[SecurityCritical]
	private static object GetOrCreateProxy(Identity idObj, object proxy, bool fRefine)
	{
		if (proxy == null)
		{
			Type type;
			if (idObj is ServerIdentity serverIdentity)
			{
				type = serverIdentity.ServerType;
			}
			else
			{
				IRemotingTypeInfo typeInfo = idObj.ObjectRef.TypeInfo;
				type = null;
				if ((typeInfo is TypeInfo && !fRefine) || typeInfo == null)
				{
					type = typeof(MarshalByRefObject);
				}
				else
				{
					string typeName = typeInfo.TypeName;
					if (typeName != null)
					{
						string typeName2 = null;
						string assemName = null;
						TypeInfo.ParseTypeAndAssembly(typeName, out typeName2, out assemName);
						Assembly assembly = FormatterServices.LoadAssemblyFromStringNoThrow(assemName);
						if (assembly != null)
						{
							type = assembly.GetType(typeName2, throwOnError: false, ignoreCase: false);
						}
					}
				}
				if (null == type)
				{
					throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_BadType"), typeInfo.TypeName));
				}
			}
			proxy = SetOrCreateProxy(idObj, type, null);
		}
		else
		{
			proxy = SetOrCreateProxy(idObj, null, proxy);
		}
		if (proxy == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_UnexpectedNullTP"));
		}
		return proxy;
	}

	[SecurityCritical]
	private static object GetOrCreateProxy(Type classToProxy, Identity idObj)
	{
		object obj = idObj.TPOrObject;
		if (obj == null)
		{
			obj = SetOrCreateProxy(idObj, classToProxy, null);
		}
		if (idObj is ServerIdentity { ServerType: var serverType } && !classToProxy.IsAssignableFrom(serverType))
		{
			throw new InvalidCastException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("InvalidCast_FromTo"), serverType.FullName, classToProxy.FullName));
		}
		return obj;
	}

	[SecurityCritical]
	private static MarshalByRefObject SetOrCreateProxy(Identity idObj, Type classToProxy, object proxy)
	{
		RealProxy realProxy = null;
		if (proxy == null)
		{
			ServerIdentity serverIdentity = idObj as ServerIdentity;
			if (idObj.ObjectRef != null)
			{
				ProxyAttribute proxyAttribute = ActivationServices.GetProxyAttribute(classToProxy);
				realProxy = proxyAttribute.CreateProxy(idObj.ObjectRef, classToProxy, null, null);
			}
			if (realProxy == null)
			{
				ProxyAttribute defaultProxyAttribute = ActivationServices.DefaultProxyAttribute;
				realProxy = defaultProxyAttribute.CreateProxy(idObj.ObjectRef, classToProxy, null, serverIdentity?.ServerContext);
			}
		}
		else
		{
			realProxy = GetRealProxy(proxy);
		}
		realProxy.IdentityObject = idObj;
		proxy = realProxy.GetTransparentProxy();
		proxy = idObj.RaceSetTransparentProxy(proxy);
		return (MarshalByRefObject)proxy;
	}

	private static bool AreChannelDataElementsNull(object[] channelData)
	{
		foreach (object obj in channelData)
		{
			if (obj != null)
			{
				return false;
			}
		}
		return true;
	}

	[SecurityCritical]
	internal static void CreateEnvoyAndChannelSinks(MarshalByRefObject tpOrObject, ObjRef objectRef, out IMessageSink chnlSink, out IMessageSink envoySink)
	{
		chnlSink = null;
		envoySink = null;
		if (objectRef == null)
		{
			chnlSink = ChannelServices.GetCrossContextChannelSink();
			envoySink = Thread.CurrentContext.CreateEnvoyChain(tpOrObject);
			return;
		}
		object[] channelData = objectRef.ChannelInfo.ChannelData;
		if (channelData != null && !AreChannelDataElementsNull(channelData))
		{
			for (int i = 0; i < channelData.Length; i++)
			{
				chnlSink = ChannelServices.CreateMessageSink(channelData[i]);
				if (chnlSink != null)
				{
					break;
				}
			}
			if (chnlSink == null)
			{
				lock (s_delayLoadChannelLock)
				{
					for (int j = 0; j < channelData.Length; j++)
					{
						chnlSink = ChannelServices.CreateMessageSink(channelData[j]);
						if (chnlSink != null)
						{
							break;
						}
					}
					if (chnlSink == null)
					{
						object[] array = channelData;
						foreach (object data in array)
						{
							chnlSink = RemotingConfigHandler.FindDelayLoadChannelForCreateMessageSink(null, data, out var _);
							if (chnlSink != null)
							{
								break;
							}
						}
					}
				}
			}
		}
		if (objectRef.EnvoyInfo != null && objectRef.EnvoyInfo.EnvoySinks != null)
		{
			envoySink = objectRef.EnvoyInfo.EnvoySinks;
		}
		else
		{
			envoySink = EnvoyTerminatorSink.MessageSink;
		}
	}

	[SecurityCritical]
	internal static string CreateEnvoyAndChannelSinks(string url, object data, out IMessageSink chnlSink, out IMessageSink envoySink)
	{
		string text = null;
		text = CreateChannelSink(url, data, out chnlSink);
		envoySink = EnvoyTerminatorSink.MessageSink;
		return text;
	}

	[SecurityCritical]
	private static string CreateChannelSink(string url, object data, out IMessageSink chnlSink)
	{
		string objectURI = null;
		chnlSink = ChannelServices.CreateMessageSink(url, data, out objectURI);
		if (chnlSink == null)
		{
			lock (s_delayLoadChannelLock)
			{
				chnlSink = ChannelServices.CreateMessageSink(url, data, out objectURI);
				if (chnlSink == null)
				{
					chnlSink = RemotingConfigHandler.FindDelayLoadChannelForCreateMessageSink(url, data, out objectURI);
				}
			}
		}
		return objectURI;
	}

	internal static void SetEnvoyAndChannelSinks(Identity idObj, IMessageSink chnlSink, IMessageSink envoySink)
	{
		if (idObj.ChannelSink == null && chnlSink != null)
		{
			idObj.RaceSetChannelSink(chnlSink);
		}
		if (idObj.EnvoyChain == null)
		{
			if (envoySink == null)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_BadInternalState_FailEnvoySink")));
			}
			idObj.RaceSetEnvoyChain(envoySink);
		}
	}

	[SecurityCritical]
	private static bool CheckCast(RealProxy rp, RuntimeType castType)
	{
		bool result = false;
		if (castType == typeof(object))
		{
			return true;
		}
		if (!castType.IsInterface && !castType.IsMarshalByRef)
		{
			return false;
		}
		if (castType != typeof(IObjectReference))
		{
			if (rp is IRemotingTypeInfo remotingTypeInfo)
			{
				result = remotingTypeInfo.CanCastTo(castType, rp.GetTransparentProxy());
			}
			else
			{
				Identity identityObject = rp.IdentityObject;
				if (identityObject != null)
				{
					ObjRef objectRef = identityObject.ObjectRef;
					if (objectRef != null)
					{
						IRemotingTypeInfo typeInfo = objectRef.TypeInfo;
						if (typeInfo != null)
						{
							result = typeInfo.CanCastTo(castType, rp.GetTransparentProxy());
						}
					}
				}
			}
		}
		return result;
	}

	[SecurityCritical]
	internal static bool ProxyCheckCast(RealProxy rp, RuntimeType castType)
	{
		return CheckCast(rp, castType);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object CheckCast(object objToExpand, RuntimeType type);

	[SecurityCritical]
	internal static GCHandle CreateDelegateInvocation(WaitCallback waitDelegate, object state)
	{
		return GCHandle.Alloc(new object[2] { waitDelegate, state });
	}

	[SecurityCritical]
	internal static void DisposeDelegateInvocation(GCHandle delegateCallToken)
	{
		delegateCallToken.Free();
	}

	[SecurityCritical]
	internal static object CreateProxyForDomain(int appDomainId, IntPtr defCtxID)
	{
		AppDomain appDomain = null;
		ObjRef objectRef = CreateDataForDomain(appDomainId, defCtxID);
		return (AppDomain)Unmarshal(objectRef);
	}

	[SecurityCritical]
	internal static object CreateDataForDomainCallback(object[] args)
	{
		RegisterWellKnownChannels();
		ObjRef objRef = MarshalInternal(Thread.CurrentContext.AppDomain, null, null, updateChannelData: false);
		ServerIdentity serverIdentity = (ServerIdentity)MarshalByRefObject.GetIdentity(Thread.CurrentContext.AppDomain);
		serverIdentity.SetHandle();
		objRef.SetServerIdentity(serverIdentity.GetHandle());
		objRef.SetDomainID(AppDomain.CurrentDomain.GetId());
		return objRef;
	}

	[SecurityCritical]
	internal static ObjRef CreateDataForDomain(int appDomainId, IntPtr defCtxID)
	{
		RegisterWellKnownChannels();
		InternalCrossContextDelegate ftnToCall = CreateDataForDomainCallback;
		return (ObjRef)Thread.CurrentThread.InternalCrossContextCallback(null, defCtxID, appDomainId, ftnToCall, null);
	}

	[SecurityCritical]
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
	{
		return InternalGetMethodBaseFromMethodMessage(msg);
	}

	[SecurityCritical]
	internal static MethodBase InternalGetMethodBaseFromMethodMessage(IMethodMessage msg)
	{
		if (msg == null)
		{
			return null;
		}
		Type type = InternalGetTypeFromQualifiedTypeName(msg.TypeName);
		if (type == null)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_BadType"), msg.TypeName));
		}
		Type[] signature = (Type[])msg.MethodSignature;
		return GetMethodBase(msg, type, signature);
	}

	[SecurityCritical]
	public static bool IsMethodOverloaded(IMethodMessage msg)
	{
		RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(msg.MethodBase);
		return reflectionCachedData.IsOverloaded();
	}

	[SecurityCritical]
	private static MethodBase GetMethodBase(IMethodMessage msg, Type t, Type[] signature)
	{
		MethodBase result = null;
		if (msg is IConstructionCallMessage || msg is IConstructionReturnMessage)
		{
			if (signature == null)
			{
				RuntimeType runtimeType = t as RuntimeType;
				ConstructorInfo[] array = ((!(runtimeType == null)) ? runtimeType.GetConstructors() : t.GetConstructors());
				if (1 != array.Length)
				{
					throw new AmbiguousMatchException(Environment.GetResourceString("Remoting_AmbiguousCTOR"));
				}
				result = array[0];
			}
			else
			{
				RuntimeType runtimeType2 = t as RuntimeType;
				result = ((!(runtimeType2 == null)) ? runtimeType2.GetConstructor(signature) : t.GetConstructor(signature));
			}
		}
		else if (msg is IMethodCallMessage || msg is IMethodReturnMessage)
		{
			if (signature == null)
			{
				RuntimeType runtimeType3 = t as RuntimeType;
				result = ((!(runtimeType3 == null)) ? runtimeType3.GetMethod(msg.MethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic) : t.GetMethod(msg.MethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic));
			}
			else
			{
				RuntimeType runtimeType4 = t as RuntimeType;
				result = ((!(runtimeType4 == null)) ? runtimeType4.GetMethod(msg.MethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, signature, null) : t.GetMethod(msg.MethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, signature, null));
			}
		}
		return result;
	}

	[SecurityCritical]
	internal static bool IsMethodAllowedRemotely(MethodBase method)
	{
		if (s_FieldGetterMB == null || s_FieldSetterMB == null || s_IsInstanceOfTypeMB == null || s_InvokeMemberMB == null || s_CanCastToXmlTypeMB == null)
		{
			CodeAccessPermission.Assert(allPossible: true);
			if (s_FieldGetterMB == null)
			{
				s_FieldGetterMB = typeof(object).GetMethod("FieldGetter", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
			if (s_FieldSetterMB == null)
			{
				s_FieldSetterMB = typeof(object).GetMethod("FieldSetter", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
			if (s_IsInstanceOfTypeMB == null)
			{
				s_IsInstanceOfTypeMB = typeof(MarshalByRefObject).GetMethod("IsInstanceOfType", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
			if (s_CanCastToXmlTypeMB == null)
			{
				s_CanCastToXmlTypeMB = typeof(MarshalByRefObject).GetMethod("CanCastToXmlType", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
			if (s_InvokeMemberMB == null)
			{
				s_InvokeMemberMB = typeof(MarshalByRefObject).GetMethod("InvokeMember", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}
		if (!(method == s_FieldGetterMB) && !(method == s_FieldSetterMB) && !(method == s_IsInstanceOfTypeMB) && !(method == s_InvokeMemberMB))
		{
			return method == s_CanCastToXmlTypeMB;
		}
		return true;
	}

	[SecurityCritical]
	public static bool IsOneWay(MethodBase method)
	{
		if (method == null)
		{
			return false;
		}
		RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(method);
		return reflectionCachedData.IsOneWayMethod();
	}

	internal static bool FindAsyncMethodVersion(MethodInfo method, out MethodInfo beginMethod, out MethodInfo endMethod)
	{
		beginMethod = null;
		endMethod = null;
		string value = "Begin" + method.Name;
		string value2 = "End" + method.Name;
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		Type typeFromHandle = typeof(IAsyncResult);
		Type returnType = method.ReturnType;
		ParameterInfo[] parameters = method.GetParameters();
		ParameterInfo[] array = parameters;
		foreach (ParameterInfo parameterInfo in array)
		{
			if (parameterInfo.IsOut)
			{
				arrayList2.Add(parameterInfo);
			}
			else if (parameterInfo.ParameterType.IsByRef)
			{
				arrayList.Add(parameterInfo);
				arrayList2.Add(parameterInfo);
			}
			else
			{
				arrayList.Add(parameterInfo);
			}
		}
		arrayList.Add(typeof(AsyncCallback));
		arrayList.Add(typeof(object));
		arrayList2.Add(typeof(IAsyncResult));
		Type declaringType = method.DeclaringType;
		MethodInfo[] methods = declaringType.GetMethods();
		MethodInfo[] array2 = methods;
		foreach (MethodInfo methodInfo in array2)
		{
			ParameterInfo[] parameters2 = methodInfo.GetParameters();
			if (methodInfo.Name.Equals(value) && methodInfo.ReturnType == typeFromHandle && CompareParameterList(arrayList, parameters2))
			{
				beginMethod = methodInfo;
			}
			else if (methodInfo.Name.Equals(value2) && methodInfo.ReturnType == returnType && CompareParameterList(arrayList2, parameters2))
			{
				endMethod = methodInfo;
			}
		}
		if (beginMethod != null && endMethod != null)
		{
			return true;
		}
		return false;
	}

	private static bool CompareParameterList(ArrayList params1, ParameterInfo[] params2)
	{
		if (params1.Count != params2.Length)
		{
			return false;
		}
		int num = 0;
		foreach (object item in params1)
		{
			ParameterInfo parameterInfo = params2[num];
			if (item is ParameterInfo parameterInfo2)
			{
				if (parameterInfo2.ParameterType != parameterInfo.ParameterType || parameterInfo2.IsIn != parameterInfo.IsIn || parameterInfo2.IsOut != parameterInfo.IsOut)
				{
					return false;
				}
			}
			else if ((Type)item != parameterInfo.ParameterType && parameterInfo.IsIn)
			{
				return false;
			}
			num++;
		}
		return true;
	}

	[SecurityCritical]
	public static Type GetServerTypeForUri(string URI)
	{
		Type result = null;
		if (URI != null)
		{
			ServerIdentity serverIdentity = (ServerIdentity)IdentityHolder.ResolveIdentity(URI);
			result = ((serverIdentity != null) ? serverIdentity.ServerType : RemotingConfigHandler.GetServerTypeForUri(URI));
		}
		return result;
	}

	[SecurityCritical]
	internal static void DomainUnloaded(int domainID)
	{
		IdentityHolder.FlushIdentityTable();
		CrossAppDomainSink.DomainUnloaded(domainID);
	}

	[SecurityCritical]
	internal static IntPtr GetServerContextForProxy(object tp)
	{
		ObjRef objRef = null;
		bool bSameDomain;
		int domainId;
		return GetServerContextForProxy(tp, out objRef, out bSameDomain, out domainId);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static int GetServerDomainIdForProxy(object tp)
	{
		RealProxy realProxy = GetRealProxy(tp);
		Identity identityObject = realProxy.IdentityObject;
		return identityObject.ObjectRef.GetServerDomainId();
	}

	[SecurityCritical]
	internal static void GetServerContextAndDomainIdForProxy(object tp, out IntPtr contextId, out int domainId)
	{
		contextId = GetServerContextForProxy(tp, out var _, out var _, out domainId);
	}

	[SecurityCritical]
	private static IntPtr GetServerContextForProxy(object tp, out ObjRef objRef, out bool bSameDomain, out int domainId)
	{
		IntPtr result = IntPtr.Zero;
		objRef = null;
		bSameDomain = false;
		domainId = 0;
		if (IsTransparentProxy(tp))
		{
			RealProxy realProxy = GetRealProxy(tp);
			Identity identityObject = realProxy.IdentityObject;
			if (identityObject != null)
			{
				if (identityObject is ServerIdentity serverIdentity)
				{
					bSameDomain = true;
					result = serverIdentity.ServerContext.InternalContextID;
					domainId = Thread.GetDomain().GetId();
				}
				else
				{
					objRef = identityObject.ObjectRef;
					result = ((objRef == null) ? IntPtr.Zero : objRef.GetServerContext(out domainId));
				}
			}
			else
			{
				result = Context.DefaultContext.InternalContextID;
			}
		}
		return result;
	}

	[SecurityCritical]
	internal static Context GetServerContext(MarshalByRefObject obj)
	{
		Context result = null;
		if (!IsTransparentProxy(obj) && obj is ContextBoundObject)
		{
			result = Thread.CurrentContext;
		}
		else
		{
			RealProxy realProxy = GetRealProxy(obj);
			Identity identityObject = realProxy.IdentityObject;
			if (identityObject is ServerIdentity serverIdentity)
			{
				result = serverIdentity.ServerContext;
			}
		}
		return result;
	}

	[SecurityCritical]
	private static object GetType(object tp)
	{
		Type result = null;
		RealProxy realProxy = GetRealProxy(tp);
		Identity identityObject = realProxy.IdentityObject;
		if (identityObject != null && identityObject.ObjectRef != null && identityObject.ObjectRef.TypeInfo != null)
		{
			IRemotingTypeInfo typeInfo = identityObject.ObjectRef.TypeInfo;
			string typeName = typeInfo.TypeName;
			if (typeName != null)
			{
				result = InternalGetTypeFromQualifiedTypeName(typeName);
			}
		}
		return result;
	}

	[SecurityCritical]
	internal static byte[] MarshalToBuffer(object o, bool crossRuntime)
	{
		if (crossRuntime)
		{
			if (IsTransparentProxy(o))
			{
				if (GetRealProxy(o) is RemotingProxy && ChannelServices.RegisteredChannels.Length == 0)
				{
					return null;
				}
			}
			else if (o is MarshalByRefObject marshalByRefObject)
			{
				ProxyAttribute proxyAttribute = ActivationServices.GetProxyAttribute(marshalByRefObject.GetType());
				if (proxyAttribute == ActivationServices.DefaultProxyAttribute && ChannelServices.RegisteredChannels.Length == 0)
				{
					return null;
				}
			}
		}
		MemoryStream memoryStream = new MemoryStream();
		RemotingSurrogateSelector surrogateSelector = new RemotingSurrogateSelector();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.SurrogateSelector = surrogateSelector;
		binaryFormatter.Context = new StreamingContext(StreamingContextStates.Other);
		binaryFormatter.Serialize(memoryStream, o, null, fCheck: false);
		return memoryStream.GetBuffer();
	}

	[SecurityCritical]
	internal static object UnmarshalFromBuffer(byte[] b, bool crossRuntime)
	{
		MemoryStream serializationStream = new MemoryStream(b);
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
		binaryFormatter.SurrogateSelector = null;
		binaryFormatter.Context = new StreamingContext(StreamingContextStates.Other);
		object obj = binaryFormatter.Deserialize(serializationStream, null, fCheck: false);
		if (crossRuntime && IsTransparentProxy(obj))
		{
			if (!(GetRealProxy(obj) is RemotingProxy))
			{
				return obj;
			}
			if (ChannelServices.RegisteredChannels.Length == 0)
			{
				return null;
			}
			obj.GetHashCode();
		}
		return obj;
	}

	internal static object UnmarshalReturnMessageFromBuffer(byte[] b, IMethodCallMessage msg)
	{
		MemoryStream serializationStream = new MemoryStream(b);
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.SurrogateSelector = null;
		binaryFormatter.Context = new StreamingContext(StreamingContextStates.Other);
		return binaryFormatter.DeserializeMethodResponse(serializationStream, null, msg);
	}

	[SecurityCritical]
	public static IMethodReturnMessage ExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		RealProxy realProxy = GetRealProxy(target);
		if (realProxy is RemotingProxy && !realProxy.DoContextsMatch())
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Proxy_WrongContext"));
		}
		StackBuilderSink stackBuilderSink = new StackBuilderSink(target);
		return (IMethodReturnMessage)stackBuilderSink.SyncProcessMessage(reqMsg);
	}

	[SecurityCritical]
	internal static string DetermineDefaultQualifiedTypeName(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		string xmlType = null;
		string xmlTypeNamespace = null;
		if (SoapServices.GetXmlTypeForInteropType(type, out xmlType, out xmlTypeNamespace))
		{
			return "soap:" + xmlType + ", " + xmlTypeNamespace;
		}
		return type.AssemblyQualifiedName;
	}

	[SecurityCritical]
	internal static string GetDefaultQualifiedTypeName(RuntimeType type)
	{
		RemotingTypeCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(type);
		return reflectionCachedData.QualifiedTypeName;
	}

	internal static string InternalGetClrTypeNameFromQualifiedTypeName(string qualifiedTypeName)
	{
		if (qualifiedTypeName.Length > 4 && string.CompareOrdinal(qualifiedTypeName, 0, "clr:", 0, 4) == 0)
		{
			return qualifiedTypeName.Substring(4);
		}
		return null;
	}

	private static int IsSoapType(string qualifiedTypeName)
	{
		if (qualifiedTypeName.Length > 5 && string.CompareOrdinal(qualifiedTypeName, 0, "soap:", 0, 5) == 0)
		{
			return qualifiedTypeName.IndexOf(',', 5);
		}
		return -1;
	}

	[SecurityCritical]
	internal static string InternalGetSoapTypeNameFromQualifiedTypeName(string xmlTypeName, string xmlTypeNamespace)
	{
		if (!SoapServices.DecodeXmlNamespaceForClrTypeNamespace(xmlTypeNamespace, out var typeNamespace, out var assemblyName))
		{
			return null;
		}
		string text = ((typeNamespace == null || typeNamespace.Length <= 0) ? xmlTypeName : (typeNamespace + "." + xmlTypeName));
		try
		{
			return text + ", " + assemblyName;
		}
		catch
		{
		}
		return null;
	}

	[SecurityCritical]
	internal static string InternalGetTypeNameFromQualifiedTypeName(string qualifiedTypeName)
	{
		if (qualifiedTypeName == null)
		{
			throw new ArgumentNullException("qualifiedTypeName");
		}
		string text = InternalGetClrTypeNameFromQualifiedTypeName(qualifiedTypeName);
		if (text != null)
		{
			return text;
		}
		int num = IsSoapType(qualifiedTypeName);
		if (num != -1)
		{
			string xmlTypeName = qualifiedTypeName.Substring(5, num - 5);
			string xmlTypeNamespace = qualifiedTypeName.Substring(num + 2, qualifiedTypeName.Length - (num + 2));
			text = InternalGetSoapTypeNameFromQualifiedTypeName(xmlTypeName, xmlTypeNamespace);
			if (text != null)
			{
				return text;
			}
		}
		return qualifiedTypeName;
	}

	[SecurityCritical]
	internal static RuntimeType InternalGetTypeFromQualifiedTypeName(string qualifiedTypeName, bool partialFallback)
	{
		if (qualifiedTypeName == null)
		{
			throw new ArgumentNullException("qualifiedTypeName");
		}
		string text = InternalGetClrTypeNameFromQualifiedTypeName(qualifiedTypeName);
		if (text != null)
		{
			return LoadClrTypeWithPartialBindFallback(text, partialFallback);
		}
		int num = IsSoapType(qualifiedTypeName);
		if (num != -1)
		{
			string text2 = qualifiedTypeName.Substring(5, num - 5);
			string xmlTypeNamespace = qualifiedTypeName.Substring(num + 2, qualifiedTypeName.Length - (num + 2));
			RuntimeType runtimeType = (RuntimeType)SoapServices.GetInteropTypeFromXmlType(text2, xmlTypeNamespace);
			if (runtimeType != null)
			{
				return runtimeType;
			}
			text = InternalGetSoapTypeNameFromQualifiedTypeName(text2, xmlTypeNamespace);
			if (text != null)
			{
				return LoadClrTypeWithPartialBindFallback(text, partialFallback: true);
			}
		}
		return LoadClrTypeWithPartialBindFallback(qualifiedTypeName, partialFallback);
	}

	[SecurityCritical]
	internal static Type InternalGetTypeFromQualifiedTypeName(string qualifiedTypeName)
	{
		return InternalGetTypeFromQualifiedTypeName(qualifiedTypeName, partialFallback: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static RuntimeType LoadClrTypeWithPartialBindFallback(string typeName, bool partialFallback)
	{
		if (!partialFallback)
		{
			return (RuntimeType)Type.GetType(typeName, throwOnError: false);
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeTypeHandle.GetTypeByName(typeName, throwOnError: false, ignoreCase: false, reflectionOnly: false, ref stackMark, loadTypeFromPartialName: true);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool CORProfilerTrackRemoting();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool CORProfilerTrackRemotingCookie();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool CORProfilerTrackRemotingAsync();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void CORProfilerRemotingClientSendingMessage(out Guid id, bool fIsAsync);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void CORProfilerRemotingClientReceivingReply(Guid id, bool fIsAsync);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void CORProfilerRemotingServerReceivingMessage(Guid id, bool fIsAsync);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void CORProfilerRemotingServerSendingReply(out Guid id, bool fIsAsync);

	[SecurityCritical]
	[Conditional("REMOTING_PERF")]
	[Obsolete("Use of this method is not recommended. The LogRemotingStage existed for internal diagnostic purposes only.")]
	public static void LogRemotingStage(int stage)
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void ResetInterfaceCache(object proxy);
}
