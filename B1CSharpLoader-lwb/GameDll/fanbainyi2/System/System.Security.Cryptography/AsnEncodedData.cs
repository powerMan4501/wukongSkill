namespace System.Security.Cryptography;

public class AsnEncodedData
{
	internal Oid m_oid;

	internal byte[] m_rawData;

	public Oid Oid
	{
		get
		{
			return m_oid;
		}
		set
		{
			if (value == null)
			{
				m_oid = null;
			}
			else
			{
				m_oid = new Oid(value);
			}
		}
	}

	public byte[] RawData
	{
		get
		{
			return m_rawData;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_rawData = (byte[])value.Clone();
		}
	}

	internal AsnEncodedData(Oid oid)
	{
		m_oid = oid;
	}

	internal AsnEncodedData(string oid, CAPIBase.CRYPTOAPI_BLOB encodedBlob)
		: this(oid, CAPI.BlobToByteArray(encodedBlob))
	{
	}

	internal AsnEncodedData(Oid oid, CAPIBase.CRYPTOAPI_BLOB encodedBlob)
		: this(oid, CAPI.BlobToByteArray(encodedBlob))
	{
	}

	protected AsnEncodedData()
	{
	}

	public AsnEncodedData(byte[] rawData)
	{
		Reset(null, rawData);
	}

	public AsnEncodedData(string oid, byte[] rawData)
	{
		Reset(new Oid(oid), rawData);
	}

	public AsnEncodedData(Oid oid, byte[] rawData)
	{
		Reset(oid, rawData);
	}

	public AsnEncodedData(AsnEncodedData asnEncodedData)
	{
		if (asnEncodedData == null)
		{
			throw new ArgumentNullException("asnEncodedData");
		}
		Reset(asnEncodedData.m_oid, asnEncodedData.m_rawData);
	}

	public virtual void CopyFrom(AsnEncodedData asnEncodedData)
	{
		if (asnEncodedData == null)
		{
			throw new ArgumentNullException("asnEncodedData");
		}
		Reset(asnEncodedData.m_oid, asnEncodedData.m_rawData);
	}

	public virtual string Format(bool multiLine)
	{
		if (m_rawData == null || m_rawData.Length == 0)
		{
			return string.Empty;
		}
		string lpszStructType = string.Empty;
		if (m_oid != null && m_oid.Value != null)
		{
			lpszStructType = m_oid.Value;
		}
		return CAPI.CryptFormatObject(1u, multiLine ? 1u : 0u, lpszStructType, m_rawData);
	}

	private void Reset(Oid oid, byte[] rawData)
	{
		Oid = oid;
		RawData = rawData;
	}
}
