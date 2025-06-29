using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.BoundsCopyComponent", "Engine", UnrealModuleType.Engine)]
public class UBoundsCopyComponent : UActorComponent
{
	private static bool SetTransformToBounds_IsValid;

	private static IntPtr SetTransformToBounds_FunctionAddress;

	private static int SetTransformToBounds_ParamsSize;

	private static bool SetRotation_IsValid;

	private static IntPtr SetRotation_FunctionAddress;

	private static int SetRotation_ParamsSize;

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Engine.BoundsCopyComponent:SetTransformToBounds")]
	public unsafe void SetTransformToBounds()
	{
		CheckDestroyed();
		if (!SetTransformToBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BoundsCopyComponent:SetTransformToBounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTransformToBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTransformToBounds_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetTransformToBounds_FunctionAddress, argsSize: SetTransformToBounds_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Engine.BoundsCopyComponent:SetRotation")]
	public unsafe void SetRotation()
	{
		CheckDestroyed();
		if (!SetRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BoundsCopyComponent:SetRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRotation_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetRotation_FunctionAddress, argsSize: SetRotation_ParamsSize);
	}

	static UBoundsCopyComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBoundsCopyComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBoundsCopyComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.BoundsCopyComponent");
		SetTransformToBounds_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTransformToBounds");
		SetTransformToBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTransformToBounds_FunctionAddress);
		SetTransformToBounds_IsValid = SetTransformToBounds_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BoundsCopyComponent:SetTransformToBounds", SetTransformToBounds_IsValid);
		SetRotation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRotation");
		SetRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRotation_FunctionAddress);
		SetRotation_IsValid = SetRotation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BoundsCopyComponent:SetRotation", SetRotation_IsValid);
	}
}
