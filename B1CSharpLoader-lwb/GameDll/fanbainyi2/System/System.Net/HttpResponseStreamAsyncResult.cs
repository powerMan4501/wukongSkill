using System.Runtime.InteropServices;
using System.Threading;

namespace System.Net;

internal class HttpResponseStreamAsyncResult : LazyAsyncResult
{
	internal unsafe NativeOverlapped* m_pOverlapped;

	private UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK[] m_DataChunks;

	internal bool m_SentHeaders;

	private unsafe static readonly IOCompletionCallback s_IOCallback = Callback;

	internal ushort dataChunkCount
	{
		get
		{
			if (m_DataChunks == null)
			{
				return 0;
			}
			return (ushort)m_DataChunks.Length;
		}
	}

	internal unsafe UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK* pDataChunks
	{
		get
		{
			if (m_DataChunks == null)
			{
				return null;
			}
			return (UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_DataChunks, 0);
		}
	}

	internal HttpResponseStreamAsyncResult(object asyncObject, object userState, AsyncCallback callback)
		: base(asyncObject, userState, callback)
	{
	}

	internal unsafe HttpResponseStreamAsyncResult(object asyncObject, object userState, AsyncCallback callback, byte[] buffer, int offset, int size, bool chunked, bool sentHeaders)
		: base(asyncObject, userState, callback)
	{
		m_SentHeaders = sentHeaders;
		Overlapped overlapped = new Overlapped
		{
			AsyncResult = this
		};
		if (size == 0)
		{
			m_DataChunks = null;
			m_pOverlapped = overlapped.Pack(s_IOCallback, null);
			return;
		}
		m_DataChunks = new UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK[(!chunked) ? 1 : 3];
		object[] array = new object[1 + m_DataChunks.Length];
		array[m_DataChunks.Length] = m_DataChunks;
		int offset2 = 0;
		byte[] array2 = null;
		if (chunked)
		{
			array2 = ConnectStream.GetChunkHeader(size, out offset2);
			m_DataChunks[0] = default(UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK);
			m_DataChunks[0].DataChunkType = UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromMemory;
			m_DataChunks[0].BufferLength = (uint)(array2.Length - offset2);
			array[0] = array2;
			m_DataChunks[1] = default(UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK);
			m_DataChunks[1].DataChunkType = UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromMemory;
			m_DataChunks[1].BufferLength = (uint)size;
			array[1] = buffer;
			m_DataChunks[2] = default(UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK);
			m_DataChunks[2].DataChunkType = UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromMemory;
			m_DataChunks[2].BufferLength = (uint)NclConstants.CRLF.Length;
			array[2] = NclConstants.CRLF;
		}
		else
		{
			m_DataChunks[0] = default(UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK);
			m_DataChunks[0].DataChunkType = UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromMemory;
			m_DataChunks[0].BufferLength = (uint)size;
			array[0] = buffer;
		}
		m_pOverlapped = overlapped.Pack(s_IOCallback, array);
		if (chunked)
		{
			m_DataChunks[0].pBuffer = (byte*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)array2, offset2);
			m_DataChunks[1].pBuffer = (byte*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffer, offset);
			m_DataChunks[2].pBuffer = (byte*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)NclConstants.CRLF, 0);
		}
		else
		{
			m_DataChunks[0].pBuffer = (byte*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffer, offset);
		}
	}

	internal void IOCompleted(uint errorCode, uint numBytes)
	{
		IOCompleted(this, errorCode, numBytes);
	}

	private unsafe static void IOCompleted(HttpResponseStreamAsyncResult asyncResult, uint errorCode, uint numBytes)
	{
		object obj = null;
		try
		{
			if (errorCode != 0 && errorCode != 38)
			{
				asyncResult.ErrorCode = (int)errorCode;
				obj = new HttpListenerException((int)errorCode);
			}
			else if (asyncResult.m_DataChunks == null)
			{
				obj = 0u;
				if (Logging.On)
				{
					Logging.Dump(Logging.HttpListener, asyncResult, "Callback", IntPtr.Zero, 0);
				}
			}
			else
			{
				obj = ((asyncResult.m_DataChunks.Length == 1) ? asyncResult.m_DataChunks[0].BufferLength : 0u);
				if (Logging.On)
				{
					for (int i = 0; i < asyncResult.m_DataChunks.Length; i++)
					{
						Logging.Dump(Logging.HttpListener, asyncResult, "Callback", (IntPtr)asyncResult.m_DataChunks[0].pBuffer, (int)asyncResult.m_DataChunks[0].BufferLength);
					}
				}
			}
		}
		catch (Exception ex)
		{
			obj = ex;
		}
		asyncResult.InvokeCallback(obj);
	}

	private unsafe static void Callback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
	{
		Overlapped overlapped = Overlapped.Unpack(nativeOverlapped);
		HttpResponseStreamAsyncResult asyncResult = overlapped.AsyncResult as HttpResponseStreamAsyncResult;
		IOCompleted(asyncResult, errorCode, numBytes);
	}

	protected unsafe override void Cleanup()
	{
		base.Cleanup();
		if (m_pOverlapped != null)
		{
			Overlapped.Free(m_pOverlapped);
		}
	}
}
