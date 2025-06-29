namespace System.Net;

internal enum ReadState
{
	Start,
	StatusLine,
	Headers,
	Data
}
