using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FScriptMapHelper
{
	private IntPtr mapProperty;

	private unsafe FScriptMap* map;

	private FScriptMapLayout mapLayout;

	private IntPtr keyProp;

	private int keySize;

	private int keyArrayDim;

	private IntPtr valueProp;

	private int valueSize;

	private int valueArrayDim;

	public unsafe int Count => map->Num();

	public IntPtr PropertyAddress => mapProperty;

	public IntPtr KeyPropertyAddress => keyProp;

	public IntPtr ValuePropertyAddress => valueProp;

	public unsafe IntPtr Map
	{
		get
		{
			return (IntPtr)map;
		}
		set
		{
			map = (FScriptMap*)(void*)value;
		}
	}

	public unsafe FScriptMapHelper(IntPtr mapProperty, IntPtr map)
	{
		this.mapProperty = mapProperty;
		this.map = (FScriptMap*)(void*)map;
		mapLayout = Native_FMapProperty.Get_MapLayout(mapProperty);
		keyProp = Native_FMapProperty.Get_KeyProp(mapProperty);
		keySize = Native_FProperty.Get_ElementSize(keyProp);
		keyArrayDim = Native_FProperty.Get_ArrayDim(keyProp);
		valueProp = Native_FMapProperty.Get_ValueProp(mapProperty);
		valueSize = Native_FProperty.Get_ElementSize(valueProp);
		valueArrayDim = Native_FProperty.Get_ArrayDim(valueProp);
	}

	public FScriptMapHelper(FMapProperty property, IntPtr map)
		: this(property.Address, map)
	{
	}

	public FScriptMapHelper(IntPtr mapProperty)
		: this(mapProperty, IntPtr.Zero)
	{
	}

	public FScriptMapHelper(FMapProperty property)
		: this(property.Address, IntPtr.Zero)
	{
	}

	public void Update(FFieldAddress property)
	{
		if (mapProperty != property.Address)
		{
			mapProperty = property.Address;
			keyProp = property.GenericArg1Address;
			keySize = property.GenericArg1Size;
			keyArrayDim = property.GenericArg1ArrayDim;
			valueProp = property.GenericArg2Address;
			valueSize = property.GenericArg2Size;
			valueArrayDim = property.GenericArg2ArrayDim;
		}
	}

	public unsafe bool IsValidIndex(int index)
	{
		return map->IsValidIndex(index);
	}

	public unsafe int Num()
	{
		return map->Num();
	}

	public unsafe int GetMaxIndex()
	{
		return map->GetMaxIndex();
	}

	public unsafe static int Num(IntPtr target)
	{
		return ((FScriptMap*)(void*)target)->Num();
	}

	public unsafe IntPtr GetPairPtr(int index)
	{
		if (Num() == 0)
		{
			return IntPtr.Zero;
		}
		return map->GetData(index, ref mapLayout);
	}

	public unsafe bool GetPairPtr(int index, out IntPtr keyPtr, out IntPtr valuePtr)
	{
		if (Num() == 0)
		{
			keyPtr = IntPtr.Zero;
			valuePtr = IntPtr.Zero;
			return false;
		}
		valuePtr = (keyPtr = map->GetData(index, ref mapLayout)) + mapLayout.ValueOffset;
		return true;
	}

	public unsafe IntPtr GetKeyPtr(int index)
	{
		if (Num() == 0)
		{
			return IntPtr.Zero;
		}
		return map->GetData(index, ref mapLayout);
	}

	public unsafe IntPtr GetValuePtr(int index)
	{
		if (Num() == 0)
		{
			return IntPtr.Zero;
		}
		return map->GetData(index, ref mapLayout) + mapLayout.ValueOffset;
	}

	public unsafe int AddUninitializedValue()
	{
		return map->AddUninitialized(ref mapLayout);
	}

	public unsafe void EmptyValues(int slack = 0)
	{
		int num = Num();
		if (num != 0)
		{
			DestructItems(0, num);
		}
		if (num != 0 || slack != 0)
		{
			map->Empty(slack, ref mapLayout);
		}
	}

	public int AddDefaultValue_Invalid_NeedsRehash()
	{
		int num = AddUninitializedValue();
		ConstructItem(num);
		return num;
	}

	public IntPtr GetKeyPropertyPtr()
	{
		return keyProp;
	}

	public FProperty GetKeyProperty()
	{
		return new FProperty(keyProp);
	}

	public IntPtr GetValuePropertyPtr()
	{
		return valueProp;
	}

	public FProperty GetValueProperty()
	{
		return new FProperty(valueProp);
	}

	public unsafe void RemoveAt(int index, int count = 1)
	{
		DestructItems(index, count);
		while (count != 0)
		{
			if (IsValidIndex(index))
			{
				map->RemoveAt(index, ref mapLayout);
				count--;
			}
			index++;
		}
	}

	public unsafe void Rehash()
	{
		IntPtr tempKeyProp = keyProp;
		HashDelegates.GetKeyHash getKeyHash = (IntPtr src) => Native_FProperty.GetValueTypeHash(tempKeyProp, src);
		map->Rehash(ref mapLayout, getKeyHash);
	}

	public int FindMapIndexWithKey(IntPtr pairWithKeyToFind, int indexHint = 0)
	{
		int maxIndex = GetMaxIndex();
		if (maxIndex == 0)
		{
			return -1;
		}
		IntPtr instance = keyProp;
		int num = indexHint;
		do
		{
			if (IsValidIndex(num))
			{
				IntPtr pairPtrWithoutCheck = GetPairPtrWithoutCheck(num);
				if ((bool)Native_FProperty.Identical(instance, pairWithKeyToFind, pairPtrWithoutCheck, 0u))
				{
					return num;
				}
			}
			num++;
			if (num == maxIndex)
			{
				num = 0;
			}
		}
		while (num != indexHint);
		return -1;
	}

	public IntPtr FindMapPairPtrWithKey(IntPtr pairWithKeyToFind, int indexHint = 0)
	{
		int num = FindMapIndexWithKey(pairWithKeyToFind, indexHint);
		if (num < 0)
		{
			return IntPtr.Zero;
		}
		return GetPairPtr(num);
	}

	public unsafe IntPtr FindValueFromHash(IntPtr keyPtr)
	{
		return map->FindValueEx(keyPtr, ref mapLayout, keyProp);
	}

	public unsafe int FindPairIndexFromHash(IntPtr keyToFind)
	{
		return map->FindPairIndexEx(keyToFind, ref mapLayout, keyProp);
	}

	public unsafe int FindPairIndex<TKey>(TKey key, MarshalingDelegates<TKey>.ToNative keyToNative, UObject owner)
	{
		IntPtr intPtr = (IntPtr)stackalloc byte[(int)(uint)(keySize * keyArrayDim)];
		Native_FProperty.InitializeValue(keyProp, intPtr);
		keyToNative(intPtr, 0, keyProp, key);
		int result = FindPairIndexFromHash(intPtr);
		Native_FProperty.DestroyValue(keyProp, intPtr);
		return result;
	}

	public unsafe void AddPair<TKey, TValue>(TKey key, TValue value, MarshalingDelegates<TKey>.ToNative keyToNative, MarshalingDelegates<TValue>.ToNative valueToNative)
	{
		IntPtr intPtr = (IntPtr)stackalloc byte[(int)(uint)(keySize * keyArrayDim)];
		Native_FProperty.InitializeValue(keyProp, intPtr);
		keyToNative(intPtr, 0, keyProp, key);
		IntPtr intPtr2 = (IntPtr)stackalloc byte[(int)(uint)(valueSize * valueArrayDim)];
		Native_FProperty.InitializeValue(valueProp, intPtr2);
		valueToNative(intPtr2, 0, valueProp, value);
		AddPair(intPtr, intPtr2);
		Native_FProperty.DestroyValue(keyProp, intPtr);
		Native_FProperty.DestroyValue(valueProp, intPtr2);
	}

	public unsafe void AddPair(IntPtr keyPtr, IntPtr valuePtr)
	{
		map->AddEx(keyPtr, valuePtr, ref mapLayout, keyProp, valueProp);
	}

	public unsafe bool RemovePair(IntPtr keyPtr)
	{
		IntPtr intPtr = map->FindValueEx(keyPtr, ref mapLayout, keyProp);
		if (intPtr != IntPtr.Zero)
		{
			int index = (int)((intPtr.ToInt64() - map->GetData(0, ref mapLayout).ToInt64()) / mapLayout.SetLayout.Size);
			RemoveAt(index);
			return true;
		}
		return false;
	}

	public bool HasKey(IntPtr inBaseAddress, string inKeyValue)
	{
		int num = 0;
		int num2 = Num();
		while (num2 > 0)
		{
			if (IsValidIndex(num))
			{
				num2--;
				IntPtr pairPtr = GetPairPtr(num);
				IntPtr intPtr = Native_FProperty.ContainerVoidPtrToValuePtr(keyProp, pairPtr, 0);
				using FStringUnsafe fStringUnsafe = new FStringUnsafe();
				if (intPtr != inBaseAddress && (bool)Native_FProperty.ExportText_Direct(keyProp, ref fStringUnsafe.Array, intPtr, intPtr, IntPtr.Zero, 0, IntPtr.Zero) && (((bool)Native_FField.IsA(keyProp, Classes.FObjectProperty) && fStringUnsafe.Value.Contains(inKeyValue)) || inKeyValue == fStringUnsafe.Value))
				{
					return true;
				}
			}
			num++;
		}
		return false;
	}

	private void ConstructItem(int index)
	{
		bool num = Native_FProperty.HasAnyPropertyFlags(keyProp, EPropertyFlags.ZeroConstructor);
		bool flag = Native_FProperty.HasAnyPropertyFlags(valueProp, EPropertyFlags.ZeroConstructor);
		IntPtr pairPtrWithoutCheck = GetPairPtrWithoutCheck(index);
		if (num || flag)
		{
			FMemory.Memzero(pairPtrWithoutCheck, mapLayout.SetLayout.Size);
		}
		if (!num)
		{
			Native_FProperty.InitializeValue_InContainer(keyProp, pairPtrWithoutCheck);
		}
		if (!flag)
		{
			Native_FProperty.InitializeValue_InContainer(valueProp, pairPtrWithoutCheck);
		}
	}

	private void DestructItems(int index, int count)
	{
		if (count <= 0)
		{
			return;
		}
		bool flag = !Native_FProperty.HasAnyPropertyFlags(keyProp, EPropertyFlags.IsPlainOldData | EPropertyFlags.NoDestructor);
		bool flag2 = !Native_FProperty.HasAnyPropertyFlags(valueProp, EPropertyFlags.IsPlainOldData | EPropertyFlags.NoDestructor);
		if (!(flag || flag2))
		{
			return;
		}
		int size = mapLayout.SetLayout.Size;
		IntPtr pairPtr = GetPairPtr(index);
		if (flag)
		{
			if (flag2)
			{
				while (count != 0)
				{
					if (IsValidIndex(index))
					{
						Native_FProperty.DestroyValue_InContainer(keyProp, pairPtr);
						Native_FProperty.DestroyValue_InContainer(valueProp, pairPtr);
						count--;
					}
					pairPtr += size;
					index++;
				}
				return;
			}
			while (count != 0)
			{
				if (IsValidIndex(index))
				{
					Native_FProperty.DestroyValue_InContainer(keyProp, pairPtr);
					count--;
				}
				pairPtr += size;
				index++;
			}
			return;
		}
		while (count != 0)
		{
			if (IsValidIndex(index))
			{
				Native_FProperty.DestroyValue_InContainer(valueProp, pairPtr);
				count--;
			}
			pairPtr += size;
			index++;
		}
	}

	private unsafe IntPtr GetPairPtrWithoutCheck(int index)
	{
		return map->GetData(index, ref mapLayout);
	}

	public unsafe static FScriptMapHelper CreateHelperFormInnerProperty(IntPtr keyProperty, IntPtr valProperty, IntPtr map)
	{
		return new FScriptMapHelper
		{
			keyProp = keyProperty,
			valueProp = valProperty,
			map = (FScriptMap*)(void*)map,
			mapLayout = FScriptMap.GetScriptLayout(Native_FProperty.GetSize(keyProperty), Native_FProperty.GetMinAlignment(keyProperty), Native_FProperty.GetSize(valProperty), Native_FProperty.GetMinAlignment(valProperty))
		};
	}

	public static FScriptMapHelper CreateHelperFormInnerProperty(FProperty keyProperty, FProperty valProperty, IntPtr array)
	{
		return CreateHelperFormInnerProperty(keyProperty.Address, valProperty.Address, array);
	}
}
