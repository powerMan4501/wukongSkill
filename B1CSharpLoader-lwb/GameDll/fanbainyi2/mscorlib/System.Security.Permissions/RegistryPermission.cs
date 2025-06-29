using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class RegistryPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
{
	private StringExpressionSet m_read;

	private StringExpressionSet m_write;

	private StringExpressionSet m_create;

	[OptionalField(VersionAdded = 2)]
	private StringExpressionSet m_viewAcl;

	[OptionalField(VersionAdded = 2)]
	private StringExpressionSet m_changeAcl;

	private bool m_unrestricted;

	public RegistryPermission(PermissionState state)
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

	public RegistryPermission(RegistryPermissionAccess access, string pathList)
	{
		SetPathList(access, pathList);
	}

	public RegistryPermission(RegistryPermissionAccess access, AccessControlActions control, string pathList)
	{
		m_unrestricted = false;
		AddPathList(access, control, pathList);
	}

	public void SetPathList(RegistryPermissionAccess access, string pathList)
	{
		VerifyAccess(access);
		m_unrestricted = false;
		if ((access & RegistryPermissionAccess.Read) != RegistryPermissionAccess.NoAccess)
		{
			m_read = null;
		}
		if ((access & RegistryPermissionAccess.Write) != RegistryPermissionAccess.NoAccess)
		{
			m_write = null;
		}
		if ((access & RegistryPermissionAccess.Create) != RegistryPermissionAccess.NoAccess)
		{
			m_create = null;
		}
		AddPathList(access, pathList);
	}

	internal void SetPathList(AccessControlActions control, string pathList)
	{
		m_unrestricted = false;
		if ((control & AccessControlActions.View) != AccessControlActions.None)
		{
			m_viewAcl = null;
		}
		if ((control & AccessControlActions.Change) != AccessControlActions.None)
		{
			m_changeAcl = null;
		}
		AddPathList(RegistryPermissionAccess.NoAccess, control, pathList);
	}

	public void AddPathList(RegistryPermissionAccess access, string pathList)
	{
		AddPathList(access, AccessControlActions.None, pathList);
	}

	[SecuritySafeCritical]
	public void AddPathList(RegistryPermissionAccess access, AccessControlActions control, string pathList)
	{
		VerifyAccess(access);
		if ((access & RegistryPermissionAccess.Read) != RegistryPermissionAccess.NoAccess)
		{
			if (m_read == null)
			{
				m_read = new StringExpressionSet();
			}
			m_read.AddExpressions(pathList);
		}
		if ((access & RegistryPermissionAccess.Write) != RegistryPermissionAccess.NoAccess)
		{
			if (m_write == null)
			{
				m_write = new StringExpressionSet();
			}
			m_write.AddExpressions(pathList);
		}
		if ((access & RegistryPermissionAccess.Create) != RegistryPermissionAccess.NoAccess)
		{
			if (m_create == null)
			{
				m_create = new StringExpressionSet();
			}
			m_create.AddExpressions(pathList);
		}
		if ((control & AccessControlActions.View) != AccessControlActions.None)
		{
			if (m_viewAcl == null)
			{
				m_viewAcl = new StringExpressionSet();
			}
			m_viewAcl.AddExpressions(pathList);
		}
		if ((control & AccessControlActions.Change) != AccessControlActions.None)
		{
			if (m_changeAcl == null)
			{
				m_changeAcl = new StringExpressionSet();
			}
			m_changeAcl.AddExpressions(pathList);
		}
	}

	[SecuritySafeCritical]
	public string GetPathList(RegistryPermissionAccess access)
	{
		VerifyAccess(access);
		ExclusiveAccess(access);
		if ((access & RegistryPermissionAccess.Read) != RegistryPermissionAccess.NoAccess)
		{
			if (m_read == null)
			{
				return "";
			}
			return m_read.UnsafeToString();
		}
		if ((access & RegistryPermissionAccess.Write) != RegistryPermissionAccess.NoAccess)
		{
			if (m_write == null)
			{
				return "";
			}
			return m_write.UnsafeToString();
		}
		if ((access & RegistryPermissionAccess.Create) != RegistryPermissionAccess.NoAccess)
		{
			if (m_create == null)
			{
				return "";
			}
			return m_create.UnsafeToString();
		}
		return "";
	}

	private void VerifyAccess(RegistryPermissionAccess access)
	{
		if ((access & ~RegistryPermissionAccess.AllAccess) != RegistryPermissionAccess.NoAccess)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)access));
		}
	}

	private void ExclusiveAccess(RegistryPermissionAccess access)
	{
		if (access == RegistryPermissionAccess.NoAccess)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumNotSingleFlag"));
		}
		if ((access & (access - 1)) != RegistryPermissionAccess.NoAccess)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumNotSingleFlag"));
		}
	}

	private bool IsEmpty()
	{
		if (!m_unrestricted && (m_read == null || m_read.IsEmpty()) && (m_write == null || m_write.IsEmpty()) && (m_create == null || m_create.IsEmpty()) && (m_viewAcl == null || m_viewAcl.IsEmpty()))
		{
			if (m_changeAcl != null)
			{
				return m_changeAcl.IsEmpty();
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
		if (!(target is RegistryPermission registryPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (registryPermission.IsUnrestricted())
		{
			return true;
		}
		if (IsUnrestricted())
		{
			return false;
		}
		if ((m_read == null || m_read.IsSubsetOf(registryPermission.m_read)) && (m_write == null || m_write.IsSubsetOf(registryPermission.m_write)) && (m_create == null || m_create.IsSubsetOf(registryPermission.m_create)) && (m_viewAcl == null || m_viewAcl.IsSubsetOf(registryPermission.m_viewAcl)))
		{
			if (m_changeAcl != null)
			{
				return m_changeAcl.IsSubsetOf(registryPermission.m_changeAcl);
			}
			return true;
		}
		return false;
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
		RegistryPermission registryPermission = (RegistryPermission)target;
		if (registryPermission.IsUnrestricted())
		{
			return Copy();
		}
		StringExpressionSet stringExpressionSet = ((m_read == null) ? null : m_read.Intersect(registryPermission.m_read));
		StringExpressionSet stringExpressionSet2 = ((m_write == null) ? null : m_write.Intersect(registryPermission.m_write));
		StringExpressionSet stringExpressionSet3 = ((m_create == null) ? null : m_create.Intersect(registryPermission.m_create));
		StringExpressionSet stringExpressionSet4 = ((m_viewAcl == null) ? null : m_viewAcl.Intersect(registryPermission.m_viewAcl));
		StringExpressionSet stringExpressionSet5 = ((m_changeAcl == null) ? null : m_changeAcl.Intersect(registryPermission.m_changeAcl));
		if ((stringExpressionSet == null || stringExpressionSet.IsEmpty()) && (stringExpressionSet2 == null || stringExpressionSet2.IsEmpty()) && (stringExpressionSet3 == null || stringExpressionSet3.IsEmpty()) && (stringExpressionSet4 == null || stringExpressionSet4.IsEmpty()) && (stringExpressionSet5 == null || stringExpressionSet5.IsEmpty()))
		{
			return null;
		}
		RegistryPermission registryPermission2 = new RegistryPermission(PermissionState.None);
		registryPermission2.m_unrestricted = false;
		registryPermission2.m_read = stringExpressionSet;
		registryPermission2.m_write = stringExpressionSet2;
		registryPermission2.m_create = stringExpressionSet3;
		registryPermission2.m_viewAcl = stringExpressionSet4;
		registryPermission2.m_changeAcl = stringExpressionSet5;
		return registryPermission2;
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
		RegistryPermission registryPermission = (RegistryPermission)other;
		if (IsUnrestricted() || registryPermission.IsUnrestricted())
		{
			return new RegistryPermission(PermissionState.Unrestricted);
		}
		StringExpressionSet stringExpressionSet = ((m_read == null) ? registryPermission.m_read : m_read.Union(registryPermission.m_read));
		StringExpressionSet stringExpressionSet2 = ((m_write == null) ? registryPermission.m_write : m_write.Union(registryPermission.m_write));
		StringExpressionSet stringExpressionSet3 = ((m_create == null) ? registryPermission.m_create : m_create.Union(registryPermission.m_create));
		StringExpressionSet stringExpressionSet4 = ((m_viewAcl == null) ? registryPermission.m_viewAcl : m_viewAcl.Union(registryPermission.m_viewAcl));
		StringExpressionSet stringExpressionSet5 = ((m_changeAcl == null) ? registryPermission.m_changeAcl : m_changeAcl.Union(registryPermission.m_changeAcl));
		if ((stringExpressionSet == null || stringExpressionSet.IsEmpty()) && (stringExpressionSet2 == null || stringExpressionSet2.IsEmpty()) && (stringExpressionSet3 == null || stringExpressionSet3.IsEmpty()) && (stringExpressionSet4 == null || stringExpressionSet4.IsEmpty()) && (stringExpressionSet5 == null || stringExpressionSet5.IsEmpty()))
		{
			return null;
		}
		RegistryPermission registryPermission2 = new RegistryPermission(PermissionState.None);
		registryPermission2.m_unrestricted = false;
		registryPermission2.m_read = stringExpressionSet;
		registryPermission2.m_write = stringExpressionSet2;
		registryPermission2.m_create = stringExpressionSet3;
		registryPermission2.m_viewAcl = stringExpressionSet4;
		registryPermission2.m_changeAcl = stringExpressionSet5;
		return registryPermission2;
	}

	public override IPermission Copy()
	{
		RegistryPermission registryPermission = new RegistryPermission(PermissionState.None);
		if (m_unrestricted)
		{
			registryPermission.m_unrestricted = true;
		}
		else
		{
			registryPermission.m_unrestricted = false;
			if (m_read != null)
			{
				registryPermission.m_read = m_read.Copy();
			}
			if (m_write != null)
			{
				registryPermission.m_write = m_write.Copy();
			}
			if (m_create != null)
			{
				registryPermission.m_create = m_create.Copy();
			}
			if (m_viewAcl != null)
			{
				registryPermission.m_viewAcl = m_viewAcl.Copy();
			}
			if (m_changeAcl != null)
			{
				registryPermission.m_changeAcl = m_changeAcl.Copy();
			}
		}
		return registryPermission;
	}

	[SecuritySafeCritical]
	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.RegistryPermission");
		if (!IsUnrestricted())
		{
			if (m_read != null && !m_read.IsEmpty())
			{
				securityElement.AddAttribute("Read", SecurityElement.Escape(m_read.UnsafeToString()));
			}
			if (m_write != null && !m_write.IsEmpty())
			{
				securityElement.AddAttribute("Write", SecurityElement.Escape(m_write.UnsafeToString()));
			}
			if (m_create != null && !m_create.IsEmpty())
			{
				securityElement.AddAttribute("Create", SecurityElement.Escape(m_create.UnsafeToString()));
			}
			if (m_viewAcl != null && !m_viewAcl.IsEmpty())
			{
				securityElement.AddAttribute("ViewAccessControl", SecurityElement.Escape(m_viewAcl.UnsafeToString()));
			}
			if (m_changeAcl != null && !m_changeAcl.IsEmpty())
			{
				securityElement.AddAttribute("ChangeAccessControl", SecurityElement.Escape(m_changeAcl.UnsafeToString()));
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
		m_create = null;
		m_viewAcl = null;
		m_changeAcl = null;
		string text = esd.Attribute("Read");
		if (text != null)
		{
			m_read = new StringExpressionSet(text);
		}
		text = esd.Attribute("Write");
		if (text != null)
		{
			m_write = new StringExpressionSet(text);
		}
		text = esd.Attribute("Create");
		if (text != null)
		{
			m_create = new StringExpressionSet(text);
		}
		text = esd.Attribute("ViewAccessControl");
		if (text != null)
		{
			m_viewAcl = new StringExpressionSet(text);
		}
		text = esd.Attribute("ChangeAccessControl");
		if (text != null)
		{
			m_changeAcl = new StringExpressionSet(text);
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 5;
	}
}
