using System.Runtime.InteropServices;

namespace System.Net;

internal class SyncRequestContext : RequestContextBase
{
	private GCHandle m_PinnedHandle;

	internal unsafe SyncRequestContext(int size)
	{
		BaseConstruction(Allocate(size));
	}

	private unsafe UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST* Allocate(int size)
	{
		if (m_PinnedHandle.IsAllocated)
		{
			if (base.RequestBuffer.Length == size)
			{
				return base.RequestBlob;
			}
			m_PinnedHandle.Free();
		}
		SetBuffer(size);
		if (base.RequestBuffer == null)
		{
			return null;
		}
		m_PinnedHandle = GCHandle.Alloc(base.RequestBuffer, GCHandleType.Pinned);
		return (UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)base.RequestBuffer, 0);
	}

	internal unsafe void Reset(int size)
	{
		SetBlob(Allocate(size));
	}

	protected override void OnReleasePins()
	{
		if (m_PinnedHandle.IsAllocated)
		{
			m_PinnedHandle.Free();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (m_PinnedHandle.IsAllocated && (!NclUtilities.HasShutdownStarted || disposing))
		{
			m_PinnedHandle.Free();
		}
		base.Dispose(disposing);
	}
}
