using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode")]
public class BED_ProcessMachineNode : BED_ProcessNode
{
	private static bool OnRefreshAssetInCS_IsValid;

	private static IntPtr OnRefreshAssetInCS_FunctionAddress;

	private static int OnRefreshAssetInCS_ParamsSize;

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode:OnRefreshAssetInCS")]
	protected override void OnRefreshAssetInCS_Implementation()
	{
		SyncSceneObjPoliceConfig();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode:OnRefreshAssetInCS")]
	private static void OnRefreshAssetInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode bED_ProcessMachineNode = GCHelper.Find<BED_ProcessMachineNode>(obj);
		bED_ProcessMachineNode.OnRefreshAssetInCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode");
		OnRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRefreshAssetInCS");
		OnRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAssetInCS_FunctionAddress);
		OnRefreshAssetInCS_IsValid = OnRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode:OnRefreshAssetInCS", OnRefreshAssetInCS_IsValid);
	}

	static BED_ProcessMachineNode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode));
	}
}
