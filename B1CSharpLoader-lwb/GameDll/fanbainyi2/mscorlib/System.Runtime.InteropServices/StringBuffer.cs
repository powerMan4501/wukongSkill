using System.Security;

namespace System.Runtime.InteropServices;

internal class StringBuffer : NativeBuffer
{
	private uint _length;

	public unsafe char this[uint index]
	{
		[SecuritySafeCritical]
		get
		{
			if (index >= _length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return CharPointer[index];
		}
		[SecuritySafeCritical]
		set
		{
			if (index >= _length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			CharPointer[index] = value;
		}
	}

	public uint CharCapacity
	{
		[SecuritySafeCritical]
		get
		{
			ulong byteCapacity = base.ByteCapacity;
			ulong num = ((byteCapacity == 0L) ? 0 : (byteCapacity / 2));
			if (num <= uint.MaxValue)
			{
				return (uint)num;
			}
			return uint.MaxValue;
		}
	}

	public unsafe uint Length
	{
		get
		{
			return _length;
		}
		[SecuritySafeCritical]
		set
		{
			if (value == uint.MaxValue)
			{
				throw new ArgumentOutOfRangeException("Length");
			}
			EnsureCharCapacity(value + 1);
			CharPointer[value] = '\0';
			_length = value;
		}
	}

	internal unsafe char* CharPointer
	{
		[SecurityCritical]
		get
		{
			return (char*)base.VoidPointer;
		}
	}

	public StringBuffer(uint initialCapacity = 0u)
		: base((ulong)initialCapacity * 2uL)
	{
	}

	public StringBuffer(string initialContents)
		: base(0uL)
	{
		if (initialContents != null)
		{
			Append(initialContents);
		}
	}

	public StringBuffer(StringBuffer initialContents)
		: base(0uL)
	{
		if (initialContents != null)
		{
			Append(initialContents);
		}
	}

	[SecuritySafeCritical]
	public void EnsureCharCapacity(uint minCapacity)
	{
		EnsureByteCapacity((ulong)minCapacity * 2uL);
	}

	[SecuritySafeCritical]
	public unsafe void SetLengthToFirstNull()
	{
		char* charPointer = CharPointer;
		uint charCapacity = CharCapacity;
		for (uint num = 0u; num < charCapacity; num++)
		{
			if (charPointer[num] == '\0')
			{
				_length = num;
				break;
			}
		}
	}

	[SecurityCritical]
	public unsafe bool Contains(char value)
	{
		char* charPointer = CharPointer;
		uint length = _length;
		for (uint num = 0u; num < length; num++)
		{
			if (*(charPointer++) == value)
			{
				return true;
			}
		}
		return false;
	}

	[SecuritySafeCritical]
	public bool StartsWith(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (_length < (uint)value.Length)
		{
			return false;
		}
		return SubstringEquals(value, 0u, value.Length);
	}

	[SecuritySafeCritical]
	public unsafe bool SubstringEquals(string value, uint startIndex = 0u, int count = -1)
	{
		if (value == null)
		{
			return false;
		}
		if (count < -1)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (startIndex > _length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		uint num = ((count == -1) ? (_length - startIndex) : ((uint)count));
		if (checked(startIndex + num) > _length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		int length = value.Length;
		if (num != (uint)length)
		{
			return false;
		}
		fixed (char* ptr = value)
		{
			char* ptr2 = CharPointer + startIndex;
			for (int i = 0; i < length; i++)
			{
				if (*(ptr2++) != ptr[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	[SecuritySafeCritical]
	public void Append(string value, int startIndex = 0, int count = -1)
	{
		CopyFrom(_length, value, startIndex, count);
	}

	public void Append(StringBuffer value, uint startIndex = 0u)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (value.Length != 0)
		{
			value.CopyTo(startIndex, this, _length, value.Length);
		}
	}

	public void Append(StringBuffer value, uint startIndex, uint count)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (count != 0)
		{
			value.CopyTo(startIndex, this, _length, count);
		}
	}

	[SecuritySafeCritical]
	public unsafe void CopyTo(uint bufferIndex, StringBuffer destination, uint destinationIndex, uint count)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (destinationIndex > destination._length)
		{
			throw new ArgumentOutOfRangeException("destinationIndex");
		}
		if (bufferIndex >= _length)
		{
			throw new ArgumentOutOfRangeException("bufferIndex");
		}
		checked
		{
			if (_length < bufferIndex + count)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (count != 0)
			{
				uint num = destinationIndex + count;
				if (destination._length < num)
				{
					destination.Length = num;
				}
				Buffer.MemoryCopy(CharPointer + bufferIndex, destination.CharPointer + destinationIndex, (long)(destination.ByteCapacity - destinationIndex * 2), unchecked((long)count) * 2L);
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe void CopyFrom(uint bufferIndex, string source, int sourceIndex = 0, int count = -1)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (bufferIndex > _length)
		{
			throw new ArgumentOutOfRangeException("bufferIndex");
		}
		if (sourceIndex < 0 || sourceIndex >= source.Length)
		{
			throw new ArgumentOutOfRangeException("sourceIndex");
		}
		if (count == -1)
		{
			count = source.Length - sourceIndex;
		}
		if (count < 0 || source.Length - count < sourceIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count != 0)
		{
			uint num = bufferIndex + (uint)count;
			if (_length < num)
			{
				Length = num;
			}
			fixed (char* ptr = source)
			{
				Buffer.MemoryCopy(ptr + sourceIndex, CharPointer + bufferIndex, checked((long)(base.ByteCapacity - bufferIndex * 2)), (long)count * 2L);
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe void TrimEnd(char[] values)
	{
		if (values != null && values.Length != 0 && _length != 0)
		{
			char* ptr = CharPointer + _length - 1;
			while (_length != 0 && Array.IndexOf(values, *ptr) >= 0)
			{
				Length = _length - 1;
				ptr--;
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe override string ToString()
	{
		if (_length == 0)
		{
			return string.Empty;
		}
		if (_length > int.MaxValue)
		{
			throw new InvalidOperationException();
		}
		return new string(CharPointer, 0, (int)_length);
	}

	[SecuritySafeCritical]
	public unsafe string Substring(uint startIndex, int count = -1)
	{
		if (startIndex > ((_length != 0) ? (_length - 1) : 0))
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < -1)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		uint num = ((count == -1) ? (_length - startIndex) : ((uint)count));
		if (num > int.MaxValue || checked(startIndex + num) > _length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (num == 0)
		{
			return string.Empty;
		}
		return new string(CharPointer + startIndex, 0, (int)num);
	}

	[SecuritySafeCritical]
	public override void Free()
	{
		base.Free();
		_length = 0u;
	}
}
