using System.Security.Permissions;

namespace System.Security.Policy;

[Serializable]
internal sealed class LegacyEvidenceWrapper : EvidenceBase, ILegacyEvidenceAdapter
{
	private object m_legacyEvidence;

	public object EvidenceObject => m_legacyEvidence;

	public Type EvidenceType => m_legacyEvidence.GetType();

	internal LegacyEvidenceWrapper(object legacyEvidence)
	{
		m_legacyEvidence = legacyEvidence;
	}

	public override bool Equals(object obj)
	{
		return m_legacyEvidence.Equals(obj);
	}

	public override int GetHashCode()
	{
		return m_legacyEvidence.GetHashCode();
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override EvidenceBase Clone()
	{
		return base.Clone();
	}
}
