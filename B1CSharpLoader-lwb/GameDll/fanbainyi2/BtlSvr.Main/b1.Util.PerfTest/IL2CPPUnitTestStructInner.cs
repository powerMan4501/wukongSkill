using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructInner")]
public struct IL2CPPUnitTestStructInner
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructInner:ItemInts")]
	public List<FName> ItemInts;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructInner:InnerStruct")]
	public List<IL2CPPUnitTestStructInnerInner> InnerStruct;

	private static int IL2CPPUnitTestStructInner_StructSize;

	private static int IL2CPPUnitTestStructInner_IsValid;

	private static bool ItemInts_IsValid;

	private static int ItemInts_Offset;

	private static FFieldAddress ItemInts_PropertyAddress;

	private static bool InnerStruct_IsValid;

	private static int InnerStruct_Offset;

	private static FFieldAddress InnerStruct_PropertyAddress;

	public IL2CPPUnitTestStructInner Copy()
	{
		IL2CPPUnitTestStructInner result = this;
		if (ItemInts != null)
		{
			result.ItemInts = new List<FName>(ItemInts);
		}
		if (InnerStruct != null)
		{
			result.InnerStruct = new List<IL2CPPUnitTestStructInnerInner>(InnerStruct);
		}
		return result;
	}

	public static IL2CPPUnitTestStructInner FromNative(IntPtr nativeBuffer)
	{
		return new IL2CPPUnitTestStructInner(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, IL2CPPUnitTestStructInner value)
	{
		value.ToNative(nativeBuffer);
	}

	public static IL2CPPUnitTestStructInner FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new IL2CPPUnitTestStructInner(IntPtr.Add(nativeBuffer, arrayIndex * IL2CPPUnitTestStructInner_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IL2CPPUnitTestStructInner value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * IL2CPPUnitTestStructInner_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (IL2CPPUnitTestStructInner_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IL2CPPUnitTestStructInner");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, ItemInts_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ItemInts_Offset), ItemInts);
		new TArrayCopyMarshaler<IL2CPPUnitTestStructInnerInner>(1, InnerStruct_PropertyAddress, CachedMarshalingDelegates<IL2CPPUnitTestStructInnerInner, IL2CPPUnitTestStructInnerInner>.FromNative, CachedMarshalingDelegates<IL2CPPUnitTestStructInnerInner, IL2CPPUnitTestStructInnerInner>.ToNative).ToNative(IntPtr.Add(nativeStruct, InnerStruct_Offset), InnerStruct);
	}

	public IL2CPPUnitTestStructInner(IntPtr nativeStruct)
	{
		if (IL2CPPUnitTestStructInner_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IL2CPPUnitTestStructInner");
			ItemInts = null;
			InnerStruct = null;
		}
		else
		{
			ItemInts = new TArrayCopyMarshaler<FName>(1, ItemInts_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ItemInts_Offset));
			InnerStruct = new TArrayCopyMarshaler<IL2CPPUnitTestStructInnerInner>(1, InnerStruct_PropertyAddress, CachedMarshalingDelegates<IL2CPPUnitTestStructInnerInner, IL2CPPUnitTestStructInnerInner>.FromNative, CachedMarshalingDelegates<IL2CPPUnitTestStructInnerInner, IL2CPPUnitTestStructInnerInner>.ToNative).FromNative(IntPtr.Add(nativeStruct, InnerStruct_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.IL2CPPUnitTestStructInner");
		IL2CPPUnitTestStructInner_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ItemInts_PropertyAddress, intPtr, "ItemInts");
		ItemInts_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemInts");
		ItemInts_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemInts", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InnerStruct_PropertyAddress, intPtr, "InnerStruct");
		InnerStruct_Offset = NativeReflection.GetPropertyOffset(intPtr, "InnerStruct");
		InnerStruct_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InnerStruct", Classes.FArrayProperty);
		IL2CPPUnitTestStructInner_IsValid = ((intPtr != IntPtr.Zero && ItemInts_IsValid && InnerStruct_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.IL2CPPUnitTestStructInner", (byte)IL2CPPUnitTestStructInner_IsValid != 0);
	}

	static IL2CPPUnitTestStructInner()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(IL2CPPUnitTestStructInner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IL2CPPUnitTestStructInner));
	}
}
