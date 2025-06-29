using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

[SecurityCritical]
internal struct PinAndClear : IDisposable
{
	private byte[] _data;

	private GCHandle _gcHandle;

	[SecurityCritical]
	internal static PinAndClear Track(byte[] data)
	{
		return new PinAndClear
		{
			_gcHandle = GCHandle.Alloc(data, GCHandleType.Pinned),
			_data = data
		};
	}

	[SecurityCritical]
	public void Dispose()
	{
		Array.Clear(_data, 0, _data.Length);
		_gcHandle.Free();
	}
}
