using System.Globalization;

namespace System.Security.Permissions;

[Serializable]
public sealed class StorePermission : CodeAccessPermission, IUnrestrictedPermission
{
	private StorePermissionFlags m_flags;

	public StorePermissionFlags Flags
	{
		get
		{
			return m_flags;
		}
		set
		{
			VerifyFlags(value);
			m_flags = value;
		}
	}

	public StorePermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			m_flags = StorePermissionFlags.AllFlags;
			break;
		case PermissionState.None:
			m_flags = StorePermissionFlags.NoFlags;
			break;
		default:
			throw new ArgumentException(SR.GetString("Argument_InvalidPermissionState"));
		}
	}

	public StorePermission(StorePermissionFlags flag)
	{
		VerifyFlags(flag);
		m_flags = flag;
	}

	public bool IsUnrestricted()
	{
		return m_flags == StorePermissionFlags.AllFlags;
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		try
		{
			StorePermission storePermission = (StorePermission)target;
			StorePermissionFlags storePermissionFlags = m_flags | storePermission.m_flags;
			if (storePermissionFlags == StorePermissionFlags.NoFlags)
			{
				return null;
			}
			return new StorePermission(storePermissionFlags);
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString("Argument_WrongType"), new object[1] { GetType().FullName }));
		}
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return m_flags == StorePermissionFlags.NoFlags;
		}
		try
		{
			StorePermission storePermission = (StorePermission)target;
			StorePermissionFlags flags = m_flags;
			StorePermissionFlags flags2 = storePermission.m_flags;
			return (flags & flags2) == flags;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString("Argument_WrongType"), new object[1] { GetType().FullName }));
		}
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		try
		{
			StorePermission storePermission = (StorePermission)target;
			StorePermissionFlags storePermissionFlags = storePermission.m_flags & m_flags;
			if (storePermissionFlags == StorePermissionFlags.NoFlags)
			{
				return null;
			}
			return new StorePermission(storePermissionFlags);
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString("Argument_WrongType"), new object[1] { GetType().FullName }));
		}
	}

	public override IPermission Copy()
	{
		return new StorePermission(m_flags);
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("IPermission");
		securityElement.AddAttribute("class", GetType().FullName + ", " + GetType().Module.Assembly.FullName.Replace('"', '\''));
		securityElement.AddAttribute("version", "1");
		if (!IsUnrestricted())
		{
			securityElement.AddAttribute("Flags", m_flags.ToString());
		}
		else
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		return securityElement;
	}

	public override void FromXml(SecurityElement securityElement)
	{
		if (securityElement == null)
		{
			throw new ArgumentNullException("securityElement");
		}
		string text = securityElement.Attribute("class");
		if (text == null || text.IndexOf(GetType().FullName, StringComparison.Ordinal) == -1)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidClassAttribute"), "securityElement");
		}
		string text2 = securityElement.Attribute("Unrestricted");
		if (text2 != null && string.Compare(text2, "true", StringComparison.OrdinalIgnoreCase) == 0)
		{
			m_flags = StorePermissionFlags.AllFlags;
			return;
		}
		m_flags = StorePermissionFlags.NoFlags;
		string text3 = securityElement.Attribute("Flags");
		if (text3 != null)
		{
			StorePermissionFlags flags = (StorePermissionFlags)Enum.Parse(typeof(StorePermissionFlags), text3);
			VerifyFlags(flags);
			m_flags = flags;
		}
	}

	internal static void VerifyFlags(StorePermissionFlags flags)
	{
		if ((flags & ~StorePermissionFlags.AllFlags) != StorePermissionFlags.NoFlags)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString("Arg_EnumIllegalVal"), new object[1] { (int)flags }));
		}
	}
}
