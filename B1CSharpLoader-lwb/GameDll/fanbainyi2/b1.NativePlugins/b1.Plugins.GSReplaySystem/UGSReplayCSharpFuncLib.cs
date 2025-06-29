using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSReplaySystem;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib", "GSReplaySystem", UnrealModuleType.GamePlugin)]
public class UGSReplayCSharpFuncLib : UObject
{
	private static bool WriteGameSpecificDemoHeaderCS_IsValid;

	private IntPtr WriteGameSpecificDemoHeaderCS_InstanceFunctionAddress;

	private static IntPtr WriteGameSpecificDemoHeaderCS_FunctionAddress;

	private static int WriteGameSpecificDemoHeaderCS_ParamsSize;

	private static bool WriteGameSpecificDemoHeaderCS_GameSpecificData_IsValid;

	private static FFieldAddress WriteGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress;

	private static int WriteGameSpecificDemoHeaderCS_GameSpecificData_Offset;

	private static bool SetViewTargetPlayer_IsValid;

	private IntPtr SetViewTargetPlayer_InstanceFunctionAddress;

	private static IntPtr SetViewTargetPlayer_FunctionAddress;

	private static int SetViewTargetPlayer_ParamsSize;

	private static bool SetViewTargetPlayer_PlayerId_IsValid;

	private static FFieldAddress SetViewTargetPlayer_PlayerId_PropertyAddress;

	private static int SetViewTargetPlayer_PlayerId_Offset;

	private static bool SetViewTargetPlayer_ReturnValue_IsValid;

	private static FFieldAddress SetViewTargetPlayer_ReturnValue_PropertyAddress;

	private static int SetViewTargetPlayer_ReturnValue_Offset;

	private static bool SetDemoCurrentTime_IsValid;

	private IntPtr SetDemoCurrentTime_InstanceFunctionAddress;

	private static IntPtr SetDemoCurrentTime_FunctionAddress;

	private static int SetDemoCurrentTime_ParamsSize;

	private static bool SetDemoCurrentTime_InTimeToSet_IsValid;

	private static FFieldAddress SetDemoCurrentTime_InTimeToSet_PropertyAddress;

	private static int SetDemoCurrentTime_InTimeToSet_Offset;

	private static bool ProcessGameSpecificDemoHeaderCS_IsValid;

	private IntPtr ProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress;

	private static IntPtr ProcessGameSpecificDemoHeaderCS_FunctionAddress;

	private static int ProcessGameSpecificDemoHeaderCS_ParamsSize;

	private static bool ProcessGameSpecificDemoHeaderCS_GameSpecificData_IsValid;

	private static FFieldAddress ProcessGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress;

	private static int ProcessGameSpecificDemoHeaderCS_GameSpecificData_Offset;

	private static bool ProcessGameSpecificDemoHeaderCS_Error_IsValid;

	private static FFieldAddress ProcessGameSpecificDemoHeaderCS_Error_PropertyAddress;

	private static int ProcessGameSpecificDemoHeaderCS_Error_Offset;

	private static bool PreProcessGameSpecificDemoHeaderCS_IsValid;

	private IntPtr PreProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress;

	private static IntPtr PreProcessGameSpecificDemoHeaderCS_FunctionAddress;

	private static int PreProcessGameSpecificDemoHeaderCS_ParamsSize;

	private static bool PostProcessGameSpecificDemoHeaderCS_IsValid;

	private IntPtr PostProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress;

	private static IntPtr PostProcessGameSpecificDemoHeaderCS_FunctionAddress;

	private static int PostProcessGameSpecificDemoHeaderCS_ParamsSize;

	private static bool OnWriteGameSpecificDemoHeader_IsValid;

	private static IntPtr OnWriteGameSpecificDemoHeader_FunctionAddress;

	private static int OnWriteGameSpecificDemoHeader_ParamsSize;

	private static bool OnWriteGameSpecificDemoHeader_GameSpecificData_IsValid;

	private static FFieldAddress OnWriteGameSpecificDemoHeader_GameSpecificData_PropertyAddress;

	private static int OnWriteGameSpecificDemoHeader_GameSpecificData_Offset;

	private static bool OnReplayStarted_IsValid;

	private IntPtr OnReplayStarted_InstanceFunctionAddress;

	private static IntPtr OnReplayStarted_FunctionAddress;

	private static int OnReplayStarted_ParamsSize;

	private static bool OnReplayStarted_World_IsValid;

	private static FFieldAddress OnReplayStarted_World_PropertyAddress;

	private static int OnReplayStarted_World_Offset;

	private static bool OnReplaySeverConnectionInit_IsValid;

	private IntPtr OnReplaySeverConnectionInit_InstanceFunctionAddress;

	private static IntPtr OnReplaySeverConnectionInit_FunctionAddress;

	private static int OnReplaySeverConnectionInit_ParamsSize;

	private static bool OnReplaySeverConnectionInit_World_IsValid;

	private static FFieldAddress OnReplaySeverConnectionInit_World_PropertyAddress;

	private static int OnReplaySeverConnectionInit_World_Offset;

	private static bool OnReplaySeverConnectionInit_SeverConnection_IsValid;

	private static FFieldAddress OnReplaySeverConnectionInit_SeverConnection_PropertyAddress;

	private static int OnReplaySeverConnectionInit_SeverConnection_Offset;

	private static bool OnReplayScrubComplete_IsValid;

	private IntPtr OnReplayScrubComplete_InstanceFunctionAddress;

	private static IntPtr OnReplayScrubComplete_FunctionAddress;

	private static int OnReplayScrubComplete_ParamsSize;

	private static bool OnReplayScrubComplete_World_IsValid;

	private static FFieldAddress OnReplayScrubComplete_World_PropertyAddress;

	private static int OnReplayScrubComplete_World_Offset;

	private static bool OnProcessGameSpecificDemoHeader_IsValid;

	private static IntPtr OnProcessGameSpecificDemoHeader_FunctionAddress;

	private static int OnProcessGameSpecificDemoHeader_ParamsSize;

	private static bool OnProcessGameSpecificDemoHeader_GameSpecificData_IsValid;

	private static FFieldAddress OnProcessGameSpecificDemoHeader_GameSpecificData_PropertyAddress;

	private static int OnProcessGameSpecificDemoHeader_GameSpecificData_Offset;

	private static bool OnProcessGameSpecificDemoHeader_Error_IsValid;

	private static FFieldAddress OnProcessGameSpecificDemoHeader_Error_PropertyAddress;

	private static int OnProcessGameSpecificDemoHeader_Error_Offset;

	private static bool OnPreScrub_IsValid;

	private IntPtr OnPreScrub_InstanceFunctionAddress;

	private static IntPtr OnPreScrub_FunctionAddress;

	private static int OnPreScrub_ParamsSize;

	private static bool OnPreScrub_World_IsValid;

	private static FFieldAddress OnPreScrub_World_PropertyAddress;

	private static int OnPreScrub_World_Offset;

	private static bool OnPostDemoPlay_IsValid;

	private IntPtr OnPostDemoPlay_InstanceFunctionAddress;

	private static IntPtr OnPostDemoPlay_FunctionAddress;

	private static int OnPostDemoPlay_ParamsSize;

	private static bool GSNetworkRemapPathCS_IsValid;

	private IntPtr GSNetworkRemapPathCS_InstanceFunctionAddress;

	private static IntPtr GSNetworkRemapPathCS_FunctionAddress;

	private static int GSNetworkRemapPathCS_ParamsSize;

	private static bool GSNetworkRemapPathCS_Outer_IsValid;

	private static FFieldAddress GSNetworkRemapPathCS_Outer_PropertyAddress;

	private static int GSNetworkRemapPathCS_Outer_Offset;

	private static bool GSNetworkRemapPathCS_OriginName_IsValid;

	private static FFieldAddress GSNetworkRemapPathCS_OriginName_PropertyAddress;

	private static int GSNetworkRemapPathCS_OriginName_Offset;

	private static bool GSNetworkRemapPathCS_Name_IsValid;

	private static FFieldAddress GSNetworkRemapPathCS_Name_PropertyAddress;

	private static int GSNetworkRemapPathCS_Name_Offset;

	private static bool GSNetworkRemapPath_IsValid;

	private static IntPtr GSNetworkRemapPath_FunctionAddress;

	private static int GSNetworkRemapPath_ParamsSize;

	private static bool GSNetworkRemapPath_Outer_IsValid;

	private static FFieldAddress GSNetworkRemapPath_Outer_PropertyAddress;

	private static int GSNetworkRemapPath_Outer_Offset;

	private static bool GSNetworkRemapPath_Name_IsValid;

	private static FFieldAddress GSNetworkRemapPath_Name_PropertyAddress;

	private static int GSNetworkRemapPath_Name_Offset;

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:WriteGameSpecificDemoHeaderCS")]
	public unsafe void WriteGameSpecificDemoHeaderCS(out List<string> GameSpecificData)
	{
		CheckDestroyed();
		if (!WriteGameSpecificDemoHeaderCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:WriteGameSpecificDemoHeaderCS");
			GameSpecificData = null;
			return;
		}
		if (WriteGameSpecificDemoHeaderCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			WriteGameSpecificDemoHeaderCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "WriteGameSpecificDemoHeaderCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteGameSpecificDemoHeaderCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteGameSpecificDemoHeaderCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, WriteGameSpecificDemoHeaderCS_InstanceFunctionAddress, intPtr, WriteGameSpecificDemoHeaderCS_ParamsSize);
		GameSpecificData = new TArrayCopyMarshaler<string>(1, WriteGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, WriteGameSpecificDemoHeaderCS_GameSpecificData_Offset));
		NativeReflection.DestroyValue_InContainer(WriteGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void WriteGameSpecificDemoHeaderCS_Implementation(out List<string> GameSpecificData)
	{
		CheckDestroyed();
		if (!WriteGameSpecificDemoHeaderCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:WriteGameSpecificDemoHeaderCS");
			GameSpecificData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteGameSpecificDemoHeaderCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteGameSpecificDemoHeaderCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, WriteGameSpecificDemoHeaderCS_FunctionAddress, intPtr, WriteGameSpecificDemoHeaderCS_ParamsSize);
		GameSpecificData = new TArrayCopyMarshaler<string>(1, WriteGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, WriteGameSpecificDemoHeaderCS_GameSpecificData_Offset));
		NativeReflection.DestroyValue_InContainer(WriteGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:SetViewTargetPlayer")]
	public unsafe bool SetViewTargetPlayer(int PlayerId)
	{
		CheckDestroyed();
		if (!SetViewTargetPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:SetViewTargetPlayer");
			return false;
		}
		if (SetViewTargetPlayer_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetViewTargetPlayer_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetViewTargetPlayer");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewTargetPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewTargetPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetViewTargetPlayer_PlayerId_Offset), 0, SetViewTargetPlayer_PlayerId_PropertyAddress.Address, PlayerId);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewTargetPlayer_InstanceFunctionAddress, intPtr, SetViewTargetPlayer_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetViewTargetPlayer_ReturnValue_Offset), 0, SetViewTargetPlayer_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool SetViewTargetPlayer_Implementation(int PlayerId)
	{
		CheckDestroyed();
		if (!SetViewTargetPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:SetViewTargetPlayer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewTargetPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewTargetPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetViewTargetPlayer_PlayerId_Offset), 0, SetViewTargetPlayer_PlayerId_PropertyAddress.Address, PlayerId);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewTargetPlayer_FunctionAddress, intPtr, SetViewTargetPlayer_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetViewTargetPlayer_ReturnValue_Offset), 0, SetViewTargetPlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:SetDemoCurrentTime")]
	public unsafe void SetDemoCurrentTime(float InTimeToSet)
	{
		CheckDestroyed();
		if (!SetDemoCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:SetDemoCurrentTime");
			return;
		}
		if (SetDemoCurrentTime_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetDemoCurrentTime_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetDemoCurrentTime");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDemoCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDemoCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDemoCurrentTime_InTimeToSet_Offset), 0, SetDemoCurrentTime_InTimeToSet_PropertyAddress.Address, InTimeToSet);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDemoCurrentTime_InstanceFunctionAddress, intPtr, SetDemoCurrentTime_ParamsSize);
	}

	protected unsafe virtual void SetDemoCurrentTime_Implementation(float InTimeToSet)
	{
		CheckDestroyed();
		if (!SetDemoCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:SetDemoCurrentTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDemoCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDemoCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDemoCurrentTime_InTimeToSet_Offset), 0, SetDemoCurrentTime_InTimeToSet_PropertyAddress.Address, InTimeToSet);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDemoCurrentTime_FunctionAddress, intPtr, SetDemoCurrentTime_ParamsSize);
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:ProcessGameSpecificDemoHeaderCS")]
	public unsafe void ProcessGameSpecificDemoHeaderCS(string GameSpecificData, out string Error)
	{
		CheckDestroyed();
		if (!ProcessGameSpecificDemoHeaderCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:ProcessGameSpecificDemoHeaderCS");
			Error = FStringMarshaler.DefaultString;
			return;
		}
		if (ProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProcessGameSpecificDemoHeaderCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessGameSpecificDemoHeaderCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessGameSpecificDemoHeaderCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ProcessGameSpecificDemoHeaderCS_GameSpecificData_Offset), 0, ProcessGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress.Address, GameSpecificData);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress, intPtr, ProcessGameSpecificDemoHeaderCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProcessGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress.Address, intPtr);
		Error = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProcessGameSpecificDemoHeaderCS_Error_Offset), 0, ProcessGameSpecificDemoHeaderCS_Error_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProcessGameSpecificDemoHeaderCS_Error_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ProcessGameSpecificDemoHeaderCS_Implementation(string GameSpecificData, out string Error)
	{
		CheckDestroyed();
		if (!ProcessGameSpecificDemoHeaderCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:ProcessGameSpecificDemoHeaderCS");
			Error = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessGameSpecificDemoHeaderCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessGameSpecificDemoHeaderCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ProcessGameSpecificDemoHeaderCS_GameSpecificData_Offset), 0, ProcessGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress.Address, GameSpecificData);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProcessGameSpecificDemoHeaderCS_FunctionAddress, intPtr, ProcessGameSpecificDemoHeaderCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProcessGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress.Address, intPtr);
		Error = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ProcessGameSpecificDemoHeaderCS_Error_Offset), 0, ProcessGameSpecificDemoHeaderCS_Error_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ProcessGameSpecificDemoHeaderCS_Error_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:PreProcessGameSpecificDemoHeaderCS")]
	public unsafe void PreProcessGameSpecificDemoHeaderCS()
	{
		CheckDestroyed();
		if (!PreProcessGameSpecificDemoHeaderCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:PreProcessGameSpecificDemoHeaderCS");
			return;
		}
		if (PreProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreProcessGameSpecificDemoHeaderCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreProcessGameSpecificDemoHeaderCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreProcessGameSpecificDemoHeaderCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress, argsSize: PreProcessGameSpecificDemoHeaderCS_ParamsSize);
	}

	protected unsafe virtual void PreProcessGameSpecificDemoHeaderCS_Implementation()
	{
		CheckDestroyed();
		if (!PreProcessGameSpecificDemoHeaderCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:PreProcessGameSpecificDemoHeaderCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreProcessGameSpecificDemoHeaderCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreProcessGameSpecificDemoHeaderCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreProcessGameSpecificDemoHeaderCS_FunctionAddress, argsSize: PreProcessGameSpecificDemoHeaderCS_ParamsSize);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:PostProcessGameSpecificDemoHeaderCS")]
	public unsafe void PostProcessGameSpecificDemoHeaderCS()
	{
		CheckDestroyed();
		if (!PostProcessGameSpecificDemoHeaderCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:PostProcessGameSpecificDemoHeaderCS");
			return;
		}
		if (PostProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostProcessGameSpecificDemoHeaderCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostProcessGameSpecificDemoHeaderCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostProcessGameSpecificDemoHeaderCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostProcessGameSpecificDemoHeaderCS_InstanceFunctionAddress, argsSize: PostProcessGameSpecificDemoHeaderCS_ParamsSize);
	}

	protected unsafe virtual void PostProcessGameSpecificDemoHeaderCS_Implementation()
	{
		CheckDestroyed();
		if (!PostProcessGameSpecificDemoHeaderCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:PostProcessGameSpecificDemoHeaderCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostProcessGameSpecificDemoHeaderCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostProcessGameSpecificDemoHeaderCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostProcessGameSpecificDemoHeaderCS_FunctionAddress, argsSize: PostProcessGameSpecificDemoHeaderCS_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnWriteGameSpecificDemoHeader")]
	public unsafe void OnWriteGameSpecificDemoHeader(out List<string> GameSpecificData)
	{
		CheckDestroyed();
		if (!OnWriteGameSpecificDemoHeader_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnWriteGameSpecificDemoHeader");
			GameSpecificData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWriteGameSpecificDemoHeader_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWriteGameSpecificDemoHeader_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWriteGameSpecificDemoHeader_FunctionAddress, intPtr, OnWriteGameSpecificDemoHeader_ParamsSize);
		GameSpecificData = new TArrayCopyMarshaler<string>(1, OnWriteGameSpecificDemoHeader_GameSpecificData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, OnWriteGameSpecificDemoHeader_GameSpecificData_Offset));
		NativeReflection.DestroyValue_InContainer(OnWriteGameSpecificDemoHeader_GameSpecificData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplayStarted")]
	public unsafe void OnReplayStarted(UWorld World)
	{
		CheckDestroyed();
		if (!OnReplayStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplayStarted");
			return;
		}
		if (OnReplayStarted_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnReplayStarted_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnReplayStarted");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReplayStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReplayStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnReplayStarted_World_Offset), 0, OnReplayStarted_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReplayStarted_InstanceFunctionAddress, intPtr, OnReplayStarted_ParamsSize);
	}

	protected unsafe virtual void OnReplayStarted_Implementation(UWorld World)
	{
		CheckDestroyed();
		if (!OnReplayStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplayStarted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReplayStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReplayStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnReplayStarted_World_Offset), 0, OnReplayStarted_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReplayStarted_FunctionAddress, intPtr, OnReplayStarted_ParamsSize);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplaySeverConnectionInit")]
	public unsafe void OnReplaySeverConnectionInit(UWorld World, UNetConnection SeverConnection)
	{
		CheckDestroyed();
		if (!OnReplaySeverConnectionInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplaySeverConnectionInit");
			return;
		}
		if (OnReplaySeverConnectionInit_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnReplaySeverConnectionInit_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnReplaySeverConnectionInit");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReplaySeverConnectionInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReplaySeverConnectionInit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnReplaySeverConnectionInit_World_Offset), 0, OnReplaySeverConnectionInit_World_PropertyAddress.Address, World);
		UObjectMarshaler<UNetConnection>.ToNative(IntPtr.Add(intPtr, OnReplaySeverConnectionInit_SeverConnection_Offset), 0, OnReplaySeverConnectionInit_SeverConnection_PropertyAddress.Address, SeverConnection);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReplaySeverConnectionInit_InstanceFunctionAddress, intPtr, OnReplaySeverConnectionInit_ParamsSize);
	}

	protected unsafe virtual void OnReplaySeverConnectionInit_Implementation(UWorld World, UNetConnection SeverConnection)
	{
		CheckDestroyed();
		if (!OnReplaySeverConnectionInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplaySeverConnectionInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReplaySeverConnectionInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReplaySeverConnectionInit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnReplaySeverConnectionInit_World_Offset), 0, OnReplaySeverConnectionInit_World_PropertyAddress.Address, World);
		UObjectMarshaler<UNetConnection>.ToNative(IntPtr.Add(intPtr, OnReplaySeverConnectionInit_SeverConnection_Offset), 0, OnReplaySeverConnectionInit_SeverConnection_PropertyAddress.Address, SeverConnection);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReplaySeverConnectionInit_FunctionAddress, intPtr, OnReplaySeverConnectionInit_ParamsSize);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplayScrubComplete")]
	public unsafe void OnReplayScrubComplete(UWorld World)
	{
		CheckDestroyed();
		if (!OnReplayScrubComplete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplayScrubComplete");
			return;
		}
		if (OnReplayScrubComplete_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnReplayScrubComplete_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnReplayScrubComplete");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReplayScrubComplete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReplayScrubComplete_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnReplayScrubComplete_World_Offset), 0, OnReplayScrubComplete_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReplayScrubComplete_InstanceFunctionAddress, intPtr, OnReplayScrubComplete_ParamsSize);
	}

	protected unsafe virtual void OnReplayScrubComplete_Implementation(UWorld World)
	{
		CheckDestroyed();
		if (!OnReplayScrubComplete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplayScrubComplete");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReplayScrubComplete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReplayScrubComplete_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnReplayScrubComplete_World_Offset), 0, OnReplayScrubComplete_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReplayScrubComplete_FunctionAddress, intPtr, OnReplayScrubComplete_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnProcessGameSpecificDemoHeader")]
	public unsafe void OnProcessGameSpecificDemoHeader(List<string> GameSpecificData, out string Error)
	{
		CheckDestroyed();
		if (!OnProcessGameSpecificDemoHeader_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnProcessGameSpecificDemoHeader");
			Error = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnProcessGameSpecificDemoHeader_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnProcessGameSpecificDemoHeader_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, OnProcessGameSpecificDemoHeader_GameSpecificData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, OnProcessGameSpecificDemoHeader_GameSpecificData_Offset), GameSpecificData);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnProcessGameSpecificDemoHeader_FunctionAddress, intPtr, OnProcessGameSpecificDemoHeader_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnProcessGameSpecificDemoHeader_GameSpecificData_PropertyAddress.Address, intPtr);
		Error = FStringMarshaler.FromNative(IntPtr.Add(intPtr, OnProcessGameSpecificDemoHeader_Error_Offset), 0, OnProcessGameSpecificDemoHeader_Error_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnProcessGameSpecificDemoHeader_Error_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnPreScrub")]
	public unsafe void OnPreScrub(UWorld World)
	{
		CheckDestroyed();
		if (!OnPreScrub_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnPreScrub");
			return;
		}
		if (OnPreScrub_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreScrub_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreScrub");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreScrub_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreScrub_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnPreScrub_World_Offset), 0, OnPreScrub_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreScrub_InstanceFunctionAddress, intPtr, OnPreScrub_ParamsSize);
	}

	protected unsafe virtual void OnPreScrub_Implementation(UWorld World)
	{
		CheckDestroyed();
		if (!OnPreScrub_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnPreScrub");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreScrub_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreScrub_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnPreScrub_World_Offset), 0, OnPreScrub_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreScrub_FunctionAddress, intPtr, OnPreScrub_ParamsSize);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnPostDemoPlay")]
	public unsafe void OnPostDemoPlay()
	{
		CheckDestroyed();
		if (!OnPostDemoPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnPostDemoPlay");
			return;
		}
		if (OnPostDemoPlay_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPostDemoPlay_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPostDemoPlay");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostDemoPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostDemoPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPostDemoPlay_InstanceFunctionAddress, argsSize: OnPostDemoPlay_ParamsSize);
	}

	protected unsafe virtual void OnPostDemoPlay_Implementation()
	{
		CheckDestroyed();
		if (!OnPostDemoPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnPostDemoPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostDemoPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostDemoPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPostDemoPlay_FunctionAddress, argsSize: OnPostDemoPlay_ParamsSize);
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:GSNetworkRemapPathCS")]
	public unsafe void GSNetworkRemapPathCS(UObject Outer, string OriginName, out string Name)
	{
		CheckDestroyed();
		if (!GSNetworkRemapPathCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:GSNetworkRemapPathCS");
			Name = FStringMarshaler.DefaultString;
			return;
		}
		if (GSNetworkRemapPathCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNetworkRemapPathCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNetworkRemapPathCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNetworkRemapPathCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNetworkRemapPathCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_Outer_Offset), 0, GSNetworkRemapPathCS_Outer_PropertyAddress.Address, Outer);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_OriginName_Offset), 0, GSNetworkRemapPathCS_OriginName_PropertyAddress.Address, OriginName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNetworkRemapPathCS_InstanceFunctionAddress, intPtr, GSNetworkRemapPathCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSNetworkRemapPathCS_OriginName_PropertyAddress.Address, intPtr);
		Name = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_Name_Offset), 0, GSNetworkRemapPathCS_Name_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GSNetworkRemapPathCS_Name_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void GSNetworkRemapPathCS_Implementation(UObject Outer, string OriginName, out string Name)
	{
		CheckDestroyed();
		if (!GSNetworkRemapPathCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:GSNetworkRemapPathCS");
			Name = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNetworkRemapPathCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNetworkRemapPathCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_Outer_Offset), 0, GSNetworkRemapPathCS_Outer_PropertyAddress.Address, Outer);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_OriginName_Offset), 0, GSNetworkRemapPathCS_OriginName_PropertyAddress.Address, OriginName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNetworkRemapPathCS_FunctionAddress, intPtr, GSNetworkRemapPathCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSNetworkRemapPathCS_OriginName_PropertyAddress.Address, intPtr);
		Name = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GSNetworkRemapPathCS_Name_Offset), 0, GSNetworkRemapPathCS_Name_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GSNetworkRemapPathCS_Name_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GSReplaySystem.GSReplayCSharpFuncLib:GSNetworkRemapPath")]
	public unsafe void GSNetworkRemapPath(UObject Outer, out string Name)
	{
		CheckDestroyed();
		if (!GSNetworkRemapPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSReplaySystem.GSReplayCSharpFuncLib:GSNetworkRemapPath");
			Name = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNetworkRemapPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNetworkRemapPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GSNetworkRemapPath_Outer_Offset), 0, GSNetworkRemapPath_Outer_PropertyAddress.Address, Outer);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNetworkRemapPath_FunctionAddress, intPtr, GSNetworkRemapPath_ParamsSize);
		Name = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GSNetworkRemapPath_Name_Offset), 0, GSNetworkRemapPath_Name_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GSNetworkRemapPath_Name_PropertyAddress.Address, intPtr);
	}

	static UGSReplayCSharpFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSReplayCSharpFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSReplayCSharpFuncLib));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GSReplaySystem.GSReplayCSharpFuncLib");
		WriteGameSpecificDemoHeaderCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WriteGameSpecificDemoHeaderCS");
		WriteGameSpecificDemoHeaderCS_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteGameSpecificDemoHeaderCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress, WriteGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData");
		WriteGameSpecificDemoHeaderCS_GameSpecificData_Offset = NativeReflectionCached.GetPropertyOffset(WriteGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData");
		WriteGameSpecificDemoHeaderCS_GameSpecificData_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData", Classes.FArrayProperty);
		WriteGameSpecificDemoHeaderCS_IsValid = WriteGameSpecificDemoHeaderCS_FunctionAddress != IntPtr.Zero && WriteGameSpecificDemoHeaderCS_GameSpecificData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:WriteGameSpecificDemoHeaderCS", WriteGameSpecificDemoHeaderCS_IsValid);
		SetViewTargetPlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetViewTargetPlayer");
		SetViewTargetPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewTargetPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewTargetPlayer_PlayerId_PropertyAddress, SetViewTargetPlayer_FunctionAddress, "PlayerId");
		SetViewTargetPlayer_PlayerId_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTargetPlayer_FunctionAddress, "PlayerId");
		SetViewTargetPlayer_PlayerId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTargetPlayer_FunctionAddress, "PlayerId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewTargetPlayer_ReturnValue_PropertyAddress, SetViewTargetPlayer_FunctionAddress, "ReturnValue");
		SetViewTargetPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTargetPlayer_FunctionAddress, "ReturnValue");
		SetViewTargetPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTargetPlayer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetViewTargetPlayer_IsValid = SetViewTargetPlayer_FunctionAddress != IntPtr.Zero && SetViewTargetPlayer_PlayerId_IsValid && SetViewTargetPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:SetViewTargetPlayer", SetViewTargetPlayer_IsValid);
		SetDemoCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDemoCurrentTime");
		SetDemoCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDemoCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDemoCurrentTime_InTimeToSet_PropertyAddress, SetDemoCurrentTime_FunctionAddress, "InTimeToSet");
		SetDemoCurrentTime_InTimeToSet_Offset = NativeReflectionCached.GetPropertyOffset(SetDemoCurrentTime_FunctionAddress, "InTimeToSet");
		SetDemoCurrentTime_InTimeToSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDemoCurrentTime_FunctionAddress, "InTimeToSet", Classes.FFloatProperty);
		SetDemoCurrentTime_IsValid = SetDemoCurrentTime_FunctionAddress != IntPtr.Zero && SetDemoCurrentTime_InTimeToSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:SetDemoCurrentTime", SetDemoCurrentTime_IsValid);
		ProcessGameSpecificDemoHeaderCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProcessGameSpecificDemoHeaderCS");
		ProcessGameSpecificDemoHeaderCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessGameSpecificDemoHeaderCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProcessGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress, ProcessGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData");
		ProcessGameSpecificDemoHeaderCS_GameSpecificData_Offset = NativeReflectionCached.GetPropertyOffset(ProcessGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData");
		ProcessGameSpecificDemoHeaderCS_GameSpecificData_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessGameSpecificDemoHeaderCS_Error_PropertyAddress, ProcessGameSpecificDemoHeaderCS_FunctionAddress, "Error");
		ProcessGameSpecificDemoHeaderCS_Error_Offset = NativeReflectionCached.GetPropertyOffset(ProcessGameSpecificDemoHeaderCS_FunctionAddress, "Error");
		ProcessGameSpecificDemoHeaderCS_Error_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessGameSpecificDemoHeaderCS_FunctionAddress, "Error", Classes.FStrProperty);
		ProcessGameSpecificDemoHeaderCS_IsValid = ProcessGameSpecificDemoHeaderCS_FunctionAddress != IntPtr.Zero && ProcessGameSpecificDemoHeaderCS_GameSpecificData_IsValid && ProcessGameSpecificDemoHeaderCS_Error_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:ProcessGameSpecificDemoHeaderCS", ProcessGameSpecificDemoHeaderCS_IsValid);
		PreProcessGameSpecificDemoHeaderCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreProcessGameSpecificDemoHeaderCS");
		PreProcessGameSpecificDemoHeaderCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PreProcessGameSpecificDemoHeaderCS_FunctionAddress);
		PreProcessGameSpecificDemoHeaderCS_IsValid = PreProcessGameSpecificDemoHeaderCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:PreProcessGameSpecificDemoHeaderCS", PreProcessGameSpecificDemoHeaderCS_IsValid);
		PostProcessGameSpecificDemoHeaderCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostProcessGameSpecificDemoHeaderCS");
		PostProcessGameSpecificDemoHeaderCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostProcessGameSpecificDemoHeaderCS_FunctionAddress);
		PostProcessGameSpecificDemoHeaderCS_IsValid = PostProcessGameSpecificDemoHeaderCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:PostProcessGameSpecificDemoHeaderCS", PostProcessGameSpecificDemoHeaderCS_IsValid);
		OnWriteGameSpecificDemoHeader_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWriteGameSpecificDemoHeader");
		OnWriteGameSpecificDemoHeader_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWriteGameSpecificDemoHeader_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWriteGameSpecificDemoHeader_GameSpecificData_PropertyAddress, OnWriteGameSpecificDemoHeader_FunctionAddress, "GameSpecificData");
		OnWriteGameSpecificDemoHeader_GameSpecificData_Offset = NativeReflectionCached.GetPropertyOffset(OnWriteGameSpecificDemoHeader_FunctionAddress, "GameSpecificData");
		OnWriteGameSpecificDemoHeader_GameSpecificData_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWriteGameSpecificDemoHeader_FunctionAddress, "GameSpecificData", Classes.FArrayProperty);
		OnWriteGameSpecificDemoHeader_IsValid = OnWriteGameSpecificDemoHeader_FunctionAddress != IntPtr.Zero && OnWriteGameSpecificDemoHeader_GameSpecificData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnWriteGameSpecificDemoHeader", OnWriteGameSpecificDemoHeader_IsValid);
		OnReplayStarted_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReplayStarted");
		OnReplayStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReplayStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnReplayStarted_World_PropertyAddress, OnReplayStarted_FunctionAddress, "World");
		OnReplayStarted_World_Offset = NativeReflectionCached.GetPropertyOffset(OnReplayStarted_FunctionAddress, "World");
		OnReplayStarted_World_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReplayStarted_FunctionAddress, "World", Classes.FObjectProperty);
		OnReplayStarted_IsValid = OnReplayStarted_FunctionAddress != IntPtr.Zero && OnReplayStarted_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplayStarted", OnReplayStarted_IsValid);
		OnReplaySeverConnectionInit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReplaySeverConnectionInit");
		OnReplaySeverConnectionInit_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReplaySeverConnectionInit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnReplaySeverConnectionInit_World_PropertyAddress, OnReplaySeverConnectionInit_FunctionAddress, "World");
		OnReplaySeverConnectionInit_World_Offset = NativeReflectionCached.GetPropertyOffset(OnReplaySeverConnectionInit_FunctionAddress, "World");
		OnReplaySeverConnectionInit_World_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReplaySeverConnectionInit_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnReplaySeverConnectionInit_SeverConnection_PropertyAddress, OnReplaySeverConnectionInit_FunctionAddress, "SeverConnection");
		OnReplaySeverConnectionInit_SeverConnection_Offset = NativeReflectionCached.GetPropertyOffset(OnReplaySeverConnectionInit_FunctionAddress, "SeverConnection");
		OnReplaySeverConnectionInit_SeverConnection_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReplaySeverConnectionInit_FunctionAddress, "SeverConnection", Classes.FObjectProperty);
		OnReplaySeverConnectionInit_IsValid = OnReplaySeverConnectionInit_FunctionAddress != IntPtr.Zero && OnReplaySeverConnectionInit_World_IsValid && OnReplaySeverConnectionInit_SeverConnection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplaySeverConnectionInit", OnReplaySeverConnectionInit_IsValid);
		OnReplayScrubComplete_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReplayScrubComplete");
		OnReplayScrubComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReplayScrubComplete_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnReplayScrubComplete_World_PropertyAddress, OnReplayScrubComplete_FunctionAddress, "World");
		OnReplayScrubComplete_World_Offset = NativeReflectionCached.GetPropertyOffset(OnReplayScrubComplete_FunctionAddress, "World");
		OnReplayScrubComplete_World_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReplayScrubComplete_FunctionAddress, "World", Classes.FObjectProperty);
		OnReplayScrubComplete_IsValid = OnReplayScrubComplete_FunctionAddress != IntPtr.Zero && OnReplayScrubComplete_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnReplayScrubComplete", OnReplayScrubComplete_IsValid);
		OnProcessGameSpecificDemoHeader_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnProcessGameSpecificDemoHeader");
		OnProcessGameSpecificDemoHeader_ParamsSize = NativeReflection.GetFunctionParamsSize(OnProcessGameSpecificDemoHeader_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnProcessGameSpecificDemoHeader_GameSpecificData_PropertyAddress, OnProcessGameSpecificDemoHeader_FunctionAddress, "GameSpecificData");
		OnProcessGameSpecificDemoHeader_GameSpecificData_Offset = NativeReflectionCached.GetPropertyOffset(OnProcessGameSpecificDemoHeader_FunctionAddress, "GameSpecificData");
		OnProcessGameSpecificDemoHeader_GameSpecificData_IsValid = NativeReflectionCached.ValidatePropertyClass(OnProcessGameSpecificDemoHeader_FunctionAddress, "GameSpecificData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OnProcessGameSpecificDemoHeader_Error_PropertyAddress, OnProcessGameSpecificDemoHeader_FunctionAddress, "Error");
		OnProcessGameSpecificDemoHeader_Error_Offset = NativeReflectionCached.GetPropertyOffset(OnProcessGameSpecificDemoHeader_FunctionAddress, "Error");
		OnProcessGameSpecificDemoHeader_Error_IsValid = NativeReflectionCached.ValidatePropertyClass(OnProcessGameSpecificDemoHeader_FunctionAddress, "Error", Classes.FStrProperty);
		OnProcessGameSpecificDemoHeader_IsValid = OnProcessGameSpecificDemoHeader_FunctionAddress != IntPtr.Zero && OnProcessGameSpecificDemoHeader_GameSpecificData_IsValid && OnProcessGameSpecificDemoHeader_Error_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnProcessGameSpecificDemoHeader", OnProcessGameSpecificDemoHeader_IsValid);
		OnPreScrub_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnPreScrub");
		OnPreScrub_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreScrub_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreScrub_World_PropertyAddress, OnPreScrub_FunctionAddress, "World");
		OnPreScrub_World_Offset = NativeReflectionCached.GetPropertyOffset(OnPreScrub_FunctionAddress, "World");
		OnPreScrub_World_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreScrub_FunctionAddress, "World", Classes.FObjectProperty);
		OnPreScrub_IsValid = OnPreScrub_FunctionAddress != IntPtr.Zero && OnPreScrub_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnPreScrub", OnPreScrub_IsValid);
		OnPostDemoPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnPostDemoPlay");
		OnPostDemoPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostDemoPlay_FunctionAddress);
		OnPostDemoPlay_IsValid = OnPostDemoPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:OnPostDemoPlay", OnPostDemoPlay_IsValid);
		GSNetworkRemapPathCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNetworkRemapPathCS");
		GSNetworkRemapPathCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNetworkRemapPathCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNetworkRemapPathCS_Outer_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "Outer");
		GSNetworkRemapPathCS_Outer_Offset = NativeReflectionCached.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "Outer");
		GSNetworkRemapPathCS_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNetworkRemapPathCS_OriginName_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "OriginName");
		GSNetworkRemapPathCS_OriginName_Offset = NativeReflectionCached.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "OriginName");
		GSNetworkRemapPathCS_OriginName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "OriginName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNetworkRemapPathCS_Name_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "Name");
		GSNetworkRemapPathCS_Name_Offset = NativeReflectionCached.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "Name");
		GSNetworkRemapPathCS_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "Name", Classes.FStrProperty);
		GSNetworkRemapPathCS_IsValid = GSNetworkRemapPathCS_FunctionAddress != IntPtr.Zero && GSNetworkRemapPathCS_Outer_IsValid && GSNetworkRemapPathCS_OriginName_IsValid && GSNetworkRemapPathCS_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:GSNetworkRemapPathCS", GSNetworkRemapPathCS_IsValid);
		GSNetworkRemapPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNetworkRemapPath");
		GSNetworkRemapPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNetworkRemapPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNetworkRemapPath_Outer_PropertyAddress, GSNetworkRemapPath_FunctionAddress, "Outer");
		GSNetworkRemapPath_Outer_Offset = NativeReflectionCached.GetPropertyOffset(GSNetworkRemapPath_FunctionAddress, "Outer");
		GSNetworkRemapPath_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNetworkRemapPath_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNetworkRemapPath_Name_PropertyAddress, GSNetworkRemapPath_FunctionAddress, "Name");
		GSNetworkRemapPath_Name_Offset = NativeReflectionCached.GetPropertyOffset(GSNetworkRemapPath_FunctionAddress, "Name");
		GSNetworkRemapPath_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNetworkRemapPath_FunctionAddress, "Name", Classes.FStrProperty);
		GSNetworkRemapPath_IsValid = GSNetworkRemapPath_FunctionAddress != IntPtr.Zero && GSNetworkRemapPath_Outer_IsValid && GSNetworkRemapPath_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSReplaySystem.GSReplayCSharpFuncLib:GSNetworkRemapPath", GSNetworkRemapPath_IsValid);
	}
}
