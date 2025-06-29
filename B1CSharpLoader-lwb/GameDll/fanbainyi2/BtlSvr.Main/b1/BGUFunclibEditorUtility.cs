using System;
using System.Collections.Generic;
using System.IO;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility")]
public class BGUFunclibEditorUtility : UBlueprintFunctionLibrary
{
	private static bool PrintStringsToCSV_IsValid;

	private static IntPtr PrintStringsToCSV_FunctionAddress;

	private static int PrintStringsToCSV_ParamsSize;

	private static bool PrintStringsToCSV_Infos_IsValid;

	private static int PrintStringsToCSV_Infos_Offset;

	private static FFieldAddress PrintStringsToCSV_Infos_PropertyAddress;

	private static bool PrintStringsToCSV_CSVPath_IsValid;

	private static int PrintStringsToCSV_CSVPath_Offset;

	private static FFieldAddress PrintStringsToCSV_CSVPath_PropertyAddress;

	private static bool GetSkillIDByAMPath_IsValid;

	private static IntPtr GetSkillIDByAMPath_FunctionAddress;

	private static int GetSkillIDByAMPath_ParamsSize;

	private static bool GetSkillIDByAMPath_AMPath_IsValid;

	private static int GetSkillIDByAMPath_AMPath_Offset;

	private static FFieldAddress GetSkillIDByAMPath_AMPath_PropertyAddress;

	private static bool GetSkillIDByAMPath_ReturnValue_IsValid;

	private static int GetSkillIDByAMPath_ReturnValue_Offset;

	private static FFieldAddress GetSkillIDByAMPath_ReturnValue_PropertyAddress;

	private static bool GetAMPathBySkillID_IsValid;

	private static IntPtr GetAMPathBySkillID_FunctionAddress;

	private static int GetAMPathBySkillID_ParamsSize;

	private static bool GetAMPathBySkillID_SkillID_IsValid;

	private static int GetAMPathBySkillID_SkillID_Offset;

	private static bool GetAMPathBySkillID_ReturnValue_IsValid;

	private static int GetAMPathBySkillID_ReturnValue_Offset;

	private static FFieldAddress GetAMPathBySkillID_ReturnValue_PropertyAddress;

	private static bool SwitchDebugWidgetState_IsValid;

	private static IntPtr SwitchDebugWidgetState_FunctionAddress;

	private static int SwitchDebugWidgetState_ParamsSize;

	private static bool SwitchDebugWidgetState_Actor_IsValid;

	private static int SwitchDebugWidgetState_Actor_Offset;

	private static bool GetAllSkeletalActorInLevel_IsValid;

	private static IntPtr GetAllSkeletalActorInLevel_FunctionAddress;

	private static int GetAllSkeletalActorInLevel_ParamsSize;

	private static bool GetAllSkeletalActorInLevel_Level_IsValid;

	private static int GetAllSkeletalActorInLevel_Level_Offset;

	private static bool GetAllSkeletalActorInLevel_ReturnValue_IsValid;

	private static int GetAllSkeletalActorInLevel_ReturnValue_Offset;

	private static FFieldAddress GetAllSkeletalActorInLevel_ReturnValue_PropertyAddress;

	private static bool CheckIsActorInactiveManaged_IsValid;

	private static IntPtr CheckIsActorInactiveManaged_FunctionAddress;

	private static int CheckIsActorInactiveManaged_ParamsSize;

	private static bool CheckIsActorInactiveManaged_Actor_IsValid;

	private static int CheckIsActorInactiveManaged_Actor_Offset;

	private static bool CheckIsActorInactiveManaged_ReturnValue_IsValid;

	private static int CheckIsActorInactiveManaged_ReturnValue_Offset;

	private static FFieldAddress CheckIsActorInactiveManaged_ReturnValue_PropertyAddress;

	private static bool PrintSkeletalMeshPerfInfoCSV_IsValid;

	private static IntPtr PrintSkeletalMeshPerfInfoCSV_FunctionAddress;

	private static int PrintSkeletalMeshPerfInfoCSV_ParamsSize;

	private static bool PrintSkeletalMeshPerfInfoCSV_LevelSkeletalMeshInfo_IsValid;

	private static int PrintSkeletalMeshPerfInfoCSV_LevelSkeletalMeshInfo_Offset;

	private static FFieldAddress PrintSkeletalMeshPerfInfoCSV_LevelSkeletalMeshInfo_PropertyAddress;

	private static bool PrintSkeletalMeshPerfInfoCSV_CSVPath_IsValid;

	private static int PrintSkeletalMeshPerfInfoCSV_CSVPath_Offset;

	private static FFieldAddress PrintSkeletalMeshPerfInfoCSV_CSVPath_PropertyAddress;

	private static bool SetupSkeletalActorInactiveInfo_IsValid;

	private static IntPtr SetupSkeletalActorInactiveInfo_FunctionAddress;

	private static int SetupSkeletalActorInactiveInfo_ParamsSize;

	private static bool SetupSkeletalActorInactiveInfo_InActor_IsValid;

	private static int SetupSkeletalActorInactiveInfo_InActor_Offset;

	private static bool GetAllSkeletalActorWithoutPerfFromSelected_IsValid;

	private static IntPtr GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress;

	private static int GetAllSkeletalActorWithoutPerfFromSelected_ParamsSize;

	private static bool GetAllSkeletalActorWithoutPerfFromSelected_SelectedLevels_IsValid;

	private static int GetAllSkeletalActorWithoutPerfFromSelected_SelectedLevels_Offset;

	private static FFieldAddress GetAllSkeletalActorWithoutPerfFromSelected_SelectedLevels_PropertyAddress;

	private static bool GetAllSkeletalActorWithoutPerfFromSelected_ReturnValue_IsValid;

	private static int GetAllSkeletalActorWithoutPerfFromSelected_ReturnValue_Offset;

	private static FFieldAddress GetAllSkeletalActorWithoutPerfFromSelected_ReturnValue_PropertyAddress;

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility:GetSkillIDByAMPath")]
	public static List<int> GetSkillIDByAMPath(string AMPath)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStSkillSDesc>();
		Dictionary<int, FUStSkillSDesc> allSkillSDesc = BGW_GameDB.GetAllSkillSDesc();
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, FUStSkillSDesc> item in allSkillSDesc)
		{
			if (item.Value.TemplatePath.Contains(AMPath))
			{
				list.Add(item.Key);
			}
		}
		return list;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility:GetAMPathBySkillID")]
	public static string GetAMPathBySkillID(int SkillID)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStSkillSDesc>();
		foreach (KeyValuePair<int, FUStSkillSDesc> item in BGW_GameDB.GetAllSkillSDesc())
		{
			if (item.Value.ID == SkillID)
			{
				return item.Value.TemplatePath;
			}
		}
		return "";
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility:GetAllSkeletalActorInLevel")]
	public static List<AActor> GetAllSkeletalActorInLevel(ULevel Level)
	{
		List<AActor> allActorsInLevel = UBGUFunctionLibrary.GetAllActorsInLevel(Level);
		List<AActor> list = new List<AActor>();
		foreach (AActor item in allActorsInLevel)
		{
			if (!(item is BUTamerActor) && !(item is ACharacter) && !(item == null) && item.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()).Count > 0)
			{
				list.Add(item);
			}
		}
		return list;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility:GetAllSkeletalActorWithoutPerfFromSelected")]
	public static List<FLevelSkeletalMeshCheckInfoHelper> GetAllSkeletalActorWithoutPerfFromSelected(List<string> SelectedLevels)
	{
		List<FLevelSkeletalMeshCheckInfoHelper> list = new List<FLevelSkeletalMeshCheckInfoHelper>();
		foreach (ULevel level in UGSEditorLevelLibrary.GetLevels(UGSE_EditorFuncLib.GetCurrentEditingWorld()))
		{
			string pathName = UBGUFunctionLibraryForCS.BGUGetUWorld(level).GetPathName();
			if (!SelectedLevels.Contains(pathName))
			{
				continue;
			}
			FLevelSkeletalMeshCheckInfoHelper item = new FLevelSkeletalMeshCheckInfoHelper
			{
				LevelPath = pathName,
				ActorWithoutPerfInfos = new List<FLevelSkeletalMeshCheckActorInfoHelper>()
			};
			foreach (AActor item2 in GetAllSkeletalActorInLevel(level))
			{
				if (!CheckIsActorInactiveManaged(item2))
				{
					item.ActorWithoutPerfInfos.Add(new FLevelSkeletalMeshCheckActorInfoHelper
					{
						ActorLabel = item2.GetActorLabel(),
						Path = item2.GetPathName()
					});
				}
			}
			list.Add(item);
		}
		return list;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility:PrintSkeletalMeshPerfInfoCSV")]
	public static void PrintSkeletalMeshPerfInfoCSV(List<FLevelSkeletalMeshCheckInfoHelper> LevelSkeletalMeshInfo, string CSVPath)
	{
		FileStream fileStream = new FileStream(CSVPath, FileMode.Create);
		StreamWriter streamWriter = new StreamWriter(fileStream);
		foreach (FLevelSkeletalMeshCheckInfoHelper item in LevelSkeletalMeshInfo)
		{
			if (item.ActorWithoutPerfInfos == null || item.ActorWithoutPerfInfos.Count == 0)
			{
				continue;
			}
			streamWriter.Write("Level:, " + item.LevelPath + " \n");
			streamWriter.Write("Actor, PathName \n");
			foreach (FLevelSkeletalMeshCheckActorInfoHelper actorWithoutPerfInfo in item.ActorWithoutPerfInfos)
			{
				streamWriter.Write(actorWithoutPerfInfo.ActorLabel + ", " + actorWithoutPerfInfo.Path + " \n");
			}
			streamWriter.Write("\n\n\n");
		}
		streamWriter.Flush();
		streamWriter.Close();
		fileStream.Close();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility:PrintStringsToCSV")]
	public static void PrintStringsToCSV(List<string> Infos, string CSVPath)
	{
		FileStream fileStream = new FileStream(CSVPath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
		StreamWriter streamWriter = new StreamWriter(fileStream);
		foreach (string Info in Infos)
		{
			streamWriter.WriteLine(Info);
		}
		streamWriter.Flush();
		streamWriter.Close();
		fileStream.Close();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility:CheckIsActorInactiveManaged")]
	public static bool CheckIsActorInactiveManaged(AActor Actor)
	{
		return Actor.GetComponentsByClass(UClass.GetClass<BUS_SceneInactiveActorComp>()).Count > 0;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility:SetupSkeletalActorInactiveInfo")]
	public static void SetupSkeletalActorInactiveInfo(AActor InActor)
	{
		if (InActor == null)
		{
			return;
		}
		foreach (UActorComponent item in InActor.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
			if (!uSkeletalMeshComponent.ComponentHasTag(B1GlobalFNames.PhysicsComp))
			{
				uSkeletalMeshComponent.ComponentTags.Add(B1GlobalFNames.PhysicsComp);
			}
		}
		BUS_SceneInactiveActorComp bUS_SceneInactiveActorComp = InActor.GetComponentByClass<BUS_SceneInactiveActorComp>();
		if (bUS_SceneInactiveActorComp == null)
		{
			bUS_SceneInactiveActorComp = UGSE_ActorFuncLib.AddComponentByClass(InActor, UClass.GetClass<BUS_SceneInactiveActorComp>(), bManualAttachment: false, FTransform.Default, bDeferredFinish: false) as BUS_SceneInactiveActorComp;
			UBGUFunctionLibrary.BGURenameActorComponent(bUS_SceneInactiveActorComp, "BUS_SceneInactiveActorComp");
			UBGUFunctionLibrary.SerializeActorComponentToLevelActor(InActor, bUS_SceneInactiveActorComp);
		}
		if (bUS_SceneInactiveActorComp.GetSceneActorActivationInfo().FindIndex((FGSSceneActorActivationInfo r) => r.SceneActorActivationType == EGSSceneActorActivationType.TickEnable) < 0)
		{
			bUS_SceneInactiveActorComp.TryAddActivationInfo(new FGSSceneActorActivationInfo
			{
				SceneActorActivationType = EGSSceneActorActivationType.TickEnable,
				ActivateDistance = 5000f,
				Tag = B1GlobalFNames.PhysicsComp
			});
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunclibEditorUtility:SwitchDebugWidgetState")]
	public static void SwitchDebugWidgetState(AActor Actor)
	{
		BUS_EventCollectionCS.Get(Actor)?.Evt_SwitchDebugWidgetState.Invoke();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunclibEditorUtility:PrintStringsToCSV")]
	private static void PrintStringsToCSV__Invoker(IntPtr buffer, IntPtr obj)
	{
		List<string> infos = new TArrayCopyMarshaler<string>(1, PrintStringsToCSV_Infos_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(buffer, PrintStringsToCSV_Infos_Offset));
		string cSVPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, PrintStringsToCSV_CSVPath_Offset));
		PrintStringsToCSV(infos, cSVPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunclibEditorUtility:GetSkillIDByAMPath")]
	private static void GetSkillIDByAMPath__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<int> tArrayCopyMarshaler = new TArrayCopyMarshaler<int>(1, GetSkillIDByAMPath_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
		string aMPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetSkillIDByAMPath_AMPath_Offset));
		List<int> skillIDByAMPath = GetSkillIDByAMPath(aMPath);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSkillIDByAMPath_ReturnValue_Offset), skillIDByAMPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunclibEditorUtility:GetAMPathBySkillID")]
	private static void GetAMPathBySkillID__Invoker(IntPtr buffer, IntPtr obj)
	{
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, GetAMPathBySkillID_SkillID_Offset));
		string aMPathBySkillID = GetAMPathBySkillID(skillID);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetAMPathBySkillID_ReturnValue_Offset), aMPathBySkillID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunclibEditorUtility:SwitchDebugWidgetState")]
	private static void SwitchDebugWidgetState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SwitchDebugWidgetState_Actor_Offset));
		SwitchDebugWidgetState(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunclibEditorUtility:GetAllSkeletalActorInLevel")]
	private static void GetAllSkeletalActorInLevel__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<AActor> tArrayCopyMarshaler = new TArrayCopyMarshaler<AActor>(1, GetAllSkeletalActorInLevel_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
		ULevel level = UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(buffer, GetAllSkeletalActorInLevel_Level_Offset));
		List<AActor> allSkeletalActorInLevel = GetAllSkeletalActorInLevel(level);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetAllSkeletalActorInLevel_ReturnValue_Offset), allSkeletalActorInLevel);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunclibEditorUtility:CheckIsActorInactiveManaged")]
	private static void CheckIsActorInactiveManaged__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, CheckIsActorInactiveManaged_Actor_Offset));
		bool value = CheckIsActorInactiveManaged(actor);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckIsActorInactiveManaged_ReturnValue_Offset), 0, CheckIsActorInactiveManaged_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunclibEditorUtility:PrintSkeletalMeshPerfInfoCSV")]
	private static void PrintSkeletalMeshPerfInfoCSV__Invoker(IntPtr buffer, IntPtr obj)
	{
		List<FLevelSkeletalMeshCheckInfoHelper> levelSkeletalMeshInfo = new TArrayCopyMarshaler<FLevelSkeletalMeshCheckInfoHelper>(1, PrintSkeletalMeshPerfInfoCSV_LevelSkeletalMeshInfo_PropertyAddress, CachedMarshalingDelegates<FLevelSkeletalMeshCheckInfoHelper, FLevelSkeletalMeshCheckInfoHelper>.FromNative, CachedMarshalingDelegates<FLevelSkeletalMeshCheckInfoHelper, FLevelSkeletalMeshCheckInfoHelper>.ToNative).FromNative(IntPtr.Add(buffer, PrintSkeletalMeshPerfInfoCSV_LevelSkeletalMeshInfo_Offset));
		string cSVPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, PrintSkeletalMeshPerfInfoCSV_CSVPath_Offset));
		PrintSkeletalMeshPerfInfoCSV(levelSkeletalMeshInfo, cSVPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunclibEditorUtility:SetupSkeletalActorInactiveInfo")]
	private static void SetupSkeletalActorInactiveInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor inActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SetupSkeletalActorInactiveInfo_InActor_Offset));
		SetupSkeletalActorInactiveInfo(inActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunclibEditorUtility:GetAllSkeletalActorWithoutPerfFromSelected")]
	private static void GetAllSkeletalActorWithoutPerfFromSelected__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<FLevelSkeletalMeshCheckInfoHelper> tArrayCopyMarshaler = new TArrayCopyMarshaler<FLevelSkeletalMeshCheckInfoHelper>(1, GetAllSkeletalActorWithoutPerfFromSelected_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FLevelSkeletalMeshCheckInfoHelper, FLevelSkeletalMeshCheckInfoHelper>.FromNative, CachedMarshalingDelegates<FLevelSkeletalMeshCheckInfoHelper, FLevelSkeletalMeshCheckInfoHelper>.ToNative);
		List<string> selectedLevels = new TArrayCopyMarshaler<string>(1, GetAllSkeletalActorWithoutPerfFromSelected_SelectedLevels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(buffer, GetAllSkeletalActorWithoutPerfFromSelected_SelectedLevels_Offset));
		List<FLevelSkeletalMeshCheckInfoHelper> allSkeletalActorWithoutPerfFromSelected = GetAllSkeletalActorWithoutPerfFromSelected(selectedLevels);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetAllSkeletalActorWithoutPerfFromSelected_ReturnValue_Offset), allSkeletalActorWithoutPerfFromSelected);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFunclibEditorUtility");
		PrintStringsToCSV_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PrintStringsToCSV");
		PrintStringsToCSV_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintStringsToCSV_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PrintStringsToCSV_Infos_PropertyAddress, PrintStringsToCSV_FunctionAddress, "Infos");
		PrintStringsToCSV_Infos_Offset = NativeReflection.GetPropertyOffset(PrintStringsToCSV_FunctionAddress, "Infos");
		PrintStringsToCSV_Infos_IsValid = NativeReflection.ValidatePropertyClass(PrintStringsToCSV_FunctionAddress, "Infos", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PrintStringsToCSV_CSVPath_PropertyAddress, PrintStringsToCSV_FunctionAddress, "CSVPath");
		PrintStringsToCSV_CSVPath_Offset = NativeReflection.GetPropertyOffset(PrintStringsToCSV_FunctionAddress, "CSVPath");
		PrintStringsToCSV_CSVPath_IsValid = NativeReflection.ValidatePropertyClass(PrintStringsToCSV_FunctionAddress, "CSVPath", Classes.FStrProperty);
		PrintStringsToCSV_IsValid = PrintStringsToCSV_FunctionAddress != IntPtr.Zero && PrintStringsToCSV_Infos_IsValid && PrintStringsToCSV_CSVPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunclibEditorUtility:PrintStringsToCSV", PrintStringsToCSV_IsValid);
		GetSkillIDByAMPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSkillIDByAMPath");
		GetSkillIDByAMPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkillIDByAMPath_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSkillIDByAMPath_AMPath_PropertyAddress, GetSkillIDByAMPath_FunctionAddress, "AMPath");
		GetSkillIDByAMPath_AMPath_Offset = NativeReflection.GetPropertyOffset(GetSkillIDByAMPath_FunctionAddress, "AMPath");
		GetSkillIDByAMPath_AMPath_IsValid = NativeReflection.ValidatePropertyClass(GetSkillIDByAMPath_FunctionAddress, "AMPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetSkillIDByAMPath_ReturnValue_PropertyAddress, GetSkillIDByAMPath_FunctionAddress, "ReturnValue");
		GetSkillIDByAMPath_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSkillIDByAMPath_FunctionAddress, "ReturnValue");
		GetSkillIDByAMPath_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSkillIDByAMPath_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSkillIDByAMPath_IsValid = GetSkillIDByAMPath_FunctionAddress != IntPtr.Zero && GetSkillIDByAMPath_AMPath_IsValid && GetSkillIDByAMPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunclibEditorUtility:GetSkillIDByAMPath", GetSkillIDByAMPath_IsValid);
		GetAMPathBySkillID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAMPathBySkillID");
		GetAMPathBySkillID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAMPathBySkillID_FunctionAddress);
		GetAMPathBySkillID_SkillID_Offset = NativeReflection.GetPropertyOffset(GetAMPathBySkillID_FunctionAddress, "SkillID");
		GetAMPathBySkillID_SkillID_IsValid = NativeReflection.ValidatePropertyClass(GetAMPathBySkillID_FunctionAddress, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref GetAMPathBySkillID_ReturnValue_PropertyAddress, GetAMPathBySkillID_FunctionAddress, "ReturnValue");
		GetAMPathBySkillID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAMPathBySkillID_FunctionAddress, "ReturnValue");
		GetAMPathBySkillID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAMPathBySkillID_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAMPathBySkillID_IsValid = GetAMPathBySkillID_FunctionAddress != IntPtr.Zero && GetAMPathBySkillID_SkillID_IsValid && GetAMPathBySkillID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunclibEditorUtility:GetAMPathBySkillID", GetAMPathBySkillID_IsValid);
		SwitchDebugWidgetState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SwitchDebugWidgetState");
		SwitchDebugWidgetState_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchDebugWidgetState_FunctionAddress);
		SwitchDebugWidgetState_Actor_Offset = NativeReflection.GetPropertyOffset(SwitchDebugWidgetState_FunctionAddress, "Actor");
		SwitchDebugWidgetState_Actor_IsValid = NativeReflection.ValidatePropertyClass(SwitchDebugWidgetState_FunctionAddress, "Actor", Classes.FObjectProperty);
		SwitchDebugWidgetState_IsValid = SwitchDebugWidgetState_FunctionAddress != IntPtr.Zero && SwitchDebugWidgetState_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunclibEditorUtility:SwitchDebugWidgetState", SwitchDebugWidgetState_IsValid);
		GetAllSkeletalActorInLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllSkeletalActorInLevel");
		GetAllSkeletalActorInLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllSkeletalActorInLevel_FunctionAddress);
		GetAllSkeletalActorInLevel_Level_Offset = NativeReflection.GetPropertyOffset(GetAllSkeletalActorInLevel_FunctionAddress, "Level");
		GetAllSkeletalActorInLevel_Level_IsValid = NativeReflection.ValidatePropertyClass(GetAllSkeletalActorInLevel_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetAllSkeletalActorInLevel_ReturnValue_PropertyAddress, GetAllSkeletalActorInLevel_FunctionAddress, "ReturnValue");
		GetAllSkeletalActorInLevel_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAllSkeletalActorInLevel_FunctionAddress, "ReturnValue");
		GetAllSkeletalActorInLevel_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAllSkeletalActorInLevel_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllSkeletalActorInLevel_IsValid = GetAllSkeletalActorInLevel_FunctionAddress != IntPtr.Zero && GetAllSkeletalActorInLevel_Level_IsValid && GetAllSkeletalActorInLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunclibEditorUtility:GetAllSkeletalActorInLevel", GetAllSkeletalActorInLevel_IsValid);
		CheckIsActorInactiveManaged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckIsActorInactiveManaged");
		CheckIsActorInactiveManaged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckIsActorInactiveManaged_FunctionAddress);
		CheckIsActorInactiveManaged_Actor_Offset = NativeReflection.GetPropertyOffset(CheckIsActorInactiveManaged_FunctionAddress, "Actor");
		CheckIsActorInactiveManaged_Actor_IsValid = NativeReflection.ValidatePropertyClass(CheckIsActorInactiveManaged_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CheckIsActorInactiveManaged_ReturnValue_PropertyAddress, CheckIsActorInactiveManaged_FunctionAddress, "ReturnValue");
		CheckIsActorInactiveManaged_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckIsActorInactiveManaged_FunctionAddress, "ReturnValue");
		CheckIsActorInactiveManaged_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckIsActorInactiveManaged_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckIsActorInactiveManaged_IsValid = CheckIsActorInactiveManaged_FunctionAddress != IntPtr.Zero && CheckIsActorInactiveManaged_Actor_IsValid && CheckIsActorInactiveManaged_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunclibEditorUtility:CheckIsActorInactiveManaged", CheckIsActorInactiveManaged_IsValid);
		PrintSkeletalMeshPerfInfoCSV_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PrintSkeletalMeshPerfInfoCSV");
		PrintSkeletalMeshPerfInfoCSV_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintSkeletalMeshPerfInfoCSV_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PrintSkeletalMeshPerfInfoCSV_LevelSkeletalMeshInfo_PropertyAddress, PrintSkeletalMeshPerfInfoCSV_FunctionAddress, "LevelSkeletalMeshInfo");
		PrintSkeletalMeshPerfInfoCSV_LevelSkeletalMeshInfo_Offset = NativeReflection.GetPropertyOffset(PrintSkeletalMeshPerfInfoCSV_FunctionAddress, "LevelSkeletalMeshInfo");
		PrintSkeletalMeshPerfInfoCSV_LevelSkeletalMeshInfo_IsValid = NativeReflection.ValidatePropertyClass(PrintSkeletalMeshPerfInfoCSV_FunctionAddress, "LevelSkeletalMeshInfo", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PrintSkeletalMeshPerfInfoCSV_CSVPath_PropertyAddress, PrintSkeletalMeshPerfInfoCSV_FunctionAddress, "CSVPath");
		PrintSkeletalMeshPerfInfoCSV_CSVPath_Offset = NativeReflection.GetPropertyOffset(PrintSkeletalMeshPerfInfoCSV_FunctionAddress, "CSVPath");
		PrintSkeletalMeshPerfInfoCSV_CSVPath_IsValid = NativeReflection.ValidatePropertyClass(PrintSkeletalMeshPerfInfoCSV_FunctionAddress, "CSVPath", Classes.FStrProperty);
		PrintSkeletalMeshPerfInfoCSV_IsValid = PrintSkeletalMeshPerfInfoCSV_FunctionAddress != IntPtr.Zero && PrintSkeletalMeshPerfInfoCSV_LevelSkeletalMeshInfo_IsValid && PrintSkeletalMeshPerfInfoCSV_CSVPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunclibEditorUtility:PrintSkeletalMeshPerfInfoCSV", PrintSkeletalMeshPerfInfoCSV_IsValid);
		SetupSkeletalActorInactiveInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetupSkeletalActorInactiveInfo");
		SetupSkeletalActorInactiveInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupSkeletalActorInactiveInfo_FunctionAddress);
		SetupSkeletalActorInactiveInfo_InActor_Offset = NativeReflection.GetPropertyOffset(SetupSkeletalActorInactiveInfo_FunctionAddress, "InActor");
		SetupSkeletalActorInactiveInfo_InActor_IsValid = NativeReflection.ValidatePropertyClass(SetupSkeletalActorInactiveInfo_FunctionAddress, "InActor", Classes.FObjectProperty);
		SetupSkeletalActorInactiveInfo_IsValid = SetupSkeletalActorInactiveInfo_FunctionAddress != IntPtr.Zero && SetupSkeletalActorInactiveInfo_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunclibEditorUtility:SetupSkeletalActorInactiveInfo", SetupSkeletalActorInactiveInfo_IsValid);
		GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllSkeletalActorWithoutPerfFromSelected");
		GetAllSkeletalActorWithoutPerfFromSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAllSkeletalActorWithoutPerfFromSelected_SelectedLevels_PropertyAddress, GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress, "SelectedLevels");
		GetAllSkeletalActorWithoutPerfFromSelected_SelectedLevels_Offset = NativeReflection.GetPropertyOffset(GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress, "SelectedLevels");
		GetAllSkeletalActorWithoutPerfFromSelected_SelectedLevels_IsValid = NativeReflection.ValidatePropertyClass(GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress, "SelectedLevels", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref GetAllSkeletalActorWithoutPerfFromSelected_ReturnValue_PropertyAddress, GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress, "ReturnValue");
		GetAllSkeletalActorWithoutPerfFromSelected_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress, "ReturnValue");
		GetAllSkeletalActorWithoutPerfFromSelected_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllSkeletalActorWithoutPerfFromSelected_IsValid = GetAllSkeletalActorWithoutPerfFromSelected_FunctionAddress != IntPtr.Zero && GetAllSkeletalActorWithoutPerfFromSelected_SelectedLevels_IsValid && GetAllSkeletalActorWithoutPerfFromSelected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunclibEditorUtility:GetAllSkeletalActorWithoutPerfFromSelected", GetAllSkeletalActorWithoutPerfFromSelected_IsValid);
	}

	static BGUFunclibEditorUtility()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFunclibEditorUtility)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFunclibEditorUtility));
	}
}
