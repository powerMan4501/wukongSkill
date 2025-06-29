using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class ReflectionPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
{
	internal const ReflectionPermissionFlag AllFlagsAndMore = ReflectionPermissionFlag.AllFlags | ReflectionPermissionFlag.RestrictedMemberAccess;

	private ReflectionPermissionFlag m_flags;

	public ReflectionPermissionFlag Flags
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

	public ReflectionPermission(PermissionState state)
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
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public ReflectionPermission(ReflectionPermissionFlag flag)
	{
		VerifyAccess(flag);
		SetUnrestricted(unrestricted: false);
		m_flags = flag;
	}

	private void SetUnrestricted(bool unrestricted)
	{
		if (unrestricted)
		{
			m_flags = ReflectionPermissionFlag.AllFlags | ReflectionPermissionFlag.RestrictedMemberAccess;
		}
		else
		{
			Reset();
		}
	}

	private void Reset()
	{
		m_flags = ReflectionPermissionFlag.NoFlags;
	}

	public bool IsUnrestricted()
	{
		return m_flags == (ReflectionPermissionFlag.AllFlags | ReflectionPermissionFlag.RestrictedMemberAccess);
	}

	public override IPermission Union(IPermission other)
	{
		if (other == null)
		{
			return Copy();
		}
		if (!VerifyType(other))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		ReflectionPermission reflectionPermission = (ReflectionPermission)other;
		if (IsUnrestricted() || reflectionPermission.IsUnrestricted())
		{
			return new ReflectionPermission(PermissionState.Unrestricted);
		}
		ReflectionPermissionFlag flag = m_flags | reflectionPermission.m_flags;
		return new ReflectionPermission(flag);
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return m_flags == ReflectionPermissionFlag.NoFlags;
		}
		try
		{
			ReflectionPermission reflectionPermission = (ReflectionPermission)target;
			if (reflectionPermission.IsUnrestricted())
			{
				return true;
			}
			if (IsUnrestricted())
			{
				return false;
			}
			return (m_flags & ~reflectionPermission.m_flags) == 0;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!VerifyType(target))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		ReflectionPermission reflectionPermission = (ReflectionPermission)target;
		ReflectionPermissionFlag reflectionPermissionFlag = reflectionPermission.m_flags & m_flags;
		if (reflectionPermissionFlag == ReflectionPermissionFlag.NoFlags)
		{
			return null;
		}
		return new ReflectionPermission(reflectionPermissionFlag);
	}

	public override IPermission Copy()
	{
		if (IsUnrestricted())
		{
			return new ReflectionPermission(PermissionState.Unrestricted);
		}
		return new ReflectionPermission(m_flags);
	}

	private void VerifyAccess(ReflectionPermissionFlag type)
	{
		if ((type & ~(ReflectionPermissionFlag.AllFlags | ReflectionPermissionFlag.RestrictedMemberAccess)) != ReflectionPermissionFlag.NoFlags)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)type));
		}
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.ReflectionPermission");
		if (!IsUnrestricted())
		{
			securityElement.AddAttribute("Flags", XMLUtil.BitFieldEnumToString(typeof(ReflectionPermissionFlag), m_flags));
		}
		else
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		return securityElement;
	}

	public override void FromXml(SecurityElement esd)
	{
		CodeAccessPermission.ValidateElement(esd, this);
		if (XMLUtil.IsUnrestricted(esd))
		{
			m_flags = ReflectionPermissionFlag.AllFlags | ReflectionPermissionFlag.RestrictedMemberAccess;
			return;
		}
		Reset();
		SetUnrestricted(unrestricted: false);
		string text = esd.Attribute("Flags");
		if (text != null)
		{
			m_flags = (ReflectionPermissionFlag)Enum.Parse(typeof(ReflectionPermissionFlag), text);
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 4;
	}
}
