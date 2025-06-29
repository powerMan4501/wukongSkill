using System.Collections.Immutable;
using System.Reflection.Internal;
using System.Text;

namespace System.Reflection.Metadata.Ecma335;

internal struct BlobHeap
{
	internal readonly MemoryBlock Block;

	internal BlobHeap(MemoryBlock block, MetadataKind metadataKind)
	{
		Block = block;
	}

	internal byte[] GetBytes(BlobHandle handle)
	{
		int heapOffset = handle.GetHeapOffset();
		int numberOfBytesRead;
		int num = Block.PeekCompressedInteger(heapOffset, out numberOfBytesRead);
		if (num == int.MaxValue)
		{
			return ImmutableArray<byte>.Empty.UnderlyingArray;
		}
		return Block.PeekBytes(heapOffset + numberOfBytesRead, num);
	}

	internal MemoryBlock GetMemoryBlock(BlobHandle handle)
	{
		Block.PeekHeapValueOffsetAndSize(handle.GetHeapOffset(), out var offset, out var size);
		return Block.GetMemoryBlockAt(offset, size);
	}

	internal BlobReader GetBlobReader(BlobHandle handle)
	{
		return new BlobReader(GetMemoryBlock(handle));
	}

	public string GetDocumentName(DocumentNameBlobHandle handle)
	{
		BlobReader blobReader = GetBlobReader(handle);
		int num = blobReader.ReadByte();
		if (num > 127)
		{
			throw new BadImageFormatException("InvalidDocumentName");
		}
		PooledStringBuilder instance = PooledStringBuilder.GetInstance();
		StringBuilder builder = instance.Builder;
		bool flag = true;
		while (blobReader.RemainingBytes > 0)
		{
			if (num != 0 && !flag)
			{
				builder.Append((char)num);
			}
			BlobReader blobReader2 = GetBlobReader(blobReader.ReadBlobHandle());
			builder.Append(blobReader2.ReadUTF8(blobReader2.Length));
			flag = false;
		}
		return instance.ToStringAndFree();
	}
}
