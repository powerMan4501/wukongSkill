using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.MemoryMappedFiles;

internal class MemoryMappedView : IDisposable
{
	private SafeMemoryMappedViewHandle m_viewHandle;

	private long m_pointerOffset;

	private long m_size;

	private MemoryMappedFileAccess m_access;

	private const int MaxFlushWaits = 15;

	private const int MaxFlushRetriesPerWait = 20;

	internal SafeMemoryMappedViewHandle ViewHandle
	{
		[SecurityCritical]
		get
		{
			return m_viewHandle;
		}
	}

	internal long PointerOffset => m_pointerOffset;

	internal long Size => m_size;

	internal MemoryMappedFileAccess Access => m_access;

	internal bool IsClosed
	{
		[SecuritySafeCritical]
		get
		{
			if (m_viewHandle != null)
			{
				return m_viewHandle.IsClosed;
			}
			return true;
		}
	}

	[SecurityCritical]
	private MemoryMappedView(SafeMemoryMappedViewHandle viewHandle, long pointerOffset, long size, MemoryMappedFileAccess access)
	{
		m_viewHandle = viewHandle;
		m_pointerOffset = pointerOffset;
		m_size = size;
		m_access = access;
	}

	[SecurityCritical]
	internal static MemoryMappedView CreateView(SafeMemoryMappedFileHandle memMappedFileHandle, MemoryMappedFileAccess access, long offset, long size)
	{
		ulong num = (ulong)offset % (ulong)MemoryMappedFile.GetSystemPageAllocationGranularity();
		ulong num2 = (ulong)offset - num;
		ulong num3 = ((size == 0L) ? 0 : ((ulong)size + num));
		if (IntPtr.Size == 4 && num3 > uint.MaxValue)
		{
			throw new ArgumentOutOfRangeException("size", System.SR.GetString("ArgumentOutOfRange_CapacityLargerThanLogicalAddressSpaceNotAllowed"));
		}
		Microsoft.Win32.UnsafeNativeMethods.MEMORYSTATUSEX lpBuffer = default(Microsoft.Win32.UnsafeNativeMethods.MEMORYSTATUSEX);
		bool flag = Microsoft.Win32.UnsafeNativeMethods.GlobalMemoryStatusEx(ref lpBuffer);
		ulong ullTotalVirtual = lpBuffer.ullTotalVirtual;
		if (num3 >= ullTotalVirtual)
		{
			throw new IOException(System.SR.GetString("IO_NotEnoughMemory"));
		}
		uint dwFileOffsetLow = (uint)(num2 & 0xFFFFFFFFu);
		uint dwFileOffsetHigh = (uint)(num2 >> 32);
		SafeMemoryMappedViewHandle safeMemoryMappedViewHandle = Microsoft.Win32.UnsafeNativeMethods.MapViewOfFile(memMappedFileHandle, MemoryMappedFile.GetFileMapAccess(access), dwFileOffsetHigh, dwFileOffsetLow, new UIntPtr(num3));
		if (safeMemoryMappedViewHandle.IsInvalid)
		{
			__Error.WinIOError(Marshal.GetLastWin32Error(), string.Empty);
		}
		Microsoft.Win32.UnsafeNativeMethods.MEMORY_BASIC_INFORMATION buffer = default(Microsoft.Win32.UnsafeNativeMethods.MEMORY_BASIC_INFORMATION);
		Microsoft.Win32.UnsafeNativeMethods.VirtualQuery(safeMemoryMappedViewHandle, ref buffer, (IntPtr)Marshal.SizeOf((object)buffer));
		ulong num4 = (ulong)buffer.RegionSize;
		if ((buffer.State & 0x2000) != 0 || num4 < num3)
		{
			ulong num5 = ((num3 == 0L) ? num4 : num3);
			IntPtr intPtr = Microsoft.Win32.UnsafeNativeMethods.VirtualAlloc(safeMemoryMappedViewHandle, (UIntPtr)num5, 4096, MemoryMappedFile.GetPageAccess(access));
			int lastWin32Error = Marshal.GetLastWin32Error();
			buffer = default(Microsoft.Win32.UnsafeNativeMethods.MEMORY_BASIC_INFORMATION);
			Microsoft.Win32.UnsafeNativeMethods.VirtualQuery(safeMemoryMappedViewHandle, ref buffer, (IntPtr)Marshal.SizeOf((object)buffer));
			num4 = (ulong)buffer.RegionSize;
		}
		if (size == 0L)
		{
			size = (long)(num4 - num);
		}
		safeMemoryMappedViewHandle.Initialize((ulong)size + num);
		return new MemoryMappedView(safeMemoryMappedViewHandle, (long)num, size, access);
	}

	[SecurityCritical]
	public unsafe void Flush(IntPtr capacity)
	{
		if (m_viewHandle == null)
		{
			return;
		}
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			m_viewHandle.AcquirePointer(ref pointer);
			bool flag = Microsoft.Win32.UnsafeNativeMethods.FlushViewOfFile(pointer, capacity);
			if (flag)
			{
				return;
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			bool flag2 = !flag && lastWin32Error == 33;
			int num = 0;
			while (flag2 && num < 15)
			{
				int millisecondsTimeout = 1 << num;
				Thread.Sleep(millisecondsTimeout);
				int num2 = 0;
				while (flag2 && num2 < 20)
				{
					if (Microsoft.Win32.UnsafeNativeMethods.FlushViewOfFile(pointer, capacity))
					{
						return;
					}
					Thread.Sleep(0);
					lastWin32Error = Marshal.GetLastWin32Error();
					flag2 = lastWin32Error == 33;
					num2++;
				}
				num++;
			}
			__Error.WinIOError(lastWin32Error, string.Empty);
		}
		finally
		{
			if (pointer != null)
			{
				m_viewHandle.ReleasePointer();
			}
		}
	}

	[SecurityCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (m_viewHandle != null && !m_viewHandle.IsClosed)
		{
			m_viewHandle.Dispose();
		}
	}

	[SecurityCritical]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
