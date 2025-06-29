using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class EnvironmentPermissionAttribute : CodeAccessSecurityAttribute
{
	private string m_read;

	private string m_write;

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

	public string All
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_GetMethod"));
		}
		set
		{
			m_write = value;
			m_read = value;
		}
	}

	public EnvironmentPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new EnvironmentPermission(PermissionState.Unrestricted);
		}
		EnvironmentPermission environmentPermission = new EnvironmentPermission(PermissionState.None);
		if (m_read != null)
		{
			environmentPermission.SetPathList(EnvironmentPermissionAccess.Read, m_read);
		}
		if (m_write != null)
		{
			environmentPermission.SetPathList(EnvironmentPermissionAccess.Write, m_write);
		}
		return environmentPermission;
	}
}
