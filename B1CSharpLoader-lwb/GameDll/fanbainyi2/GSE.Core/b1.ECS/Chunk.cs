using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.ECS;

public class Chunk : IDisposable
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct CompTickStatId
	{
	}

	public class CompList
	{
		public int TickGroup = -1;

		public List<IEntityComponent> List;

		public CompTickStatId StatId;
	}

	public Dictionary<int, IntPtr> MemoryByTypes = new Dictionary<int, IntPtr>();

	public Dictionary<int, List<IEntitySafeData>> SafeDataByTypes = new Dictionary<int, List<IEntitySafeData>>();

	public UnorderedDict<int, CompList> ComponentByTypes = new UnorderedDict<int, CompList>();

	public Dictionary<int, object[]> ObjByTypes = new Dictionary<int, object[]>();

	public bool[] IsUsed;

	public int[] Masks;

	public int[] Versions;

	public int Count;

	public int Capacity;

	private EntityArchetype ParentArch;

	public Chunk(EntityArchetype Arch)
	{
		AllocateChunk(Arch);
	}

	public object GetObjectOrDataSafe(int TypeIndex, int IndexInChunk)
	{
		object obj = GetObject(TypeIndex, IndexInChunk);
		if (obj == null)
		{
			obj = GetDataSafe(TypeIndex, IndexInChunk);
		}
		return obj;
	}

	public object GetObject(int TypeIndex, int IndexInChunk)
	{
		if (!ObjByTypes.TryGetValue(TypeIndex, out var value))
		{
			return null;
		}
		return value[IndexInChunk];
	}

	public object GetDataSafe(int TypeIndex, int IndexInChunk)
	{
		if (!SafeDataByTypes.TryGetValue(TypeIndex, out var value))
		{
			return null;
		}
		object obj = value[IndexInChunk];
		if (obj == null)
		{
			obj = GetDefaultObject(TypeIndex);
			if (obj is IEntitySafeData entitySafeData)
			{
				int rawFromSafe = TypeManager.GetRawFromSafe(TypeIndex);
				IntPtr ptr = MemoryByTypes[rawFromSafe];
				ptr += TypeManager.GetTypeSize(rawFromSafe) * IndexInChunk;
				entitySafeData.SetPtr(ptr);
				value[IndexInChunk] = entitySafeData;
			}
			else
			{
				obj = null;
			}
		}
		return obj;
	}

	private object GetDefaultObject(int TypeIndex)
	{
		return Activator.CreateInstance(TypeManager.GetTypeByIndex(TypeIndex));
	}

	public int AllocateEntityWithIndex(int IndexInChunk)
	{
		IsUsed[IndexInChunk] = true;
		int num = (Versions[IndexInChunk] + 1) % 16;
		foreach (KeyValuePair<int, IntPtr> memoryByType in MemoryByTypes)
		{
			IntPtr value = memoryByType.Value;
			int num2 = ParentArch.RawDataSizeOfs[memoryByType.Key];
			FMemory.Memset(value + num2 * IndexInChunk, 0, num2);
		}
		Versions[IndexInChunk] = num;
		Count++;
		return num;
	}

	public void DeallocateEntityUnPersistentPartWithIndex(int IndexInChunk)
	{
		ComponentByTypes.BeginItr();
		int oKey;
		CompList oVal;
		while (ComponentByTypes.NextItr(out oKey, out oVal))
		{
			oVal.List[IndexInChunk] = null;
		}
		foreach (KeyValuePair<int, object[]> objByType in ObjByTypes)
		{
			if (objByType.Value[IndexInChunk] is UObject || !(objByType.Value[IndexInChunk] is IPersistentECSData))
			{
				GS_GCHelper.Instance.AddObjectToClearTStrongPtr(objByType.Value[IndexInChunk]);
				objByType.Value[IndexInChunk] = null;
			}
			else
			{
				(objByType.Value[IndexInChunk] as IPersistentECSDataWithDestroyCB)?.OnUnPersistentDestroy();
			}
		}
	}

	public void DeallocateEntityWithIndex(int IndexInChunk)
	{
		IsUsed[IndexInChunk] = false;
		Versions[IndexInChunk]++;
		Count--;
		ComponentByTypes.BeginItr();
		int oKey;
		CompList oVal;
		while (ComponentByTypes.NextItr(out oKey, out oVal))
		{
			oVal.List[IndexInChunk] = null;
		}
		foreach (KeyValuePair<int, object[]> objByType in ObjByTypes)
		{
			GS_GCHelper.Instance.AddObjectToClearTStrongPtr(objByType.Value[IndexInChunk]);
			objByType.Value[IndexInChunk] = null;
		}
	}

	private void AllocateChunk(EntityArchetype Arch)
	{
		ParentArch = Arch;
		for (int i = 0; i < Arch.RawDataTypes.Count; i++)
		{
			int typeIndex = TypeManager.GetTypeIndex(Arch.RawDataTypes[i]);
			int num = Marshal.SizeOf(Arch.RawDataTypes[i]);
			int count = num * 64;
			IntPtr intPtr = Marshal.AllocHGlobal(num * 64);
			MemoryByTypes[typeIndex] = intPtr;
			FMemory.Memset(intPtr, 0, count);
		}
		for (int j = 0; j < Arch.SafeDataTypes.Count; j++)
		{
			int typeIndex2 = TypeManager.GetTypeIndex(Arch.SafeDataTypes[j]);
			List<IEntitySafeData> list = new List<IEntitySafeData>(64);
			SafeDataByTypes[typeIndex2] = list;
			for (int k = 0; k < 64; k++)
			{
				list.Add(null);
			}
		}
		for (int l = 0; l < Arch.ComponentTypes.Count; l++)
		{
			AddObjType(Arch.ComponentTypes[l], IsComponentType: true);
		}
		for (int m = 0; m < Arch.ObjTypes.Count; m++)
		{
			AddObjType(Arch.ObjTypes[m], IsComponentType: false);
		}
		IsUsed = new bool[64];
		Masks = new int[64];
		Versions = new int[64];
		Count = 0;
		Capacity = 64;
	}

	public void AddObjType(int TypeIndex, Type ObjType, bool IsComponentType)
	{
		List<IEntityComponent> list = null;
		if (IsComponentType)
		{
			CompList compList = new CompList();
			list = (compList.List = new List<IEntityComponent>(64));
			ComponentByTypes.Set(TypeIndex, compList);
			compList.TickGroup = ((IEntityComponent)Activator.CreateInstance(ObjType)).GetTickGroupMask();
		}
		object[] value = new object[64];
		ObjByTypes[TypeIndex] = value;
		for (int i = 0; i < 64; i++)
		{
			if (IsComponentType)
			{
				list.Add(null);
			}
		}
	}

	public void AddObjType(Type ObjType, bool IsComponentType)
	{
		int typeIndex = TypeManager.GetTypeIndex(ObjType);
		AddObjType(typeIndex, ObjType, IsComponentType);
	}

	private void DeallocateChunk()
	{
		foreach (KeyValuePair<int, IntPtr> memoryByType in MemoryByTypes)
		{
			Marshal.FreeHGlobal(memoryByType.Value);
		}
		MemoryByTypes.Clear();
		ComponentByTypes.Clear();
		ObjByTypes.Clear();
		SafeDataByTypes.Clear();
	}

	public void Dispose()
	{
		DeallocateChunk();
	}

	~Chunk()
	{
		DeallocateChunk();
	}
}
