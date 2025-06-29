namespace System.Collections.Specialized;

public class StringEnumerator
{
	private IEnumerator baseEnumerator;

	private IEnumerable temp;

	public string Current => (string)baseEnumerator.Current;

	internal StringEnumerator(StringCollection mappings)
	{
		temp = mappings;
		baseEnumerator = temp.GetEnumerator();
	}

	public bool MoveNext()
	{
		return baseEnumerator.MoveNext();
	}

	public void Reset()
	{
		baseEnumerator.Reset();
	}
}
