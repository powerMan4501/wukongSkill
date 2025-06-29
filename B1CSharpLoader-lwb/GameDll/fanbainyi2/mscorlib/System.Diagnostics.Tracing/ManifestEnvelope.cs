namespace System.Diagnostics.Tracing;

internal struct ManifestEnvelope
{
	public enum ManifestFormats : byte
	{
		SimpleXmlFormat = 1
	}

	public const int MaxChunkSize = 65280;

	public ManifestFormats Format;

	public byte MajorVersion;

	public byte MinorVersion;

	public byte Magic;

	public ushort TotalChunks;

	public ushort ChunkNumber;
}
