using System.Security.Policy;

namespace System.Security.Permissions;

[Serializable]
internal sealed class StrongName2
{
	public StrongNamePublicKeyBlob m_publicKeyBlob;

	public string m_name;

	public Version m_version;

	public StrongName2(StrongNamePublicKeyBlob publicKeyBlob, string name, Version version)
	{
		m_publicKeyBlob = publicKeyBlob;
		m_name = name;
		m_version = version;
	}

	public StrongName2 Copy()
	{
		return new StrongName2(m_publicKeyBlob, m_name, m_version);
	}

	public bool IsSubsetOf(StrongName2 target)
	{
		if (m_publicKeyBlob == null)
		{
			return true;
		}
		if (!m_publicKeyBlob.Equals(target.m_publicKeyBlob))
		{
			return false;
		}
		if (m_name != null && (target.m_name == null || !StrongName.CompareNames(target.m_name, m_name)))
		{
			return false;
		}
		if ((object)m_version != null && ((object)target.m_version == null || target.m_version.CompareTo(m_version) != 0))
		{
			return false;
		}
		return true;
	}

	public StrongName2 Intersect(StrongName2 target)
	{
		if (target.IsSubsetOf(this))
		{
			return target.Copy();
		}
		if (IsSubsetOf(target))
		{
			return Copy();
		}
		return null;
	}

	public bool Equals(StrongName2 target)
	{
		if (!target.IsSubsetOf(this))
		{
			return false;
		}
		if (!IsSubsetOf(target))
		{
			return false;
		}
		return true;
	}
}
