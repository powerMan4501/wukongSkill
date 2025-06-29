namespace System.IO.Pipes;

[Serializable]
[Flags]
public enum PipeOptions
{
	None = 0,
	WriteThrough = int.MinValue,
	Asynchronous = 0x40000000
}
