namespace System.Security.Cryptography.X509Certificates;

internal struct ReadOnlySpan<T>
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
	}

	public bool IsEmpty => _Segment.Count == 0;

	public bool IsNull => _Segment.Array == null;

	public int Length => _Segment.Count;

	public ReadOnlySpan(ArraySegment<T> segment)
	{
		_Segment = segment;
	}

	public ReadOnlySpan(T[] array, int offset, int count)
		: this((array != null || offset != 0 || count != 0) ? new ArraySegment<T>(array, offset, count) : default(ArraySegment<T>))
	{
	}

	public ReadOnlySpan(T[] array)
		: this((array != null) ? new ArraySegment<T>(array) : default(ArraySegment<T>))
	{
	}

	public ReadOnlySpan<T> Slice(int start)
	{
		if (start < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		return new ReadOnlySpan<T>(_Segment.Array, _Segment.Offset + start, _Segment.Count - start);
	}

	public ReadOnlySpan<T> Slice(int start, int length)
	{
		if (start < 0)
		{
			throw new InvalidOperationException();
		}
		if (length > _Segment.Count - start)
		{
			throw new InvalidOperationException();
		}
		return new ReadOnlySpan<T>(_Segment.Array, _Segment.Offset + start, length);
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

	public bool Overlaps(ReadOnlySpan<T> destination)
	{
		int elementOffset;
		return Overlaps(destination, out elementOffset);
	}

	public bool Overlaps(ReadOnlySpan<T> destination, out int elementOffset)
	{
		elementOffset = 0;
		if (IsEmpty || destination.IsEmpty)
		{
			return false;
		}
		if (_Segment.Array != destination._Segment.Array)
		{
			return false;
		}
		elementOffset = destination._Segment.Offset - _Segment.Offset;
		if (elementOffset >= _Segment.Count || elementOffset <= -destination._Segment.Count)
		{
			elementOffset = 0;
			return false;
		}
		return true;
	}

	public ArraySegment<T> DangerousGetArraySegment()
	{
		return _Segment;
	}

	public static implicit operator ReadOnlySpan<T>(T[] array)
	{
		return new ReadOnlySpan<T>(array);
	}
}
