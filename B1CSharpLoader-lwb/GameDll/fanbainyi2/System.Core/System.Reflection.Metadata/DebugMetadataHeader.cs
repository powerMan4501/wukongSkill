using System.Collections.Immutable;

namespace System.Reflection.Metadata;

internal sealed class DebugMetadataHeader
{
	public ImmutableArray<byte> Id { get; }

	public MethodDefinitionHandle EntryPoint { get; }

	internal DebugMetadataHeader(ImmutableArray<byte> id, MethodDefinitionHandle entryPoint)
	{
		Id = id;
		EntryPoint = entryPoint;
	}
}
