namespace System.Reflection.Metadata;

internal struct Document
{
	private readonly MetadataReader _reader;

	private readonly int _rowId;

	private DocumentHandle Handle => DocumentHandle.FromRowId(_rowId);

	public DocumentNameBlobHandle Name => _reader.DocumentTable.GetName(Handle);

	internal Document(MetadataReader reader, DocumentHandle handle)
	{
		_reader = reader;
		_rowId = handle.RowId;
	}
}
