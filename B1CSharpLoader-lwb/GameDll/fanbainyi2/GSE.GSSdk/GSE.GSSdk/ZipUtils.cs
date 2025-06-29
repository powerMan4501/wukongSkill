using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace GSE.GSSdk;

public class ZipUtils
{
	public static string CompressBase64(string src)
	{
		if (string.IsNullOrEmpty(src) || src.Length == 0)
		{
			return "";
		}
		return Convert.ToBase64String(Compress(Encoding.Default.GetBytes(src.ToString())));
	}

	public static string DecompressBase64(string zsrc)
	{
		if (string.IsNullOrEmpty(zsrc) || zsrc.Length == 0)
		{
			return "";
		}
		byte[] zsrc2 = Convert.FromBase64String(zsrc.ToString());
		return Encoding.Default.GetString(Decompress(zsrc2));
	}

	public static byte[] Compress(byte[] src)
	{
		MemoryStream memoryStream = new MemoryStream();
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
		gZipStream.Write(src, 0, src.Length);
		gZipStream.Close();
		return memoryStream.ToArray();
	}

	public static byte[] Decompress(byte[] zsrc)
	{
		GZipStream gZipStream = new GZipStream(new MemoryStream(zsrc), CompressionMode.Decompress);
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = new byte[1024];
		while (true)
		{
			int num = gZipStream.Read(array, 0, array.Length);
			if (num <= 0)
			{
				break;
			}
			memoryStream.Write(array, 0, num);
		}
		gZipStream.Close();
		return memoryStream.ToArray();
	}
}
