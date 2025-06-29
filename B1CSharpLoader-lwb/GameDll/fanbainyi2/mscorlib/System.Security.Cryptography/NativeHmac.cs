using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

internal sealed class NativeHmac : IDisposable
{
	private struct BLOBHEADER
	{
		internal byte bType;

		internal byte bVersion;

		internal short reserved;

		internal CapiNative.AlgorithmID aiKeyAlg;
	}

	private struct HMAC_Info
	{
		internal CapiNative.AlgorithmID HashAlgid;

		internal IntPtr pbInnerString;

		internal uint cbInnerString;

		internal IntPtr pbOuterString;

		internal uint cbOuterString;
	}

	[SecurityCritical]
	private SafeCspHashHandle _hash;

	[SecurityCritical]
	private SafeCspKeyHandle _key;

	private CapiNative.AlgorithmID _algId;

	internal NativeHmac(CapiNative.AlgorithmID algId)
	{
		_algId = algId;
	}

	[SecuritySafeCritical]
	public void Dispose()
	{
		Reset();
	}

	[SecuritySafeCritical]
	internal void SetKey(byte[] key)
	{
		SafeCspHandle value = CapiNative.SafeNativeMethods.DefaultProvider.Value;
		_key = OpenKeyHandle(value, key);
		try
		{
			_hash = OpenHmacHandle(value, _algId, _key);
		}
		catch (CryptographicException)
		{
			_key.Dispose();
			_key = null;
			throw;
		}
	}

	[SecuritySafeCritical]
	internal unsafe void AppendData(byte[] data, int offset, int count)
	{
		fixed (byte* ptr = data)
		{
			if (!CapiNative.SafeNativeMethods.CryptHashData(_hash, (IntPtr)(ptr + offset), count, 0))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
	}

	[SecuritySafeCritical]
	internal void Finish(byte[] output)
	{
		int pdwDataLen = output.Length;
		Exception ex = null;
		if (!CapiNative.SafeNativeMethods.CryptGetHashParam(_hash, CapiNative.HashProperty.HashValue, output, ref pdwDataLen, 0))
		{
			ex = new CryptographicException(Marshal.GetLastWin32Error());
		}
		Reset();
		if (ex != null)
		{
			throw ex;
		}
		if (pdwDataLen != output.Length)
		{
			throw new CryptographicException();
		}
	}

	[SecuritySafeCritical]
	internal void Reset()
	{
		_hash?.Dispose();
		_hash = null;
		_key?.Dispose();
		_key = null;
	}

	[SecurityCritical]
	private unsafe static SafeCspKeyHandle OpenKeyHandle(SafeCspHandle hProv, byte[] key)
	{
		if (key.Length > 128)
		{
			throw new CryptographicException();
		}
		int num = sizeof(BLOBHEADER) + 4;
		int num2 = num + 128;
		int dwDataLen = num + key.Length;
		byte* ptr = stackalloc byte[(int)(uint)num2];
		BLOBHEADER* ptr2 = (BLOBHEADER*)ptr;
		ptr2->bType = 8;
		ptr2->bVersion = 2;
		ptr2->reserved = 0;
		ptr2->aiKeyAlg = CapiNative.AlgorithmID.Rc2;
		int* ptr3 = (int*)(ptr + sizeof(BLOBHEADER));
		byte* ptr4 = ptr + sizeof(BLOBHEADER) + 4;
		if (key.Length >= 2)
		{
			*ptr3 = key.Length;
		}
		else
		{
			*ptr3 = 2;
			*(short*)ptr4 = 0;
			dwDataLen = num + 2;
		}
		Marshal.Copy(key, 0, (IntPtr)ptr4, key.Length);
		SafeCspKeyHandle phKey;
		bool flag = CapiNative.SafeNativeMethods.CryptImportKey(hProv, (IntPtr)ptr, dwDataLen, IntPtr.Zero, (CapiNative.KeyGenerationFlags)256, out phKey);
		for (int i = 0; i < key.Length; i++)
		{
			ptr4[i] = 0;
		}
		if (!flag)
		{
			Exception ex = new CryptographicException(Marshal.GetLastWin32Error());
			phKey.Dispose();
			throw ex;
		}
		return phKey;
	}

	[SecurityCritical]
	private unsafe static SafeCspHashHandle OpenHmacHandle(SafeCspHandle hProv, CapiNative.AlgorithmID algId, SafeCspKeyHandle macKey)
	{
		if (!CapiNative.SafeNativeMethods.CryptCreateHash(hProv, CapiNative.AlgorithmID.Hmac, macKey.DangerousGetHandle(), 0, out var phHash))
		{
			Exception ex = new CryptographicException(Marshal.GetLastWin32Error());
			phHash.Dispose();
			throw ex;
		}
		HMAC_Info hMAC_Info = new HMAC_Info
		{
			HashAlgid = algId
		};
		if (!CapiNative.SafeNativeMethods.CryptSetHashParam(pbData: new IntPtr(&hMAC_Info), hHash: phHash, dwParam: CapiNative.HashProperty.HmacInfo, dwFlags: 0))
		{
			Exception ex2 = new CryptographicException(Marshal.GetLastWin32Error());
			phHash.Dispose();
			throw ex2;
		}
		GC.KeepAlive(macKey);
		return phHash;
	}
}
