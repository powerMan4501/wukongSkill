using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.ClothingSystemRuntimeInterface;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SkeletalMesh", "Engine", UnrealModuleType.Engine)]
public class USkeletalMesh : UStreamableRenderAsset, IInterface_CollisionDataProvider, IInterface, IInterface_AssetUserData, INodeMappingProviderInterface, IInterface_AsyncCompilation
{
	private static bool Skeleton_IsValid;

	private static int Skeleton_Offset;

	private static bool PositiveBoundsExtension_IsValid;

	private static int PositiveBoundsExtension_Offset;

	private static bool NegativeBoundsExtension_IsValid;

	private static int NegativeBoundsExtension_Offset;

	private static bool Materials_IsValid;

	private static FFieldAddress Materials_PropertyAddress;

	private static int Materials_Offset;

	private TArrayReadWriteMarshaler<FSkeletalMaterial> Materials_MarshalerCached;

	private static bool LODSettings_IsValid;

	private static int LODSettings_Offset;

	private static bool DefaultAnimatingRig_IsValid;

	private static int DefaultAnimatingRig_Offset;

	private static bool PhysicsAsset_IsValid;

	private static int PhysicsAsset_Offset;

	private static bool ShadowPhysicsAsset_IsValid;

	private static int ShadowPhysicsAsset_Offset;

	private static bool NodeMappingData_IsValid;

	private static FFieldAddress NodeMappingData_PropertyAddress;

	private static int NodeMappingData_Offset;

	private TArrayReadOnlyMarshaler<UNodeMappingContainer> NodeMappingData_MarshalerCached;

	private static bool MorphTargets_IsValid;

	private static FFieldAddress MorphTargets_PropertyAddress;

	private static int MorphTargets_Offset;

	private TArrayReadWriteMarshaler<UMorphTarget> MorphTargets_MarshalerCached;

	private static bool PostProcessAnimBlueprint_IsValid;

	private static int PostProcessAnimBlueprint_Offset;

	private static bool MeshClothingAssets_IsValid;

	private static FFieldAddress MeshClothingAssets_PropertyAddress;

	private static int MeshClothingAssets_Offset;

	private TArrayReadWriteMarshaler<UClothingAssetBase> MeshClothingAssets_MarshalerCached;

	private static bool SetSkeleton_IsValid;

	private static IntPtr SetSkeleton_FunctionAddress;

	private static int SetSkeleton_ParamsSize;

	private static bool SetSkeleton_InSkeleton_IsValid;

	private static FFieldAddress SetSkeleton_InSkeleton_PropertyAddress;

	private static int SetSkeleton_InSkeleton_Offset;

	private static bool SetMorphTargets_IsValid;

	private static IntPtr SetMorphTargets_FunctionAddress;

	private static int SetMorphTargets_ParamsSize;

	private static bool SetMorphTargets_InMorphTargets_IsValid;

	private static FFieldAddress SetMorphTargets_InMorphTargets_PropertyAddress;

	private static int SetMorphTargets_InMorphTargets_Offset;

	private static bool SetMeshClothingAssets_IsValid;

	private static IntPtr SetMeshClothingAssets_FunctionAddress;

	private static int SetMeshClothingAssets_ParamsSize;

	private static bool SetMeshClothingAssets_InMeshClothingAssets_IsValid;

	private static FFieldAddress SetMeshClothingAssets_InMeshClothingAssets_PropertyAddress;

	private static int SetMeshClothingAssets_InMeshClothingAssets_Offset;

	private static bool SetMaterials_IsValid;

	private static IntPtr SetMaterials_FunctionAddress;

	private static int SetMaterials_ParamsSize;

	private static bool SetMaterials_InMaterials_IsValid;

	private static FFieldAddress SetMaterials_InMaterials_PropertyAddress;

	private static int SetMaterials_InMaterials_Offset;

	private static bool SetLODSettings_IsValid;

	private static IntPtr SetLODSettings_FunctionAddress;

	private static int SetLODSettings_ParamsSize;

	private static bool SetLODSettings_InLODSettings_IsValid;

	private static FFieldAddress SetLODSettings_InLODSettings_PropertyAddress;

	private static int SetLODSettings_InLODSettings_Offset;

	private static bool SetDefaultAnimatingRig_IsValid;

	private static IntPtr SetDefaultAnimatingRig_FunctionAddress;

	private static int SetDefaultAnimatingRig_ParamsSize;

	private static bool SetDefaultAnimatingRig_InAnimatingRig_IsValid;

	private static FFieldAddress SetDefaultAnimatingRig_InAnimatingRig_PropertyAddress;

	private static int SetDefaultAnimatingRig_InAnimatingRig_Offset;

	private static bool NumSockets_IsValid;

	private static IntPtr NumSockets_FunctionAddress;

	private static int NumSockets_ParamsSize;

	private static bool NumSockets_ReturnValue_IsValid;

	private static FFieldAddress NumSockets_ReturnValue_PropertyAddress;

	private static int NumSockets_ReturnValue_Offset;

	private static bool GetAllMorphTargetNames_IsValid;

	private static IntPtr GetAllMorphTargetNames_FunctionAddress;

	private static int GetAllMorphTargetNames_ParamsSize;

	private static bool GetAllMorphTargetNames_ReturnValue_IsValid;

	private static FFieldAddress GetAllMorphTargetNames_ReturnValue_PropertyAddress;

	private static int GetAllMorphTargetNames_ReturnValue_Offset;

	private static bool IsSectionUsingCloth_IsValid;

	private static IntPtr IsSectionUsingCloth_FunctionAddress;

	private static int IsSectionUsingCloth_ParamsSize;

	private static bool IsSectionUsingCloth_InSectionIndex_IsValid;

	private static FFieldAddress IsSectionUsingCloth_InSectionIndex_PropertyAddress;

	private static int IsSectionUsingCloth_InSectionIndex_Offset;

	private static bool IsSectionUsingCloth_bCheckCorrespondingSections_IsValid;

	private static FFieldAddress IsSectionUsingCloth_bCheckCorrespondingSections_PropertyAddress;

	private static int IsSectionUsingCloth_bCheckCorrespondingSections_Offset;

	private static bool IsSectionUsingCloth_ReturnValue_IsValid;

	private static FFieldAddress IsSectionUsingCloth_ReturnValue_PropertyAddress;

	private static int IsSectionUsingCloth_ReturnValue_Offset;

	private static bool GetSocketByIndex_IsValid;

	private static IntPtr GetSocketByIndex_FunctionAddress;

	private static int GetSocketByIndex_ParamsSize;

	private static bool GetSocketByIndex_Index_IsValid;

	private static FFieldAddress GetSocketByIndex_Index_PropertyAddress;

	private static int GetSocketByIndex_Index_Offset;

	private static bool GetSocketByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetSocketByIndex_ReturnValue_PropertyAddress;

	private static int GetSocketByIndex_ReturnValue_Offset;

	private static bool GetSkeleton_IsValid;

	private static IntPtr GetSkeleton_FunctionAddress;

	private static int GetSkeleton_ParamsSize;

	private static bool GetSkeleton_ReturnValue_IsValid;

	private static FFieldAddress GetSkeleton_ReturnValue_PropertyAddress;

	private static int GetSkeleton_ReturnValue_Offset;

	private static bool GetShadowPhysicsAsset_IsValid;

	private static IntPtr GetShadowPhysicsAsset_FunctionAddress;

	private static int GetShadowPhysicsAsset_ParamsSize;

	private static bool GetShadowPhysicsAsset_ReturnValue_IsValid;

	private static FFieldAddress GetShadowPhysicsAsset_ReturnValue_PropertyAddress;

	private static int GetShadowPhysicsAsset_ReturnValue_Offset;

	private static bool GetPhysicsAsset_IsValid;

	private static IntPtr GetPhysicsAsset_FunctionAddress;

	private static int GetPhysicsAsset_ParamsSize;

	private static bool GetPhysicsAsset_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsAsset_ReturnValue_PropertyAddress;

	private static int GetPhysicsAsset_ReturnValue_Offset;

	private static bool GetNodeMappingData_IsValid;

	private static IntPtr GetNodeMappingData_FunctionAddress;

	private static int GetNodeMappingData_ParamsSize;

	private static bool GetNodeMappingData_ReturnValue_IsValid;

	private static FFieldAddress GetNodeMappingData_ReturnValue_PropertyAddress;

	private static int GetNodeMappingData_ReturnValue_Offset;

	private static bool GetNodeMappingContainer_IsValid;

	private static IntPtr GetNodeMappingContainer_FunctionAddress;

	private static int GetNodeMappingContainer_ParamsSize;

	private static bool GetNodeMappingContainer_SourceAsset_IsValid;

	private static FFieldAddress GetNodeMappingContainer_SourceAsset_PropertyAddress;

	private static int GetNodeMappingContainer_SourceAsset_Offset;

	private static bool GetNodeMappingContainer_ReturnValue_IsValid;

	private static FFieldAddress GetNodeMappingContainer_ReturnValue_PropertyAddress;

	private static int GetNodeMappingContainer_ReturnValue_Offset;

	private static bool GetMorphTargets_IsValid;

	private static IntPtr GetMorphTargets_FunctionAddress;

	private static int GetMorphTargets_ParamsSize;

	private static bool GetMorphTargets_ReturnValue_IsValid;

	private static FFieldAddress GetMorphTargets_ReturnValue_PropertyAddress;

	private static int GetMorphTargets_ReturnValue_Offset;

	private static bool GetMeshClothingAssets_IsValid;

	private static IntPtr GetMeshClothingAssets_FunctionAddress;

	private static int GetMeshClothingAssets_ParamsSize;

	private static bool GetMeshClothingAssets_ReturnValue_IsValid;

	private static FFieldAddress GetMeshClothingAssets_ReturnValue_PropertyAddress;

	private static int GetMeshClothingAssets_ReturnValue_Offset;

	private static bool GetMaterials_IsValid;

	private static IntPtr GetMaterials_FunctionAddress;

	private static int GetMaterials_ParamsSize;

	private static bool GetMaterials_ReturnValue_IsValid;

	private static FFieldAddress GetMaterials_ReturnValue_PropertyAddress;

	private static int GetMaterials_ReturnValue_Offset;

	private static bool GetLODSettings_IsValid;

	private static IntPtr GetLODSettings_FunctionAddress;

	private static int GetLODSettings_ParamsSize;

	private static bool GetLODSettings_ReturnValue_IsValid;

	private static FFieldAddress GetLODSettings_ReturnValue_PropertyAddress;

	private static int GetLODSettings_ReturnValue_Offset;

	private static bool GetImportedBounds_IsValid;

	private static IntPtr GetImportedBounds_FunctionAddress;

	private static int GetImportedBounds_ParamsSize;

	private static bool GetImportedBounds_ReturnValue_IsValid;

	private static FFieldAddress GetImportedBounds_ReturnValue_PropertyAddress;

	private static int GetImportedBounds_ReturnValue_Offset;

	private static bool GetDefaultAnimatingRig_IsValid;

	private static IntPtr GetDefaultAnimatingRig_FunctionAddress;

	private static int GetDefaultAnimatingRig_ParamsSize;

	private static bool GetDefaultAnimatingRig_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultAnimatingRig_ReturnValue_PropertyAddress;

	private static int GetDefaultAnimatingRig_ReturnValue_Offset;

	private static bool GetBounds_IsValid;

	private static IntPtr GetBounds_FunctionAddress;

	private static int GetBounds_ParamsSize;

	private static bool GetBounds_ReturnValue_IsValid;

	private static FFieldAddress GetBounds_ReturnValue_PropertyAddress;

	private static int GetBounds_ReturnValue_Offset;

	private static bool FindSocketInfo_IsValid;

	private static IntPtr FindSocketInfo_FunctionAddress;

	private static int FindSocketInfo_ParamsSize;

	private static bool FindSocketInfo_InSocketName_IsValid;

	private static FFieldAddress FindSocketInfo_InSocketName_PropertyAddress;

	private static int FindSocketInfo_InSocketName_Offset;

	private static bool FindSocketInfo_OutTransform_IsValid;

	private static FFieldAddress FindSocketInfo_OutTransform_PropertyAddress;

	private static int FindSocketInfo_OutTransform_Offset;

	private static bool FindSocketInfo_OutBoneIndex_IsValid;

	private static FFieldAddress FindSocketInfo_OutBoneIndex_PropertyAddress;

	private static int FindSocketInfo_OutBoneIndex_Offset;

	private static bool FindSocketInfo_OutIndex_IsValid;

	private static FFieldAddress FindSocketInfo_OutIndex_PropertyAddress;

	private static int FindSocketInfo_OutIndex_Offset;

	private static bool FindSocketInfo_ReturnValue_IsValid;

	private static FFieldAddress FindSocketInfo_ReturnValue_PropertyAddress;

	private static int FindSocketInfo_ReturnValue_Offset;

	private static bool FindSocketAndIndex_IsValid;

	private static IntPtr FindSocketAndIndex_FunctionAddress;

	private static int FindSocketAndIndex_ParamsSize;

	private static bool FindSocketAndIndex_InSocketName_IsValid;

	private static FFieldAddress FindSocketAndIndex_InSocketName_PropertyAddress;

	private static int FindSocketAndIndex_InSocketName_Offset;

	private static bool FindSocketAndIndex_OutIndex_IsValid;

	private static FFieldAddress FindSocketAndIndex_OutIndex_PropertyAddress;

	private static int FindSocketAndIndex_OutIndex_Offset;

	private static bool FindSocketAndIndex_ReturnValue_IsValid;

	private static FFieldAddress FindSocketAndIndex_ReturnValue_PropertyAddress;

	private static int FindSocketAndIndex_ReturnValue_Offset;

	private static bool FindSocket_IsValid;

	private static IntPtr FindSocket_FunctionAddress;

	private static int FindSocket_ParamsSize;

	private static bool FindSocket_InSocketName_IsValid;

	private static FFieldAddress FindSocket_InSocketName_PropertyAddress;

	private static int FindSocket_InSocketName_Offset;

	private static bool FindSocket_ReturnValue_IsValid;

	private static FFieldAddress FindSocket_ReturnValue_PropertyAddress;

	private static int FindSocket_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7882468652876293uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:Skeleton")]
	public USkeleton Skeleton
	{
		get
		{
			CheckDestroyed();
			if (!Skeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:Skeleton");
				return null;
			}
			return UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(base.Address, Skeleton_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Skeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:Skeleton");
			}
			else
			{
				UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(base.Address, Skeleton_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:PositiveBoundsExtension")]
	protected FVector PositiveBoundsExtension
	{
		get
		{
			CheckDestroyed();
			if (!PositiveBoundsExtension_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:PositiveBoundsExtension");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PositiveBoundsExtension_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PositiveBoundsExtension_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:PositiveBoundsExtension");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PositiveBoundsExtension_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:NegativeBoundsExtension")]
	protected FVector NegativeBoundsExtension
	{
		get
		{
			CheckDestroyed();
			if (!NegativeBoundsExtension_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:NegativeBoundsExtension");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, NegativeBoundsExtension_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NegativeBoundsExtension_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:NegativeBoundsExtension");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, NegativeBoundsExtension_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599629476357uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:Materials")]
	public TArrayReadWrite<FSkeletalMaterial> Materials
	{
		get
		{
			CheckDestroyed();
			if (!Materials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:Materials");
				return null;
			}
			if (Materials_MarshalerCached == null)
			{
				Materials_MarshalerCached = new TArrayReadWriteMarshaler<FSkeletalMaterial>(1, Materials_PropertyAddress, CachedMarshalingDelegates<FSkeletalMaterial, FSkeletalMaterial>.FromNative, CachedMarshalingDelegates<FSkeletalMaterial, FSkeletalMaterial>.ToNative);
			}
			return Materials_MarshalerCached.FromNative(IntPtr.Add(base.Address, Materials_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7882503012483589uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:LODSettings")]
	public USkeletalMeshLODSettings LODSettings
	{
		get
		{
			CheckDestroyed();
			if (!LODSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:LODSettings");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshLODSettings>.FromNative(IntPtr.Add(base.Address, LODSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LODSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:LODSettings");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshLODSettings>.ToNative(IntPtr.Add(base.Address, LODSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881333707636741uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:DefaultAnimatingRig")]
	public TSoftObject<UObject> DefaultAnimatingRig
	{
		get
		{
			CheckDestroyed();
			if (!DefaultAnimatingRig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:DefaultAnimatingRig");
				return default(TSoftObject<UObject>);
			}
			return TSoftObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, DefaultAnimatingRig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultAnimatingRig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:DefaultAnimatingRig");
			}
			else
			{
				TSoftObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, DefaultAnimatingRig_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7882468652745237uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:PhysicsAsset")]
	public UPhysicsAsset PhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:PhysicsAsset");
				return null;
			}
			return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(base.Address, PhysicsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:PhysicsAsset");
			}
			else
			{
				UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(base.Address, PhysicsAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7882468652745237uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:ShadowPhysicsAsset")]
	public UPhysicsAsset ShadowPhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!ShadowPhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:ShadowPhysicsAsset");
				return null;
			}
			return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(base.Address, ShadowPhysicsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowPhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:ShadowPhysicsAsset");
			}
			else
			{
				UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(base.Address, ShadowPhysicsAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213717uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:NodeMappingData")]
	public TArrayReadOnly<UNodeMappingContainer> NodeMappingData
	{
		get
		{
			CheckDestroyed();
			if (!NodeMappingData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:NodeMappingData");
				return null;
			}
			if (NodeMappingData_MarshalerCached == null)
			{
				NodeMappingData_MarshalerCached = new TArrayReadOnlyMarshaler<UNodeMappingContainer>(1, NodeMappingData_PropertyAddress, CachedMarshalingDelegates<UNodeMappingContainer, UObjectMarshaler<UNodeMappingContainer>>.FromNative, CachedMarshalingDelegates<UNodeMappingContainer, UObjectMarshaler<UNodeMappingContainer>>.ToNative);
			}
			return NodeMappingData_MarshalerCached.FromNative(IntPtr.Add(base.Address, NodeMappingData_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213636uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:MorphTargets")]
	public TArrayReadWrite<UMorphTarget> MorphTargets
	{
		get
		{
			CheckDestroyed();
			if (!MorphTargets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:MorphTargets");
				return null;
			}
			if (MorphTargets_MarshalerCached == null)
			{
				MorphTargets_MarshalerCached = new TArrayReadWriteMarshaler<UMorphTarget>(1, MorphTargets_PropertyAddress, CachedMarshalingDelegates<UMorphTarget, UObjectMarshaler<UMorphTarget>>.FromNative, CachedMarshalingDelegates<UMorphTarget, UObjectMarshaler<UMorphTarget>>.ToNative);
			}
			return MorphTargets_MarshalerCached.FromNative(IntPtr.Add(base.Address, MorphTargets_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:PostProcessAnimBlueprint")]
	public TSubclassOf<UAnimInstance> PostProcessAnimBlueprint
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessAnimBlueprint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:PostProcessAnimBlueprint");
				return default(TSubclassOf<UAnimInstance>);
			}
			return TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(base.Address, PostProcessAnimBlueprint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessAnimBlueprint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:PostProcessAnimBlueprint");
			}
			else
			{
				TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(base.Address, PostProcessAnimBlueprint_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213701uL)]
	[UMetaPath("/Script/Engine.SkeletalMesh:MeshClothingAssets")]
	public TArrayReadWrite<UClothingAssetBase> MeshClothingAssets
	{
		get
		{
			CheckDestroyed();
			if (!MeshClothingAssets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMesh:MeshClothingAssets");
				return null;
			}
			if (MeshClothingAssets_MarshalerCached == null)
			{
				MeshClothingAssets_MarshalerCached = new TArrayReadWriteMarshaler<UClothingAssetBase>(1, MeshClothingAssets_PropertyAddress, CachedMarshalingDelegates<UClothingAssetBase, UObjectMarshaler<UClothingAssetBase>>.FromNative, CachedMarshalingDelegates<UClothingAssetBase, UObjectMarshaler<UClothingAssetBase>>.ToNative);
			}
			return MeshClothingAssets_MarshalerCached.FromNative(IntPtr.Add(base.Address, MeshClothingAssets_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:SetSkeleton")]
	public unsafe void SetSkeleton(USkeleton InSkeleton)
	{
		CheckDestroyed();
		if (!SetSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:SetSkeleton");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, SetSkeleton_InSkeleton_Offset), 0, SetSkeleton_InSkeleton_PropertyAddress.Address, InSkeleton);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkeleton_FunctionAddress, intPtr, SetSkeleton_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:SetMorphTargets")]
	public unsafe void SetMorphTargets(List<UMorphTarget> InMorphTargets)
	{
		CheckDestroyed();
		if (!SetMorphTargets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:SetMorphTargets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMorphTargets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMorphTargets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMorphTarget>(1, SetMorphTargets_InMorphTargets_PropertyAddress, CachedMarshalingDelegates<UMorphTarget, UObjectMarshaler<UMorphTarget>>.FromNative, CachedMarshalingDelegates<UMorphTarget, UObjectMarshaler<UMorphTarget>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMorphTargets_InMorphTargets_Offset), InMorphTargets);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMorphTargets_FunctionAddress, intPtr, SetMorphTargets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMorphTargets_InMorphTargets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:SetMeshClothingAssets")]
	public unsafe void SetMeshClothingAssets(List<UClothingAssetBase> InMeshClothingAssets)
	{
		CheckDestroyed();
		if (!SetMeshClothingAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:SetMeshClothingAssets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshClothingAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshClothingAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UClothingAssetBase>(1, SetMeshClothingAssets_InMeshClothingAssets_PropertyAddress, CachedMarshalingDelegates<UClothingAssetBase, UObjectMarshaler<UClothingAssetBase>>.FromNative, CachedMarshalingDelegates<UClothingAssetBase, UObjectMarshaler<UClothingAssetBase>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMeshClothingAssets_InMeshClothingAssets_Offset), InMeshClothingAssets);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMeshClothingAssets_FunctionAddress, intPtr, SetMeshClothingAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMeshClothingAssets_InMeshClothingAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:SetMaterials")]
	public unsafe void SetMaterials(List<FSkeletalMaterial> InMaterials)
	{
		CheckDestroyed();
		if (!SetMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:SetMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FSkeletalMaterial>(1, SetMaterials_InMaterials_PropertyAddress, CachedMarshalingDelegates<FSkeletalMaterial, FSkeletalMaterial>.FromNative, CachedMarshalingDelegates<FSkeletalMaterial, FSkeletalMaterial>.ToNative).ToNative(IntPtr.Add(intPtr, SetMaterials_InMaterials_Offset), InMaterials);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterials_FunctionAddress, intPtr, SetMaterials_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMaterials_InMaterials_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:SetLODSettings")]
	public unsafe void SetLODSettings(USkeletalMeshLODSettings InLODSettings)
	{
		CheckDestroyed();
		if (!SetLODSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:SetLODSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLODSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLODSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshLODSettings>.ToNative(IntPtr.Add(intPtr, SetLODSettings_InLODSettings_Offset), 0, SetLODSettings_InLODSettings_PropertyAddress.Address, InLODSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLODSettings_FunctionAddress, intPtr, SetLODSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:SetDefaultAnimatingRig")]
	public unsafe void SetDefaultAnimatingRig(TSoftObject<UObject> InAnimatingRig)
	{
		CheckDestroyed();
		if (!SetDefaultAnimatingRig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:SetDefaultAnimatingRig");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultAnimatingRig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultAnimatingRig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDefaultAnimatingRig_InAnimatingRig_PropertyAddress.Address, intPtr);
		TSoftObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetDefaultAnimatingRig_InAnimatingRig_Offset), 0, SetDefaultAnimatingRig_InAnimatingRig_PropertyAddress.Address, InAnimatingRig);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultAnimatingRig_FunctionAddress, intPtr, SetDefaultAnimatingRig_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDefaultAnimatingRig_InAnimatingRig_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:NumSockets")]
	public unsafe int NumSockets()
	{
		CheckDestroyed();
		if (!NumSockets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:NumSockets");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NumSockets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NumSockets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, NumSockets_FunctionAddress, intPtr, NumSockets_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, NumSockets_ReturnValue_Offset), 0, NumSockets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "K2_GetAllMorphTargetNames")]
	[UMetaPath("/Script/Engine.SkeletalMesh:K2_GetAllMorphTargetNames")]
	public unsafe List<string> GetAllMorphTargetNames()
	{
		CheckDestroyed();
		if (!GetAllMorphTargetNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:K2_GetAllMorphTargetNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllMorphTargetNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllMorphTargetNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllMorphTargetNames_FunctionAddress, intPtr, GetAllMorphTargetNames_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetAllMorphTargetNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllMorphTargetNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllMorphTargetNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:IsSectionUsingCloth")]
	public unsafe bool IsSectionUsingCloth(int InSectionIndex, bool bCheckCorrespondingSections = true)
	{
		CheckDestroyed();
		if (!IsSectionUsingCloth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:IsSectionUsingCloth");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSectionUsingCloth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSectionUsingCloth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsSectionUsingCloth_InSectionIndex_Offset), 0, IsSectionUsingCloth_InSectionIndex_PropertyAddress.Address, InSectionIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IsSectionUsingCloth_bCheckCorrespondingSections_Offset), 0, IsSectionUsingCloth_bCheckCorrespondingSections_PropertyAddress.Address, bCheckCorrespondingSections);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSectionUsingCloth_FunctionAddress, intPtr, IsSectionUsingCloth_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSectionUsingCloth_ReturnValue_Offset), 0, IsSectionUsingCloth_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetSocketByIndex")]
	public unsafe USkeletalMeshSocket GetSocketByIndex(int Index)
	{
		CheckDestroyed();
		if (!GetSocketByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetSocketByIndex");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSocketByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSocketByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSocketByIndex_Index_Offset), 0, GetSocketByIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSocketByIndex_FunctionAddress, intPtr, GetSocketByIndex_ParamsSize);
		return UObjectMarshaler<USkeletalMeshSocket>.FromNative(IntPtr.Add(intPtr, GetSocketByIndex_ReturnValue_Offset), 0, GetSocketByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetSkeleton")]
	public unsafe USkeleton GetSkeleton()
	{
		CheckDestroyed();
		if (!GetSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetSkeleton");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSkeleton_FunctionAddress, intPtr, GetSkeleton_ParamsSize);
		return UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(intPtr, GetSkeleton_ReturnValue_Offset), 0, GetSkeleton_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetShadowPhysicsAsset")]
	public unsafe UPhysicsAsset GetShadowPhysicsAsset()
	{
		CheckDestroyed();
		if (!GetShadowPhysicsAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetShadowPhysicsAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShadowPhysicsAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShadowPhysicsAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShadowPhysicsAsset_FunctionAddress, intPtr, GetShadowPhysicsAsset_ParamsSize);
		return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(intPtr, GetShadowPhysicsAsset_ReturnValue_Offset), 0, GetShadowPhysicsAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetPhysicsAsset")]
	public unsafe UPhysicsAsset GetPhysicsAsset()
	{
		CheckDestroyed();
		if (!GetPhysicsAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetPhysicsAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicsAsset_FunctionAddress, intPtr, GetPhysicsAsset_ParamsSize);
		return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(intPtr, GetPhysicsAsset_ReturnValue_Offset), 0, GetPhysicsAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetNodeMappingData")]
	public unsafe List<UNodeMappingContainer> GetNodeMappingData()
	{
		CheckDestroyed();
		if (!GetNodeMappingData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetNodeMappingData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeMappingData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeMappingData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeMappingData_FunctionAddress, intPtr, GetNodeMappingData_ParamsSize);
		List<UNodeMappingContainer> result = new TArrayCopyMarshaler<UNodeMappingContainer>(1, GetNodeMappingData_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UNodeMappingContainer, UObjectMarshaler<UNodeMappingContainer>>.FromNative, CachedMarshalingDelegates<UNodeMappingContainer, UObjectMarshaler<UNodeMappingContainer>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNodeMappingData_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNodeMappingData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetNodeMappingContainer")]
	public unsafe UNodeMappingContainer GetNodeMappingContainer(UBlueprint SourceAsset)
	{
		CheckDestroyed();
		if (!GetNodeMappingContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetNodeMappingContainer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeMappingContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeMappingContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, GetNodeMappingContainer_SourceAsset_Offset), 0, GetNodeMappingContainer_SourceAsset_PropertyAddress.Address, SourceAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeMappingContainer_FunctionAddress, intPtr, GetNodeMappingContainer_ParamsSize);
		return UObjectMarshaler<UNodeMappingContainer>.FromNative(IntPtr.Add(intPtr, GetNodeMappingContainer_ReturnValue_Offset), 0, GetNodeMappingContainer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetMorphTargets")]
	public unsafe List<UMorphTarget> GetMorphTargets()
	{
		CheckDestroyed();
		if (!GetMorphTargets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetMorphTargets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMorphTargets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMorphTargets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMorphTargets_FunctionAddress, intPtr, GetMorphTargets_ParamsSize);
		List<UMorphTarget> result = new TArrayCopyMarshaler<UMorphTarget>(1, GetMorphTargets_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMorphTarget, UObjectMarshaler<UMorphTarget>>.FromNative, CachedMarshalingDelegates<UMorphTarget, UObjectMarshaler<UMorphTarget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMorphTargets_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMorphTargets_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetMeshClothingAssets")]
	public unsafe List<UClothingAssetBase> GetMeshClothingAssets()
	{
		CheckDestroyed();
		if (!GetMeshClothingAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetMeshClothingAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshClothingAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshClothingAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMeshClothingAssets_FunctionAddress, intPtr, GetMeshClothingAssets_ParamsSize);
		List<UClothingAssetBase> result = new TArrayCopyMarshaler<UClothingAssetBase>(1, GetMeshClothingAssets_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UClothingAssetBase, UObjectMarshaler<UClothingAssetBase>>.FromNative, CachedMarshalingDelegates<UClothingAssetBase, UObjectMarshaler<UClothingAssetBase>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMeshClothingAssets_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMeshClothingAssets_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetMaterials")]
	public unsafe List<FSkeletalMaterial> GetMaterials()
	{
		CheckDestroyed();
		if (!GetMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetMaterials");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterials_FunctionAddress, intPtr, GetMaterials_ParamsSize);
		List<FSkeletalMaterial> result = new TArrayCopyMarshaler<FSkeletalMaterial>(1, GetMaterials_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSkeletalMaterial, FSkeletalMaterial>.FromNative, CachedMarshalingDelegates<FSkeletalMaterial, FSkeletalMaterial>.ToNative).FromNative(IntPtr.Add(intPtr, GetMaterials_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMaterials_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetLODSettings")]
	public unsafe USkeletalMeshLODSettings GetLODSettings()
	{
		CheckDestroyed();
		if (!GetLODSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetLODSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLODSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLODSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLODSettings_FunctionAddress, intPtr, GetLODSettings_ParamsSize);
		return UObjectMarshaler<USkeletalMeshLODSettings>.FromNative(IntPtr.Add(intPtr, GetLODSettings_ReturnValue_Offset), 0, GetLODSettings_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetImportedBounds")]
	public unsafe FBoxSphereBounds GetImportedBounds()
	{
		CheckDestroyed();
		if (!GetImportedBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetImportedBounds");
			return default(FBoxSphereBounds);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetImportedBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetImportedBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetImportedBounds_FunctionAddress, intPtr, GetImportedBounds_ParamsSize);
		return BlittableTypeMarshaler<FBoxSphereBounds>.FromNative(IntPtr.Add(intPtr, GetImportedBounds_ReturnValue_Offset), 0, GetImportedBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetDefaultAnimatingRig")]
	public unsafe TSoftObject<UObject> GetDefaultAnimatingRig()
	{
		CheckDestroyed();
		if (!GetDefaultAnimatingRig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetDefaultAnimatingRig");
			return default(TSoftObject<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultAnimatingRig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultAnimatingRig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultAnimatingRig_FunctionAddress, intPtr, GetDefaultAnimatingRig_ParamsSize);
		TSoftObject<UObject> result = TSoftObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetDefaultAnimatingRig_ReturnValue_Offset), 0, GetDefaultAnimatingRig_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDefaultAnimatingRig_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:GetBounds")]
	public unsafe FBoxSphereBounds GetBounds()
	{
		CheckDestroyed();
		if (!GetBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:GetBounds");
			return default(FBoxSphereBounds);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBounds_FunctionAddress, intPtr, GetBounds_ParamsSize);
		return BlittableTypeMarshaler<FBoxSphereBounds>.FromNative(IntPtr.Add(intPtr, GetBounds_ReturnValue_Offset), 0, GetBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:FindSocketInfo")]
	public unsafe USkeletalMeshSocket FindSocketInfo(FName InSocketName, out FTransform OutTransform, out int OutBoneIndex, out int OutIndex)
	{
		CheckDestroyed();
		if (!FindSocketInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:FindSocketInfo");
			OutTransform = default(FTransform);
			OutBoneIndex = 0;
			OutIndex = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindSocketInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindSocketInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindSocketInfo_InSocketName_Offset), 0, FindSocketInfo_InSocketName_PropertyAddress.Address, InSocketName);
		NativeReflection.InitializeValue_InContainer(FindSocketInfo_OutTransform_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindSocketInfo_FunctionAddress, intPtr, FindSocketInfo_ParamsSize);
		OutTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, FindSocketInfo_OutTransform_Offset), 0, FindSocketInfo_OutTransform_PropertyAddress.Address);
		OutBoneIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindSocketInfo_OutBoneIndex_Offset), 0, FindSocketInfo_OutBoneIndex_PropertyAddress.Address);
		OutIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindSocketInfo_OutIndex_Offset), 0, FindSocketInfo_OutIndex_PropertyAddress.Address);
		return UObjectMarshaler<USkeletalMeshSocket>.FromNative(IntPtr.Add(intPtr, FindSocketInfo_ReturnValue_Offset), 0, FindSocketInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:FindSocketAndIndex")]
	public unsafe USkeletalMeshSocket FindSocketAndIndex(FName InSocketName, out int OutIndex)
	{
		CheckDestroyed();
		if (!FindSocketAndIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:FindSocketAndIndex");
			OutIndex = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindSocketAndIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindSocketAndIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindSocketAndIndex_InSocketName_Offset), 0, FindSocketAndIndex_InSocketName_PropertyAddress.Address, InSocketName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindSocketAndIndex_FunctionAddress, intPtr, FindSocketAndIndex_ParamsSize);
		OutIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindSocketAndIndex_OutIndex_Offset), 0, FindSocketAndIndex_OutIndex_PropertyAddress.Address);
		return UObjectMarshaler<USkeletalMeshSocket>.FromNative(IntPtr.Add(intPtr, FindSocketAndIndex_ReturnValue_Offset), 0, FindSocketAndIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkeletalMesh:FindSocket")]
	public unsafe USkeletalMeshSocket FindSocket(FName InSocketName)
	{
		CheckDestroyed();
		if (!FindSocket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMesh:FindSocket");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindSocket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindSocket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindSocket_InSocketName_Offset), 0, FindSocket_InSocketName_PropertyAddress.Address, InSocketName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindSocket_FunctionAddress, intPtr, FindSocket_ParamsSize);
		return UObjectMarshaler<USkeletalMeshSocket>.FromNative(IntPtr.Add(intPtr, FindSocket_ReturnValue_Offset), 0, FindSocket_ReturnValue_PropertyAddress.Address);
	}

	static USkeletalMesh()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USkeletalMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USkeletalMesh));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SkeletalMesh");
		Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Skeleton");
		Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Skeleton", Classes.FObjectProperty);
		PositiveBoundsExtension_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositiveBoundsExtension");
		PositiveBoundsExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositiveBoundsExtension", Classes.FStructProperty);
		NegativeBoundsExtension_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NegativeBoundsExtension");
		NegativeBoundsExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NegativeBoundsExtension", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Materials_PropertyAddress, intPtr, "Materials");
		Materials_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Materials");
		Materials_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Materials", Classes.FArrayProperty);
		LODSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODSettings");
		LODSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODSettings", Classes.FObjectProperty);
		DefaultAnimatingRig_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultAnimatingRig");
		DefaultAnimatingRig_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultAnimatingRig", Classes.FSoftObjectProperty);
		PhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysicsAsset");
		PhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysicsAsset", Classes.FObjectProperty);
		ShadowPhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowPhysicsAsset");
		ShadowPhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowPhysicsAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NodeMappingData_PropertyAddress, intPtr, "NodeMappingData");
		NodeMappingData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NodeMappingData");
		NodeMappingData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NodeMappingData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MorphTargets_PropertyAddress, intPtr, "MorphTargets");
		MorphTargets_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MorphTargets");
		MorphTargets_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MorphTargets", Classes.FArrayProperty);
		PostProcessAnimBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessAnimBlueprint");
		PostProcessAnimBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessAnimBlueprint", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshClothingAssets_PropertyAddress, intPtr, "MeshClothingAssets");
		MeshClothingAssets_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshClothingAssets");
		MeshClothingAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshClothingAssets", Classes.FArrayProperty);
		SetSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSkeleton");
		SetSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkeleton_InSkeleton_PropertyAddress, SetSkeleton_FunctionAddress, "InSkeleton");
		SetSkeleton_InSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeleton_FunctionAddress, "InSkeleton");
		SetSkeleton_InSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeleton_FunctionAddress, "InSkeleton", Classes.FObjectProperty);
		SetSkeleton_IsValid = SetSkeleton_FunctionAddress != IntPtr.Zero && SetSkeleton_InSkeleton_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:SetSkeleton", SetSkeleton_IsValid);
		SetMorphTargets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMorphTargets");
		SetMorphTargets_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMorphTargets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMorphTargets_InMorphTargets_PropertyAddress, SetMorphTargets_FunctionAddress, "InMorphTargets");
		SetMorphTargets_InMorphTargets_Offset = NativeReflectionCached.GetPropertyOffset(SetMorphTargets_FunctionAddress, "InMorphTargets");
		SetMorphTargets_InMorphTargets_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMorphTargets_FunctionAddress, "InMorphTargets", Classes.FArrayProperty);
		SetMorphTargets_IsValid = SetMorphTargets_FunctionAddress != IntPtr.Zero && SetMorphTargets_InMorphTargets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:SetMorphTargets", SetMorphTargets_IsValid);
		SetMeshClothingAssets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMeshClothingAssets");
		SetMeshClothingAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshClothingAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshClothingAssets_InMeshClothingAssets_PropertyAddress, SetMeshClothingAssets_FunctionAddress, "InMeshClothingAssets");
		SetMeshClothingAssets_InMeshClothingAssets_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshClothingAssets_FunctionAddress, "InMeshClothingAssets");
		SetMeshClothingAssets_InMeshClothingAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshClothingAssets_FunctionAddress, "InMeshClothingAssets", Classes.FArrayProperty);
		SetMeshClothingAssets_IsValid = SetMeshClothingAssets_FunctionAddress != IntPtr.Zero && SetMeshClothingAssets_InMeshClothingAssets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:SetMeshClothingAssets", SetMeshClothingAssets_IsValid);
		SetMaterials_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaterials");
		SetMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterials_InMaterials_PropertyAddress, SetMaterials_FunctionAddress, "InMaterials");
		SetMaterials_InMaterials_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterials_FunctionAddress, "InMaterials");
		SetMaterials_InMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterials_FunctionAddress, "InMaterials", Classes.FArrayProperty);
		SetMaterials_IsValid = SetMaterials_FunctionAddress != IntPtr.Zero && SetMaterials_InMaterials_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:SetMaterials", SetMaterials_IsValid);
		SetLODSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLODSettings");
		SetLODSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLODSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLODSettings_InLODSettings_PropertyAddress, SetLODSettings_FunctionAddress, "InLODSettings");
		SetLODSettings_InLODSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetLODSettings_FunctionAddress, "InLODSettings");
		SetLODSettings_InLODSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODSettings_FunctionAddress, "InLODSettings", Classes.FObjectProperty);
		SetLODSettings_IsValid = SetLODSettings_FunctionAddress != IntPtr.Zero && SetLODSettings_InLODSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:SetLODSettings", SetLODSettings_IsValid);
		SetDefaultAnimatingRig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultAnimatingRig");
		SetDefaultAnimatingRig_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultAnimatingRig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultAnimatingRig_InAnimatingRig_PropertyAddress, SetDefaultAnimatingRig_FunctionAddress, "InAnimatingRig");
		SetDefaultAnimatingRig_InAnimatingRig_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultAnimatingRig_FunctionAddress, "InAnimatingRig");
		SetDefaultAnimatingRig_InAnimatingRig_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultAnimatingRig_FunctionAddress, "InAnimatingRig", Classes.FSoftObjectProperty);
		SetDefaultAnimatingRig_IsValid = SetDefaultAnimatingRig_FunctionAddress != IntPtr.Zero && SetDefaultAnimatingRig_InAnimatingRig_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:SetDefaultAnimatingRig", SetDefaultAnimatingRig_IsValid);
		NumSockets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NumSockets");
		NumSockets_ParamsSize = NativeReflection.GetFunctionParamsSize(NumSockets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NumSockets_ReturnValue_PropertyAddress, NumSockets_FunctionAddress, "ReturnValue");
		NumSockets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NumSockets_FunctionAddress, "ReturnValue");
		NumSockets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NumSockets_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		NumSockets_IsValid = NumSockets_FunctionAddress != IntPtr.Zero && NumSockets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:NumSockets", NumSockets_IsValid);
		GetAllMorphTargetNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetAllMorphTargetNames");
		GetAllMorphTargetNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllMorphTargetNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllMorphTargetNames_ReturnValue_PropertyAddress, GetAllMorphTargetNames_FunctionAddress, "ReturnValue");
		GetAllMorphTargetNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllMorphTargetNames_FunctionAddress, "ReturnValue");
		GetAllMorphTargetNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllMorphTargetNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllMorphTargetNames_IsValid = GetAllMorphTargetNames_FunctionAddress != IntPtr.Zero && GetAllMorphTargetNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:K2_GetAllMorphTargetNames", GetAllMorphTargetNames_IsValid);
		IsSectionUsingCloth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSectionUsingCloth");
		IsSectionUsingCloth_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSectionUsingCloth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSectionUsingCloth_InSectionIndex_PropertyAddress, IsSectionUsingCloth_FunctionAddress, "InSectionIndex");
		IsSectionUsingCloth_InSectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(IsSectionUsingCloth_FunctionAddress, "InSectionIndex");
		IsSectionUsingCloth_InSectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSectionUsingCloth_FunctionAddress, "InSectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSectionUsingCloth_bCheckCorrespondingSections_PropertyAddress, IsSectionUsingCloth_FunctionAddress, "bCheckCorrespondingSections");
		IsSectionUsingCloth_bCheckCorrespondingSections_Offset = NativeReflectionCached.GetPropertyOffset(IsSectionUsingCloth_FunctionAddress, "bCheckCorrespondingSections");
		IsSectionUsingCloth_bCheckCorrespondingSections_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSectionUsingCloth_FunctionAddress, "bCheckCorrespondingSections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSectionUsingCloth_ReturnValue_PropertyAddress, IsSectionUsingCloth_FunctionAddress, "ReturnValue");
		IsSectionUsingCloth_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSectionUsingCloth_FunctionAddress, "ReturnValue");
		IsSectionUsingCloth_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSectionUsingCloth_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSectionUsingCloth_IsValid = IsSectionUsingCloth_FunctionAddress != IntPtr.Zero && IsSectionUsingCloth_InSectionIndex_IsValid && IsSectionUsingCloth_bCheckCorrespondingSections_IsValid && IsSectionUsingCloth_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:IsSectionUsingCloth", IsSectionUsingCloth_IsValid);
		GetSocketByIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSocketByIndex");
		GetSocketByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSocketByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSocketByIndex_Index_PropertyAddress, GetSocketByIndex_FunctionAddress, "Index");
		GetSocketByIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketByIndex_FunctionAddress, "Index");
		GetSocketByIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketByIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketByIndex_ReturnValue_PropertyAddress, GetSocketByIndex_FunctionAddress, "ReturnValue");
		GetSocketByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketByIndex_FunctionAddress, "ReturnValue");
		GetSocketByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketByIndex_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSocketByIndex_IsValid = GetSocketByIndex_FunctionAddress != IntPtr.Zero && GetSocketByIndex_Index_IsValid && GetSocketByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetSocketByIndex", GetSocketByIndex_IsValid);
		GetSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSkeleton");
		GetSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeleton_ReturnValue_PropertyAddress, GetSkeleton_FunctionAddress, "ReturnValue");
		GetSkeleton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeleton_FunctionAddress, "ReturnValue");
		GetSkeleton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeleton_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSkeleton_IsValid = GetSkeleton_FunctionAddress != IntPtr.Zero && GetSkeleton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetSkeleton", GetSkeleton_IsValid);
		GetShadowPhysicsAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetShadowPhysicsAsset");
		GetShadowPhysicsAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShadowPhysicsAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShadowPhysicsAsset_ReturnValue_PropertyAddress, GetShadowPhysicsAsset_FunctionAddress, "ReturnValue");
		GetShadowPhysicsAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShadowPhysicsAsset_FunctionAddress, "ReturnValue");
		GetShadowPhysicsAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShadowPhysicsAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetShadowPhysicsAsset_IsValid = GetShadowPhysicsAsset_FunctionAddress != IntPtr.Zero && GetShadowPhysicsAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetShadowPhysicsAsset", GetShadowPhysicsAsset_IsValid);
		GetPhysicsAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicsAsset");
		GetPhysicsAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAsset_ReturnValue_PropertyAddress, GetPhysicsAsset_FunctionAddress, "ReturnValue");
		GetPhysicsAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAsset_FunctionAddress, "ReturnValue");
		GetPhysicsAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPhysicsAsset_IsValid = GetPhysicsAsset_FunctionAddress != IntPtr.Zero && GetPhysicsAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetPhysicsAsset", GetPhysicsAsset_IsValid);
		GetNodeMappingData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeMappingData");
		GetNodeMappingData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeMappingData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeMappingData_ReturnValue_PropertyAddress, GetNodeMappingData_FunctionAddress, "ReturnValue");
		GetNodeMappingData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeMappingData_FunctionAddress, "ReturnValue");
		GetNodeMappingData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeMappingData_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNodeMappingData_IsValid = GetNodeMappingData_FunctionAddress != IntPtr.Zero && GetNodeMappingData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetNodeMappingData", GetNodeMappingData_IsValid);
		GetNodeMappingContainer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeMappingContainer");
		GetNodeMappingContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeMappingContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeMappingContainer_SourceAsset_PropertyAddress, GetNodeMappingContainer_FunctionAddress, "SourceAsset");
		GetNodeMappingContainer_SourceAsset_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeMappingContainer_FunctionAddress, "SourceAsset");
		GetNodeMappingContainer_SourceAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeMappingContainer_FunctionAddress, "SourceAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodeMappingContainer_ReturnValue_PropertyAddress, GetNodeMappingContainer_FunctionAddress, "ReturnValue");
		GetNodeMappingContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeMappingContainer_FunctionAddress, "ReturnValue");
		GetNodeMappingContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeMappingContainer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNodeMappingContainer_IsValid = GetNodeMappingContainer_FunctionAddress != IntPtr.Zero && GetNodeMappingContainer_SourceAsset_IsValid && GetNodeMappingContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetNodeMappingContainer", GetNodeMappingContainer_IsValid);
		GetMorphTargets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMorphTargets");
		GetMorphTargets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMorphTargets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMorphTargets_ReturnValue_PropertyAddress, GetMorphTargets_FunctionAddress, "ReturnValue");
		GetMorphTargets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMorphTargets_FunctionAddress, "ReturnValue");
		GetMorphTargets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMorphTargets_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMorphTargets_IsValid = GetMorphTargets_FunctionAddress != IntPtr.Zero && GetMorphTargets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetMorphTargets", GetMorphTargets_IsValid);
		GetMeshClothingAssets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMeshClothingAssets");
		GetMeshClothingAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshClothingAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshClothingAssets_ReturnValue_PropertyAddress, GetMeshClothingAssets_FunctionAddress, "ReturnValue");
		GetMeshClothingAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshClothingAssets_FunctionAddress, "ReturnValue");
		GetMeshClothingAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshClothingAssets_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMeshClothingAssets_IsValid = GetMeshClothingAssets_FunctionAddress != IntPtr.Zero && GetMeshClothingAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetMeshClothingAssets", GetMeshClothingAssets_IsValid);
		GetMaterials_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaterials");
		GetMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterials_ReturnValue_PropertyAddress, GetMaterials_FunctionAddress, "ReturnValue");
		GetMaterials_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterials_FunctionAddress, "ReturnValue");
		GetMaterials_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterials_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMaterials_IsValid = GetMaterials_FunctionAddress != IntPtr.Zero && GetMaterials_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetMaterials", GetMaterials_IsValid);
		GetLODSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLODSettings");
		GetLODSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLODSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLODSettings_ReturnValue_PropertyAddress, GetLODSettings_FunctionAddress, "ReturnValue");
		GetLODSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLODSettings_FunctionAddress, "ReturnValue");
		GetLODSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODSettings_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLODSettings_IsValid = GetLODSettings_FunctionAddress != IntPtr.Zero && GetLODSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetLODSettings", GetLODSettings_IsValid);
		GetImportedBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetImportedBounds");
		GetImportedBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetImportedBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetImportedBounds_ReturnValue_PropertyAddress, GetImportedBounds_FunctionAddress, "ReturnValue");
		GetImportedBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetImportedBounds_FunctionAddress, "ReturnValue");
		GetImportedBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetImportedBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetImportedBounds_IsValid = GetImportedBounds_FunctionAddress != IntPtr.Zero && GetImportedBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetImportedBounds", GetImportedBounds_IsValid);
		GetDefaultAnimatingRig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultAnimatingRig");
		GetDefaultAnimatingRig_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultAnimatingRig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultAnimatingRig_ReturnValue_PropertyAddress, GetDefaultAnimatingRig_FunctionAddress, "ReturnValue");
		GetDefaultAnimatingRig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultAnimatingRig_FunctionAddress, "ReturnValue");
		GetDefaultAnimatingRig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultAnimatingRig_FunctionAddress, "ReturnValue", Classes.FSoftObjectProperty);
		GetDefaultAnimatingRig_IsValid = GetDefaultAnimatingRig_FunctionAddress != IntPtr.Zero && GetDefaultAnimatingRig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetDefaultAnimatingRig", GetDefaultAnimatingRig_IsValid);
		GetBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBounds");
		GetBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBounds_ReturnValue_PropertyAddress, GetBounds_FunctionAddress, "ReturnValue");
		GetBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBounds_FunctionAddress, "ReturnValue");
		GetBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBounds_IsValid = GetBounds_FunctionAddress != IntPtr.Zero && GetBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:GetBounds", GetBounds_IsValid);
		FindSocketInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindSocketInfo");
		FindSocketInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(FindSocketInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindSocketInfo_InSocketName_PropertyAddress, FindSocketInfo_FunctionAddress, "InSocketName");
		FindSocketInfo_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(FindSocketInfo_FunctionAddress, "InSocketName");
		FindSocketInfo_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocketInfo_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSocketInfo_OutTransform_PropertyAddress, FindSocketInfo_FunctionAddress, "OutTransform");
		FindSocketInfo_OutTransform_Offset = NativeReflectionCached.GetPropertyOffset(FindSocketInfo_FunctionAddress, "OutTransform");
		FindSocketInfo_OutTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocketInfo_FunctionAddress, "OutTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSocketInfo_OutBoneIndex_PropertyAddress, FindSocketInfo_FunctionAddress, "OutBoneIndex");
		FindSocketInfo_OutBoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(FindSocketInfo_FunctionAddress, "OutBoneIndex");
		FindSocketInfo_OutBoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocketInfo_FunctionAddress, "OutBoneIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSocketInfo_OutIndex_PropertyAddress, FindSocketInfo_FunctionAddress, "OutIndex");
		FindSocketInfo_OutIndex_Offset = NativeReflectionCached.GetPropertyOffset(FindSocketInfo_FunctionAddress, "OutIndex");
		FindSocketInfo_OutIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocketInfo_FunctionAddress, "OutIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSocketInfo_ReturnValue_PropertyAddress, FindSocketInfo_FunctionAddress, "ReturnValue");
		FindSocketInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindSocketInfo_FunctionAddress, "ReturnValue");
		FindSocketInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocketInfo_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindSocketInfo_IsValid = FindSocketInfo_FunctionAddress != IntPtr.Zero && FindSocketInfo_InSocketName_IsValid && FindSocketInfo_OutTransform_IsValid && FindSocketInfo_OutBoneIndex_IsValid && FindSocketInfo_OutIndex_IsValid && FindSocketInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:FindSocketInfo", FindSocketInfo_IsValid);
		FindSocketAndIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindSocketAndIndex");
		FindSocketAndIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(FindSocketAndIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindSocketAndIndex_InSocketName_PropertyAddress, FindSocketAndIndex_FunctionAddress, "InSocketName");
		FindSocketAndIndex_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(FindSocketAndIndex_FunctionAddress, "InSocketName");
		FindSocketAndIndex_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocketAndIndex_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSocketAndIndex_OutIndex_PropertyAddress, FindSocketAndIndex_FunctionAddress, "OutIndex");
		FindSocketAndIndex_OutIndex_Offset = NativeReflectionCached.GetPropertyOffset(FindSocketAndIndex_FunctionAddress, "OutIndex");
		FindSocketAndIndex_OutIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocketAndIndex_FunctionAddress, "OutIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSocketAndIndex_ReturnValue_PropertyAddress, FindSocketAndIndex_FunctionAddress, "ReturnValue");
		FindSocketAndIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindSocketAndIndex_FunctionAddress, "ReturnValue");
		FindSocketAndIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocketAndIndex_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindSocketAndIndex_IsValid = FindSocketAndIndex_FunctionAddress != IntPtr.Zero && FindSocketAndIndex_InSocketName_IsValid && FindSocketAndIndex_OutIndex_IsValid && FindSocketAndIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:FindSocketAndIndex", FindSocketAndIndex_IsValid);
		FindSocket_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindSocket");
		FindSocket_ParamsSize = NativeReflection.GetFunctionParamsSize(FindSocket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindSocket_InSocketName_PropertyAddress, FindSocket_FunctionAddress, "InSocketName");
		FindSocket_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(FindSocket_FunctionAddress, "InSocketName");
		FindSocket_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocket_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSocket_ReturnValue_PropertyAddress, FindSocket_FunctionAddress, "ReturnValue");
		FindSocket_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindSocket_FunctionAddress, "ReturnValue");
		FindSocket_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSocket_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindSocket_IsValid = FindSocket_FunctionAddress != IntPtr.Zero && FindSocket_InSocketName_IsValid && FindSocket_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMesh:FindSocket", FindSocket_IsValid);
	}
}
