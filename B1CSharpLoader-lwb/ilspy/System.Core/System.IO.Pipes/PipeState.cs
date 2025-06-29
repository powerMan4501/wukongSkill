namespace System.IO.Pipes;

[Serializable]
internal enum PipeState
{
	WaitingToConnect,
	Connected,
	Broken,
	Disconnected,
	Closed
}
