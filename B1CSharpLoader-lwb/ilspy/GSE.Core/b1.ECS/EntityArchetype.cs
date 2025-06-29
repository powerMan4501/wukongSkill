using System;
using System.Collections.Generic;

namespace b1.ECS;

public class EntityArchetype : IDisposable
{
	public const int ChunkItemCount = 64;

	public int ArchIndex;

	public List<Type> RawDataTypes = new List<Type>();

	public List<Type> SafeDataTypes = new List<Type>();

	public List<Type> ComponentTypes = new List<Type>();

	public List<Type> ObjTypes = new List<Type>();

	public Dictionary<int, int> RawDataSizeOfs = new Dictionary<int, int>();

	public List<Chunk> Chunks = new List<Chunk>();

	private bool Allocated;

	private static Type EntityComponentType = typeof(IEntityComponent);

	public EntityArchetype(int ArchIndex)
	{
	}

	public bool HasRawDataType(int TypeIndex)
	{
		return RawDataSizeOfs.ContainsKey(TypeIndex);
	}

	public void AddDataType<SafeDataT, RawDataT>(bool NeedSnapshot = false) where SafeDataT : IEntitySafeData where RawDataT : unmanaged
	{
		if (Allocated)
		{
			throw new Exception("Can't AddDataType after Preallocation");
		}
		RawDataTypes.Add(typeof(RawDataT));
		SafeDataTypes.Add(typeof(SafeDataT));
		TypeManager.SetSafeRawPair<SafeDataT, RawDataT>();
		RawDataSizeOfs[TypeManager.GetTypeIndex<RawDataT>()] = TypeManager.GetTypeSize<RawDataT>();
	}

	public void AddObjectType(int TypeIndex)
	{
		Type typeByIndex = TypeManager.GetTypeByIndex(TypeIndex);
		bool isComponentType = false;
		if (EntityComponentType.IsAssignableFrom(typeByIndex))
		{
			ComponentTypes.Add(typeByIndex);
			isComponentType = true;
		}
		ObjTypes.Add(typeByIndex);
		for (int i = 0; i < Chunks.Count; i++)
		{
			Chunks[i].AddObjType(TypeIndex, typeByIndex, isComponentType);
		}
	}

	public void AddObjectType<T>() where T : class
	{
		int typeIndex = TypeManager.GetTypeIndex<T>();
		AddObjectType(typeIndex);
	}

	public bool HasObjectType(int TypeIndex)
	{
		if (Chunks.Count > 0)
		{
			return Chunks[0].ObjByTypes.ContainsKey(TypeIndex);
		}
		return false;
	}

	public bool HasObjectType<T>() where T : class
	{
		return HasObjectType(TypeManager.GetTypeIndex<T>());
	}

	public void PreAllocate(int PreAllocateCount)
	{
		int num = (int)Math.Ceiling((float)PreAllocateCount / 64f);
		for (int i = 0; i < num; i++)
		{
			Chunks.Add(new Chunk(this));
		}
		Allocated = true;
	}

	public void ForEachComponents(EntityManager.IterateCompFunc Func)
	{
		for (int i = 0; i < Chunks.Count; i++)
		{
			Chunk chunk = Chunks[i];
			chunk.ComponentByTypes.BeginItr();
			int oKey;
			Chunk.CompList oVal;
			while (chunk.ComponentByTypes.NextItr(out oKey, out oVal))
			{
				Chunk.CompList compList = oVal;
				int count = compList.List.Count;
				for (int j = 0; j < count; j++)
				{
					if (chunk.IsUsed[j])
					{
						IEntityComponent entityComponent = compList.List[j];
						if (entityComponent != null)
						{
							Func(entityComponent);
						}
					}
				}
			}
		}
	}

	public void ForEachComponentsWithMask(int Mask, EntityManager.IterateCompFunc Func)
	{
		for (int i = 0; i < Chunks.Count; i++)
		{
			Chunk chunk = Chunks[i];
			chunk.ComponentByTypes.BeginItr();
			int oKey;
			Chunk.CompList oVal;
			while (chunk.ComponentByTypes.NextItr(out oKey, out oVal))
			{
				Chunk.CompList compList = oVal;
				int count = compList.List.Count;
				for (int j = 0; j < count; j++)
				{
					if (chunk.IsUsed[j] && (chunk.Masks[j] & Mask) != 0)
					{
						IEntityComponent entityComponent = compList.List[j];
						if (entityComponent != null)
						{
							Func(entityComponent);
						}
					}
				}
			}
		}
	}

	private void TickAllComponentImpl(float DeltaTime, int TickGroup, int ThreadIdx, int ThreadCount)
	{
		if (TickGroup == 0)
		{
			return;
		}
		for (int i = 0; i < Chunks.Count; i++)
		{
			Chunk chunk = Chunks[i];
			int CurIdx = 0;
			int oKey;
			Chunk.CompList oVal;
			while (chunk.ComponentByTypes.NextItr(ref CurIdx, out oKey, out oVal))
			{
				List<IEntityComponent> list = oVal.List;
				int count = list.Count;
				if (oVal.TickGroup <= 0 || (oVal.TickGroup & TickGroup) == 0)
				{
					continue;
				}
				for (int j = ThreadIdx; j < count; j += ThreadCount)
				{
					if (!chunk.IsUsed[j])
					{
						continue;
					}
					IEntityComponent entityComponent = list[j];
					if (entityComponent != null)
					{
						float accumulatedDeltaTime = entityComponent.GetAccumulatedDeltaTime();
						if (accumulatedDeltaTime >= 0f)
						{
							entityComponent.OnTickWithGroup((DeltaTime + accumulatedDeltaTime) * entityComponent.GetCustomTimeDilation(), TickGroup);
						}
					}
				}
			}
		}
	}

	public void TickAllComponentWithGroup(float DeltaTime, int TickGroup, int ThreadIdx, int ThreadCount)
	{
		TickAllComponentImpl(DeltaTime, TickGroup, ThreadIdx, ThreadCount);
	}

	public void Dispose()
	{
		for (int i = 0; i < Chunks.Count; i++)
		{
			Chunks[i].Dispose();
		}
		Chunks.Clear();
		RawDataTypes.Clear();
		SafeDataTypes.Clear();
		ComponentTypes.Clear();
		ObjTypes.Clear();
		RawDataSizeOfs.Clear();
	}
}
