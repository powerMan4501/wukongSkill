using System;
using UnrealEngine.Engine;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangePipelines;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline", "InterchangePipelines", UnrealModuleType.EnginePlugin)]
public class UInterchangeGenericAssetsPipeline : UInterchangePipelineBase
{
	private static bool UseSourceNameForAsset_IsValid;

	private static FFieldAddress UseSourceNameForAsset_PropertyAddress;

	private static int UseSourceNameForAsset_Offset;

	private static bool ImportLods_IsValid;

	private static FFieldAddress ImportLods_PropertyAddress;

	private static int ImportLods_Offset;

	private static bool BakeMeshes_IsValid;

	private static FFieldAddress BakeMeshes_PropertyAddress;

	private static int BakeMeshes_Offset;

	private static bool VertexColorImportOption_IsValid;

	private static FFieldAddress VertexColorImportOption_PropertyAddress;

	private static int VertexColorImportOption_Offset;

	private static bool VertexOverrideColor_IsValid;

	private static int VertexOverrideColor_Offset;

	private static bool ImportStaticMeshes_IsValid;

	private static FFieldAddress ImportStaticMeshes_PropertyAddress;

	private static int ImportStaticMeshes_Offset;

	private static bool CombineStaticMeshes_IsValid;

	private static FFieldAddress CombineStaticMeshes_PropertyAddress;

	private static int CombineStaticMeshes_Offset;

	private static bool Skeleton_IsValid;

	private static int Skeleton_Offset;

	private static bool ImportSkeletalMeshes_IsValid;

	private static FFieldAddress ImportSkeletalMeshes_PropertyAddress;

	private static int ImportSkeletalMeshes_Offset;

	private static bool CombineSkeletalMeshes_IsValid;

	private static FFieldAddress CombineSkeletalMeshes_PropertyAddress;

	private static int CombineSkeletalMeshes_Offset;

	private static bool ImportMorphTargets_IsValid;

	private static FFieldAddress ImportMorphTargets_PropertyAddress;

	private static int ImportMorphTargets_Offset;

	private static bool CreatePhysicsAsset_IsValid;

	private static FFieldAddress CreatePhysicsAsset_PropertyAddress;

	private static int CreatePhysicsAsset_Offset;

	private static bool PhysicsAsset_IsValid;

	private static int PhysicsAsset_Offset;

	private static bool ImportMaterials_IsValid;

	private static FFieldAddress ImportMaterials_PropertyAddress;

	private static int ImportMaterials_Offset;

	private static bool ImportTextures_IsValid;

	private static FFieldAddress ImportTextures_PropertyAddress;

	private static int ImportTextures_Offset;

	private static bool DetectNormalMapTexture_IsValid;

	private static FFieldAddress DetectNormalMapTexture_PropertyAddress;

	private static int DetectNormalMapTexture_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bUseSourceNameForAsset")]
	public bool UseSourceNameForAsset
	{
		get
		{
			CheckDestroyed();
			if (!UseSourceNameForAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bUseSourceNameForAsset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSourceNameForAsset_Offset), 0, UseSourceNameForAsset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSourceNameForAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bUseSourceNameForAsset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSourceNameForAsset_Offset), 0, UseSourceNameForAsset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportLods")]
	public bool ImportLods
	{
		get
		{
			CheckDestroyed();
			if (!ImportLods_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportLods");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportLods_Offset), 0, ImportLods_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportLods_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportLods");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportLods_Offset), 0, ImportLods_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bBakeMeshes")]
	public bool BakeMeshes
	{
		get
		{
			CheckDestroyed();
			if (!BakeMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bBakeMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BakeMeshes_Offset), 0, BakeMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BakeMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bBakeMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BakeMeshes_Offset), 0, BakeMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:VertexColorImportOption")]
	public EInterchangeVertexColorImportOption VertexColorImportOption
	{
		get
		{
			CheckDestroyed();
			if (!VertexColorImportOption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:VertexColorImportOption");
				return EInterchangeVertexColorImportOption.IVCIO_Replace;
			}
			return EnumMarshaler<EInterchangeVertexColorImportOption>.FromNative(IntPtr.Add(base.Address, VertexColorImportOption_Offset), 0, VertexColorImportOption_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VertexColorImportOption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:VertexColorImportOption");
			}
			else
			{
				EnumMarshaler<EInterchangeVertexColorImportOption>.ToNative(IntPtr.Add(base.Address, VertexColorImportOption_Offset), 0, VertexColorImportOption_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:VertexOverrideColor")]
	public FColor VertexOverrideColor
	{
		get
		{
			CheckDestroyed();
			if (!VertexOverrideColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:VertexOverrideColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, VertexOverrideColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VertexOverrideColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:VertexOverrideColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, VertexOverrideColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportStaticMeshes")]
	public bool ImportStaticMeshes
	{
		get
		{
			CheckDestroyed();
			if (!ImportStaticMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportStaticMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportStaticMeshes_Offset), 0, ImportStaticMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportStaticMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportStaticMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportStaticMeshes_Offset), 0, ImportStaticMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bCombineStaticMeshes")]
	public bool CombineStaticMeshes
	{
		get
		{
			CheckDestroyed();
			if (!CombineStaticMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bCombineStaticMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CombineStaticMeshes_Offset), 0, CombineStaticMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CombineStaticMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bCombineStaticMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CombineStaticMeshes_Offset), 0, CombineStaticMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:Skeleton")]
	public USkeleton Skeleton
	{
		get
		{
			CheckDestroyed();
			if (!Skeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:Skeleton");
				return null;
			}
			return UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(base.Address, Skeleton_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Skeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:Skeleton");
			}
			else
			{
				UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(base.Address, Skeleton_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportSkeletalMeshes")]
	public bool ImportSkeletalMeshes
	{
		get
		{
			CheckDestroyed();
			if (!ImportSkeletalMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportSkeletalMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportSkeletalMeshes_Offset), 0, ImportSkeletalMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportSkeletalMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportSkeletalMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportSkeletalMeshes_Offset), 0, ImportSkeletalMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bCombineSkeletalMeshes")]
	public bool CombineSkeletalMeshes
	{
		get
		{
			CheckDestroyed();
			if (!CombineSkeletalMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bCombineSkeletalMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CombineSkeletalMeshes_Offset), 0, CombineSkeletalMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CombineSkeletalMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bCombineSkeletalMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CombineSkeletalMeshes_Offset), 0, CombineSkeletalMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportMorphTargets")]
	public bool ImportMorphTargets
	{
		get
		{
			CheckDestroyed();
			if (!ImportMorphTargets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportMorphTargets");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportMorphTargets_Offset), 0, ImportMorphTargets_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportMorphTargets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportMorphTargets");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportMorphTargets_Offset), 0, ImportMorphTargets_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bCreatePhysicsAsset")]
	public bool CreatePhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!CreatePhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bCreatePhysicsAsset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CreatePhysicsAsset_Offset), 0, CreatePhysicsAsset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CreatePhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bCreatePhysicsAsset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CreatePhysicsAsset_Offset), 0, CreatePhysicsAsset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:PhysicsAsset")]
	public UPhysicsAsset PhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:PhysicsAsset");
				return null;
			}
			return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(base.Address, PhysicsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:PhysicsAsset");
			}
			else
			{
				UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(base.Address, PhysicsAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportMaterials")]
	public bool ImportMaterials
	{
		get
		{
			CheckDestroyed();
			if (!ImportMaterials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportMaterials");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportMaterials_Offset), 0, ImportMaterials_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportMaterials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportMaterials");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportMaterials_Offset), 0, ImportMaterials_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportTextures")]
	public bool ImportTextures
	{
		get
		{
			CheckDestroyed();
			if (!ImportTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportTextures");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImportTextures_Offset), 0, ImportTextures_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bImportTextures");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImportTextures_Offset), 0, ImportTextures_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bDetectNormalMapTexture")]
	public bool DetectNormalMapTexture
	{
		get
		{
			CheckDestroyed();
			if (!DetectNormalMapTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bDetectNormalMapTexture");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DetectNormalMapTexture_Offset), 0, DetectNormalMapTexture_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetectNormalMapTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline:bDetectNormalMapTexture");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DetectNormalMapTexture_Offset), 0, DetectNormalMapTexture_PropertyAddress.Address, value);
			}
		}
	}

	static UInterchangeGenericAssetsPipeline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeGenericAssetsPipeline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeGenericAssetsPipeline));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/InterchangePipelines.InterchangeGenericAssetsPipeline");
		NativeReflectionCached.GetPropertyRef(ref UseSourceNameForAsset_PropertyAddress, unrealStruct, "bUseSourceNameForAsset");
		UseSourceNameForAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseSourceNameForAsset");
		UseSourceNameForAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseSourceNameForAsset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLods_PropertyAddress, unrealStruct, "bImportLods");
		ImportLods_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bImportLods");
		ImportLods_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bImportLods", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BakeMeshes_PropertyAddress, unrealStruct, "bBakeMeshes");
		BakeMeshes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBakeMeshes");
		BakeMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBakeMeshes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VertexColorImportOption_PropertyAddress, unrealStruct, "VertexColorImportOption");
		VertexColorImportOption_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VertexColorImportOption");
		VertexColorImportOption_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VertexColorImportOption", Classes.FByteProperty);
		VertexOverrideColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VertexOverrideColor");
		VertexOverrideColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VertexOverrideColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportStaticMeshes_PropertyAddress, unrealStruct, "bImportStaticMeshes");
		ImportStaticMeshes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bImportStaticMeshes");
		ImportStaticMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bImportStaticMeshes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CombineStaticMeshes_PropertyAddress, unrealStruct, "bCombineStaticMeshes");
		CombineStaticMeshes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCombineStaticMeshes");
		CombineStaticMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCombineStaticMeshes", Classes.FBoolProperty);
		Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Skeleton");
		Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Skeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportSkeletalMeshes_PropertyAddress, unrealStruct, "bImportSkeletalMeshes");
		ImportSkeletalMeshes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bImportSkeletalMeshes");
		ImportSkeletalMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bImportSkeletalMeshes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CombineSkeletalMeshes_PropertyAddress, unrealStruct, "bCombineSkeletalMeshes");
		CombineSkeletalMeshes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCombineSkeletalMeshes");
		CombineSkeletalMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCombineSkeletalMeshes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportMorphTargets_PropertyAddress, unrealStruct, "bImportMorphTargets");
		ImportMorphTargets_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bImportMorphTargets");
		ImportMorphTargets_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bImportMorphTargets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePhysicsAsset_PropertyAddress, unrealStruct, "bCreatePhysicsAsset");
		CreatePhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCreatePhysicsAsset");
		CreatePhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCreatePhysicsAsset", Classes.FBoolProperty);
		PhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PhysicsAsset");
		PhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PhysicsAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportMaterials_PropertyAddress, unrealStruct, "bImportMaterials");
		ImportMaterials_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bImportMaterials");
		ImportMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bImportMaterials", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportTextures_PropertyAddress, unrealStruct, "bImportTextures");
		ImportTextures_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bImportTextures");
		ImportTextures_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bImportTextures", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectNormalMapTexture_PropertyAddress, unrealStruct, "bDetectNormalMapTexture");
		DetectNormalMapTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDetectNormalMapTexture");
		DetectNormalMapTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDetectNormalMapTexture", Classes.FBoolProperty);
	}
}
