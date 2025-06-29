namespace System.Security.Cryptography.X509Certificates;

internal struct PfxAsn
{
	internal int Version;

	internal ContentInfoAsn AuthSafe;

	internal MacData? MacData;

	private const uint MaxIterationWork = 600000u;

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out PfxAsn decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out PfxAsn decoded)
	{
		try
		{
			DecodeCore(ref reader, expectedTag, rebind, out decoded);
		}
		catch (InvalidOperationException inner)
		{
			throw new CryptographicException("ASN1 corrupted data.", inner);
		}
	}

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out PfxAsn decoded)
	{
		decoded = default(PfxAsn);
		AsnValueReader reader2 = reader.ReadSequence(expectedTag);
		if (!reader2.TryReadInt32(out decoded.Version))
		{
			reader2.ThrowIfNotEmpty();
		}
		ContentInfoAsn.Decode(ref reader2, rebind, out decoded.AuthSafe);
		if (reader2.HasData && reader2.PeekTag().HasSameClassAndValue(Asn1Tag.Sequence))
		{
			System.Security.Cryptography.X509Certificates.MacData.Decode(ref reader2, rebind, out var decoded2);
			decoded.MacData = decoded2;
		}
		reader2.ThrowIfNotEmpty();
	}

	internal ulong CountTotalIterations()
	{
		ulong num = 0uL;
		if (!Helpers.SequenceEqual(AuthSafe.ContentType, Oids.Pkcs7Data))
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		ReadOnlyMemory<byte> rebind = Helpers.DecodeOctetStringAsMemory(AuthSafe.Content);
		AsnValueReader asnValueReader = new AsnValueReader(rebind.Span, AsnEncodingRules.BER);
		AsnValueReader reader = asnValueReader.ReadSequence();
		asnValueReader.ThrowIfNotEmpty();
		bool flag = false;
		checked
		{
			while (reader.HasData)
			{
				ContentInfoAsn.Decode(ref reader, rebind, out var decoded);
				ArraySegment<byte>? arraySegment = null;
				try
				{
					ReadOnlyMemory<byte> rebind2;
					if (!Helpers.SequenceEqual(decoded.ContentType, Oids.Pkcs7Data))
					{
						if (!Helpers.SequenceEqual(decoded.ContentType, Oids.Pkcs7Encrypted))
						{
							throw new CryptographicException(Environment.GetResourceString("Cryptography_X509_PfxWithoutPassword"));
						}
						if (flag)
						{
							throw new CryptographicException(Environment.GetResourceString("Cryptography_X509_PfxWithoutPassword"));
						}
						uint iterations;
						ArraySegment<byte> arraySegment2 = DecryptContentInfo(decoded, out iterations);
						rebind2 = arraySegment2;
						arraySegment = arraySegment2;
						flag = true;
						num += iterations;
					}
					else
					{
						rebind2 = Helpers.DecodeOctetStringAsMemory(decoded.Content);
					}
					AsnValueReader asnValueReader2 = new AsnValueReader(rebind2.Span, AsnEncodingRules.BER);
					AsnValueReader reader2 = asnValueReader2.ReadSequence();
					asnValueReader2.ThrowIfNotEmpty();
					while (reader2.HasData)
					{
						SafeBagAsn.Decode(ref reader2, rebind2, out var decoded2);
						if (Helpers.SequenceEqual(decoded2.BagId, Oids.Pkcs12ShroudedKeyBag))
						{
							AsnValueReader reader3 = new AsnValueReader(decoded2.BagValue.Span, AsnEncodingRules.BER);
							EncryptedPrivateKeyInfoAsn.Decode(ref reader3, decoded2.BagValue, out var decoded3);
							num += IterationsFromParameters(ref decoded3.EncryptionAlgorithm);
						}
					}
				}
				finally
				{
					if (arraySegment.HasValue)
					{
						CryptoPool.Return(arraySegment.Value);
					}
				}
			}
			if (MacData.HasValue)
			{
				if (MacData.Value.IterationCount < 0)
				{
					throw new CryptographicException("ASN1 corrupted data.");
				}
				num += (uint)MacData.Value.IterationCount;
			}
			return num;
		}
	}

	private static ArraySegment<byte> DecryptContentInfo(ContentInfoAsn contentInfo, out uint iterations)
	{
		char[] array = new char[0];
		byte[] array2 = new byte[0];
		char[] array3 = null;
		byte[] array4 = null;
		EncryptedDataAsn encryptedDataAsn = EncryptedDataAsn.Decode(contentInfo.Content, AsnEncodingRules.BER);
		if (encryptedDataAsn.Version != 0 && encryptedDataAsn.Version != 2)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		if (!Helpers.SequenceEqual(encryptedDataAsn.EncryptedContentInfo.ContentType, Oids.Pkcs7Data))
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		if (!encryptedDataAsn.EncryptedContentInfo.EncryptedContent.HasValue)
		{
			throw new CryptographicException("ASN1 corrupted data.");
		}
		iterations = IterationsFromParameters(ref encryptedDataAsn.EncryptedContentInfo.ContentEncryptionAlgorithm);
		if (iterations > 600000)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_X509_PfxWithoutPassword"));
		}
		int length = encryptedDataAsn.EncryptedContentInfo.EncryptedContent.Value.Length;
		byte[] array5 = new byte[length];
		int num = 0;
		try
		{
			num = PasswordBasedEncryption.Decrypt(ref encryptedDataAsn.EncryptedContentInfo.ContentEncryptionAlgorithm, array, array2, encryptedDataAsn.EncryptedContentInfo.EncryptedContent.Value.Span, array5);
			AsnValueReader asnValueReader = new AsnValueReader(new ReadOnlySpan<byte>(array5, 0, num), AsnEncodingRules.BER);
			AsnValueReader asnValueReader2 = asnValueReader.ReadSequence();
			asnValueReader.ThrowIfNotEmpty();
		}
		catch
		{
			num = PasswordBasedEncryption.Decrypt(ref encryptedDataAsn.EncryptedContentInfo.ContentEncryptionAlgorithm, array3, array4, encryptedDataAsn.EncryptedContentInfo.EncryptedContent.Value.Span, array5);
			AsnValueReader asnValueReader3 = new AsnValueReader(new ReadOnlySpan<byte>(array5, 0, num), AsnEncodingRules.BER);
			AsnValueReader asnValueReader4 = asnValueReader3.ReadSequence();
			asnValueReader3.ThrowIfNotEmpty();
		}
		finally
		{
			if (num == 0)
			{
				CryptographicOperations.ZeroMemory(array5);
			}
		}
		return new ArraySegment<byte>(array5, 0, num);
	}

	private static uint IterationsFromParameters(ref AlgorithmIdentifierAsn algorithmIdentifier)
	{
		if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PasswordBasedEncryptionScheme2))
		{
			if (!algorithmIdentifier.Parameters.HasValue)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			PBES2Params pBES2Params = PBES2Params.Decode(algorithmIdentifier.Parameters.Value, AsnEncodingRules.BER);
			if (!Helpers.SequenceEqual(pBES2Params.KeyDerivationFunc.Algorithm, Oids.Pbkdf2))
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			if (!pBES2Params.KeyDerivationFunc.Parameters.HasValue)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			Pbkdf2Params pbkdf2Params = Pbkdf2Params.Decode(pBES2Params.KeyDerivationFunc.Parameters.Value, AsnEncodingRules.BER);
			if (pbkdf2Params.IterationCount < 0)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			return (uint)pbkdf2Params.IterationCount;
		}
		if (Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PbeWithMD5AndDESCBC) || Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PbeWithMD5AndRC2CBC) || Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PbeWithSha1AndDESCBC) || Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.PbeWithSha1AndRC2CBC) || Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.Pkcs12PbeWithShaAnd3Key3Des) || Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.Pkcs12PbeWithShaAnd2Key3Des) || Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.Pkcs12PbeWithShaAnd128BitRC2) || Helpers.SequenceEqual(algorithmIdentifier.Algorithm, Oids.Pkcs12PbeWithShaAnd40BitRC2))
		{
			if (!algorithmIdentifier.Parameters.HasValue)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			PBEParameter pBEParameter = PBEParameter.Decode(algorithmIdentifier.Parameters.Value, AsnEncodingRules.BER);
			if (pBEParameter.IterationCount < 0)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			return (uint)pBEParameter.IterationCount;
		}
		throw new CryptographicException("ASN1 corrupted data.");
	}
}
