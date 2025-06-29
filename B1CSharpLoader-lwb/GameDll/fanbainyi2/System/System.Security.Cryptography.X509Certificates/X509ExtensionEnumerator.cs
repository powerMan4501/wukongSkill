using System.Collections;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ExtensionEnumerator : IEnumerator
{
	private X509ExtensionCollection m_extensions;

	private int m_current;

	public X509Extension Current => m_extensions[m_current];

	object IEnumerator.Current => m_extensions[m_current];

	private X509ExtensionEnumerator()
	{
	}

	internal X509ExtensionEnumerator(X509ExtensionCollection extensions)
	{
		m_extensions = extensions;
		m_current = -1;
	}

	public bool MoveNext()
	{
		if (m_current == m_extensions.Count - 1)
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
