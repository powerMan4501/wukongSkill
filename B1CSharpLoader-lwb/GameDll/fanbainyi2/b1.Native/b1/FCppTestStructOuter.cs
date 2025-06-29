using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.CppTestStructOuter", "b1", UnrealModuleType.Game)]
public struct FCppTestStructOuter
{
	private static bool TestInt_IsValid;

	private static int TestInt_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.CppTestStructOuter:TestInt")]
	public int TestInt;

	private static bool ItemStructs_IsValid;

	private static FFieldAddress ItemStructs_PropertyAddress;

	private static int ItemStructs_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.CppTestStructOuter:ItemStructs")]
	public List<FCppTestStructInner> ItemStructs;

	private static bool FCppTestStructOuter_IsValid;

	private static int FCppTestStructOuter_StructSize;

	public FCppTestStructOuter Copy()
	{
		FCppTestStructOuter result = this;
		if (ItemStructs != null)
		{
			result.ItemStructs = new List<FCppTestStructInner>(ItemStructs);
		}
		return result;
	}

	public static FCppTestStructOuter FromNative(IntPtr nativeBuffer)
	{
		return new FCppTestStructOuter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCppTestStructOuter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCppTestStructOuter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCppTestStructOuter(nativeBuffer + arrayIndex * FCppTestStructOuter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCppTestStructOuter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCppTestStructOuter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCppTestStructOuter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.CppTestStructOuter");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TestInt_Offset), TestInt);
		new TArrayCopyMarshaler<FCppTestStructInner>(1, ItemStructs_PropertyAddress, CachedMarshalingDelegates<FCppTestStructInner, FCppTestStructInner>.FromNative, CachedMarshalingDelegates<FCppTestStructInner, FCppTestStructInner>.ToNative).ToNative(IntPtr.Add(nativeStruct, ItemStructs_Offset), ItemStructs);
	}

	public FCppTestStructOuter(IntPtr nativeStruct)
	{
		if (!FCppTestStructOuter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.CppTestStructOuter");
			TestInt = 0;
			ItemStructs = null;
		}
		else
		{
			TestInt = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TestInt_Offset));
			ItemStructs = new TArrayCopyMarshaler<FCppTestStructInner>(1, ItemStructs_PropertyAddress, CachedMarshalingDelegates<FCppTestStructInner, FCppTestStructInner>.FromNative, CachedMarshalingDelegates<FCppTestStructInner, FCppTestStructInner>.ToNative).FromNative(IntPtr.Add(nativeStruct, ItemStructs_Offset));
		}
	}

	static FCppTestStructOuter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCppTestStructOuter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCppTestStructOuter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.CppTestStructOuter");
		FCppTestStructOuter_StructSize = NativeReflection.GetStructSize(intPtr);
		TestInt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TestInt");
		TestInt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TestInt", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ItemStructs_PropertyAddress, intPtr, "ItemStructs");
		ItemStructs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemStructs");
		ItemStructs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemStructs", Classes.FArrayProperty);
		FCppTestStructOuter_IsValid = intPtr != IntPtr.Zero && TestInt_IsValid && ItemStructs_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.CppTestStructOuter", FCppTestStructOuter_IsValid);
	}
}
