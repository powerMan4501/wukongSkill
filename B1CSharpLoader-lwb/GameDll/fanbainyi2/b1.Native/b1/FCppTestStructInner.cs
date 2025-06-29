using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.CppTestStructInner", "b1", UnrealModuleType.Game)]
public struct FCppTestStructInner
{
	private static bool ItemInts_IsValid;

	private static FFieldAddress ItemInts_PropertyAddress;

	private static int ItemInts_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.CppTestStructInner:ItemInts")]
	public List<FName> ItemInts;

	private static bool InnerStruct_IsValid;

	private static FFieldAddress InnerStruct_PropertyAddress;

	private static int InnerStruct_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.CppTestStructInner:InnerStruct")]
	public List<FCppTestStructInnerInner> InnerStruct;

	private static bool FCppTestStructInner_IsValid;

	private static int FCppTestStructInner_StructSize;

	public FCppTestStructInner Copy()
	{
		FCppTestStructInner result = this;
		if (ItemInts != null)
		{
			result.ItemInts = new List<FName>(ItemInts);
		}
		if (InnerStruct != null)
		{
			result.InnerStruct = new List<FCppTestStructInnerInner>(InnerStruct);
		}
		return result;
	}

	public static FCppTestStructInner FromNative(IntPtr nativeBuffer)
	{
		return new FCppTestStructInner(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCppTestStructInner value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCppTestStructInner FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCppTestStructInner(nativeBuffer + arrayIndex * FCppTestStructInner_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCppTestStructInner value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCppTestStructInner_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCppTestStructInner_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.CppTestStructInner");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, ItemInts_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ItemInts_Offset), ItemInts);
		new TArrayCopyMarshaler<FCppTestStructInnerInner>(1, InnerStruct_PropertyAddress, CachedMarshalingDelegates<FCppTestStructInnerInner, FCppTestStructInnerInner>.FromNative, CachedMarshalingDelegates<FCppTestStructInnerInner, FCppTestStructInnerInner>.ToNative).ToNative(IntPtr.Add(nativeStruct, InnerStruct_Offset), InnerStruct);
	}

	public FCppTestStructInner(IntPtr nativeStruct)
	{
		if (!FCppTestStructInner_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.CppTestStructInner");
			ItemInts = null;
			InnerStruct = null;
		}
		else
		{
			ItemInts = new TArrayCopyMarshaler<FName>(1, ItemInts_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ItemInts_Offset));
			InnerStruct = new TArrayCopyMarshaler<FCppTestStructInnerInner>(1, InnerStruct_PropertyAddress, CachedMarshalingDelegates<FCppTestStructInnerInner, FCppTestStructInnerInner>.FromNative, CachedMarshalingDelegates<FCppTestStructInnerInner, FCppTestStructInnerInner>.ToNative).FromNative(IntPtr.Add(nativeStruct, InnerStruct_Offset));
		}
	}

	static FCppTestStructInner()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCppTestStructInner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCppTestStructInner));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.CppTestStructInner");
		FCppTestStructInner_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ItemInts_PropertyAddress, intPtr, "ItemInts");
		ItemInts_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemInts");
		ItemInts_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemInts", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref InnerStruct_PropertyAddress, intPtr, "InnerStruct");
		InnerStruct_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InnerStruct");
		InnerStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InnerStruct", Classes.FArrayProperty);
		FCppTestStructInner_IsValid = intPtr != IntPtr.Zero && ItemInts_IsValid && InnerStruct_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.CppTestStructInner", FCppTestStructInner_IsValid);
	}
}
