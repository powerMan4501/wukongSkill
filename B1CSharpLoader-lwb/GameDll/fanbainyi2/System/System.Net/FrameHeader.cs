using System.Globalization;

namespace System.Net;

internal class FrameHeader
{
	public const int IgnoreValue = -1;

	public const int HandshakeDoneId = 20;

	public const int HandshakeErrId = 21;

	public const int HandshakeId = 22;

	public const int DefaultMajorV = 1;

	public const int DefaultMinorV = 0;

	private int _MessageId;

	private int _MajorV;

	private int _MinorV;

	private int _PayloadSize;

	public int Size => 5;

	public int MaxMessageSize => 65535;

	public int MessageId
	{
		get
		{
			return _MessageId;
		}
		set
		{
			_MessageId = value;
		}
	}

	public int MajorV => _MajorV;

	public int MinorV => _MinorV;

	public int PayloadSize
	{
		get
		{
			return _PayloadSize;
		}
		set
		{
			if (value > MaxMessageSize)
			{
				throw new ArgumentException(SR.GetString("net_frame_max_size", MaxMessageSize.ToString(NumberFormatInfo.InvariantInfo), value.ToString(NumberFormatInfo.InvariantInfo)), "PayloadSize");
			}
			_PayloadSize = value;
		}
	}

	public FrameHeader()
	{
		_MessageId = 22;
		_MajorV = 1;
		_MinorV = 0;
		_PayloadSize = -1;
	}

	public FrameHeader(int messageId, int majorV, int minorV)
	{
		_MessageId = messageId;
		_MajorV = majorV;
		_MinorV = minorV;
		_PayloadSize = -1;
	}

	public void CopyTo(byte[] dest, int start)
	{
		dest[start++] = (byte)_MessageId;
		dest[start++] = (byte)_MajorV;
		dest[start++] = (byte)_MinorV;
		dest[start++] = (byte)((_PayloadSize >> 8) & 0xFF);
		dest[start] = (byte)(_PayloadSize & 0xFF);
	}

	public void CopyFrom(byte[] bytes, int start, FrameHeader verifier)
	{
		_MessageId = bytes[start++];
		_MajorV = bytes[start++];
		_MinorV = bytes[start++];
		_PayloadSize = (bytes[start++] << 8) | bytes[start];
		if (verifier.MessageId != -1 && MessageId != verifier.MessageId)
		{
			throw new InvalidOperationException(SR.GetString("net_io_header_id", "MessageId", MessageId, verifier.MessageId));
		}
		if (verifier.MajorV != -1 && MajorV != verifier.MajorV)
		{
			throw new InvalidOperationException(SR.GetString("net_io_header_id", "MajorV", MajorV, verifier.MajorV));
		}
		if (verifier.MinorV != -1 && MinorV != verifier.MinorV)
		{
			throw new InvalidOperationException(SR.GetString("net_io_header_id", "MinorV", MinorV, verifier.MinorV));
		}
	}
}
