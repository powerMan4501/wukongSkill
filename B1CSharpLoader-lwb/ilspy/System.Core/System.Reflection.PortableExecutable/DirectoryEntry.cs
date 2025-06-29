namespace System.Reflection.PortableExecutable;

internal struct DirectoryEntry
{
	public readonly int RelativeVirtualAddress;

	public readonly int Size;

	public DirectoryEntry(int relativeVirtualAddress, int size)
	{
		RelativeVirtualAddress = relativeVirtualAddress;
		Size = size;
	}

	internal DirectoryEntry(ref PEBinaryReader reader)
	{
		RelativeVirtualAddress = reader.ReadInt32();
		Size = reader.ReadInt32();
	}
}
