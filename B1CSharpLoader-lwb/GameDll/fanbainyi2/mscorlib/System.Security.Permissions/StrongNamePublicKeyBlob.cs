using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class StrongNamePublicKeyBlob
{
	internal byte[] PublicKey;

	internal StrongNamePublicKeyBlob()
	{
	}

	public StrongNamePublicKeyBlob(byte[] publicKey)
	{
		if (publicKey == null)
		{
			throw new ArgumentNullException("PublicKey");
		}
		PublicKey = new byte[publicKey.Length];
		Array.Copy(publicKey, 0, PublicKey, 0, publicKey.Length);
	}

	internal StrongNamePublicKeyBlob(string publicKey)
	{
		PublicKey = Hex.DecodeHexString(publicKey);
	}

	private static bool CompareArrays(byte[] first, byte[] second)
	{
		if (first.Length != second.Length)
		{
			return false;
		}
		int num = first.Length;
		for (int i = 0; i < num; i++)
		{
			if (first[i] != second[i])
			{
				return false;
			}
		}
		return true;
	}

	internal bool Equals(StrongNamePublicKeyBlob blob)
	{
		if (blob == null)
		{
			return false;
		}
		return CompareArrays(PublicKey, blob.PublicKey);
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is StrongNamePublicKeyBlob))
		{
			return false;
		}
		return Equals((StrongNamePublicKeyBlob)obj);
	}

	private static int GetByteArrayHashCode(byte[] baData)
	{
		if (baData == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < baData.Length; i++)
		{
			num = (num << 8) ^ baData[i] ^ (num >> 24);
		}
		return num;
	}

	public override int GetHashCode()
	{
		return GetByteArrayHashCode(PublicKey);
	}

	public override string ToString()
	{
		return Hex.EncodeHexString(PublicKey);
	}
}
