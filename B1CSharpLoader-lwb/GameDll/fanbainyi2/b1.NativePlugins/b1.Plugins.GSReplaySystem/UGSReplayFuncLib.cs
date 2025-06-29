using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSReplaySystem;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib", "GSReplaySystem", UnrealModuleType.GamePlugin)]
public class UGSReplayFuncLib : UObject
{
	private static IntPtr classAddress;

	private static bool UnRegisterNetworkRemapPath_IsValid;

	private static IntPtr UnRegisterNetworkRemapPath_FunctionAddress;

	private static int UnRegisterNetworkRemapPath_ParamsSize;

	private static bool UnRegisterNetworkRemapPath_WorldContext_IsValid;

	private static FFieldAddress UnRegisterNetworkRemapPath_WorldContext_PropertyAddress;

	private static int UnRegisterNetworkRemapPath_WorldContext_Offset;

	private static bool UnregisterCSharpFuncLibObj_IsValid;

	private static IntPtr UnregisterCSharpFuncLibObj_FunctionAddress;

	private static int UnregisterCSharpFuncLibObj_ParamsSize;

	private static bool UnregisterCSharpFuncLibObj_WorldContext_IsValid;

	private static FFieldAddress UnregisterCSharpFuncLibObj_WorldContext_PropertyAddress;

	private static int UnregisterCSharpFuncLibObj_WorldContext_Offset;

	private static bool StopReplay_IsValid;

	private static IntPtr StopReplay_FunctionAddress;

	private static int StopReplay_ParamsSize;

	private static bool StopReplay_WorldContext_IsValid;

	private static FFieldAddress StopReplay_WorldContext_PropertyAddress;

	private static int StopReplay_WorldContext_Offset;

	private static bool SkipTime_IsValid;

	private static IntPtr SkipTime_FunctionAddress;

	private static int SkipTime_ParamsSize;

	private static bool SkipTime_WorldContext_IsValid;

	private static FFieldAddress SkipTime_WorldContext_PropertyAddress;

	private static int SkipTime_WorldContext_Offset;

	private static bool SkipTime_InTimeToSkip_IsValid;

	private static FFieldAddress SkipTime_InTimeToSkip_PropertyAddress;

	private static int SkipTime_InTimeToSkip_Offset;

	private static bool SetDemoPlayTimeDilation_IsValid;

	private static IntPtr SetDemoPlayTimeDilation_FunctionAddress;

	private static int SetDemoPlayTimeDilation_ParamsSize;

	private static bool SetDemoPlayTimeDilation_WorldContext_IsValid;

	private static FFieldAddress SetDemoPlayTimeDilation_WorldContext_PropertyAddress;

	private static int SetDemoPlayTimeDilation_WorldContext_Offset;

	private static bool SetDemoPlayTimeDilation_InDemoPlayTimeDilation_IsValid;

	private static FFieldAddress SetDemoPlayTimeDilation_InDemoPlayTimeDilation_PropertyAddress;

	private static int SetDemoPlayTimeDilation_InDemoPlayTimeDilation_Offset;

	private static bool SetDemoCurrentTime_IsValid;

	private static IntPtr SetDemoCurrentTime_FunctionAddress;

	private static int SetDemoCurrentTime_ParamsSize;

	private static bool SetDemoCurrentTime_WorldContext_IsValid;

	private static FFieldAddress SetDemoCurrentTime_WorldContext_PropertyAddress;

	private static int SetDemoCurrentTime_WorldContext_Offset;

	private static bool SetDemoCurrentTime_CurrentTime_IsValid;

	private static FFieldAddress SetDemoCurrentTime_CurrentTime_PropertyAddress;

	private static int SetDemoCurrentTime_CurrentTime_Offset;

	private static bool SetActorPrioritizationEnabled_IsValid;

	private static IntPtr SetActorPrioritizationEnabled_FunctionAddress;

	private static int SetActorPrioritizationEnabled_ParamsSize;

	private static bool SetActorPrioritizationEnabled_WorldContext_IsValid;

	private static FFieldAddress SetActorPrioritizationEnabled_WorldContext_PropertyAddress;

	private static int SetActorPrioritizationEnabled_WorldContext_Offset;

	private static bool SetActorPrioritizationEnabled_bInPrioritizeActors_IsValid;

	private static FFieldAddress SetActorPrioritizationEnabled_bInPrioritizeActors_PropertyAddress;

	private static int SetActorPrioritizationEnabled_bInPrioritizeActors_Offset;

	private static bool RequestCheckpoint_IsValid;

	private static IntPtr RequestCheckpoint_FunctionAddress;

	private static int RequestCheckpoint_ParamsSize;

	private static bool RequestCheckpoint_WorldContext_IsValid;

	private static FFieldAddress RequestCheckpoint_WorldContext_PropertyAddress;

	private static int RequestCheckpoint_WorldContext_Offset;

	private static bool RegisterNetworkRemapPath_IsValid;

	private static IntPtr RegisterNetworkRemapPath_FunctionAddress;

	private static int RegisterNetworkRemapPath_ParamsSize;

	private static bool RegisterNetworkRemapPath_WorldContext_IsValid;

	private static FFieldAddress RegisterNetworkRemapPath_WorldContext_PropertyAddress;

	private static int RegisterNetworkRemapPath_WorldContext_Offset;

	private static bool RegisterNetworkRemapPath_ReturnValue_IsValid;

	private static FFieldAddress RegisterNetworkRemapPath_ReturnValue_PropertyAddress;

	private static int RegisterNetworkRemapPath_ReturnValue_Offset;

	private static bool RegisterCSharpFuncLibObj_IsValid;

	private static IntPtr RegisterCSharpFuncLibObj_FunctionAddress;

	private static int RegisterCSharpFuncLibObj_ParamsSize;

	private static bool RegisterCSharpFuncLibObj_WorldContext_IsValid;

	private static FFieldAddress RegisterCSharpFuncLibObj_WorldContext_PropertyAddress;

	private static int RegisterCSharpFuncLibObj_WorldContext_Offset;

	private static bool RegisterCSharpFuncLibObj_CSharpFuncLibObj_IsValid;

	private static FFieldAddress RegisterCSharpFuncLibObj_CSharpFuncLibObj_PropertyAddress;

	private static int RegisterCSharpFuncLibObj_CSharpFuncLibObj_Offset;

	private static bool RecordReplayToLocalFile_IsValid;

	private static IntPtr RecordReplayToLocalFile_FunctionAddress;

	private static int RecordReplayToLocalFile_ParamsSize;

	private static bool RecordReplayToLocalFile_WorldContext_IsValid;

	private static FFieldAddress RecordReplayToLocalFile_WorldContext_PropertyAddress;

	private static int RecordReplayToLocalFile_WorldContext_Offset;

	private static bool RecordReplayToLocalFile_Name_IsValid;

	private static FFieldAddress RecordReplayToLocalFile_Name_PropertyAddress;

	private static int RecordReplayToLocalFile_Name_Offset;

	private static bool RecordReplayToLocalFile_FriendlyName_IsValid;

	private static FFieldAddress RecordReplayToLocalFile_FriendlyName_PropertyAddress;

	private static int RecordReplayToLocalFile_FriendlyName_Offset;

	private static bool RecordReplayToLocalFile_InOptions_IsValid;

	private static FFieldAddress RecordReplayToLocalFile_InOptions_PropertyAddress;

	private static int RecordReplayToLocalFile_InOptions_Offset;

	private static bool PlayReplayFromLocalFile_IsValid;

	private static IntPtr PlayReplayFromLocalFile_FunctionAddress;

	private static int PlayReplayFromLocalFile_ParamsSize;

	private static bool PlayReplayFromLocalFile_WorldContext_IsValid;

	private static FFieldAddress PlayReplayFromLocalFile_WorldContext_PropertyAddress;

	private static int PlayReplayFromLocalFile_WorldContext_Offset;

	private static bool PlayReplayFromLocalFile_Name_IsValid;

	private static FFieldAddress PlayReplayFromLocalFile_Name_PropertyAddress;

	private static int PlayReplayFromLocalFile_Name_Offset;

	private static bool PlayReplayFromLocalFile_InOptions_IsValid;

	private static FFieldAddress PlayReplayFromLocalFile_InOptions_PropertyAddress;

	private static int PlayReplayFromLocalFile_InOptions_Offset;

	private static bool PauseReplay_IsValid;

	private static IntPtr PauseReplay_FunctionAddress;

	private static int PauseReplay_ParamsSize;

	private static bool PauseReplay_WorldContext_IsValid;

	private static FFieldAddress PauseReplay_WorldContext_PropertyAddress;

	private static int PauseReplay_WorldContext_Offset;

	private static bool PauseReplay_bPause_IsValid;

	private static FFieldAddress PauseReplay_bPause_PropertyAddress;

	private static int PauseReplay_bPause_Offset;

	private static bool IsReplayPause_IsValid;

	private static IntPtr IsReplayPause_FunctionAddress;

	private static int IsReplayPause_ParamsSize;

	private static bool IsReplayPause_WorldContext_IsValid;

	private static FFieldAddress IsReplayPause_WorldContext_PropertyAddress;

	private static int IsReplayPause_WorldContext_Offset;

	private static bool IsReplayPause_ReturnValue_IsValid;

	private static FFieldAddress IsReplayPause_ReturnValue_PropertyAddress;

	private static int IsReplayPause_ReturnValue_Offset;

	private static bool IsRecordingReplay_IsValid;

	private static IntPtr IsRecordingReplay_FunctionAddress;

	private static int IsRecordingReplay_ParamsSize;

	private static bool IsRecordingReplay_WorldContext_IsValid;

	private static FFieldAddress IsRecordingReplay_WorldContext_PropertyAddress;

	private static int IsRecordingReplay_WorldContext_Offset;

	private static bool IsRecordingReplay_ReturnValue_IsValid;

	private static FFieldAddress IsRecordingReplay_ReturnValue_PropertyAddress;

	private static int IsRecordingReplay_ReturnValue_Offset;

	private static bool IsPlayingReplay_IsValid;

	private static IntPtr IsPlayingReplay_FunctionAddress;

	private static int IsPlayingReplay_ParamsSize;

	private static bool IsPlayingReplay_WorldContext_IsValid;

	private static FFieldAddress IsPlayingReplay_WorldContext_PropertyAddress;

	private static int IsPlayingReplay_WorldContext_Offset;

	private static bool IsPlayingReplay_ReturnValue_IsValid;

	private static FFieldAddress IsPlayingReplay_ReturnValue_PropertyAddress;

	private static int IsPlayingReplay_ReturnValue_Offset;

	private static bool IsLoadingCheckpoint_IsValid;

	private static IntPtr IsLoadingCheckpoint_FunctionAddress;

	private static int IsLoadingCheckpoint_ParamsSize;

	private static bool IsLoadingCheckpoint_WorldContext_IsValid;

	private static FFieldAddress IsLoadingCheckpoint_WorldContext_PropertyAddress;

	private static int IsLoadingCheckpoint_WorldContext_Offset;

	private static bool IsLoadingCheckpoint_ReturnValue_IsValid;

	private static FFieldAddress IsLoadingCheckpoint_ReturnValue_PropertyAddress;

	private static int IsLoadingCheckpoint_ReturnValue_Offset;

	private static bool GetLastCheckpointTime_IsValid;

	private static IntPtr GetLastCheckpointTime_FunctionAddress;

	private static int GetLastCheckpointTime_ParamsSize;

	private static bool GetLastCheckpointTime_WorldContext_IsValid;

	private static FFieldAddress GetLastCheckpointTime_WorldContext_PropertyAddress;

	private static int GetLastCheckpointTime_WorldContext_Offset;

	private static bool GetLastCheckpointTime_ReturnValue_IsValid;

	private static FFieldAddress GetLastCheckpointTime_ReturnValue_PropertyAddress;

	private static int GetLastCheckpointTime_ReturnValue_Offset;

	private static bool GetDemoTotalTime_IsValid;

	private static IntPtr GetDemoTotalTime_FunctionAddress;

	private static int GetDemoTotalTime_ParamsSize;

	private static bool GetDemoTotalTime_WorldContext_IsValid;

	private static FFieldAddress GetDemoTotalTime_WorldContext_PropertyAddress;

	private static int GetDemoTotalTime_WorldContext_Offset;

	private static bool GetDemoTotalTime_ReturnValue_IsValid;

	private static FFieldAddress GetDemoTotalTime_ReturnValue_PropertyAddress;

	private static int GetDemoTotalTime_ReturnValue_Offset;

	private static bool GetDemoPlayTimeDilation_IsValid;

	private static IntPtr GetDemoPlayTimeDilation_FunctionAddress;

	private static int GetDemoPlayTimeDilation_ParamsSize;

	private static bool GetDemoPlayTimeDilation_WorldContext_IsValid;

	private static FFieldAddress GetDemoPlayTimeDilation_WorldContext_PropertyAddress;

	private static int GetDemoPlayTimeDilation_WorldContext_Offset;

	private static bool GetDemoPlayTimeDilation_ReturnValue_IsValid;

	private static FFieldAddress GetDemoPlayTimeDilation_ReturnValue_PropertyAddress;

	private static int GetDemoPlayTimeDilation_ReturnValue_Offset;

	private static bool GetDemoCurrentTime_IsValid;

	private static IntPtr GetDemoCurrentTime_FunctionAddress;

	private static int GetDemoCurrentTime_ParamsSize;

	private static bool GetDemoCurrentTime_WorldContext_IsValid;

	private static FFieldAddress GetDemoCurrentTime_WorldContext_PropertyAddress;

	private static int GetDemoCurrentTime_WorldContext_Offset;

	private static bool GetDemoCurrentTime_ReturnValue_IsValid;

	private static FFieldAddress GetDemoCurrentTime_ReturnValue_PropertyAddress;

	private static int GetDemoCurrentTime_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:UnRegisterNetworkRemapPath")]
	public unsafe static void UnRegisterNetworkRemapPath(UObject WorldContext)
	{
		if (!UnRegisterNetworkRemapPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:UnRegisterNetworkRemapPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnRegisterNetworkRemapPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnRegisterNetworkRemapPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, UnRegisterNetworkRemapPath_WorldContext_Offset), 0, UnRegisterNetworkRemapPath_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnRegisterNetworkRemapPath_FunctionAddress, intPtr, UnRegisterNetworkRemapPath_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:UnregisterCSharpFuncLibObj")]
	public unsafe static void UnregisterCSharpFuncLibObj(UObject WorldContext)
	{
		if (!UnregisterCSharpFuncLibObj_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:UnregisterCSharpFuncLibObj");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterCSharpFuncLibObj_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterCSharpFuncLibObj_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, UnregisterCSharpFuncLibObj_WorldContext_Offset), 0, UnregisterCSharpFuncLibObj_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnregisterCSharpFuncLibObj_FunctionAddress, intPtr, UnregisterCSharpFuncLibObj_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:StopReplay")]
	public unsafe static void StopReplay(UObject WorldContext)
	{
		if (!StopReplay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:StopReplay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopReplay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopReplay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StopReplay_WorldContext_Offset), 0, StopReplay_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopReplay_FunctionAddress, intPtr, StopReplay_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:SkipTime")]
	public unsafe static void SkipTime(UObject WorldContext, float InTimeToSkip)
	{
		if (!SkipTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:SkipTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SkipTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SkipTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SkipTime_WorldContext_Offset), 0, SkipTime_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SkipTime_InTimeToSkip_Offset), 0, SkipTime_InTimeToSkip_PropertyAddress.Address, InTimeToSkip);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SkipTime_FunctionAddress, intPtr, SkipTime_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:SetDemoPlayTimeDilation")]
	public unsafe static void SetDemoPlayTimeDilation(UObject WorldContext, float InDemoPlayTimeDilation)
	{
		if (!SetDemoPlayTimeDilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:SetDemoPlayTimeDilation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDemoPlayTimeDilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDemoPlayTimeDilation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetDemoPlayTimeDilation_WorldContext_Offset), 0, SetDemoPlayTimeDilation_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDemoPlayTimeDilation_InDemoPlayTimeDilation_Offset), 0, SetDemoPlayTimeDilation_InDemoPlayTimeDilation_PropertyAddress.Address, InDemoPlayTimeDilation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDemoPlayTimeDilation_FunctionAddress, intPtr, SetDemoPlayTimeDilation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:SetDemoCurrentTime")]
	public unsafe static void SetDemoCurrentTime(UObject WorldContext, float CurrentTime)
	{
		if (!SetDemoCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:SetDemoCurrentTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDemoCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDemoCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetDemoCurrentTime_WorldContext_Offset), 0, SetDemoCurrentTime_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDemoCurrentTime_CurrentTime_Offset), 0, SetDemoCurrentTime_CurrentTime_PropertyAddress.Address, CurrentTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDemoCurrentTime_FunctionAddress, intPtr, SetDemoCurrentTime_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:SetActorPrioritizationEnabled")]
	public unsafe static void SetActorPrioritizationEnabled(UObject WorldContext, bool bInPrioritizeActors)
	{
		if (!SetActorPrioritizationEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:SetActorPrioritizationEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorPrioritizationEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorPrioritizationEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetActorPrioritizationEnabled_WorldContext_Offset), 0, SetActorPrioritizationEnabled_WorldContext_PropertyAddress.Address, WorldContext);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorPrioritizationEnabled_bInPrioritizeActors_Offset), 0, SetActorPrioritizationEnabled_bInPrioritizeActors_PropertyAddress.Address, bInPrioritizeActors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorPrioritizationEnabled_FunctionAddress, intPtr, SetActorPrioritizationEnabled_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:RequestCheckpoint")]
	public unsafe static void RequestCheckpoint(UObject WorldContext)
	{
		if (!RequestCheckpoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:RequestCheckpoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestCheckpoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestCheckpoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RequestCheckpoint_WorldContext_Offset), 0, RequestCheckpoint_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestCheckpoint_FunctionAddress, intPtr, RequestCheckpoint_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:RegisterNetworkRemapPath")]
	public unsafe static bool RegisterNetworkRemapPath(UObject WorldContext)
	{
		if (!RegisterNetworkRemapPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:RegisterNetworkRemapPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterNetworkRemapPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterNetworkRemapPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RegisterNetworkRemapPath_WorldContext_Offset), 0, RegisterNetworkRemapPath_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterNetworkRemapPath_FunctionAddress, intPtr, RegisterNetworkRemapPath_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RegisterNetworkRemapPath_ReturnValue_Offset), 0, RegisterNetworkRemapPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:RegisterCSharpFuncLibObj")]
	public unsafe static void RegisterCSharpFuncLibObj(UObject WorldContext, UGSReplayCSharpFuncLib CSharpFuncLibObj)
	{
		if (!RegisterCSharpFuncLibObj_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:RegisterCSharpFuncLibObj");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterCSharpFuncLibObj_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterCSharpFuncLibObj_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RegisterCSharpFuncLibObj_WorldContext_Offset), 0, RegisterCSharpFuncLibObj_WorldContext_PropertyAddress.Address, WorldContext);
		UObjectMarshaler<UGSReplayCSharpFuncLib>.ToNative(IntPtr.Add(intPtr, RegisterCSharpFuncLibObj_CSharpFuncLibObj_Offset), 0, RegisterCSharpFuncLibObj_CSharpFuncLibObj_PropertyAddress.Address, CSharpFuncLibObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterCSharpFuncLibObj_FunctionAddress, intPtr, RegisterCSharpFuncLibObj_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:RecordReplayToLocalFile")]
	public unsafe static void RecordReplayToLocalFile(UObject WorldContext, string Name, string FriendlyName, List<string> InOptions)
	{
		if (!RecordReplayToLocalFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:RecordReplayToLocalFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecordReplayToLocalFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecordReplayToLocalFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RecordReplayToLocalFile_WorldContext_Offset), 0, RecordReplayToLocalFile_WorldContext_PropertyAddress.Address, WorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RecordReplayToLocalFile_Name_Offset), 0, RecordReplayToLocalFile_Name_PropertyAddress.Address, Name);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RecordReplayToLocalFile_FriendlyName_Offset), 0, RecordReplayToLocalFile_FriendlyName_PropertyAddress.Address, FriendlyName);
		new TArrayCopyMarshaler<string>(1, RecordReplayToLocalFile_InOptions_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, RecordReplayToLocalFile_InOptions_Offset), InOptions);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RecordReplayToLocalFile_FunctionAddress, intPtr, RecordReplayToLocalFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RecordReplayToLocalFile_Name_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RecordReplayToLocalFile_FriendlyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RecordReplayToLocalFile_InOptions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:PlayReplayFromLocalFile")]
	public unsafe static void PlayReplayFromLocalFile(UObject WorldContext, string Name, List<string> InOptions)
	{
		if (!PlayReplayFromLocalFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:PlayReplayFromLocalFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayReplayFromLocalFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayReplayFromLocalFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PlayReplayFromLocalFile_WorldContext_Offset), 0, PlayReplayFromLocalFile_WorldContext_PropertyAddress.Address, WorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PlayReplayFromLocalFile_Name_Offset), 0, PlayReplayFromLocalFile_Name_PropertyAddress.Address, Name);
		new TArrayCopyMarshaler<string>(1, PlayReplayFromLocalFile_InOptions_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, PlayReplayFromLocalFile_InOptions_Offset), InOptions);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PlayReplayFromLocalFile_FunctionAddress, intPtr, PlayReplayFromLocalFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PlayReplayFromLocalFile_Name_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PlayReplayFromLocalFile_InOptions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:PauseReplay")]
	public unsafe static void PauseReplay(UObject WorldContext, bool bPause)
	{
		if (!PauseReplay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:PauseReplay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PauseReplay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PauseReplay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PauseReplay_WorldContext_Offset), 0, PauseReplay_WorldContext_PropertyAddress.Address, WorldContext);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PauseReplay_bPause_Offset), 0, PauseReplay_bPause_PropertyAddress.Address, bPause);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PauseReplay_FunctionAddress, intPtr, PauseReplay_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:IsReplayPause")]
	public unsafe static bool IsReplayPause(UObject WorldContext)
	{
		if (!IsReplayPause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:IsReplayPause");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReplayPause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReplayPause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsReplayPause_WorldContext_Offset), 0, IsReplayPause_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsReplayPause_FunctionAddress, intPtr, IsReplayPause_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReplayPause_ReturnValue_Offset), 0, IsReplayPause_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:IsRecordingReplay")]
	public unsafe static bool IsRecordingReplay(UObject WorldContext)
	{
		if (!IsRecordingReplay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:IsRecordingReplay");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRecordingReplay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRecordingReplay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsRecordingReplay_WorldContext_Offset), 0, IsRecordingReplay_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRecordingReplay_FunctionAddress, intPtr, IsRecordingReplay_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRecordingReplay_ReturnValue_Offset), 0, IsRecordingReplay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:IsPlayingReplay")]
	public unsafe static bool IsPlayingReplay(UObject WorldContext)
	{
		if (!IsPlayingReplay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:IsPlayingReplay");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayingReplay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayingReplay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsPlayingReplay_WorldContext_Offset), 0, IsPlayingReplay_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPlayingReplay_FunctionAddress, intPtr, IsPlayingReplay_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayingReplay_ReturnValue_Offset), 0, IsPlayingReplay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:IsLoadingCheckpoint")]
	public unsafe static bool IsLoadingCheckpoint(UObject WorldContext)
	{
		if (!IsLoadingCheckpoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:IsLoadingCheckpoint");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLoadingCheckpoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLoadingCheckpoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsLoadingCheckpoint_WorldContext_Offset), 0, IsLoadingCheckpoint_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsLoadingCheckpoint_FunctionAddress, intPtr, IsLoadingCheckpoint_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLoadingCheckpoint_ReturnValue_Offset), 0, IsLoadingCheckpoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:GetLastCheckpointTime")]
	public unsafe static double GetLastCheckpointTime(UObject WorldContext)
	{
		if (!GetLastCheckpointTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:GetLastCheckpointTime");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastCheckpointTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastCheckpointTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLastCheckpointTime_WorldContext_Offset), 0, GetLastCheckpointTime_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLastCheckpointTime_FunctionAddress, intPtr, GetLastCheckpointTime_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetLastCheckpointTime_ReturnValue_Offset), 0, GetLastCheckpointTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:GetDemoTotalTime")]
	public unsafe static float GetDemoTotalTime(UObject WorldContext)
	{
		if (!GetDemoTotalTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:GetDemoTotalTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDemoTotalTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDemoTotalTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetDemoTotalTime_WorldContext_Offset), 0, GetDemoTotalTime_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDemoTotalTime_FunctionAddress, intPtr, GetDemoTotalTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDemoTotalTime_ReturnValue_Offset), 0, GetDemoTotalTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:GetDemoPlayTimeDilation")]
	public unsafe static float GetDemoPlayTimeDilation(UObject WorldContext)
	{
		if (!GetDemoPlayTimeDilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:GetDemoPlayTimeDilation");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDemoPlayTimeDilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDemoPlayTimeDilation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetDemoPlayTimeDilation_WorldContext_Offset), 0, GetDemoPlayTimeDilation_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDemoPlayTimeDilation_FunctionAddress, intPtr, GetDemoPlayTimeDilation_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDemoPlayTimeDilation_ReturnValue_Offset), 0, GetDemoPlayTimeDilation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayFuncLib:GetDemoCurrentTime")]
	public unsafe static float GetDemoCurrentTime(UObject WorldContext)
	{
		if (!GetDemoCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayFuncLib:GetDemoCurrentTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDemoCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDemoCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetDemoCurrentTime_WorldContext_Offset), 0, GetDemoCurrentTime_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDemoCurrentTime_FunctionAddress, intPtr, GetDemoCurrentTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDemoCurrentTime_ReturnValue_Offset), 0, GetDemoCurrentTime_ReturnValue_PropertyAddress.Address);
	}

	static UGSReplayFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSReplayFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSReplayFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSReplaySystem.GSReplayFuncLib");
		UnRegisterNetworkRemapPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnRegisterNetworkRemapPath");
		UnRegisterNetworkRemapPath_ParamsSize = NativeReflection.GetFunctionParamsSize(UnRegisterNetworkRemapPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnRegisterNetworkRemapPath_WorldContext_PropertyAddress, UnRegisterNetworkRemapPath_FunctionAddress, "WorldContext");
		UnRegisterNetworkRemapPath_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(UnRegisterNetworkRemapPath_FunctionAddress, "WorldContext");
		UnRegisterNetworkRemapPath_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(UnRegisterNetworkRemapPath_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		UnRegisterNetworkRemapPath_IsValid = UnRegisterNetworkRemapPath_FunctionAddress != IntPtr.Zero && UnRegisterNetworkRemapPath_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:UnRegisterNetworkRemapPath", UnRegisterNetworkRemapPath_IsValid);
		UnregisterCSharpFuncLibObj_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnregisterCSharpFuncLibObj");
		UnregisterCSharpFuncLibObj_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterCSharpFuncLibObj_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterCSharpFuncLibObj_WorldContext_PropertyAddress, UnregisterCSharpFuncLibObj_FunctionAddress, "WorldContext");
		UnregisterCSharpFuncLibObj_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterCSharpFuncLibObj_FunctionAddress, "WorldContext");
		UnregisterCSharpFuncLibObj_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterCSharpFuncLibObj_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		UnregisterCSharpFuncLibObj_IsValid = UnregisterCSharpFuncLibObj_FunctionAddress != IntPtr.Zero && UnregisterCSharpFuncLibObj_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:UnregisterCSharpFuncLibObj", UnregisterCSharpFuncLibObj_IsValid);
		StopReplay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopReplay");
		StopReplay_ParamsSize = NativeReflection.GetFunctionParamsSize(StopReplay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopReplay_WorldContext_PropertyAddress, StopReplay_FunctionAddress, "WorldContext");
		StopReplay_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(StopReplay_FunctionAddress, "WorldContext");
		StopReplay_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(StopReplay_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		StopReplay_IsValid = StopReplay_FunctionAddress != IntPtr.Zero && StopReplay_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:StopReplay", StopReplay_IsValid);
		SkipTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SkipTime");
		SkipTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SkipTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SkipTime_WorldContext_PropertyAddress, SkipTime_FunctionAddress, "WorldContext");
		SkipTime_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(SkipTime_FunctionAddress, "WorldContext");
		SkipTime_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SkipTime_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipTime_InTimeToSkip_PropertyAddress, SkipTime_FunctionAddress, "InTimeToSkip");
		SkipTime_InTimeToSkip_Offset = NativeReflectionCached.GetPropertyOffset(SkipTime_FunctionAddress, "InTimeToSkip");
		SkipTime_InTimeToSkip_IsValid = NativeReflectionCached.ValidatePropertyClass(SkipTime_FunctionAddress, "InTimeToSkip", Classes.FFloatProperty);
		SkipTime_IsValid = SkipTime_FunctionAddress != IntPtr.Zero && SkipTime_WorldContext_IsValid && SkipTime_InTimeToSkip_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:SkipTime", SkipTime_IsValid);
		SetDemoPlayTimeDilation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDemoPlayTimeDilation");
		SetDemoPlayTimeDilation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDemoPlayTimeDilation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDemoPlayTimeDilation_WorldContext_PropertyAddress, SetDemoPlayTimeDilation_FunctionAddress, "WorldContext");
		SetDemoPlayTimeDilation_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(SetDemoPlayTimeDilation_FunctionAddress, "WorldContext");
		SetDemoPlayTimeDilation_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDemoPlayTimeDilation_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDemoPlayTimeDilation_InDemoPlayTimeDilation_PropertyAddress, SetDemoPlayTimeDilation_FunctionAddress, "InDemoPlayTimeDilation");
		SetDemoPlayTimeDilation_InDemoPlayTimeDilation_Offset = NativeReflectionCached.GetPropertyOffset(SetDemoPlayTimeDilation_FunctionAddress, "InDemoPlayTimeDilation");
		SetDemoPlayTimeDilation_InDemoPlayTimeDilation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDemoPlayTimeDilation_FunctionAddress, "InDemoPlayTimeDilation", Classes.FFloatProperty);
		SetDemoPlayTimeDilation_IsValid = SetDemoPlayTimeDilation_FunctionAddress != IntPtr.Zero && SetDemoPlayTimeDilation_WorldContext_IsValid && SetDemoPlayTimeDilation_InDemoPlayTimeDilation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:SetDemoPlayTimeDilation", SetDemoPlayTimeDilation_IsValid);
		SetDemoCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDemoCurrentTime");
		SetDemoCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDemoCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDemoCurrentTime_WorldContext_PropertyAddress, SetDemoCurrentTime_FunctionAddress, "WorldContext");
		SetDemoCurrentTime_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(SetDemoCurrentTime_FunctionAddress, "WorldContext");
		SetDemoCurrentTime_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDemoCurrentTime_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDemoCurrentTime_CurrentTime_PropertyAddress, SetDemoCurrentTime_FunctionAddress, "CurrentTime");
		SetDemoCurrentTime_CurrentTime_Offset = NativeReflectionCached.GetPropertyOffset(SetDemoCurrentTime_FunctionAddress, "CurrentTime");
		SetDemoCurrentTime_CurrentTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDemoCurrentTime_FunctionAddress, "CurrentTime", Classes.FFloatProperty);
		SetDemoCurrentTime_IsValid = SetDemoCurrentTime_FunctionAddress != IntPtr.Zero && SetDemoCurrentTime_WorldContext_IsValid && SetDemoCurrentTime_CurrentTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:SetDemoCurrentTime", SetDemoCurrentTime_IsValid);
		SetActorPrioritizationEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorPrioritizationEnabled");
		SetActorPrioritizationEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorPrioritizationEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorPrioritizationEnabled_WorldContext_PropertyAddress, SetActorPrioritizationEnabled_FunctionAddress, "WorldContext");
		SetActorPrioritizationEnabled_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(SetActorPrioritizationEnabled_FunctionAddress, "WorldContext");
		SetActorPrioritizationEnabled_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorPrioritizationEnabled_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorPrioritizationEnabled_bInPrioritizeActors_PropertyAddress, SetActorPrioritizationEnabled_FunctionAddress, "bInPrioritizeActors");
		SetActorPrioritizationEnabled_bInPrioritizeActors_Offset = NativeReflectionCached.GetPropertyOffset(SetActorPrioritizationEnabled_FunctionAddress, "bInPrioritizeActors");
		SetActorPrioritizationEnabled_bInPrioritizeActors_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorPrioritizationEnabled_FunctionAddress, "bInPrioritizeActors", Classes.FBoolProperty);
		SetActorPrioritizationEnabled_IsValid = SetActorPrioritizationEnabled_FunctionAddress != IntPtr.Zero && SetActorPrioritizationEnabled_WorldContext_IsValid && SetActorPrioritizationEnabled_bInPrioritizeActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:SetActorPrioritizationEnabled", SetActorPrioritizationEnabled_IsValid);
		RequestCheckpoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestCheckpoint");
		RequestCheckpoint_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestCheckpoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestCheckpoint_WorldContext_PropertyAddress, RequestCheckpoint_FunctionAddress, "WorldContext");
		RequestCheckpoint_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(RequestCheckpoint_FunctionAddress, "WorldContext");
		RequestCheckpoint_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestCheckpoint_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		RequestCheckpoint_IsValid = RequestCheckpoint_FunctionAddress != IntPtr.Zero && RequestCheckpoint_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:RequestCheckpoint", RequestCheckpoint_IsValid);
		RegisterNetworkRemapPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterNetworkRemapPath");
		RegisterNetworkRemapPath_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterNetworkRemapPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterNetworkRemapPath_WorldContext_PropertyAddress, RegisterNetworkRemapPath_FunctionAddress, "WorldContext");
		RegisterNetworkRemapPath_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNetworkRemapPath_FunctionAddress, "WorldContext");
		RegisterNetworkRemapPath_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNetworkRemapPath_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterNetworkRemapPath_ReturnValue_PropertyAddress, RegisterNetworkRemapPath_FunctionAddress, "ReturnValue");
		RegisterNetworkRemapPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNetworkRemapPath_FunctionAddress, "ReturnValue");
		RegisterNetworkRemapPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNetworkRemapPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RegisterNetworkRemapPath_IsValid = RegisterNetworkRemapPath_FunctionAddress != IntPtr.Zero && RegisterNetworkRemapPath_WorldContext_IsValid && RegisterNetworkRemapPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:RegisterNetworkRemapPath", RegisterNetworkRemapPath_IsValid);
		RegisterCSharpFuncLibObj_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterCSharpFuncLibObj");
		RegisterCSharpFuncLibObj_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterCSharpFuncLibObj_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterCSharpFuncLibObj_WorldContext_PropertyAddress, RegisterCSharpFuncLibObj_FunctionAddress, "WorldContext");
		RegisterCSharpFuncLibObj_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(RegisterCSharpFuncLibObj_FunctionAddress, "WorldContext");
		RegisterCSharpFuncLibObj_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterCSharpFuncLibObj_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterCSharpFuncLibObj_CSharpFuncLibObj_PropertyAddress, RegisterCSharpFuncLibObj_FunctionAddress, "CSharpFuncLibObj");
		RegisterCSharpFuncLibObj_CSharpFuncLibObj_Offset = NativeReflectionCached.GetPropertyOffset(RegisterCSharpFuncLibObj_FunctionAddress, "CSharpFuncLibObj");
		RegisterCSharpFuncLibObj_CSharpFuncLibObj_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterCSharpFuncLibObj_FunctionAddress, "CSharpFuncLibObj", Classes.FObjectProperty);
		RegisterCSharpFuncLibObj_IsValid = RegisterCSharpFuncLibObj_FunctionAddress != IntPtr.Zero && RegisterCSharpFuncLibObj_WorldContext_IsValid && RegisterCSharpFuncLibObj_CSharpFuncLibObj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:RegisterCSharpFuncLibObj", RegisterCSharpFuncLibObj_IsValid);
		RecordReplayToLocalFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecordReplayToLocalFile");
		RecordReplayToLocalFile_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordReplayToLocalFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecordReplayToLocalFile_WorldContext_PropertyAddress, RecordReplayToLocalFile_FunctionAddress, "WorldContext");
		RecordReplayToLocalFile_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(RecordReplayToLocalFile_FunctionAddress, "WorldContext");
		RecordReplayToLocalFile_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordReplayToLocalFile_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RecordReplayToLocalFile_Name_PropertyAddress, RecordReplayToLocalFile_FunctionAddress, "Name");
		RecordReplayToLocalFile_Name_Offset = NativeReflectionCached.GetPropertyOffset(RecordReplayToLocalFile_FunctionAddress, "Name");
		RecordReplayToLocalFile_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordReplayToLocalFile_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RecordReplayToLocalFile_FriendlyName_PropertyAddress, RecordReplayToLocalFile_FunctionAddress, "FriendlyName");
		RecordReplayToLocalFile_FriendlyName_Offset = NativeReflectionCached.GetPropertyOffset(RecordReplayToLocalFile_FunctionAddress, "FriendlyName");
		RecordReplayToLocalFile_FriendlyName_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordReplayToLocalFile_FunctionAddress, "FriendlyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RecordReplayToLocalFile_InOptions_PropertyAddress, RecordReplayToLocalFile_FunctionAddress, "InOptions");
		RecordReplayToLocalFile_InOptions_Offset = NativeReflectionCached.GetPropertyOffset(RecordReplayToLocalFile_FunctionAddress, "InOptions");
		RecordReplayToLocalFile_InOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordReplayToLocalFile_FunctionAddress, "InOptions", Classes.FArrayProperty);
		RecordReplayToLocalFile_IsValid = RecordReplayToLocalFile_FunctionAddress != IntPtr.Zero && RecordReplayToLocalFile_WorldContext_IsValid && RecordReplayToLocalFile_Name_IsValid && RecordReplayToLocalFile_FriendlyName_IsValid && RecordReplayToLocalFile_InOptions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:RecordReplayToLocalFile", RecordReplayToLocalFile_IsValid);
		PlayReplayFromLocalFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PlayReplayFromLocalFile");
		PlayReplayFromLocalFile_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayReplayFromLocalFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayReplayFromLocalFile_WorldContext_PropertyAddress, PlayReplayFromLocalFile_FunctionAddress, "WorldContext");
		PlayReplayFromLocalFile_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(PlayReplayFromLocalFile_FunctionAddress, "WorldContext");
		PlayReplayFromLocalFile_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayReplayFromLocalFile_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayReplayFromLocalFile_Name_PropertyAddress, PlayReplayFromLocalFile_FunctionAddress, "Name");
		PlayReplayFromLocalFile_Name_Offset = NativeReflectionCached.GetPropertyOffset(PlayReplayFromLocalFile_FunctionAddress, "Name");
		PlayReplayFromLocalFile_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayReplayFromLocalFile_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayReplayFromLocalFile_InOptions_PropertyAddress, PlayReplayFromLocalFile_FunctionAddress, "InOptions");
		PlayReplayFromLocalFile_InOptions_Offset = NativeReflectionCached.GetPropertyOffset(PlayReplayFromLocalFile_FunctionAddress, "InOptions");
		PlayReplayFromLocalFile_InOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayReplayFromLocalFile_FunctionAddress, "InOptions", Classes.FArrayProperty);
		PlayReplayFromLocalFile_IsValid = PlayReplayFromLocalFile_FunctionAddress != IntPtr.Zero && PlayReplayFromLocalFile_WorldContext_IsValid && PlayReplayFromLocalFile_Name_IsValid && PlayReplayFromLocalFile_InOptions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:PlayReplayFromLocalFile", PlayReplayFromLocalFile_IsValid);
		PauseReplay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PauseReplay");
		PauseReplay_ParamsSize = NativeReflection.GetFunctionParamsSize(PauseReplay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PauseReplay_WorldContext_PropertyAddress, PauseReplay_FunctionAddress, "WorldContext");
		PauseReplay_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(PauseReplay_FunctionAddress, "WorldContext");
		PauseReplay_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseReplay_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PauseReplay_bPause_PropertyAddress, PauseReplay_FunctionAddress, "bPause");
		PauseReplay_bPause_Offset = NativeReflectionCached.GetPropertyOffset(PauseReplay_FunctionAddress, "bPause");
		PauseReplay_bPause_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseReplay_FunctionAddress, "bPause", Classes.FBoolProperty);
		PauseReplay_IsValid = PauseReplay_FunctionAddress != IntPtr.Zero && PauseReplay_WorldContext_IsValid && PauseReplay_bPause_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:PauseReplay", PauseReplay_IsValid);
		IsReplayPause_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsReplayPause");
		IsReplayPause_ParamsSize = NativeReflection.GetFunctionParamsSize(IsReplayPause_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsReplayPause_WorldContext_PropertyAddress, IsReplayPause_FunctionAddress, "WorldContext");
		IsReplayPause_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(IsReplayPause_FunctionAddress, "WorldContext");
		IsReplayPause_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReplayPause_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsReplayPause_ReturnValue_PropertyAddress, IsReplayPause_FunctionAddress, "ReturnValue");
		IsReplayPause_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsReplayPause_FunctionAddress, "ReturnValue");
		IsReplayPause_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReplayPause_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsReplayPause_IsValid = IsReplayPause_FunctionAddress != IntPtr.Zero && IsReplayPause_WorldContext_IsValid && IsReplayPause_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:IsReplayPause", IsReplayPause_IsValid);
		IsRecordingReplay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRecordingReplay");
		IsRecordingReplay_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRecordingReplay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRecordingReplay_WorldContext_PropertyAddress, IsRecordingReplay_FunctionAddress, "WorldContext");
		IsRecordingReplay_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(IsRecordingReplay_FunctionAddress, "WorldContext");
		IsRecordingReplay_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRecordingReplay_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRecordingReplay_ReturnValue_PropertyAddress, IsRecordingReplay_FunctionAddress, "ReturnValue");
		IsRecordingReplay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRecordingReplay_FunctionAddress, "ReturnValue");
		IsRecordingReplay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRecordingReplay_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRecordingReplay_IsValid = IsRecordingReplay_FunctionAddress != IntPtr.Zero && IsRecordingReplay_WorldContext_IsValid && IsRecordingReplay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:IsRecordingReplay", IsRecordingReplay_IsValid);
		IsPlayingReplay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPlayingReplay");
		IsPlayingReplay_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayingReplay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayingReplay_WorldContext_PropertyAddress, IsPlayingReplay_FunctionAddress, "WorldContext");
		IsPlayingReplay_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayingReplay_FunctionAddress, "WorldContext");
		IsPlayingReplay_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayingReplay_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPlayingReplay_ReturnValue_PropertyAddress, IsPlayingReplay_FunctionAddress, "ReturnValue");
		IsPlayingReplay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayingReplay_FunctionAddress, "ReturnValue");
		IsPlayingReplay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayingReplay_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayingReplay_IsValid = IsPlayingReplay_FunctionAddress != IntPtr.Zero && IsPlayingReplay_WorldContext_IsValid && IsPlayingReplay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:IsPlayingReplay", IsPlayingReplay_IsValid);
		IsLoadingCheckpoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsLoadingCheckpoint");
		IsLoadingCheckpoint_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLoadingCheckpoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLoadingCheckpoint_WorldContext_PropertyAddress, IsLoadingCheckpoint_FunctionAddress, "WorldContext");
		IsLoadingCheckpoint_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(IsLoadingCheckpoint_FunctionAddress, "WorldContext");
		IsLoadingCheckpoint_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLoadingCheckpoint_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLoadingCheckpoint_ReturnValue_PropertyAddress, IsLoadingCheckpoint_FunctionAddress, "ReturnValue");
		IsLoadingCheckpoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLoadingCheckpoint_FunctionAddress, "ReturnValue");
		IsLoadingCheckpoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLoadingCheckpoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLoadingCheckpoint_IsValid = IsLoadingCheckpoint_FunctionAddress != IntPtr.Zero && IsLoadingCheckpoint_WorldContext_IsValid && IsLoadingCheckpoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:IsLoadingCheckpoint", IsLoadingCheckpoint_IsValid);
		GetLastCheckpointTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLastCheckpointTime");
		GetLastCheckpointTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastCheckpointTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastCheckpointTime_WorldContext_PropertyAddress, GetLastCheckpointTime_FunctionAddress, "WorldContext");
		GetLastCheckpointTime_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetLastCheckpointTime_FunctionAddress, "WorldContext");
		GetLastCheckpointTime_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastCheckpointTime_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLastCheckpointTime_ReturnValue_PropertyAddress, GetLastCheckpointTime_FunctionAddress, "ReturnValue");
		GetLastCheckpointTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastCheckpointTime_FunctionAddress, "ReturnValue");
		GetLastCheckpointTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastCheckpointTime_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetLastCheckpointTime_IsValid = GetLastCheckpointTime_FunctionAddress != IntPtr.Zero && GetLastCheckpointTime_WorldContext_IsValid && GetLastCheckpointTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:GetLastCheckpointTime", GetLastCheckpointTime_IsValid);
		GetDemoTotalTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDemoTotalTime");
		GetDemoTotalTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDemoTotalTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDemoTotalTime_WorldContext_PropertyAddress, GetDemoTotalTime_FunctionAddress, "WorldContext");
		GetDemoTotalTime_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetDemoTotalTime_FunctionAddress, "WorldContext");
		GetDemoTotalTime_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDemoTotalTime_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDemoTotalTime_ReturnValue_PropertyAddress, GetDemoTotalTime_FunctionAddress, "ReturnValue");
		GetDemoTotalTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDemoTotalTime_FunctionAddress, "ReturnValue");
		GetDemoTotalTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDemoTotalTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDemoTotalTime_IsValid = GetDemoTotalTime_FunctionAddress != IntPtr.Zero && GetDemoTotalTime_WorldContext_IsValid && GetDemoTotalTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:GetDemoTotalTime", GetDemoTotalTime_IsValid);
		GetDemoPlayTimeDilation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDemoPlayTimeDilation");
		GetDemoPlayTimeDilation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDemoPlayTimeDilation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDemoPlayTimeDilation_WorldContext_PropertyAddress, GetDemoPlayTimeDilation_FunctionAddress, "WorldContext");
		GetDemoPlayTimeDilation_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetDemoPlayTimeDilation_FunctionAddress, "WorldContext");
		GetDemoPlayTimeDilation_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDemoPlayTimeDilation_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDemoPlayTimeDilation_ReturnValue_PropertyAddress, GetDemoPlayTimeDilation_FunctionAddress, "ReturnValue");
		GetDemoPlayTimeDilation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDemoPlayTimeDilation_FunctionAddress, "ReturnValue");
		GetDemoPlayTimeDilation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDemoPlayTimeDilation_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDemoPlayTimeDilation_IsValid = GetDemoPlayTimeDilation_FunctionAddress != IntPtr.Zero && GetDemoPlayTimeDilation_WorldContext_IsValid && GetDemoPlayTimeDilation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:GetDemoPlayTimeDilation", GetDemoPlayTimeDilation_IsValid);
		GetDemoCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDemoCurrentTime");
		GetDemoCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDemoCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDemoCurrentTime_WorldContext_PropertyAddress, GetDemoCurrentTime_FunctionAddress, "WorldContext");
		GetDemoCurrentTime_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetDemoCurrentTime_FunctionAddress, "WorldContext");
		GetDemoCurrentTime_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDemoCurrentTime_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDemoCurrentTime_ReturnValue_PropertyAddress, GetDemoCurrentTime_FunctionAddress, "ReturnValue");
		GetDemoCurrentTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDemoCurrentTime_FunctionAddress, "ReturnValue");
		GetDemoCurrentTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDemoCurrentTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDemoCurrentTime_IsValid = GetDemoCurrentTime_FunctionAddress != IntPtr.Zero && GetDemoCurrentTime_WorldContext_IsValid && GetDemoCurrentTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayFuncLib:GetDemoCurrentTime", GetDemoCurrentTime_IsValid);
	}
}
