using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security.Cryptography;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ECDiffieHellmanCngPublicKey : ECDiffieHellmanPublicKey
{
	private CngKeyBlobFormat m_format;

	[OptionalField]
	private string m_curveName;

	public CngKeyBlobFormat BlobFormat => m_format;

	[SecuritySafeCritical]
	internal ECDiffieHellmanCngPublicKey(byte[] keyBlob, string curveName, CngKeyBlobFormat format)
		: base(keyBlob)
	{
		m_format = format;
		m_curveName = curveName;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[SecuritySafeCritical]
	public static ECDiffieHellmanPublicKey FromByteArray(byte[] publicKeyBlob, CngKeyBlobFormat format)
	{
		if (publicKeyBlob == null)
		{
			throw new ArgumentNullException("publicKeyBlob");
		}
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		using CngKey cngKey = CngKey.Import(publicKeyBlob, format);
		if (cngKey.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDHRequiresECDHKey"));
		}
		return new ECDiffieHellmanCngPublicKey(publicKeyBlob, null, format);
	}

	internal static ECDiffieHellmanCngPublicKey FromKey(CngKey key)
	{
		CngKeyBlobFormat format;
		string curveName;
		byte[] keyBlob = ECCng.ExportKeyBlob(key, includePrivateParameters: false, out format, out curveName);
		return new ECDiffieHellmanCngPublicKey(keyBlob, curveName, format);
	}

	[SecuritySafeCritical]
	public static ECDiffieHellmanCngPublicKey FromXmlString(string xml)
	{
		if (xml == null)
		{
			throw new ArgumentNullException("xml");
		}
		bool isEcdh;
		ECParameters parameters = Rfc4050KeyFormatter.FromXml(xml, out isEcdh);
		if (!isEcdh)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDHRequiresECDHKey"), "xml");
		}
		CngKeyBlobFormat format;
		string curveName;
		byte[] keyBlob = ECCng.EcdhParametersToBlob(ref parameters, out format, out curveName);
		return new ECDiffieHellmanCngPublicKey(keyBlob, curveName, format);
	}

	public CngKey Import()
	{
		return CngKey.Import(ToByteArray(), m_curveName, BlobFormat);
	}

	public override string ToXmlString()
	{
		ECParameters parameters = ExportParameters();
		return Rfc4050KeyFormatter.ToXml(parameters, isEcdh: true);
	}

	public override ECParameters ExportExplicitParameters()
	{
		using CngKey key = Import();
		return ECCng.ExportExplicitParameters(key, includePrivateParameters: false);
	}

	public override ECParameters ExportParameters()
	{
		using CngKey key = Import();
		return ECCng.ExportParameters(key, includePrivateParameters: false);
	}
}
