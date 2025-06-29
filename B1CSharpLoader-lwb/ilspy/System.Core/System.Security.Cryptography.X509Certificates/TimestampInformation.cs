using System.Security.Permissions;

namespace System.Security.Cryptography.X509Certificates;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class TimestampInformation
{
	private CapiNative.AlgorithmId m_hashAlgorithmId;

	private DateTime m_timestamp;

	private X509Chain m_timestampChain;

	private SignatureVerificationResult m_verificationResult;

	private X509Certificate2 m_timestamper;

	public string HashAlgorithm => CapiNative.GetAlgorithmName(m_hashAlgorithmId);

	public int HResult => CapiNative.HResultForVerificationResult(m_verificationResult);

	public bool IsValid
	{
		get
		{
			if (VerificationResult != SignatureVerificationResult.Valid)
			{
				return VerificationResult == SignatureVerificationResult.CertificateNotExplicitlyTrusted;
			}
			return true;
		}
	}

	public X509Chain SignatureChain
	{
		[SecuritySafeCritical]
		[StorePermission(SecurityAction.Demand, OpenStore = true, EnumerateCertificates = true)]
		get
		{
			return m_timestampChain;
		}
	}

	public X509Certificate2 SigningCertificate
	{
		[SecuritySafeCritical]
		[StorePermission(SecurityAction.Demand, OpenStore = true, EnumerateCertificates = true)]
		get
		{
			if (m_timestamper == null && SignatureChain != null)
			{
				m_timestamper = SignatureChain.ChainElements[0].Certificate;
			}
			return m_timestamper;
		}
	}

	public DateTime Timestamp => m_timestamp.ToLocalTime();

	public SignatureVerificationResult VerificationResult => m_verificationResult;

	[SecurityCritical]
	internal TimestampInformation(X509Native.AXL_AUTHENTICODE_TIMESTAMPER_INFO timestamper)
	{
		m_hashAlgorithmId = timestamper.algHash;
		m_verificationResult = (SignatureVerificationResult)timestamper.dwError;
		ulong fileTime = ((ulong)(uint)timestamper.ftTimestamp.dwHighDateTime << 32) | (uint)timestamper.ftTimestamp.dwLowDateTime;
		m_timestamp = DateTime.FromFileTimeUtc((long)fileTime);
		if (timestamper.pChainContext != IntPtr.Zero)
		{
			m_timestampChain = new X509Chain(timestamper.pChainContext);
		}
	}

	internal TimestampInformation(SignatureVerificationResult error)
	{
		m_verificationResult = error;
	}
}
