using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
internal sealed class HostProtectionPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
{
	internal static volatile HostProtectionResource protectedResources;

	private HostProtectionResource m_resources;

	public HostProtectionResource Resources
	{
		get
		{
			return m_resources;
		}
		set
		{
			if (value < HostProtectionResource.None || value > HostProtectionResource.All)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)value));
			}
			m_resources = value;
		}
	}

	public HostProtectionPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			Resources = HostProtectionResource.All;
			break;
		case PermissionState.None:
			Resources = HostProtectionResource.None;
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public HostProtectionPermission(HostProtectionResource resources)
	{
		Resources = resources;
	}

	public bool IsUnrestricted()
	{
		return Resources == HostProtectionResource.All;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return m_resources == HostProtectionResource.None;
		}
		if (GetType() != target.GetType())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		return (m_resources & ((HostProtectionPermission)target).m_resources) == m_resources;
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		if (GetType() != target.GetType())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		HostProtectionResource resources = m_resources | ((HostProtectionPermission)target).m_resources;
		return new HostProtectionPermission(resources);
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (GetType() != target.GetType())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		HostProtectionResource hostProtectionResource = m_resources & ((HostProtectionPermission)target).m_resources;
		if (hostProtectionResource == HostProtectionResource.None)
		{
			return null;
		}
		return new HostProtectionPermission(hostProtectionResource);
	}

	public override IPermission Copy()
	{
		return new HostProtectionPermission(m_resources);
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, GetType().FullName);
		if (IsUnrestricted())
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		else
		{
			securityElement.AddAttribute("Resources", XMLUtil.BitFieldEnumToString(typeof(HostProtectionResource), Resources));
		}
		return securityElement;
	}

	public override void FromXml(SecurityElement esd)
	{
		CodeAccessPermission.ValidateElement(esd, this);
		if (XMLUtil.IsUnrestricted(esd))
		{
			Resources = HostProtectionResource.All;
			return;
		}
		string text = esd.Attribute("Resources");
		if (text == null)
		{
			Resources = HostProtectionResource.None;
		}
		else
		{
			Resources = (HostProtectionResource)Enum.Parse(typeof(HostProtectionResource), text);
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 9;
	}
}
