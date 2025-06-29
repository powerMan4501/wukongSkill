using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class EnvironmentPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
{
	private StringExpressionSet m_read;

	private StringExpressionSet m_write;

	private bool m_unrestricted;

	public EnvironmentPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			m_unrestricted = true;
			break;
		case PermissionState.None:
			m_unrestricted = false;
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public EnvironmentPermission(EnvironmentPermissionAccess flag, string pathList)
	{
		SetPathList(flag, pathList);
	}

	public void SetPathList(EnvironmentPermissionAccess flag, string pathList)
	{
		VerifyFlag(flag);
		m_unrestricted = false;
		if ((flag & EnvironmentPermissionAccess.Read) != EnvironmentPermissionAccess.NoAccess)
		{
			m_read = null;
		}
		if ((flag & EnvironmentPermissionAccess.Write) != EnvironmentPermissionAccess.NoAccess)
		{
			m_write = null;
		}
		AddPathList(flag, pathList);
	}

	[SecuritySafeCritical]
	public void AddPathList(EnvironmentPermissionAccess flag, string pathList)
	{
		VerifyFlag(flag);
		if (FlagIsSet(flag, EnvironmentPermissionAccess.Read))
		{
			if (m_read == null)
			{
				m_read = new EnvironmentStringExpressionSet();
			}
			m_read.AddExpressions(pathList);
		}
		if (FlagIsSet(flag, EnvironmentPermissionAccess.Write))
		{
			if (m_write == null)
			{
				m_write = new EnvironmentStringExpressionSet();
			}
			m_write.AddExpressions(pathList);
		}
	}

	public string GetPathList(EnvironmentPermissionAccess flag)
	{
		VerifyFlag(flag);
		ExclusiveFlag(flag);
		if (FlagIsSet(flag, EnvironmentPermissionAccess.Read))
		{
			if (m_read == null)
			{
				return "";
			}
			return m_read.ToString();
		}
		if (FlagIsSet(flag, EnvironmentPermissionAccess.Write))
		{
			if (m_write == null)
			{
				return "";
			}
			return m_write.ToString();
		}
		return "";
	}

	private void VerifyFlag(EnvironmentPermissionAccess flag)
	{
		if ((flag & ~EnvironmentPermissionAccess.AllAccess) != EnvironmentPermissionAccess.NoAccess)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)flag));
		}
	}

	private void ExclusiveFlag(EnvironmentPermissionAccess flag)
	{
		if (flag == EnvironmentPermissionAccess.NoAccess)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumNotSingleFlag"));
		}
		if ((flag & (flag - 1)) != EnvironmentPermissionAccess.NoAccess)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumNotSingleFlag"));
		}
	}

	private bool FlagIsSet(EnvironmentPermissionAccess flag, EnvironmentPermissionAccess question)
	{
		return (flag & question) != 0;
	}

	private bool IsEmpty()
	{
		if (!m_unrestricted && (m_read == null || m_read.IsEmpty()))
		{
			if (m_write != null)
			{
				return m_write.IsEmpty();
			}
			return true;
		}
		return false;
	}

	public bool IsUnrestricted()
	{
		return m_unrestricted;
	}

	[SecuritySafeCritical]
	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return IsEmpty();
		}
		try
		{
			EnvironmentPermission environmentPermission = (EnvironmentPermission)target;
			if (environmentPermission.IsUnrestricted())
			{
				return true;
			}
			if (IsUnrestricted())
			{
				return false;
			}
			return (m_read == null || m_read.IsSubsetOf(environmentPermission.m_read)) && (m_write == null || m_write.IsSubsetOf(environmentPermission.m_write));
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
	}

	[SecuritySafeCritical]
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
		if (IsUnrestricted())
		{
			return target.Copy();
		}
		EnvironmentPermission environmentPermission = (EnvironmentPermission)target;
		if (environmentPermission.IsUnrestricted())
		{
			return Copy();
		}
		StringExpressionSet stringExpressionSet = ((m_read == null) ? null : m_read.Intersect(environmentPermission.m_read));
		StringExpressionSet stringExpressionSet2 = ((m_write == null) ? null : m_write.Intersect(environmentPermission.m_write));
		if ((stringExpressionSet == null || stringExpressionSet.IsEmpty()) && (stringExpressionSet2 == null || stringExpressionSet2.IsEmpty()))
		{
			return null;
		}
		EnvironmentPermission environmentPermission2 = new EnvironmentPermission(PermissionState.None);
		environmentPermission2.m_unrestricted = false;
		environmentPermission2.m_read = stringExpressionSet;
		environmentPermission2.m_write = stringExpressionSet2;
		return environmentPermission2;
	}

	[SecuritySafeCritical]
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
		EnvironmentPermission environmentPermission = (EnvironmentPermission)other;
		if (IsUnrestricted() || environmentPermission.IsUnrestricted())
		{
			return new EnvironmentPermission(PermissionState.Unrestricted);
		}
		StringExpressionSet stringExpressionSet = ((m_read == null) ? environmentPermission.m_read : m_read.Union(environmentPermission.m_read));
		StringExpressionSet stringExpressionSet2 = ((m_write == null) ? environmentPermission.m_write : m_write.Union(environmentPermission.m_write));
		if ((stringExpressionSet == null || stringExpressionSet.IsEmpty()) && (stringExpressionSet2 == null || stringExpressionSet2.IsEmpty()))
		{
			return null;
		}
		EnvironmentPermission environmentPermission2 = new EnvironmentPermission(PermissionState.None);
		environmentPermission2.m_unrestricted = false;
		environmentPermission2.m_read = stringExpressionSet;
		environmentPermission2.m_write = stringExpressionSet2;
		return environmentPermission2;
	}

	public override IPermission Copy()
	{
		EnvironmentPermission environmentPermission = new EnvironmentPermission(PermissionState.None);
		if (m_unrestricted)
		{
			environmentPermission.m_unrestricted = true;
		}
		else
		{
			environmentPermission.m_unrestricted = false;
			if (m_read != null)
			{
				environmentPermission.m_read = m_read.Copy();
			}
			if (m_write != null)
			{
				environmentPermission.m_write = m_write.Copy();
			}
		}
		return environmentPermission;
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.EnvironmentPermission");
		if (!IsUnrestricted())
		{
			if (m_read != null && !m_read.IsEmpty())
			{
				securityElement.AddAttribute("Read", SecurityElement.Escape(m_read.ToString()));
			}
			if (m_write != null && !m_write.IsEmpty())
			{
				securityElement.AddAttribute("Write", SecurityElement.Escape(m_write.ToString()));
			}
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
			m_unrestricted = true;
			return;
		}
		m_unrestricted = false;
		m_read = null;
		m_write = null;
		string text = esd.Attribute("Read");
		if (text != null)
		{
			m_read = new EnvironmentStringExpressionSet(text);
		}
		text = esd.Attribute("Write");
		if (text != null)
		{
			m_write = new EnvironmentStringExpressionSet(text);
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 0;
	}
}
