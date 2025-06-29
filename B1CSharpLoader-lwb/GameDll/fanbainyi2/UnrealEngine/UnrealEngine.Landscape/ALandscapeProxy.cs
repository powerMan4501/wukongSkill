using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[Abstract]
[UClass(Flags = (ClassFlags)818414245uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Landscape.LandscapeProxy", "Landscape", UnrealModuleType.Engine)]
public class ALandscapeProxy : APartitionActor, ILandscapeSplineInterface, IInterface
{
	private static bool LandscapeMaterial_IsValid;

	private static int LandscapeMaterial_Offset;

	private static bool MeshHoles_IsValid;

	private static FFieldAddress MeshHoles_PropertyAddress;

	private static int MeshHoles_Offset;

	private static bool MeshHolesMaxLod_IsValid;

	private static int MeshHolesMaxLod_Offset;

	private static bool RuntimeVirtualTextures_IsValid;

	private static FFieldAddress RuntimeVirtualTextures_PropertyAddress;

	private static int RuntimeVirtualTextures_Offset;

	private TArrayReadWriteMarshaler<URuntimeVirtualTexture> RuntimeVirtualTextures_MarshalerCached;

	private static bool VirtualTextureNumLods_IsValid;

	private static int VirtualTextureNumLods_Offset;

	private static bool VirtualTextureLodBias_IsValid;

	private static int VirtualTextureLodBias_Offset;

	private static bool VirtualTextureRenderPassType_IsValid;

	private static FFieldAddress VirtualTextureRenderPassType_PropertyAddress;

	private static int VirtualTextureRenderPassType_Offset;

	private static bool CastShadow_IsValid;

	private static FFieldAddress CastShadow_PropertyAddress;

	private static int CastShadow_Offset;

	private static bool CastDynamicShadow_IsValid;

	private static FFieldAddress CastDynamicShadow_PropertyAddress;

	private static int CastDynamicShadow_Offset;

	private static bool CastStaticShadow_IsValid;

	private static FFieldAddress CastStaticShadow_PropertyAddress;

	private static int CastStaticShadow_Offset;

	private static bool CastContactShadow_IsValid;

	private static FFieldAddress CastContactShadow_PropertyAddress;

	private static int CastContactShadow_Offset;

	private static bool CastFarShadow_IsValid;

	private static FFieldAddress CastFarShadow_PropertyAddress;

	private static int CastFarShadow_Offset;

	private static bool CastHiddenShadow_IsValid;

	private static FFieldAddress CastHiddenShadow_PropertyAddress;

	private static int CastHiddenShadow_Offset;

	private static bool CastShadowAsTwoSided_IsValid;

	private static FFieldAddress CastShadowAsTwoSided_PropertyAddress;

	private static int CastShadowAsTwoSided_Offset;

	private static bool AffectDistanceFieldLighting_IsValid;

	private static FFieldAddress AffectDistanceFieldLighting_PropertyAddress;

	private static int AffectDistanceFieldLighting_Offset;

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

	private static bool LDMaxDrawDistance_IsValid;

	private static int LDMaxDrawDistance_Offset;

	private static bool BodyInstance_IsValid;

	private static int BodyInstance_Offset;

	private static bool GenerateOverlapEvents_IsValid;

	private static FFieldAddress GenerateOverlapEvents_PropertyAddress;

	private static int GenerateOverlapEvents_Offset;

	private static bool SetLandscapeMaterialVectorParameterValue_IsValid;

	private static IntPtr SetLandscapeMaterialVectorParameterValue_FunctionAddress;

	private static int SetLandscapeMaterialVectorParameterValue_ParamsSize;

	private static bool SetLandscapeMaterialVectorParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetLandscapeMaterialVectorParameterValue_ParameterName_PropertyAddress;

	private static int SetLandscapeMaterialVectorParameterValue_ParameterName_Offset;

	private static bool SetLandscapeMaterialVectorParameterValue_Value_IsValid;

	private static FFieldAddress SetLandscapeMaterialVectorParameterValue_Value_PropertyAddress;

	private static int SetLandscapeMaterialVectorParameterValue_Value_Offset;

	private static bool SetLandscapeMaterialTextureParameterValue_IsValid;

	private static IntPtr SetLandscapeMaterialTextureParameterValue_FunctionAddress;

	private static int SetLandscapeMaterialTextureParameterValue_ParamsSize;

	private static bool SetLandscapeMaterialTextureParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetLandscapeMaterialTextureParameterValue_ParameterName_PropertyAddress;

	private static int SetLandscapeMaterialTextureParameterValue_ParameterName_Offset;

	private static bool SetLandscapeMaterialTextureParameterValue_Value_IsValid;

	private static FFieldAddress SetLandscapeMaterialTextureParameterValue_Value_PropertyAddress;

	private static int SetLandscapeMaterialTextureParameterValue_Value_Offset;

	private static bool SetLandscapeMaterialScalarParameterValue_IsValid;

	private static IntPtr SetLandscapeMaterialScalarParameterValue_FunctionAddress;

	private static int SetLandscapeMaterialScalarParameterValue_ParamsSize;

	private static bool SetLandscapeMaterialScalarParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetLandscapeMaterialScalarParameterValue_ParameterName_PropertyAddress;

	private static int SetLandscapeMaterialScalarParameterValue_ParameterName_Offset;

	private static bool SetLandscapeMaterialScalarParameterValue_Value_IsValid;

	private static FFieldAddress SetLandscapeMaterialScalarParameterValue_Value_PropertyAddress;

	private static int SetLandscapeMaterialScalarParameterValue_Value_Offset;

	private static bool LandscapeImportWeightmapFromRenderTarget_IsValid;

	private static IntPtr LandscapeImportWeightmapFromRenderTarget_FunctionAddress;

	private static int LandscapeImportWeightmapFromRenderTarget_ParamsSize;

	private static bool LandscapeImportWeightmapFromRenderTarget_InRenderTarget_IsValid;

	private static FFieldAddress LandscapeImportWeightmapFromRenderTarget_InRenderTarget_PropertyAddress;

	private static int LandscapeImportWeightmapFromRenderTarget_InRenderTarget_Offset;

	private static bool LandscapeImportWeightmapFromRenderTarget_InLayerName_IsValid;

	private static FFieldAddress LandscapeImportWeightmapFromRenderTarget_InLayerName_PropertyAddress;

	private static int LandscapeImportWeightmapFromRenderTarget_InLayerName_Offset;

	private static bool LandscapeImportWeightmapFromRenderTarget_ReturnValue_IsValid;

	private static FFieldAddress LandscapeImportWeightmapFromRenderTarget_ReturnValue_PropertyAddress;

	private static int LandscapeImportWeightmapFromRenderTarget_ReturnValue_Offset;

	private static bool LandscapeImportHeightmapFromRenderTarget_IsValid;

	private static IntPtr LandscapeImportHeightmapFromRenderTarget_FunctionAddress;

	private static int LandscapeImportHeightmapFromRenderTarget_ParamsSize;

	private static bool LandscapeImportHeightmapFromRenderTarget_InRenderTarget_IsValid;

	private static FFieldAddress LandscapeImportHeightmapFromRenderTarget_InRenderTarget_PropertyAddress;

	private static int LandscapeImportHeightmapFromRenderTarget_InRenderTarget_Offset;

	private static bool LandscapeImportHeightmapFromRenderTarget_InImportHeightFromRGChannel_IsValid;

	private static FFieldAddress LandscapeImportHeightmapFromRenderTarget_InImportHeightFromRGChannel_PropertyAddress;

	private static int LandscapeImportHeightmapFromRenderTarget_InImportHeightFromRGChannel_Offset;

	private static bool LandscapeImportHeightmapFromRenderTarget_ReturnValue_IsValid;

	private static FFieldAddress LandscapeImportHeightmapFromRenderTarget_ReturnValue_PropertyAddress;

	private static int LandscapeImportHeightmapFromRenderTarget_ReturnValue_Offset;

	private static bool LandscapeExportWeightmapToRenderTarget_IsValid;

	private static IntPtr LandscapeExportWeightmapToRenderTarget_FunctionAddress;

	private static int LandscapeExportWeightmapToRenderTarget_ParamsSize;

	private static bool LandscapeExportWeightmapToRenderTarget_InRenderTarget_IsValid;

	private static FFieldAddress LandscapeExportWeightmapToRenderTarget_InRenderTarget_PropertyAddress;

	private static int LandscapeExportWeightmapToRenderTarget_InRenderTarget_Offset;

	private static bool LandscapeExportWeightmapToRenderTarget_InLayerName_IsValid;

	private static FFieldAddress LandscapeExportWeightmapToRenderTarget_InLayerName_PropertyAddress;

	private static int LandscapeExportWeightmapToRenderTarget_InLayerName_Offset;

	private static bool LandscapeExportWeightmapToRenderTarget_ReturnValue_IsValid;

	private static FFieldAddress LandscapeExportWeightmapToRenderTarget_ReturnValue_PropertyAddress;

	private static int LandscapeExportWeightmapToRenderTarget_ReturnValue_Offset;

	private static bool LandscapeExportHeightmapToRenderTarget_IsValid;

	private static IntPtr LandscapeExportHeightmapToRenderTarget_FunctionAddress;

	private static int LandscapeExportHeightmapToRenderTarget_ParamsSize;

	private static bool LandscapeExportHeightmapToRenderTarget_InRenderTarget_IsValid;

	private static FFieldAddress LandscapeExportHeightmapToRenderTarget_InRenderTarget_PropertyAddress;

	private static int LandscapeExportHeightmapToRenderTarget_InRenderTarget_Offset;

	private static bool LandscapeExportHeightmapToRenderTarget_InExportHeightIntoRGChannel_IsValid;

	private static FFieldAddress LandscapeExportHeightmapToRenderTarget_InExportHeightIntoRGChannel_PropertyAddress;

	private static int LandscapeExportHeightmapToRenderTarget_InExportHeightIntoRGChannel_Offset;

	private static bool LandscapeExportHeightmapToRenderTarget_InExportLandscapeProxies_IsValid;

	private static FFieldAddress LandscapeExportHeightmapToRenderTarget_InExportLandscapeProxies_PropertyAddress;

	private static int LandscapeExportHeightmapToRenderTarget_InExportLandscapeProxies_Offset;

	private static bool LandscapeExportHeightmapToRenderTarget_ReturnValue_IsValid;

	private static FFieldAddress LandscapeExportHeightmapToRenderTarget_ReturnValue_PropertyAddress;

	private static int LandscapeExportHeightmapToRenderTarget_ReturnValue_Offset;

	private static bool EditorSetLandscapeMaterial_IsValid;

	private static IntPtr EditorSetLandscapeMaterial_FunctionAddress;

	private static int EditorSetLandscapeMaterial_ParamsSize;

	private static bool EditorSetLandscapeMaterial_NewLandscapeMaterial_IsValid;

	private static FFieldAddress EditorSetLandscapeMaterial_NewLandscapeMaterial_PropertyAddress;

	private static int EditorSetLandscapeMaterial_NewLandscapeMaterial_Offset;

	private static bool EditorApplySpline_IsValid;

	private static IntPtr EditorApplySpline_FunctionAddress;

	private static int EditorApplySpline_ParamsSize;

	private static bool EditorApplySpline_InSplineComponent_IsValid;

	private static FFieldAddress EditorApplySpline_InSplineComponent_PropertyAddress;

	private static int EditorApplySpline_InSplineComponent_Offset;

	private static bool EditorApplySpline_StartWidth_IsValid;

	private static FFieldAddress EditorApplySpline_StartWidth_PropertyAddress;

	private static int EditorApplySpline_StartWidth_Offset;

	private static bool EditorApplySpline_EndWidth_IsValid;

	private static FFieldAddress EditorApplySpline_EndWidth_PropertyAddress;

	private static int EditorApplySpline_EndWidth_Offset;

	private static bool EditorApplySpline_StartSideFalloff_IsValid;

	private static FFieldAddress EditorApplySpline_StartSideFalloff_PropertyAddress;

	private static int EditorApplySpline_StartSideFalloff_Offset;

	private static bool EditorApplySpline_EndSideFalloff_IsValid;

	private static FFieldAddress EditorApplySpline_EndSideFalloff_PropertyAddress;

	private static int EditorApplySpline_EndSideFalloff_Offset;

	private static bool EditorApplySpline_StartRoll_IsValid;

	private static FFieldAddress EditorApplySpline_StartRoll_PropertyAddress;

	private static int EditorApplySpline_StartRoll_Offset;

	private static bool EditorApplySpline_EndRoll_IsValid;

	private static FFieldAddress EditorApplySpline_EndRoll_PropertyAddress;

	private static int EditorApplySpline_EndRoll_Offset;

	private static bool EditorApplySpline_NumSubdivisions_IsValid;

	private static FFieldAddress EditorApplySpline_NumSubdivisions_PropertyAddress;

	private static int EditorApplySpline_NumSubdivisions_Offset;

	private static bool EditorApplySpline_bRaiseHeights_IsValid;

	private static FFieldAddress EditorApplySpline_bRaiseHeights_PropertyAddress;

	private static int EditorApplySpline_bRaiseHeights_Offset;

	private static bool EditorApplySpline_bLowerHeights_IsValid;

	private static FFieldAddress EditorApplySpline_bLowerHeights_PropertyAddress;

	private static int EditorApplySpline_bLowerHeights_Offset;

	private static bool EditorApplySpline_PaintLayer_IsValid;

	private static FFieldAddress EditorApplySpline_PaintLayer_PropertyAddress;

	private static int EditorApplySpline_PaintLayer_Offset;

	private static bool EditorApplySpline_EditLayerName_IsValid;

	private static FFieldAddress EditorApplySpline_EditLayerName_PropertyAddress;

	private static int EditorApplySpline_EditLayerName_Offset;

	private static bool ChangeComponentScreenSizeToUseSubSections_IsValid;

	private static IntPtr ChangeComponentScreenSizeToUseSubSections_FunctionAddress;

	private static int ChangeComponentScreenSizeToUseSubSections_ParamsSize;

	private static bool ChangeComponentScreenSizeToUseSubSections_InComponentScreenSizeToUseSubSections_IsValid;

	private static FFieldAddress ChangeComponentScreenSizeToUseSubSections_InComponentScreenSizeToUseSubSections_PropertyAddress;

	private static int ChangeComponentScreenSizeToUseSubSections_InComponentScreenSizeToUseSubSections_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:LandscapeMaterial")]
	public UMaterialInterface LandscapeMaterial
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:LandscapeMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, LandscapeMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:LandscapeMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, LandscapeMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bMeshHoles")]
	public bool MeshHoles
	{
		get
		{
			CheckDestroyed();
			if (!MeshHoles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bMeshHoles");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MeshHoles_Offset), 0, MeshHoles_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MeshHoles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bMeshHoles");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MeshHoles_Offset), 0, MeshHoles_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:MeshHolesMaxLod")]
	public byte MeshHolesMaxLod
	{
		get
		{
			CheckDestroyed();
			if (!MeshHolesMaxLod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:MeshHolesMaxLod");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, MeshHolesMaxLod_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeshHolesMaxLod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:MeshHolesMaxLod");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, MeshHolesMaxLod_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:RuntimeVirtualTextures")]
	public TArrayReadWrite<URuntimeVirtualTexture> RuntimeVirtualTextures
	{
		get
		{
			CheckDestroyed();
			if (!RuntimeVirtualTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:RuntimeVirtualTextures");
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
	[UMetaPath("/Script/Landscape.LandscapeProxy:VirtualTextureNumLods")]
	public int VirtualTextureNumLods
	{
		get
		{
			CheckDestroyed();
			if (!VirtualTextureNumLods_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:VirtualTextureNumLods");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VirtualTextureNumLods_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VirtualTextureNumLods_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:VirtualTextureNumLods");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VirtualTextureNumLods_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:VirtualTextureLodBias")]
	public int VirtualTextureLodBias
	{
		get
		{
			CheckDestroyed();
			if (!VirtualTextureLodBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:VirtualTextureLodBias");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VirtualTextureLodBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VirtualTextureLodBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:VirtualTextureLodBias");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VirtualTextureLodBias_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:VirtualTextureRenderPassType")]
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType
	{
		get
		{
			CheckDestroyed();
			if (!VirtualTextureRenderPassType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:VirtualTextureRenderPassType");
				return ERuntimeVirtualTextureMainPassType.Never;
			}
			return EnumMarshaler<ERuntimeVirtualTextureMainPassType>.FromNative(IntPtr.Add(base.Address, VirtualTextureRenderPassType_Offset), 0, VirtualTextureRenderPassType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VirtualTextureRenderPassType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:VirtualTextureRenderPassType");
			}
			else
			{
				EnumMarshaler<ERuntimeVirtualTextureMainPassType>.ToNative(IntPtr.Add(base.Address, VirtualTextureRenderPassType_Offset), 0, VirtualTextureRenderPassType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:CastShadow")]
	public bool CastShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:CastShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadow_Offset), 0, CastShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:CastShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadow_Offset), 0, CastShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bCastDynamicShadow")]
	public bool CastDynamicShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastDynamicShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastDynamicShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastDynamicShadow_Offset), 0, CastDynamicShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastDynamicShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastDynamicShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastDynamicShadow_Offset), 0, CastDynamicShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bCastStaticShadow")]
	public bool CastStaticShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastStaticShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastStaticShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastStaticShadow_Offset), 0, CastStaticShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastStaticShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastStaticShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastStaticShadow_Offset), 0, CastStaticShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bCastContactShadow")]
	public bool CastContactShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastContactShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastContactShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastContactShadow_Offset), 0, CastContactShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastContactShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastContactShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastContactShadow_Offset), 0, CastContactShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bCastFarShadow")]
	public bool CastFarShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastFarShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastFarShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastFarShadow_Offset), 0, CastFarShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastFarShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastFarShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastFarShadow_Offset), 0, CastFarShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bCastHiddenShadow")]
	public bool CastHiddenShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastHiddenShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastHiddenShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastHiddenShadow_Offset), 0, CastHiddenShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastHiddenShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastHiddenShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastHiddenShadow_Offset), 0, CastHiddenShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bCastShadowAsTwoSided")]
	public bool CastShadowAsTwoSided
	{
		get
		{
			CheckDestroyed();
			if (!CastShadowAsTwoSided_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastShadowAsTwoSided");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadowAsTwoSided_Offset), 0, CastShadowAsTwoSided_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadowAsTwoSided_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bCastShadowAsTwoSided");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadowAsTwoSided_Offset), 0, CastShadowAsTwoSided_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bAffectDistanceFieldLighting")]
	public bool AffectDistanceFieldLighting
	{
		get
		{
			CheckDestroyed();
			if (!AffectDistanceFieldLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bAffectDistanceFieldLighting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectDistanceFieldLighting_Offset), 0, AffectDistanceFieldLighting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectDistanceFieldLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bAffectDistanceFieldLighting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectDistanceFieldLighting_Offset), 0, AffectDistanceFieldLighting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358357uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:LightingChannels")]
	public FLightingChannels LightingChannels
	{
		get
		{
			CheckDestroyed();
			if (!LightingChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:LightingChannels");
				return default(FLightingChannels);
			}
			return FLightingChannels.FromNative(IntPtr.Add(base.Address, LightingChannels_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightingChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:LightingChannels");
			}
			else
			{
				FLightingChannels.ToNative(IntPtr.Add(base.Address, LightingChannels_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bRenderCustomDepth")]
	public bool RenderCustomDepth
	{
		get
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bRenderCustomDepth");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bRenderCustomDepth");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:CustomDepthStencilWriteMask")]
	public ERendererStencilMask CustomDepthStencilWriteMask
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilWriteMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:CustomDepthStencilWriteMask");
				return ERendererStencilMask.ERSM_Default;
			}
			return EnumMarshaler<ERendererStencilMask>.FromNative(IntPtr.Add(base.Address, CustomDepthStencilWriteMask_Offset), 0, CustomDepthStencilWriteMask_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CustomDepthStencilWriteMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:CustomDepthStencilWriteMask");
			}
			else
			{
				EnumMarshaler<ERendererStencilMask>.ToNative(IntPtr.Add(base.Address, CustomDepthStencilWriteMask_Offset), 0, CustomDepthStencilWriteMask_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:CustomDepthStencilValue")]
	public int CustomDepthStencilValue
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:CustomDepthStencilValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:CustomDepthStencilValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:LDMaxDrawDistance")]
	public float LDMaxDrawDistance
	{
		get
		{
			CheckDestroyed();
			if (!LDMaxDrawDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:LDMaxDrawDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LDMaxDrawDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LDMaxDrawDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:LDMaxDrawDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LDMaxDrawDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:BodyInstance")]
	public FBodyInstance BodyInstance
	{
		get
		{
			CheckDestroyed();
			if (!BodyInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:BodyInstance");
				return default(FBodyInstance);
			}
			return FBodyInstance.FromNative(IntPtr.Add(base.Address, BodyInstance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:BodyInstance");
			}
			else
			{
				FBodyInstance.ToNative(IntPtr.Add(base.Address, BodyInstance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:bGenerateOverlapEvents")]
	public bool GenerateOverlapEvents
	{
		get
		{
			CheckDestroyed();
			if (!GenerateOverlapEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bGenerateOverlapEvents");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GenerateOverlapEvents_Offset), 0, GenerateOverlapEvents_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenerateOverlapEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeProxy:bGenerateOverlapEvents");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GenerateOverlapEvents_Offset), 0, GenerateOverlapEvents_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:SetLandscapeMaterialVectorParameterValue")]
	public unsafe void SetLandscapeMaterialVectorParameterValue(FName ParameterName, FLinearColor Value)
	{
		CheckDestroyed();
		if (!SetLandscapeMaterialVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:SetLandscapeMaterialVectorParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLandscapeMaterialVectorParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLandscapeMaterialVectorParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLandscapeMaterialVectorParameterValue_ParameterName_Offset), 0, SetLandscapeMaterialVectorParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetLandscapeMaterialVectorParameterValue_Value_Offset), 0, SetLandscapeMaterialVectorParameterValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLandscapeMaterialVectorParameterValue_FunctionAddress, intPtr, SetLandscapeMaterialVectorParameterValue_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:SetLandscapeMaterialTextureParameterValue")]
	public unsafe void SetLandscapeMaterialTextureParameterValue(FName ParameterName, UTexture Value)
	{
		CheckDestroyed();
		if (!SetLandscapeMaterialTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:SetLandscapeMaterialTextureParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLandscapeMaterialTextureParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLandscapeMaterialTextureParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLandscapeMaterialTextureParameterValue_ParameterName_Offset), 0, SetLandscapeMaterialTextureParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetLandscapeMaterialTextureParameterValue_Value_Offset), 0, SetLandscapeMaterialTextureParameterValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLandscapeMaterialTextureParameterValue_FunctionAddress, intPtr, SetLandscapeMaterialTextureParameterValue_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:SetLandscapeMaterialScalarParameterValue")]
	public unsafe void SetLandscapeMaterialScalarParameterValue(FName ParameterName, float Value)
	{
		CheckDestroyed();
		if (!SetLandscapeMaterialScalarParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:SetLandscapeMaterialScalarParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLandscapeMaterialScalarParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLandscapeMaterialScalarParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLandscapeMaterialScalarParameterValue_ParameterName_Offset), 0, SetLandscapeMaterialScalarParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLandscapeMaterialScalarParameterValue_Value_Offset), 0, SetLandscapeMaterialScalarParameterValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLandscapeMaterialScalarParameterValue_FunctionAddress, intPtr, SetLandscapeMaterialScalarParameterValue_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:LandscapeImportWeightmapFromRenderTarget")]
	public unsafe bool LandscapeImportWeightmapFromRenderTarget(UTextureRenderTarget2D InRenderTarget, FName InLayerName)
	{
		CheckDestroyed();
		if (!LandscapeImportWeightmapFromRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:LandscapeImportWeightmapFromRenderTarget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LandscapeImportWeightmapFromRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LandscapeImportWeightmapFromRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, LandscapeImportWeightmapFromRenderTarget_InRenderTarget_Offset), 0, LandscapeImportWeightmapFromRenderTarget_InRenderTarget_PropertyAddress.Address, InRenderTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, LandscapeImportWeightmapFromRenderTarget_InLayerName_Offset), 0, LandscapeImportWeightmapFromRenderTarget_InLayerName_PropertyAddress.Address, InLayerName);
		NativeReflection.InvokeFunctionOptimized(base.Address, LandscapeImportWeightmapFromRenderTarget_FunctionAddress, intPtr, LandscapeImportWeightmapFromRenderTarget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LandscapeImportWeightmapFromRenderTarget_ReturnValue_Offset), 0, LandscapeImportWeightmapFromRenderTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:LandscapeImportHeightmapFromRenderTarget")]
	public unsafe bool LandscapeImportHeightmapFromRenderTarget(UTextureRenderTarget2D InRenderTarget, bool InImportHeightFromRGChannel = false)
	{
		CheckDestroyed();
		if (!LandscapeImportHeightmapFromRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:LandscapeImportHeightmapFromRenderTarget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LandscapeImportHeightmapFromRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LandscapeImportHeightmapFromRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, LandscapeImportHeightmapFromRenderTarget_InRenderTarget_Offset), 0, LandscapeImportHeightmapFromRenderTarget_InRenderTarget_PropertyAddress.Address, InRenderTarget);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LandscapeImportHeightmapFromRenderTarget_InImportHeightFromRGChannel_Offset), 0, LandscapeImportHeightmapFromRenderTarget_InImportHeightFromRGChannel_PropertyAddress.Address, InImportHeightFromRGChannel);
		NativeReflection.InvokeFunctionOptimized(base.Address, LandscapeImportHeightmapFromRenderTarget_FunctionAddress, intPtr, LandscapeImportHeightmapFromRenderTarget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LandscapeImportHeightmapFromRenderTarget_ReturnValue_Offset), 0, LandscapeImportHeightmapFromRenderTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:LandscapeExportWeightmapToRenderTarget")]
	public unsafe bool LandscapeExportWeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget, FName InLayerName)
	{
		CheckDestroyed();
		if (!LandscapeExportWeightmapToRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:LandscapeExportWeightmapToRenderTarget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LandscapeExportWeightmapToRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LandscapeExportWeightmapToRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, LandscapeExportWeightmapToRenderTarget_InRenderTarget_Offset), 0, LandscapeExportWeightmapToRenderTarget_InRenderTarget_PropertyAddress.Address, InRenderTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, LandscapeExportWeightmapToRenderTarget_InLayerName_Offset), 0, LandscapeExportWeightmapToRenderTarget_InLayerName_PropertyAddress.Address, InLayerName);
		NativeReflection.InvokeFunctionOptimized(base.Address, LandscapeExportWeightmapToRenderTarget_FunctionAddress, intPtr, LandscapeExportWeightmapToRenderTarget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LandscapeExportWeightmapToRenderTarget_ReturnValue_Offset), 0, LandscapeExportWeightmapToRenderTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:LandscapeExportHeightmapToRenderTarget")]
	public unsafe bool LandscapeExportHeightmapToRenderTarget(UTextureRenderTarget2D InRenderTarget, bool InExportHeightIntoRGChannel = false, bool InExportLandscapeProxies = true)
	{
		CheckDestroyed();
		if (!LandscapeExportHeightmapToRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:LandscapeExportHeightmapToRenderTarget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LandscapeExportHeightmapToRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LandscapeExportHeightmapToRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, LandscapeExportHeightmapToRenderTarget_InRenderTarget_Offset), 0, LandscapeExportHeightmapToRenderTarget_InRenderTarget_PropertyAddress.Address, InRenderTarget);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LandscapeExportHeightmapToRenderTarget_InExportHeightIntoRGChannel_Offset), 0, LandscapeExportHeightmapToRenderTarget_InExportHeightIntoRGChannel_PropertyAddress.Address, InExportHeightIntoRGChannel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LandscapeExportHeightmapToRenderTarget_InExportLandscapeProxies_Offset), 0, LandscapeExportHeightmapToRenderTarget_InExportLandscapeProxies_PropertyAddress.Address, InExportLandscapeProxies);
		NativeReflection.InvokeFunctionOptimized(base.Address, LandscapeExportHeightmapToRenderTarget_FunctionAddress, intPtr, LandscapeExportHeightmapToRenderTarget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LandscapeExportHeightmapToRenderTarget_ReturnValue_Offset), 0, LandscapeExportHeightmapToRenderTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:EditorSetLandscapeMaterial")]
	public unsafe void EditorSetLandscapeMaterial(UMaterialInterface NewLandscapeMaterial)
	{
		CheckDestroyed();
		if (!EditorSetLandscapeMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:EditorSetLandscapeMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorSetLandscapeMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorSetLandscapeMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, EditorSetLandscapeMaterial_NewLandscapeMaterial_Offset), 0, EditorSetLandscapeMaterial_NewLandscapeMaterial_PropertyAddress.Address, NewLandscapeMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorSetLandscapeMaterial_FunctionAddress, intPtr, EditorSetLandscapeMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:EditorApplySpline")]
	public unsafe void EditorApplySpline(USplineComponent InSplineComponent, float StartWidth, float EndWidth, float StartSideFalloff, float EndSideFalloff, float StartRoll, float EndRoll, int NumSubdivisions, bool bRaiseHeights, bool bLowerHeights, ULandscapeLayerInfoObject PaintLayer, FName EditLayerName)
	{
		CheckDestroyed();
		if (!EditorApplySpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:EditorApplySpline");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorApplySpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorApplySpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_InSplineComponent_Offset), 0, EditorApplySpline_InSplineComponent_PropertyAddress.Address, InSplineComponent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_StartWidth_Offset), 0, EditorApplySpline_StartWidth_PropertyAddress.Address, StartWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_EndWidth_Offset), 0, EditorApplySpline_EndWidth_PropertyAddress.Address, EndWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_StartSideFalloff_Offset), 0, EditorApplySpline_StartSideFalloff_PropertyAddress.Address, StartSideFalloff);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_EndSideFalloff_Offset), 0, EditorApplySpline_EndSideFalloff_PropertyAddress.Address, EndSideFalloff);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_StartRoll_Offset), 0, EditorApplySpline_StartRoll_PropertyAddress.Address, StartRoll);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_EndRoll_Offset), 0, EditorApplySpline_EndRoll_PropertyAddress.Address, EndRoll);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_NumSubdivisions_Offset), 0, EditorApplySpline_NumSubdivisions_PropertyAddress.Address, NumSubdivisions);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EditorApplySpline_bRaiseHeights_Offset), 0, EditorApplySpline_bRaiseHeights_PropertyAddress.Address, bRaiseHeights);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EditorApplySpline_bLowerHeights_Offset), 0, EditorApplySpline_bLowerHeights_PropertyAddress.Address, bLowerHeights);
		UObjectMarshaler<ULandscapeLayerInfoObject>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_PaintLayer_Offset), 0, EditorApplySpline_PaintLayer_PropertyAddress.Address, PaintLayer);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EditorApplySpline_EditLayerName_Offset), 0, EditorApplySpline_EditLayerName_PropertyAddress.Address, EditLayerName);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorApplySpline_FunctionAddress, intPtr, EditorApplySpline_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Landscape.LandscapeProxy:ChangeComponentScreenSizeToUseSubSections")]
	public unsafe void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections)
	{
		CheckDestroyed();
		if (!ChangeComponentScreenSizeToUseSubSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeProxy:ChangeComponentScreenSizeToUseSubSections");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeComponentScreenSizeToUseSubSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeComponentScreenSizeToUseSubSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ChangeComponentScreenSizeToUseSubSections_InComponentScreenSizeToUseSubSections_Offset), 0, ChangeComponentScreenSizeToUseSubSections_InComponentScreenSizeToUseSubSections_PropertyAddress.Address, InComponentScreenSizeToUseSubSections);
		NativeReflection.InvokeFunctionOptimized(base.Address, ChangeComponentScreenSizeToUseSubSections_FunctionAddress, intPtr, ChangeComponentScreenSizeToUseSubSections_ParamsSize);
	}

	static ALandscapeProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALandscapeProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALandscapeProxy));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Landscape.LandscapeProxy");
		LandscapeMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LandscapeMaterial");
		LandscapeMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LandscapeMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshHoles_PropertyAddress, intPtr, "bMeshHoles");
		MeshHoles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMeshHoles");
		MeshHoles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMeshHoles", Classes.FBoolProperty);
		MeshHolesMaxLod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshHolesMaxLod");
		MeshHolesMaxLod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshHolesMaxLod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref RuntimeVirtualTextures_PropertyAddress, intPtr, "RuntimeVirtualTextures");
		RuntimeVirtualTextures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RuntimeVirtualTextures");
		RuntimeVirtualTextures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RuntimeVirtualTextures", Classes.FArrayProperty);
		VirtualTextureNumLods_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VirtualTextureNumLods");
		VirtualTextureNumLods_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VirtualTextureNumLods", Classes.FIntProperty);
		VirtualTextureLodBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VirtualTextureLodBias");
		VirtualTextureLodBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VirtualTextureLodBias", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref VirtualTextureRenderPassType_PropertyAddress, intPtr, "VirtualTextureRenderPassType");
		VirtualTextureRenderPassType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VirtualTextureRenderPassType");
		VirtualTextureRenderPassType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VirtualTextureRenderPassType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadow_PropertyAddress, intPtr, "CastShadow");
		CastShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastShadow");
		CastShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastDynamicShadow_PropertyAddress, intPtr, "bCastDynamicShadow");
		CastDynamicShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastDynamicShadow");
		CastDynamicShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastDynamicShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastStaticShadow_PropertyAddress, intPtr, "bCastStaticShadow");
		CastStaticShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastStaticShadow");
		CastStaticShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastStaticShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastContactShadow_PropertyAddress, intPtr, "bCastContactShadow");
		CastContactShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastContactShadow");
		CastContactShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastContactShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastFarShadow_PropertyAddress, intPtr, "bCastFarShadow");
		CastFarShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastFarShadow");
		CastFarShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastFarShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastHiddenShadow_PropertyAddress, intPtr, "bCastHiddenShadow");
		CastHiddenShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastHiddenShadow");
		CastHiddenShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastHiddenShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadowAsTwoSided_PropertyAddress, intPtr, "bCastShadowAsTwoSided");
		CastShadowAsTwoSided_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastShadowAsTwoSided");
		CastShadowAsTwoSided_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastShadowAsTwoSided", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectDistanceFieldLighting_PropertyAddress, intPtr, "bAffectDistanceFieldLighting");
		AffectDistanceFieldLighting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectDistanceFieldLighting");
		AffectDistanceFieldLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectDistanceFieldLighting", Classes.FBoolProperty);
		LightingChannels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightingChannels");
		LightingChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightingChannels", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderCustomDepth_PropertyAddress, intPtr, "bRenderCustomDepth");
		RenderCustomDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderCustomDepth");
		RenderCustomDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderCustomDepth", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomDepthStencilWriteMask_PropertyAddress, intPtr, "CustomDepthStencilWriteMask");
		CustomDepthStencilWriteMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomDepthStencilWriteMask");
		CustomDepthStencilWriteMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomDepthStencilWriteMask", Classes.FEnumProperty);
		CustomDepthStencilValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomDepthStencilValue");
		CustomDepthStencilValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomDepthStencilValue", Classes.FIntProperty);
		LDMaxDrawDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LDMaxDrawDistance");
		LDMaxDrawDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LDMaxDrawDistance", Classes.FFloatProperty);
		BodyInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BodyInstance");
		BodyInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BodyInstance", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateOverlapEvents_PropertyAddress, intPtr, "bGenerateOverlapEvents");
		GenerateOverlapEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateOverlapEvents");
		GenerateOverlapEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateOverlapEvents", Classes.FBoolProperty);
		SetLandscapeMaterialVectorParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLandscapeMaterialVectorParameterValue");
		SetLandscapeMaterialVectorParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLandscapeMaterialVectorParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeMaterialVectorParameterValue_ParameterName_PropertyAddress, SetLandscapeMaterialVectorParameterValue_FunctionAddress, "ParameterName");
		SetLandscapeMaterialVectorParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeMaterialVectorParameterValue_FunctionAddress, "ParameterName");
		SetLandscapeMaterialVectorParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeMaterialVectorParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeMaterialVectorParameterValue_Value_PropertyAddress, SetLandscapeMaterialVectorParameterValue_FunctionAddress, "Value");
		SetLandscapeMaterialVectorParameterValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeMaterialVectorParameterValue_FunctionAddress, "Value");
		SetLandscapeMaterialVectorParameterValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeMaterialVectorParameterValue_FunctionAddress, "Value", Classes.FStructProperty);
		SetLandscapeMaterialVectorParameterValue_IsValid = SetLandscapeMaterialVectorParameterValue_FunctionAddress != IntPtr.Zero && SetLandscapeMaterialVectorParameterValue_ParameterName_IsValid && SetLandscapeMaterialVectorParameterValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:SetLandscapeMaterialVectorParameterValue", SetLandscapeMaterialVectorParameterValue_IsValid);
		SetLandscapeMaterialTextureParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLandscapeMaterialTextureParameterValue");
		SetLandscapeMaterialTextureParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLandscapeMaterialTextureParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeMaterialTextureParameterValue_ParameterName_PropertyAddress, SetLandscapeMaterialTextureParameterValue_FunctionAddress, "ParameterName");
		SetLandscapeMaterialTextureParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeMaterialTextureParameterValue_FunctionAddress, "ParameterName");
		SetLandscapeMaterialTextureParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeMaterialTextureParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeMaterialTextureParameterValue_Value_PropertyAddress, SetLandscapeMaterialTextureParameterValue_FunctionAddress, "Value");
		SetLandscapeMaterialTextureParameterValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeMaterialTextureParameterValue_FunctionAddress, "Value");
		SetLandscapeMaterialTextureParameterValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeMaterialTextureParameterValue_FunctionAddress, "Value", Classes.FObjectProperty);
		SetLandscapeMaterialTextureParameterValue_IsValid = SetLandscapeMaterialTextureParameterValue_FunctionAddress != IntPtr.Zero && SetLandscapeMaterialTextureParameterValue_ParameterName_IsValid && SetLandscapeMaterialTextureParameterValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:SetLandscapeMaterialTextureParameterValue", SetLandscapeMaterialTextureParameterValue_IsValid);
		SetLandscapeMaterialScalarParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLandscapeMaterialScalarParameterValue");
		SetLandscapeMaterialScalarParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLandscapeMaterialScalarParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeMaterialScalarParameterValue_ParameterName_PropertyAddress, SetLandscapeMaterialScalarParameterValue_FunctionAddress, "ParameterName");
		SetLandscapeMaterialScalarParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeMaterialScalarParameterValue_FunctionAddress, "ParameterName");
		SetLandscapeMaterialScalarParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeMaterialScalarParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeMaterialScalarParameterValue_Value_PropertyAddress, SetLandscapeMaterialScalarParameterValue_FunctionAddress, "Value");
		SetLandscapeMaterialScalarParameterValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeMaterialScalarParameterValue_FunctionAddress, "Value");
		SetLandscapeMaterialScalarParameterValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeMaterialScalarParameterValue_FunctionAddress, "Value", Classes.FFloatProperty);
		SetLandscapeMaterialScalarParameterValue_IsValid = SetLandscapeMaterialScalarParameterValue_FunctionAddress != IntPtr.Zero && SetLandscapeMaterialScalarParameterValue_ParameterName_IsValid && SetLandscapeMaterialScalarParameterValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:SetLandscapeMaterialScalarParameterValue", SetLandscapeMaterialScalarParameterValue_IsValid);
		LandscapeImportWeightmapFromRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LandscapeImportWeightmapFromRenderTarget");
		LandscapeImportWeightmapFromRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(LandscapeImportWeightmapFromRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LandscapeImportWeightmapFromRenderTarget_InRenderTarget_PropertyAddress, LandscapeImportWeightmapFromRenderTarget_FunctionAddress, "InRenderTarget");
		LandscapeImportWeightmapFromRenderTarget_InRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeImportWeightmapFromRenderTarget_FunctionAddress, "InRenderTarget");
		LandscapeImportWeightmapFromRenderTarget_InRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeImportWeightmapFromRenderTarget_FunctionAddress, "InRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeImportWeightmapFromRenderTarget_InLayerName_PropertyAddress, LandscapeImportWeightmapFromRenderTarget_FunctionAddress, "InLayerName");
		LandscapeImportWeightmapFromRenderTarget_InLayerName_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeImportWeightmapFromRenderTarget_FunctionAddress, "InLayerName");
		LandscapeImportWeightmapFromRenderTarget_InLayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeImportWeightmapFromRenderTarget_FunctionAddress, "InLayerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeImportWeightmapFromRenderTarget_ReturnValue_PropertyAddress, LandscapeImportWeightmapFromRenderTarget_FunctionAddress, "ReturnValue");
		LandscapeImportWeightmapFromRenderTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeImportWeightmapFromRenderTarget_FunctionAddress, "ReturnValue");
		LandscapeImportWeightmapFromRenderTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeImportWeightmapFromRenderTarget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LandscapeImportWeightmapFromRenderTarget_IsValid = LandscapeImportWeightmapFromRenderTarget_FunctionAddress != IntPtr.Zero && LandscapeImportWeightmapFromRenderTarget_InRenderTarget_IsValid && LandscapeImportWeightmapFromRenderTarget_InLayerName_IsValid && LandscapeImportWeightmapFromRenderTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:LandscapeImportWeightmapFromRenderTarget", LandscapeImportWeightmapFromRenderTarget_IsValid);
		LandscapeImportHeightmapFromRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LandscapeImportHeightmapFromRenderTarget");
		LandscapeImportHeightmapFromRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(LandscapeImportHeightmapFromRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LandscapeImportHeightmapFromRenderTarget_InRenderTarget_PropertyAddress, LandscapeImportHeightmapFromRenderTarget_FunctionAddress, "InRenderTarget");
		LandscapeImportHeightmapFromRenderTarget_InRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeImportHeightmapFromRenderTarget_FunctionAddress, "InRenderTarget");
		LandscapeImportHeightmapFromRenderTarget_InRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeImportHeightmapFromRenderTarget_FunctionAddress, "InRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeImportHeightmapFromRenderTarget_InImportHeightFromRGChannel_PropertyAddress, LandscapeImportHeightmapFromRenderTarget_FunctionAddress, "InImportHeightFromRGChannel");
		LandscapeImportHeightmapFromRenderTarget_InImportHeightFromRGChannel_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeImportHeightmapFromRenderTarget_FunctionAddress, "InImportHeightFromRGChannel");
		LandscapeImportHeightmapFromRenderTarget_InImportHeightFromRGChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeImportHeightmapFromRenderTarget_FunctionAddress, "InImportHeightFromRGChannel", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeImportHeightmapFromRenderTarget_ReturnValue_PropertyAddress, LandscapeImportHeightmapFromRenderTarget_FunctionAddress, "ReturnValue");
		LandscapeImportHeightmapFromRenderTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeImportHeightmapFromRenderTarget_FunctionAddress, "ReturnValue");
		LandscapeImportHeightmapFromRenderTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeImportHeightmapFromRenderTarget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LandscapeImportHeightmapFromRenderTarget_IsValid = LandscapeImportHeightmapFromRenderTarget_FunctionAddress != IntPtr.Zero && LandscapeImportHeightmapFromRenderTarget_InRenderTarget_IsValid && LandscapeImportHeightmapFromRenderTarget_InImportHeightFromRGChannel_IsValid && LandscapeImportHeightmapFromRenderTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:LandscapeImportHeightmapFromRenderTarget", LandscapeImportHeightmapFromRenderTarget_IsValid);
		LandscapeExportWeightmapToRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LandscapeExportWeightmapToRenderTarget");
		LandscapeExportWeightmapToRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(LandscapeExportWeightmapToRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LandscapeExportWeightmapToRenderTarget_InRenderTarget_PropertyAddress, LandscapeExportWeightmapToRenderTarget_FunctionAddress, "InRenderTarget");
		LandscapeExportWeightmapToRenderTarget_InRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeExportWeightmapToRenderTarget_FunctionAddress, "InRenderTarget");
		LandscapeExportWeightmapToRenderTarget_InRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeExportWeightmapToRenderTarget_FunctionAddress, "InRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeExportWeightmapToRenderTarget_InLayerName_PropertyAddress, LandscapeExportWeightmapToRenderTarget_FunctionAddress, "InLayerName");
		LandscapeExportWeightmapToRenderTarget_InLayerName_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeExportWeightmapToRenderTarget_FunctionAddress, "InLayerName");
		LandscapeExportWeightmapToRenderTarget_InLayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeExportWeightmapToRenderTarget_FunctionAddress, "InLayerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeExportWeightmapToRenderTarget_ReturnValue_PropertyAddress, LandscapeExportWeightmapToRenderTarget_FunctionAddress, "ReturnValue");
		LandscapeExportWeightmapToRenderTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeExportWeightmapToRenderTarget_FunctionAddress, "ReturnValue");
		LandscapeExportWeightmapToRenderTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeExportWeightmapToRenderTarget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LandscapeExportWeightmapToRenderTarget_IsValid = LandscapeExportWeightmapToRenderTarget_FunctionAddress != IntPtr.Zero && LandscapeExportWeightmapToRenderTarget_InRenderTarget_IsValid && LandscapeExportWeightmapToRenderTarget_InLayerName_IsValid && LandscapeExportWeightmapToRenderTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:LandscapeExportWeightmapToRenderTarget", LandscapeExportWeightmapToRenderTarget_IsValid);
		LandscapeExportHeightmapToRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LandscapeExportHeightmapToRenderTarget");
		LandscapeExportHeightmapToRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(LandscapeExportHeightmapToRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LandscapeExportHeightmapToRenderTarget_InRenderTarget_PropertyAddress, LandscapeExportHeightmapToRenderTarget_FunctionAddress, "InRenderTarget");
		LandscapeExportHeightmapToRenderTarget_InRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeExportHeightmapToRenderTarget_FunctionAddress, "InRenderTarget");
		LandscapeExportHeightmapToRenderTarget_InRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeExportHeightmapToRenderTarget_FunctionAddress, "InRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeExportHeightmapToRenderTarget_InExportHeightIntoRGChannel_PropertyAddress, LandscapeExportHeightmapToRenderTarget_FunctionAddress, "InExportHeightIntoRGChannel");
		LandscapeExportHeightmapToRenderTarget_InExportHeightIntoRGChannel_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeExportHeightmapToRenderTarget_FunctionAddress, "InExportHeightIntoRGChannel");
		LandscapeExportHeightmapToRenderTarget_InExportHeightIntoRGChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeExportHeightmapToRenderTarget_FunctionAddress, "InExportHeightIntoRGChannel", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeExportHeightmapToRenderTarget_InExportLandscapeProxies_PropertyAddress, LandscapeExportHeightmapToRenderTarget_FunctionAddress, "InExportLandscapeProxies");
		LandscapeExportHeightmapToRenderTarget_InExportLandscapeProxies_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeExportHeightmapToRenderTarget_FunctionAddress, "InExportLandscapeProxies");
		LandscapeExportHeightmapToRenderTarget_InExportLandscapeProxies_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeExportHeightmapToRenderTarget_FunctionAddress, "InExportLandscapeProxies", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LandscapeExportHeightmapToRenderTarget_ReturnValue_PropertyAddress, LandscapeExportHeightmapToRenderTarget_FunctionAddress, "ReturnValue");
		LandscapeExportHeightmapToRenderTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LandscapeExportHeightmapToRenderTarget_FunctionAddress, "ReturnValue");
		LandscapeExportHeightmapToRenderTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LandscapeExportHeightmapToRenderTarget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LandscapeExportHeightmapToRenderTarget_IsValid = LandscapeExportHeightmapToRenderTarget_FunctionAddress != IntPtr.Zero && LandscapeExportHeightmapToRenderTarget_InRenderTarget_IsValid && LandscapeExportHeightmapToRenderTarget_InExportHeightIntoRGChannel_IsValid && LandscapeExportHeightmapToRenderTarget_InExportLandscapeProxies_IsValid && LandscapeExportHeightmapToRenderTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:LandscapeExportHeightmapToRenderTarget", LandscapeExportHeightmapToRenderTarget_IsValid);
		EditorSetLandscapeMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorSetLandscapeMaterial");
		EditorSetLandscapeMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorSetLandscapeMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorSetLandscapeMaterial_NewLandscapeMaterial_PropertyAddress, EditorSetLandscapeMaterial_FunctionAddress, "NewLandscapeMaterial");
		EditorSetLandscapeMaterial_NewLandscapeMaterial_Offset = NativeReflectionCached.GetPropertyOffset(EditorSetLandscapeMaterial_FunctionAddress, "NewLandscapeMaterial");
		EditorSetLandscapeMaterial_NewLandscapeMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorSetLandscapeMaterial_FunctionAddress, "NewLandscapeMaterial", Classes.FObjectProperty);
		EditorSetLandscapeMaterial_IsValid = EditorSetLandscapeMaterial_FunctionAddress != IntPtr.Zero && EditorSetLandscapeMaterial_NewLandscapeMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:EditorSetLandscapeMaterial", EditorSetLandscapeMaterial_IsValid);
		EditorApplySpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorApplySpline");
		EditorApplySpline_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorApplySpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_InSplineComponent_PropertyAddress, EditorApplySpline_FunctionAddress, "InSplineComponent");
		EditorApplySpline_InSplineComponent_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "InSplineComponent");
		EditorApplySpline_InSplineComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "InSplineComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_StartWidth_PropertyAddress, EditorApplySpline_FunctionAddress, "StartWidth");
		EditorApplySpline_StartWidth_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "StartWidth");
		EditorApplySpline_StartWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "StartWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_EndWidth_PropertyAddress, EditorApplySpline_FunctionAddress, "EndWidth");
		EditorApplySpline_EndWidth_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "EndWidth");
		EditorApplySpline_EndWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "EndWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_StartSideFalloff_PropertyAddress, EditorApplySpline_FunctionAddress, "StartSideFalloff");
		EditorApplySpline_StartSideFalloff_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "StartSideFalloff");
		EditorApplySpline_StartSideFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "StartSideFalloff", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_EndSideFalloff_PropertyAddress, EditorApplySpline_FunctionAddress, "EndSideFalloff");
		EditorApplySpline_EndSideFalloff_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "EndSideFalloff");
		EditorApplySpline_EndSideFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "EndSideFalloff", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_StartRoll_PropertyAddress, EditorApplySpline_FunctionAddress, "StartRoll");
		EditorApplySpline_StartRoll_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "StartRoll");
		EditorApplySpline_StartRoll_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "StartRoll", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_EndRoll_PropertyAddress, EditorApplySpline_FunctionAddress, "EndRoll");
		EditorApplySpline_EndRoll_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "EndRoll");
		EditorApplySpline_EndRoll_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "EndRoll", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_NumSubdivisions_PropertyAddress, EditorApplySpline_FunctionAddress, "NumSubdivisions");
		EditorApplySpline_NumSubdivisions_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "NumSubdivisions");
		EditorApplySpline_NumSubdivisions_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "NumSubdivisions", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_bRaiseHeights_PropertyAddress, EditorApplySpline_FunctionAddress, "bRaiseHeights");
		EditorApplySpline_bRaiseHeights_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "bRaiseHeights");
		EditorApplySpline_bRaiseHeights_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "bRaiseHeights", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_bLowerHeights_PropertyAddress, EditorApplySpline_FunctionAddress, "bLowerHeights");
		EditorApplySpline_bLowerHeights_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "bLowerHeights");
		EditorApplySpline_bLowerHeights_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "bLowerHeights", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_PaintLayer_PropertyAddress, EditorApplySpline_FunctionAddress, "PaintLayer");
		EditorApplySpline_PaintLayer_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "PaintLayer");
		EditorApplySpline_PaintLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "PaintLayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorApplySpline_EditLayerName_PropertyAddress, EditorApplySpline_FunctionAddress, "EditLayerName");
		EditorApplySpline_EditLayerName_Offset = NativeReflectionCached.GetPropertyOffset(EditorApplySpline_FunctionAddress, "EditLayerName");
		EditorApplySpline_EditLayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorApplySpline_FunctionAddress, "EditLayerName", Classes.FNameProperty);
		EditorApplySpline_IsValid = EditorApplySpline_FunctionAddress != IntPtr.Zero && EditorApplySpline_InSplineComponent_IsValid && EditorApplySpline_StartWidth_IsValid && EditorApplySpline_EndWidth_IsValid && EditorApplySpline_StartSideFalloff_IsValid && EditorApplySpline_EndSideFalloff_IsValid && EditorApplySpline_StartRoll_IsValid && EditorApplySpline_EndRoll_IsValid && EditorApplySpline_NumSubdivisions_IsValid && EditorApplySpline_bRaiseHeights_IsValid && EditorApplySpline_bLowerHeights_IsValid && EditorApplySpline_PaintLayer_IsValid && EditorApplySpline_EditLayerName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:EditorApplySpline", EditorApplySpline_IsValid);
		ChangeComponentScreenSizeToUseSubSections_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChangeComponentScreenSizeToUseSubSections");
		ChangeComponentScreenSizeToUseSubSections_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeComponentScreenSizeToUseSubSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeComponentScreenSizeToUseSubSections_InComponentScreenSizeToUseSubSections_PropertyAddress, ChangeComponentScreenSizeToUseSubSections_FunctionAddress, "InComponentScreenSizeToUseSubSections");
		ChangeComponentScreenSizeToUseSubSections_InComponentScreenSizeToUseSubSections_Offset = NativeReflectionCached.GetPropertyOffset(ChangeComponentScreenSizeToUseSubSections_FunctionAddress, "InComponentScreenSizeToUseSubSections");
		ChangeComponentScreenSizeToUseSubSections_InComponentScreenSizeToUseSubSections_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeComponentScreenSizeToUseSubSections_FunctionAddress, "InComponentScreenSizeToUseSubSections", Classes.FFloatProperty);
		ChangeComponentScreenSizeToUseSubSections_IsValid = ChangeComponentScreenSizeToUseSubSections_FunctionAddress != IntPtr.Zero && ChangeComponentScreenSizeToUseSubSections_InComponentScreenSizeToUseSubSections_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeProxy:ChangeComponentScreenSizeToUseSubSections", ChangeComponentScreenSizeToUseSubSections_IsValid);
	}
}
