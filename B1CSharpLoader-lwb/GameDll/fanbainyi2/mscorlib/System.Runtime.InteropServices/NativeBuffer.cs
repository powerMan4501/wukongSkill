using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices;

internal class NativeBuffer : IDisposable
{
	[SecurityCritical]
	private sealed class EmptySafeHandle : SafeHandle
	{
		public override bool IsInvalid
		{
			[SecurityCritical]
			get
			{
				return true;
			}
		}

		public EmptySafeHandle()
			: base(IntPtr.Zero, ownsHandle: true)
		{
		}

		[SecurityCritical]
		protected override bool ReleaseHandle()
		{
			return true;
		}
	}

	private static readonly SafeHeapHandleCache s_handleCache;

	[SecurityCritical]
	private static readonly SafeHandle s_emptyHandle;

	[SecurityCritical]
	private SafeHeapHandle _handle;

	private ulong _capacity;

	protected unsafe void* VoidPointer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SecurityCritical]
		get
		{
			if (_handle != null)
			{
				return _handle.DangerousGetHandle().ToPointer();
			}
			return null;
		}
	}

	protected unsafe byte* BytePointer
	{
		[SecurityCritical]
		get
		{
			return (byte*)VoidPointer;
		}
	}

	public ulong ByteCapacity => _capacity;

	public unsafe byte this[ulong index]
	{
		[SecuritySafeCritical]
		get
		{
			if (index >= _capacity)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BytePointer[index];
		}
		[SecuritySafeCritical]
		set
		{
			if (index >= _capacity)
			{
				throw new ArgumentOutOfRangeException();
			}
			BytePointer[index] = value;
		}
	}

	[SecuritySafeCritical]
	static NativeBuffer()
	{
		s_emptyHandle = new EmptySafeHandle();
		s_handleCache = new SafeHeapHandleCache(64uL, 2048uL);
	}

	public NativeBuffer(ulong initialMinCapacity = 0uL)
	{
		EnsureByteCapacity(initialMinCapacity);
	}

	[SecuritySafeCritical]
	public SafeHandle GetHandle()
	{
		return _handle ?? s_emptyHandle;
	}

	[SecuritySafeCritical]
	public void EnsureByteCapacity(ulong minCapacity)
	{
		if (_capacity < minCapacity)
		{
			Resize(minCapacity);
			_capacity = minCapacity;
		}
	}

	[SecuritySafeCritical]
	private void Resize(ulong byteLength)
	{
		if (byteLength == 0L)
		{
			ReleaseHandle();
		}
		else if (_handle == null)
		{
			_handle = s_handleCache.Acquire(byteLength);
		}
		else
		{
			_handle.Resize(byteLength);
		}
	}

	[SecuritySafeCritical]
	private void ReleaseHandle()
	{
		if (_handle != null)
		{
			s_handleCache.Release(_handle);
			_capacity = 0uL;
			_handle = null;
		}
	}

	[SecuritySafeCritical]
	public virtual void Free()
	{
		ReleaseHandle();
	}

	[SecuritySafeCritical]
	public void Dispose()
	{
		Free();
	}
}
