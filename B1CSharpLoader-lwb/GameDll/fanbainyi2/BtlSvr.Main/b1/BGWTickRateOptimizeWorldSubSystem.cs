using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWTickRateOptimizeWorldSubSystem")]
public class BGWTickRateOptimizeWorldSubSystem : UBGWTickableWorldSubSystem
{
	private static bool OnWorldBeginPlayCS_IsValid;

	private static IntPtr OnWorldBeginPlayCS_FunctionAddress;

	private static int OnWorldBeginPlayCS_ParamsSize;

	private static bool OnWorldBeginPlayCS_InWorld_IsValid;

	private static int OnWorldBeginPlayCS_InWorld_Offset;

	private static bool DoesSupportWorldTypeCS_IsValid;

	private static IntPtr DoesSupportWorldTypeCS_FunctionAddress;

	private static int DoesSupportWorldTypeCS_ParamsSize;

	private static bool DoesSupportWorldTypeCS_WorldType_IsValid;

	private static int DoesSupportWorldTypeCS_WorldType_Offset;

	private static bool DoesSupportWorldTypeCS_ReturnValue_IsValid;

	private static int DoesSupportWorldTypeCS_ReturnValue_Offset;

	private static FFieldAddress DoesSupportWorldTypeCS_ReturnValue_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BGWTickRateOptimizeWorldSubSystem:DoesSupportWorldTypeCS")]
	protected override bool DoesSupportWorldTypeCS_Implementation(int WorldType)
	{
		if (WorldType != 1)
		{
			return WorldType == 3;
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.BGWTickRateOptimizeWorldSubSystem:OnWorldBeginPlayCS")]
	protected override void OnWorldBeginPlayCS_Implementation(UWorld InWorld)
	{
		BGW_WorldSettings bGW_WorldSettings = InWorld.GetWorldSettings() as BGW_WorldSettings;
		for (int i = 0; i < bGW_WorldSettings.TROCellPatitionLayerConfig.Count; i++)
		{
			BGWCellPatitionWorldSubSystem obj = InWorld.GetWorldSubsystem(UClass.GetClass<BGWCellPatitionWorldSubSystem>()) as BGWCellPatitionWorldSubSystem;
			FGSTROConfig TROCfg = bGW_WorldSettings.TROCellPatitionLayerConfig[i];
			obj.RegisterLayer($"TRO{i}", TROCfg.PatitionLayerConfig, CellPartitionLayerTag.TickRateOptimize, delegate
			{
				BGW_LogUtil.LogError($"TROCfg {TROCfg.TROLevel}");
			}, delegate
			{
				BGW_LogUtil.LogError($"TROCfg {TROCfg.TROLevel}");
			});
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWTickRateOptimizeWorldSubSystem:OnWorldBeginPlayCS")]
	private static void OnWorldBeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWTickRateOptimizeWorldSubSystem bGWTickRateOptimizeWorldSubSystem = GCHelper.Find<BGWTickRateOptimizeWorldSubSystem>(obj);
		UWorld inWorld = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnWorldBeginPlayCS_InWorld_Offset));
		bGWTickRateOptimizeWorldSubSystem.OnWorldBeginPlayCS_Implementation(inWorld);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWTickRateOptimizeWorldSubSystem:DoesSupportWorldTypeCS")]
	private static void DoesSupportWorldTypeCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWTickRateOptimizeWorldSubSystem bGWTickRateOptimizeWorldSubSystem = GCHelper.Find<BGWTickRateOptimizeWorldSubSystem>(obj);
		int worldType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DoesSupportWorldTypeCS_WorldType_Offset));
		bool value = bGWTickRateOptimizeWorldSubSystem.DoesSupportWorldTypeCS_Implementation(worldType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, DoesSupportWorldTypeCS_ReturnValue_Offset), 0, DoesSupportWorldTypeCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGWTickRateOptimizeWorldSubSystem");
		OnWorldBeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWorldBeginPlayCS");
		OnWorldBeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldBeginPlayCS_FunctionAddress);
		OnWorldBeginPlayCS_InWorld_Offset = NativeReflection.GetPropertyOffset(OnWorldBeginPlayCS_FunctionAddress, "InWorld");
		OnWorldBeginPlayCS_InWorld_IsValid = NativeReflection.ValidatePropertyClass(OnWorldBeginPlayCS_FunctionAddress, "InWorld", Classes.FObjectProperty);
		OnWorldBeginPlayCS_IsValid = OnWorldBeginPlayCS_FunctionAddress != IntPtr.Zero && OnWorldBeginPlayCS_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWTickRateOptimizeWorldSubSystem:OnWorldBeginPlayCS", OnWorldBeginPlayCS_IsValid);
		DoesSupportWorldTypeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DoesSupportWorldTypeCS");
		DoesSupportWorldTypeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesSupportWorldTypeCS_FunctionAddress);
		DoesSupportWorldTypeCS_WorldType_Offset = NativeReflection.GetPropertyOffset(DoesSupportWorldTypeCS_FunctionAddress, "WorldType");
		DoesSupportWorldTypeCS_WorldType_IsValid = NativeReflection.ValidatePropertyClass(DoesSupportWorldTypeCS_FunctionAddress, "WorldType", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref DoesSupportWorldTypeCS_ReturnValue_PropertyAddress, DoesSupportWorldTypeCS_FunctionAddress, "ReturnValue");
		DoesSupportWorldTypeCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(DoesSupportWorldTypeCS_FunctionAddress, "ReturnValue");
		DoesSupportWorldTypeCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(DoesSupportWorldTypeCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesSupportWorldTypeCS_IsValid = DoesSupportWorldTypeCS_FunctionAddress != IntPtr.Zero && DoesSupportWorldTypeCS_WorldType_IsValid && DoesSupportWorldTypeCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWTickRateOptimizeWorldSubSystem:DoesSupportWorldTypeCS", DoesSupportWorldTypeCS_IsValid);
	}

	static BGWTickRateOptimizeWorldSubSystem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWTickRateOptimizeWorldSubSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWTickRateOptimizeWorldSubSystem));
	}
}
