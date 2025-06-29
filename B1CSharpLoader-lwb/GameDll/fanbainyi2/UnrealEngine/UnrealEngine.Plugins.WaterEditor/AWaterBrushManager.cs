using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Water;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.WaterEditor;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/WaterEditor.WaterBrushManager", "WaterEditor", UnrealModuleType.EnginePlugin)]
public class AWaterBrushManager : AWaterLandscapeBrush
{
	private static bool BrushAngleFalloffMaterial_IsValid;

	private static int BrushAngleFalloffMaterial_Offset;

	private static bool BrushWidthFalloffMaterial_IsValid;

	private static int BrushWidthFalloffMaterial_Offset;

	private static bool DistanceFieldCacheMaterial_IsValid;

	private static int DistanceFieldCacheMaterial_Offset;

	private static bool RenderRiverSplineDepthMaterial_IsValid;

	private static int RenderRiverSplineDepthMaterial_Offset;

	private static bool DebugDistanceFieldMaterial_IsValid;

	private static int DebugDistanceFieldMaterial_Offset;

	private static bool WeightmapMaterial_IsValid;

	private static int WeightmapMaterial_Offset;

	private static bool DrawCanvasMaterial_IsValid;

	private static int DrawCanvasMaterial_Offset;

	private static bool CompositeWaterBodyTextureMaterial_IsValid;

	private static int CompositeWaterBodyTextureMaterial_Offset;

	private static bool IslandFalloffMaterial_IsValid;

	private static int IslandFalloffMaterial_Offset;

	private static bool FinalizeVelocityHeightMaterial_IsValid;

	private static int FinalizeVelocityHeightMaterial_Offset;

	private static bool JumpStepMaterial_IsValid;

	private static int JumpStepMaterial_Offset;

	private static bool FindEdgesMaterial_IsValid;

	private static int FindEdgesMaterial_Offset;

	private static bool BlurEdgesMaterial_IsValid;

	private static int BlurEdgesMaterial_Offset;

	private static bool BrushAngleFalloffMID_IsValid;

	private static int BrushAngleFalloffMID_Offset;

	private static bool BrushWidthFalloffMID_IsValid;

	private static int BrushWidthFalloffMID_Offset;

	private static bool DistanceFieldCacheMID_IsValid;

	private static int DistanceFieldCacheMID_Offset;

	private static bool RiverSplineMIDs_IsValid;

	private static FFieldAddress RiverSplineMIDs_PropertyAddress;

	private static int RiverSplineMIDs_Offset;

	private TArrayReadWriteMarshaler<UMaterialInstanceDynamic> RiverSplineMIDs_MarshalerCached;

	private static bool DebugDistanceFieldMID_IsValid;

	private static int DebugDistanceFieldMID_Offset;

	private static bool WeightmapMID_IsValid;

	private static int WeightmapMID_Offset;

	private static bool DrawCanvasMID_IsValid;

	private static int DrawCanvasMID_Offset;

	private static bool CompositeWaterBodyTextureMID_IsValid;

	private static int CompositeWaterBodyTextureMID_Offset;

	private static bool IslandFalloffMID_IsValid;

	private static int IslandFalloffMID_Offset;

	private static bool FinalizeVelocityHeightMID_IsValid;

	private static int FinalizeVelocityHeightMID_Offset;

	private static bool BrushCurveRTCache_IsValid;

	private static FFieldAddress BrushCurveRTCache_PropertyAddress;

	private static int BrushCurveRTCache_Offset;

	private TMapReadWriteMarshaler<UCurveFloat, FWaterBodyBrushCache> BrushCurveRTCache_MarshalerCached;

	private static bool WorldSize_IsValid;

	private static int WorldSize_Offset;

	private static bool LandscapeRTRes_IsValid;

	private static int LandscapeRTRes_Offset;

	private static bool LandscapeQuads_IsValid;

	private static int LandscapeQuads_Offset;

	private static bool LandscapeTransform_IsValid;

	private static int LandscapeTransform_Offset;

	private static bool ShowGradient_IsValid;

	private static FFieldAddress ShowGradient_PropertyAddress;

	private static int ShowGradient_Offset;

	private static bool DistanceDivisor_IsValid;

	private static int DistanceDivisor_Offset;

	private static bool ShowDistance_IsValid;

	private static FFieldAddress ShowDistance_PropertyAddress;

	private static int ShowDistance_Offset;

	private static bool ShowGrid_IsValid;

	private static FFieldAddress ShowGrid_PropertyAddress;

	private static int ShowGrid_Offset;

	private static bool CanvasSegmentSize_IsValid;

	private static int CanvasSegmentSize_Offset;

	private static bool WaterClearHeight_IsValid;

	private static int WaterClearHeight_Offset;

	private static bool SplineMeshExtension_IsValid;

	private static int SplineMeshExtension_Offset;

	private static bool UseDynamicPreviewRT_IsValid;

	private static FFieldAddress UseDynamicPreviewRT_PropertyAddress;

	private static int UseDynamicPreviewRT_Offset;

	private static bool DisableBrushTextureEffects_IsValid;

	private static FFieldAddress DisableBrushTextureEffects_PropertyAddress;

	private static int DisableBrushTextureEffects_Offset;

	private static bool SortWaterBodiesForBrushRender_IsValid;

	private IntPtr SortWaterBodiesForBrushRender_InstanceFunctionAddress;

	private static IntPtr SortWaterBodiesForBrushRender_FunctionAddress;

	private static int SortWaterBodiesForBrushRender_ParamsSize;

	private static bool SortWaterBodiesForBrushRender_InOutWaterBodies_IsValid;

	private static FFieldAddress SortWaterBodiesForBrushRender_InOutWaterBodies_PropertyAddress;

	private static int SortWaterBodiesForBrushRender_InOutWaterBodies_Offset;

	private static bool SingleJumpStep_IsValid;

	private static IntPtr SingleJumpStep_FunctionAddress;

	private static int SingleJumpStep_ParamsSize;

	private static bool SingleBlurStep_IsValid;

	private static IntPtr SingleBlurStep_FunctionAddress;

	private static int SingleBlurStep_ParamsSize;

	private static bool SetupDefaultMaterials_IsValid;

	private static IntPtr SetupDefaultMaterials_FunctionAddress;

	private static int SetupDefaultMaterials_ParamsSize;

	private static bool GetWaterCacheKey_IsValid;

	private static IntPtr GetWaterCacheKey_FunctionAddress;

	private static int GetWaterCacheKey_ParamsSize;

	private static bool GetWaterCacheKey_WaterBrush_IsValid;

	private static FFieldAddress GetWaterCacheKey_WaterBrush_PropertyAddress;

	private static int GetWaterCacheKey_WaterBrush_Offset;

	private static bool GetWaterCacheKey_ContainerObject_IsValid;

	private static FFieldAddress GetWaterCacheKey_ContainerObject_PropertyAddress;

	private static int GetWaterCacheKey_ContainerObject_Offset;

	private static bool GetWaterCacheKey_Value_IsValid;

	private static FFieldAddress GetWaterCacheKey_Value_PropertyAddress;

	private static int GetWaterCacheKey_Value_Offset;

	private static bool ForceUpdate_IsValid;

	private static IntPtr ForceUpdate_FunctionAddress;

	private static int ForceUpdate_ParamsSize;

	private static bool FindEdges_IsValid;

	private static IntPtr FindEdges_FunctionAddress;

	private static int FindEdges_ParamsSize;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:BrushAngleFalloffMaterial")]
	public UMaterialInterface BrushAngleFalloffMaterial
	{
		get
		{
			CheckDestroyed();
			if (!BrushAngleFalloffMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BrushAngleFalloffMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, BrushAngleFalloffMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushAngleFalloffMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BrushAngleFalloffMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, BrushAngleFalloffMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:BrushWidthFalloffMaterial")]
	public UMaterialInterface BrushWidthFalloffMaterial
	{
		get
		{
			CheckDestroyed();
			if (!BrushWidthFalloffMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BrushWidthFalloffMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, BrushWidthFalloffMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushWidthFalloffMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BrushWidthFalloffMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, BrushWidthFalloffMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:DistanceFieldCacheMaterial")]
	public UMaterialInterface DistanceFieldCacheMaterial
	{
		get
		{
			CheckDestroyed();
			if (!DistanceFieldCacheMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DistanceFieldCacheMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, DistanceFieldCacheMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceFieldCacheMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DistanceFieldCacheMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, DistanceFieldCacheMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:RenderRiverSplineDepthMaterial")]
	public UMaterialInterface RenderRiverSplineDepthMaterial
	{
		get
		{
			CheckDestroyed();
			if (!RenderRiverSplineDepthMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:RenderRiverSplineDepthMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, RenderRiverSplineDepthMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderRiverSplineDepthMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:RenderRiverSplineDepthMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, RenderRiverSplineDepthMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:DebugDistanceFieldMaterial")]
	public UMaterialInterface DebugDistanceFieldMaterial
	{
		get
		{
			CheckDestroyed();
			if (!DebugDistanceFieldMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DebugDistanceFieldMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, DebugDistanceFieldMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugDistanceFieldMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DebugDistanceFieldMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, DebugDistanceFieldMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:WeightmapMaterial")]
	public UMaterialInterface WeightmapMaterial
	{
		get
		{
			CheckDestroyed();
			if (!WeightmapMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:WeightmapMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, WeightmapMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeightmapMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:WeightmapMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, WeightmapMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:DrawCanvasMaterial")]
	public UMaterialInterface DrawCanvasMaterial
	{
		get
		{
			CheckDestroyed();
			if (!DrawCanvasMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DrawCanvasMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, DrawCanvasMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrawCanvasMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DrawCanvasMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, DrawCanvasMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:CompositeWaterBodyTextureMaterial")]
	public UMaterialInterface CompositeWaterBodyTextureMaterial
	{
		get
		{
			CheckDestroyed();
			if (!CompositeWaterBodyTextureMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:CompositeWaterBodyTextureMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, CompositeWaterBodyTextureMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompositeWaterBodyTextureMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:CompositeWaterBodyTextureMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, CompositeWaterBodyTextureMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:IslandFalloffMaterial")]
	public UMaterialInterface IslandFalloffMaterial
	{
		get
		{
			CheckDestroyed();
			if (!IslandFalloffMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:IslandFalloffMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, IslandFalloffMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IslandFalloffMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:IslandFalloffMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, IslandFalloffMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:FinalizeVelocityHeightMaterial")]
	public UMaterialInterface FinalizeVelocityHeightMaterial
	{
		get
		{
			CheckDestroyed();
			if (!FinalizeVelocityHeightMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:FinalizeVelocityHeightMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, FinalizeVelocityHeightMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinalizeVelocityHeightMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:FinalizeVelocityHeightMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, FinalizeVelocityHeightMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:JumpStepMaterial")]
	public UMaterialInterface JumpStepMaterial
	{
		get
		{
			CheckDestroyed();
			if (!JumpStepMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:JumpStepMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, JumpStepMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpStepMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:JumpStepMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, JumpStepMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:FindEdgesMaterial")]
	public UMaterialInterface FindEdgesMaterial
	{
		get
		{
			CheckDestroyed();
			if (!FindEdgesMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:FindEdgesMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, FindEdgesMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FindEdgesMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:FindEdgesMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, FindEdgesMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:BlurEdgesMaterial")]
	public UMaterialInterface BlurEdgesMaterial
	{
		get
		{
			CheckDestroyed();
			if (!BlurEdgesMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BlurEdgesMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, BlurEdgesMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlurEdgesMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BlurEdgesMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, BlurEdgesMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280796165uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:BrushAngleFalloffMID")]
	public UMaterialInstanceDynamic BrushAngleFalloffMID
	{
		get
		{
			CheckDestroyed();
			if (!BrushAngleFalloffMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BrushAngleFalloffMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, BrushAngleFalloffMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushAngleFalloffMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BrushAngleFalloffMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, BrushAngleFalloffMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280796165uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:BrushWidthFalloffMID")]
	public UMaterialInstanceDynamic BrushWidthFalloffMID
	{
		get
		{
			CheckDestroyed();
			if (!BrushWidthFalloffMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BrushWidthFalloffMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, BrushWidthFalloffMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushWidthFalloffMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BrushWidthFalloffMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, BrushWidthFalloffMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280796165uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:DistanceFieldCacheMID")]
	public UMaterialInstanceDynamic DistanceFieldCacheMID
	{
		get
		{
			CheckDestroyed();
			if (!DistanceFieldCacheMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DistanceFieldCacheMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, DistanceFieldCacheMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceFieldCacheMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DistanceFieldCacheMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, DistanceFieldCacheMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4507997673892357uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:RiverSplineMIDs")]
	public TArrayReadWrite<UMaterialInstanceDynamic> RiverSplineMIDs
	{
		get
		{
			CheckDestroyed();
			if (!RiverSplineMIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:RiverSplineMIDs");
				return null;
			}
			if (RiverSplineMIDs_MarshalerCached == null)
			{
				RiverSplineMIDs_MarshalerCached = new TArrayReadWriteMarshaler<UMaterialInstanceDynamic>(1, RiverSplineMIDs_PropertyAddress, CachedMarshalingDelegates<UMaterialInstanceDynamic, UObjectMarshaler<UMaterialInstanceDynamic>>.FromNative, CachedMarshalingDelegates<UMaterialInstanceDynamic, UObjectMarshaler<UMaterialInstanceDynamic>>.ToNative);
			}
			return RiverSplineMIDs_MarshalerCached.FromNative(IntPtr.Add(base.Address, RiverSplineMIDs_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6759867280796165uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:DebugDistanceFieldMID")]
	public UMaterialInstanceDynamic DebugDistanceFieldMID
	{
		get
		{
			CheckDestroyed();
			if (!DebugDistanceFieldMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DebugDistanceFieldMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, DebugDistanceFieldMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugDistanceFieldMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DebugDistanceFieldMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, DebugDistanceFieldMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280796165uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:WeightmapMID")]
	public UMaterialInstanceDynamic WeightmapMID
	{
		get
		{
			CheckDestroyed();
			if (!WeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:WeightmapMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, WeightmapMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:WeightmapMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, WeightmapMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280796165uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:DrawCanvasMID")]
	public UMaterialInstanceDynamic DrawCanvasMID
	{
		get
		{
			CheckDestroyed();
			if (!DrawCanvasMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DrawCanvasMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, DrawCanvasMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrawCanvasMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DrawCanvasMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, DrawCanvasMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280796165uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:CompositeWaterBodyTextureMID")]
	public UMaterialInstanceDynamic CompositeWaterBodyTextureMID
	{
		get
		{
			CheckDestroyed();
			if (!CompositeWaterBodyTextureMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:CompositeWaterBodyTextureMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, CompositeWaterBodyTextureMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompositeWaterBodyTextureMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:CompositeWaterBodyTextureMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, CompositeWaterBodyTextureMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280796165uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:IslandFalloffMID")]
	public UMaterialInstanceDynamic IslandFalloffMID
	{
		get
		{
			CheckDestroyed();
			if (!IslandFalloffMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:IslandFalloffMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, IslandFalloffMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IslandFalloffMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:IslandFalloffMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, IslandFalloffMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280796165uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:FinalizeVelocityHeightMID")]
	public UMaterialInstanceDynamic FinalizeVelocityHeightMID
	{
		get
		{
			CheckDestroyed();
			if (!FinalizeVelocityHeightMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:FinalizeVelocityHeightMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, FinalizeVelocityHeightMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinalizeVelocityHeightMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:FinalizeVelocityHeightMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, FinalizeVelocityHeightMID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627509765uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:BrushCurveRTCache")]
	public TMapReadWrite<UCurveFloat, FWaterBodyBrushCache> BrushCurveRTCache
	{
		get
		{
			CheckDestroyed();
			if (!BrushCurveRTCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:BrushCurveRTCache");
				return null;
			}
			if (BrushCurveRTCache_MarshalerCached == null)
			{
				BrushCurveRTCache_MarshalerCached = new TMapReadWriteMarshaler<UCurveFloat, FWaterBodyBrushCache>(1, BrushCurveRTCache_PropertyAddress, CachedMarshalingDelegates<UCurveFloat, UObjectMarshaler<UCurveFloat>>.FromNative, CachedMarshalingDelegates<UCurveFloat, UObjectMarshaler<UCurveFloat>>.ToNative, CachedMarshalingDelegates<FWaterBodyBrushCache, FWaterBodyBrushCache>.FromNative, CachedMarshalingDelegates<FWaterBodyBrushCache, FWaterBodyBrushCache>.ToNative);
			}
			return BrushCurveRTCache_MarshalerCached.FromNative(IntPtr.Add(base.Address, BrushCurveRTCache_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:WorldSize")]
	public FVector WorldSize
	{
		get
		{
			CheckDestroyed();
			if (!WorldSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:WorldSize");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, WorldSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WorldSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:WorldSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, WorldSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:LandscapeRTRes")]
	public FIntPoint LandscapeRTRes
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeRTRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:LandscapeRTRes");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, LandscapeRTRes_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeRTRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:LandscapeRTRes");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, LandscapeRTRes_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:LandscapeQuads")]
	public FIntPoint LandscapeQuads
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeQuads_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:LandscapeQuads");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, LandscapeQuads_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeQuads_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:LandscapeQuads");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, LandscapeQuads_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420720149uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:LandscapeTransform")]
	public FTransform LandscapeTransform
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:LandscapeTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, LandscapeTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:LandscapeTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, LandscapeTransform_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:ShowGradient")]
	public bool ShowGradient
	{
		get
		{
			CheckDestroyed();
			if (!ShowGradient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:ShowGradient");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowGradient_Offset), 0, ShowGradient_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowGradient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:ShowGradient");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowGradient_Offset), 0, ShowGradient_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:DistanceDivisor")]
	public float DistanceDivisor
	{
		get
		{
			CheckDestroyed();
			if (!DistanceDivisor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DistanceDivisor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceDivisor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceDivisor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DistanceDivisor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceDivisor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:ShowDistance")]
	public bool ShowDistance
	{
		get
		{
			CheckDestroyed();
			if (!ShowDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:ShowDistance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowDistance_Offset), 0, ShowDistance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:ShowDistance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowDistance_Offset), 0, ShowDistance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:ShowGrid")]
	public bool ShowGrid
	{
		get
		{
			CheckDestroyed();
			if (!ShowGrid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:ShowGrid");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowGrid_Offset), 0, ShowGrid_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowGrid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:ShowGrid");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowGrid_Offset), 0, ShowGrid_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:CanvasSegmentSize")]
	public float CanvasSegmentSize
	{
		get
		{
			CheckDestroyed();
			if (!CanvasSegmentSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:CanvasSegmentSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CanvasSegmentSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CanvasSegmentSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:CanvasSegmentSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CanvasSegmentSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:WaterClearHeight")]
	public float WaterClearHeight
	{
		get
		{
			CheckDestroyed();
			if (!WaterClearHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:WaterClearHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WaterClearHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterClearHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:WaterClearHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WaterClearHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:SplineMeshExtension")]
	public float SplineMeshExtension
	{
		get
		{
			CheckDestroyed();
			if (!SplineMeshExtension_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:SplineMeshExtension");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SplineMeshExtension_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineMeshExtension_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:SplineMeshExtension");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SplineMeshExtension_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:UseDynamicPreviewRT")]
	public bool UseDynamicPreviewRT
	{
		get
		{
			CheckDestroyed();
			if (!UseDynamicPreviewRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:UseDynamicPreviewRT");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseDynamicPreviewRT_Offset), 0, UseDynamicPreviewRT_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseDynamicPreviewRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:UseDynamicPreviewRT");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseDynamicPreviewRT_Offset), 0, UseDynamicPreviewRT_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:DisableBrushTextureEffects")]
	public bool DisableBrushTextureEffects
	{
		get
		{
			CheckDestroyed();
			if (!DisableBrushTextureEffects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DisableBrushTextureEffects");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableBrushTextureEffects_Offset), 0, DisableBrushTextureEffects_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableBrushTextureEffects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBrushManager:DisableBrushTextureEffects");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableBrushTextureEffects_Offset), 0, DisableBrushTextureEffects_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:SortWaterBodiesForBrushRender")]
	public unsafe void SortWaterBodiesForBrushRender(out List<AWaterBody> InOutWaterBodies)
	{
		CheckDestroyed();
		if (!SortWaterBodiesForBrushRender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterBrushManager:SortWaterBodiesForBrushRender");
			InOutWaterBodies = null;
			return;
		}
		if (SortWaterBodiesForBrushRender_InstanceFunctionAddress == IntPtr.Zero)
		{
			SortWaterBodiesForBrushRender_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SortWaterBodiesForBrushRender");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortWaterBodiesForBrushRender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortWaterBodiesForBrushRender_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortWaterBodiesForBrushRender_InstanceFunctionAddress, intPtr, SortWaterBodiesForBrushRender_ParamsSize);
		InOutWaterBodies = new TArrayCopyMarshaler<AWaterBody>(1, SortWaterBodiesForBrushRender_InOutWaterBodies_PropertyAddress, CachedMarshalingDelegates<AWaterBody, UObjectMarshaler<AWaterBody>>.FromNative, CachedMarshalingDelegates<AWaterBody, UObjectMarshaler<AWaterBody>>.ToNative).FromNative(IntPtr.Add(intPtr, SortWaterBodiesForBrushRender_InOutWaterBodies_Offset));
		NativeReflection.DestroyValue_InContainer(SortWaterBodiesForBrushRender_InOutWaterBodies_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void SortWaterBodiesForBrushRender_Implementation(out List<AWaterBody> InOutWaterBodies)
	{
		CheckDestroyed();
		if (!SortWaterBodiesForBrushRender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterBrushManager:SortWaterBodiesForBrushRender");
			InOutWaterBodies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortWaterBodiesForBrushRender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortWaterBodiesForBrushRender_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortWaterBodiesForBrushRender_FunctionAddress, intPtr, SortWaterBodiesForBrushRender_ParamsSize);
		InOutWaterBodies = new TArrayCopyMarshaler<AWaterBody>(1, SortWaterBodiesForBrushRender_InOutWaterBodies_PropertyAddress, CachedMarshalingDelegates<AWaterBody, UObjectMarshaler<AWaterBody>>.FromNative, CachedMarshalingDelegates<AWaterBody, UObjectMarshaler<AWaterBody>>.ToNative).FromNative(IntPtr.Add(intPtr, SortWaterBodiesForBrushRender_InOutWaterBodies_Offset));
		NativeReflection.DestroyValue_InContainer(SortWaterBodiesForBrushRender_InOutWaterBodies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:SingleJumpStep")]
	public unsafe void SingleJumpStep()
	{
		CheckDestroyed();
		if (!SingleJumpStep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterBrushManager:SingleJumpStep");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SingleJumpStep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SingleJumpStep_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SingleJumpStep_FunctionAddress, argsSize: SingleJumpStep_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:SingleBlurStep")]
	public unsafe void SingleBlurStep()
	{
		CheckDestroyed();
		if (!SingleBlurStep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterBrushManager:SingleBlurStep");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SingleBlurStep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SingleBlurStep_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SingleBlurStep_FunctionAddress, argsSize: SingleBlurStep_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:SetupDefaultMaterials")]
	public unsafe void SetupDefaultMaterials()
	{
		CheckDestroyed();
		if (!SetupDefaultMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterBrushManager:SetupDefaultMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetupDefaultMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetupDefaultMaterials_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetupDefaultMaterials_FunctionAddress, argsSize: SetupDefaultMaterials_ParamsSize);
	}

	[UFunction(Flags = 339870720u)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:GetWaterCacheKey")]
	public unsafe void GetWaterCacheKey(AActor WaterBrush, out UWaterBodyBrushCacheContainer ContainerObject, out FWaterBodyBrushCache Value)
	{
		CheckDestroyed();
		if (!GetWaterCacheKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterBrushManager:GetWaterCacheKey");
			ContainerObject = null;
			Value = default(FWaterBodyBrushCache);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterCacheKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterCacheKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetWaterCacheKey_WaterBrush_Offset), 0, GetWaterCacheKey_WaterBrush_PropertyAddress.Address, WaterBrush);
		NativeReflection.InitializeValue_InContainer(GetWaterCacheKey_Value_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterCacheKey_FunctionAddress, intPtr, GetWaterCacheKey_ParamsSize);
		ContainerObject = UObjectMarshaler<UWaterBodyBrushCacheContainer>.FromNative(IntPtr.Add(intPtr, GetWaterCacheKey_ContainerObject_Offset), 0, GetWaterCacheKey_ContainerObject_PropertyAddress.Address);
		Value = FWaterBodyBrushCache.FromNative(IntPtr.Add(intPtr, GetWaterCacheKey_Value_Offset), 0, GetWaterCacheKey_Value_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:ForceUpdate")]
	public unsafe void ForceUpdate()
	{
		CheckDestroyed();
		if (!ForceUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterBrushManager:ForceUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceUpdate_FunctionAddress, argsSize: ForceUpdate_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/WaterEditor.WaterBrushManager:FindEdges")]
	public unsafe void FindEdges()
	{
		CheckDestroyed();
		if (!FindEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterBrushManager:FindEdges");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindEdges_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FindEdges_FunctionAddress, argsSize: FindEdges_ParamsSize);
	}

	static AWaterBrushManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AWaterBrushManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AWaterBrushManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/WaterEditor.WaterBrushManager");
		BrushAngleFalloffMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushAngleFalloffMaterial");
		BrushAngleFalloffMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushAngleFalloffMaterial", Classes.FObjectProperty);
		BrushWidthFalloffMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushWidthFalloffMaterial");
		BrushWidthFalloffMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushWidthFalloffMaterial", Classes.FObjectProperty);
		DistanceFieldCacheMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceFieldCacheMaterial");
		DistanceFieldCacheMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceFieldCacheMaterial", Classes.FObjectProperty);
		RenderRiverSplineDepthMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderRiverSplineDepthMaterial");
		RenderRiverSplineDepthMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderRiverSplineDepthMaterial", Classes.FObjectProperty);
		DebugDistanceFieldMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugDistanceFieldMaterial");
		DebugDistanceFieldMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugDistanceFieldMaterial", Classes.FObjectProperty);
		WeightmapMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeightmapMaterial");
		WeightmapMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeightmapMaterial", Classes.FObjectProperty);
		DrawCanvasMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawCanvasMaterial");
		DrawCanvasMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawCanvasMaterial", Classes.FObjectProperty);
		CompositeWaterBodyTextureMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CompositeWaterBodyTextureMaterial");
		CompositeWaterBodyTextureMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CompositeWaterBodyTextureMaterial", Classes.FObjectProperty);
		IslandFalloffMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IslandFalloffMaterial");
		IslandFalloffMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IslandFalloffMaterial", Classes.FObjectProperty);
		FinalizeVelocityHeightMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FinalizeVelocityHeightMaterial");
		FinalizeVelocityHeightMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FinalizeVelocityHeightMaterial", Classes.FObjectProperty);
		JumpStepMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpStepMaterial");
		JumpStepMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpStepMaterial", Classes.FObjectProperty);
		FindEdgesMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FindEdgesMaterial");
		FindEdgesMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FindEdgesMaterial", Classes.FObjectProperty);
		BlurEdgesMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlurEdgesMaterial");
		BlurEdgesMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlurEdgesMaterial", Classes.FObjectProperty);
		BrushAngleFalloffMID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushAngleFalloffMID");
		BrushAngleFalloffMID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushAngleFalloffMID", Classes.FObjectProperty);
		BrushWidthFalloffMID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushWidthFalloffMID");
		BrushWidthFalloffMID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushWidthFalloffMID", Classes.FObjectProperty);
		DistanceFieldCacheMID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceFieldCacheMID");
		DistanceFieldCacheMID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceFieldCacheMID", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RiverSplineMIDs_PropertyAddress, intPtr, "RiverSplineMIDs");
		RiverSplineMIDs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RiverSplineMIDs");
		RiverSplineMIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RiverSplineMIDs", Classes.FArrayProperty);
		DebugDistanceFieldMID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugDistanceFieldMID");
		DebugDistanceFieldMID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugDistanceFieldMID", Classes.FObjectProperty);
		WeightmapMID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeightmapMID");
		WeightmapMID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeightmapMID", Classes.FObjectProperty);
		DrawCanvasMID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawCanvasMID");
		DrawCanvasMID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawCanvasMID", Classes.FObjectProperty);
		CompositeWaterBodyTextureMID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CompositeWaterBodyTextureMID");
		CompositeWaterBodyTextureMID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CompositeWaterBodyTextureMID", Classes.FObjectProperty);
		IslandFalloffMID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IslandFalloffMID");
		IslandFalloffMID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IslandFalloffMID", Classes.FObjectProperty);
		FinalizeVelocityHeightMID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FinalizeVelocityHeightMID");
		FinalizeVelocityHeightMID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FinalizeVelocityHeightMID", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BrushCurveRTCache_PropertyAddress, intPtr, "BrushCurveRTCache");
		BrushCurveRTCache_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushCurveRTCache");
		BrushCurveRTCache_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushCurveRTCache", Classes.FMapProperty);
		WorldSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WorldSize");
		WorldSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WorldSize", Classes.FStructProperty);
		LandscapeRTRes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LandscapeRTRes");
		LandscapeRTRes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LandscapeRTRes", Classes.FStructProperty);
		LandscapeQuads_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LandscapeQuads");
		LandscapeQuads_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LandscapeQuads", Classes.FStructProperty);
		LandscapeTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LandscapeTransform");
		LandscapeTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LandscapeTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowGradient_PropertyAddress, intPtr, "ShowGradient");
		ShowGradient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowGradient");
		ShowGradient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowGradient", Classes.FBoolProperty);
		DistanceDivisor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceDivisor");
		DistanceDivisor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceDivisor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowDistance_PropertyAddress, intPtr, "ShowDistance");
		ShowDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowDistance");
		ShowDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowDistance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowGrid_PropertyAddress, intPtr, "ShowGrid");
		ShowGrid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowGrid");
		ShowGrid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowGrid", Classes.FBoolProperty);
		CanvasSegmentSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanvasSegmentSize");
		CanvasSegmentSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanvasSegmentSize", Classes.FFloatProperty);
		WaterClearHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterClearHeight");
		WaterClearHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterClearHeight", Classes.FFloatProperty);
		SplineMeshExtension_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SplineMeshExtension");
		SplineMeshExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SplineMeshExtension", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseDynamicPreviewRT_PropertyAddress, intPtr, "UseDynamicPreviewRT");
		UseDynamicPreviewRT_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseDynamicPreviewRT");
		UseDynamicPreviewRT_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseDynamicPreviewRT", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableBrushTextureEffects_PropertyAddress, intPtr, "DisableBrushTextureEffects");
		DisableBrushTextureEffects_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisableBrushTextureEffects");
		DisableBrushTextureEffects_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisableBrushTextureEffects", Classes.FBoolProperty);
		SortWaterBodiesForBrushRender_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SortWaterBodiesForBrushRender");
		SortWaterBodiesForBrushRender_ParamsSize = NativeReflection.GetFunctionParamsSize(SortWaterBodiesForBrushRender_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortWaterBodiesForBrushRender_InOutWaterBodies_PropertyAddress, SortWaterBodiesForBrushRender_FunctionAddress, "InOutWaterBodies");
		SortWaterBodiesForBrushRender_InOutWaterBodies_Offset = NativeReflectionCached.GetPropertyOffset(SortWaterBodiesForBrushRender_FunctionAddress, "InOutWaterBodies");
		SortWaterBodiesForBrushRender_InOutWaterBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(SortWaterBodiesForBrushRender_FunctionAddress, "InOutWaterBodies", Classes.FArrayProperty);
		SortWaterBodiesForBrushRender_IsValid = SortWaterBodiesForBrushRender_FunctionAddress != IntPtr.Zero && SortWaterBodiesForBrushRender_InOutWaterBodies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterBrushManager:SortWaterBodiesForBrushRender", SortWaterBodiesForBrushRender_IsValid);
		SingleJumpStep_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SingleJumpStep");
		SingleJumpStep_ParamsSize = NativeReflection.GetFunctionParamsSize(SingleJumpStep_FunctionAddress);
		SingleJumpStep_IsValid = SingleJumpStep_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterBrushManager:SingleJumpStep", SingleJumpStep_IsValid);
		SingleBlurStep_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SingleBlurStep");
		SingleBlurStep_ParamsSize = NativeReflection.GetFunctionParamsSize(SingleBlurStep_FunctionAddress);
		SingleBlurStep_IsValid = SingleBlurStep_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterBrushManager:SingleBlurStep", SingleBlurStep_IsValid);
		SetupDefaultMaterials_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupDefaultMaterials");
		SetupDefaultMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupDefaultMaterials_FunctionAddress);
		SetupDefaultMaterials_IsValid = SetupDefaultMaterials_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterBrushManager:SetupDefaultMaterials", SetupDefaultMaterials_IsValid);
		GetWaterCacheKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterCacheKey");
		GetWaterCacheKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterCacheKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterCacheKey_WaterBrush_PropertyAddress, GetWaterCacheKey_FunctionAddress, "WaterBrush");
		GetWaterCacheKey_WaterBrush_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterCacheKey_FunctionAddress, "WaterBrush");
		GetWaterCacheKey_WaterBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterCacheKey_FunctionAddress, "WaterBrush", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterCacheKey_ContainerObject_PropertyAddress, GetWaterCacheKey_FunctionAddress, "ContainerObject");
		GetWaterCacheKey_ContainerObject_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterCacheKey_FunctionAddress, "ContainerObject");
		GetWaterCacheKey_ContainerObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterCacheKey_FunctionAddress, "ContainerObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterCacheKey_Value_PropertyAddress, GetWaterCacheKey_FunctionAddress, "Value");
		GetWaterCacheKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterCacheKey_FunctionAddress, "Value");
		GetWaterCacheKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterCacheKey_FunctionAddress, "Value", Classes.FStructProperty);
		GetWaterCacheKey_IsValid = GetWaterCacheKey_FunctionAddress != IntPtr.Zero && GetWaterCacheKey_WaterBrush_IsValid && GetWaterCacheKey_ContainerObject_IsValid && GetWaterCacheKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterBrushManager:GetWaterCacheKey", GetWaterCacheKey_IsValid);
		ForceUpdate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceUpdate");
		ForceUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceUpdate_FunctionAddress);
		ForceUpdate_IsValid = ForceUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterBrushManager:ForceUpdate", ForceUpdate_IsValid);
		FindEdges_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindEdges");
		FindEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(FindEdges_FunctionAddress);
		FindEdges_IsValid = FindEdges_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterBrushManager:FindEdges", FindEdges_IsValid);
	}
}
