using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GameplayTasks.GameplayTasksComponent", "GameplayTasks", UnrealModuleType.Engine)]
public class UGameplayTasksComponent : UActorComponent, IGameplayTaskOwnerInterface, IInterface
{
	private static IntPtr classAddress;

	private static bool OnClaimedResourcesChange_IsValid;

	private static int OnClaimedResourcesChange_Offset;

	private FOnClaimedResourcesChangeSignature OnClaimedResourcesChange_DelegateCached;

	private static bool RunGameplayTask_IsValid;

	private static IntPtr RunGameplayTask_FunctionAddress;

	private static int RunGameplayTask_ParamsSize;

	private static bool RunGameplayTask_TaskOwner_IsValid;

	private static FFieldAddress RunGameplayTask_TaskOwner_PropertyAddress;

	private static int RunGameplayTask_TaskOwner_Offset;

	private static bool RunGameplayTask_Task_IsValid;

	private static FFieldAddress RunGameplayTask_Task_PropertyAddress;

	private static int RunGameplayTask_Task_Offset;

	private static bool RunGameplayTask_Priority_IsValid;

	private static FFieldAddress RunGameplayTask_Priority_PropertyAddress;

	private static int RunGameplayTask_Priority_Offset;

	private static bool RunGameplayTask_AdditionalRequiredResources_IsValid;

	private static FFieldAddress RunGameplayTask_AdditionalRequiredResources_PropertyAddress;

	private static int RunGameplayTask_AdditionalRequiredResources_Offset;

	private static bool RunGameplayTask_AdditionalClaimedResources_IsValid;

	private static FFieldAddress RunGameplayTask_AdditionalClaimedResources_PropertyAddress;

	private static int RunGameplayTask_AdditionalClaimedResources_Offset;

	private static bool RunGameplayTask_ReturnValue_IsValid;

	private static FFieldAddress RunGameplayTask_ReturnValue_PropertyAddress;

	private static int RunGameplayTask_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627895300uL)]
	[UMetaPath("/Script/GameplayTasks.GameplayTasksComponent:OnClaimedResourcesChange")]
	public FOnClaimedResourcesChangeSignature OnClaimedResourcesChange
	{
		get
		{
			CheckDestroyed();
			if (!OnClaimedResourcesChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayTasks.GameplayTasksComponent:OnClaimedResourcesChange");
				return new FOnClaimedResourcesChangeSignature();
			}
			if (OnClaimedResourcesChange_DelegateCached == null)
			{
				OnClaimedResourcesChange_DelegateCached = new FOnClaimedResourcesChangeSignature();
				OnClaimedResourcesChange_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnClaimedResourcesChange_Offset));
			}
			return OnClaimedResourcesChange_DelegateCached;
		}
	}

	[UFunction(Flags = 67249153u, OriginalName = "K2_RunGameplayTask")]
	[UMetaPath("/Script/GameplayTasks.GameplayTasksComponent:K2_RunGameplayTask")]
	public unsafe static EGameplayTaskRunResult RunGameplayTask(IGameplayTaskOwnerInterface TaskOwner, UGameplayTask Task, byte Priority, ref List<TSubclassOf<UGameplayTaskResource>> AdditionalRequiredResources, ref List<TSubclassOf<UGameplayTaskResource>> AdditionalClaimedResources)
	{
		if (!RunGameplayTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTasks.GameplayTasksComponent:K2_RunGameplayTask");
			return EGameplayTaskRunResult.Error;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunGameplayTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunGameplayTask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<IGameplayTaskOwnerInterface>.ToNative(IntPtr.Add(intPtr, RunGameplayTask_TaskOwner_Offset), 0, RunGameplayTask_TaskOwner_PropertyAddress.Address, TaskOwner);
		UObjectMarshaler<UGameplayTask>.ToNative(IntPtr.Add(intPtr, RunGameplayTask_Task_Offset), 0, RunGameplayTask_Task_PropertyAddress.Address, Task);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, RunGameplayTask_Priority_Offset), 0, RunGameplayTask_Priority_PropertyAddress.Address, Priority);
		new TArrayCopyMarshaler<TSubclassOf<UGameplayTaskResource>>(1, RunGameplayTask_AdditionalRequiredResources_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UGameplayTaskResource>, TSubclassOfMarshaler<UGameplayTaskResource>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UGameplayTaskResource>, TSubclassOfMarshaler<UGameplayTaskResource>>.ToNative).ToNative(IntPtr.Add(intPtr, RunGameplayTask_AdditionalRequiredResources_Offset), AdditionalRequiredResources);
		new TArrayCopyMarshaler<TSubclassOf<UGameplayTaskResource>>(1, RunGameplayTask_AdditionalClaimedResources_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UGameplayTaskResource>, TSubclassOfMarshaler<UGameplayTaskResource>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UGameplayTaskResource>, TSubclassOfMarshaler<UGameplayTaskResource>>.ToNative).ToNative(IntPtr.Add(intPtr, RunGameplayTask_AdditionalClaimedResources_Offset), AdditionalClaimedResources);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RunGameplayTask_FunctionAddress, intPtr, RunGameplayTask_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RunGameplayTask_AdditionalRequiredResources_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RunGameplayTask_AdditionalClaimedResources_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EGameplayTaskRunResult>.FromNative(IntPtr.Add(intPtr, RunGameplayTask_ReturnValue_Offset), 0, RunGameplayTask_ReturnValue_PropertyAddress.Address);
	}

	static UGameplayTasksComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameplayTasksComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameplayTasksComponent));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GameplayTasks.GameplayTasksComponent");
		OnClaimedResourcesChange_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnClaimedResourcesChange");
		OnClaimedResourcesChange_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnClaimedResourcesChange", Classes.FMulticastDelegateProperty);
		RunGameplayTask_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_RunGameplayTask");
		RunGameplayTask_ParamsSize = NativeReflection.GetFunctionParamsSize(RunGameplayTask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunGameplayTask_TaskOwner_PropertyAddress, RunGameplayTask_FunctionAddress, "TaskOwner");
		RunGameplayTask_TaskOwner_Offset = NativeReflectionCached.GetPropertyOffset(RunGameplayTask_FunctionAddress, "TaskOwner");
		RunGameplayTask_TaskOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(RunGameplayTask_FunctionAddress, "TaskOwner", Classes.FInterfaceProperty);
		NativeReflectionCached.GetPropertyRef(ref RunGameplayTask_Task_PropertyAddress, RunGameplayTask_FunctionAddress, "Task");
		RunGameplayTask_Task_Offset = NativeReflectionCached.GetPropertyOffset(RunGameplayTask_FunctionAddress, "Task");
		RunGameplayTask_Task_IsValid = NativeReflectionCached.ValidatePropertyClass(RunGameplayTask_FunctionAddress, "Task", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RunGameplayTask_Priority_PropertyAddress, RunGameplayTask_FunctionAddress, "Priority");
		RunGameplayTask_Priority_Offset = NativeReflectionCached.GetPropertyOffset(RunGameplayTask_FunctionAddress, "Priority");
		RunGameplayTask_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(RunGameplayTask_FunctionAddress, "Priority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref RunGameplayTask_AdditionalRequiredResources_PropertyAddress, RunGameplayTask_FunctionAddress, "AdditionalRequiredResources");
		RunGameplayTask_AdditionalRequiredResources_Offset = NativeReflectionCached.GetPropertyOffset(RunGameplayTask_FunctionAddress, "AdditionalRequiredResources");
		RunGameplayTask_AdditionalRequiredResources_IsValid = NativeReflectionCached.ValidatePropertyClass(RunGameplayTask_FunctionAddress, "AdditionalRequiredResources", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RunGameplayTask_AdditionalClaimedResources_PropertyAddress, RunGameplayTask_FunctionAddress, "AdditionalClaimedResources");
		RunGameplayTask_AdditionalClaimedResources_Offset = NativeReflectionCached.GetPropertyOffset(RunGameplayTask_FunctionAddress, "AdditionalClaimedResources");
		RunGameplayTask_AdditionalClaimedResources_IsValid = NativeReflectionCached.ValidatePropertyClass(RunGameplayTask_FunctionAddress, "AdditionalClaimedResources", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RunGameplayTask_ReturnValue_PropertyAddress, RunGameplayTask_FunctionAddress, "ReturnValue");
		RunGameplayTask_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RunGameplayTask_FunctionAddress, "ReturnValue");
		RunGameplayTask_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RunGameplayTask_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		RunGameplayTask_IsValid = RunGameplayTask_FunctionAddress != IntPtr.Zero && RunGameplayTask_TaskOwner_IsValid && RunGameplayTask_Task_IsValid && RunGameplayTask_Priority_IsValid && RunGameplayTask_AdditionalRequiredResources_IsValid && RunGameplayTask_AdditionalClaimedResources_IsValid && RunGameplayTask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTasks.GameplayTasksComponent:K2_RunGameplayTask", RunGameplayTask_IsValid);
	}
}
