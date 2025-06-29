using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class KeyContainerPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
{
	private KeyContainerPermissionFlags m_flags;

	private KeyContainerPermissionAccessEntryCollection m_accessEntries;

	public KeyContainerPermissionFlags Flags => m_flags;

	public KeyContainerPermissionAccessEntryCollection AccessEntries => m_accessEntries;

	public KeyContainerPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			m_flags = KeyContainerPermissionFlags.AllFlags;
			break;
		case PermissionState.None:
			m_flags = KeyContainerPermissionFlags.NoFlags;
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
		m_accessEntries = new KeyContainerPermissionAccessEntryCollection(m_flags);
	}

	public KeyContainerPermission(KeyContainerPermissionFlags flags)
	{
		VerifyFlags(flags);
		m_flags = flags;
		m_accessEntries = new KeyContainerPermissionAccessEntryCollection(m_flags);
	}

	public KeyContainerPermission(KeyContainerPermissionFlags flags, KeyContainerPermissionAccessEntry[] accessList)
	{
		if (accessList == null)
		{
			throw new ArgumentNullException("accessList");
		}
		VerifyFlags(flags);
		m_flags = flags;
		m_accessEntries = new KeyContainerPermissionAccessEntryCollection(m_flags);
		for (int i = 0; i < accessList.Length; i++)
		{
			m_accessEntries.Add(accessList[i]);
		}
	}

	public bool IsUnrestricted()
	{
		if (m_flags != KeyContainerPermissionFlags.AllFlags)
		{
			return false;
		}
		KeyContainerPermissionAccessEntryEnumerator enumerator = AccessEntries.GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyContainerPermissionAccessEntry current = enumerator.Current;
			if ((current.Flags & KeyContainerPermissionFlags.AllFlags) != KeyContainerPermissionFlags.AllFlags)
			{
				return false;
			}
		}
		return true;
	}

	private bool IsEmpty()
	{
		if (Flags == KeyContainerPermissionFlags.NoFlags)
		{
			KeyContainerPermissionAccessEntryEnumerator enumerator = AccessEntries.GetEnumerator();
			while (enumerator.MoveNext())
			{
				KeyContainerPermissionAccessEntry current = enumerator.Current;
				if (current.Flags != KeyContainerPermissionFlags.NoFlags)
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return IsEmpty();
		}
		if (!VerifyType(target))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		KeyContainerPermission keyContainerPermission = (KeyContainerPermission)target;
		if ((m_flags & keyContainerPermission.m_flags) != m_flags)
		{
			return false;
		}
		KeyContainerPermissionAccessEntryEnumerator enumerator = AccessEntries.GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyContainerPermissionAccessEntry current = enumerator.Current;
			KeyContainerPermissionFlags applicableFlags = GetApplicableFlags(current, keyContainerPermission);
			if ((current.Flags & applicableFlags) != current.Flags)
			{
				return false;
			}
		}
		KeyContainerPermissionAccessEntryEnumerator enumerator2 = keyContainerPermission.AccessEntries.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			KeyContainerPermissionAccessEntry current2 = enumerator2.Current;
			KeyContainerPermissionFlags applicableFlags2 = GetApplicableFlags(current2, this);
			if ((applicableFlags2 & current2.Flags) != applicableFlags2)
			{
				return false;
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
		if (!VerifyType(target))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		KeyContainerPermission keyContainerPermission = (KeyContainerPermission)target;
		if (IsEmpty() || keyContainerPermission.IsEmpty())
		{
			return null;
		}
		KeyContainerPermissionFlags flags = keyContainerPermission.m_flags & m_flags;
		KeyContainerPermission keyContainerPermission2 = new KeyContainerPermission(flags);
		KeyContainerPermissionAccessEntryEnumerator enumerator = AccessEntries.GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyContainerPermissionAccessEntry current = enumerator.Current;
			keyContainerPermission2.AddAccessEntryAndIntersect(current, keyContainerPermission);
		}
		KeyContainerPermissionAccessEntryEnumerator enumerator2 = keyContainerPermission.AccessEntries.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			KeyContainerPermissionAccessEntry current2 = enumerator2.Current;
			keyContainerPermission2.AddAccessEntryAndIntersect(current2, this);
		}
		if (!keyContainerPermission2.IsEmpty())
		{
			return keyContainerPermission2;
		}
		return null;
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
		KeyContainerPermission keyContainerPermission = (KeyContainerPermission)target;
		if (IsUnrestricted() || keyContainerPermission.IsUnrestricted())
		{
			return new KeyContainerPermission(PermissionState.Unrestricted);
		}
		KeyContainerPermissionFlags flags = m_flags | keyContainerPermission.m_flags;
		KeyContainerPermission keyContainerPermission2 = new KeyContainerPermission(flags);
		KeyContainerPermissionAccessEntryEnumerator enumerator = AccessEntries.GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyContainerPermissionAccessEntry current = enumerator.Current;
			keyContainerPermission2.AddAccessEntryAndUnion(current, keyContainerPermission);
		}
		KeyContainerPermissionAccessEntryEnumerator enumerator2 = keyContainerPermission.AccessEntries.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			KeyContainerPermissionAccessEntry current2 = enumerator2.Current;
			keyContainerPermission2.AddAccessEntryAndUnion(current2, this);
		}
		if (!keyContainerPermission2.IsEmpty())
		{
			return keyContainerPermission2;
		}
		return null;
	}

	public override IPermission Copy()
	{
		if (IsEmpty())
		{
			return null;
		}
		KeyContainerPermission keyContainerPermission = new KeyContainerPermission(m_flags);
		KeyContainerPermissionAccessEntryEnumerator enumerator = AccessEntries.GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyContainerPermissionAccessEntry current = enumerator.Current;
			keyContainerPermission.AccessEntries.Add(current);
		}
		return keyContainerPermission;
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.KeyContainerPermission");
		if (!IsUnrestricted())
		{
			securityElement.AddAttribute("Flags", m_flags.ToString());
			if (AccessEntries.Count > 0)
			{
				SecurityElement securityElement2 = new SecurityElement("AccessList");
				KeyContainerPermissionAccessEntryEnumerator enumerator = AccessEntries.GetEnumerator();
				while (enumerator.MoveNext())
				{
					KeyContainerPermissionAccessEntry current = enumerator.Current;
					SecurityElement securityElement3 = new SecurityElement("AccessEntry");
					securityElement3.AddAttribute("KeyStore", current.KeyStore);
					securityElement3.AddAttribute("ProviderName", current.ProviderName);
					securityElement3.AddAttribute("ProviderType", current.ProviderType.ToString(null, null));
					securityElement3.AddAttribute("KeyContainerName", current.KeyContainerName);
					securityElement3.AddAttribute("KeySpec", current.KeySpec.ToString(null, null));
					securityElement3.AddAttribute("Flags", current.Flags.ToString());
					securityElement2.AddChild(securityElement3);
				}
				securityElement.AddChild(securityElement2);
			}
		}
		else
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		return securityElement;
	}

	public override void FromXml(SecurityElement securityElement)
	{
		CodeAccessPermission.ValidateElement(securityElement, this);
		if (XMLUtil.IsUnrestricted(securityElement))
		{
			m_flags = KeyContainerPermissionFlags.AllFlags;
			m_accessEntries = new KeyContainerPermissionAccessEntryCollection(m_flags);
			return;
		}
		m_flags = KeyContainerPermissionFlags.NoFlags;
		string text = securityElement.Attribute("Flags");
		if (text != null)
		{
			KeyContainerPermissionFlags flags = (KeyContainerPermissionFlags)Enum.Parse(typeof(KeyContainerPermissionFlags), text);
			VerifyFlags(flags);
			m_flags = flags;
		}
		m_accessEntries = new KeyContainerPermissionAccessEntryCollection(m_flags);
		if (securityElement.InternalChildren == null || securityElement.InternalChildren.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = securityElement.Children.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SecurityElement securityElement2 = (SecurityElement)enumerator.Current;
			if (securityElement2 != null && string.Equals(securityElement2.Tag, "AccessList"))
			{
				AddAccessEntries(securityElement2);
			}
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	private void AddAccessEntries(SecurityElement securityElement)
	{
		if (securityElement.InternalChildren == null || securityElement.InternalChildren.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = securityElement.Children.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SecurityElement securityElement2 = (SecurityElement)enumerator.Current;
			if (securityElement2 == null || !string.Equals(securityElement2.Tag, "AccessEntry"))
			{
				continue;
			}
			int count = securityElement2.m_lAttributes.Count;
			string keyStore = null;
			string providerName = null;
			int providerType = -1;
			string keyContainerName = null;
			int keySpec = -1;
			KeyContainerPermissionFlags flags = KeyContainerPermissionFlags.NoFlags;
			for (int i = 0; i < count; i += 2)
			{
				string a = (string)securityElement2.m_lAttributes[i];
				string text = (string)securityElement2.m_lAttributes[i + 1];
				if (string.Equals(a, "KeyStore"))
				{
					keyStore = text;
				}
				if (string.Equals(a, "ProviderName"))
				{
					providerName = text;
				}
				else if (string.Equals(a, "ProviderType"))
				{
					providerType = Convert.ToInt32(text, null);
				}
				else if (string.Equals(a, "KeyContainerName"))
				{
					keyContainerName = text;
				}
				else if (string.Equals(a, "KeySpec"))
				{
					keySpec = Convert.ToInt32(text, null);
				}
				else if (string.Equals(a, "Flags"))
				{
					flags = (KeyContainerPermissionFlags)Enum.Parse(typeof(KeyContainerPermissionFlags), text);
				}
			}
			KeyContainerPermissionAccessEntry accessEntry = new KeyContainerPermissionAccessEntry(keyStore, providerName, providerType, keyContainerName, keySpec, flags);
			AccessEntries.Add(accessEntry);
		}
	}

	private void AddAccessEntryAndUnion(KeyContainerPermissionAccessEntry accessEntry, KeyContainerPermission target)
	{
		KeyContainerPermissionAccessEntry keyContainerPermissionAccessEntry = new KeyContainerPermissionAccessEntry(accessEntry);
		keyContainerPermissionAccessEntry.Flags |= GetApplicableFlags(accessEntry, target);
		AccessEntries.Add(keyContainerPermissionAccessEntry);
	}

	private void AddAccessEntryAndIntersect(KeyContainerPermissionAccessEntry accessEntry, KeyContainerPermission target)
	{
		KeyContainerPermissionAccessEntry keyContainerPermissionAccessEntry = new KeyContainerPermissionAccessEntry(accessEntry);
		keyContainerPermissionAccessEntry.Flags &= GetApplicableFlags(accessEntry, target);
		AccessEntries.Add(keyContainerPermissionAccessEntry);
	}

	internal static void VerifyFlags(KeyContainerPermissionFlags flags)
	{
		if ((flags & ~KeyContainerPermissionFlags.AllFlags) != KeyContainerPermissionFlags.NoFlags)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)flags));
		}
	}

	private static KeyContainerPermissionFlags GetApplicableFlags(KeyContainerPermissionAccessEntry accessEntry, KeyContainerPermission target)
	{
		KeyContainerPermissionFlags keyContainerPermissionFlags = KeyContainerPermissionFlags.NoFlags;
		bool flag = true;
		int num = target.AccessEntries.IndexOf(accessEntry);
		if (num != -1)
		{
			return target.AccessEntries[num].Flags;
		}
		KeyContainerPermissionAccessEntryEnumerator enumerator = target.AccessEntries.GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyContainerPermissionAccessEntry current = enumerator.Current;
			if (accessEntry.IsSubsetOf(current))
			{
				if (!flag)
				{
					keyContainerPermissionFlags &= current.Flags;
					continue;
				}
				keyContainerPermissionFlags = current.Flags;
				flag = false;
			}
		}
		if (flag)
		{
			keyContainerPermissionFlags = target.Flags;
		}
		return keyContainerPermissionFlags;
	}

	private static int GetTokenIndex()
	{
		return 16;
	}
}
