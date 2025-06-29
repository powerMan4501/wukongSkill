using System.Collections;
using System.Security.Permissions;

namespace System.Net;

[global::__DynamicallyInvokable]
public class CredentialCache : ICredentials, ICredentialsByHost, IEnumerable
{
	private class CredentialEnumerator : IEnumerator
	{
		private CredentialCache m_cache;

		private ICredentials[] m_array;

		private int m_index = -1;

		private int m_version;

		object IEnumerator.Current
		{
			get
			{
				if (m_index < 0 || m_index >= m_array.Length)
				{
					throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumOpCantHappen"));
				}
				if (m_version != m_cache.m_version)
				{
					throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
				}
				return m_array[m_index];
			}
		}

		internal CredentialEnumerator(CredentialCache cache, Hashtable table, Hashtable hostTable, int version)
		{
			m_cache = cache;
			m_array = new ICredentials[table.Count + hostTable.Count];
			table.Values.CopyTo(m_array, 0);
			hostTable.Values.CopyTo(m_array, table.Count);
			m_version = version;
		}

		bool IEnumerator.MoveNext()
		{
			if (m_version != m_cache.m_version)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
			}
			if (++m_index < m_array.Length)
			{
				return true;
			}
			m_index = m_array.Length;
			return false;
		}

		void IEnumerator.Reset()
		{
			m_index = -1;
		}
	}

	private Hashtable cache = new Hashtable();

	private Hashtable cacheForHosts = new Hashtable();

	internal int m_version;

	private int m_NumbDefaultCredInCache;

	internal bool IsDefaultInCache => m_NumbDefaultCredInCache != 0;

	[global::__DynamicallyInvokable]
	public static ICredentials DefaultCredentials
	{
		[global::__DynamicallyInvokable]
		get
		{
			new EnvironmentPermission(EnvironmentPermissionAccess.Read, "USERNAME").Demand();
			return SystemNetworkCredential.defaultCredential;
		}
	}

	[global::__DynamicallyInvokable]
	public static NetworkCredential DefaultNetworkCredentials
	{
		[global::__DynamicallyInvokable]
		get
		{
			new EnvironmentPermission(EnvironmentPermissionAccess.Read, "USERNAME").Demand();
			return SystemNetworkCredential.defaultCredential;
		}
	}

	[global::__DynamicallyInvokable]
	public CredentialCache()
	{
	}

	[global::__DynamicallyInvokable]
	public void Add(Uri uriPrefix, string authType, NetworkCredential cred)
	{
		if (uriPrefix == null)
		{
			throw new ArgumentNullException("uriPrefix");
		}
		if (authType == null)
		{
			throw new ArgumentNullException("authType");
		}
		if (cred is SystemNetworkCredential && string.Compare(authType, "NTLM", StringComparison.OrdinalIgnoreCase) != 0 && (!DigestClient.WDigestAvailable || string.Compare(authType, "Digest", StringComparison.OrdinalIgnoreCase) != 0) && string.Compare(authType, "Kerberos", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(authType, "Negotiate", StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw new ArgumentException(SR.GetString("net_nodefaultcreds", authType), "authType");
		}
		m_version++;
		CredentialKey key = new CredentialKey(uriPrefix, authType);
		cache.Add(key, cred);
		if (cred is SystemNetworkCredential)
		{
			m_NumbDefaultCredInCache++;
		}
	}

	[global::__DynamicallyInvokable]
	public void Add(string host, int port, string authenticationType, NetworkCredential credential)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (authenticationType == null)
		{
			throw new ArgumentNullException("authenticationType");
		}
		if (host.Length == 0)
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "host"));
		}
		if (port < 0)
		{
			throw new ArgumentOutOfRangeException("port");
		}
		if (credential is SystemNetworkCredential && string.Compare(authenticationType, "NTLM", StringComparison.OrdinalIgnoreCase) != 0 && (!DigestClient.WDigestAvailable || string.Compare(authenticationType, "Digest", StringComparison.OrdinalIgnoreCase) != 0) && string.Compare(authenticationType, "Kerberos", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(authenticationType, "Negotiate", StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw new ArgumentException(SR.GetString("net_nodefaultcreds", authenticationType), "authenticationType");
		}
		m_version++;
		CredentialHostKey key = new CredentialHostKey(host, port, authenticationType);
		cacheForHosts.Add(key, credential);
		if (credential is SystemNetworkCredential)
		{
			m_NumbDefaultCredInCache++;
		}
	}

	[global::__DynamicallyInvokable]
	public void Remove(Uri uriPrefix, string authType)
	{
		if (!(uriPrefix == null) && authType != null)
		{
			m_version++;
			CredentialKey key = new CredentialKey(uriPrefix, authType);
			if (cache[key] is SystemNetworkCredential)
			{
				m_NumbDefaultCredInCache--;
			}
			cache.Remove(key);
		}
	}

	[global::__DynamicallyInvokable]
	public void Remove(string host, int port, string authenticationType)
	{
		if (host != null && authenticationType != null && port >= 0)
		{
			m_version++;
			CredentialHostKey key = new CredentialHostKey(host, port, authenticationType);
			if (cacheForHosts[key] is SystemNetworkCredential)
			{
				m_NumbDefaultCredInCache--;
			}
			cacheForHosts.Remove(key);
		}
	}

	[global::__DynamicallyInvokable]
	public NetworkCredential GetCredential(Uri uriPrefix, string authType)
	{
		if (uriPrefix == null)
		{
			throw new ArgumentNullException("uriPrefix");
		}
		if (authType == null)
		{
			throw new ArgumentNullException("authType");
		}
		int num = -1;
		NetworkCredential result = null;
		IDictionaryEnumerator enumerator = cache.GetEnumerator();
		while (enumerator.MoveNext())
		{
			CredentialKey credentialKey = (CredentialKey)enumerator.Key;
			if (credentialKey.Match(uriPrefix, authType))
			{
				int uriPrefixLength = credentialKey.UriPrefixLength;
				if (uriPrefixLength > num)
				{
					num = uriPrefixLength;
					result = (NetworkCredential)enumerator.Value;
				}
			}
		}
		return result;
	}

	[global::__DynamicallyInvokable]
	public NetworkCredential GetCredential(string host, int port, string authenticationType)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (authenticationType == null)
		{
			throw new ArgumentNullException("authenticationType");
		}
		if (host.Length == 0)
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "host"));
		}
		if (port < 0)
		{
			throw new ArgumentOutOfRangeException("port");
		}
		NetworkCredential result = null;
		IDictionaryEnumerator enumerator = cacheForHosts.GetEnumerator();
		while (enumerator.MoveNext())
		{
			CredentialHostKey credentialHostKey = (CredentialHostKey)enumerator.Key;
			if (credentialHostKey.Match(host, port, authenticationType))
			{
				result = (NetworkCredential)enumerator.Value;
			}
		}
		return result;
	}

	[global::__DynamicallyInvokable]
	public IEnumerator GetEnumerator()
	{
		return new CredentialEnumerator(this, cache, cacheForHosts, m_version);
	}
}
