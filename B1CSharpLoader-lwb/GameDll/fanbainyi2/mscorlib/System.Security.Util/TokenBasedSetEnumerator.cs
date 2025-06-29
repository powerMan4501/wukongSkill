namespace System.Security.Util;

internal struct TokenBasedSetEnumerator
{
	public object Current;

	public int Index;

	private TokenBasedSet _tb;

	public bool MoveNext()
	{
		if (_tb == null)
		{
			return false;
		}
		return _tb.MoveNext(ref this);
	}

	public void Reset()
	{
		Index = -1;
		Current = null;
	}

	public TokenBasedSetEnumerator(TokenBasedSet tb)
	{
		Index = -1;
		Current = null;
		_tb = tb;
	}
}
