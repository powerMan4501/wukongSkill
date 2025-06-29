using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.FoliageInstanceData", "FuncLibEditor", UnrealModuleType.Game)]
public struct FFoliageInstanceData
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.FoliageInstanceData:Location")]
	public FVector Location;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/FuncLibEditor.FoliageInstanceData:Rotation")]
	public FRotator Rotation;

	private static bool PreAlignRotation_IsValid;

	private static int PreAlignRotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/FuncLibEditor.FoliageInstanceData:PreAlignRotation")]
	public FRotator PreAlignRotation;

	private static bool DrawScale3D_IsValid;

	private static int DrawScale3D_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.FoliageInstanceData:DrawScale3D")]
	public FVector DrawScale3D;

	private static bool ZOffset_IsValid;

	private static int ZOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.FoliageInstanceData:ZOffset")]
	public float ZOffset;

	private static bool Flags_IsValid;

	private static int Flags_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.FoliageInstanceData:Flags")]
	public byte Flags;

	private static bool FFoliageInstanceData_IsValid;

	private static int FFoliageInstanceData_StructSize;

	public FFoliageInstanceData Copy()
	{
		return this;
	}

	public static FFoliageInstanceData FromNative(IntPtr nativeBuffer)
	{
		return new FFoliageInstanceData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFoliageInstanceData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFoliageInstanceData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFoliageInstanceData(nativeBuffer + arrayIndex * FFoliageInstanceData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFoliageInstanceData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFoliageInstanceData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFoliageInstanceData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FoliageInstanceData");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, PreAlignRotation_Offset), PreAlignRotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, DrawScale3D_Offset), DrawScale3D);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ZOffset_Offset), ZOffset);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Flags_Offset), Flags);
	}

	public FFoliageInstanceData(IntPtr nativeStruct)
	{
		if (!FFoliageInstanceData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FoliageInstanceData");
			Location = default(FVector);
			Rotation = default(FRotator);
			PreAlignRotation = default(FRotator);
			DrawScale3D = default(FVector);
			ZOffset = 0f;
			Flags = 0;
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			PreAlignRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, PreAlignRotation_Offset));
			DrawScale3D = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, DrawScale3D_Offset));
			ZOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ZOffset_Offset));
			Flags = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Flags_Offset));
		}
	}

	static FFoliageInstanceData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFoliageInstanceData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFoliageInstanceData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.FoliageInstanceData");
		FFoliageInstanceData_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		PreAlignRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreAlignRotation");
		PreAlignRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreAlignRotation", Classes.FStructProperty);
		DrawScale3D_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawScale3D");
		DrawScale3D_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawScale3D", Classes.FStructProperty);
		ZOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ZOffset");
		ZOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ZOffset", Classes.FFloatProperty);
		Flags_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Flags");
		Flags_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Flags", Classes.FByteProperty);
		FFoliageInstanceData_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Rotation_IsValid && PreAlignRotation_IsValid && DrawScale3D_IsValid && ZOffset_IsValid && Flags_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.FoliageInstanceData", FFoliageInstanceData_IsValid);
	}
}
