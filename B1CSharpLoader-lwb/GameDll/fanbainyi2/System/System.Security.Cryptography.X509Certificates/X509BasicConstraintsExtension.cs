using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509BasicConstraintsExtension : X509Extension
{
	private bool m_isCA;

	private bool m_hasPathLenConstraint;

	private int m_pathLenConstraint;

	private bool m_decoded;

	public bool CertificateAuthority
	{
		get
		{
			if (!m_decoded)
			{
				DecodeExtension();
			}
			return m_isCA;
		}
	}

	public bool HasPathLengthConstraint
	{
		get
		{
			if (!m_decoded)
			{
				DecodeExtension();
			}
			return m_hasPathLenConstraint;
		}
	}

	public int PathLengthConstraint
	{
		get
		{
			if (!m_decoded)
			{
				DecodeExtension();
			}
			return m_pathLenConstraint;
		}
	}

	public X509BasicConstraintsExtension()
		: base("2.5.29.19")
	{
		m_decoded = true;
	}

	public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
		: base("2.5.29.19", EncodeExtension(certificateAuthority, hasPathLengthConstraint, pathLengthConstraint), critical)
	{
	}

	public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
		: base("2.5.29.19", encodedBasicConstraints.RawData, critical)
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
		if (base.Oid.Value == "2.5.29.10")
		{
			if (!CAPI.DecodeObject(new IntPtr(13L), m_rawData, out decodedValue, out cbDecodedValue))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			CAPIBase.CERT_BASIC_CONSTRAINTS_INFO cERT_BASIC_CONSTRAINTS_INFO = (CAPIBase.CERT_BASIC_CONSTRAINTS_INFO)Marshal.PtrToStructure(decodedValue.DangerousGetHandle(), typeof(CAPIBase.CERT_BASIC_CONSTRAINTS_INFO));
			byte[] array = new byte[1];
			Marshal.Copy(cERT_BASIC_CONSTRAINTS_INFO.SubjectType.pbData, array, 0, 1);
			m_isCA = (((array[0] & 0x80) != 0) ? true : false);
			m_hasPathLenConstraint = cERT_BASIC_CONSTRAINTS_INFO.fPathLenConstraint;
			m_pathLenConstraint = (int)cERT_BASIC_CONSTRAINTS_INFO.dwPathLenConstraint;
		}
		else
		{
			if (!CAPI.DecodeObject(new IntPtr(15L), m_rawData, out decodedValue, out cbDecodedValue))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			CAPIBase.CERT_BASIC_CONSTRAINTS2_INFO cERT_BASIC_CONSTRAINTS2_INFO = (CAPIBase.CERT_BASIC_CONSTRAINTS2_INFO)Marshal.PtrToStructure(decodedValue.DangerousGetHandle(), typeof(CAPIBase.CERT_BASIC_CONSTRAINTS2_INFO));
			m_isCA = ((cERT_BASIC_CONSTRAINTS2_INFO.fCA != 0) ? true : false);
			m_hasPathLenConstraint = ((cERT_BASIC_CONSTRAINTS2_INFO.fPathLenConstraint != 0) ? true : false);
			m_pathLenConstraint = (int)cERT_BASIC_CONSTRAINTS2_INFO.dwPathLenConstraint;
		}
		m_decoded = true;
		decodedValue.Dispose();
	}

	private unsafe static byte[] EncodeExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint)
	{
		CAPIBase.CERT_BASIC_CONSTRAINTS2_INFO cERT_BASIC_CONSTRAINTS2_INFO = new CAPIBase.CERT_BASIC_CONSTRAINTS2_INFO
		{
			fCA = (certificateAuthority ? 1 : 0),
			fPathLenConstraint = (hasPathLengthConstraint ? 1 : 0)
		};
		if (hasPathLengthConstraint)
		{
			if (pathLengthConstraint < 0)
			{
				throw new ArgumentOutOfRangeException("pathLengthConstraint", System.SR.GetString("Arg_OutOfRange_NeedNonNegNum"));
			}
			cERT_BASIC_CONSTRAINTS2_INFO.dwPathLenConstraint = (uint)pathLengthConstraint;
		}
		byte[] encodedData = null;
		if (!CAPI.EncodeObject("2.5.29.19", new IntPtr(&cERT_BASIC_CONSTRAINTS2_INFO), out encodedData))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return encodedData;
	}
}
