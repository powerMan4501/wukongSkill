using System;
using System.Collections.Generic;

namespace Game_Helper;

public class BU_TypeManager
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

	private static Dictionary<int, Type> DictType = new Dictionary<int, Type>();

	public static int GetTypeIndex<T>()
	{
		return StaticLookUp<T>.GetIndex();
	}

	public static int GetTypeIndex(Type T)
	{
		return DictIndex[T];
	}

	public static Type GetTypeByIndex(int Index)
	{
		return DictType[Index];
	}
}
