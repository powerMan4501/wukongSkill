namespace System.Security.Cryptography.X509Certificates;

internal struct Triple<T1, T2, T3>
{
	private readonly T1 _first;

	private readonly T2 _second;

	private readonly T3 _third;

	public T1 Item1 => _first;

	public T2 Item2 => _second;

	public T3 Item3 => _third;

	internal Triple(T1 first, T2 second, T3 third)
	{
		_first = first;
		_second = second;
		_third = third;
	}
}
