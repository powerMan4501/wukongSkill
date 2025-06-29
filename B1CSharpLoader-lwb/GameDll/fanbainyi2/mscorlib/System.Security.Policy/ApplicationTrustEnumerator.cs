using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Policy;

[ComVisible(true)]
public sealed class ApplicationTrustEnumerator : IEnumerator
{
	[SecurityCritical]
	private ApplicationTrustCollection m_trusts;

	private int m_current;

	public ApplicationTrust Current
	{
		[SecuritySafeCritical]
		get
		{
			return m_trusts[m_current];
		}
	}

	object IEnumerator.Current
	{
		[SecuritySafeCritical]
		get
		{
			return m_trusts[m_current];
		}
	}

	private ApplicationTrustEnumerator()
	{
	}

	[SecurityCritical]
	internal ApplicationTrustEnumerator(ApplicationTrustCollection trusts)
	{
		m_trusts = trusts;
		m_current = -1;
	}

	[SecuritySafeCritical]
	public bool MoveNext()
	{
		if (m_current == m_trusts.Count - 1)
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
