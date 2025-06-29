using System.Collections.Immutable;
using System.Reflection.Internal;
using System.Reflection.Metadata.Ecma335;
using System.Security;

namespace System.Reflection.Metadata;

internal sealed class MetadataReader
{
	internal readonly MemoryBlock Block;

	private readonly MetadataReaderOptions _options;

	private readonly string _versionString;

	private readonly MetadataKind _metadataKind;

	private readonly MetadataStreamKind _metadataStreamKind;

	private readonly DebugMetadataHeader _debugMetadataHeader;

	internal BlobHeap BlobHeap;

	internal bool IsMinimalDelta;

	private readonly TableMask _sortedTables;

	internal int[] TableRowCounts;

	internal DocumentTableReader DocumentTable;

	internal MethodDebugInformationTableReader MethodDebugInformationTable;

	private const int SmallIndexSize = 2;

	private const int LargeIndexSize = 4;

	public MetadataReaderOptions Options => _options;

	public string MetadataVersion => _versionString;

	public DebugMetadataHeader DebugMetadataHeader => _debugMetadataHeader;

	[SecurityCritical]
	public unsafe MetadataReader(byte* metadata, int length, MetadataReaderOptions options)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		Block = new MemoryBlock(metadata, length);
		_options = options;
		BlobReader memReader = new BlobReader(Block);
		ReadMetadataHeader(ref memReader, out _versionString);
		_metadataKind = GetMetadataKind(_versionString);
		StreamHeader[] streamHeaders = ReadStreamHeaders(ref memReader);
		InitializeStreamReaders(ref Block, streamHeaders, out _metadataStreamKind, out var metadataTableStream, out var standalonePdbStream);
		int[] externalTableRowCounts;
		if (standalonePdbStream.Length > 0)
		{
			ReadStandalonePortablePdbStream(standalonePdbStream, out _debugMetadataHeader, out externalTableRowCounts);
		}
		else
		{
			externalTableRowCounts = null;
		}
		BlobReader reader = new BlobReader(metadataTableStream);
		ReadMetadataTableHeader(ref reader, out var heapSizes, out var metadataTableRowCounts, out _sortedTables);
		InitializeTableReaders(reader.GetMemoryBlockAt(0, reader.RemainingBytes), heapSizes, metadataTableRowCounts, externalTableRowCounts);
	}

	private void ReadMetadataHeader(ref BlobReader memReader, out string versionString)
	{
		if (memReader.RemainingBytes < 16)
		{
			throw new BadImageFormatException("MetadataHeaderTooSmall");
		}
		uint num = memReader.ReadUInt32();
		if (num != 1112167234)
		{
			throw new BadImageFormatException("MetadataSignature");
		}
		memReader.ReadUInt16();
		memReader.ReadUInt16();
		memReader.ReadUInt32();
		int num2 = memReader.ReadInt32();
		if (memReader.RemainingBytes < num2)
		{
			throw new BadImageFormatException("NotEnoughSpaceForVersionString");
		}
		versionString = memReader.GetMemoryBlockAt(0, num2).PeekUtf8NullTerminated(0, out var _);
		memReader.Offset += num2;
	}

	private MetadataKind GetMetadataKind(string versionString)
	{
		if ((_options & MetadataReaderOptions.Default) == 0)
		{
			return MetadataKind.Ecma335;
		}
		if (!versionString.Contains("WindowsRuntime"))
		{
			return MetadataKind.Ecma335;
		}
		if (versionString.Contains("CLR"))
		{
			return MetadataKind.ManagedWindowsMetadata;
		}
		return MetadataKind.WindowsMetadata;
	}

	private StreamHeader[] ReadStreamHeaders(ref BlobReader memReader)
	{
		memReader.ReadUInt16();
		int num = memReader.ReadInt16();
		StreamHeader[] array = new StreamHeader[num];
		for (int i = 0; i < array.Length; i++)
		{
			if (memReader.RemainingBytes < 8)
			{
				throw new BadImageFormatException("StreamHeaderTooSmall");
			}
			array[i].Offset = memReader.ReadUInt32();
			array[i].Size = memReader.ReadInt32();
			array[i].Name = memReader.ReadUtf8NullTerminated();
			if (!memReader.TryAlign(4) || memReader.RemainingBytes == 0)
			{
				throw new BadImageFormatException("NotEnoughSpaceForStreamHeaderName");
			}
		}
		return array;
	}

	private void InitializeStreamReaders(ref MemoryBlock metadataRoot, StreamHeader[] streamHeaders, out MetadataStreamKind metadataStreamKind, out MemoryBlock metadataTableStream, out MemoryBlock standalonePdbStream)
	{
		metadataTableStream = default(MemoryBlock);
		standalonePdbStream = default(MemoryBlock);
		metadataStreamKind = MetadataStreamKind.Illegal;
		for (int i = 0; i < streamHeaders.Length; i++)
		{
			StreamHeader streamHeader = streamHeaders[i];
			switch (streamHeader.Name)
			{
			case "#Strings":
				if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
				{
					throw new BadImageFormatException("NotEnoughSpaceForStringStream");
				}
				break;
			case "#Blob":
				if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
				{
					throw new BadImageFormatException("NotEnoughSpaceForBlobStream");
				}
				BlobHeap = new BlobHeap(metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size), _metadataKind);
				break;
			case "#GUID":
				if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
				{
					throw new BadImageFormatException("NotEnoughSpaceForGUIDStream");
				}
				break;
			case "#US":
				if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
				{
					throw new BadImageFormatException("NotEnoughSpaceForBlobStream");
				}
				break;
			case "#~":
				if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
				{
					throw new BadImageFormatException("NotEnoughSpaceForMetadataStream");
				}
				metadataStreamKind = MetadataStreamKind.Compressed;
				metadataTableStream = metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size);
				break;
			case "#-":
				if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
				{
					throw new BadImageFormatException("NotEnoughSpaceForMetadataStream");
				}
				metadataStreamKind = MetadataStreamKind.Uncompressed;
				metadataTableStream = metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size);
				break;
			case "#JTD":
				if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
				{
					throw new BadImageFormatException("NotEnoughSpaceForMetadataStream");
				}
				IsMinimalDelta = true;
				break;
			case "#Pdb":
				if (metadataRoot.Length < streamHeader.Offset + streamHeader.Size)
				{
					throw new BadImageFormatException("NotEnoughSpaceForMetadataStream");
				}
				standalonePdbStream = metadataRoot.GetMemoryBlockAt((int)streamHeader.Offset, streamHeader.Size);
				break;
			}
		}
		if (IsMinimalDelta && metadataStreamKind != MetadataStreamKind.Uncompressed)
		{
			throw new BadImageFormatException("InvalidMetadataStreamFormat");
		}
	}

	private void ReadMetadataTableHeader(ref BlobReader reader, out HeapSizes heapSizes, out int[] metadataTableRowCounts, out TableMask sortedTables)
	{
		if (reader.RemainingBytes < 24)
		{
			throw new BadImageFormatException("MetadataTableHeaderTooSmall");
		}
		reader.ReadUInt32();
		reader.ReadByte();
		reader.ReadByte();
		heapSizes = (HeapSizes)reader.ReadByte();
		reader.ReadByte();
		ulong num = reader.ReadUInt64();
		sortedTables = (TableMask)reader.ReadUInt64();
		ulong num2 = 71811071505072127uL;
		if ((num & ~num2) != 0L)
		{
			throw new BadImageFormatException("UnknownTables");
		}
		if (_metadataStreamKind == MetadataStreamKind.Compressed && (num & 0x804800A8u) != 0L)
		{
			throw new BadImageFormatException("IllegalTablesInCompressedMetadataStream");
		}
		metadataTableRowCounts = ReadMetadataTableRowCounts(ref reader, num);
		if ((heapSizes & HeapSizes.ExtraData) == HeapSizes.ExtraData)
		{
			reader.ReadUInt32();
		}
	}

	private static int[] ReadMetadataTableRowCounts(ref BlobReader memReader, ulong presentTableMask)
	{
		ulong num = 1uL;
		int[] array = new int[MetadataTokens.TableCount];
		for (int i = 0; i < array.Length; i++)
		{
			if ((presentTableMask & num) != 0L)
			{
				if (memReader.RemainingBytes < 4)
				{
					throw new BadImageFormatException("TableRowCountSpaceTooSmall");
				}
				uint num2 = memReader.ReadUInt32();
				if (num2 > 16777215)
				{
					throw new BadImageFormatException("InvalidRowCount");
				}
				array[i] = (int)num2;
			}
			num <<= 1;
		}
		return array;
	}

	internal static void ReadStandalonePortablePdbStream(MemoryBlock block, out DebugMetadataHeader debugMetadataHeader, out int[] externalTableRowCounts)
	{
		BlobReader memReader = new BlobReader(block);
		byte[] array = memReader.ReadBytes(20);
		uint num = memReader.ReadUInt32();
		int num2 = (int)(num & 0xFFFFFF);
		if (num != 0 && ((num & 0x7F000000) != 100663296 || num2 == 0))
		{
			throw new BadImageFormatException("InvalidEntryPointToken");
		}
		ulong num3 = memReader.ReadUInt64();
		if ((num3 & 0xFFFFE036C04800A8uL) != 0L)
		{
			throw new BadImageFormatException("UnknownTables");
		}
		externalTableRowCounts = ReadMetadataTableRowCounts(ref memReader, num3);
		debugMetadataHeader = new DebugMetadataHeader(new ImmutableArray<byte>(array), MethodDefinitionHandle.FromRowId(num2));
	}

	private int GetReferenceSize(int[] rowCounts, TableIndex index)
	{
		if ((long)rowCounts[(uint)index] >= 65536L || IsMinimalDelta)
		{
			return 4;
		}
		return 2;
	}

	private void InitializeTableReaders(MemoryBlock metadataTablesMemoryBlock, HeapSizes heapSizes, int[] rowCounts, int[] externalRowCountsOpt)
	{
		TableRowCounts = rowCounts;
		int guidHeapRefSize = (((heapSizes & HeapSizes.GuidHeapLarge) == HeapSizes.GuidHeapLarge) ? 4 : 2);
		int blobHeapRefSize = (((heapSizes & HeapSizes.BlobHeapLarge) == HeapSizes.BlobHeapLarge) ? 4 : 2);
		int num = 0;
		DocumentTable = new DocumentTableReader(rowCounts[48], guidHeapRefSize, blobHeapRefSize, metadataTablesMemoryBlock, num);
		num += DocumentTable.Block.Length;
		MethodDebugInformationTable = new MethodDebugInformationTableReader(rowCounts[49], GetReferenceSize(rowCounts, TableIndex.Document), blobHeapRefSize, metadataTablesMemoryBlock, num);
		num += MethodDebugInformationTable.Block.Length;
		if (num > metadataTablesMemoryBlock.Length)
		{
			throw new BadImageFormatException("MetadataTablesTooSmall");
		}
	}

	public string GetString(DocumentNameBlobHandle handle)
	{
		return BlobHeap.GetDocumentName(handle);
	}

	public Document GetDocument(DocumentHandle handle)
	{
		return new Document(this, handle);
	}

	public MethodDebugInformation GetMethodDebugInformation(MethodDebugInformationHandle handle)
	{
		return new MethodDebugInformation(this, handle);
	}
}
