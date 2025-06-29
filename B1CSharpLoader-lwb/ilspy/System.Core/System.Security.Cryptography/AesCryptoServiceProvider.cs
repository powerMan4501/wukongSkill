using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class AesCryptoServiceProvider : Aes
{
	private static volatile KeySizes[] s_supportedKeySizes;

	private static volatile int s_defaultKeySize;

	[SecurityCritical]
	private Microsoft.Win32.SafeHandles.SafeCspHandle m_cspHandle;

	[SecurityCritical]
	private SafeCapiKeyHandle m_key;

	public override byte[] Key
	{
		[SecuritySafeCritical]
		get
		{
			if (m_key == null || m_key.IsInvalid || m_key.IsClosed)
			{
				GenerateKey();
			}
			return CapiNative.ExportSymmetricKey(m_key);
		}
		[SecuritySafeCritical]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			byte[] array = (byte[])value.Clone();
			if (!ValidKeySize(array.Length * 8))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_InvalidKeySize"));
			}
			SafeCapiKeyHandle key = CapiNative.ImportSymmetricKey(m_cspHandle, GetAlgorithmId(array.Length * 8), array);
			if (m_key != null)
			{
				m_key.Dispose();
			}
			m_key = key;
			KeySizeValue = array.Length * 8;
		}
	}

	public override int KeySize
	{
		get
		{
			return base.KeySize;
		}
		[SecuritySafeCritical]
		set
		{
			base.KeySize = value;
			if (m_key != null)
			{
				m_key.Dispose();
			}
		}
	}

	[SecurityCritical]
	public AesCryptoServiceProvider()
	{
		string providerName = "Microsoft Enhanced RSA and AES Cryptographic Provider";
		if (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor == 1)
		{
			providerName = "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";
		}
		m_cspHandle = CapiNative.AcquireCsp(null, providerName, CapiNative.ProviderType.RsaAes, CapiNative.CryptAcquireContextFlags.VerifyContext, throwPlatformException: true);
		FeedbackSizeValue = 8;
		int defaultKeySize = 0;
		KeySizes[] array = FindSupportedKeySizes(m_cspHandle, out defaultKeySize);
		if (array.Length != 0)
		{
			KeySizeValue = defaultKeySize;
			return;
		}
		throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
	}

	[SecuritySafeCritical]
	public override ICryptoTransform CreateDecryptor()
	{
		if (m_key == null || m_key.IsInvalid || m_key.IsClosed)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_DecryptWithNoKey"));
		}
		return CreateDecryptor(m_key, IVValue);
	}

	[SecuritySafeCritical]
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!ValidKeySize(key.Length * 8))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidKeySize"), "key");
		}
		if (iv != null && iv.Length * 8 != BlockSizeValue)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidIVSize"), "iv");
		}
		byte[] array = (byte[])key.Clone();
		byte[] iv2 = null;
		if (iv != null)
		{
			iv2 = (byte[])iv.Clone();
		}
		using SafeCapiKeyHandle key2 = CapiNative.ImportSymmetricKey(m_cspHandle, GetAlgorithmId(array.Length * 8), array);
		return CreateDecryptor(key2, iv2);
	}

	[SecurityCritical]
	private ICryptoTransform CreateDecryptor(SafeCapiKeyHandle key, byte[] iv)
	{
		return new CapiSymmetricAlgorithm(BlockSizeValue, FeedbackSizeValue, m_cspHandle, key, iv, Mode, PaddingValue, EncryptionMode.Decrypt);
	}

	[SecuritySafeCritical]
	public override ICryptoTransform CreateEncryptor()
	{
		if (m_key == null || m_key.IsInvalid || m_key.IsClosed)
		{
			GenerateKey();
		}
		if (Mode != CipherMode.ECB && IVValue == null)
		{
			GenerateIV();
		}
		return CreateEncryptor(m_key, IVValue);
	}

	[SecuritySafeCritical]
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!ValidKeySize(key.Length * 8))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidKeySize"), "key");
		}
		if (iv != null && iv.Length * 8 != BlockSizeValue)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidIVSize"), "iv");
		}
		byte[] array = (byte[])key.Clone();
		byte[] iv2 = null;
		if (iv != null)
		{
			iv2 = (byte[])iv.Clone();
		}
		using SafeCapiKeyHandle key2 = CapiNative.ImportSymmetricKey(m_cspHandle, GetAlgorithmId(array.Length * 8), array);
		return CreateEncryptor(key2, iv2);
	}

	[SecurityCritical]
	private ICryptoTransform CreateEncryptor(SafeCapiKeyHandle key, byte[] iv)
	{
		return new CapiSymmetricAlgorithm(BlockSizeValue, FeedbackSizeValue, m_cspHandle, key, iv, Mode, PaddingValue, EncryptionMode.Encrypt);
	}

	[SecuritySafeCritical]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				if (m_key != null)
				{
					m_key.Dispose();
				}
				if (m_cspHandle != null)
				{
					m_cspHandle.Dispose();
				}
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[SecurityCritical]
	private static KeySizes[] FindSupportedKeySizes(Microsoft.Win32.SafeHandles.SafeCspHandle csp, out int defaultKeySize)
	{
		if (s_supportedKeySizes == null)
		{
			List<KeySizes> list = new List<KeySizes>();
			int num = 0;
			CapiNative.PROV_ENUMALGS providerParameterStruct = CapiNative.GetProviderParameterStruct<CapiNative.PROV_ENUMALGS>(csp, CapiNative.ProviderParameter.EnumerateAlgorithms, CapiNative.ProviderParameterFlags.RestartEnumeration);
			while (providerParameterStruct.aiAlgId != CapiNative.AlgorithmId.None)
			{
				switch (providerParameterStruct.aiAlgId)
				{
				case CapiNative.AlgorithmId.Aes128:
					list.Add(new KeySizes(128, 128, 0));
					if (128 > num)
					{
						num = 128;
					}
					break;
				case CapiNative.AlgorithmId.Aes192:
					list.Add(new KeySizes(192, 192, 0));
					if (192 > num)
					{
						num = 192;
					}
					break;
				case CapiNative.AlgorithmId.Aes256:
					list.Add(new KeySizes(256, 256, 0));
					if (256 > num)
					{
						num = 256;
					}
					break;
				}
				providerParameterStruct = CapiNative.GetProviderParameterStruct<CapiNative.PROV_ENUMALGS>(csp, CapiNative.ProviderParameter.EnumerateAlgorithms, CapiNative.ProviderParameterFlags.None);
			}
			s_supportedKeySizes = list.ToArray();
			s_defaultKeySize = num;
		}
		defaultKeySize = s_defaultKeySize;
		return s_supportedKeySizes;
	}

	[SecuritySafeCritical]
	public override void GenerateKey()
	{
		SafeCapiKeyHandle phKey = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (!CapiNative.UnsafeNativeMethods.CryptGenKey(m_cspHandle, GetAlgorithmId(KeySizeValue), CapiNative.KeyFlags.Exportable, out phKey))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
		finally
		{
			if (phKey != null && !phKey.IsInvalid)
			{
				phKey.SetParentCsp(m_cspHandle);
			}
		}
		if (m_key != null)
		{
			m_key.Dispose();
		}
		m_key = phKey;
	}

	[SecuritySafeCritical]
	public override void GenerateIV()
	{
		byte[] array = new byte[BlockSizeValue / 8];
		if (!CapiNative.UnsafeNativeMethods.CryptGenRandom(m_cspHandle, array.Length, array))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		IVValue = array;
	}

	private static CapiNative.AlgorithmId GetAlgorithmId(int keySize)
	{
		return keySize switch
		{
			128 => CapiNative.AlgorithmId.Aes128, 
			192 => CapiNative.AlgorithmId.Aes192, 
			256 => CapiNative.AlgorithmId.Aes256, 
			_ => CapiNative.AlgorithmId.None, 
		};
	}
}
