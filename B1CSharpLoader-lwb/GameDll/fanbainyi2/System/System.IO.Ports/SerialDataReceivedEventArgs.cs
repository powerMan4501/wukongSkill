namespace System.IO.Ports;

public class SerialDataReceivedEventArgs : EventArgs
{
	internal SerialData receiveType;

	public SerialData EventType => receiveType;

	internal SerialDataReceivedEventArgs(SerialData eventCode)
	{
		receiveType = eventCode;
	}
}
