using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class SHA512Managed : SHA512
{
	private static readonly CngHashAlgorithmFactory<SHA512> _factory = new CngHashAlgorithmFactory<SHA512>("System.Security.Cryptography.SHA512Cng");

	private SHA512 _impl;

	public SHA512Managed()
	{
		if (CryptoConfig.AllowOnlyFipsAlgorithms && AppContextSwitches.UseLegacyFipsThrow)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Cryptography_NonCompliantFIPSAlgorithm"));
		}
		_impl = _factory.CreateInstance();
	}

	public override void Initialize()
	{
		_impl.Initialize();
	}

	[SecuritySafeCritical]
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
		_impl.TransformBlock(rgb, ibStart, cbSize, null, 0);
	}

	[SecuritySafeCritical]
	protected override byte[] HashFinal()
	{
		_impl.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
		return _impl.Hash;
	}

	protected override void Dispose(bool disposing)
	{
		_impl.Dispose();
		base.Dispose(disposing);
	}
}
