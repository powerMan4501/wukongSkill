using System.Security.Permissions;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class StrongNameSignatureInformation
{
	private SignatureVerificationResult m_verificationResult;

	private AsymmetricAlgorithm m_publicKey;

	private static readonly string StrongNameHashAlgorithm = CapiNative.GetAlgorithmName(CapiNative.AlgorithmId.Sha1);

	public string HashAlgorithm => StrongNameHashAlgorithm;

	public int HResult => CapiNative.HResultForVerificationResult(m_verificationResult);

	public bool IsValid => m_verificationResult == SignatureVerificationResult.Valid;

	public AsymmetricAlgorithm PublicKey => m_publicKey;

	public SignatureVerificationResult VerificationResult => m_verificationResult;

	internal StrongNameSignatureInformation(AsymmetricAlgorithm publicKey)
	{
		m_verificationResult = SignatureVerificationResult.Valid;
		m_publicKey = publicKey;
	}

	internal StrongNameSignatureInformation(SignatureVerificationResult error)
	{
		m_verificationResult = error;
	}
}
