using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[Abstract]
[UClass(Flags = (ClassFlags)818413733uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FunctionalTesting.PhasedAutomationActorBase", "FunctionalTesting", UnrealModuleType.Engine)]
public class APhasedAutomationActorBase : AActor
{
	private static bool OnFunctionalTestingComplete_IsValid;

	private IntPtr OnFunctionalTestingComplete_InstanceFunctionAddress;

	private static IntPtr OnFunctionalTestingComplete_FunctionAddress;

	private static int OnFunctionalTestingComplete_ParamsSize;

	private static bool OnFunctionalTestingBegin_IsValid;

	private IntPtr OnFunctionalTestingBegin_InstanceFunctionAddress;

	private static IntPtr OnFunctionalTestingBegin_FunctionAddress;

	private static int OnFunctionalTestingBegin_ParamsSize;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/FunctionalTesting.PhasedAutomationActorBase:OnFunctionalTestingComplete")]
	public unsafe void OnFunctionalTestingComplete()
	{
		CheckDestroyed();
		if (!OnFunctionalTestingComplete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.PhasedAutomationActorBase:OnFunctionalTestingComplete");
			return;
		}
		if (OnFunctionalTestingComplete_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnFunctionalTestingComplete_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnFunctionalTestingComplete");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFunctionalTestingComplete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFunctionalTestingComplete_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnFunctionalTestingComplete_InstanceFunctionAddress, argsSize: OnFunctionalTestingComplete_ParamsSize);
	}

	protected unsafe virtual void OnFunctionalTestingComplete_Implementation()
	{
		CheckDestroyed();
		if (!OnFunctionalTestingComplete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.PhasedAutomationActorBase:OnFunctionalTestingComplete");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFunctionalTestingComplete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFunctionalTestingComplete_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnFunctionalTestingComplete_FunctionAddress, argsSize: OnFunctionalTestingComplete_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/FunctionalTesting.PhasedAutomationActorBase:OnFunctionalTestingBegin")]
	public unsafe void OnFunctionalTestingBegin()
	{
		CheckDestroyed();
		if (!OnFunctionalTestingBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.PhasedAutomationActorBase:OnFunctionalTestingBegin");
			return;
		}
		if (OnFunctionalTestingBegin_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnFunctionalTestingBegin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnFunctionalTestingBegin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFunctionalTestingBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFunctionalTestingBegin_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnFunctionalTestingBegin_InstanceFunctionAddress, argsSize: OnFunctionalTestingBegin_ParamsSize);
	}

	protected unsafe virtual void OnFunctionalTestingBegin_Implementation()
	{
		CheckDestroyed();
		if (!OnFunctionalTestingBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.PhasedAutomationActorBase:OnFunctionalTestingBegin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFunctionalTestingBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFunctionalTestingBegin_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnFunctionalTestingBegin_FunctionAddress, argsSize: OnFunctionalTestingBegin_ParamsSize);
	}

	static APhasedAutomationActorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APhasedAutomationActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APhasedAutomationActorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FunctionalTesting.PhasedAutomationActorBase");
		OnFunctionalTestingComplete_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnFunctionalTestingComplete");
		OnFunctionalTestingComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFunctionalTestingComplete_FunctionAddress);
		OnFunctionalTestingComplete_IsValid = OnFunctionalTestingComplete_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.PhasedAutomationActorBase:OnFunctionalTestingComplete", OnFunctionalTestingComplete_IsValid);
		OnFunctionalTestingBegin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnFunctionalTestingBegin");
		OnFunctionalTestingBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFunctionalTestingBegin_FunctionAddress);
		OnFunctionalTestingBegin_IsValid = OnFunctionalTestingBegin_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.PhasedAutomationActorBase:OnFunctionalTestingBegin", OnFunctionalTestingBegin_IsValid);
	}
}
