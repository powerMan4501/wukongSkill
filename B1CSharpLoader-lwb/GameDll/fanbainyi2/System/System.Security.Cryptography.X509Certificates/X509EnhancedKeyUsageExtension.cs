using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509EnhancedKeyUsageExtension : X509Extension
{
	private OidCollection m_enhancedKeyUsages;

	private bool m_decoded;

	public OidCollection EnhancedKeyUsages
	{
		get
		{
			if (!m_decoded)
			{
				DecodeExtension();
			}
			OidCollection oidCollection = new OidCollection();
			OidEnumerator enumerator = m_enhancedKeyUsages.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Oid current = enumerator.Current;
				oidCollection.Add(current);
			}
			return oidCollection;
		}
	}

	public X509EnhancedKeyUsageExtension()
		: base("2.5.29.37")
	{
		m_enhancedKeyUsages = new OidCollection();
		m_decoded = true;
	}

	public X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical)
		: base("2.5.29.37", EncodeExtension(enhancedKeyUsages), critical)
	{
	}

	public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
		: base("2.5.29.37", encodedEnhancedKeyUsages.RawData, critical)
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
		if (!CAPI.DecodeObject(new IntPtr(36L), m_rawData, out decodedValue, out cbDecodedValue))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		CAPIBase.CERT_ENHKEY_USAGE cERT_ENHKEY_USAGE = (CAPIBase.CERT_ENHKEY_USAGE)Marshal.PtrToStructure(decodedValue.DangerousGetHandle(), typeof(CAPIBase.CERT_ENHKEY_USAGE));
		m_enhancedKeyUsages = new OidCollection();
		for (int i = 0; i < cERT_ENHKEY_USAGE.cUsageIdentifier; i++)
		{
			IntPtr ptr = Marshal.ReadIntPtr(new IntPtr((long)cERT_ENHKEY_USAGE.rgpszUsageIdentifier + i * Marshal.SizeOf(typeof(IntPtr))));
			string oid = Marshal.PtrToStringAnsi(ptr);
			Oid oid2 = new Oid(oid, System.Security.Cryptography.OidGroup.ExtensionOrAttribute, lookupFriendlyName: false);
			m_enhancedKeyUsages.Add(oid2);
		}
		m_decoded = true;
		decodedValue.Dispose();
	}

	private unsafe static byte[] EncodeExtension(OidCollection enhancedKeyUsages)
	{
		if (enhancedKeyUsages == null)
		{
			throw new ArgumentNullException("enhancedKeyUsages");
		}
		SafeLocalAllocHandle safeLocalAllocHandle = X509Utils.CopyOidsToUnmanagedMemory(enhancedKeyUsages);
		byte[] encodedData = null;
		using (safeLocalAllocHandle)
		{
			CAPIBase.CERT_ENHKEY_USAGE cERT_ENHKEY_USAGE = new CAPIBase.CERT_ENHKEY_USAGE
			{
				cUsageIdentifier = (uint)enhancedKeyUsages.Count,
				rgpszUsageIdentifier = safeLocalAllocHandle.DangerousGetHandle()
			};
			if (!CAPI.EncodeObject("2.5.29.37", new IntPtr(&cERT_ENHKEY_USAGE), out encodedData))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			return encodedData;
		}
	}
}
