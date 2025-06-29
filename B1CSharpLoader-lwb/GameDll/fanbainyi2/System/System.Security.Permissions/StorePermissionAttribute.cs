namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
public sealed class StorePermissionAttribute : CodeAccessSecurityAttribute
{
	private StorePermissionFlags m_flags;

	public StorePermissionFlags Flags
	{
		get
		{
			return m_flags;
		}
		set
		{
			StorePermission.VerifyFlags(value);
			m_flags = value;
		}
	}

	public bool CreateStore
	{
		get
		{
			return (m_flags & StorePermissionFlags.CreateStore) != 0;
		}
		set
		{
			m_flags = (value ? (m_flags | StorePermissionFlags.CreateStore) : (m_flags & ~StorePermissionFlags.CreateStore));
		}
	}

	public bool DeleteStore
	{
		get
		{
			return (m_flags & StorePermissionFlags.DeleteStore) != 0;
		}
		set
		{
			m_flags = (value ? (m_flags | StorePermissionFlags.DeleteStore) : (m_flags & ~StorePermissionFlags.DeleteStore));
		}
	}

	public bool EnumerateStores
	{
		get
		{
			return (m_flags & StorePermissionFlags.EnumerateStores) != 0;
		}
		set
		{
			m_flags = (value ? (m_flags | StorePermissionFlags.EnumerateStores) : (m_flags & ~StorePermissionFlags.EnumerateStores));
		}
	}

	public bool OpenStore
	{
		get
		{
			return (m_flags & StorePermissionFlags.OpenStore) != 0;
		}
		set
		{
			m_flags = (value ? (m_flags | StorePermissionFlags.OpenStore) : (m_flags & ~StorePermissionFlags.OpenStore));
		}
	}

	public bool AddToStore
	{
		get
		{
			return (m_flags & StorePermissionFlags.AddToStore) != 0;
		}
		set
		{
			m_flags = (value ? (m_flags | StorePermissionFlags.AddToStore) : (m_flags & ~StorePermissionFlags.AddToStore));
		}
	}

	public bool RemoveFromStore
	{
		get
		{
			return (m_flags & StorePermissionFlags.RemoveFromStore) != 0;
		}
		set
		{
			m_flags = (value ? (m_flags | StorePermissionFlags.RemoveFromStore) : (m_flags & ~StorePermissionFlags.RemoveFromStore));
		}
	}

	public bool EnumerateCertificates
	{
		get
		{
			return (m_flags & StorePermissionFlags.EnumerateCertificates) != 0;
		}
		set
		{
			m_flags = (value ? (m_flags | StorePermissionFlags.EnumerateCertificates) : (m_flags & ~StorePermissionFlags.EnumerateCertificates));
		}
	}

	public StorePermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (base.Unrestricted)
		{
			return new StorePermission(PermissionState.Unrestricted);
		}
		return new StorePermission(m_flags);
	}
}
