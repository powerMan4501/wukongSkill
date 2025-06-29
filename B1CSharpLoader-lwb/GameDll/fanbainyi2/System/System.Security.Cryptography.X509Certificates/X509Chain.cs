using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

public class X509Chain : IDisposable
{
	private struct X509ChainErrorMapping
	{
		public readonly uint Win32Flag;

		public readonly int Win32ErrorCode;

		public readonly X509ChainStatusFlags ChainStatusFlag;

		public X509ChainErrorMapping(uint win32Flag, int win32ErrorCode, X509ChainStatusFlags chainStatusFlag)
		{
			Win32Flag = win32Flag;
			Win32ErrorCode = win32ErrorCode;
			ChainStatusFlag = chainStatusFlag;
		}
	}

	private static class CompatSwitches
	{
		internal static readonly bool ShouldThrowOnChainBuildingFailure = ReadInt32CompatSwitch("X509Chain_ThrowOnBuildFailure", 1) != 0;

		[SecuritySafeCritical]
		[EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
		private static int ReadInt32CompatSwitch(string switchName, int defaultValue)
		{
			string environmentVariable = Environment.GetEnvironmentVariable("COMPlus_" + switchName);
			if (environmentVariable != null && int.TryParse(environmentVariable, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
			{
				return result;
			}
			return ReadInt32CompatSwitchFromRegistry(RegistryHive.CurrentUser, switchName) ?? ReadInt32CompatSwitchFromRegistry(RegistryHive.LocalMachine, switchName) ?? defaultValue;
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		[RegistryPermission(SecurityAction.Assert, Unrestricted = true)]
		private static int? ReadInt32CompatSwitchFromRegistry(RegistryHive hive, string switchName)
		{
			try
			{
				using RegistryKey registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64);
				using RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\.NETFramework", writable: false);
				return registryKey2?.GetValue(switchName) as int?;
			}
			catch
			{
			}
			return null;
		}
	}

	private uint m_status;

	private X509ChainPolicy m_chainPolicy;

	private X509ChainStatus[] m_chainStatus;

	private X509ChainElementCollection m_chainElementCollection;

	[SecurityCritical]
	private SafeX509ChainHandle m_safeCertChainHandle;

	private bool m_useMachineContext;

	private readonly object m_syncRoot = new object();

	private static readonly X509ChainErrorMapping[] s_x509ChainErrorMappings = new X509ChainErrorMapping[23]
	{
		new X509ChainErrorMapping(8u, -2146869244, X509ChainStatusFlags.NotSignatureValid),
		new X509ChainErrorMapping(262144u, -2146869244, X509ChainStatusFlags.CtlNotSignatureValid),
		new X509ChainErrorMapping(32u, -2146762487, X509ChainStatusFlags.UntrustedRoot),
		new X509ChainErrorMapping(65536u, -2146762486, X509ChainStatusFlags.PartialChain),
		new X509ChainErrorMapping(4u, -2146885616, X509ChainStatusFlags.Revoked),
		new X509ChainErrorMapping(16u, -2146762480, X509ChainStatusFlags.NotValidForUsage),
		new X509ChainErrorMapping(524288u, -2146762480, X509ChainStatusFlags.CtlNotValidForUsage),
		new X509ChainErrorMapping(1u, -2146762495, X509ChainStatusFlags.NotTimeValid),
		new X509ChainErrorMapping(131072u, -2146762495, X509ChainStatusFlags.CtlNotTimeValid),
		new X509ChainErrorMapping(2048u, -2146762476, X509ChainStatusFlags.InvalidNameConstraints),
		new X509ChainErrorMapping(4096u, -2146762476, X509ChainStatusFlags.HasNotSupportedNameConstraint),
		new X509ChainErrorMapping(8192u, -2146762476, X509ChainStatusFlags.HasNotDefinedNameConstraint),
		new X509ChainErrorMapping(16384u, -2146762476, X509ChainStatusFlags.HasNotPermittedNameConstraint),
		new X509ChainErrorMapping(32768u, -2146762476, X509ChainStatusFlags.HasExcludedNameConstraint),
		new X509ChainErrorMapping(512u, -2146762477, X509ChainStatusFlags.InvalidPolicyConstraints),
		new X509ChainErrorMapping(33554432u, -2146762477, X509ChainStatusFlags.NoIssuanceChainPolicy),
		new X509ChainErrorMapping(1024u, -2146869223, X509ChainStatusFlags.InvalidBasicConstraints),
		new X509ChainErrorMapping(2u, -2146762494, X509ChainStatusFlags.NotTimeNested),
		new X509ChainErrorMapping(64u, -2146885614, X509ChainStatusFlags.RevocationStatusUnknown),
		new X509ChainErrorMapping(16777216u, -2146885613, X509ChainStatusFlags.OfflineRevocation),
		new X509ChainErrorMapping(67108864u, -2146762479, X509ChainStatusFlags.ExplicitDistrust),
		new X509ChainErrorMapping(134217728u, -2146762491, X509ChainStatusFlags.HasNotSupportedCriticalExtension),
		new X509ChainErrorMapping(1048576u, -2146877418, X509ChainStatusFlags.HasWeakSignature)
	};

	public IntPtr ChainContext
	{
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			return m_safeCertChainHandle.DangerousGetHandle();
		}
	}

	public SafeX509ChainHandle SafeHandle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			return m_safeCertChainHandle;
		}
	}

	public X509ChainPolicy ChainPolicy
	{
		get
		{
			if (m_chainPolicy == null)
			{
				m_chainPolicy = new X509ChainPolicy();
			}
			return m_chainPolicy;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_chainPolicy = value;
		}
	}

	public X509ChainStatus[] ChainStatus
	{
		get
		{
			if (m_chainStatus == null)
			{
				if (m_status == 0)
				{
					m_chainStatus = new X509ChainStatus[0];
				}
				else
				{
					m_chainStatus = GetChainStatusInformation(m_status);
				}
			}
			return m_chainStatus;
		}
	}

	public X509ChainElementCollection ChainElements => m_chainElementCollection;

	public static X509Chain Create()
	{
		return (X509Chain)CryptoConfig.CreateFromName("X509Chain");
	}

	[SecurityCritical]
	public X509Chain()
		: this(useMachineContext: false)
	{
	}

	[SecurityCritical]
	public X509Chain(bool useMachineContext)
	{
		m_status = 0u;
		m_chainPolicy = null;
		m_chainStatus = null;
		m_chainElementCollection = new X509ChainElementCollection();
		m_safeCertChainHandle = SafeX509ChainHandle.InvalidHandle;
		m_useMachineContext = useMachineContext;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public X509Chain(IntPtr chainContext)
	{
		if (chainContext == IntPtr.Zero)
		{
			throw new ArgumentNullException("chainContext");
		}
		m_safeCertChainHandle = CAPISafe.CertDuplicateCertificateChain(chainContext);
		if (m_safeCertChainHandle == null || m_safeCertChainHandle == SafeX509ChainHandle.InvalidHandle)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_InvalidContextHandle"), "chainContext");
		}
		Init();
	}

	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public bool Build(X509Certificate2 certificate)
	{
		lock (m_syncRoot)
		{
			if (certificate == null || certificate.CertContext.IsInvalid)
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_InvalidContextHandle"), "certificate");
			}
			StorePermission storePermission = new StorePermission(StorePermissionFlags.OpenStore | StorePermissionFlags.EnumerateCertificates);
			storePermission.Demand();
			X509ChainPolicy chainPolicy = ChainPolicy;
			if (chainPolicy.RevocationMode == X509RevocationMode.Online && (certificate.Extensions["2.5.29.31"] != null || certificate.Extensions["1.3.6.1.5.5.7.1.1"] != null))
			{
				PermissionSet permissionSet = new PermissionSet(PermissionState.None);
				permissionSet.AddPermission(new WebPermission(PermissionState.Unrestricted));
				permissionSet.AddPermission(new StorePermission(StorePermissionFlags.AddToStore));
				permissionSet.Demand();
			}
			Reset();
			int num = BuildChain(m_useMachineContext ? new IntPtr(1L) : new IntPtr(0L), certificate.CertContext, chainPolicy.ExtraStore, chainPolicy.ApplicationPolicy, chainPolicy.CertificatePolicy, chainPolicy.RevocationMode, chainPolicy.RevocationFlag, chainPolicy.VerificationTime, chainPolicy.UrlRetrievalTimeout, ref m_safeCertChainHandle);
			if (num != 0)
			{
				if (CompatSwitches.ShouldThrowOnChainBuildingFailure)
				{
					throw new CryptographicException(num);
				}
				return false;
			}
			Init();
			CAPIBase.CERT_CHAIN_POLICY_PARA pPolicyPara = new CAPIBase.CERT_CHAIN_POLICY_PARA(Marshal.SizeOf(typeof(CAPIBase.CERT_CHAIN_POLICY_PARA)));
			CAPIBase.CERT_CHAIN_POLICY_STATUS pPolicyStatus = new CAPIBase.CERT_CHAIN_POLICY_STATUS(Marshal.SizeOf(typeof(CAPIBase.CERT_CHAIN_POLICY_STATUS)));
			pPolicyPara.dwFlags = (uint)chainPolicy.VerificationFlags;
			if (!CAPISafe.CertVerifyCertificateChainPolicy(new IntPtr(1L), m_safeCertChainHandle, ref pPolicyPara, ref pPolicyStatus))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			CAPISafe.SetLastError(pPolicyStatus.dwError);
			return pPolicyStatus.dwError == 0;
		}
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public void Reset()
	{
		m_status = 0u;
		m_chainStatus = null;
		m_chainElementCollection = new X509ChainElementCollection();
		if (!m_safeCertChainHandle.IsInvalid)
		{
			m_safeCertChainHandle.Dispose();
			m_safeCertChainHandle = SafeX509ChainHandle.InvalidHandle;
		}
	}

	[SecuritySafeCritical]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			Reset();
		}
	}

	[SecurityCritical]
	private unsafe void Init()
	{
		using SafeX509ChainHandle safeX509ChainHandle = CAPISafe.CertDuplicateCertificateChain(m_safeCertChainHandle);
		CAPIBase.CERT_CHAIN_CONTEXT cERT_CHAIN_CONTEXT = new CAPIBase.CERT_CHAIN_CONTEXT(Marshal.SizeOf(typeof(CAPIBase.CERT_CHAIN_CONTEXT)));
		uint num = (uint)Marshal.ReadInt32(safeX509ChainHandle.DangerousGetHandle());
		if (num > Marshal.SizeOf((object)cERT_CHAIN_CONTEXT))
		{
			num = (uint)Marshal.SizeOf((object)cERT_CHAIN_CONTEXT);
		}
		X509Utils.memcpy(m_safeCertChainHandle.DangerousGetHandle(), new IntPtr(&cERT_CHAIN_CONTEXT), num);
		m_status = cERT_CHAIN_CONTEXT.dwErrorStatus;
		m_chainElementCollection = new X509ChainElementCollection(Marshal.ReadIntPtr(cERT_CHAIN_CONTEXT.rgpChain));
	}

	internal static X509ChainStatus[] GetChainStatusInformation(uint dwStatus)
	{
		if (dwStatus == 0)
		{
			return new X509ChainStatus[0];
		}
		int num = 0;
		for (uint num2 = dwStatus; num2 != 0; num2 >>= 1)
		{
			if ((num2 & 1) != 0)
			{
				num++;
			}
		}
		X509ChainStatus[] array = new X509ChainStatus[num];
		int num3 = 0;
		X509ChainErrorMapping[] array2 = s_x509ChainErrorMappings;
		for (int i = 0; i < array2.Length; i++)
		{
			X509ChainErrorMapping x509ChainErrorMapping = array2[i];
			if ((dwStatus & x509ChainErrorMapping.Win32Flag) != 0)
			{
				array[num3].StatusInformation = X509Utils.GetSystemErrorString(x509ChainErrorMapping.Win32ErrorCode);
				array[num3].Status = x509ChainErrorMapping.ChainStatusFlag;
				num3++;
				dwStatus &= ~x509ChainErrorMapping.Win32Flag;
			}
		}
		int num4 = 0;
		for (uint num5 = dwStatus; num5 != 0; num5 >>= 1)
		{
			if ((num5 & 1) != 0)
			{
				array[num3].Status = (X509ChainStatusFlags)(1 << num4);
				array[num3].StatusInformation = System.SR.GetString("Unknown_Error");
				num3++;
			}
			num4++;
		}
		return array;
	}

	[SecurityCritical]
	internal unsafe static int BuildChain(IntPtr hChainEngine, System.Security.Cryptography.SafeCertContextHandle pCertContext, X509Certificate2Collection extraStore, OidCollection applicationPolicy, OidCollection certificatePolicy, X509RevocationMode revocationMode, X509RevocationFlag revocationFlag, DateTime verificationTime, TimeSpan timeout, ref SafeX509ChainHandle ppChainContext)
	{
		if (pCertContext == null || pCertContext.IsInvalid)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidContextHandle"), "pCertContext");
		}
		System.Security.Cryptography.SafeCertStoreHandle hAdditionalStore = System.Security.Cryptography.SafeCertStoreHandle.InvalidHandle;
		if (extraStore != null && extraStore.Count > 0)
		{
			hAdditionalStore = X509Utils.ExportToMemoryStore(extraStore);
		}
		CAPIBase.CERT_CHAIN_PARA pChainPara = default(CAPIBase.CERT_CHAIN_PARA);
		pChainPara.cbSize = (uint)Marshal.SizeOf((object)pChainPara);
		SafeLocalAllocHandle safeLocalAllocHandle = SafeLocalAllocHandle.InvalidHandle;
		SafeLocalAllocHandle safeLocalAllocHandle2 = SafeLocalAllocHandle.InvalidHandle;
		try
		{
			if (applicationPolicy != null && applicationPolicy.Count > 0)
			{
				pChainPara.RequestedUsage.dwType = 0u;
				pChainPara.RequestedUsage.Usage.cUsageIdentifier = (uint)applicationPolicy.Count;
				safeLocalAllocHandle = X509Utils.CopyOidsToUnmanagedMemory(applicationPolicy);
				pChainPara.RequestedUsage.Usage.rgpszUsageIdentifier = safeLocalAllocHandle.DangerousGetHandle();
			}
			if (certificatePolicy != null && certificatePolicy.Count > 0)
			{
				pChainPara.RequestedIssuancePolicy.dwType = 0u;
				pChainPara.RequestedIssuancePolicy.Usage.cUsageIdentifier = (uint)certificatePolicy.Count;
				safeLocalAllocHandle2 = X509Utils.CopyOidsToUnmanagedMemory(certificatePolicy);
				pChainPara.RequestedIssuancePolicy.Usage.rgpszUsageIdentifier = safeLocalAllocHandle2.DangerousGetHandle();
			}
			pChainPara.dwUrlRetrievalTimeout = (uint)Math.Floor(timeout.TotalMilliseconds);
			System.Runtime.InteropServices.ComTypes.FILETIME pTime = default(System.Runtime.InteropServices.ComTypes.FILETIME);
			*(long*)(&pTime) = verificationTime.ToFileTime();
			uint dwFlags = X509Utils.MapRevocationFlags(revocationMode, revocationFlag);
			if (!CAPISafe.CertGetCertificateChain(hChainEngine, pCertContext, ref pTime, hAdditionalStore, ref pChainPara, dwFlags, IntPtr.Zero, ref ppChainContext))
			{
				return Marshal.GetHRForLastWin32Error();
			}
		}
		finally
		{
			safeLocalAllocHandle.Dispose();
			safeLocalAllocHandle2.Dispose();
		}
		return 0;
	}
}
