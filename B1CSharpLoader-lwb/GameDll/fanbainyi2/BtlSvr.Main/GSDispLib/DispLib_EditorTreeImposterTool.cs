using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1;
using b1.Plugins.HoudiniEngineRuntime;
using UnrealEngine.AssetRegistry;
using UnrealEngine.Engine;
using UnrealEngine.MaterialEditor;
using UnrealEngine.Plugins.EditorScriptingUtilities;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool")]
public class DispLib_EditorTreeImposterTool : ABGUPlacedEditorUtilityBase
{
	private string RTSavedSuffix = "tga";

	private FName GSImposterMaterialSlotName = new FName("GSImposter");

	private string GSImposterMaterialName = "M_TreeImposter";

	private string GSImposterMaterialUnrealPath = "/Game/00Main/GlobalMat/BaseLibrary/Env/M_TreeImposter.M_TreeImposter";

	private string SnowMatUnrealPath = "/Game/00Main/GlobalMat/BaseLibrary/Env/M_Snow.M_Snow";

	private string B1TreeAssetRootFolderPath = "/Game/00MainHZ/Environment/Speedtree";

	private string B1TreeAssetMeshRootFolderPath = "/Game/00MainHZ/Environment/Speedtree/Meshs";

	private string B1TreeAssetTextureRootFolderPath = "/Game/00MainHZ/Environment/Speedtree/Textures";

	private string B1TreeAssetMaterialRootFolderPath = "/Game/00MainHZ/Environment/Speedtree/Materials";

	private string[] SplitPathArray = new string[1] { "/Game/00MainHZ/Environment/Speedtree/Meshs" };

	private string PythonScriptPath_ReleaseAssets = "../../../../../unreal_proj/Content/03_VFXRes/EditorArtTool/TreeImposter/GSImposterReleaseAssets.py";

	private string PythonScriptPath_CreateHDAInstance = "../../../../../unreal_proj/Content/03_VFXRes/EditorArtTool/TreeImposter/GSImposterDoHDA.py";

	private string PythonScriptPath_PerformanceCompressOneRGBA8 = "../../../../../unreal_proj/Content/03_VFXRes/EditorArtTool/TreeImposter/GSImposterPerformanceCompressRGBA8.py";

	private string PythonScriptPath_PerformanceCompressMultiTex = "../../../../../unreal_proj/Content/03_VFXRes/EditorArtTool/TreeImposter/GSImposterPerformanceMultiTexture.py";

	public ADirectionalLight DirectionalLightActor;

	public UDirectionalLightComponent DirectionalLightComponent;

	public AActor SkySphereActor;

	public UStaticMeshComponent SkySphereComponent;

	private int ShadowMaskShotCount;

	private int PBRSceneShotCount;

	private bool isWaittingStage;

	private int isWaittingStageWaittingFrameCount;

	private CreatTreeImposterStage CTIStage;

	private bool OnChangeViewStateStage;

	private float ViewStateChangeTempTimeACC;

	private int SetViewStateStep;

	private int PBRSceneShot_CompletedBufferCount;

	private string[] BufferNameArray = new string[7] { "BaseColor", "Opacity", "Specular", "Roughness", "WorldNormal", "ShadingModel", "SubsurfaceColor" };

	private string[] PBRFileNameArray = new string[7] { "BaseColor", "Opacity", "Specular", "Roughness", "NWS", "ShadingModel", "SSS" };

	private static bool TempFileSaveRootFolderUnrealPath_IsValid;

	private static int TempFileSaveRootFolderUnrealPath_Offset;

	private static bool TempAutogenRootFolderDiskPath_IsValid;

	private static int TempAutogenRootFolderDiskPath_Offset;

	private static bool ManualSaveAssets_IsValid;

	private static int ManualSaveAssets_Offset;

	private static FFieldAddress ManualSaveAssets_PropertyAddress;

	private static bool UseCustomSavePath_IsValid;

	private static int UseCustomSavePath_Offset;

	private static FFieldAddress UseCustomSavePath_PropertyAddress;

	private static bool PerformanceMatInstanceSaveAt_IsValid;

	private static int PerformanceMatInstanceSaveAt_Offset;

	private static bool PerformanceMatDataTextureSaveAt_IsValid;

	private static int PerformanceMatDataTextureSaveAt_Offset;

	private static bool TaskFromFolder_IsValid;

	private static int TaskFromFolder_Offset;

	private static FFieldAddress TaskFromFolder_PropertyAddress;

	private TArrayReadWriteMarshaler<string> TaskFromFolder_Marshaler;

	private static bool TaskList_IsValid;

	private static int TaskList_Offset;

	private static FFieldAddress TaskList_PropertyAddress;

	private TArrayReadWriteMarshaler<TreeImposter_TaskData> TaskList_Marshaler;

	private static bool DefaultCardMicoScale_IsValid;

	private static int DefaultCardMicoScale_Offset;

	private static bool DefaultCardPairCount_IsValid;

	private static int DefaultCardPairCount_Offset;

	private static bool DefaultCaptureRTSize_IsValid;

	private static int DefaultCaptureRTSize_Offset;

	private static bool DefaultShotTextureSize_IsValid;

	private static int DefaultShotTextureSize_Offset;

	private static bool DefaultTrunkMaskThreshold_IsValid;

	private static int DefaultTrunkMaskThreshold_Offset;

	private static bool DefaultLeafMaskThreshold_IsValid;

	private static int DefaultLeafMaskThreshold_Offset;

	private static bool DebugPause_IsValid;

	private static int DebugPause_Offset;

	private static FFieldAddress DebugPause_PropertyAddress;

	private static bool CurTaskIndex_IsValid;

	private static int CurTaskIndex_Offset;

	private static bool TreeMesh_IsValid;

	private static int TreeMesh_Offset;

	private static bool BakeLOD_IsValid;

	private static int BakeLOD_Offset;

	private static bool CardPairCount_IsValid;

	private static int CardPairCount_Offset;

	private static bool CardMicoScale_IsValid;

	private static int CardMicoScale_Offset;

	private static bool CaptureRTSize_IsValid;

	private static int CaptureRTSize_Offset;

	private static bool ShotTextureSize_IsValid;

	private static int ShotTextureSize_Offset;

	private static bool TrunkMaskThreshold_IsValid;

	private static int TrunkMaskThreshold_Offset;

	private static bool LeafMaskThreshold_IsValid;

	private static int LeafMaskThreshold_Offset;

	private static bool ImposterCardMeshAsset_IsValid;

	private static int ImposterCardMeshAsset_Offset;

	private static bool CardSize_IsValid;

	private static int CardSize_Offset;

	private static FFieldAddress CardSize_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> CardSize_Marshaler;

	private static bool PosOffset_IsValid;

	private static int PosOffset_Offset;

	private static FFieldAddress PosOffset_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> PosOffset_Marshaler;

	private static bool LastMeshName_IsValid;

	private static int LastMeshName_Offset;

	private static bool GlobalOffset_IsValid;

	private static int GlobalOffset_Offset;

	private static bool ShadowMapCountEveryCard_IsValid;

	private static int ShadowMapCountEveryCard_Offset;

	private static bool ForceResetExitstedMat_IsValid;

	private static int ForceResetExitstedMat_Offset;

	private static FFieldAddress ForceResetExitstedMat_PropertyAddress;

	private static bool PerformanceMaterialUseOneTextureMode_IsValid;

	private static int PerformanceMaterialUseOneTextureMode_Offset;

	private static FFieldAddress PerformanceMaterialUseOneTextureMode_PropertyAddress;

	private static bool AutoSetImposterMeshToTreeLOD_IsValid;

	private static int AutoSetImposterMeshToTreeLOD_Offset;

	private static FFieldAddress AutoSetImposterMeshToTreeLOD_PropertyAddress;

	private static bool SaveImposterCardMesh_IsValid;

	private static int SaveImposterCardMesh_Offset;

	private static FFieldAddress SaveImposterCardMesh_PropertyAddress;

	private static bool OverrideMPCParam_IsValid;

	private static int OverrideMPCParam_Offset;

	private static FFieldAddress OverrideMPCParam_PropertyAddress;

	private TArrayReadWriteMarshaler<TreeImposter_OverrideMPCParam> OverrideMPCParam_Marshaler;

	private static bool OverrideTreeMeshMatScalarParam_IsValid;

	private static int OverrideTreeMeshMatScalarParam_Offset;

	private static FFieldAddress OverrideTreeMeshMatScalarParam_PropertyAddress;

	private TArrayReadWriteMarshaler<TreeImposter_OverrideMatScalarParam> OverrideTreeMeshMatScalarParam_Marshaler;

	private static bool OverrideTreeMeshMatLinearColorParam_IsValid;

	private static int OverrideTreeMeshMatLinearColorParam_Offset;

	private static FFieldAddress OverrideTreeMeshMatLinearColorParam_PropertyAddress;

	private TArrayReadWriteMarshaler<TreeImposter_OverrideMatLinearColorParam> OverrideTreeMeshMatLinearColorParam_Marshaler;

	private static bool OverrideShotTexSetting_IsValid;

	private static int OverrideShotTexSetting_Offset;

	private static FFieldAddress OverrideShotTexSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<TreeImposter_OverrideTexSetting> OverrideShotTexSetting_Marshaler;

	private static bool OverrideFinalTexSetting_IsValid;

	private static int OverrideFinalTexSetting_Offset;

	private static FFieldAddress OverrideFinalTexSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<TreeImposter_OverrideTexSetting> OverrideFinalTexSetting_Marshaler;

	private static bool CopyScalarParamsFromHQToImposterMat_IsValid;

	private static int CopyScalarParamsFromHQToImposterMat_Offset;

	private static FFieldAddress CopyScalarParamsFromHQToImposterMat_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> CopyScalarParamsFromHQToImposterMat_Marshaler;

	private static bool CopySwitchParamsFromHQToImposterMat_IsValid;

	private static int CopySwitchParamsFromHQToImposterMat_Offset;

	private static FFieldAddress CopySwitchParamsFromHQToImposterMat_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> CopySwitchParamsFromHQToImposterMat_Marshaler;

	private static bool HDA_Asset_IsValid;

	private static int HDA_Asset_Offset;

	private static bool ToggleViewModeWaittngTime_IsValid;

	private static int ToggleViewModeWaittngTime_Offset;

	private static bool RT_CustomShadowmap_IsValid;

	private static int RT_CustomShadowmap_Offset;

	private static bool DebugColorArray_IsValid;

	private static int DebugColorArray_Offset;

	private static FFieldAddress DebugColorArray_PropertyAddress;

	private TArrayReadWriteMarshaler<FLinearColor> DebugColorArray_Marshaler;

	private static bool SkySphereToolMat_IsValid;

	private static int SkySphereToolMat_Offset;

	private static bool MergeActorToolMat_IsValid;

	private static int MergeActorToolMat_Offset;

	private static bool ColorDilateToolMat_IsValid;

	private static int ColorDilateToolMat_Offset;

	private static bool CustomShadowMapMat_IsValid;

	private static int CustomShadowMapMat_Offset;

	private static bool DistanceFieldToolMat_IsValid;

	private static int DistanceFieldToolMat_Offset;

	private static bool CombineRGBAndAlphaToolMat_IsValid;

	private static int CombineRGBAndAlphaToolMat_Offset;

	private static bool OriginImposterMatIns_IsValid;

	private static int OriginImposterMatIns_Offset;

	private static bool OriginOneTexPerformanceImposterMatIns_IsValid;

	private static int OriginOneTexPerformanceImposterMatIns_Offset;

	private static bool OriginMultiTexPerformanceImposterMatIns_IsValid;

	private static int OriginMultiTexPerformanceImposterMatIns_Offset;

	private static bool TreeActor_IsValid;

	private static int TreeActor_Offset;

	private static bool TreeStaticMeshComp_IsValid;

	private static int TreeStaticMeshComp_Offset;

	private static bool CopyFromHQMatIndex_IsValid;

	private static int CopyFromHQMatIndex_Offset;

	private static bool ShadowMapTreeActor_IsValid;

	private static int ShadowMapTreeActor_Offset;

	private static bool ShadowMapTreeStaticMeshComp_IsValid;

	private static int ShadowMapTreeStaticMeshComp_Offset;

	private static bool Capture2DActor_IsValid;

	private static int Capture2DActor_Offset;

	private static bool CaptureComponent2D_IsValid;

	private static int CaptureComponent2D_Offset;

	private static bool CameraActor_IsValid;

	private static int CameraActor_Offset;

	private static bool CameraComp_IsValid;

	private static int CameraComp_Offset;

	private static bool ShadowMapCameraActor_IsValid;

	private static int ShadowMapCameraActor_Offset;

	private static bool ShadowMapCameraComp_IsValid;

	private static int ShadowMapCameraComp_Offset;

	private static bool ShadowMapCapture2DActor_IsValid;

	private static int ShadowMapCapture2DActor_Offset;

	private static bool ShadowMapCaptureComponent2D_IsValid;

	private static int ShadowMapCaptureComponent2D_Offset;

	private static bool RT_4Capture_RGB_IsValid;

	private static int RT_4Capture_RGB_Offset;

	private static bool RT_4Capture_NearestFillterRGB_IsValid;

	private static int RT_4Capture_NearestFillterRGB_Offset;

	private static bool RT_4Capture_Alpha_IsValid;

	private static int RT_4Capture_Alpha_Offset;

	private static bool RT_4Capture_FinalTex_IsValid;

	private static int RT_4Capture_FinalTex_Offset;

	private static bool isShadowMaskSceneShot_IsValid;

	private static int isShadowMaskSceneShot_Offset;

	private static FFieldAddress isShadowMaskSceneShot_PropertyAddress;

	private static bool isPBRSceneShot_IsValid;

	private static int isPBRSceneShot_Offset;

	private static FFieldAddress isPBRSceneShot_PropertyAddress;

	private static bool isCreateTreeImposter_IsValid;

	private static int isCreateTreeImposter_Offset;

	private static FFieldAddress isCreateTreeImposter_PropertyAddress;

	private static bool ImposterMatInsAsset_IsValid;

	private static int ImposterMatInsAsset_Offset;

	private static bool ImposterMatPerformanceModeInsAsset_IsValid;

	private static int ImposterMatPerformanceModeInsAsset_Offset;

	private static bool DoSetLOD_IsValid;

	private static IntPtr DoSetLOD_FunctionAddress;

	private static int DoSetLOD_ParamsSize;

	private static bool ShowCompare_IsValid;

	private static IntPtr ShowCompare_FunctionAddress;

	private static int ShowCompare_ParamsSize;

	private static bool SetCurrentTask_IsValid;

	private static IntPtr SetCurrentTask_FunctionAddress;

	private static int SetCurrentTask_ParamsSize;

	private static bool SetCurrentTask_TaskIndex_IsValid;

	private static int SetCurrentTask_TaskIndex_Offset;

	private static bool SetCurrentTask_ReturnValue_IsValid;

	private static int SetCurrentTask_ReturnValue_Offset;

	private static FFieldAddress SetCurrentTask_ReturnValue_PropertyAddress;

	private static bool FillHoudiniData_IsValid;

	private static IntPtr FillHoudiniData_FunctionAddress;

	private static int FillHoudiniData_ParamsSize;

	private static bool FillHoudiniData_ReturnValue_IsValid;

	private static int FillHoudiniData_ReturnValue_Offset;

	private static FFieldAddress FillHoudiniData_ReturnValue_PropertyAddress;

	private static bool ToggleDebugPause_IsValid;

	private static IntPtr ToggleDebugPause_FunctionAddress;

	private static int ToggleDebugPause_ParamsSize;

	private static bool LogForwardVector_IsValid;

	private static IntPtr LogForwardVector_FunctionAddress;

	private static int LogForwardVector_ParamsSize;

	private static bool CreateHDAInstance_IsValid;

	private static IntPtr CreateHDAInstance_FunctionAddress;

	private static int CreateHDAInstance_ParamsSize;

	private static bool CheckHDABakeResult_IsValid;

	private static IntPtr CheckHDABakeResult_FunctionAddress;

	private static int CheckHDABakeResult_ParamsSize;

	private static bool CheckHDABakeResult_ReturnValue_IsValid;

	private static int CheckHDABakeResult_ReturnValue_Offset;

	private static FFieldAddress CheckHDABakeResult_ReturnValue_PropertyAddress;

	private static bool CleanAllToolAssets_IsValid;

	private static IntPtr CleanAllToolAssets_FunctionAddress;

	private static int CleanAllToolAssets_ParamsSize;

	private static bool AutoImportSceneShot_IsValid;

	private static IntPtr AutoImportSceneShot_FunctionAddress;

	private static int AutoImportSceneShot_ParamsSize;

	private static bool AutoDelectSceneShot_IsValid;

	private static IntPtr AutoDelectSceneShot_FunctionAddress;

	private static int AutoDelectSceneShot_ParamsSize;

	private static bool SetNewLevelEnvActor_IsValid;

	private static IntPtr SetNewLevelEnvActor_FunctionAddress;

	private static int SetNewLevelEnvActor_ParamsSize;

	private static bool SetNewLevelEnvActor_Visable_IsValid;

	private static int SetNewLevelEnvActor_Visable_Offset;

	private static FFieldAddress SetNewLevelEnvActor_Visable_PropertyAddress;

	private static bool RemoveAllInvalidTask_IsValid;

	private static IntPtr RemoveAllInvalidTask_FunctionAddress;

	private static int RemoveAllInvalidTask_ParamsSize;

	private static bool CheckTaskMeshValidity_IsValid;

	private static IntPtr CheckTaskMeshValidity_FunctionAddress;

	private static int CheckTaskMeshValidity_ParamsSize;

	private static bool CheckTaskMeshValidity_ReturnValue_IsValid;

	private static int CheckTaskMeshValidity_ReturnValue_Offset;

	private static FFieldAddress CheckTaskMeshValidity_ReturnValue_PropertyAddress;

	private static bool SetAllTaskBakeZeroLOD_IsValid;

	private static IntPtr SetAllTaskBakeZeroLOD_FunctionAddress;

	private static int SetAllTaskBakeZeroLOD_ParamsSize;

	private static bool DoCombinedFinalTexture_IsValid;

	private static IntPtr DoCombinedFinalTexture_FunctionAddress;

	private static int DoCombinedFinalTexture_ParamsSize;

	private static bool DoCombinedFinalTexture_ReturnValue_IsValid;

	private static int DoCombinedFinalTexture_ReturnValue_Offset;

	private static FFieldAddress DoCombinedFinalTexture_ReturnValue_PropertyAddress;

	private static bool DoSaveImposterCardMesh_IsValid;

	private static IntPtr DoSaveImposterCardMesh_FunctionAddress;

	private static int DoSaveImposterCardMesh_ParamsSize;

	private static bool CreatSceneShotToolActor_IsValid;

	private static IntPtr CreatSceneShotToolActor_FunctionAddress;

	private static int CreatSceneShotToolActor_ParamsSize;

	private static bool CreatSceneShotToolActor_ReturnValue_IsValid;

	private static int CreatSceneShotToolActor_ReturnValue_Offset;

	private static FFieldAddress CreatSceneShotToolActor_ReturnValue_PropertyAddress;

	private static bool DoCreateTreeImposterTask_IsValid;

	private static IntPtr DoCreateTreeImposterTask_FunctionAddress;

	private static int DoCreateTreeImposterTask_ParamsSize;

	private static bool ReleaseGeneratedTextures_IsValid;

	private static IntPtr ReleaseGeneratedTextures_FunctionAddress;

	private static int ReleaseGeneratedTextures_ParamsSize;

	private static bool DoCleanTempMemoryResource_IsValid;

	private static IntPtr DoCleanTempMemoryResource_FunctionAddress;

	private static int DoCleanTempMemoryResource_ParamsSize;

	private static bool SetTaskListFromFolderPath_IsValid;

	private static IntPtr SetTaskListFromFolderPath_FunctionAddress;

	private static int SetTaskListFromFolderPath_ParamsSize;

	private static bool RemoveAllHasGSImposterTask_IsValid;

	private static IntPtr RemoveAllHasGSImposterTask_FunctionAddress;

	private static int RemoveAllHasGSImposterTask_ParamsSize;

	private static bool CreatFinalImposterMaterial_IsValid;

	private static IntPtr CreatFinalImposterMaterial_FunctionAddress;

	private static int CreatFinalImposterMaterial_ParamsSize;

	private static bool CreatFinalImposterMaterial_ForceOverrideMat_IsValid;

	private static int CreatFinalImposterMaterial_ForceOverrideMat_Offset;

	private static FFieldAddress CreatFinalImposterMaterial_ForceOverrideMat_PropertyAddress;

	private static bool TestRenderCustomShadowMask_IsValid;

	private static IntPtr TestRenderCustomShadowMask_FunctionAddress;

	private static int TestRenderCustomShadowMask_ParamsSize;

	private static bool TestRenderCustomShadowMask_cardIndex_IsValid;

	private static int TestRenderCustomShadowMask_cardIndex_Offset;

	private static bool TestRenderCustomShadowMask_shadowMaskIndex_IsValid;

	private static int TestRenderCustomShadowMask_shadowMaskIndex_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool DoPBRTextureRenderBySceneShot_IsValid;

	private static IntPtr DoPBRTextureRenderBySceneShot_FunctionAddress;

	private static int DoPBRTextureRenderBySceneShot_ParamsSize;

	private static bool PythonCreatePerformanceTexture_IsValid;

	private static IntPtr PythonCreatePerformanceTexture_FunctionAddress;

	private static int PythonCreatePerformanceTexture_ParamsSize;

	private static bool PythonCreatePerformanceTexture_CaptureRTSize_IsValid;

	private static int PythonCreatePerformanceTexture_CaptureRTSize_Offset;

	private static FFieldAddress PythonCreatePerformanceTexture_CaptureRTSize_PropertyAddress;

	private static bool PythonCreatePerformanceTexture_PerformanceMatInstanceAssetPath_IsValid;

	private static int PythonCreatePerformanceTexture_PerformanceMatInstanceAssetPath_Offset;

	private static FFieldAddress PythonCreatePerformanceTexture_PerformanceMatInstanceAssetPath_PropertyAddress;

	private static bool PythonCreatePerformanceTexture_ImposterCombinedStdTextureFolderPath_IsValid;

	private static int PythonCreatePerformanceTexture_ImposterCombinedStdTextureFolderPath_Offset;

	private static FFieldAddress PythonCreatePerformanceTexture_ImposterCombinedStdTextureFolderPath_PropertyAddress;

	private static bool PythonCreatePerformanceTexture_ImposterDataTextureFolderPath_IsValid;

	private static int PythonCreatePerformanceTexture_ImposterDataTextureFolderPath_Offset;

	private static FFieldAddress PythonCreatePerformanceTexture_ImposterDataTextureFolderPath_PropertyAddress;

	private static bool PythonCreatePerformanceTexture_TrunkMaskThreshold_IsValid;

	private static int PythonCreatePerformanceTexture_TrunkMaskThreshold_Offset;

	private static FFieldAddress PythonCreatePerformanceTexture_TrunkMaskThreshold_PropertyAddress;

	private static bool PythonCreatePerformanceTexture_LeafMaskThreshold_IsValid;

	private static int PythonCreatePerformanceTexture_LeafMaskThreshold_Offset;

	private static FFieldAddress PythonCreatePerformanceTexture_LeafMaskThreshold_PropertyAddress;

	private static bool DoShadowMaskTextureRenderBySceneShot_IsValid;

	private static IntPtr DoShadowMaskTextureRenderBySceneShot_FunctionAddress;

	private static int DoShadowMaskTextureRenderBySceneShot_ParamsSize;

	[Category("GSImposter Path Setting")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "需要保存或导入到引擎的临时资源会保存在这个引擎目录下")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TempFileSaveRootFolderUnrealPath")]
	public string TempFileSaveRootFolderUnrealPath
	{
		get
		{
			CheckDestroyed();
			if (!TempFileSaveRootFolderUnrealPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TempFileSaveRootFolderUnrealPath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TempFileSaveRootFolderUnrealPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TempFileSaveRootFolderUnrealPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TempFileSaveRootFolderUnrealPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TempFileSaveRootFolderUnrealPath_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("GSImposter Path Setting")]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "路径中必须包含名为autogen的文件夹，否则导入资源时检测脚本会拦截。需要保存或导出到本地硬盘的临时资源会保存在这个硬盘目录下")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TempAutogenRootFolderDiskPath")]
	public string TempAutogenRootFolderDiskPath
	{
		get
		{
			CheckDestroyed();
			if (!TempAutogenRootFolderDiskPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TempAutogenRootFolderDiskPath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TempAutogenRootFolderDiskPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TempAutogenRootFolderDiskPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TempAutogenRootFolderDiskPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TempAutogenRootFolderDiskPath_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MD.ToolTip, "开启手动模式后各种新生成资源不会按照预定规则直接保存到SpeedTree文件夹而是全都保存到临时文件夹且临时文件夹，方便debug")]
	[Category("GSImposter Path Setting")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ManualSaveAssets")]
	public bool ManualSaveAssets
	{
		get
		{
			CheckDestroyed();
			if (!ManualSaveAssets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ManualSaveAssets");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ManualSaveAssets_Offset), 0, ManualSaveAssets_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ManualSaveAssets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ManualSaveAssets");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ManualSaveAssets_Offset), 0, ManualSaveAssets_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "ManualSaveAssets == false")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Path Setting")]
	[UMeta(MD.ToolTip, "勾选后生成的资源将保存到指定的文件夹路径")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:UseCustomSavePath")]
	public bool UseCustomSavePath
	{
		get
		{
			CheckDestroyed();
			if (!UseCustomSavePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:UseCustomSavePath");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCustomSavePath_Offset), 0, UseCustomSavePath_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCustomSavePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:UseCustomSavePath");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCustomSavePath_Offset), 0, UseCustomSavePath_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSImposter Path Setting")]
	[UMeta(MDProp.EditCondition, "ManualSaveAssets == false && UseCustomSavePath == true")]
	[UMeta(MD.ToolTip, "性能模式材质球保存在哪个文件夹路径")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PerformanceMatInstanceSaveAt")]
	public string PerformanceMatInstanceSaveAt
	{
		get
		{
			CheckDestroyed();
			if (!PerformanceMatInstanceSaveAt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PerformanceMatInstanceSaveAt");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PerformanceMatInstanceSaveAt_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformanceMatInstanceSaveAt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PerformanceMatInstanceSaveAt");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PerformanceMatInstanceSaveAt_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "ManualSaveAssets == false && UseCustomSavePath == true")]
	[UMeta(MD.ToolTip, "性能模式材质的Data纹理保存在哪个文件夹路径")]
	[Category("GSImposter Path Setting")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PerformanceMatDataTextureSaveAt")]
	public string PerformanceMatDataTextureSaveAt
	{
		get
		{
			CheckDestroyed();
			if (!PerformanceMatDataTextureSaveAt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PerformanceMatDataTextureSaveAt");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PerformanceMatDataTextureSaveAt_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformanceMatDataTextureSaveAt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PerformanceMatDataTextureSaveAt");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PerformanceMatDataTextureSaveAt_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Task Setting")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TaskFromFolder")]
	public TArrayReadWrite<string> TaskFromFolder
	{
		get
		{
			CheckDestroyed();
			if (!TaskFromFolder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TaskFromFolder");
				return null;
			}
			if (TaskFromFolder_Marshaler == null)
			{
				TaskFromFolder_Marshaler = new TArrayReadWriteMarshaler<string>(1, TaskFromFolder_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return TaskFromFolder_Marshaler.FromNative(IntPtr.Add(base.Address, TaskFromFolder_Offset));
		}
	}

	[EditAnywhere]
	[Category("GSImposter Task Setting")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TaskList")]
	public TArrayReadWrite<TreeImposter_TaskData> TaskList
	{
		get
		{
			CheckDestroyed();
			if (!TaskList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TaskList");
				return null;
			}
			if (TaskList_Marshaler == null)
			{
				TaskList_Marshaler = new TArrayReadWriteMarshaler<TreeImposter_TaskData>(1, TaskList_PropertyAddress, CachedMarshalingDelegates<TreeImposter_TaskData, TreeImposter_TaskData>.FromNative, CachedMarshalingDelegates<TreeImposter_TaskData, TreeImposter_TaskData>.ToNative);
			}
			return TaskList_Marshaler.FromNative(IntPtr.Add(base.Address, TaskList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Default Build Params")]
	[UMeta(MD.ToolTip, "略微放大生成的插片尺寸，因为植物应用了PPWPO后实际边缘一般比原始静态模型略微大一圈")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultCardMicoScale")]
	public float DefaultCardMicoScale
	{
		get
		{
			CheckDestroyed();
			if (!DefaultCardMicoScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultCardMicoScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultCardMicoScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultCardMicoScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultCardMicoScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultCardMicoScale_Offset), value);
			}
		}
	}

	[Category("GSImposter Default Build Params")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultCardPairCount")]
	public int DefaultCardPairCount
	{
		get
		{
			CheckDestroyed();
			if (!DefaultCardPairCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultCardPairCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefaultCardPairCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultCardPairCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultCardPairCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefaultCardPairCount_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "最终生成的实际使用的纹理尺寸")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("GSImposter Default Build Params")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultCaptureRTSize")]
	public int DefaultCaptureRTSize
	{
		get
		{
			CheckDestroyed();
			if (!DefaultCaptureRTSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultCaptureRTSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefaultCaptureRTSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultCaptureRTSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultCaptureRTSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefaultCaptureRTSize_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "截图的尺寸")]
	[Category("GSImposter Default Build Params")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultShotTextureSize")]
	public int DefaultShotTextureSize
	{
		get
		{
			CheckDestroyed();
			if (!DefaultShotTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultShotTextureSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DefaultShotTextureSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultShotTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultShotTextureSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DefaultShotTextureSize_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "生成ImposterData纹理时，原始Mask值大于此参数视为树干部分")]
	[Category("GSImposter Default Build Params")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultTrunkMaskThreshold")]
	public float DefaultTrunkMaskThreshold
	{
		get
		{
			CheckDestroyed();
			if (!DefaultTrunkMaskThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultTrunkMaskThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultTrunkMaskThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultTrunkMaskThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultTrunkMaskThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultTrunkMaskThreshold_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "生成ImposterData纹理时，原始Mask值大于此参数视为叶子部分")]
	[Category("GSImposter Default Build Params")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultLeafMaskThreshold")]
	public float DefaultLeafMaskThreshold
	{
		get
		{
			CheckDestroyed();
			if (!DefaultLeafMaskThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultLeafMaskThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultLeafMaskThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultLeafMaskThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DefaultLeafMaskThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultLeafMaskThreshold_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("GSImposter Cur Task Info")]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DebugPause")]
	public bool DebugPause
	{
		get
		{
			CheckDestroyed();
			if (!DebugPause_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DebugPause");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugPause_Offset), 0, DebugPause_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugPause_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DebugPause");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugPause_Offset), 0, DebugPause_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("GSImposter Cur Task Info")]
	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CurTaskIndex")]
	public int CurTaskIndex
	{
		get
		{
			CheckDestroyed();
			if (!CurTaskIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CurTaskIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CurTaskIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurTaskIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CurTaskIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CurTaskIndex_Offset), value);
			}
		}
	}

	[Category("GSImposter Cur Task Info")]
	[BlueprintReadOnly]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TreeMesh")]
	public UStaticMesh TreeMesh
	{
		get
		{
			CheckDestroyed();
			if (!TreeMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TreeMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, TreeMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TreeMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TreeMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, TreeMesh_Offset), value);
			}
		}
	}

	[Category("GSImposter Cur Task Info")]
	[BlueprintReadOnly]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:BakeLOD")]
	public int BakeLOD
	{
		get
		{
			CheckDestroyed();
			if (!BakeLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:BakeLOD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BakeLOD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BakeLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:BakeLOD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BakeLOD_Offset), value);
			}
		}
	}

	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[Category("GSImposter Cur Task Info")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CardPairCount")]
	public int CardPairCount
	{
		get
		{
			CheckDestroyed();
			if (!CardPairCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CardPairCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CardPairCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CardPairCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CardPairCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CardPairCount_Offset), value);
			}
		}
	}

	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[Category("GSImposter Cur Task Info")]
	[UMeta(MD.ToolTip, "略微放大生成的插片尺寸，因为植物应用了PPWPO后实际边缘一般比原始静态模型略微大一圈")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CardMicoScale")]
	public float CardMicoScale
	{
		get
		{
			CheckDestroyed();
			if (!CardMicoScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CardMicoScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CardMicoScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CardMicoScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CardMicoScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CardMicoScale_Offset), value);
			}
		}
	}

	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[Category("GSImposter Cur Task Info")]
	[UMeta(MD.ToolTip, "最终合成的实际使用的纹理尺寸")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CaptureRTSize")]
	public int CaptureRTSize
	{
		get
		{
			CheckDestroyed();
			if (!CaptureRTSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CaptureRTSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CaptureRTSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureRTSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CaptureRTSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CaptureRTSize_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UMeta(MD.ToolTip, "截图各角度素材的截图尺寸")]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[Category("GSImposter Cur Task Info")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShotTextureSize")]
	public int ShotTextureSize
	{
		get
		{
			CheckDestroyed();
			if (!ShotTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShotTextureSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ShotTextureSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShotTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShotTextureSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ShotTextureSize_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[UMeta(MD.ToolTip, "生成ImposterData纹理时，原始Mask值大于此参数视为树干部分")]
	[Category("GSImposter Cur Task Info")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TrunkMaskThreshold")]
	public float TrunkMaskThreshold
	{
		get
		{
			CheckDestroyed();
			if (!TrunkMaskThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TrunkMaskThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TrunkMaskThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TrunkMaskThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TrunkMaskThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TrunkMaskThreshold_Offset), value);
			}
		}
	}

	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[Category("GSImposter Cur Task Info")]
	[UMeta(MD.ToolTip, "生成ImposterData纹理时，原始Mask值大于此参数视为叶子部分")]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:LeafMaskThreshold")]
	public float LeafMaskThreshold
	{
		get
		{
			CheckDestroyed();
			if (!LeafMaskThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:LeafMaskThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeafMaskThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeafMaskThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:LeafMaskThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeafMaskThreshold_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("GSImposter Cur Task Info")]
	[BlueprintReadOnly]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ImposterCardMeshAsset")]
	public UObject ImposterCardMeshAsset
	{
		get
		{
			CheckDestroyed();
			if (!ImposterCardMeshAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ImposterCardMeshAsset");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, ImposterCardMeshAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImposterCardMeshAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ImposterCardMeshAsset");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, ImposterCardMeshAsset_Offset), value);
			}
		}
	}

	[Category("GSImposter Cur Task Info")]
	[BlueprintReadOnly]
	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CardSize")]
	public TArrayReadWrite<FVector> CardSize
	{
		get
		{
			CheckDestroyed();
			if (!CardSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CardSize");
				return null;
			}
			if (CardSize_Marshaler == null)
			{
				CardSize_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, CardSize_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return CardSize_Marshaler.FromNative(IntPtr.Add(base.Address, CardSize_Offset));
		}
	}

	[Category("GSImposter Cur Task Info")]
	[BlueprintReadOnly]
	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PosOffset")]
	public TArrayReadWrite<FVector> PosOffset
	{
		get
		{
			CheckDestroyed();
			if (!PosOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PosOffset");
				return null;
			}
			if (PosOffset_Marshaler == null)
			{
				PosOffset_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, PosOffset_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return PosOffset_Marshaler.FromNative(IntPtr.Add(base.Address, PosOffset_Offset));
		}
	}

	[BlueprintReadOnly]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[UProperty]
	[Category("GSImposter Cur Task Info")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:LastMeshName")]
	public FName LastMeshName
	{
		get
		{
			CheckDestroyed();
			if (!LastMeshName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:LastMeshName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LastMeshName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastMeshName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:LastMeshName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LastMeshName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Global Setting")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:GlobalOffset")]
	public FVector GlobalOffset
	{
		get
		{
			CheckDestroyed();
			if (!GlobalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:GlobalOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, GlobalOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlobalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:GlobalOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, GlobalOffset_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("GSImposter Global Setting")]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCountEveryCard")]
	public int ShadowMapCountEveryCard
	{
		get
		{
			CheckDestroyed();
			if (!ShadowMapCountEveryCard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCountEveryCard");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ShadowMapCountEveryCard_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowMapCountEveryCard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCountEveryCard");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ShadowMapCountEveryCard_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("GSImposter Global Setting")]
	[UMeta(MD.ToolTip, "如果Imposter材质球已经存在，是否还要重设其参数并生成新的Data纹理。勾选此项很可能覆盖已经精调过参数的材质")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ForceResetExitstedMat")]
	public bool ForceResetExitstedMat
	{
		get
		{
			CheckDestroyed();
			if (!ForceResetExitstedMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ForceResetExitstedMat");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceResetExitstedMat_Offset), 0, ForceResetExitstedMat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceResetExitstedMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ForceResetExitstedMat");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceResetExitstedMat_Offset), 0, ForceResetExitstedMat_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MD.ToolTip, "性能模式材质球是使用多图模式还是单图模式；多图模式是半成品考虑移除")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Global Setting")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PerformanceMaterialUseOneTextureMode")]
	public bool PerformanceMaterialUseOneTextureMode
	{
		get
		{
			CheckDestroyed();
			if (!PerformanceMaterialUseOneTextureMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PerformanceMaterialUseOneTextureMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PerformanceMaterialUseOneTextureMode_Offset), 0, PerformanceMaterialUseOneTextureMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PerformanceMaterialUseOneTextureMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PerformanceMaterialUseOneTextureMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PerformanceMaterialUseOneTextureMode_Offset), 0, PerformanceMaterialUseOneTextureMode_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("GSImposter Global Setting")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:AutoSetImposterMeshToTreeLOD")]
	public bool AutoSetImposterMeshToTreeLOD
	{
		get
		{
			CheckDestroyed();
			if (!AutoSetImposterMeshToTreeLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:AutoSetImposterMeshToTreeLOD");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoSetImposterMeshToTreeLOD_Offset), 0, AutoSetImposterMeshToTreeLOD_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoSetImposterMeshToTreeLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:AutoSetImposterMeshToTreeLOD");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoSetImposterMeshToTreeLOD_Offset), 0, AutoSetImposterMeshToTreeLOD_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSImposter Global Setting")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SaveImposterCardMesh")]
	public bool SaveImposterCardMesh
	{
		get
		{
			CheckDestroyed();
			if (!SaveImposterCardMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SaveImposterCardMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SaveImposterCardMesh_Offset), 0, SaveImposterCardMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SaveImposterCardMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SaveImposterCardMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SaveImposterCardMesh_Offset), 0, SaveImposterCardMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("GSImposter Global Setting")]
	[UMeta(MD.ToolTip, "烘焙之前会设置MPC的以下参数，主要是为了关闭WPO")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideMPCParam")]
	public TArrayReadWrite<TreeImposter_OverrideMPCParam> OverrideMPCParam
	{
		get
		{
			CheckDestroyed();
			if (!OverrideMPCParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideMPCParam");
				return null;
			}
			if (OverrideMPCParam_Marshaler == null)
			{
				OverrideMPCParam_Marshaler = new TArrayReadWriteMarshaler<TreeImposter_OverrideMPCParam>(1, OverrideMPCParam_PropertyAddress, CachedMarshalingDelegates<TreeImposter_OverrideMPCParam, TreeImposter_OverrideMPCParam>.FromNative, CachedMarshalingDelegates<TreeImposter_OverrideMPCParam, TreeImposter_OverrideMPCParam>.ToNative);
			}
			return OverrideMPCParam_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideMPCParam_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Global Setting")]
	[UMeta(MD.ToolTip, "烘焙之前会设置高模材质的以下参数，主要是为了关闭WPO")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideTreeMeshMatScalarParam")]
	public TArrayReadWrite<TreeImposter_OverrideMatScalarParam> OverrideTreeMeshMatScalarParam
	{
		get
		{
			CheckDestroyed();
			if (!OverrideTreeMeshMatScalarParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideTreeMeshMatScalarParam");
				return null;
			}
			if (OverrideTreeMeshMatScalarParam_Marshaler == null)
			{
				OverrideTreeMeshMatScalarParam_Marshaler = new TArrayReadWriteMarshaler<TreeImposter_OverrideMatScalarParam>(1, OverrideTreeMeshMatScalarParam_PropertyAddress, CachedMarshalingDelegates<TreeImposter_OverrideMatScalarParam, BlittableTypeMarshaler<TreeImposter_OverrideMatScalarParam>>.FromNative, CachedMarshalingDelegates<TreeImposter_OverrideMatScalarParam, BlittableTypeMarshaler<TreeImposter_OverrideMatScalarParam>>.ToNative);
			}
			return OverrideTreeMeshMatScalarParam_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideTreeMeshMatScalarParam_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Global Setting")]
	[UMeta(MD.ToolTip, "烘焙之前会设置高模材质的以下参数，主要是为了关闭WPO")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideTreeMeshMatLinearColorParam")]
	public TArrayReadWrite<TreeImposter_OverrideMatLinearColorParam> OverrideTreeMeshMatLinearColorParam
	{
		get
		{
			CheckDestroyed();
			if (!OverrideTreeMeshMatLinearColorParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideTreeMeshMatLinearColorParam");
				return null;
			}
			if (OverrideTreeMeshMatLinearColorParam_Marshaler == null)
			{
				OverrideTreeMeshMatLinearColorParam_Marshaler = new TArrayReadWriteMarshaler<TreeImposter_OverrideMatLinearColorParam>(1, OverrideTreeMeshMatLinearColorParam_PropertyAddress, CachedMarshalingDelegates<TreeImposter_OverrideMatLinearColorParam, BlittableTypeMarshaler<TreeImposter_OverrideMatLinearColorParam>>.FromNative, CachedMarshalingDelegates<TreeImposter_OverrideMatLinearColorParam, BlittableTypeMarshaler<TreeImposter_OverrideMatLinearColorParam>>.ToNative);
			}
			return OverrideTreeMeshMatLinearColorParam_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideTreeMeshMatLinearColorParam_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("GSImposter Global Setting")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideShotTexSetting")]
	public TArrayReadWrite<TreeImposter_OverrideTexSetting> OverrideShotTexSetting
	{
		get
		{
			CheckDestroyed();
			if (!OverrideShotTexSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideShotTexSetting");
				return null;
			}
			if (OverrideShotTexSetting_Marshaler == null)
			{
				OverrideShotTexSetting_Marshaler = new TArrayReadWriteMarshaler<TreeImposter_OverrideTexSetting>(1, OverrideShotTexSetting_PropertyAddress, CachedMarshalingDelegates<TreeImposter_OverrideTexSetting, TreeImposter_OverrideTexSetting>.FromNative, CachedMarshalingDelegates<TreeImposter_OverrideTexSetting, TreeImposter_OverrideTexSetting>.ToNative);
			}
			return OverrideShotTexSetting_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideShotTexSetting_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Global Setting")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideFinalTexSetting")]
	public TArrayReadWrite<TreeImposter_OverrideTexSetting> OverrideFinalTexSetting
	{
		get
		{
			CheckDestroyed();
			if (!OverrideFinalTexSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OverrideFinalTexSetting");
				return null;
			}
			if (OverrideFinalTexSetting_Marshaler == null)
			{
				OverrideFinalTexSetting_Marshaler = new TArrayReadWriteMarshaler<TreeImposter_OverrideTexSetting>(1, OverrideFinalTexSetting_PropertyAddress, CachedMarshalingDelegates<TreeImposter_OverrideTexSetting, TreeImposter_OverrideTexSetting>.FromNative, CachedMarshalingDelegates<TreeImposter_OverrideTexSetting, TreeImposter_OverrideTexSetting>.ToNative);
			}
			return OverrideFinalTexSetting_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideFinalTexSetting_Offset));
		}
	}

	[UMeta(MD.ToolTip, "烘焙之后从高模拷贝以下参数设置到imposter材质，主要是为了还原sss透光率和season，盖雪等开关。高模有多个材质，逐个遍历直到找到材质球名字里没有trunk的作为拷贝源")]
	[Category("GSImposter Global Setting")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CopyScalarParamsFromHQToImposterMat")]
	public TArrayReadWrite<FName> CopyScalarParamsFromHQToImposterMat
	{
		get
		{
			CheckDestroyed();
			if (!CopyScalarParamsFromHQToImposterMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CopyScalarParamsFromHQToImposterMat");
				return null;
			}
			if (CopyScalarParamsFromHQToImposterMat_Marshaler == null)
			{
				CopyScalarParamsFromHQToImposterMat_Marshaler = new TArrayReadWriteMarshaler<FName>(1, CopyScalarParamsFromHQToImposterMat_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return CopyScalarParamsFromHQToImposterMat_Marshaler.FromNative(IntPtr.Add(base.Address, CopyScalarParamsFromHQToImposterMat_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Global Setting")]
	[UMeta(MD.ToolTip, "烘焙之后从高模拷贝以下参数设置到imposter材质，主要是为了还原sss透光率和season，盖雪等开关。高模有多个材质，逐个遍历直到找到材质球名字里没有trunk的作为拷贝源")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CopySwitchParamsFromHQToImposterMat")]
	public TArrayReadWrite<FName> CopySwitchParamsFromHQToImposterMat
	{
		get
		{
			CheckDestroyed();
			if (!CopySwitchParamsFromHQToImposterMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CopySwitchParamsFromHQToImposterMat");
				return null;
			}
			if (CopySwitchParamsFromHQToImposterMat_Marshaler == null)
			{
				CopySwitchParamsFromHQToImposterMat_Marshaler = new TArrayReadWriteMarshaler<FName>(1, CopySwitchParamsFromHQToImposterMat_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return CopySwitchParamsFromHQToImposterMat_Marshaler.FromNative(IntPtr.Add(base.Address, CopySwitchParamsFromHQToImposterMat_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("GSImposter Global Setting")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:HDA_Asset")]
	public UHoudiniAsset HDA_Asset
	{
		get
		{
			CheckDestroyed();
			if (!HDA_Asset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:HDA_Asset");
				return null;
			}
			return UObjectMarshaler<UHoudiniAsset>.FromNative(IntPtr.Add(base.Address, HDA_Asset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HDA_Asset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:HDA_Asset");
			}
			else
			{
				UObjectMarshaler<UHoudiniAsset>.ToNative(IntPtr.Add(base.Address, HDA_Asset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Global Setting")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ToggleViewModeWaittngTime")]
	public float ToggleViewModeWaittngTime
	{
		get
		{
			CheckDestroyed();
			if (!ToggleViewModeWaittngTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ToggleViewModeWaittngTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ToggleViewModeWaittngTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ToggleViewModeWaittngTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ToggleViewModeWaittngTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ToggleViewModeWaittngTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("GSImposter Material")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_CustomShadowmap")]
	public UTextureRenderTarget2D RT_CustomShadowmap
	{
		get
		{
			CheckDestroyed();
			if (!RT_CustomShadowmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_CustomShadowmap");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_CustomShadowmap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_CustomShadowmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_CustomShadowmap");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_CustomShadowmap_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Material")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DebugColorArray")]
	public TArrayReadWrite<FLinearColor> DebugColorArray
	{
		get
		{
			CheckDestroyed();
			if (!DebugColorArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DebugColorArray");
				return null;
			}
			if (DebugColorArray_Marshaler == null)
			{
				DebugColorArray_Marshaler = new TArrayReadWriteMarshaler<FLinearColor>(1, DebugColorArray_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative);
			}
			return DebugColorArray_Marshaler.FromNative(IntPtr.Add(base.Address, DebugColorArray_Offset));
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[BlueprintReadWrite]
	[Category("GSImposter Material")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SkySphereToolMat")]
	public UMaterial SkySphereToolMat
	{
		get
		{
			CheckDestroyed();
			if (!SkySphereToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SkySphereToolMat");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, SkySphereToolMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkySphereToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SkySphereToolMat");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, SkySphereToolMat_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSImposter Material")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:MergeActorToolMat")]
	public UMaterial MergeActorToolMat
	{
		get
		{
			CheckDestroyed();
			if (!MergeActorToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:MergeActorToolMat");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, MergeActorToolMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MergeActorToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:MergeActorToolMat");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, MergeActorToolMat_Offset), value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[Category("GSImposter Material")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ColorDilateToolMat")]
	public UMaterial ColorDilateToolMat
	{
		get
		{
			CheckDestroyed();
			if (!ColorDilateToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ColorDilateToolMat");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, ColorDilateToolMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorDilateToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ColorDilateToolMat");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, ColorDilateToolMat_Offset), value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("GSImposter Material")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CustomShadowMapMat")]
	public UMaterial CustomShadowMapMat
	{
		get
		{
			CheckDestroyed();
			if (!CustomShadowMapMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CustomShadowMapMat");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, CustomShadowMapMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomShadowMapMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CustomShadowMapMat");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, CustomShadowMapMat_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("GSImposter Material")]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DistanceFieldToolMat")]
	public UMaterial DistanceFieldToolMat
	{
		get
		{
			CheckDestroyed();
			if (!DistanceFieldToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DistanceFieldToolMat");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, DistanceFieldToolMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceFieldToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DistanceFieldToolMat");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, DistanceFieldToolMat_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDFunc.AdvancedDisplay)]
	[Category("GSImposter Material")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CombineRGBAndAlphaToolMat")]
	public UMaterial CombineRGBAndAlphaToolMat
	{
		get
		{
			CheckDestroyed();
			if (!CombineRGBAndAlphaToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CombineRGBAndAlphaToolMat");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, CombineRGBAndAlphaToolMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CombineRGBAndAlphaToolMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CombineRGBAndAlphaToolMat");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, CombineRGBAndAlphaToolMat_Offset), value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[Category("GSImposter Material")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OriginImposterMatIns")]
	public UMaterialInstance OriginImposterMatIns
	{
		get
		{
			CheckDestroyed();
			if (!OriginImposterMatIns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OriginImposterMatIns");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, OriginImposterMatIns_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OriginImposterMatIns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OriginImposterMatIns");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, OriginImposterMatIns_Offset), value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSImposter Material")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OriginOneTexPerformanceImposterMatIns")]
	public UMaterialInstance OriginOneTexPerformanceImposterMatIns
	{
		get
		{
			CheckDestroyed();
			if (!OriginOneTexPerformanceImposterMatIns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OriginOneTexPerformanceImposterMatIns");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, OriginOneTexPerformanceImposterMatIns_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OriginOneTexPerformanceImposterMatIns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OriginOneTexPerformanceImposterMatIns");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, OriginOneTexPerformanceImposterMatIns_Offset), value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("GSImposter Material")]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OriginMultiTexPerformanceImposterMatIns")]
	public UMaterialInstance OriginMultiTexPerformanceImposterMatIns
	{
		get
		{
			CheckDestroyed();
			if (!OriginMultiTexPerformanceImposterMatIns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OriginMultiTexPerformanceImposterMatIns");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, OriginMultiTexPerformanceImposterMatIns_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OriginMultiTexPerformanceImposterMatIns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:OriginMultiTexPerformanceImposterMatIns");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, OriginMultiTexPerformanceImposterMatIns_Offset), value);
			}
		}
	}

	private AHoudiniAssetActor HDAActor { get; set; }

	private UHoudiniAssetComponent HDAComp { get; set; }

	private UStaticMeshComponent[] HDA_StaticMeshCompArray_ForCombineTexture { get; set; }

	private UStaticMeshComponent HDA_StaticMeshComp_RealCard { get; set; }

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TreeActor")]
	private AActor TreeActor
	{
		get
		{
			CheckDestroyed();
			if (!TreeActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TreeActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, TreeActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TreeActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TreeActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, TreeActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TreeStaticMeshComp")]
	private UStaticMeshComponent TreeStaticMeshComp
	{
		get
		{
			CheckDestroyed();
			if (!TreeStaticMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TreeStaticMeshComp");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, TreeStaticMeshComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TreeStaticMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TreeStaticMeshComp");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, TreeStaticMeshComp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CopyFromHQMatIndex")]
	private int CopyFromHQMatIndex
	{
		get
		{
			CheckDestroyed();
			if (!CopyFromHQMatIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CopyFromHQMatIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CopyFromHQMatIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CopyFromHQMatIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CopyFromHQMatIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CopyFromHQMatIndex_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapTreeActor")]
	private AActor ShadowMapTreeActor
	{
		get
		{
			CheckDestroyed();
			if (!ShadowMapTreeActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapTreeActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ShadowMapTreeActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowMapTreeActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapTreeActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ShadowMapTreeActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapTreeStaticMeshComp")]
	private UStaticMeshComponent ShadowMapTreeStaticMeshComp
	{
		get
		{
			CheckDestroyed();
			if (!ShadowMapTreeStaticMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapTreeStaticMeshComp");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, ShadowMapTreeStaticMeshComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowMapTreeStaticMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapTreeStaticMeshComp");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, ShadowMapTreeStaticMeshComp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:Capture2DActor")]
	private AActor Capture2DActor
	{
		get
		{
			CheckDestroyed();
			if (!Capture2DActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:Capture2DActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, Capture2DActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Capture2DActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:Capture2DActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, Capture2DActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CaptureComponent2D")]
	private USceneCaptureComponent2D CaptureComponent2D
	{
		get
		{
			CheckDestroyed();
			if (!CaptureComponent2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CaptureComponent2D");
				return null;
			}
			return UObjectMarshaler<USceneCaptureComponent2D>.FromNative(IntPtr.Add(base.Address, CaptureComponent2D_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureComponent2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CaptureComponent2D");
			}
			else
			{
				UObjectMarshaler<USceneCaptureComponent2D>.ToNative(IntPtr.Add(base.Address, CaptureComponent2D_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CameraActor")]
	private AActor CameraActor
	{
		get
		{
			CheckDestroyed();
			if (!CameraActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CameraActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, CameraActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CameraActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, CameraActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CameraComp")]
	private UCameraComponent CameraComp
	{
		get
		{
			CheckDestroyed();
			if (!CameraComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CameraComp");
				return null;
			}
			return UObjectMarshaler<UCameraComponent>.FromNative(IntPtr.Add(base.Address, CameraComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CameraComp");
			}
			else
			{
				UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(base.Address, CameraComp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCameraActor")]
	private AActor ShadowMapCameraActor
	{
		get
		{
			CheckDestroyed();
			if (!ShadowMapCameraActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCameraActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ShadowMapCameraActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowMapCameraActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCameraActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ShadowMapCameraActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCameraComp")]
	private UCameraComponent ShadowMapCameraComp
	{
		get
		{
			CheckDestroyed();
			if (!ShadowMapCameraComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCameraComp");
				return null;
			}
			return UObjectMarshaler<UCameraComponent>.FromNative(IntPtr.Add(base.Address, ShadowMapCameraComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowMapCameraComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCameraComp");
			}
			else
			{
				UObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(base.Address, ShadowMapCameraComp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCapture2DActor")]
	private AActor ShadowMapCapture2DActor
	{
		get
		{
			CheckDestroyed();
			if (!ShadowMapCapture2DActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCapture2DActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ShadowMapCapture2DActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowMapCapture2DActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCapture2DActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ShadowMapCapture2DActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCaptureComponent2D")]
	private USceneCaptureComponent2D ShadowMapCaptureComponent2D
	{
		get
		{
			CheckDestroyed();
			if (!ShadowMapCaptureComponent2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCaptureComponent2D");
				return null;
			}
			return UObjectMarshaler<USceneCaptureComponent2D>.FromNative(IntPtr.Add(base.Address, ShadowMapCaptureComponent2D_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowMapCaptureComponent2D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShadowMapCaptureComponent2D");
			}
			else
			{
				UObjectMarshaler<USceneCaptureComponent2D>.ToNative(IntPtr.Add(base.Address, ShadowMapCaptureComponent2D_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_RGB")]
	private UTextureRenderTarget2D RT_4Capture_RGB
	{
		get
		{
			CheckDestroyed();
			if (!RT_4Capture_RGB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_RGB");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_4Capture_RGB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_4Capture_RGB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_RGB");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_4Capture_RGB_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_NearestFillterRGB")]
	private UTextureRenderTarget2D RT_4Capture_NearestFillterRGB
	{
		get
		{
			CheckDestroyed();
			if (!RT_4Capture_NearestFillterRGB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_NearestFillterRGB");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_4Capture_NearestFillterRGB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_4Capture_NearestFillterRGB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_NearestFillterRGB");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_4Capture_NearestFillterRGB_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_Alpha")]
	private UTextureRenderTarget2D RT_4Capture_Alpha
	{
		get
		{
			CheckDestroyed();
			if (!RT_4Capture_Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_Alpha");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_4Capture_Alpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_4Capture_Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_Alpha");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_4Capture_Alpha_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_FinalTex")]
	private UTextureRenderTarget2D RT_4Capture_FinalTex
	{
		get
		{
			CheckDestroyed();
			if (!RT_4Capture_FinalTex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_FinalTex");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_4Capture_FinalTex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_4Capture_FinalTex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RT_4Capture_FinalTex");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_4Capture_FinalTex_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:isShadowMaskSceneShot")]
	private bool isShadowMaskSceneShot
	{
		get
		{
			CheckDestroyed();
			if (!isShadowMaskSceneShot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:isShadowMaskSceneShot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, isShadowMaskSceneShot_Offset), 0, isShadowMaskSceneShot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!isShadowMaskSceneShot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:isShadowMaskSceneShot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, isShadowMaskSceneShot_Offset), 0, isShadowMaskSceneShot_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:isPBRSceneShot")]
	private bool isPBRSceneShot
	{
		get
		{
			CheckDestroyed();
			if (!isPBRSceneShot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:isPBRSceneShot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, isPBRSceneShot_Offset), 0, isPBRSceneShot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!isPBRSceneShot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:isPBRSceneShot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, isPBRSceneShot_Offset), 0, isPBRSceneShot_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:isCreateTreeImposter")]
	private bool isCreateTreeImposter
	{
		get
		{
			CheckDestroyed();
			if (!isCreateTreeImposter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:isCreateTreeImposter");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, isCreateTreeImposter_Offset), 0, isCreateTreeImposter_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!isCreateTreeImposter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:isCreateTreeImposter");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, isCreateTreeImposter_Offset), 0, isCreateTreeImposter_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ImposterMatInsAsset")]
	private UMaterialInstance ImposterMatInsAsset
	{
		get
		{
			CheckDestroyed();
			if (!ImposterMatInsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ImposterMatInsAsset");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, ImposterMatInsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImposterMatInsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ImposterMatInsAsset");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, ImposterMatInsAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ImposterMatPerformanceModeInsAsset")]
	private UMaterialInstance ImposterMatPerformanceModeInsAsset
	{
		get
		{
			CheckDestroyed();
			if (!ImposterMatPerformanceModeInsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ImposterMatPerformanceModeInsAsset");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, ImposterMatPerformanceModeInsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImposterMatPerformanceModeInsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ImposterMatPerformanceModeInsAsset");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, ImposterMatPerformanceModeInsAsset_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	private Dictionary<GSImposterPathMark, string> GetUtilPath(UStaticMesh TreeMeshAsset)
	{
		Dictionary<GSImposterPathMark, string> dictionary = new Dictionary<GSImposterPathMark, string>
		{
			{
				GSImposterPathMark.AssetName,
				""
			},
			{
				GSImposterPathMark.AssetUnrealPath,
				""
			},
			{
				GSImposterPathMark.PerformanceImposterMaterialName,
				""
			},
			{
				GSImposterPathMark.ImposterDataTextureFolderUnrealPath,
				""
			},
			{
				GSImposterPathMark.ImposterCombinedStdTextureFolderDiskPath,
				""
			},
			{
				GSImposterPathMark.ImposterCombinedStdTextureFolderUnrealPath,
				""
			},
			{
				GSImposterPathMark.StdImposterMaterialFolderPath,
				""
			},
			{
				GSImposterPathMark.PerformanceImposterMaterialFolderPath,
				""
			},
			{
				GSImposterPathMark.ImposterCardMeshFolderUnrealPath,
				""
			},
			{
				GSImposterPathMark.ShotTexSaveToFolderDiskPath,
				""
			},
			{
				GSImposterPathMark.ShotTexImportToFolderUnrealPath,
				""
			}
		};
		string name = TreeMeshAsset.GetName();
		string pathName = TreeMeshAsset.GetPathName();
		string value = "Performance_" + name + "_Imposter";
		string text = pathName.Split(SplitPathArray, StringSplitOptions.RemoveEmptyEntries)[0];
		text = text.Split(new string[1] { name + "." + name }, StringSplitOptions.RemoveEmptyEntries)[0];
		text = text.Substring(0, text.Length - 1);
		string value2 = B1TreeAssetTextureRootFolderPath + text;
		string text2 = TempFileSaveRootFolderUnrealPath + "/" + name;
		string value3 = B1TreeAssetMaterialRootFolderPath + text;
		string value4 = TempAutogenRootFolderDiskPath + "/" + text2.Split(new string[1] { "/Game/" }, StringSplitOptions.None)[1];
		if (ManualSaveAssets)
		{
			dictionary[GSImposterPathMark.AssetName] = name;
			dictionary[GSImposterPathMark.AssetUnrealPath] = pathName;
			dictionary[GSImposterPathMark.PerformanceImposterMaterialName] = value;
			dictionary[GSImposterPathMark.ImposterDataTextureFolderUnrealPath] = text2;
			dictionary[GSImposterPathMark.ImposterCombinedStdTextureFolderDiskPath] = value4;
			dictionary[GSImposterPathMark.ImposterCombinedStdTextureFolderUnrealPath] = text2;
			dictionary[GSImposterPathMark.StdImposterMaterialFolderPath] = text2;
			dictionary[GSImposterPathMark.PerformanceImposterMaterialFolderPath] = text2;
			dictionary[GSImposterPathMark.ImposterCardMeshFolderUnrealPath] = text2;
			dictionary[GSImposterPathMark.ImposterCardMeshExportToFolderDiskPath] = value4;
			dictionary[GSImposterPathMark.ShotTexSaveToFolderDiskPath] = value4;
			dictionary[GSImposterPathMark.ShotTexImportToFolderUnrealPath] = text2;
		}
		else if (UseCustomSavePath)
		{
			dictionary[GSImposterPathMark.AssetName] = name;
			dictionary[GSImposterPathMark.AssetUnrealPath] = pathName;
			dictionary[GSImposterPathMark.PerformanceImposterMaterialName] = value;
			dictionary[GSImposterPathMark.ImposterDataTextureFolderUnrealPath] = PerformanceMatDataTextureSaveAt;
			dictionary[GSImposterPathMark.ImposterCombinedStdTextureFolderDiskPath] = value4;
			dictionary[GSImposterPathMark.ImposterCombinedStdTextureFolderUnrealPath] = text2;
			dictionary[GSImposterPathMark.StdImposterMaterialFolderPath] = text2;
			dictionary[GSImposterPathMark.PerformanceImposterMaterialFolderPath] = PerformanceMatInstanceSaveAt;
			dictionary[GSImposterPathMark.ImposterCardMeshFolderUnrealPath] = text2;
			dictionary[GSImposterPathMark.ImposterCardMeshExportToFolderDiskPath] = value4;
			dictionary[GSImposterPathMark.ShotTexSaveToFolderDiskPath] = value4;
			dictionary[GSImposterPathMark.ShotTexImportToFolderUnrealPath] = text2;
		}
		else
		{
			dictionary[GSImposterPathMark.AssetName] = name;
			dictionary[GSImposterPathMark.AssetUnrealPath] = pathName;
			dictionary[GSImposterPathMark.PerformanceImposterMaterialName] = value;
			dictionary[GSImposterPathMark.ImposterDataTextureFolderUnrealPath] = value2;
			dictionary[GSImposterPathMark.ImposterCombinedStdTextureFolderDiskPath] = value4;
			dictionary[GSImposterPathMark.ImposterCombinedStdTextureFolderUnrealPath] = text2;
			dictionary[GSImposterPathMark.StdImposterMaterialFolderPath] = text2;
			dictionary[GSImposterPathMark.PerformanceImposterMaterialFolderPath] = value3;
			dictionary[GSImposterPathMark.ImposterCardMeshFolderUnrealPath] = text2;
			dictionary[GSImposterPathMark.ImposterCardMeshExportToFolderDiskPath] = value4;
			dictionary[GSImposterPathMark.ShotTexSaveToFolderDiskPath] = value4;
			dictionary[GSImposterPathMark.ShotTexImportToFolderUnrealPath] = text2;
		}
		return dictionary;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetTaskListFromFolderPath")]
	public void SetTaskListFromFolderPath()
	{
		List<FAssetData> list = new List<FAssetData>();
		foreach (string item in TaskFromFolder)
		{
			UGSEditorAssetLibrary.GetAssetsByClassInFolder(out var OutAssetData, item, UClass.GetClass(typeof(UStaticMesh)).GetFName(), bRecursive: true);
			list.AddRange(OutAssetData);
		}
		if (list.Count != 0)
		{
			TaskList.Clear();
		}
		for (int i = 0; i < list.Count; i++)
		{
			UObject asset = list[i].GetAsset();
			if (!asset.IsNullOrDestroyed())
			{
				int bakeLOD = (asset as UStaticMesh).GetNumLods() - 1;
				TaskList.Add(new TreeImposter_TaskData(asset as UStaticMesh, bakeLOD));
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RemoveAllInvalidTask")]
	public void RemoveAllInvalidTask()
	{
		for (int num = TaskList.Count - 1; num >= 0; num--)
		{
			if (!Interior_CheckOneTaskValidity(num, TaskList[num]))
			{
				TaskList.RemoveAt(num);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RemoveAllHasGSImposterTask")]
	public void RemoveAllHasGSImposterTask()
	{
		for (int num = TaskList.Count - 1; num >= 0; num--)
		{
			if (TaskList[num].TreeMeshAsset.GetStaticMaterials().Last().MaterialInterface.GetBaseMaterial().GetPathName() == GSImposterMaterialUnrealPath)
			{
				TaskList.RemoveAt(num);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetAllTaskBakeZeroLOD")]
	public void SetAllTaskBakeZeroLOD()
	{
		for (int num = TaskList.Count - 1; num >= 0; num--)
		{
			if (Interior_CheckOneTaskValidity(num, TaskList[num]))
			{
				TreeImposter_TaskData value = new TreeImposter_TaskData
				{
					BakeLOD = 0,
					TreeMeshAsset = TaskList[num].TreeMeshAsset,
					CardMicoScale = TaskList[num].CardMicoScale,
					CardPairCount = TaskList[num].CardPairCount,
					CaptureRTSize = TaskList[num].CaptureRTSize,
					ShotTextureSize = TaskList[num].ShotTextureSize
				};
				TaskList[num] = value;
			}
		}
	}

	private bool Interior_CheckOneTaskValidity(int TaskIndex, TreeImposter_TaskData Task)
	{
		string text = "";
		string text2 = "";
		TreeImposter_TaskData treeImposter_TaskData = Task;
		if (treeImposter_TaskData.TreeMeshAsset.IsNullOrDestroyed())
		{
			text += "\n\tTreeMeshAsset is null.";
		}
		else
		{
			List<FStaticMaterial> staticMaterials = treeImposter_TaskData.TreeMeshAsset.GetStaticMaterials();
			int numLods = treeImposter_TaskData.TreeMeshAsset.GetNumLods();
			if (treeImposter_TaskData.BakeLOD < 0 || treeImposter_TaskData.BakeLOD > numLods)
			{
				text2 += "\n\tBakeLOD大于模型LOD数量";
			}
			if (treeImposter_TaskData.BakeLOD == numLods && staticMaterials[staticMaterials.Count - 1].MaterialSlotName.PlainName.ToLower().Contains("bill"))
			{
				text += "\n\t准备烘焙的LOD可能是SpeedTreeBillboard";
			}
			Dictionary<GSImposterPathMark, string> utilPath = GetUtilPath(treeImposter_TaskData.TreeMeshAsset);
			if (!ManualSaveAssets && UseCustomSavePath)
			{
				if (!UEditorAssetLibrary.DoesDirectoryExist(utilPath[GSImposterPathMark.ImposterDataTextureFolderUnrealPath]))
				{
					text2 = text2 + "\n\t纹理文件夹不存在，期望路径 " + utilPath[GSImposterPathMark.ImposterDataTextureFolderUnrealPath];
				}
				if (!UEditorAssetLibrary.DoesDirectoryExist(utilPath[GSImposterPathMark.PerformanceImposterMaterialFolderPath]))
				{
					text2 = text2 + "\n\t材质文件夹不存在，期望路径 " + utilPath[GSImposterPathMark.PerformanceImposterMaterialFolderPath];
				}
			}
			else
			{
				if (!utilPath[GSImposterPathMark.AssetUnrealPath].Contains(B1TreeAssetMeshRootFolderPath))
				{
					text2 = text2 + "\n\t模型路径不在" + B1TreeAssetMeshRootFolderPath;
				}
				if (!UEditorAssetLibrary.DoesDirectoryExist(utilPath[GSImposterPathMark.ImposterDataTextureFolderUnrealPath]))
				{
					text2 = text2 + "\n\t纹理文件夹不存在，期望路径 " + utilPath[GSImposterPathMark.ImposterDataTextureFolderUnrealPath];
				}
				if (!UEditorAssetLibrary.DoesDirectoryExist(utilPath[GSImposterPathMark.PerformanceImposterMaterialFolderPath]))
				{
					text2 = text2 + "\n\t材质文件夹不存在，期望路径 " + utilPath[GSImposterPathMark.PerformanceImposterMaterialFolderPath];
				}
			}
			if (!UEditorAssetLibrary.CheckoutAsset(utilPath[GSImposterPathMark.AssetUnrealPath]))
			{
				text2 = text2 + "\n\t无法Checkout模型 " + utilPath[GSImposterPathMark.AssetUnrealPath];
			}
			for (int i = 0; i < staticMaterials.Count; i++)
			{
				FStaticMaterial fStaticMaterial = staticMaterials[i];
				if (fStaticMaterial.MaterialInterface.IsNullOrDestroyed())
				{
					text2 += $"\n\t\tmaterial_{i} is null.";
					continue;
				}
				UMaterialInterface materialInterface = fStaticMaterial.MaterialInterface;
				UMaterial baseMaterial = fStaticMaterial.MaterialInterface.GetBaseMaterial();
				UMaterialInstanceConstant instance = fStaticMaterial.MaterialInterface as UMaterialInstanceConstant;
				if (fStaticMaterial.MaterialSlotName.PlainName.ToLower().Contains("houdini"))
				{
					text2 += "\n\t存在插槽名称包含houdini的旧材质";
				}
				else if (baseMaterial.GetPathName() == GSImposterMaterialUnrealPath)
				{
					if (i != staticMaterials.Count - 1)
					{
						text2 += $"\n\t\tmaterial_{i} 是 GSImposter 材质，但不是模型的最后一个材质（材质总数{staticMaterials.Count - 1}）";
					}
					if (!UEditorAssetLibrary.CheckoutAsset(materialInterface.GetPathName()))
					{
						text2 = text2 + "\n\t无法Checkout材质 " + materialInterface.GetPathName();
					}
					UTexture materialInstanceTextureParameterValue = UMaterialEditingLibrary.GetMaterialInstanceTextureParameterValue(instance, new FName("DataTex"));
					if (materialInstanceTextureParameterValue.IsNullOrDestroyed())
					{
						text2 += "\n\tGSImposter Data纹理为null";
					}
					else if (!materialInstanceTextureParameterValue.GetPathName().Contains(utilPath[GSImposterPathMark.ImposterDataTextureFolderUnrealPath]))
					{
						text2 += "\n\tGSImposter Data纹理不在指定文件夹";
					}
					else if (!UEditorAssetLibrary.CheckoutAsset(materialInstanceTextureParameterValue.GetPathName()))
					{
						text2 = text2 + "\n\t无法Checkout GSImposter Data 纹理 " + materialInstanceTextureParameterValue.GetPathName();
					}
					for (int j = 0; j < staticMaterials.Count; j++)
					{
						if (staticMaterials[j].MaterialSlotName.PlainName.ToLower().Contains("bill"))
						{
							text2 += "\n\t模型使用了GSImposter材质但存在其他名称为Billboard的材质插槽";
						}
					}
				}
				else
				{
					UTexture materialInstanceTextureParameterValue2 = UMaterialEditingLibrary.GetMaterialInstanceTextureParameterValue(instance, new FName("AlphaTex"));
					UTexture materialInstanceTextureParameterValue3 = UMaterialEditingLibrary.GetMaterialInstanceTextureParameterValue(instance, new FName("NormalMap"));
					if (materialInstanceTextureParameterValue2.IsNullOrDestroyed() && fStaticMaterial.MaterialInterface.GetBaseMaterial().BlendMode != EBlendMode.BLEND_Opaque)
					{
						text2 += $"\n\t\tmaterial_{i} 没有 AlphaTex";
					}
					if (materialInstanceTextureParameterValue3.IsNullOrDestroyed() && fStaticMaterial.MaterialInterface.GetBaseMaterial().GetPathName() != SnowMatUnrealPath)
					{
						text2 += $"\n\t\tmaterial_{i} 没有 NormalMap";
					}
				}
			}
		}
		if (treeImposter_TaskData.CardMicoScale == 1f)
		{
			text += "\n\tCardMicoScale等于1，可能导致模型实际尺寸大于插片模型尺寸，纹理可能出现切边";
		}
		if (text != "" || text2 != "")
		{
			_ = text == "";
			_ = text2 == "";
		}
		return text2 == "";
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CheckTaskMeshValidity")]
	public bool CheckTaskMeshValidity()
	{
		bool flag = false;
		new List<UPackage>();
		for (int i = 0; i < TaskList.Count; i++)
		{
			bool flag2 = Interior_CheckOneTaskValidity(i, TaskList[i]);
			flag = flag || !flag2;
		}
		return !flag;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetNewLevelEnvActor")]
	public void SetNewLevelEnvActor(bool Visable)
	{
		AVolumetricCloud[] allActorsOfClass = base.World.GetAllActorsOfClass<AVolumetricCloud>();
		base.World.GetAllActorsOfClass<AExponentialHeightFog>();
		base.World.GetAllActorsOfClass<ASkyAtmosphere>();
		base.World.GetAllActorsOfClass<ASkyLight>();
		AVolumetricCloud[] array = allActorsOfClass;
		foreach (AVolumetricCloud aVolumetricCloud in array)
		{
			if (!aVolumetricCloud.IsNullOrDestroyed())
			{
				aVolumetricCloud.GetComponentByClass<UVolumetricCloudComponent>()?.SetVisibility(Visable);
			}
		}
	}

	public void SetPP(bool BeginSnap)
	{
		USystemLibrary.ExecuteConsoleCommand(this, "r.EyeAdaptationQuality " + ((!BeginSnap) ? 2 : 0), null);
	}

	private string GetCurSystemTimeHash()
	{
		string s = DateTime.Now.ToString();
		uint num = 2166136261u;
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		foreach (byte b in bytes)
		{
			num ^= b;
			num *= 16777619;
		}
		string text = num.ToString("X");
		return text.Substring(0, Math.Min(8, text.Length));
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoCleanTempMemoryResource")]
	public void DoCleanTempMemoryResource()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetCurrentTask")]
	public bool SetCurrentTask(int TaskIndex = -1)
	{
		if (TaskIndex <= -1)
		{
			while (CurTaskIndex + 1 < TaskList.Count)
			{
				CurTaskIndex++;
				TreeImposter_TaskData treeImposter_TaskData = TaskList[CurTaskIndex];
				if (!treeImposter_TaskData.TreeMeshAsset.IsNullOrDestroyed())
				{
					TreeMesh = treeImposter_TaskData.TreeMeshAsset;
					BakeLOD = treeImposter_TaskData.BakeLOD;
					CardMicoScale = ((treeImposter_TaskData.CardMicoScale == 0f) ? DefaultCardMicoScale : treeImposter_TaskData.CardMicoScale);
					CardPairCount = ((treeImposter_TaskData.CardPairCount <= 0) ? DefaultCardPairCount : treeImposter_TaskData.CardPairCount);
					CaptureRTSize = ((treeImposter_TaskData.CaptureRTSize <= 0) ? DefaultCaptureRTSize : treeImposter_TaskData.CaptureRTSize);
					ShotTextureSize = ((treeImposter_TaskData.ShotTextureSize <= 0) ? DefaultShotTextureSize : treeImposter_TaskData.ShotTextureSize);
					TrunkMaskThreshold = ((treeImposter_TaskData.TrunkMaskThreshold <= 0f) ? DefaultTrunkMaskThreshold : treeImposter_TaskData.TrunkMaskThreshold);
					LeafMaskThreshold = ((treeImposter_TaskData.LeafMaskThreshold <= 0f) ? DefaultLeafMaskThreshold : treeImposter_TaskData.LeafMaskThreshold);
					return true;
				}
			}
			return false;
		}
		if (TaskIndex < TaskList.Count)
		{
			TreeImposter_TaskData treeImposter_TaskData2 = TaskList[TaskIndex];
			TreeMesh = treeImposter_TaskData2.TreeMeshAsset;
			BakeLOD = treeImposter_TaskData2.BakeLOD;
			CardMicoScale = ((treeImposter_TaskData2.CardMicoScale == 0f) ? DefaultCardMicoScale : treeImposter_TaskData2.CardMicoScale);
			CardPairCount = ((treeImposter_TaskData2.CardPairCount <= 0) ? DefaultCardPairCount : treeImposter_TaskData2.CardPairCount);
			CaptureRTSize = ((treeImposter_TaskData2.CaptureRTSize <= 0) ? DefaultCaptureRTSize : treeImposter_TaskData2.CaptureRTSize);
			ShotTextureSize = ((treeImposter_TaskData2.ShotTextureSize <= 0) ? DefaultShotTextureSize : treeImposter_TaskData2.ShotTextureSize);
			TrunkMaskThreshold = ((treeImposter_TaskData2.TrunkMaskThreshold <= 0f) ? DefaultTrunkMaskThreshold : treeImposter_TaskData2.TrunkMaskThreshold);
			LeafMaskThreshold = ((treeImposter_TaskData2.LeafMaskThreshold <= 0f) ? DefaultLeafMaskThreshold : treeImposter_TaskData2.LeafMaskThreshold);
			return true;
		}
		return false;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CreateHDAInstance")]
	public void CreateHDAInstance()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ToggleDebugPause")]
	public void ToggleDebugPause()
	{
		DebugPause = !DebugPause;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoCreateTreeImposterTask")]
	public void DoCreateTreeImposterTask()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CheckHDABakeResult")]
	public bool CheckHDABakeResult()
	{
		AHoudiniAssetActor[] allActorsOfClass = base.World.GetAllActorsOfClass<AHoudiniAssetActor>();
		if (allActorsOfClass.Length != 1)
		{
			return false;
		}
		AHoudiniAssetActor aHoudiniAssetActor = allActorsOfClass[0];
		if (aHoudiniAssetActor.GetComponentByClass<UHoudiniAssetComponent>().IsNullOrDestroyed())
		{
			return false;
		}
		foreach (UActorComponent item in aHoudiniAssetActor.GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>()))
		{
			UStaticMeshComponent uStaticMeshComponent = item as UStaticMeshComponent;
			if (uStaticMeshComponent == null || uStaticMeshComponent.StaticMesh.IsNullOrDestroyed())
			{
				return false;
			}
		}
		return true;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:FillHoudiniData")]
	public bool FillHoudiniData()
	{
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CreatSceneShotToolActor")]
	public bool CreatSceneShotToolActor()
	{
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoPBRTextureRenderBySceneShot")]
	public void DoPBRTextureRenderBySceneShot()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoShadowMaskTextureRenderBySceneShot")]
	public void DoShadowMaskTextureRenderBySceneShot()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:AutoImportSceneShot")]
	public void AutoImportSceneShot()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:AutoDelectSceneShot")]
	public void AutoDelectSceneShot()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoCombinedFinalTexture")]
	public bool DoCombinedFinalTexture()
	{
		return false;
	}

	private void TextureApplyOverrideTexSetting(UTexture2D Tex, TreeImposter_OverrideTexSetting OverrideSetting)
	{
	}

	private void CleanAllRenderTarget()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CreatFinalImposterMaterial")]
	public void CreatFinalImposterMaterial(bool ForceOverrideMat = false)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoSaveImposterCardMesh")]
	public void DoSaveImposterCardMesh()
	{
		if (!HDA_StaticMeshComp_RealCard.IsNullOrDestroyed() && !HDA_StaticMeshComp_RealCard.StaticMesh.IsNullOrDestroyed())
		{
			Dictionary<GSImposterPathMark, string> utilPath = GetUtilPath(TreeMesh);
			string text = utilPath[GSImposterPathMark.AssetName] + "_ImposterMesh";
			string text2 = utilPath[GSImposterPathMark.ImposterCardMeshFolderUnrealPath];
			string text3 = utilPath[GSImposterPathMark.ImposterCardMeshExportToFolderDiskPath] + "/" + text + ".fbx";
			string pathName = HDA_StaticMeshComp_RealCard.StaticMesh.GetPathName();
			_ = text2 + "/" + text + "." + text;
			string command = "py \neditor_util = unreal.EditorUtilityLibrary()\nasset_registry = unreal.AssetRegistryHelpers.get_asset_registry()\ntask = unreal.AssetExportTask()\ntask.set_editor_property(\"filename\", \"" + text3 + "\")\ntask.set_editor_property(\"automated\", True)\nexport_obj_data = unreal.AssetRegistry.get_asset_by_object_path(asset_registry, \"" + pathName + "\", False)\nexport_obj = export_obj_data.get_asset()\ntask.set_editor_property(\"object\", export_obj)\nfbx_options = unreal.FbxExportOption()\nfbx_options.set_editor_property(\"collision\", False)\nfbx_options.set_editor_property(\"force_front_x_axis\", False)\nfbx_options.set_editor_property(\"level_of_detail\", False)\ntask.set_editor_property(\"options\", fbx_options)\nunreal.Exporter.run_asset_export_task(task)\n";
			USystemLibrary.ExecuteConsoleCommand(this, command, null);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShowCompare")]
	public void ShowCompare()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoSetLOD")]
	public void DoSetLOD()
	{
	}

	private void ResetAllStageParams()
	{
		isCreateTreeImposter = false;
		DebugPause = false;
		CTIStage = CreatTreeImposterStage.CleanLastMeshMemoryResource;
		OnChangeViewStateStage = false;
		SetViewStateStep = 0;
		ViewStateChangeTempTimeACC = 0f;
		isShadowMaskSceneShot = false;
		isShadowMaskSceneShot = false;
		ShadowMaskShotCount = 0;
		if (!ShadowMapCameraComp.IsNullOrDestroyed())
		{
			ShadowMapCameraComp.PostProcessBlendWeight = 0f;
		}
		isPBRSceneShot = false;
		PBRSceneShotCount = 0;
		PBRSceneShot_CompletedBufferCount = 0;
		if (!CameraComp.IsNullOrDestroyed())
		{
			CameraComp.PostProcessBlendWeight = 0f;
		}
		isWaittingStage = false;
		isWaittingStageWaittingFrameCount = 0;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CleanAllToolAssets")]
	public void CleanAllToolAssets()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:LogForwardVector")]
	public void LogForwardVector()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ReleaseGeneratedTextures")]
	public void ReleaseGeneratedTextures()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "py \"../../../../../unreal_proj/Content/Python/AssetsManager_forProgrammer/ReleaseAssets.py\" \"/Game/03_VFXRes/EditorArtTool/TreeImposter/TreeImposterTempFolder/\"", null);
	}

	private void StartWaittingStage()
	{
	}

	private bool CheckSourceMatCanRenderCustomShadowMap()
	{
		if (TreeStaticMeshComp.IsNullOrDestroyed())
		{
			return false;
		}
		int numMaterials = TreeStaticMeshComp.GetNumMaterials();
		for (int i = 0; i < numMaterials; i++)
		{
			UMaterialInterface material = TreeStaticMeshComp.GetMaterial(i);
			if (material.IsNullOrDestroyed())
			{
				return false;
			}
			if (material.GetBaseMaterial().GetName().Contains(GSImposterMaterialName))
			{
				if (i == numMaterials - 1)
				{
				}
				continue;
			}
			UMaterialInstanceDynamic uMaterialInstanceDynamic = material as UMaterialInstanceDynamic;
			if (uMaterialInstanceDynamic != null)
			{
				UTexture uTexture = null;
				uTexture = uMaterialInstanceDynamic.GetTextureParameterValue(new FName("AlphaTex"));
				UTexture textureParameterValue = uMaterialInstanceDynamic.GetTextureParameterValue(new FName("NormalMap"));
				uTexture.IsNullOrDestroyed();
				if (textureParameterValue.IsNullOrDestroyed())
				{
					BGW_LogUtil.LogError($"[GSImposterTool][Error] {TreeMesh.GetName()} material {i} has no normal map. Bake tool stop.");
					return false;
				}
			}
		}
		return true;
	}

	private bool SetCustomShadowMaskMaterial()
	{
		if (CustomShadowMapMat.IsNullOrDestroyed())
		{
			return false;
		}
		if (TreeStaticMeshComp.IsNullOrDestroyed())
		{
			return false;
		}
		if (ShadowMapTreeStaticMeshComp.IsNullOrDestroyed())
		{
			return false;
		}
		int numMaterials = TreeStaticMeshComp.GetNumMaterials();
		for (int i = 0; i < numMaterials; i++)
		{
			UMaterialInterface material = TreeStaticMeshComp.GetMaterial(i);
			UTexture materialInstanceTextureParameterValue = UMaterialEditingLibrary.GetMaterialInstanceTextureParameterValue(material as UMaterialInstanceConstant, new FName("AlphaTex"));
			UTexture materialInstanceTextureParameterValue2 = UMaterialEditingLibrary.GetMaterialInstanceTextureParameterValue(material as UMaterialInstanceConstant, new FName("NormalMap"));
			UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(this, CustomShadowMapMat, FName.None, EMIDCreationFlags.None);
			if (!materialInstanceTextureParameterValue.IsNullOrDestroyed())
			{
				uMaterialInstanceDynamic.SetTextureParameterValue(new FName("MaskTex"), materialInstanceTextureParameterValue);
			}
			if (!materialInstanceTextureParameterValue2.IsNullOrDestroyed())
			{
				uMaterialInstanceDynamic.SetTextureParameterValue(new FName("NormalTex"), materialInstanceTextureParameterValue2);
			}
			ShadowMapTreeStaticMeshComp.SetMaterial(i, uMaterialInstanceDynamic);
		}
		return true;
	}

	private void RenderCustomShadowMask(int cardIndex, int shadowMaskIndex)
	{
		if (!ShadowMapTreeStaticMeshComp.IsNullOrDestroyed())
		{
			ShadowMapTreeStaticMeshComp.SetVisibility(bNewVisibility: true);
		}
		if (!TreeStaticMeshComp.IsNullOrDestroyed())
		{
			TreeStaticMeshComp.SetVisibility(bNewVisibility: false);
		}
		ShadowMapCameraComp.SetProjectionMode(ECameraProjectionMode.Orthographic);
		ShadowMapCameraComp.SetAspectRatio(1f);
		float num = (float)cardIndex * 180f / (float)CardPairCount;
		ShadowMapCameraActor.SetActorRotation(new FRotator(-45.0, (float)shadowMaskIndex * 90f + num, 0.0), bTeleportPhysics: true);
		DirectionalLightActor.SetActorRotation(new FRotator(-45.0, (float)shadowMaskIndex * 90f + num, 0.0), bTeleportPhysics: true);
		DirectionalLightComponent.SetDynamicShadowDistanceMovableLight(40000f);
		FTransform actorTransform = TreeActor.GetActorTransform();
		TreeActor.GetActorBounds(bOnlyCollidingComponents: false, out var Origin, out var BoxExtent);
		TreeActor.SetActorRotation(new FRotator(-45.0, (float)shadowMaskIndex * 90f + num, 0.0), bTeleportPhysics: true);
		TreeActor.GetActorBounds(bOnlyCollidingComponents: false, out var _, out var BoxExtent2);
		TreeActor.SetActorTransform(actorTransform, bSweep: false, out var SweepHitResult, bTeleport: true);
		BoxExtent *= 2.0;
		BoxExtent2 *= 2.0;
		float num2 = (float)Math.Sqrt(BoxExtent.X * BoxExtent.X + BoxExtent.Y * BoxExtent.Y + BoxExtent.Z * BoxExtent.Z);
		float orthoWidth;
		float num3 = (orthoWidth = (float)Math.Sqrt(BoxExtent2.X * BoxExtent2.X + BoxExtent2.Y * BoxExtent2.Y + BoxExtent2.Z * BoxExtent2.Z)) * 4f;
		ShadowMapCameraComp.SetOrthoWidth(orthoWidth);
		FVector fVector = ShadowMapCameraActor.GetActorForwardVector().Normal();
		ShadowMapCameraActor.SetActorLocation(Origin + fVector * -1.0 * num3, bSweep: true, out SweepHitResult, bTeleport: true);
		ShadowMapCapture2DActor.SetActorRotation(new FRotator(-45.0, (float)shadowMaskIndex * 90f + num, 0.0), bTeleportPhysics: true);
		ShadowMapCapture2DActor.SetActorLocation(Origin + fVector * -1.0 * num3, bSweep: true, out SweepHitResult, bTeleport: true);
		ShadowMapCaptureComponent2D.OrthoWidth = orthoWidth;
		ShadowMapCaptureComponent2D.ProjectionType = ECameraProjectionMode.Orthographic;
		ShadowMapCaptureComponent2D.CaptureSource = ESceneCaptureSource.SCS_SceneDepth;
		ShadowMapCaptureComponent2D.TextureTarget = RT_CustomShadowmap;
		ShadowMapCaptureComponent2D.CaptureEveryFrame = true;
		ShadowMapCaptureComponent2D.CaptureScene();
		ShadowMapCameraComp.GetCameraView(0f, out var DesiredView);
		UGameplayStatics.GetViewProjectionMatrix(DesiredView, out var _, out var _, out var ViewProjectionMatrix);
		FMatrix fMatrix = ViewProjectionMatrix;
		fMatrix = fMatrix.GetTransposed();
		FVector vector = fVector * -1.0;
		int numMaterials = ShadowMapTreeStaticMeshComp.GetNumMaterials();
		for (int i = 0; i < numMaterials; i++)
		{
			UMaterialInstanceDynamic obj = ShadowMapTreeStaticMeshComp.GetMaterial(i) as UMaterialInstanceDynamic;
			obj.SetVectorParameterValue(new FName("LightPosWS"), new FLinearColor(ShadowMapCapture2DActor.GetActorLocation()));
			obj.SetVectorParameterValue(new FName("LightDirWS"), new FLinearColor(vector));
			obj.SetVectorParameterValue(new FName("ShadowMatrix_0"), new FLinearColor(fMatrix[0, 0], fMatrix[0, 1], fMatrix[0, 2], fMatrix[0, 3]));
			obj.SetVectorParameterValue(new FName("ShadowMatrix_1"), new FLinearColor(fMatrix[1, 0], fMatrix[1, 1], fMatrix[1, 2], fMatrix[1, 3]));
			obj.SetVectorParameterValue(new FName("ShadowMatrix_2"), new FLinearColor(fMatrix[2, 0], fMatrix[2, 1], fMatrix[2, 2], fMatrix[2, 3]));
			obj.SetVectorParameterValue(new FName("ShadowMatrix_3"), new FLinearColor(fMatrix[3, 0], fMatrix[3, 1], fMatrix[3, 2], fMatrix[3, 3]));
			obj.SetTextureParameterValue(new FName("ShadowMap"), RT_CustomShadowmap);
		}
		if (cardIndex == CardPairCount * 2)
		{
			FTransform fTransform = FTransform.Default;
			fTransform.SetRotation(new FRotator(0.0, 0.0, 0.0).Quaternion());
			fTransform.SetLocation(PosOffset[cardIndex] * new FVector(1.0, 1.0, 0.0));
			fTransform = fTransform.Inverse();
			CameraActor.SetActorTransform(fTransform, bSweep: false, out SweepHitResult, bTeleport: true);
			CameraComp.SetProjectionMode(ECameraProjectionMode.Orthographic);
			FVector fVector2 = CardSize[cardIndex];
			CameraComp.SetOrthoWidth(fVector2.X);
			CameraComp.SetAspectRatio(fVector2.X / fVector2.Z);
			FRotator newRotation = new FRotator(-90.0, 0.0, -90.0);
			FVector fVector3 = new FVector(0.0, 0.0, BoxExtent.Z * 4f);
			CameraComp.SetRelativeLocationAndRotation(fVector3 + GlobalOffset, newRotation, bSweep: false, out SweepHitResult, bTeleport: false);
		}
		else
		{
			FTransform fTransform2 = FTransform.Default;
			fTransform2.SetRotation(new FRotator(0.0, num, 0.0).Quaternion());
			fTransform2.SetLocation(PosOffset[cardIndex]);
			fTransform2 = fTransform2.Inverse();
			CameraActor.SetActorTransform(fTransform2, bSweep: false, out SweepHitResult, bTeleport: true);
			CameraComp.SetProjectionMode(ECameraProjectionMode.Orthographic);
			FVector fVector4 = CardSize[cardIndex];
			CameraComp.SetOrthoWidth(fVector4.X);
			CameraComp.SetAspectRatio(fVector4.X / fVector4.Z);
			FRotator newRotation2 = new FRotator(0.0, -90.0, 0.0);
			FVector fVector5 = new FVector(0.0, num2 * 4f, 0.0);
			CameraComp.SetRelativeLocationAndRotation(fVector5 + GlobalOffset, newRotation2, bSweep: false, out SweepHitResult, bTeleport: false);
		}
	}

	private void WaitChangeViewStateStageACC(float DeltaSeconds, float WaitThreshold = 0.25f)
	{
		ViewStateChangeTempTimeACC += DeltaSeconds;
		if (ViewStateChangeTempTimeACC >= WaitThreshold)
		{
			ViewStateChangeTempTimeACC = 0f;
			SetViewStateStep++;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PythonCreatePerformanceTexture")]
	public void PythonCreatePerformanceTexture(string CaptureRTSize, string PerformanceMatInstanceAssetPath, string ImposterCombinedStdTextureFolderPath, string ImposterDataTextureFolderPath, string TrunkMaskThreshold, string LeafMaskThreshold)
	{
		if (PerformanceMaterialUseOneTextureMode)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "py \"" + PythonScriptPath_PerformanceCompressOneRGBA8 + "\" \"" + CaptureRTSize + "\" \"" + PerformanceMatInstanceAssetPath + "\" \"" + ImposterCombinedStdTextureFolderPath + "\" \"" + ImposterDataTextureFolderPath + "\" \"" + TempAutogenRootFolderDiskPath + "\" \"" + TrunkMaskThreshold + "\" \"" + LeafMaskThreshold + "\"", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "py \"" + PythonScriptPath_PerformanceCompressMultiTex + "\" \"" + CaptureRTSize + "\" \"" + PerformanceMatInstanceAssetPath + "\" \"" + ImposterCombinedStdTextureFolderPath + "\" \"" + ImposterDataTextureFolderPath + "\" \"" + TempAutogenRootFolderDiskPath + "\" \"" + TrunkMaskThreshold + "\" \"" + LeafMaskThreshold + "\"", null);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TestRenderCustomShadowMask")]
	public void TestRenderCustomShadowMask(int cardIndex, int shadowMaskIndex)
	{
		ShadowMapCameraComp.SetProjectionMode(ECameraProjectionMode.Orthographic);
		ShadowMapCameraComp.SetAspectRatio(1f);
		float num = (float)cardIndex * 180f / (float)CardPairCount;
		ShadowMapCameraActor.SetActorRotation(new FRotator(-45.0, (float)shadowMaskIndex * 90f + num, 0.0), bTeleportPhysics: true);
		DirectionalLightActor.SetActorRotation(new FRotator(-45.0, (float)shadowMaskIndex * 90f + num, 0.0), bTeleportPhysics: true);
		DirectionalLightComponent.SetDynamicShadowDistanceMovableLight(40000f);
		FTransform actorTransform = TreeActor.GetActorTransform();
		TreeActor.GetActorBounds(bOnlyCollidingComponents: false, out var Origin, out var BoxExtent);
		TreeActor.SetActorRotation(new FRotator(-45.0, (float)shadowMaskIndex * 90f + num, 0.0), bTeleportPhysics: true);
		TreeActor.GetActorBounds(bOnlyCollidingComponents: false, out var _, out var BoxExtent2);
		TreeActor.SetActorTransform(actorTransform, bSweep: false, out var SweepHitResult, bTeleport: true);
		BoxExtent *= 2.0;
		BoxExtent2 *= 2.0;
		float num2 = (float)Math.Sqrt(BoxExtent.X * BoxExtent.X + BoxExtent.Y * BoxExtent.Y + BoxExtent.Z * BoxExtent.Z);
		float orthoWidth;
		float num3 = (orthoWidth = (float)Math.Sqrt(BoxExtent2.X * BoxExtent2.X + BoxExtent2.Y * BoxExtent2.Y + BoxExtent2.Z * BoxExtent2.Z)) * 4f;
		ShadowMapCameraComp.SetOrthoWidth(orthoWidth);
		FVector fVector = ShadowMapCameraActor.GetActorForwardVector().Normal();
		FVector vector = fVector * -1.0;
		ShadowMapCameraActor.SetActorLocation(Origin + fVector * -1.0 * num3, bSweep: true, out SweepHitResult, bTeleport: true);
		ShadowMapCapture2DActor.SetActorRotation(new FRotator(-45.0, (float)shadowMaskIndex * 90f + num, 0.0), bTeleportPhysics: true);
		ShadowMapCapture2DActor.SetActorLocation(Origin + fVector * -1.0 * num3, bSweep: true, out SweepHitResult, bTeleport: true);
		ShadowMapCaptureComponent2D.OrthoWidth = orthoWidth;
		ShadowMapCaptureComponent2D.ProjectionType = ECameraProjectionMode.Orthographic;
		ShadowMapCaptureComponent2D.CaptureSource = ESceneCaptureSource.SCS_SceneDepth;
		ShadowMapCaptureComponent2D.TextureTarget = RT_CustomShadowmap;
		ShadowMapCaptureComponent2D.CaptureEveryFrame = true;
		ShadowMapCaptureComponent2D.CaptureScene();
		ShadowMapCameraComp.GetCameraView(0f, out var DesiredView);
		UGameplayStatics.GetViewProjectionMatrix(DesiredView, out var _, out var _, out var ViewProjectionMatrix);
		FMatrix fMatrix = ViewProjectionMatrix;
		fMatrix = fMatrix.GetTransposed();
		if (!ShadowMapTreeStaticMeshComp.IsNullOrDestroyed())
		{
			ShadowMapTreeStaticMeshComp.SetVisibility(bNewVisibility: true);
		}
		if (!TreeStaticMeshComp.IsNullOrDestroyed())
		{
			TreeStaticMeshComp.SetVisibility(bNewVisibility: false);
		}
		int numMaterials = TreeStaticMeshComp.GetNumMaterials();
		for (int i = 0; i < numMaterials; i++)
		{
			UMaterialInstanceConstant instance = TreeStaticMeshComp.GetMaterial(i) as UMaterialInstanceConstant;
			UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(this, CustomShadowMapMat, FName.None, EMIDCreationFlags.None);
			uMaterialInstanceDynamic.SetVectorParameterValue(new FName("LightPosWS"), new FLinearColor(ShadowMapCameraActor.GetActorLocation()));
			uMaterialInstanceDynamic.SetVectorParameterValue(new FName("LightDirWS"), new FLinearColor(vector));
			uMaterialInstanceDynamic.SetVectorParameterValue(new FName("ShadowMatrix_0"), new FLinearColor(fMatrix[0, 0], fMatrix[0, 1], fMatrix[0, 2], fMatrix[0, 3]));
			uMaterialInstanceDynamic.SetVectorParameterValue(new FName("ShadowMatrix_1"), new FLinearColor(fMatrix[1, 0], fMatrix[1, 1], fMatrix[1, 2], fMatrix[1, 3]));
			uMaterialInstanceDynamic.SetVectorParameterValue(new FName("ShadowMatrix_2"), new FLinearColor(fMatrix[2, 0], fMatrix[2, 1], fMatrix[2, 2], fMatrix[2, 3]));
			uMaterialInstanceDynamic.SetVectorParameterValue(new FName("ShadowMatrix_3"), new FLinearColor(fMatrix[3, 0], fMatrix[3, 1], fMatrix[3, 2], fMatrix[3, 3]));
			uMaterialInstanceDynamic.SetTextureParameterValue(new FName("ShadowMap"), RT_CustomShadowmap);
			UTexture materialInstanceTextureParameterValue = UMaterialEditingLibrary.GetMaterialInstanceTextureParameterValue(instance, new FName("AlphaTex"));
			UTexture materialInstanceTextureParameterValue2 = UMaterialEditingLibrary.GetMaterialInstanceTextureParameterValue(instance, new FName("NormalMap"));
			if (!materialInstanceTextureParameterValue.IsNullOrDestroyed())
			{
				uMaterialInstanceDynamic.SetTextureParameterValue(new FName("MaskTex"), materialInstanceTextureParameterValue);
			}
			if (!materialInstanceTextureParameterValue2.IsNullOrDestroyed())
			{
				uMaterialInstanceDynamic.SetTextureParameterValue(new FName("NormalTex"), materialInstanceTextureParameterValue2);
			}
			ShadowMapTreeStaticMeshComp.SetMaterial(i, uMaterialInstanceDynamic);
		}
		if (cardIndex == CardPairCount * 2)
		{
			FTransform fTransform = FTransform.Default;
			fTransform.SetRotation(new FRotator(0.0, 0.0, 0.0).Quaternion());
			fTransform.SetLocation(PosOffset[cardIndex] * new FVector(1.0, 1.0, 0.0));
			fTransform = fTransform.Inverse();
			CameraActor.SetActorTransform(fTransform, bSweep: false, out SweepHitResult, bTeleport: true);
			CameraComp.SetProjectionMode(ECameraProjectionMode.Orthographic);
			FVector fVector2 = CardSize[cardIndex];
			CameraComp.SetOrthoWidth(fVector2.X);
			CameraComp.SetAspectRatio(fVector2.X / fVector2.Z);
			FRotator newRotation = new FRotator(-90.0, 0.0, -90.0);
			FVector fVector3 = new FVector(0.0, 0.0, BoxExtent.Z * 4f);
			CameraComp.SetRelativeLocationAndRotation(fVector3 + GlobalOffset, newRotation, bSweep: false, out SweepHitResult, bTeleport: false);
		}
		else
		{
			FTransform fTransform2 = FTransform.Default;
			fTransform2.SetRotation(new FRotator(0.0, num, 0.0).Quaternion());
			fTransform2.SetLocation(PosOffset[cardIndex]);
			fTransform2 = fTransform2.Inverse();
			CameraActor.SetActorTransform(fTransform2, bSweep: false, out SweepHitResult, bTeleport: true);
			CameraComp.SetProjectionMode(ECameraProjectionMode.Orthographic);
			FVector fVector4 = CardSize[cardIndex];
			CameraComp.SetOrthoWidth(fVector4.X);
			CameraComp.SetAspectRatio(fVector4.X / fVector4.Z);
			FRotator newRotation2 = new FRotator(0.0, -90.0, 0.0);
			FVector fVector5 = new FVector(0.0, num2 * 4f, 0.0);
			CameraComp.SetRelativeLocationAndRotation(fVector5 + GlobalOffset, newRotation2, bSweep: false, out SweepHitResult, bTeleport: false);
		}
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoSetLOD")]
	private static void DoSetLOD__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.DoSetLOD();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShowCompare")]
	private static void ShowCompare__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.ShowCompare();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetCurrentTask")]
	private static void SetCurrentTask__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		int currentTask = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, SetCurrentTask_TaskIndex_Offset));
		bool value = dispLib_EditorTreeImposterTool.SetCurrentTask(currentTask);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, SetCurrentTask_ReturnValue_Offset), 0, SetCurrentTask_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:FillHoudiniData")]
	private static void FillHoudiniData__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		bool value = dispLib_EditorTreeImposterTool.FillHoudiniData();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, FillHoudiniData_ReturnValue_Offset), 0, FillHoudiniData_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ToggleDebugPause")]
	private static void ToggleDebugPause__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.ToggleDebugPause();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:LogForwardVector")]
	private static void LogForwardVector__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.LogForwardVector();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CreateHDAInstance")]
	private static void CreateHDAInstance__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.CreateHDAInstance();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CheckHDABakeResult")]
	private static void CheckHDABakeResult__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		bool value = dispLib_EditorTreeImposterTool.CheckHDABakeResult();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckHDABakeResult_ReturnValue_Offset), 0, CheckHDABakeResult_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CleanAllToolAssets")]
	private static void CleanAllToolAssets__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.CleanAllToolAssets();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:AutoImportSceneShot")]
	private static void AutoImportSceneShot__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.AutoImportSceneShot();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:AutoDelectSceneShot")]
	private static void AutoDelectSceneShot__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.AutoDelectSceneShot();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetNewLevelEnvActor")]
	private static void SetNewLevelEnvActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		bool newLevelEnvActor = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetNewLevelEnvActor_Visable_Offset), 0, SetNewLevelEnvActor_Visable_PropertyAddress.Address);
		dispLib_EditorTreeImposterTool.SetNewLevelEnvActor(newLevelEnvActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RemoveAllInvalidTask")]
	private static void RemoveAllInvalidTask__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.RemoveAllInvalidTask();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CheckTaskMeshValidity")]
	private static void CheckTaskMeshValidity__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		bool value = dispLib_EditorTreeImposterTool.CheckTaskMeshValidity();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckTaskMeshValidity_ReturnValue_Offset), 0, CheckTaskMeshValidity_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetAllTaskBakeZeroLOD")]
	private static void SetAllTaskBakeZeroLOD__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.SetAllTaskBakeZeroLOD();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoCombinedFinalTexture")]
	private static void DoCombinedFinalTexture__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		bool value = dispLib_EditorTreeImposterTool.DoCombinedFinalTexture();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, DoCombinedFinalTexture_ReturnValue_Offset), 0, DoCombinedFinalTexture_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoSaveImposterCardMesh")]
	private static void DoSaveImposterCardMesh__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.DoSaveImposterCardMesh();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CreatSceneShotToolActor")]
	private static void CreatSceneShotToolActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		bool value = dispLib_EditorTreeImposterTool.CreatSceneShotToolActor();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CreatSceneShotToolActor_ReturnValue_Offset), 0, CreatSceneShotToolActor_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoCreateTreeImposterTask")]
	private static void DoCreateTreeImposterTask__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.DoCreateTreeImposterTask();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ReleaseGeneratedTextures")]
	private static void ReleaseGeneratedTextures__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.ReleaseGeneratedTextures();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoCleanTempMemoryResource")]
	private static void DoCleanTempMemoryResource__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.DoCleanTempMemoryResource();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetTaskListFromFolderPath")]
	private static void SetTaskListFromFolderPath__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.SetTaskListFromFolderPath();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RemoveAllHasGSImposterTask")]
	private static void RemoveAllHasGSImposterTask__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.RemoveAllHasGSImposterTask();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CreatFinalImposterMaterial")]
	private static void CreatFinalImposterMaterial__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		bool forceOverrideMat = BoolMarshaler.FromNative(IntPtr.Add(buffer, CreatFinalImposterMaterial_ForceOverrideMat_Offset), 0, CreatFinalImposterMaterial_ForceOverrideMat_PropertyAddress.Address);
		dispLib_EditorTreeImposterTool.CreatFinalImposterMaterial(forceOverrideMat);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TestRenderCustomShadowMask")]
	private static void TestRenderCustomShadowMask__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		int cardIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, TestRenderCustomShadowMask_cardIndex_Offset));
		int shadowMaskIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, TestRenderCustomShadowMask_shadowMaskIndex_Offset));
		dispLib_EditorTreeImposterTool.TestRenderCustomShadowMask(cardIndex, shadowMaskIndex);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		dispLib_EditorTreeImposterTool.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoPBRTextureRenderBySceneShot")]
	private static void DoPBRTextureRenderBySceneShot__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.DoPBRTextureRenderBySceneShot();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PythonCreatePerformanceTexture")]
	private static void PythonCreatePerformanceTexture__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		string captureRTSize = FStringMarshaler.FromNative(IntPtr.Add(buffer, PythonCreatePerformanceTexture_CaptureRTSize_Offset));
		string performanceMatInstanceAssetPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, PythonCreatePerformanceTexture_PerformanceMatInstanceAssetPath_Offset));
		string imposterCombinedStdTextureFolderPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, PythonCreatePerformanceTexture_ImposterCombinedStdTextureFolderPath_Offset));
		string imposterDataTextureFolderPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, PythonCreatePerformanceTexture_ImposterDataTextureFolderPath_Offset));
		string trunkMaskThreshold = FStringMarshaler.FromNative(IntPtr.Add(buffer, PythonCreatePerformanceTexture_TrunkMaskThreshold_Offset));
		string leafMaskThreshold = FStringMarshaler.FromNative(IntPtr.Add(buffer, PythonCreatePerformanceTexture_LeafMaskThreshold_Offset));
		dispLib_EditorTreeImposterTool.PythonCreatePerformanceTexture(captureRTSize, performanceMatInstanceAssetPath, imposterCombinedStdTextureFolderPath, imposterDataTextureFolderPath, trunkMaskThreshold, leafMaskThreshold);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoShadowMaskTextureRenderBySceneShot")]
	private static void DoShadowMaskTextureRenderBySceneShot__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorTreeImposterTool dispLib_EditorTreeImposterTool = GCHelper.Find<DispLib_EditorTreeImposterTool>(obj);
		dispLib_EditorTreeImposterTool.DoShadowMaskTextureRenderBySceneShot();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_EditorTreeImposterTool");
		TempFileSaveRootFolderUnrealPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "TempFileSaveRootFolderUnrealPath");
		TempFileSaveRootFolderUnrealPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TempFileSaveRootFolderUnrealPath", Classes.FStrProperty);
		TempAutogenRootFolderDiskPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "TempAutogenRootFolderDiskPath");
		TempAutogenRootFolderDiskPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TempAutogenRootFolderDiskPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ManualSaveAssets_PropertyAddress, intPtr, "ManualSaveAssets");
		ManualSaveAssets_Offset = NativeReflection.GetPropertyOffset(intPtr, "ManualSaveAssets");
		ManualSaveAssets_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ManualSaveAssets", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseCustomSavePath_PropertyAddress, intPtr, "UseCustomSavePath");
		UseCustomSavePath_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseCustomSavePath");
		UseCustomSavePath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseCustomSavePath", Classes.FBoolProperty);
		PerformanceMatInstanceSaveAt_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerformanceMatInstanceSaveAt");
		PerformanceMatInstanceSaveAt_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerformanceMatInstanceSaveAt", Classes.FStrProperty);
		PerformanceMatDataTextureSaveAt_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerformanceMatDataTextureSaveAt");
		PerformanceMatDataTextureSaveAt_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerformanceMatDataTextureSaveAt", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref TaskFromFolder_PropertyAddress, intPtr, "TaskFromFolder");
		TaskFromFolder_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskFromFolder");
		TaskFromFolder_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskFromFolder", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TaskList_PropertyAddress, intPtr, "TaskList");
		TaskList_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskList");
		TaskList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskList", Classes.FArrayProperty);
		DefaultCardMicoScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultCardMicoScale");
		DefaultCardMicoScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultCardMicoScale", Classes.FFloatProperty);
		DefaultCardPairCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultCardPairCount");
		DefaultCardPairCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultCardPairCount", Classes.FIntProperty);
		DefaultCaptureRTSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultCaptureRTSize");
		DefaultCaptureRTSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultCaptureRTSize", Classes.FIntProperty);
		DefaultShotTextureSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultShotTextureSize");
		DefaultShotTextureSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultShotTextureSize", Classes.FIntProperty);
		DefaultTrunkMaskThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultTrunkMaskThreshold");
		DefaultTrunkMaskThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultTrunkMaskThreshold", Classes.FFloatProperty);
		DefaultLeafMaskThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultLeafMaskThreshold");
		DefaultLeafMaskThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultLeafMaskThreshold", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DebugPause_PropertyAddress, intPtr, "DebugPause");
		DebugPause_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugPause");
		DebugPause_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugPause", Classes.FBoolProperty);
		CurTaskIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurTaskIndex");
		CurTaskIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurTaskIndex", Classes.FIntProperty);
		TreeMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "TreeMesh");
		TreeMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TreeMesh", Classes.FObjectProperty);
		BakeLOD_Offset = NativeReflection.GetPropertyOffset(intPtr, "BakeLOD");
		BakeLOD_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BakeLOD", Classes.FIntProperty);
		CardPairCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "CardPairCount");
		CardPairCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CardPairCount", Classes.FIntProperty);
		CardMicoScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "CardMicoScale");
		CardMicoScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CardMicoScale", Classes.FFloatProperty);
		CaptureRTSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "CaptureRTSize");
		CaptureRTSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CaptureRTSize", Classes.FIntProperty);
		ShotTextureSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShotTextureSize");
		ShotTextureSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShotTextureSize", Classes.FIntProperty);
		TrunkMaskThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "TrunkMaskThreshold");
		TrunkMaskThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TrunkMaskThreshold", Classes.FFloatProperty);
		LeafMaskThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeafMaskThreshold");
		LeafMaskThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeafMaskThreshold", Classes.FFloatProperty);
		ImposterCardMeshAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImposterCardMeshAsset");
		ImposterCardMeshAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImposterCardMeshAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CardSize_PropertyAddress, intPtr, "CardSize");
		CardSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "CardSize");
		CardSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CardSize", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PosOffset_PropertyAddress, intPtr, "PosOffset");
		PosOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "PosOffset");
		PosOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PosOffset", Classes.FArrayProperty);
		LastMeshName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LastMeshName");
		LastMeshName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LastMeshName", Classes.FNameProperty);
		GlobalOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "GlobalOffset");
		GlobalOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GlobalOffset", Classes.FStructProperty);
		ShadowMapCountEveryCard_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadowMapCountEveryCard");
		ShadowMapCountEveryCard_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadowMapCountEveryCard", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ForceResetExitstedMat_PropertyAddress, intPtr, "ForceResetExitstedMat");
		ForceResetExitstedMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceResetExitstedMat");
		ForceResetExitstedMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceResetExitstedMat", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PerformanceMaterialUseOneTextureMode_PropertyAddress, intPtr, "PerformanceMaterialUseOneTextureMode");
		PerformanceMaterialUseOneTextureMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerformanceMaterialUseOneTextureMode");
		PerformanceMaterialUseOneTextureMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerformanceMaterialUseOneTextureMode", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AutoSetImposterMeshToTreeLOD_PropertyAddress, intPtr, "AutoSetImposterMeshToTreeLOD");
		AutoSetImposterMeshToTreeLOD_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoSetImposterMeshToTreeLOD");
		AutoSetImposterMeshToTreeLOD_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoSetImposterMeshToTreeLOD", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SaveImposterCardMesh_PropertyAddress, intPtr, "SaveImposterCardMesh");
		SaveImposterCardMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "SaveImposterCardMesh");
		SaveImposterCardMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SaveImposterCardMesh", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OverrideMPCParam_PropertyAddress, intPtr, "OverrideMPCParam");
		OverrideMPCParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideMPCParam");
		OverrideMPCParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideMPCParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverrideTreeMeshMatScalarParam_PropertyAddress, intPtr, "OverrideTreeMeshMatScalarParam");
		OverrideTreeMeshMatScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideTreeMeshMatScalarParam");
		OverrideTreeMeshMatScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideTreeMeshMatScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverrideTreeMeshMatLinearColorParam_PropertyAddress, intPtr, "OverrideTreeMeshMatLinearColorParam");
		OverrideTreeMeshMatLinearColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideTreeMeshMatLinearColorParam");
		OverrideTreeMeshMatLinearColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideTreeMeshMatLinearColorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverrideShotTexSetting_PropertyAddress, intPtr, "OverrideShotTexSetting");
		OverrideShotTexSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideShotTexSetting");
		OverrideShotTexSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideShotTexSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverrideFinalTexSetting_PropertyAddress, intPtr, "OverrideFinalTexSetting");
		OverrideFinalTexSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideFinalTexSetting");
		OverrideFinalTexSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideFinalTexSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CopyScalarParamsFromHQToImposterMat_PropertyAddress, intPtr, "CopyScalarParamsFromHQToImposterMat");
		CopyScalarParamsFromHQToImposterMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "CopyScalarParamsFromHQToImposterMat");
		CopyScalarParamsFromHQToImposterMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CopyScalarParamsFromHQToImposterMat", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CopySwitchParamsFromHQToImposterMat_PropertyAddress, intPtr, "CopySwitchParamsFromHQToImposterMat");
		CopySwitchParamsFromHQToImposterMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "CopySwitchParamsFromHQToImposterMat");
		CopySwitchParamsFromHQToImposterMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CopySwitchParamsFromHQToImposterMat", Classes.FArrayProperty);
		HDA_Asset_Offset = NativeReflection.GetPropertyOffset(intPtr, "HDA_Asset");
		HDA_Asset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HDA_Asset", Classes.FObjectProperty);
		ToggleViewModeWaittngTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "ToggleViewModeWaittngTime");
		ToggleViewModeWaittngTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ToggleViewModeWaittngTime", Classes.FFloatProperty);
		RT_CustomShadowmap_Offset = NativeReflection.GetPropertyOffset(intPtr, "RT_CustomShadowmap");
		RT_CustomShadowmap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RT_CustomShadowmap", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DebugColorArray_PropertyAddress, intPtr, "DebugColorArray");
		DebugColorArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugColorArray");
		DebugColorArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugColorArray", Classes.FArrayProperty);
		SkySphereToolMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkySphereToolMat");
		SkySphereToolMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkySphereToolMat", Classes.FObjectProperty);
		MergeActorToolMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "MergeActorToolMat");
		MergeActorToolMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MergeActorToolMat", Classes.FObjectProperty);
		ColorDilateToolMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "ColorDilateToolMat");
		ColorDilateToolMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ColorDilateToolMat", Classes.FObjectProperty);
		CustomShadowMapMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomShadowMapMat");
		CustomShadowMapMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomShadowMapMat", Classes.FObjectProperty);
		DistanceFieldToolMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceFieldToolMat");
		DistanceFieldToolMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceFieldToolMat", Classes.FObjectProperty);
		CombineRGBAndAlphaToolMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "CombineRGBAndAlphaToolMat");
		CombineRGBAndAlphaToolMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CombineRGBAndAlphaToolMat", Classes.FObjectProperty);
		OriginImposterMatIns_Offset = NativeReflection.GetPropertyOffset(intPtr, "OriginImposterMatIns");
		OriginImposterMatIns_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OriginImposterMatIns", Classes.FObjectProperty);
		OriginOneTexPerformanceImposterMatIns_Offset = NativeReflection.GetPropertyOffset(intPtr, "OriginOneTexPerformanceImposterMatIns");
		OriginOneTexPerformanceImposterMatIns_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OriginOneTexPerformanceImposterMatIns", Classes.FObjectProperty);
		OriginMultiTexPerformanceImposterMatIns_Offset = NativeReflection.GetPropertyOffset(intPtr, "OriginMultiTexPerformanceImposterMatIns");
		OriginMultiTexPerformanceImposterMatIns_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OriginMultiTexPerformanceImposterMatIns", Classes.FObjectProperty);
		TreeActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TreeActor");
		TreeActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TreeActor", Classes.FObjectProperty);
		TreeStaticMeshComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "TreeStaticMeshComp");
		TreeStaticMeshComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TreeStaticMeshComp", Classes.FObjectProperty);
		CopyFromHQMatIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "CopyFromHQMatIndex");
		CopyFromHQMatIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CopyFromHQMatIndex", Classes.FIntProperty);
		ShadowMapTreeActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadowMapTreeActor");
		ShadowMapTreeActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadowMapTreeActor", Classes.FObjectProperty);
		ShadowMapTreeStaticMeshComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadowMapTreeStaticMeshComp");
		ShadowMapTreeStaticMeshComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadowMapTreeStaticMeshComp", Classes.FObjectProperty);
		Capture2DActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Capture2DActor");
		Capture2DActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Capture2DActor", Classes.FObjectProperty);
		CaptureComponent2D_Offset = NativeReflection.GetPropertyOffset(intPtr, "CaptureComponent2D");
		CaptureComponent2D_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CaptureComponent2D", Classes.FObjectProperty);
		CameraActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraActor");
		CameraActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraActor", Classes.FObjectProperty);
		CameraComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraComp");
		CameraComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraComp", Classes.FObjectProperty);
		ShadowMapCameraActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadowMapCameraActor");
		ShadowMapCameraActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadowMapCameraActor", Classes.FObjectProperty);
		ShadowMapCameraComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadowMapCameraComp");
		ShadowMapCameraComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadowMapCameraComp", Classes.FObjectProperty);
		ShadowMapCapture2DActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadowMapCapture2DActor");
		ShadowMapCapture2DActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadowMapCapture2DActor", Classes.FObjectProperty);
		ShadowMapCaptureComponent2D_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadowMapCaptureComponent2D");
		ShadowMapCaptureComponent2D_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadowMapCaptureComponent2D", Classes.FObjectProperty);
		RT_4Capture_RGB_Offset = NativeReflection.GetPropertyOffset(intPtr, "RT_4Capture_RGB");
		RT_4Capture_RGB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RT_4Capture_RGB", Classes.FObjectProperty);
		RT_4Capture_NearestFillterRGB_Offset = NativeReflection.GetPropertyOffset(intPtr, "RT_4Capture_NearestFillterRGB");
		RT_4Capture_NearestFillterRGB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RT_4Capture_NearestFillterRGB", Classes.FObjectProperty);
		RT_4Capture_Alpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "RT_4Capture_Alpha");
		RT_4Capture_Alpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RT_4Capture_Alpha", Classes.FObjectProperty);
		RT_4Capture_FinalTex_Offset = NativeReflection.GetPropertyOffset(intPtr, "RT_4Capture_FinalTex");
		RT_4Capture_FinalTex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RT_4Capture_FinalTex", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref isShadowMaskSceneShot_PropertyAddress, intPtr, "isShadowMaskSceneShot");
		isShadowMaskSceneShot_Offset = NativeReflection.GetPropertyOffset(intPtr, "isShadowMaskSceneShot");
		isShadowMaskSceneShot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "isShadowMaskSceneShot", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref isPBRSceneShot_PropertyAddress, intPtr, "isPBRSceneShot");
		isPBRSceneShot_Offset = NativeReflection.GetPropertyOffset(intPtr, "isPBRSceneShot");
		isPBRSceneShot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "isPBRSceneShot", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref isCreateTreeImposter_PropertyAddress, intPtr, "isCreateTreeImposter");
		isCreateTreeImposter_Offset = NativeReflection.GetPropertyOffset(intPtr, "isCreateTreeImposter");
		isCreateTreeImposter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "isCreateTreeImposter", Classes.FBoolProperty);
		ImposterMatInsAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImposterMatInsAsset");
		ImposterMatInsAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImposterMatInsAsset", Classes.FObjectProperty);
		ImposterMatPerformanceModeInsAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImposterMatPerformanceModeInsAsset");
		ImposterMatPerformanceModeInsAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImposterMatPerformanceModeInsAsset", Classes.FObjectProperty);
		DoSetLOD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoSetLOD");
		DoSetLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(DoSetLOD_FunctionAddress);
		DoSetLOD_IsValid = DoSetLOD_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoSetLOD", DoSetLOD_IsValid);
		ShowCompare_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShowCompare");
		ShowCompare_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowCompare_FunctionAddress);
		ShowCompare_IsValid = ShowCompare_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ShowCompare", ShowCompare_IsValid);
		SetCurrentTask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCurrentTask");
		SetCurrentTask_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentTask_FunctionAddress);
		SetCurrentTask_TaskIndex_Offset = NativeReflection.GetPropertyOffset(SetCurrentTask_FunctionAddress, "TaskIndex");
		SetCurrentTask_TaskIndex_IsValid = NativeReflection.ValidatePropertyClass(SetCurrentTask_FunctionAddress, "TaskIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SetCurrentTask_ReturnValue_PropertyAddress, SetCurrentTask_FunctionAddress, "ReturnValue");
		SetCurrentTask_ReturnValue_Offset = NativeReflection.GetPropertyOffset(SetCurrentTask_FunctionAddress, "ReturnValue");
		SetCurrentTask_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(SetCurrentTask_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurrentTask_IsValid = SetCurrentTask_FunctionAddress != IntPtr.Zero && SetCurrentTask_TaskIndex_IsValid && SetCurrentTask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetCurrentTask", SetCurrentTask_IsValid);
		FillHoudiniData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FillHoudiniData");
		FillHoudiniData_ParamsSize = NativeReflection.GetFunctionParamsSize(FillHoudiniData_FunctionAddress);
		NativeReflection.GetPropertyRef(ref FillHoudiniData_ReturnValue_PropertyAddress, FillHoudiniData_FunctionAddress, "ReturnValue");
		FillHoudiniData_ReturnValue_Offset = NativeReflection.GetPropertyOffset(FillHoudiniData_FunctionAddress, "ReturnValue");
		FillHoudiniData_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(FillHoudiniData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FillHoudiniData_IsValid = FillHoudiniData_FunctionAddress != IntPtr.Zero && FillHoudiniData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:FillHoudiniData", FillHoudiniData_IsValid);
		ToggleDebugPause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToggleDebugPause");
		ToggleDebugPause_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleDebugPause_FunctionAddress);
		ToggleDebugPause_IsValid = ToggleDebugPause_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ToggleDebugPause", ToggleDebugPause_IsValid);
		LogForwardVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LogForwardVector");
		LogForwardVector_ParamsSize = NativeReflection.GetFunctionParamsSize(LogForwardVector_FunctionAddress);
		LogForwardVector_IsValid = LogForwardVector_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:LogForwardVector", LogForwardVector_IsValid);
		CreateHDAInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateHDAInstance");
		CreateHDAInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateHDAInstance_FunctionAddress);
		CreateHDAInstance_IsValid = CreateHDAInstance_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CreateHDAInstance", CreateHDAInstance_IsValid);
		CheckHDABakeResult_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckHDABakeResult");
		CheckHDABakeResult_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckHDABakeResult_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckHDABakeResult_ReturnValue_PropertyAddress, CheckHDABakeResult_FunctionAddress, "ReturnValue");
		CheckHDABakeResult_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckHDABakeResult_FunctionAddress, "ReturnValue");
		CheckHDABakeResult_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckHDABakeResult_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckHDABakeResult_IsValid = CheckHDABakeResult_FunctionAddress != IntPtr.Zero && CheckHDABakeResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CheckHDABakeResult", CheckHDABakeResult_IsValid);
		CleanAllToolAssets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CleanAllToolAssets");
		CleanAllToolAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanAllToolAssets_FunctionAddress);
		CleanAllToolAssets_IsValid = CleanAllToolAssets_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CleanAllToolAssets", CleanAllToolAssets_IsValid);
		AutoImportSceneShot_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AutoImportSceneShot");
		AutoImportSceneShot_ParamsSize = NativeReflection.GetFunctionParamsSize(AutoImportSceneShot_FunctionAddress);
		AutoImportSceneShot_IsValid = AutoImportSceneShot_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:AutoImportSceneShot", AutoImportSceneShot_IsValid);
		AutoDelectSceneShot_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AutoDelectSceneShot");
		AutoDelectSceneShot_ParamsSize = NativeReflection.GetFunctionParamsSize(AutoDelectSceneShot_FunctionAddress);
		AutoDelectSceneShot_IsValid = AutoDelectSceneShot_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:AutoDelectSceneShot", AutoDelectSceneShot_IsValid);
		SetNewLevelEnvActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNewLevelEnvActor");
		SetNewLevelEnvActor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNewLevelEnvActor_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetNewLevelEnvActor_Visable_PropertyAddress, SetNewLevelEnvActor_FunctionAddress, "Visable");
		SetNewLevelEnvActor_Visable_Offset = NativeReflection.GetPropertyOffset(SetNewLevelEnvActor_FunctionAddress, "Visable");
		SetNewLevelEnvActor_Visable_IsValid = NativeReflection.ValidatePropertyClass(SetNewLevelEnvActor_FunctionAddress, "Visable", Classes.FBoolProperty);
		SetNewLevelEnvActor_IsValid = SetNewLevelEnvActor_FunctionAddress != IntPtr.Zero && SetNewLevelEnvActor_Visable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetNewLevelEnvActor", SetNewLevelEnvActor_IsValid);
		RemoveAllInvalidTask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveAllInvalidTask");
		RemoveAllInvalidTask_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllInvalidTask_FunctionAddress);
		RemoveAllInvalidTask_IsValid = RemoveAllInvalidTask_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RemoveAllInvalidTask", RemoveAllInvalidTask_IsValid);
		CheckTaskMeshValidity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckTaskMeshValidity");
		CheckTaskMeshValidity_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckTaskMeshValidity_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckTaskMeshValidity_ReturnValue_PropertyAddress, CheckTaskMeshValidity_FunctionAddress, "ReturnValue");
		CheckTaskMeshValidity_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckTaskMeshValidity_FunctionAddress, "ReturnValue");
		CheckTaskMeshValidity_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckTaskMeshValidity_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckTaskMeshValidity_IsValid = CheckTaskMeshValidity_FunctionAddress != IntPtr.Zero && CheckTaskMeshValidity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CheckTaskMeshValidity", CheckTaskMeshValidity_IsValid);
		SetAllTaskBakeZeroLOD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllTaskBakeZeroLOD");
		SetAllTaskBakeZeroLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllTaskBakeZeroLOD_FunctionAddress);
		SetAllTaskBakeZeroLOD_IsValid = SetAllTaskBakeZeroLOD_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetAllTaskBakeZeroLOD", SetAllTaskBakeZeroLOD_IsValid);
		DoCombinedFinalTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoCombinedFinalTexture");
		DoCombinedFinalTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(DoCombinedFinalTexture_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoCombinedFinalTexture_ReturnValue_PropertyAddress, DoCombinedFinalTexture_FunctionAddress, "ReturnValue");
		DoCombinedFinalTexture_ReturnValue_Offset = NativeReflection.GetPropertyOffset(DoCombinedFinalTexture_FunctionAddress, "ReturnValue");
		DoCombinedFinalTexture_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(DoCombinedFinalTexture_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoCombinedFinalTexture_IsValid = DoCombinedFinalTexture_FunctionAddress != IntPtr.Zero && DoCombinedFinalTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoCombinedFinalTexture", DoCombinedFinalTexture_IsValid);
		DoSaveImposterCardMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoSaveImposterCardMesh");
		DoSaveImposterCardMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(DoSaveImposterCardMesh_FunctionAddress);
		DoSaveImposterCardMesh_IsValid = DoSaveImposterCardMesh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoSaveImposterCardMesh", DoSaveImposterCardMesh_IsValid);
		CreatSceneShotToolActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreatSceneShotToolActor");
		CreatSceneShotToolActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatSceneShotToolActor_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CreatSceneShotToolActor_ReturnValue_PropertyAddress, CreatSceneShotToolActor_FunctionAddress, "ReturnValue");
		CreatSceneShotToolActor_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CreatSceneShotToolActor_FunctionAddress, "ReturnValue");
		CreatSceneShotToolActor_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CreatSceneShotToolActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CreatSceneShotToolActor_IsValid = CreatSceneShotToolActor_FunctionAddress != IntPtr.Zero && CreatSceneShotToolActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CreatSceneShotToolActor", CreatSceneShotToolActor_IsValid);
		DoCreateTreeImposterTask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoCreateTreeImposterTask");
		DoCreateTreeImposterTask_ParamsSize = NativeReflection.GetFunctionParamsSize(DoCreateTreeImposterTask_FunctionAddress);
		DoCreateTreeImposterTask_IsValid = DoCreateTreeImposterTask_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoCreateTreeImposterTask", DoCreateTreeImposterTask_IsValid);
		ReleaseGeneratedTextures_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReleaseGeneratedTextures");
		ReleaseGeneratedTextures_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseGeneratedTextures_FunctionAddress);
		ReleaseGeneratedTextures_IsValid = ReleaseGeneratedTextures_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ReleaseGeneratedTextures", ReleaseGeneratedTextures_IsValid);
		DoCleanTempMemoryResource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoCleanTempMemoryResource");
		DoCleanTempMemoryResource_ParamsSize = NativeReflection.GetFunctionParamsSize(DoCleanTempMemoryResource_FunctionAddress);
		DoCleanTempMemoryResource_IsValid = DoCleanTempMemoryResource_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoCleanTempMemoryResource", DoCleanTempMemoryResource_IsValid);
		SetTaskListFromFolderPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTaskListFromFolderPath");
		SetTaskListFromFolderPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTaskListFromFolderPath_FunctionAddress);
		SetTaskListFromFolderPath_IsValid = SetTaskListFromFolderPath_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:SetTaskListFromFolderPath", SetTaskListFromFolderPath_IsValid);
		RemoveAllHasGSImposterTask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveAllHasGSImposterTask");
		RemoveAllHasGSImposterTask_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllHasGSImposterTask_FunctionAddress);
		RemoveAllHasGSImposterTask_IsValid = RemoveAllHasGSImposterTask_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:RemoveAllHasGSImposterTask", RemoveAllHasGSImposterTask_IsValid);
		CreatFinalImposterMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreatFinalImposterMaterial");
		CreatFinalImposterMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatFinalImposterMaterial_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CreatFinalImposterMaterial_ForceOverrideMat_PropertyAddress, CreatFinalImposterMaterial_FunctionAddress, "ForceOverrideMat");
		CreatFinalImposterMaterial_ForceOverrideMat_Offset = NativeReflection.GetPropertyOffset(CreatFinalImposterMaterial_FunctionAddress, "ForceOverrideMat");
		CreatFinalImposterMaterial_ForceOverrideMat_IsValid = NativeReflection.ValidatePropertyClass(CreatFinalImposterMaterial_FunctionAddress, "ForceOverrideMat", Classes.FBoolProperty);
		CreatFinalImposterMaterial_IsValid = CreatFinalImposterMaterial_FunctionAddress != IntPtr.Zero && CreatFinalImposterMaterial_ForceOverrideMat_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:CreatFinalImposterMaterial", CreatFinalImposterMaterial_IsValid);
		TestRenderCustomShadowMask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TestRenderCustomShadowMask");
		TestRenderCustomShadowMask_ParamsSize = NativeReflection.GetFunctionParamsSize(TestRenderCustomShadowMask_FunctionAddress);
		TestRenderCustomShadowMask_cardIndex_Offset = NativeReflection.GetPropertyOffset(TestRenderCustomShadowMask_FunctionAddress, "cardIndex");
		TestRenderCustomShadowMask_cardIndex_IsValid = NativeReflection.ValidatePropertyClass(TestRenderCustomShadowMask_FunctionAddress, "cardIndex", Classes.FIntProperty);
		TestRenderCustomShadowMask_shadowMaskIndex_Offset = NativeReflection.GetPropertyOffset(TestRenderCustomShadowMask_FunctionAddress, "shadowMaskIndex");
		TestRenderCustomShadowMask_shadowMaskIndex_IsValid = NativeReflection.ValidatePropertyClass(TestRenderCustomShadowMask_FunctionAddress, "shadowMaskIndex", Classes.FIntProperty);
		TestRenderCustomShadowMask_IsValid = TestRenderCustomShadowMask_FunctionAddress != IntPtr.Zero && TestRenderCustomShadowMask_cardIndex_IsValid && TestRenderCustomShadowMask_shadowMaskIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:TestRenderCustomShadowMask", TestRenderCustomShadowMask_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:ReceiveTick", ReceiveTick_IsValid);
		DoPBRTextureRenderBySceneShot_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoPBRTextureRenderBySceneShot");
		DoPBRTextureRenderBySceneShot_ParamsSize = NativeReflection.GetFunctionParamsSize(DoPBRTextureRenderBySceneShot_FunctionAddress);
		DoPBRTextureRenderBySceneShot_IsValid = DoPBRTextureRenderBySceneShot_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoPBRTextureRenderBySceneShot", DoPBRTextureRenderBySceneShot_IsValid);
		PythonCreatePerformanceTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PythonCreatePerformanceTexture");
		PythonCreatePerformanceTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(PythonCreatePerformanceTexture_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PythonCreatePerformanceTexture_CaptureRTSize_PropertyAddress, PythonCreatePerformanceTexture_FunctionAddress, "CaptureRTSize");
		PythonCreatePerformanceTexture_CaptureRTSize_Offset = NativeReflection.GetPropertyOffset(PythonCreatePerformanceTexture_FunctionAddress, "CaptureRTSize");
		PythonCreatePerformanceTexture_CaptureRTSize_IsValid = NativeReflection.ValidatePropertyClass(PythonCreatePerformanceTexture_FunctionAddress, "CaptureRTSize", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PythonCreatePerformanceTexture_PerformanceMatInstanceAssetPath_PropertyAddress, PythonCreatePerformanceTexture_FunctionAddress, "PerformanceMatInstanceAssetPath");
		PythonCreatePerformanceTexture_PerformanceMatInstanceAssetPath_Offset = NativeReflection.GetPropertyOffset(PythonCreatePerformanceTexture_FunctionAddress, "PerformanceMatInstanceAssetPath");
		PythonCreatePerformanceTexture_PerformanceMatInstanceAssetPath_IsValid = NativeReflection.ValidatePropertyClass(PythonCreatePerformanceTexture_FunctionAddress, "PerformanceMatInstanceAssetPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PythonCreatePerformanceTexture_ImposterCombinedStdTextureFolderPath_PropertyAddress, PythonCreatePerformanceTexture_FunctionAddress, "ImposterCombinedStdTextureFolderPath");
		PythonCreatePerformanceTexture_ImposterCombinedStdTextureFolderPath_Offset = NativeReflection.GetPropertyOffset(PythonCreatePerformanceTexture_FunctionAddress, "ImposterCombinedStdTextureFolderPath");
		PythonCreatePerformanceTexture_ImposterCombinedStdTextureFolderPath_IsValid = NativeReflection.ValidatePropertyClass(PythonCreatePerformanceTexture_FunctionAddress, "ImposterCombinedStdTextureFolderPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PythonCreatePerformanceTexture_ImposterDataTextureFolderPath_PropertyAddress, PythonCreatePerformanceTexture_FunctionAddress, "ImposterDataTextureFolderPath");
		PythonCreatePerformanceTexture_ImposterDataTextureFolderPath_Offset = NativeReflection.GetPropertyOffset(PythonCreatePerformanceTexture_FunctionAddress, "ImposterDataTextureFolderPath");
		PythonCreatePerformanceTexture_ImposterDataTextureFolderPath_IsValid = NativeReflection.ValidatePropertyClass(PythonCreatePerformanceTexture_FunctionAddress, "ImposterDataTextureFolderPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PythonCreatePerformanceTexture_TrunkMaskThreshold_PropertyAddress, PythonCreatePerformanceTexture_FunctionAddress, "TrunkMaskThreshold");
		PythonCreatePerformanceTexture_TrunkMaskThreshold_Offset = NativeReflection.GetPropertyOffset(PythonCreatePerformanceTexture_FunctionAddress, "TrunkMaskThreshold");
		PythonCreatePerformanceTexture_TrunkMaskThreshold_IsValid = NativeReflection.ValidatePropertyClass(PythonCreatePerformanceTexture_FunctionAddress, "TrunkMaskThreshold", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PythonCreatePerformanceTexture_LeafMaskThreshold_PropertyAddress, PythonCreatePerformanceTexture_FunctionAddress, "LeafMaskThreshold");
		PythonCreatePerformanceTexture_LeafMaskThreshold_Offset = NativeReflection.GetPropertyOffset(PythonCreatePerformanceTexture_FunctionAddress, "LeafMaskThreshold");
		PythonCreatePerformanceTexture_LeafMaskThreshold_IsValid = NativeReflection.ValidatePropertyClass(PythonCreatePerformanceTexture_FunctionAddress, "LeafMaskThreshold", Classes.FStrProperty);
		PythonCreatePerformanceTexture_IsValid = PythonCreatePerformanceTexture_FunctionAddress != IntPtr.Zero && PythonCreatePerformanceTexture_CaptureRTSize_IsValid && PythonCreatePerformanceTexture_PerformanceMatInstanceAssetPath_IsValid && PythonCreatePerformanceTexture_ImposterCombinedStdTextureFolderPath_IsValid && PythonCreatePerformanceTexture_ImposterDataTextureFolderPath_IsValid && PythonCreatePerformanceTexture_TrunkMaskThreshold_IsValid && PythonCreatePerformanceTexture_LeafMaskThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:PythonCreatePerformanceTexture", PythonCreatePerformanceTexture_IsValid);
		DoShadowMaskTextureRenderBySceneShot_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoShadowMaskTextureRenderBySceneShot");
		DoShadowMaskTextureRenderBySceneShot_ParamsSize = NativeReflection.GetFunctionParamsSize(DoShadowMaskTextureRenderBySceneShot_FunctionAddress);
		DoShadowMaskTextureRenderBySceneShot_IsValid = DoShadowMaskTextureRenderBySceneShot_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorTreeImposterTool:DoShadowMaskTextureRenderBySceneShot", DoShadowMaskTextureRenderBySceneShot_IsValid);
	}

	static DispLib_EditorTreeImposterTool()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_EditorTreeImposterTool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_EditorTreeImposterTool));
	}
}
