namespace System.IO.Ports;

public class SerialErrorReceivedEventArgs : EventArgs
{
	private SerialError errorType;

	public SerialError EventType => errorType;

	internal SerialErrorReceivedEventArgs(SerialError eventCode)
	{
		errorType = eventCode;
	}
}
