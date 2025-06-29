using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Policy;

internal sealed class PEFileEvidenceFactory : IRuntimeEvidenceFactory
{
	[SecurityCritical]
	private SafePEFileHandle m_peFile;

	private List<EvidenceBase> m_assemblyProvidedEvidence;

	private bool m_generatedLocationEvidence;

	private Site m_siteEvidence;

	private Url m_urlEvidence;

	private Zone m_zoneEvidence;

	internal SafePEFileHandle PEFile
	{
		[SecurityCritical]
		get
		{
			return m_peFile;
		}
	}

	public IEvidenceFactory Target => null;

	[SecurityCritical]
	private PEFileEvidenceFactory(SafePEFileHandle peFile)
	{
		m_peFile = peFile;
	}

	[SecurityCritical]
	private static Evidence CreateSecurityIdentity(SafePEFileHandle peFile, Evidence hostProvidedEvidence)
	{
		PEFileEvidenceFactory target = new PEFileEvidenceFactory(peFile);
		Evidence evidence = new Evidence(target);
		if (hostProvidedEvidence != null)
		{
			evidence.MergeWithNoDuplicates(hostProvidedEvidence);
		}
		return evidence;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void FireEvidenceGeneratedEvent(SafePEFileHandle peFile, EvidenceTypeGenerated type);

	[SecuritySafeCritical]
	internal void FireEvidenceGeneratedEvent(EvidenceTypeGenerated type)
	{
		FireEvidenceGeneratedEvent(m_peFile, type);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetAssemblySuppliedEvidence(SafePEFileHandle peFile, ObjectHandleOnStack retSerializedEvidence);

	[SecuritySafeCritical]
	public IEnumerable<EvidenceBase> GetFactorySuppliedEvidence()
	{
		if (m_assemblyProvidedEvidence == null)
		{
			byte[] o = null;
			GetAssemblySuppliedEvidence(m_peFile, JitHelpers.GetObjectHandleOnStack(ref o));
			m_assemblyProvidedEvidence = new List<EvidenceBase>();
			if (o != null)
			{
				Evidence evidence = new Evidence();
				new SecurityPermission(SecurityPermissionFlag.SerializationFormatter).Assert();
				try
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					using MemoryStream serializationStream = new MemoryStream(o);
					evidence = (Evidence)binaryFormatter.Deserialize(serializationStream);
				}
				catch
				{
				}
				CodeAccessPermission.RevertAssert();
				if (evidence != null)
				{
					IEnumerator assemblyEnumerator = evidence.GetAssemblyEnumerator();
					while (assemblyEnumerator.MoveNext())
					{
						if (assemblyEnumerator.Current != null)
						{
							EvidenceBase evidenceBase = assemblyEnumerator.Current as EvidenceBase;
							if (evidenceBase == null)
							{
								evidenceBase = new LegacyEvidenceWrapper(assemblyEnumerator.Current);
							}
							m_assemblyProvidedEvidence.Add(evidenceBase);
						}
					}
				}
			}
		}
		return m_assemblyProvidedEvidence;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetLocationEvidence(SafePEFileHandle peFile, out SecurityZone zone, StringHandleOnStack retUrl);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetPublisherCertificate(SafePEFileHandle peFile, ObjectHandleOnStack retCertificate);

	public EvidenceBase GenerateEvidence(Type evidenceType)
	{
		if (evidenceType == typeof(Site))
		{
			return GenerateSiteEvidence();
		}
		if (evidenceType == typeof(Url))
		{
			return GenerateUrlEvidence();
		}
		if (evidenceType == typeof(Zone))
		{
			return GenerateZoneEvidence();
		}
		if (evidenceType == typeof(Publisher))
		{
			return GeneratePublisherEvidence();
		}
		return null;
	}

	[SecuritySafeCritical]
	private void GenerateLocationEvidence()
	{
		if (m_generatedLocationEvidence)
		{
			return;
		}
		SecurityZone zone = SecurityZone.NoZone;
		string s = null;
		GetLocationEvidence(m_peFile, out zone, JitHelpers.GetStringHandleOnStack(ref s));
		if (zone != SecurityZone.NoZone)
		{
			m_zoneEvidence = new Zone(zone);
		}
		if (!string.IsNullOrEmpty(s))
		{
			m_urlEvidence = new Url(s, parsed: true);
			if (!s.StartsWith("file:", StringComparison.OrdinalIgnoreCase))
			{
				m_siteEvidence = Site.CreateFromUrl(s);
			}
		}
		m_generatedLocationEvidence = true;
	}

	[SecuritySafeCritical]
	private Publisher GeneratePublisherEvidence()
	{
		byte[] o = null;
		GetPublisherCertificate(m_peFile, JitHelpers.GetObjectHandleOnStack(ref o));
		if (o == null)
		{
			return null;
		}
		return new Publisher(new X509Certificate(o));
	}

	private Site GenerateSiteEvidence()
	{
		if (m_siteEvidence == null)
		{
			GenerateLocationEvidence();
		}
		return m_siteEvidence;
	}

	private Url GenerateUrlEvidence()
	{
		if (m_urlEvidence == null)
		{
			GenerateLocationEvidence();
		}
		return m_urlEvidence;
	}

	private Zone GenerateZoneEvidence()
	{
		if (m_zoneEvidence == null)
		{
			GenerateLocationEvidence();
		}
		return m_zoneEvidence;
	}
}
