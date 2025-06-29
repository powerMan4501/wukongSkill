using System.Collections;
using System.Collections.Generic;

namespace System.Net;

internal class ListenerPrefixEnumerator : IEnumerator<string>, IDisposable, IEnumerator
{
	private IEnumerator enumerator;

	public string Current => (string)enumerator.Current;

	object IEnumerator.Current => enumerator.Current;

	internal ListenerPrefixEnumerator(IEnumerator enumerator)
	{
		this.enumerator = enumerator;
	}

	public bool MoveNext()
	{
		return enumerator.MoveNext();
	}

	public void Dispose()
	{
	}

	void IEnumerator.Reset()
	{
		enumerator.Reset();
	}
}
