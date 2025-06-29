namespace System.Reflection.Metadata;

internal struct BlobHandle : IEquatable<BlobHandle>
{
	internal enum VirtualIndex : byte
	{
		Nil,
		ContractPublicKeyToken,
		ContractPublicKey,
		AttributeUsage_AllowSingle,
		AttributeUsage_AllowMultiple,
		Count
	}

	private readonly uint _value;

	internal const int TemplateParameterOffset_AttributeUsageTarget = 2;

	public bool IsNil => _value == 0;

	internal bool IsVirtual => (_value & 0x80000000u) != 0;

	private ushort VirtualValue => (ushort)(_value >> 8);

	private BlobHandle(uint value)
	{
		_value = value;
	}

	internal static BlobHandle FromOffset(int heapOffset)
	{
		return new BlobHandle((uint)heapOffset);
	}

	internal void SubstituteTemplateParameters(byte[] blob)
	{
		ushort virtualValue = VirtualValue;
		blob[2] = (byte)(virtualValue & 0xFF);
		blob[3] = (byte)((virtualValue >> 8) & 0xFF);
		blob[4] = 0;
		blob[5] = 0;
	}

	internal int GetHeapOffset()
	{
		return (int)_value;
	}

	internal VirtualIndex GetVirtualIndex()
	{
		return (VirtualIndex)(_value & 0xFF);
	}

	public override bool Equals(object obj)
	{
		if (obj is BlobHandle)
		{
			return Equals((BlobHandle)obj);
		}
		return false;
	}

	public bool Equals(BlobHandle other)
	{
		return _value == other._value;
	}

	public override int GetHashCode()
	{
		return (int)_value;
	}
}
