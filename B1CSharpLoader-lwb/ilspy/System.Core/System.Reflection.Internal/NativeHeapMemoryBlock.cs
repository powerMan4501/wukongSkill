using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System.Reflection.Internal;

internal sealed class NativeHeapMemoryBlock : AbstractMemoryBlock
{
	private sealed class DisposableData : CriticalDisposableObject
	{
		private IntPtr _pointer;

		public unsafe byte* Pointer
		{
			[SecurityCritical]
			get
			{
				return (byte*)(void*)_pointer;
			}
		}

		[SecuritySafeCritical]
		public DisposableData(int size)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				_pointer = Marshal.AllocHGlobal(size);
			}
		}

		[SecuritySafeCritical]
		protected override void Release()
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				IntPtr intPtr = Interlocked.Exchange(ref _pointer, IntPtr.Zero);
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
		}
	}

	private readonly DisposableData _data;

	private readonly int _size;

	public unsafe override byte* Pointer
	{
		[SecurityCritical]
		get
		{
			return _data.Pointer;
		}
	}

	public override int Size => _size;

	internal NativeHeapMemoryBlock(int size)
	{
		_data = new DisposableData(size);
		_size = size;
	}

	public override void Dispose()
	{
		_data.Dispose();
	}
}
