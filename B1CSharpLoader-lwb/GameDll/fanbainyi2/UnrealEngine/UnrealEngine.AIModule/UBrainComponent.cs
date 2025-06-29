using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AIModule.BrainComponent", "AIModule", UnrealModuleType.Engine)]
public class UBrainComponent : UActorComponent, IAIResourceInterface, IInterface
{
	private static bool StopLogic_IsValid;

	private static IntPtr StopLogic_FunctionAddress;

	private static int StopLogic_ParamsSize;

	private static bool StopLogic_Reason_IsValid;

	private static FFieldAddress StopLogic_Reason_PropertyAddress;

	private static int StopLogic_Reason_Offset;

	private static bool StartLogic_IsValid;

	private static IntPtr StartLogic_FunctionAddress;

	private static int StartLogic_ParamsSize;

	private static bool RestartLogic_IsValid;

	private static IntPtr RestartLogic_FunctionAddress;

	private static int RestartLogic_ParamsSize;

	private static bool IsRunning_IsValid;

	private static IntPtr IsRunning_FunctionAddress;

	private static int IsRunning_ParamsSize;

	private static bool IsRunning_ReturnValue_IsValid;

	private static FFieldAddress IsRunning_ReturnValue_PropertyAddress;

	private static int IsRunning_ReturnValue_Offset;

	private static bool IsPaused_IsValid;

	private static IntPtr IsPaused_FunctionAddress;

	private static int IsPaused_ParamsSize;

	private static bool IsPaused_ReturnValue_IsValid;

	private static FFieldAddress IsPaused_ReturnValue_PropertyAddress;

	private static int IsPaused_ReturnValue_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AIModule.BrainComponent:StopLogic")]
	public unsafe void StopLogic(string Reason)
	{
		CheckDestroyed();
		if (!StopLogic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BrainComponent:StopLogic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopLogic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopLogic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StopLogic_Reason_Offset), 0, StopLogic_Reason_PropertyAddress.Address, Reason);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopLogic_FunctionAddress, intPtr, StopLogic_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StopLogic_Reason_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AIModule.BrainComponent:StartLogic")]
	public unsafe void StartLogic()
	{
		CheckDestroyed();
		if (!StartLogic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BrainComponent:StartLogic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartLogic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartLogic_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartLogic_FunctionAddress, argsSize: StartLogic_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AIModule.BrainComponent:RestartLogic")]
	public unsafe void RestartLogic()
	{
		CheckDestroyed();
		if (!RestartLogic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BrainComponent:RestartLogic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartLogic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartLogic_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RestartLogic_FunctionAddress, argsSize: RestartLogic_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AIModule.BrainComponent:IsRunning")]
	public unsafe bool IsRunning()
	{
		CheckDestroyed();
		if (!IsRunning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BrainComponent:IsRunning");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRunning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRunning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRunning_FunctionAddress, intPtr, IsRunning_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRunning_ReturnValue_Offset), 0, IsRunning_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AIModule.BrainComponent:IsPaused")]
	public unsafe bool IsPaused()
	{
		CheckDestroyed();
		if (!IsPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BrainComponent:IsPaused");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPaused_FunctionAddress, intPtr, IsPaused_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPaused_ReturnValue_Offset), 0, IsPaused_ReturnValue_PropertyAddress.Address);
	}

	static UBrainComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBrainComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBrainComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AIModule.BrainComponent");
		StopLogic_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopLogic");
		StopLogic_ParamsSize = NativeReflection.GetFunctionParamsSize(StopLogic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopLogic_Reason_PropertyAddress, StopLogic_FunctionAddress, "Reason");
		StopLogic_Reason_Offset = NativeReflectionCached.GetPropertyOffset(StopLogic_FunctionAddress, "Reason");
		StopLogic_Reason_IsValid = NativeReflectionCached.ValidatePropertyClass(StopLogic_FunctionAddress, "Reason", Classes.FStrProperty);
		StopLogic_IsValid = StopLogic_FunctionAddress != IntPtr.Zero && StopLogic_Reason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BrainComponent:StopLogic", StopLogic_IsValid);
		StartLogic_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartLogic");
		StartLogic_ParamsSize = NativeReflection.GetFunctionParamsSize(StartLogic_FunctionAddress);
		StartLogic_IsValid = StartLogic_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BrainComponent:StartLogic", StartLogic_IsValid);
		RestartLogic_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RestartLogic");
		RestartLogic_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartLogic_FunctionAddress);
		RestartLogic_IsValid = RestartLogic_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BrainComponent:RestartLogic", RestartLogic_IsValid);
		IsRunning_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsRunning");
		IsRunning_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRunning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRunning_ReturnValue_PropertyAddress, IsRunning_FunctionAddress, "ReturnValue");
		IsRunning_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRunning_FunctionAddress, "ReturnValue");
		IsRunning_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRunning_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRunning_IsValid = IsRunning_FunctionAddress != IntPtr.Zero && IsRunning_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BrainComponent:IsRunning", IsRunning_IsValid);
		IsPaused_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsPaused");
		IsPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPaused_ReturnValue_PropertyAddress, IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPaused_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPaused_IsValid = IsPaused_FunctionAddress != IntPtr.Zero && IsPaused_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BrainComponent:IsPaused", IsPaused_IsValid);
	}
}
