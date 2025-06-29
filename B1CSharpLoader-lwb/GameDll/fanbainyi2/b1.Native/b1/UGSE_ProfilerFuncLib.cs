using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_ProfilerFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_ProfilerFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StopRecordingPerfChart_IsValid;

	private static IntPtr StopRecordingPerfChart_FunctionAddress;

	private static int StopRecordingPerfChart_ParamsSize;

	private static bool StartRecordingPerfChart_IsValid;

	private static IntPtr StartRecordingPerfChart_FunctionAddress;

	private static int StartRecordingPerfChart_ParamsSize;

	private static bool StartRecordingPerfChart_TargetFileName_IsValid;

	private static FFieldAddress StartRecordingPerfChart_TargetFileName_PropertyAddress;

	private static int StartRecordingPerfChart_TargetFileName_Offset;

	private static bool StartRecordingPerfChart_InTotalFrames_IsValid;

	private static FFieldAddress StartRecordingPerfChart_InTotalFrames_PropertyAddress;

	private static int StartRecordingPerfChart_InTotalFrames_Offset;

	private static bool StartRecordingPerfChart_bCollectInsightData_IsValid;

	private static FFieldAddress StartRecordingPerfChart_bCollectInsightData_PropertyAddress;

	private static int StartRecordingPerfChart_bCollectInsightData_Offset;

	private static bool GSStatsMasterEnableAdd_IsValid;

	private static IntPtr GSStatsMasterEnableAdd_FunctionAddress;

	private static int GSStatsMasterEnableAdd_ParamsSize;

	private static bool CaptureSpecificStatsInfo_IsValid;

	private static IntPtr CaptureSpecificStatsInfo_FunctionAddress;

	private static int CaptureSpecificStatsInfo_ParamsSize;

	private static bool CaptureSpecificStatsInfo_StatNames_IsValid;

	private static FFieldAddress CaptureSpecificStatsInfo_StatNames_PropertyAddress;

	private static int CaptureSpecificStatsInfo_StatNames_Offset;

	private static bool CaptureSpecificStatsInfo_ReturnValue_IsValid;

	private static FFieldAddress CaptureSpecificStatsInfo_ReturnValue_PropertyAddress;

	private static int CaptureSpecificStatsInfo_ReturnValue_Offset;

	private static bool CaptureAllStatsInfo_IsValid;

	private static IntPtr CaptureAllStatsInfo_FunctionAddress;

	private static int CaptureAllStatsInfo_ParamsSize;

	private static bool CaptureAllStatsInfo_ReturnValue_IsValid;

	private static FFieldAddress CaptureAllStatsInfo_ReturnValue_PropertyAddress;

	private static int CaptureAllStatsInfo_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ProfilerFuncLib:StopRecordingPerfChart")]
	public unsafe static void StopRecordingPerfChart()
	{
		if (!StopRecordingPerfChart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ProfilerFuncLib:StopRecordingPerfChart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopRecordingPerfChart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopRecordingPerfChart_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StopRecordingPerfChart_FunctionAddress, argsSize: StopRecordingPerfChart_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ProfilerFuncLib:StartRecordingPerfChart")]
	public unsafe static void StartRecordingPerfChart(string TargetFileName, int InTotalFrames = 0, bool bCollectInsightData = false)
	{
		if (!StartRecordingPerfChart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ProfilerFuncLib:StartRecordingPerfChart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartRecordingPerfChart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartRecordingPerfChart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartRecordingPerfChart_TargetFileName_Offset), 0, StartRecordingPerfChart_TargetFileName_PropertyAddress.Address, TargetFileName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, StartRecordingPerfChart_InTotalFrames_Offset), 0, StartRecordingPerfChart_InTotalFrames_PropertyAddress.Address, InTotalFrames);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StartRecordingPerfChart_bCollectInsightData_Offset), 0, StartRecordingPerfChart_bCollectInsightData_PropertyAddress.Address, bCollectInsightData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartRecordingPerfChart_FunctionAddress, intPtr, StartRecordingPerfChart_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartRecordingPerfChart_TargetFileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ProfilerFuncLib:GSStatsMasterEnableAdd")]
	public unsafe static void GSStatsMasterEnableAdd()
	{
		if (!GSStatsMasterEnableAdd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ProfilerFuncLib:GSStatsMasterEnableAdd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSStatsMasterEnableAdd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSStatsMasterEnableAdd_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: GSStatsMasterEnableAdd_FunctionAddress, argsSize: GSStatsMasterEnableAdd_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ProfilerFuncLib:CaptureSpecificStatsInfo")]
	public unsafe static List<FGSCapturedStatResult> CaptureSpecificStatsInfo(List<string> StatNames)
	{
		if (!CaptureSpecificStatsInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ProfilerFuncLib:CaptureSpecificStatsInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureSpecificStatsInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureSpecificStatsInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, CaptureSpecificStatsInfo_StatNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, CaptureSpecificStatsInfo_StatNames_Offset), StatNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CaptureSpecificStatsInfo_FunctionAddress, intPtr, CaptureSpecificStatsInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CaptureSpecificStatsInfo_StatNames_PropertyAddress.Address, intPtr);
		List<FGSCapturedStatResult> result = new TArrayCopyMarshaler<FGSCapturedStatResult>(1, CaptureSpecificStatsInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.FromNative, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.ToNative).FromNative(IntPtr.Add(intPtr, CaptureSpecificStatsInfo_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CaptureSpecificStatsInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_ProfilerFuncLib:CaptureAllStatsInfo")]
	public unsafe static List<FGSCapturedStatResult> CaptureAllStatsInfo()
	{
		if (!CaptureAllStatsInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_ProfilerFuncLib:CaptureAllStatsInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureAllStatsInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureAllStatsInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CaptureAllStatsInfo_FunctionAddress, intPtr, CaptureAllStatsInfo_ParamsSize);
		List<FGSCapturedStatResult> result = new TArrayCopyMarshaler<FGSCapturedStatResult>(1, CaptureAllStatsInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.FromNative, CachedMarshalingDelegates<FGSCapturedStatResult, FGSCapturedStatResult>.ToNative).FromNative(IntPtr.Add(intPtr, CaptureAllStatsInfo_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CaptureAllStatsInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSE_ProfilerFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_ProfilerFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_ProfilerFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_ProfilerFuncLib");
		StopRecordingPerfChart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopRecordingPerfChart");
		StopRecordingPerfChart_ParamsSize = NativeReflection.GetFunctionParamsSize(StopRecordingPerfChart_FunctionAddress);
		StopRecordingPerfChart_IsValid = StopRecordingPerfChart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ProfilerFuncLib:StopRecordingPerfChart", StopRecordingPerfChart_IsValid);
		StartRecordingPerfChart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartRecordingPerfChart");
		StartRecordingPerfChart_ParamsSize = NativeReflection.GetFunctionParamsSize(StartRecordingPerfChart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartRecordingPerfChart_TargetFileName_PropertyAddress, StartRecordingPerfChart_FunctionAddress, "TargetFileName");
		StartRecordingPerfChart_TargetFileName_Offset = NativeReflectionCached.GetPropertyOffset(StartRecordingPerfChart_FunctionAddress, "TargetFileName");
		StartRecordingPerfChart_TargetFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecordingPerfChart_FunctionAddress, "TargetFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartRecordingPerfChart_InTotalFrames_PropertyAddress, StartRecordingPerfChart_FunctionAddress, "InTotalFrames");
		StartRecordingPerfChart_InTotalFrames_Offset = NativeReflectionCached.GetPropertyOffset(StartRecordingPerfChart_FunctionAddress, "InTotalFrames");
		StartRecordingPerfChart_InTotalFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecordingPerfChart_FunctionAddress, "InTotalFrames", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref StartRecordingPerfChart_bCollectInsightData_PropertyAddress, StartRecordingPerfChart_FunctionAddress, "bCollectInsightData");
		StartRecordingPerfChart_bCollectInsightData_Offset = NativeReflectionCached.GetPropertyOffset(StartRecordingPerfChart_FunctionAddress, "bCollectInsightData");
		StartRecordingPerfChart_bCollectInsightData_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecordingPerfChart_FunctionAddress, "bCollectInsightData", Classes.FBoolProperty);
		StartRecordingPerfChart_IsValid = StartRecordingPerfChart_FunctionAddress != IntPtr.Zero && StartRecordingPerfChart_TargetFileName_IsValid && StartRecordingPerfChart_InTotalFrames_IsValid && StartRecordingPerfChart_bCollectInsightData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ProfilerFuncLib:StartRecordingPerfChart", StartRecordingPerfChart_IsValid);
		GSStatsMasterEnableAdd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSStatsMasterEnableAdd");
		GSStatsMasterEnableAdd_ParamsSize = NativeReflection.GetFunctionParamsSize(GSStatsMasterEnableAdd_FunctionAddress);
		GSStatsMasterEnableAdd_IsValid = GSStatsMasterEnableAdd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ProfilerFuncLib:GSStatsMasterEnableAdd", GSStatsMasterEnableAdd_IsValid);
		CaptureSpecificStatsInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CaptureSpecificStatsInfo");
		CaptureSpecificStatsInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(CaptureSpecificStatsInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CaptureSpecificStatsInfo_StatNames_PropertyAddress, CaptureSpecificStatsInfo_FunctionAddress, "StatNames");
		CaptureSpecificStatsInfo_StatNames_Offset = NativeReflectionCached.GetPropertyOffset(CaptureSpecificStatsInfo_FunctionAddress, "StatNames");
		CaptureSpecificStatsInfo_StatNames_IsValid = NativeReflectionCached.ValidatePropertyClass(CaptureSpecificStatsInfo_FunctionAddress, "StatNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureSpecificStatsInfo_ReturnValue_PropertyAddress, CaptureSpecificStatsInfo_FunctionAddress, "ReturnValue");
		CaptureSpecificStatsInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CaptureSpecificStatsInfo_FunctionAddress, "ReturnValue");
		CaptureSpecificStatsInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CaptureSpecificStatsInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CaptureSpecificStatsInfo_IsValid = CaptureSpecificStatsInfo_FunctionAddress != IntPtr.Zero && CaptureSpecificStatsInfo_StatNames_IsValid && CaptureSpecificStatsInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ProfilerFuncLib:CaptureSpecificStatsInfo", CaptureSpecificStatsInfo_IsValid);
		CaptureAllStatsInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CaptureAllStatsInfo");
		CaptureAllStatsInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(CaptureAllStatsInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CaptureAllStatsInfo_ReturnValue_PropertyAddress, CaptureAllStatsInfo_FunctionAddress, "ReturnValue");
		CaptureAllStatsInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CaptureAllStatsInfo_FunctionAddress, "ReturnValue");
		CaptureAllStatsInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CaptureAllStatsInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CaptureAllStatsInfo_IsValid = CaptureAllStatsInfo_FunctionAddress != IntPtr.Zero && CaptureAllStatsInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_ProfilerFuncLib:CaptureAllStatsInfo", CaptureAllStatsInfo_IsValid);
	}
}
