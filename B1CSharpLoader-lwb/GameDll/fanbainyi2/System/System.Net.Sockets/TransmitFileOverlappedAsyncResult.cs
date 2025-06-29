using System.IO;
using System.Runtime.InteropServices;

namespace System.Net.Sockets;

internal class TransmitFileOverlappedAsyncResult : BaseOverlappedAsyncResult
{
	private FileStream m_fileStream;

	private TransmitFileOptions m_flags;

	private TransmitFileBuffers m_buffers;

	internal TransmitFileBuffers TransmitFileBuffers => m_buffers;

	internal TransmitFileOptions Flags => m_flags;

	internal TransmitFileOverlappedAsyncResult(Socket socket, object asyncState, AsyncCallback asyncCallback)
		: base(socket, asyncState, asyncCallback)
	{
	}

	internal TransmitFileOverlappedAsyncResult(Socket socket)
		: base(socket)
	{
	}

	internal void SetUnmanagedStructures(byte[] preBuffer, byte[] postBuffer, FileStream fileStream, TransmitFileOptions flags, bool sync)
	{
		m_fileStream = fileStream;
		m_flags = flags;
		m_buffers = null;
		int num = 0;
		if (preBuffer != null && preBuffer.Length != 0)
		{
			num++;
		}
		if (postBuffer != null && postBuffer.Length != 0)
		{
			num++;
		}
		object[] array = null;
		if (num != 0)
		{
			num++;
			array = new object[num];
			m_buffers = new TransmitFileBuffers();
			array[--num] = m_buffers;
			if (preBuffer != null && preBuffer.Length != 0)
			{
				m_buffers.preBufferLength = preBuffer.Length;
				array[--num] = preBuffer;
			}
			if (postBuffer != null && postBuffer.Length != 0)
			{
				m_buffers.postBufferLength = postBuffer.Length;
				array[--num] = postBuffer;
			}
			if (sync)
			{
				PinUnmanagedObjects(array);
			}
			else
			{
				SetUnmanagedStructures(array);
			}
			if (preBuffer != null && preBuffer.Length != 0)
			{
				m_buffers.preBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)preBuffer, 0);
			}
			if (postBuffer != null && postBuffer.Length != 0)
			{
				m_buffers.postBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)postBuffer, 0);
			}
		}
		else if (!sync)
		{
			SetUnmanagedStructures(null);
		}
	}

	internal void SetUnmanagedStructures(byte[] preBuffer, byte[] postBuffer, FileStream fileStream, TransmitFileOptions flags, ref OverlappedCache overlappedCache)
	{
		SetupCache(ref overlappedCache);
		SetUnmanagedStructures(preBuffer, postBuffer, fileStream, flags, sync: false);
	}

	protected override void ForceReleaseUnmanagedStructures()
	{
		if (m_fileStream != null)
		{
			m_fileStream.Close();
			m_fileStream = null;
		}
		base.ForceReleaseUnmanagedStructures();
	}

	internal void SyncReleaseUnmanagedStructures()
	{
		ForceReleaseUnmanagedStructures();
	}
}
