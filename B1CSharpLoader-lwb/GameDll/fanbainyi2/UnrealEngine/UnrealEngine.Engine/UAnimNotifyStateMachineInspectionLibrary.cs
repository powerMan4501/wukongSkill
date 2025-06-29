using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.AnimNotifyStateMachineInspectionLibrary", "Engine", UnrealModuleType.Engine)]
public class UAnimNotifyStateMachineInspectionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsTriggeredByStateMachine_IsValid;

	private static IntPtr IsTriggeredByStateMachine_FunctionAddress;

	private static int IsTriggeredByStateMachine_ParamsSize;

	private static bool IsTriggeredByStateMachine_EventReference_IsValid;

	private static FFieldAddress IsTriggeredByStateMachine_EventReference_PropertyAddress;

	private static int IsTriggeredByStateMachine_EventReference_Offset;

	private static bool IsTriggeredByStateMachine_AnimInstance_IsValid;

	private static FFieldAddress IsTriggeredByStateMachine_AnimInstance_PropertyAddress;

	private static int IsTriggeredByStateMachine_AnimInstance_Offset;

	private static bool IsTriggeredByStateMachine_StateMachineName_IsValid;

	private static FFieldAddress IsTriggeredByStateMachine_StateMachineName_PropertyAddress;

	private static int IsTriggeredByStateMachine_StateMachineName_Offset;

	private static bool IsTriggeredByStateMachine_ReturnValue_IsValid;

	private static FFieldAddress IsTriggeredByStateMachine_ReturnValue_PropertyAddress;

	private static int IsTriggeredByStateMachine_ReturnValue_Offset;

	private static bool IsTriggeredByStateInStateMachine_IsValid;

	private static IntPtr IsTriggeredByStateInStateMachine_FunctionAddress;

	private static int IsTriggeredByStateInStateMachine_ParamsSize;

	private static bool IsTriggeredByStateInStateMachine_EventReference_IsValid;

	private static FFieldAddress IsTriggeredByStateInStateMachine_EventReference_PropertyAddress;

	private static int IsTriggeredByStateInStateMachine_EventReference_Offset;

	private static bool IsTriggeredByStateInStateMachine_AnimInstance_IsValid;

	private static FFieldAddress IsTriggeredByStateInStateMachine_AnimInstance_PropertyAddress;

	private static int IsTriggeredByStateInStateMachine_AnimInstance_Offset;

	private static bool IsTriggeredByStateInStateMachine_StateMachineName_IsValid;

	private static FFieldAddress IsTriggeredByStateInStateMachine_StateMachineName_PropertyAddress;

	private static int IsTriggeredByStateInStateMachine_StateMachineName_Offset;

	private static bool IsTriggeredByStateInStateMachine_StateName_IsValid;

	private static FFieldAddress IsTriggeredByStateInStateMachine_StateName_PropertyAddress;

	private static int IsTriggeredByStateInStateMachine_StateName_Offset;

	private static bool IsTriggeredByStateInStateMachine_ReturnValue_IsValid;

	private static FFieldAddress IsTriggeredByStateInStateMachine_ReturnValue_PropertyAddress;

	private static int IsTriggeredByStateInStateMachine_ReturnValue_Offset;

	private static bool IsTriggeredByState_IsValid;

	private static IntPtr IsTriggeredByState_FunctionAddress;

	private static int IsTriggeredByState_ParamsSize;

	private static bool IsTriggeredByState_EventReference_IsValid;

	private static FFieldAddress IsTriggeredByState_EventReference_PropertyAddress;

	private static int IsTriggeredByState_EventReference_Offset;

	private static bool IsTriggeredByState_AnimInstance_IsValid;

	private static FFieldAddress IsTriggeredByState_AnimInstance_PropertyAddress;

	private static int IsTriggeredByState_AnimInstance_Offset;

	private static bool IsTriggeredByState_StateName_IsValid;

	private static FFieldAddress IsTriggeredByState_StateName_PropertyAddress;

	private static int IsTriggeredByState_StateName_Offset;

	private static bool IsTriggeredByState_ReturnValue_IsValid;

	private static FFieldAddress IsTriggeredByState_ReturnValue_PropertyAddress;

	private static int IsTriggeredByState_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByStateMachine")]
	public unsafe static bool IsTriggeredByStateMachine(FAnimNotifyEventReference EventReference, UAnimInstance AnimInstance, FName StateMachineName)
	{
		if (!IsTriggeredByStateMachine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByStateMachine");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTriggeredByStateMachine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTriggeredByStateMachine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTriggeredByStateMachine_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, IsTriggeredByStateMachine_EventReference_Offset), 0, IsTriggeredByStateMachine_EventReference_PropertyAddress.Address, EventReference);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, IsTriggeredByStateMachine_AnimInstance_Offset), 0, IsTriggeredByStateMachine_AnimInstance_PropertyAddress.Address, AnimInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsTriggeredByStateMachine_StateMachineName_Offset), 0, IsTriggeredByStateMachine_StateMachineName_PropertyAddress.Address, StateMachineName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsTriggeredByStateMachine_FunctionAddress, intPtr, IsTriggeredByStateMachine_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsTriggeredByStateMachine_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTriggeredByStateMachine_ReturnValue_Offset), 0, IsTriggeredByStateMachine_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByStateInStateMachine")]
	public unsafe static bool IsTriggeredByStateInStateMachine(FAnimNotifyEventReference EventReference, UAnimInstance AnimInstance, FName StateMachineName, FName StateName)
	{
		if (!IsTriggeredByStateInStateMachine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByStateInStateMachine");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTriggeredByStateInStateMachine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTriggeredByStateInStateMachine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTriggeredByStateInStateMachine_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, IsTriggeredByStateInStateMachine_EventReference_Offset), 0, IsTriggeredByStateInStateMachine_EventReference_PropertyAddress.Address, EventReference);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, IsTriggeredByStateInStateMachine_AnimInstance_Offset), 0, IsTriggeredByStateInStateMachine_AnimInstance_PropertyAddress.Address, AnimInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsTriggeredByStateInStateMachine_StateMachineName_Offset), 0, IsTriggeredByStateInStateMachine_StateMachineName_PropertyAddress.Address, StateMachineName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsTriggeredByStateInStateMachine_StateName_Offset), 0, IsTriggeredByStateInStateMachine_StateName_PropertyAddress.Address, StateName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsTriggeredByStateInStateMachine_FunctionAddress, intPtr, IsTriggeredByStateInStateMachine_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsTriggeredByStateInStateMachine_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTriggeredByStateInStateMachine_ReturnValue_Offset), 0, IsTriggeredByStateInStateMachine_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByState")]
	public unsafe static bool IsTriggeredByState(FAnimNotifyEventReference EventReference, UAnimInstance AnimInstance, FName StateName)
	{
		if (!IsTriggeredByState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByState");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTriggeredByState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTriggeredByState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTriggeredByState_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, IsTriggeredByState_EventReference_Offset), 0, IsTriggeredByState_EventReference_PropertyAddress.Address, EventReference);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, IsTriggeredByState_AnimInstance_Offset), 0, IsTriggeredByState_AnimInstance_PropertyAddress.Address, AnimInstance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsTriggeredByState_StateName_Offset), 0, IsTriggeredByState_StateName_PropertyAddress.Address, StateName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsTriggeredByState_FunctionAddress, intPtr, IsTriggeredByState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsTriggeredByState_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTriggeredByState_ReturnValue_Offset), 0, IsTriggeredByState_ReturnValue_PropertyAddress.Address);
	}

	static UAnimNotifyStateMachineInspectionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyStateMachineInspectionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyStateMachineInspectionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.AnimNotifyStateMachineInspectionLibrary");
		IsTriggeredByStateMachine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsTriggeredByStateMachine");
		IsTriggeredByStateMachine_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTriggeredByStateMachine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByStateMachine_EventReference_PropertyAddress, IsTriggeredByStateMachine_FunctionAddress, "EventReference");
		IsTriggeredByStateMachine_EventReference_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByStateMachine_FunctionAddress, "EventReference");
		IsTriggeredByStateMachine_EventReference_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByStateMachine_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByStateMachine_AnimInstance_PropertyAddress, IsTriggeredByStateMachine_FunctionAddress, "AnimInstance");
		IsTriggeredByStateMachine_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByStateMachine_FunctionAddress, "AnimInstance");
		IsTriggeredByStateMachine_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByStateMachine_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByStateMachine_StateMachineName_PropertyAddress, IsTriggeredByStateMachine_FunctionAddress, "StateMachineName");
		IsTriggeredByStateMachine_StateMachineName_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByStateMachine_FunctionAddress, "StateMachineName");
		IsTriggeredByStateMachine_StateMachineName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByStateMachine_FunctionAddress, "StateMachineName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByStateMachine_ReturnValue_PropertyAddress, IsTriggeredByStateMachine_FunctionAddress, "ReturnValue");
		IsTriggeredByStateMachine_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByStateMachine_FunctionAddress, "ReturnValue");
		IsTriggeredByStateMachine_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByStateMachine_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTriggeredByStateMachine_IsValid = IsTriggeredByStateMachine_FunctionAddress != IntPtr.Zero && IsTriggeredByStateMachine_EventReference_IsValid && IsTriggeredByStateMachine_AnimInstance_IsValid && IsTriggeredByStateMachine_StateMachineName_IsValid && IsTriggeredByStateMachine_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByStateMachine", IsTriggeredByStateMachine_IsValid);
		IsTriggeredByStateInStateMachine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsTriggeredByStateInStateMachine");
		IsTriggeredByStateInStateMachine_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTriggeredByStateInStateMachine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByStateInStateMachine_EventReference_PropertyAddress, IsTriggeredByStateInStateMachine_FunctionAddress, "EventReference");
		IsTriggeredByStateInStateMachine_EventReference_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByStateInStateMachine_FunctionAddress, "EventReference");
		IsTriggeredByStateInStateMachine_EventReference_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByStateInStateMachine_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByStateInStateMachine_AnimInstance_PropertyAddress, IsTriggeredByStateInStateMachine_FunctionAddress, "AnimInstance");
		IsTriggeredByStateInStateMachine_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByStateInStateMachine_FunctionAddress, "AnimInstance");
		IsTriggeredByStateInStateMachine_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByStateInStateMachine_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByStateInStateMachine_StateMachineName_PropertyAddress, IsTriggeredByStateInStateMachine_FunctionAddress, "StateMachineName");
		IsTriggeredByStateInStateMachine_StateMachineName_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByStateInStateMachine_FunctionAddress, "StateMachineName");
		IsTriggeredByStateInStateMachine_StateMachineName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByStateInStateMachine_FunctionAddress, "StateMachineName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByStateInStateMachine_StateName_PropertyAddress, IsTriggeredByStateInStateMachine_FunctionAddress, "StateName");
		IsTriggeredByStateInStateMachine_StateName_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByStateInStateMachine_FunctionAddress, "StateName");
		IsTriggeredByStateInStateMachine_StateName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByStateInStateMachine_FunctionAddress, "StateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByStateInStateMachine_ReturnValue_PropertyAddress, IsTriggeredByStateInStateMachine_FunctionAddress, "ReturnValue");
		IsTriggeredByStateInStateMachine_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByStateInStateMachine_FunctionAddress, "ReturnValue");
		IsTriggeredByStateInStateMachine_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByStateInStateMachine_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTriggeredByStateInStateMachine_IsValid = IsTriggeredByStateInStateMachine_FunctionAddress != IntPtr.Zero && IsTriggeredByStateInStateMachine_EventReference_IsValid && IsTriggeredByStateInStateMachine_AnimInstance_IsValid && IsTriggeredByStateInStateMachine_StateMachineName_IsValid && IsTriggeredByStateInStateMachine_StateName_IsValid && IsTriggeredByStateInStateMachine_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByStateInStateMachine", IsTriggeredByStateInStateMachine_IsValid);
		IsTriggeredByState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsTriggeredByState");
		IsTriggeredByState_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTriggeredByState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByState_EventReference_PropertyAddress, IsTriggeredByState_FunctionAddress, "EventReference");
		IsTriggeredByState_EventReference_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByState_FunctionAddress, "EventReference");
		IsTriggeredByState_EventReference_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByState_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByState_AnimInstance_PropertyAddress, IsTriggeredByState_FunctionAddress, "AnimInstance");
		IsTriggeredByState_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByState_FunctionAddress, "AnimInstance");
		IsTriggeredByState_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByState_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByState_StateName_PropertyAddress, IsTriggeredByState_FunctionAddress, "StateName");
		IsTriggeredByState_StateName_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByState_FunctionAddress, "StateName");
		IsTriggeredByState_StateName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByState_FunctionAddress, "StateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriggeredByState_ReturnValue_PropertyAddress, IsTriggeredByState_FunctionAddress, "ReturnValue");
		IsTriggeredByState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTriggeredByState_FunctionAddress, "ReturnValue");
		IsTriggeredByState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriggeredByState_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTriggeredByState_IsValid = IsTriggeredByState_FunctionAddress != IntPtr.Zero && IsTriggeredByState_EventReference_IsValid && IsTriggeredByState_AnimInstance_IsValid && IsTriggeredByState_StateName_IsValid && IsTriggeredByState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByState", IsTriggeredByState_IsValid);
	}
}
