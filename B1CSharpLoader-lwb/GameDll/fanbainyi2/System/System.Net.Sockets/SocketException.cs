using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net.Sockets;

[Serializable]
[global::__DynamicallyInvokable]
public class SocketException : Win32Exception
{
	[NonSerialized]
	private EndPoint m_EndPoint;

	public override int ErrorCode => base.NativeErrorCode;

	[global::__DynamicallyInvokable]
	public override string Message
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (m_EndPoint == null)
			{
				return base.Message;
			}
			return base.Message + " " + m_EndPoint.ToString();
		}
	}

	[global::__DynamicallyInvokable]
	public SocketError SocketErrorCode
	{
		[global::__DynamicallyInvokable]
		get
		{
			return (SocketError)base.NativeErrorCode;
		}
	}

	[global::__DynamicallyInvokable]
	public SocketException()
		: base(Marshal.GetLastWin32Error())
	{
	}

	internal SocketException(EndPoint endPoint)
		: base(Marshal.GetLastWin32Error())
	{
		m_EndPoint = endPoint;
	}

	[global::__DynamicallyInvokable]
	public SocketException(int errorCode)
		: base(errorCode)
	{
	}

	internal SocketException(int errorCode, EndPoint endPoint)
		: base(errorCode)
	{
		m_EndPoint = endPoint;
	}

	internal SocketException(SocketError socketError)
		: base((int)socketError)
	{
	}

	protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}
}
