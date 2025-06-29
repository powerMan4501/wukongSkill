using System.Collections.Generic;
using System.Reflection;

namespace System.Security.Policy;

internal sealed class AppDomainEvidenceFactory : IRuntimeEvidenceFactory
{
	private AppDomain m_targetDomain;

	private Evidence m_entryPointEvidence;

	public IEvidenceFactory Target => m_targetDomain;

	internal AppDomainEvidenceFactory(AppDomain target)
	{
		m_targetDomain = target;
	}

	public IEnumerable<EvidenceBase> GetFactorySuppliedEvidence()
	{
		return new EvidenceBase[0];
	}

	[SecuritySafeCritical]
	public EvidenceBase GenerateEvidence(Type evidenceType)
	{
		if (m_targetDomain.IsDefaultAppDomain())
		{
			if (m_entryPointEvidence == null)
			{
				Assembly entryAssembly = Assembly.GetEntryAssembly();
				RuntimeAssembly runtimeAssembly = entryAssembly as RuntimeAssembly;
				if (runtimeAssembly != null)
				{
					m_entryPointEvidence = runtimeAssembly.EvidenceNoDemand.Clone();
				}
				else if (entryAssembly != null)
				{
					m_entryPointEvidence = entryAssembly.Evidence;
				}
			}
			if (m_entryPointEvidence != null)
			{
				return m_entryPointEvidence.GetHostEvidence(evidenceType);
			}
			return null;
		}
		AppDomain defaultDomain = AppDomain.GetDefaultDomain();
		return defaultDomain.GetHostEvidence(evidenceType);
	}
}
