using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FScriptSetHelper
{
	private IntPtr setProperty;

	private unsafe FScriptSet* set;

	private FScriptSetLayout setLayout;

	private IntPtr elementProp;

	private int elementSize;

	private int elementArrayDim;

	public unsafe int Count => set->Num();

	public IntPtr PropertyAddress => setProperty;

	public IntPtr ElementPropertyAddress => elementProp;

	public unsafe IntPtr Set
	{
		get
		{
			return (IntPtr)set;
		}
		set
		{
			set = (FScriptSet*)(void*)value;
		}
	}

	public unsafe FScriptSetHelper(IntPtr setProperty, IntPtr set)
	{
		this.setProperty = setProperty;
		this.set = (FScriptSet*)(void*)set;
		setLayout = Native_FSetProperty.Get_SetLayout(setProperty);
		elementProp = Native_FSetProperty.Get_ElementProp(setProperty);
		elementSize = Native_FProperty.Get_ElementSize(elementProp);
		elementArrayDim = Native_FProperty.Get_ArrayDim(elementProp);
	}

	public FScriptSetHelper(FSetProperty property, IntPtr set)
		: this(property.Address, set)
	{
	}

	public FScriptSetHelper(IntPtr setProperty)
		: this(setProperty, IntPtr.Zero)
	{
	}

	public FScriptSetHelper(FSetProperty property)
		: this(property.Address, IntPtr.Zero)
	{
	}

	public void Update(FFieldAddress property)
	{
		if (setProperty != property.Address)
		{
			setProperty = property.Address;
			elementProp = property.GenericArg1Address;
			elementSize = property.GenericArg1Size;
			elementArrayDim = property.GenericArg1ArrayDim;
		}
	}

	public unsafe bool IsValidIndex(int index)
	{
		return set->IsValidIndex(index);
	}

	public unsafe int Num()
	{
		return set->Num();
	}

	public unsafe int GetMaxIndex()
	{
		return set->GetMaxIndex();
	}

	public unsafe static int Num(IntPtr target)
	{
		return ((FScriptSet*)(void*)target)->Num();
	}

	public unsafe IntPtr GetElementPtr(int index)
	{
		if (Num() == 0)
		{
			return IntPtr.Zero;
		}
		return set->GetData(index, ref setLayout);
	}

	public unsafe int AddUninitializedValue()
	{
		return set->AddUninitialized(ref setLayout);
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
			set->Empty(slack, ref setLayout);
		}
	}

	public int AddDefaultValue_Invalid_NeedsRehash()
	{
		int num = AddUninitializedValue();
		ConstructItem(num);
		return num;
	}

	public IntPtr GetElementPropertyPtr()
	{
		return elementProp;
	}

	public FProperty GetElementProperty()
	{
		return new FProperty(elementProp);
	}

	public unsafe void RemoveAt(int index, int count = 1)
	{
		DestructItems(index, count);
		while (count != 0)
		{
			if (IsValidIndex(index))
			{
				set->RemoveAt(index, ref setLayout);
				count--;
			}
			index++;
		}
	}

	public unsafe void Rehash()
	{
		IntPtr tempKeyProp = elementProp;
		HashDelegates.GetKeyHash getKeyHash = (IntPtr src) => Native_FProperty.GetValueTypeHash(tempKeyProp, src);
		set->Rehash(ref setLayout, getKeyHash);
	}

	public int FindElementIndex(IntPtr elementToFind, int indexHint = 0)
	{
		int maxIndex = GetMaxIndex();
		if (maxIndex == 0)
		{
			return -1;
		}
		IntPtr instance = elementProp;
		int num = indexHint;
		do
		{
			if (IsValidIndex(num))
			{
				IntPtr elementPtrWithoutCheck = GetElementPtrWithoutCheck(num);
				if ((bool)Native_FProperty.Identical(instance, elementToFind, elementPtrWithoutCheck, 0u))
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

	public IntPtr FindElementPtr(IntPtr elementToFind, int indexHint = 0)
	{
		int num = FindElementIndex(elementToFind, indexHint);
		if (num < 0)
		{
			return IntPtr.Zero;
		}
		return GetElementPtr(num);
	}

	public unsafe int FindElementIndexFromHash(IntPtr elementToFind)
	{
		IntPtr localElementPropForCapture = elementProp;
		HashDelegates.GetKeyHash getKeyHash = (IntPtr elementKey) => Native_FProperty.GetValueTypeHash(localElementPropForCapture, elementKey);
		HashDelegates.Equality equalityFn = (IntPtr a, IntPtr b) => Native_FProperty.Identical(localElementPropForCapture, a, b, 0u);
		return set->FindIndex(elementToFind, ref setLayout, getKeyHash, equalityFn);
	}

	public unsafe int IndexOf<T>(T item, MarshalingDelegates<T>.ToNative toNative, UObject owner)
	{
		IntPtr intPtr = (IntPtr)stackalloc byte[(int)(uint)(elementSize * elementArrayDim)];
		Native_FProperty.InitializeValue(elementProp, intPtr);
		toNative(intPtr, 0, elementProp, item);
		int result = FindElementIndexFromHash(intPtr);
		Native_FProperty.DestroyValue(elementProp, intPtr);
		return result;
	}

	public unsafe void AddElement<T>(T item, MarshalingDelegates<T>.ToNative toNative)
	{
		IntPtr intPtr = (IntPtr)stackalloc byte[(int)(uint)(elementSize * elementArrayDim)];
		Native_FProperty.InitializeValue(elementProp, intPtr);
		toNative(intPtr, 0, elementProp, item);
		AddElement(intPtr);
		Native_FProperty.DestroyValue(elementProp, intPtr);
	}

	public unsafe void AddElement(IntPtr elementToAdd)
	{
		IntPtr localElementPropForCapture = elementProp;
		HashDelegates.GetKeyHash getKeyHash = (IntPtr elementKey) => Native_FProperty.GetValueTypeHash(localElementPropForCapture, elementKey);
		HashDelegates.Equality equalityFn = (IntPtr a, IntPtr b) => Native_FProperty.Identical(localElementPropForCapture, a, b, 0u);
		HashDelegates.Construct constructFn = delegate(IntPtr newElement)
		{
			if ((bool)Native_FProperty.HasAnyPropertyFlags(localElementPropForCapture, EPropertyFlags.ZeroConstructor))
			{
				FMemory.Memzero(newElement, Native_FProperty.GetSize(localElementPropForCapture));
			}
			else
			{
				Native_FProperty.InitializeValue(localElementPropForCapture, newElement);
			}
			Native_FProperty.CopySingleValue(localElementPropForCapture, newElement, elementToAdd);
		};
		HashDelegates.Destruct destructFn = delegate(IntPtr element)
		{
			if (!Native_FProperty.HasAnyPropertyFlags(localElementPropForCapture, EPropertyFlags.IsPlainOldData | EPropertyFlags.NoDestructor))
			{
				Native_FProperty.DestroyValue(localElementPropForCapture, element);
			}
		};
		set->Add(elementToAdd, ref setLayout, getKeyHash, equalityFn, constructFn, destructFn);
	}

	public unsafe bool RemoveElement(IntPtr elementToRemove)
	{
		IntPtr localElementPropForCapture = elementProp;
		HashDelegates.GetKeyHash getKeyHash = (IntPtr elementKey) => Native_FProperty.GetValueTypeHash(localElementPropForCapture, elementKey);
		HashDelegates.Equality equalityFn = (IntPtr a, IntPtr b) => Native_FProperty.Identical(localElementPropForCapture, a, b, 0u);
		int num = set->FindIndex(elementToRemove, ref setLayout, getKeyHash, equalityFn);
		if (num != -1)
		{
			RemoveAt(num);
			return true;
		}
		return false;
	}

	public bool HasElement(IntPtr inBaseAddress, string inElementValue)
	{
		int num = 0;
		int num2 = Num();
		while (num2 > 0)
		{
			if (IsValidIndex(num))
			{
				num2--;
				IntPtr elementPtr = GetElementPtr(num);
				using FStringUnsafe fStringUnsafe = new FStringUnsafe();
				if (elementPtr != inBaseAddress && (bool)Native_FProperty.ExportText_Direct(elementProp, ref fStringUnsafe.Array, elementPtr, elementPtr, IntPtr.Zero, 0, IntPtr.Zero) && (((bool)Native_FField.IsA(elementProp, Classes.FObjectProperty) && fStringUnsafe.Value.Contains(inElementValue)) || inElementValue == fStringUnsafe.Value))
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
		bool num = Native_FProperty.HasAnyPropertyFlags(elementProp, EPropertyFlags.ZeroConstructor);
		IntPtr elementPtrWithoutCheck = GetElementPtrWithoutCheck(index);
		if (num)
		{
			FMemory.Memzero(elementPtrWithoutCheck, setLayout.Size);
		}
		if (!num)
		{
			Native_FProperty.InitializeValue_InContainer(elementProp, elementPtrWithoutCheck);
		}
	}

	private void DestructItems(int index, int count)
	{
		if (count <= 0 || (bool)Native_FProperty.HasAnyPropertyFlags(elementProp, EPropertyFlags.IsPlainOldData | EPropertyFlags.NoDestructor))
		{
			return;
		}
		int size = setLayout.Size;
		IntPtr elementPtrWithoutCheck = GetElementPtrWithoutCheck(index);
		while (count != 0)
		{
			if (IsValidIndex(index))
			{
				Native_FProperty.DestroyValue_InContainer(elementProp, elementPtrWithoutCheck);
				count--;
			}
			elementPtrWithoutCheck += size;
			index++;
		}
	}

	private unsafe IntPtr GetElementPtrWithoutCheck(int index)
	{
		return set->GetData(index, ref setLayout);
	}

	public unsafe static FScriptSetHelper CreateHelperFormInnerProperty(IntPtr elementProperty, IntPtr set)
	{
		return new FScriptSetHelper
		{
			elementProp = elementProperty,
			set = (FScriptSet*)(void*)set,
			setLayout = FScriptSet.GetScriptLayout(Native_FProperty.GetSize(elementProperty), Native_FProperty.GetMinAlignment(elementProperty))
		};
	}

	public static FScriptSetHelper CreateHelperFormInnerProperty(FProperty elementProperty, IntPtr set)
	{
		return CreateHelperFormInnerProperty(elementProperty.Address, set);
	}
}
