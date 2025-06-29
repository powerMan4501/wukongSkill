namespace System.Net.Sockets;

public class SendPacketsElement
{
	internal string m_FilePath;

	internal byte[] m_Buffer;

	internal int m_Offset;

	internal int m_Count;

	internal UnsafeNclNativeMethods.OSSOCK.TransmitPacketsElementFlags m_Flags;

	public string FilePath => m_FilePath;

	public byte[] Buffer => m_Buffer;

	public int Count => m_Count;

	public int Offset => m_Offset;

	public bool EndOfPacket => (m_Flags & UnsafeNclNativeMethods.OSSOCK.TransmitPacketsElementFlags.EndOfPacket) != 0;

	private SendPacketsElement()
	{
	}

	public SendPacketsElement(string filepath)
		: this(filepath, 0, 0, endOfPacket: false)
	{
	}

	public SendPacketsElement(string filepath, int offset, int count)
		: this(filepath, offset, count, endOfPacket: false)
	{
	}

	public SendPacketsElement(string filepath, int offset, int count, bool endOfPacket)
	{
		if (filepath == null)
		{
			throw new ArgumentNullException("filepath");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		Initialize(filepath, null, offset, count, UnsafeNclNativeMethods.OSSOCK.TransmitPacketsElementFlags.File, endOfPacket);
	}

	public SendPacketsElement(byte[] buffer)
		: this(buffer, 0, (buffer != null) ? buffer.Length : 0, endOfPacket: false)
	{
	}

	public SendPacketsElement(byte[] buffer, int offset, int count)
		: this(buffer, offset, count, endOfPacket: false)
	{
	}

	public SendPacketsElement(byte[] buffer, int offset, int count, bool endOfPacket)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		Initialize(null, buffer, offset, count, UnsafeNclNativeMethods.OSSOCK.TransmitPacketsElementFlags.Memory, endOfPacket);
	}

	private void Initialize(string filePath, byte[] buffer, int offset, int count, UnsafeNclNativeMethods.OSSOCK.TransmitPacketsElementFlags flags, bool endOfPacket)
	{
		m_FilePath = filePath;
		m_Buffer = buffer;
		m_Offset = offset;
		m_Count = count;
		m_Flags = flags;
		if (endOfPacket)
		{
			m_Flags |= UnsafeNclNativeMethods.OSSOCK.TransmitPacketsElementFlags.EndOfPacket;
		}
	}
}
