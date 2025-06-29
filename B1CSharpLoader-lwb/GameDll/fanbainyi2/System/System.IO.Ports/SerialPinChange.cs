namespace System.IO.Ports;

public enum SerialPinChange
{
	CtsChanged = 8,
	DsrChanged = 16,
	CDChanged = 32,
	Ring = 256,
	Break = 64
}
