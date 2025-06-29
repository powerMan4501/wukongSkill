using System.Collections;

namespace System.Security.Cryptography;

public sealed class AsnEncodedDataEnumerator : IEnumerator
{
	private AsnEncodedDataCollection m_asnEncodedDatas;

	private int m_current;

	public AsnEncodedData Current => m_asnEncodedDatas[m_current];

	object IEnumerator.Current => m_asnEncodedDatas[m_current];

	private AsnEncodedDataEnumerator()
	{
	}

	internal AsnEncodedDataEnumerator(AsnEncodedDataCollection asnEncodedDatas)
	{
		m_asnEncodedDatas = asnEncodedDatas;
		m_current = -1;
	}

	public bool MoveNext()
	{
		if (m_current == m_asnEncodedDatas.Count - 1)
		{
			return false;
		}
		m_current++;
		return true;
	}

	public void Reset()
	{
		m_current = -1;
	}
}
