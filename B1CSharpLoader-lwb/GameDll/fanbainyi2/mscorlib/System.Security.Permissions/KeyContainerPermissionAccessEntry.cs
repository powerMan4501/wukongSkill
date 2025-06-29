using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class KeyContainerPermissionAccessEntry
{
	private string m_keyStore;

	private string m_providerName;

	private int m_providerType;

	private string m_keyContainerName;

	private int m_keySpec;

	private KeyContainerPermissionFlags m_flags;

	public string KeyStore
	{
		get
		{
			return m_keyStore;
		}
		set
		{
			if (IsUnrestrictedEntry(value, ProviderName, ProviderType, KeyContainerName, KeySpec))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidAccessEntry"));
			}
			if (value == null)
			{
				m_keyStore = "*";
				return;
			}
			if (value != "User" && value != "Machine" && value != "*")
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidKeyStore", value), "value");
			}
			m_keyStore = value;
		}
	}

	public string ProviderName
	{
		get
		{
			return m_providerName;
		}
		set
		{
			if (IsUnrestrictedEntry(KeyStore, value, ProviderType, KeyContainerName, KeySpec))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidAccessEntry"));
			}
			if (value == null)
			{
				m_providerName = "*";
			}
			else
			{
				m_providerName = value;
			}
		}
	}

	public int ProviderType
	{
		get
		{
			return m_providerType;
		}
		set
		{
			if (IsUnrestrictedEntry(KeyStore, ProviderName, value, KeyContainerName, KeySpec))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidAccessEntry"));
			}
			m_providerType = value;
		}
	}

	public string KeyContainerName
	{
		get
		{
			return m_keyContainerName;
		}
		set
		{
			if (IsUnrestrictedEntry(KeyStore, ProviderName, ProviderType, value, KeySpec))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidAccessEntry"));
			}
			if (value == null)
			{
				m_keyContainerName = "*";
			}
			else
			{
				m_keyContainerName = value;
			}
		}
	}

	public int KeySpec
	{
		get
		{
			return m_keySpec;
		}
		set
		{
			if (IsUnrestrictedEntry(KeyStore, ProviderName, ProviderType, KeyContainerName, value))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidAccessEntry"));
			}
			m_keySpec = value;
		}
	}

	public KeyContainerPermissionFlags Flags
	{
		get
		{
			return m_flags;
		}
		set
		{
			KeyContainerPermission.VerifyFlags(value);
			m_flags = value;
		}
	}

	internal KeyContainerPermissionAccessEntry(KeyContainerPermissionAccessEntry accessEntry)
		: this(accessEntry.KeyStore, accessEntry.ProviderName, accessEntry.ProviderType, accessEntry.KeyContainerName, accessEntry.KeySpec, accessEntry.Flags)
	{
	}

	public KeyContainerPermissionAccessEntry(string keyContainerName, KeyContainerPermissionFlags flags)
		: this(null, null, -1, keyContainerName, -1, flags)
	{
	}

	public KeyContainerPermissionAccessEntry(CspParameters parameters, KeyContainerPermissionFlags flags)
		: this(((parameters.Flags & CspProviderFlags.UseMachineKeyStore) == CspProviderFlags.UseMachineKeyStore) ? "Machine" : "User", parameters.ProviderName, parameters.ProviderType, parameters.KeyContainerName, parameters.KeyNumber, flags)
	{
	}

	public KeyContainerPermissionAccessEntry(string keyStore, string providerName, int providerType, string keyContainerName, int keySpec, KeyContainerPermissionFlags flags)
	{
		m_providerName = ((providerName == null) ? "*" : providerName);
		m_providerType = providerType;
		m_keyContainerName = ((keyContainerName == null) ? "*" : keyContainerName);
		m_keySpec = keySpec;
		KeyStore = keyStore;
		Flags = flags;
	}

	public override bool Equals(object o)
	{
		if (!(o is KeyContainerPermissionAccessEntry keyContainerPermissionAccessEntry))
		{
			return false;
		}
		if (keyContainerPermissionAccessEntry.m_keyStore != m_keyStore)
		{
			return false;
		}
		if (keyContainerPermissionAccessEntry.m_providerName != m_providerName)
		{
			return false;
		}
		if (keyContainerPermissionAccessEntry.m_providerType != m_providerType)
		{
			return false;
		}
		if (keyContainerPermissionAccessEntry.m_keyContainerName != m_keyContainerName)
		{
			return false;
		}
		if (keyContainerPermissionAccessEntry.m_keySpec != m_keySpec)
		{
			return false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		int num = 0;
		num |= (m_keyStore.GetHashCode() & 0xFF) << 24;
		num |= (m_providerName.GetHashCode() & 0xFF) << 16;
		num |= (m_providerType & 0xF) << 12;
		num |= (m_keyContainerName.GetHashCode() & 0xFF) << 4;
		return num | (m_keySpec & 0xF);
	}

	internal bool IsSubsetOf(KeyContainerPermissionAccessEntry target)
	{
		if (target.m_keyStore != "*" && m_keyStore != target.m_keyStore)
		{
			return false;
		}
		if (target.m_providerName != "*" && m_providerName != target.m_providerName)
		{
			return false;
		}
		if (target.m_providerType != -1 && m_providerType != target.m_providerType)
		{
			return false;
		}
		if (target.m_keyContainerName != "*" && m_keyContainerName != target.m_keyContainerName)
		{
			return false;
		}
		if (target.m_keySpec != -1 && m_keySpec != target.m_keySpec)
		{
			return false;
		}
		return true;
	}

	internal static bool IsUnrestrictedEntry(string keyStore, string providerName, int providerType, string keyContainerName, int keySpec)
	{
		if (keyStore != "*" && keyStore != null)
		{
			return false;
		}
		if (providerName != "*" && providerName != null)
		{
			return false;
		}
		if (providerType != -1)
		{
			return false;
		}
		if (keyContainerName != "*" && keyContainerName != null)
		{
			return false;
		}
		if (keySpec != -1)
		{
			return false;
		}
		return true;
	}
}
