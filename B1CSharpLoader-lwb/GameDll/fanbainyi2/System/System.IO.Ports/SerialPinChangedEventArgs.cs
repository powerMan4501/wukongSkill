namespace System.IO.Ports;

public class SerialPinChangedEventArgs : EventArgs
{
	private SerialPinChange pinChanged;

	public SerialPinChange EventType => pinChanged;

	internal SerialPinChangedEventArgs(SerialPinChange eventCode)
	{
		pinChanged = eventCode;
	}
}
