namespace System.Security.Cryptography.X509Certificates;

internal struct Span<T>
{
	public static readonly Span<T> Empty;

	private ArraySegment<T> _Segment;

	public T this[int index]
	{
		get
		{
			if (index < 0 || index >= _Segment.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return _Segment.Array[index + _Segment.Offset];
		}
		set
		{
			if (index < 0 || index >= _Segment.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			_Segment.Array[index + _Segment.Offset] = value;
		}
	}

	public bool IsEmpty => _Segment.Count == 0;

	public int Length => _Segment.Count;

	public Span(ArraySegment<T> segment)
	{
		_Segment = segment;
	}

	public Span(T[] array, int offset, int count)
		: this((array != null || offset != 0 || count != 0) ? new ArraySegment<T>(array, offset, count) : default(ArraySegment<T>))
	{
	}

	public Span(T[] array)
		: this((array != null) ? new ArraySegment<T>(array) : default(ArraySegment<T>))
	{
	}

	public Span<T> Slice(int start)
	{
		if (start < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		return new Span<T>(_Segment.Array, _Segment.Offset + start, _Segment.Count - start);
	}

	public Span<T> Slice(int start, int length)
	{
		if (start < 0 || length > _Segment.Count - start)
		{
			throw new ArgumentOutOfRangeException();
		}
		return new Span<T>(_Segment.Array, _Segment.Offset + start, length);
	}

	public void Fill(T value)
	{
		for (int i = _Segment.Offset; i < _Segment.Count - _Segment.Offset; i++)
		{
			_Segment.Array[i] = value;
		}
	}

	public void Clear()
	{
		for (int i = _Segment.Offset; i < _Segment.Count - _Segment.Offset; i++)
		{
			_Segment.Array[i] = default(T);
		}
	}

	public T[] ToArray()
	{
		T[] array = new T[_Segment.Count];
		if (!IsEmpty)
		{
			Array.Copy(_Segment.Array, _Segment.Offset, array, 0, _Segment.Count);
		}
		return array;
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

	public bool Overlaps(ReadOnlySpan<T> destination, out int elementOffset)
	{
		return ((ReadOnlySpan<T>)this).Overlaps(destination, out elementOffset);
	}

	public ArraySegment<T> DangerousGetArraySegment()
	{
		return _Segment;
	}

	public static implicit operator Span<T>(T[] array)
	{
		return new Span<T>(array);
	}

	public static implicit operator ReadOnlySpan<T>(Span<T> span)
	{
		return new ReadOnlySpan<T>(span._Segment);
	}

	public T[] DangerousGetArrayForPinning()
	{
		return _Segment.Array;
	}
}
