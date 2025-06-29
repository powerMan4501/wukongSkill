using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Security.Cryptography.X509Certificates;

internal class Pkcs10CertificationRequestInfo
{
	private static readonly byte[][] s_encodedVersion = DerEncoder.SegmentedEncodeUnsignedInteger(new byte[1]);

	internal X500DistinguishedName Subject { get; set; }

	internal PublicKey PublicKey { get; set; }

	internal Collection<X501Attribute> Attributes { get; } = new Collection<X501Attribute>();

	internal Pkcs10CertificationRequestInfo(X500DistinguishedName subject, PublicKey publicKey, IEnumerable<X501Attribute> attributes)
	{
		if (subject == null)
		{
			throw new ArgumentNullException("subject");
		}
		if (publicKey == null)
		{
			throw new ArgumentNullException("publicKey");
		}
		Subject = subject;
		PublicKey = publicKey;
		if (attributes == null)
		{
			return;
		}
		Collection<X501Attribute> attributes2 = Attributes;
		foreach (X501Attribute attribute in attributes)
		{
			attributes2.Add(attribute);
		}
	}

	private byte[] Encode()
	{
		byte[][] array = Attributes.SegmentedEncodeAttributeSet();
		array[0][0] = 160;
		return DerEncoder.ConstructSequence(s_encodedVersion, Subject.RawData.WrapAsSegmentedForSequence(), PublicKey.SegmentedEncodeSubjectPublicKeyInfo(), array);
	}

	internal byte[] ToPkcs10Request(X509SignatureGenerator signatureGenerator, HashAlgorithmName hashAlgorithm)
	{
		byte[] array = Encode();
		byte[] data = signatureGenerator.SignData(array, hashAlgorithm);
		byte[] signatureAlgorithmIdentifier = signatureGenerator.GetSignatureAlgorithmIdentifier(hashAlgorithm);
		EncodingHelpers.ValidateSignatureAlgorithm(signatureAlgorithmIdentifier);
		return DerEncoder.ConstructSequence(array.WrapAsSegmentedForSequence(), signatureAlgorithmIdentifier.WrapAsSegmentedForSequence(), DerEncoder.SegmentedEncodeBitString(data));
	}
}
