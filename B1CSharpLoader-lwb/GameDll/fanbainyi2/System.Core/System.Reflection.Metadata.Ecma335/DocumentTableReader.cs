using System.Reflection.Internal;

namespace System.Reflection.Metadata.Ecma335;

internal struct DocumentTableReader
{
	internal readonly int NumberOfRows;

	private readonly bool _isGuidHeapRefSizeSmall;

	private readonly bool _isBlobHeapRefSizeSmall;

	private const int NameOffset = 0;

	private readonly int _hashAlgorithmOffset;

	private readonly int _hashOffset;

	private readonly int _languageOffset;

	internal readonly int RowSize;

	internal readonly MemoryBlock Block;

	internal DocumentTableReader(int numberOfRows, int guidHeapRefSize, int blobHeapRefSize, MemoryBlock containingBlock, int containingBlockOffset)
	{
		NumberOfRows = numberOfRows;
		_isGuidHeapRefSizeSmall = guidHeapRefSize == 2;
		_isBlobHeapRefSizeSmall = blobHeapRefSize == 2;
		_hashAlgorithmOffset = blobHeapRefSize;
		_hashOffset = _hashAlgorithmOffset + guidHeapRefSize;
		_languageOffset = _hashOffset + blobHeapRefSize;
		RowSize = _languageOffset + guidHeapRefSize;
		Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, RowSize * numberOfRows);
	}

	internal DocumentNameBlobHandle GetName(DocumentHandle handle)
	{
		int offset = (handle.RowId - 1) * RowSize;
		return DocumentNameBlobHandle.FromOffset(Block.PeekHeapReference(offset, _isBlobHeapRefSizeSmall));
	}

	internal BlobHandle GetHash(DocumentHandle handle)
	{
		int num = (handle.RowId - 1) * RowSize;
		return BlobHandle.FromOffset(Block.PeekHeapReference(num + _hashOffset, _isBlobHeapRefSizeSmall));
	}
}
