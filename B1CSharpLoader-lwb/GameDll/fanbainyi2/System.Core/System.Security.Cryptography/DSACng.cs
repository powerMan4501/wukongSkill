using System.IO;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

public sealed class DSACng : DSA
{
	private CngKey _key;

	private static KeySizes[] s_legalKeySizes = new KeySizes[1]
	{
		new KeySizes(512, 3072, 64)
	};

	private static CngAlgorithm s_cngAlgorithmDsa = new CngAlgorithm("DSA");

	private const int MaxV1KeySize = 1024;

	private const int Sha1HashOutputSize = 20;

	private const int Sha256HashOutputSize = 32;

	private const int Sha512HashOutputSize = 64;

	public CngKey Key
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		get
		{
			if (_key != null && _key.KeySize != KeySize)
			{
				_key.Dispose();
				_key = null;
			}
			if (_key == null)
			{
				CngKeyCreationParameters cngKeyCreationParameters = new CngKeyCreationParameters
				{
					ExportPolicy = CngExportPolicies.AllowPlaintextExport
				};
				CngProperty item = new CngProperty("Length", BitConverter.GetBytes(KeySize), CngPropertyOptions.None);
				cngKeyCreationParameters.Parameters.Add(item);
				_key = CngKey.Create(s_cngAlgorithmDsa, null, cngKeyCreationParameters);
			}
			return _key;
		}
		private set
		{
			if (value.AlgorithmGroup != CngAlgorithmGroup.Dsa)
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_ArgDSARequiresDSAKey"), "value");
			}
			if (_key != null)
			{
				_key.Dispose();
			}
			_key = value;
			KeySizeValue = value.KeySize;
		}
	}

	private SafeNCryptKeyHandle KeyHandle
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		get
		{
			return Key.Handle;
		}
	}

	public override KeySizes[] LegalKeySizes => base.LegalKeySizes;

	public override string SignatureAlgorithm => "DSA";

	public override string KeyExchangeAlgorithm => null;

	public DSACng()
		: this(2048)
	{
	}

	public DSACng(int keySize)
	{
		LegalKeySizesValue = s_legalKeySizes;
		KeySize = keySize;
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	public DSACng(CngKey key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key.AlgorithmGroup != CngAlgorithmGroup.Dsa)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgDSARequiresDSAKey"), "key");
		}
		LegalKeySizesValue = s_legalKeySizes;
		Key = CngKey.Open(key.Handle, key.IsEphemeral ? CngKeyHandleOpenOptions.EphemeralKey : CngKeyHandleOpenOptions.None);
	}

	[SecuritySafeCritical]
	public override byte[] CreateSignature(byte[] rgbHash)
	{
		if (rgbHash == null)
		{
			throw new ArgumentNullException("rgbHash");
		}
		rgbHash = AdjustHashSizeIfNecessary(rgbHash);
		return NCryptNative.SignHash(KeyHandle, rgbHash, rgbHash.Length * 2);
	}

	[SecuritySafeCritical]
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
	{
		if (rgbHash == null)
		{
			throw new ArgumentNullException("rgbHash");
		}
		if (rgbSignature == null)
		{
			throw new ArgumentNullException("rgbSignature");
		}
		rgbHash = AdjustHashSizeIfNecessary(rgbHash);
		return NCryptNative.VerifySignature(KeyHandle, rgbHash, rgbSignature);
	}

	protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
	{
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(new CngAlgorithm(hashAlgorithm.Name), "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashCore(data, offset, count);
		return bCryptHashAlgorithm.HashFinal();
	}

	protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
	{
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(new CngAlgorithm(hashAlgorithm.Name), "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashStream(data);
		return bCryptHashAlgorithm.HashFinal();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _key != null)
		{
			_key.Dispose();
			_key = null;
		}
	}

	private byte[] AdjustHashSizeIfNecessary(byte[] hash)
	{
		int num = ComputeQLength();
		if (num > hash.Length)
		{
			throw new PlatformNotSupportedException("Cryptography_DSA_HashTooShort");
		}
		Array.Resize(ref hash, num);
		return hash;
	}

	[SecuritySafeCritical]
	private unsafe int ComputeQLength()
	{
		CngKey key = Key;
		byte[] array = key.Export(CngKeyBlobFormat.GenericPublicBlob);
		if (array.Length < sizeof(BCRYPT_DSA_KEY_BLOB_V2))
		{
			return 20;
		}
		fixed (byte* ptr = array)
		{
			BCRYPT_DSA_KEY_BLOB_V2* ptr2 = (BCRYPT_DSA_KEY_BLOB_V2*)ptr;
			if (ptr2->dwMagic != BCryptNative.KeyBlobMagicNumber.DsaPublicV2 && ptr2->dwMagic != BCryptNative.KeyBlobMagicNumber.DsaPrivateV2)
			{
				return 20;
			}
			return ptr2->cbGroupSize;
		}
	}

	public override DSAParameters ExportParameters(bool includePrivateParameters)
	{
		byte[] buffer = Key.Export(includePrivateParameters ? CngKeyBlobFormat.GenericPrivateBlob : CngKeyBlobFormat.GenericPublicBlob);
		using BinaryReader binaryReader = new BinaryReader(new MemoryStream(buffer));
		try
		{
			DSAParameters result = default(DSAParameters);
			BCryptNative.KeyBlobMagicNumber keyBlobMagicNumber = (BCryptNative.KeyBlobMagicNumber)binaryReader.ReadInt32();
			switch (keyBlobMagicNumber)
			{
			case BCryptNative.KeyBlobMagicNumber.DsaPublic:
			case BCryptNative.KeyBlobMagicNumber.DsaPrivate:
			{
				if (includePrivateParameters && keyBlobMagicNumber != BCryptNative.KeyBlobMagicNumber.DsaPrivate)
				{
					throw new CryptographicException("Cryptography_NotValidPublicOrPrivateKey");
				}
				int count4 = binaryReader.ReadInt32();
				result.Counter = FromBigEndian(binaryReader.ReadBytes(4));
				result.Seed = binaryReader.ReadBytes(20);
				result.Q = binaryReader.ReadBytes(20);
				result.P = binaryReader.ReadBytes(count4);
				result.G = binaryReader.ReadBytes(count4);
				result.Y = binaryReader.ReadBytes(count4);
				if (includePrivateParameters)
				{
					result.X = binaryReader.ReadBytes(20);
				}
				break;
			}
			case BCryptNative.KeyBlobMagicNumber.DsaPublicV2:
			case BCryptNative.KeyBlobMagicNumber.DsaPrivateV2:
			{
				if (includePrivateParameters && keyBlobMagicNumber != BCryptNative.KeyBlobMagicNumber.DsaPrivateV2)
				{
					throw new CryptographicException("Cryptography_NotValidPublicOrPrivateKey");
				}
				int count = binaryReader.ReadInt32();
				HASHALGORITHM_ENUM hASHALGORITHM_ENUM = (HASHALGORITHM_ENUM)binaryReader.ReadInt32();
				DSAFIPSVERSION_ENUM dSAFIPSVERSION_ENUM = (DSAFIPSVERSION_ENUM)binaryReader.ReadInt32();
				int count2 = binaryReader.ReadInt32();
				int count3 = binaryReader.ReadInt32();
				result.Counter = FromBigEndian(binaryReader.ReadBytes(4));
				result.Seed = binaryReader.ReadBytes(count2);
				result.Q = binaryReader.ReadBytes(count3);
				result.P = binaryReader.ReadBytes(count);
				result.G = binaryReader.ReadBytes(count);
				result.Y = binaryReader.ReadBytes(count);
				if (includePrivateParameters)
				{
					result.X = binaryReader.ReadBytes(count3);
				}
				break;
			}
			default:
				throw new CryptographicException("Cryptography_NotValidPublicOrPrivateKey");
			}
			if (result.Counter == -1)
			{
				result.Counter = 0;
				result.Seed = null;
			}
			return result;
		}
		catch (EndOfStreamException)
		{
			throw new CryptographicException("Cryptography_NotValidPublicOrPrivateKey");
		}
	}

	private static int FromBigEndian(byte[] b)
	{
		return (b[0] << 24) | (b[1] << 16) | (b[2] << 8) | b[3];
	}

	public override void ImportParameters(DSAParameters parameters)
	{
		if (parameters.P == null || parameters.Q == null || parameters.G == null || parameters.Y == null)
		{
			throw new ArgumentException("Cryptography_InvalidDsaParameters_MissingFields");
		}
		if (parameters.J != null && parameters.J.Length >= parameters.P.Length)
		{
			throw new ArgumentException("Cryptography_InvalidDsaParameters_MismatchedPJ");
		}
		bool flag = parameters.X != null;
		int num = parameters.P.Length;
		int num2 = num * 8;
		if (parameters.G.Length != num || parameters.Y.Length != num)
		{
			throw new ArgumentException("Cryptography_InvalidDsaParameters_MismatchedPGY");
		}
		if (flag && parameters.X.Length != parameters.Q.Length)
		{
			throw new ArgumentException("Cryptography_InvalidDsaParameters_MismatchedQX");
		}
		using MemoryStream memoryStream = new MemoryStream();
		using (BinaryWriter bw = new BinaryWriter(memoryStream))
		{
			if (num2 <= 1024)
			{
				GenerateV1DsaBlob(bw, parameters, num, flag);
			}
			else
			{
				GenerateV2DsaBlob(bw, parameters, num, flag);
			}
		}
		memoryStream.Flush();
		byte[] keyBlob = memoryStream.ToArray();
		CngKey cngKey = CngKey.Import(keyBlob, flag ? CngKeyBlobFormat.GenericPrivateBlob : CngKeyBlobFormat.GenericPublicBlob);
		CngExportPolicies value = cngKey.ExportPolicy | CngExportPolicies.AllowPlaintextExport;
		cngKey.SetProperty(new CngProperty("Export Policy", BitConverter.GetBytes((int)value), CngPropertyOptions.None));
		Key = cngKey;
	}

	private static void GenerateV1DsaBlob(BinaryWriter bw, DSAParameters parameters, int keySizeInBytes, bool hasPrivateKey)
	{
		bw.Write(hasPrivateKey ? 1448104772 : 1112560452);
		bw.Write(keySizeInBytes);
		if (parameters.Seed != null)
		{
			if (parameters.Seed.Length != 20)
			{
				throw new ArgumentException("Cryptography_InvalidDsaParameters_SeedRestriction_ShortKey");
			}
			bw.Write(ToBigEndian(parameters.Counter));
			bw.Write(parameters.Seed);
		}
		else
		{
			bw.Write(uint.MaxValue);
			for (int i = 0; i < 20; i++)
			{
				bw.Write(byte.MaxValue);
			}
		}
		if (parameters.Q.Length != 20)
		{
			throw new ArgumentException("Cryptography_InvalidDsaParameters_QRestriction_ShortKey");
		}
		bw.Write(parameters.Q);
		bw.Write(parameters.P);
		bw.Write(parameters.G);
		bw.Write(parameters.Y);
		if (hasPrivateKey)
		{
			bw.Write(parameters.X);
		}
	}

	private static void GenerateV2DsaBlob(BinaryWriter bw, DSAParameters parameters, int keySizeInBytes, bool hasPrivateKey)
	{
		bw.Write(hasPrivateKey ? 844517444 : 843206724);
		bw.Write(keySizeInBytes);
		bw.Write(parameters.Q.Length switch
		{
			20 => 0, 
			32 => 1, 
			64 => 2, 
			_ => throw new PlatformNotSupportedException("Cryptography_InvalidDsaParameters_QRestriction_LargeKey"), 
		});
		bw.Write(1);
		if (parameters.Seed != null)
		{
			bw.Write(parameters.Seed.Length);
			bw.Write(parameters.Q.Length);
			bw.Write(ToBigEndian(parameters.Counter));
			bw.Write(parameters.Seed);
		}
		else
		{
			int num = parameters.Q.Length;
			bw.Write(num);
			bw.Write(parameters.Q.Length);
			bw.Write(uint.MaxValue);
			for (int i = 0; i < num; i++)
			{
				bw.Write(byte.MaxValue);
			}
		}
		bw.Write(parameters.Q);
		bw.Write(parameters.P);
		bw.Write(parameters.G);
		bw.Write(parameters.Y);
		if (hasPrivateKey)
		{
			bw.Write(parameters.X);
		}
	}

	private static byte[] ToBigEndian(int i)
	{
		return new byte[4]
		{
			(byte)(i >> 24),
			(byte)(i >> 16),
			(byte)(i >> 8),
			(byte)i
		};
	}
}
