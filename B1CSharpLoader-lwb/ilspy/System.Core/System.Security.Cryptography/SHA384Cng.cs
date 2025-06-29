using System.Security.Permissions;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class SHA384Cng : SHA384
{
	private BCryptHashAlgorithm m_hashAlgorithm;

	public SHA384Cng()
	{
		m_hashAlgorithm = new BCryptHashAlgorithm(CngAlgorithm.Sha384, "Microsoft Primitive Provider");
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
