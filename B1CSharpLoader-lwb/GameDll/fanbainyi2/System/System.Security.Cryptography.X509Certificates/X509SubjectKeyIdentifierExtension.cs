using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509SubjectKeyIdentifierExtension : X509Extension
{
	private string m_subjectKeyIdentifier;

	private bool m_decoded;

	public string SubjectKeyIdentifier
	{
		get
		{
			if (!m_decoded)
			{
				DecodeExtension();
			}
			return m_subjectKeyIdentifier;
		}
	}

	public X509SubjectKeyIdentifierExtension()
		: base("2.5.29.14")
	{
		m_subjectKeyIdentifier = null;
		m_decoded = true;
	}

	public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
		: base("2.5.29.14", EncodeExtension(subjectKeyIdentifier), critical)
	{
	}

	public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical)
		: base("2.5.29.14", EncodeExtension(subjectKeyIdentifier), critical)
	{
	}

	public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
		: base("2.5.29.14", encodedSubjectKeyIdentifier.RawData, critical)
	{
	}

	public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
		: base("2.5.29.14", EncodePublicKey(key, X509SubjectKeyIdentifierHashAlgorithm.Sha1), critical)
	{
	}

	public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
		: base("2.5.29.14", EncodePublicKey(key, algorithm), critical)
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
		SafeLocalAllocHandle safeLocalAllocHandle = X509Utils.StringToAnsiPtr("2.5.29.14");
		if (!CAPI.DecodeObject(safeLocalAllocHandle.DangerousGetHandle(), m_rawData, out decodedValue, out cbDecodedValue))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		CAPIBase.CRYPTOAPI_BLOB blob = (CAPIBase.CRYPTOAPI_BLOB)Marshal.PtrToStructure(decodedValue.DangerousGetHandle(), typeof(CAPIBase.CRYPTOAPI_BLOB));
		byte[] sArray = CAPI.BlobToByteArray(blob);
		m_subjectKeyIdentifier = X509Utils.EncodeHexString(sArray);
		m_decoded = true;
		decodedValue.Dispose();
		safeLocalAllocHandle.Dispose();
	}

	private static byte[] EncodeExtension(string subjectKeyIdentifier)
	{
		if (subjectKeyIdentifier == null)
		{
			throw new ArgumentNullException("subjectKeyIdentifier");
		}
		return EncodeExtension(X509Utils.DecodeHexString(subjectKeyIdentifier));
	}

	private unsafe static byte[] EncodeExtension(byte[] subjectKeyIdentifier)
	{
		if (subjectKeyIdentifier == null)
		{
			throw new ArgumentNullException("subjectKeyIdentifier");
		}
		if (subjectKeyIdentifier.Length == 0)
		{
			throw new ArgumentException("subjectKeyIdentifier");
		}
		byte[] encodedData = null;
		fixed (byte* value = subjectKeyIdentifier)
		{
			CAPIBase.CRYPTOAPI_BLOB cRYPTOAPI_BLOB = new CAPIBase.CRYPTOAPI_BLOB
			{
				pbData = new IntPtr(value),
				cbData = (uint)subjectKeyIdentifier.Length
			};
			if (!CAPI.EncodeObject("2.5.29.14", new IntPtr(&cRYPTOAPI_BLOB), out encodedData))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
		return encodedData;
	}

	private unsafe static SafeLocalAllocHandle EncodePublicKey(PublicKey key)
	{
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		CAPIBase.CERT_PUBLIC_KEY_INFO2* ptr = null;
		string value = key.Oid.Value;
		byte[] rawData = key.EncodedParameters.RawData;
		byte[] rawData2 = key.EncodedKeyValue.RawData;
		uint num = (uint)(Marshal.SizeOf(typeof(CAPIBase.CERT_PUBLIC_KEY_INFO2)) + X509Utils.AlignedLength((uint)(value.Length + 1)) + X509Utils.AlignedLength((uint)rawData.Length) + rawData2.Length);
		invalidHandle = CAPI.LocalAlloc(64u, new IntPtr(num));
		ptr = (CAPIBase.CERT_PUBLIC_KEY_INFO2*)(void*)invalidHandle.DangerousGetHandle();
		IntPtr intPtr = new IntPtr((long)ptr + (long)Marshal.SizeOf(typeof(CAPIBase.CERT_PUBLIC_KEY_INFO2)));
		IntPtr intPtr2 = new IntPtr((long)intPtr + X509Utils.AlignedLength((uint)(value.Length + 1)));
		IntPtr intPtr3 = new IntPtr((long)intPtr2 + X509Utils.AlignedLength((uint)rawData.Length));
		ptr->Algorithm.pszObjId = intPtr;
		byte[] array = new byte[value.Length + 1];
		Encoding.ASCII.GetBytes(value, 0, value.Length, array, 0);
		Marshal.Copy(array, 0, intPtr, array.Length);
		if (rawData.Length != 0)
		{
			ptr->Algorithm.Parameters.cbData = (uint)rawData.Length;
			ptr->Algorithm.Parameters.pbData = intPtr2;
			Marshal.Copy(rawData, 0, intPtr2, rawData.Length);
		}
		ptr->PublicKey.cbData = (uint)rawData2.Length;
		ptr->PublicKey.pbData = intPtr3;
		Marshal.Copy(rawData2, 0, intPtr3, rawData2.Length);
		return invalidHandle;
	}

	private unsafe static byte[] EncodePublicKey(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		SafeLocalAllocHandle safeLocalAllocHandle = EncodePublicKey(key);
		CAPIBase.CERT_PUBLIC_KEY_INFO2* ptr = (CAPIBase.CERT_PUBLIC_KEY_INFO2*)(void*)safeLocalAllocHandle.DangerousGetHandle();
		byte[] array = new byte[20];
		byte[] array2 = null;
		fixed (byte* value = array)
		{
			uint num = (uint)array.Length;
			IntPtr pbComputedHash = new IntPtr(value);
			try
			{
				if (algorithm == X509SubjectKeyIdentifierHashAlgorithm.Sha1 || X509SubjectKeyIdentifierHashAlgorithm.ShortSha1 == algorithm)
				{
					if (!CAPISafe.CryptHashCertificate(IntPtr.Zero, 32772u, 0u, ptr->PublicKey.pbData, ptr->PublicKey.cbData, pbComputedHash, new IntPtr(&num)))
					{
						throw new CryptographicException(Marshal.GetHRForLastWin32Error());
					}
				}
				else
				{
					if (X509SubjectKeyIdentifierHashAlgorithm.CapiSha1 != algorithm)
					{
						throw new ArgumentException("algorithm");
					}
					if (!CAPISafe.CryptHashPublicKeyInfo(IntPtr.Zero, 32772u, 0u, 1u, new IntPtr(ptr), pbComputedHash, new IntPtr(&num)))
					{
						throw new CryptographicException(Marshal.GetHRForLastWin32Error());
					}
				}
				if (X509SubjectKeyIdentifierHashAlgorithm.ShortSha1 == algorithm)
				{
					array2 = new byte[8];
					Array.Copy(array, array.Length - 8, array2, 0, array2.Length);
					array2[0] &= 15;
					array2[0] |= 64;
				}
				else
				{
					array2 = array;
					if (array.Length > (int)num)
					{
						array2 = new byte[num];
						Array.Copy(array, 0, array2, 0, array2.Length);
					}
				}
			}
			finally
			{
				safeLocalAllocHandle.Dispose();
			}
		}
		return EncodeExtension(array2);
	}
}
