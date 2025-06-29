namespace System.IO.Compression;

internal interface IInflater : IDisposable
{
	int AvailableOutput { get; }

	int Inflate(byte[] bytes, int offset, int length);

	bool Finished();

	bool NeedsInput();

	void SetInput(byte[] inputBytes, int offset, int length);
}
