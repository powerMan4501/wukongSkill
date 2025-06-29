using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace System.Security;

public sealed class SecureString : IDisposable
{
	[SecurityCritical]
	private SafeBSTRHandle m_buffer;

	private int m_length;

	private bool m_readOnly;

	private bool m_encrypted;

	private static bool supportedOnCurrentPlatform;

	private const int BlockSize = 8;

	private const int MaxLength = 65536;

	private const uint ProtectionScope = 0u;

	public int Length
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[SecuritySafeCritical]
		get
		{
			EnsureNotDisposed();
			return m_length;
		}
	}

	private int BufferLength
	{
		[SecurityCritical]
		get
		{
			return m_buffer.Length;
		}
	}

	[SecuritySafeCritical]
	static SecureString()
	{
		supportedOnCurrentPlatform = EncryptionSupported();
	}

	[SecurityCritical]
	private static bool EncryptionSupported()
	{
		bool result = true;
		try
		{
			Win32Native.SystemFunction041(SafeBSTRHandle.Allocate(null, 16u), 16u, 0u);
		}
		catch (EntryPointNotFoundException)
		{
			result = false;
		}
		return result;
	}

	[SecurityCritical]
	internal SecureString(SecureString str)
	{
		AllocateBuffer(str.BufferLength);
		SafeBSTRHandle.Copy(str.m_buffer, m_buffer);
		m_length = str.m_length;
		m_encrypted = str.m_encrypted;
	}

	[SecuritySafeCritical]
	public SecureString()
	{
		CheckSupportedOnCurrentPlatform();
		AllocateBuffer(8);
		m_length = 0;
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	private unsafe void InitializeSecureString(char* value, int length)
	{
		CheckSupportedOnCurrentPlatform();
		AllocateBuffer(length);
		m_length = length;
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			m_buffer.AcquirePointer(ref pointer);
			Buffer.Memcpy(pointer, (byte*)value, length * 2);
		}
		catch (Exception)
		{
			ProtectMemory();
			throw;
		}
		finally
		{
			if (pointer != null)
			{
				m_buffer.ReleasePointer();
			}
		}
		ProtectMemory();
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe SecureString(char* value, int length)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (length > 65536)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_Length"));
		}
		InitializeSecureString(value, length);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecuritySafeCritical]
	[HandleProcessCorruptedStateExceptions]
	public void AppendChar(char c)
	{
		EnsureNotDisposed();
		EnsureNotReadOnly();
		EnsureCapacity(m_length + 1);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			UnProtectMemory();
			m_buffer.Write((uint)(m_length * 2), c);
			m_length++;
		}
		catch (Exception)
		{
			ProtectMemory();
			throw;
		}
		finally
		{
			ProtectMemory();
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecuritySafeCritical]
	public void Clear()
	{
		EnsureNotDisposed();
		EnsureNotReadOnly();
		m_length = 0;
		m_buffer.ClearBuffer();
		m_encrypted = false;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecuritySafeCritical]
	public SecureString Copy()
	{
		EnsureNotDisposed();
		return new SecureString(this);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecuritySafeCritical]
	public void Dispose()
	{
		if (m_buffer != null && !m_buffer.IsInvalid)
		{
			m_buffer.Close();
			m_buffer = null;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecuritySafeCritical]
	[HandleProcessCorruptedStateExceptions]
	public unsafe void InsertAt(int index, char c)
	{
		if (index < 0 || index > m_length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_IndexString"));
		}
		EnsureNotDisposed();
		EnsureNotReadOnly();
		EnsureCapacity(m_length + 1);
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			UnProtectMemory();
			m_buffer.AcquirePointer(ref pointer);
			char* ptr = (char*)pointer;
			for (int num = m_length; num > index; num--)
			{
				ptr[num] = ptr[num - 1];
			}
			ptr[index] = c;
			m_length++;
		}
		catch (Exception)
		{
			ProtectMemory();
			throw;
		}
		finally
		{
			ProtectMemory();
			if (pointer != null)
			{
				m_buffer.ReleasePointer();
			}
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecuritySafeCritical]
	public bool IsReadOnly()
	{
		EnsureNotDisposed();
		return m_readOnly;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecuritySafeCritical]
	public void MakeReadOnly()
	{
		EnsureNotDisposed();
		m_readOnly = true;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecuritySafeCritical]
	[HandleProcessCorruptedStateExceptions]
	public unsafe void RemoveAt(int index)
	{
		EnsureNotDisposed();
		EnsureNotReadOnly();
		if (index < 0 || index >= m_length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_IndexString"));
		}
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			UnProtectMemory();
			m_buffer.AcquirePointer(ref pointer);
			char* ptr = (char*)pointer;
			for (int i = index; i < m_length - 1; i++)
			{
				ptr[i] = ptr[i + 1];
			}
			ptr[--m_length] = '\0';
		}
		catch (Exception)
		{
			ProtectMemory();
			throw;
		}
		finally
		{
			ProtectMemory();
			if (pointer != null)
			{
				m_buffer.ReleasePointer();
			}
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecuritySafeCritical]
	[HandleProcessCorruptedStateExceptions]
	public void SetAt(int index, char c)
	{
		if (index < 0 || index >= m_length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_IndexString"));
		}
		EnsureNotDisposed();
		EnsureNotReadOnly();
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			UnProtectMemory();
			m_buffer.Write((uint)(index * 2), c);
		}
		catch (Exception)
		{
			ProtectMemory();
			throw;
		}
		finally
		{
			ProtectMemory();
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private void AllocateBuffer(int size)
	{
		uint alignedSize = GetAlignedSize(size);
		m_buffer = SafeBSTRHandle.Allocate(null, alignedSize);
		if (m_buffer.IsInvalid)
		{
			throw new OutOfMemoryException();
		}
	}

	private void CheckSupportedOnCurrentPlatform()
	{
		if (!supportedOnCurrentPlatform)
		{
			throw new NotSupportedException(Environment.GetResourceString("Arg_PlatformSecureString"));
		}
	}

	[SecurityCritical]
	private void EnsureCapacity(int capacity)
	{
		if (capacity > 65536)
		{
			throw new ArgumentOutOfRangeException("capacity", Environment.GetResourceString("ArgumentOutOfRange_Capacity"));
		}
		if (capacity > m_buffer.Length)
		{
			SafeBSTRHandle safeBSTRHandle = SafeBSTRHandle.Allocate(null, GetAlignedSize(capacity));
			if (safeBSTRHandle.IsInvalid)
			{
				throw new OutOfMemoryException();
			}
			SafeBSTRHandle.Copy(m_buffer, safeBSTRHandle);
			m_buffer.Close();
			m_buffer = safeBSTRHandle;
		}
	}

	[SecurityCritical]
	private void EnsureNotDisposed()
	{
		if (m_buffer == null)
		{
			throw new ObjectDisposedException(null);
		}
	}

	private void EnsureNotReadOnly()
	{
		if (m_readOnly)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ReadOnly"));
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static uint GetAlignedSize(int size)
	{
		uint num = (uint)size / 8u * 8;
		if (size % 8 != 0 || size == 0)
		{
			num += 8;
		}
		return num;
	}

	[SecurityCritical]
	private unsafe int GetAnsiByteCount()
	{
		uint flags = 1024u;
		uint num = 63u;
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			m_buffer.AcquirePointer(ref pointer);
			return Win32Native.WideCharToMultiByte(0u, flags, (char*)pointer, m_length, null, 0, IntPtr.Zero, new IntPtr(&num));
		}
		finally
		{
			if (pointer != null)
			{
				m_buffer.ReleasePointer();
			}
		}
	}

	[SecurityCritical]
	private unsafe void GetAnsiBytes(byte* ansiStrPtr, int byteCount)
	{
		uint flags = 1024u;
		uint num = 63u;
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			m_buffer.AcquirePointer(ref pointer);
			Win32Native.WideCharToMultiByte(0u, flags, (char*)pointer, m_length, ansiStrPtr, byteCount - 1, IntPtr.Zero, new IntPtr(&num));
			*(ansiStrPtr + byteCount - 1) = 0;
		}
		finally
		{
			if (pointer != null)
			{
				m_buffer.ReleasePointer();
			}
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	private void ProtectMemory()
	{
		if (m_length == 0 || m_encrypted)
		{
			return;
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			int num = Win32Native.SystemFunction040(m_buffer, (uint)(m_buffer.Length * 2), 0u);
			if (num < 0)
			{
				throw new CryptographicException(Win32Native.LsaNtStatusToWinError(num));
			}
			m_encrypted = true;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[HandleProcessCorruptedStateExceptions]
	internal unsafe IntPtr ToBSTR()
	{
		EnsureNotDisposed();
		int length = m_length;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				intPtr = Win32Native.SysAllocStringLen(null, length);
			}
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			UnProtectMemory();
			m_buffer.AcquirePointer(ref pointer);
			Buffer.Memcpy((byte*)intPtr.ToPointer(), pointer, length * 2);
			intPtr2 = intPtr;
		}
		catch (Exception)
		{
			ProtectMemory();
			throw;
		}
		finally
		{
			ProtectMemory();
			if (intPtr2 == IntPtr.Zero && intPtr != IntPtr.Zero)
			{
				Win32Native.ZeroMemory(intPtr, (UIntPtr)(ulong)(length * 2));
				Win32Native.SysFreeString(intPtr);
			}
			if (pointer != null)
			{
				m_buffer.ReleasePointer();
			}
		}
		return intPtr2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	internal unsafe IntPtr ToUniStr(bool allocateFromHeap)
	{
		EnsureNotDisposed();
		int length = m_length;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		byte* pointer = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				intPtr = ((!allocateFromHeap) ? Marshal.AllocCoTaskMem((length + 1) * 2) : Marshal.AllocHGlobal((length + 1) * 2));
			}
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			UnProtectMemory();
			m_buffer.AcquirePointer(ref pointer);
			Buffer.Memcpy((byte*)intPtr.ToPointer(), pointer, length * 2);
			char* ptr = (char*)intPtr.ToPointer();
			ptr[length] = '\0';
			intPtr2 = intPtr;
		}
		catch (Exception)
		{
			ProtectMemory();
			throw;
		}
		finally
		{
			ProtectMemory();
			if (intPtr2 == IntPtr.Zero && intPtr != IntPtr.Zero)
			{
				Win32Native.ZeroMemory(intPtr, (UIntPtr)(ulong)(length * 2));
				if (allocateFromHeap)
				{
					Marshal.FreeHGlobal(intPtr);
				}
				else
				{
					Marshal.FreeCoTaskMem(intPtr);
				}
			}
			if (pointer != null)
			{
				m_buffer.ReleasePointer();
			}
		}
		return intPtr2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	internal unsafe IntPtr ToAnsiStr(bool allocateFromHeap)
	{
		EnsureNotDisposed();
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		int num = 0;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			UnProtectMemory();
			num = GetAnsiByteCount() + 1;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				intPtr = ((!allocateFromHeap) ? Marshal.AllocCoTaskMem(num) : Marshal.AllocHGlobal(num));
			}
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			GetAnsiBytes((byte*)intPtr.ToPointer(), num);
			intPtr2 = intPtr;
		}
		catch (Exception)
		{
			ProtectMemory();
			throw;
		}
		finally
		{
			ProtectMemory();
			if (intPtr2 == IntPtr.Zero && intPtr != IntPtr.Zero)
			{
				Win32Native.ZeroMemory(intPtr, (UIntPtr)(ulong)num);
				if (allocateFromHeap)
				{
					Marshal.FreeHGlobal(intPtr);
				}
				else
				{
					Marshal.FreeCoTaskMem(intPtr);
				}
			}
		}
		return intPtr2;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private void UnProtectMemory()
	{
		if (m_length == 0)
		{
			return;
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			if (m_encrypted)
			{
				int num = Win32Native.SystemFunction041(m_buffer, (uint)(m_buffer.Length * 2), 0u);
				if (num < 0)
				{
					throw new CryptographicException(Win32Native.LsaNtStatusToWinError(num));
				}
				m_encrypted = false;
			}
		}
	}
}
