using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class UrlIdentityPermissionAttribute : CodeAccessSecurityAttribute
{
	private string m_url;

	public string Url
	{
		get
		{
			return m_url;
		}
		set
		{
			m_url = value;
		}
	}

	public UrlIdentityPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new UrlIdentityPermission(PermissionState.Unrestricted);
		}
		if (m_url == null)
		{
			return new UrlIdentityPermission(PermissionState.None);
		}
		return new UrlIdentityPermission(m_url);
	}
}
