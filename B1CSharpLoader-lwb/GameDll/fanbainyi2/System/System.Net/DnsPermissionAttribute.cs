using System.Security;
using System.Security.Permissions;

namespace System.Net;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
public sealed class DnsPermissionAttribute : CodeAccessSecurityAttribute
{
	public DnsPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (base.Unrestricted)
		{
			return new DnsPermission(PermissionState.Unrestricted);
		}
		return new DnsPermission(PermissionState.None);
	}
}
