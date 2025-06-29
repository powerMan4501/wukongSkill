using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class RegistryPermissionAttribute : CodeAccessSecurityAttribute
{
	private string m_read;

	private string m_write;

	private string m_create;

	private string m_viewAcl;

	private string m_changeAcl;

	public string Read
	{
		get
		{
			return m_read;
		}
		set
		{
			m_read = value;
		}
	}

	public string Write
	{
		get
		{
			return m_write;
		}
		set
		{
			m_write = value;
		}
	}

	public string Create
	{
		get
		{
			return m_create;
		}
		set
		{
			m_create = value;
		}
	}

	public string ViewAccessControl
	{
		get
		{
			return m_viewAcl;
		}
		set
		{
			m_viewAcl = value;
		}
	}

	public string ChangeAccessControl
	{
		get
		{
			return m_changeAcl;
		}
		set
		{
			m_changeAcl = value;
		}
	}

	public string ViewAndModify
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_GetMethod"));
		}
		set
		{
			m_read = value;
			m_write = value;
			m_create = value;
		}
	}

	[Obsolete("Please use the ViewAndModify property instead.")]
	public string All
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_GetMethod"));
		}
		set
		{
			m_read = value;
			m_write = value;
			m_create = value;
		}
	}

	public RegistryPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new RegistryPermission(PermissionState.Unrestricted);
		}
		RegistryPermission registryPermission = new RegistryPermission(PermissionState.None);
		if (m_read != null)
		{
			registryPermission.SetPathList(RegistryPermissionAccess.Read, m_read);
		}
		if (m_write != null)
		{
			registryPermission.SetPathList(RegistryPermissionAccess.Write, m_write);
		}
		if (m_create != null)
		{
			registryPermission.SetPathList(RegistryPermissionAccess.Create, m_create);
		}
		if (m_viewAcl != null)
		{
			registryPermission.SetPathList(AccessControlActions.View, m_viewAcl);
		}
		if (m_changeAcl != null)
		{
			registryPermission.SetPathList(AccessControlActions.Change, m_changeAcl);
		}
		return registryPermission;
	}
}
