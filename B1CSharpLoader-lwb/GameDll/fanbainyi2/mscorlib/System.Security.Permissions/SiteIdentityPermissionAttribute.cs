using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class SiteIdentityPermissionAttribute : CodeAccessSecurityAttribute
{
	private string m_site;

	public string Site
	{
		get
		{
			return m_site;
		}
		set
		{
			m_site = value;
		}
	}

	public SiteIdentityPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new SiteIdentityPermission(PermissionState.Unrestricted);
		}
		if (m_site == null)
		{
			return new SiteIdentityPermission(PermissionState.None);
		}
		return new SiteIdentityPermission(m_site);
	}
}
