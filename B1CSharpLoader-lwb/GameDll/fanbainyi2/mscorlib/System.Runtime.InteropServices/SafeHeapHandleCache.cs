using System.Security;
using System.Threading;

namespace System.Runtime.InteropServices;

internal sealed class SafeHeapHandleCache : IDisposable
{
	private readonly ulong _minSize;

	private readonly ulong _maxSize;

	[SecurityCritical]
	internal readonly SafeHeapHandle[] _handleCache;

	[SecuritySafeCritical]
	public SafeHeapHandleCache(ulong minSize = 64uL, ulong maxSize = 2048uL, int maxHandles = 0)
	{
		_minSize = minSize;
		_maxSize = maxSize;
		_handleCache = new SafeHeapHandle[(maxHandles > 0) ? maxHandles : (Environment.ProcessorCount * 4)];
	}

	[SecurityCritical]
	public SafeHeapHandle Acquire(ulong minSize = 0uL)
	{
		if (minSize < _minSize)
		{
			minSize = _minSize;
		}
		SafeHeapHandle safeHeapHandle = null;
		for (int i = 0; i < _handleCache.Length; i++)
		{
			safeHeapHandle = Interlocked.Exchange(ref _handleCache[i], null);
			if (safeHeapHandle != null)
			{
				break;
			}
		}
		if (safeHeapHandle != null)
		{
			if (safeHeapHandle.ByteLength < minSize)
			{
				safeHeapHandle.Resize(minSize);
			}
		}
		else
		{
			safeHeapHandle = new SafeHeapHandle(minSize);
		}
		return safeHeapHandle;
	}

	[SecurityCritical]
	public void Release(SafeHeapHandle handle)
	{
		if (handle.ByteLength <= _maxSize)
		{
			for (int i = 0; i < _handleCache.Length; i++)
			{
				handle = Interlocked.Exchange(ref _handleCache[i], handle);
				if (handle == null)
				{
					return;
				}
			}
		}
		handle.Dispose();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	private void Dispose(bool disposing)
	{
		if (_handleCache == null)
		{
			return;
		}
		for (int i = 0; i < _handleCache.Length; i++)
		{
			SafeHeapHandle safeHeapHandle = _handleCache[i];
			_handleCache[i] = null;
			if (safeHeapHandle != null && disposing)
			{
				safeHeapHandle.Dispose();
			}
		}
	}

	~SafeHeapHandleCache()
	{
		Dispose(disposing: false);
	}
}
