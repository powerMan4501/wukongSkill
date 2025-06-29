using System;
using System.Collections.Generic;

namespace b1.ECS;

public class EntityManager
{
	public delegate void IterateCompFunc(IEntityComponent Comp);

	public unsafe delegate void IterateRawDataFunc<T>(T* Data) where T : unmanaged;

	private List<EntityArchetype> ArchList = new List<EntityArchetype>();

	private static int s_ManagerIdxAlloc;

	private bool Threading;

	public int ManagerIdx { get; private set; }

	public EntityManager()
	{
		ManagerIdx = s_ManagerIdxAlloc;
		s_ManagerIdxAlloc = (s_ManagerIdxAlloc + 1) % 16;
	}

	public EntityArchetype GetOrCreateArchetype(int ArchIdx)
	{
		ThreadCheck();
		EntityArchetype entityArchetype = null;
		if (ArchList.Count > ArchIdx)
		{
			entityArchetype = ArchList[ArchIdx];
		}
		else
		{
			if (ArchList.Count != ArchIdx)
			{
				throw new Exception("need to create archetype in index order");
			}
			entityArchetype = new EntityArchetype(ArchIdx);
			entityArchetype.ArchIndex = ArchList.Count;
			ArchList.Add(entityArchetype);
		}
		return entityArchetype;
	}

	public Entity CreateEntity(int ArchIndex)
	{
		return CreateEntity(ArchList[ArchIndex]);
	}

	private Entity CreateEntity(EntityArchetype Archtype)
	{
		ThreadCheck();
		Entity result = default(Entity);
		int num = -1;
		int chunkIndex = -1;
		int num2 = -1;
		List<Chunk> chunks = Archtype.Chunks;
		Chunk chunk = null;
		for (int i = 0; i < chunks.Count; i++)
		{
			Chunk chunk2 = chunks[i];
			if (chunk2.Count >= chunk2.Capacity)
			{
				continue;
			}
			chunkIndex = i;
			for (int j = 0; j < chunk2.Capacity; j++)
			{
				if (!chunk2.IsUsed[j])
				{
					num = j;
					chunk = chunk2;
					break;
				}
			}
			if (num >= 0)
			{
				break;
			}
		}
		if (chunk != null && num >= 0)
		{
			num2 = chunk.AllocateEntityWithIndex(num);
			result.SetChunkIndices(ManagerIdx, Archtype.ArchIndex, chunkIndex, num, num2);
		}
		else
		{
			chunk = new Chunk(Archtype);
			Archtype.Chunks.Add(chunk);
			num2 = chunk.AllocateEntityWithIndex(0);
			result.SetChunkIndices(ManagerIdx, Archtype.ArchIndex, Archtype.Chunks.Count - 1, 0, num2);
		}
		return result;
	}

	public void DestroyEntityUnPersistentPart(Entity entity)
	{
		entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) != null)
		{
			Chunk chunk = ArchList[OutArchIndex].Chunks[OutChunkIndex];
			if (chunk.IsUsed[OutIndexInChunk])
			{
				chunk.DeallocateEntityUnPersistentPartWithIndex(OutIndexInChunk);
			}
		}
	}

	public void DestroyEntity(Entity entity)
	{
		entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) != null)
		{
			Chunk chunk = ArchList[OutArchIndex].Chunks[OutChunkIndex];
			if (chunk.IsUsed[OutIndexInChunk])
			{
				chunk.DeallocateEntityWithIndex(OutIndexInChunk);
			}
		}
	}

	public void Dispose()
	{
		foreach (EntityArchetype arch in ArchList)
		{
			arch.Dispose();
		}
		ArchList.Clear();
	}

	public bool Exists(Entity entity)
	{
		entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		return GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) != null;
	}

	public Chunk GetChunk(Entity Ent)
	{
		Ent.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		return GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion);
	}

	public Chunk GetChunk(int ArchIndex, int ChunkIndex, int IndexInChunk, int Version)
	{
		if (ArchIndex < ArchList.Count && ChunkIndex < ArchList[ArchIndex].Chunks.Count)
		{
			Chunk chunk = ArchList[ArchIndex].Chunks[ChunkIndex];
			if (IndexInChunk < chunk.Versions.Length && chunk.Versions[IndexInChunk] == Version)
			{
				return chunk;
			}
		}
		return null;
	}

	public bool HasData<T>(Entity entity) where T : unmanaged
	{
		entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) == null)
		{
			return false;
		}
		Type typeFromHandle = typeof(T);
		foreach (Type rawDataType in ArchList[OutArchIndex].RawDataTypes)
		{
			if (rawDataType == typeFromHandle)
			{
				return true;
			}
		}
		return false;
	}

	public unsafe T GetData<T>(Entity entity) where T : unmanaged
	{
		T* ptr = (T*)(void*)GetDataPtr<T>(entity);
		if (ptr != null)
		{
			return *ptr;
		}
		return default(T);
	}

	public object GetDataSafe(Entity InEntity, int TypeIndex)
	{
		InEntity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		return GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion)?.GetDataSafe(TypeIndex, OutIndexInChunk);
	}

	private object GetDefaultObject(int TypeIndex)
	{
		return Activator.CreateInstance(TypeManager.GetTypeByIndex(TypeIndex));
	}

	public T GetDataSafe<T>(Entity InEntity, int TypeIndex) where T : new()
	{
		return (T)GetDataSafe(InEntity, TypeIndex);
	}

	public T GetDataSafe<T>(Entity InEntity) where T : IEntitySafeData, new()
	{
		return (T)GetDataSafe(InEntity, TypeManager.GetTypeIndex<T>());
	}

	public unsafe IntPtr GetDataPtr<T>(Entity entity) where T : unmanaged
	{
		entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) == null)
		{
			return IntPtr.Zero;
		}
		T* ptr = (T*)(void*)ArchList[OutArchIndex].Chunks[OutChunkIndex].MemoryByTypes[TypeManager.GetTypeIndex<T>()];
		ptr += OutIndexInChunk;
		return (IntPtr)ptr;
	}

	public unsafe void SetData<T>(Entity Entity, T Data) where T : unmanaged
	{
		T* ptr = (T*)(void*)GetDataPtr<T>(Entity);
		if (ptr != null)
		{
			*ptr = Data;
		}
	}

	public void SetObject(Entity Entity, int TypeIndex, object Data)
	{
		Entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) != null)
		{
			ThreadCheck();
			EntityArchetype entityArchetype = ArchList[OutArchIndex];
			if (!entityArchetype.HasObjectType(TypeIndex))
			{
				entityArchetype.AddObjectType(TypeIndex);
			}
			if (Data is IEntityComponent value)
			{
				entityArchetype.Chunks[OutChunkIndex].ComponentByTypes[TypeIndex].List[OutIndexInChunk] = value;
			}
			entityArchetype.Chunks[OutChunkIndex].ObjByTypes[TypeIndex][OutIndexInChunk] = Data;
		}
	}

	public void SetObject<T>(Entity Entity, T Data) where T : class
	{
		SetObject(Entity, TypeManager.GetTypeIndex<T>(), Data);
	}

	public void RemoveAllComp(Entity Entity)
	{
		Entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) != null)
		{
			Chunk chunk = ArchList[OutArchIndex].Chunks[OutChunkIndex];
			int CurIdx = 0;
			int oKey;
			Chunk.CompList oVal;
			while (chunk.ComponentByTypes.NextItr(ref CurIdx, out oKey, out oVal))
			{
				Chunk.CompList compList = oVal;
				chunk.ObjByTypes[oKey][OutIndexInChunk] = null;
				compList.List[OutIndexInChunk] = null;
			}
		}
	}

	public void RemoveObject<T>(Entity Entity, T Data) where T : class
	{
		Entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) != null)
		{
			EntityArchetype entityArchetype = ArchList[OutArchIndex];
			if (!entityArchetype.HasObjectType<T>())
			{
				entityArchetype.AddObjectType<T>();
			}
			if (Data is IEntityComponent)
			{
				entityArchetype.Chunks[OutChunkIndex].ComponentByTypes[TypeManager.GetTypeIndex<T>()].List[OutIndexInChunk] = null;
			}
			entityArchetype.Chunks[OutChunkIndex].ObjByTypes[TypeManager.GetTypeIndex<T>()][OutIndexInChunk] = null;
		}
	}

	public T GetObject<T>(Entity Entity) where T : class
	{
		return (T)GetObject(Entity, TypeManager.GetTypeIndex<T>());
	}

	public object GetObject(Entity InEntity, int TypeIndex)
	{
		InEntity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		return GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion)?.GetObject(TypeIndex, OutIndexInChunk);
	}

	public void AddMask(Entity Entity, int Mask)
	{
		Entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) != null)
		{
			ArchList[OutArchIndex].Chunks[OutChunkIndex].Masks[OutIndexInChunk] |= Mask;
		}
	}

	public void RemoveMask(Entity Entity, int Mask)
	{
		Entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) != null)
		{
			ArchList[OutArchIndex].Chunks[OutChunkIndex].Masks[OutIndexInChunk] &= ~Mask;
		}
	}

	public int GetMask(Entity Entity)
	{
		Entity.GetChunkIndices(out var _, out var OutArchIndex, out var OutChunkIndex, out var OutIndexInChunk, out var OutVersion);
		if (GetChunk(OutArchIndex, OutChunkIndex, OutIndexInChunk, OutVersion) == null)
		{
			return 0;
		}
		return ArchList[OutArchIndex].Chunks[OutChunkIndex].Masks[OutIndexInChunk];
	}

	public void ForEachComponents(IterateCompFunc Func)
	{
		foreach (EntityArchetype arch in ArchList)
		{
			arch.ForEachComponents(Func);
		}
	}

	public void ForEachComponentsWithMask(int Mask, IterateCompFunc Func)
	{
		foreach (EntityArchetype arch in ArchList)
		{
			arch.ForEachComponentsWithMask(Mask, Func);
		}
	}

	public unsafe void ForEachData<T>(IterateRawDataFunc<T> Func) where T : unmanaged
	{
		int rawFromSafe = TypeManager.GetRawFromSafe<T>();
		foreach (EntityArchetype arch in ArchList)
		{
			if (!arch.HasRawDataType(rawFromSafe))
			{
				continue;
			}
			for (int i = 0; i < arch.Chunks.Count; i++)
			{
				Chunk chunk = arch.Chunks[i];
				T* ptr = (T*)(void*)chunk.MemoryByTypes[rawFromSafe];
				for (int j = 0; j < chunk.Count; j++)
				{
					if (chunk.IsUsed[j])
					{
						T* data = ptr + j;
						Func(data);
					}
				}
			}
		}
	}

	public void BeginThreadCheck()
	{
		if (Threading)
		{
			throw new Exception("overlap thread check is not supported");
		}
		Threading = true;
	}

	public void EndThreadCheck()
	{
		Threading = false;
	}

	private void ThreadCheck()
	{
		if (Threading)
		{
			throw new Exception("Add object during thread tick is not supported");
		}
	}

	public void TickAllComponentsWithGroup(float DeltaTime, int TickGroup)
	{
		TickAllComponentsWithGroup(DeltaTime, TickGroup, 0, 1);
	}

	public void TickAllComponentsWithGroup(float DeltaTime, int TickGroup, int ThreadIdx, int ThreadCount)
	{
		foreach (EntityArchetype arch in ArchList)
		{
			arch.TickAllComponentWithGroup(DeltaTime, TickGroup, ThreadIdx, ThreadCount);
		}
	}

	public void CreateSnapshot()
	{
	}
}
