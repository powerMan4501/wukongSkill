namespace System.Security.Policy;

[Serializable]
internal sealed class EvidenceTypeDescriptor
{
	[NonSerialized]
	private bool m_hostCanGenerate;

	[NonSerialized]
	private bool m_generated;

	private EvidenceBase m_hostEvidence;

	private EvidenceBase m_assemblyEvidence;

	public EvidenceBase AssemblyEvidence
	{
		get
		{
			return m_assemblyEvidence;
		}
		set
		{
			m_assemblyEvidence = value;
		}
	}

	public bool Generated
	{
		get
		{
			return m_generated;
		}
		set
		{
			m_generated = value;
		}
	}

	public bool HostCanGenerate
	{
		get
		{
			return m_hostCanGenerate;
		}
		set
		{
			m_hostCanGenerate = value;
		}
	}

	public EvidenceBase HostEvidence
	{
		get
		{
			return m_hostEvidence;
		}
		set
		{
			m_hostEvidence = value;
		}
	}

	public EvidenceTypeDescriptor()
	{
	}

	private EvidenceTypeDescriptor(EvidenceTypeDescriptor descriptor)
	{
		m_hostCanGenerate = descriptor.m_hostCanGenerate;
		if (descriptor.m_assemblyEvidence != null)
		{
			m_assemblyEvidence = descriptor.m_assemblyEvidence.Clone();
		}
		if (descriptor.m_hostEvidence != null)
		{
			m_hostEvidence = descriptor.m_hostEvidence.Clone();
		}
	}

	public EvidenceTypeDescriptor Clone()
	{
		return new EvidenceTypeDescriptor(this);
	}
}
