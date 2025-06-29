using System.IO;
using System.Runtime.InteropServices;
using System.Security.Util;
using System.Text;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class DSA : AsymmetricAlgorithm
{
	public new static DSA Create()
	{
		return Create("System.Security.Cryptography.DSA");
	}

	public new static DSA Create(string algName)
	{
		return (DSA)CryptoConfig.CreateFromName(algName);
	}

	public static DSA Create(int keySizeInBits)
	{
		DSA dSA = (DSA)CryptoConfig.CreateFromName("DSA-FIPS186-3");
		dSA.KeySize = keySizeInBits;
		if (dSA.KeySize != keySizeInBits)
		{
			throw new CryptographicException();
		}
		return dSA;
	}

	public static DSA Create(DSAParameters parameters)
	{
		DSA dSA = (DSA)CryptoConfig.CreateFromName("DSA-FIPS186-3");
		dSA.ImportParameters(parameters);
		return dSA;
	}

	public abstract byte[] CreateSignature(byte[] rgbHash);

	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
	{
		throw DerivedClassMustOverride();
	}

	protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
	{
		throw DerivedClassMustOverride();
	}

	public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return SignData(data, 0, data.Length, hashAlgorithm);
	}

	public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (offset < 0 || offset > data.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > data.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw HashAlgorithmNameNullOrEmpty();
		}
		byte[] rgbHash = HashData(data, offset, count, hashAlgorithm);
		return CreateSignature(rgbHash);
	}

	public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw HashAlgorithmNameNullOrEmpty();
		}
		byte[] rgbHash = HashData(data, hashAlgorithm);
		return CreateSignature(rgbHash);
	}

	public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return VerifyData(data, 0, data.Length, signature, hashAlgorithm);
	}

	public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (offset < 0 || offset > data.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > data.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw HashAlgorithmNameNullOrEmpty();
		}
		byte[] rgbHash = HashData(data, offset, count, hashAlgorithm);
		return VerifySignature(rgbHash, signature);
	}

	public virtual bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw HashAlgorithmNameNullOrEmpty();
		}
		byte[] rgbHash = HashData(data, hashAlgorithm);
		return VerifySignature(rgbHash, signature);
	}

	public override void FromXmlString(string xmlString)
	{
		if (xmlString == null)
		{
			throw new ArgumentNullException("xmlString");
		}
		DSAParameters parameters = default(DSAParameters);
		Parser parser = new Parser(xmlString);
		SecurityElement topElement = parser.GetTopElement();
		string text = topElement.SearchForTextOfLocalName("P");
		if (text == null)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidFromXmlString", "DSA", "P"));
		}
		parameters.P = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text));
		string text2 = topElement.SearchForTextOfLocalName("Q");
		if (text2 == null)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidFromXmlString", "DSA", "Q"));
		}
		parameters.Q = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text2));
		string text3 = topElement.SearchForTextOfLocalName("G");
		if (text3 == null)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidFromXmlString", "DSA", "G"));
		}
		parameters.G = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text3));
		string text4 = topElement.SearchForTextOfLocalName("Y");
		if (text4 == null)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidFromXmlString", "DSA", "Y"));
		}
		parameters.Y = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text4));
		string text5 = topElement.SearchForTextOfLocalName("J");
		if (text5 != null)
		{
			parameters.J = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text5));
		}
		string text6 = topElement.SearchForTextOfLocalName("X");
		if (text6 != null)
		{
			parameters.X = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text6));
		}
		string text7 = topElement.SearchForTextOfLocalName("Seed");
		string text8 = topElement.SearchForTextOfLocalName("PgenCounter");
		if (text7 != null && text8 != null)
		{
			parameters.Seed = Convert.FromBase64String(Utils.DiscardWhiteSpaces(text7));
			parameters.Counter = Utils.ConvertByteArrayToInt(Convert.FromBase64String(Utils.DiscardWhiteSpaces(text8)));
		}
		else if (text7 != null || text8 != null)
		{
			if (text7 == null)
			{
				throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidFromXmlString", "DSA", "Seed"));
			}
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidFromXmlString", "DSA", "PgenCounter"));
		}
		ImportParameters(parameters);
	}

	public override string ToXmlString(bool includePrivateParameters)
	{
		DSAParameters dSAParameters = ExportParameters(includePrivateParameters);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<DSAKeyValue>");
		stringBuilder.Append("<P>" + Convert.ToBase64String(dSAParameters.P) + "</P>");
		stringBuilder.Append("<Q>" + Convert.ToBase64String(dSAParameters.Q) + "</Q>");
		stringBuilder.Append("<G>" + Convert.ToBase64String(dSAParameters.G) + "</G>");
		stringBuilder.Append("<Y>" + Convert.ToBase64String(dSAParameters.Y) + "</Y>");
		if (dSAParameters.J != null)
		{
			stringBuilder.Append("<J>" + Convert.ToBase64String(dSAParameters.J) + "</J>");
		}
		if (dSAParameters.Seed != null)
		{
			stringBuilder.Append("<Seed>" + Convert.ToBase64String(dSAParameters.Seed) + "</Seed>");
			stringBuilder.Append("<PgenCounter>" + Convert.ToBase64String(Utils.ConvertIntToByteArray(dSAParameters.Counter)) + "</PgenCounter>");
		}
		if (includePrivateParameters)
		{
			stringBuilder.Append("<X>" + Convert.ToBase64String(dSAParameters.X) + "</X>");
		}
		stringBuilder.Append("</DSAKeyValue>");
		return stringBuilder.ToString();
	}

	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	public abstract void ImportParameters(DSAParameters parameters);

	private static Exception DerivedClassMustOverride()
	{
		return new NotImplementedException(Environment.GetResourceString("NotSupported_SubclassOverride"));
	}

	internal static Exception HashAlgorithmNameNullOrEmpty()
	{
		return new ArgumentException(Environment.GetResourceString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
	}
}
