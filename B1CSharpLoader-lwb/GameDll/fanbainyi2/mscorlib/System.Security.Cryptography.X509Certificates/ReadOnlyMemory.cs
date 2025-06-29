namespace System.Security.Cryptography.X509Certificates;

internal struct ReadOnlyMemory<T>
{
	private readonly ArraySegment<T> _Segment;

	public bool IsEmpty => _Segment.Count == 0;

	public int Length => _Segment.Count;

	public ReadOnlySpan<T> Span => new ReadOnlySpan<T>(_Segment);

	public ReadOnlyMemory(ArraySegment<T> segment)
	{
		_Segment = segment;
	}

	public ReadOnlyMemory(T[] array, int offset, int count)
		: this((array != null || offset != 0 || count != 0) ? new ArraySegment<T>(array, offset, count) : default(ArraySegment<T>))
	{
	}

	public ReadOnlyMemory(T[] array)
		: this((array != null) ? new ArraySegment<T>(array) : default(ArraySegment<T>))
	{
	}

	public ReadOnlyMemory<T> Slice(int start)
	{
		if (start < 0)
		{
			throw new InvalidOperationException();
		}
		return new ReadOnlyMemory<T>(_Segment.Array, _Segment.Offset + start, _Segment.Count - start);
	}

	public ReadOnlyMemory<T> Slice(int start, int length)
	{
		if (start < 0)
		{
			throw new InvalidOperationException();
		}
		if (length > _Segment.Count - start)
		{
			throw new InvalidOperationException();
		}
		return new ReadOnlyMemory<T>(_Segment.Array, _Segment.Offset + start, length);
	}

	public void CopyTo(Span<T> destination)
	{
		if (destination.Length < Length)
		{
			throw new InvalidOperationException("Destination too short");
		}
		if (!IsEmpty)
		{
			ArraySegment<T> arraySegment = destination.DangerousGetArraySegment();
			Array.Copy(_Segment.Array, _Segment.Offset, arraySegment.Array, arraySegment.Offset, _Segment.Count);
		}
	}

	public static implicit operator ReadOnlyMemory<T>(T[] array)
	{
		return new ReadOnlyMemory<T>(array);
	}

	public static implicit operator ArraySegment<T>(ReadOnlyMemory<T> memory)
	{
		return memory._Segment;
	}

	public static implicit operator ReadOnlyMemory<T>(ArraySegment<T> segment)
	{
		return new ReadOnlyMemory<T>(segment);
	}
}
