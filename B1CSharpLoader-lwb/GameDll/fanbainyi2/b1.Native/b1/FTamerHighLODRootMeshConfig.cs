using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.TamerHighLODRootMeshConfig", "b1", UnrealModuleType.Game)]
public struct FTamerHighLODRootMeshConfig
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

	private static bool SubMeshes_IsValid;

	private static FFieldAddress SubMeshes_PropertyAddress;

	private static int SubMeshes_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/b1.TamerHighLODRootMeshConfig:SubMeshes")]
	public Dictionary<FName, FTamerHighLODMeshConfig> SubMeshes;

	private static bool FTamerHighLODRootMeshConfig_IsValid;

	private static int FTamerHighLODRootMeshConfig_StructSize;

	public FTamerHighLODRootMeshConfig Copy()
	{
		FTamerHighLODRootMeshConfig result = this;
		if (SubMeshes != null)
		{
			result.SubMeshes = new Dictionary<FName, FTamerHighLODMeshConfig>(SubMeshes);
		}
		if (Materials != null)
		{
			result.Materials = new List<UMaterialInterface>(Materials);
		}
		return result;
	}

	public static FTamerHighLODRootMeshConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTamerHighLODRootMeshConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTamerHighLODRootMeshConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTamerHighLODRootMeshConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTamerHighLODRootMeshConfig(nativeBuffer + arrayIndex * FTamerHighLODRootMeshConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTamerHighLODRootMeshConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTamerHighLODRootMeshConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTamerHighLODRootMeshConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.TamerHighLODRootMeshConfig");
			return;
		}
		new TMapCopyMarshaler<FName, FTamerHighLODMeshConfig>(1, SubMeshes_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FTamerHighLODMeshConfig, FTamerHighLODMeshConfig>.FromNative, CachedMarshalingDelegates<FTamerHighLODMeshConfig, FTamerHighLODMeshConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, SubMeshes_Offset), SubMeshes);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(nativeStruct, Mesh_Offset), Mesh);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(nativeStruct, BstdAnim_Offset), BstdAnim);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, MeshTransform_Offset), MeshTransform);
		new TArrayCopyMarshaler<UMaterialInterface>(1, Materials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Materials_Offset), Materials);
	}

	public FTamerHighLODRootMeshConfig(IntPtr nativeStruct)
	{
		if (!FTamerHighLODRootMeshConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.TamerHighLODRootMeshConfig");
			SubMeshes = null;
			Mesh = null;
			BstdAnim = null;
			MeshTransform = default(FTransform);
			Materials = null;
		}
		else
		{
			SubMeshes = new TMapCopyMarshaler<FName, FTamerHighLODMeshConfig>(1, SubMeshes_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FTamerHighLODMeshConfig, FTamerHighLODMeshConfig>.FromNative, CachedMarshalingDelegates<FTamerHighLODMeshConfig, FTamerHighLODMeshConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, SubMeshes_Offset));
			Mesh = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(nativeStruct, Mesh_Offset));
			BstdAnim = UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(nativeStruct, BstdAnim_Offset));
			MeshTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, MeshTransform_Offset));
			Materials = new TArrayCopyMarshaler<UMaterialInterface>(1, Materials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Materials_Offset));
		}
	}

	static FTamerHighLODRootMeshConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTamerHighLODRootMeshConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTamerHighLODRootMeshConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.TamerHighLODRootMeshConfig");
		FTamerHighLODRootMeshConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Mesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mesh", Classes.FObjectProperty);
		BstdAnim_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BstdAnim");
		BstdAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BstdAnim", Classes.FObjectProperty);
		MeshTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshTransform");
		MeshTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Materials_PropertyAddress, intPtr, "Materials");
		Materials_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Materials");
		Materials_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Materials", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SubMeshes_PropertyAddress, intPtr, "SubMeshes");
		SubMeshes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubMeshes");
		SubMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubMeshes", Classes.FMapProperty);
		FTamerHighLODRootMeshConfig_IsValid = intPtr != IntPtr.Zero && SubMeshes_IsValid && Mesh_IsValid && BstdAnim_IsValid && MeshTransform_IsValid && Materials_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.TamerHighLODRootMeshConfig", FTamerHighLODRootMeshConfig_IsValid);
	}
}
