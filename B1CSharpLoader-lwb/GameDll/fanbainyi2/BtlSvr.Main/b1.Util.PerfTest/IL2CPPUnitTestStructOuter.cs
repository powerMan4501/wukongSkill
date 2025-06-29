using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructOuter")]
public struct IL2CPPUnitTestStructOuter
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructOuter:TestInt")]
	public int TestInt;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructOuter:ItemStructs")]
	public List<IL2CPPUnitTestStructInner> ItemStructs;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructOuter:Anim")]
	public UAnimSequence Anim;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestStructOuter:TestInt2")]
	public int TestInt2;

	private static int IL2CPPUnitTestStructOuter_StructSize;

	private static int IL2CPPUnitTestStructOuter_IsValid;

	private static bool TestInt_IsValid;

	private static int TestInt_Offset;

	private static bool ItemStructs_IsValid;

	private static int ItemStructs_Offset;

	private static FFieldAddress ItemStructs_PropertyAddress;

	private static bool Anim_IsValid;

	private static int Anim_Offset;

	private static bool TestInt2_IsValid;

	private static int TestInt2_Offset;

	public IL2CPPUnitTestStructOuter Copy()
	{
		IL2CPPUnitTestStructOuter result = this;
		if (ItemStructs != null)
		{
			result.ItemStructs = new List<IL2CPPUnitTestStructInner>(ItemStructs);
		}
		return result;
	}

	public static IL2CPPUnitTestStructOuter FromNative(IntPtr nativeBuffer)
	{
		return new IL2CPPUnitTestStructOuter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, IL2CPPUnitTestStructOuter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static IL2CPPUnitTestStructOuter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new IL2CPPUnitTestStructOuter(IntPtr.Add(nativeBuffer, arrayIndex * IL2CPPUnitTestStructOuter_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, IL2CPPUnitTestStructOuter value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * IL2CPPUnitTestStructOuter_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (IL2CPPUnitTestStructOuter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IL2CPPUnitTestStructOuter");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TestInt_Offset), TestInt);
		new TArrayCopyMarshaler<IL2CPPUnitTestStructInner>(1, ItemStructs_PropertyAddress, CachedMarshalingDelegates<IL2CPPUnitTestStructInner, IL2CPPUnitTestStructInner>.FromNative, CachedMarshalingDelegates<IL2CPPUnitTestStructInner, IL2CPPUnitTestStructInner>.ToNative).ToNative(IntPtr.Add(nativeStruct, ItemStructs_Offset), ItemStructs);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, Anim_Offset), Anim);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TestInt2_Offset), TestInt2);
	}

	public IL2CPPUnitTestStructOuter(IntPtr nativeStruct)
	{
		if (IL2CPPUnitTestStructOuter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.IL2CPPUnitTestStructOuter");
			TestInt = 0;
			ItemStructs = null;
			Anim = null;
			TestInt2 = 0;
		}
		else
		{
			TestInt = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TestInt_Offset));
			ItemStructs = new TArrayCopyMarshaler<IL2CPPUnitTestStructInner>(1, ItemStructs_PropertyAddress, CachedMarshalingDelegates<IL2CPPUnitTestStructInner, IL2CPPUnitTestStructInner>.FromNative, CachedMarshalingDelegates<IL2CPPUnitTestStructInner, IL2CPPUnitTestStructInner>.ToNative).FromNative(IntPtr.Add(nativeStruct, ItemStructs_Offset));
			Anim = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, Anim_Offset));
			TestInt2 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TestInt2_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.IL2CPPUnitTestStructOuter");
		IL2CPPUnitTestStructOuter_StructSize = NativeReflection.GetStructSize(intPtr);
		TestInt_Offset = NativeReflection.GetPropertyOffset(intPtr, "TestInt");
		TestInt_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TestInt", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ItemStructs_PropertyAddress, intPtr, "ItemStructs");
		ItemStructs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemStructs");
		ItemStructs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemStructs", Classes.FArrayProperty);
		Anim_Offset = NativeReflection.GetPropertyOffset(intPtr, "Anim");
		Anim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Anim", Classes.FObjectProperty);
		TestInt2_Offset = NativeReflection.GetPropertyOffset(intPtr, "TestInt2");
		TestInt2_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TestInt2", Classes.FIntProperty);
		IL2CPPUnitTestStructOuter_IsValid = ((intPtr != IntPtr.Zero && TestInt_IsValid && ItemStructs_IsValid && Anim_IsValid && TestInt2_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.IL2CPPUnitTestStructOuter", (byte)IL2CPPUnitTestStructOuter_IsValid != 0);
	}

	static IL2CPPUnitTestStructOuter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(IL2CPPUnitTestStructOuter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IL2CPPUnitTestStructOuter));
	}
}
