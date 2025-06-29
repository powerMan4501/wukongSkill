using System;
using System.Runtime.CompilerServices;
using b1.Plugins.HoudiniEngineRuntime;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEHoudini;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSEHoudini.GSHoudiniAssetActor", "GSEHoudini", UnrealModuleType.GamePlugin)]
public class AGSHoudiniAssetActor : AHoudiniAssetActor
{
	private static bool OnPostEditChangePropertyCS_IsValid;

	private IntPtr OnPostEditChangePropertyCS_InstanceFunctionAddress;

	private static IntPtr OnPostEditChangePropertyCS_FunctionAddress;

	private static int OnPostEditChangePropertyCS_ParamsSize;

	private static bool OnConstructionCS_IsValid;

	private IntPtr OnConstructionCS_InstanceFunctionAddress;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	[UFunction(Flags = 671221760u)]
	[UMetaPath("/Script/GSEHoudini.GSHoudiniAssetActor:OnPostEditChangePropertyCS")]
	public unsafe void OnPostEditChangePropertyCS()
	{
		CheckDestroyed();
		if (!OnPostEditChangePropertyCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEHoudini.GSHoudiniAssetActor:OnPostEditChangePropertyCS");
			return;
		}
		if (OnPostEditChangePropertyCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPostEditChangePropertyCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPostEditChangePropertyCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostEditChangePropertyCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostEditChangePropertyCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPostEditChangePropertyCS_InstanceFunctionAddress, argsSize: OnPostEditChangePropertyCS_ParamsSize);
	}

	protected unsafe virtual void OnPostEditChangePropertyCS_Implementation()
	{
		CheckDestroyed();
		if (!OnPostEditChangePropertyCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEHoudini.GSHoudiniAssetActor:OnPostEditChangePropertyCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostEditChangePropertyCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostEditChangePropertyCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPostEditChangePropertyCS_FunctionAddress, argsSize: OnPostEditChangePropertyCS_ParamsSize);
	}

	[UFunction(Flags = 671221760u)]
	[UMetaPath("/Script/GSEHoudini.GSHoudiniAssetActor:OnConstructionCS")]
	public unsafe void OnConstructionCS()
	{
		CheckDestroyed();
		if (!OnConstructionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEHoudini.GSHoudiniAssetActor:OnConstructionCS");
			return;
		}
		if (OnConstructionCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnConstructionCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnConstructionCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnConstructionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnConstructionCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnConstructionCS_InstanceFunctionAddress, argsSize: OnConstructionCS_ParamsSize);
	}

	protected unsafe virtual void OnConstructionCS_Implementation()
	{
		CheckDestroyed();
		if (!OnConstructionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEHoudini.GSHoudiniAssetActor:OnConstructionCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnConstructionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnConstructionCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnConstructionCS_FunctionAddress, argsSize: OnConstructionCS_ParamsSize);
	}

	static AGSHoudiniAssetActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSHoudiniAssetActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSHoudiniAssetActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GSEHoudini.GSHoudiniAssetActor");
		OnPostEditChangePropertyCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnPostEditChangePropertyCS");
		OnPostEditChangePropertyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostEditChangePropertyCS_FunctionAddress);
		OnPostEditChangePropertyCS_IsValid = OnPostEditChangePropertyCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSEHoudini.GSHoudiniAssetActor:OnPostEditChangePropertyCS", OnPostEditChangePropertyCS_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSEHoudini.GSHoudiniAssetActor:OnConstructionCS", OnConstructionCS_IsValid);
	}
}
