using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class SHA256Managed : SHA256
{
	private static readonly CngHashAlgorithmFactory<SHA256> _factory = new CngHashAlgorithmFactory<SHA256>("System.Security.Cryptography.SHA256Cng");

	private SHA256 _impl;

	public SHA256Managed()
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

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
		_impl.TransformBlock(rgb, ibStart, cbSize, null, 0);
	}

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
