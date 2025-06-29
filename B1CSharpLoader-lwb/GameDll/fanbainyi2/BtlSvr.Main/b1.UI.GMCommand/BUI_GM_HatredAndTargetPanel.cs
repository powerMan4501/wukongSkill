using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI.GMCommand;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel")]
public class BUI_GM_HatredAndTargetPanel : BUI_Widget
{
	private static bool CleanTargetInfos_IsValid;

	private static IntPtr CleanTargetInfos_FunctionAddress;

	private static int CleanTargetInfos_ParamsSize;

	private static bool GetDebugTargetInfo_IsValid;

	private static IntPtr GetDebugTargetInfo_FunctionAddress;

	private static int GetDebugTargetInfo_ParamsSize;

	private static bool GetDebugTargetInfo_Target_IsValid;

	private static int GetDebugTargetInfo_Target_Offset;

	private static bool GetDebugTargetInfo_ReturnValue_IsValid;

	private static int GetDebugTargetInfo_ReturnValue_Offset;

	private static bool SetNeedShowDebugTargetInfos_IsValid;

	private static IntPtr SetNeedShowDebugTargetInfos_FunctionAddress;

	private static int SetNeedShowDebugTargetInfos_ParamsSize;

	private static bool SetNeedShowDebugTargetInfos_Target_IsValid;

	private static int SetNeedShowDebugTargetInfos_Target_Offset;

	private static bool SetNeedShowDebugTargetInfos_Value_IsValid;

	private static int SetNeedShowDebugTargetInfos_Value_Offset;

	private static bool RefreshInstanceListWithFilterRadius_IsValid;

	private static IntPtr RefreshInstanceListWithFilterRadius_FunctionAddress;

	private static int RefreshInstanceListWithFilterRadius_ParamsSize;

	private static bool RefreshInstanceListWithFilterRadius__FilterRadius_IsValid;

	private static int RefreshInstanceListWithFilterRadius__FilterRadius_Offset;

	private static FFieldAddress RefreshInstanceListWithFilterRadius__FilterRadius_PropertyAddress;

	private static bool RefreshInstanceListWithFilterRadius_Instances_IsValid;

	private static int RefreshInstanceListWithFilterRadius_Instances_Offset;

	private static FFieldAddress RefreshInstanceListWithFilterRadius_Instances_PropertyAddress;

	private static bool RefreshInstanceListWithFilterRadius_Units_IsValid;

	private static int RefreshInstanceListWithFilterRadius_Units_Offset;

	private static FFieldAddress RefreshInstanceListWithFilterRadius_Units_PropertyAddress;

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:SetNeedShowDebugTargetInfos")]
	private void SetNeedShowDebugTargetInfos(AActor Target, int Value)
	{
		BGUCharacterCS bGUCharacterCS = Target as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BGS_EventCollectionCS.Get(this)?.Evt_BGS_SetNeedShowDebugChr.Invoke(bGUCharacterCS, Value);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:CleanTargetInfos")]
	private void CleanTargetInfos()
	{
		BGS_EventCollectionCS.Get(this)?.Evt_BGS_CleanTargetInfos.Invoke();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:GetDebugTargetInfo")]
	private int GetDebugTargetInfo(AActor Target)
	{
		if (Target == null)
		{
			return 0;
		}
		IBGC_DebugTargetMgrData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_DebugTargetMgrData, BGC_DebugTargetMgrData>(this);
		if (gameStateReadonlyData != null && gameStateReadonlyData.DebugTargetInfos.Find((BGUDebugTargetInfo Info) => Info.Self == Target) != null)
		{
			return gameStateReadonlyData.DebugTargetInfos.Find((BGUDebugTargetInfo Info) => Info.Self == Target).Masks;
		}
		return 0;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:RefreshInstanceListWithFilterRadius")]
	private void RefreshInstanceListWithFilterRadius(string _FilterRadius, out List<FName> Instances, out List<AActor> Units)
	{
		Instances = new List<FName>();
		Units = new List<AActor>();
		int.TryParse(_FilterRadius, out var result);
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (!(firstLocalPlayerController != null))
		{
			return;
		}
		FVector actorLocation = firstLocalPlayerController.GetControlledPawn().GetActorLocation();
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(this);
		foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
		{
			if (FVector.Dist(bGUCharacterCS.GetActorLocation(), actorLocation) < (float)result)
			{
				Instances.Add(bGUCharacterCS.GetFName());
				Units.Add(bGUCharacterCS);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:CleanTargetInfos")]
	private static void CleanTargetInfos__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_GM_HatredAndTargetPanel bUI_GM_HatredAndTargetPanel = GCHelper.Find<BUI_GM_HatredAndTargetPanel>(obj);
		bUI_GM_HatredAndTargetPanel.CleanTargetInfos();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:GetDebugTargetInfo")]
	private static void GetDebugTargetInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_GM_HatredAndTargetPanel bUI_GM_HatredAndTargetPanel = GCHelper.Find<BUI_GM_HatredAndTargetPanel>(obj);
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GetDebugTargetInfo_Target_Offset));
		int debugTargetInfo = bUI_GM_HatredAndTargetPanel.GetDebugTargetInfo(target);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetDebugTargetInfo_ReturnValue_Offset), debugTargetInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:SetNeedShowDebugTargetInfos")]
	private static void SetNeedShowDebugTargetInfos__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_GM_HatredAndTargetPanel bUI_GM_HatredAndTargetPanel = GCHelper.Find<BUI_GM_HatredAndTargetPanel>(obj);
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SetNeedShowDebugTargetInfos_Target_Offset));
		int value = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, SetNeedShowDebugTargetInfos_Value_Offset));
		bUI_GM_HatredAndTargetPanel.SetNeedShowDebugTargetInfos(target, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:RefreshInstanceListWithFilterRadius")]
	private static void RefreshInstanceListWithFilterRadius__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_GM_HatredAndTargetPanel bUI_GM_HatredAndTargetPanel = GCHelper.Find<BUI_GM_HatredAndTargetPanel>(obj);
		string filterRadius = FStringMarshaler.FromNative(IntPtr.Add(buffer, RefreshInstanceListWithFilterRadius__FilterRadius_Offset));
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, RefreshInstanceListWithFilterRadius_Instances_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> Instances = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, RefreshInstanceListWithFilterRadius_Instances_Offset));
		TArrayCopyMarshaler<AActor> tArrayCopyMarshaler2 = new TArrayCopyMarshaler<AActor>(1, RefreshInstanceListWithFilterRadius_Units_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
		List<AActor> Units = tArrayCopyMarshaler2.FromNative(IntPtr.Add(buffer, RefreshInstanceListWithFilterRadius_Units_Offset));
		bUI_GM_HatredAndTargetPanel.RefreshInstanceListWithFilterRadius(filterRadius, out Instances, out Units);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, RefreshInstanceListWithFilterRadius_Instances_Offset), Instances);
		tArrayCopyMarshaler2.ToNative(IntPtr.Add(buffer, RefreshInstanceListWithFilterRadius_Units_Offset), Units);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel");
		CleanTargetInfos_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CleanTargetInfos");
		CleanTargetInfos_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanTargetInfos_FunctionAddress);
		CleanTargetInfos_IsValid = CleanTargetInfos_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:CleanTargetInfos", CleanTargetInfos_IsValid);
		GetDebugTargetInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDebugTargetInfo");
		GetDebugTargetInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDebugTargetInfo_FunctionAddress);
		GetDebugTargetInfo_Target_Offset = NativeReflection.GetPropertyOffset(GetDebugTargetInfo_FunctionAddress, "Target");
		GetDebugTargetInfo_Target_IsValid = NativeReflection.ValidatePropertyClass(GetDebugTargetInfo_FunctionAddress, "Target", Classes.FObjectProperty);
		GetDebugTargetInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDebugTargetInfo_FunctionAddress, "ReturnValue");
		GetDebugTargetInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDebugTargetInfo_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetDebugTargetInfo_IsValid = GetDebugTargetInfo_FunctionAddress != IntPtr.Zero && GetDebugTargetInfo_Target_IsValid && GetDebugTargetInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:GetDebugTargetInfo", GetDebugTargetInfo_IsValid);
		SetNeedShowDebugTargetInfos_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNeedShowDebugTargetInfos");
		SetNeedShowDebugTargetInfos_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNeedShowDebugTargetInfos_FunctionAddress);
		SetNeedShowDebugTargetInfos_Target_Offset = NativeReflection.GetPropertyOffset(SetNeedShowDebugTargetInfos_FunctionAddress, "Target");
		SetNeedShowDebugTargetInfos_Target_IsValid = NativeReflection.ValidatePropertyClass(SetNeedShowDebugTargetInfos_FunctionAddress, "Target", Classes.FObjectProperty);
		SetNeedShowDebugTargetInfos_Value_Offset = NativeReflection.GetPropertyOffset(SetNeedShowDebugTargetInfos_FunctionAddress, "Value");
		SetNeedShowDebugTargetInfos_Value_IsValid = NativeReflection.ValidatePropertyClass(SetNeedShowDebugTargetInfos_FunctionAddress, "Value", Classes.FIntProperty);
		SetNeedShowDebugTargetInfos_IsValid = SetNeedShowDebugTargetInfos_FunctionAddress != IntPtr.Zero && SetNeedShowDebugTargetInfos_Target_IsValid && SetNeedShowDebugTargetInfos_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:SetNeedShowDebugTargetInfos", SetNeedShowDebugTargetInfos_IsValid);
		RefreshInstanceListWithFilterRadius_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RefreshInstanceListWithFilterRadius");
		RefreshInstanceListWithFilterRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshInstanceListWithFilterRadius_FunctionAddress);
		NativeReflection.GetPropertyRef(ref RefreshInstanceListWithFilterRadius__FilterRadius_PropertyAddress, RefreshInstanceListWithFilterRadius_FunctionAddress, "_FilterRadius");
		RefreshInstanceListWithFilterRadius__FilterRadius_Offset = NativeReflection.GetPropertyOffset(RefreshInstanceListWithFilterRadius_FunctionAddress, "_FilterRadius");
		RefreshInstanceListWithFilterRadius__FilterRadius_IsValid = NativeReflection.ValidatePropertyClass(RefreshInstanceListWithFilterRadius_FunctionAddress, "_FilterRadius", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref RefreshInstanceListWithFilterRadius_Instances_PropertyAddress, RefreshInstanceListWithFilterRadius_FunctionAddress, "Instances");
		RefreshInstanceListWithFilterRadius_Instances_Offset = NativeReflection.GetPropertyOffset(RefreshInstanceListWithFilterRadius_FunctionAddress, "Instances");
		RefreshInstanceListWithFilterRadius_Instances_IsValid = NativeReflection.ValidatePropertyClass(RefreshInstanceListWithFilterRadius_FunctionAddress, "Instances", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RefreshInstanceListWithFilterRadius_Units_PropertyAddress, RefreshInstanceListWithFilterRadius_FunctionAddress, "Units");
		RefreshInstanceListWithFilterRadius_Units_Offset = NativeReflection.GetPropertyOffset(RefreshInstanceListWithFilterRadius_FunctionAddress, "Units");
		RefreshInstanceListWithFilterRadius_Units_IsValid = NativeReflection.ValidatePropertyClass(RefreshInstanceListWithFilterRadius_FunctionAddress, "Units", Classes.FArrayProperty);
		RefreshInstanceListWithFilterRadius_IsValid = RefreshInstanceListWithFilterRadius_FunctionAddress != IntPtr.Zero && RefreshInstanceListWithFilterRadius__FilterRadius_IsValid && RefreshInstanceListWithFilterRadius_Instances_IsValid && RefreshInstanceListWithFilterRadius_Units_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_HatredAndTargetPanel:RefreshInstanceListWithFilterRadius", RefreshInstanceListWithFilterRadius_IsValid);
	}

	static BUI_GM_HatredAndTargetPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_GM_HatredAndTargetPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_GM_HatredAndTargetPanel));
	}
}
