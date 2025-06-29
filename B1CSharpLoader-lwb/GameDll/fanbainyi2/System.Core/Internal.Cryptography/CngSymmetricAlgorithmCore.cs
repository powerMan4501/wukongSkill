using System;
using System.Security;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace Internal.Cryptography;

internal struct CngSymmetricAlgorithmCore
{
	private readonly ICngSymmetricAlgorithm _outer;

	private string _keyName;

	private CngProvider _provider;

	private CngKeyOpenOptions _optionOptions;

	private const int BitsPerByte = 8;

	private bool KeyInPlainText => _keyName == null;

	public CngSymmetricAlgorithmCore(ICngSymmetricAlgorithm outer)
	{
		_outer = outer;
		_keyName = null;
		_provider = null;
		_optionOptions = CngKeyOpenOptions.None;
	}

	public CngSymmetricAlgorithmCore(ICngSymmetricAlgorithm outer, string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
	{
		if (keyName == null)
		{
			throw new ArgumentNullException("keyName");
		}
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		_outer = outer;
		_keyName = keyName;
		_provider = provider;
		_optionOptions = openOptions;
		using CngKey cngKey = ProduceCngKey();
		CngAlgorithm algorithm = cngKey.Algorithm;
		string nCryptAlgorithmIdentifier = _outer.GetNCryptAlgorithmIdentifier();
		if (nCryptAlgorithmIdentifier != algorithm.Algorithm)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_CngKeyWrongAlgorithm", algorithm.Algorithm, nCryptAlgorithmIdentifier));
		}
		_outer.BaseKeySize = cngKey.KeySize;
	}

	public byte[] GetKeyIfExportable()
	{
		if (KeyInPlainText)
		{
			return _outer.BaseKey;
		}
		using CngKey cngKey = ProduceCngKey();
		return cngKey.GetSymmetricKeyDataIfExportable(_outer.GetNCryptAlgorithmIdentifier());
	}

	public void SetKey(byte[] key)
	{
		_outer.BaseKey = key;
		_keyName = null;
	}

	public void SetKeySize(int keySize, ICngSymmetricAlgorithm outer)
	{
		outer.BaseKeySize = keySize;
		_keyName = null;
	}

	public void GenerateKey()
	{
		byte[] key = Helpers.GenerateRandom(_outer.BaseKeySize.BitSizeToByteSize());
		SetKey(key);
	}

	public void GenerateIV()
	{
		byte[] iV = Helpers.GenerateRandom(_outer.BlockSize.BitSizeToByteSize());
		_outer.IV = iV;
	}

	public ICryptoTransform CreateEncryptor()
	{
		return CreateCryptoTransform(encrypting: true);
	}

	public ICryptoTransform CreateDecryptor()
	{
		return CreateCryptoTransform(encrypting: false);
	}

	public ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateCryptoTransform(rgbKey, rgbIV, encrypting: true);
	}

	public ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return CreateCryptoTransform(rgbKey, rgbIV, encrypting: false);
	}

	private ICryptoTransform CreateCryptoTransform(bool encrypting)
	{
		if (KeyInPlainText)
		{
			return CreateCryptoTransform(_outer.BaseKey, _outer.IV, encrypting);
		}
		return CreatePersistedCryptoTransformCore(ProduceCngKey, _outer.IV, encrypting);
	}

	private ICryptoTransform CreateCryptoTransform(byte[] rgbKey, byte[] rgbIV, bool encrypting)
	{
		if (rgbKey == null)
		{
			throw new ArgumentNullException("key");
		}
		byte[] key = rgbKey.CloneByteArray();
		long num = (long)key.Length * 8L;
		if (num > int.MaxValue || !((int)num).IsLegalSize(_outer.LegalKeySizes))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidKeySize", "key"));
		}
		if (_outer.IsWeakKey(key))
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_WeakKey"));
		}
		if (rgbIV != null && rgbIV.Length != _outer.BlockSize.BitSizeToByteSize())
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidIVSize", "iv"));
		}
		byte[] iv = _outer.Mode.GetCipherIv(rgbIV).CloneByteArray();
		if (System.LocalAppContextSwitches.SymmetricCngAlwaysUseNCrypt)
		{
			string algorithm = _outer.GetNCryptAlgorithmIdentifier();
			return CreatePersistedCryptoTransformCore(() => key.ToCngKey(algorithm), iv, encrypting);
		}
		return CreateEphemeralCryptoTransformCore(key, iv, encrypting);
	}

	private ICryptoTransform CreatePersistedCryptoTransformCore(Func<CngKey> cngKeyFactory, byte[] iv, bool encrypting)
	{
		int blockSizeInBytes = _outer.BlockSize.BitSizeToByteSize();
		BasicSymmetricCipher cipher = new BasicSymmetricCipherNCrypt(cngKeyFactory, _outer.Mode, blockSizeInBytes, iv, encrypting);
		return UniversalCryptoTransform.Create(_outer.Padding, cipher, encrypting);
	}

	[SecuritySafeCritical]
	private ICryptoTransform CreateEphemeralCryptoTransformCore(byte[] key, byte[] iv, bool encrypting)
	{
		int blockSizeInBytes = _outer.BlockSize.BitSizeToByteSize();
		SafeBCryptAlgorithmHandle ephemeralModeHandle = _outer.GetEphemeralModeHandle();
		BasicSymmetricCipher cipher = new BasicSymmetricCipherBCrypt(ephemeralModeHandle, _outer.Mode, blockSizeInBytes, key, iv, encrypting);
		return UniversalCryptoTransform.Create(_outer.Padding, cipher, encrypting);
	}

	private CngKey ProduceCngKey()
	{
		return CngKey.Open(_keyName, _provider, _optionOptions);
	}
}
