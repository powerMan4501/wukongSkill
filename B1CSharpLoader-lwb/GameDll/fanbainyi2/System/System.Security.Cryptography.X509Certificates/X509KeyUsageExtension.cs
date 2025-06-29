using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509KeyUsageExtension : X509Extension
{
	private uint m_keyUsages;

	private bool m_decoded;

	public X509KeyUsageFlags KeyUsages
	{
		get
		{
			if (!m_decoded)
			{
				DecodeExtension();
			}
			return (X509KeyUsageFlags)m_keyUsages;
		}
	}

	public X509KeyUsageExtension()
		: base("2.5.29.15")
	{
		m_decoded = true;
	}

	public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
		: base("2.5.29.15", EncodeExtension(keyUsages), critical)
	{
	}

	public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
		: base("2.5.29.15", encodedKeyUsage.RawData, critical)
	{
	}

	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
		base.CopyFrom(asnEncodedData);
		m_decoded = false;
	}

	private void DecodeExtension()
	{
		uint cbDecodedValue = 0u;
		SafeLocalAllocHandle decodedValue = null;
		if (!CAPI.DecodeObject(new IntPtr(14L), m_rawData, out decodedValue, out cbDecodedValue))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		CAPIBase.CRYPTOAPI_BLOB cRYPTOAPI_BLOB = (CAPIBase.CRYPTOAPI_BLOB)Marshal.PtrToStructure(decodedValue.DangerousGetHandle(), typeof(CAPIBase.CRYPTOAPI_BLOB));
		if (cRYPTOAPI_BLOB.cbData > 4)
		{
			cRYPTOAPI_BLOB.cbData = 4u;
		}
		byte[] array = new byte[4];
		if (cRYPTOAPI_BLOB.pbData != IntPtr.Zero)
		{
			Marshal.Copy(cRYPTOAPI_BLOB.pbData, array, 0, (int)cRYPTOAPI_BLOB.cbData);
		}
		m_keyUsages = BitConverter.ToUInt32(array, 0);
		m_decoded = true;
		decodedValue.Dispose();
	}

	private unsafe static byte[] EncodeExtension(X509KeyUsageFlags keyUsages)
	{
		CAPIBase.CRYPT_BIT_BLOB cRYPT_BIT_BLOB = new CAPIBase.CRYPT_BIT_BLOB
		{
			cbData = 2u,
			pbData = new IntPtr(&keyUsages),
			cUnusedBits = 0u
		};
		byte[] encodedData = null;
		if (!CAPI.EncodeObject("2.5.29.15", new IntPtr(&cRYPT_BIT_BLOB), out encodedData))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return encodedData;
	}
}
