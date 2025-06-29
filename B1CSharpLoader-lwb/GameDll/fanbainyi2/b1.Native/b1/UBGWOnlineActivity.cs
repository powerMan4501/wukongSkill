using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineActivity", "b1", UnrealModuleType.Game)]
public class UBGWOnlineActivity : UBGWOnlineInterface
{
	private static bool StartActivity_IsValid;

	private static IntPtr StartActivity_FunctionAddress;

	private static int StartActivity_ParamsSize;

	private static bool StartActivity_ActivityId_IsValid;

	private static FFieldAddress StartActivity_ActivityId_PropertyAddress;

	private static int StartActivity_ActivityId_Offset;

	private static bool SetActivityPriority_IsValid;

	private static IntPtr SetActivityPriority_FunctionAddress;

	private static int SetActivityPriority_ParamsSize;

	private static bool SetActivityPriority_PriorityMap_IsValid;

	private static FFieldAddress SetActivityPriority_PriorityMap_PropertyAddress;

	private static int SetActivityPriority_PriorityMap_Offset;

	private static bool SetActivityAvailability_IsValid;

	private static IntPtr SetActivityAvailability_FunctionAddress;

	private static int SetActivityAvailability_ParamsSize;

	private static bool SetActivityAvailability_ActivityId_IsValid;

	private static FFieldAddress SetActivityAvailability_ActivityId_PropertyAddress;

	private static int SetActivityAvailability_ActivityId_Offset;

	private static bool SetActivityAvailability_bEnable_IsValid;

	private static FFieldAddress SetActivityAvailability_bEnable_PropertyAddress;

	private static int SetActivityAvailability_bEnable_Offset;

	private static bool ResumeActivity_IsValid;

	private static IntPtr ResumeActivity_FunctionAddress;

	private static int ResumeActivity_ParamsSize;

	private static bool ResumeActivity_ActivityId_IsValid;

	private static FFieldAddress ResumeActivity_ActivityId_PropertyAddress;

	private static int ResumeActivity_ActivityId_Offset;

	private static bool ResumeActivity_InProgressTasks_IsValid;

	private static FFieldAddress ResumeActivity_InProgressTasks_PropertyAddress;

	private static int ResumeActivity_InProgressTasks_Offset;

	private static bool ResumeActivity_CompletedTasks_IsValid;

	private static FFieldAddress ResumeActivity_CompletedTasks_PropertyAddress;

	private static int ResumeActivity_CompletedTasks_Offset;

	private static bool ResetAllActiveActivities_IsValid;

	private static IntPtr ResetAllActiveActivities_FunctionAddress;

	private static int ResetAllActiveActivities_ParamsSize;

	private static bool OnStartActivityCompleteCS_IsValid;

	private IntPtr OnStartActivityCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnStartActivityCompleteCS_FunctionAddress;

	private static int OnStartActivityCompleteCS_ParamsSize;

	private static bool OnStartActivityCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnStartActivityCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnStartActivityCompleteCS_bWasSuccessful_Offset;

	private static bool OnSetActivityPriorityCompleteCS_IsValid;

	private IntPtr OnSetActivityPriorityCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnSetActivityPriorityCompleteCS_FunctionAddress;

	private static int OnSetActivityPriorityCompleteCS_ParamsSize;

	private static bool OnSetActivityPriorityCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnSetActivityPriorityCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnSetActivityPriorityCompleteCS_bWasSuccessful_Offset;

	private static bool OnSetActivityAvailabilityCompleteCS_IsValid;

	private IntPtr OnSetActivityAvailabilityCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnSetActivityAvailabilityCompleteCS_FunctionAddress;

	private static int OnSetActivityAvailabilityCompleteCS_ParamsSize;

	private static bool OnSetActivityAvailabilityCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnSetActivityAvailabilityCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnSetActivityAvailabilityCompleteCS_bWasSuccessful_Offset;

	private static bool OnResumeActivityCompleteCS_IsValid;

	private IntPtr OnResumeActivityCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnResumeActivityCompleteCS_FunctionAddress;

	private static int OnResumeActivityCompleteCS_ParamsSize;

	private static bool OnResumeActivityCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnResumeActivityCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnResumeActivityCompleteCS_bWasSuccessful_Offset;

	private static bool OnResetAllActiveActivitiesCompleteCS_IsValid;

	private IntPtr OnResetAllActiveActivitiesCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnResetAllActiveActivitiesCompleteCS_FunctionAddress;

	private static int OnResetAllActiveActivitiesCompleteCS_ParamsSize;

	private static bool OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_Offset;

	private static bool OnGameActivityActivationCompleteCS_IsValid;

	private IntPtr OnGameActivityActivationCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnGameActivityActivationCompleteCS_FunctionAddress;

	private static int OnGameActivityActivationCompleteCS_ParamsSize;

	private static bool OnGameActivityActivationCompleteCS_ActivityId_IsValid;

	private static FFieldAddress OnGameActivityActivationCompleteCS_ActivityId_PropertyAddress;

	private static int OnGameActivityActivationCompleteCS_ActivityId_Offset;

	private static bool OnGameActivityActivationCompleteCS_SessionStr_IsValid;

	private static FFieldAddress OnGameActivityActivationCompleteCS_SessionStr_PropertyAddress;

	private static int OnGameActivityActivationCompleteCS_SessionStr_Offset;

	private static bool OnEndActivityCompleteCS_IsValid;

	private IntPtr OnEndActivityCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnEndActivityCompleteCS_FunctionAddress;

	private static int OnEndActivityCompleteCS_ParamsSize;

	private static bool OnEndActivityCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnEndActivityCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnEndActivityCompleteCS_bWasSuccessful_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_ReturnValue_IsValid;

	private static FFieldAddress Init_ReturnValue_PropertyAddress;

	private static int Init_ReturnValue_Offset;

	private static bool EndActivity_IsValid;

	private static IntPtr EndActivity_FunctionAddress;

	private static int EndActivity_ParamsSize;

	private static bool EndActivity_ActivityId_IsValid;

	private static FFieldAddress EndActivity_ActivityId_PropertyAddress;

	private static int EndActivity_ActivityId_Offset;

	private static bool EndActivity_Outcome_IsValid;

	private static FFieldAddress EndActivity_Outcome_PropertyAddress;

	private static int EndActivity_Outcome_Offset;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:StartActivity")]
	public unsafe void StartActivity(string ActivityId)
	{
		CheckDestroyed();
		if (!StartActivity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:StartActivity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartActivity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartActivity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartActivity_ActivityId_Offset), 0, StartActivity_ActivityId_PropertyAddress.Address, ActivityId);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartActivity_FunctionAddress, intPtr, StartActivity_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartActivity_ActivityId_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:SetActivityPriority")]
	public unsafe void SetActivityPriority(Dictionary<string, int> PriorityMap)
	{
		CheckDestroyed();
		if (!SetActivityPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:SetActivityPriority");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActivityPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActivityPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetActivityPriority_PriorityMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, int>(1, SetActivityPriority_PriorityMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, SetActivityPriority_PriorityMap_Offset), PriorityMap);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActivityPriority_FunctionAddress, intPtr, SetActivityPriority_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetActivityPriority_PriorityMap_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:SetActivityAvailability")]
	public unsafe void SetActivityAvailability(string ActivityId, bool bEnable)
	{
		CheckDestroyed();
		if (!SetActivityAvailability_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:SetActivityAvailability");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActivityAvailability_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActivityAvailability_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetActivityAvailability_ActivityId_Offset), 0, SetActivityAvailability_ActivityId_PropertyAddress.Address, ActivityId);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActivityAvailability_bEnable_Offset), 0, SetActivityAvailability_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActivityAvailability_FunctionAddress, intPtr, SetActivityAvailability_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetActivityAvailability_ActivityId_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:ResumeActivity")]
	public unsafe void ResumeActivity(string ActivityId, List<string> InProgressTasks, List<string> CompletedTasks)
	{
		CheckDestroyed();
		if (!ResumeActivity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:ResumeActivity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResumeActivity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResumeActivity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ResumeActivity_ActivityId_Offset), 0, ResumeActivity_ActivityId_PropertyAddress.Address, ActivityId);
		new TArrayCopyMarshaler<string>(1, ResumeActivity_InProgressTasks_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ResumeActivity_InProgressTasks_Offset), InProgressTasks);
		new TArrayCopyMarshaler<string>(1, ResumeActivity_CompletedTasks_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ResumeActivity_CompletedTasks_Offset), CompletedTasks);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResumeActivity_FunctionAddress, intPtr, ResumeActivity_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResumeActivity_ActivityId_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ResumeActivity_InProgressTasks_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ResumeActivity_CompletedTasks_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:ResetAllActiveActivities")]
	public unsafe void ResetAllActiveActivities()
	{
		CheckDestroyed();
		if (!ResetAllActiveActivities_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:ResetAllActiveActivities");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetAllActiveActivities_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetAllActiveActivities_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetAllActiveActivities_FunctionAddress, argsSize: ResetAllActiveActivities_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:OnStartActivityCompleteCS")]
	protected unsafe void OnStartActivityCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnStartActivityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnStartActivityCompleteCS");
			return;
		}
		if (OnStartActivityCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnStartActivityCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnStartActivityCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStartActivityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStartActivityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnStartActivityCompleteCS_bWasSuccessful_Offset), 0, OnStartActivityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnStartActivityCompleteCS_InstanceFunctionAddress, intPtr, OnStartActivityCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnStartActivityCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnStartActivityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnStartActivityCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStartActivityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStartActivityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnStartActivityCompleteCS_bWasSuccessful_Offset), 0, OnStartActivityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnStartActivityCompleteCS_FunctionAddress, intPtr, OnStartActivityCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:OnSetActivityPriorityCompleteCS")]
	protected unsafe void OnSetActivityPriorityCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnSetActivityPriorityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnSetActivityPriorityCompleteCS");
			return;
		}
		if (OnSetActivityPriorityCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSetActivityPriorityCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSetActivityPriorityCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetActivityPriorityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetActivityPriorityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSetActivityPriorityCompleteCS_bWasSuccessful_Offset), 0, OnSetActivityPriorityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetActivityPriorityCompleteCS_InstanceFunctionAddress, intPtr, OnSetActivityPriorityCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnSetActivityPriorityCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnSetActivityPriorityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnSetActivityPriorityCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetActivityPriorityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetActivityPriorityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSetActivityPriorityCompleteCS_bWasSuccessful_Offset), 0, OnSetActivityPriorityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetActivityPriorityCompleteCS_FunctionAddress, intPtr, OnSetActivityPriorityCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:OnSetActivityAvailabilityCompleteCS")]
	protected unsafe void OnSetActivityAvailabilityCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnSetActivityAvailabilityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnSetActivityAvailabilityCompleteCS");
			return;
		}
		if (OnSetActivityAvailabilityCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSetActivityAvailabilityCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSetActivityAvailabilityCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetActivityAvailabilityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetActivityAvailabilityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSetActivityAvailabilityCompleteCS_bWasSuccessful_Offset), 0, OnSetActivityAvailabilityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetActivityAvailabilityCompleteCS_InstanceFunctionAddress, intPtr, OnSetActivityAvailabilityCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnSetActivityAvailabilityCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnSetActivityAvailabilityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnSetActivityAvailabilityCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetActivityAvailabilityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetActivityAvailabilityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSetActivityAvailabilityCompleteCS_bWasSuccessful_Offset), 0, OnSetActivityAvailabilityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetActivityAvailabilityCompleteCS_FunctionAddress, intPtr, OnSetActivityAvailabilityCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:OnResumeActivityCompleteCS")]
	protected unsafe void OnResumeActivityCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnResumeActivityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnResumeActivityCompleteCS");
			return;
		}
		if (OnResumeActivityCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnResumeActivityCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnResumeActivityCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnResumeActivityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnResumeActivityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnResumeActivityCompleteCS_bWasSuccessful_Offset), 0, OnResumeActivityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnResumeActivityCompleteCS_InstanceFunctionAddress, intPtr, OnResumeActivityCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnResumeActivityCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnResumeActivityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnResumeActivityCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnResumeActivityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnResumeActivityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnResumeActivityCompleteCS_bWasSuccessful_Offset), 0, OnResumeActivityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnResumeActivityCompleteCS_FunctionAddress, intPtr, OnResumeActivityCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:OnResetAllActiveActivitiesCompleteCS")]
	protected unsafe void OnResetAllActiveActivitiesCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnResetAllActiveActivitiesCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnResetAllActiveActivitiesCompleteCS");
			return;
		}
		if (OnResetAllActiveActivitiesCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnResetAllActiveActivitiesCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnResetAllActiveActivitiesCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnResetAllActiveActivitiesCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnResetAllActiveActivitiesCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_Offset), 0, OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnResetAllActiveActivitiesCompleteCS_InstanceFunctionAddress, intPtr, OnResetAllActiveActivitiesCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnResetAllActiveActivitiesCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnResetAllActiveActivitiesCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnResetAllActiveActivitiesCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnResetAllActiveActivitiesCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnResetAllActiveActivitiesCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_Offset), 0, OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnResetAllActiveActivitiesCompleteCS_FunctionAddress, intPtr, OnResetAllActiveActivitiesCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:OnGameActivityActivationCompleteCS")]
	protected unsafe void OnGameActivityActivationCompleteCS(string ActivityId, string SessionStr)
	{
		CheckDestroyed();
		if (!OnGameActivityActivationCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnGameActivityActivationCompleteCS");
			return;
		}
		if (OnGameActivityActivationCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnGameActivityActivationCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnGameActivityActivationCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnGameActivityActivationCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGameActivityActivationCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnGameActivityActivationCompleteCS_ActivityId_Offset), 0, OnGameActivityActivationCompleteCS_ActivityId_PropertyAddress.Address, ActivityId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnGameActivityActivationCompleteCS_SessionStr_Offset), 0, OnGameActivityActivationCompleteCS_SessionStr_PropertyAddress.Address, SessionStr);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnGameActivityActivationCompleteCS_InstanceFunctionAddress, intPtr, OnGameActivityActivationCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnGameActivityActivationCompleteCS_ActivityId_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnGameActivityActivationCompleteCS_SessionStr_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnGameActivityActivationCompleteCS_Implementation(string ActivityId, string SessionStr)
	{
		CheckDestroyed();
		if (!OnGameActivityActivationCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnGameActivityActivationCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnGameActivityActivationCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGameActivityActivationCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnGameActivityActivationCompleteCS_ActivityId_Offset), 0, OnGameActivityActivationCompleteCS_ActivityId_PropertyAddress.Address, ActivityId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnGameActivityActivationCompleteCS_SessionStr_Offset), 0, OnGameActivityActivationCompleteCS_SessionStr_PropertyAddress.Address, SessionStr);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnGameActivityActivationCompleteCS_FunctionAddress, intPtr, OnGameActivityActivationCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnGameActivityActivationCompleteCS_ActivityId_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnGameActivityActivationCompleteCS_SessionStr_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:OnEndActivityCompleteCS")]
	protected unsafe void OnEndActivityCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnEndActivityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnEndActivityCompleteCS");
			return;
		}
		if (OnEndActivityCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEndActivityCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEndActivityCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEndActivityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEndActivityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnEndActivityCompleteCS_bWasSuccessful_Offset), 0, OnEndActivityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEndActivityCompleteCS_InstanceFunctionAddress, intPtr, OnEndActivityCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnEndActivityCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnEndActivityCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:OnEndActivityCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEndActivityCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEndActivityCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnEndActivityCompleteCS_bWasSuccessful_Offset), 0, OnEndActivityCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEndActivityCompleteCS_FunctionAddress, intPtr, OnEndActivityCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:Init")]
	public unsafe int Init()
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:Init");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Init_FunctionAddress, intPtr, Init_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Init_ReturnValue_Offset), 0, Init_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:EndActivity")]
	public unsafe void EndActivity(string ActivityId, EOnlineActivityOutcomeType Outcome)
	{
		CheckDestroyed();
		if (!EndActivity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:EndActivity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndActivity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndActivity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EndActivity_ActivityId_Offset), 0, EndActivity_ActivityId_PropertyAddress.Address, ActivityId);
		EnumMarshaler<EOnlineActivityOutcomeType>.ToNative(IntPtr.Add(intPtr, EndActivity_Outcome_Offset), 0, EndActivity_Outcome_PropertyAddress.Address, Outcome);
		NativeReflection.InvokeFunctionOptimized(base.Address, EndActivity_FunctionAddress, intPtr, EndActivity_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EndActivity_ActivityId_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineActivity:Destroy")]
	public unsafe void Destroy()
	{
		CheckDestroyed();
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineActivity:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destroy_FunctionAddress, argsSize: Destroy_ParamsSize);
	}

	static UBGWOnlineActivity()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWOnlineActivity)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWOnlineActivity));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWOnlineActivity");
		StartActivity_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartActivity");
		StartActivity_ParamsSize = NativeReflection.GetFunctionParamsSize(StartActivity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartActivity_ActivityId_PropertyAddress, StartActivity_FunctionAddress, "ActivityId");
		StartActivity_ActivityId_Offset = NativeReflectionCached.GetPropertyOffset(StartActivity_FunctionAddress, "ActivityId");
		StartActivity_ActivityId_IsValid = NativeReflectionCached.ValidatePropertyClass(StartActivity_FunctionAddress, "ActivityId", Classes.FStrProperty);
		StartActivity_IsValid = StartActivity_FunctionAddress != IntPtr.Zero && StartActivity_ActivityId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:StartActivity", StartActivity_IsValid);
		SetActivityPriority_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetActivityPriority");
		SetActivityPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActivityPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActivityPriority_PriorityMap_PropertyAddress, SetActivityPriority_FunctionAddress, "PriorityMap");
		SetActivityPriority_PriorityMap_Offset = NativeReflectionCached.GetPropertyOffset(SetActivityPriority_FunctionAddress, "PriorityMap");
		SetActivityPriority_PriorityMap_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActivityPriority_FunctionAddress, "PriorityMap", Classes.FMapProperty);
		SetActivityPriority_IsValid = SetActivityPriority_FunctionAddress != IntPtr.Zero && SetActivityPriority_PriorityMap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:SetActivityPriority", SetActivityPriority_IsValid);
		SetActivityAvailability_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetActivityAvailability");
		SetActivityAvailability_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActivityAvailability_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActivityAvailability_ActivityId_PropertyAddress, SetActivityAvailability_FunctionAddress, "ActivityId");
		SetActivityAvailability_ActivityId_Offset = NativeReflectionCached.GetPropertyOffset(SetActivityAvailability_FunctionAddress, "ActivityId");
		SetActivityAvailability_ActivityId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActivityAvailability_FunctionAddress, "ActivityId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActivityAvailability_bEnable_PropertyAddress, SetActivityAvailability_FunctionAddress, "bEnable");
		SetActivityAvailability_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetActivityAvailability_FunctionAddress, "bEnable");
		SetActivityAvailability_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActivityAvailability_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetActivityAvailability_IsValid = SetActivityAvailability_FunctionAddress != IntPtr.Zero && SetActivityAvailability_ActivityId_IsValid && SetActivityAvailability_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:SetActivityAvailability", SetActivityAvailability_IsValid);
		ResumeActivity_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResumeActivity");
		ResumeActivity_ParamsSize = NativeReflection.GetFunctionParamsSize(ResumeActivity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResumeActivity_ActivityId_PropertyAddress, ResumeActivity_FunctionAddress, "ActivityId");
		ResumeActivity_ActivityId_Offset = NativeReflectionCached.GetPropertyOffset(ResumeActivity_FunctionAddress, "ActivityId");
		ResumeActivity_ActivityId_IsValid = NativeReflectionCached.ValidatePropertyClass(ResumeActivity_FunctionAddress, "ActivityId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ResumeActivity_InProgressTasks_PropertyAddress, ResumeActivity_FunctionAddress, "InProgressTasks");
		ResumeActivity_InProgressTasks_Offset = NativeReflectionCached.GetPropertyOffset(ResumeActivity_FunctionAddress, "InProgressTasks");
		ResumeActivity_InProgressTasks_IsValid = NativeReflectionCached.ValidatePropertyClass(ResumeActivity_FunctionAddress, "InProgressTasks", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ResumeActivity_CompletedTasks_PropertyAddress, ResumeActivity_FunctionAddress, "CompletedTasks");
		ResumeActivity_CompletedTasks_Offset = NativeReflectionCached.GetPropertyOffset(ResumeActivity_FunctionAddress, "CompletedTasks");
		ResumeActivity_CompletedTasks_IsValid = NativeReflectionCached.ValidatePropertyClass(ResumeActivity_FunctionAddress, "CompletedTasks", Classes.FArrayProperty);
		ResumeActivity_IsValid = ResumeActivity_FunctionAddress != IntPtr.Zero && ResumeActivity_ActivityId_IsValid && ResumeActivity_InProgressTasks_IsValid && ResumeActivity_CompletedTasks_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:ResumeActivity", ResumeActivity_IsValid);
		ResetAllActiveActivities_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetAllActiveActivities");
		ResetAllActiveActivities_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetAllActiveActivities_FunctionAddress);
		ResetAllActiveActivities_IsValid = ResetAllActiveActivities_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:ResetAllActiveActivities", ResetAllActiveActivities_IsValid);
		OnStartActivityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStartActivityCompleteCS");
		OnStartActivityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStartActivityCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnStartActivityCompleteCS_bWasSuccessful_PropertyAddress, OnStartActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStartActivityCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnStartActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStartActivityCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnStartActivityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnStartActivityCompleteCS_IsValid = OnStartActivityCompleteCS_FunctionAddress != IntPtr.Zero && OnStartActivityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:OnStartActivityCompleteCS", OnStartActivityCompleteCS_IsValid);
		OnSetActivityPriorityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSetActivityPriorityCompleteCS");
		OnSetActivityPriorityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetActivityPriorityCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSetActivityPriorityCompleteCS_bWasSuccessful_PropertyAddress, OnSetActivityPriorityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetActivityPriorityCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnSetActivityPriorityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetActivityPriorityCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSetActivityPriorityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnSetActivityPriorityCompleteCS_IsValid = OnSetActivityPriorityCompleteCS_FunctionAddress != IntPtr.Zero && OnSetActivityPriorityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:OnSetActivityPriorityCompleteCS", OnSetActivityPriorityCompleteCS_IsValid);
		OnSetActivityAvailabilityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSetActivityAvailabilityCompleteCS");
		OnSetActivityAvailabilityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetActivityAvailabilityCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSetActivityAvailabilityCompleteCS_bWasSuccessful_PropertyAddress, OnSetActivityAvailabilityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetActivityAvailabilityCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnSetActivityAvailabilityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetActivityAvailabilityCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSetActivityAvailabilityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnSetActivityAvailabilityCompleteCS_IsValid = OnSetActivityAvailabilityCompleteCS_FunctionAddress != IntPtr.Zero && OnSetActivityAvailabilityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:OnSetActivityAvailabilityCompleteCS", OnSetActivityAvailabilityCompleteCS_IsValid);
		OnResumeActivityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnResumeActivityCompleteCS");
		OnResumeActivityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResumeActivityCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnResumeActivityCompleteCS_bWasSuccessful_PropertyAddress, OnResumeActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnResumeActivityCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnResumeActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnResumeActivityCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnResumeActivityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnResumeActivityCompleteCS_IsValid = OnResumeActivityCompleteCS_FunctionAddress != IntPtr.Zero && OnResumeActivityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:OnResumeActivityCompleteCS", OnResumeActivityCompleteCS_IsValid);
		OnResetAllActiveActivitiesCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnResetAllActiveActivitiesCompleteCS");
		OnResetAllActiveActivitiesCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResetAllActiveActivitiesCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_PropertyAddress, OnResetAllActiveActivitiesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnResetAllActiveActivitiesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnResetAllActiveActivitiesCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnResetAllActiveActivitiesCompleteCS_IsValid = OnResetAllActiveActivitiesCompleteCS_FunctionAddress != IntPtr.Zero && OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:OnResetAllActiveActivitiesCompleteCS", OnResetAllActiveActivitiesCompleteCS_IsValid);
		OnGameActivityActivationCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnGameActivityActivationCompleteCS");
		OnGameActivityActivationCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGameActivityActivationCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnGameActivityActivationCompleteCS_ActivityId_PropertyAddress, OnGameActivityActivationCompleteCS_FunctionAddress, "ActivityId");
		OnGameActivityActivationCompleteCS_ActivityId_Offset = NativeReflectionCached.GetPropertyOffset(OnGameActivityActivationCompleteCS_FunctionAddress, "ActivityId");
		OnGameActivityActivationCompleteCS_ActivityId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGameActivityActivationCompleteCS_FunctionAddress, "ActivityId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnGameActivityActivationCompleteCS_SessionStr_PropertyAddress, OnGameActivityActivationCompleteCS_FunctionAddress, "SessionStr");
		OnGameActivityActivationCompleteCS_SessionStr_Offset = NativeReflectionCached.GetPropertyOffset(OnGameActivityActivationCompleteCS_FunctionAddress, "SessionStr");
		OnGameActivityActivationCompleteCS_SessionStr_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGameActivityActivationCompleteCS_FunctionAddress, "SessionStr", Classes.FStrProperty);
		OnGameActivityActivationCompleteCS_IsValid = OnGameActivityActivationCompleteCS_FunctionAddress != IntPtr.Zero && OnGameActivityActivationCompleteCS_ActivityId_IsValid && OnGameActivityActivationCompleteCS_SessionStr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:OnGameActivityActivationCompleteCS", OnGameActivityActivationCompleteCS_IsValid);
		OnEndActivityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEndActivityCompleteCS");
		OnEndActivityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndActivityCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEndActivityCompleteCS_bWasSuccessful_PropertyAddress, OnEndActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnEndActivityCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnEndActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnEndActivityCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEndActivityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnEndActivityCompleteCS_IsValid = OnEndActivityCompleteCS_FunctionAddress != IntPtr.Zero && OnEndActivityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:OnEndActivityCompleteCS", OnEndActivityCompleteCS_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_ReturnValue_PropertyAddress, Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:Init", Init_IsValid);
		EndActivity_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndActivity");
		EndActivity_ParamsSize = NativeReflection.GetFunctionParamsSize(EndActivity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndActivity_ActivityId_PropertyAddress, EndActivity_FunctionAddress, "ActivityId");
		EndActivity_ActivityId_Offset = NativeReflectionCached.GetPropertyOffset(EndActivity_FunctionAddress, "ActivityId");
		EndActivity_ActivityId_IsValid = NativeReflectionCached.ValidatePropertyClass(EndActivity_FunctionAddress, "ActivityId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EndActivity_Outcome_PropertyAddress, EndActivity_FunctionAddress, "Outcome");
		EndActivity_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(EndActivity_FunctionAddress, "Outcome");
		EndActivity_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(EndActivity_FunctionAddress, "Outcome", Classes.FEnumProperty);
		EndActivity_IsValid = EndActivity_FunctionAddress != IntPtr.Zero && EndActivity_ActivityId_IsValid && EndActivity_Outcome_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:EndActivity", EndActivity_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineActivity:Destroy", Destroy_IsValid);
	}
}
