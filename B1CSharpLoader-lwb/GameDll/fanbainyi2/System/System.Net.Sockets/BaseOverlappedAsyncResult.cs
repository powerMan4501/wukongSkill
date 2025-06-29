using System.Runtime.InteropServices;
using System.Threading;

namespace System.Net.Sockets;

internal class BaseOverlappedAsyncResult : ContextAwareResult
{
	private SafeOverlappedFree m_UnmanagedBlob;

	private AutoResetEvent m_OverlappedEvent;

	private int m_CleanupCount;

	private bool m_DisableOverlapped;

	private bool m_UseOverlappedIO;

	private GCHandle[] m_GCHandles;

	private OverlappedCache m_Cache;

	private unsafe static readonly IOCompletionCallback s_IOCallback = CompletionPortCallback;

	internal SafeHandle OverlappedHandle
	{
		get
		{
			if (m_UseOverlappedIO)
			{
				if (m_UnmanagedBlob != null && !m_UnmanagedBlob.IsInvalid)
				{
					return m_UnmanagedBlob;
				}
				return SafeOverlappedFree.Zero;
			}
			if (m_Cache != null)
			{
				return m_Cache.NativeOverlapped;
			}
			return SafeNativeOverlapped.Zero;
		}
	}

	internal BaseOverlappedAsyncResult(Socket socket, object asyncState, AsyncCallback asyncCallback)
		: base(socket, asyncState, asyncCallback)
	{
		m_UseOverlappedIO = Socket.UseOverlappedIO || socket.UseOnlyOverlappedIO;
		if (m_UseOverlappedIO)
		{
			m_CleanupCount = 1;
		}
		else
		{
			m_CleanupCount = 2;
		}
	}

	internal BaseOverlappedAsyncResult(Socket socket)
		: base(socket, null, null)
	{
		m_CleanupCount = 1;
		m_DisableOverlapped = true;
	}

	internal virtual object PostCompletion(int numBytes)
	{
		return numBytes;
	}

	internal void SetUnmanagedStructures(object objectsToPin)
	{
		if (m_DisableOverlapped)
		{
			return;
		}
		object[] array = null;
		bool alreadyTriedCast = false;
		bool flag = false;
		if (m_Cache != null)
		{
			if (objectsToPin == null && m_Cache.PinnedObjects == null)
			{
				flag = true;
			}
			else if (m_Cache.PinnedObjects != null)
			{
				if (m_Cache.PinnedObjectsArray == null)
				{
					if (objectsToPin == m_Cache.PinnedObjects)
					{
						flag = true;
					}
				}
				else if (objectsToPin != null)
				{
					alreadyTriedCast = true;
					array = objectsToPin as object[];
					if (array != null && array.Length == 0)
					{
						array = null;
					}
					if (array != null && array.Length == m_Cache.PinnedObjectsArray.Length)
					{
						flag = true;
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i] != m_Cache.PinnedObjectsArray[i])
							{
								flag = false;
								break;
							}
						}
					}
				}
			}
		}
		if (!flag && m_Cache != null)
		{
			m_Cache.Free();
			m_Cache = null;
		}
		Socket socket = (Socket)base.AsyncObject;
		if (m_UseOverlappedIO)
		{
			m_UnmanagedBlob = SafeOverlappedFree.Alloc(socket.SafeHandle);
			PinUnmanagedObjects(objectsToPin);
			m_OverlappedEvent = new AutoResetEvent(initialState: false);
			Marshal.WriteIntPtr(m_UnmanagedBlob.DangerousGetHandle(), Win32.OverlappedhEventOffset, m_OverlappedEvent.SafeWaitHandle.DangerousGetHandle());
			return;
		}
		socket.BindToCompletionPort();
		if (m_Cache == null)
		{
			if (array != null)
			{
				m_Cache = new OverlappedCache(new Overlapped(), array, s_IOCallback);
			}
			else
			{
				m_Cache = new OverlappedCache(new Overlapped(), objectsToPin, s_IOCallback, alreadyTriedCast);
			}
		}
		m_Cache.Overlapped.AsyncResult = this;
	}

	protected void SetupCache(ref OverlappedCache overlappedCache)
	{
		if (!m_UseOverlappedIO && !m_DisableOverlapped)
		{
			m_Cache = ((overlappedCache == null) ? null : Interlocked.Exchange(ref overlappedCache, null));
			m_CleanupCount++;
		}
	}

	protected void PinUnmanagedObjects(object objectsToPin)
	{
		if (m_Cache != null)
		{
			m_Cache.Free();
			m_Cache = null;
		}
		if (objectsToPin == null)
		{
			return;
		}
		if (objectsToPin.GetType() == typeof(object[]))
		{
			object[] array = (object[])objectsToPin;
			m_GCHandles = new GCHandle[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					m_GCHandles[i] = GCHandle.Alloc(array[i], GCHandleType.Pinned);
				}
			}
		}
		else
		{
			m_GCHandles = new GCHandle[1];
			m_GCHandles[0] = GCHandle.Alloc(objectsToPin, GCHandleType.Pinned);
		}
	}

	internal void ExtractCache(ref OverlappedCache overlappedCache)
	{
		if (m_UseOverlappedIO || m_DisableOverlapped)
		{
			return;
		}
		OverlappedCache overlappedCache2 = ((m_Cache == null) ? null : Interlocked.Exchange(ref m_Cache, null));
		if (overlappedCache2 != null)
		{
			if (overlappedCache == null)
			{
				overlappedCache = overlappedCache2;
			}
			else
			{
				Interlocked.Exchange(ref overlappedCache, overlappedCache2)?.Free();
			}
		}
		ReleaseUnmanagedStructures();
	}

	private unsafe static void CompletionPortCallback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
	{
		Overlapped overlapped = Overlapped.Unpack(nativeOverlapped);
		BaseOverlappedAsyncResult baseOverlappedAsyncResult = (BaseOverlappedAsyncResult)overlapped.AsyncResult;
		overlapped.AsyncResult = null;
		object obj = null;
		SocketError socketError = (SocketError)errorCode;
		if (socketError != SocketError.Success && socketError != SocketError.OperationAborted)
		{
			if (!(baseOverlappedAsyncResult.AsyncObject is Socket socket))
			{
				socketError = SocketError.NotSocket;
			}
			else if (socket.CleanedUp)
			{
				socketError = SocketError.OperationAborted;
			}
			else
			{
				try
				{
					if (!UnsafeNclNativeMethods.OSSOCK.WSAGetOverlappedResult(socket.SafeHandle, baseOverlappedAsyncResult.m_Cache.NativeOverlapped, out numBytes, wait: false, out var _))
					{
						socketError = (SocketError)Marshal.GetLastWin32Error();
					}
				}
				catch (ObjectDisposedException)
				{
					socketError = SocketError.OperationAborted;
				}
			}
		}
		baseOverlappedAsyncResult.ErrorCode = (int)socketError;
		obj = baseOverlappedAsyncResult.PostCompletion((int)numBytes);
		baseOverlappedAsyncResult.ReleaseUnmanagedStructures();
		baseOverlappedAsyncResult.InvokeCallback(obj);
	}

	private void OverlappedCallback(object stateObject, bool Signaled)
	{
		BaseOverlappedAsyncResult baseOverlappedAsyncResult = (BaseOverlappedAsyncResult)stateObject;
		uint num = (uint)Marshal.ReadInt32(IntPtrHelper.Add(baseOverlappedAsyncResult.m_UnmanagedBlob.DangerousGetHandle(), 0));
		uint numBytes = ((num != 0) ? uint.MaxValue : ((uint)Marshal.ReadInt32(IntPtrHelper.Add(baseOverlappedAsyncResult.m_UnmanagedBlob.DangerousGetHandle(), Win32.OverlappedInternalHighOffset))));
		baseOverlappedAsyncResult.ErrorCode = (int)num;
		object result = baseOverlappedAsyncResult.PostCompletion((int)numBytes);
		baseOverlappedAsyncResult.ReleaseUnmanagedStructures();
		baseOverlappedAsyncResult.InvokeCallback(result);
	}

	internal SocketError CheckAsyncCallOverlappedResult(SocketError errorCode)
	{
		if (m_UseOverlappedIO)
		{
			if (errorCode == SocketError.Success || errorCode == SocketError.IOPending)
			{
				ThreadPool.UnsafeRegisterWaitForSingleObject(m_OverlappedEvent, OverlappedCallback, this, -1, executeOnlyOnce: true);
				return SocketError.Success;
			}
			base.ErrorCode = (int)errorCode;
			base.Result = -1;
			ReleaseUnmanagedStructures();
		}
		else
		{
			ReleaseUnmanagedStructures();
			if (errorCode == SocketError.Success || errorCode == SocketError.IOPending)
			{
				return SocketError.Success;
			}
			base.ErrorCode = (int)errorCode;
			base.Result = -1;
			if (m_Cache != null)
			{
				m_Cache.Overlapped.AsyncResult = null;
			}
			ReleaseUnmanagedStructures();
		}
		return errorCode;
	}

	private void ReleaseUnmanagedStructures()
	{
		if (Interlocked.Decrement(ref m_CleanupCount) == 0)
		{
			ForceReleaseUnmanagedStructures();
		}
	}

	protected override void Cleanup()
	{
		base.Cleanup();
		if (m_CleanupCount > 0 && Interlocked.Exchange(ref m_CleanupCount, 0) > 0)
		{
			ForceReleaseUnmanagedStructures();
		}
	}

	protected virtual void ForceReleaseUnmanagedStructures()
	{
		ReleaseGCHandles();
		GC.SuppressFinalize(this);
		if (m_UnmanagedBlob != null && !m_UnmanagedBlob.IsInvalid)
		{
			m_UnmanagedBlob.Close(resetOwner: true);
			m_UnmanagedBlob = null;
		}
		OverlappedCache.InterlockedFree(ref m_Cache);
		if (m_OverlappedEvent != null)
		{
			m_OverlappedEvent.Close();
			m_OverlappedEvent = null;
		}
	}

	~BaseOverlappedAsyncResult()
	{
		ReleaseGCHandles();
	}

	private void ReleaseGCHandles()
	{
		GCHandle[] gCHandles = m_GCHandles;
		if (gCHandles == null)
		{
			return;
		}
		for (int i = 0; i < gCHandles.Length; i++)
		{
			if (gCHandles[i].IsAllocated)
			{
				gCHandles[i].Free();
			}
		}
	}
}
