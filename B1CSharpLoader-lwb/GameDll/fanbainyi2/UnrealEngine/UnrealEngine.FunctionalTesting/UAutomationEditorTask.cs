using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.AutomationEditorTask", "FunctionalTesting", UnrealModuleType.Engine)]
public class UAutomationEditorTask : UObject
{
	private static bool IsValidTask_IsValid;

	private static IntPtr IsValidTask_FunctionAddress;

	private static int IsValidTask_ParamsSize;

	private static bool IsValidTask_ReturnValue_IsValid;

	private static FFieldAddress IsValidTask_ReturnValue_PropertyAddress;

	private static int IsValidTask_ReturnValue_Offset;

	private static bool IsTaskDone_IsValid;

	private static IntPtr IsTaskDone_FunctionAddress;

	private static int IsTaskDone_ParamsSize;

	private static bool IsTaskDone_ReturnValue_IsValid;

	private static FFieldAddress IsTaskDone_ReturnValue_PropertyAddress;

	private static int IsTaskDone_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationEditorTask:IsValidTask")]
	public unsafe bool IsValidTask()
	{
		CheckDestroyed();
		if (!IsValidTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationEditorTask:IsValidTask");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidTask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsValidTask_FunctionAddress, intPtr, IsValidTask_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidTask_ReturnValue_Offset), 0, IsValidTask_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationEditorTask:IsTaskDone")]
	public unsafe bool IsTaskDone()
	{
		CheckDestroyed();
		if (!IsTaskDone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationEditorTask:IsTaskDone");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTaskDone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTaskDone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTaskDone_FunctionAddress, intPtr, IsTaskDone_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTaskDone_ReturnValue_Offset), 0, IsTaskDone_ReturnValue_PropertyAddress.Address);
	}

	static UAutomationEditorTask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAutomationEditorTask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAutomationEditorTask));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FunctionalTesting.AutomationEditorTask");
		IsValidTask_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsValidTask");
		IsValidTask_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidTask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidTask_ReturnValue_PropertyAddress, IsValidTask_FunctionAddress, "ReturnValue");
		IsValidTask_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidTask_FunctionAddress, "ReturnValue");
		IsValidTask_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidTask_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidTask_IsValid = IsValidTask_FunctionAddress != IntPtr.Zero && IsValidTask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationEditorTask:IsValidTask", IsValidTask_IsValid);
		IsTaskDone_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsTaskDone");
		IsTaskDone_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTaskDone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTaskDone_ReturnValue_PropertyAddress, IsTaskDone_FunctionAddress, "ReturnValue");
		IsTaskDone_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTaskDone_FunctionAddress, "ReturnValue");
		IsTaskDone_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTaskDone_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTaskDone_IsValid = IsTaskDone_FunctionAddress != IntPtr.Zero && IsTaskDone_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationEditorTask:IsTaskDone", IsTaskDone_IsValid);
	}
}
