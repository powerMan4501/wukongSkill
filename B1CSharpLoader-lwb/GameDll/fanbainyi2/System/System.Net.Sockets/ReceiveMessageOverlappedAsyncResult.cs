using System.Runtime.InteropServices;

namespace System.Net.Sockets;

internal class ReceiveMessageOverlappedAsyncResult : BaseOverlappedAsyncResult
{
	private unsafe UnsafeNclNativeMethods.OSSOCK.WSAMsg* m_Message;

	internal SocketAddress SocketAddressOriginal;

	internal SocketAddress m_SocketAddress;

	private unsafe WSABuffer* m_WSABuffer;

	private byte[] m_WSABufferArray;

	private byte[] m_ControlBuffer;

	internal byte[] m_MessageBuffer;

	internal SocketFlags m_flags;

	private static readonly int s_ControlDataSize = Marshal.SizeOf(typeof(UnsafeNclNativeMethods.OSSOCK.ControlData));

	private static readonly int s_ControlDataIPv6Size = Marshal.SizeOf(typeof(UnsafeNclNativeMethods.OSSOCK.ControlDataIPv6));

	private static readonly int s_WSABufferSize = Marshal.SizeOf(typeof(WSABuffer));

	private static readonly int s_WSAMsgSize = Marshal.SizeOf(typeof(UnsafeNclNativeMethods.OSSOCK.WSAMsg));

	internal IPPacketInformation m_IPPacketInformation;

	internal SocketAddress SocketAddress => m_SocketAddress;

	internal ReceiveMessageOverlappedAsyncResult(Socket socket, object asyncState, AsyncCallback asyncCallback)
		: base(socket, asyncState, asyncCallback)
	{
	}

	internal IntPtr GetSocketAddressSizePtr()
	{
		return Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_SocketAddress.m_Buffer, m_SocketAddress.GetAddressSizeOffset());
	}

	internal unsafe void SetUnmanagedStructures(byte[] buffer, int offset, int size, SocketAddress socketAddress, SocketFlags socketFlags)
	{
		m_MessageBuffer = new byte[s_WSAMsgSize];
		m_WSABufferArray = new byte[s_WSABufferSize];
		IPAddress iPAddress = ((socketAddress.Family == AddressFamily.InterNetworkV6) ? socketAddress.GetIPAddress() : null);
		bool flag = ((Socket)base.AsyncObject).AddressFamily == AddressFamily.InterNetwork || (iPAddress?.IsIPv4MappedToIPv6 ?? false);
		bool flag2 = ((Socket)base.AsyncObject).AddressFamily == AddressFamily.InterNetworkV6;
		if (flag)
		{
			m_ControlBuffer = new byte[s_ControlDataSize];
		}
		else if (flag2)
		{
			m_ControlBuffer = new byte[s_ControlDataIPv6Size];
		}
		object[] array = new object[(m_ControlBuffer != null) ? 5 : 4];
		array[0] = buffer;
		array[1] = m_MessageBuffer;
		array[2] = m_WSABufferArray;
		m_SocketAddress = socketAddress;
		m_SocketAddress.CopyAddressSizeIntoBuffer();
		array[3] = m_SocketAddress.m_Buffer;
		if (m_ControlBuffer != null)
		{
			array[4] = m_ControlBuffer;
		}
		SetUnmanagedStructures(array);
		m_WSABuffer = (WSABuffer*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_WSABufferArray, 0);
		m_WSABuffer->Length = size;
		m_WSABuffer->Pointer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffer, offset);
		m_Message = (UnsafeNclNativeMethods.OSSOCK.WSAMsg*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_MessageBuffer, 0);
		m_Message->socketAddress = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_SocketAddress.m_Buffer, 0);
		m_Message->addressLength = (uint)m_SocketAddress.Size;
		m_Message->buffers = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_WSABufferArray, 0);
		m_Message->count = 1u;
		if (m_ControlBuffer != null)
		{
			m_Message->controlBuffer.Pointer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_ControlBuffer, 0);
			m_Message->controlBuffer.Length = m_ControlBuffer.Length;
		}
		m_Message->flags = socketFlags;
	}

	internal void SetUnmanagedStructures(byte[] buffer, int offset, int size, SocketAddress socketAddress, SocketFlags socketFlags, ref OverlappedCache overlappedCache)
	{
		SetupCache(ref overlappedCache);
		SetUnmanagedStructures(buffer, offset, size, socketAddress, socketFlags);
	}

	private unsafe void InitIPPacketInformation()
	{
		IPAddress iPAddress = null;
		if (m_ControlBuffer.Length == s_ControlDataSize)
		{
			UnsafeNclNativeMethods.OSSOCK.ControlData controlData = (UnsafeNclNativeMethods.OSSOCK.ControlData)Marshal.PtrToStructure(m_Message->controlBuffer.Pointer, typeof(UnsafeNclNativeMethods.OSSOCK.ControlData));
			if (controlData.length != UIntPtr.Zero)
			{
				iPAddress = new IPAddress(controlData.address);
			}
			m_IPPacketInformation = new IPPacketInformation((iPAddress != null) ? iPAddress : IPAddress.None, (int)controlData.index);
		}
		else if (m_ControlBuffer.Length == s_ControlDataIPv6Size)
		{
			UnsafeNclNativeMethods.OSSOCK.ControlDataIPv6 controlDataIPv = (UnsafeNclNativeMethods.OSSOCK.ControlDataIPv6)Marshal.PtrToStructure(m_Message->controlBuffer.Pointer, typeof(UnsafeNclNativeMethods.OSSOCK.ControlDataIPv6));
			if (controlDataIPv.length != UIntPtr.Zero)
			{
				iPAddress = new IPAddress(controlDataIPv.address);
			}
			m_IPPacketInformation = new IPPacketInformation((iPAddress != null) ? iPAddress : IPAddress.IPv6None, (int)controlDataIPv.index);
		}
		else
		{
			m_IPPacketInformation = default(IPPacketInformation);
		}
	}

	internal void SyncReleaseUnmanagedStructures()
	{
		InitIPPacketInformation();
		ForceReleaseUnmanagedStructures();
	}

	protected unsafe override void ForceReleaseUnmanagedStructures()
	{
		m_flags = m_Message->flags;
		base.ForceReleaseUnmanagedStructures();
	}

	internal override object PostCompletion(int numBytes)
	{
		InitIPPacketInformation();
		if (base.ErrorCode == 0 && Logging.On)
		{
			LogBuffer(numBytes);
		}
		return numBytes;
	}

	private unsafe void LogBuffer(int size)
	{
		Logging.Dump(Logging.Sockets, base.AsyncObject, "PostCompletion", m_WSABuffer->Pointer, Math.Min(m_WSABuffer->Length, size));
	}
}
