namespace System.Reflection.Metadata;

internal struct DocumentHandle : IEquatable<DocumentHandle>
{
	private readonly int _rowId;

	public bool IsNil => RowId == 0;

	internal int RowId => _rowId;

	private DocumentHandle(int rowId)
	{
		_rowId = rowId;
	}

	internal static DocumentHandle FromRowId(int rowId)
	{
		return new DocumentHandle(rowId);
	}

	public static bool operator ==(DocumentHandle left, DocumentHandle right)
	{
		return left._rowId == right._rowId;
	}

	public override bool Equals(object obj)
	{
		if (obj is DocumentHandle)
		{
			return ((DocumentHandle)obj)._rowId == _rowId;
		}
		return false;
	}

	public bool Equals(DocumentHandle other)
	{
		return _rowId == other._rowId;
	}

	public override int GetHashCode()
	{
		return _rowId.GetHashCode();
	}

	public static bool operator !=(DocumentHandle left, DocumentHandle right)
	{
		return left._rowId != right._rowId;
	}
}
