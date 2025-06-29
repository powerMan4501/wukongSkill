using System.Text;

namespace System.Security.Cryptography.X509Certificates;

internal static class PasswordBasedEncryption
{
	internal const int IterationLimit = 600000;

	private static readonly byte[] s_Empty = new byte[0];

	private static CryptographicException AlgorithmKdfRequiresChars()
	{
		return new CryptographicException("The KDF requires a char-based password input.");
	}

	[SecuritySafeCritical]
	internal unsafe static int Decrypt(ref AlgorithmIdentifierAsn algorithmIdentifier, ReadOnlySpan<char> password, ReadOnlySpan<byte> passwordBytes, ReadOnlySpan<byte> encryptedData, Span<byte> destination)
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		bool flag = false;
		HashAlgorithmName hashAlgorithm;
		if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PbeWithMD5AndDESCBC))
		{
			hashAlgorithm = HashAlgorithmName.MD5;
			symmetricAlgorithm = DES.Create();
		}
		else if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PbeWithMD5AndRC2CBC))
		{
			hashAlgorithm = HashAlgorithmName.MD5;
			symmetricAlgorithm = RC2.Create();
		}
		else if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PbeWithSha1AndDESCBC))
		{
			hashAlgorithm = HashAlgorithmName.SHA1;
			symmetricAlgorithm = DES.Create();
		}
		else if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PbeWithSha1AndRC2CBC))
		{
			hashAlgorithm = HashAlgorithmName.SHA1;
			symmetricAlgorithm = RC2.Create();
		}
		else if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.Pkcs12PbeWithShaAnd3Key3Des))
		{
			hashAlgorithm = HashAlgorithmName.SHA1;
			symmetricAlgorithm = TripleDES.Create();
			flag = true;
		}
		else if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.Pkcs12PbeWithShaAnd2Key3Des))
		{
			hashAlgorithm = HashAlgorithmName.SHA1;
			symmetricAlgorithm = TripleDES.Create();
			symmetricAlgorithm.KeySize = 128;
			flag = true;
		}
		else if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.Pkcs12PbeWithShaAnd128BitRC2))
		{
			hashAlgorithm = HashAlgorithmName.SHA1;
			symmetricAlgorithm = RC2.Create();
			symmetricAlgorithm.KeySize = 128;
			flag = true;
		}
		else
		{
			if (!Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.Pkcs12PbeWithShaAnd40BitRC2))
			{
				if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PasswordBasedEncryptionScheme2))
				{
					return Pbes2Decrypt(algorithmIdentifier.Parameters, password, passwordBytes, encryptedData, destination);
				}
				throw new CryptographicException("The algorithm is unknown, not valid for the requested usage, or was not handled.");
			}
			hashAlgorithm = HashAlgorithmName.SHA1;
			symmetricAlgorithm = RC2.Create();
			symmetricAlgorithm.KeySize = 40;
			flag = true;
		}
		using (symmetricAlgorithm)
		{
			if (flag)
			{
				if (password.Length == 0 && passwordBytes.Length > 0)
				{
					throw AlgorithmKdfRequiresChars();
				}
				return Pkcs12PbeDecrypt(algorithmIdentifier, password, hashAlgorithm, symmetricAlgorithm, encryptedData, destination);
			}
			using IncrementalHash hasher = IncrementalHash.CreateHash(hashAlgorithm);
			Span<byte> span = new byte[128];
			ReadOnlySpan<byte> password2 = default(ReadOnlySpan<byte>);
			byte[] array = null;
			Encoding encoding = null;
			if (passwordBytes.Length > 0 || password.Length == 0)
			{
				password2 = passwordBytes;
			}
			else
			{
				encoding = Encoding.UTF8;
				int num = Utility.EncodingGetByteCount(encoding, password);
				if (num > span.Length)
				{
					array = CryptoPool.Rent(num);
					span = new Span<byte>(array, 0, num);
				}
				else
				{
					span = span.Slice(0, num);
				}
			}
			fixed (byte* ptr = span.DangerousGetArrayForPinning())
			{
				if (encoding != null)
				{
					int length = Utility.EncodingGetBytes(encoding, password, span);
					span = span.Slice(0, length);
					password2 = span;
				}
				try
				{
					return Pbes1Decrypt(algorithmIdentifier.Parameters, password2, hasher, symmetricAlgorithm, encryptedData, destination);
				}
				finally
				{
					CryptographicOperations.ZeroMemory(span);
					if (array != null)
					{
						CryptoPool.Return(array, 0);
					}
				}
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe static int Pbes2Decrypt(ReadOnlyMemory<byte>? algorithmParameters, ReadOnlySpan<char> password, ReadOnlySpan<byte> passwordBytes, ReadOnlySpan<byte> encryptedData, Span<byte> destination)
	{
		Span<byte> span = new byte[128];
		ReadOnlySpan<byte> password2 = default(ReadOnlySpan<byte>);
		byte[] array = null;
		Encoding encoding = null;
		if (passwordBytes.Length > 0 || password.Length == 0)
		{
			password2 = passwordBytes;
		}
		else
		{
			encoding = Encoding.UTF8;
			int num = Utility.EncodingGetByteCount(encoding, password);
			if (num > span.Length)
			{
				array = CryptoPool.Rent(num);
				span = new Span<byte>(array, 0, num);
			}
			else
			{
				span = span.Slice(0, num);
			}
		}
		fixed (byte* ptr = span.DangerousGetArrayForPinning())
		{
			if (encoding != null)
			{
				int length = Utility.EncodingGetBytes(encoding, password, span);
				span = span.Slice(0, length);
				password2 = span;
			}
			try
			{
				return Pbes2Decrypt(algorithmParameters, password2, encryptedData, destination);
			}
			finally
			{
				if (array != null)
				{
					CryptoPool.Return(array, span.Length);
				}
			}
		}
	}

	private static int Pbes2Decrypt(ReadOnlyMemory<byte>? algorithmParameters, ReadOnlySpan<byte> password, ReadOnlySpan<byte> encryptedData, Span<byte> destination)
	{
		if (!algorithmParameters.HasValue)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		PBES2Params pBES2Params = PBES2Params.Decode(algorithmParameters.Value, AsnEncodingRules.BER);
		if (!Helpers.SequenceEqual(pBES2Params.KeyDerivationFunc.Algorithm, Oids.Pbkdf2))
		{
			throw new CryptographicException("The algorithm is unknown, not valid for the requested usage, or was not handled.");
		}
		int? requestedKeyLength;
		int iterationCount;
		ReadOnlyMemory<byte> saltMemory;
		HashAlgorithmName hashAlgorithmName = OpenPbkdf2(pBES2Params.KeyDerivationFunc.Parameters, out requestedKeyLength, out iterationCount, out saltMemory);
		Span<byte> iv = new byte[16];
		SymmetricAlgorithm symmetricAlgorithm = OpenCipher(pBES2Params.EncryptionScheme, requestedKeyLength, ref iv);
		using (symmetricAlgorithm)
		{
			byte[] array = new byte[password.Length];
			byte[] array2 = new byte[saltMemory.Length];
			password.CopyTo(array);
			saltMemory.CopyTo(array2);
			byte[] array3 = Pbkdf2.Derive(hashAlgorithmName.Name, array, array2, iterationCount, symmetricAlgorithm.KeySize / 8);
			try
			{
				return Decrypt(symmetricAlgorithm, array3, iv, encryptedData, destination);
			}
			finally
			{
				CryptographicOperations.ZeroMemory(array);
				CryptographicOperations.ZeroMemory(array2);
				CryptographicOperations.ZeroMemory(array3);
			}
		}
	}

	private static SymmetricAlgorithm OpenCipher(AlgorithmIdentifierAsn encryptionScheme, int? requestedKeyLength, ref Span<byte> iv)
	{
		byte[] algorithm = encryptionScheme.Algorithm;
		if (Helpers.SequenceEqual(algorithm, Oids.Aes128Cbc) || Helpers.SequenceEqual(algorithm, Oids.Aes192Cbc) || Helpers.SequenceEqual(algorithm, Oids.Aes256Cbc))
		{
			int num;
			if (Helpers.SequenceEqual(algorithm, Oids.Aes128Cbc))
			{
				num = 16;
			}
			else if (Helpers.SequenceEqual(algorithm, Oids.Aes192Cbc))
			{
				num = 24;
			}
			else
			{
				if (!Helpers.SequenceEqual(algorithm, Oids.Aes256Cbc))
				{
					throw new CryptographicException();
				}
				num = 32;
			}
			if (requestedKeyLength.HasValue && requestedKeyLength != num)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			ReadIvParameter(encryptionScheme.Parameters, 16, ref iv);
			Rijndael rijndael = Rijndael.Create();
			rijndael.KeySize = num * 8;
			return rijndael;
		}
		if (Helpers.SequenceEqual(algorithm, Oids.TripleDesCbc))
		{
			if (requestedKeyLength.HasValue && requestedKeyLength != 24)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			ReadIvParameter(encryptionScheme.Parameters, 8, ref iv);
			return TripleDES.Create();
		}
		if (Helpers.SequenceEqual(algorithm, Oids.Rc2Cbc))
		{
			if (!encryptionScheme.Parameters.HasValue)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			if (!requestedKeyLength.HasValue)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			Rc2CbcParameters rc2CbcParameters = Rc2CbcParameters.Decode(encryptionScheme.Parameters.Value, AsnEncodingRules.BER);
			if (rc2CbcParameters.Iv.Length != 8)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			RC2 rC = RC2.Create();
			rC.KeySize = requestedKeyLength.Value * 8;
			rC.EffectiveKeySize = rc2CbcParameters.GetEffectiveKeyBits();
			rc2CbcParameters.Iv.Span.CopyTo(iv);
			iv = iv.Slice(0, rc2CbcParameters.Iv.Length);
			return rC;
		}
		if (Helpers.SequenceEqual(algorithm, Oids.DesCbc))
		{
			if (requestedKeyLength.HasValue && requestedKeyLength != 8)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			ReadIvParameter(encryptionScheme.Parameters, 8, ref iv);
			return DES.Create();
		}
		throw new CryptographicException("The algorithm is unknown, not valid for the requested usage, or was not handled.");
	}

	private static void ReadIvParameter(ReadOnlyMemory<byte>? encryptionSchemeParameters, int length, ref Span<byte> iv)
	{
		if (!encryptionSchemeParameters.HasValue)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		try
		{
			ReadOnlySpan<byte> span = encryptionSchemeParameters.Value.Span;
			if (!AsnDecoder.TryReadOctetString(span, iv, AsnEncodingRules.BER, out var bytesConsumed, out var bytesWritten, null) || bytesWritten != length || bytesConsumed != span.Length)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			iv = iv.Slice(0, bytesWritten);
		}
		catch (InvalidOperationException inner)
		{
			throw new CryptographicException("ASN1 corrupted data.", inner);
		}
	}

	private static HashAlgorithmName OpenPbkdf2(ReadOnlyMemory<byte>? parameters, out int? requestedKeyLength, out int iterationCount, out ReadOnlyMemory<byte> saltMemory)
	{
		if (!parameters.HasValue)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		Pbkdf2Params pbkdf2Params = Pbkdf2Params.Decode(parameters.Value, AsnEncodingRules.BER);
		if (pbkdf2Params.Salt.OtherSource.HasValue)
		{
			throw new CryptographicException("The algorithm is unknown, not valid for the requested usage, or was not handled.");
		}
		if (!pbkdf2Params.Salt.Specified.HasValue)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		HashAlgorithmName result;
		if (Helpers.SequenceEqual(pbkdf2Params.Prf.Algorithm, Oids.HmacWithSha1))
		{
			result = HashAlgorithmName.SHA1;
		}
		else if (Helpers.SequenceEqual(pbkdf2Params.Prf.Algorithm, Oids.HmacWithSha256))
		{
			result = HashAlgorithmName.SHA256;
		}
		else if (Helpers.SequenceEqual(pbkdf2Params.Prf.Algorithm, Oids.HmacWithSha384))
		{
			result = HashAlgorithmName.SHA384;
		}
		else
		{
			if (!Helpers.SequenceEqual(pbkdf2Params.Prf.Algorithm, Oids.HmacWithSha512))
			{
				throw new CryptographicException("The algorithm is unknown, not valid for the requested usage, or was not handled.");
			}
			result = HashAlgorithmName.SHA512;
		}
		if (!pbkdf2Params.Prf.HasNullEquivalentParameters())
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		requestedKeyLength = pbkdf2Params.KeyLength;
		iterationCount = NormalizeIterationCount(pbkdf2Params.IterationCount, null);
		saltMemory = pbkdf2Params.Salt.Specified.Value;
		return result;
	}

	private static int Pbes1Decrypt(ReadOnlyMemory<byte>? algorithmParameters, ReadOnlySpan<byte> password, IncrementalHash hasher, SymmetricAlgorithm cipher, ReadOnlySpan<byte> encryptedData, Span<byte> destination)
	{
		if (!algorithmParameters.HasValue)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		PBEParameter pBEParameter = PBEParameter.Decode(algorithmParameters.Value, AsnEncodingRules.BER);
		if (pBEParameter.Salt.Length != 8)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		if (pBEParameter.IterationCount < 1)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		int iterationCount = NormalizeIterationCount(pBEParameter.IterationCount, null);
		Span<byte> span = new byte[16];
		try
		{
			Pbkdf1(hasher, password, pBEParameter.Salt.Span, iterationCount, span);
			Span<byte> span2 = span.Slice(0, 8);
			Span<byte> span3 = span.Slice(8, 8);
			return Decrypt(cipher, span2, span3, encryptedData, destination);
		}
		finally
		{
			CryptographicOperations.ZeroMemory(span);
		}
	}

	private static int Pkcs12PbeDecrypt(AlgorithmIdentifierAsn algorithmIdentifier, ReadOnlySpan<char> password, HashAlgorithmName hashAlgorithm, SymmetricAlgorithm cipher, ReadOnlySpan<byte> encryptedData, Span<byte> destination)
	{
		if (!algorithmIdentifier.Parameters.HasValue)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		if (cipher.KeySize > 256 || cipher.BlockSize > 256)
		{
			throw new CryptographicException();
		}
		PBEParameter pBEParameter = PBEParameter.Decode(algorithmIdentifier.Parameters.Value, AsnEncodingRules.BER);
		int iterationCount = NormalizeIterationCount(pBEParameter.IterationCount, 600000);
		Span<byte> span = new byte[cipher.BlockSize / 8];
		Span<byte> span2 = new byte[cipher.KeySize / 8];
		ReadOnlySpan<byte> span3 = pBEParameter.Salt.Span;
		try
		{
			Pkcs12Kdf.DeriveIV(password, hashAlgorithm, iterationCount, span3, span);
			Pkcs12Kdf.DeriveCipherKey(password, hashAlgorithm, iterationCount, span3, span2);
			return Decrypt(cipher, span2, span, encryptedData, destination);
		}
		finally
		{
			CryptographicOperations.ZeroMemory(span2);
			CryptographicOperations.ZeroMemory(span);
		}
	}

	[SecuritySafeCritical]
	private unsafe static int Decrypt(SymmetricAlgorithm cipher, ReadOnlySpan<byte> key, ReadOnlySpan<byte> iv, ReadOnlySpan<byte> encryptedData, Span<byte> destination)
	{
		byte[] array = new byte[key.Length];
		byte[] array2 = new byte[iv.Length];
		byte[] array3 = CryptoPool.Rent(encryptedData.Length);
		byte[] array4 = CryptoPool.Rent(destination.Length);
		fixed (byte* ptr = array)
		{
			fixed (byte* ptr2 = array2)
			{
				fixed (byte* ptr3 = array3)
				{
					fixed (byte* ptr4 = array4)
					{
						try
						{
							key.CopyTo(array);
							iv.CopyTo(array2);
							using ICryptoTransform cryptoTransform = cipher.CreateDecryptor(array, array2);
							encryptedData.CopyTo(array3);
							int num = cryptoTransform.TransformBlock(array3, 0, encryptedData.Length, array4, 0);
							new ReadOnlySpan<byte>(array4, 0, num).CopyTo(destination);
							byte[] array5 = cryptoTransform.TransformFinalBlock(s_Empty, 0, 0);
							fixed (byte* ptr5 = array5)
							{
								Span<byte> buffer = new Span<byte>(array5);
								buffer.CopyTo(destination.Slice(num));
								CryptographicOperations.ZeroMemory(buffer);
							}
							return num + array5.Length;
						}
						finally
						{
							CryptographicOperations.ZeroMemory(array);
							CryptographicOperations.ZeroMemory(array2);
							CryptoPool.Return(array3, encryptedData.Length);
							CryptoPool.Return(array4, destination.Length);
						}
					}
				}
			}
		}
	}

	private static void Pbkdf1(IncrementalHash hasher, ReadOnlySpan<byte> password, ReadOnlySpan<byte> salt, int iterationCount, Span<byte> dk)
	{
		Span<byte> destination = new byte[20];
		hasher.AppendData(password);
		hasher.AppendData(salt);
		if (!hasher.TryGetHashAndReset(destination, out var bytesWritten))
		{
			throw new CryptographicException();
		}
		destination = destination.Slice(0, bytesWritten);
		KdfWorkLimiter.RecordIterations(iterationCount);
		for (int i = 1; i < iterationCount; i++)
		{
			hasher.AppendData(destination);
			if (!hasher.TryGetHashAndReset(destination, out bytesWritten) || bytesWritten != destination.Length)
			{
				throw new CryptographicException();
			}
		}
		destination.Slice(0, dk.Length).CopyTo(dk);
		CryptographicOperations.ZeroMemory(destination);
	}

	internal static int NormalizeIterationCount(int iterationCount, int? iterationLimit)
	{
		if (iterationCount <= 0 || (iterationLimit.HasValue && iterationCount > iterationLimit.Value))
		{
			throw new CryptographicException("Value was invalid.");
		}
		return iterationCount;
	}
}
