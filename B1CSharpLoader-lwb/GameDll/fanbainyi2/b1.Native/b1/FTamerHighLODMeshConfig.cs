using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.TamerHighLODMeshConfig", "b1", UnrealModuleType.Game)]
public struct FTamerHighLODMeshConfig
{
	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.TamerHighLODMeshConfig:Mesh")]
	public USkeletalMesh Mesh;

	private static bool BstdAnim_IsValid;

	private static int BstdAnim_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.TamerHighLODMeshConfig:BstdAnim")]
	public UAnimationAsset BstdAnim;

	private static bool MeshTransform_IsValid;

	private static int MeshTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/b1.TamerHighLODMeshConfig:MeshTransform")]
	public FTransform MeshTransform;

	private static bool Materials_IsValid;

	private static FFieldAddress Materials_PropertyAddress;

	private static int Materials_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.TamerHighLODMeshConfig:Materials")]
	public List<UMaterialInterface> Materials;

	private static bool FTamerHighLODMeshConfig_IsValid;

	private static int FTamerHighLODMeshConfig_StructSize;

	public FTamerHighLODMeshConfig Copy()
	{
		FTamerHighLODMeshConfig result = this;
		if (Materials != null)
		{
			result.Materials = new List<UMaterialInterface>(Materials);
		}
		return result;
	}

	public static FTamerHighLODMeshConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTamerHighLODMeshConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTamerHighLODMeshConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTamerHighLODMeshConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTamerHighLODMeshConfig(nativeBuffer + arrayIndex * FTamerHighLODMeshConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTamerHighLODMeshConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTamerHighLODMeshConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTamerHighLODMeshConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.TamerHighLODMeshConfig");
			return;
		}
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(nativeStruct, Mesh_Offset), Mesh);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(nativeStruct, BstdAnim_Offset), BstdAnim);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, MeshTransform_Offset), MeshTransform);
		new TArrayCopyMarshaler<UMaterialInterface>(1, Materials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Materials_Offset), Materials);
	}

	public FTamerHighLODMeshConfig(IntPtr nativeStruct)
	{
		if (!FTamerHighLODMeshConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.TamerHighLODMeshConfig");
			Mesh = null;
			BstdAnim = null;
			MeshTransform = default(FTransform);
			Materials = null;
		}
		else
		{
			Mesh = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(nativeStruct, Mesh_Offset));
			BstdAnim = UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(nativeStruct, BstdAnim_Offset));
			MeshTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, MeshTransform_Offset));
			Materials = new TArrayCopyMarshaler<UMaterialInterface>(1, Materials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Materials_Offset));
		}
	}

	static FTamerHighLODMeshConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTamerHighLODMeshConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTamerHighLODMeshConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.TamerHighLODMeshConfig");
		FTamerHighLODMeshConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Mesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mesh", Classes.FObjectProperty);
		BstdAnim_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BstdAnim");
		BstdAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BstdAnim", Classes.FObjectProperty);
		MeshTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshTransform");
		MeshTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Materials_PropertyAddress, intPtr, "Materials");
		Materials_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Materials");
		Materials_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Materials", Classes.FArrayProperty);
		FTamerHighLODMeshConfig_IsValid = intPtr != IntPtr.Zero && Mesh_IsValid && BstdAnim_IsValid && MeshTransform_IsValid && Materials_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.TamerHighLODMeshConfig", FTamerHighLODMeshConfig_IsValid);
	}
}
