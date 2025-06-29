using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices;

[SecurityCritical]
[__DynamicallyInvokable]
public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
{
	private static readonly UIntPtr Uninitialized = ((UIntPtr.Size == 4) ? ((UIntPtr)uint.MaxValue) : ((UIntPtr)ulong.MaxValue));

	private UIntPtr _numBytes;

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public ulong ByteLength
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[__DynamicallyInvokable]
		get
		{
			if (_numBytes == Uninitialized)
			{
				throw NotInitialized();
			}
			return (ulong)_numBytes;
		}
	}

	[__DynamicallyInvokable]
	protected SafeBuffer(bool ownsHandle)
		: base(ownsHandle)
	{
		_numBytes = Uninitialized;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public void Initialize(ulong numBytes)
	{
		if (numBytes < 0)
		{
			throw new ArgumentOutOfRangeException("numBytes", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (IntPtr.Size == 4 && numBytes > uint.MaxValue)
		{
			throw new ArgumentOutOfRangeException("numBytes", Environment.GetResourceString("ArgumentOutOfRange_AddressSpace"));
		}
		if (numBytes >= (ulong)Uninitialized)
		{
			throw new ArgumentOutOfRangeException("numBytes", Environment.GetResourceString("ArgumentOutOfRange_UIntPtrMax-1"));
		}
		_numBytes = (UIntPtr)numBytes;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public void Initialize(uint numElements, uint sizeOfEachElement)
	{
		if (numElements < 0)
		{
			throw new ArgumentOutOfRangeException("numElements", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (sizeOfEachElement < 0)
		{
			throw new ArgumentOutOfRangeException("sizeOfEachElement", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (IntPtr.Size == 4 && numElements * sizeOfEachElement > uint.MaxValue)
		{
			throw new ArgumentOutOfRangeException("numBytes", Environment.GetResourceString("ArgumentOutOfRange_AddressSpace"));
		}
		if (numElements * sizeOfEachElement >= (ulong)Uninitialized)
		{
			throw new ArgumentOutOfRangeException("numElements", Environment.GetResourceString("ArgumentOutOfRange_UIntPtrMax-1"));
		}
		_numBytes = (UIntPtr)checked(numElements * sizeOfEachElement);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public void Initialize<T>(uint numElements) where T : struct
	{
		Initialize(numElements, Marshal.AlignedSizeOf<T>());
	}

	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public unsafe void AcquirePointer(ref byte* pointer)
	{
		if (_numBytes == Uninitialized)
		{
			throw NotInitialized();
		}
		pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			bool success = false;
			DangerousAddRef(ref success);
			pointer = (byte*)(void*)handle;
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public void ReleasePointer()
	{
		if (_numBytes == Uninitialized)
		{
			throw NotInitialized();
		}
		DangerousRelease();
	}

	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public unsafe T Read<T>(ulong byteOffset) where T : struct
	{
		if (_numBytes == Uninitialized)
		{
			throw NotInitialized();
		}
		uint num = Marshal.SizeOfType(typeof(T));
		byte* ptr = (byte*)(void*)handle + byteOffset;
		SpaceCheck(ptr, num);
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			DangerousAddRef(ref success);
			GenericPtrToStructure<T>(ptr, out var structure, num);
			return structure;
		}
		finally
		{
			if (success)
			{
				DangerousRelease();
			}
		}
	}

	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public unsafe void ReadArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (_numBytes == Uninitialized)
		{
			throw NotInitialized();
		}
		uint sizeofT = Marshal.SizeOfType(typeof(T));
		uint num = Marshal.AlignedSizeOf<T>();
		byte* ptr = (byte*)(void*)handle + byteOffset;
		SpaceCheck(ptr, checked((ulong)(num * count)));
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			DangerousAddRef(ref success);
			for (int i = 0; i < count; i++)
			{
				GenericPtrToStructure<T>(ptr + num * i, out array[i + index], sizeofT);
			}
		}
		finally
		{
			if (success)
			{
				DangerousRelease();
			}
		}
	}

	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public unsafe void Write<T>(ulong byteOffset, T value) where T : struct
	{
		if (_numBytes == Uninitialized)
		{
			throw NotInitialized();
		}
		uint num = Marshal.SizeOfType(typeof(T));
		byte* ptr = (byte*)(void*)handle + byteOffset;
		SpaceCheck(ptr, num);
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			DangerousAddRef(ref success);
			GenericStructureToPtr(ref value, ptr, num);
		}
		finally
		{
			if (success)
			{
				DangerousRelease();
			}
		}
	}

	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public unsafe void WriteArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (_numBytes == Uninitialized)
		{
			throw NotInitialized();
		}
		uint sizeofT = Marshal.SizeOfType(typeof(T));
		uint num = Marshal.AlignedSizeOf<T>();
		byte* ptr = (byte*)(void*)handle + byteOffset;
		SpaceCheck(ptr, checked((ulong)(num * count)));
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			DangerousAddRef(ref success);
			for (int i = 0; i < count; i++)
			{
				GenericStructureToPtr(ref array[i + index], ptr + num * i, sizeofT);
			}
		}
		finally
		{
			if (success)
			{
				DangerousRelease();
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private unsafe void SpaceCheck(byte* ptr, ulong sizeInBytes)
	{
		if ((ulong)_numBytes < sizeInBytes)
		{
			NotEnoughRoom();
		}
		if ((ulong)(ptr - (byte*)(void*)handle) > (ulong)_numBytes - sizeInBytes)
		{
			NotEnoughRoom();
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static void NotEnoughRoom()
	{
		throw new ArgumentException(Environment.GetResourceString("Arg_BufferTooSmall"));
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static InvalidOperationException NotInitialized()
	{
		return new InvalidOperationException(Environment.GetResourceString("InvalidOperation_MustCallInitialize"));
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void GenericPtrToStructure<T>(byte* ptr, out T structure, uint sizeofT) where T : struct
	{
		structure = default(T);
		PtrToStructureNative(ptr, __makeref(structure), sizeofT);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private unsafe static extern void PtrToStructureNative(byte* ptr, TypedReference structure, uint sizeofT);

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void GenericStructureToPtr<T>(ref T structure, byte* ptr, uint sizeofT) where T : struct
	{
		StructureToPtrNative(__makeref(structure), ptr, sizeofT);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private unsafe static extern void StructureToPtrNative(TypedReference structure, byte* ptr, uint sizeofT);
}
