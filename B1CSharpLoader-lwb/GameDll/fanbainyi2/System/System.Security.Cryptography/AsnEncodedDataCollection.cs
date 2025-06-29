using System.Collections;

namespace System.Security.Cryptography;

public sealed class AsnEncodedDataCollection : ICollection, IEnumerable
{
	private ArrayList m_list;

	private Oid m_oid;

	public AsnEncodedData this[int index] => (AsnEncodedData)m_list[index];

	public int Count => m_list.Count;

	public bool IsSynchronized => false;

	public object SyncRoot => this;

	public AsnEncodedDataCollection()
	{
		m_list = new ArrayList();
		m_oid = null;
	}

	public AsnEncodedDataCollection(AsnEncodedData asnEncodedData)
		: this()
	{
		m_list.Add(asnEncodedData);
	}

	public int Add(AsnEncodedData asnEncodedData)
	{
		if (asnEncodedData == null)
		{
			throw new ArgumentNullException("asnEncodedData");
		}
		if (m_oid != null)
		{
			string value = m_oid.Value;
			string value2 = asnEncodedData.Oid.Value;
			if (value != null && value2 != null)
			{
				if (string.Compare(value, value2, StringComparison.OrdinalIgnoreCase) != 0)
				{
					throw new CryptographicException(SR.GetString("Cryptography_Asn_MismatchedOidInCollection"));
				}
			}
			else if (value != null || value2 != null)
			{
				throw new CryptographicException(SR.GetString("Cryptography_Asn_MismatchedOidInCollection"));
			}
		}
		return m_list.Add(asnEncodedData);
	}

	public void Remove(AsnEncodedData asnEncodedData)
	{
		if (asnEncodedData == null)
		{
			throw new ArgumentNullException("asnEncodedData");
		}
		m_list.Remove(asnEncodedData);
	}

	public AsnEncodedDataEnumerator GetEnumerator()
	{
		return new AsnEncodedDataEnumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new AsnEncodedDataEnumerator(this);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(SR.GetString("Arg_RankMultiDimNotSupported"));
		}
		if (index < 0 || index >= array.Length)
		{
			throw new ArgumentOutOfRangeException("index", SR.GetString("ArgumentOutOfRange_Index"));
		}
		if (index + Count > array.Length)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		for (int i = 0; i < Count; i++)
		{
			array.SetValue(this[i], index);
			index++;
		}
	}

	public void CopyTo(AsnEncodedData[] array, int index)
	{
		((ICollection)this).CopyTo((Array)array, index);
	}
}
