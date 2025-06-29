using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class StrongNameIdentityPermission : CodeAccessPermission, IBuiltInPermission
{
	private bool m_unrestricted;

	private StrongName2[] m_strongNames;

	public StrongNamePublicKeyBlob PublicKey
	{
		get
		{
			if (m_strongNames == null || m_strongNames.Length == 0)
			{
				return null;
			}
			if (m_strongNames.Length > 1)
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_AmbiguousIdentity"));
			}
			return m_strongNames[0].m_publicKeyBlob;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("PublicKey");
			}
			m_unrestricted = false;
			if (m_strongNames != null && m_strongNames.Length == 1)
			{
				m_strongNames[0].m_publicKeyBlob = value;
				return;
			}
			m_strongNames = new StrongName2[1];
			m_strongNames[0] = new StrongName2(value, "", new Version());
		}
	}

	public string Name
	{
		get
		{
			if (m_strongNames == null || m_strongNames.Length == 0)
			{
				return "";
			}
			if (m_strongNames.Length > 1)
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_AmbiguousIdentity"));
			}
			return m_strongNames[0].m_name;
		}
		set
		{
			if (value != null && value.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"));
			}
			m_unrestricted = false;
			if (m_strongNames != null && m_strongNames.Length == 1)
			{
				m_strongNames[0].m_name = value;
				return;
			}
			m_strongNames = new StrongName2[1];
			m_strongNames[0] = new StrongName2(null, value, new Version());
		}
	}

	public Version Version
	{
		get
		{
			if (m_strongNames == null || m_strongNames.Length == 0)
			{
				return new Version();
			}
			if (m_strongNames.Length > 1)
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_AmbiguousIdentity"));
			}
			return m_strongNames[0].m_version;
		}
		set
		{
			m_unrestricted = false;
			if (m_strongNames != null && m_strongNames.Length == 1)
			{
				m_strongNames[0].m_version = value;
				return;
			}
			m_strongNames = new StrongName2[1];
			m_strongNames[0] = new StrongName2(null, "", value);
		}
	}

	public StrongNameIdentityPermission(PermissionState state)
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

	public StrongNameIdentityPermission(StrongNamePublicKeyBlob blob, string name, Version version)
	{
		if (blob == null)
		{
			throw new ArgumentNullException("blob");
		}
		if (name != null && name.Equals(""))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyStrongName"));
		}
		m_unrestricted = false;
		m_strongNames = new StrongName2[1];
		m_strongNames[0] = new StrongName2(blob, name, version);
	}

	public override IPermission Copy()
	{
		StrongNameIdentityPermission strongNameIdentityPermission = new StrongNameIdentityPermission(PermissionState.None);
		strongNameIdentityPermission.m_unrestricted = m_unrestricted;
		if (m_strongNames != null)
		{
			strongNameIdentityPermission.m_strongNames = new StrongName2[m_strongNames.Length];
			for (int i = 0; i < m_strongNames.Length; i++)
			{
				strongNameIdentityPermission.m_strongNames[i] = m_strongNames[i].Copy();
			}
		}
		return strongNameIdentityPermission;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			if (m_unrestricted)
			{
				return false;
			}
			if (m_strongNames == null)
			{
				return true;
			}
			if (m_strongNames.Length == 0)
			{
				return true;
			}
			return false;
		}
		if (!(target is StrongNameIdentityPermission strongNameIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (strongNameIdentityPermission.m_unrestricted)
		{
			return true;
		}
		if (m_unrestricted)
		{
			return false;
		}
		if (m_strongNames != null)
		{
			StrongName2[] strongNames = m_strongNames;
			foreach (StrongName2 strongName in strongNames)
			{
				bool flag = false;
				if (strongNameIdentityPermission.m_strongNames != null)
				{
					StrongName2[] strongNames2 = strongNameIdentityPermission.m_strongNames;
					foreach (StrongName2 target2 in strongNames2)
					{
						if (strongName.IsSubsetOf(target2))
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					return false;
				}
			}
		}
		return true;
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!(target is StrongNameIdentityPermission strongNameIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (m_unrestricted && strongNameIdentityPermission.m_unrestricted)
		{
			StrongNameIdentityPermission strongNameIdentityPermission2 = new StrongNameIdentityPermission(PermissionState.None);
			strongNameIdentityPermission2.m_unrestricted = true;
			return strongNameIdentityPermission2;
		}
		if (m_unrestricted)
		{
			return strongNameIdentityPermission.Copy();
		}
		if (strongNameIdentityPermission.m_unrestricted)
		{
			return Copy();
		}
		if (m_strongNames == null || strongNameIdentityPermission.m_strongNames == null || m_strongNames.Length == 0 || strongNameIdentityPermission.m_strongNames.Length == 0)
		{
			return null;
		}
		List<StrongName2> list = new List<StrongName2>();
		StrongName2[] strongNames = m_strongNames;
		foreach (StrongName2 strongName in strongNames)
		{
			StrongName2[] strongNames2 = strongNameIdentityPermission.m_strongNames;
			foreach (StrongName2 target2 in strongNames2)
			{
				StrongName2 strongName2 = strongName.Intersect(target2);
				if (strongName2 != null)
				{
					list.Add(strongName2);
				}
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		StrongNameIdentityPermission strongNameIdentityPermission3 = new StrongNameIdentityPermission(PermissionState.None);
		strongNameIdentityPermission3.m_strongNames = list.ToArray();
		return strongNameIdentityPermission3;
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			if ((m_strongNames == null || m_strongNames.Length == 0) && !m_unrestricted)
			{
				return null;
			}
			return Copy();
		}
		if (!(target is StrongNameIdentityPermission strongNameIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (m_unrestricted || strongNameIdentityPermission.m_unrestricted)
		{
			StrongNameIdentityPermission strongNameIdentityPermission2 = new StrongNameIdentityPermission(PermissionState.None);
			strongNameIdentityPermission2.m_unrestricted = true;
			return strongNameIdentityPermission2;
		}
		if (m_strongNames == null || m_strongNames.Length == 0)
		{
			if (strongNameIdentityPermission.m_strongNames == null || strongNameIdentityPermission.m_strongNames.Length == 0)
			{
				return null;
			}
			return strongNameIdentityPermission.Copy();
		}
		if (strongNameIdentityPermission.m_strongNames == null || strongNameIdentityPermission.m_strongNames.Length == 0)
		{
			return Copy();
		}
		List<StrongName2> list = new List<StrongName2>();
		StrongName2[] strongNames = m_strongNames;
		foreach (StrongName2 item in strongNames)
		{
			list.Add(item);
		}
		StrongName2[] strongNames2 = strongNameIdentityPermission.m_strongNames;
		foreach (StrongName2 strongName in strongNames2)
		{
			bool flag = false;
			foreach (StrongName2 item2 in list)
			{
				if (strongName.Equals(item2))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(strongName);
			}
		}
		StrongNameIdentityPermission strongNameIdentityPermission3 = new StrongNameIdentityPermission(PermissionState.None);
		strongNameIdentityPermission3.m_strongNames = list.ToArray();
		return strongNameIdentityPermission3;
	}

	public override void FromXml(SecurityElement e)
	{
		m_unrestricted = false;
		m_strongNames = null;
		CodeAccessPermission.ValidateElement(e, this);
		string text = e.Attribute("Unrestricted");
		if (text != null && string.Compare(text, "true", StringComparison.OrdinalIgnoreCase) == 0)
		{
			m_unrestricted = true;
			return;
		}
		string text2 = e.Attribute("PublicKeyBlob");
		string text3 = e.Attribute("Name");
		string text4 = e.Attribute("AssemblyVersion");
		List<StrongName2> list = new List<StrongName2>();
		if (text2 != null || text3 != null || text4 != null)
		{
			StrongName2 item = new StrongName2((text2 == null) ? null : new StrongNamePublicKeyBlob(text2), text3, (text4 == null) ? null : new Version(text4));
			list.Add(item);
		}
		ArrayList children = e.Children;
		if (children != null)
		{
			foreach (SecurityElement item2 in children)
			{
				text2 = item2.Attribute("PublicKeyBlob");
				text3 = item2.Attribute("Name");
				text4 = item2.Attribute("AssemblyVersion");
				if (text2 != null || text3 != null || text4 != null)
				{
					StrongName2 item = new StrongName2((text2 == null) ? null : new StrongNamePublicKeyBlob(text2), text3, (text4 == null) ? null : new Version(text4));
					list.Add(item);
				}
			}
		}
		if (list.Count != 0)
		{
			m_strongNames = list.ToArray();
		}
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.StrongNameIdentityPermission");
		if (m_unrestricted)
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		else if (m_strongNames != null)
		{
			if (m_strongNames.Length == 1)
			{
				if (m_strongNames[0].m_publicKeyBlob != null)
				{
					securityElement.AddAttribute("PublicKeyBlob", Hex.EncodeHexString(m_strongNames[0].m_publicKeyBlob.PublicKey));
				}
				if (m_strongNames[0].m_name != null)
				{
					securityElement.AddAttribute("Name", m_strongNames[0].m_name);
				}
				if ((object)m_strongNames[0].m_version != null)
				{
					securityElement.AddAttribute("AssemblyVersion", m_strongNames[0].m_version.ToString());
				}
			}
			else
			{
				for (int i = 0; i < m_strongNames.Length; i++)
				{
					SecurityElement securityElement2 = new SecurityElement("StrongName");
					if (m_strongNames[i].m_publicKeyBlob != null)
					{
						securityElement2.AddAttribute("PublicKeyBlob", Hex.EncodeHexString(m_strongNames[i].m_publicKeyBlob.PublicKey));
					}
					if (m_strongNames[i].m_name != null)
					{
						securityElement2.AddAttribute("Name", m_strongNames[i].m_name);
					}
					if ((object)m_strongNames[i].m_version != null)
					{
						securityElement2.AddAttribute("AssemblyVersion", m_strongNames[i].m_version.ToString());
					}
					securityElement.AddChild(securityElement2);
				}
			}
		}
		return securityElement;
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 12;
	}
}
