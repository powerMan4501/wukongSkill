namespace b1;

public class Cipher
{
	public static void XorEncrypt(byte[] encryptData, byte[] magic_key)
	{
		for (int i = 0; i < encryptData.Length; i++)
		{
			int num = i % magic_key.Length;
			encryptData[i] ^= magic_key[num];
		}
	}

	public static void XorDecrypt(byte[] indata, byte[] magic_key)
	{
		XorEncrypt(indata, magic_key);
	}
}
