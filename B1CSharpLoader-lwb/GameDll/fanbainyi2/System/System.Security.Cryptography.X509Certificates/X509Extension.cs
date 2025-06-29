using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

public class X509Extension : AsnEncodedData
{
	private bool m_critical;

	public bool Critical
	{
		get
		{
			return m_critical;
		}
		set
		{
			m_critical = value;
		}
	}

	internal X509Extension(string oid)
		: base(new Oid(oid, System.Security.Cryptography.OidGroup.ExtensionOrAttribute, lookupFriendlyName: false))
	{
	}

	internal X509Extension(IntPtr pExtension)
	{
		CAPIBase.CERT_EXTENSION cERT_EXTENSION = (CAPIBase.CERT_EXTENSION)Marshal.PtrToStructure(pExtension, typeof(CAPIBase.CERT_EXTENSION));
		m_critical = cERT_EXTENSION.fCritical;
		string pszObjId = cERT_EXTENSION.pszObjId;
		m_oid = new Oid(pszObjId, System.Security.Cryptography.OidGroup.ExtensionOrAttribute, lookupFriendlyName: false);
		byte[] array = new byte[cERT_EXTENSION.Value.cbData];
		if (cERT_EXTENSION.Value.pbData != IntPtr.Zero)
		{
			Marshal.Copy(cERT_EXTENSION.Value.pbData, array, 0, array.Length);
		}
		m_rawData = array;
	}

	protected X509Extension()
	{
	}

	public X509Extension(string oid, byte[] rawData, bool critical)
		: this(new Oid(oid, System.Security.Cryptography.OidGroup.ExtensionOrAttribute, lookupFriendlyName: true), rawData, critical)
	{
	}

	public X509Extension(AsnEncodedData encodedExtension, bool critical)
		: this(encodedExtension.Oid, encodedExtension.RawData, critical)
	{
	}

	public X509Extension(Oid oid, byte[] rawData, bool critical)
		: base(oid, rawData)
	{
		if (base.Oid == null || base.Oid.Value == null)
		{
			throw new ArgumentNullException("oid");
		}
		if (base.Oid.Value.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Arg_EmptyOrNullString"), "oid.Value");
		}
		m_critical = critical;
	}

	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
		if (asnEncodedData == null)
		{
			throw new ArgumentNullException("asnEncodedData");
		}
		if (!(asnEncodedData is X509Extension x509Extension))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_X509_ExtensionMismatch"));
		}
		base.CopyFrom(asnEncodedData);
		m_critical = x509Extension.Critical;
	}
}
