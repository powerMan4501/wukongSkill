using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Net.Sockets;

internal class OverlappedAsyncResult : BaseOverlappedAsyncResult
{
	private SocketAddress m_SocketAddress;

	private SocketAddress m_SocketAddressOriginal;

	internal WSABuffer m_SingleBuffer;

	internal WSABuffer[] m_WSABuffers;

	internal SocketAddress SocketAddress => m_SocketAddress;

	internal SocketAddress SocketAddressOriginal
	{
		get
		{
			return m_SocketAddressOriginal;
		}
		set
		{
			m_SocketAddressOriginal = value;
		}
	}

	internal OverlappedAsyncResult(Socket socket, object asyncState, AsyncCallback asyncCallback)
		: base(socket, asyncState, asyncCallback)
	{
	}

	internal IntPtr GetSocketAddressPtr()
	{
		return Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_SocketAddress.m_Buffer, 0);
	}

	internal IntPtr GetSocketAddressSizePtr()
	{
		return Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_SocketAddress.m_Buffer, m_SocketAddress.GetAddressSizeOffset());
	}

	internal void SetUnmanagedStructures(byte[] buffer, int offset, int size, SocketAddress socketAddress, bool pinSocketAddress)
	{
		m_SocketAddress = socketAddress;
		if (pinSocketAddress && m_SocketAddress != null)
		{
			object[] array = null;
			array = new object[2] { buffer, null };
			m_SocketAddress.CopyAddressSizeIntoBuffer();
			array[1] = m_SocketAddress.m_Buffer;
			SetUnmanagedStructures(array);
		}
		else
		{
			SetUnmanagedStructures(buffer);
		}
		m_SingleBuffer.Length = size;
		m_SingleBuffer.Pointer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffer, offset);
	}

	internal void SetUnmanagedStructures(byte[] buffer, int offset, int size, SocketAddress socketAddress, bool pinSocketAddress, ref OverlappedCache overlappedCache)
	{
		SetupCache(ref overlappedCache);
		SetUnmanagedStructures(buffer, offset, size, socketAddress, pinSocketAddress);
	}

	internal void SetUnmanagedStructures(BufferOffsetSize[] buffers)
	{
		m_WSABuffers = new WSABuffer[buffers.Length];
		object[] array = new object[buffers.Length];
		for (int i = 0; i < buffers.Length; i++)
		{
			array[i] = buffers[i].Buffer;
		}
		SetUnmanagedStructures(array);
		for (int j = 0; j < buffers.Length; j++)
		{
			m_WSABuffers[j].Length = buffers[j].Size;
			m_WSABuffers[j].Pointer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffers[j].Buffer, buffers[j].Offset);
		}
	}

	internal void SetUnmanagedStructures(BufferOffsetSize[] buffers, ref OverlappedCache overlappedCache)
	{
		SetupCache(ref overlappedCache);
		SetUnmanagedStructures(buffers);
	}

	internal void SetUnmanagedStructures(IList<ArraySegment<byte>> buffers)
	{
		int count = buffers.Count;
		ArraySegment<byte>[] array = new ArraySegment<byte>[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = buffers[i];
			ValidationHelper.ValidateSegment(array[i]);
		}
		m_WSABuffers = new WSABuffer[count];
		object[] array2 = new object[count];
		for (int j = 0; j < count; j++)
		{
			array2[j] = array[j].Array;
		}
		SetUnmanagedStructures(array2);
		for (int k = 0; k < count; k++)
		{
			m_WSABuffers[k].Length = array[k].Count;
			m_WSABuffers[k].Pointer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)array[k].Array, array[k].Offset);
		}
	}

	internal void SetUnmanagedStructures(IList<ArraySegment<byte>> buffers, ref OverlappedCache overlappedCache)
	{
		SetupCache(ref overlappedCache);
		SetUnmanagedStructures(buffers);
	}

	internal override object PostCompletion(int numBytes)
	{
		if (base.ErrorCode == 0 && Logging.On)
		{
			LogBuffer(numBytes);
		}
		return numBytes;
	}

	private void LogBuffer(int size)
	{
		if (size <= -1)
		{
			return;
		}
		if (m_WSABuffers != null)
		{
			WSABuffer[] wSABuffers = m_WSABuffers;
			for (int i = 0; i < wSABuffers.Length; i++)
			{
				WSABuffer wSABuffer = wSABuffers[i];
				Logging.Dump(Logging.Sockets, base.AsyncObject, "PostCompletion", wSABuffer.Pointer, Math.Min(wSABuffer.Length, size));
				if ((size -= wSABuffer.Length) <= 0)
				{
					break;
				}
			}
		}
		else
		{
			Logging.Dump(Logging.Sockets, base.AsyncObject, "PostCompletion", m_SingleBuffer.Pointer, Math.Min(m_SingleBuffer.Length, size));
		}
	}
}
