using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.Material", "Engine", UnrealModuleType.Engine)]
public class UMaterial : UMaterialInterface
{
	private static bool MaterialDomain_IsValid;

	private static FFieldAddress MaterialDomain_PropertyAddress;

	private static int MaterialDomain_Offset;

	private static bool BlendMode_IsValid;

	private static FFieldAddress BlendMode_PropertyAddress;

	private static int BlendMode_Offset;

	private static bool MaterialDecalResponse_IsValid;

	private static FFieldAddress MaterialDecalResponse_PropertyAddress;

	private static int MaterialDecalResponse_Offset;

	private static bool UseEmissiveForDynamicAreaLighting_IsValid;

	private static FFieldAddress UseEmissiveForDynamicAreaLighting_PropertyAddress;

	private static int UseEmissiveForDynamicAreaLighting_Offset;

	private static bool UsedWithSkeletalMesh_IsValid;

	private static FFieldAddress UsedWithSkeletalMesh_PropertyAddress;

	private static int UsedWithSkeletalMesh_Offset;

	private static bool UsedWithEditorCompositing_IsValid;

	private static FFieldAddress UsedWithEditorCompositing_PropertyAddress;

	private static int UsedWithEditorCompositing_Offset;

	private static bool UsedWithParticleSprites_IsValid;

	private static FFieldAddress UsedWithParticleSprites_PropertyAddress;

	private static int UsedWithParticleSprites_Offset;

	private static bool UsedWithBeamTrails_IsValid;

	private static FFieldAddress UsedWithBeamTrails_PropertyAddress;

	private static int UsedWithBeamTrails_Offset;

	private static bool UsedWithMeshParticles_IsValid;

	private static FFieldAddress UsedWithMeshParticles_PropertyAddress;

	private static int UsedWithMeshParticles_Offset;

	private static bool UsedWithNiagaraSprites_IsValid;

	private static FFieldAddress UsedWithNiagaraSprites_PropertyAddress;

	private static int UsedWithNiagaraSprites_Offset;

	private static bool UsedWithNiagaraRibbons_IsValid;

	private static FFieldAddress UsedWithNiagaraRibbons_PropertyAddress;

	private static int UsedWithNiagaraRibbons_Offset;

	private static bool UsedWithNiagaraMeshParticles_IsValid;

	private static FFieldAddress UsedWithNiagaraMeshParticles_PropertyAddress;

	private static int UsedWithNiagaraMeshParticles_Offset;

	private static bool UsedWithGeometryCache_IsValid;

	private static FFieldAddress UsedWithGeometryCache_PropertyAddress;

	private static int UsedWithGeometryCache_Offset;

	private static bool UsedWithStaticLighting_IsValid;

	private static FFieldAddress UsedWithStaticLighting_PropertyAddress;

	private static int UsedWithStaticLighting_Offset;

	private static bool UsedWithMorphTargets_IsValid;

	private static FFieldAddress UsedWithMorphTargets_PropertyAddress;

	private static int UsedWithMorphTargets_Offset;

	private static bool UsedWithSplineMeshes_IsValid;

	private static FFieldAddress UsedWithSplineMeshes_PropertyAddress;

	private static int UsedWithSplineMeshes_Offset;

	private static bool UsedWithInstancedStaticMeshes_IsValid;

	private static FFieldAddress UsedWithInstancedStaticMeshes_PropertyAddress;

	private static int UsedWithInstancedStaticMeshes_Offset;

	private static bool UsedWithGeometryCollections_IsValid;

	private static FFieldAddress UsedWithGeometryCollections_PropertyAddress;

	private static int UsedWithGeometryCollections_Offset;

	private static bool UsedWithClothing_IsValid;

	private static FFieldAddress UsedWithClothing_PropertyAddress;

	private static int UsedWithClothing_Offset;

	private static bool UsedWithWater_IsValid;

	private static FFieldAddress UsedWithWater_PropertyAddress;

	private static int UsedWithWater_Offset;

	private static bool UsedWithWaterCaustics_IsValid;

	private static FFieldAddress UsedWithWaterCaustics_PropertyAddress;

	private static int UsedWithWaterCaustics_Offset;

	private static bool UsedWithHairStrands_IsValid;

	private static FFieldAddress UsedWithHairStrands_PropertyAddress;

	private static int UsedWithHairStrands_Offset;

	private static bool UsedWithLidarPointCloud_IsValid;

	private static FFieldAddress UsedWithLidarPointCloud_PropertyAddress;

	private static int UsedWithLidarPointCloud_Offset;

	private static bool UsedWithReorientedNiagara_IsValid;

	private static FFieldAddress UsedWithReorientedNiagara_PropertyAddress;

	private static int UsedWithReorientedNiagara_Offset;

	private static bool UsedWithVirtualHeightfieldMesh_IsValid;

	private static FFieldAddress UsedWithVirtualHeightfieldMesh_PropertyAddress;

	private static int UsedWithVirtualHeightfieldMesh_Offset;

	private static bool UsedWithNanite_IsValid;

	private static FFieldAddress UsedWithNanite_PropertyAddress;

	private static int UsedWithNanite_Offset;

	private static bool UsedWithVolumetricCloud_IsValid;

	private static FFieldAddress UsedWithVolumetricCloud_PropertyAddress;

	private static int UsedWithVolumetricCloud_Offset;

	private static bool UsedWithHeterogeneousVolumes_IsValid;

	private static FFieldAddress UsedWithHeterogeneousVolumes_PropertyAddress;

	private static int UsedWithHeterogeneousVolumes_Offset;

	private static bool AutomaticallySetUsageInEditor_IsValid;

	private static FFieldAddress AutomaticallySetUsageInEditor_PropertyAddress;

	private static int AutomaticallySetUsageInEditor_Offset;

	private static bool FullyRough_IsValid;

	private static FFieldAddress FullyRough_PropertyAddress;

	private static int FullyRough_Offset;

	private static bool FloatPrecisionMode_IsValid;

	private static FFieldAddress FloatPrecisionMode_PropertyAddress;

	private static int FloatPrecisionMode_Offset;

	private static bool UseLightmapDirectionality_IsValid;

	private static FFieldAddress UseLightmapDirectionality_PropertyAddress;

	private static int UseLightmapDirectionality_Offset;

	private static bool MobileEnableHighQualityBRDF_IsValid;

	private static FFieldAddress MobileEnableHighQualityBRDF_PropertyAddress;

	private static int MobileEnableHighQualityBRDF_Offset;

	private static bool UseAlphaToCoverage_IsValid;

	private static FFieldAddress UseAlphaToCoverage_PropertyAddress;

	private static int UseAlphaToCoverage_Offset;

	private static bool ForwardRenderUsePreintegratedGFForSimpleIBL_IsValid;

	private static FFieldAddress ForwardRenderUsePreintegratedGFForSimpleIBL_PropertyAddress;

	private static int ForwardRenderUsePreintegratedGFForSimpleIBL_Offset;

	private static bool UseHQForwardReflections_IsValid;

	private static FFieldAddress UseHQForwardReflections_PropertyAddress;

	private static int UseHQForwardReflections_Offset;

	private static bool ForwardBlendsSkyLightCubemaps_IsValid;

	private static FFieldAddress ForwardBlendsSkyLightCubemaps_PropertyAddress;

	private static int ForwardBlendsSkyLightCubemaps_Offset;

	private static bool UsePlanarForwardReflections_IsValid;

	private static FFieldAddress UsePlanarForwardReflections_PropertyAddress;

	private static int UsePlanarForwardReflections_Offset;

	private static bool NormalCurvatureToRoughness_IsValid;

	private static FFieldAddress NormalCurvatureToRoughness_PropertyAddress;

	private static int NormalCurvatureToRoughness_Offset;

	private static bool BlendableLocation_IsValid;

	private static FFieldAddress BlendableLocation_PropertyAddress;

	private static int BlendableLocation_Offset;

	private static bool BlendableOutputAlpha_IsValid;

	private static FFieldAddress BlendableOutputAlpha_PropertyAddress;

	private static int BlendableOutputAlpha_Offset;

	private static bool BlendablePriority_IsValid;

	private static int BlendablePriority_Offset;

	private static bool IsBlendable_IsValid;

	private static FFieldAddress IsBlendable_PropertyAddress;

	private static int IsBlendable_Offset;

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.Material:MaterialDomain")]
	public EMaterialDomain MaterialDomain
	{
		get
		{
			CheckDestroyed();
			if (!MaterialDomain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:MaterialDomain");
				return EMaterialDomain.MD_Surface;
			}
			return EnumMarshaler<EMaterialDomain>.FromNative(IntPtr.Add(base.Address, MaterialDomain_Offset), 0, MaterialDomain_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MaterialDomain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:MaterialDomain");
			}
			else
			{
				EnumMarshaler<EMaterialDomain>.ToNative(IntPtr.Add(base.Address, MaterialDomain_Offset), 0, MaterialDomain_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.Material:BlendMode")]
	public EBlendMode BlendMode
	{
		get
		{
			CheckDestroyed();
			if (!BlendMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:BlendMode");
				return EBlendMode.BLEND_Opaque;
			}
			return EnumMarshaler<EBlendMode>.FromNative(IntPtr.Add(base.Address, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:BlendMode");
			}
			else
			{
				EnumMarshaler<EBlendMode>.ToNative(IntPtr.Add(base.Address, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760966792413717uL)]
	[UMetaPath("/Script/Engine.Material:MaterialDecalResponse")]
	public EMaterialDecalResponse MaterialDecalResponse
	{
		get
		{
			CheckDestroyed();
			if (!MaterialDecalResponse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:MaterialDecalResponse");
				return EMaterialDecalResponse.MDR_None;
			}
			return EnumMarshaler<EMaterialDecalResponse>.FromNative(IntPtr.Add(base.Address, MaterialDecalResponse_Offset), 0, MaterialDecalResponse_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MaterialDecalResponse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:MaterialDecalResponse");
			}
			else
			{
				EnumMarshaler<EMaterialDecalResponse>.ToNative(IntPtr.Add(base.Address, MaterialDecalResponse_Offset), 0, MaterialDecalResponse_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.Material:bUseEmissiveForDynamicAreaLighting")]
	public bool UseEmissiveForDynamicAreaLighting
	{
		get
		{
			CheckDestroyed();
			if (!UseEmissiveForDynamicAreaLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUseEmissiveForDynamicAreaLighting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseEmissiveForDynamicAreaLighting_Offset), 0, UseEmissiveForDynamicAreaLighting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseEmissiveForDynamicAreaLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUseEmissiveForDynamicAreaLighting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseEmissiveForDynamicAreaLighting_Offset), 0, UseEmissiveForDynamicAreaLighting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithSkeletalMesh")]
	public bool UsedWithSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithSkeletalMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithSkeletalMesh_Offset), 0, UsedWithSkeletalMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithSkeletalMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithSkeletalMesh_Offset), 0, UsedWithSkeletalMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithEditorCompositing")]
	public bool UsedWithEditorCompositing
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithEditorCompositing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithEditorCompositing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithEditorCompositing_Offset), 0, UsedWithEditorCompositing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithEditorCompositing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithEditorCompositing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithEditorCompositing_Offset), 0, UsedWithEditorCompositing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithParticleSprites")]
	public bool UsedWithParticleSprites
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithParticleSprites_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithParticleSprites");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithParticleSprites_Offset), 0, UsedWithParticleSprites_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithParticleSprites_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithParticleSprites");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithParticleSprites_Offset), 0, UsedWithParticleSprites_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithBeamTrails")]
	public bool UsedWithBeamTrails
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithBeamTrails_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithBeamTrails");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithBeamTrails_Offset), 0, UsedWithBeamTrails_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithBeamTrails_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithBeamTrails");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithBeamTrails_Offset), 0, UsedWithBeamTrails_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithMeshParticles")]
	public bool UsedWithMeshParticles
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithMeshParticles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithMeshParticles");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithMeshParticles_Offset), 0, UsedWithMeshParticles_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithMeshParticles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithMeshParticles");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithMeshParticles_Offset), 0, UsedWithMeshParticles_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithNiagaraSprites")]
	public bool UsedWithNiagaraSprites
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithNiagaraSprites_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithNiagaraSprites");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithNiagaraSprites_Offset), 0, UsedWithNiagaraSprites_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithNiagaraSprites_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithNiagaraSprites");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithNiagaraSprites_Offset), 0, UsedWithNiagaraSprites_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithNiagaraRibbons")]
	public bool UsedWithNiagaraRibbons
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithNiagaraRibbons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithNiagaraRibbons");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithNiagaraRibbons_Offset), 0, UsedWithNiagaraRibbons_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithNiagaraRibbons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithNiagaraRibbons");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithNiagaraRibbons_Offset), 0, UsedWithNiagaraRibbons_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithNiagaraMeshParticles")]
	public bool UsedWithNiagaraMeshParticles
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithNiagaraMeshParticles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithNiagaraMeshParticles");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithNiagaraMeshParticles_Offset), 0, UsedWithNiagaraMeshParticles_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithNiagaraMeshParticles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithNiagaraMeshParticles");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithNiagaraMeshParticles_Offset), 0, UsedWithNiagaraMeshParticles_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithGeometryCache")]
	public bool UsedWithGeometryCache
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithGeometryCache");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithGeometryCache_Offset), 0, UsedWithGeometryCache_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithGeometryCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithGeometryCache");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithGeometryCache_Offset), 0, UsedWithGeometryCache_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithStaticLighting")]
	public bool UsedWithStaticLighting
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithStaticLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithStaticLighting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithStaticLighting_Offset), 0, UsedWithStaticLighting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithStaticLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithStaticLighting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithStaticLighting_Offset), 0, UsedWithStaticLighting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithMorphTargets")]
	public bool UsedWithMorphTargets
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithMorphTargets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithMorphTargets");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithMorphTargets_Offset), 0, UsedWithMorphTargets_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithMorphTargets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithMorphTargets");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithMorphTargets_Offset), 0, UsedWithMorphTargets_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithSplineMeshes")]
	public bool UsedWithSplineMeshes
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithSplineMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithSplineMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithSplineMeshes_Offset), 0, UsedWithSplineMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithSplineMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithSplineMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithSplineMeshes_Offset), 0, UsedWithSplineMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithInstancedStaticMeshes")]
	public bool UsedWithInstancedStaticMeshes
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithInstancedStaticMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithInstancedStaticMeshes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithInstancedStaticMeshes_Offset), 0, UsedWithInstancedStaticMeshes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithInstancedStaticMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithInstancedStaticMeshes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithInstancedStaticMeshes_Offset), 0, UsedWithInstancedStaticMeshes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithGeometryCollections")]
	public bool UsedWithGeometryCollections
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithGeometryCollections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithGeometryCollections");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithGeometryCollections_Offset), 0, UsedWithGeometryCollections_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithGeometryCollections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithGeometryCollections");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithGeometryCollections_Offset), 0, UsedWithGeometryCollections_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithClothing")]
	public bool UsedWithClothing
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithClothing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithClothing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithClothing_Offset), 0, UsedWithClothing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithClothing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithClothing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithClothing_Offset), 0, UsedWithClothing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithWater")]
	public bool UsedWithWater
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithWater_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithWater");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithWater_Offset), 0, UsedWithWater_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithWater_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithWater");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithWater_Offset), 0, UsedWithWater_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithWaterCaustics")]
	public bool UsedWithWaterCaustics
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithWaterCaustics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithWaterCaustics");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithWaterCaustics_Offset), 0, UsedWithWaterCaustics_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithWaterCaustics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithWaterCaustics");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithWaterCaustics_Offset), 0, UsedWithWaterCaustics_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithHairStrands")]
	public bool UsedWithHairStrands
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithHairStrands_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithHairStrands");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithHairStrands_Offset), 0, UsedWithHairStrands_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithHairStrands_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithHairStrands");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithHairStrands_Offset), 0, UsedWithHairStrands_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithLidarPointCloud")]
	public bool UsedWithLidarPointCloud
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithLidarPointCloud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithLidarPointCloud");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithLidarPointCloud_Offset), 0, UsedWithLidarPointCloud_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithLidarPointCloud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithLidarPointCloud");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithLidarPointCloud_Offset), 0, UsedWithLidarPointCloud_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithReorientedNiagara")]
	public bool UsedWithReorientedNiagara
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithReorientedNiagara_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithReorientedNiagara");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithReorientedNiagara_Offset), 0, UsedWithReorientedNiagara_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithReorientedNiagara_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithReorientedNiagara");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithReorientedNiagara_Offset), 0, UsedWithReorientedNiagara_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithVirtualHeightfieldMesh")]
	public bool UsedWithVirtualHeightfieldMesh
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithVirtualHeightfieldMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithVirtualHeightfieldMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithVirtualHeightfieldMesh_Offset), 0, UsedWithVirtualHeightfieldMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithVirtualHeightfieldMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithVirtualHeightfieldMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithVirtualHeightfieldMesh_Offset), 0, UsedWithVirtualHeightfieldMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithNanite")]
	public bool UsedWithNanite
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithNanite");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithNanite_Offset), 0, UsedWithNanite_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithNanite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithNanite");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithNanite_Offset), 0, UsedWithNanite_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithVolumetricCloud")]
	public bool UsedWithVolumetricCloud
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithVolumetricCloud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithVolumetricCloud");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithVolumetricCloud_Offset), 0, UsedWithVolumetricCloud_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithVolumetricCloud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithVolumetricCloud");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithVolumetricCloud_Offset), 0, UsedWithVolumetricCloud_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsedWithHeterogeneousVolumes")]
	public bool UsedWithHeterogeneousVolumes
	{
		get
		{
			CheckDestroyed();
			if (!UsedWithHeterogeneousVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithHeterogeneousVolumes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsedWithHeterogeneousVolumes_Offset), 0, UsedWithHeterogeneousVolumes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsedWithHeterogeneousVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsedWithHeterogeneousVolumes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsedWithHeterogeneousVolumes_Offset), 0, UsedWithHeterogeneousVolumes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.Material:bAutomaticallySetUsageInEditor")]
	public bool AutomaticallySetUsageInEditor
	{
		get
		{
			CheckDestroyed();
			if (!AutomaticallySetUsageInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bAutomaticallySetUsageInEditor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutomaticallySetUsageInEditor_Offset), 0, AutomaticallySetUsageInEditor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutomaticallySetUsageInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bAutomaticallySetUsageInEditor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutomaticallySetUsageInEditor_Offset), 0, AutomaticallySetUsageInEditor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.Material:bFullyRough")]
	public bool FullyRough
	{
		get
		{
			CheckDestroyed();
			if (!FullyRough_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bFullyRough");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FullyRough_Offset), 0, FullyRough_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FullyRough_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bFullyRough");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FullyRough_Offset), 0, FullyRough_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.Material:FloatPrecisionMode")]
	public EMaterialFloatPrecisionMode FloatPrecisionMode
	{
		get
		{
			CheckDestroyed();
			if (!FloatPrecisionMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:FloatPrecisionMode");
				return EMaterialFloatPrecisionMode.MFPM_Default;
			}
			return EnumMarshaler<EMaterialFloatPrecisionMode>.FromNative(IntPtr.Add(base.Address, FloatPrecisionMode_Offset), 0, FloatPrecisionMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FloatPrecisionMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:FloatPrecisionMode");
			}
			else
			{
				EnumMarshaler<EMaterialFloatPrecisionMode>.ToNative(IntPtr.Add(base.Address, FloatPrecisionMode_Offset), 0, FloatPrecisionMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUseLightmapDirectionality")]
	public bool UseLightmapDirectionality
	{
		get
		{
			CheckDestroyed();
			if (!UseLightmapDirectionality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUseLightmapDirectionality");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseLightmapDirectionality_Offset), 0, UseLightmapDirectionality_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseLightmapDirectionality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUseLightmapDirectionality");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseLightmapDirectionality_Offset), 0, UseLightmapDirectionality_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bMobileEnableHighQualityBRDF")]
	public bool MobileEnableHighQualityBRDF
	{
		get
		{
			CheckDestroyed();
			if (!MobileEnableHighQualityBRDF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bMobileEnableHighQualityBRDF");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MobileEnableHighQualityBRDF_Offset), 0, MobileEnableHighQualityBRDF_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MobileEnableHighQualityBRDF_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bMobileEnableHighQualityBRDF");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MobileEnableHighQualityBRDF_Offset), 0, MobileEnableHighQualityBRDF_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.Material:bUseAlphaToCoverage")]
	public bool UseAlphaToCoverage
	{
		get
		{
			CheckDestroyed();
			if (!UseAlphaToCoverage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUseAlphaToCoverage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAlphaToCoverage_Offset), 0, UseAlphaToCoverage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAlphaToCoverage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUseAlphaToCoverage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAlphaToCoverage_Offset), 0, UseAlphaToCoverage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bForwardRenderUsePreintegratedGFForSimpleIBL")]
	public bool ForwardRenderUsePreintegratedGFForSimpleIBL
	{
		get
		{
			CheckDestroyed();
			if (!ForwardRenderUsePreintegratedGFForSimpleIBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bForwardRenderUsePreintegratedGFForSimpleIBL");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForwardRenderUsePreintegratedGFForSimpleIBL_Offset), 0, ForwardRenderUsePreintegratedGFForSimpleIBL_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForwardRenderUsePreintegratedGFForSimpleIBL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bForwardRenderUsePreintegratedGFForSimpleIBL");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForwardRenderUsePreintegratedGFForSimpleIBL_Offset), 0, ForwardRenderUsePreintegratedGFForSimpleIBL_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUseHQForwardReflections")]
	public bool UseHQForwardReflections
	{
		get
		{
			CheckDestroyed();
			if (!UseHQForwardReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUseHQForwardReflections");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseHQForwardReflections_Offset), 0, UseHQForwardReflections_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseHQForwardReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUseHQForwardReflections");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseHQForwardReflections_Offset), 0, UseHQForwardReflections_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bForwardBlendsSkyLightCubemaps")]
	public bool ForwardBlendsSkyLightCubemaps
	{
		get
		{
			CheckDestroyed();
			if (!ForwardBlendsSkyLightCubemaps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bForwardBlendsSkyLightCubemaps");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForwardBlendsSkyLightCubemaps_Offset), 0, ForwardBlendsSkyLightCubemaps_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForwardBlendsSkyLightCubemaps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bForwardBlendsSkyLightCubemaps");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForwardBlendsSkyLightCubemaps_Offset), 0, ForwardBlendsSkyLightCubemaps_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Material:bUsePlanarForwardReflections")]
	public bool UsePlanarForwardReflections
	{
		get
		{
			CheckDestroyed();
			if (!UsePlanarForwardReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsePlanarForwardReflections");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsePlanarForwardReflections_Offset), 0, UsePlanarForwardReflections_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsePlanarForwardReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bUsePlanarForwardReflections");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsePlanarForwardReflections_Offset), 0, UsePlanarForwardReflections_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.Material:bNormalCurvatureToRoughness")]
	public bool NormalCurvatureToRoughness
	{
		get
		{
			CheckDestroyed();
			if (!NormalCurvatureToRoughness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bNormalCurvatureToRoughness");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NormalCurvatureToRoughness_Offset), 0, NormalCurvatureToRoughness_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NormalCurvatureToRoughness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bNormalCurvatureToRoughness");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NormalCurvatureToRoughness_Offset), 0, NormalCurvatureToRoughness_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.Material:BlendableLocation")]
	public EBlendableLocation BlendableLocation
	{
		get
		{
			CheckDestroyed();
			if (!BlendableLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:BlendableLocation");
				return EBlendableLocation.BL_AfterTonemapping;
			}
			return EnumMarshaler<EBlendableLocation>.FromNative(IntPtr.Add(base.Address, BlendableLocation_Offset), 0, BlendableLocation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendableLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:BlendableLocation");
			}
			else
			{
				EnumMarshaler<EBlendableLocation>.ToNative(IntPtr.Add(base.Address, BlendableLocation_Offset), 0, BlendableLocation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.Material:BlendableOutputAlpha")]
	public bool BlendableOutputAlpha
	{
		get
		{
			CheckDestroyed();
			if (!BlendableOutputAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:BlendableOutputAlpha");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BlendableOutputAlpha_Offset), 0, BlendableOutputAlpha_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendableOutputAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:BlendableOutputAlpha");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BlendableOutputAlpha_Offset), 0, BlendableOutputAlpha_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.Material:BlendablePriority")]
	public int BlendablePriority
	{
		get
		{
			CheckDestroyed();
			if (!BlendablePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:BlendablePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BlendablePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendablePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:BlendablePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BlendablePriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.Material:bIsBlendable")]
	public bool IsBlendable
	{
		get
		{
			CheckDestroyed();
			if (!IsBlendable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bIsBlendable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsBlendable_Offset), 0, IsBlendable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsBlendable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Material:bIsBlendable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsBlendable_Offset), 0, IsBlendable_PropertyAddress.Address, value);
			}
		}
	}

	static UMaterial()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterial));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.Material");
		NativeReflectionCached.GetPropertyRef(ref MaterialDomain_PropertyAddress, unrealStruct, "MaterialDomain");
		MaterialDomain_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialDomain");
		MaterialDomain_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialDomain", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendMode_PropertyAddress, unrealStruct, "BlendMode");
		BlendMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendMode");
		BlendMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MaterialDecalResponse_PropertyAddress, unrealStruct, "MaterialDecalResponse");
		MaterialDecalResponse_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialDecalResponse");
		MaterialDecalResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialDecalResponse", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref UseEmissiveForDynamicAreaLighting_PropertyAddress, unrealStruct, "bUseEmissiveForDynamicAreaLighting");
		UseEmissiveForDynamicAreaLighting_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseEmissiveForDynamicAreaLighting");
		UseEmissiveForDynamicAreaLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseEmissiveForDynamicAreaLighting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithSkeletalMesh_PropertyAddress, unrealStruct, "bUsedWithSkeletalMesh");
		UsedWithSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithSkeletalMesh");
		UsedWithSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithSkeletalMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithEditorCompositing_PropertyAddress, unrealStruct, "bUsedWithEditorCompositing");
		UsedWithEditorCompositing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithEditorCompositing");
		UsedWithEditorCompositing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithEditorCompositing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithParticleSprites_PropertyAddress, unrealStruct, "bUsedWithParticleSprites");
		UsedWithParticleSprites_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithParticleSprites");
		UsedWithParticleSprites_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithParticleSprites", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithBeamTrails_PropertyAddress, unrealStruct, "bUsedWithBeamTrails");
		UsedWithBeamTrails_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithBeamTrails");
		UsedWithBeamTrails_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithBeamTrails", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithMeshParticles_PropertyAddress, unrealStruct, "bUsedWithMeshParticles");
		UsedWithMeshParticles_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithMeshParticles");
		UsedWithMeshParticles_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithMeshParticles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithNiagaraSprites_PropertyAddress, unrealStruct, "bUsedWithNiagaraSprites");
		UsedWithNiagaraSprites_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithNiagaraSprites");
		UsedWithNiagaraSprites_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithNiagaraSprites", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithNiagaraRibbons_PropertyAddress, unrealStruct, "bUsedWithNiagaraRibbons");
		UsedWithNiagaraRibbons_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithNiagaraRibbons");
		UsedWithNiagaraRibbons_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithNiagaraRibbons", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithNiagaraMeshParticles_PropertyAddress, unrealStruct, "bUsedWithNiagaraMeshParticles");
		UsedWithNiagaraMeshParticles_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithNiagaraMeshParticles");
		UsedWithNiagaraMeshParticles_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithNiagaraMeshParticles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithGeometryCache_PropertyAddress, unrealStruct, "bUsedWithGeometryCache");
		UsedWithGeometryCache_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithGeometryCache");
		UsedWithGeometryCache_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithGeometryCache", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithStaticLighting_PropertyAddress, unrealStruct, "bUsedWithStaticLighting");
		UsedWithStaticLighting_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithStaticLighting");
		UsedWithStaticLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithStaticLighting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithMorphTargets_PropertyAddress, unrealStruct, "bUsedWithMorphTargets");
		UsedWithMorphTargets_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithMorphTargets");
		UsedWithMorphTargets_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithMorphTargets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithSplineMeshes_PropertyAddress, unrealStruct, "bUsedWithSplineMeshes");
		UsedWithSplineMeshes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithSplineMeshes");
		UsedWithSplineMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithSplineMeshes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithInstancedStaticMeshes_PropertyAddress, unrealStruct, "bUsedWithInstancedStaticMeshes");
		UsedWithInstancedStaticMeshes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithInstancedStaticMeshes");
		UsedWithInstancedStaticMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithInstancedStaticMeshes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithGeometryCollections_PropertyAddress, unrealStruct, "bUsedWithGeometryCollections");
		UsedWithGeometryCollections_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithGeometryCollections");
		UsedWithGeometryCollections_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithGeometryCollections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithClothing_PropertyAddress, unrealStruct, "bUsedWithClothing");
		UsedWithClothing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithClothing");
		UsedWithClothing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithClothing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithWater_PropertyAddress, unrealStruct, "bUsedWithWater");
		UsedWithWater_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithWater");
		UsedWithWater_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithWater", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithWaterCaustics_PropertyAddress, unrealStruct, "bUsedWithWaterCaustics");
		UsedWithWaterCaustics_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithWaterCaustics");
		UsedWithWaterCaustics_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithWaterCaustics", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithHairStrands_PropertyAddress, unrealStruct, "bUsedWithHairStrands");
		UsedWithHairStrands_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithHairStrands");
		UsedWithHairStrands_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithHairStrands", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithLidarPointCloud_PropertyAddress, unrealStruct, "bUsedWithLidarPointCloud");
		UsedWithLidarPointCloud_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithLidarPointCloud");
		UsedWithLidarPointCloud_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithLidarPointCloud", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithReorientedNiagara_PropertyAddress, unrealStruct, "bUsedWithReorientedNiagara");
		UsedWithReorientedNiagara_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithReorientedNiagara");
		UsedWithReorientedNiagara_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithReorientedNiagara", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithVirtualHeightfieldMesh_PropertyAddress, unrealStruct, "bUsedWithVirtualHeightfieldMesh");
		UsedWithVirtualHeightfieldMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithVirtualHeightfieldMesh");
		UsedWithVirtualHeightfieldMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithVirtualHeightfieldMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithNanite_PropertyAddress, unrealStruct, "bUsedWithNanite");
		UsedWithNanite_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithNanite");
		UsedWithNanite_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithNanite", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithVolumetricCloud_PropertyAddress, unrealStruct, "bUsedWithVolumetricCloud");
		UsedWithVolumetricCloud_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithVolumetricCloud");
		UsedWithVolumetricCloud_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithVolumetricCloud", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsedWithHeterogeneousVolumes_PropertyAddress, unrealStruct, "bUsedWithHeterogeneousVolumes");
		UsedWithHeterogeneousVolumes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsedWithHeterogeneousVolumes");
		UsedWithHeterogeneousVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsedWithHeterogeneousVolumes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutomaticallySetUsageInEditor_PropertyAddress, unrealStruct, "bAutomaticallySetUsageInEditor");
		AutomaticallySetUsageInEditor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAutomaticallySetUsageInEditor");
		AutomaticallySetUsageInEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAutomaticallySetUsageInEditor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FullyRough_PropertyAddress, unrealStruct, "bFullyRough");
		FullyRough_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bFullyRough");
		FullyRough_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bFullyRough", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FloatPrecisionMode_PropertyAddress, unrealStruct, "FloatPrecisionMode");
		FloatPrecisionMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FloatPrecisionMode");
		FloatPrecisionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FloatPrecisionMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref UseLightmapDirectionality_PropertyAddress, unrealStruct, "bUseLightmapDirectionality");
		UseLightmapDirectionality_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseLightmapDirectionality");
		UseLightmapDirectionality_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseLightmapDirectionality", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MobileEnableHighQualityBRDF_PropertyAddress, unrealStruct, "bMobileEnableHighQualityBRDF");
		MobileEnableHighQualityBRDF_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMobileEnableHighQualityBRDF");
		MobileEnableHighQualityBRDF_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMobileEnableHighQualityBRDF", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAlphaToCoverage_PropertyAddress, unrealStruct, "bUseAlphaToCoverage");
		UseAlphaToCoverage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseAlphaToCoverage");
		UseAlphaToCoverage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseAlphaToCoverage", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForwardRenderUsePreintegratedGFForSimpleIBL_PropertyAddress, unrealStruct, "bForwardRenderUsePreintegratedGFForSimpleIBL");
		ForwardRenderUsePreintegratedGFForSimpleIBL_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bForwardRenderUsePreintegratedGFForSimpleIBL");
		ForwardRenderUsePreintegratedGFForSimpleIBL_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bForwardRenderUsePreintegratedGFForSimpleIBL", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseHQForwardReflections_PropertyAddress, unrealStruct, "bUseHQForwardReflections");
		UseHQForwardReflections_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseHQForwardReflections");
		UseHQForwardReflections_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseHQForwardReflections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForwardBlendsSkyLightCubemaps_PropertyAddress, unrealStruct, "bForwardBlendsSkyLightCubemaps");
		ForwardBlendsSkyLightCubemaps_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bForwardBlendsSkyLightCubemaps");
		ForwardBlendsSkyLightCubemaps_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bForwardBlendsSkyLightCubemaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsePlanarForwardReflections_PropertyAddress, unrealStruct, "bUsePlanarForwardReflections");
		UsePlanarForwardReflections_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsePlanarForwardReflections");
		UsePlanarForwardReflections_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsePlanarForwardReflections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NormalCurvatureToRoughness_PropertyAddress, unrealStruct, "bNormalCurvatureToRoughness");
		NormalCurvatureToRoughness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bNormalCurvatureToRoughness");
		NormalCurvatureToRoughness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bNormalCurvatureToRoughness", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendableLocation_PropertyAddress, unrealStruct, "BlendableLocation");
		BlendableLocation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendableLocation");
		BlendableLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendableLocation", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendableOutputAlpha_PropertyAddress, unrealStruct, "BlendableOutputAlpha");
		BlendableOutputAlpha_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendableOutputAlpha");
		BlendableOutputAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendableOutputAlpha", Classes.FBoolProperty);
		BlendablePriority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendablePriority");
		BlendablePriority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendablePriority", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBlendable_PropertyAddress, unrealStruct, "bIsBlendable");
		IsBlendable_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIsBlendable");
		IsBlendable_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIsBlendable", Classes.FBoolProperty);
	}
}
