namespace System.Reflection.Metadata;

internal struct DocumentNameBlobHandle : IEquatable<DocumentNameBlobHandle>
{
	private readonly int _heapOffset;

	public bool IsNil => _heapOffset == 0;

	private DocumentNameBlobHandle(int heapOffset)
	{
		_heapOffset = heapOffset;
	}

	internal static DocumentNameBlobHandle FromOffset(int heapOffset)
	{
		return new DocumentNameBlobHandle(heapOffset);
	}

	public static implicit operator BlobHandle(DocumentNameBlobHandle handle)
	{
		return BlobHandle.FromOffset(handle._heapOffset);
	}

	public static explicit operator DocumentNameBlobHandle(BlobHandle handle)
	{
		if (handle.IsVirtual)
		{
			Throw.InvalidCast();
		}
		return FromOffset(handle.GetHeapOffset());
	}

	public override bool Equals(object obj)
	{
		if (obj is DocumentNameBlobHandle)
		{
			return Equals((DocumentNameBlobHandle)obj);
		}
		return false;
	}

	public bool Equals(DocumentNameBlobHandle other)
	{
		return _heapOffset == other._heapOffset;
	}

	public override int GetHashCode()
	{
		return _heapOffset;
	}

	public static bool operator ==(DocumentNameBlobHandle left, DocumentNameBlobHandle right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(DocumentNameBlobHandle left, DocumentNameBlobHandle right)
	{
		return !left.Equals(right);
	}
}
