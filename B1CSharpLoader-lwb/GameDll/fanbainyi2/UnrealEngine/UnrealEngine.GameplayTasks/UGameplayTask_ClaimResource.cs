using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[UClass(Flags = (ClassFlags)810549412uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/GameplayTasks.GameplayTask_ClaimResource", "GameplayTasks", UnrealModuleType.Engine)]
public class UGameplayTask_ClaimResource : UGameplayTask
{
	private static IntPtr classAddress;

	private static bool ClaimResources_IsValid;

	private static IntPtr ClaimResources_FunctionAddress;

	private static int ClaimResources_ParamsSize;

	private static bool ClaimResources_InTaskOwner_IsValid;

	private static FFieldAddress ClaimResources_InTaskOwner_PropertyAddress;

	private static int ClaimResources_InTaskOwner_Offset;

	private static bool ClaimResources_ResourceClasses_IsValid;

	private static FFieldAddress ClaimResources_ResourceClasses_PropertyAddress;

	private static int ClaimResources_ResourceClasses_Offset;

	private static bool ClaimResources_Priority_IsValid;

	private static FFieldAddress ClaimResources_Priority_PropertyAddress;

	private static int ClaimResources_Priority_Offset;

	private static bool ClaimResources_TaskInstanceName_IsValid;

	private static FFieldAddress ClaimResources_TaskInstanceName_PropertyAddress;

	private static int ClaimResources_TaskInstanceName_Offset;

	private static bool ClaimResources_ReturnValue_IsValid;

	private static FFieldAddress ClaimResources_ReturnValue_PropertyAddress;

	private static int ClaimResources_ReturnValue_Offset;

	private static bool ClaimResource_IsValid;

	private static IntPtr ClaimResource_FunctionAddress;

	private static int ClaimResource_ParamsSize;

	private static bool ClaimResource_InTaskOwner_IsValid;

	private static FFieldAddress ClaimResource_InTaskOwner_PropertyAddress;

	private static int ClaimResource_InTaskOwner_Offset;

	private static bool ClaimResource_ResourceClass_IsValid;

	private static FFieldAddress ClaimResource_ResourceClass_PropertyAddress;

	private static int ClaimResource_ResourceClass_Offset;

	private static bool ClaimResource_Priority_IsValid;

	private static FFieldAddress ClaimResource_Priority_PropertyAddress;

	private static int ClaimResource_Priority_Offset;

	private static bool ClaimResource_TaskInstanceName_IsValid;

	private static FFieldAddress ClaimResource_TaskInstanceName_PropertyAddress;

	private static int ClaimResource_TaskInstanceName_Offset;

	private static bool ClaimResource_ReturnValue_IsValid;

	private static FFieldAddress ClaimResource_ReturnValue_PropertyAddress;

	private static int ClaimResource_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GameplayTasks.GameplayTask_ClaimResource:ClaimResources")]
	public unsafe static UGameplayTask_ClaimResource ClaimResources(IGameplayTaskOwnerInterface InTaskOwner, List<TSubclassOf<UGameplayTaskResource>> ResourceClasses, byte Priority, FName TaskInstanceName)
	{
		if (!ClaimResources_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTasks.GameplayTask_ClaimResource:ClaimResources");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClaimResources_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClaimResources_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<IGameplayTaskOwnerInterface>.ToNative(IntPtr.Add(intPtr, ClaimResources_InTaskOwner_Offset), 0, ClaimResources_InTaskOwner_PropertyAddress.Address, InTaskOwner);
		new TArrayCopyMarshaler<TSubclassOf<UGameplayTaskResource>>(1, ClaimResources_ResourceClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UGameplayTaskResource>, TSubclassOfMarshaler<UGameplayTaskResource>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UGameplayTaskResource>, TSubclassOfMarshaler<UGameplayTaskResource>>.ToNative).ToNative(IntPtr.Add(intPtr, ClaimResources_ResourceClasses_Offset), ResourceClasses);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, ClaimResources_Priority_Offset), 0, ClaimResources_Priority_PropertyAddress.Address, Priority);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClaimResources_TaskInstanceName_Offset), 0, ClaimResources_TaskInstanceName_PropertyAddress.Address, TaskInstanceName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClaimResources_FunctionAddress, intPtr, ClaimResources_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ClaimResources_ResourceClasses_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UGameplayTask_ClaimResource>.FromNative(IntPtr.Add(intPtr, ClaimResources_ReturnValue_Offset), 0, ClaimResources_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GameplayTasks.GameplayTask_ClaimResource:ClaimResource")]
	public unsafe static UGameplayTask_ClaimResource ClaimResource(IGameplayTaskOwnerInterface InTaskOwner, TSubclassOf<UGameplayTaskResource> ResourceClass, byte Priority, FName TaskInstanceName)
	{
		if (!ClaimResource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTasks.GameplayTask_ClaimResource:ClaimResource");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClaimResource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClaimResource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<IGameplayTaskOwnerInterface>.ToNative(IntPtr.Add(intPtr, ClaimResource_InTaskOwner_Offset), 0, ClaimResource_InTaskOwner_PropertyAddress.Address, InTaskOwner);
		TSubclassOfMarshaler<UGameplayTaskResource>.ToNative(IntPtr.Add(intPtr, ClaimResource_ResourceClass_Offset), 0, ClaimResource_ResourceClass_PropertyAddress.Address, ResourceClass);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, ClaimResource_Priority_Offset), 0, ClaimResource_Priority_PropertyAddress.Address, Priority);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClaimResource_TaskInstanceName_Offset), 0, ClaimResource_TaskInstanceName_PropertyAddress.Address, TaskInstanceName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClaimResource_FunctionAddress, intPtr, ClaimResource_ParamsSize);
		return UObjectMarshaler<UGameplayTask_ClaimResource>.FromNative(IntPtr.Add(intPtr, ClaimResource_ReturnValue_Offset), 0, ClaimResource_ReturnValue_PropertyAddress.Address);
	}

	static UGameplayTask_ClaimResource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameplayTask_ClaimResource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameplayTask_ClaimResource));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GameplayTasks.GameplayTask_ClaimResource");
		ClaimResources_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClaimResources");
		ClaimResources_ParamsSize = NativeReflection.GetFunctionParamsSize(ClaimResources_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClaimResources_InTaskOwner_PropertyAddress, ClaimResources_FunctionAddress, "InTaskOwner");
		ClaimResources_InTaskOwner_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResources_FunctionAddress, "InTaskOwner");
		ClaimResources_InTaskOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResources_FunctionAddress, "InTaskOwner", Classes.FInterfaceProperty);
		NativeReflectionCached.GetPropertyRef(ref ClaimResources_ResourceClasses_PropertyAddress, ClaimResources_FunctionAddress, "ResourceClasses");
		ClaimResources_ResourceClasses_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResources_FunctionAddress, "ResourceClasses");
		ClaimResources_ResourceClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResources_FunctionAddress, "ResourceClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ClaimResources_Priority_PropertyAddress, ClaimResources_FunctionAddress, "Priority");
		ClaimResources_Priority_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResources_FunctionAddress, "Priority");
		ClaimResources_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResources_FunctionAddress, "Priority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ClaimResources_TaskInstanceName_PropertyAddress, ClaimResources_FunctionAddress, "TaskInstanceName");
		ClaimResources_TaskInstanceName_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResources_FunctionAddress, "TaskInstanceName");
		ClaimResources_TaskInstanceName_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResources_FunctionAddress, "TaskInstanceName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ClaimResources_ReturnValue_PropertyAddress, ClaimResources_FunctionAddress, "ReturnValue");
		ClaimResources_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResources_FunctionAddress, "ReturnValue");
		ClaimResources_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResources_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ClaimResources_IsValid = ClaimResources_FunctionAddress != IntPtr.Zero && ClaimResources_InTaskOwner_IsValid && ClaimResources_ResourceClasses_IsValid && ClaimResources_Priority_IsValid && ClaimResources_TaskInstanceName_IsValid && ClaimResources_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTasks.GameplayTask_ClaimResource:ClaimResources", ClaimResources_IsValid);
		ClaimResource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClaimResource");
		ClaimResource_ParamsSize = NativeReflection.GetFunctionParamsSize(ClaimResource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClaimResource_InTaskOwner_PropertyAddress, ClaimResource_FunctionAddress, "InTaskOwner");
		ClaimResource_InTaskOwner_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResource_FunctionAddress, "InTaskOwner");
		ClaimResource_InTaskOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResource_FunctionAddress, "InTaskOwner", Classes.FInterfaceProperty);
		NativeReflectionCached.GetPropertyRef(ref ClaimResource_ResourceClass_PropertyAddress, ClaimResource_FunctionAddress, "ResourceClass");
		ClaimResource_ResourceClass_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResource_FunctionAddress, "ResourceClass");
		ClaimResource_ResourceClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResource_FunctionAddress, "ResourceClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ClaimResource_Priority_PropertyAddress, ClaimResource_FunctionAddress, "Priority");
		ClaimResource_Priority_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResource_FunctionAddress, "Priority");
		ClaimResource_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResource_FunctionAddress, "Priority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ClaimResource_TaskInstanceName_PropertyAddress, ClaimResource_FunctionAddress, "TaskInstanceName");
		ClaimResource_TaskInstanceName_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResource_FunctionAddress, "TaskInstanceName");
		ClaimResource_TaskInstanceName_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResource_FunctionAddress, "TaskInstanceName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ClaimResource_ReturnValue_PropertyAddress, ClaimResource_FunctionAddress, "ReturnValue");
		ClaimResource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClaimResource_FunctionAddress, "ReturnValue");
		ClaimResource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimResource_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ClaimResource_IsValid = ClaimResource_FunctionAddress != IntPtr.Zero && ClaimResource_InTaskOwner_IsValid && ClaimResource_ResourceClass_IsValid && ClaimResource_Priority_IsValid && ClaimResource_TaskInstanceName_IsValid && ClaimResource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTasks.GameplayTask_ClaimResource:ClaimResource", ClaimResource_IsValid);
	}
}
