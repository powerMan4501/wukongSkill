namespace System.Reflection.Metadata;

internal struct Handle : IEquatable<Handle>
{
	private readonly int _value;

	private readonly byte _vType;

	internal int RowId => _value;

	internal int Offset => _value;

	internal uint EntityHandleType => Type << 24;

	internal uint Type => (uint)(_vType & 0x7F);

	internal byte VType => _vType;

	internal bool IsVirtual => (_vType & 0x80) != 0;

	internal bool IsHeapHandle => (_vType & 0x70) == 112;

	public HandleKind Kind
	{
		get
		{
			uint type = Type;
			if ((type & 0xFFFFFFFCu) == 120)
			{
				return HandleKind.String;
			}
			return (HandleKind)type;
		}
	}

	public bool IsNil => (_value | (_vType & 0x80)) == 0;

	internal bool IsEntityOrUserStringHandle => Type <= 112;

	internal int Token => (_vType << 24) | _value;

	internal static Handle FromVToken(uint vToken)
	{
		return new Handle((byte)(vToken >> 24), (int)(vToken & 0xFFFFFF));
	}

	internal Handle(byte vType, int value)
	{
		_vType = vType;
		_value = value;
	}

	public override bool Equals(object obj)
	{
		if (obj is Handle)
		{
			return Equals((Handle)obj);
		}
		return false;
	}

	public bool Equals(Handle other)
	{
		if (_value == other._value)
		{
			return _vType == other._vType;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return _value ^ (_vType << 24);
	}

	public static bool operator ==(Handle left, Handle right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Handle left, Handle right)
	{
		return !left.Equals(right);
	}

	internal static int Compare(Handle left, Handle right)
	{
		return ((long)((uint)left._value | ((ulong)left._vType << 32))).CompareTo((long)((uint)right._value | ((ulong)right._vType << 32)));
	}
}
