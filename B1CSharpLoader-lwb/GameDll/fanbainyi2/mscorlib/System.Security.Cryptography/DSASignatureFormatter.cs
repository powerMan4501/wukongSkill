using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class DSASignatureFormatter : AsymmetricSignatureFormatter
{
	private DSA _dsaKey;

	private string _oid;

	public DSASignatureFormatter()
	{
		_oid = CryptoConfig.MapNameToOID("SHA1", OidGroup.HashAlgorithm);
	}

	public DSASignatureFormatter(AsymmetricAlgorithm key)
		: this()
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		_dsaKey = (DSA)key;
	}

	public override void SetKey(AsymmetricAlgorithm key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		_dsaKey = (DSA)key;
	}

	public override void SetHashAlgorithm(string strName)
	{
		if (CryptoConfig.MapNameToOID(strName, OidGroup.HashAlgorithm) != _oid)
		{
			throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Cryptography_InvalidOperation"));
		}
	}

	public override byte[] CreateSignature(byte[] rgbHash)
	{
		if (rgbHash == null)
		{
			throw new ArgumentNullException("rgbHash");
		}
		if (_oid == null)
		{
			throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Cryptography_MissingOID"));
		}
		if (_dsaKey == null)
		{
			throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Cryptography_MissingKey"));
		}
		return _dsaKey.CreateSignature(rgbHash);
	}
}
