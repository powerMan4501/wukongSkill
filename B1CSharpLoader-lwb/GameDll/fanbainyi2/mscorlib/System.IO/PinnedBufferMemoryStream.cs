using System.Runtime.InteropServices;
using System.Security;

namespace System.IO;

internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
{
	private byte[] _array;

	private GCHandle _pinningHandle;

	[SecurityCritical]
	private PinnedBufferMemoryStream()
	{
	}

	[SecurityCritical]
	internal unsafe PinnedBufferMemoryStream(byte[] array)
	{
		int num = array.Length;
		if (num == 0)
		{
			array = new byte[1];
			num = 0;
		}
		_array = array;
		_pinningHandle = new GCHandle(array, GCHandleType.Pinned);
		fixed (byte* array2 = _array)
		{
			Initialize(array2, num, num, FileAccess.Read, skipSecurityCheck: true);
		}
	}

	~PinnedBufferMemoryStream()
	{
		Dispose(disposing: false);
	}

	[SecuritySafeCritical]
	protected override void Dispose(bool disposing)
	{
		if (_isOpen)
		{
			_pinningHandle.Free();
			_isOpen = false;
		}
		base.Dispose(disposing);
	}
}
