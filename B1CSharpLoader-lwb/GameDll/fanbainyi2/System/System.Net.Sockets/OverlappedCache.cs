using System.Threading;

namespace System.Net.Sockets;

internal class OverlappedCache
{
	internal Overlapped m_Overlapped;

	internal SafeNativeOverlapped m_NativeOverlapped;

	internal object m_PinnedObjects;

	internal object[] m_PinnedObjectsArray;

	internal Overlapped Overlapped => m_Overlapped;

	internal SafeNativeOverlapped NativeOverlapped => m_NativeOverlapped;

	internal object PinnedObjects => m_PinnedObjects;

	internal object[] PinnedObjectsArray
	{
		get
		{
			object[] pinnedObjectsArray = m_PinnedObjectsArray;
			if (pinnedObjectsArray != null && pinnedObjectsArray.Length == 0)
			{
				pinnedObjectsArray = m_PinnedObjects as object[];
				if (pinnedObjectsArray != null && pinnedObjectsArray.Length == 0)
				{
					m_PinnedObjectsArray = null;
				}
				else
				{
					m_PinnedObjectsArray = pinnedObjectsArray;
				}
			}
			return m_PinnedObjectsArray;
		}
	}

	internal unsafe OverlappedCache(Overlapped overlapped, object[] pinnedObjectsArray, IOCompletionCallback callback)
	{
		m_Overlapped = overlapped;
		m_PinnedObjects = pinnedObjectsArray;
		m_PinnedObjectsArray = pinnedObjectsArray;
		m_NativeOverlapped = new SafeNativeOverlapped(overlapped.UnsafePack(callback, pinnedObjectsArray));
	}

	internal unsafe OverlappedCache(Overlapped overlapped, object pinnedObjects, IOCompletionCallback callback, bool alreadyTriedCast)
	{
		m_Overlapped = overlapped;
		m_PinnedObjects = pinnedObjects;
		m_PinnedObjectsArray = (alreadyTriedCast ? null : NclConstants.EmptyObjectArray);
		m_NativeOverlapped = new SafeNativeOverlapped(overlapped.UnsafePack(callback, pinnedObjects));
	}

	internal void Free()
	{
		InternalFree();
		GC.SuppressFinalize(this);
	}

	private void InternalFree()
	{
		m_Overlapped = null;
		m_PinnedObjects = null;
		if (m_NativeOverlapped != null)
		{
			if (!m_NativeOverlapped.IsInvalid)
			{
				m_NativeOverlapped.Dispose();
			}
			m_NativeOverlapped = null;
		}
	}

	internal static void InterlockedFree(ref OverlappedCache overlappedCache)
	{
		((overlappedCache == null) ? null : Interlocked.Exchange(ref overlappedCache, null))?.Free();
	}

	~OverlappedCache()
	{
		if (!NclUtilities.HasShutdownStarted)
		{
			InternalFree();
		}
	}
}
