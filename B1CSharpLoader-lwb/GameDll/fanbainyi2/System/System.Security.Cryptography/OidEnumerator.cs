using System.Collections;

namespace System.Security.Cryptography;

public sealed class OidEnumerator : IEnumerator
{
	private OidCollection m_oids;

	private int m_current;

	public Oid Current => m_oids[m_current];

	object IEnumerator.Current => m_oids[m_current];

	private OidEnumerator()
	{
	}

	internal OidEnumerator(OidCollection oids)
	{
		m_oids = oids;
		m_current = -1;
	}

	public bool MoveNext()
	{
		if (m_current == m_oids.Count - 1)
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
