namespace System.Reflection.Metadata;

internal struct MethodDebugInformationHandle : IEquatable<MethodDebugInformationHandle>
{
	private const uint tokenType = 822083584u;

	private const byte tokenTypeSmall = 49;

	private readonly int _rowId;

	public bool IsNil => RowId == 0;

	internal int RowId => _rowId;

	private MethodDebugInformationHandle(int rowId)
	{
		_rowId = rowId;
	}

	internal static MethodDebugInformationHandle FromRowId(int rowId)
	{
		return new MethodDebugInformationHandle(rowId);
	}

	public static implicit operator Handle(MethodDebugInformationHandle handle)
	{
		return new Handle(49, handle._rowId);
	}

	public static explicit operator MethodDebugInformationHandle(Handle handle)
	{
		if (handle.VType != 49)
		{
			Throw.InvalidCast();
		}
		return new MethodDebugInformationHandle(handle.RowId);
	}

	public static bool operator ==(MethodDebugInformationHandle left, MethodDebugInformationHandle right)
	{
		return left._rowId == right._rowId;
	}

	public override bool Equals(object obj)
	{
		if (obj is MethodDebugInformationHandle)
		{
			return ((MethodDebugInformationHandle)obj)._rowId == _rowId;
		}
		return false;
	}

	public bool Equals(MethodDebugInformationHandle other)
	{
		return _rowId == other._rowId;
	}

	public override int GetHashCode()
	{
		return _rowId.GetHashCode();
	}

	public static bool operator !=(MethodDebugInformationHandle left, MethodDebugInformationHandle right)
	{
		return left._rowId != right._rowId;
	}
}
