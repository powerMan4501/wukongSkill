using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Microsoft.Win32;

namespace System.Runtime;

public sealed class MemoryFailPoint : CriticalFinalizerObject, IDisposable
{
	private static readonly ulong TopOfMemory;

	private static long hiddenLastKnownFreeAddressSpace;

	private static long hiddenLastTimeCheckingAddressSpace;

	private const int CheckThreshold = 10000;

	private const int LowMemoryFudgeFactor = 16777216;

	private const int MemoryCheckGranularity = 16;

	private static readonly ulong GCSegmentSize;

	private ulong _reservedMemory;

	private bool _mustSubtractReservation;

	private static long LastKnownFreeAddressSpace
	{
		get
		{
			return Volatile.Read(ref hiddenLastKnownFreeAddressSpace);
		}
		set
		{
			Volatile.Write(ref hiddenLastKnownFreeAddressSpace, value);
		}
	}

	private static long LastTimeCheckingAddressSpace
	{
		get
		{
			return Volatile.Read(ref hiddenLastTimeCheckingAddressSpace);
		}
		set
		{
			Volatile.Write(ref hiddenLastTimeCheckingAddressSpace, value);
		}
	}

	private static long AddToLastKnownFreeAddressSpace(long addend)
	{
		return Interlocked.Add(ref hiddenLastKnownFreeAddressSpace, addend);
	}

	[SecuritySafeCritical]
	static MemoryFailPoint()
	{
		GetMemorySettings(out GCSegmentSize, out TopOfMemory);
	}

	[SecurityCritical]
	public unsafe MemoryFailPoint(int sizeInMegabytes)
	{
		if (sizeInMegabytes <= 0)
		{
			throw new ArgumentOutOfRangeException("sizeInMegabytes", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		ulong num = (_reservedMemory = (ulong)((long)sizeInMegabytes << 20));
		ulong num2 = (ulong)(Math.Ceiling((double)num / (double)GCSegmentSize) * (double)GCSegmentSize);
		if (num2 >= TopOfMemory)
		{
			throw new InsufficientMemoryException(Environment.GetResourceString("InsufficientMemory_MemFailPoint_TooBig"));
		}
		ulong num3 = (ulong)(Math.Ceiling((double)sizeInMegabytes / 16.0) * 16.0);
		num3 <<= 20;
		ulong availPageFile = 0uL;
		ulong totalAddressSpaceFree = 0uL;
		for (int i = 0; i < 3; i++)
		{
			CheckForAvailableMemory(out availPageFile, out totalAddressSpaceFree);
			ulong memoryFailPointReservedMemory = SharedStatics.MemoryFailPointReservedMemory;
			ulong num4 = num2 + memoryFailPointReservedMemory;
			bool flag = num4 < num2 || num4 < memoryFailPointReservedMemory;
			bool flag2 = availPageFile < num3 + memoryFailPointReservedMemory + 16777216 || flag;
			bool flag3 = totalAddressSpaceFree < num4 || flag;
			long num5 = Environment.TickCount;
			if (num5 > LastTimeCheckingAddressSpace + 10000 || num5 < LastTimeCheckingAddressSpace || LastKnownFreeAddressSpace < (long)num2)
			{
				CheckForFreeAddressSpace(num2, shouldThrow: false);
			}
			bool flag4 = (ulong)LastKnownFreeAddressSpace < num2;
			if (!flag2 && !flag3 && !flag4)
			{
				break;
			}
			switch (i)
			{
			case 0:
				GC.Collect();
				break;
			case 1:
				if (!flag2)
				{
					break;
				}
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					UIntPtr numBytes = new UIntPtr(num2);
					void* ptr = Win32Native.VirtualAlloc(null, numBytes, 4096, 4);
					if (ptr != null && !Win32Native.VirtualFree(ptr, UIntPtr.Zero, 32768))
					{
						__Error.WinIOError();
					}
				}
				break;
			case 2:
				if (flag2 || flag3)
				{
					InsufficientMemoryException ex = new InsufficientMemoryException(Environment.GetResourceString("InsufficientMemory_MemFailPoint"));
					throw ex;
				}
				if (flag4)
				{
					InsufficientMemoryException ex2 = new InsufficientMemoryException(Environment.GetResourceString("InsufficientMemory_MemFailPoint_VAFrag"));
					throw ex2;
				}
				break;
			}
		}
		AddToLastKnownFreeAddressSpace((long)(0L - num));
		if (LastKnownFreeAddressSpace < 0)
		{
			CheckForFreeAddressSpace(num2, shouldThrow: true);
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			SharedStatics.AddMemoryFailPointReservation((long)num);
			_mustSubtractReservation = true;
		}
	}

	[SecurityCritical]
	private static void CheckForAvailableMemory(out ulong availPageFile, out ulong totalAddressSpaceFree)
	{
		Win32Native.MEMORYSTATUSEX buffer = default(Win32Native.MEMORYSTATUSEX);
		if (!Win32Native.GlobalMemoryStatusEx(ref buffer))
		{
			__Error.WinIOError();
		}
		availPageFile = buffer.availPageFile;
		totalAddressSpaceFree = buffer.availVirtual;
	}

	[SecurityCritical]
	private unsafe static bool CheckForFreeAddressSpace(ulong size, bool shouldThrow)
	{
		ulong num = (ulong)(LastKnownFreeAddressSpace = (long)MemFreeAfterAddress(null, size));
		LastTimeCheckingAddressSpace = Environment.TickCount;
		if (num < size && shouldThrow)
		{
			throw new InsufficientMemoryException(Environment.GetResourceString("InsufficientMemory_MemFailPoint_VAFrag"));
		}
		return num >= size;
	}

	[SecurityCritical]
	private unsafe static ulong MemFreeAfterAddress(void* address, ulong size)
	{
		if (size >= TopOfMemory)
		{
			return 0uL;
		}
		ulong num = 0uL;
		Win32Native.MEMORY_BASIC_INFORMATION buffer = default(Win32Native.MEMORY_BASIC_INFORMATION);
		UIntPtr sizeOfBuffer = (UIntPtr)(ulong)Marshal.SizeOf(buffer);
		while ((ulong)((long)address + (long)size) < TopOfMemory)
		{
			UIntPtr uIntPtr = Win32Native.VirtualQuery(address, ref buffer, sizeOfBuffer);
			if (uIntPtr == UIntPtr.Zero)
			{
				__Error.WinIOError();
			}
			ulong num2 = buffer.RegionSize.ToUInt64();
			if (buffer.State == 65536)
			{
				if (num2 >= size)
				{
					return num2;
				}
				num = Math.Max(num, num2);
			}
			address = (void*)((ulong)address + num2);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void GetMemorySettings(out ulong maxGCSegmentSize, out ulong topOfMemory);

	[SecuritySafeCritical]
	~MemoryFailPoint()
	{
		Dispose(disposing: false);
	}

	[SecuritySafeCritical]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private void Dispose(bool disposing)
	{
		if (_mustSubtractReservation)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				SharedStatics.AddMemoryFailPointReservation((long)(0L - _reservedMemory));
				_mustSubtractReservation = false;
			}
		}
	}
}
