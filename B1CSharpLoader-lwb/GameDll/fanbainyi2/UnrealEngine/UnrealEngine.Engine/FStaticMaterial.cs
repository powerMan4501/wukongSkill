using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.StaticMaterial", "Engine", UnrealModuleType.Engine)]
public struct FStaticMaterial
{
	private static bool MaterialInterface_IsValid;

	private static int MaterialInterface_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.StaticMaterial:MaterialInterface")]
	public UMaterialInterface MaterialInterface;

	private static bool MaterialSlotName_IsValid;

	private static int MaterialSlotName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.StaticMaterial:MaterialSlotName")]
	public FName MaterialSlotName;

	private static bool UVChannelData_IsValid;

	private static int UVChannelData_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/Engine.StaticMaterial:UVChannelData")]
	public FMeshUVChannelInfo UVChannelData;

	private static bool FStaticMaterial_IsValid;

	private static int FStaticMaterial_StructSize;

	public FStaticMaterial Copy()
	{
		return this;
	}

	public static FStaticMaterial FromNative(IntPtr nativeBuffer)
	{
		return new FStaticMaterial(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStaticMaterial value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStaticMaterial FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStaticMaterial(nativeBuffer + arrayIndex * FStaticMaterial_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStaticMaterial value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStaticMaterial_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStaticMaterial_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.StaticMaterial");
			return;
		}
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, MaterialInterface_Offset), MaterialInterface);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MaterialSlotName_Offset), MaterialSlotName);
		FMeshUVChannelInfo.ToNative(IntPtr.Add(nativeStruct, UVChannelData_Offset), UVChannelData);
	}

	public FStaticMaterial(IntPtr nativeStruct)
	{
		if (!FStaticMaterial_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.StaticMaterial");
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

	static FStaticMaterial()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStaticMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStaticMaterial));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.StaticMaterial");
		FStaticMaterial_StructSize = NativeReflection.GetStructSize(intPtr);
		MaterialInterface_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialInterface");
		MaterialInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialInterface", Classes.FObjectProperty);
		MaterialSlotName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialSlotName");
		MaterialSlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialSlotName", Classes.FNameProperty);
		UVChannelData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVChannelData");
		UVChannelData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVChannelData", Classes.FStructProperty);
		FStaticMaterial_IsValid = intPtr != IntPtr.Zero && MaterialInterface_IsValid && MaterialSlotName_IsValid && UVChannelData_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.StaticMaterial", FStaticMaterial_IsValid);
	}
}
