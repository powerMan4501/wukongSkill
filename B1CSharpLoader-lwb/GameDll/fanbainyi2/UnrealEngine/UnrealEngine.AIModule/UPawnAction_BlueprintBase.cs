using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)818942113uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.PawnAction_BlueprintBase", "AIModule", UnrealModuleType.Engine)]
public class UPawnAction_BlueprintBase : UPawnAction
{
	private static bool ActionTick_IsValid;

	private IntPtr ActionTick_InstanceFunctionAddress;

	private static IntPtr ActionTick_FunctionAddress;

	private static int ActionTick_ParamsSize;

	private static bool ActionTick_ControlledPawn_IsValid;

	private static FFieldAddress ActionTick_ControlledPawn_PropertyAddress;

	private static int ActionTick_ControlledPawn_Offset;

	private static bool ActionTick_DeltaSeconds_IsValid;

	private static FFieldAddress ActionTick_DeltaSeconds_PropertyAddress;

	private static int ActionTick_DeltaSeconds_Offset;

	private static bool ActionStart_IsValid;

	private IntPtr ActionStart_InstanceFunctionAddress;

	private static IntPtr ActionStart_FunctionAddress;

	private static int ActionStart_ParamsSize;

	private static bool ActionStart_ControlledPawn_IsValid;

	private static FFieldAddress ActionStart_ControlledPawn_PropertyAddress;

	private static int ActionStart_ControlledPawn_Offset;

	private static bool ActionResume_IsValid;

	private IntPtr ActionResume_InstanceFunctionAddress;

	private static IntPtr ActionResume_FunctionAddress;

	private static int ActionResume_ParamsSize;

	private static bool ActionResume_ControlledPawn_IsValid;

	private static FFieldAddress ActionResume_ControlledPawn_PropertyAddress;

	private static int ActionResume_ControlledPawn_Offset;

	private static bool ActionPause_IsValid;

	private IntPtr ActionPause_InstanceFunctionAddress;

	private static IntPtr ActionPause_FunctionAddress;

	private static int ActionPause_ParamsSize;

	private static bool ActionPause_ControlledPawn_IsValid;

	private static FFieldAddress ActionPause_ControlledPawn_PropertyAddress;

	private static int ActionPause_ControlledPawn_Offset;

	private static bool ActionFinished_IsValid;

	private IntPtr ActionFinished_InstanceFunctionAddress;

	private static IntPtr ActionFinished_FunctionAddress;

	private static int ActionFinished_ParamsSize;

	private static bool ActionFinished_ControlledPawn_IsValid;

	private static FFieldAddress ActionFinished_ControlledPawn_PropertyAddress;

	private static int ActionFinished_ControlledPawn_Offset;

	private static bool ActionFinished_WithResult_IsValid;

	private static FFieldAddress ActionFinished_WithResult_PropertyAddress;

	private static int ActionFinished_WithResult_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/AIModule.PawnAction_BlueprintBase:ActionTick")]
	public unsafe void ActionTick(APawn ControlledPawn, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ActionTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionTick");
			return;
		}
		if (ActionTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			ActionTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ActionTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionTick_ControlledPawn_Offset), 0, ActionTick_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ActionTick_DeltaSeconds_Offset), 0, ActionTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionTick_InstanceFunctionAddress, intPtr, ActionTick_ParamsSize);
	}

	protected unsafe virtual void ActionTick_Implementation(APawn ControlledPawn, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ActionTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionTick_ControlledPawn_Offset), 0, ActionTick_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ActionTick_DeltaSeconds_Offset), 0, ActionTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionTick_FunctionAddress, intPtr, ActionTick_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/AIModule.PawnAction_BlueprintBase:ActionStart")]
	public unsafe void ActionStart(APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ActionStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionStart");
			return;
		}
		if (ActionStart_InstanceFunctionAddress == IntPtr.Zero)
		{
			ActionStart_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ActionStart");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionStart_ControlledPawn_Offset), 0, ActionStart_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionStart_InstanceFunctionAddress, intPtr, ActionStart_ParamsSize);
	}

	protected unsafe virtual void ActionStart_Implementation(APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ActionStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionStart_ControlledPawn_Offset), 0, ActionStart_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionStart_FunctionAddress, intPtr, ActionStart_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/AIModule.PawnAction_BlueprintBase:ActionResume")]
	public unsafe void ActionResume(APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ActionResume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionResume");
			return;
		}
		if (ActionResume_InstanceFunctionAddress == IntPtr.Zero)
		{
			ActionResume_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ActionResume");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionResume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionResume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionResume_ControlledPawn_Offset), 0, ActionResume_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionResume_InstanceFunctionAddress, intPtr, ActionResume_ParamsSize);
	}

	protected unsafe virtual void ActionResume_Implementation(APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ActionResume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionResume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionResume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionResume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionResume_ControlledPawn_Offset), 0, ActionResume_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionResume_FunctionAddress, intPtr, ActionResume_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/AIModule.PawnAction_BlueprintBase:ActionPause")]
	public unsafe void ActionPause(APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ActionPause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionPause");
			return;
		}
		if (ActionPause_InstanceFunctionAddress == IntPtr.Zero)
		{
			ActionPause_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ActionPause");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionPause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionPause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionPause_ControlledPawn_Offset), 0, ActionPause_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionPause_InstanceFunctionAddress, intPtr, ActionPause_ParamsSize);
	}

	protected unsafe virtual void ActionPause_Implementation(APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ActionPause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionPause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionPause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionPause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionPause_ControlledPawn_Offset), 0, ActionPause_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionPause_FunctionAddress, intPtr, ActionPause_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/AIModule.PawnAction_BlueprintBase:ActionFinished")]
	public unsafe void ActionFinished(APawn ControlledPawn, EPawnActionResult WithResult)
	{
		CheckDestroyed();
		if (!ActionFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionFinished");
			return;
		}
		if (ActionFinished_InstanceFunctionAddress == IntPtr.Zero)
		{
			ActionFinished_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ActionFinished");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionFinished_ControlledPawn_Offset), 0, ActionFinished_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		EnumMarshaler<EPawnActionResult>.ToNative(IntPtr.Add(intPtr, ActionFinished_WithResult_Offset), 0, ActionFinished_WithResult_PropertyAddress.Address, WithResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionFinished_InstanceFunctionAddress, intPtr, ActionFinished_ParamsSize);
	}

	protected unsafe virtual void ActionFinished_Implementation(APawn ControlledPawn, EPawnActionResult WithResult)
	{
		CheckDestroyed();
		if (!ActionFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.PawnAction_BlueprintBase:ActionFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActionFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActionFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ActionFinished_ControlledPawn_Offset), 0, ActionFinished_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		EnumMarshaler<EPawnActionResult>.ToNative(IntPtr.Add(intPtr, ActionFinished_WithResult_Offset), 0, ActionFinished_WithResult_PropertyAddress.Address, WithResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActionFinished_FunctionAddress, intPtr, ActionFinished_ParamsSize);
	}

	static UPawnAction_BlueprintBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPawnAction_BlueprintBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPawnAction_BlueprintBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AIModule.PawnAction_BlueprintBase");
		ActionTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ActionTick");
		ActionTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ActionTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActionTick_ControlledPawn_PropertyAddress, ActionTick_FunctionAddress, "ControlledPawn");
		ActionTick_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ActionTick_FunctionAddress, "ControlledPawn");
		ActionTick_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ActionTick_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActionTick_DeltaSeconds_PropertyAddress, ActionTick_FunctionAddress, "DeltaSeconds");
		ActionTick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(ActionTick_FunctionAddress, "DeltaSeconds");
		ActionTick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(ActionTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ActionTick_IsValid = ActionTick_FunctionAddress != IntPtr.Zero && ActionTick_ControlledPawn_IsValid && ActionTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnAction_BlueprintBase:ActionTick", ActionTick_IsValid);
		ActionStart_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ActionStart");
		ActionStart_ParamsSize = NativeReflection.GetFunctionParamsSize(ActionStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActionStart_ControlledPawn_PropertyAddress, ActionStart_FunctionAddress, "ControlledPawn");
		ActionStart_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ActionStart_FunctionAddress, "ControlledPawn");
		ActionStart_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ActionStart_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ActionStart_IsValid = ActionStart_FunctionAddress != IntPtr.Zero && ActionStart_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnAction_BlueprintBase:ActionStart", ActionStart_IsValid);
		ActionResume_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ActionResume");
		ActionResume_ParamsSize = NativeReflection.GetFunctionParamsSize(ActionResume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActionResume_ControlledPawn_PropertyAddress, ActionResume_FunctionAddress, "ControlledPawn");
		ActionResume_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ActionResume_FunctionAddress, "ControlledPawn");
		ActionResume_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ActionResume_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ActionResume_IsValid = ActionResume_FunctionAddress != IntPtr.Zero && ActionResume_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnAction_BlueprintBase:ActionResume", ActionResume_IsValid);
		ActionPause_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ActionPause");
		ActionPause_ParamsSize = NativeReflection.GetFunctionParamsSize(ActionPause_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActionPause_ControlledPawn_PropertyAddress, ActionPause_FunctionAddress, "ControlledPawn");
		ActionPause_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ActionPause_FunctionAddress, "ControlledPawn");
		ActionPause_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ActionPause_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ActionPause_IsValid = ActionPause_FunctionAddress != IntPtr.Zero && ActionPause_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnAction_BlueprintBase:ActionPause", ActionPause_IsValid);
		ActionFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ActionFinished");
		ActionFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(ActionFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActionFinished_ControlledPawn_PropertyAddress, ActionFinished_FunctionAddress, "ControlledPawn");
		ActionFinished_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ActionFinished_FunctionAddress, "ControlledPawn");
		ActionFinished_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ActionFinished_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActionFinished_WithResult_PropertyAddress, ActionFinished_FunctionAddress, "WithResult");
		ActionFinished_WithResult_Offset = NativeReflectionCached.GetPropertyOffset(ActionFinished_FunctionAddress, "WithResult");
		ActionFinished_WithResult_IsValid = NativeReflectionCached.ValidatePropertyClass(ActionFinished_FunctionAddress, "WithResult", Classes.FByteProperty);
		ActionFinished_IsValid = ActionFinished_FunctionAddress != IntPtr.Zero && ActionFinished_ControlledPawn_IsValid && ActionFinished_WithResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.PawnAction_BlueprintBase:ActionFinished", ActionFinished_IsValid);
	}
}
