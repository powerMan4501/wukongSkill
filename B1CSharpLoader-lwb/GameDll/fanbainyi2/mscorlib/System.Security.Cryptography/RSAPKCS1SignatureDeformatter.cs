using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
{
	private RSA _rsaKey;

	private string _strOID;

	private bool? _rsaOverridesVerifyHash;

	private bool OverridesVerifyHash
	{
		get
		{
			if (!_rsaOverridesVerifyHash.HasValue)
			{
				_rsaOverridesVerifyHash = Utils.DoesRsaKeyOverride(_rsaKey, "VerifyHash", new Type[4]
				{
					typeof(byte[]),
					typeof(byte[]),
					typeof(HashAlgorithmName),
					typeof(RSASignaturePadding)
				});
			}
			return _rsaOverridesVerifyHash.Value;
		}
	}

	public RSAPKCS1SignatureDeformatter()
	{
	}

	public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		_rsaKey = (RSA)key;
	}

	public override void SetKey(AsymmetricAlgorithm key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		_rsaKey = (RSA)key;
		_rsaOverridesVerifyHash = null;
	}

	public override void SetHashAlgorithm(string strName)
	{
		_strOID = CryptoConfig.MapNameToOID(strName, OidGroup.HashAlgorithm);
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
		if (_strOID == null)
		{
			throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Cryptography_MissingOID"));
		}
		if (_rsaKey == null)
		{
			throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Cryptography_MissingKey"));
		}
		if (_rsaKey is RSACryptoServiceProvider)
		{
			int algIdFromOid = X509Utils.GetAlgIdFromOid(_strOID, OidGroup.HashAlgorithm);
			return ((RSACryptoServiceProvider)_rsaKey).VerifyHash(rgbHash, algIdFromOid, rgbSignature);
		}
		if (OverridesVerifyHash)
		{
			HashAlgorithmName hashAlgorithm = Utils.OidToHashAlgorithmName(_strOID);
			return _rsaKey.VerifyHash(rgbHash, rgbSignature, hashAlgorithm, RSASignaturePadding.Pkcs1);
		}
		byte[] rhs = Utils.RsaPkcs1Padding(_rsaKey, CryptoConfig.EncodeOID(_strOID), rgbHash);
		return Utils.CompareBigIntArrays(_rsaKey.EncryptValue(rgbSignature), rhs);
	}
}
