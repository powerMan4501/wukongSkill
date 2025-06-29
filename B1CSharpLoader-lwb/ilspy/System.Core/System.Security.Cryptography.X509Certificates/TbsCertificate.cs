using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Security.Cryptography.X509Certificates;

internal sealed class TbsCertificate
{
	public byte Version { get; set; }

	public byte[] SerialNumber { get; set; }

	public byte[] SignatureAlgorithm { get; set; }

	public X500DistinguishedName Issuer { get; set; }

	public DateTimeOffset NotBefore { get; set; }

	public DateTimeOffset NotAfter { get; set; }

	public X500DistinguishedName Subject { get; set; }

	public PublicKey PublicKey { get; set; }

	public Collection<X509Extension> Extensions { get; } = new Collection<X509Extension>();

	private byte[] Encode(X509SignatureGenerator signatureGenerator, HashAlgorithmName hashAlgorithm)
	{
		List<byte[][]> list = new List<byte[][]>();
		byte version = Version;
		if (version != 0)
		{
			byte[][] array = DerEncoder.ConstructSegmentedSequence(DerEncoder.SegmentedEncodeUnsignedInteger(new byte[1] { version }));
			array[0][0] = 160;
			list.Add(array);
		}
		list.Add(DerEncoder.SegmentedEncodeUnsignedInteger(SerialNumber));
		byte[] array2 = SignatureAlgorithm ?? signatureGenerator.GetSignatureAlgorithmIdentifier(hashAlgorithm);
		EncodingHelpers.ValidateSignatureAlgorithm(array2);
		list.Add(array2.WrapAsSegmentedForSequence());
		list.Add(Issuer.RawData.WrapAsSegmentedForSequence());
		list.Add(DerEncoder.ConstructSegmentedSequence(EncodeValidityField(NotBefore, "NotBefore"), EncodeValidityField(NotAfter, "NotAfter")));
		list.Add(Subject.RawData.WrapAsSegmentedForSequence());
		list.Add(PublicKey.SegmentedEncodeSubjectPublicKeyInfo());
		if (Extensions.Count > 0)
		{
			List<byte[][]> list2 = new List<byte[][]>(Extensions.Count);
			HashSet<string> hashSet = new HashSet<string>(Extensions.Count);
			foreach (X509Extension extension in Extensions)
			{
				if (extension != null)
				{
					if (!hashSet.Add(extension.Oid.Value))
					{
						throw new InvalidOperationException(System.SR.GetString("Cryptography_CertReq_DuplicateExtension", extension.Oid.Value));
					}
					list2.Add(extension.SegmentedEncodedX509Extension());
				}
			}
			byte[][] array3 = DerEncoder.ConstructSegmentedSequence(DerEncoder.ConstructSegmentedSequence(list2));
			array3[0][0] = 163;
			list.Add(array3);
		}
		return DerEncoder.ConstructSequence(list);
	}

	private static byte[][] EncodeValidityField(DateTimeOffset validityField, string propertyName)
	{
		DateTime utcDateTime = validityField.UtcDateTime;
		if (utcDateTime.Year < 1950)
		{
			throw new ArgumentOutOfRangeException(propertyName, utcDateTime, System.SR.GetString("Cryptography_CertReq_DateTooOld"));
		}
		if (utcDateTime.Year < 2050)
		{
			return DerEncoder.SegmentedEncodeUtcTime(utcDateTime);
		}
		return DerEncoder.SegmentedEncodeGeneralizedTime(utcDateTime);
	}

	internal byte[] Sign(X509SignatureGenerator signatureGenerator, HashAlgorithmName hashAlgorithm)
	{
		if (signatureGenerator == null)
		{
			throw new ArgumentNullException("signatureGenerator");
		}
		byte[] array = Encode(signatureGenerator, hashAlgorithm);
		byte[] data = signatureGenerator.SignData(array, hashAlgorithm);
		byte[] signatureAlgorithmIdentifier = signatureGenerator.GetSignatureAlgorithmIdentifier(hashAlgorithm);
		EncodingHelpers.ValidateSignatureAlgorithm(signatureAlgorithmIdentifier);
		return DerEncoder.ConstructSequence(array.WrapAsSegmentedForSequence(), signatureAlgorithmIdentifier.WrapAsSegmentedForSequence(), DerEncoder.SegmentedEncodeBitString(data));
	}
}
