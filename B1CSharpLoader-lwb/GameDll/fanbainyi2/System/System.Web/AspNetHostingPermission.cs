using System.Security;
using System.Security.Permissions;

namespace System.Web;

[Serializable]
public sealed class AspNetHostingPermission : CodeAccessPermission, IUnrestrictedPermission
{
	private AspNetHostingPermissionLevel _level;

	public AspNetHostingPermissionLevel Level
	{
		get
		{
			return _level;
		}
		set
		{
			VerifyAspNetHostingPermissionLevel(value, "Level");
			_level = value;
		}
	}

	internal static void VerifyAspNetHostingPermissionLevel(AspNetHostingPermissionLevel level, string arg)
	{
		switch (level)
		{
		case AspNetHostingPermissionLevel.None:
		case AspNetHostingPermissionLevel.Minimal:
		case AspNetHostingPermissionLevel.Low:
		case AspNetHostingPermissionLevel.Medium:
		case AspNetHostingPermissionLevel.High:
		case AspNetHostingPermissionLevel.Unrestricted:
			return;
		}
		throw new ArgumentException(arg);
	}

	public AspNetHostingPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			_level = AspNetHostingPermissionLevel.Unrestricted;
			break;
		case PermissionState.None:
			_level = AspNetHostingPermissionLevel.None;
			break;
		default:
			throw new ArgumentException(SR.GetString("InvalidArgument", state.ToString(), "state"));
		}
	}

	public AspNetHostingPermission(AspNetHostingPermissionLevel level)
	{
		VerifyAspNetHostingPermissionLevel(level, "level");
		_level = level;
	}

	public bool IsUnrestricted()
	{
		return _level == AspNetHostingPermissionLevel.Unrestricted;
	}

	public override IPermission Copy()
	{
		return new AspNetHostingPermission(_level);
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		if (target.GetType() != typeof(AspNetHostingPermission))
		{
			throw new ArgumentException(SR.GetString("InvalidArgument", (target == null) ? "null" : target.ToString(), "target"));
		}
		AspNetHostingPermission aspNetHostingPermission = (AspNetHostingPermission)target;
		if (Level >= aspNetHostingPermission.Level)
		{
			return new AspNetHostingPermission(Level);
		}
		return new AspNetHostingPermission(aspNetHostingPermission.Level);
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (target.GetType() != typeof(AspNetHostingPermission))
		{
			throw new ArgumentException(SR.GetString("InvalidArgument", (target == null) ? "null" : target.ToString(), "target"));
		}
		AspNetHostingPermission aspNetHostingPermission = (AspNetHostingPermission)target;
		if (Level <= aspNetHostingPermission.Level)
		{
			return new AspNetHostingPermission(Level);
		}
		return new AspNetHostingPermission(aspNetHostingPermission.Level);
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return _level == AspNetHostingPermissionLevel.None;
		}
		if (target.GetType() != typeof(AspNetHostingPermission))
		{
			throw new ArgumentException(SR.GetString("InvalidArgument", (target == null) ? "null" : target.ToString(), "target"));
		}
		AspNetHostingPermission aspNetHostingPermission = (AspNetHostingPermission)target;
		return Level <= aspNetHostingPermission.Level;
	}

	public override void FromXml(SecurityElement securityElement)
	{
		if (securityElement == null)
		{
			throw new ArgumentNullException(SR.GetString("AspNetHostingPermissionBadXml", "securityElement"));
		}
		if (!securityElement.Tag.Equals("IPermission"))
		{
			throw new ArgumentException(SR.GetString("AspNetHostingPermissionBadXml", "securityElement"));
		}
		string text = securityElement.Attribute("class");
		if (text == null)
		{
			throw new ArgumentException(SR.GetString("AspNetHostingPermissionBadXml", "securityElement"));
		}
		if (text.IndexOf(GetType().FullName, StringComparison.Ordinal) < 0)
		{
			throw new ArgumentException(SR.GetString("AspNetHostingPermissionBadXml", "securityElement"));
		}
		string strA = securityElement.Attribute("version");
		if (string.Compare(strA, "1", StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw new ArgumentException(SR.GetString("AspNetHostingPermissionBadXml", "version"));
		}
		string text2 = securityElement.Attribute("Level");
		if (text2 == null)
		{
			_level = AspNetHostingPermissionLevel.None;
		}
		else
		{
			_level = (AspNetHostingPermissionLevel)Enum.Parse(typeof(AspNetHostingPermissionLevel), text2);
		}
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("IPermission");
		securityElement.AddAttribute("class", GetType().FullName + ", " + GetType().Module.Assembly.FullName.Replace('"', '\''));
		securityElement.AddAttribute("version", "1");
		securityElement.AddAttribute("Level", Enum.GetName(typeof(AspNetHostingPermissionLevel), _level));
		if (IsUnrestricted())
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		return securityElement;
	}
}
