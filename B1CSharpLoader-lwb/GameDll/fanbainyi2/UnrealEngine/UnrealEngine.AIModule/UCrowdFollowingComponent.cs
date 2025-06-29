using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AIModule.CrowdFollowingComponent", "AIModule", UnrealModuleType.Engine)]
public class UCrowdFollowingComponent : UPathFollowingComponent, ICrowdAgentInterface, IInterface
{
	private static bool SuspendCrowdSteering_IsValid;

	private static IntPtr SuspendCrowdSteering_FunctionAddress;

	private static int SuspendCrowdSteering_ParamsSize;

	private static bool SuspendCrowdSteering_bSuspend_IsValid;

	private static FFieldAddress SuspendCrowdSteering_bSuspend_PropertyAddress;

	private static int SuspendCrowdSteering_bSuspend_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AIModule.CrowdFollowingComponent:SuspendCrowdSteering")]
	public unsafe void SuspendCrowdSteering(bool bSuspend)
	{
		CheckDestroyed();
		if (!SuspendCrowdSteering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.CrowdFollowingComponent:SuspendCrowdSteering");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SuspendCrowdSteering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SuspendCrowdSteering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SuspendCrowdSteering_bSuspend_Offset), 0, SuspendCrowdSteering_bSuspend_PropertyAddress.Address, bSuspend);
		NativeReflection.InvokeFunctionOptimized(base.Address, SuspendCrowdSteering_FunctionAddress, intPtr, SuspendCrowdSteering_ParamsSize);
	}

	static UCrowdFollowingComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCrowdFollowingComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCrowdFollowingComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AIModule.CrowdFollowingComponent");
		SuspendCrowdSteering_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SuspendCrowdSteering");
		SuspendCrowdSteering_ParamsSize = NativeReflection.GetFunctionParamsSize(SuspendCrowdSteering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SuspendCrowdSteering_bSuspend_PropertyAddress, SuspendCrowdSteering_FunctionAddress, "bSuspend");
		SuspendCrowdSteering_bSuspend_Offset = NativeReflectionCached.GetPropertyOffset(SuspendCrowdSteering_FunctionAddress, "bSuspend");
		SuspendCrowdSteering_bSuspend_IsValid = NativeReflectionCached.ValidatePropertyClass(SuspendCrowdSteering_FunctionAddress, "bSuspend", Classes.FBoolProperty);
		SuspendCrowdSteering_IsValid = SuspendCrowdSteering_FunctionAddress != IntPtr.Zero && SuspendCrowdSteering_bSuspend_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.CrowdFollowingComponent:SuspendCrowdSteering", SuspendCrowdSteering_IsValid);
	}
}
