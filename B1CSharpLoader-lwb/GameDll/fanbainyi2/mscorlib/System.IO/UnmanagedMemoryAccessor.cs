using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.IO;

public class UnmanagedMemoryAccessor : IDisposable
{
	[SecurityCritical]
	private SafeBuffer _buffer;

	private long _offset;

	private long _capacity;

	private FileAccess _access;

	private bool _isOpen;

	private bool _canRead;

	private bool _canWrite;

	public long Capacity => _capacity;

	public bool CanRead
	{
		get
		{
			if (_isOpen)
			{
				return _canRead;
			}
			return false;
		}
	}

	public bool CanWrite
	{
		get
		{
			if (_isOpen)
			{
				return _canWrite;
			}
			return false;
		}
	}

	protected bool IsOpen => _isOpen;

	protected UnmanagedMemoryAccessor()
	{
		_isOpen = false;
	}

	[SecuritySafeCritical]
	public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity)
	{
		Initialize(buffer, offset, capacity, FileAccess.Read);
	}

	[SecuritySafeCritical]
	public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity, FileAccess access)
	{
		Initialize(buffer, offset, capacity, access);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	protected unsafe void Initialize(SafeBuffer buffer, long offset, long capacity, FileAccess access)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.ByteLength < (ulong)(offset + capacity))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_OffsetAndCapacityOutOfBounds"));
		}
		if (access < FileAccess.Read || access > FileAccess.ReadWrite)
		{
			throw new ArgumentOutOfRangeException("access");
		}
		if (_isOpen)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CalledTwice"));
		}
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			buffer.AcquirePointer(ref pointer);
			if ((nuint)((long)pointer + offset + capacity) < (nuint)pointer)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_UnmanagedMemAccessorWrapAround"));
			}
		}
		finally
		{
			if (pointer != null)
			{
				buffer.ReleasePointer();
			}
		}
		_offset = offset;
		_buffer = buffer;
		_capacity = capacity;
		_access = access;
		_isOpen = true;
		_canRead = (_access & FileAccess.Read) != 0;
		_canWrite = (_access & FileAccess.Write) != 0;
	}

	protected virtual void Dispose(bool disposing)
	{
		_isOpen = false;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public bool ReadBoolean(long position)
	{
		int sizeOfType = 1;
		EnsureSafeToRead(position, sizeOfType);
		byte b = InternalReadByte(position);
		return b != 0;
	}

	public byte ReadByte(long position)
	{
		int sizeOfType = 1;
		EnsureSafeToRead(position, sizeOfType);
		return InternalReadByte(position);
	}

	[SecuritySafeCritical]
	public unsafe char ReadChar(long position)
	{
		int sizeOfType = 2;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return *(char*)pointer;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe short ReadInt16(long position)
	{
		int sizeOfType = 2;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return *(short*)pointer;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe int ReadInt32(long position)
	{
		int sizeOfType = 4;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return *(int*)pointer;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe long ReadInt64(long position)
	{
		int sizeOfType = 8;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return *(long*)pointer;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public decimal ReadDecimal(long position)
	{
		int sizeOfType = 16;
		EnsureSafeToRead(position, sizeOfType);
		int[] array = new int[4];
		ReadArray(position, array, 0, array.Length);
		return new decimal(array);
	}

	[SecuritySafeCritical]
	public unsafe float ReadSingle(long position)
	{
		int sizeOfType = 4;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return *(float*)pointer;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe double ReadDouble(long position)
	{
		int sizeOfType = 8;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return *(double*)pointer;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe sbyte ReadSByte(long position)
	{
		int sizeOfType = 1;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return (sbyte)(*pointer);
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe ushort ReadUInt16(long position)
	{
		int sizeOfType = 2;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return *(ushort*)pointer;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe uint ReadUInt32(long position)
	{
		int sizeOfType = 4;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return *(uint*)pointer;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe ulong ReadUInt64(long position)
	{
		int sizeOfType = 8;
		EnsureSafeToRead(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			return *(ulong*)pointer;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecurityCritical]
	public void Read<T>(long position, out T structure) where T : struct
	{
		if (position < 0)
		{
			throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (!_isOpen)
		{
			throw new ObjectDisposedException("UnmanagedMemoryAccessor", Environment.GetResourceString("ObjectDisposed_ViewAccessorClosed"));
		}
		if (!CanRead)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_Reading"));
		}
		uint num = Marshal.SizeOfType(typeof(T));
		if (position > _capacity - num)
		{
			if (position >= _capacity)
			{
				throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_PositionLessThanCapacityRequired"));
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_NotEnoughBytesToRead", typeof(T).FullName), "position");
		}
		structure = _buffer.Read<T>((ulong)(_offset + position));
	}

	[SecurityCritical]
	public int ReadArray<T>(long position, T[] array, int offset, int count) where T : struct
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", "Buffer cannot be null.");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_OffsetAndLengthOutOfBounds"));
		}
		if (!CanRead)
		{
			if (!_isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", Environment.GetResourceString("ObjectDisposed_ViewAccessorClosed"));
			}
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_Reading"));
		}
		if (position < 0)
		{
			throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		uint num = Marshal.AlignedSizeOf<T>();
		if (position >= _capacity)
		{
			throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_PositionLessThanCapacityRequired"));
		}
		int num2 = count;
		long num3 = _capacity - position;
		if (num3 < 0)
		{
			num2 = 0;
		}
		else
		{
			ulong num4 = (ulong)(num * count);
			if ((ulong)num3 < num4)
			{
				num2 = (int)(num3 / num);
			}
		}
		_buffer.ReadArray((ulong)(_offset + position), array, offset, num2);
		return num2;
	}

	public void Write(long position, bool value)
	{
		int sizeOfType = 1;
		EnsureSafeToWrite(position, sizeOfType);
		byte value2 = (byte)(value ? 1u : 0u);
		InternalWrite(position, value2);
	}

	public void Write(long position, byte value)
	{
		int sizeOfType = 1;
		EnsureSafeToWrite(position, sizeOfType);
		InternalWrite(position, value);
	}

	[SecuritySafeCritical]
	public unsafe void Write(long position, char value)
	{
		int sizeOfType = 2;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*(char*)pointer = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe void Write(long position, short value)
	{
		int sizeOfType = 2;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*(short*)pointer = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe void Write(long position, int value)
	{
		int sizeOfType = 4;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*(int*)pointer = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe void Write(long position, long value)
	{
		int sizeOfType = 8;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*(long*)pointer = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public void Write(long position, decimal value)
	{
		int sizeOfType = 16;
		EnsureSafeToWrite(position, sizeOfType);
		byte[] array = new byte[16];
		decimal.GetBytes(value, array);
		int[] array2 = new int[4];
		int num = array[12] | (array[13] << 8) | (array[14] << 16) | (array[15] << 24);
		int num2 = array[0] | (array[1] << 8) | (array[2] << 16) | (array[3] << 24);
		int num3 = array[4] | (array[5] << 8) | (array[6] << 16) | (array[7] << 24);
		int num4 = array[8] | (array[9] << 8) | (array[10] << 16) | (array[11] << 24);
		array2[0] = num2;
		array2[1] = num3;
		array2[2] = num4;
		array2[3] = num;
		WriteArray(position, array2, 0, array2.Length);
	}

	[SecuritySafeCritical]
	public unsafe void Write(long position, float value)
	{
		int sizeOfType = 4;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*(float*)pointer = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe void Write(long position, double value)
	{
		int sizeOfType = 8;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*(double*)pointer = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe void Write(long position, sbyte value)
	{
		int sizeOfType = 1;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*pointer = (byte)value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe void Write(long position, ushort value)
	{
		int sizeOfType = 2;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*(ushort*)pointer = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe void Write(long position, uint value)
	{
		int sizeOfType = 4;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*(uint*)pointer = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe void Write(long position, ulong value)
	{
		int sizeOfType = 8;
		EnsureSafeToWrite(position, sizeOfType);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			pointer += _offset + position;
			*(ulong*)pointer = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecurityCritical]
	public void Write<T>(long position, ref T structure) where T : struct
	{
		if (position < 0)
		{
			throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (!_isOpen)
		{
			throw new ObjectDisposedException("UnmanagedMemoryAccessor", Environment.GetResourceString("ObjectDisposed_ViewAccessorClosed"));
		}
		if (!CanWrite)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_Writing"));
		}
		uint num = Marshal.SizeOfType(typeof(T));
		if (position > _capacity - num)
		{
			if (position >= _capacity)
			{
				throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_PositionLessThanCapacityRequired"));
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_NotEnoughBytesToWrite", typeof(T).FullName), "position");
		}
		_buffer.Write((ulong)(_offset + position), structure);
	}

	[SecurityCritical]
	public void WriteArray<T>(long position, T[] array, int offset, int count) where T : struct
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", "Buffer cannot be null.");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_OffsetAndLengthOutOfBounds"));
		}
		if (position < 0)
		{
			throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (position >= Capacity)
		{
			throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_PositionLessThanCapacityRequired"));
		}
		if (!_isOpen)
		{
			throw new ObjectDisposedException("UnmanagedMemoryAccessor", Environment.GetResourceString("ObjectDisposed_ViewAccessorClosed"));
		}
		if (!CanWrite)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_Writing"));
		}
		_buffer.WriteArray((ulong)(_offset + position), array, offset, count);
	}

	[SecuritySafeCritical]
	private unsafe byte InternalReadByte(long position)
	{
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			return (pointer + _offset)[position];
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe void InternalWrite(long position, byte value)
	{
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			_buffer.AcquirePointer(ref pointer);
			(pointer + _offset)[position] = value;
		}
		finally
		{
			if (pointer != null)
			{
				_buffer.ReleasePointer();
			}
		}
	}

	private void EnsureSafeToRead(long position, int sizeOfType)
	{
		if (!_isOpen)
		{
			throw new ObjectDisposedException("UnmanagedMemoryAccessor", Environment.GetResourceString("ObjectDisposed_ViewAccessorClosed"));
		}
		if (!CanRead)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_Reading"));
		}
		if (position < 0)
		{
			throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (position > _capacity - sizeOfType)
		{
			if (position >= _capacity)
			{
				throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_PositionLessThanCapacityRequired"));
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_NotEnoughBytesToRead"), "position");
		}
	}

	private void EnsureSafeToWrite(long position, int sizeOfType)
	{
		if (!_isOpen)
		{
			throw new ObjectDisposedException("UnmanagedMemoryAccessor", Environment.GetResourceString("ObjectDisposed_ViewAccessorClosed"));
		}
		if (!CanWrite)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_Writing"));
		}
		if (position < 0)
		{
			throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (position > _capacity - sizeOfType)
		{
			if (position >= _capacity)
			{
				throw new ArgumentOutOfRangeException("position", Environment.GetResourceString("ArgumentOutOfRange_PositionLessThanCapacityRequired"));
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_NotEnoughBytesToWrite", "Byte"), "position");
		}
	}
}
