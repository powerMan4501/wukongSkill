using System.Collections.Generic;

namespace System.Security.Cryptography.X509Certificates;

internal sealed class Pkcs9ExtensionRequest : X501Attribute
{
	internal Pkcs9ExtensionRequest(IEnumerable<X509Extension> extensions)
		: base("1.2.840.113549.1.9.14", EncodeAttribute(extensions))
	{
	}

	private static byte[] EncodeAttribute(IEnumerable<X509Extension> extensions)
	{
		if (extensions == null)
		{
			throw new ArgumentNullException("extensions");
		}
		List<byte[][]> list = new List<byte[][]>();
		foreach (X509Extension extension in extensions)
		{
			if (extension != null)
			{
				list.Add(extension.SegmentedEncodedX509Extension());
			}
		}
		return DerEncoder.ConstructSequence(list.ToArray());
	}
}
