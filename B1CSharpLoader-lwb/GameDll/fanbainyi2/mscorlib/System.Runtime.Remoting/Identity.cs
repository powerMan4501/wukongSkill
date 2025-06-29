using System.Diagnostics;
using System.Globalization;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Cryptography;
using System.Threading;

namespace System.Runtime.Remoting;

internal class Identity
{
	private static string s_originalAppDomainGuid = Guid.NewGuid().ToString().Replace('-', '_');

	private static string s_configuredAppDomainGuid = null;

	private static string s_originalAppDomainGuidString = "/" + s_originalAppDomainGuid.ToLower(CultureInfo.InvariantCulture) + "/";

	private static string s_configuredAppDomainGuidString = null;

	private static string s_IDGuidString = "/" + s_originalAppDomainGuid.ToLower(CultureInfo.InvariantCulture) + "/";

	private static RNGCryptoServiceProvider s_rng = new RNGCryptoServiceProvider();

	protected const int IDFLG_DISCONNECTED_FULL = 1;

	protected const int IDFLG_DISCONNECTED_REM = 2;

	protected const int IDFLG_IN_IDTABLE = 4;

	protected const int IDFLG_CONTEXT_BOUND = 16;

	protected const int IDFLG_WELLKNOWN = 256;

	protected const int IDFLG_SERVER_SINGLECALL = 512;

	protected const int IDFLG_SERVER_SINGLETON = 1024;

	internal int _flags;

	internal object _tpOrObject;

	protected string _ObjURI;

	protected string _URL;

	internal object _objRef;

	internal object _channelSink;

	internal object _envoyChain;

	internal DynamicPropertyHolder _dph;

	internal Lease _lease;

	private volatile bool _initializing;

	internal static string ProcessIDGuid => SharedStatics.Remoting_Identity_IDGuid;

	internal static string AppDomainUniqueId
	{
		get
		{
			if (s_configuredAppDomainGuid != null)
			{
				return s_configuredAppDomainGuid;
			}
			return s_originalAppDomainGuid;
		}
	}

	internal static string IDGuidString => s_IDGuidString;

	internal static string ProcessGuid => ProcessIDGuid;

	internal bool IsContextBound => (_flags & 0x10) == 16;

	internal bool IsInitializing
	{
		get
		{
			return _initializing;
		}
		set
		{
			_initializing = value;
		}
	}

	internal string URI
	{
		get
		{
			if (IsWellKnown())
			{
				return _URL;
			}
			return _ObjURI;
		}
	}

	internal string ObjURI => _ObjURI;

	internal MarshalByRefObject TPOrObject => (MarshalByRefObject)_tpOrObject;

	internal ObjRef ObjectRef
	{
		[SecurityCritical]
		get
		{
			return (ObjRef)_objRef;
		}
	}

	internal IMessageSink ChannelSink => (IMessageSink)_channelSink;

	internal IMessageSink EnvoyChain => (IMessageSink)_envoyChain;

	internal Lease Lease
	{
		get
		{
			return _lease;
		}
		set
		{
			_lease = value;
		}
	}

	internal ArrayWithSize ProxySideDynamicSinks
	{
		[SecurityCritical]
		get
		{
			if (_dph == null)
			{
				return null;
			}
			return _dph.DynamicSinks;
		}
	}

	internal static string RemoveAppNameOrAppGuidIfNecessary(string uri)
	{
		if (uri == null || uri.Length <= 1 || uri[0] != '/')
		{
			return uri;
		}
		string text;
		if (s_configuredAppDomainGuidString != null)
		{
			text = s_configuredAppDomainGuidString;
			if (uri.Length > text.Length && StringStartsWith(uri, text))
			{
				return uri.Substring(text.Length);
			}
		}
		text = s_originalAppDomainGuidString;
		if (uri.Length > text.Length && StringStartsWith(uri, text))
		{
			return uri.Substring(text.Length);
		}
		string applicationName = RemotingConfiguration.ApplicationName;
		if (applicationName != null && uri.Length > applicationName.Length + 2 && string.Compare(uri, 1, applicationName, 0, applicationName.Length, ignoreCase: true, CultureInfo.InvariantCulture) == 0 && uri[applicationName.Length + 1] == '/')
		{
			return uri.Substring(applicationName.Length + 2);
		}
		uri = uri.Substring(1);
		return uri;
	}

	private static bool StringStartsWith(string s1, string prefix)
	{
		if (s1.Length < prefix.Length)
		{
			return false;
		}
		return string.CompareOrdinal(s1, 0, prefix, 0, prefix.Length) == 0;
	}

	private static int GetNextSeqNum()
	{
		return SharedStatics.Remoting_Identity_GetNextSeqNum();
	}

	private static byte[] GetRandomBytes()
	{
		byte[] array = new byte[18];
		s_rng.GetBytes(array);
		return array;
	}

	internal Identity(string objURI, string URL)
	{
		if (URL != null)
		{
			_flags |= 256;
			_URL = URL;
		}
		SetOrCreateURI(objURI, bIdCtor: true);
	}

	internal Identity(bool bContextBound)
	{
		if (bContextBound)
		{
			_flags |= 16;
		}
	}

	internal bool IsWellKnown()
	{
		return (_flags & 0x100) == 256;
	}

	internal void SetInIDTable()
	{
		int flags;
		int value;
		do
		{
			flags = _flags;
			value = _flags | 4;
		}
		while (flags != Interlocked.CompareExchange(ref _flags, value, flags));
	}

	[SecurityCritical]
	internal void ResetInIDTable(bool bResetURI)
	{
		int flags;
		int value;
		do
		{
			flags = _flags;
			value = _flags & -5;
		}
		while (flags != Interlocked.CompareExchange(ref _flags, value, flags));
		if (bResetURI)
		{
			((ObjRef)_objRef).URI = null;
			_ObjURI = null;
		}
	}

	internal bool IsInIDTable()
	{
		return (_flags & 4) == 4;
	}

	internal void SetFullyConnected()
	{
		int flags;
		int value;
		do
		{
			flags = _flags;
			value = _flags & -4;
		}
		while (flags != Interlocked.CompareExchange(ref _flags, value, flags));
	}

	internal bool IsFullyDisconnected()
	{
		return (_flags & 1) == 1;
	}

	internal bool IsRemoteDisconnected()
	{
		return (_flags & 2) == 2;
	}

	internal bool IsDisconnected()
	{
		if (!IsFullyDisconnected())
		{
			return IsRemoteDisconnected();
		}
		return true;
	}

	internal object RaceSetTransparentProxy(object tpObj)
	{
		if (_tpOrObject == null)
		{
			Interlocked.CompareExchange(ref _tpOrObject, tpObj, null);
		}
		return _tpOrObject;
	}

	[SecurityCritical]
	internal ObjRef RaceSetObjRef(ObjRef objRefGiven)
	{
		if (_objRef == null)
		{
			Interlocked.CompareExchange(ref _objRef, objRefGiven, null);
		}
		return (ObjRef)_objRef;
	}

	internal IMessageSink RaceSetChannelSink(IMessageSink channelSink)
	{
		if (_channelSink == null)
		{
			Interlocked.CompareExchange(ref _channelSink, channelSink, null);
		}
		return (IMessageSink)_channelSink;
	}

	internal IMessageSink RaceSetEnvoyChain(IMessageSink envoyChain)
	{
		if (_envoyChain == null)
		{
			Interlocked.CompareExchange(ref _envoyChain, envoyChain, null);
		}
		return (IMessageSink)_envoyChain;
	}

	internal void SetOrCreateURI(string uri)
	{
		SetOrCreateURI(uri, bIdCtor: false);
	}

	internal void SetOrCreateURI(string uri, bool bIdCtor)
	{
		if (!bIdCtor && _ObjURI != null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_SetObjectUriForMarshal__UriExists"));
		}
		if (uri == null)
		{
			string text = Convert.ToBase64String(GetRandomBytes());
			_ObjURI = (IDGuidString + text.Replace('/', '_') + "_" + GetNextSeqNum().ToString(CultureInfo.InvariantCulture.NumberFormat) + ".rem").ToLower(CultureInfo.InvariantCulture);
		}
		else if (this is ServerIdentity)
		{
			_ObjURI = IDGuidString + uri;
		}
		else
		{
			_ObjURI = uri;
		}
	}

	internal static string GetNewLogicalCallID()
	{
		return IDGuidString + GetNextSeqNum();
	}

	[SecurityCritical]
	[Conditional("_DEBUG")]
	internal virtual void AssertValid()
	{
		if (URI != null)
		{
			Identity identity = IdentityHolder.ResolveIdentity(URI);
		}
	}

	[SecurityCritical]
	internal bool AddProxySideDynamicProperty(IDynamicProperty prop)
	{
		lock (this)
		{
			if (_dph == null)
			{
				DynamicPropertyHolder dph = new DynamicPropertyHolder();
				lock (this)
				{
					if (_dph == null)
					{
						_dph = dph;
					}
				}
			}
			return _dph.AddDynamicProperty(prop);
		}
	}

	[SecurityCritical]
	internal bool RemoveProxySideDynamicProperty(string name)
	{
		lock (this)
		{
			if (_dph == null)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Contexts_NoProperty"), name));
			}
			return _dph.RemoveDynamicProperty(name);
		}
	}
}
