using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGWStatsCapturer", "b1", UnrealModuleType.Game)]
public class ABGWStatsCapturer : AActor
{
	private static bool TickInterval_IsValid;

	private static int TickInterval_Offset;

	private static bool CaptureSwitch_IsValid;

	private static FFieldAddress CaptureSwitch_PropertyAddress;

	private static int CaptureSwitch_Offset;

	private static bool CapturingVRAMInfo_IsValid;

	private static FFieldAddress CapturingVRAMInfo_PropertyAddress;

	private static int CapturingVRAMInfo_Offset;

	private static bool StatDataTable_IsValid;

	private static int StatDataTable_Offset;

	private static bool StatNameList_IsValid;

	private static FFieldAddress StatNameList_PropertyAddress;

	private static int StatNameList_Offset;

	private TArrayReadWriteMarshaler<string> StatNameList_MarshalerCached;

	private static bool VRAMCategoryList_IsValid;

	private static FFieldAddress VRAMCategoryList_PropertyAddress;

	private static int VRAMCategoryList_Offset;

	private TArrayReadWriteMarshaler<string> VRAMCategoryList_MarshalerCached;

	private static bool DesiredStatsValue_IsValid;

	private static FFieldAddress DesiredStatsValue_PropertyAddress;

	private static int DesiredStatsValue_Offset;

	private TArrayReadOnlyMarshaler<FGSCapturedStatResult> DesiredStatsValue_MarshalerCached;

	private static bool DesiredVRAMInfo_IsValid;

	private static FFieldAddress DesiredVRAMInfo_PropertyAddress;

	private static int DesiredVRAMInfo_Offset;

	private TArrayReadOnlyMarshaler<FGSCapturedStatResult> DesiredVRAMInfo_MarshalerCached;

	private static bool GetTotalCapturedPerfInfo_IsValid;

	private static IntPtr GetTotalCapturedPerfInfo_FunctionAddress;

	private static int GetTotalCapturedPerfInfo_ParamsSize;

	private static bool GetTotalCapturedPerfInfo_ReturnValue_IsValid;

	private static FFieldAddress GetTotalCapturedPerfInfo_ReturnValue_PropertyAddress;

	private static int GetTotalCapturedPerfInfo_ReturnValue_Offset;

	private static bool GetStartCycle_IsValid;

	private static IntPtr GetStartCycle_FunctionAddress;

	private static int GetStartCycle_ParamsSize;

	private static bool GetStartCycle_ReturnValue_IsValid;

	private static FFieldAddress GetStartCycle_ReturnValue_PropertyAddress;

	private static int GetStartCycle_ReturnValue_Offset;

	private static bool GetDesiredVRAMInfo_IsValid;

	private static IntPtr GetDesiredVRAMInfo_FunctionAddress;

	private static int GetDesiredVRAMInfo_ParamsSize;

	private static bool GetDesiredVRAMInfo_ReturnValue_IsValid;

	private static FFieldAddress GetDesiredVRAMInfo_ReturnValue_PropertyAddress;

	private static int GetDesiredVRAMInfo_ReturnValue_Offset;

	private static bool GetDesiredStatsValue_IsValid;

	private static IntPtr GetDesiredStatsValue_FunctionAddress;

	private static int GetDesiredStatsValue_ParamsSize;

	private static bool GetDesiredStatsValue_ReturnValue_IsValid;

	private static FFieldAddress GetDesiredStatsValue_ReturnValue_PropertyAddress;

	private static int GetDesiredStatsValue_ReturnValue_Offset;

	private static bool ExecuteRHIDumpResMemCmds_IsValid;

	private static IntPtr ExecuteRHIDumpResMemCmds_FunctionAddress;

	private static int ExecuteRHIDumpResMemCmds_ParamsSize;

	private static bool EnableCapturing_DT_IsValid;

	private static IntPtr EnableCapturing_DT_FunctionAddress;

	private static int EnableCapturing_DT_ParamsSize;

	private static bool EnableCapturing_DT_bTriggerLogListening_IsValid;

	private static FFieldAddress EnableCapturing_DT_bTriggerLogListening_PropertyAddress;

	private static int EnableCapturing_DT_bTriggerLogListening_Offset;

	private static bool EnableCapturing_DT_InStatDataTable_IsValid;

	private static FFieldAddress EnableCapturing_DT_InStatDataTable_PropertyAddress;

	private static int EnableCapturing_DT_InStatDataTable_Offset;

	private static bool EnableCapturing_IsValid;

	private static IntPtr EnableCapturing_FunctionAddress;

	private static int EnableCapturing_ParamsSize;

	private static bool EnableCapturing_bTriggerLogListening_IsValid;

	private static FFieldAddress EnableCapturing_bTriggerLogListening_PropertyAddress;

	private static int EnableCapturing_bTriggerLogListening_Offset;

	private static bool EnableCapturing_MetricsConfigPathUnderProjDir_IsValid;

	private static FFieldAddress EnableCapturing_MetricsConfigPathUnderProjDir_PropertyAddress;

	private static int EnableCapturing_MetricsConfigPathUnderProjDir_Offset;

	private static bool DisableCapturing_IsValid;

	private static IntPtr DisableCapturing_FunctionAddress;

	private static int DisableCapturing_ParamsSize;

	private static bool DisableCapturing_bIsStop_IsValid;

	private static FFieldAddress DisableCapturing_bIsStop_PropertyAddress;

	private static int DisableCapturing_bIsStop_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:TickInterval")]
	public float TickInterval
	{
		get
		{
			CheckDestroyed();
			if (!TickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:TickInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TickInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:TickInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TickInterval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:bCaptureSwitch")]
	public bool CaptureSwitch
	{
		get
		{
			CheckDestroyed();
			if (!CaptureSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:bCaptureSwitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CaptureSwitch_Offset), 0, CaptureSwitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CaptureSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:bCaptureSwitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CaptureSwitch_Offset), 0, CaptureSwitch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:bCapturingVRAMInfo")]
	public bool CapturingVRAMInfo
	{
		get
		{
			CheckDestroyed();
			if (!CapturingVRAMInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:bCapturingVRAMInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CapturingVRAMInfo_Offset), 0, CapturingVRAMInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CapturingVRAMInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:bCapturingVRAMInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CapturingVRAMInfo_Offset), 0, CapturingVRAMInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:StatDataTable")]
	public UDataTable StatDataTable
	{
		get
		{
			CheckDestroyed();
			if (!StatDataTable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:StatDataTable");
				return null;
			}
			return UObjectMarshaler<UDataTable>.FromNative(IntPtr.Add(base.Address, StatDataTable_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StatDataTable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:StatDataTable");
			}
			else
			{
				UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(base.Address, StatDataTable_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:StatNameList")]
	public TArrayReadWrite<string> StatNameList
	{
		get
		{
			CheckDestroyed();
			if (!StatNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:StatNameList");
				return null;
			}
			if (StatNameList_MarshalerCached == null)
			{
				StatNameList_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, StatNameList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return StatNameList_MarshalerCached.FromNative(IntPtr.Add(base.Address, StatNameList_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:VRAMCategoryList")]
	public TArrayReadWrite<string> VRAMCategoryList
	{
		get
		{
			CheckDestroyed();
			if (!VRAMCategoryList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:VRAMCategoryList");
				return null;
			}
			if (VRAMCategoryList_MarshalerCached == null)
			{
				VRAMCategoryList_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, VRAMCategoryList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return VRAMCategoryList_MarshalerCached.FromNative(IntPtr.Add(base.Address, VRAMCategoryList_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:DesiredStatsValue")]
	public TArrayReadOnly<FGSCapturedStatResult> DesiredStatsValue
	{
		get
		{
			CheckDestroyed();
			if (!DesiredStatsValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:DesiredStatsValue");
				return null;
			}
			if (DesiredStatsValue_MarshalerCached == null)
			{
				DesiredStatsValue_MarshalerCached = new TArrayReadOnlyMarshaler<FGSCapturedStatResult>(1, DesiredStatsValue_PropertyAddress, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.FromNative, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.ToNative);
			}
			return DesiredStatsValue_MarshalerCached.FromNative(IntPtr.Add(base.Address, DesiredStatsValue_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:DesiredVRAMInfo")]
	public TArrayReadOnly<FGSCapturedStatResult> DesiredVRAMInfo
	{
		get
		{
			CheckDestroyed();
			if (!DesiredVRAMInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWStatsCapturer:DesiredVRAMInfo");
				return null;
			}
			if (DesiredVRAMInfo_MarshalerCached == null)
			{
				DesiredVRAMInfo_MarshalerCached = new TArrayReadOnlyMarshaler<FGSCapturedStatResult>(1, DesiredVRAMInfo_PropertyAddress, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.FromNative, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.ToNative);
			}
			return DesiredVRAMInfo_MarshalerCached.FromNative(IntPtr.Add(base.Address, DesiredVRAMInfo_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:GetTotalCapturedPerfInfo")]
	public unsafe List<FGSCapturedStatResult> GetTotalCapturedPerfInfo()
	{
		CheckDestroyed();
		if (!GetTotalCapturedPerfInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWStatsCapturer:GetTotalCapturedPerfInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTotalCapturedPerfInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTotalCapturedPerfInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTotalCapturedPerfInfo_FunctionAddress, intPtr, GetTotalCapturedPerfInfo_ParamsSize);
		List<FGSCapturedStatResult> result = new TArrayCopyMarshaler<FGSCapturedStatResult>(1, GetTotalCapturedPerfInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.FromNative, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.ToNative).FromNative(IntPtr.Add(intPtr, GetTotalCapturedPerfInfo_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTotalCapturedPerfInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:GetStartCycle")]
	public unsafe long GetStartCycle()
	{
		CheckDestroyed();
		if (!GetStartCycle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWStatsCapturer:GetStartCycle");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartCycle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartCycle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartCycle_FunctionAddress, intPtr, GetStartCycle_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetStartCycle_ReturnValue_Offset), 0, GetStartCycle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:GetDesiredVRAMInfo")]
	public unsafe List<FGSCapturedStatResult> GetDesiredVRAMInfo()
	{
		CheckDestroyed();
		if (!GetDesiredVRAMInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWStatsCapturer:GetDesiredVRAMInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDesiredVRAMInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDesiredVRAMInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDesiredVRAMInfo_FunctionAddress, intPtr, GetDesiredVRAMInfo_ParamsSize);
		List<FGSCapturedStatResult> result = new TArrayCopyMarshaler<FGSCapturedStatResult>(1, GetDesiredVRAMInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.FromNative, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.ToNative).FromNative(IntPtr.Add(intPtr, GetDesiredVRAMInfo_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetDesiredVRAMInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:GetDesiredStatsValue")]
	public unsafe List<FGSCapturedStatResult> GetDesiredStatsValue()
	{
		CheckDestroyed();
		if (!GetDesiredStatsValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWStatsCapturer:GetDesiredStatsValue");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDesiredStatsValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDesiredStatsValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDesiredStatsValue_FunctionAddress, intPtr, GetDesiredStatsValue_ParamsSize);
		List<FGSCapturedStatResult> result = new TArrayCopyMarshaler<FGSCapturedStatResult>(1, GetDesiredStatsValue_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.FromNative, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.ToNative).FromNative(IntPtr.Add(intPtr, GetDesiredStatsValue_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetDesiredStatsValue_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:ExecuteRHIDumpResMemCmds")]
	public unsafe void ExecuteRHIDumpResMemCmds()
	{
		CheckDestroyed();
		if (!ExecuteRHIDumpResMemCmds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWStatsCapturer:ExecuteRHIDumpResMemCmds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteRHIDumpResMemCmds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteRHIDumpResMemCmds_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ExecuteRHIDumpResMemCmds_FunctionAddress, argsSize: ExecuteRHIDumpResMemCmds_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:EnableCapturing_DT")]
	public unsafe void EnableCapturing_DT(bool bTriggerLogListening, UDataTable InStatDataTable)
	{
		CheckDestroyed();
		if (!EnableCapturing_DT_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWStatsCapturer:EnableCapturing_DT");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableCapturing_DT_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableCapturing_DT_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableCapturing_DT_bTriggerLogListening_Offset), 0, EnableCapturing_DT_bTriggerLogListening_PropertyAddress.Address, bTriggerLogListening);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, EnableCapturing_DT_InStatDataTable_Offset), 0, EnableCapturing_DT_InStatDataTable_PropertyAddress.Address, InStatDataTable);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableCapturing_DT_FunctionAddress, intPtr, EnableCapturing_DT_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:EnableCapturing")]
	public unsafe void EnableCapturing(bool bTriggerLogListening, string MetricsConfigPathUnderProjDir = "Tools/AutoMove/PerfMetrics.txt")
	{
		CheckDestroyed();
		if (!EnableCapturing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWStatsCapturer:EnableCapturing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableCapturing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableCapturing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableCapturing_bTriggerLogListening_Offset), 0, EnableCapturing_bTriggerLogListening_PropertyAddress.Address, bTriggerLogListening);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EnableCapturing_MetricsConfigPathUnderProjDir_Offset), 0, EnableCapturing_MetricsConfigPathUnderProjDir_PropertyAddress.Address, MetricsConfigPathUnderProjDir);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableCapturing_FunctionAddress, intPtr, EnableCapturing_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EnableCapturing_MetricsConfigPathUnderProjDir_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWStatsCapturer:DisableCapturing")]
	public unsafe void DisableCapturing(bool bIsStop)
	{
		CheckDestroyed();
		if (!DisableCapturing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWStatsCapturer:DisableCapturing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableCapturing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableCapturing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DisableCapturing_bIsStop_Offset), 0, DisableCapturing_bIsStop_PropertyAddress.Address, bIsStop);
		NativeReflection.InvokeFunctionOptimized(base.Address, DisableCapturing_FunctionAddress, intPtr, DisableCapturing_ParamsSize);
	}

	static ABGWStatsCapturer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWStatsCapturer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWStatsCapturer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGWStatsCapturer");
		TickInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TickInterval");
		TickInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TickInterval", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureSwitch_PropertyAddress, intPtr, "bCaptureSwitch");
		CaptureSwitch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCaptureSwitch");
		CaptureSwitch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCaptureSwitch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CapturingVRAMInfo_PropertyAddress, intPtr, "bCapturingVRAMInfo");
		CapturingVRAMInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCapturingVRAMInfo");
		CapturingVRAMInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCapturingVRAMInfo", Classes.FBoolProperty);
		StatDataTable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatDataTable");
		StatDataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatDataTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StatNameList_PropertyAddress, intPtr, "StatNameList");
		StatNameList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatNameList");
		StatNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatNameList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref VRAMCategoryList_PropertyAddress, intPtr, "VRAMCategoryList");
		VRAMCategoryList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VRAMCategoryList");
		VRAMCategoryList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VRAMCategoryList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DesiredStatsValue_PropertyAddress, intPtr, "DesiredStatsValue");
		DesiredStatsValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DesiredStatsValue");
		DesiredStatsValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DesiredStatsValue", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DesiredVRAMInfo_PropertyAddress, intPtr, "DesiredVRAMInfo");
		DesiredVRAMInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DesiredVRAMInfo");
		DesiredVRAMInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DesiredVRAMInfo", Classes.FArrayProperty);
		GetTotalCapturedPerfInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTotalCapturedPerfInfo");
		GetTotalCapturedPerfInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTotalCapturedPerfInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTotalCapturedPerfInfo_ReturnValue_PropertyAddress, GetTotalCapturedPerfInfo_FunctionAddress, "ReturnValue");
		GetTotalCapturedPerfInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTotalCapturedPerfInfo_FunctionAddress, "ReturnValue");
		GetTotalCapturedPerfInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTotalCapturedPerfInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetTotalCapturedPerfInfo_IsValid = GetTotalCapturedPerfInfo_FunctionAddress != IntPtr.Zero && GetTotalCapturedPerfInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWStatsCapturer:GetTotalCapturedPerfInfo", GetTotalCapturedPerfInfo_IsValid);
		GetStartCycle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStartCycle");
		GetStartCycle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartCycle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartCycle_ReturnValue_PropertyAddress, GetStartCycle_FunctionAddress, "ReturnValue");
		GetStartCycle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartCycle_FunctionAddress, "ReturnValue");
		GetStartCycle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartCycle_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetStartCycle_IsValid = GetStartCycle_FunctionAddress != IntPtr.Zero && GetStartCycle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWStatsCapturer:GetStartCycle", GetStartCycle_IsValid);
		GetDesiredVRAMInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDesiredVRAMInfo");
		GetDesiredVRAMInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDesiredVRAMInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDesiredVRAMInfo_ReturnValue_PropertyAddress, GetDesiredVRAMInfo_FunctionAddress, "ReturnValue");
		GetDesiredVRAMInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDesiredVRAMInfo_FunctionAddress, "ReturnValue");
		GetDesiredVRAMInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDesiredVRAMInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetDesiredVRAMInfo_IsValid = GetDesiredVRAMInfo_FunctionAddress != IntPtr.Zero && GetDesiredVRAMInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWStatsCapturer:GetDesiredVRAMInfo", GetDesiredVRAMInfo_IsValid);
		GetDesiredStatsValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDesiredStatsValue");
		GetDesiredStatsValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDesiredStatsValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDesiredStatsValue_ReturnValue_PropertyAddress, GetDesiredStatsValue_FunctionAddress, "ReturnValue");
		GetDesiredStatsValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDesiredStatsValue_FunctionAddress, "ReturnValue");
		GetDesiredStatsValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDesiredStatsValue_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetDesiredStatsValue_IsValid = GetDesiredStatsValue_FunctionAddress != IntPtr.Zero && GetDesiredStatsValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWStatsCapturer:GetDesiredStatsValue", GetDesiredStatsValue_IsValid);
		ExecuteRHIDumpResMemCmds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExecuteRHIDumpResMemCmds");
		ExecuteRHIDumpResMemCmds_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteRHIDumpResMemCmds_FunctionAddress);
		ExecuteRHIDumpResMemCmds_IsValid = ExecuteRHIDumpResMemCmds_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWStatsCapturer:ExecuteRHIDumpResMemCmds", ExecuteRHIDumpResMemCmds_IsValid);
		EnableCapturing_DT_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableCapturing_DT");
		EnableCapturing_DT_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableCapturing_DT_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableCapturing_DT_bTriggerLogListening_PropertyAddress, EnableCapturing_DT_FunctionAddress, "bTriggerLogListening");
		EnableCapturing_DT_bTriggerLogListening_Offset = NativeReflectionCached.GetPropertyOffset(EnableCapturing_DT_FunctionAddress, "bTriggerLogListening");
		EnableCapturing_DT_bTriggerLogListening_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableCapturing_DT_FunctionAddress, "bTriggerLogListening", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCapturing_DT_InStatDataTable_PropertyAddress, EnableCapturing_DT_FunctionAddress, "InStatDataTable");
		EnableCapturing_DT_InStatDataTable_Offset = NativeReflectionCached.GetPropertyOffset(EnableCapturing_DT_FunctionAddress, "InStatDataTable");
		EnableCapturing_DT_InStatDataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableCapturing_DT_FunctionAddress, "InStatDataTable", Classes.FObjectProperty);
		EnableCapturing_DT_IsValid = EnableCapturing_DT_FunctionAddress != IntPtr.Zero && EnableCapturing_DT_bTriggerLogListening_IsValid && EnableCapturing_DT_InStatDataTable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWStatsCapturer:EnableCapturing_DT", EnableCapturing_DT_IsValid);
		EnableCapturing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableCapturing");
		EnableCapturing_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableCapturing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableCapturing_bTriggerLogListening_PropertyAddress, EnableCapturing_FunctionAddress, "bTriggerLogListening");
		EnableCapturing_bTriggerLogListening_Offset = NativeReflectionCached.GetPropertyOffset(EnableCapturing_FunctionAddress, "bTriggerLogListening");
		EnableCapturing_bTriggerLogListening_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableCapturing_FunctionAddress, "bTriggerLogListening", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCapturing_MetricsConfigPathUnderProjDir_PropertyAddress, EnableCapturing_FunctionAddress, "MetricsConfigPathUnderProjDir");
		EnableCapturing_MetricsConfigPathUnderProjDir_Offset = NativeReflectionCached.GetPropertyOffset(EnableCapturing_FunctionAddress, "MetricsConfigPathUnderProjDir");
		EnableCapturing_MetricsConfigPathUnderProjDir_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableCapturing_FunctionAddress, "MetricsConfigPathUnderProjDir", Classes.FStrProperty);
		EnableCapturing_IsValid = EnableCapturing_FunctionAddress != IntPtr.Zero && EnableCapturing_bTriggerLogListening_IsValid && EnableCapturing_MetricsConfigPathUnderProjDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWStatsCapturer:EnableCapturing", EnableCapturing_IsValid);
		DisableCapturing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableCapturing");
		DisableCapturing_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableCapturing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableCapturing_bIsStop_PropertyAddress, DisableCapturing_FunctionAddress, "bIsStop");
		DisableCapturing_bIsStop_Offset = NativeReflectionCached.GetPropertyOffset(DisableCapturing_FunctionAddress, "bIsStop");
		DisableCapturing_bIsStop_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableCapturing_FunctionAddress, "bIsStop", Classes.FBoolProperty);
		DisableCapturing_IsValid = DisableCapturing_FunctionAddress != IntPtr.Zero && DisableCapturing_bIsStop_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWStatsCapturer:DisableCapturing", DisableCapturing_IsValid);
	}
}
