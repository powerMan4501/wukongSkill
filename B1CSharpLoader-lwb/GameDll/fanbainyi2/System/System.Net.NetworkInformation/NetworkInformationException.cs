using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation;

[Serializable]
[global::__DynamicallyInvokable]
public class NetworkInformationException : Win32Exception
{
	[global::__DynamicallyInvokable]
	public override int ErrorCode
	{
		[global::__DynamicallyInvokable]
		get
		{
			return base.NativeErrorCode;
		}
	}

	[global::__DynamicallyInvokable]
	public NetworkInformationException()
		: base(Marshal.GetLastWin32Error())
	{
	}

	[global::__DynamicallyInvokable]
	public NetworkInformationException(int errorCode)
		: base(errorCode)
	{
	}

	internal NetworkInformationException(SocketError socketError)
		: base((int)socketError)
	{
	}

	protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}
}
