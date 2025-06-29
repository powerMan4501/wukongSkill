using System;
using System.Collections.Generic;
using System.Globalization;
using b1.BGW;
using b1.GSMUI.GSWidget;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged")]
public class BGUFunctionLibraryManaged : UBlueprintFunctionLibrary
{
	private static bool RunScriptGM_IsValid;

	private static IntPtr RunScriptGM_FunctionAddress;

	private static int RunScriptGM_ParamsSize;

	private static bool RunScriptGM_GMCommand_IsValid;

	private static int RunScriptGM_GMCommand_Offset;

	private static FFieldAddress RunScriptGM_GMCommand_PropertyAddress;

	private static bool RunScriptGM_WorldContext_IsValid;

	private static int RunScriptGM_WorldContext_Offset;

	private static bool BGUSwitchPage_IsValid;

	private static IntPtr BGUSwitchPage_FunctionAddress;

	private static int BGUSwitchPage_ParamsSize;

	private static bool BGUSwitchPage_WorldContext_IsValid;

	private static int BGUSwitchPage_WorldContext_Offset;

	private static bool BGUSwitchPage_PageId_IsValid;

	private static int BGUSwitchPage_PageId_Offset;

	private static FFieldAddress BGUSwitchPage_PageId_PropertyAddress;

	private static bool FindOrLoadClass_IsValid;

	private static IntPtr FindOrLoadClass_FunctionAddress;

	private static int FindOrLoadClass_ParamsSize;

	private static bool FindOrLoadClass_ClassName_IsValid;

	private static int FindOrLoadClass_ClassName_Offset;

	private static FFieldAddress FindOrLoadClass_ClassName_PropertyAddress;

	private static bool FindOrLoadClass_ReturnValue_IsValid;

	private static int FindOrLoadClass_ReturnValue_Offset;

	private static bool BGUSetPageActive_IsValid;

	private static IntPtr BGUSetPageActive_FunctionAddress;

	private static int BGUSetPageActive_ParamsSize;

	private static bool BGUSetPageActive_WorldContext_IsValid;

	private static int BGUSetPageActive_WorldContext_Offset;

	private static bool BGUSetPageActive_PageId_IsValid;

	private static int BGUSetPageActive_PageId_Offset;

	private static FFieldAddress BGUSetPageActive_PageId_PropertyAddress;

	private static bool BGUSetPageActive_IsActive_IsValid;

	private static int BGUSetPageActive_IsActive_Offset;

	private static FFieldAddress BGUSetPageActive_IsActive_PropertyAddress;

	private static bool BGUSaveTempWidget_IsValid;

	private static IntPtr BGUSaveTempWidget_FunctionAddress;

	private static int BGUSaveTempWidget_ParamsSize;

	private static bool BGUSaveTempWidget_TmpWidget_IsValid;

	private static int BGUSaveTempWidget_TmpWidget_Offset;

	private static bool FindAllNodeByClass_IsValid;

	private static IntPtr FindAllNodeByClass_FunctionAddress;

	private static int FindAllNodeByClass_ParamsSize;

	private static bool FindAllNodeByClass_InAsset_IsValid;

	private static int FindAllNodeByClass_InAsset_Offset;

	private static bool FindAllNodeByClass_NodeClass_IsValid;

	private static int FindAllNodeByClass_NodeClass_Offset;

	private static bool FindAllNodeByClass_Nodes_IsValid;

	private static int FindAllNodeByClass_Nodes_Offset;

	private static FFieldAddress FindAllNodeByClass_Nodes_PropertyAddress;

	private static bool BGUActiveUIBlackOut_IsValid;

	private static IntPtr BGUActiveUIBlackOut_FunctionAddress;

	private static int BGUActiveUIBlackOut_ParamsSize;

	private static bool BGUActiveUIBlackOut_WorldContext_IsValid;

	private static int BGUActiveUIBlackOut_WorldContext_Offset;

	private static bool BGUActiveUIBlackOut_IsActive_IsValid;

	private static int BGUActiveUIBlackOut_IsActive_Offset;

	private static FFieldAddress BGUActiveUIBlackOut_IsActive_PropertyAddress;

	private static bool FixTransactionalTamer_IsValid;

	private static IntPtr FixTransactionalTamer_FunctionAddress;

	private static int FixTransactionalTamer_ParamsSize;

	private static bool FixTransactionalTamer_WorldContext_IsValid;

	private static int FixTransactionalTamer_WorldContext_Offset;

	private static bool CreateTamerFromBPPath_IsValid;

	private static IntPtr CreateTamerFromBPPath_FunctionAddress;

	private static int CreateTamerFromBPPath_ParamsSize;

	private static bool CreateTamerFromBPPath_WorldContext_IsValid;

	private static int CreateTamerFromBPPath_WorldContext_Offset;

	private static bool CreateTamerFromBPPath_BPPath_IsValid;

	private static int CreateTamerFromBPPath_BPPath_Offset;

	private static FFieldAddress CreateTamerFromBPPath_BPPath_PropertyAddress;

	private static bool CreateTamerFromBPPath_TamerObject_IsValid;

	private static int CreateTamerFromBPPath_TamerObject_Offset;

	private static bool CreateTamerFromBPPath_TamerClass_IsValid;

	private static int CreateTamerFromBPPath_TamerClass_Offset;

	private static bool CreateTamerFromBPPath_ReturnValue_IsValid;

	private static int CreateTamerFromBPPath_ReturnValue_Offset;

	private static FFieldAddress CreateTamerFromBPPath_ReturnValue_PropertyAddress;

	private static bool CreateTamerFromUnitClass_IsValid;

	private static IntPtr CreateTamerFromUnitClass_FunctionAddress;

	private static int CreateTamerFromUnitClass_ParamsSize;

	private static bool CreateTamerFromUnitClass_WorldContext_IsValid;

	private static int CreateTamerFromUnitClass_WorldContext_Offset;

	private static bool CreateTamerFromUnitClass_UnitClass_IsValid;

	private static int CreateTamerFromUnitClass_UnitClass_Offset;

	private static bool CreateTamerFromUnitClass_TamerObject_IsValid;

	private static int CreateTamerFromUnitClass_TamerObject_Offset;

	private static bool CreateTamerFromUnitClass_TamerClass_IsValid;

	private static int CreateTamerFromUnitClass_TamerClass_Offset;

	private static bool CreateTamerFromUnitClass_ReturnValue_IsValid;

	private static int CreateTamerFromUnitClass_ReturnValue_Offset;

	private static FFieldAddress CreateTamerFromUnitClass_ReturnValue_PropertyAddress;

	private static bool RegGSGridConScreenAdapter_IsValid;

	private static IntPtr RegGSGridConScreenAdapter_FunctionAddress;

	private static int RegGSGridConScreenAdapter_ParamsSize;

	private static bool RegGSGridConScreenAdapter_WorldContext_IsValid;

	private static int RegGSGridConScreenAdapter_WorldContext_Offset;

	private static bool RegGSGridConScreenAdapter_RefGSGridConScreenAdapter_IsValid;

	private static int RegGSGridConScreenAdapter_RefGSGridConScreenAdapter_Offset;

	private static bool BGUChangeChapterLightBase_IsValid;

	private static IntPtr BGUChangeChapterLightBase_FunctionAddress;

	private static int BGUChangeChapterLightBase_ParamsSize;

	private static bool BGUChangeChapterLightBase_WorldContext_IsValid;

	private static int BGUChangeChapterLightBase_WorldContext_Offset;

	private static bool BGUChangeChapterLightBase_LightBase_IsValid;

	private static int BGUChangeChapterLightBase_LightBase_Offset;

	private static bool IsAnyStoryNodeHasGainItem_IsValid;

	private static IntPtr IsAnyStoryNodeHasGainItem_FunctionAddress;

	private static int IsAnyStoryNodeHasGainItem_ParamsSize;

	private static bool IsAnyStoryNodeHasGainItem_InAsset_IsValid;

	private static int IsAnyStoryNodeHasGainItem_InAsset_Offset;

	private static bool IsAnyStoryNodeHasGainItem_ReturnValue_IsValid;

	private static int IsAnyStoryNodeHasGainItem_ReturnValue_Offset;

	private static FFieldAddress IsAnyStoryNodeHasGainItem_ReturnValue_PropertyAddress;

	private static bool UnRegGSGridConScreenAdapter_IsValid;

	private static IntPtr UnRegGSGridConScreenAdapter_FunctionAddress;

	private static int UnRegGSGridConScreenAdapter_ParamsSize;

	private static bool UnRegGSGridConScreenAdapter_WorldContext_IsValid;

	private static int UnRegGSGridConScreenAdapter_WorldContext_Offset;

	private static bool UnRegGSGridConScreenAdapter_RefGSGridConScreenAdapter_IsValid;

	private static int UnRegGSGridConScreenAdapter_RefGSGridConScreenAdapter_Offset;

	private static bool ConvertToTamerPathFromBPPath_IsValid;

	private static IntPtr ConvertToTamerPathFromBPPath_FunctionAddress;

	private static int ConvertToTamerPathFromBPPath_ParamsSize;

	private static bool ConvertToTamerPathFromBPPath_WorldContext_IsValid;

	private static int ConvertToTamerPathFromBPPath_WorldContext_Offset;

	private static bool ConvertToTamerPathFromBPPath_BPPath_IsValid;

	private static int ConvertToTamerPathFromBPPath_BPPath_Offset;

	private static FFieldAddress ConvertToTamerPathFromBPPath_BPPath_PropertyAddress;

	private static bool ConvertToTamerPathFromBPPath_ReturnValue_IsValid;

	private static int ConvertToTamerPathFromBPPath_ReturnValue_Offset;

	private static FFieldAddress ConvertToTamerPathFromBPPath_ReturnValue_PropertyAddress;

	private static bool BatchReplaceMapUnitWithTamer_IsValid;

	private static IntPtr BatchReplaceMapUnitWithTamer_FunctionAddress;

	private static int BatchReplaceMapUnitWithTamer_ParamsSize;

	private static bool BatchReplaceMapUnitWithTamer_WorldContext_IsValid;

	private static int BatchReplaceMapUnitWithTamer_WorldContext_Offset;

	private static bool AutoGenTamerFromUnitBlueprint_IsValid;

	private static IntPtr AutoGenTamerFromUnitBlueprint_FunctionAddress;

	private static int AutoGenTamerFromUnitBlueprint_ParamsSize;

	private static bool AutoGenTamerFromUnitBlueprint_WorldContext_IsValid;

	private static int AutoGenTamerFromUnitBlueprint_WorldContext_Offset;

	private static bool AutoGenTamerFromUnitBlueprint_Folder_IsValid;

	private static int AutoGenTamerFromUnitBlueprint_Folder_Offset;

	private static FFieldAddress AutoGenTamerFromUnitBlueprint_Folder_PropertyAddress;

	private static bool AutoGenTamerFromUnitBlueprint_bRecursive_IsValid;

	private static int AutoGenTamerFromUnitBlueprint_bRecursive_Offset;

	private static FFieldAddress AutoGenTamerFromUnitBlueprint_bRecursive_PropertyAddress;

	private static bool SetShaderPipelineCacheEnabled_IsValid;

	private static IntPtr SetShaderPipelineCacheEnabled_FunctionAddress;

	private static int SetShaderPipelineCacheEnabled_ParamsSize;

	private static bool SetShaderPipelineCacheEnabled_WorldContext_IsValid;

	private static int SetShaderPipelineCacheEnabled_WorldContext_Offset;

	private static bool SetShaderPipelineCacheEnabled_IsEnable_IsValid;

	private static int SetShaderPipelineCacheEnabled_IsEnable_Offset;

	private static FFieldAddress SetShaderPipelineCacheEnabled_IsEnable_PropertyAddress;

	private static bool SetShaderPipelineCacheEnabled_TargetPlayerController_IsValid;

	private static int SetShaderPipelineCacheEnabled_TargetPlayerController_Offset;

	private static bool IsContainNonexistentTaskStage_IsValid;

	private static IntPtr IsContainNonexistentTaskStage_FunctionAddress;

	private static int IsContainNonexistentTaskStage_ParamsSize;

	private static bool IsContainNonexistentTaskStage_InAsset_IsValid;

	private static int IsContainNonexistentTaskStage_InAsset_Offset;

	private static bool IsContainNonexistentTaskStage_ReturnValue_IsValid;

	private static int IsContainNonexistentTaskStage_ReturnValue_Offset;

	private static FFieldAddress IsContainNonexistentTaskStage_ReturnValue_PropertyAddress;

	private static bool BatchReplaceMapSpawnerWithTamer_IsValid;

	private static IntPtr BatchReplaceMapSpawnerWithTamer_FunctionAddress;

	private static int BatchReplaceMapSpawnerWithTamer_ParamsSize;

	private static bool BatchReplaceMapSpawnerWithTamer_WorldContext_IsValid;

	private static int BatchReplaceMapSpawnerWithTamer_WorldContext_Offset;

	private static bool FixFontForPIEPreviewInEditorDebug_IsValid;

	private static IntPtr FixFontForPIEPreviewInEditorDebug_FunctionAddress;

	private static int FixFontForPIEPreviewInEditorDebug_ParamsSize;

	private static bool FixFontForPIEPreviewInEditorDebug_TargetWidget_IsValid;

	private static int FixFontForPIEPreviewInEditorDebug_TargetWidget_Offset;

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUSaveTempWidget")]
	public static void BGUSaveTempWidget(UUserWidget TmpWidget)
	{
		BGW_UIMgr.Get(TmpWidget).TempSaveBluprintWidget(TmpWidget);
	}

	[Category("BGW|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:RunScriptGM")]
	public static void RunScriptGM(string GMCommand, UObject WorldContext)
	{
		UGSE_EngineFuncLib.LogInfo("Try to RunScriptGM StrCommand:" + GMCommand);
		if (WorldContext == null)
		{
			UGSE_EngineFuncLib.LogError("RunScriptGM Failed WorldContext is NULL StrCommand:" + GMCommand);
			return;
		}
		BGW_ILRuntimeMgr.ILRuntimeInvoke(WorldContext, "B1UI.GSSvc.GSGMSvc", "RunGSScriptGM", null, GMCommand);
	}

	[Category("BGW|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:RegGSGridConScreenAdapter")]
	public static void RegGSGridConScreenAdapter(UObject WorldContext, GSGridConScreenAdapter RefGSGridConScreenAdapter)
	{
		BGW_CameraAdapterMgr.Get(WorldContext)?.RegUIGSGridConScreenAdapter(RefGSGridConScreenAdapter);
	}

	[Category("BGW|Util")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:UnRegGSGridConScreenAdapter")]
	public static void UnRegGSGridConScreenAdapter(UObject WorldContext, GSGridConScreenAdapter RefGSGridConScreenAdapter)
	{
		BGW_CameraAdapterMgr.Get(WorldContext)?.UnRegUIGSGridConScreenAdapter(RefGSGridConScreenAdapter);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGW|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:SetShaderPipelineCacheEnabled")]
	public static void SetShaderPipelineCacheEnabled(UObject WorldContext, bool IsEnable, APlayerController TargetPlayerController = null)
	{
		int num = (IsEnable ? 1 : 0);
		string command = $"r.ShaderPipelineCache.Enabled {num}";
		USystemLibrary.ExecuteConsoleCommand(WorldContext, command, TargetPlayerController);
	}

	[Category("BGW|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:FixFontForPIEPreviewInEditorDebug")]
	public static void FixFontForPIEPreviewInEditorDebug(UUserWidget TargetWidget)
	{
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUSetPageActive")]
	public static void BGUSetPageActive(UObject WorldContext, EUIPageID PageId, bool IsActive)
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(WorldContext);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_SetPageActive(PageId, IsActive);
		}
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUSwitchPage")]
	public static void BGUSwitchPage(UObject WorldContext, EUIPageID PageId)
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(WorldContext);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_SwitchPageActive(PageId);
		}
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUChangeChapterLightBase")]
	public static void BGUChangeChapterLightBase(UObject WorldContext, float LightBase)
	{
		if (DebugConfig.Debug820Demo)
		{
			BGW_ChapterView820Mgr bGW_ChapterView820Mgr = BGW_ChapterView820Mgr.Get(WorldContext);
			if (bGW_ChapterView820Mgr != null)
			{
				bGW_ChapterView820Mgr.ChangeChapterLightBase(LightBase);
			}
		}
		else if (DebugConfig.EnableChapterRoamV2)
		{
			BGW_ChapterViewMgrV2 bGW_ChapterViewMgrV = BGW_ChapterViewMgrV2.Get(WorldContext);
			if (bGW_ChapterViewMgrV != null)
			{
				bGW_ChapterViewMgrV.ChangeChapterLightBase(LightBase);
			}
		}
		else
		{
			BGW_ChapterViewMgr bGW_ChapterViewMgr = BGW_ChapterViewMgr.Get(WorldContext);
			if (bGW_ChapterViewMgr != null)
			{
				bGW_ChapterViewMgr.ChangeChapterLightBase(LightBase);
			}
		}
	}

	[Category("BGU|Util")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUActiveUIBlackOut")]
	public static void BGUActiveUIBlackOut(UObject WorldContext, bool IsActive)
	{
		BGW_UIEventCollection.Get(WorldContext)?.Evt_UI_ActiveBlackOut(IsActive);
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:AutoGenTamerFromUnitBlueprint")]
	public static void AutoGenTamerFromUnitBlueprint(UObject WorldContext, string Folder, bool bRecursive = true)
	{
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:BatchReplaceMapUnitWithTamer")]
	public static void BatchReplaceMapUnitWithTamer(UObject WorldContext)
	{
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(WorldContext);
		List<UObject> list = new List<UObject>();
		BGUCharacterCS[] array = allActorsOfClass;
		foreach (BGUCharacterCS bGUCharacterCS in array)
		{
			if (bGUCharacterCS.GetAttachParentActor() != null)
			{
				continue;
			}
			string pathName = bGUCharacterCS.GetClass().GetPathName();
			string path = FPaths.GetPath(pathName);
			string baseFilename = FPaths.GetBaseFilename(pathName);
			if (baseFilename.StartsWith("unit_", ignoreCase: true, CultureInfo.CurrentCulture))
			{
				string text = pathName.Substring(0, pathName.Length - 2);
				UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, text, out var Blueprint);
				string assetName = "TAMER_" + baseFilename.Substring(5).ToLower();
				UObject uObject = UGSFuncLibForEditor.CreateBlueprintWithClass(UClass.GetClass(typeof(BUTamerActor)), assetName, path);
				if (uObject != null && UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, uObject.GetPathName(), out var Blueprint2) is BUTamerActor bUTamerActor)
				{
					UAssetDataArray assetsByPath = UGSE_AssetUtilFuncLib.GetAssetsByPath(new List<string> { text });
					UPackage uPackage = UObject.FindPackage(ObjectOuter.Null, assetsByPath.AssetDataArr[0].PackagePath.ToString());
					bUTamerActor.SetMonsterClass(UObject.FindObject<UClass>(uPackage, pathName));
					bUTamerActor.CopyPropertiesFromUnit();
					UGSFuncLibForEditor.CopyThumbnailBetweenBlueprint(Blueprint, Blueprint2);
					list.Add(uObject);
				}
			}
		}
		UGSEditorAssetLibrary.ReloadAssets(list);
		Dictionary<BGUCharacterCS, BUTamerActor> dictionary = new Dictionary<BGUCharacterCS, BUTamerActor>();
		array = allActorsOfClass;
		foreach (BGUCharacterCS bGUCharacterCS2 in array)
		{
			if (bGUCharacterCS2.GetAttachParentActor() != null)
			{
				continue;
			}
			string pathName2 = bGUCharacterCS2.GetClass().GetPathName();
			string path2 = FPaths.GetPath(pathName2);
			string baseFilename2 = FPaths.GetBaseFilename(pathName2);
			if (!baseFilename2.StartsWith("unit_", ignoreCase: true, CultureInfo.CurrentCulture))
			{
				continue;
			}
			string path3 = pathName2.Substring(0, pathName2.Length - 2);
			UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, path3, out var _);
			string text2 = "TAMER_" + baseFilename2.Substring(5).ToLower();
			if (!(UGSFuncLibForEditor.CreateBlueprintWithClass(UClass.GetClass(typeof(BUTamerActor)), text2, path2) == null) || !(UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, path2 + "/" + text2, out var Blueprint4) is BUTamerActor))
			{
				continue;
			}
			FTransform actorTransform = bGUCharacterCS2.GetActorTransform();
			BUTamerActor bUTamerActor2 = UGSE_ActorFuncLib.SpawnBlueprintActorByFactory(Blueprint4, bGUCharacterCS2.GetOuter() as ULevel, actorTransform) as BUTamerActor;
			if (!(bUTamerActor2 != null))
			{
				continue;
			}
			bUTamerActor2.SetActorLabel(bGUCharacterCS2.GetActorLabel().ToLower().Replace("unit", "TAMER"));
			bUTamerActor2.CopyPropertiesFromUnitActor(bGUCharacterCS2);
			AActor attachParentActor = bGUCharacterCS2.GetAttachParentActor();
			if (attachParentActor != null)
			{
				FName attachParentSocketName = bGUCharacterCS2.GetAttachParentSocketName();
				bUTamerActor2.AttachToActor(attachParentActor, attachParentSocketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
			bGUCharacterCS2.GetAttachedActors(out var OutActors);
			foreach (AActor item in OutActors)
			{
				FName attachParentSocketName2 = item.GetAttachParentSocketName();
				item.AttachToActor(bUTamerActor2, attachParentSocketName2, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
			dictionary.Add(bGUCharacterCS2, bUTamerActor2);
		}
		foreach (BUTamerActor value2 in dictionary.Values)
		{
			FGSWakeUpConfig wakeUpConfig = value2.ExtendConfigComp.WakeUpConfig;
			wakeUpConfig.TargetTamerList.Clear();
			foreach (ABGUCharacter target in wakeUpConfig.TargetList)
			{
				if (target as BGUCharacterCS != null && dictionary.TryGetValue(target as BGUCharacterCS, out var value))
				{
					wakeUpConfig.TargetTamerList.Add(value);
				}
			}
			value2.ExtendConfigComp.WakeUpConfig = wakeUpConfig;
		}
		foreach (KeyValuePair<BGUCharacterCS, BUTamerActor> item2 in dictionary)
		{
			item2.Key.DestroyActor();
		}
		dictionary.Clear();
	}

	[BlueprintCallable]
	[Category("BGU|Util")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:FixTransactionalTamer")]
	public static void FixTransactionalTamer(UObject WorldContext)
	{
		Dictionary<BUTamerActor, BUTamerActor> dictionary = new Dictionary<BUTamerActor, BUTamerActor>();
		BUTamerActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>(WorldContext);
		foreach (BUTamerActor bUTamerActor in allActorsOfClass)
		{
			if (bUTamerActor.HasAllFlags(EObjectFlags.Transactional))
			{
				continue;
			}
			string pathName = bUTamerActor.GetClass().GetPathName();
			string path = FPaths.GetPath(pathName);
			string baseFilename = FPaths.GetBaseFilename(pathName);
			if (!(UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, path + "/" + baseFilename, out var Blueprint) is BUTamerActor))
			{
				continue;
			}
			FTransform actorTransform = bUTamerActor.GetActorTransform();
			BUTamerActor bUTamerActor2 = UGSE_ActorFuncLib.SpawnBlueprintActorByFactory(Blueprint, bUTamerActor.GetOuter() as ULevel, actorTransform) as BUTamerActor;
			if (!(bUTamerActor2 != null))
			{
				continue;
			}
			bUTamerActor2.SetActorLabel(bUTamerActor.GetActorLabel());
			bUTamerActor2.CopyPropertiesFromTamerActor(bUTamerActor);
			AActor attachParentActor = bUTamerActor.GetAttachParentActor();
			if (attachParentActor != null)
			{
				FName attachParentSocketName = bUTamerActor.GetAttachParentSocketName();
				bUTamerActor2.AttachToActor(attachParentActor, attachParentSocketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
			bUTamerActor.GetAttachedActors(out var OutActors);
			foreach (AActor item in OutActors)
			{
				FName attachParentSocketName2 = item.GetAttachParentSocketName();
				item.AttachToActor(bUTamerActor2, attachParentSocketName2, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
			dictionary.Add(bUTamerActor, bUTamerActor2);
		}
		foreach (KeyValuePair<BUTamerActor, BUTamerActor> item2 in dictionary)
		{
			item2.Key.DestroyActor();
		}
		dictionary.Clear();
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:FindOrLoadClass")]
	public static UClass FindOrLoadClass(string ClassName)
	{
		UClass uClass = UObject.FindObject<UClass>(ObjectOuter.AnyPackage, ClassName);
		if (uClass == null)
		{
			uClass = UObject.LoadObject<UClass>(ObjectOuter.Null, ClassName);
		}
		return uClass;
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:BatchReplaceMapSpawnerWithTamer")]
	public static void BatchReplaceMapSpawnerWithTamer(UObject WorldContext)
	{
		Dictionary<UClass, UClass> dictionary = new Dictionary<UClass, UClass>();
		List<UObject> list = new List<UObject>();
		BGUSpawnMultiPointActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUSpawnMultiPointActor>(WorldContext);
		BGUSpawnMultiPointActor[] array = allActorsOfClass;
		for (int i = 0; i < array.Length; i++)
		{
			foreach (TSubclassOf<AActor> item in array[i].SpawnMultiPointConfigComp.SpawnActorList.ToList())
			{
				UClass value = item.Value;
				if (!dictionary.ContainsKey(value) && value.IsChildOf<BGUCharacterCS>() && CreateTamerFromUnitClass(WorldContext, value, out var TamerObject, out var TamerClass))
				{
					if (TamerObject != null)
					{
						list.Add(TamerObject);
					}
					dictionary.Add(value, TamerClass);
				}
			}
		}
		BGU_QuestActor[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<BGU_QuestActor>(WorldContext);
		BGU_QuestActor[] array2 = allActorsOfClass2;
		foreach (BGU_QuestActor bGU_QuestActor in array2)
		{
			if (bGU_QuestActor.QuestActorType != EQuestActorType.SpawnWaves)
			{
				continue;
			}
			for (int j = 0; j < bGU_QuestActor.Waves.Count; j++)
			{
				foreach (FSpawnWaveUnitConfig spawnWaveUnit in bGU_QuestActor.Waves[j].SpawnWaveUnits)
				{
					UClass value2 = spawnWaveUnit.UnitType.Value;
					if (value2 != null && !dictionary.ContainsKey(value2) && CreateTamerFromUnitClass(WorldContext, value2, out var TamerObject2, out var TamerClass2))
					{
						if (TamerObject2 != null)
						{
							list.Add(TamerObject2);
						}
						dictionary.Add(value2, TamerClass2);
					}
				}
			}
		}
		UGSEditorAssetLibrary.ReloadAssets(list);
		array = allActorsOfClass;
		foreach (BGUSpawnMultiPointActor bGUSpawnMultiPointActor in array)
		{
			List<TSubclassOf<AActor>> list2 = bGUSpawnMultiPointActor.SpawnMultiPointConfigComp.SpawnActorList.ToList();
			for (int k = 0; k < list2.Count; k++)
			{
				UClass value3 = list2[k].Value;
				if (dictionary.TryGetValue(value3, out var value4))
				{
					bGUSpawnMultiPointActor.SpawnMultiPointConfigComp.SpawnActorList[k] = value4;
				}
			}
			bGUSpawnMultiPointActor.MarkPackageDirty();
		}
		array2 = allActorsOfClass2;
		foreach (BGU_QuestActor bGU_QuestActor2 in array2)
		{
			if (bGU_QuestActor2.QuestActorType != EQuestActorType.SpawnWaves)
			{
				continue;
			}
			for (int l = 0; l < bGU_QuestActor2.Waves.Count; l++)
			{
				FSpawnWaveConfig value5 = bGU_QuestActor2.Waves[l];
				for (int m = 0; m < value5.SpawnWaveUnits.Count; m++)
				{
					FSpawnWaveUnitConfig value6 = value5.SpawnWaveUnits[m];
					UClass value7 = value6.UnitType.Value;
					if (value7 != null && dictionary.TryGetValue(value7, out var value8))
					{
						value6.TamerClass = value8;
						value5.SpawnWaveUnits[m] = value6;
					}
				}
				bGU_QuestActor2.Waves[l] = value5;
			}
			bGU_QuestActor2.MarkPackageDirty();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:CreateTamerFromUnitClass")]
	public static bool CreateTamerFromUnitClass(UObject WorldContext, UClass UnitClass, out UObject TamerObject, out UClass TamerClass)
	{
		TamerClass = null;
		TamerObject = null;
		string pathName = UnitClass.GetPathName();
		string path = FPaths.GetPath(pathName);
		string baseFilename = FPaths.GetBaseFilename(pathName);
		if (baseFilename.StartsWith("unit_", ignoreCase: true, CultureInfo.CurrentCulture))
		{
			string text = pathName.Substring(0, pathName.Length - 2);
			UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, text, out var Blueprint);
			string text2 = "TAMER_" + baseFilename.Substring(5).ToLower();
			TamerObject = UGSFuncLibForEditor.CreateBlueprintWithClass(UClass.GetClass(typeof(BUTamerActor)), text2, path);
			if (TamerObject != null && UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, TamerObject.GetPathName(), out var Blueprint2) is BUTamerActor bUTamerActor)
			{
				UAssetDataArray assetsByPath = UGSE_AssetUtilFuncLib.GetAssetsByPath(new List<string> { text });
				UPackage uPackage = UObject.FindPackage(ObjectOuter.Null, assetsByPath.AssetDataArr[0].PackagePath.ToString());
				bUTamerActor.SetMonsterClass(UObject.FindObject<UClass>(uPackage, pathName));
				bUTamerActor.CopyPropertiesFromUnit();
				UGSFuncLibForEditor.CopyThumbnailBetweenBlueprint(Blueprint, Blueprint2);
			}
			TamerClass = FindOrLoadClass(path + "/" + text2 + "." + text2 + "_C");
			return true;
		}
		return false;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:CreateTamerFromBPPath")]
	public static bool CreateTamerFromBPPath(UObject WorldContext, string BPPath, out UObject TamerObject, out UClass TamerClass)
	{
		TamerClass = null;
		TamerObject = null;
		string path = FPaths.GetPath(BPPath);
		string baseFilename = FPaths.GetBaseFilename(BPPath);
		if (baseFilename.StartsWith("unit_", ignoreCase: true, CultureInfo.CurrentCulture))
		{
			string text = BPPath.Substring(0, BPPath.Length - 2);
			UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, text, out var Blueprint);
			if (Blueprint == null)
			{
				return false;
			}
			string text2 = "TAMER_" + baseFilename.Substring(5).ToLower();
			TamerObject = UGSFuncLibForEditor.CreateBlueprintWithClass(UClass.GetClass(typeof(BUTamerActor)), text2, path);
			if (TamerObject != null && UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, TamerObject.GetPathName(), out var Blueprint2) is BUTamerActor bUTamerActor)
			{
				UAssetDataArray assetsByPath = UGSE_AssetUtilFuncLib.GetAssetsByPath(new List<string> { text });
				UPackage uPackage = UObject.FindPackage(ObjectOuter.Null, assetsByPath.AssetDataArr[0].PackagePath.ToString());
				bUTamerActor.SetMonsterClass(UObject.FindObject<UClass>(uPackage, BPPath));
				bUTamerActor.CopyPropertiesFromUnit();
				UGSFuncLibForEditor.CopyThumbnailBetweenBlueprint(Blueprint, Blueprint2);
			}
			TamerClass = FindOrLoadClass(path + "/" + text2 + "." + text2 + "_C");
			return true;
		}
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:ConvertToTamerPathFromBPPath")]
	public static string ConvertToTamerPathFromBPPath(UObject WorldContext, string BPPath)
	{
		string path = FPaths.GetPath(BPPath);
		string baseFilename = FPaths.GetBaseFilename(BPPath);
		if (baseFilename.StartsWith("unit_", ignoreCase: true, CultureInfo.CurrentCulture))
		{
			string path2 = BPPath.Substring(0, BPPath.Length - 2);
			UGSE_EditorFuncLib.AssetPath_GetCDO(WorldContext, path2, out var Blueprint);
			if (Blueprint == null)
			{
				return null;
			}
			string text = "TAMER_" + baseFilename.Substring(5).ToLower();
			return path + "/" + text + "." + text + "_C";
		}
		return null;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:FindAllNodeByClass")]
	public static void FindAllNodeByClass(BED_CalliopeAssetBase InAsset, TSubclassOf<BED_CalliopeNodeBae> NodeClass, out List<BED_CalliopeNodeBae> Nodes)
	{
		Nodes = new List<BED_CalliopeNodeBae>();
		if (InAsset == null || NodeClass == null)
		{
			return;
		}
		foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> node in InAsset.Nodes)
		{
			BED_CalliopeNodeBae bED_CalliopeNodeBae = node.Value as BED_CalliopeNodeBae;
			if (!(bED_CalliopeNodeBae == null) && bED_CalliopeNodeBae.IsA(NodeClass.Value))
			{
				Nodes.Add(bED_CalliopeNodeBae);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:IsAnyStoryNodeHasGainItem")]
	public static bool IsAnyStoryNodeHasGainItem(BED_CalliopeAssetBase InAsset)
	{
		FindAllNodeByClass(InAsset, UClass.GetClass<BED_ProcessMachineNode_Story>(), out var Nodes);
		if (Nodes != null && Nodes.Count > 0)
		{
			foreach (BED_CalliopeNodeBae item in Nodes)
			{
				BED_ProcessMachineNode_Story bED_ProcessMachineNode_Story = item as BED_ProcessMachineNode_Story;
				if (bED_ProcessMachineNode_Story != null && bED_ProcessMachineNode_Story.bGainItemWhenFinish)
				{
					return true;
				}
			}
		}
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryManaged:IsContainNonexistentTaskStage")]
	public static bool IsContainNonexistentTaskStage(BED_CalliopeAssetBase InAsset)
	{
		FindAllNodeByClass(InAsset, UClass.GetClass<b1.BED_TaskNode_PushTaskStageState>(), out var Nodes);
		if (Nodes != null && Nodes.Count > 0)
		{
			foreach (BED_CalliopeNodeBae item in Nodes)
			{
				b1.BED_TaskNode_PushTaskStageState bED_TaskNode_PushTaskStageState = item as b1.BED_TaskNode_PushTaskStageState;
				if (bED_TaskNode_PushTaskStageState != null && BGW_GameDB.GetTaskStageDesc(InAsset.GetTaskStageIDBySmartParam(bED_TaskNode_PushTaskStageState.PushTaskStage)) == null)
				{
					return true;
				}
			}
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:RunScriptGM")]
	private static void RunScriptGM__Invoker(IntPtr buffer, IntPtr obj)
	{
		string gMCommand = FStringMarshaler.FromNative(IntPtr.Add(buffer, RunScriptGM_GMCommand_Offset));
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, RunScriptGM_WorldContext_Offset));
		RunScriptGM(gMCommand, worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUSwitchPage")]
	private static void BGUSwitchPage__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUSwitchPage_WorldContext_Offset));
		EUIPageID pageId = EnumMarshaler<EUIPageID>.FromNative(IntPtr.Add(buffer, BGUSwitchPage_PageId_Offset), 0, BGUSwitchPage_PageId_PropertyAddress.Address);
		BGUSwitchPage(worldContext, pageId);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:FindOrLoadClass")]
	private static void FindOrLoadClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		string className = FStringMarshaler.FromNative(IntPtr.Add(buffer, FindOrLoadClass_ClassName_Offset));
		UClass value = FindOrLoadClass(className);
		UObjectMarshaler<UClass>.ToNative(IntPtr.Add(buffer, FindOrLoadClass_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUSetPageActive")]
	private static void BGUSetPageActive__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUSetPageActive_WorldContext_Offset));
		EUIPageID pageId = EnumMarshaler<EUIPageID>.FromNative(IntPtr.Add(buffer, BGUSetPageActive_PageId_Offset), 0, BGUSetPageActive_PageId_PropertyAddress.Address);
		bool isActive = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUSetPageActive_IsActive_Offset), 0, BGUSetPageActive_IsActive_PropertyAddress.Address);
		BGUSetPageActive(worldContext, pageId, isActive);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUSaveTempWidget")]
	private static void BGUSaveTempWidget__Invoker(IntPtr buffer, IntPtr obj)
	{
		UUserWidget tmpWidget = UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(buffer, BGUSaveTempWidget_TmpWidget_Offset));
		BGUSaveTempWidget(tmpWidget);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:FindAllNodeByClass")]
	private static void FindAllNodeByClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase inAsset = UObjectMarshaler<BED_CalliopeAssetBase>.FromNative(IntPtr.Add(buffer, FindAllNodeByClass_InAsset_Offset));
		TSubclassOf<BED_CalliopeNodeBae> nodeClass = TSubclassOfMarshaler<BED_CalliopeNodeBae>.FromNative(IntPtr.Add(buffer, FindAllNodeByClass_NodeClass_Offset));
		TArrayCopyMarshaler<BED_CalliopeNodeBae> tArrayCopyMarshaler = new TArrayCopyMarshaler<BED_CalliopeNodeBae>(1, FindAllNodeByClass_Nodes_PropertyAddress, CachedMarshalingDelegates<BED_CalliopeNodeBae, UObjectMarshaler<BED_CalliopeNodeBae>>.FromNative, CachedMarshalingDelegates<BED_CalliopeNodeBae, UObjectMarshaler<BED_CalliopeNodeBae>>.ToNative);
		List<BED_CalliopeNodeBae> Nodes = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, FindAllNodeByClass_Nodes_Offset));
		FindAllNodeByClass(inAsset, nodeClass, out Nodes);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, FindAllNodeByClass_Nodes_Offset), Nodes);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUActiveUIBlackOut")]
	private static void BGUActiveUIBlackOut__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUActiveUIBlackOut_WorldContext_Offset));
		bool isActive = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUActiveUIBlackOut_IsActive_Offset), 0, BGUActiveUIBlackOut_IsActive_PropertyAddress.Address);
		BGUActiveUIBlackOut(worldContext, isActive);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:FixTransactionalTamer")]
	private static void FixTransactionalTamer__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, FixTransactionalTamer_WorldContext_Offset));
		FixTransactionalTamer(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:CreateTamerFromBPPath")]
	private static void CreateTamerFromBPPath__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, CreateTamerFromBPPath_WorldContext_Offset));
		string bPPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, CreateTamerFromBPPath_BPPath_Offset));
		UObject TamerObject;
		UClass TamerClass;
		bool value = CreateTamerFromBPPath(worldContext, bPPath, out TamerObject, out TamerClass);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CreateTamerFromBPPath_ReturnValue_Offset), 0, CreateTamerFromBPPath_ReturnValue_PropertyAddress.Address, value);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(buffer, CreateTamerFromBPPath_TamerObject_Offset), TamerObject);
		UObjectMarshaler<UClass>.ToNative(IntPtr.Add(buffer, CreateTamerFromBPPath_TamerClass_Offset), TamerClass);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:CreateTamerFromUnitClass")]
	private static void CreateTamerFromUnitClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, CreateTamerFromUnitClass_WorldContext_Offset));
		UClass unitClass = UObjectMarshaler<UClass>.FromNative(IntPtr.Add(buffer, CreateTamerFromUnitClass_UnitClass_Offset));
		UObject TamerObject;
		UClass TamerClass;
		bool value = CreateTamerFromUnitClass(worldContext, unitClass, out TamerObject, out TamerClass);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CreateTamerFromUnitClass_ReturnValue_Offset), 0, CreateTamerFromUnitClass_ReturnValue_PropertyAddress.Address, value);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(buffer, CreateTamerFromUnitClass_TamerObject_Offset), TamerObject);
		UObjectMarshaler<UClass>.ToNative(IntPtr.Add(buffer, CreateTamerFromUnitClass_TamerClass_Offset), TamerClass);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:RegGSGridConScreenAdapter")]
	private static void RegGSGridConScreenAdapter__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, RegGSGridConScreenAdapter_WorldContext_Offset));
		GSGridConScreenAdapter refGSGridConScreenAdapter = UObjectMarshaler<GSGridConScreenAdapter>.FromNative(IntPtr.Add(buffer, RegGSGridConScreenAdapter_RefGSGridConScreenAdapter_Offset));
		RegGSGridConScreenAdapter(worldContext, refGSGridConScreenAdapter);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUChangeChapterLightBase")]
	private static void BGUChangeChapterLightBase__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUChangeChapterLightBase_WorldContext_Offset));
		float lightBase = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUChangeChapterLightBase_LightBase_Offset));
		BGUChangeChapterLightBase(worldContext, lightBase);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:IsAnyStoryNodeHasGainItem")]
	private static void IsAnyStoryNodeHasGainItem__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase inAsset = UObjectMarshaler<BED_CalliopeAssetBase>.FromNative(IntPtr.Add(buffer, IsAnyStoryNodeHasGainItem_InAsset_Offset));
		bool value = IsAnyStoryNodeHasGainItem(inAsset);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsAnyStoryNodeHasGainItem_ReturnValue_Offset), 0, IsAnyStoryNodeHasGainItem_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:UnRegGSGridConScreenAdapter")]
	private static void UnRegGSGridConScreenAdapter__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, UnRegGSGridConScreenAdapter_WorldContext_Offset));
		GSGridConScreenAdapter refGSGridConScreenAdapter = UObjectMarshaler<GSGridConScreenAdapter>.FromNative(IntPtr.Add(buffer, UnRegGSGridConScreenAdapter_RefGSGridConScreenAdapter_Offset));
		UnRegGSGridConScreenAdapter(worldContext, refGSGridConScreenAdapter);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:ConvertToTamerPathFromBPPath")]
	private static void ConvertToTamerPathFromBPPath__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ConvertToTamerPathFromBPPath_WorldContext_Offset));
		string bPPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, ConvertToTamerPathFromBPPath_BPPath_Offset));
		string value = ConvertToTamerPathFromBPPath(worldContext, bPPath);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, ConvertToTamerPathFromBPPath_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:BatchReplaceMapUnitWithTamer")]
	private static void BatchReplaceMapUnitWithTamer__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BatchReplaceMapUnitWithTamer_WorldContext_Offset));
		BatchReplaceMapUnitWithTamer(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:AutoGenTamerFromUnitBlueprint")]
	private static void AutoGenTamerFromUnitBlueprint__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, AutoGenTamerFromUnitBlueprint_WorldContext_Offset));
		string folder = FStringMarshaler.FromNative(IntPtr.Add(buffer, AutoGenTamerFromUnitBlueprint_Folder_Offset));
		bool bRecursive = BoolMarshaler.FromNative(IntPtr.Add(buffer, AutoGenTamerFromUnitBlueprint_bRecursive_Offset), 0, AutoGenTamerFromUnitBlueprint_bRecursive_PropertyAddress.Address);
		AutoGenTamerFromUnitBlueprint(worldContext, folder, bRecursive);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:SetShaderPipelineCacheEnabled")]
	private static void SetShaderPipelineCacheEnabled__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, SetShaderPipelineCacheEnabled_WorldContext_Offset));
		bool isEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetShaderPipelineCacheEnabled_IsEnable_Offset), 0, SetShaderPipelineCacheEnabled_IsEnable_PropertyAddress.Address);
		APlayerController targetPlayerController = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, SetShaderPipelineCacheEnabled_TargetPlayerController_Offset));
		SetShaderPipelineCacheEnabled(worldContext, isEnable, targetPlayerController);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:IsContainNonexistentTaskStage")]
	private static void IsContainNonexistentTaskStage__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase inAsset = UObjectMarshaler<BED_CalliopeAssetBase>.FromNative(IntPtr.Add(buffer, IsContainNonexistentTaskStage_InAsset_Offset));
		bool value = IsContainNonexistentTaskStage(inAsset);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsContainNonexistentTaskStage_ReturnValue_Offset), 0, IsContainNonexistentTaskStage_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:BatchReplaceMapSpawnerWithTamer")]
	private static void BatchReplaceMapSpawnerWithTamer__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BatchReplaceMapSpawnerWithTamer_WorldContext_Offset));
		BatchReplaceMapSpawnerWithTamer(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryManaged:FixFontForPIEPreviewInEditorDebug")]
	private static void FixFontForPIEPreviewInEditorDebug__Invoker(IntPtr buffer, IntPtr obj)
	{
		UUserWidget targetWidget = UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(buffer, FixFontForPIEPreviewInEditorDebug_TargetWidget_Offset));
		FixFontForPIEPreviewInEditorDebug(targetWidget);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFunctionLibraryManaged");
		RunScriptGM_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RunScriptGM");
		RunScriptGM_ParamsSize = NativeReflection.GetFunctionParamsSize(RunScriptGM_FunctionAddress);
		NativeReflection.GetPropertyRef(ref RunScriptGM_GMCommand_PropertyAddress, RunScriptGM_FunctionAddress, "GMCommand");
		RunScriptGM_GMCommand_Offset = NativeReflection.GetPropertyOffset(RunScriptGM_FunctionAddress, "GMCommand");
		RunScriptGM_GMCommand_IsValid = NativeReflection.ValidatePropertyClass(RunScriptGM_FunctionAddress, "GMCommand", Classes.FStrProperty);
		RunScriptGM_WorldContext_Offset = NativeReflection.GetPropertyOffset(RunScriptGM_FunctionAddress, "WorldContext");
		RunScriptGM_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(RunScriptGM_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		RunScriptGM_IsValid = RunScriptGM_FunctionAddress != IntPtr.Zero && RunScriptGM_GMCommand_IsValid && RunScriptGM_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:RunScriptGM", RunScriptGM_IsValid);
		BGUSwitchPage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSwitchPage");
		BGUSwitchPage_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSwitchPage_FunctionAddress);
		BGUSwitchPage_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUSwitchPage_FunctionAddress, "WorldContext");
		BGUSwitchPage_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUSwitchPage_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSwitchPage_PageId_PropertyAddress, BGUSwitchPage_FunctionAddress, "PageId");
		BGUSwitchPage_PageId_Offset = NativeReflection.GetPropertyOffset(BGUSwitchPage_FunctionAddress, "PageId");
		BGUSwitchPage_PageId_IsValid = NativeReflection.ValidatePropertyClass(BGUSwitchPage_FunctionAddress, "PageId", Classes.FEnumProperty);
		BGUSwitchPage_IsValid = BGUSwitchPage_FunctionAddress != IntPtr.Zero && BGUSwitchPage_WorldContext_IsValid && BGUSwitchPage_PageId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUSwitchPage", BGUSwitchPage_IsValid);
		FindOrLoadClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindOrLoadClass");
		FindOrLoadClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FindOrLoadClass_FunctionAddress);
		NativeReflection.GetPropertyRef(ref FindOrLoadClass_ClassName_PropertyAddress, FindOrLoadClass_FunctionAddress, "ClassName");
		FindOrLoadClass_ClassName_Offset = NativeReflection.GetPropertyOffset(FindOrLoadClass_FunctionAddress, "ClassName");
		FindOrLoadClass_ClassName_IsValid = NativeReflection.ValidatePropertyClass(FindOrLoadClass_FunctionAddress, "ClassName", Classes.FStrProperty);
		FindOrLoadClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(FindOrLoadClass_FunctionAddress, "ReturnValue");
		FindOrLoadClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(FindOrLoadClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindOrLoadClass_IsValid = FindOrLoadClass_FunctionAddress != IntPtr.Zero && FindOrLoadClass_ClassName_IsValid && FindOrLoadClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:FindOrLoadClass", FindOrLoadClass_IsValid);
		BGUSetPageActive_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetPageActive");
		BGUSetPageActive_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetPageActive_FunctionAddress);
		BGUSetPageActive_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUSetPageActive_FunctionAddress, "WorldContext");
		BGUSetPageActive_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUSetPageActive_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetPageActive_PageId_PropertyAddress, BGUSetPageActive_FunctionAddress, "PageId");
		BGUSetPageActive_PageId_Offset = NativeReflection.GetPropertyOffset(BGUSetPageActive_FunctionAddress, "PageId");
		BGUSetPageActive_PageId_IsValid = NativeReflection.ValidatePropertyClass(BGUSetPageActive_FunctionAddress, "PageId", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGUSetPageActive_IsActive_PropertyAddress, BGUSetPageActive_FunctionAddress, "IsActive");
		BGUSetPageActive_IsActive_Offset = NativeReflection.GetPropertyOffset(BGUSetPageActive_FunctionAddress, "IsActive");
		BGUSetPageActive_IsActive_IsValid = NativeReflection.ValidatePropertyClass(BGUSetPageActive_FunctionAddress, "IsActive", Classes.FBoolProperty);
		BGUSetPageActive_IsValid = BGUSetPageActive_FunctionAddress != IntPtr.Zero && BGUSetPageActive_WorldContext_IsValid && BGUSetPageActive_PageId_IsValid && BGUSetPageActive_IsActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUSetPageActive", BGUSetPageActive_IsValid);
		BGUSaveTempWidget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSaveTempWidget");
		BGUSaveTempWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSaveTempWidget_FunctionAddress);
		BGUSaveTempWidget_TmpWidget_Offset = NativeReflection.GetPropertyOffset(BGUSaveTempWidget_FunctionAddress, "TmpWidget");
		BGUSaveTempWidget_TmpWidget_IsValid = NativeReflection.ValidatePropertyClass(BGUSaveTempWidget_FunctionAddress, "TmpWidget", Classes.FObjectProperty);
		BGUSaveTempWidget_IsValid = BGUSaveTempWidget_FunctionAddress != IntPtr.Zero && BGUSaveTempWidget_TmpWidget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUSaveTempWidget", BGUSaveTempWidget_IsValid);
		FindAllNodeByClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindAllNodeByClass");
		FindAllNodeByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAllNodeByClass_FunctionAddress);
		FindAllNodeByClass_InAsset_Offset = NativeReflection.GetPropertyOffset(FindAllNodeByClass_FunctionAddress, "InAsset");
		FindAllNodeByClass_InAsset_IsValid = NativeReflection.ValidatePropertyClass(FindAllNodeByClass_FunctionAddress, "InAsset", Classes.FObjectProperty);
		FindAllNodeByClass_NodeClass_Offset = NativeReflection.GetPropertyOffset(FindAllNodeByClass_FunctionAddress, "NodeClass");
		FindAllNodeByClass_NodeClass_IsValid = NativeReflection.ValidatePropertyClass(FindAllNodeByClass_FunctionAddress, "NodeClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref FindAllNodeByClass_Nodes_PropertyAddress, FindAllNodeByClass_FunctionAddress, "Nodes");
		FindAllNodeByClass_Nodes_Offset = NativeReflection.GetPropertyOffset(FindAllNodeByClass_FunctionAddress, "Nodes");
		FindAllNodeByClass_Nodes_IsValid = NativeReflection.ValidatePropertyClass(FindAllNodeByClass_FunctionAddress, "Nodes", Classes.FArrayProperty);
		FindAllNodeByClass_IsValid = FindAllNodeByClass_FunctionAddress != IntPtr.Zero && FindAllNodeByClass_InAsset_IsValid && FindAllNodeByClass_NodeClass_IsValid && FindAllNodeByClass_Nodes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:FindAllNodeByClass", FindAllNodeByClass_IsValid);
		BGUActiveUIBlackOut_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUActiveUIBlackOut");
		BGUActiveUIBlackOut_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUActiveUIBlackOut_FunctionAddress);
		BGUActiveUIBlackOut_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUActiveUIBlackOut_FunctionAddress, "WorldContext");
		BGUActiveUIBlackOut_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUActiveUIBlackOut_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUActiveUIBlackOut_IsActive_PropertyAddress, BGUActiveUIBlackOut_FunctionAddress, "IsActive");
		BGUActiveUIBlackOut_IsActive_Offset = NativeReflection.GetPropertyOffset(BGUActiveUIBlackOut_FunctionAddress, "IsActive");
		BGUActiveUIBlackOut_IsActive_IsValid = NativeReflection.ValidatePropertyClass(BGUActiveUIBlackOut_FunctionAddress, "IsActive", Classes.FBoolProperty);
		BGUActiveUIBlackOut_IsValid = BGUActiveUIBlackOut_FunctionAddress != IntPtr.Zero && BGUActiveUIBlackOut_WorldContext_IsValid && BGUActiveUIBlackOut_IsActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUActiveUIBlackOut", BGUActiveUIBlackOut_IsValid);
		FixTransactionalTamer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FixTransactionalTamer");
		FixTransactionalTamer_ParamsSize = NativeReflection.GetFunctionParamsSize(FixTransactionalTamer_FunctionAddress);
		FixTransactionalTamer_WorldContext_Offset = NativeReflection.GetPropertyOffset(FixTransactionalTamer_FunctionAddress, "WorldContext");
		FixTransactionalTamer_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(FixTransactionalTamer_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		FixTransactionalTamer_IsValid = FixTransactionalTamer_FunctionAddress != IntPtr.Zero && FixTransactionalTamer_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:FixTransactionalTamer", FixTransactionalTamer_IsValid);
		CreateTamerFromBPPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateTamerFromBPPath");
		CreateTamerFromBPPath_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTamerFromBPPath_FunctionAddress);
		CreateTamerFromBPPath_WorldContext_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromBPPath_FunctionAddress, "WorldContext");
		CreateTamerFromBPPath_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromBPPath_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CreateTamerFromBPPath_BPPath_PropertyAddress, CreateTamerFromBPPath_FunctionAddress, "BPPath");
		CreateTamerFromBPPath_BPPath_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromBPPath_FunctionAddress, "BPPath");
		CreateTamerFromBPPath_BPPath_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromBPPath_FunctionAddress, "BPPath", Classes.FStrProperty);
		CreateTamerFromBPPath_TamerObject_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromBPPath_FunctionAddress, "TamerObject");
		CreateTamerFromBPPath_TamerObject_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromBPPath_FunctionAddress, "TamerObject", Classes.FObjectProperty);
		CreateTamerFromBPPath_TamerClass_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromBPPath_FunctionAddress, "TamerClass");
		CreateTamerFromBPPath_TamerClass_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromBPPath_FunctionAddress, "TamerClass", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CreateTamerFromBPPath_ReturnValue_PropertyAddress, CreateTamerFromBPPath_FunctionAddress, "ReturnValue");
		CreateTamerFromBPPath_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromBPPath_FunctionAddress, "ReturnValue");
		CreateTamerFromBPPath_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromBPPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CreateTamerFromBPPath_IsValid = CreateTamerFromBPPath_FunctionAddress != IntPtr.Zero && CreateTamerFromBPPath_WorldContext_IsValid && CreateTamerFromBPPath_BPPath_IsValid && CreateTamerFromBPPath_TamerObject_IsValid && CreateTamerFromBPPath_TamerClass_IsValid && CreateTamerFromBPPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:CreateTamerFromBPPath", CreateTamerFromBPPath_IsValid);
		CreateTamerFromUnitClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateTamerFromUnitClass");
		CreateTamerFromUnitClass_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTamerFromUnitClass_FunctionAddress);
		CreateTamerFromUnitClass_WorldContext_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromUnitClass_FunctionAddress, "WorldContext");
		CreateTamerFromUnitClass_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromUnitClass_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		CreateTamerFromUnitClass_UnitClass_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromUnitClass_FunctionAddress, "UnitClass");
		CreateTamerFromUnitClass_UnitClass_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromUnitClass_FunctionAddress, "UnitClass", Classes.FObjectProperty);
		CreateTamerFromUnitClass_TamerObject_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromUnitClass_FunctionAddress, "TamerObject");
		CreateTamerFromUnitClass_TamerObject_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromUnitClass_FunctionAddress, "TamerObject", Classes.FObjectProperty);
		CreateTamerFromUnitClass_TamerClass_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromUnitClass_FunctionAddress, "TamerClass");
		CreateTamerFromUnitClass_TamerClass_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromUnitClass_FunctionAddress, "TamerClass", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CreateTamerFromUnitClass_ReturnValue_PropertyAddress, CreateTamerFromUnitClass_FunctionAddress, "ReturnValue");
		CreateTamerFromUnitClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CreateTamerFromUnitClass_FunctionAddress, "ReturnValue");
		CreateTamerFromUnitClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CreateTamerFromUnitClass_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CreateTamerFromUnitClass_IsValid = CreateTamerFromUnitClass_FunctionAddress != IntPtr.Zero && CreateTamerFromUnitClass_WorldContext_IsValid && CreateTamerFromUnitClass_UnitClass_IsValid && CreateTamerFromUnitClass_TamerObject_IsValid && CreateTamerFromUnitClass_TamerClass_IsValid && CreateTamerFromUnitClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:CreateTamerFromUnitClass", CreateTamerFromUnitClass_IsValid);
		RegGSGridConScreenAdapter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RegGSGridConScreenAdapter");
		RegGSGridConScreenAdapter_ParamsSize = NativeReflection.GetFunctionParamsSize(RegGSGridConScreenAdapter_FunctionAddress);
		RegGSGridConScreenAdapter_WorldContext_Offset = NativeReflection.GetPropertyOffset(RegGSGridConScreenAdapter_FunctionAddress, "WorldContext");
		RegGSGridConScreenAdapter_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(RegGSGridConScreenAdapter_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		RegGSGridConScreenAdapter_RefGSGridConScreenAdapter_Offset = NativeReflection.GetPropertyOffset(RegGSGridConScreenAdapter_FunctionAddress, "RefGSGridConScreenAdapter");
		RegGSGridConScreenAdapter_RefGSGridConScreenAdapter_IsValid = NativeReflection.ValidatePropertyClass(RegGSGridConScreenAdapter_FunctionAddress, "RefGSGridConScreenAdapter", Classes.FObjectProperty);
		RegGSGridConScreenAdapter_IsValid = RegGSGridConScreenAdapter_FunctionAddress != IntPtr.Zero && RegGSGridConScreenAdapter_WorldContext_IsValid && RegGSGridConScreenAdapter_RefGSGridConScreenAdapter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:RegGSGridConScreenAdapter", RegGSGridConScreenAdapter_IsValid);
		BGUChangeChapterLightBase_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUChangeChapterLightBase");
		BGUChangeChapterLightBase_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUChangeChapterLightBase_FunctionAddress);
		BGUChangeChapterLightBase_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUChangeChapterLightBase_FunctionAddress, "WorldContext");
		BGUChangeChapterLightBase_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUChangeChapterLightBase_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		BGUChangeChapterLightBase_LightBase_Offset = NativeReflection.GetPropertyOffset(BGUChangeChapterLightBase_FunctionAddress, "LightBase");
		BGUChangeChapterLightBase_LightBase_IsValid = NativeReflection.ValidatePropertyClass(BGUChangeChapterLightBase_FunctionAddress, "LightBase", Classes.FFloatProperty);
		BGUChangeChapterLightBase_IsValid = BGUChangeChapterLightBase_FunctionAddress != IntPtr.Zero && BGUChangeChapterLightBase_WorldContext_IsValid && BGUChangeChapterLightBase_LightBase_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:BGUChangeChapterLightBase", BGUChangeChapterLightBase_IsValid);
		IsAnyStoryNodeHasGainItem_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsAnyStoryNodeHasGainItem");
		IsAnyStoryNodeHasGainItem_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnyStoryNodeHasGainItem_FunctionAddress);
		IsAnyStoryNodeHasGainItem_InAsset_Offset = NativeReflection.GetPropertyOffset(IsAnyStoryNodeHasGainItem_FunctionAddress, "InAsset");
		IsAnyStoryNodeHasGainItem_InAsset_IsValid = NativeReflection.ValidatePropertyClass(IsAnyStoryNodeHasGainItem_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsAnyStoryNodeHasGainItem_ReturnValue_PropertyAddress, IsAnyStoryNodeHasGainItem_FunctionAddress, "ReturnValue");
		IsAnyStoryNodeHasGainItem_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsAnyStoryNodeHasGainItem_FunctionAddress, "ReturnValue");
		IsAnyStoryNodeHasGainItem_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsAnyStoryNodeHasGainItem_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnyStoryNodeHasGainItem_IsValid = IsAnyStoryNodeHasGainItem_FunctionAddress != IntPtr.Zero && IsAnyStoryNodeHasGainItem_InAsset_IsValid && IsAnyStoryNodeHasGainItem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:IsAnyStoryNodeHasGainItem", IsAnyStoryNodeHasGainItem_IsValid);
		UnRegGSGridConScreenAdapter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UnRegGSGridConScreenAdapter");
		UnRegGSGridConScreenAdapter_ParamsSize = NativeReflection.GetFunctionParamsSize(UnRegGSGridConScreenAdapter_FunctionAddress);
		UnRegGSGridConScreenAdapter_WorldContext_Offset = NativeReflection.GetPropertyOffset(UnRegGSGridConScreenAdapter_FunctionAddress, "WorldContext");
		UnRegGSGridConScreenAdapter_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(UnRegGSGridConScreenAdapter_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		UnRegGSGridConScreenAdapter_RefGSGridConScreenAdapter_Offset = NativeReflection.GetPropertyOffset(UnRegGSGridConScreenAdapter_FunctionAddress, "RefGSGridConScreenAdapter");
		UnRegGSGridConScreenAdapter_RefGSGridConScreenAdapter_IsValid = NativeReflection.ValidatePropertyClass(UnRegGSGridConScreenAdapter_FunctionAddress, "RefGSGridConScreenAdapter", Classes.FObjectProperty);
		UnRegGSGridConScreenAdapter_IsValid = UnRegGSGridConScreenAdapter_FunctionAddress != IntPtr.Zero && UnRegGSGridConScreenAdapter_WorldContext_IsValid && UnRegGSGridConScreenAdapter_RefGSGridConScreenAdapter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:UnRegGSGridConScreenAdapter", UnRegGSGridConScreenAdapter_IsValid);
		ConvertToTamerPathFromBPPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ConvertToTamerPathFromBPPath");
		ConvertToTamerPathFromBPPath_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToTamerPathFromBPPath_FunctionAddress);
		ConvertToTamerPathFromBPPath_WorldContext_Offset = NativeReflection.GetPropertyOffset(ConvertToTamerPathFromBPPath_FunctionAddress, "WorldContext");
		ConvertToTamerPathFromBPPath_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(ConvertToTamerPathFromBPPath_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ConvertToTamerPathFromBPPath_BPPath_PropertyAddress, ConvertToTamerPathFromBPPath_FunctionAddress, "BPPath");
		ConvertToTamerPathFromBPPath_BPPath_Offset = NativeReflection.GetPropertyOffset(ConvertToTamerPathFromBPPath_FunctionAddress, "BPPath");
		ConvertToTamerPathFromBPPath_BPPath_IsValid = NativeReflection.ValidatePropertyClass(ConvertToTamerPathFromBPPath_FunctionAddress, "BPPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ConvertToTamerPathFromBPPath_ReturnValue_PropertyAddress, ConvertToTamerPathFromBPPath_FunctionAddress, "ReturnValue");
		ConvertToTamerPathFromBPPath_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ConvertToTamerPathFromBPPath_FunctionAddress, "ReturnValue");
		ConvertToTamerPathFromBPPath_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ConvertToTamerPathFromBPPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ConvertToTamerPathFromBPPath_IsValid = ConvertToTamerPathFromBPPath_FunctionAddress != IntPtr.Zero && ConvertToTamerPathFromBPPath_WorldContext_IsValid && ConvertToTamerPathFromBPPath_BPPath_IsValid && ConvertToTamerPathFromBPPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:ConvertToTamerPathFromBPPath", ConvertToTamerPathFromBPPath_IsValid);
		BatchReplaceMapUnitWithTamer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BatchReplaceMapUnitWithTamer");
		BatchReplaceMapUnitWithTamer_ParamsSize = NativeReflection.GetFunctionParamsSize(BatchReplaceMapUnitWithTamer_FunctionAddress);
		BatchReplaceMapUnitWithTamer_WorldContext_Offset = NativeReflection.GetPropertyOffset(BatchReplaceMapUnitWithTamer_FunctionAddress, "WorldContext");
		BatchReplaceMapUnitWithTamer_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BatchReplaceMapUnitWithTamer_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		BatchReplaceMapUnitWithTamer_IsValid = BatchReplaceMapUnitWithTamer_FunctionAddress != IntPtr.Zero && BatchReplaceMapUnitWithTamer_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:BatchReplaceMapUnitWithTamer", BatchReplaceMapUnitWithTamer_IsValid);
		AutoGenTamerFromUnitBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AutoGenTamerFromUnitBlueprint");
		AutoGenTamerFromUnitBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(AutoGenTamerFromUnitBlueprint_FunctionAddress);
		AutoGenTamerFromUnitBlueprint_WorldContext_Offset = NativeReflection.GetPropertyOffset(AutoGenTamerFromUnitBlueprint_FunctionAddress, "WorldContext");
		AutoGenTamerFromUnitBlueprint_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(AutoGenTamerFromUnitBlueprint_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AutoGenTamerFromUnitBlueprint_Folder_PropertyAddress, AutoGenTamerFromUnitBlueprint_FunctionAddress, "Folder");
		AutoGenTamerFromUnitBlueprint_Folder_Offset = NativeReflection.GetPropertyOffset(AutoGenTamerFromUnitBlueprint_FunctionAddress, "Folder");
		AutoGenTamerFromUnitBlueprint_Folder_IsValid = NativeReflection.ValidatePropertyClass(AutoGenTamerFromUnitBlueprint_FunctionAddress, "Folder", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref AutoGenTamerFromUnitBlueprint_bRecursive_PropertyAddress, AutoGenTamerFromUnitBlueprint_FunctionAddress, "bRecursive");
		AutoGenTamerFromUnitBlueprint_bRecursive_Offset = NativeReflection.GetPropertyOffset(AutoGenTamerFromUnitBlueprint_FunctionAddress, "bRecursive");
		AutoGenTamerFromUnitBlueprint_bRecursive_IsValid = NativeReflection.ValidatePropertyClass(AutoGenTamerFromUnitBlueprint_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		AutoGenTamerFromUnitBlueprint_IsValid = AutoGenTamerFromUnitBlueprint_FunctionAddress != IntPtr.Zero && AutoGenTamerFromUnitBlueprint_WorldContext_IsValid && AutoGenTamerFromUnitBlueprint_Folder_IsValid && AutoGenTamerFromUnitBlueprint_bRecursive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:AutoGenTamerFromUnitBlueprint", AutoGenTamerFromUnitBlueprint_IsValid);
		SetShaderPipelineCacheEnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetShaderPipelineCacheEnabled");
		SetShaderPipelineCacheEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShaderPipelineCacheEnabled_FunctionAddress);
		SetShaderPipelineCacheEnabled_WorldContext_Offset = NativeReflection.GetPropertyOffset(SetShaderPipelineCacheEnabled_FunctionAddress, "WorldContext");
		SetShaderPipelineCacheEnabled_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(SetShaderPipelineCacheEnabled_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SetShaderPipelineCacheEnabled_IsEnable_PropertyAddress, SetShaderPipelineCacheEnabled_FunctionAddress, "IsEnable");
		SetShaderPipelineCacheEnabled_IsEnable_Offset = NativeReflection.GetPropertyOffset(SetShaderPipelineCacheEnabled_FunctionAddress, "IsEnable");
		SetShaderPipelineCacheEnabled_IsEnable_IsValid = NativeReflection.ValidatePropertyClass(SetShaderPipelineCacheEnabled_FunctionAddress, "IsEnable", Classes.FBoolProperty);
		SetShaderPipelineCacheEnabled_TargetPlayerController_Offset = NativeReflection.GetPropertyOffset(SetShaderPipelineCacheEnabled_FunctionAddress, "TargetPlayerController");
		SetShaderPipelineCacheEnabled_TargetPlayerController_IsValid = NativeReflection.ValidatePropertyClass(SetShaderPipelineCacheEnabled_FunctionAddress, "TargetPlayerController", Classes.FObjectProperty);
		SetShaderPipelineCacheEnabled_IsValid = SetShaderPipelineCacheEnabled_FunctionAddress != IntPtr.Zero && SetShaderPipelineCacheEnabled_WorldContext_IsValid && SetShaderPipelineCacheEnabled_IsEnable_IsValid && SetShaderPipelineCacheEnabled_TargetPlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:SetShaderPipelineCacheEnabled", SetShaderPipelineCacheEnabled_IsValid);
		IsContainNonexistentTaskStage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsContainNonexistentTaskStage");
		IsContainNonexistentTaskStage_ParamsSize = NativeReflection.GetFunctionParamsSize(IsContainNonexistentTaskStage_FunctionAddress);
		IsContainNonexistentTaskStage_InAsset_Offset = NativeReflection.GetPropertyOffset(IsContainNonexistentTaskStage_FunctionAddress, "InAsset");
		IsContainNonexistentTaskStage_InAsset_IsValid = NativeReflection.ValidatePropertyClass(IsContainNonexistentTaskStage_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsContainNonexistentTaskStage_ReturnValue_PropertyAddress, IsContainNonexistentTaskStage_FunctionAddress, "ReturnValue");
		IsContainNonexistentTaskStage_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsContainNonexistentTaskStage_FunctionAddress, "ReturnValue");
		IsContainNonexistentTaskStage_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsContainNonexistentTaskStage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsContainNonexistentTaskStage_IsValid = IsContainNonexistentTaskStage_FunctionAddress != IntPtr.Zero && IsContainNonexistentTaskStage_InAsset_IsValid && IsContainNonexistentTaskStage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:IsContainNonexistentTaskStage", IsContainNonexistentTaskStage_IsValid);
		BatchReplaceMapSpawnerWithTamer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BatchReplaceMapSpawnerWithTamer");
		BatchReplaceMapSpawnerWithTamer_ParamsSize = NativeReflection.GetFunctionParamsSize(BatchReplaceMapSpawnerWithTamer_FunctionAddress);
		BatchReplaceMapSpawnerWithTamer_WorldContext_Offset = NativeReflection.GetPropertyOffset(BatchReplaceMapSpawnerWithTamer_FunctionAddress, "WorldContext");
		BatchReplaceMapSpawnerWithTamer_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BatchReplaceMapSpawnerWithTamer_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		BatchReplaceMapSpawnerWithTamer_IsValid = BatchReplaceMapSpawnerWithTamer_FunctionAddress != IntPtr.Zero && BatchReplaceMapSpawnerWithTamer_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:BatchReplaceMapSpawnerWithTamer", BatchReplaceMapSpawnerWithTamer_IsValid);
		FixFontForPIEPreviewInEditorDebug_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FixFontForPIEPreviewInEditorDebug");
		FixFontForPIEPreviewInEditorDebug_ParamsSize = NativeReflection.GetFunctionParamsSize(FixFontForPIEPreviewInEditorDebug_FunctionAddress);
		FixFontForPIEPreviewInEditorDebug_TargetWidget_Offset = NativeReflection.GetPropertyOffset(FixFontForPIEPreviewInEditorDebug_FunctionAddress, "TargetWidget");
		FixFontForPIEPreviewInEditorDebug_TargetWidget_IsValid = NativeReflection.ValidatePropertyClass(FixFontForPIEPreviewInEditorDebug_FunctionAddress, "TargetWidget", Classes.FObjectProperty);
		FixFontForPIEPreviewInEditorDebug_IsValid = FixFontForPIEPreviewInEditorDebug_FunctionAddress != IntPtr.Zero && FixFontForPIEPreviewInEditorDebug_TargetWidget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryManaged:FixFontForPIEPreviewInEditorDebug", FixFontForPIEPreviewInEditorDebug_IsValid);
	}

	static BGUFunctionLibraryManaged()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFunctionLibraryManaged)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFunctionLibraryManaged));
	}
}
