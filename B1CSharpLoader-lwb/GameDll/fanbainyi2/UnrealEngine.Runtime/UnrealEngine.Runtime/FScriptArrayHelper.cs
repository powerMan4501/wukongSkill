using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FScriptArrayHelper
{
	private IntPtr innerProperty;

	private IntPtr arrayProperty;

	private unsafe FScriptArray* array;

	private int elementSize;

	public unsafe int Count => array->ArrayNum;

	public IntPtr PropertyAddress => arrayProperty;

	public IntPtr InnerPropertyAddress => innerProperty;

	public unsafe IntPtr Array
	{
		get
		{
			return (IntPtr)array;
		}
		set
		{
			array = (FScriptArray*)(void*)value;
		}
	}

	public unsafe FScriptArrayHelper(IntPtr arrayProperty, IntPtr array)
	{
		innerProperty = Native_FArrayProperty.Get_Inner(arrayProperty);
		this.arrayProperty = arrayProperty;
		this.array = (FScriptArray*)(void*)array;
		elementSize = Native_FProperty.Get_ElementSize(innerProperty);
	}

	public FScriptArrayHelper(FArrayProperty property, IntPtr array)
		: this(property.Address, array)
	{
	}

	public FScriptArrayHelper(IntPtr arrayProperty)
		: this(arrayProperty, IntPtr.Zero)
	{
	}

	public FScriptArrayHelper(FArrayProperty property)
		: this(property, IntPtr.Zero)
	{
	}

	public void Update(FFieldAddress property)
	{
		if (arrayProperty != property.Address)
		{
			arrayProperty = property.Address;
			innerProperty = property.GenericArg1Address;
			elementSize = property.GenericArg1Size;
		}
	}

	public bool IsValidIndex(int index)
	{
		if (index >= 0)
		{
			return index <= Num();
		}
		return false;
	}

	public int Num()
	{
		return Count;
	}

	public unsafe static int Num(IntPtr target)
	{
		return ((FScriptArray*)(void*)target)->ArrayNum;
	}

	public unsafe IntPtr GetRawPtr(int index = 0)
	{
		if (Count == 0)
		{
			return IntPtr.Zero;
		}
		return array->Data + index * elementSize;
	}

	public void EmptyAndAddValues(int count)
	{
		EmptyValues(count);
		if (count > 0)
		{
			AddValues(count);
		}
	}

	public void EmptyAndAddUninitializedValues(int count)
	{
		EmptyValues(count);
		if (count > 0)
		{
			AddUninitializedValues(count);
		}
	}

	public void EmptyAndAddZeroedValues(int count)
	{
		EmptyValues(count);
		if (count > 0)
		{
			AddZeroedValues(count);
		}
	}

	public bool ExpandForIndex(int index)
	{
		if (index >= Num())
		{
			AddValues(index - Num() + 1);
			return true;
		}
		return false;
	}

	public void Resize(int count)
	{
		int num = Num();
		if (count > num)
		{
			AddValues(count - num);
		}
		else if (count < num)
		{
			RemoveValues(count, num - count);
		}
	}

	public int AddValues(int count)
	{
		int num = AddUninitializedValues(count);
		ConstructItems(num, count);
		return num;
	}

	public int AddValue()
	{
		return AddValues(1);
	}

	public unsafe int AddUninitializedValues(int count)
	{
		return array->Add(elementSize, count);
	}

	public int AddUninitializedValue()
	{
		return AddUninitializedValues(1);
	}

	public unsafe int AddZeroedValues(int count)
	{
		int result = array->Add(elementSize, count);
		FMemory.Memzero(GetRawPtr(), count * elementSize);
		return result;
	}

	public unsafe void InsertValues(int index, int count = 1)
	{
		array->Insert(index, elementSize, count);
		ConstructItems(index, count);
	}

	public unsafe void EmptyValues(int slack = 0)
	{
		int num = Num();
		if (num > 0)
		{
			DestructItems(0, num);
		}
		if (num > 0 || slack > 0)
		{
			array->Empty(slack, elementSize);
		}
	}

	public unsafe void RemoveValues(int index, int count = 1)
	{
		DestructItems(index, count);
		array->RemoveAt(index, elementSize, count);
	}

	public void ClearValues(int index, int count = 1)
	{
		ClearItems(index, count);
	}

	public unsafe void SwapValues(int a, int b)
	{
		array->SwapMemory(a, b, elementSize);
	}

	private void ConstructItems(int index, int count)
	{
		IntPtr rawPtr = GetRawPtr(index);
		if ((bool)Native_FProperty.HasAnyPropertyFlags(innerProperty, EPropertyFlags.ZeroConstructor))
		{
			FMemory.Memzero(rawPtr, count * elementSize);
			return;
		}
		int num = 0;
		while (num < count)
		{
			Native_FProperty.InitializeValue(innerProperty, rawPtr);
			num++;
			rawPtr += elementSize;
		}
	}

	private void DestructItems(int index, int count)
	{
		if (!Native_FProperty.HasAnyPropertyFlags(innerProperty, EPropertyFlags.IsPlainOldData | EPropertyFlags.NoDestructor))
		{
			IntPtr rawPtr = GetRawPtr(index);
			int num = 0;
			while (num < count)
			{
				Native_FProperty.DestroyValue(innerProperty, rawPtr);
				num++;
				rawPtr += elementSize;
			}
		}
	}

	private void ClearItems(int index, int count)
	{
		IntPtr rawPtr = GetRawPtr(index);
		if ((bool)Native_FProperty.HasAnyPropertyFlags(innerProperty, EPropertyFlags.ZeroConstructor | EPropertyFlags.NoDestructor))
		{
			FMemory.Memzero(rawPtr, count * elementSize);
			return;
		}
		int num = 0;
		while (num < count)
		{
			Native_FProperty.ClearValue(innerProperty, rawPtr);
			num++;
			rawPtr += elementSize;
		}
	}

	public unsafe static FScriptArrayHelper CreateHelperFormInnerProperty(IntPtr innerProperty, IntPtr array)
	{
		return new FScriptArrayHelper
		{
			innerProperty = innerProperty,
			array = (FScriptArray*)(void*)array,
			elementSize = Native_FProperty.Get_ElementSize(innerProperty)
		};
	}

	public static FScriptArrayHelper CreateHelperFormInnerProperty(FProperty innerProperty, IntPtr array)
	{
		return CreateHelperFormInnerProperty(innerProperty.Address, array);
	}
}
