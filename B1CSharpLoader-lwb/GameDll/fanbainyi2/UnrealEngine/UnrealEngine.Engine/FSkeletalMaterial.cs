using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SkeletalMaterial", "Engine", UnrealModuleType.Engine)]
public struct FSkeletalMaterial
{
	private static bool MaterialInterface_IsValid;

	private static int MaterialInterface_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SkeletalMaterial:MaterialInterface")]
	public UMaterialInterface MaterialInterface;

	private static bool MaterialSlotName_IsValid;

	private static int MaterialSlotName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SkeletalMaterial:MaterialSlotName")]
	public FName MaterialSlotName;

	private static bool UVChannelData_IsValid;

	private static int UVChannelData_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/Engine.SkeletalMaterial:UVChannelData")]
	public FMeshUVChannelInfo UVChannelData;

	private static bool FSkeletalMaterial_IsValid;

	private static int FSkeletalMaterial_StructSize;

	public FSkeletalMaterial Copy()
	{
		return this;
	}

	public static FSkeletalMaterial FromNative(IntPtr nativeBuffer)
	{
		return new FSkeletalMaterial(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkeletalMaterial value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkeletalMaterial FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkeletalMaterial(nativeBuffer + arrayIndex * FSkeletalMaterial_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkeletalMaterial value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkeletalMaterial_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkeletalMaterial_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkeletalMaterial");
			return;
		}
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, MaterialInterface_Offset), MaterialInterface);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MaterialSlotName_Offset), MaterialSlotName);
		FMeshUVChannelInfo.ToNative(IntPtr.Add(nativeStruct, UVChannelData_Offset), UVChannelData);
	}

	public FSkeletalMaterial(IntPtr nativeStruct)
	{
		if (!FSkeletalMaterial_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkeletalMaterial");
			MaterialInterface = null;
			MaterialSlotName = default(FName);
			UVChannelData = default(FMeshUVChannelInfo);
		}
		else
		{
			MaterialInterface = UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(nativeStruct, MaterialInterface_Offset));
			MaterialSlotName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MaterialSlotName_Offset));
			UVChannelData = FMeshUVChannelInfo.FromNative(IntPtr.Add(nativeStruct, UVChannelData_Offset));
		}
	}

	static FSkeletalMaterial()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkeletalMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkeletalMaterial));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SkeletalMaterial");
		FSkeletalMaterial_StructSize = NativeReflection.GetStructSize(intPtr);
		MaterialInterface_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialInterface");
		MaterialInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialInterface", Classes.FObjectProperty);
		MaterialSlotName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialSlotName");
		MaterialSlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialSlotName", Classes.FNameProperty);
		UVChannelData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVChannelData");
		UVChannelData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVChannelData", Classes.FStructProperty);
		FSkeletalMaterial_IsValid = intPtr != IntPtr.Zero && MaterialInterface_IsValid && MaterialSlotName_IsValid && UVChannelData_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SkeletalMaterial", FSkeletalMaterial_IsValid);
	}
}
