using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class CapiHashAlgorithm : IDisposable
{
	private CapiNative.AlgorithmId m_algorithmId;

	[SecurityCritical]
	private Microsoft.Win32.SafeHandles.SafeCspHandle m_cspHandle;

	[SecurityCritical]
	private SafeCapiHashHandle m_hashHandle;

	[SecuritySafeCritical]
	public CapiHashAlgorithm(string provider, CapiNative.ProviderType providerType, CapiNative.AlgorithmId algorithm)
	{
		m_algorithmId = algorithm;
		m_cspHandle = CapiNative.AcquireCsp(null, provider, providerType, CapiNative.CryptAcquireContextFlags.VerifyContext, throwPlatformException: true);
		Initialize();
	}

	[SecuritySafeCritical]
	public void Dispose()
	{
		if (m_hashHandle != null)
		{
			m_hashHandle.Dispose();
		}
		if (m_cspHandle != null)
		{
			m_cspHandle.Dispose();
		}
	}

	[SecuritySafeCritical]
	public void Initialize()
	{
		SafeCapiHashHandle phHash = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (!CapiNative.UnsafeNativeMethods.CryptCreateHash(m_cspHandle, m_algorithmId, SafeCapiKeyHandle.InvalidHandle, 0, out phHash))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error == -2146893816)
				{
					throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
				}
				throw new CryptographicException(lastWin32Error);
			}
		}
		finally
		{
			if (phHash != null && !phHash.IsInvalid)
			{
				phHash.SetParentCsp(m_cspHandle);
			}
		}
		if (m_hashHandle != null)
		{
			m_hashHandle.Dispose();
		}
		m_hashHandle = phHash;
	}

	[SecuritySafeCritical]
	public unsafe void HashCore(byte[] array, int ibStart, int cbSize)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (ibStart < 0 || ibStart > array.Length - cbSize)
		{
			throw new ArgumentOutOfRangeException("ibStart");
		}
		if (cbSize < 0 || cbSize > array.Length)
		{
			throw new ArgumentOutOfRangeException("cbSize");
		}
		if (cbSize == 0)
		{
			return;
		}
		fixed (byte* ptr = array)
		{
			if (!CapiNative.UnsafeNativeMethods.CryptHashData(m_hashHandle, ptr + ibStart, cbSize, 0))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
	}

	[SecuritySafeCritical]
	public byte[] HashFinal()
	{
		return CapiNative.GetHashParameter(m_hashHandle, CapiNative.HashParameter.HashValue);
	}
}
