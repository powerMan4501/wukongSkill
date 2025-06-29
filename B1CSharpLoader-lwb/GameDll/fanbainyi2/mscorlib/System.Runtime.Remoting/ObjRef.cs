using System.Globalization;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Remoting;

[Serializable]
[SecurityCritical]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public class ObjRef : IObjectReference, ISerializable
{
	internal const int FLG_MARSHALED_OBJECT = 1;

	internal const int FLG_WELLKNOWN_OBJREF = 2;

	internal const int FLG_LITE_OBJREF = 4;

	internal const int FLG_PROXY_ATTRIBUTE = 8;

	internal string uri;

	internal IRemotingTypeInfo typeInfo;

	internal IEnvoyInfo envoyInfo;

	internal IChannelInfo channelInfo;

	internal int objrefFlags;

	internal GCHandle srvIdentity;

	internal int domainID;

	private static Type orType = typeof(ObjRef);

	public virtual string URI
	{
		get
		{
			return uri;
		}
		set
		{
			uri = value;
		}
	}

	public virtual IRemotingTypeInfo TypeInfo
	{
		get
		{
			return typeInfo;
		}
		set
		{
			typeInfo = value;
		}
	}

	public virtual IEnvoyInfo EnvoyInfo
	{
		get
		{
			return envoyInfo;
		}
		set
		{
			envoyInfo = value;
		}
	}

	public virtual IChannelInfo ChannelInfo
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return channelInfo;
		}
		set
		{
			channelInfo = value;
		}
	}

	internal void SetServerIdentity(GCHandle hndSrvIdentity)
	{
		srvIdentity = hndSrvIdentity;
	}

	internal GCHandle GetServerIdentity()
	{
		return srvIdentity;
	}

	internal void SetDomainID(int id)
	{
		domainID = id;
	}

	internal int GetDomainID()
	{
		return domainID;
	}

	[SecurityCritical]
	private ObjRef(ObjRef o)
	{
		uri = o.uri;
		typeInfo = o.typeInfo;
		envoyInfo = o.envoyInfo;
		channelInfo = o.channelInfo;
		objrefFlags = o.objrefFlags;
		SetServerIdentity(o.GetServerIdentity());
		SetDomainID(o.GetDomainID());
	}

	[SecurityCritical]
	public ObjRef(MarshalByRefObject o, Type requestedType)
	{
		if (o == null)
		{
			throw new ArgumentNullException("o");
		}
		RuntimeType runtimeType = requestedType as RuntimeType;
		if (requestedType != null && runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"));
		}
		bool fServer;
		Identity identity = MarshalByRefObject.GetIdentity(o, out fServer);
		Init(o, identity, runtimeType);
	}

	[SecurityCritical]
	protected ObjRef(SerializationInfo info, StreamingContext context)
	{
		string text = null;
		bool flag = false;
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Name.Equals("uri"))
			{
				uri = (string)enumerator.Value;
			}
			else if (enumerator.Name.Equals("typeInfo"))
			{
				typeInfo = (IRemotingTypeInfo)enumerator.Value;
			}
			else if (enumerator.Name.Equals("envoyInfo"))
			{
				envoyInfo = (IEnvoyInfo)enumerator.Value;
			}
			else if (enumerator.Name.Equals("channelInfo"))
			{
				channelInfo = (IChannelInfo)enumerator.Value;
			}
			else if (enumerator.Name.Equals("objrefFlags"))
			{
				object value = enumerator.Value;
				if (value.GetType() == typeof(string))
				{
					objrefFlags = ((IConvertible)value).ToInt32(null);
				}
				else
				{
					objrefFlags = (int)value;
				}
			}
			else if (enumerator.Name.Equals("fIsMarshalled"))
			{
				object value2 = enumerator.Value;
				if (((!(value2.GetType() == typeof(string))) ? ((int)value2) : ((IConvertible)value2).ToInt32(null)) == 0)
				{
					flag = true;
				}
			}
			else if (enumerator.Name.Equals("url"))
			{
				text = (string)enumerator.Value;
			}
			else if (enumerator.Name.Equals("SrvIdentity"))
			{
				SetServerIdentity((GCHandle)enumerator.Value);
			}
			else if (enumerator.Name.Equals("DomainId"))
			{
				SetDomainID((int)enumerator.Value);
			}
		}
		if (!flag)
		{
			objrefFlags |= 1;
		}
		else
		{
			objrefFlags &= -2;
		}
		if (text != null)
		{
			uri = text;
			objrefFlags |= 4;
		}
	}

	[SecurityCritical]
	internal bool CanSmuggle()
	{
		if (GetType() != typeof(ObjRef) || IsObjRefLite())
		{
			return false;
		}
		Type type = null;
		if (typeInfo != null)
		{
			type = typeInfo.GetType();
		}
		Type type2 = null;
		if (channelInfo != null)
		{
			type2 = channelInfo.GetType();
		}
		if ((type == null || type == typeof(TypeInfo) || type == typeof(DynamicTypeInfo)) && envoyInfo == null && (type2 == null || type2 == typeof(ChannelInfo)))
		{
			if (channelInfo != null)
			{
				object[] channelData = channelInfo.ChannelData;
				foreach (object obj in channelData)
				{
					if (!(obj is CrossAppDomainData))
					{
						return false;
					}
				}
			}
			return true;
		}
		return false;
	}

	[SecurityCritical]
	internal ObjRef CreateSmuggleableCopy()
	{
		return new ObjRef(this);
	}

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.SetType(orType);
		if (!IsObjRefLite())
		{
			info.AddValue("uri", uri, typeof(string));
			info.AddValue("objrefFlags", objrefFlags);
			info.AddValue("typeInfo", typeInfo, typeof(IRemotingTypeInfo));
			info.AddValue("envoyInfo", envoyInfo, typeof(IEnvoyInfo));
			info.AddValue("channelInfo", GetChannelInfoHelper(), typeof(IChannelInfo));
		}
		else
		{
			info.AddValue("url", uri, typeof(string));
		}
	}

	[SecurityCritical]
	private IChannelInfo GetChannelInfoHelper()
	{
		if (!(this.channelInfo is ChannelInfo { ChannelData: var channelData } channelInfo))
		{
			return this.channelInfo;
		}
		if (channelData == null)
		{
			return channelInfo;
		}
		string[] array = (string[])CallContext.GetData("__bashChannelUrl");
		if (array == null)
		{
			return channelInfo;
		}
		string value = array[0];
		string text = array[1];
		ChannelInfo channelInfo2 = new ChannelInfo();
		channelInfo2.ChannelData = new object[channelData.Length];
		for (int i = 0; i < channelData.Length; i++)
		{
			channelInfo2.ChannelData[i] = channelData[i];
			if (channelInfo2.ChannelData[i] is ChannelDataStore { ChannelUris: { } channelUris } channelDataStore && channelUris.Length == 1 && channelUris[0].Equals(value))
			{
				ChannelDataStore channelDataStore2 = channelDataStore.InternalShallowCopy();
				channelDataStore2.ChannelUris = new string[1];
				channelDataStore2.ChannelUris[0] = text;
				channelInfo2.ChannelData[i] = channelDataStore2;
			}
		}
		return channelInfo2;
	}

	[SecurityCritical]
	public virtual object GetRealObject(StreamingContext context)
	{
		return GetRealObjectHelper();
	}

	[SecurityCritical]
	internal object GetRealObjectHelper()
	{
		if (!IsMarshaledObject())
		{
			return this;
		}
		if (IsObjRefLite())
		{
			int num = uri.IndexOf(RemotingConfiguration.ApplicationId);
			if (num > 0)
			{
				uri = uri.Substring(num - 1);
			}
		}
		bool fRefine = !(GetType() == typeof(ObjRef));
		object ret = RemotingServices.Unmarshal(this, fRefine);
		return GetCustomMarshaledCOMObject(ret);
	}

	[SecurityCritical]
	private object GetCustomMarshaledCOMObject(object ret)
	{
		if (TypeInfo is DynamicTypeInfo)
		{
			object obj = null;
			IntPtr intPtr = IntPtr.Zero;
			if (IsFromThisProcess() && !IsFromThisAppDomain())
			{
				try
				{
					intPtr = ((__ComObject)ret).GetIUnknown(out var fIsURTAggregated);
					if (intPtr != IntPtr.Zero && !fIsURTAggregated)
					{
						string typeName = TypeInfo.TypeName;
						string typeName2 = null;
						string assemName = null;
						System.Runtime.Remoting.TypeInfo.ParseTypeAndAssembly(typeName, out typeName2, out assemName);
						Assembly assembly = FormatterServices.LoadAssemblyFromStringNoThrow(assemName);
						if (assembly == null)
						{
							throw new RemotingException(Environment.GetResourceString("Serialization_AssemblyNotFound", assemName));
						}
						Type type = assembly.GetType(typeName2, throwOnError: false, ignoreCase: false);
						if (type != null && !type.IsVisible)
						{
							type = null;
						}
						obj = Marshal.GetTypedObjectForIUnknown(intPtr, type);
						if (obj != null)
						{
							ret = obj;
						}
					}
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						Marshal.Release(intPtr);
					}
				}
			}
		}
		return ret;
	}

	public ObjRef()
	{
		objrefFlags = 0;
	}

	internal bool IsMarshaledObject()
	{
		return (objrefFlags & 1) == 1;
	}

	internal void SetMarshaledObject()
	{
		objrefFlags |= 1;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal bool IsWellKnown()
	{
		return (objrefFlags & 2) == 2;
	}

	internal void SetWellKnown()
	{
		objrefFlags |= 2;
	}

	internal bool HasProxyAttribute()
	{
		return (objrefFlags & 8) == 8;
	}

	internal void SetHasProxyAttribute()
	{
		objrefFlags |= 8;
	}

	internal bool IsObjRefLite()
	{
		return (objrefFlags & 4) == 4;
	}

	internal void SetObjRefLite()
	{
		objrefFlags |= 4;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private CrossAppDomainData GetAppDomainChannelData()
	{
		int i = 0;
		CrossAppDomainData crossAppDomainData = null;
		for (; i < ChannelInfo.ChannelData.Length; i++)
		{
			if (ChannelInfo.ChannelData[i] is CrossAppDomainData result)
			{
				return result;
			}
		}
		return null;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public bool IsFromThisProcess()
	{
		if (IsWellKnown())
		{
			return false;
		}
		return GetAppDomainChannelData()?.IsFromThisProcess() ?? false;
	}

	[SecurityCritical]
	public bool IsFromThisAppDomain()
	{
		return GetAppDomainChannelData()?.IsFromThisAppDomain() ?? false;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal int GetServerDomainId()
	{
		if (!IsFromThisProcess())
		{
			return 0;
		}
		CrossAppDomainData appDomainChannelData = GetAppDomainChannelData();
		return appDomainChannelData.DomainID;
	}

	[SecurityCritical]
	internal IntPtr GetServerContext(out int domainId)
	{
		IntPtr result = IntPtr.Zero;
		domainId = 0;
		if (IsFromThisProcess())
		{
			CrossAppDomainData appDomainChannelData = GetAppDomainChannelData();
			domainId = appDomainChannelData.DomainID;
			if (AppDomain.IsDomainIdValid(appDomainChannelData.DomainID))
			{
				result = appDomainChannelData.ContextID;
			}
		}
		return result;
	}

	[SecurityCritical]
	internal void Init(object o, Identity idObj, RuntimeType requestedType)
	{
		uri = idObj.URI;
		MarshalByRefObject tPOrObject = idObj.TPOrObject;
		RuntimeType runtimeType = null;
		runtimeType = (RemotingServices.IsTransparentProxy(tPOrObject) ? ((RuntimeType)RemotingServices.GetRealProxy(tPOrObject).GetProxiedType()) : ((RuntimeType)tPOrObject.GetType()));
		RuntimeType runtimeType2 = ((null == requestedType) ? runtimeType : requestedType);
		if (null != requestedType && !requestedType.IsAssignableFrom(runtimeType) && !typeof(IMessageSink).IsAssignableFrom(runtimeType))
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_InvalidRequestedType"), requestedType.ToString()));
		}
		if (runtimeType.IsCOMObject)
		{
			DynamicTypeInfo dynamicTypeInfo = new DynamicTypeInfo(runtimeType2);
			TypeInfo = dynamicTypeInfo;
		}
		else
		{
			RemotingTypeCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(runtimeType2);
			TypeInfo = reflectionCachedData.TypeInfo;
		}
		if (!idObj.IsWellKnown())
		{
			EnvoyInfo = System.Runtime.Remoting.EnvoyInfo.CreateEnvoyInfo(idObj as ServerIdentity);
			IChannelInfo channelInfo = new ChannelInfo();
			if (o is AppDomain)
			{
				object[] channelData = channelInfo.ChannelData;
				int num = channelData.Length;
				object[] array = new object[num];
				Array.Copy(channelData, array, num);
				for (int i = 0; i < num; i++)
				{
					if (!(array[i] is CrossAppDomainData))
					{
						array[i] = null;
					}
				}
				channelInfo.ChannelData = array;
			}
			ChannelInfo = channelInfo;
			if (runtimeType.HasProxyAttribute)
			{
				SetHasProxyAttribute();
			}
		}
		else
		{
			SetWellKnown();
		}
		if (!ShouldUseUrlObjRef())
		{
			return;
		}
		if (IsWellKnown())
		{
			SetObjRefLite();
			return;
		}
		string text = ChannelServices.FindFirstHttpUrlForObject(URI);
		if (text != null)
		{
			URI = text;
			SetObjRefLite();
		}
	}

	internal static bool ShouldUseUrlObjRef()
	{
		return RemotingConfigHandler.UrlObjRefMode;
	}

	[SecurityCritical]
	internal static bool IsWellFormed(ObjRef objectRef)
	{
		bool result = true;
		if (objectRef == null || objectRef.URI == null || (!objectRef.IsWellKnown() && !objectRef.IsObjRefLite() && !(objectRef.GetType() != orType) && objectRef.ChannelInfo == null))
		{
			result = false;
		}
		return result;
	}
}
