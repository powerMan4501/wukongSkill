using System.Security;
using System.Security.Permissions;

namespace System.Net.Mail;

[Serializable]
public sealed class SmtpPermission : CodeAccessPermission, IUnrestrictedPermission
{
	private SmtpAccess access;

	private bool unrestricted;

	public SmtpAccess Access => access;

	public SmtpPermission(PermissionState state)
	{
		if (state == PermissionState.Unrestricted)
		{
			access = SmtpAccess.ConnectToUnrestrictedPort;
			unrestricted = true;
		}
		else
		{
			access = SmtpAccess.None;
		}
	}

	public SmtpPermission(bool unrestricted)
	{
		if (unrestricted)
		{
			access = SmtpAccess.ConnectToUnrestrictedPort;
			this.unrestricted = true;
		}
		else
		{
			access = SmtpAccess.None;
		}
	}

	public SmtpPermission(SmtpAccess access)
	{
		this.access = access;
	}

	public void AddPermission(SmtpAccess access)
	{
		if (access > this.access)
		{
			this.access = access;
		}
	}

	public bool IsUnrestricted()
	{
		return unrestricted;
	}

	public override IPermission Copy()
	{
		if (unrestricted)
		{
			return new SmtpPermission(unrestricted: true);
		}
		return new SmtpPermission(access);
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		if (!(target is SmtpPermission smtpPermission))
		{
			throw new ArgumentException(SR.GetString("net_perm_target"), "target");
		}
		if (unrestricted || smtpPermission.IsUnrestricted())
		{
			return new SmtpPermission(unrestricted: true);
		}
		return new SmtpPermission((access > smtpPermission.access) ? access : smtpPermission.access);
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!(target is SmtpPermission smtpPermission))
		{
			throw new ArgumentException(SR.GetString("net_perm_target"), "target");
		}
		if (IsUnrestricted() && smtpPermission.IsUnrestricted())
		{
			return new SmtpPermission(unrestricted: true);
		}
		return new SmtpPermission((access < smtpPermission.access) ? access : smtpPermission.access);
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return access == SmtpAccess.None;
		}
		if (!(target is SmtpPermission smtpPermission))
		{
			throw new ArgumentException(SR.GetString("net_perm_target"), "target");
		}
		if (unrestricted && !smtpPermission.IsUnrestricted())
		{
			return false;
		}
		return smtpPermission.access >= access;
	}

	public override void FromXml(SecurityElement securityElement)
	{
		if (securityElement == null)
		{
			throw new ArgumentNullException("securityElement");
		}
		if (!securityElement.Tag.Equals("IPermission"))
		{
			throw new ArgumentException(SR.GetString("net_not_ipermission"), "securityElement");
		}
		string text = securityElement.Attribute("class");
		if (text == null)
		{
			throw new ArgumentException(SR.GetString("net_no_classname"), "securityElement");
		}
		if (text.IndexOf(GetType().FullName) < 0)
		{
			throw new ArgumentException(SR.GetString("net_no_typename"), "securityElement");
		}
		string text2 = securityElement.Attribute("Unrestricted");
		if (text2 != null && string.Compare(text2, "true", StringComparison.OrdinalIgnoreCase) == 0)
		{
			access = SmtpAccess.ConnectToUnrestrictedPort;
			unrestricted = true;
			return;
		}
		text2 = securityElement.Attribute("Access");
		if (text2 == null)
		{
			return;
		}
		if (string.Compare(text2, "Connect", StringComparison.OrdinalIgnoreCase) == 0)
		{
			access = SmtpAccess.Connect;
			return;
		}
		if (string.Compare(text2, "ConnectToUnrestrictedPort", StringComparison.OrdinalIgnoreCase) == 0)
		{
			access = SmtpAccess.ConnectToUnrestrictedPort;
			return;
		}
		if (string.Compare(text2, "None", StringComparison.OrdinalIgnoreCase) == 0)
		{
			access = SmtpAccess.None;
			return;
		}
		throw new ArgumentException(SR.GetString("net_perm_invalid_val_in_element"), "Access");
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("IPermission");
		securityElement.AddAttribute("class", GetType().FullName + ", " + GetType().Module.Assembly.FullName.Replace('"', '\''));
		securityElement.AddAttribute("version", "1");
		if (unrestricted)
		{
			securityElement.AddAttribute("Unrestricted", "true");
			return securityElement;
		}
		if (access == SmtpAccess.Connect)
		{
			securityElement.AddAttribute("Access", "Connect");
		}
		else if (access == SmtpAccess.ConnectToUnrestrictedPort)
		{
			securityElement.AddAttribute("Access", "ConnectToUnrestrictedPort");
		}
		return securityElement;
	}
}
