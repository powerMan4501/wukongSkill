using System.Runtime.InteropServices;
using System.Threading;

namespace System.Net;

internal class AsyncRequestContext : RequestContextBase
{
	private unsafe NativeOverlapped* m_NativeOverlapped;

	private ListenerAsyncResult m_Result;

	internal unsafe NativeOverlapped* NativeOverlapped => m_NativeOverlapped;

	internal unsafe AsyncRequestContext(ListenerAsyncResult result)
	{
		m_Result = result;
		BaseConstruction(Allocate(0u));
	}

	private unsafe UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST* Allocate(uint size)
	{
		uint num = ((size != 0) ? size : ((base.RequestBuffer == null) ? 4096u : base.Size));
		if (m_NativeOverlapped != null && num != base.RequestBuffer.Length)
		{
			NativeOverlapped* nativeOverlapped = m_NativeOverlapped;
			m_NativeOverlapped = null;
			Overlapped.Free(nativeOverlapped);
		}
		if (m_NativeOverlapped == null)
		{
			SetBuffer(checked((int)num));
			Overlapped overlapped = new Overlapped();
			overlapped.AsyncResult = m_Result;
			m_NativeOverlapped = overlapped.Pack(ListenerAsyncResult.IOCallback, base.RequestBuffer);
			return (UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)base.RequestBuffer, 0);
		}
		return base.RequestBlob;
	}

	internal unsafe void Reset(ulong requestId, uint size)
	{
		SetBlob(Allocate(size));
		base.RequestBlob->RequestId = requestId;
	}

	protected unsafe override void OnReleasePins()
	{
		if (m_NativeOverlapped != null)
		{
			NativeOverlapped* nativeOverlapped = m_NativeOverlapped;
			m_NativeOverlapped = null;
			Overlapped.Free(nativeOverlapped);
		}
	}

	protected unsafe override void Dispose(bool disposing)
	{
		if (m_NativeOverlapped != null && (!NclUtilities.HasShutdownStarted || disposing))
		{
			Overlapped.Free(m_NativeOverlapped);
		}
		base.Dispose(disposing);
	}
}
