using System.Collections;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X509Certificate2Enumerator : IEnumerator
{
	private IEnumerator baseEnumerator;

	public X509Certificate2 Current => (X509Certificate2)baseEnumerator.Current;

	object IEnumerator.Current => baseEnumerator.Current;

	private X509Certificate2Enumerator()
	{
	}

	internal X509Certificate2Enumerator(X509Certificate2Collection mappings)
	{
		baseEnumerator = ((IEnumerable)mappings).GetEnumerator();
	}

	public bool MoveNext()
	{
		return baseEnumerator.MoveNext();
	}

	bool IEnumerator.MoveNext()
	{
		return baseEnumerator.MoveNext();
	}

	public void Reset()
	{
		baseEnumerator.Reset();
	}

	void IEnumerator.Reset()
	{
		baseEnumerator.Reset();
	}
}
