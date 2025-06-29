using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class SecurityPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
{
	private SecurityPermissionFlag m_flags;

	private const string _strHeaderAssertion = "Assertion";

	private const string _strHeaderUnmanagedCode = "UnmanagedCode";

	private const string _strHeaderExecution = "Execution";

	private const string _strHeaderSkipVerification = "SkipVerification";

	private const string _strHeaderControlThread = "ControlThread";

	private const string _strHeaderControlEvidence = "ControlEvidence";

	private const string _strHeaderControlPolicy = "ControlPolicy";

	private const string _strHeaderSerializationFormatter = "SerializationFormatter";

	private const string _strHeaderControlDomainPolicy = "ControlDomainPolicy";

	private const string _strHeaderControlPrincipal = "ControlPrincipal";

	private const string _strHeaderControlAppDomain = "ControlAppDomain";

	public SecurityPermissionFlag Flags
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

	public SecurityPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			SetUnrestricted(unrestricted: true);
			break;
		case PermissionState.None:
			SetUnrestricted(unrestricted: false);
			Reset();
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public SecurityPermission(SecurityPermissionFlag flag)
	{
		VerifyAccess(flag);
		SetUnrestricted(unrestricted: false);
		m_flags = flag;
	}

	private void SetUnrestricted(bool unrestricted)
	{
		if (unrestricted)
		{
			m_flags = SecurityPermissionFlag.AllFlags;
		}
	}

	private void Reset()
	{
		m_flags = SecurityPermissionFlag.NoFlags;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return m_flags == SecurityPermissionFlag.NoFlags;
		}
		if (target is SecurityPermission securityPermission)
		{
			return (m_flags & ~securityPermission.m_flags) == 0;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		if (!VerifyType(target))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		SecurityPermission securityPermission = (SecurityPermission)target;
		if (securityPermission.IsUnrestricted() || IsUnrestricted())
		{
			return new SecurityPermission(PermissionState.Unrestricted);
		}
		SecurityPermissionFlag flag = m_flags | securityPermission.m_flags;
		return new SecurityPermission(flag);
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
		SecurityPermission securityPermission = (SecurityPermission)target;
		SecurityPermissionFlag securityPermissionFlag = SecurityPermissionFlag.NoFlags;
		if (!securityPermission.IsUnrestricted())
		{
			securityPermissionFlag = ((!IsUnrestricted()) ? (m_flags & securityPermission.m_flags) : securityPermission.m_flags);
		}
		else
		{
			if (IsUnrestricted())
			{
				return new SecurityPermission(PermissionState.Unrestricted);
			}
			securityPermissionFlag = m_flags;
		}
		if (securityPermissionFlag == SecurityPermissionFlag.NoFlags)
		{
			return null;
		}
		return new SecurityPermission(securityPermissionFlag);
	}

	public override IPermission Copy()
	{
		if (IsUnrestricted())
		{
			return new SecurityPermission(PermissionState.Unrestricted);
		}
		return new SecurityPermission(m_flags);
	}

	public bool IsUnrestricted()
	{
		return m_flags == SecurityPermissionFlag.AllFlags;
	}

	private void VerifyAccess(SecurityPermissionFlag type)
	{
		if ((type & ~SecurityPermissionFlag.AllFlags) != SecurityPermissionFlag.NoFlags)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)type));
		}
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.SecurityPermission");
		if (!IsUnrestricted())
		{
			securityElement.AddAttribute("Flags", XMLUtil.BitFieldEnumToString(typeof(SecurityPermissionFlag), m_flags));
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
			m_flags = SecurityPermissionFlag.AllFlags;
			return;
		}
		Reset();
		SetUnrestricted(unrestricted: false);
		string text = esd.Attribute("Flags");
		if (text != null)
		{
			m_flags = (SecurityPermissionFlag)Enum.Parse(typeof(SecurityPermissionFlag), text);
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 6;
	}
}
