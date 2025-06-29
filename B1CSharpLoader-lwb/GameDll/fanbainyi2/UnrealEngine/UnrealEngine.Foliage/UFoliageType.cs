using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[Abstract]
[UClass(Flags = (ClassFlags)810029217uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Foliage.FoliageType", "Foliage", UnrealModuleType.Engine)]
public class UFoliageType : UObject
{
	private static bool CustomData_IsValid;

	private static int CustomData_Offset;

	private static bool ZOffset_IsValid;

	private static int ZOffset_Offset;

	private static bool AlignToNormal_IsValid;

	private static FFieldAddress AlignToNormal_PropertyAddress;

	private static int AlignToNormal_Offset;

	private static bool AverageNormal_IsValid;

	private static FFieldAddress AverageNormal_PropertyAddress;

	private static int AverageNormal_Offset;

	private static bool AverageNormalSingleComponent_IsValid;

	private static FFieldAddress AverageNormalSingleComponent_PropertyAddress;

	private static int AverageNormalSingleComponent_Offset;

	private static bool AlignMaxAngle_IsValid;

	private static int AlignMaxAngle_Offset;

	private static bool RandomYaw_IsValid;

	private static FFieldAddress RandomYaw_PropertyAddress;

	private static int RandomYaw_Offset;

	private static bool RandomPitchAngle_IsValid;

	private static int RandomPitchAngle_Offset;

	private static bool GroundSlopeAngle_IsValid;

	private static int GroundSlopeAngle_Offset;

	private static bool Height_IsValid;

	private static int Height_Offset;

	private static bool LandscapeLayers_IsValid;

	private static FFieldAddress LandscapeLayers_PropertyAddress;

	private static int LandscapeLayers_Offset;

	private TArrayReadWriteMarshaler<FName> LandscapeLayers_MarshalerCached;

	private static bool MinimumLayerWeight_IsValid;

	private static int MinimumLayerWeight_Offset;

	private static bool ExclusionLandscapeLayers_IsValid;

	private static FFieldAddress ExclusionLandscapeLayers_PropertyAddress;

	private static int ExclusionLandscapeLayers_Offset;

	private TArrayReadWriteMarshaler<FName> ExclusionLandscapeLayers_MarshalerCached;

	private static bool MinimumExclusionLayerWeight_IsValid;

	private static int MinimumExclusionLayerWeight_Offset;

	private static bool CollisionWithWorld_IsValid;

	private static FFieldAddress CollisionWithWorld_PropertyAddress;

	private static int CollisionWithWorld_Offset;

	private static bool CollisionScale_IsValid;

	private static int CollisionScale_Offset;

	private static bool AverageNormalSampleCount_IsValid;

	private static int AverageNormalSampleCount_Offset;

	private static bool Mobility_IsValid;

	private static FFieldAddress Mobility_PropertyAddress;

	private static int Mobility_Offset;

	private static bool CastShadow_IsValid;

	private static FFieldAddress CastShadow_PropertyAddress;

	private static int CastShadow_Offset;

	private static bool AffectDynamicIndirectLighting_IsValid;

	private static FFieldAddress AffectDynamicIndirectLighting_PropertyAddress;

	private static int AffectDynamicIndirectLighting_Offset;

	private static bool AffectDistanceFieldLighting_IsValid;

	private static FFieldAddress AffectDistanceFieldLighting_PropertyAddress;

	private static int AffectDistanceFieldLighting_Offset;

	private static bool CastDynamicShadow_IsValid;

	private static FFieldAddress CastDynamicShadow_PropertyAddress;

	private static int CastDynamicShadow_Offset;

	private static bool CastStaticShadow_IsValid;

	private static FFieldAddress CastStaticShadow_PropertyAddress;

	private static int CastStaticShadow_Offset;

	private static bool CastContactShadow_IsValid;

	private static FFieldAddress CastContactShadow_PropertyAddress;

	private static int CastContactShadow_Offset;

	private static bool CastShadowAsTwoSided_IsValid;

	private static FFieldAddress CastShadowAsTwoSided_PropertyAddress;

	private static int CastShadowAsTwoSided_Offset;

	private static bool ReceivesDecals_IsValid;

	private static FFieldAddress ReceivesDecals_PropertyAddress;

	private static int ReceivesDecals_Offset;

	private static bool OverrideLightMapRes_IsValid;

	private static FFieldAddress OverrideLightMapRes_PropertyAddress;

	private static int OverrideLightMapRes_Offset;

	private static bool OverriddenLightMapRes_IsValid;

	private static int OverriddenLightMapRes_Offset;

	private static bool LightmapType_IsValid;

	private static FFieldAddress LightmapType_PropertyAddress;

	private static int LightmapType_Offset;

	private static bool UseAsOccluder_IsValid;

	private static FFieldAddress UseAsOccluder_PropertyAddress;

	private static int UseAsOccluder_Offset;

	private static bool VisibleInRayTracing_IsValid;

	private static FFieldAddress VisibleInRayTracing_PropertyAddress;

	private static int VisibleInRayTracing_Offset;

	private static bool EvaluateWorldPositionOffset_IsValid;

	private static FFieldAddress EvaluateWorldPositionOffset_PropertyAddress;

	private static int EvaluateWorldPositionOffset_Offset;

	private static bool LightingChannels_IsValid;

	private static int LightingChannels_Offset;

	private static bool RenderCustomDepth_IsValid;

	private static FFieldAddress RenderCustomDepth_PropertyAddress;

	private static int RenderCustomDepth_Offset;

	private static bool CustomDepthStencilWriteMask_IsValid;

	private static FFieldAddress CustomDepthStencilWriteMask_PropertyAddress;

	private static int CustomDepthStencilWriteMask_Offset;

	private static bool CustomDepthStencilValue_IsValid;

	private static int CustomDepthStencilValue_Offset;

	private static bool TranslucencySortPriority_IsValid;

	private static int TranslucencySortPriority_Offset;

	private static bool RuntimeVirtualTextures_IsValid;

	private static FFieldAddress RuntimeVirtualTextures_PropertyAddress;

	private static int RuntimeVirtualTextures_Offset;

	private TArrayReadWriteMarshaler<URuntimeVirtualTexture> RuntimeVirtualTextures_MarshalerCached;

	private static bool VirtualTextureCullMips_IsValid;

	private static int VirtualTextureCullMips_Offset;

	private static bool VirtualTextureRenderPassType_IsValid;

	private static FFieldAddress VirtualTextureRenderPassType_PropertyAddress;

	private static int VirtualTextureRenderPassType_Offset;

	private static bool IncludeInHLOD_IsValid;

	private static FFieldAddress IncludeInHLOD_PropertyAddress;

	private static int IncludeInHLOD_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/Foliage.FoliageType:CustomData")]
	public TSoftObject<UHISMCustomRenderData> CustomData
	{
		get
		{
			CheckDestroyed();
			if (!CustomData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CustomData");
				return default(TSoftObject<UHISMCustomRenderData>);
			}
			return TSoftObjectMarshaler<UHISMCustomRenderData>.FromNative(IntPtr.Add(base.Address, CustomData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CustomData");
			}
			else
			{
				TSoftObjectMarshaler<UHISMCustomRenderData>.ToNative(IntPtr.Add(base.Address, CustomData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.FoliageType:ZOffset")]
	public FFloatInterval ZOffset
	{
		get
		{
			CheckDestroyed();
			if (!ZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:ZOffset");
				return default(FFloatInterval);
			}
			return BlittableTypeMarshaler<FFloatInterval>.FromNative(IntPtr.Add(base.Address, ZOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:ZOffset");
			}
			else
			{
				BlittableTypeMarshaler<FFloatInterval>.ToNative(IntPtr.Add(base.Address, ZOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Foliage.FoliageType:AlignToNormal")]
	public bool AlignToNormal
	{
		get
		{
			CheckDestroyed();
			if (!AlignToNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AlignToNormal");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlignToNormal_Offset), 0, AlignToNormal_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlignToNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AlignToNormal");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlignToNormal_Offset), 0, AlignToNormal_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Foliage.FoliageType:AverageNormal")]
	public bool AverageNormal
	{
		get
		{
			CheckDestroyed();
			if (!AverageNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AverageNormal");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AverageNormal_Offset), 0, AverageNormal_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AverageNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AverageNormal");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AverageNormal_Offset), 0, AverageNormal_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Foliage.FoliageType:AverageNormalSingleComponent")]
	public bool AverageNormalSingleComponent
	{
		get
		{
			CheckDestroyed();
			if (!AverageNormalSingleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AverageNormalSingleComponent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AverageNormalSingleComponent_Offset), 0, AverageNormalSingleComponent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AverageNormalSingleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AverageNormalSingleComponent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AverageNormalSingleComponent_Offset), 0, AverageNormalSingleComponent_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.FoliageType:AlignMaxAngle")]
	public float AlignMaxAngle
	{
		get
		{
			CheckDestroyed();
			if (!AlignMaxAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AlignMaxAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AlignMaxAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AlignMaxAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AlignMaxAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AlignMaxAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Foliage.FoliageType:RandomYaw")]
	public bool RandomYaw
	{
		get
		{
			CheckDestroyed();
			if (!RandomYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:RandomYaw");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RandomYaw_Offset), 0, RandomYaw_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RandomYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:RandomYaw");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RandomYaw_Offset), 0, RandomYaw_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.FoliageType:RandomPitchAngle")]
	public float RandomPitchAngle
	{
		get
		{
			CheckDestroyed();
			if (!RandomPitchAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:RandomPitchAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RandomPitchAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomPitchAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:RandomPitchAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RandomPitchAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.FoliageType:GroundSlopeAngle")]
	public FFloatInterval GroundSlopeAngle
	{
		get
		{
			CheckDestroyed();
			if (!GroundSlopeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:GroundSlopeAngle");
				return default(FFloatInterval);
			}
			return BlittableTypeMarshaler<FFloatInterval>.FromNative(IntPtr.Add(base.Address, GroundSlopeAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroundSlopeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:GroundSlopeAngle");
			}
			else
			{
				BlittableTypeMarshaler<FFloatInterval>.ToNative(IntPtr.Add(base.Address, GroundSlopeAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.FoliageType:Height")]
	public FFloatInterval Height
	{
		get
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:Height");
				return default(FFloatInterval);
			}
			return BlittableTypeMarshaler<FFloatInterval>.FromNative(IntPtr.Add(base.Address, Height_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:Height");
			}
			else
			{
				BlittableTypeMarshaler<FFloatInterval>.ToNative(IntPtr.Add(base.Address, Height_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4507997673882117uL)]
	[UMetaPath("/Script/Foliage.FoliageType:LandscapeLayers")]
	public TArrayReadWrite<FName> LandscapeLayers
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeLayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:LandscapeLayers");
				return null;
			}
			if (LandscapeLayers_MarshalerCached == null)
			{
				LandscapeLayers_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, LandscapeLayers_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return LandscapeLayers_MarshalerCached.FromNative(IntPtr.Add(base.Address, LandscapeLayers_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Foliage.FoliageType:MinimumLayerWeight")]
	public float MinimumLayerWeight
	{
		get
		{
			CheckDestroyed();
			if (!MinimumLayerWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:MinimumLayerWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumLayerWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumLayerWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:MinimumLayerWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumLayerWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4507997673882117uL)]
	[UMetaPath("/Script/Foliage.FoliageType:ExclusionLandscapeLayers")]
	public TArrayReadWrite<FName> ExclusionLandscapeLayers
	{
		get
		{
			CheckDestroyed();
			if (!ExclusionLandscapeLayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:ExclusionLandscapeLayers");
				return null;
			}
			if (ExclusionLandscapeLayers_MarshalerCached == null)
			{
				ExclusionLandscapeLayers_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, ExclusionLandscapeLayers_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return ExclusionLandscapeLayers_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExclusionLandscapeLayers_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Foliage.FoliageType:MinimumExclusionLayerWeight")]
	public float MinimumExclusionLayerWeight
	{
		get
		{
			CheckDestroyed();
			if (!MinimumExclusionLayerWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:MinimumExclusionLayerWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumExclusionLayerWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumExclusionLayerWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:MinimumExclusionLayerWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumExclusionLayerWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Foliage.FoliageType:CollisionWithWorld")]
	public bool CollisionWithWorld
	{
		get
		{
			CheckDestroyed();
			if (!CollisionWithWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CollisionWithWorld");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CollisionWithWorld_Offset), 0, CollisionWithWorld_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CollisionWithWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CollisionWithWorld");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CollisionWithWorld_Offset), 0, CollisionWithWorld_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Foliage.FoliageType:CollisionScale")]
	public FVector CollisionScale
	{
		get
		{
			CheckDestroyed();
			if (!CollisionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CollisionScale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CollisionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CollisionScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CollisionScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Foliage.FoliageType:AverageNormalSampleCount")]
	public int AverageNormalSampleCount
	{
		get
		{
			CheckDestroyed();
			if (!AverageNormalSampleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AverageNormalSampleCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AverageNormalSampleCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AverageNormalSampleCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:AverageNormalSampleCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AverageNormalSampleCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Foliage.FoliageType:Mobility")]
	public EComponentMobility Mobility
	{
		get
		{
			CheckDestroyed();
			if (!Mobility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:Mobility");
				return EComponentMobility.Static;
			}
			return EnumMarshaler<EComponentMobility>.FromNative(IntPtr.Add(base.Address, Mobility_Offset), 0, Mobility_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mobility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:Mobility");
			}
			else
			{
				EnumMarshaler<EComponentMobility>.ToNative(IntPtr.Add(base.Address, Mobility_Offset), 0, Mobility_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Foliage.FoliageType:CastShadow")]
	public bool CastShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CastShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadow_Offset), 0, CastShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CastShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadow_Offset), 0, CastShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bAffectDynamicIndirectLighting")]
	public bool AffectDynamicIndirectLighting
	{
		get
		{
			CheckDestroyed();
			if (!AffectDynamicIndirectLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bAffectDynamicIndirectLighting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectDynamicIndirectLighting_Offset), 0, AffectDynamicIndirectLighting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectDynamicIndirectLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bAffectDynamicIndirectLighting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectDynamicIndirectLighting_Offset), 0, AffectDynamicIndirectLighting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bAffectDistanceFieldLighting")]
	public bool AffectDistanceFieldLighting
	{
		get
		{
			CheckDestroyed();
			if (!AffectDistanceFieldLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bAffectDistanceFieldLighting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectDistanceFieldLighting_Offset), 0, AffectDistanceFieldLighting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectDistanceFieldLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bAffectDistanceFieldLighting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectDistanceFieldLighting_Offset), 0, AffectDistanceFieldLighting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bCastDynamicShadow")]
	public bool CastDynamicShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastDynamicShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bCastDynamicShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastDynamicShadow_Offset), 0, CastDynamicShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastDynamicShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bCastDynamicShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastDynamicShadow_Offset), 0, CastDynamicShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bCastStaticShadow")]
	public bool CastStaticShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastStaticShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bCastStaticShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastStaticShadow_Offset), 0, CastStaticShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastStaticShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bCastStaticShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastStaticShadow_Offset), 0, CastStaticShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bCastContactShadow")]
	public bool CastContactShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastContactShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bCastContactShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastContactShadow_Offset), 0, CastContactShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastContactShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bCastContactShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastContactShadow_Offset), 0, CastContactShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bCastShadowAsTwoSided")]
	public bool CastShadowAsTwoSided
	{
		get
		{
			CheckDestroyed();
			if (!CastShadowAsTwoSided_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bCastShadowAsTwoSided");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadowAsTwoSided_Offset), 0, CastShadowAsTwoSided_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadowAsTwoSided_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bCastShadowAsTwoSided");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadowAsTwoSided_Offset), 0, CastShadowAsTwoSided_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bReceivesDecals")]
	public bool ReceivesDecals
	{
		get
		{
			CheckDestroyed();
			if (!ReceivesDecals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bReceivesDecals");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReceivesDecals_Offset), 0, ReceivesDecals_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReceivesDecals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bReceivesDecals");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReceivesDecals_Offset), 0, ReceivesDecals_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bOverrideLightMapRes")]
	public bool OverrideLightMapRes
	{
		get
		{
			CheckDestroyed();
			if (!OverrideLightMapRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bOverrideLightMapRes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideLightMapRes_Offset), 0, OverrideLightMapRes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideLightMapRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bOverrideLightMapRes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideLightMapRes_Offset), 0, OverrideLightMapRes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Foliage.FoliageType:OverriddenLightMapRes")]
	public int OverriddenLightMapRes
	{
		get
		{
			CheckDestroyed();
			if (!OverriddenLightMapRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:OverriddenLightMapRes");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OverriddenLightMapRes_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverriddenLightMapRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:OverriddenLightMapRes");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OverriddenLightMapRes_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Foliage.FoliageType:LightmapType")]
	public ELightmapType LightmapType
	{
		get
		{
			CheckDestroyed();
			if (!LightmapType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:LightmapType");
				return ELightmapType.Default;
			}
			return EnumMarshaler<ELightmapType>.FromNative(IntPtr.Add(base.Address, LightmapType_Offset), 0, LightmapType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LightmapType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:LightmapType");
			}
			else
			{
				EnumMarshaler<ELightmapType>.ToNative(IntPtr.Add(base.Address, LightmapType_Offset), 0, LightmapType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bUseAsOccluder")]
	public bool UseAsOccluder
	{
		get
		{
			CheckDestroyed();
			if (!UseAsOccluder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bUseAsOccluder");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAsOccluder_Offset), 0, UseAsOccluder_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAsOccluder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bUseAsOccluder");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAsOccluder_Offset), 0, UseAsOccluder_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bVisibleInRayTracing")]
	public bool VisibleInRayTracing
	{
		get
		{
			CheckDestroyed();
			if (!VisibleInRayTracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bVisibleInRayTracing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, VisibleInRayTracing_Offset), 0, VisibleInRayTracing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VisibleInRayTracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bVisibleInRayTracing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, VisibleInRayTracing_Offset), 0, VisibleInRayTracing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bEvaluateWorldPositionOffset")]
	public bool EvaluateWorldPositionOffset
	{
		get
		{
			CheckDestroyed();
			if (!EvaluateWorldPositionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bEvaluateWorldPositionOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EvaluateWorldPositionOffset_Offset), 0, EvaluateWorldPositionOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EvaluateWorldPositionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bEvaluateWorldPositionOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EvaluateWorldPositionOffset_Offset), 0, EvaluateWorldPositionOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358357uL)]
	[UMetaPath("/Script/Foliage.FoliageType:LightingChannels")]
	public FLightingChannels LightingChannels
	{
		get
		{
			CheckDestroyed();
			if (!LightingChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:LightingChannels");
				return default(FLightingChannels);
			}
			return FLightingChannels.FromNative(IntPtr.Add(base.Address, LightingChannels_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightingChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:LightingChannels");
			}
			else
			{
				FLightingChannels.ToNative(IntPtr.Add(base.Address, LightingChannels_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bRenderCustomDepth")]
	public bool RenderCustomDepth
	{
		get
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bRenderCustomDepth");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bRenderCustomDepth");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Foliage.FoliageType:CustomDepthStencilWriteMask")]
	public ERendererStencilMask CustomDepthStencilWriteMask
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilWriteMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CustomDepthStencilWriteMask");
				return ERendererStencilMask.ERSM_Default;
			}
			return EnumMarshaler<ERendererStencilMask>.FromNative(IntPtr.Add(base.Address, CustomDepthStencilWriteMask_Offset), 0, CustomDepthStencilWriteMask_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CustomDepthStencilWriteMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CustomDepthStencilWriteMask");
			}
			else
			{
				EnumMarshaler<ERendererStencilMask>.ToNative(IntPtr.Add(base.Address, CustomDepthStencilWriteMask_Offset), 0, CustomDepthStencilWriteMask_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Foliage.FoliageType:CustomDepthStencilValue")]
	public int CustomDepthStencilValue
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CustomDepthStencilValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:CustomDepthStencilValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Foliage.FoliageType:TranslucencySortPriority")]
	public int TranslucencySortPriority
	{
		get
		{
			CheckDestroyed();
			if (!TranslucencySortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:TranslucencySortPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TranslucencySortPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TranslucencySortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:TranslucencySortPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TranslucencySortPriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Foliage.FoliageType:RuntimeVirtualTextures")]
	public TArrayReadWrite<URuntimeVirtualTexture> RuntimeVirtualTextures
	{
		get
		{
			CheckDestroyed();
			if (!RuntimeVirtualTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:RuntimeVirtualTextures");
				return null;
			}
			if (RuntimeVirtualTextures_MarshalerCached == null)
			{
				RuntimeVirtualTextures_MarshalerCached = new TArrayReadWriteMarshaler<URuntimeVirtualTexture>(1, RuntimeVirtualTextures_PropertyAddress, CachedMarshalingDelegates<URuntimeVirtualTexture, UObjectMarshaler<URuntimeVirtualTexture>>.FromNative, CachedMarshalingDelegates<URuntimeVirtualTexture, UObjectMarshaler<URuntimeVirtualTexture>>.ToNative);
			}
			return RuntimeVirtualTextures_MarshalerCached.FromNative(IntPtr.Add(base.Address, RuntimeVirtualTextures_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Foliage.FoliageType:VirtualTextureCullMips")]
	public int VirtualTextureCullMips
	{
		get
		{
			CheckDestroyed();
			if (!VirtualTextureCullMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:VirtualTextureCullMips");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VirtualTextureCullMips_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VirtualTextureCullMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:VirtualTextureCullMips");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VirtualTextureCullMips_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Foliage.FoliageType:VirtualTextureRenderPassType")]
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType
	{
		get
		{
			CheckDestroyed();
			if (!VirtualTextureRenderPassType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:VirtualTextureRenderPassType");
				return ERuntimeVirtualTextureMainPassType.Never;
			}
			return EnumMarshaler<ERuntimeVirtualTextureMainPassType>.FromNative(IntPtr.Add(base.Address, VirtualTextureRenderPassType_Offset), 0, VirtualTextureRenderPassType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VirtualTextureRenderPassType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:VirtualTextureRenderPassType");
			}
			else
			{
				EnumMarshaler<ERuntimeVirtualTextureMainPassType>.ToNative(IntPtr.Add(base.Address, VirtualTextureRenderPassType_Offset), 0, VirtualTextureRenderPassType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755502520270853uL)]
	[UMetaPath("/Script/Foliage.FoliageType:bIncludeInHLOD")]
	public bool IncludeInHLOD
	{
		get
		{
			CheckDestroyed();
			if (!IncludeInHLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bIncludeInHLOD");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeInHLOD_Offset), 0, IncludeInHLOD_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeInHLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType:bIncludeInHLOD");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeInHLOD_Offset), 0, IncludeInHLOD_PropertyAddress.Address, value);
			}
		}
	}

	static UFoliageType()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFoliageType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFoliageType));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Foliage.FoliageType");
		CustomData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomData");
		CustomData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomData", Classes.FSoftObjectProperty);
		ZOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ZOffset");
		ZOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ZOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AlignToNormal_PropertyAddress, unrealStruct, "AlignToNormal");
		AlignToNormal_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AlignToNormal");
		AlignToNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AlignToNormal", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AverageNormal_PropertyAddress, unrealStruct, "AverageNormal");
		AverageNormal_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AverageNormal");
		AverageNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AverageNormal", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AverageNormalSingleComponent_PropertyAddress, unrealStruct, "AverageNormalSingleComponent");
		AverageNormalSingleComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AverageNormalSingleComponent");
		AverageNormalSingleComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AverageNormalSingleComponent", Classes.FBoolProperty);
		AlignMaxAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AlignMaxAngle");
		AlignMaxAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AlignMaxAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomYaw_PropertyAddress, unrealStruct, "RandomYaw");
		RandomYaw_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RandomYaw");
		RandomYaw_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RandomYaw", Classes.FBoolProperty);
		RandomPitchAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RandomPitchAngle");
		RandomPitchAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RandomPitchAngle", Classes.FFloatProperty);
		GroundSlopeAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GroundSlopeAngle");
		GroundSlopeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GroundSlopeAngle", Classes.FStructProperty);
		Height_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Height");
		Height_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Height", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeLayers_PropertyAddress, unrealStruct, "LandscapeLayers");
		LandscapeLayers_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LandscapeLayers");
		LandscapeLayers_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LandscapeLayers", Classes.FArrayProperty);
		MinimumLayerWeight_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinimumLayerWeight");
		MinimumLayerWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinimumLayerWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ExclusionLandscapeLayers_PropertyAddress, unrealStruct, "ExclusionLandscapeLayers");
		ExclusionLandscapeLayers_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExclusionLandscapeLayers");
		ExclusionLandscapeLayers_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExclusionLandscapeLayers", Classes.FArrayProperty);
		MinimumExclusionLayerWeight_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinimumExclusionLayerWeight");
		MinimumExclusionLayerWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinimumExclusionLayerWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CollisionWithWorld_PropertyAddress, unrealStruct, "CollisionWithWorld");
		CollisionWithWorld_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CollisionWithWorld");
		CollisionWithWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CollisionWithWorld", Classes.FBoolProperty);
		CollisionScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CollisionScale");
		CollisionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CollisionScale", Classes.FStructProperty);
		AverageNormalSampleCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AverageNormalSampleCount");
		AverageNormalSampleCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AverageNormalSampleCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Mobility_PropertyAddress, unrealStruct, "Mobility");
		Mobility_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mobility");
		Mobility_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mobility", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadow_PropertyAddress, unrealStruct, "CastShadow");
		CastShadow_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CastShadow");
		CastShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CastShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectDynamicIndirectLighting_PropertyAddress, unrealStruct, "bAffectDynamicIndirectLighting");
		AffectDynamicIndirectLighting_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAffectDynamicIndirectLighting");
		AffectDynamicIndirectLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAffectDynamicIndirectLighting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectDistanceFieldLighting_PropertyAddress, unrealStruct, "bAffectDistanceFieldLighting");
		AffectDistanceFieldLighting_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAffectDistanceFieldLighting");
		AffectDistanceFieldLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAffectDistanceFieldLighting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastDynamicShadow_PropertyAddress, unrealStruct, "bCastDynamicShadow");
		CastDynamicShadow_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCastDynamicShadow");
		CastDynamicShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCastDynamicShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastStaticShadow_PropertyAddress, unrealStruct, "bCastStaticShadow");
		CastStaticShadow_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCastStaticShadow");
		CastStaticShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCastStaticShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastContactShadow_PropertyAddress, unrealStruct, "bCastContactShadow");
		CastContactShadow_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCastContactShadow");
		CastContactShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCastContactShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadowAsTwoSided_PropertyAddress, unrealStruct, "bCastShadowAsTwoSided");
		CastShadowAsTwoSided_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCastShadowAsTwoSided");
		CastShadowAsTwoSided_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCastShadowAsTwoSided", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivesDecals_PropertyAddress, unrealStruct, "bReceivesDecals");
		ReceivesDecals_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReceivesDecals");
		ReceivesDecals_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReceivesDecals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideLightMapRes_PropertyAddress, unrealStruct, "bOverrideLightMapRes");
		OverrideLightMapRes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideLightMapRes");
		OverrideLightMapRes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideLightMapRes", Classes.FBoolProperty);
		OverriddenLightMapRes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OverriddenLightMapRes");
		OverriddenLightMapRes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OverriddenLightMapRes", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LightmapType_PropertyAddress, unrealStruct, "LightmapType");
		LightmapType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightmapType");
		LightmapType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightmapType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAsOccluder_PropertyAddress, unrealStruct, "bUseAsOccluder");
		UseAsOccluder_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseAsOccluder");
		UseAsOccluder_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseAsOccluder", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisibleInRayTracing_PropertyAddress, unrealStruct, "bVisibleInRayTracing");
		VisibleInRayTracing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bVisibleInRayTracing");
		VisibleInRayTracing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bVisibleInRayTracing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateWorldPositionOffset_PropertyAddress, unrealStruct, "bEvaluateWorldPositionOffset");
		EvaluateWorldPositionOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEvaluateWorldPositionOffset");
		EvaluateWorldPositionOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEvaluateWorldPositionOffset", Classes.FBoolProperty);
		LightingChannels_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightingChannels");
		LightingChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightingChannels", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderCustomDepth_PropertyAddress, unrealStruct, "bRenderCustomDepth");
		RenderCustomDepth_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRenderCustomDepth");
		RenderCustomDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRenderCustomDepth", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomDepthStencilWriteMask_PropertyAddress, unrealStruct, "CustomDepthStencilWriteMask");
		CustomDepthStencilWriteMask_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomDepthStencilWriteMask");
		CustomDepthStencilWriteMask_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomDepthStencilWriteMask", Classes.FEnumProperty);
		CustomDepthStencilValue_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomDepthStencilValue");
		CustomDepthStencilValue_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomDepthStencilValue", Classes.FIntProperty);
		TranslucencySortPriority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TranslucencySortPriority");
		TranslucencySortPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TranslucencySortPriority", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RuntimeVirtualTextures_PropertyAddress, unrealStruct, "RuntimeVirtualTextures");
		RuntimeVirtualTextures_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RuntimeVirtualTextures");
		RuntimeVirtualTextures_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RuntimeVirtualTextures", Classes.FArrayProperty);
		VirtualTextureCullMips_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VirtualTextureCullMips");
		VirtualTextureCullMips_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VirtualTextureCullMips", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref VirtualTextureRenderPassType_PropertyAddress, unrealStruct, "VirtualTextureRenderPassType");
		VirtualTextureRenderPassType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VirtualTextureRenderPassType");
		VirtualTextureRenderPassType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VirtualTextureRenderPassType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeInHLOD_PropertyAddress, unrealStruct, "bIncludeInHLOD");
		IncludeInHLOD_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIncludeInHLOD");
		IncludeInHLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIncludeInHLOD", Classes.FBoolProperty);
	}
}
