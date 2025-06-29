using System.Collections;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ChainElementEnumerator : IEnumerator
{
	private X509ChainElementCollection m_chainElements;

	private int m_current;

	public X509ChainElement Current => m_chainElements[m_current];

	object IEnumerator.Current => m_chainElements[m_current];

	private X509ChainElementEnumerator()
	{
	}

	internal X509ChainElementEnumerator(X509ChainElementCollection chainElements)
	{
		m_chainElements = chainElements;
		m_current = -1;
	}

	public bool MoveNext()
	{
		if (m_current == m_chainElements.Count - 1)
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
