using System.Collections.Generic;

namespace System.Security.Cryptography.X509Certificates;

internal static class EncodingHelpers
{
	internal static readonly byte[] s_emptyArray = new byte[0];

	internal static byte[][] WrapAsSegmentedForSequence(this byte[] derData)
	{
		return new byte[3][] { s_emptyArray, s_emptyArray, derData };
	}

	internal static void ValidateSignatureAlgorithm(byte[] signatureAlgorithm)
	{
		DerSequenceReader derSequenceReader = new DerSequenceReader(signatureAlgorithm);
		derSequenceReader.ReadOidAsString();
		if (derSequenceReader.HasData)
		{
			derSequenceReader.ValidateAndSkipDerValue();
		}
		if (derSequenceReader.HasData)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
	}

	internal static byte[][] SegmentedEncodeSubjectPublicKeyInfo(this PublicKey publicKey)
	{
		if (publicKey == null)
		{
			throw new ArgumentNullException("publicKey");
		}
		if (publicKey.Oid == null || string.IsNullOrEmpty(publicKey.Oid.Value) || publicKey.EncodedKeyValue == null)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPublicKey_Object"));
		}
		byte[][] array;
		if (publicKey.EncodedParameters == null)
		{
			array = DerEncoder.ConstructSegmentedSequence(DerEncoder.SegmentedEncodeOid(publicKey.Oid));
		}
		else
		{
			DerSequenceReader derSequenceReader = DerSequenceReader.CreateForPayload(publicKey.EncodedParameters.RawData);
			derSequenceReader.ValidateAndSkipDerValue();
			if (derSequenceReader.HasData)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
			}
			array = DerEncoder.ConstructSegmentedSequence(DerEncoder.SegmentedEncodeOid(publicKey.Oid), publicKey.EncodedParameters.RawData.WrapAsSegmentedForSequence());
		}
		return DerEncoder.ConstructSegmentedSequence(array, DerEncoder.SegmentedEncodeBitString(publicKey.EncodedKeyValue.RawData));
	}

	internal static byte[][] SegmentedEncodedX509Extension(this X509Extension extension)
	{
		if (extension.Critical)
		{
			return DerEncoder.ConstructSegmentedSequence(DerEncoder.SegmentedEncodeOid(extension.Oid), DerEncoder.SegmentedEncodeBoolean(extension.Critical), DerEncoder.SegmentedEncodeOctetString(extension.RawData));
		}
		return DerEncoder.ConstructSegmentedSequence(DerEncoder.SegmentedEncodeOid(extension.Oid), DerEncoder.SegmentedEncodeOctetString(extension.RawData));
	}

	internal static byte[][] SegmentedEncodeAttributeSet(this IEnumerable<X501Attribute> attributes)
	{
		List<byte[][]> list = new List<byte[][]>();
		foreach (X501Attribute attribute in attributes)
		{
			list.Add(DerEncoder.ConstructSegmentedSequence(DerEncoder.SegmentedEncodeOid(attribute.Oid), DerEncoder.ConstructSegmentedPresortedSet(attribute.RawData.WrapAsSegmentedForSequence())));
		}
		return DerEncoder.ConstructSegmentedSet(list.ToArray());
	}
}
