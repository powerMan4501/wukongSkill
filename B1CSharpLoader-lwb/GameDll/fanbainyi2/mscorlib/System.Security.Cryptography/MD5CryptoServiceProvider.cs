using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class MD5CryptoServiceProvider : MD5
{
	[SecurityCritical]
	private SafeHashHandle _safeHashHandle;

	[SecuritySafeCritical]
	public MD5CryptoServiceProvider()
	{
		if (CryptoConfig.AllowOnlyFipsAlgorithms && AppContextSwitches.UseLegacyFipsThrow)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Cryptography_NonCompliantFIPSAlgorithm"));
		}
		_safeHashHandle = Utils.CreateHash(Utils.StaticProvHandle, 32771);
	}

	[SecuritySafeCritical]
	protected override void Dispose(bool disposing)
	{
		if (_safeHashHandle != null && !_safeHashHandle.IsClosed)
		{
			_safeHashHandle.Dispose();
		}
		base.Dispose(disposing);
	}

	[SecuritySafeCritical]
	public override void Initialize()
	{
		if (_safeHashHandle != null && !_safeHashHandle.IsClosed)
		{
			_safeHashHandle.Dispose();
		}
		_safeHashHandle = Utils.CreateHash(Utils.StaticProvHandle, 32771);
	}

	[SecuritySafeCritical]
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
		Utils.HashData(_safeHashHandle, rgb, ibStart, cbSize);
	}

	[SecuritySafeCritical]
	protected override byte[] HashFinal()
	{
		return Utils.EndHash(_safeHashHandle);
	}
}
