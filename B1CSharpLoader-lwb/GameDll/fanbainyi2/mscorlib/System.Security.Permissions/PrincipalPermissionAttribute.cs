using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class PrincipalPermissionAttribute : CodeAccessSecurityAttribute
{
	private string m_name;

	private string m_role;

	private bool m_authenticated = true;

	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			m_name = value;
		}
	}

	public string Role
	{
		get
		{
			return m_role;
		}
		set
		{
			m_role = value;
		}
	}

	public bool Authenticated
	{
		get
		{
			return m_authenticated;
		}
		set
		{
			m_authenticated = value;
		}
	}

	public PrincipalPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new PrincipalPermission(PermissionState.Unrestricted);
		}
		return new PrincipalPermission(m_name, m_role, m_authenticated);
	}
}
