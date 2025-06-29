using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.UI.GMCommand;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GM_CalliopePanel")]
public class BUI_GM_CalliopePanel : BUI_Widget
{
	private static bool GetInstanceDebugInfo_IsValid;

	private static IntPtr GetInstanceDebugInfo_FunctionAddress;

	private static int GetInstanceDebugInfo_ParamsSize;

	private static bool GetInstanceDebugInfo_InInstanceName_IsValid;

	private static int GetInstanceDebugInfo_InInstanceName_Offset;

	private static bool GetInstanceDebugInfo_ReturnValue_IsValid;

	private static int GetInstanceDebugInfo_ReturnValue_Offset;

	private static FFieldAddress GetInstanceDebugInfo_ReturnValue_PropertyAddress;

	private static bool RefreshInstanceListWithFilter_IsValid;

	private static IntPtr RefreshInstanceListWithFilter_FunctionAddress;

	private static int RefreshInstanceListWithFilter_ParamsSize;

	private static bool RefreshInstanceListWithFilter_InFilterStr_IsValid;

	private static int RefreshInstanceListWithFilter_InFilterStr_Offset;

	private static FFieldAddress RefreshInstanceListWithFilter_InFilterStr_PropertyAddress;

	private static bool RefreshInstanceListWithFilter_Instances_IsValid;

	private static int RefreshInstanceListWithFilter_Instances_Offset;

	private static FFieldAddress RefreshInstanceListWithFilter_Instances_PropertyAddress;

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GM_CalliopePanel:RefreshInstanceListWithFilter")]
	public void RefreshInstanceListWithFilter(string InFilterStr, out List<FName> Instances)
	{
		Instances = new List<FName>();
		BGW_CalliopeDebugManager bGW_CalliopeDebugManager = BGW_CalliopeDebugManager.Get(this);
		if (!(bGW_CalliopeDebugManager != null) || bGW_CalliopeDebugManager.GetActiveCalliopeInstances(out var OutInstanceNames) <= 0)
		{
			return;
		}
		InFilterStr = InFilterStr.Trim().ToLower();
		string[] array = InFilterStr.Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
		foreach (FName item in OutInstanceNames)
		{
			string plainName = item.PlainName;
			if (string.IsNullOrEmpty(InFilterStr))
			{
				Instances.Add(item);
				continue;
			}
			plainName = plainName.ToLower();
			string[] array2 = array;
			foreach (string value in array2)
			{
				if (plainName.Contains(value))
				{
					Instances.Add(item);
					break;
				}
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GM_CalliopePanel:GetInstanceDebugInfo")]
	public string GetInstanceDebugInfo(FName InInstanceName)
	{
		BGW_CalliopeDebugManager bGW_CalliopeDebugManager = BGW_CalliopeDebugManager.Get(this);
		if (bGW_CalliopeDebugManager != null)
		{
			bGW_CalliopeDebugManager.GetAssetCurrentNodeDebugInfo(InInstanceName, out var DebugInfoStringBuilder);
			return DebugInfoStringBuilder.ToString();
		}
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_CalliopePanel:GetInstanceDebugInfo")]
	private static void GetInstanceDebugInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_GM_CalliopePanel bUI_GM_CalliopePanel = GCHelper.Find<BUI_GM_CalliopePanel>(obj);
		FName inInstanceName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, GetInstanceDebugInfo_InInstanceName_Offset));
		string instanceDebugInfo = bUI_GM_CalliopePanel.GetInstanceDebugInfo(inInstanceName);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetInstanceDebugInfo_ReturnValue_Offset), instanceDebugInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_CalliopePanel:RefreshInstanceListWithFilter")]
	private static void RefreshInstanceListWithFilter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_GM_CalliopePanel bUI_GM_CalliopePanel = GCHelper.Find<BUI_GM_CalliopePanel>(obj);
		string inFilterStr = FStringMarshaler.FromNative(IntPtr.Add(buffer, RefreshInstanceListWithFilter_InFilterStr_Offset));
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, RefreshInstanceListWithFilter_Instances_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> Instances = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, RefreshInstanceListWithFilter_Instances_Offset));
		bUI_GM_CalliopePanel.RefreshInstanceListWithFilter(inFilterStr, out Instances);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, RefreshInstanceListWithFilter_Instances_Offset), Instances);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_GM_CalliopePanel");
		GetInstanceDebugInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInstanceDebugInfo");
		GetInstanceDebugInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstanceDebugInfo_FunctionAddress);
		GetInstanceDebugInfo_InInstanceName_Offset = NativeReflection.GetPropertyOffset(GetInstanceDebugInfo_FunctionAddress, "InInstanceName");
		GetInstanceDebugInfo_InInstanceName_IsValid = NativeReflection.ValidatePropertyClass(GetInstanceDebugInfo_FunctionAddress, "InInstanceName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref GetInstanceDebugInfo_ReturnValue_PropertyAddress, GetInstanceDebugInfo_FunctionAddress, "ReturnValue");
		GetInstanceDebugInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetInstanceDebugInfo_FunctionAddress, "ReturnValue");
		GetInstanceDebugInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetInstanceDebugInfo_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetInstanceDebugInfo_IsValid = GetInstanceDebugInfo_FunctionAddress != IntPtr.Zero && GetInstanceDebugInfo_InInstanceName_IsValid && GetInstanceDebugInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_CalliopePanel:GetInstanceDebugInfo", GetInstanceDebugInfo_IsValid);
		RefreshInstanceListWithFilter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RefreshInstanceListWithFilter");
		RefreshInstanceListWithFilter_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshInstanceListWithFilter_FunctionAddress);
		NativeReflection.GetPropertyRef(ref RefreshInstanceListWithFilter_InFilterStr_PropertyAddress, RefreshInstanceListWithFilter_FunctionAddress, "InFilterStr");
		RefreshInstanceListWithFilter_InFilterStr_Offset = NativeReflection.GetPropertyOffset(RefreshInstanceListWithFilter_FunctionAddress, "InFilterStr");
		RefreshInstanceListWithFilter_InFilterStr_IsValid = NativeReflection.ValidatePropertyClass(RefreshInstanceListWithFilter_FunctionAddress, "InFilterStr", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref RefreshInstanceListWithFilter_Instances_PropertyAddress, RefreshInstanceListWithFilter_FunctionAddress, "Instances");
		RefreshInstanceListWithFilter_Instances_Offset = NativeReflection.GetPropertyOffset(RefreshInstanceListWithFilter_FunctionAddress, "Instances");
		RefreshInstanceListWithFilter_Instances_IsValid = NativeReflection.ValidatePropertyClass(RefreshInstanceListWithFilter_FunctionAddress, "Instances", Classes.FArrayProperty);
		RefreshInstanceListWithFilter_IsValid = RefreshInstanceListWithFilter_FunctionAddress != IntPtr.Zero && RefreshInstanceListWithFilter_InFilterStr_IsValid && RefreshInstanceListWithFilter_Instances_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_CalliopePanel:RefreshInstanceListWithFilter", RefreshInstanceListWithFilter_IsValid);
	}

	static BUI_GM_CalliopePanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_GM_CalliopePanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_GM_CalliopePanel));
	}
}
