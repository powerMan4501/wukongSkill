using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace b1.ECS;

public static class TypeManager
{
	private static class StaticLookUp<T>
	{
		private static int Index;

		public static int GetIndex()
		{
			if (Index == 0)
			{
				Index = s_Counter++;
				Type typeFromHandle = typeof(T);
				DictIndex.Add(typeFromHandle, Index);
				DictType[Index] = typeFromHandle;
			}
			return Index;
		}
	}

	private static int s_Counter = 1;

	private static Dictionary<Type, int> DictIndex = new Dictionary<Type, int>();

	private static Dictionary<int, int> DictSafeToRaw = new Dictionary<int, int>();

	private static Dictionary<int, int> DictIndexToSize = new Dictionary<int, int>();

	private static Dictionary<int, Type> DictType = new Dictionary<int, Type>();

	public static int GetTypeIndex<T>()
	{
		return StaticLookUp<T>.GetIndex();
	}

	public static Type GetTypeByIndex(int Index)
	{
		return DictType[Index];
	}

	public static void SetSafeRawPair<SafeType, RawType>()
	{
		int typeIndex = GetTypeIndex<RawType>();
		DictSafeToRaw[GetTypeIndex<SafeType>()] = typeIndex;
		DictIndexToSize[typeIndex] = Marshal.SizeOf(typeof(RawType));
	}

	public static int GetRawFromSafe<SafeType>()
	{
		return DictSafeToRaw[GetTypeIndex<SafeType>()];
	}

	public static int GetRawFromSafe(int TypeIndex)
	{
		return DictSafeToRaw[TypeIndex];
	}

	public static int GetTypeIndex(Type T)
	{
		return DictIndex[T];
	}

	public static int GetTypeSize<T>()
	{
		return DictIndexToSize[GetTypeIndex<T>()];
	}

	public static int GetTypeSize(int Index)
	{
		return DictIndexToSize[Index];
	}
}
