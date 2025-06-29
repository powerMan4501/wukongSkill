using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Internal.Cryptography;

internal static class SymmetricImportExportExtensions
{
	private const int SizeOf_NCRYPT_KEY_BLOB_HEADER_SIZE = 16;

	private const int SizeOf_BCRYPT_KEY_DATA_BLOB_HEADER = 12;

	private static readonly CngKeyBlobFormat s_cipherKeyBlobFormat = new CngKeyBlobFormat("CipherKeyBlob");

	public static CngKey ToCngKey(this byte[] key, string algorithm)
	{
		int capacity = 16 + (algorithm.Length + 1) * 2 + 12 + key.Length;
		using MemoryStream memoryStream = new MemoryStream(capacity);
		using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.Unicode))
		{
			binaryWriter.Write(16);
			binaryWriter.Write(1380470851);
			binaryWriter.Write((algorithm.Length + 1) * 2);
			binaryWriter.Write(12 + key.Length);
			binaryWriter.Write(algorithm.ToCharArray());
			binaryWriter.Write('\0');
			binaryWriter.Write(1296188491);
			binaryWriter.Write(1);
			binaryWriter.Write(key.Length);
			binaryWriter.Write(key);
		}
		byte[] keyBlob = memoryStream.ToArray();
		return CngKey.Import(keyBlob, s_cipherKeyBlobFormat);
	}

	public static byte[] GetSymmetricKeyDataIfExportable(this CngKey cngKey, string algorithm)
	{
		byte[] buffer = cngKey.Export(s_cipherKeyBlobFormat);
		using MemoryStream input = new MemoryStream(buffer);
		using BinaryReader binaryReader = new BinaryReader(input, Encoding.Unicode);
		int num = binaryReader.ReadInt32();
		if (num != 16)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_KeyBlobParsingError"));
		}
		int num2 = binaryReader.ReadInt32();
		if (num2 != 1380470851)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_KeyBlobParsingError"));
		}
		int num3 = binaryReader.ReadInt32();
		binaryReader.ReadInt32();
		string text = new string(binaryReader.ReadChars(num3 / 2 - 1));
		if (text != algorithm)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_CngKeyWrongAlgorithm", text, algorithm));
		}
		if (binaryReader.ReadChar() != 0)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_KeyBlobParsingError"));
		}
		int num4 = binaryReader.ReadInt32();
		if (num4 != 1296188491)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_KeyBlobParsingError"));
		}
		int num5 = binaryReader.ReadInt32();
		if (num5 != 1)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_KeyBlobParsingError"));
		}
		int count = binaryReader.ReadInt32();
		return binaryReader.ReadBytes(count);
	}
}
