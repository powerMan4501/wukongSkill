using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Net.WebSockets;

internal class WebSocketBuffer : IDisposable
{
	private static class SendBufferState
	{
		public const int None = 0;

		public const int SendPayloadSpecified = 1;
	}

	private const int NativeOverheadBufferSize = 144;

	internal const int MinSendBufferSize = 16;

	internal const int MinReceiveBufferSize = 256;

	internal const int MaxBufferSize = 65536;

	private static readonly int s_SizeOfUInt = Marshal.SizeOf(typeof(uint));

	private static readonly int s_SizeOfBool = Marshal.SizeOf(typeof(bool));

	private static readonly int s_PropertyBufferSize = 2 * s_SizeOfUInt + s_SizeOfBool + IntPtr.Size;

	private readonly int m_ReceiveBufferSize;

	private readonly long m_StartAddress;

	private readonly long m_EndAddress;

	private readonly GCHandle m_GCHandle;

	private readonly ArraySegment<byte> m_InternalBuffer;

	private readonly ArraySegment<byte> m_NativeBuffer;

	private readonly ArraySegment<byte> m_PayloadBuffer;

	private readonly ArraySegment<byte> m_PropertyBuffer;

	private readonly int m_SendBufferSize;

	private volatile int m_PayloadOffset;

	private volatile WebSocketReceiveResult m_BufferedPayloadReceiveResult;

	private long m_PinnedSendBufferStartAddress;

	private long m_PinnedSendBufferEndAddress;

	private ArraySegment<byte> m_PinnedSendBuffer;

	private GCHandle m_PinnedSendBufferHandle;

	private int m_StateWhenDisposing = int.MinValue;

	private int m_SendBufferState;

	internal static int SizeOfUInt => s_SizeOfUInt;

	public int ReceiveBufferSize => m_ReceiveBufferSize;

	public int SendBufferSize => m_SendBufferSize;

	private WebSocketBuffer(ArraySegment<byte> internalBuffer, int receiveBufferSize, int sendBufferSize)
	{
		m_ReceiveBufferSize = receiveBufferSize;
		m_SendBufferSize = sendBufferSize;
		m_InternalBuffer = internalBuffer;
		m_GCHandle = GCHandle.Alloc(internalBuffer.Array, GCHandleType.Pinned);
		int num = m_ReceiveBufferSize + m_SendBufferSize + 144;
		m_StartAddress = Marshal.UnsafeAddrOfPinnedArrayElement((Array)internalBuffer.Array, internalBuffer.Offset).ToInt64();
		m_EndAddress = m_StartAddress + num;
		m_NativeBuffer = new ArraySegment<byte>(internalBuffer.Array, internalBuffer.Offset, num);
		m_PayloadBuffer = new ArraySegment<byte>(internalBuffer.Array, m_NativeBuffer.Offset + m_NativeBuffer.Count, m_ReceiveBufferSize);
		m_PropertyBuffer = new ArraySegment<byte>(internalBuffer.Array, m_PayloadBuffer.Offset + m_PayloadBuffer.Count, s_PropertyBufferSize);
		m_SendBufferState = 0;
	}

	internal static WebSocketBuffer CreateClientBuffer(ArraySegment<byte> internalBuffer, int receiveBufferSize, int sendBufferSize)
	{
		return new WebSocketBuffer(internalBuffer, receiveBufferSize, GetNativeSendBufferSize(sendBufferSize, isServerBuffer: false));
	}

	internal static WebSocketBuffer CreateServerBuffer(ArraySegment<byte> internalBuffer, int receiveBufferSize)
	{
		int nativeSendBufferSize = GetNativeSendBufferSize(16, isServerBuffer: true);
		return new WebSocketBuffer(internalBuffer, receiveBufferSize, nativeSendBufferSize);
	}

	public void Dispose(WebSocketState webSocketState)
	{
		if (Interlocked.CompareExchange(ref m_StateWhenDisposing, (int)webSocketState, int.MinValue) == int.MinValue)
		{
			CleanUp();
		}
	}

	public void Dispose()
	{
		Dispose(WebSocketState.None);
	}

	internal WebSocketProtocolComponent.Property[] CreateProperties(bool useZeroMaskingKey)
	{
		ThrowIfDisposed();
		IntPtr intPtr = m_GCHandle.AddrOfPinnedObject();
		int offset = m_PropertyBuffer.Offset;
		Marshal.WriteInt32(intPtr, offset, m_ReceiveBufferSize);
		offset += s_SizeOfUInt;
		Marshal.WriteInt32(intPtr, offset, m_SendBufferSize);
		offset += s_SizeOfUInt;
		Marshal.WriteIntPtr(intPtr, offset, intPtr + m_InternalBuffer.Offset);
		offset += IntPtr.Size;
		Marshal.WriteInt32(intPtr, offset, useZeroMaskingKey ? 1 : 0);
		int num = (useZeroMaskingKey ? 4 : 3);
		WebSocketProtocolComponent.Property[] array = new WebSocketProtocolComponent.Property[num];
		offset = m_PropertyBuffer.Offset;
		array[0] = new WebSocketProtocolComponent.Property
		{
			Type = WebSocketProtocolComponent.PropertyType.ReceiveBufferSize,
			PropertySize = (uint)s_SizeOfUInt,
			PropertyData = IntPtr.Add(intPtr, offset)
		};
		offset += s_SizeOfUInt;
		array[1] = new WebSocketProtocolComponent.Property
		{
			Type = WebSocketProtocolComponent.PropertyType.SendBufferSize,
			PropertySize = (uint)s_SizeOfUInt,
			PropertyData = IntPtr.Add(intPtr, offset)
		};
		offset += s_SizeOfUInt;
		array[2] = new WebSocketProtocolComponent.Property
		{
			Type = WebSocketProtocolComponent.PropertyType.AllocatedBuffer,
			PropertySize = (uint)m_NativeBuffer.Count,
			PropertyData = IntPtr.Add(intPtr, offset)
		};
		offset += IntPtr.Size;
		if (useZeroMaskingKey)
		{
			array[3] = new WebSocketProtocolComponent.Property
			{
				Type = WebSocketProtocolComponent.PropertyType.DisableMasking,
				PropertySize = (uint)s_SizeOfBool,
				PropertyData = IntPtr.Add(intPtr, offset)
			};
		}
		return array;
	}

	internal void PinSendBuffer(ArraySegment<byte> payload, out bool bufferHasBeenPinned)
	{
		bufferHasBeenPinned = false;
		WebSocketHelpers.ValidateBuffer(payload.Array, payload.Offset, payload.Count);
		if (Interlocked.Exchange(ref m_SendBufferState, 1) != 0)
		{
			throw new AccessViolationException();
		}
		m_PinnedSendBuffer = payload;
		m_PinnedSendBufferHandle = GCHandle.Alloc(m_PinnedSendBuffer.Array, GCHandleType.Pinned);
		bufferHasBeenPinned = true;
		m_PinnedSendBufferStartAddress = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_PinnedSendBuffer.Array, m_PinnedSendBuffer.Offset).ToInt64();
		m_PinnedSendBufferEndAddress = m_PinnedSendBufferStartAddress + m_PinnedSendBuffer.Count;
	}

	internal IntPtr ConvertPinnedSendPayloadToNative(ArraySegment<byte> payload)
	{
		return ConvertPinnedSendPayloadToNative(payload.Array, payload.Offset, payload.Count);
	}

	internal IntPtr ConvertPinnedSendPayloadToNative(byte[] buffer, int offset, int count)
	{
		if (!IsPinnedSendPayloadBuffer(buffer, offset, count))
		{
			throw new AccessViolationException();
		}
		return new IntPtr(m_PinnedSendBufferStartAddress + offset - m_PinnedSendBuffer.Offset);
	}

	internal ArraySegment<byte> ConvertPinnedSendPayloadFromNative(WebSocketProtocolComponent.Buffer buffer, WebSocketProtocolComponent.BufferType bufferType)
	{
		if (!IsPinnedSendPayloadBuffer(buffer, bufferType))
		{
			throw new AccessViolationException();
		}
		UnwrapWebSocketBuffer(buffer, bufferType, out var bufferData, out var bufferLength);
		int num = (int)(bufferData.ToInt64() - m_PinnedSendBufferStartAddress);
		return new ArraySegment<byte>(m_PinnedSendBuffer.Array, m_PinnedSendBuffer.Offset + num, (int)bufferLength);
	}

	private bool IsPinnedSendPayloadBuffer(byte[] buffer, int offset, int count)
	{
		if (m_SendBufferState != 1)
		{
			return false;
		}
		if (buffer == m_PinnedSendBuffer.Array && offset >= m_PinnedSendBuffer.Offset)
		{
			return offset + count <= m_PinnedSendBuffer.Offset + m_PinnedSendBuffer.Count;
		}
		return false;
	}

	internal bool IsPinnedSendPayloadBuffer(WebSocketProtocolComponent.Buffer buffer, WebSocketProtocolComponent.BufferType bufferType)
	{
		if (m_SendBufferState != 1)
		{
			return false;
		}
		UnwrapWebSocketBuffer(buffer, bufferType, out var bufferData, out var bufferLength);
		long num = bufferData.ToInt64();
		long num2 = num + bufferLength;
		if (num >= m_PinnedSendBufferStartAddress && num2 >= m_PinnedSendBufferStartAddress && num <= m_PinnedSendBufferEndAddress)
		{
			return num2 <= m_PinnedSendBufferEndAddress;
		}
		return false;
	}

	internal void ReleasePinnedSendBuffer()
	{
		int num = Interlocked.Exchange(ref m_SendBufferState, 0);
		if (num == 1)
		{
			if (m_PinnedSendBufferHandle.IsAllocated)
			{
				m_PinnedSendBufferHandle.Free();
			}
			m_PinnedSendBuffer = WebSocketHelpers.EmptyPayload;
		}
	}

	internal void BufferPayload(ArraySegment<byte> payload, int unconsumedDataOffset, WebSocketMessageType messageType, bool endOfMessage)
	{
		ThrowIfDisposed();
		int count = payload.Count - unconsumedDataOffset;
		Buffer.BlockCopy(payload.Array, payload.Offset + unconsumedDataOffset, m_PayloadBuffer.Array, m_PayloadBuffer.Offset, count);
		m_BufferedPayloadReceiveResult = new WebSocketReceiveResult(count, messageType, endOfMessage);
	}

	internal bool ReceiveFromBufferedPayload(ArraySegment<byte> buffer, out WebSocketReceiveResult receiveResult)
	{
		ThrowIfDisposed();
		int num = Math.Min(buffer.Count, m_BufferedPayloadReceiveResult.Count);
		receiveResult = m_BufferedPayloadReceiveResult.Copy(num);
		Buffer.BlockCopy(m_PayloadBuffer.Array, m_PayloadBuffer.Offset + m_PayloadOffset, buffer.Array, buffer.Offset, num);
		if (m_BufferedPayloadReceiveResult.Count == 0)
		{
			m_PayloadOffset = 0;
			m_BufferedPayloadReceiveResult = null;
			return false;
		}
		m_PayloadOffset += num;
		return true;
	}

	internal ArraySegment<byte> ConvertNativeBuffer(WebSocketProtocolComponent.Action action, WebSocketProtocolComponent.Buffer buffer, WebSocketProtocolComponent.BufferType bufferType)
	{
		ThrowIfDisposed();
		UnwrapWebSocketBuffer(buffer, bufferType, out var bufferData, out var bufferLength);
		if (bufferData == IntPtr.Zero)
		{
			return WebSocketHelpers.EmptyPayload;
		}
		if (IsNativeBuffer(bufferData, bufferLength))
		{
			return new ArraySegment<byte>(m_InternalBuffer.Array, GetOffset(bufferData), (int)bufferLength);
		}
		throw new AccessViolationException();
	}

	internal void ConvertCloseBuffer(WebSocketProtocolComponent.Action action, WebSocketProtocolComponent.Buffer buffer, out WebSocketCloseStatus closeStatus, out string reason)
	{
		ThrowIfDisposed();
		closeStatus = (WebSocketCloseStatus)buffer.CloseStatus.CloseStatus;
		UnwrapWebSocketBuffer(buffer, WebSocketProtocolComponent.BufferType.Close, out var bufferData, out var bufferLength);
		if (bufferData == IntPtr.Zero)
		{
			reason = null;
			return;
		}
		if (IsNativeBuffer(bufferData, bufferLength))
		{
			ArraySegment<byte> arraySegment = new ArraySegment<byte>(m_InternalBuffer.Array, GetOffset(bufferData), (int)bufferLength);
			reason = Encoding.UTF8.GetString(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			return;
		}
		throw new AccessViolationException();
	}

	internal void ValidateNativeBuffers(WebSocketProtocolComponent.Action action, WebSocketProtocolComponent.BufferType bufferType, WebSocketProtocolComponent.Buffer[] dataBuffers, uint dataBufferCount)
	{
		ThrowIfDisposed();
		if (dataBufferCount > dataBuffers.Length)
		{
			throw new AccessViolationException();
		}
		int num = dataBuffers.Length;
		bool flag = action == WebSocketProtocolComponent.Action.IndicateSendComplete || action == WebSocketProtocolComponent.Action.SendToNetwork;
		if (flag)
		{
			num = (int)dataBufferCount;
		}
		bool flag2 = false;
		for (int i = 0; i < num; i++)
		{
			WebSocketProtocolComponent.Buffer buffer = dataBuffers[i];
			UnwrapWebSocketBuffer(buffer, bufferType, out var bufferData, out var bufferLength);
			if (!(bufferData == IntPtr.Zero))
			{
				flag2 = true;
				bool flag3 = IsPinnedSendPayloadBuffer(buffer, bufferType);
				if (bufferLength > GetMaxBufferSize() && (!flag || !flag3))
				{
					throw new AccessViolationException();
				}
				if (!flag3 && !IsNativeBuffer(bufferData, bufferLength))
				{
					throw new AccessViolationException();
				}
			}
		}
		if (!flag2 && action != WebSocketProtocolComponent.Action.NoAction && action != WebSocketProtocolComponent.Action.IndicateReceiveComplete)
		{
			_ = 2;
		}
	}

	private static int GetNativeSendBufferSize(int sendBufferSize, bool isServerBuffer)
	{
		if (!isServerBuffer)
		{
			return sendBufferSize;
		}
		return 16;
	}

	internal static void UnwrapWebSocketBuffer(WebSocketProtocolComponent.Buffer buffer, WebSocketProtocolComponent.BufferType bufferType, out IntPtr bufferData, out uint bufferLength)
	{
		bufferData = IntPtr.Zero;
		bufferLength = 0u;
		switch (bufferType)
		{
		case WebSocketProtocolComponent.BufferType.Close:
			bufferData = buffer.CloseStatus.ReasonData;
			bufferLength = buffer.CloseStatus.ReasonLength;
			break;
		case WebSocketProtocolComponent.BufferType.UTF8Message:
		case WebSocketProtocolComponent.BufferType.UTF8Fragment:
		case WebSocketProtocolComponent.BufferType.BinaryMessage:
		case WebSocketProtocolComponent.BufferType.BinaryFragment:
		case WebSocketProtocolComponent.BufferType.PingPong:
		case WebSocketProtocolComponent.BufferType.UnsolicitedPong:
		case WebSocketProtocolComponent.BufferType.None:
			bufferData = buffer.Data.BufferData;
			bufferLength = buffer.Data.BufferLength;
			break;
		}
	}

	private void ThrowIfDisposed()
	{
		switch (m_StateWhenDisposing)
		{
		case int.MinValue:
			break;
		case 5:
		case 6:
			throw new WebSocketException(WebSocketError.InvalidState, SR.GetString("net_WebSockets_InvalidState_ClosedOrAborted", typeof(WebSocketBase), m_StateWhenDisposing));
		default:
			throw new ObjectDisposedException(GetType().FullName);
		}
	}

	[Conditional("DEBUG")]
	[Conditional("CONTRACTS_FULL")]
	private void ValidateBufferedPayload()
	{
	}

	private int GetOffset(IntPtr pBuffer)
	{
		return (int)(pBuffer.ToInt64() - m_StartAddress + m_InternalBuffer.Offset);
	}

	private int GetMaxBufferSize()
	{
		return Math.Max(m_ReceiveBufferSize, m_SendBufferSize);
	}

	internal bool IsInternalBuffer(byte[] buffer, int offset, int count)
	{
		if (buffer == m_NativeBuffer.Array && offset >= m_NativeBuffer.Offset)
		{
			return offset + count <= m_NativeBuffer.Offset + m_NativeBuffer.Count;
		}
		return false;
	}

	internal IntPtr ToIntPtr(int offset)
	{
		return new IntPtr(m_StartAddress + offset - m_InternalBuffer.Offset);
	}

	private bool IsNativeBuffer(IntPtr pBuffer, uint bufferSize)
	{
		long num = pBuffer.ToInt64();
		long num2 = bufferSize + num;
		if (num >= m_StartAddress && num <= m_EndAddress && num2 >= m_StartAddress && num2 <= m_EndAddress)
		{
			return true;
		}
		return false;
	}

	private void CleanUp()
	{
		if (m_GCHandle.IsAllocated)
		{
			m_GCHandle.Free();
		}
		ReleasePinnedSendBuffer();
	}

	internal static ArraySegment<byte> CreateInternalBufferArraySegment(int receiveBufferSize, int sendBufferSize, bool isServerBuffer)
	{
		int internalBufferSize = GetInternalBufferSize(receiveBufferSize, sendBufferSize, isServerBuffer);
		return new ArraySegment<byte>(new byte[internalBufferSize]);
	}

	internal static void Validate(int count, int receiveBufferSize, int sendBufferSize, bool isServerBuffer)
	{
		int internalBufferSize = GetInternalBufferSize(receiveBufferSize, sendBufferSize, isServerBuffer);
		if (count < internalBufferSize)
		{
			throw new ArgumentOutOfRangeException("internalBuffer", SR.GetString("net_WebSockets_ArgumentOutOfRange_InternalBuffer", internalBufferSize));
		}
	}

	private static int GetInternalBufferSize(int receiveBufferSize, int sendBufferSize, bool isServerBuffer)
	{
		int nativeSendBufferSize = GetNativeSendBufferSize(sendBufferSize, isServerBuffer);
		return 2 * receiveBufferSize + nativeSendBufferSize + 144 + s_PropertyBufferSize;
	}
}
