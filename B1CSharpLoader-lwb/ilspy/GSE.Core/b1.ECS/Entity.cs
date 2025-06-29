using System;

namespace b1.ECS;

public struct Entity : IEquatable<Entity>
{
	public const int MaxMgrCount = 16;

	public const int MaxVersion = 16;

	private int Index;

	public int EntityMgrIdx => (Index & 0x78000000) >> 27;

	public int ArchIndex => (Index & 0x7F00000) >> 20;

	internal int ChunkIndex => (Index & 0xFC000) >> 14;

	internal int Version => (Index & 0x3C00) >> 10;

	public int IndexInChunk => Index & 0x3FF;

	public static Entity Null => default(Entity);

	public static bool operator ==(Entity lhs, Entity rhs)
	{
		return lhs.Index == rhs.Index;
	}

	public static bool operator !=(Entity lhs, Entity rhs)
	{
		return !(lhs == rhs);
	}

	public override bool Equals(object compare)
	{
		return this == (Entity)compare;
	}

	public override int GetHashCode()
	{
		return Index;
	}

	public bool Equals(Entity entity)
	{
		return entity.Index == Index;
	}

	public override string ToString()
	{
		return $"Entity Index: {Index} Version: {Version} ChunkIndex: {ChunkIndex} EntityMgrIdx:{EntityMgrIdx} ArchIndex{ArchIndex}";
	}

	public void GetChunkIndices(out int OutEntityMgrIdx, out int OutArchIndex, out int OutChunkIndex, out int OutIndexInChunk, out int OutVersion)
	{
		OutEntityMgrIdx = EntityMgrIdx;
		OutArchIndex = ArchIndex;
		OutChunkIndex = ChunkIndex;
		OutVersion = Version;
		OutIndexInChunk = IndexInChunk;
	}

	public void SetChunkIndices(int EntityMgrIdx, int ArchIndex, int ChunkIndex, int IndexInChunk, int Version)
	{
		Index = (EntityMgrIdx << 27) + (ArchIndex << 20) + (ChunkIndex << 14) + (Version << 10) + IndexInChunk;
	}

	public void SetNull()
	{
		Index = 0;
	}

	public bool IsNull()
	{
		return Index == 0;
	}
}
