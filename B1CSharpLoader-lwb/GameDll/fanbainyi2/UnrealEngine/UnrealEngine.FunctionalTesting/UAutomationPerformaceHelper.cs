using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper", "FunctionalTesting", UnrealModuleType.Engine)]
public class UAutomationPerformaceHelper : UObject
{
	private static bool WriteLogFile_IsValid;

	private static IntPtr WriteLogFile_FunctionAddress;

	private static int WriteLogFile_ParamsSize;

	private static bool WriteLogFile_CaptureDir_IsValid;

	private static FFieldAddress WriteLogFile_CaptureDir_PropertyAddress;

	private static int WriteLogFile_CaptureDir_Offset;

	private static bool WriteLogFile_CaptureExtension_IsValid;

	private static FFieldAddress WriteLogFile_CaptureExtension_PropertyAddress;

	private static int WriteLogFile_CaptureExtension_Offset;

	private static bool TriggerGPUTraceIfRecordFallsBelowBudget_IsValid;

	private static IntPtr TriggerGPUTraceIfRecordFallsBelowBudget_FunctionAddress;

	private static int TriggerGPUTraceIfRecordFallsBelowBudget_ParamsSize;

	private static bool Tick_IsValid;

	private static IntPtr Tick_FunctionAddress;

	private static int Tick_ParamsSize;

	private static bool Tick_DeltaSeconds_IsValid;

	private static FFieldAddress Tick_DeltaSeconds_PropertyAddress;

	private static int Tick_DeltaSeconds_Offset;

	private static bool StopCPUProfiling_IsValid;

	private static IntPtr StopCPUProfiling_FunctionAddress;

	private static int StopCPUProfiling_ParamsSize;

	private static bool StartCPUProfiling_IsValid;

	private static IntPtr StartCPUProfiling_FunctionAddress;

	private static int StartCPUProfiling_ParamsSize;

	private static bool Sample_IsValid;

	private static IntPtr Sample_FunctionAddress;

	private static int Sample_ParamsSize;

	private static bool Sample_DeltaSeconds_IsValid;

	private static FFieldAddress Sample_DeltaSeconds_PropertyAddress;

	private static int Sample_DeltaSeconds_Offset;

	private static bool OnBeginTests_IsValid;

	private static IntPtr OnBeginTests_FunctionAddress;

	private static int OnBeginTests_ParamsSize;

	private static bool OnAllTestsComplete_IsValid;

	private static IntPtr OnAllTestsComplete_FunctionAddress;

	private static int OnAllTestsComplete_ParamsSize;

	private static bool IsRecording_IsValid;

	private static IntPtr IsRecording_FunctionAddress;

	private static int IsRecording_ParamsSize;

	private static bool IsRecording_ReturnValue_IsValid;

	private static FFieldAddress IsRecording_ReturnValue_PropertyAddress;

	private static int IsRecording_ReturnValue_Offset;

	private static bool IsCurrentRecordWithinRenderThreadBudget_IsValid;

	private static IntPtr IsCurrentRecordWithinRenderThreadBudget_FunctionAddress;

	private static int IsCurrentRecordWithinRenderThreadBudget_ParamsSize;

	private static bool IsCurrentRecordWithinRenderThreadBudget_ReturnValue_IsValid;

	private static FFieldAddress IsCurrentRecordWithinRenderThreadBudget_ReturnValue_PropertyAddress;

	private static int IsCurrentRecordWithinRenderThreadBudget_ReturnValue_Offset;

	private static bool IsCurrentRecordWithinGPUBudget_IsValid;

	private static IntPtr IsCurrentRecordWithinGPUBudget_FunctionAddress;

	private static int IsCurrentRecordWithinGPUBudget_ParamsSize;

	private static bool IsCurrentRecordWithinGPUBudget_ReturnValue_IsValid;

	private static FFieldAddress IsCurrentRecordWithinGPUBudget_ReturnValue_PropertyAddress;

	private static int IsCurrentRecordWithinGPUBudget_ReturnValue_Offset;

	private static bool IsCurrentRecordWithinGameThreadBudget_IsValid;

	private static IntPtr IsCurrentRecordWithinGameThreadBudget_FunctionAddress;

	private static int IsCurrentRecordWithinGameThreadBudget_ParamsSize;

	private static bool IsCurrentRecordWithinGameThreadBudget_ReturnValue_IsValid;

	private static FFieldAddress IsCurrentRecordWithinGameThreadBudget_ReturnValue_PropertyAddress;

	private static int IsCurrentRecordWithinGameThreadBudget_ReturnValue_Offset;

	private static bool EndStatsFile_IsValid;

	private static IntPtr EndStatsFile_FunctionAddress;

	private static int EndStatsFile_ParamsSize;

	private static bool EndRecordingBaseline_IsValid;

	private static IntPtr EndRecordingBaseline_FunctionAddress;

	private static int EndRecordingBaseline_ParamsSize;

	private static bool EndRecording_IsValid;

	private static IntPtr EndRecording_FunctionAddress;

	private static int EndRecording_ParamsSize;

	private static bool BeginStatsFile_IsValid;

	private static IntPtr BeginStatsFile_FunctionAddress;

	private static int BeginStatsFile_ParamsSize;

	private static bool BeginStatsFile_RecordName_IsValid;

	private static FFieldAddress BeginStatsFile_RecordName_PropertyAddress;

	private static int BeginStatsFile_RecordName_Offset;

	private static bool BeginRecordingBaseline_IsValid;

	private static IntPtr BeginRecordingBaseline_FunctionAddress;

	private static int BeginRecordingBaseline_ParamsSize;

	private static bool BeginRecordingBaseline_RecordName_IsValid;

	private static FFieldAddress BeginRecordingBaseline_RecordName_PropertyAddress;

	private static int BeginRecordingBaseline_RecordName_Offset;

	private static bool BeginRecording_IsValid;

	private static IntPtr BeginRecording_FunctionAddress;

	private static int BeginRecording_ParamsSize;

	private static bool BeginRecording_RecordName_IsValid;

	private static FFieldAddress BeginRecording_RecordName_PropertyAddress;

	private static int BeginRecording_RecordName_Offset;

	private static bool BeginRecording_InGPUBudget_IsValid;

	private static FFieldAddress BeginRecording_InGPUBudget_PropertyAddress;

	private static int BeginRecording_InGPUBudget_Offset;

	private static bool BeginRecording_InRenderThreadBudget_IsValid;

	private static FFieldAddress BeginRecording_InRenderThreadBudget_PropertyAddress;

	private static int BeginRecording_InRenderThreadBudget_Offset;

	private static bool BeginRecording_InGameThreadBudget_IsValid;

	private static FFieldAddress BeginRecording_InGameThreadBudget_PropertyAddress;

	private static int BeginRecording_InGameThreadBudget_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:WriteLogFile")]
	public unsafe void WriteLogFile(string CaptureDir, string CaptureExtension)
	{
		CheckDestroyed();
		if (!WriteLogFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:WriteLogFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteLogFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteLogFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WriteLogFile_CaptureDir_Offset), 0, WriteLogFile_CaptureDir_PropertyAddress.Address, CaptureDir);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WriteLogFile_CaptureExtension_Offset), 0, WriteLogFile_CaptureExtension_PropertyAddress.Address, CaptureExtension);
		NativeReflection.InvokeFunctionOptimized(base.Address, WriteLogFile_FunctionAddress, intPtr, WriteLogFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WriteLogFile_CaptureDir_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(WriteLogFile_CaptureExtension_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:TriggerGPUTraceIfRecordFallsBelowBudget")]
	public unsafe void TriggerGPUTraceIfRecordFallsBelowBudget()
	{
		CheckDestroyed();
		if (!TriggerGPUTraceIfRecordFallsBelowBudget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:TriggerGPUTraceIfRecordFallsBelowBudget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TriggerGPUTraceIfRecordFallsBelowBudget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TriggerGPUTraceIfRecordFallsBelowBudget_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: TriggerGPUTraceIfRecordFallsBelowBudget_FunctionAddress, argsSize: TriggerGPUTraceIfRecordFallsBelowBudget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:Tick")]
	public unsafe void Tick(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!Tick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:Tick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Tick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Tick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Tick_DeltaSeconds_Offset), 0, Tick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, Tick_FunctionAddress, intPtr, Tick_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:StopCPUProfiling")]
	public unsafe void StopCPUProfiling()
	{
		CheckDestroyed();
		if (!StopCPUProfiling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:StopCPUProfiling");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopCPUProfiling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopCPUProfiling_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopCPUProfiling_FunctionAddress, argsSize: StopCPUProfiling_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:StartCPUProfiling")]
	public unsafe void StartCPUProfiling()
	{
		CheckDestroyed();
		if (!StartCPUProfiling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:StartCPUProfiling");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartCPUProfiling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartCPUProfiling_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartCPUProfiling_FunctionAddress, argsSize: StartCPUProfiling_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:Sample")]
	public unsafe void Sample(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!Sample_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:Sample");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Sample_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Sample_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Sample_DeltaSeconds_Offset), 0, Sample_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, Sample_FunctionAddress, intPtr, Sample_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:OnBeginTests")]
	public unsafe void OnBeginTests()
	{
		CheckDestroyed();
		if (!OnBeginTests_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:OnBeginTests");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBeginTests_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBeginTests_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBeginTests_FunctionAddress, argsSize: OnBeginTests_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:OnAllTestsComplete")]
	public unsafe void OnAllTestsComplete()
	{
		CheckDestroyed();
		if (!OnAllTestsComplete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:OnAllTestsComplete");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAllTestsComplete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAllTestsComplete_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnAllTestsComplete_FunctionAddress, argsSize: OnAllTestsComplete_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:IsRecording")]
	public unsafe bool IsRecording()
	{
		CheckDestroyed();
		if (!IsRecording_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:IsRecording");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRecording_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRecording_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRecording_FunctionAddress, intPtr, IsRecording_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRecording_ReturnValue_Offset), 0, IsRecording_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:IsCurrentRecordWithinRenderThreadBudget")]
	public unsafe bool IsCurrentRecordWithinRenderThreadBudget()
	{
		CheckDestroyed();
		if (!IsCurrentRecordWithinRenderThreadBudget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:IsCurrentRecordWithinRenderThreadBudget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCurrentRecordWithinRenderThreadBudget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCurrentRecordWithinRenderThreadBudget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCurrentRecordWithinRenderThreadBudget_FunctionAddress, intPtr, IsCurrentRecordWithinRenderThreadBudget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCurrentRecordWithinRenderThreadBudget_ReturnValue_Offset), 0, IsCurrentRecordWithinRenderThreadBudget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:IsCurrentRecordWithinGPUBudget")]
	public unsafe bool IsCurrentRecordWithinGPUBudget()
	{
		CheckDestroyed();
		if (!IsCurrentRecordWithinGPUBudget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:IsCurrentRecordWithinGPUBudget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCurrentRecordWithinGPUBudget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCurrentRecordWithinGPUBudget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCurrentRecordWithinGPUBudget_FunctionAddress, intPtr, IsCurrentRecordWithinGPUBudget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCurrentRecordWithinGPUBudget_ReturnValue_Offset), 0, IsCurrentRecordWithinGPUBudget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:IsCurrentRecordWithinGameThreadBudget")]
	public unsafe bool IsCurrentRecordWithinGameThreadBudget()
	{
		CheckDestroyed();
		if (!IsCurrentRecordWithinGameThreadBudget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:IsCurrentRecordWithinGameThreadBudget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCurrentRecordWithinGameThreadBudget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCurrentRecordWithinGameThreadBudget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCurrentRecordWithinGameThreadBudget_FunctionAddress, intPtr, IsCurrentRecordWithinGameThreadBudget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCurrentRecordWithinGameThreadBudget_ReturnValue_Offset), 0, IsCurrentRecordWithinGameThreadBudget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:EndStatsFile")]
	public unsafe void EndStatsFile()
	{
		CheckDestroyed();
		if (!EndStatsFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:EndStatsFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndStatsFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndStatsFile_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EndStatsFile_FunctionAddress, argsSize: EndStatsFile_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:EndRecordingBaseline")]
	public unsafe void EndRecordingBaseline()
	{
		CheckDestroyed();
		if (!EndRecordingBaseline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:EndRecordingBaseline");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndRecordingBaseline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndRecordingBaseline_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EndRecordingBaseline_FunctionAddress, argsSize: EndRecordingBaseline_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:EndRecording")]
	public unsafe void EndRecording()
	{
		CheckDestroyed();
		if (!EndRecording_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:EndRecording");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndRecording_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndRecording_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EndRecording_FunctionAddress, argsSize: EndRecording_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:BeginStatsFile")]
	public unsafe void BeginStatsFile(string RecordName)
	{
		CheckDestroyed();
		if (!BeginStatsFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:BeginStatsFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginStatsFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginStatsFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BeginStatsFile_RecordName_Offset), 0, BeginStatsFile_RecordName_PropertyAddress.Address, RecordName);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeginStatsFile_FunctionAddress, intPtr, BeginStatsFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BeginStatsFile_RecordName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:BeginRecordingBaseline")]
	public unsafe void BeginRecordingBaseline(string RecordName)
	{
		CheckDestroyed();
		if (!BeginRecordingBaseline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:BeginRecordingBaseline");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginRecordingBaseline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginRecordingBaseline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BeginRecordingBaseline_RecordName_Offset), 0, BeginRecordingBaseline_RecordName_PropertyAddress.Address, RecordName);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeginRecordingBaseline_FunctionAddress, intPtr, BeginRecordingBaseline_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BeginRecordingBaseline_RecordName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.AutomationPerformaceHelper:BeginRecording")]
	public unsafe void BeginRecording(string RecordName, float InGPUBudget, float InRenderThreadBudget, float InGameThreadBudget)
	{
		CheckDestroyed();
		if (!BeginRecording_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.AutomationPerformaceHelper:BeginRecording");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginRecording_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginRecording_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BeginRecording_RecordName_Offset), 0, BeginRecording_RecordName_PropertyAddress.Address, RecordName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BeginRecording_InGPUBudget_Offset), 0, BeginRecording_InGPUBudget_PropertyAddress.Address, InGPUBudget);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BeginRecording_InRenderThreadBudget_Offset), 0, BeginRecording_InRenderThreadBudget_PropertyAddress.Address, InRenderThreadBudget);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BeginRecording_InGameThreadBudget_Offset), 0, BeginRecording_InGameThreadBudget_PropertyAddress.Address, InGameThreadBudget);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeginRecording_FunctionAddress, intPtr, BeginRecording_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BeginRecording_RecordName_PropertyAddress.Address, intPtr);
	}

	static UAutomationPerformaceHelper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAutomationPerformaceHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAutomationPerformaceHelper));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FunctionalTesting.AutomationPerformaceHelper");
		WriteLogFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WriteLogFile");
		WriteLogFile_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteLogFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteLogFile_CaptureDir_PropertyAddress, WriteLogFile_FunctionAddress, "CaptureDir");
		WriteLogFile_CaptureDir_Offset = NativeReflectionCached.GetPropertyOffset(WriteLogFile_FunctionAddress, "CaptureDir");
		WriteLogFile_CaptureDir_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteLogFile_FunctionAddress, "CaptureDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteLogFile_CaptureExtension_PropertyAddress, WriteLogFile_FunctionAddress, "CaptureExtension");
		WriteLogFile_CaptureExtension_Offset = NativeReflectionCached.GetPropertyOffset(WriteLogFile_FunctionAddress, "CaptureExtension");
		WriteLogFile_CaptureExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteLogFile_FunctionAddress, "CaptureExtension", Classes.FStrProperty);
		WriteLogFile_IsValid = WriteLogFile_FunctionAddress != IntPtr.Zero && WriteLogFile_CaptureDir_IsValid && WriteLogFile_CaptureExtension_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:WriteLogFile", WriteLogFile_IsValid);
		TriggerGPUTraceIfRecordFallsBelowBudget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TriggerGPUTraceIfRecordFallsBelowBudget");
		TriggerGPUTraceIfRecordFallsBelowBudget_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggerGPUTraceIfRecordFallsBelowBudget_FunctionAddress);
		TriggerGPUTraceIfRecordFallsBelowBudget_IsValid = TriggerGPUTraceIfRecordFallsBelowBudget_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:TriggerGPUTraceIfRecordFallsBelowBudget", TriggerGPUTraceIfRecordFallsBelowBudget_IsValid);
		Tick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Tick");
		Tick_ParamsSize = NativeReflection.GetFunctionParamsSize(Tick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Tick_DeltaSeconds_PropertyAddress, Tick_FunctionAddress, "DeltaSeconds");
		Tick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(Tick_FunctionAddress, "DeltaSeconds");
		Tick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(Tick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		Tick_IsValid = Tick_FunctionAddress != IntPtr.Zero && Tick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:Tick", Tick_IsValid);
		StopCPUProfiling_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopCPUProfiling");
		StopCPUProfiling_ParamsSize = NativeReflection.GetFunctionParamsSize(StopCPUProfiling_FunctionAddress);
		StopCPUProfiling_IsValid = StopCPUProfiling_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:StopCPUProfiling", StopCPUProfiling_IsValid);
		StartCPUProfiling_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartCPUProfiling");
		StartCPUProfiling_ParamsSize = NativeReflection.GetFunctionParamsSize(StartCPUProfiling_FunctionAddress);
		StartCPUProfiling_IsValid = StartCPUProfiling_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:StartCPUProfiling", StartCPUProfiling_IsValid);
		Sample_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Sample");
		Sample_ParamsSize = NativeReflection.GetFunctionParamsSize(Sample_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Sample_DeltaSeconds_PropertyAddress, Sample_FunctionAddress, "DeltaSeconds");
		Sample_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(Sample_FunctionAddress, "DeltaSeconds");
		Sample_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(Sample_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		Sample_IsValid = Sample_FunctionAddress != IntPtr.Zero && Sample_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:Sample", Sample_IsValid);
		OnBeginTests_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnBeginTests");
		OnBeginTests_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBeginTests_FunctionAddress);
		OnBeginTests_IsValid = OnBeginTests_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:OnBeginTests", OnBeginTests_IsValid);
		OnAllTestsComplete_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAllTestsComplete");
		OnAllTestsComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAllTestsComplete_FunctionAddress);
		OnAllTestsComplete_IsValid = OnAllTestsComplete_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:OnAllTestsComplete", OnAllTestsComplete_IsValid);
		IsRecording_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsRecording");
		IsRecording_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRecording_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRecording_ReturnValue_PropertyAddress, IsRecording_FunctionAddress, "ReturnValue");
		IsRecording_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRecording_FunctionAddress, "ReturnValue");
		IsRecording_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRecording_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRecording_IsValid = IsRecording_FunctionAddress != IntPtr.Zero && IsRecording_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:IsRecording", IsRecording_IsValid);
		IsCurrentRecordWithinRenderThreadBudget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsCurrentRecordWithinRenderThreadBudget");
		IsCurrentRecordWithinRenderThreadBudget_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCurrentRecordWithinRenderThreadBudget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCurrentRecordWithinRenderThreadBudget_ReturnValue_PropertyAddress, IsCurrentRecordWithinRenderThreadBudget_FunctionAddress, "ReturnValue");
		IsCurrentRecordWithinRenderThreadBudget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCurrentRecordWithinRenderThreadBudget_FunctionAddress, "ReturnValue");
		IsCurrentRecordWithinRenderThreadBudget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCurrentRecordWithinRenderThreadBudget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCurrentRecordWithinRenderThreadBudget_IsValid = IsCurrentRecordWithinRenderThreadBudget_FunctionAddress != IntPtr.Zero && IsCurrentRecordWithinRenderThreadBudget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:IsCurrentRecordWithinRenderThreadBudget", IsCurrentRecordWithinRenderThreadBudget_IsValid);
		IsCurrentRecordWithinGPUBudget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsCurrentRecordWithinGPUBudget");
		IsCurrentRecordWithinGPUBudget_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCurrentRecordWithinGPUBudget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCurrentRecordWithinGPUBudget_ReturnValue_PropertyAddress, IsCurrentRecordWithinGPUBudget_FunctionAddress, "ReturnValue");
		IsCurrentRecordWithinGPUBudget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCurrentRecordWithinGPUBudget_FunctionAddress, "ReturnValue");
		IsCurrentRecordWithinGPUBudget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCurrentRecordWithinGPUBudget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCurrentRecordWithinGPUBudget_IsValid = IsCurrentRecordWithinGPUBudget_FunctionAddress != IntPtr.Zero && IsCurrentRecordWithinGPUBudget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:IsCurrentRecordWithinGPUBudget", IsCurrentRecordWithinGPUBudget_IsValid);
		IsCurrentRecordWithinGameThreadBudget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsCurrentRecordWithinGameThreadBudget");
		IsCurrentRecordWithinGameThreadBudget_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCurrentRecordWithinGameThreadBudget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCurrentRecordWithinGameThreadBudget_ReturnValue_PropertyAddress, IsCurrentRecordWithinGameThreadBudget_FunctionAddress, "ReturnValue");
		IsCurrentRecordWithinGameThreadBudget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCurrentRecordWithinGameThreadBudget_FunctionAddress, "ReturnValue");
		IsCurrentRecordWithinGameThreadBudget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCurrentRecordWithinGameThreadBudget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCurrentRecordWithinGameThreadBudget_IsValid = IsCurrentRecordWithinGameThreadBudget_FunctionAddress != IntPtr.Zero && IsCurrentRecordWithinGameThreadBudget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:IsCurrentRecordWithinGameThreadBudget", IsCurrentRecordWithinGameThreadBudget_IsValid);
		EndStatsFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndStatsFile");
		EndStatsFile_ParamsSize = NativeReflection.GetFunctionParamsSize(EndStatsFile_FunctionAddress);
		EndStatsFile_IsValid = EndStatsFile_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:EndStatsFile", EndStatsFile_IsValid);
		EndRecordingBaseline_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndRecordingBaseline");
		EndRecordingBaseline_ParamsSize = NativeReflection.GetFunctionParamsSize(EndRecordingBaseline_FunctionAddress);
		EndRecordingBaseline_IsValid = EndRecordingBaseline_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:EndRecordingBaseline", EndRecordingBaseline_IsValid);
		EndRecording_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndRecording");
		EndRecording_ParamsSize = NativeReflection.GetFunctionParamsSize(EndRecording_FunctionAddress);
		EndRecording_IsValid = EndRecording_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:EndRecording", EndRecording_IsValid);
		BeginStatsFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginStatsFile");
		BeginStatsFile_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginStatsFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginStatsFile_RecordName_PropertyAddress, BeginStatsFile_FunctionAddress, "RecordName");
		BeginStatsFile_RecordName_Offset = NativeReflectionCached.GetPropertyOffset(BeginStatsFile_FunctionAddress, "RecordName");
		BeginStatsFile_RecordName_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginStatsFile_FunctionAddress, "RecordName", Classes.FStrProperty);
		BeginStatsFile_IsValid = BeginStatsFile_FunctionAddress != IntPtr.Zero && BeginStatsFile_RecordName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:BeginStatsFile", BeginStatsFile_IsValid);
		BeginRecordingBaseline_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginRecordingBaseline");
		BeginRecordingBaseline_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginRecordingBaseline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginRecordingBaseline_RecordName_PropertyAddress, BeginRecordingBaseline_FunctionAddress, "RecordName");
		BeginRecordingBaseline_RecordName_Offset = NativeReflectionCached.GetPropertyOffset(BeginRecordingBaseline_FunctionAddress, "RecordName");
		BeginRecordingBaseline_RecordName_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginRecordingBaseline_FunctionAddress, "RecordName", Classes.FStrProperty);
		BeginRecordingBaseline_IsValid = BeginRecordingBaseline_FunctionAddress != IntPtr.Zero && BeginRecordingBaseline_RecordName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:BeginRecordingBaseline", BeginRecordingBaseline_IsValid);
		BeginRecording_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginRecording");
		BeginRecording_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginRecording_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginRecording_RecordName_PropertyAddress, BeginRecording_FunctionAddress, "RecordName");
		BeginRecording_RecordName_Offset = NativeReflectionCached.GetPropertyOffset(BeginRecording_FunctionAddress, "RecordName");
		BeginRecording_RecordName_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginRecording_FunctionAddress, "RecordName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginRecording_InGPUBudget_PropertyAddress, BeginRecording_FunctionAddress, "InGPUBudget");
		BeginRecording_InGPUBudget_Offset = NativeReflectionCached.GetPropertyOffset(BeginRecording_FunctionAddress, "InGPUBudget");
		BeginRecording_InGPUBudget_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginRecording_FunctionAddress, "InGPUBudget", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginRecording_InRenderThreadBudget_PropertyAddress, BeginRecording_FunctionAddress, "InRenderThreadBudget");
		BeginRecording_InRenderThreadBudget_Offset = NativeReflectionCached.GetPropertyOffset(BeginRecording_FunctionAddress, "InRenderThreadBudget");
		BeginRecording_InRenderThreadBudget_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginRecording_FunctionAddress, "InRenderThreadBudget", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginRecording_InGameThreadBudget_PropertyAddress, BeginRecording_FunctionAddress, "InGameThreadBudget");
		BeginRecording_InGameThreadBudget_Offset = NativeReflectionCached.GetPropertyOffset(BeginRecording_FunctionAddress, "InGameThreadBudget");
		BeginRecording_InGameThreadBudget_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginRecording_FunctionAddress, "InGameThreadBudget", Classes.FFloatProperty);
		BeginRecording_IsValid = BeginRecording_FunctionAddress != IntPtr.Zero && BeginRecording_RecordName_IsValid && BeginRecording_InGPUBudget_IsValid && BeginRecording_InRenderThreadBudget_IsValid && BeginRecording_InGameThreadBudget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.AutomationPerformaceHelper:BeginRecording", BeginRecording_IsValid);
	}
}
