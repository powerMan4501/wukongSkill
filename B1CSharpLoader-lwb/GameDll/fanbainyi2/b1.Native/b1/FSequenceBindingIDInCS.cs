using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.SequenceBindingIDInCS", "UnrealExtent", UnrealModuleType.Game)]
public struct FSequenceBindingIDInCS
{
	private static bool SequenceID_IsValid;

	private static int SequenceID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.SequenceBindingIDInCS:SequenceID")]
	public int SequenceID;

	private static bool Space_IsValid;

	private static int Space_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.SequenceBindingIDInCS:Space")]
	public int Space;

	private static bool Guid_IsValid;

	private static int Guid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.SequenceBindingIDInCS:Guid")]
	public Guid Guid;

	private static bool FSequenceBindingIDInCS_IsValid;

	private static int FSequenceBindingIDInCS_StructSize;

	public FSequenceBindingIDInCS Copy()
	{
		return this;
	}

	public static FSequenceBindingIDInCS FromNative(IntPtr nativeBuffer)
	{
		return new FSequenceBindingIDInCS(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSequenceBindingIDInCS value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSequenceBindingIDInCS FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSequenceBindingIDInCS(nativeBuffer + arrayIndex * FSequenceBindingIDInCS_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSequenceBindingIDInCS value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSequenceBindingIDInCS_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSequenceBindingIDInCS_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.SequenceBindingIDInCS");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SequenceID_Offset), SequenceID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Space_Offset), Space);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, Guid_Offset), Guid);
	}

	public FSequenceBindingIDInCS(IntPtr nativeStruct)
	{
		if (!FSequenceBindingIDInCS_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.SequenceBindingIDInCS");
			SequenceID = 0;
			Space = 0;
			Guid = default(Guid);
		}
		else
		{
			SequenceID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SequenceID_Offset));
			Space = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Space_Offset));
			Guid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, Guid_Offset));
		}
	}

	static FSequenceBindingIDInCS()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSequenceBindingIDInCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSequenceBindingIDInCS));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.SequenceBindingIDInCS");
		FSequenceBindingIDInCS_StructSize = NativeReflection.GetStructSize(intPtr);
		SequenceID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SequenceID");
		SequenceID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SequenceID", Classes.FIntProperty);
		Space_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Space");
		Space_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Space", Classes.FIntProperty);
		Guid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Guid");
		Guid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Guid", Classes.FStructProperty);
		FSequenceBindingIDInCS_IsValid = intPtr != IntPtr.Zero && SequenceID_IsValid && Space_IsValid && Guid_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.SequenceBindingIDInCS", FSequenceBindingIDInCS_IsValid);
	}
}
