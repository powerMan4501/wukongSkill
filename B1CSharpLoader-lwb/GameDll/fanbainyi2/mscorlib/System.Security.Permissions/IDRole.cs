using System.Security.Principal;

namespace System.Security.Permissions;

[Serializable]
internal class IDRole
{
	internal bool m_authenticated;

	internal string m_id;

	internal string m_role;

	[NonSerialized]
	private SecurityIdentifier m_sid;

	internal SecurityIdentifier Sid
	{
		[SecurityCritical]
		get
		{
			if (string.IsNullOrEmpty(m_role))
			{
				return null;
			}
			if (m_sid == null)
			{
				NTAccount identity = new NTAccount(m_role);
				IdentityReferenceCollection identityReferenceCollection = new IdentityReferenceCollection(1);
				identityReferenceCollection.Add(identity);
				IdentityReferenceCollection identityReferenceCollection2 = NTAccount.Translate(identityReferenceCollection, typeof(SecurityIdentifier), forceSuccess: false);
				m_sid = identityReferenceCollection2[0] as SecurityIdentifier;
			}
			return m_sid;
		}
	}

	internal SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("Identity");
		if (m_authenticated)
		{
			securityElement.AddAttribute("Authenticated", "true");
		}
		if (m_id != null)
		{
			securityElement.AddAttribute("ID", SecurityElement.Escape(m_id));
		}
		if (m_role != null)
		{
			securityElement.AddAttribute("Role", SecurityElement.Escape(m_role));
		}
		return securityElement;
	}

	internal void FromXml(SecurityElement e)
	{
		string text = e.Attribute("Authenticated");
		if (text != null)
		{
			m_authenticated = string.Compare(text, "true", StringComparison.OrdinalIgnoreCase) == 0;
		}
		else
		{
			m_authenticated = false;
		}
		string text2 = e.Attribute("ID");
		if (text2 != null)
		{
			m_id = text2;
		}
		else
		{
			m_id = null;
		}
		string text3 = e.Attribute("Role");
		if (text3 != null)
		{
			m_role = text3;
		}
		else
		{
			m_role = null;
		}
	}

	public override int GetHashCode()
	{
		return ((!m_authenticated) ? 101 : 0) + ((m_id != null) ? m_id.GetHashCode() : 0) + ((m_role != null) ? m_role.GetHashCode() : 0);
	}
}
