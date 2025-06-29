using System.Security;
using System.Security.Permissions;

namespace System.Net.Mail;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
public sealed class SmtpPermissionAttribute : CodeAccessSecurityAttribute
{
	private const string strAccess = "Access";

	private string access;

	public string Access
	{
		get
		{
			return access;
		}
		set
		{
			access = value;
		}
	}

	public SmtpPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		SmtpPermission smtpPermission = null;
		if (base.Unrestricted)
		{
			smtpPermission = new SmtpPermission(PermissionState.Unrestricted);
		}
		else
		{
			smtpPermission = new SmtpPermission(PermissionState.None);
			if (access != null)
			{
				if (string.Compare(access, "Connect", StringComparison.OrdinalIgnoreCase) == 0)
				{
					smtpPermission.AddPermission(SmtpAccess.Connect);
				}
				else if (string.Compare(access, "ConnectToUnrestrictedPort", StringComparison.OrdinalIgnoreCase) == 0)
				{
					smtpPermission.AddPermission(SmtpAccess.ConnectToUnrestrictedPort);
				}
				else
				{
					if (string.Compare(access, "None", StringComparison.OrdinalIgnoreCase) != 0)
					{
						throw new ArgumentException(SR.GetString("net_perm_invalid_val", "Access", access));
					}
					smtpPermission.AddPermission(SmtpAccess.None);
				}
			}
		}
		return smtpPermission;
	}
}
