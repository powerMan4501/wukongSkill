namespace System.IO.Ports;

public enum SerialError
{
	TXFull = 256,
	RXOver = 1,
	Overrun = 2,
	RXParity = 4,
	Frame = 8
}
