using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class BCryptHashAlgorithm : IDisposable
{
	[ThreadStatic]
	[SecurityCritical]
	private static BCryptAlgorithmHandleCache _algorithmCache;

	[SecurityCritical]
	private SafeBCryptAlgorithmHandle m_algorithmHandle;

	[SecurityCritical]
	private SafeBCryptHashHandle m_hashHandle;

	[SecuritySafeCritical]
	public BCryptHashAlgorithm(CngAlgorithm algorithm, string implementation)
	{
		if (!BCryptNative.BCryptSupported)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
		}
		if (_algorithmCache == null)
		{
			_algorithmCache = new BCryptAlgorithmHandleCache();
		}
		m_algorithmHandle = _algorithmCache.GetCachedAlgorithmHandle(algorithm.Algorithm, implementation);
		Initialize();
	}

	[SecuritySafeCritical]
	public void Dispose()
	{
		if (m_hashHandle != null)
		{
			m_hashHandle.Dispose();
		}
		if (m_algorithmHandle != null)
		{
			m_algorithmHandle = null;
		}
	}

	[SecuritySafeCritical]
	public void Initialize()
	{
		SafeBCryptHashHandle phHash = null;
		IntPtr intPtr = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			int int32Property = BCryptNative.GetInt32Property(m_algorithmHandle, "ObjectLength");
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				intPtr = Marshal.AllocCoTaskMem(int32Property);
			}
			BCryptNative.ErrorCode errorCode = BCryptNative.UnsafeNativeMethods.BCryptCreateHash(m_algorithmHandle, out phHash, intPtr, int32Property, IntPtr.Zero, 0, 0);
			if (errorCode != BCryptNative.ErrorCode.Success)
			{
				throw new CryptographicException((int)errorCode);
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				if (phHash != null)
				{
					phHash.HashObject = intPtr;
				}
				else
				{
					Marshal.FreeCoTaskMem(intPtr);
				}
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
		if (cbSize != 0)
		{
			BCryptNative.ErrorCode errorCode;
			fixed (byte* ptr = array)
			{
				errorCode = BCryptNative.UnsafeNativeMethods.BCryptHashData(m_hashHandle, ptr + ibStart, cbSize, 0);
			}
			if (errorCode != BCryptNative.ErrorCode.Success)
			{
				throw new CryptographicException((int)errorCode);
			}
		}
	}

	[SecuritySafeCritical]
	public byte[] HashFinal()
	{
		int int32Property = BCryptNative.GetInt32Property(m_hashHandle, "HashDigestLength");
		byte[] array = new byte[int32Property];
		BCryptNative.ErrorCode errorCode = BCryptNative.UnsafeNativeMethods.BCryptFinishHash(m_hashHandle, array, array.Length, 0);
		if (errorCode != BCryptNative.ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	[SecuritySafeCritical]
	public void HashStream(Stream stream)
	{
		byte[] array = new byte[4096];
		int num = 0;
		do
		{
			num = stream.Read(array, 0, array.Length);
			if (num > 0)
			{
				HashCore(array, 0, num);
			}
		}
		while (num > 0);
	}
}
