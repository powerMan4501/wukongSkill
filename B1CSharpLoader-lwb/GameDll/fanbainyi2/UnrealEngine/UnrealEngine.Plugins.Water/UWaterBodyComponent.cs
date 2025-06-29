using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Water.WaterBodyComponent", "Water", UnrealModuleType.EnginePlugin)]
public class UWaterBodyComponent : UPrimitiveComponent
{
	private static bool TargetWaveMaskDepth_IsValid;

	private static int TargetWaveMaskDepth_Offset;

	private static bool UnderwaterPostProcessSettings_IsValid;

	private static int UnderwaterPostProcessSettings_Offset;

	private static bool CurveSettings_IsValid;

	private static int CurveSettings_Offset;

	private static bool WaterMaterial_IsValid;

	private static int WaterMaterial_Offset;

	private static bool UnderwaterPostProcessMaterial_IsValid;

	private static int UnderwaterPostProcessMaterial_Offset;

	private static bool WaterHeightmapSettings_IsValid;

	private static int WaterHeightmapSettings_Offset;

	private static bool LayerWeightmapSettings_IsValid;

	private static FFieldAddress LayerWeightmapSettings_PropertyAddress;

	private static int LayerWeightmapSettings_Offset;

	private TMapReadWriteMarshaler<FName, FWaterBodyWeightmapSettings> LayerWeightmapSettings_MarshalerCached;

	private static bool ShapeDilation_IsValid;

	private static int ShapeDilation_Offset;

	private static bool CollisionHeightOffset_IsValid;

	private static int CollisionHeightOffset_Offset;

	private static bool AffectsLandscape_IsValid;

	private static FFieldAddress AffectsLandscape_PropertyAddress;

	private static int AffectsLandscape_Offset;

	private static bool GenerateCollisions_IsValid;

	private static FFieldAddress GenerateCollisions_PropertyAddress;

	private static int GenerateCollisions_Offset;

	private static bool WaterBodyIndex_IsValid;

	private static int WaterBodyIndex_Offset;

	private static bool WaterMeshOverride_IsValid;

	private static int WaterMeshOverride_Offset;

	private static bool OverlapMaterialPriority_IsValid;

	private static int OverlapMaterialPriority_Offset;

	private static bool CollisionProfileName_IsValid;

	private static int CollisionProfileName_Offset;

	private static bool CanAffectNavigation_IsValid;

	private static FFieldAddress CanAffectNavigation_PropertyAddress;

	private static int CanAffectNavigation_Offset;

	private static bool WaterNavAreaClass_IsValid;

	private static int WaterNavAreaClass_Offset;

	private static bool OnWaterBodyChanged_IsValid;

	private static IntPtr OnWaterBodyChanged_FunctionAddress;

	private static int OnWaterBodyChanged_ParamsSize;

	private static bool OnWaterBodyChanged_bShapeOrPositionChanged_IsValid;

	private static FFieldAddress OnWaterBodyChanged_bShapeOrPositionChanged_PropertyAddress;

	private static int OnWaterBodyChanged_bShapeOrPositionChanged_Offset;

	private static bool OnWaterBodyChanged_bWeightmapSettingsChanged_IsValid;

	private static FFieldAddress OnWaterBodyChanged_bWeightmapSettingsChanged_PropertyAddress;

	private static int OnWaterBodyChanged_bWeightmapSettingsChanged_Offset;

	private static bool GetWaterWaves_IsValid;

	private static IntPtr GetWaterWaves_FunctionAddress;

	private static int GetWaterWaves_ParamsSize;

	private static bool GetWaterWaves_ReturnValue_IsValid;

	private static FFieldAddress GetWaterWaves_ReturnValue_PropertyAddress;

	private static int GetWaterWaves_ReturnValue_Offset;

	private static bool GetWaterVelocityAtSplineInputKey_IsValid;

	private static IntPtr GetWaterVelocityAtSplineInputKey_FunctionAddress;

	private static int GetWaterVelocityAtSplineInputKey_ParamsSize;

	private static bool GetWaterVelocityAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetWaterVelocityAtSplineInputKey_InKey_PropertyAddress;

	private static int GetWaterVelocityAtSplineInputKey_InKey_Offset;

	private static bool GetWaterVelocityAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetWaterVelocityAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetWaterVelocityAtSplineInputKey_ReturnValue_Offset;

	private static bool GetWaterSurfaceInfoAtLocation_IsValid;

	private static IntPtr GetWaterSurfaceInfoAtLocation_FunctionAddress;

	private static int GetWaterSurfaceInfoAtLocation_ParamsSize;

	private static bool GetWaterSurfaceInfoAtLocation_InLocation_IsValid;

	private static FFieldAddress GetWaterSurfaceInfoAtLocation_InLocation_PropertyAddress;

	private static int GetWaterSurfaceInfoAtLocation_InLocation_Offset;

	private static bool GetWaterSurfaceInfoAtLocation_OutWaterSurfaceLocation_IsValid;

	private static FFieldAddress GetWaterSurfaceInfoAtLocation_OutWaterSurfaceLocation_PropertyAddress;

	private static int GetWaterSurfaceInfoAtLocation_OutWaterSurfaceLocation_Offset;

	private static bool GetWaterSurfaceInfoAtLocation_OutWaterSurfaceNormal_IsValid;

	private static FFieldAddress GetWaterSurfaceInfoAtLocation_OutWaterSurfaceNormal_PropertyAddress;

	private static int GetWaterSurfaceInfoAtLocation_OutWaterSurfaceNormal_Offset;

	private static bool GetWaterSurfaceInfoAtLocation_OutWaterVelocity_IsValid;

	private static FFieldAddress GetWaterSurfaceInfoAtLocation_OutWaterVelocity_PropertyAddress;

	private static int GetWaterSurfaceInfoAtLocation_OutWaterVelocity_Offset;

	private static bool GetWaterSurfaceInfoAtLocation_OutWaterDepth_IsValid;

	private static FFieldAddress GetWaterSurfaceInfoAtLocation_OutWaterDepth_PropertyAddress;

	private static int GetWaterSurfaceInfoAtLocation_OutWaterDepth_Offset;

	private static bool GetWaterSurfaceInfoAtLocation_bIncludeDepth_IsValid;

	private static FFieldAddress GetWaterSurfaceInfoAtLocation_bIncludeDepth_PropertyAddress;

	private static int GetWaterSurfaceInfoAtLocation_bIncludeDepth_Offset;

	private static bool GetWaterSpline_IsValid;

	private static IntPtr GetWaterSpline_FunctionAddress;

	private static int GetWaterSpline_ParamsSize;

	private static bool GetWaterSpline_ReturnValue_IsValid;

	private static FFieldAddress GetWaterSpline_ReturnValue_PropertyAddress;

	private static int GetWaterSpline_ReturnValue_Offset;

	private static bool GetWaterMaterialInstance_IsValid;

	private static IntPtr GetWaterMaterialInstance_FunctionAddress;

	private static int GetWaterMaterialInstance_ParamsSize;

	private static bool GetWaterMaterialInstance_ReturnValue_IsValid;

	private static FFieldAddress GetWaterMaterialInstance_ReturnValue_PropertyAddress;

	private static int GetWaterMaterialInstance_ReturnValue_Offset;

	private static bool GetWaterMaterial_IsValid;

	private static IntPtr GetWaterMaterial_FunctionAddress;

	private static int GetWaterMaterial_ParamsSize;

	private static bool GetWaterMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetWaterMaterial_ReturnValue_PropertyAddress;

	private static int GetWaterMaterial_ReturnValue_Offset;

	private static bool GetWaterBodyActor_IsValid;

	private static IntPtr GetWaterBodyActor_FunctionAddress;

	private static int GetWaterBodyActor_ParamsSize;

	private static bool GetWaterBodyActor_ReturnValue_IsValid;

	private static FFieldAddress GetWaterBodyActor_ReturnValue_PropertyAddress;

	private static int GetWaterBodyActor_ReturnValue_Offset;

	private static bool GetUnderwaterPostProcessMaterialInstance_IsValid;

	private static IntPtr GetUnderwaterPostProcessMaterialInstance_FunctionAddress;

	private static int GetUnderwaterPostProcessMaterialInstance_ParamsSize;

	private static bool GetUnderwaterPostProcessMaterialInstance_ReturnValue_IsValid;

	private static FFieldAddress GetUnderwaterPostProcessMaterialInstance_ReturnValue_PropertyAddress;

	private static int GetUnderwaterPostProcessMaterialInstance_ReturnValue_Offset;

	private static bool GetStandardRenderableComponents_IsValid;

	private static IntPtr GetStandardRenderableComponents_FunctionAddress;

	private static int GetStandardRenderableComponents_ParamsSize;

	private static bool GetStandardRenderableComponents_ReturnValue_IsValid;

	private static FFieldAddress GetStandardRenderableComponents_ReturnValue_PropertyAddress;

	private static int GetStandardRenderableComponents_ReturnValue_Offset;

	private static bool GetRiverToOceanTransitionMaterialInstance_IsValid;

	private static IntPtr GetRiverToOceanTransitionMaterialInstance_FunctionAddress;

	private static int GetRiverToOceanTransitionMaterialInstance_ParamsSize;

	private static bool GetRiverToOceanTransitionMaterialInstance_ReturnValue_IsValid;

	private static FFieldAddress GetRiverToOceanTransitionMaterialInstance_ReturnValue_PropertyAddress;

	private static int GetRiverToOceanTransitionMaterialInstance_ReturnValue_Offset;

	private static bool GetRiverToLakeTransitionMaterialInstance_IsValid;

	private static IntPtr GetRiverToLakeTransitionMaterialInstance_FunctionAddress;

	private static int GetRiverToLakeTransitionMaterialInstance_ParamsSize;

	private static bool GetRiverToLakeTransitionMaterialInstance_ReturnValue_IsValid;

	private static FFieldAddress GetRiverToLakeTransitionMaterialInstance_ReturnValue_PropertyAddress;

	private static int GetRiverToLakeTransitionMaterialInstance_ReturnValue_Offset;

	private static bool GetMaxWaveHeight_IsValid;

	private static IntPtr GetMaxWaveHeight_FunctionAddress;

	private static int GetMaxWaveHeight_ParamsSize;

	private static bool GetMaxWaveHeight_ReturnValue_IsValid;

	private static FFieldAddress GetMaxWaveHeight_ReturnValue_PropertyAddress;

	private static int GetMaxWaveHeight_ReturnValue_Offset;

	private static bool GetIslands_IsValid;

	private static IntPtr GetIslands_FunctionAddress;

	private static int GetIslands_ParamsSize;

	private static bool GetIslands_ReturnValue_IsValid;

	private static FFieldAddress GetIslands_ReturnValue_PropertyAddress;

	private static int GetIslands_ReturnValue_Offset;

	private static bool GetExclusionVolumes_IsValid;

	private static IntPtr GetExclusionVolumes_FunctionAddress;

	private static int GetExclusionVolumes_ParamsSize;

	private static bool GetExclusionVolumes_ReturnValue_IsValid;

	private static FFieldAddress GetExclusionVolumes_ReturnValue_PropertyAddress;

	private static int GetExclusionVolumes_ReturnValue_Offset;

	private static bool GetCollisionComponents_IsValid;

	private static IntPtr GetCollisionComponents_FunctionAddress;

	private static int GetCollisionComponents_ParamsSize;

	private static bool GetCollisionComponents_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionComponents_ReturnValue_PropertyAddress;

	private static int GetCollisionComponents_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:TargetWaveMaskDepth")]
	public float TargetWaveMaskDepth
	{
		get
		{
			CheckDestroyed();
			if (!TargetWaveMaskDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:TargetWaveMaskDepth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TargetWaveMaskDepth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetWaveMaskDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:TargetWaveMaskDepth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TargetWaveMaskDepth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:UnderwaterPostProcessSettings")]
	public FUnderwaterPostProcessSettings UnderwaterPostProcessSettings
	{
		get
		{
			CheckDestroyed();
			if (!UnderwaterPostProcessSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:UnderwaterPostProcessSettings");
				return default(FUnderwaterPostProcessSettings);
			}
			return FUnderwaterPostProcessSettings.FromNative(IntPtr.Add(base.Address, UnderwaterPostProcessSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnderwaterPostProcessSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:UnderwaterPostProcessSettings");
			}
			else
			{
				FUnderwaterPostProcessSettings.ToNative(IntPtr.Add(base.Address, UnderwaterPostProcessSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:CurveSettings")]
	public FWaterCurveSettings CurveSettings
	{
		get
		{
			CheckDestroyed();
			if (!CurveSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:CurveSettings");
				return default(FWaterCurveSettings);
			}
			return FWaterCurveSettings.FromNative(IntPtr.Add(base.Address, CurveSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:CurveSettings");
			}
			else
			{
				FWaterCurveSettings.ToNative(IntPtr.Add(base.Address, CurveSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:WaterMaterial")]
	public UMaterialInterface WaterMaterial
	{
		get
		{
			CheckDestroyed();
			if (!WaterMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, WaterMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, WaterMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:UnderwaterPostProcessMaterial")]
	public UMaterialInterface UnderwaterPostProcessMaterial
	{
		get
		{
			CheckDestroyed();
			if (!UnderwaterPostProcessMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:UnderwaterPostProcessMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, UnderwaterPostProcessMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnderwaterPostProcessMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:UnderwaterPostProcessMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, UnderwaterPostProcessMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503702706585605uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:WaterHeightmapSettings")]
	public FWaterBodyHeightmapSettings WaterHeightmapSettings
	{
		get
		{
			CheckDestroyed();
			if (!WaterHeightmapSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterHeightmapSettings");
				return default(FWaterBodyHeightmapSettings);
			}
			return FWaterBodyHeightmapSettings.FromNative(IntPtr.Add(base.Address, WaterHeightmapSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterHeightmapSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterHeightmapSettings");
			}
			else
			{
				FWaterBodyHeightmapSettings.ToNative(IntPtr.Add(base.Address, WaterHeightmapSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503633987108869uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:LayerWeightmapSettings")]
	public TMapReadWrite<FName, FWaterBodyWeightmapSettings> LayerWeightmapSettings
	{
		get
		{
			CheckDestroyed();
			if (!LayerWeightmapSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:LayerWeightmapSettings");
				return null;
			}
			if (LayerWeightmapSettings_MarshalerCached == null)
			{
				LayerWeightmapSettings_MarshalerCached = new TMapReadWriteMarshaler<FName, FWaterBodyWeightmapSettings>(1, LayerWeightmapSettings_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FWaterBodyWeightmapSettings, FWaterBodyWeightmapSettings>.FromNative, CachedMarshalingDelegates<FWaterBodyWeightmapSettings, FWaterBodyWeightmapSettings>.ToNative);
			}
			return LayerWeightmapSettings_MarshalerCached.FromNative(IntPtr.Add(base.Address, LayerWeightmapSettings_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:ShapeDilation")]
	public float ShapeDilation
	{
		get
		{
			CheckDestroyed();
			if (!ShapeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:ShapeDilation");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShapeDilation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShapeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:ShapeDilation");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShapeDilation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:CollisionHeightOffset")]
	public float CollisionHeightOffset
	{
		get
		{
			CheckDestroyed();
			if (!CollisionHeightOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:CollisionHeightOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CollisionHeightOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionHeightOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:CollisionHeightOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CollisionHeightOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:bAffectsLandscape")]
	public bool AffectsLandscape
	{
		get
		{
			CheckDestroyed();
			if (!AffectsLandscape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:bAffectsLandscape");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectsLandscape_Offset), 0, AffectsLandscape_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectsLandscape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:bAffectsLandscape");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectsLandscape_Offset), 0, AffectsLandscape_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:bGenerateCollisions")]
	public bool GenerateCollisions
	{
		get
		{
			CheckDestroyed();
			if (!GenerateCollisions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:bGenerateCollisions");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GenerateCollisions_Offset), 0, GenerateCollisions_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenerateCollisions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:bGenerateCollisions");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GenerateCollisions_Offset), 0, GenerateCollisions_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267882136773141uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:WaterBodyIndex")]
	protected int WaterBodyIndex
	{
		get
		{
			CheckDestroyed();
			if (!WaterBodyIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterBodyIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WaterBodyIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterBodyIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterBodyIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WaterBodyIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:WaterMeshOverride")]
	protected UStaticMesh WaterMeshOverride
	{
		get
		{
			CheckDestroyed();
			if (!WaterMeshOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterMeshOverride");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, WaterMeshOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterMeshOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterMeshOverride");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, WaterMeshOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:OverlapMaterialPriority")]
	protected int OverlapMaterialPriority
	{
		get
		{
			CheckDestroyed();
			if (!OverlapMaterialPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:OverlapMaterialPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OverlapMaterialPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverlapMaterialPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:OverlapMaterialPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OverlapMaterialPriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:CollisionProfileName")]
	protected FName CollisionProfileName
	{
		get
		{
			CheckDestroyed();
			if (!CollisionProfileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:CollisionProfileName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CollisionProfileName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionProfileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:CollisionProfileName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CollisionProfileName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:bCanAffectNavigation")]
	protected bool CanAffectNavigation
	{
		get
		{
			CheckDestroyed();
			if (!CanAffectNavigation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:bCanAffectNavigation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanAffectNavigation_Offset), 0, CanAffectNavigation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanAffectNavigation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:bCanAffectNavigation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanAffectNavigation_Offset), 0, CanAffectNavigation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510149uL)]
	[UMetaPath("/Script/Water.WaterBodyComponent:WaterNavAreaClass")]
	protected TSubclassOf<UNavAreaBase> WaterNavAreaClass
	{
		get
		{
			CheckDestroyed();
			if (!WaterNavAreaClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterNavAreaClass");
				return default(TSubclassOf<UNavAreaBase>);
			}
			return TSubclassOfMarshaler<UNavAreaBase>.FromNative(IntPtr.Add(base.Address, WaterNavAreaClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterNavAreaClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyComponent:WaterNavAreaClass");
			}
			else
			{
				TSubclassOfMarshaler<UNavAreaBase>.ToNative(IntPtr.Add(base.Address, WaterNavAreaClass_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:OnWaterBodyChanged")]
	public unsafe void OnWaterBodyChanged(bool bShapeOrPositionChanged, bool bWeightmapSettingsChanged = false)
	{
		CheckDestroyed();
		if (!OnWaterBodyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:OnWaterBodyChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWaterBodyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWaterBodyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnWaterBodyChanged_bShapeOrPositionChanged_Offset), 0, OnWaterBodyChanged_bShapeOrPositionChanged_PropertyAddress.Address, bShapeOrPositionChanged);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnWaterBodyChanged_bWeightmapSettingsChanged_Offset), 0, OnWaterBodyChanged_bWeightmapSettingsChanged_PropertyAddress.Address, bWeightmapSettingsChanged);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWaterBodyChanged_FunctionAddress, intPtr, OnWaterBodyChanged_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetWaterWaves")]
	public unsafe UWaterWavesBase GetWaterWaves()
	{
		CheckDestroyed();
		if (!GetWaterWaves_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetWaterWaves");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterWaves_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterWaves_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterWaves_FunctionAddress, intPtr, GetWaterWaves_ParamsSize);
		return UObjectMarshaler<UWaterWavesBase>.FromNative(IntPtr.Add(intPtr, GetWaterWaves_ReturnValue_Offset), 0, GetWaterWaves_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetWaterVelocityAtSplineInputKey")]
	public unsafe float GetWaterVelocityAtSplineInputKey(float InKey)
	{
		CheckDestroyed();
		if (!GetWaterVelocityAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetWaterVelocityAtSplineInputKey");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterVelocityAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterVelocityAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetWaterVelocityAtSplineInputKey_InKey_Offset), 0, GetWaterVelocityAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterVelocityAtSplineInputKey_FunctionAddress, intPtr, GetWaterVelocityAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetWaterVelocityAtSplineInputKey_ReturnValue_Offset), 0, GetWaterVelocityAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetWaterSurfaceInfoAtLocation")]
	public unsafe void GetWaterSurfaceInfoAtLocation(FVector InLocation, out FVector OutWaterSurfaceLocation, out FVector OutWaterSurfaceNormal, out FVector OutWaterVelocity, out float OutWaterDepth, bool bIncludeDepth = false)
	{
		CheckDestroyed();
		if (!GetWaterSurfaceInfoAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetWaterSurfaceInfoAtLocation");
			OutWaterSurfaceLocation = default(FVector);
			OutWaterSurfaceNormal = default(FVector);
			OutWaterVelocity = default(FVector);
			OutWaterDepth = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterSurfaceInfoAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterSurfaceInfoAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetWaterSurfaceInfoAtLocation_InLocation_Offset), 0, GetWaterSurfaceInfoAtLocation_InLocation_PropertyAddress.Address, InLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetWaterSurfaceInfoAtLocation_bIncludeDepth_Offset), 0, GetWaterSurfaceInfoAtLocation_bIncludeDepth_PropertyAddress.Address, bIncludeDepth);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterSurfaceInfoAtLocation_FunctionAddress, intPtr, GetWaterSurfaceInfoAtLocation_ParamsSize);
		OutWaterSurfaceLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetWaterSurfaceInfoAtLocation_OutWaterSurfaceLocation_Offset), 0, GetWaterSurfaceInfoAtLocation_OutWaterSurfaceLocation_PropertyAddress.Address);
		OutWaterSurfaceNormal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetWaterSurfaceInfoAtLocation_OutWaterSurfaceNormal_Offset), 0, GetWaterSurfaceInfoAtLocation_OutWaterSurfaceNormal_PropertyAddress.Address);
		OutWaterVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetWaterSurfaceInfoAtLocation_OutWaterVelocity_Offset), 0, GetWaterSurfaceInfoAtLocation_OutWaterVelocity_PropertyAddress.Address);
		OutWaterDepth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetWaterSurfaceInfoAtLocation_OutWaterDepth_Offset), 0, GetWaterSurfaceInfoAtLocation_OutWaterDepth_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetWaterSpline")]
	public unsafe UWaterSplineComponent GetWaterSpline()
	{
		CheckDestroyed();
		if (!GetWaterSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetWaterSpline");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterSpline_FunctionAddress, intPtr, GetWaterSpline_ParamsSize);
		return UObjectMarshaler<UWaterSplineComponent>.FromNative(IntPtr.Add(intPtr, GetWaterSpline_ReturnValue_Offset), 0, GetWaterSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetWaterMaterialInstance")]
	public unsafe UMaterialInstanceDynamic GetWaterMaterialInstance()
	{
		CheckDestroyed();
		if (!GetWaterMaterialInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetWaterMaterialInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterMaterialInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterMaterialInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterMaterialInstance_FunctionAddress, intPtr, GetWaterMaterialInstance_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetWaterMaterialInstance_ReturnValue_Offset), 0, GetWaterMaterialInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetWaterMaterial")]
	public unsafe UMaterialInterface GetWaterMaterial()
	{
		CheckDestroyed();
		if (!GetWaterMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetWaterMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterMaterial_FunctionAddress, intPtr, GetWaterMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetWaterMaterial_ReturnValue_Offset), 0, GetWaterMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetWaterBodyActor")]
	public unsafe AWaterBody GetWaterBodyActor()
	{
		CheckDestroyed();
		if (!GetWaterBodyActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetWaterBodyActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterBodyActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterBodyActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterBodyActor_FunctionAddress, intPtr, GetWaterBodyActor_ParamsSize);
		return UObjectMarshaler<AWaterBody>.FromNative(IntPtr.Add(intPtr, GetWaterBodyActor_ReturnValue_Offset), 0, GetWaterBodyActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetUnderwaterPostProcessMaterialInstance")]
	public unsafe UMaterialInstanceDynamic GetUnderwaterPostProcessMaterialInstance()
	{
		CheckDestroyed();
		if (!GetUnderwaterPostProcessMaterialInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetUnderwaterPostProcessMaterialInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnderwaterPostProcessMaterialInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnderwaterPostProcessMaterialInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnderwaterPostProcessMaterialInstance_FunctionAddress, intPtr, GetUnderwaterPostProcessMaterialInstance_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetUnderwaterPostProcessMaterialInstance_ReturnValue_Offset), 0, GetUnderwaterPostProcessMaterialInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetStandardRenderableComponents")]
	public unsafe List<UPrimitiveComponent> GetStandardRenderableComponents()
	{
		CheckDestroyed();
		if (!GetStandardRenderableComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetStandardRenderableComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStandardRenderableComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStandardRenderableComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStandardRenderableComponents_FunctionAddress, intPtr, GetStandardRenderableComponents_ParamsSize);
		List<UPrimitiveComponent> result = new TArrayCopyMarshaler<UPrimitiveComponent>(1, GetStandardRenderableComponents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.FromNative, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetStandardRenderableComponents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetStandardRenderableComponents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetRiverToOceanTransitionMaterialInstance")]
	public unsafe UMaterialInstanceDynamic GetRiverToOceanTransitionMaterialInstance()
	{
		CheckDestroyed();
		if (!GetRiverToOceanTransitionMaterialInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetRiverToOceanTransitionMaterialInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRiverToOceanTransitionMaterialInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRiverToOceanTransitionMaterialInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRiverToOceanTransitionMaterialInstance_FunctionAddress, intPtr, GetRiverToOceanTransitionMaterialInstance_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetRiverToOceanTransitionMaterialInstance_ReturnValue_Offset), 0, GetRiverToOceanTransitionMaterialInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetRiverToLakeTransitionMaterialInstance")]
	public unsafe UMaterialInstanceDynamic GetRiverToLakeTransitionMaterialInstance()
	{
		CheckDestroyed();
		if (!GetRiverToLakeTransitionMaterialInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetRiverToLakeTransitionMaterialInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRiverToLakeTransitionMaterialInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRiverToLakeTransitionMaterialInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRiverToLakeTransitionMaterialInstance_FunctionAddress, intPtr, GetRiverToLakeTransitionMaterialInstance_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetRiverToLakeTransitionMaterialInstance_ReturnValue_Offset), 0, GetRiverToLakeTransitionMaterialInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetMaxWaveHeight")]
	public unsafe float GetMaxWaveHeight()
	{
		CheckDestroyed();
		if (!GetMaxWaveHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetMaxWaveHeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxWaveHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxWaveHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxWaveHeight_FunctionAddress, intPtr, GetMaxWaveHeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMaxWaveHeight_ReturnValue_Offset), 0, GetMaxWaveHeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetIslands")]
	public unsafe List<AWaterBodyIsland> GetIslands()
	{
		CheckDestroyed();
		if (!GetIslands_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetIslands");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIslands_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIslands_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIslands_FunctionAddress, intPtr, GetIslands_ParamsSize);
		List<AWaterBodyIsland> result = new TArrayCopyMarshaler<AWaterBodyIsland>(1, GetIslands_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AWaterBodyIsland, UObjectMarshaler<AWaterBodyIsland>>.FromNative, CachedMarshalingDelegates<AWaterBodyIsland, UObjectMarshaler<AWaterBodyIsland>>.ToNative).FromNative(IntPtr.Add(intPtr, GetIslands_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetIslands_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetExclusionVolumes")]
	public unsafe List<AWaterBodyExclusionVolume> GetExclusionVolumes()
	{
		CheckDestroyed();
		if (!GetExclusionVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetExclusionVolumes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExclusionVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExclusionVolumes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExclusionVolumes_FunctionAddress, intPtr, GetExclusionVolumes_ParamsSize);
		List<AWaterBodyExclusionVolume> result = new TArrayCopyMarshaler<AWaterBodyExclusionVolume>(1, GetExclusionVolumes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AWaterBodyExclusionVolume, UObjectMarshaler<AWaterBodyExclusionVolume>>.FromNative, CachedMarshalingDelegates<AWaterBodyExclusionVolume, UObjectMarshaler<AWaterBodyExclusionVolume>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExclusionVolumes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetExclusionVolumes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Water.WaterBodyComponent:GetCollisionComponents")]
	public unsafe List<UPrimitiveComponent> GetCollisionComponents()
	{
		CheckDestroyed();
		if (!GetCollisionComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBodyComponent:GetCollisionComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCollisionComponents_FunctionAddress, intPtr, GetCollisionComponents_ParamsSize);
		List<UPrimitiveComponent> result = new TArrayCopyMarshaler<UPrimitiveComponent>(1, GetCollisionComponents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.FromNative, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCollisionComponents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCollisionComponents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UWaterBodyComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWaterBodyComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWaterBodyComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Water.WaterBodyComponent");
		TargetWaveMaskDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetWaveMaskDepth");
		TargetWaveMaskDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetWaveMaskDepth", Classes.FFloatProperty);
		UnderwaterPostProcessSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnderwaterPostProcessSettings");
		UnderwaterPostProcessSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnderwaterPostProcessSettings", Classes.FStructProperty);
		CurveSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveSettings");
		CurveSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveSettings", Classes.FStructProperty);
		WaterMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterMaterial");
		WaterMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterMaterial", Classes.FObjectProperty);
		UnderwaterPostProcessMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnderwaterPostProcessMaterial");
		UnderwaterPostProcessMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnderwaterPostProcessMaterial", Classes.FObjectProperty);
		WaterHeightmapSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterHeightmapSettings");
		WaterHeightmapSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterHeightmapSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LayerWeightmapSettings_PropertyAddress, intPtr, "LayerWeightmapSettings");
		LayerWeightmapSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LayerWeightmapSettings");
		LayerWeightmapSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LayerWeightmapSettings", Classes.FMapProperty);
		ShapeDilation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShapeDilation");
		ShapeDilation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShapeDilation", Classes.FFloatProperty);
		CollisionHeightOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionHeightOffset");
		CollisionHeightOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionHeightOffset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectsLandscape_PropertyAddress, intPtr, "bAffectsLandscape");
		AffectsLandscape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectsLandscape");
		AffectsLandscape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectsLandscape", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateCollisions_PropertyAddress, intPtr, "bGenerateCollisions");
		GenerateCollisions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateCollisions");
		GenerateCollisions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateCollisions", Classes.FBoolProperty);
		WaterBodyIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterBodyIndex");
		WaterBodyIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterBodyIndex", Classes.FIntProperty);
		WaterMeshOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterMeshOverride");
		WaterMeshOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterMeshOverride", Classes.FObjectProperty);
		OverlapMaterialPriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverlapMaterialPriority");
		OverlapMaterialPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverlapMaterialPriority", Classes.FIntProperty);
		CollisionProfileName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionProfileName");
		CollisionProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CanAffectNavigation_PropertyAddress, intPtr, "bCanAffectNavigation");
		CanAffectNavigation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanAffectNavigation");
		CanAffectNavigation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanAffectNavigation", Classes.FBoolProperty);
		WaterNavAreaClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterNavAreaClass");
		WaterNavAreaClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterNavAreaClass", Classes.FClassProperty);
		OnWaterBodyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnWaterBodyChanged");
		OnWaterBodyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWaterBodyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWaterBodyChanged_bShapeOrPositionChanged_PropertyAddress, OnWaterBodyChanged_FunctionAddress, "bShapeOrPositionChanged");
		OnWaterBodyChanged_bShapeOrPositionChanged_Offset = NativeReflectionCached.GetPropertyOffset(OnWaterBodyChanged_FunctionAddress, "bShapeOrPositionChanged");
		OnWaterBodyChanged_bShapeOrPositionChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWaterBodyChanged_FunctionAddress, "bShapeOrPositionChanged", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnWaterBodyChanged_bWeightmapSettingsChanged_PropertyAddress, OnWaterBodyChanged_FunctionAddress, "bWeightmapSettingsChanged");
		OnWaterBodyChanged_bWeightmapSettingsChanged_Offset = NativeReflectionCached.GetPropertyOffset(OnWaterBodyChanged_FunctionAddress, "bWeightmapSettingsChanged");
		OnWaterBodyChanged_bWeightmapSettingsChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWaterBodyChanged_FunctionAddress, "bWeightmapSettingsChanged", Classes.FBoolProperty);
		OnWaterBodyChanged_IsValid = OnWaterBodyChanged_FunctionAddress != IntPtr.Zero && OnWaterBodyChanged_bShapeOrPositionChanged_IsValid && OnWaterBodyChanged_bWeightmapSettingsChanged_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:OnWaterBodyChanged", OnWaterBodyChanged_IsValid);
		GetWaterWaves_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterWaves");
		GetWaterWaves_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterWaves_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterWaves_ReturnValue_PropertyAddress, GetWaterWaves_FunctionAddress, "ReturnValue");
		GetWaterWaves_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterWaves_FunctionAddress, "ReturnValue");
		GetWaterWaves_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterWaves_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWaterWaves_IsValid = GetWaterWaves_FunctionAddress != IntPtr.Zero && GetWaterWaves_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetWaterWaves", GetWaterWaves_IsValid);
		GetWaterVelocityAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterVelocityAtSplineInputKey");
		GetWaterVelocityAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterVelocityAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterVelocityAtSplineInputKey_InKey_PropertyAddress, GetWaterVelocityAtSplineInputKey_FunctionAddress, "InKey");
		GetWaterVelocityAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterVelocityAtSplineInputKey_FunctionAddress, "InKey");
		GetWaterVelocityAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterVelocityAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterVelocityAtSplineInputKey_ReturnValue_PropertyAddress, GetWaterVelocityAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetWaterVelocityAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterVelocityAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetWaterVelocityAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterVelocityAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetWaterVelocityAtSplineInputKey_IsValid = GetWaterVelocityAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetWaterVelocityAtSplineInputKey_InKey_IsValid && GetWaterVelocityAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetWaterVelocityAtSplineInputKey", GetWaterVelocityAtSplineInputKey_IsValid);
		GetWaterSurfaceInfoAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterSurfaceInfoAtLocation");
		GetWaterSurfaceInfoAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterSurfaceInfoAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterSurfaceInfoAtLocation_InLocation_PropertyAddress, GetWaterSurfaceInfoAtLocation_FunctionAddress, "InLocation");
		GetWaterSurfaceInfoAtLocation_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterSurfaceInfoAtLocation_FunctionAddress, "InLocation");
		GetWaterSurfaceInfoAtLocation_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterSurfaceInfoAtLocation_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterSurfaceInfoAtLocation_OutWaterSurfaceLocation_PropertyAddress, GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterSurfaceLocation");
		GetWaterSurfaceInfoAtLocation_OutWaterSurfaceLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterSurfaceLocation");
		GetWaterSurfaceInfoAtLocation_OutWaterSurfaceLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterSurfaceLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterSurfaceInfoAtLocation_OutWaterSurfaceNormal_PropertyAddress, GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterSurfaceNormal");
		GetWaterSurfaceInfoAtLocation_OutWaterSurfaceNormal_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterSurfaceNormal");
		GetWaterSurfaceInfoAtLocation_OutWaterSurfaceNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterSurfaceNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterSurfaceInfoAtLocation_OutWaterVelocity_PropertyAddress, GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterVelocity");
		GetWaterSurfaceInfoAtLocation_OutWaterVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterVelocity");
		GetWaterSurfaceInfoAtLocation_OutWaterVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterVelocity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterSurfaceInfoAtLocation_OutWaterDepth_PropertyAddress, GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterDepth");
		GetWaterSurfaceInfoAtLocation_OutWaterDepth_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterDepth");
		GetWaterSurfaceInfoAtLocation_OutWaterDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterSurfaceInfoAtLocation_FunctionAddress, "OutWaterDepth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterSurfaceInfoAtLocation_bIncludeDepth_PropertyAddress, GetWaterSurfaceInfoAtLocation_FunctionAddress, "bIncludeDepth");
		GetWaterSurfaceInfoAtLocation_bIncludeDepth_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterSurfaceInfoAtLocation_FunctionAddress, "bIncludeDepth");
		GetWaterSurfaceInfoAtLocation_bIncludeDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterSurfaceInfoAtLocation_FunctionAddress, "bIncludeDepth", Classes.FBoolProperty);
		GetWaterSurfaceInfoAtLocation_IsValid = GetWaterSurfaceInfoAtLocation_FunctionAddress != IntPtr.Zero && GetWaterSurfaceInfoAtLocation_InLocation_IsValid && GetWaterSurfaceInfoAtLocation_OutWaterSurfaceLocation_IsValid && GetWaterSurfaceInfoAtLocation_OutWaterSurfaceNormal_IsValid && GetWaterSurfaceInfoAtLocation_OutWaterVelocity_IsValid && GetWaterSurfaceInfoAtLocation_OutWaterDepth_IsValid && GetWaterSurfaceInfoAtLocation_bIncludeDepth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetWaterSurfaceInfoAtLocation", GetWaterSurfaceInfoAtLocation_IsValid);
		GetWaterSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterSpline");
		GetWaterSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterSpline_ReturnValue_PropertyAddress, GetWaterSpline_FunctionAddress, "ReturnValue");
		GetWaterSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterSpline_FunctionAddress, "ReturnValue");
		GetWaterSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterSpline_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWaterSpline_IsValid = GetWaterSpline_FunctionAddress != IntPtr.Zero && GetWaterSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetWaterSpline", GetWaterSpline_IsValid);
		GetWaterMaterialInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterMaterialInstance");
		GetWaterMaterialInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterMaterialInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterMaterialInstance_ReturnValue_PropertyAddress, GetWaterMaterialInstance_FunctionAddress, "ReturnValue");
		GetWaterMaterialInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterMaterialInstance_FunctionAddress, "ReturnValue");
		GetWaterMaterialInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterMaterialInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWaterMaterialInstance_IsValid = GetWaterMaterialInstance_FunctionAddress != IntPtr.Zero && GetWaterMaterialInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetWaterMaterialInstance", GetWaterMaterialInstance_IsValid);
		GetWaterMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterMaterial");
		GetWaterMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterMaterial_ReturnValue_PropertyAddress, GetWaterMaterial_FunctionAddress, "ReturnValue");
		GetWaterMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterMaterial_FunctionAddress, "ReturnValue");
		GetWaterMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWaterMaterial_IsValid = GetWaterMaterial_FunctionAddress != IntPtr.Zero && GetWaterMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetWaterMaterial", GetWaterMaterial_IsValid);
		GetWaterBodyActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterBodyActor");
		GetWaterBodyActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterBodyActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterBodyActor_ReturnValue_PropertyAddress, GetWaterBodyActor_FunctionAddress, "ReturnValue");
		GetWaterBodyActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterBodyActor_FunctionAddress, "ReturnValue");
		GetWaterBodyActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterBodyActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWaterBodyActor_IsValid = GetWaterBodyActor_FunctionAddress != IntPtr.Zero && GetWaterBodyActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetWaterBodyActor", GetWaterBodyActor_IsValid);
		GetUnderwaterPostProcessMaterialInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnderwaterPostProcessMaterialInstance");
		GetUnderwaterPostProcessMaterialInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnderwaterPostProcessMaterialInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnderwaterPostProcessMaterialInstance_ReturnValue_PropertyAddress, GetUnderwaterPostProcessMaterialInstance_FunctionAddress, "ReturnValue");
		GetUnderwaterPostProcessMaterialInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnderwaterPostProcessMaterialInstance_FunctionAddress, "ReturnValue");
		GetUnderwaterPostProcessMaterialInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnderwaterPostProcessMaterialInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetUnderwaterPostProcessMaterialInstance_IsValid = GetUnderwaterPostProcessMaterialInstance_FunctionAddress != IntPtr.Zero && GetUnderwaterPostProcessMaterialInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetUnderwaterPostProcessMaterialInstance", GetUnderwaterPostProcessMaterialInstance_IsValid);
		GetStandardRenderableComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStandardRenderableComponents");
		GetStandardRenderableComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStandardRenderableComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStandardRenderableComponents_ReturnValue_PropertyAddress, GetStandardRenderableComponents_FunctionAddress, "ReturnValue");
		GetStandardRenderableComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStandardRenderableComponents_FunctionAddress, "ReturnValue");
		GetStandardRenderableComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStandardRenderableComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetStandardRenderableComponents_IsValid = GetStandardRenderableComponents_FunctionAddress != IntPtr.Zero && GetStandardRenderableComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetStandardRenderableComponents", GetStandardRenderableComponents_IsValid);
		GetRiverToOceanTransitionMaterialInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRiverToOceanTransitionMaterialInstance");
		GetRiverToOceanTransitionMaterialInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRiverToOceanTransitionMaterialInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRiverToOceanTransitionMaterialInstance_ReturnValue_PropertyAddress, GetRiverToOceanTransitionMaterialInstance_FunctionAddress, "ReturnValue");
		GetRiverToOceanTransitionMaterialInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRiverToOceanTransitionMaterialInstance_FunctionAddress, "ReturnValue");
		GetRiverToOceanTransitionMaterialInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRiverToOceanTransitionMaterialInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRiverToOceanTransitionMaterialInstance_IsValid = GetRiverToOceanTransitionMaterialInstance_FunctionAddress != IntPtr.Zero && GetRiverToOceanTransitionMaterialInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetRiverToOceanTransitionMaterialInstance", GetRiverToOceanTransitionMaterialInstance_IsValid);
		GetRiverToLakeTransitionMaterialInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRiverToLakeTransitionMaterialInstance");
		GetRiverToLakeTransitionMaterialInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRiverToLakeTransitionMaterialInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRiverToLakeTransitionMaterialInstance_ReturnValue_PropertyAddress, GetRiverToLakeTransitionMaterialInstance_FunctionAddress, "ReturnValue");
		GetRiverToLakeTransitionMaterialInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRiverToLakeTransitionMaterialInstance_FunctionAddress, "ReturnValue");
		GetRiverToLakeTransitionMaterialInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRiverToLakeTransitionMaterialInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRiverToLakeTransitionMaterialInstance_IsValid = GetRiverToLakeTransitionMaterialInstance_FunctionAddress != IntPtr.Zero && GetRiverToLakeTransitionMaterialInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetRiverToLakeTransitionMaterialInstance", GetRiverToLakeTransitionMaterialInstance_IsValid);
		GetMaxWaveHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxWaveHeight");
		GetMaxWaveHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxWaveHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxWaveHeight_ReturnValue_PropertyAddress, GetMaxWaveHeight_FunctionAddress, "ReturnValue");
		GetMaxWaveHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxWaveHeight_FunctionAddress, "ReturnValue");
		GetMaxWaveHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxWaveHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMaxWaveHeight_IsValid = GetMaxWaveHeight_FunctionAddress != IntPtr.Zero && GetMaxWaveHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetMaxWaveHeight", GetMaxWaveHeight_IsValid);
		GetIslands_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIslands");
		GetIslands_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIslands_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIslands_ReturnValue_PropertyAddress, GetIslands_FunctionAddress, "ReturnValue");
		GetIslands_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIslands_FunctionAddress, "ReturnValue");
		GetIslands_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIslands_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetIslands_IsValid = GetIslands_FunctionAddress != IntPtr.Zero && GetIslands_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetIslands", GetIslands_IsValid);
		GetExclusionVolumes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExclusionVolumes");
		GetExclusionVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExclusionVolumes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExclusionVolumes_ReturnValue_PropertyAddress, GetExclusionVolumes_FunctionAddress, "ReturnValue");
		GetExclusionVolumes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExclusionVolumes_FunctionAddress, "ReturnValue");
		GetExclusionVolumes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExclusionVolumes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetExclusionVolumes_IsValid = GetExclusionVolumes_FunctionAddress != IntPtr.Zero && GetExclusionVolumes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetExclusionVolumes", GetExclusionVolumes_IsValid);
		GetCollisionComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCollisionComponents");
		GetCollisionComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionComponents_ReturnValue_PropertyAddress, GetCollisionComponents_FunctionAddress, "ReturnValue");
		GetCollisionComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionComponents_FunctionAddress, "ReturnValue");
		GetCollisionComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCollisionComponents_IsValid = GetCollisionComponents_FunctionAddress != IntPtr.Zero && GetCollisionComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBodyComponent:GetCollisionComponents", GetCollisionComponents_IsValid);
	}
}
