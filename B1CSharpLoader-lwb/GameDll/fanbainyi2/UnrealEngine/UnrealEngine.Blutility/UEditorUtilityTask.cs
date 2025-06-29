using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Blutility.EditorUtilityTask", "Blutility", UnrealModuleType.Engine)]
public class UEditorUtilityTask : UObject
{
	private static bool WasCancelRequested_IsValid;

	private static IntPtr WasCancelRequested_FunctionAddress;

	private static int WasCancelRequested_ParamsSize;

	private static bool WasCancelRequested_ReturnValue_IsValid;

	private static FFieldAddress WasCancelRequested_ReturnValue_PropertyAddress;

	private static int WasCancelRequested_ReturnValue_Offset;

	private static bool SetTaskNotificationText_IsValid;

	private static IntPtr SetTaskNotificationText_FunctionAddress;

	private static int SetTaskNotificationText_ParamsSize;

	private static bool SetTaskNotificationText_Text_IsValid;

	private static FFieldAddress SetTaskNotificationText_Text_PropertyAddress;

	private static int SetTaskNotificationText_Text_Offset;

	private static bool ReceiveCancelRequested_IsValid;

	private IntPtr ReceiveCancelRequested_InstanceFunctionAddress;

	private static IntPtr ReceiveCancelRequested_FunctionAddress;

	private static int ReceiveCancelRequested_ParamsSize;

	private static bool ReceiveBeginExecution_IsValid;

	private IntPtr ReceiveBeginExecution_InstanceFunctionAddress;

	private static IntPtr ReceiveBeginExecution_FunctionAddress;

	private static int ReceiveBeginExecution_ParamsSize;

	private static bool FinishExecutingTask_IsValid;

	private static IntPtr FinishExecutingTask_FunctionAddress;

	private static int FinishExecutingTask_ParamsSize;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Blutility.EditorUtilityTask:WasCancelRequested")]
	public unsafe bool WasCancelRequested()
	{
		CheckDestroyed();
		if (!WasCancelRequested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityTask:WasCancelRequested");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WasCancelRequested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WasCancelRequested_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, WasCancelRequested_FunctionAddress, intPtr, WasCancelRequested_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WasCancelRequested_ReturnValue_Offset), 0, WasCancelRequested_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Blutility.EditorUtilityTask:SetTaskNotificationText")]
	public unsafe void SetTaskNotificationText(FText Text)
	{
		CheckDestroyed();
		if (!SetTaskNotificationText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityTask:SetTaskNotificationText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTaskNotificationText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTaskNotificationText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTaskNotificationText_Text_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetTaskNotificationText_Text_Offset), 0, SetTaskNotificationText_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTaskNotificationText_FunctionAddress, intPtr, SetTaskNotificationText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTaskNotificationText_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/Blutility.EditorUtilityTask:ReceiveCancelRequested")]
	protected unsafe void ReceiveCancelRequested()
	{
		CheckDestroyed();
		if (!ReceiveCancelRequested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityTask:ReceiveCancelRequested");
			return;
		}
		if (ReceiveCancelRequested_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveCancelRequested_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveCancelRequested");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveCancelRequested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveCancelRequested_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveCancelRequested_InstanceFunctionAddress, argsSize: ReceiveCancelRequested_ParamsSize);
	}

	protected unsafe virtual void ReceiveCancelRequested_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveCancelRequested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityTask:ReceiveCancelRequested");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveCancelRequested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveCancelRequested_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveCancelRequested_FunctionAddress, argsSize: ReceiveCancelRequested_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/Blutility.EditorUtilityTask:ReceiveBeginExecution")]
	protected unsafe void ReceiveBeginExecution()
	{
		CheckDestroyed();
		if (!ReceiveBeginExecution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityTask:ReceiveBeginExecution");
			return;
		}
		if (ReceiveBeginExecution_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveBeginExecution_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveBeginExecution");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveBeginExecution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveBeginExecution_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveBeginExecution_InstanceFunctionAddress, argsSize: ReceiveBeginExecution_ParamsSize);
	}

	protected unsafe virtual void ReceiveBeginExecution_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveBeginExecution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityTask:ReceiveBeginExecution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveBeginExecution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveBeginExecution_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveBeginExecution_FunctionAddress, argsSize: ReceiveBeginExecution_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Blutility.EditorUtilityTask:FinishExecutingTask")]
	public unsafe void FinishExecutingTask()
	{
		CheckDestroyed();
		if (!FinishExecutingTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityTask:FinishExecutingTask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishExecutingTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishExecutingTask_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FinishExecutingTask_FunctionAddress, argsSize: FinishExecutingTask_ParamsSize);
	}

	static UEditorUtilityTask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorUtilityTask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorUtilityTask));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Blutility.EditorUtilityTask");
		WasCancelRequested_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WasCancelRequested");
		WasCancelRequested_ParamsSize = NativeReflection.GetFunctionParamsSize(WasCancelRequested_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WasCancelRequested_ReturnValue_PropertyAddress, WasCancelRequested_FunctionAddress, "ReturnValue");
		WasCancelRequested_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WasCancelRequested_FunctionAddress, "ReturnValue");
		WasCancelRequested_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WasCancelRequested_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WasCancelRequested_IsValid = WasCancelRequested_FunctionAddress != IntPtr.Zero && WasCancelRequested_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityTask:WasCancelRequested", WasCancelRequested_IsValid);
		SetTaskNotificationText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTaskNotificationText");
		SetTaskNotificationText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTaskNotificationText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTaskNotificationText_Text_PropertyAddress, SetTaskNotificationText_FunctionAddress, "Text");
		SetTaskNotificationText_Text_Offset = NativeReflectionCached.GetPropertyOffset(SetTaskNotificationText_FunctionAddress, "Text");
		SetTaskNotificationText_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTaskNotificationText_FunctionAddress, "Text", Classes.FTextProperty);
		SetTaskNotificationText_IsValid = SetTaskNotificationText_FunctionAddress != IntPtr.Zero && SetTaskNotificationText_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityTask:SetTaskNotificationText", SetTaskNotificationText_IsValid);
		ReceiveCancelRequested_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveCancelRequested");
		ReceiveCancelRequested_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveCancelRequested_FunctionAddress);
		ReceiveCancelRequested_IsValid = ReceiveCancelRequested_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityTask:ReceiveCancelRequested", ReceiveCancelRequested_IsValid);
		ReceiveBeginExecution_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveBeginExecution");
		ReceiveBeginExecution_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginExecution_FunctionAddress);
		ReceiveBeginExecution_IsValid = ReceiveBeginExecution_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityTask:ReceiveBeginExecution", ReceiveBeginExecution_IsValid);
		FinishExecutingTask_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FinishExecutingTask");
		FinishExecutingTask_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishExecutingTask_FunctionAddress);
		FinishExecutingTask_IsValid = FinishExecutingTask_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityTask:FinishExecutingTask", FinishExecutingTask_IsValid);
	}
}
