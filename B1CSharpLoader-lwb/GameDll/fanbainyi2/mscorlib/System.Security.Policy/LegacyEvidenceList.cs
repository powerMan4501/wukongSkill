using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;

namespace System.Security.Policy;

[Serializable]
internal sealed class LegacyEvidenceList : EvidenceBase, IEnumerable<EvidenceBase>, IEnumerable, ILegacyEvidenceAdapter
{
	private List<EvidenceBase> m_legacyEvidenceList = new List<EvidenceBase>();

	public object EvidenceObject
	{
		get
		{
			if (m_legacyEvidenceList.Count <= 0)
			{
				return null;
			}
			return m_legacyEvidenceList[0];
		}
	}

	public Type EvidenceType
	{
		get
		{
			if (m_legacyEvidenceList[0] is ILegacyEvidenceAdapter legacyEvidenceAdapter)
			{
				return legacyEvidenceAdapter.EvidenceType;
			}
			return m_legacyEvidenceList[0].GetType();
		}
	}

	public void Add(EvidenceBase evidence)
	{
		m_legacyEvidenceList.Add(evidence);
	}

	public IEnumerator<EvidenceBase> GetEnumerator()
	{
		return m_legacyEvidenceList.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return m_legacyEvidenceList.GetEnumerator();
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override EvidenceBase Clone()
	{
		return base.Clone();
	}
}
