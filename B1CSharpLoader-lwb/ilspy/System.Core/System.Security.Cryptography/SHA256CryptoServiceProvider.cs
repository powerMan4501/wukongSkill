using System.Security.Permissions;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class SHA256CryptoServiceProvider : SHA256
{
	private CapiHashAlgorithm m_hashAlgorithm;

	public SHA256CryptoServiceProvider()
	{
		m_hashAlgorithm = new CapiHashAlgorithm("Microsoft Enhanced RSA and AES Cryptographic Provider", CapiNative.ProviderType.RsaAes, CapiNative.AlgorithmId.Sha256);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				m_hashAlgorithm.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void Initialize()
	{
		m_hashAlgorithm.Initialize();
	}

	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
		m_hashAlgorithm.HashCore(array, ibStart, cbSize);
	}

	protected override byte[] HashFinal()
	{
		return m_hashAlgorithm.HashFinal();
	}
}
