using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.ChaosSolverEngine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ChaosSolverEngine.ChaosSolverActor", "ChaosSolverEngine", UnrealModuleType.Engine)]
public class AChaosSolverActor : AActor
{
	private static bool SetSolverActive_IsValid;

	private static IntPtr SetSolverActive_FunctionAddress;

	private static int SetSolverActive_ParamsSize;

	private static bool SetSolverActive_bActive_IsValid;

	private static FFieldAddress SetSolverActive_bActive_PropertyAddress;

	private static int SetSolverActive_bActive_Offset;

	private static bool SetAsCurrentWorldSolver_IsValid;

	private static IntPtr SetAsCurrentWorldSolver_FunctionAddress;

	private static int SetAsCurrentWorldSolver_ParamsSize;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosSolverActor:SetSolverActive")]
	public unsafe void SetSolverActive(bool bActive)
	{
		CheckDestroyed();
		if (!SetSolverActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosSolverEngine.ChaosSolverActor:SetSolverActive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSolverActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSolverActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSolverActive_bActive_Offset), 0, SetSolverActive_bActive_PropertyAddress.Address, bActive);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSolverActive_FunctionAddress, intPtr, SetSolverActive_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ChaosSolverEngine.ChaosSolverActor:SetAsCurrentWorldSolver")]
	public unsafe void SetAsCurrentWorldSolver()
	{
		CheckDestroyed();
		if (!SetAsCurrentWorldSolver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ChaosSolverEngine.ChaosSolverActor:SetAsCurrentWorldSolver");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAsCurrentWorldSolver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAsCurrentWorldSolver_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetAsCurrentWorldSolver_FunctionAddress, argsSize: SetAsCurrentWorldSolver_ParamsSize);
	}

	static AChaosSolverActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AChaosSolverActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AChaosSolverActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ChaosSolverEngine.ChaosSolverActor");
		SetSolverActive_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSolverActive");
		SetSolverActive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSolverActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSolverActive_bActive_PropertyAddress, SetSolverActive_FunctionAddress, "bActive");
		SetSolverActive_bActive_Offset = NativeReflectionCached.GetPropertyOffset(SetSolverActive_FunctionAddress, "bActive");
		SetSolverActive_bActive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSolverActive_FunctionAddress, "bActive", Classes.FBoolProperty);
		SetSolverActive_IsValid = SetSolverActive_FunctionAddress != IntPtr.Zero && SetSolverActive_bActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ChaosSolverEngine.ChaosSolverActor:SetSolverActive", SetSolverActive_IsValid);
		SetAsCurrentWorldSolver_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAsCurrentWorldSolver");
		SetAsCurrentWorldSolver_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAsCurrentWorldSolver_FunctionAddress);
		SetAsCurrentWorldSolver_IsValid = SetAsCurrentWorldSolver_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ChaosSolverEngine.ChaosSolverActor:SetAsCurrentWorldSolver", SetAsCurrentWorldSolver_IsValid);
	}
}
