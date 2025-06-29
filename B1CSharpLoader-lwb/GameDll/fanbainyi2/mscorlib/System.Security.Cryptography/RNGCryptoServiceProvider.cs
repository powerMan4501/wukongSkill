using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
{
	[SecurityCritical]
	private SafeProvHandle m_safeProvHandle;

	private bool m_ownsHandle;

	public RNGCryptoServiceProvider()
		: this((CspParameters)null)
	{
	}

	public RNGCryptoServiceProvider(string str)
		: this((CspParameters)null)
	{
	}

	public RNGCryptoServiceProvider(byte[] rgb)
		: this((CspParameters)null)
	{
	}

	[SecuritySafeCritical]
	public RNGCryptoServiceProvider(CspParameters cspParams)
	{
		if (cspParams != null)
		{
			m_safeProvHandle = Utils.AcquireProvHandle(cspParams);
			m_ownsHandle = true;
		}
		else
		{
			m_safeProvHandle = Utils.StaticProvHandle;
			m_ownsHandle = false;
		}
	}

	[SecuritySafeCritical]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing && m_ownsHandle)
		{
			m_safeProvHandle.Dispose();
		}
	}

	[SecuritySafeCritical]
	public override void GetBytes(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		GetBytes(m_safeProvHandle, data, data.Length);
	}

	[SecuritySafeCritical]
	public override void GetNonZeroBytes(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		GetNonZeroBytes(m_safeProvHandle, data, data.Length);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetBytes(SafeProvHandle hProv, byte[] randomBytes, int count);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetNonZeroBytes(SafeProvHandle hProv, byte[] randomBytes, int count);
}
