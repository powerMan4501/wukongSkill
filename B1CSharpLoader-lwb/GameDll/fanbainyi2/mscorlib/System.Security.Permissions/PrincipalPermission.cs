using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Security.Principal;
using System.Security.Util;
using System.Threading;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class PrincipalPermission : IPermission, ISecurityEncodable, IUnrestrictedPermission, IBuiltInPermission
{
	private IDRole[] m_array;

	public PrincipalPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			m_array = new IDRole[1];
			m_array[0] = new IDRole();
			m_array[0].m_authenticated = true;
			m_array[0].m_id = null;
			m_array[0].m_role = null;
			break;
		case PermissionState.None:
			m_array = new IDRole[1];
			m_array[0] = new IDRole();
			m_array[0].m_authenticated = false;
			m_array[0].m_id = "";
			m_array[0].m_role = "";
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public PrincipalPermission(string name, string role)
	{
		m_array = new IDRole[1];
		m_array[0] = new IDRole();
		m_array[0].m_authenticated = true;
		m_array[0].m_id = name;
		m_array[0].m_role = role;
	}

	public PrincipalPermission(string name, string role, bool isAuthenticated)
	{
		m_array = new IDRole[1];
		m_array[0] = new IDRole();
		m_array[0].m_authenticated = isAuthenticated;
		m_array[0].m_id = name;
		m_array[0].m_role = role;
	}

	private PrincipalPermission(IDRole[] array)
	{
		m_array = array;
	}

	private bool IsEmpty()
	{
		for (int i = 0; i < m_array.Length; i++)
		{
			if (m_array[i].m_id == null || !m_array[i].m_id.Equals("") || m_array[i].m_role == null || !m_array[i].m_role.Equals("") || m_array[i].m_authenticated)
			{
				return false;
			}
		}
		return true;
	}

	private bool VerifyType(IPermission perm)
	{
		if (perm == null || perm.GetType() != GetType())
		{
			return false;
		}
		return true;
	}

	public bool IsUnrestricted()
	{
		for (int i = 0; i < m_array.Length; i++)
		{
			if (m_array[i].m_id != null || m_array[i].m_role != null || !m_array[i].m_authenticated)
			{
				return false;
			}
		}
		return true;
	}

	public bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return IsEmpty();
		}
		try
		{
			PrincipalPermission principalPermission = (PrincipalPermission)target;
			if (principalPermission.IsUnrestricted())
			{
				return true;
			}
			if (IsUnrestricted())
			{
				return false;
			}
			for (int i = 0; i < m_array.Length; i++)
			{
				bool flag = false;
				for (int j = 0; j < principalPermission.m_array.Length; j++)
				{
					if (principalPermission.m_array[j].m_authenticated == m_array[i].m_authenticated && (principalPermission.m_array[j].m_id == null || (m_array[i].m_id != null && m_array[i].m_id.Equals(principalPermission.m_array[j].m_id))) && (principalPermission.m_array[j].m_role == null || (m_array[i].m_role != null && m_array[i].m_role.Equals(principalPermission.m_array[j].m_role))))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
	}

	public IPermission Intersect(IPermission target)
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
		PrincipalPermission principalPermission = (PrincipalPermission)target;
		if (principalPermission.IsUnrestricted())
		{
			return Copy();
		}
		List<IDRole> list = null;
		for (int i = 0; i < m_array.Length; i++)
		{
			for (int j = 0; j < principalPermission.m_array.Length; j++)
			{
				if (principalPermission.m_array[j].m_authenticated != m_array[i].m_authenticated)
				{
					continue;
				}
				if (principalPermission.m_array[j].m_id == null || m_array[i].m_id == null || m_array[i].m_id.Equals(principalPermission.m_array[j].m_id))
				{
					if (list == null)
					{
						list = new List<IDRole>();
					}
					IDRole iDRole = new IDRole();
					iDRole.m_id = ((principalPermission.m_array[j].m_id == null) ? m_array[i].m_id : principalPermission.m_array[j].m_id);
					if (principalPermission.m_array[j].m_role == null || m_array[i].m_role == null || m_array[i].m_role.Equals(principalPermission.m_array[j].m_role))
					{
						iDRole.m_role = ((principalPermission.m_array[j].m_role == null) ? m_array[i].m_role : principalPermission.m_array[j].m_role);
					}
					else
					{
						iDRole.m_role = "";
					}
					iDRole.m_authenticated = principalPermission.m_array[j].m_authenticated;
					list.Add(iDRole);
				}
				else if (principalPermission.m_array[j].m_role == null || m_array[i].m_role == null || m_array[i].m_role.Equals(principalPermission.m_array[j].m_role))
				{
					if (list == null)
					{
						list = new List<IDRole>();
					}
					IDRole iDRole2 = new IDRole();
					iDRole2.m_id = "";
					iDRole2.m_role = ((principalPermission.m_array[j].m_role == null) ? m_array[i].m_role : principalPermission.m_array[j].m_role);
					iDRole2.m_authenticated = principalPermission.m_array[j].m_authenticated;
					list.Add(iDRole2);
				}
			}
		}
		if (list == null)
		{
			return null;
		}
		IDRole[] array = new IDRole[list.Count];
		IEnumerator enumerator = list.GetEnumerator();
		int num = 0;
		while (enumerator.MoveNext())
		{
			array[num++] = (IDRole)enumerator.Current;
		}
		return new PrincipalPermission(array);
	}

	public IPermission Union(IPermission other)
	{
		if (other == null)
		{
			return Copy();
		}
		if (!VerifyType(other))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		PrincipalPermission principalPermission = (PrincipalPermission)other;
		if (IsUnrestricted() || principalPermission.IsUnrestricted())
		{
			return new PrincipalPermission(PermissionState.Unrestricted);
		}
		int num = m_array.Length + principalPermission.m_array.Length;
		IDRole[] array = new IDRole[num];
		int i;
		for (i = 0; i < m_array.Length; i++)
		{
			array[i] = m_array[i];
		}
		for (int j = 0; j < principalPermission.m_array.Length; j++)
		{
			array[i + j] = principalPermission.m_array[j];
		}
		return new PrincipalPermission(array);
	}

	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		IPermission permission = obj as IPermission;
		if (obj != null && permission == null)
		{
			return false;
		}
		if (!IsSubsetOf(permission))
		{
			return false;
		}
		if (permission != null && !permission.IsSubsetOf(this))
		{
			return false;
		}
		return true;
	}

	[ComVisible(false)]
	public override int GetHashCode()
	{
		int num = 0;
		for (int i = 0; i < m_array.Length; i++)
		{
			num += m_array[i].GetHashCode();
		}
		return num;
	}

	public IPermission Copy()
	{
		return new PrincipalPermission(m_array);
	}

	[SecurityCritical]
	private void ThrowSecurityException()
	{
		AssemblyName assemblyName = null;
		Evidence evidence = null;
		PermissionSet.s_fullTrust.Assert();
		try
		{
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			assemblyName = callingAssembly.GetName();
			if (callingAssembly != Assembly.GetExecutingAssembly())
			{
				evidence = callingAssembly.Evidence;
			}
		}
		catch
		{
		}
		PermissionSet.RevertAssert();
		throw new SecurityException(Environment.GetResourceString("Security_PrincipalPermission"), assemblyName, null, null, null, SecurityAction.Demand, this, this, evidence);
	}

	[SecuritySafeCritical]
	public void Demand()
	{
		IPrincipal principal = null;
		new SecurityPermission(SecurityPermissionFlag.ControlPrincipal).Assert();
		principal = Thread.CurrentPrincipal;
		if (principal == null)
		{
			ThrowSecurityException();
		}
		if (m_array == null)
		{
			return;
		}
		int num = m_array.Length;
		bool flag = false;
		for (int i = 0; i < num; i++)
		{
			if (m_array[i].m_authenticated)
			{
				IIdentity identity = principal.Identity;
				if (identity.IsAuthenticated && (m_array[i].m_id == null || string.Compare(identity.Name, m_array[i].m_id, StringComparison.OrdinalIgnoreCase) == 0))
				{
					flag = m_array[i].m_role == null || ((!(principal is WindowsPrincipal windowsPrincipal) || !(m_array[i].Sid != null)) ? principal.IsInRole(m_array[i].m_role) : windowsPrincipal.IsInRole(m_array[i].Sid));
					if (flag)
					{
						break;
					}
				}
				continue;
			}
			flag = true;
			break;
		}
		if (!flag)
		{
			ThrowSecurityException();
		}
	}

	public SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("IPermission");
		XMLUtil.AddClassAttribute(securityElement, GetType(), "System.Security.Permissions.PrincipalPermission");
		securityElement.AddAttribute("version", "1");
		int num = m_array.Length;
		for (int i = 0; i < num; i++)
		{
			securityElement.AddChild(m_array[i].ToXml());
		}
		return securityElement;
	}

	public void FromXml(SecurityElement elem)
	{
		CodeAccessPermission.ValidateElement(elem, this);
		if (elem.InternalChildren != null && elem.InternalChildren.Count != 0)
		{
			int count = elem.InternalChildren.Count;
			int num = 0;
			m_array = new IDRole[count];
			IEnumerator enumerator = elem.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IDRole iDRole = new IDRole();
				iDRole.FromXml((SecurityElement)enumerator.Current);
				m_array[num++] = iDRole;
			}
		}
		else
		{
			m_array = new IDRole[0];
		}
	}

	public override string ToString()
	{
		return ToXml().ToString();
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 8;
	}
}
