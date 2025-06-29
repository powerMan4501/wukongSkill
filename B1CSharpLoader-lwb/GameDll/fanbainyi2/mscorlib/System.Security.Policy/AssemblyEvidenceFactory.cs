using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Policy;

internal sealed class AssemblyEvidenceFactory : IRuntimeEvidenceFactory
{
	private PEFileEvidenceFactory m_peFileFactory;

	private RuntimeAssembly m_targetAssembly;

	internal SafePEFileHandle PEFile
	{
		[SecurityCritical]
		get
		{
			return m_peFileFactory.PEFile;
		}
	}

	public IEvidenceFactory Target => m_targetAssembly;

	private AssemblyEvidenceFactory(RuntimeAssembly targetAssembly, PEFileEvidenceFactory peFileFactory)
	{
		m_targetAssembly = targetAssembly;
		m_peFileFactory = peFileFactory;
	}

	public EvidenceBase GenerateEvidence(Type evidenceType)
	{
		EvidenceBase evidenceBase = m_peFileFactory.GenerateEvidence(evidenceType);
		if (evidenceBase != null)
		{
			return evidenceBase;
		}
		if (evidenceType == typeof(GacInstalled))
		{
			return GenerateGacEvidence();
		}
		if (evidenceType == typeof(Hash))
		{
			return GenerateHashEvidence();
		}
		if (evidenceType == typeof(PermissionRequestEvidence))
		{
			return GeneratePermissionRequestEvidence();
		}
		if (evidenceType == typeof(StrongName))
		{
			return GenerateStrongNameEvidence();
		}
		return null;
	}

	private GacInstalled GenerateGacEvidence()
	{
		if (!m_targetAssembly.GlobalAssemblyCache)
		{
			return null;
		}
		m_peFileFactory.FireEvidenceGeneratedEvent(EvidenceTypeGenerated.Gac);
		return new GacInstalled();
	}

	private Hash GenerateHashEvidence()
	{
		if (m_targetAssembly.IsDynamic)
		{
			return null;
		}
		m_peFileFactory.FireEvidenceGeneratedEvent(EvidenceTypeGenerated.Hash);
		return new Hash(m_targetAssembly);
	}

	[SecuritySafeCritical]
	private PermissionRequestEvidence GeneratePermissionRequestEvidence()
	{
		PermissionSet o = null;
		PermissionSet o2 = null;
		PermissionSet o3 = null;
		GetAssemblyPermissionRequests(m_targetAssembly.GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o), JitHelpers.GetObjectHandleOnStack(ref o2), JitHelpers.GetObjectHandleOnStack(ref o3));
		if (o != null || o2 != null || o3 != null)
		{
			return new PermissionRequestEvidence(o, o2, o3);
		}
		return null;
	}

	[SecuritySafeCritical]
	private StrongName GenerateStrongNameEvidence()
	{
		byte[] o = null;
		string s = null;
		ushort majorVersion = 0;
		ushort minorVersion = 0;
		ushort build = 0;
		ushort revision = 0;
		GetStrongNameInformation(m_targetAssembly.GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o), JitHelpers.GetStringHandleOnStack(ref s), out majorVersion, out minorVersion, out build, out revision);
		if (o == null || o.Length == 0)
		{
			return null;
		}
		return new StrongName(new StrongNamePublicKeyBlob(o), s, new Version(majorVersion, minorVersion, build, revision), m_targetAssembly);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetAssemblyPermissionRequests(RuntimeAssembly assembly, ObjectHandleOnStack retMinimumPermissions, ObjectHandleOnStack retOptionalPermissions, ObjectHandleOnStack retRefusedPermissions);

	public IEnumerable<EvidenceBase> GetFactorySuppliedEvidence()
	{
		return m_peFileFactory.GetFactorySuppliedEvidence();
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetStrongNameInformation(RuntimeAssembly assembly, ObjectHandleOnStack retPublicKeyBlob, StringHandleOnStack retSimpleName, out ushort majorVersion, out ushort minorVersion, out ushort build, out ushort revision);

	[SecurityCritical]
	private static Evidence UpgradeSecurityIdentity(Evidence peFileEvidence, RuntimeAssembly targetAssembly)
	{
		peFileEvidence.Target = new AssemblyEvidenceFactory(targetAssembly, peFileEvidence.Target as PEFileEvidenceFactory);
		HostSecurityManager hostSecurityManager = AppDomain.CurrentDomain.HostSecurityManager;
		if ((hostSecurityManager.Flags & HostSecurityManagerOptions.HostAssemblyEvidence) == HostSecurityManagerOptions.HostAssemblyEvidence)
		{
			peFileEvidence = hostSecurityManager.ProvideAssemblyEvidence(targetAssembly, peFileEvidence);
			if (peFileEvidence == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Policy_NullHostEvidence", hostSecurityManager.GetType().FullName, targetAssembly.FullName));
			}
		}
		return peFileEvidence;
	}
}
