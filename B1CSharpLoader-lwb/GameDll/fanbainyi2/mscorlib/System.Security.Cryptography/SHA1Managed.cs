using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class SHA1Managed : SHA1
{
	private SHA1 _impl;

	public SHA1Managed()
	{
		if (CryptoConfig.AllowOnlyFipsAlgorithms && AppContextSwitches.UseLegacyFipsThrow)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Cryptography_NonCompliantFIPSAlgorithm"));
		}
		_impl = new SHA1CryptoServiceProvider();
	}

	public override void Initialize()
	{
		_impl.Initialize();
	}

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
		try
		{
			_impl.TransformBlock(rgb, ibStart, cbSize, null, 0);
		}
		catch (ArgumentException)
		{
			throw new IndexOutOfRangeException();
		}
	}

	protected override byte[] HashFinal()
	{
		_impl.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
		return _impl.Hash;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			_impl.Dispose();
		}
		base.Dispose(disposing);
	}
}
