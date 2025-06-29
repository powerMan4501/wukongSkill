using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class KeyContainerPermissionAttribute : CodeAccessSecurityAttribute
{
	private KeyContainerPermissionFlags m_flags;

	private string m_keyStore;

	private string m_providerName;

	private int m_providerType = -1;

	private string m_keyContainerName;

	private int m_keySpec = -1;

	public string KeyStore
	{
		get
		{
			return m_keyStore;
		}
		set
		{
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
			m_providerName = value;
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
			m_keyContainerName = value;
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
			m_flags = value;
		}
	}

	public KeyContainerPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new KeyContainerPermission(PermissionState.Unrestricted);
		}
		if (KeyContainerPermissionAccessEntry.IsUnrestrictedEntry(m_keyStore, m_providerName, m_providerType, m_keyContainerName, m_keySpec))
		{
			return new KeyContainerPermission(m_flags);
		}
		KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
		KeyContainerPermissionAccessEntry accessEntry = new KeyContainerPermissionAccessEntry(m_keyStore, m_providerName, m_providerType, m_keyContainerName, m_keySpec, m_flags);
		keyContainerPermission.AccessEntries.Add(accessEntry);
		return keyContainerPermission;
	}
}
