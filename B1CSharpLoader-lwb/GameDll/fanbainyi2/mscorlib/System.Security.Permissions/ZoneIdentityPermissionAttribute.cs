using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class ZoneIdentityPermissionAttribute : CodeAccessSecurityAttribute
{
	private SecurityZone m_flag = SecurityZone.NoZone;

	public SecurityZone Zone
	{
		get
		{
			return m_flag;
		}
		set
		{
			m_flag = value;
		}
	}

	public ZoneIdentityPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new ZoneIdentityPermission(PermissionState.Unrestricted);
		}
		return new ZoneIdentityPermission(m_flag);
	}
}
