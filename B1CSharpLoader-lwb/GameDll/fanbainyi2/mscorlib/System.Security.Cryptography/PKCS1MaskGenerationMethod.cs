using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class PKCS1MaskGenerationMethod : MaskGenerationMethod
{
	private string HashNameValue;

	public string HashName
	{
		get
		{
			return HashNameValue;
		}
		set
		{
			HashNameValue = value;
			if (HashNameValue == null)
			{
				HashNameValue = "SHA1";
			}
		}
	}

	public PKCS1MaskGenerationMethod()
	{
		HashNameValue = "SHA1";
	}

	public override byte[] GenerateMask(byte[] rgbSeed, int cbReturn)
	{
		HashAlgorithm hashAlgorithm = (HashAlgorithm)CryptoConfig.CreateFromName(HashNameValue);
		byte[] counter = new byte[4];
		byte[] array = new byte[cbReturn];
		uint num = 0u;
		for (int i = 0; i < array.Length; i += hashAlgorithm.Hash.Length)
		{
			Utils.ConvertIntToByteArray(num++, ref counter);
			hashAlgorithm.TransformBlock(rgbSeed, 0, rgbSeed.Length, rgbSeed, 0);
			hashAlgorithm.TransformFinalBlock(counter, 0, 4);
			byte[] hash = hashAlgorithm.Hash;
			hashAlgorithm.Initialize();
			if (array.Length - i > hash.Length)
			{
				Buffer.BlockCopy(hash, 0, array, i, hash.Length);
			}
			else
			{
				Buffer.BlockCopy(hash, 0, array, i, array.Length - i);
			}
		}
		return array;
	}
}
