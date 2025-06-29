namespace System.Reflection.Metadata;

internal struct MethodDebugInformation
{
	private readonly MetadataReader _reader;

	private readonly int _rowId;

	private MethodDebugInformationHandle Handle => MethodDebugInformationHandle.FromRowId(_rowId);

	public BlobHandle SequencePointsBlob => _reader.MethodDebugInformationTable.GetSequencePoints(Handle);

	public DocumentHandle Document => _reader.MethodDebugInformationTable.GetDocument(Handle);

	internal MethodDebugInformation(MetadataReader reader, MethodDebugInformationHandle handle)
	{
		_reader = reader;
		_rowId = handle.RowId;
	}

	public SequencePointCollection GetSequencePoints()
	{
		return new SequencePointCollection(_reader.BlobHeap.GetMemoryBlock(SequencePointsBlob), Document);
	}
}
