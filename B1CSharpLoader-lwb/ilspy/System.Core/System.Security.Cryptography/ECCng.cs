using System.Runtime.InteropServices;
using Internal.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal static class ECCng
{
	private static readonly Func<string, bool, global::Interop.BCrypt.KeyBlobMagicNumber> s_ecdhNamedMagicResolver = (string curveName, bool includePrivate) => EcdhCurveNameToMagicNumber(curveName, includePrivate);

	private static readonly Func<bool, global::Interop.BCrypt.KeyBlobMagicNumber> s_ecdhExplicitMagicResolver = (bool includePrivate) => (!includePrivate) ? global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_GENERIC_MAGIC : global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_GENERIC_MAGIC;

	private static readonly Func<string, bool, global::Interop.BCrypt.KeyBlobMagicNumber> s_ecdsaNamedMagicResolver = (string curveName, bool includePrivate) => ECDsaCurveNameToMagicNumber(curveName, includePrivate);

	private static readonly Func<bool, global::Interop.BCrypt.KeyBlobMagicNumber> s_ecdsaExplicitMagicResolver = (bool includePrivate) => (!includePrivate) ? global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_GENERIC_MAGIC : global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_GENERIC_MAGIC;

	internal static ECParameters ExportExplicitParameters(CngKey key, bool includePrivateParameters)
	{
		ECParameters ecparams = default(ECParameters);
		ExportExplicitParameters(key, includePrivateParameters, ref ecparams);
		return ecparams;
	}

	internal static void ExportExplicitParameters(CngKey key, bool includePrivateParameters, ref ECParameters ecparams)
	{
		byte[] ecBlob = ExportFullKeyBlob(key, includePrivateParameters);
		ExportPrimeCurveParameters(ref ecparams, ecBlob, includePrivateParameters);
	}

	internal static ECParameters ExportParameters(CngKey key, bool includePrivateParameters)
	{
		ECParameters ecparams = default(ECParameters);
		ExportParameters(key, includePrivateParameters, ref ecparams);
		return ecparams;
	}

	internal static void ExportParameters(CngKey key, bool includePrivateParameters, ref ECParameters ecparams)
	{
		string curveName = key.GetCurveName();
		if (string.IsNullOrEmpty(curveName))
		{
			byte[] ecBlob = ExportFullKeyBlob(key, includePrivateParameters);
			ExportPrimeCurveParameters(ref ecparams, ecBlob, includePrivateParameters);
		}
		else
		{
			byte[] ecBlob2 = ExportKeyBlob(key, includePrivateParameters);
			ExportNamedCurveParameters(ref ecparams, ecBlob2, includePrivateParameters);
			ecparams.Curve = ECCurve.CreateFromFriendlyName(curveName);
		}
	}

	internal static byte[] ExportKeyBlob(CngKey key, bool includePrivateParameters, out CngKeyBlobFormat format, out string curveName)
	{
		curveName = key.GetCurveName();
		bool flag = false;
		if (string.IsNullOrEmpty(curveName))
		{
			curveName = null;
			flag = true;
			format = (includePrivateParameters ? CngKeyBlobFormat.EccFullPrivateBlob : CngKeyBlobFormat.EccFullPublicBlob);
		}
		else
		{
			format = (includePrivateParameters ? CngKeyBlobFormat.EccPrivateBlob : CngKeyBlobFormat.EccPublicBlob);
		}
		byte[] array = key.Export(format);
		if (flag)
		{
			FixupGenericBlob(array);
		}
		return array;
	}

	internal static CngKey ImportECDsaParameters(ref ECParameters ecparams)
	{
		CngKeyBlobFormat format;
		string curveName;
		byte[] blob = ECDsaParametersToBlob(ref ecparams, out format, out curveName);
		return ImportKeyBlob(blob, curveName, format, ecparams.Curve.CurveType);
	}

	internal static CngKey ImportEcdhParameters(ref ECParameters ecparams)
	{
		CngKeyBlobFormat format;
		string curveName;
		byte[] blob = EcdhParametersToBlob(ref ecparams, out format, out curveName);
		return ImportKeyBlob(blob, curveName, format, ecparams.Curve.CurveType);
	}

	internal static byte[] ECDsaParametersToBlob(ref ECParameters parameters, out CngKeyBlobFormat format, out string curveName)
	{
		return ParametersToBlob(ref parameters, s_ecdsaNamedMagicResolver, s_ecdsaExplicitMagicResolver, out format, out curveName);
	}

	internal static byte[] EcdhParametersToBlob(ref ECParameters parameters, out CngKeyBlobFormat format, out string curveName)
	{
		return ParametersToBlob(ref parameters, s_ecdhNamedMagicResolver, s_ecdhExplicitMagicResolver, out format, out curveName);
	}

	[SecuritySafeCritical]
	internal static SafeNCryptKeyHandle ImportKeyBlob(string blobType, byte[] keyBlob, string curveName, SafeNCryptProviderHandle provider)
	{
		global::Interop.BCrypt.BCryptBufferDesc bCryptBufferDesc = default(global::Interop.BCrypt.BCryptBufferDesc);
		global::Interop.BCrypt.BCryptBuffer bCryptBuffer = default(global::Interop.BCrypt.BCryptBuffer);
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		try
		{
			intPtr3 = Marshal.StringToHGlobalUni(curveName);
			intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)bCryptBufferDesc));
			intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf((object)bCryptBuffer));
			bCryptBuffer.cbBuffer = (curveName.Length + 1) * 2;
			bCryptBuffer.BufferType = global::Interop.BCrypt.NCryptBufferDescriptors.NCRYPTBUFFER_ECC_CURVE_NAME;
			bCryptBuffer.pvBuffer = intPtr3;
			Marshal.StructureToPtr((object)bCryptBuffer, intPtr2, fDeleteOld: false);
			bCryptBufferDesc.cBuffers = 1;
			bCryptBufferDesc.pBuffers = intPtr2;
			bCryptBufferDesc.ulVersion = 0;
			Marshal.StructureToPtr((object)bCryptBufferDesc, intPtr, fDeleteOld: false);
			return NCryptNative.ImportKey(provider, keyBlob, blobType, intPtr);
		}
		catch (CryptographicException ex)
		{
			if (ex.HResult == -2146893785)
			{
				throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_CurveNotSupported", curveName), ex);
			}
			throw;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
			Marshal.FreeHGlobal(intPtr2);
			Marshal.FreeHGlobal(intPtr3);
		}
	}

	private static global::Interop.BCrypt.KeyBlobMagicNumber ECDsaCurveNameToMagicNumber(string name, bool includePrivateParameters)
	{
		switch (CngKey.EcdsaCurveNameToAlgorithm(name).Algorithm)
		{
		case "ECDSA_P256":
			if (!includePrivateParameters)
			{
				return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P256_MAGIC;
			}
			return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P256_MAGIC;
		case "ECDSA_P384":
			if (!includePrivateParameters)
			{
				return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P384_MAGIC;
			}
			return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P384_MAGIC;
		case "ECDSA_P521":
			if (!includePrivateParameters)
			{
				return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P521_MAGIC;
			}
			return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P521_MAGIC;
		default:
			if (!includePrivateParameters)
			{
				return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_GENERIC_MAGIC;
			}
			return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_GENERIC_MAGIC;
		}
	}

	private static global::Interop.BCrypt.KeyBlobMagicNumber EcdhCurveNameToMagicNumber(string name, bool includePrivateParameters)
	{
		switch (CngKey.EcdhCurveNameToAlgorithm(name).Algorithm)
		{
		case "ECDH_P256":
			if (!includePrivateParameters)
			{
				return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_P256_MAGIC;
			}
			return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_P256_MAGIC;
		case "ECDH_P384":
			if (!includePrivateParameters)
			{
				return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_P384_MAGIC;
			}
			return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_P384_MAGIC;
		case "ECDH_P521":
			if (!includePrivateParameters)
			{
				return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_P521_MAGIC;
			}
			return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_P521_MAGIC;
		default:
			if (!includePrivateParameters)
			{
				return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_GENERIC_MAGIC;
			}
			return global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_GENERIC_MAGIC;
		}
	}

	[SecuritySafeCritical]
	private unsafe static byte[] GetNamedCurveBlob(ref ECParameters parameters, Func<string, bool, global::Interop.BCrypt.KeyBlobMagicNumber> magicResolver)
	{
		bool flag = parameters.D != null;
		int num = sizeof(global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB) + parameters.Q.X.Length + parameters.Q.Y.Length;
		if (flag)
		{
			num += parameters.D.Length;
		}
		byte[] array = new byte[num];
		fixed (byte* ptr = array)
		{
			global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB* ptr2 = (global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB*)ptr;
			ptr2->Magic = magicResolver(parameters.Curve.Oid.FriendlyName, flag);
			ptr2->cbKey = parameters.Q.X.Length;
		}
		int offset = sizeof(global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB);
		global::Interop.BCrypt.Emit(array, ref offset, parameters.Q.X);
		global::Interop.BCrypt.Emit(array, ref offset, parameters.Q.Y);
		if (flag)
		{
			global::Interop.BCrypt.Emit(array, ref offset, parameters.D);
		}
		return array;
	}

	[SecuritySafeCritical]
	private unsafe static byte[] GetPrimeCurveBlob(ref ECParameters parameters, Func<bool, global::Interop.BCrypt.KeyBlobMagicNumber> magicResolver)
	{
		bool flag = parameters.D != null;
		ECCurve curve = parameters.Curve;
		int num = sizeof(global::Interop.BCrypt.BCRYPT_ECCFULLKEY_BLOB) + curve.Prime.Length + curve.A.Length + curve.B.Length + curve.G.X.Length + curve.G.Y.Length + curve.Order.Length + curve.Cofactor.Length + ((curve.Seed != null) ? curve.Seed.Length : 0) + parameters.Q.X.Length + parameters.Q.Y.Length;
		if (flag)
		{
			num += parameters.D.Length;
		}
		byte[] array = new byte[num];
		fixed (byte* ptr = array)
		{
			global::Interop.BCrypt.BCRYPT_ECCFULLKEY_BLOB* ptr2 = (global::Interop.BCrypt.BCRYPT_ECCFULLKEY_BLOB*)ptr;
			ptr2->Version = 1;
			ptr2->Magic = magicResolver(flag);
			ptr2->cbCofactor = curve.Cofactor.Length;
			ptr2->cbFieldLength = parameters.Q.X.Length;
			ptr2->cbSeed = ((curve.Seed != null) ? curve.Seed.Length : 0);
			ptr2->cbSubgroupOrder = curve.Order.Length;
			ptr2->CurveGenerationAlgId = GetHashAlgorithmId(curve.Hash);
			ptr2->CurveType = ConvertToCurveTypeEnum(curve.CurveType);
		}
		int offset = sizeof(global::Interop.BCrypt.BCRYPT_ECCFULLKEY_BLOB);
		global::Interop.BCrypt.Emit(array, ref offset, curve.Prime);
		global::Interop.BCrypt.Emit(array, ref offset, curve.A);
		global::Interop.BCrypt.Emit(array, ref offset, curve.B);
		global::Interop.BCrypt.Emit(array, ref offset, curve.G.X);
		global::Interop.BCrypt.Emit(array, ref offset, curve.G.Y);
		global::Interop.BCrypt.Emit(array, ref offset, curve.Order);
		global::Interop.BCrypt.Emit(array, ref offset, curve.Cofactor);
		if (curve.Seed != null)
		{
			global::Interop.BCrypt.Emit(array, ref offset, curve.Seed);
		}
		global::Interop.BCrypt.Emit(array, ref offset, parameters.Q.X);
		global::Interop.BCrypt.Emit(array, ref offset, parameters.Q.Y);
		if (flag)
		{
			global::Interop.BCrypt.Emit(array, ref offset, parameters.D);
		}
		return array;
	}

	[SecuritySafeCritical]
	private unsafe static void ExportNamedCurveParameters(ref ECParameters ecParams, byte[] ecBlob, bool includePrivateParameters)
	{
		global::Interop.BCrypt.KeyBlobMagicNumber magic = (global::Interop.BCrypt.KeyBlobMagicNumber)BitConverter.ToInt32(ecBlob, 0);
		CheckMagicValueOfKey(magic, includePrivateParameters);
		if (ecBlob.Length < sizeof(global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB))
		{
			throw global::Interop.NCrypt.ErrorCode.E_FAIL.ToCryptographicException();
		}
		fixed (byte* ptr = ecBlob)
		{
			global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB* ptr2 = (global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB*)ptr;
			int offset = sizeof(global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB);
			ecParams.Q = new ECPoint
			{
				X = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbKey),
				Y = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbKey)
			};
			if (includePrivateParameters)
			{
				ecParams.D = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbKey);
			}
		}
	}

	[SecuritySafeCritical]
	internal unsafe static void ExportPrimeCurveParameters(ref ECParameters ecParams, byte[] ecBlob, bool includePrivateParameters)
	{
		global::Interop.BCrypt.KeyBlobMagicNumber magic = (global::Interop.BCrypt.KeyBlobMagicNumber)BitConverter.ToInt32(ecBlob, 0);
		CheckMagicValueOfKey(magic, includePrivateParameters);
		if (ecBlob.Length < sizeof(global::Interop.BCrypt.BCRYPT_ECCFULLKEY_BLOB))
		{
			throw global::Interop.NCrypt.ErrorCode.E_FAIL.ToCryptographicException();
		}
		fixed (byte* ptr = ecBlob)
		{
			global::Interop.BCrypt.BCRYPT_ECCFULLKEY_BLOB* ptr2 = (global::Interop.BCrypt.BCRYPT_ECCFULLKEY_BLOB*)ptr;
			ECCurve curve = new ECCurve
			{
				CurveType = ConvertToCurveTypeEnum(ptr2->CurveType),
				Hash = GetHashAlgorithmName(ptr2->CurveGenerationAlgId)
			};
			int offset = sizeof(global::Interop.BCrypt.BCRYPT_ECCFULLKEY_BLOB);
			curve.Prime = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbFieldLength);
			curve.A = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbFieldLength);
			curve.B = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbFieldLength);
			curve.G = new ECPoint
			{
				X = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbFieldLength),
				Y = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbFieldLength)
			};
			curve.Order = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbSubgroupOrder);
			curve.Cofactor = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbCofactor);
			curve.Seed = ((ptr2->cbSeed == 0) ? null : global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbSeed));
			ecParams.Q = new ECPoint
			{
				X = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbFieldLength),
				Y = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbFieldLength)
			};
			if (includePrivateParameters)
			{
				ecParams.D = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbSubgroupOrder);
			}
			ecParams.Curve = curve;
		}
	}

	[SecuritySafeCritical]
	internal unsafe static byte[] GetPrimeCurveParameterBlob(ref ECCurve curve)
	{
		int num = sizeof(global::Interop.BCrypt.BCRYPT_ECC_PARAMETER_HEADER) + curve.Prime.Length + curve.A.Length + curve.B.Length + curve.G.X.Length + curve.G.Y.Length + curve.Order.Length + curve.Cofactor.Length + ((curve.Seed != null) ? curve.Seed.Length : 0);
		byte[] array = new byte[num];
		fixed (byte* ptr = array)
		{
			global::Interop.BCrypt.BCRYPT_ECC_PARAMETER_HEADER* ptr2 = (global::Interop.BCrypt.BCRYPT_ECC_PARAMETER_HEADER*)ptr;
			ptr2->Version = 1;
			ptr2->cbCofactor = curve.Cofactor.Length;
			ptr2->cbFieldLength = curve.A.Length;
			ptr2->cbSeed = ((curve.Seed != null) ? curve.Seed.Length : 0);
			ptr2->cbSubgroupOrder = curve.Order.Length;
			ptr2->CurveGenerationAlgId = GetHashAlgorithmId(curve.Hash);
			ptr2->CurveType = ConvertToCurveTypeEnum(curve.CurveType);
		}
		int offset = sizeof(global::Interop.BCrypt.BCRYPT_ECC_PARAMETER_HEADER);
		global::Interop.BCrypt.Emit(array, ref offset, curve.Prime);
		global::Interop.BCrypt.Emit(array, ref offset, curve.A);
		global::Interop.BCrypt.Emit(array, ref offset, curve.B);
		global::Interop.BCrypt.Emit(array, ref offset, curve.G.X);
		global::Interop.BCrypt.Emit(array, ref offset, curve.G.Y);
		global::Interop.BCrypt.Emit(array, ref offset, curve.Order);
		global::Interop.BCrypt.Emit(array, ref offset, curve.Cofactor);
		if (curve.Seed != null)
		{
			global::Interop.BCrypt.Emit(array, ref offset, curve.Seed);
		}
		return array;
	}

	private static void CheckMagicValueOfKey(global::Interop.BCrypt.KeyBlobMagicNumber magic, bool includePrivateParameters)
	{
		if (includePrivateParameters)
		{
			if (!IsMagicValueOfKeyPrivate(magic))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_NotValidPrivateKey"));
			}
		}
		else if (!IsMagicValueOfKeyPublic(magic))
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_NotValidPublicOrPrivateKey"));
		}
	}

	private static bool IsMagicValueOfKeyPrivate(global::Interop.BCrypt.KeyBlobMagicNumber magic)
	{
		switch (magic)
		{
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_P256_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P256_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_P384_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P384_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_P521_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P521_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_GENERIC_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_GENERIC_MAGIC:
			return true;
		default:
			return false;
		}
	}

	private static bool IsMagicValueOfKeyPublic(global::Interop.BCrypt.KeyBlobMagicNumber magic)
	{
		switch (magic)
		{
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_P256_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P256_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_P384_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P384_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_P521_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P521_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_GENERIC_MAGIC:
		case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_GENERIC_MAGIC:
			return true;
		default:
			return IsMagicValueOfKeyPrivate(magic);
		}
	}

	private static global::Interop.BCrypt.ECC_CURVE_TYPE_ENUM ConvertToCurveTypeEnum(ECCurve.ECCurveType value)
	{
		return (global::Interop.BCrypt.ECC_CURVE_TYPE_ENUM)value;
	}

	private static ECCurve.ECCurveType ConvertToCurveTypeEnum(global::Interop.BCrypt.ECC_CURVE_TYPE_ENUM value)
	{
		return (ECCurve.ECCurveType)value;
	}

	private static global::Interop.BCrypt.ECC_CURVE_ALG_ID_ENUM GetHashAlgorithmId(HashAlgorithmName? name)
	{
		if (!name.HasValue || string.IsNullOrEmpty(name.Value.Name))
		{
			return global::Interop.BCrypt.ECC_CURVE_ALG_ID_ENUM.BCRYPT_NO_CURVE_GENERATION_ALG_ID;
		}
		global::Interop.Crypt32.CRYPT_OID_INFO cRYPT_OID_INFO = global::Interop.Crypt32.FindOidInfo(global::Interop.Crypt32.CryptOidInfoKeyType.CRYPT_OID_INFO_NAME_KEY, name.Value.Name, OidGroup.HashAlgorithm, fallBackToAllGroups: false);
		if (cRYPT_OID_INFO.AlgId == -1)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_UnknownHashAlgorithm", name.Value.Name));
		}
		return (global::Interop.BCrypt.ECC_CURVE_ALG_ID_ENUM)cRYPT_OID_INFO.AlgId;
	}

	private static HashAlgorithmName? GetHashAlgorithmName(global::Interop.BCrypt.ECC_CURVE_ALG_ID_ENUM hashId)
	{
		global::Interop.Crypt32.CRYPT_OID_INFO cRYPT_OID_INFO = global::Interop.Crypt32.FindAlgIdOidInfo((int)hashId);
		if (cRYPT_OID_INFO.AlgId == -1)
		{
			return null;
		}
		return new HashAlgorithmName(cRYPT_OID_INFO.Name);
	}

	[SecuritySafeCritical]
	private unsafe static void FixupGenericBlob(byte[] blob)
	{
		if (blob.Length <= sizeof(global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB))
		{
			return;
		}
		fixed (byte* ptr = blob)
		{
			global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB* ptr2 = (global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB*)ptr;
			switch (ptr2->Magic)
			{
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_P256_MAGIC:
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_P384_MAGIC:
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_P521_MAGIC:
				ptr2->Magic = global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PUBLIC_GENERIC_MAGIC;
				break;
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_P256_MAGIC:
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_P384_MAGIC:
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_P521_MAGIC:
				ptr2->Magic = global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDH_PRIVATE_GENERIC_MAGIC;
				break;
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P256_MAGIC:
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P384_MAGIC:
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P521_MAGIC:
				ptr2->Magic = global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_GENERIC_MAGIC;
				break;
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P256_MAGIC:
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P384_MAGIC:
			case global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P521_MAGIC:
				ptr2->Magic = global::Interop.BCrypt.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_GENERIC_MAGIC;
				break;
			}
		}
	}

	private static CngKey ImportKeyBlob(byte[] blob, string curveName, CngKeyBlobFormat format, ECCurve.ECCurveType curveType)
	{
		try
		{
			CngKey cngKey = CngKey.Import(blob, curveName, format);
			cngKey.ExportPolicy |= CngExportPolicies.AllowPlaintextExport;
			return cngKey;
		}
		catch (CryptographicException ex)
		{
			if (curveType != ECCurve.ECCurveType.Named && ex.HResult == -2146893783)
			{
				throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_CurveNotSupported", curveType), ex);
			}
			throw;
		}
	}

	private static byte[] ExportKeyBlob(CngKey key, bool includePrivateParameters)
	{
		CngKeyBlobFormat format = (includePrivateParameters ? CngKeyBlobFormat.EccPrivateBlob : CngKeyBlobFormat.EccPublicBlob);
		return key.Export(format);
	}

	private static byte[] ExportFullKeyBlob(CngKey key, bool includePrivateParameters)
	{
		CngKeyBlobFormat format = (includePrivateParameters ? CngKeyBlobFormat.EccFullPrivateBlob : CngKeyBlobFormat.EccFullPublicBlob);
		return key.Export(format);
	}

	private static byte[] ParametersToBlob(ref ECParameters parameters, Func<string, bool, global::Interop.BCrypt.KeyBlobMagicNumber> namedCurveResolver, Func<bool, global::Interop.BCrypt.KeyBlobMagicNumber> explicitCurveResolver, out CngKeyBlobFormat format, out string curveName)
	{
		parameters.Validate();
		ECCurve curve = parameters.Curve;
		bool flag = parameters.D != null;
		if (curve.IsPrime)
		{
			curveName = null;
			format = (flag ? CngKeyBlobFormat.EccFullPrivateBlob : CngKeyBlobFormat.EccFullPublicBlob);
			return GetPrimeCurveBlob(ref parameters, explicitCurveResolver);
		}
		if (curve.IsNamed)
		{
			curveName = curve.Oid.FriendlyName;
			if (string.IsNullOrEmpty(curveName))
			{
				throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_InvalidCurveOid", curve.Oid.Value.ToString()));
			}
			format = (flag ? CngKeyBlobFormat.EccPrivateBlob : CngKeyBlobFormat.EccPublicBlob);
			return GetNamedCurveBlob(ref parameters, namedCurveResolver);
		}
		throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_CurveNotSupported", curve.CurveType.ToString()));
	}
}
