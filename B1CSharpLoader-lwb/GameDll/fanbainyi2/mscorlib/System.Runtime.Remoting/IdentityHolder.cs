using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Proxies;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting;

internal sealed class IdentityHolder
{
	private static volatile int SetIDCount = 0;

	private const int CleanUpCountInterval = 64;

	private const int INFINITE = int.MaxValue;

	private static Hashtable _URITable = new Hashtable();

	private static volatile Context _cachedDefaultContext = null;

	internal static Hashtable URITable => _URITable;

	internal static Context DefaultContext
	{
		[SecurityCritical]
		get
		{
			if (_cachedDefaultContext == null)
			{
				_cachedDefaultContext = Thread.GetDomain().GetDefaultContext();
			}
			return _cachedDefaultContext;
		}
	}

	internal static ReaderWriterLock TableLock => Thread.GetDomain().RemotingData.IDTableLock;

	private static string MakeURIKey(string uri)
	{
		return Identity.RemoveAppNameOrAppGuidIfNecessary(uri.ToLower(CultureInfo.InvariantCulture));
	}

	private static string MakeURIKeyNoLower(string uri)
	{
		return Identity.RemoveAppNameOrAppGuidIfNecessary(uri);
	}

	private static void CleanupIdentities(object state)
	{
		IDictionaryEnumerator enumerator = URITable.GetEnumerator();
		ArrayList arrayList = new ArrayList();
		while (enumerator.MoveNext())
		{
			object value = enumerator.Value;
			if (value is WeakReference { Target: null })
			{
				arrayList.Add(enumerator.Key);
			}
		}
		foreach (string item in arrayList)
		{
			URITable.Remove(item);
		}
	}

	[SecurityCritical]
	internal static void FlushIdentityTable()
	{
		ReaderWriterLock tableLock = TableLock;
		bool flag = !tableLock.IsWriterLockHeld;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (flag)
			{
				tableLock.AcquireWriterLock(int.MaxValue);
			}
			CleanupIdentities(null);
		}
		finally
		{
			if (flag && tableLock.IsWriterLockHeld)
			{
				tableLock.ReleaseWriterLock();
			}
		}
	}

	private IdentityHolder()
	{
	}

	[SecurityCritical]
	internal static Identity ResolveIdentity(string URI)
	{
		if (URI == null)
		{
			throw new ArgumentNullException("URI");
		}
		ReaderWriterLock tableLock = TableLock;
		bool flag = !tableLock.IsReaderLockHeld;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (flag)
			{
				tableLock.AcquireReaderLock(int.MaxValue);
			}
			return ResolveReference(URITable[MakeURIKey(URI)]);
		}
		finally
		{
			if (flag && tableLock.IsReaderLockHeld)
			{
				tableLock.ReleaseReaderLock();
			}
		}
	}

	[SecurityCritical]
	internal static Identity CasualResolveIdentity(string uri)
	{
		if (uri == null)
		{
			return null;
		}
		Identity identity = CasualResolveReference(URITable[MakeURIKeyNoLower(uri)]);
		if (identity == null)
		{
			identity = CasualResolveReference(URITable[MakeURIKey(uri)]);
			if (identity == null || identity.IsInitializing)
			{
				identity = RemotingConfigHandler.CreateWellKnownObject(uri);
			}
		}
		return identity;
	}

	private static Identity ResolveReference(object o)
	{
		if (o is WeakReference weakReference)
		{
			return (Identity)weakReference.Target;
		}
		return (Identity)o;
	}

	private static Identity CasualResolveReference(object o)
	{
		if (o is WeakReference weakReference)
		{
			return (Identity)weakReference.Target;
		}
		return (Identity)o;
	}

	[SecurityCritical]
	internal static ServerIdentity FindOrCreateServerIdentity(MarshalByRefObject obj, string objURI, int flags)
	{
		ServerIdentity serverIdentity = null;
		serverIdentity = (ServerIdentity)MarshalByRefObject.GetIdentity(obj, out var fServer);
		if (serverIdentity == null)
		{
			Context context = null;
			context = ((!(obj is ContextBoundObject)) ? DefaultContext : Thread.CurrentContext);
			ServerIdentity serverIdentity2 = new ServerIdentity(obj, context);
			if (fServer)
			{
				serverIdentity = obj.__RaceSetServerIdentity(serverIdentity2);
			}
			else
			{
				RealProxy realProxy = null;
				realProxy = RemotingServices.GetRealProxy(obj);
				realProxy.IdentityObject = serverIdentity2;
				serverIdentity = (ServerIdentity)realProxy.IdentityObject;
			}
			if (IdOps.bIsInitializing(flags))
			{
				serverIdentity.IsInitializing = true;
			}
		}
		if (IdOps.bStrongIdentity(flags))
		{
			ReaderWriterLock tableLock = TableLock;
			bool flag = !tableLock.IsWriterLockHeld;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				if (flag)
				{
					tableLock.AcquireWriterLock(int.MaxValue);
				}
				if (serverIdentity.ObjURI == null || !serverIdentity.IsInIDTable())
				{
					SetIdentity(serverIdentity, objURI, DuplicateIdentityOption.Unique);
				}
				if (serverIdentity.IsDisconnected())
				{
					serverIdentity.SetFullyConnected();
				}
			}
			finally
			{
				if (flag && tableLock.IsWriterLockHeld)
				{
					tableLock.ReleaseWriterLock();
				}
			}
		}
		return serverIdentity;
	}

	[SecurityCritical]
	internal static Identity FindOrCreateIdentity(string objURI, string URL, ObjRef objectRef)
	{
		Identity identity = null;
		bool flag = URL != null;
		identity = ResolveIdentity(flag ? URL : objURI);
		if (flag && identity != null && identity is ServerIdentity)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_WellKnown_CantDirectlyConnect"), URL));
		}
		if (identity == null)
		{
			identity = new Identity(objURI, URL);
			ReaderWriterLock tableLock = TableLock;
			bool flag2 = !tableLock.IsWriterLockHeld;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				if (flag2)
				{
					tableLock.AcquireWriterLock(int.MaxValue);
				}
				identity = SetIdentity(identity, null, DuplicateIdentityOption.UseExisting);
				identity.RaceSetObjRef(objectRef);
			}
			finally
			{
				if (flag2 && tableLock.IsWriterLockHeld)
				{
					tableLock.ReleaseWriterLock();
				}
			}
		}
		return identity;
	}

	[SecurityCritical]
	private static Identity SetIdentity(Identity idObj, string URI, DuplicateIdentityOption duplicateOption)
	{
		bool flag = idObj is ServerIdentity;
		if (idObj.URI == null)
		{
			idObj.SetOrCreateURI(URI);
			if (idObj.ObjectRef != null)
			{
				idObj.ObjectRef.URI = idObj.URI;
			}
		}
		string key = MakeURIKey(idObj.URI);
		object obj = URITable[key];
		if (obj != null)
		{
			WeakReference weakReference = obj as WeakReference;
			Identity identity = null;
			bool flag2;
			if (weakReference != null)
			{
				identity = (Identity)weakReference.Target;
				flag2 = identity is ServerIdentity;
			}
			else
			{
				identity = (Identity)obj;
				flag2 = identity is ServerIdentity;
			}
			if (identity != null && identity != idObj)
			{
				switch (duplicateOption)
				{
				case DuplicateIdentityOption.Unique:
				{
					string uRI = idObj.URI;
					throw new RemotingException(Environment.GetResourceString("Remoting_URIClash", uRI));
				}
				case DuplicateIdentityOption.UseExisting:
					idObj = identity;
					break;
				}
			}
			else if (weakReference != null)
			{
				if (flag2)
				{
					URITable[key] = idObj;
				}
				else
				{
					weakReference.Target = idObj;
				}
			}
		}
		else
		{
			object obj2 = null;
			if (flag)
			{
				obj2 = idObj;
				((ServerIdentity)idObj).SetHandle();
			}
			else
			{
				obj2 = new WeakReference(idObj);
			}
			URITable.Add(key, obj2);
			idObj.SetInIDTable();
			SetIDCount++;
			if (SetIDCount % 64 == 0)
			{
				CleanupIdentities(null);
			}
		}
		return idObj;
	}

	[SecurityCritical]
	internal static void RemoveIdentity(string uri)
	{
		RemoveIdentity(uri, bResetURI: true);
	}

	[SecurityCritical]
	internal static void RemoveIdentity(string uri, bool bResetURI)
	{
		string key = MakeURIKey(uri);
		ReaderWriterLock tableLock = TableLock;
		bool flag = !tableLock.IsWriterLockHeld;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (flag)
			{
				tableLock.AcquireWriterLock(int.MaxValue);
			}
			object obj = URITable[key];
			Identity identity;
			if (obj is WeakReference weakReference)
			{
				identity = (Identity)weakReference.Target;
				weakReference.Target = null;
			}
			else
			{
				identity = (Identity)obj;
				if (identity != null)
				{
					((ServerIdentity)identity).ResetHandle();
				}
			}
			if (identity != null)
			{
				URITable.Remove(key);
				identity.ResetInIDTable(bResetURI);
			}
		}
		finally
		{
			if (flag && tableLock.IsWriterLockHeld)
			{
				tableLock.ReleaseWriterLock();
			}
		}
	}

	[SecurityCritical]
	internal static bool AddDynamicProperty(MarshalByRefObject obj, IDynamicProperty prop)
	{
		if (RemotingServices.IsObjectOutOfContext(obj))
		{
			RealProxy realProxy = RemotingServices.GetRealProxy(obj);
			return realProxy.IdentityObject.AddProxySideDynamicProperty(prop);
		}
		MarshalByRefObject obj2 = (MarshalByRefObject)RemotingServices.AlwaysUnwrap((ContextBoundObject)obj);
		ServerIdentity serverIdentity = (ServerIdentity)MarshalByRefObject.GetIdentity(obj2);
		if (serverIdentity != null)
		{
			return serverIdentity.AddServerSideDynamicProperty(prop);
		}
		throw new RemotingException(Environment.GetResourceString("Remoting_NoIdentityEntry"));
	}

	[SecurityCritical]
	internal static bool RemoveDynamicProperty(MarshalByRefObject obj, string name)
	{
		if (RemotingServices.IsObjectOutOfContext(obj))
		{
			RealProxy realProxy = RemotingServices.GetRealProxy(obj);
			return realProxy.IdentityObject.RemoveProxySideDynamicProperty(name);
		}
		MarshalByRefObject obj2 = (MarshalByRefObject)RemotingServices.AlwaysUnwrap((ContextBoundObject)obj);
		ServerIdentity serverIdentity = (ServerIdentity)MarshalByRefObject.GetIdentity(obj2);
		if (serverIdentity != null)
		{
			return serverIdentity.RemoveServerSideDynamicProperty(name);
		}
		throw new RemotingException(Environment.GetResourceString("Remoting_NoIdentityEntry"));
	}
}
