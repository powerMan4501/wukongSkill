using System.Globalization;

namespace System.Security.Permissions;

[Serializable]
public sealed class TypeDescriptorPermission : CodeAccessPermission, IUnrestrictedPermission
{
	private TypeDescriptorPermissionFlags m_flags;

	public TypeDescriptorPermissionFlags Flags
	{
		get
		{
			return m_flags;
		}
		set
		{
			VerifyAccess(value);
			m_flags = value;
		}
	}

	public TypeDescriptorPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			SetUnrestricted(unrestricted: true);
			break;
		case PermissionState.None:
			SetUnrestricted(unrestricted: false);
			break;
		default:
			throw new ArgumentException(SR.GetString("Argument_InvalidPermissionState"));
		}
	}

	public TypeDescriptorPermission(TypeDescriptorPermissionFlags flag)
	{
		VerifyAccess(flag);
		SetUnrestricted(unrestricted: false);
		m_flags = flag;
	}

	private void SetUnrestricted(bool unrestricted)
	{
		if (unrestricted)
		{
			m_flags = TypeDescriptorPermissionFlags.RestrictedRegistrationAccess;
		}
		else
		{
			Reset();
		}
	}

	private void Reset()
	{
		m_flags = TypeDescriptorPermissionFlags.NoFlags;
	}

	public bool IsUnrestricted()
	{
		return m_flags == TypeDescriptorPermissionFlags.RestrictedRegistrationAccess;
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		try
		{
			TypeDescriptorPermission typeDescriptorPermission = (TypeDescriptorPermission)target;
			TypeDescriptorPermissionFlags typeDescriptorPermissionFlags = m_flags | typeDescriptorPermission.m_flags;
			if (typeDescriptorPermissionFlags == TypeDescriptorPermissionFlags.NoFlags)
			{
				return null;
			}
			return new TypeDescriptorPermission(typeDescriptorPermissionFlags);
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
			return m_flags == TypeDescriptorPermissionFlags.NoFlags;
		}
		try
		{
			TypeDescriptorPermission typeDescriptorPermission = (TypeDescriptorPermission)target;
			TypeDescriptorPermissionFlags flags = m_flags;
			TypeDescriptorPermissionFlags flags2 = typeDescriptorPermission.m_flags;
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
			TypeDescriptorPermission typeDescriptorPermission = (TypeDescriptorPermission)target;
			TypeDescriptorPermissionFlags typeDescriptorPermissionFlags = typeDescriptorPermission.m_flags & m_flags;
			if (typeDescriptorPermissionFlags == TypeDescriptorPermissionFlags.NoFlags)
			{
				return null;
			}
			return new TypeDescriptorPermission(typeDescriptorPermissionFlags);
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString("Argument_WrongType"), new object[1] { GetType().FullName }));
		}
	}

	public override IPermission Copy()
	{
		return new TypeDescriptorPermission(m_flags);
	}

	private void VerifyAccess(TypeDescriptorPermissionFlags type)
	{
		if ((type & ~TypeDescriptorPermissionFlags.RestrictedRegistrationAccess) != TypeDescriptorPermissionFlags.NoFlags)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString("Arg_EnumIllegalVal"), new object[1] { (int)type }));
		}
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
			m_flags = TypeDescriptorPermissionFlags.RestrictedRegistrationAccess;
			return;
		}
		m_flags = TypeDescriptorPermissionFlags.NoFlags;
		string text3 = securityElement.Attribute("Flags");
		if (text3 != null)
		{
			TypeDescriptorPermissionFlags flags = (TypeDescriptorPermissionFlags)Enum.Parse(typeof(TypeDescriptorPermissionFlags), text3);
			VerifyFlags(flags);
			m_flags = flags;
		}
	}

	internal static void VerifyFlags(TypeDescriptorPermissionFlags flags)
	{
		if ((flags & ~TypeDescriptorPermissionFlags.RestrictedRegistrationAccess) != TypeDescriptorPermissionFlags.NoFlags)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString("Arg_EnumIllegalVal"), new object[1] { (int)flags }));
		}
	}
}
