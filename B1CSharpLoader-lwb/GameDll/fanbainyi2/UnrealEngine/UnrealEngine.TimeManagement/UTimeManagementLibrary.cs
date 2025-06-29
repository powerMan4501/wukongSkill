using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.TimeManagement;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary", "TimeManagement", UnrealModuleType.Engine)]
public class UTimeManagementLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TransformTime_IsValid;

	private static IntPtr TransformTime_FunctionAddress;

	private static int TransformTime_ParamsSize;

	private static bool TransformTime_SourceTime_IsValid;

	private static FFieldAddress TransformTime_SourceTime_PropertyAddress;

	private static int TransformTime_SourceTime_Offset;

	private static bool TransformTime_SourceRate_IsValid;

	private static FFieldAddress TransformTime_SourceRate_PropertyAddress;

	private static int TransformTime_SourceRate_Offset;

	private static bool TransformTime_DestinationRate_IsValid;

	private static FFieldAddress TransformTime_DestinationRate_PropertyAddress;

	private static int TransformTime_DestinationRate_Offset;

	private static bool TransformTime_ReturnValue_IsValid;

	private static FFieldAddress TransformTime_ReturnValue_PropertyAddress;

	private static int TransformTime_ReturnValue_Offset;

	private static bool Subtract_FrameNumberInteger_IsValid;

	private static IntPtr Subtract_FrameNumberInteger_FunctionAddress;

	private static int Subtract_FrameNumberInteger_ParamsSize;

	private static bool Subtract_FrameNumberInteger_A_IsValid;

	private static FFieldAddress Subtract_FrameNumberInteger_A_PropertyAddress;

	private static int Subtract_FrameNumberInteger_A_Offset;

	private static bool Subtract_FrameNumberInteger_B_IsValid;

	private static FFieldAddress Subtract_FrameNumberInteger_B_PropertyAddress;

	private static int Subtract_FrameNumberInteger_B_Offset;

	private static bool Subtract_FrameNumberInteger_ReturnValue_IsValid;

	private static FFieldAddress Subtract_FrameNumberInteger_ReturnValue_PropertyAddress;

	private static int Subtract_FrameNumberInteger_ReturnValue_Offset;

	private static bool Subtract_FrameNumberFrameNumber_IsValid;

	private static IntPtr Subtract_FrameNumberFrameNumber_FunctionAddress;

	private static int Subtract_FrameNumberFrameNumber_ParamsSize;

	private static bool Subtract_FrameNumberFrameNumber_A_IsValid;

	private static FFieldAddress Subtract_FrameNumberFrameNumber_A_PropertyAddress;

	private static int Subtract_FrameNumberFrameNumber_A_Offset;

	private static bool Subtract_FrameNumberFrameNumber_B_IsValid;

	private static FFieldAddress Subtract_FrameNumberFrameNumber_B_PropertyAddress;

	private static int Subtract_FrameNumberFrameNumber_B_Offset;

	private static bool Subtract_FrameNumberFrameNumber_ReturnValue_IsValid;

	private static FFieldAddress Subtract_FrameNumberFrameNumber_ReturnValue_PropertyAddress;

	private static int Subtract_FrameNumberFrameNumber_ReturnValue_Offset;

	private static bool SnapFrameTimeToRate_IsValid;

	private static IntPtr SnapFrameTimeToRate_FunctionAddress;

	private static int SnapFrameTimeToRate_ParamsSize;

	private static bool SnapFrameTimeToRate_SourceTime_IsValid;

	private static FFieldAddress SnapFrameTimeToRate_SourceTime_PropertyAddress;

	private static int SnapFrameTimeToRate_SourceTime_Offset;

	private static bool SnapFrameTimeToRate_SourceRate_IsValid;

	private static FFieldAddress SnapFrameTimeToRate_SourceRate_PropertyAddress;

	private static int SnapFrameTimeToRate_SourceRate_Offset;

	private static bool SnapFrameTimeToRate_SnapToRate_IsValid;

	private static FFieldAddress SnapFrameTimeToRate_SnapToRate_PropertyAddress;

	private static int SnapFrameTimeToRate_SnapToRate_Offset;

	private static bool SnapFrameTimeToRate_ReturnValue_IsValid;

	private static FFieldAddress SnapFrameTimeToRate_ReturnValue_PropertyAddress;

	private static int SnapFrameTimeToRate_ReturnValue_Offset;

	private static bool Multiply_SecondsFrameRate_IsValid;

	private static IntPtr Multiply_SecondsFrameRate_FunctionAddress;

	private static int Multiply_SecondsFrameRate_ParamsSize;

	private static bool Multiply_SecondsFrameRate_TimeInSeconds_IsValid;

	private static FFieldAddress Multiply_SecondsFrameRate_TimeInSeconds_PropertyAddress;

	private static int Multiply_SecondsFrameRate_TimeInSeconds_Offset;

	private static bool Multiply_SecondsFrameRate_FrameRate_IsValid;

	private static FFieldAddress Multiply_SecondsFrameRate_FrameRate_PropertyAddress;

	private static int Multiply_SecondsFrameRate_FrameRate_Offset;

	private static bool Multiply_SecondsFrameRate_ReturnValue_IsValid;

	private static FFieldAddress Multiply_SecondsFrameRate_ReturnValue_PropertyAddress;

	private static int Multiply_SecondsFrameRate_ReturnValue_Offset;

	private static bool Multiply_FrameNumberInteger_IsValid;

	private static IntPtr Multiply_FrameNumberInteger_FunctionAddress;

	private static int Multiply_FrameNumberInteger_ParamsSize;

	private static bool Multiply_FrameNumberInteger_A_IsValid;

	private static FFieldAddress Multiply_FrameNumberInteger_A_PropertyAddress;

	private static int Multiply_FrameNumberInteger_A_Offset;

	private static bool Multiply_FrameNumberInteger_B_IsValid;

	private static FFieldAddress Multiply_FrameNumberInteger_B_PropertyAddress;

	private static int Multiply_FrameNumberInteger_B_Offset;

	private static bool Multiply_FrameNumberInteger_ReturnValue_IsValid;

	private static FFieldAddress Multiply_FrameNumberInteger_ReturnValue_PropertyAddress;

	private static int Multiply_FrameNumberInteger_ReturnValue_Offset;

	private static bool IsValid_MultipleOf_IsValid;

	private static IntPtr IsValid_MultipleOf_FunctionAddress;

	private static int IsValid_MultipleOf_ParamsSize;

	private static bool IsValid_MultipleOf_InFrameRate_IsValid;

	private static FFieldAddress IsValid_MultipleOf_InFrameRate_PropertyAddress;

	private static int IsValid_MultipleOf_InFrameRate_Offset;

	private static bool IsValid_MultipleOf_OtherFramerate_IsValid;

	private static FFieldAddress IsValid_MultipleOf_OtherFramerate_PropertyAddress;

	private static int IsValid_MultipleOf_OtherFramerate_Offset;

	private static bool IsValid_MultipleOf_ReturnValue_IsValid;

	private static FFieldAddress IsValid_MultipleOf_ReturnValue_PropertyAddress;

	private static int IsValid_MultipleOf_ReturnValue_Offset;

	private static bool IsValid_Framerate_IsValid;

	private static IntPtr IsValid_Framerate_FunctionAddress;

	private static int IsValid_Framerate_ParamsSize;

	private static bool IsValid_Framerate_InFrameRate_IsValid;

	private static FFieldAddress IsValid_Framerate_InFrameRate_PropertyAddress;

	private static int IsValid_Framerate_InFrameRate_Offset;

	private static bool IsValid_Framerate_ReturnValue_IsValid;

	private static FFieldAddress IsValid_Framerate_ReturnValue_PropertyAddress;

	private static int IsValid_Framerate_ReturnValue_Offset;

	private static bool GetTimecodeFrameRate_IsValid;

	private static IntPtr GetTimecodeFrameRate_FunctionAddress;

	private static int GetTimecodeFrameRate_ParamsSize;

	private static bool GetTimecodeFrameRate_ReturnValue_IsValid;

	private static FFieldAddress GetTimecodeFrameRate_ReturnValue_PropertyAddress;

	private static int GetTimecodeFrameRate_ReturnValue_Offset;

	private static bool GetTimecode_IsValid;

	private static IntPtr GetTimecode_FunctionAddress;

	private static int GetTimecode_ParamsSize;

	private static bool GetTimecode_ReturnValue_IsValid;

	private static FFieldAddress GetTimecode_ReturnValue_PropertyAddress;

	private static int GetTimecode_ReturnValue_Offset;

	private static bool Divide_FrameNumberInteger_IsValid;

	private static IntPtr Divide_FrameNumberInteger_FunctionAddress;

	private static int Divide_FrameNumberInteger_ParamsSize;

	private static bool Divide_FrameNumberInteger_A_IsValid;

	private static FFieldAddress Divide_FrameNumberInteger_A_PropertyAddress;

	private static int Divide_FrameNumberInteger_A_Offset;

	private static bool Divide_FrameNumberInteger_B_IsValid;

	private static FFieldAddress Divide_FrameNumberInteger_B_PropertyAddress;

	private static int Divide_FrameNumberInteger_B_Offset;

	private static bool Divide_FrameNumberInteger_ReturnValue_IsValid;

	private static FFieldAddress Divide_FrameNumberInteger_ReturnValue_PropertyAddress;

	private static int Divide_FrameNumberInteger_ReturnValue_Offset;

	private static bool Conv_TimecodeToString_IsValid;

	private static IntPtr Conv_TimecodeToString_FunctionAddress;

	private static int Conv_TimecodeToString_ParamsSize;

	private static bool Conv_TimecodeToString_InTimecode_IsValid;

	private static FFieldAddress Conv_TimecodeToString_InTimecode_PropertyAddress;

	private static int Conv_TimecodeToString_InTimecode_Offset;

	private static bool Conv_TimecodeToString_bForceSignDisplay_IsValid;

	private static FFieldAddress Conv_TimecodeToString_bForceSignDisplay_PropertyAddress;

	private static int Conv_TimecodeToString_bForceSignDisplay_Offset;

	private static bool Conv_TimecodeToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_TimecodeToString_ReturnValue_PropertyAddress;

	private static int Conv_TimecodeToString_ReturnValue_Offset;

	private static bool Conv_QualifiedFrameTimeToSeconds_IsValid;

	private static IntPtr Conv_QualifiedFrameTimeToSeconds_FunctionAddress;

	private static int Conv_QualifiedFrameTimeToSeconds_ParamsSize;

	private static bool Conv_QualifiedFrameTimeToSeconds_InFrameTime_IsValid;

	private static FFieldAddress Conv_QualifiedFrameTimeToSeconds_InFrameTime_PropertyAddress;

	private static int Conv_QualifiedFrameTimeToSeconds_InFrameTime_Offset;

	private static bool Conv_QualifiedFrameTimeToSeconds_ReturnValue_IsValid;

	private static FFieldAddress Conv_QualifiedFrameTimeToSeconds_ReturnValue_PropertyAddress;

	private static int Conv_QualifiedFrameTimeToSeconds_ReturnValue_Offset;

	private static bool Conv_FrameRateToSeconds_IsValid;

	private static IntPtr Conv_FrameRateToSeconds_FunctionAddress;

	private static int Conv_FrameRateToSeconds_ParamsSize;

	private static bool Conv_FrameRateToSeconds_InFrameRate_IsValid;

	private static FFieldAddress Conv_FrameRateToSeconds_InFrameRate_PropertyAddress;

	private static int Conv_FrameRateToSeconds_InFrameRate_Offset;

	private static bool Conv_FrameRateToSeconds_ReturnValue_IsValid;

	private static FFieldAddress Conv_FrameRateToSeconds_ReturnValue_PropertyAddress;

	private static int Conv_FrameRateToSeconds_ReturnValue_Offset;

	private static bool FrameNumberToInteger_IsValid;

	private static IntPtr FrameNumberToInteger_FunctionAddress;

	private static int FrameNumberToInteger_ParamsSize;

	private static bool FrameNumberToInteger_InFrameNumber_IsValid;

	private static FFieldAddress FrameNumberToInteger_InFrameNumber_PropertyAddress;

	private static int FrameNumberToInteger_InFrameNumber_Offset;

	private static bool FrameNumberToInteger_ReturnValue_IsValid;

	private static FFieldAddress FrameNumberToInteger_ReturnValue_PropertyAddress;

	private static int FrameNumberToInteger_ReturnValue_Offset;

	private static bool Add_FrameNumberInteger_IsValid;

	private static IntPtr Add_FrameNumberInteger_FunctionAddress;

	private static int Add_FrameNumberInteger_ParamsSize;

	private static bool Add_FrameNumberInteger_A_IsValid;

	private static FFieldAddress Add_FrameNumberInteger_A_PropertyAddress;

	private static int Add_FrameNumberInteger_A_Offset;

	private static bool Add_FrameNumberInteger_B_IsValid;

	private static FFieldAddress Add_FrameNumberInteger_B_PropertyAddress;

	private static int Add_FrameNumberInteger_B_Offset;

	private static bool Add_FrameNumberInteger_ReturnValue_IsValid;

	private static FFieldAddress Add_FrameNumberInteger_ReturnValue_PropertyAddress;

	private static int Add_FrameNumberInteger_ReturnValue_Offset;

	private static bool Add_FrameNumberFrameNumber_IsValid;

	private static IntPtr Add_FrameNumberFrameNumber_FunctionAddress;

	private static int Add_FrameNumberFrameNumber_ParamsSize;

	private static bool Add_FrameNumberFrameNumber_A_IsValid;

	private static FFieldAddress Add_FrameNumberFrameNumber_A_PropertyAddress;

	private static int Add_FrameNumberFrameNumber_A_Offset;

	private static bool Add_FrameNumberFrameNumber_B_IsValid;

	private static FFieldAddress Add_FrameNumberFrameNumber_B_PropertyAddress;

	private static int Add_FrameNumberFrameNumber_B_Offset;

	private static bool Add_FrameNumberFrameNumber_ReturnValue_IsValid;

	private static FFieldAddress Add_FrameNumberFrameNumber_ReturnValue_PropertyAddress;

	private static int Add_FrameNumberFrameNumber_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:TransformTime")]
	public unsafe static FFrameTime TransformTime(FFrameTime SourceTime, FFrameRate SourceRate, FFrameRate DestinationRate)
	{
		if (!TransformTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:TransformTime");
			return default(FFrameTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransformTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransformTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TransformTime_SourceTime_PropertyAddress.Address, intPtr);
		FFrameTime.ToNative(IntPtr.Add(intPtr, TransformTime_SourceTime_Offset), 0, TransformTime_SourceTime_PropertyAddress.Address, SourceTime);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, TransformTime_SourceRate_Offset), 0, TransformTime_SourceRate_PropertyAddress.Address, SourceRate);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, TransformTime_DestinationRate_Offset), 0, TransformTime_DestinationRate_PropertyAddress.Address, DestinationRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TransformTime_FunctionAddress, intPtr, TransformTime_ParamsSize);
		return FFrameTime.FromNative(IntPtr.Add(intPtr, TransformTime_ReturnValue_Offset), 0, TransformTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Subtract_FrameNumberInteger")]
	public unsafe static FFrameNumber Subtract_FrameNumberInteger(FFrameNumber A, int B)
	{
		if (!Subtract_FrameNumberInteger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Subtract_FrameNumberInteger");
			return default(FFrameNumber);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Subtract_FrameNumberInteger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Subtract_FrameNumberInteger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Subtract_FrameNumberInteger_A_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, Subtract_FrameNumberInteger_A_Offset), 0, Subtract_FrameNumberInteger_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Subtract_FrameNumberInteger_B_Offset), 0, Subtract_FrameNumberInteger_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Subtract_FrameNumberInteger_FunctionAddress, intPtr, Subtract_FrameNumberInteger_ParamsSize);
		return FFrameNumber.FromNative(IntPtr.Add(intPtr, Subtract_FrameNumberInteger_ReturnValue_Offset), 0, Subtract_FrameNumberInteger_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Subtract_FrameNumberFrameNumber")]
	public unsafe static FFrameNumber Subtract_FrameNumberFrameNumber(FFrameNumber A, FFrameNumber B)
	{
		if (!Subtract_FrameNumberFrameNumber_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Subtract_FrameNumberFrameNumber");
			return default(FFrameNumber);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Subtract_FrameNumberFrameNumber_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Subtract_FrameNumberFrameNumber_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Subtract_FrameNumberFrameNumber_A_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, Subtract_FrameNumberFrameNumber_A_Offset), 0, Subtract_FrameNumberFrameNumber_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(Subtract_FrameNumberFrameNumber_B_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, Subtract_FrameNumberFrameNumber_B_Offset), 0, Subtract_FrameNumberFrameNumber_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Subtract_FrameNumberFrameNumber_FunctionAddress, intPtr, Subtract_FrameNumberFrameNumber_ParamsSize);
		return FFrameNumber.FromNative(IntPtr.Add(intPtr, Subtract_FrameNumberFrameNumber_ReturnValue_Offset), 0, Subtract_FrameNumberFrameNumber_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:SnapFrameTimeToRate")]
	public unsafe static FFrameTime SnapFrameTimeToRate(FFrameTime SourceTime, FFrameRate SourceRate, FFrameRate SnapToRate)
	{
		if (!SnapFrameTimeToRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:SnapFrameTimeToRate");
			return default(FFrameTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SnapFrameTimeToRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SnapFrameTimeToRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SnapFrameTimeToRate_SourceTime_PropertyAddress.Address, intPtr);
		FFrameTime.ToNative(IntPtr.Add(intPtr, SnapFrameTimeToRate_SourceTime_Offset), 0, SnapFrameTimeToRate_SourceTime_PropertyAddress.Address, SourceTime);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, SnapFrameTimeToRate_SourceRate_Offset), 0, SnapFrameTimeToRate_SourceRate_PropertyAddress.Address, SourceRate);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, SnapFrameTimeToRate_SnapToRate_Offset), 0, SnapFrameTimeToRate_SnapToRate_PropertyAddress.Address, SnapToRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SnapFrameTimeToRate_FunctionAddress, intPtr, SnapFrameTimeToRate_ParamsSize);
		return FFrameTime.FromNative(IntPtr.Add(intPtr, SnapFrameTimeToRate_ReturnValue_Offset), 0, SnapFrameTimeToRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Multiply_SecondsFrameRate")]
	public unsafe static FFrameTime Multiply_SecondsFrameRate(float TimeInSeconds, FFrameRate FrameRate)
	{
		if (!Multiply_SecondsFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Multiply_SecondsFrameRate");
			return default(FFrameTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Multiply_SecondsFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Multiply_SecondsFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Multiply_SecondsFrameRate_TimeInSeconds_Offset), 0, Multiply_SecondsFrameRate_TimeInSeconds_PropertyAddress.Address, TimeInSeconds);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, Multiply_SecondsFrameRate_FrameRate_Offset), 0, Multiply_SecondsFrameRate_FrameRate_PropertyAddress.Address, FrameRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Multiply_SecondsFrameRate_FunctionAddress, intPtr, Multiply_SecondsFrameRate_ParamsSize);
		return FFrameTime.FromNative(IntPtr.Add(intPtr, Multiply_SecondsFrameRate_ReturnValue_Offset), 0, Multiply_SecondsFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Multiply_FrameNumberInteger")]
	public unsafe static FFrameNumber Multiply_FrameNumberInteger(FFrameNumber A, int B)
	{
		if (!Multiply_FrameNumberInteger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Multiply_FrameNumberInteger");
			return default(FFrameNumber);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Multiply_FrameNumberInteger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Multiply_FrameNumberInteger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Multiply_FrameNumberInteger_A_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, Multiply_FrameNumberInteger_A_Offset), 0, Multiply_FrameNumberInteger_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Multiply_FrameNumberInteger_B_Offset), 0, Multiply_FrameNumberInteger_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Multiply_FrameNumberInteger_FunctionAddress, intPtr, Multiply_FrameNumberInteger_ParamsSize);
		return FFrameNumber.FromNative(IntPtr.Add(intPtr, Multiply_FrameNumberInteger_ReturnValue_Offset), 0, Multiply_FrameNumberInteger_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:IsValid_MultipleOf")]
	public unsafe static bool IsValid_MultipleOf(FFrameRate InFrameRate, FFrameRate OtherFramerate)
	{
		if (!IsValid_MultipleOf_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:IsValid_MultipleOf");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_MultipleOf_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_MultipleOf_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, IsValid_MultipleOf_InFrameRate_Offset), 0, IsValid_MultipleOf_InFrameRate_PropertyAddress.Address, InFrameRate);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, IsValid_MultipleOf_OtherFramerate_Offset), 0, IsValid_MultipleOf_OtherFramerate_PropertyAddress.Address, OtherFramerate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_MultipleOf_FunctionAddress, intPtr, IsValid_MultipleOf_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_MultipleOf_ReturnValue_Offset), 0, IsValid_MultipleOf_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:IsValid_Framerate")]
	public unsafe static bool IsValid_Framerate(FFrameRate InFrameRate)
	{
		if (!IsValid_Framerate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:IsValid_Framerate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_Framerate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_Framerate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, IsValid_Framerate_InFrameRate_Offset), 0, IsValid_Framerate_InFrameRate_PropertyAddress.Address, InFrameRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_Framerate_FunctionAddress, intPtr, IsValid_Framerate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_Framerate_ReturnValue_Offset), 0, IsValid_Framerate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:GetTimecodeFrameRate")]
	public unsafe static FFrameRate GetTimecodeFrameRate()
	{
		if (!GetTimecodeFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:GetTimecodeFrameRate");
			return default(FFrameRate);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimecodeFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimecodeFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTimecodeFrameRate_FunctionAddress, intPtr, GetTimecodeFrameRate_ParamsSize);
		return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(intPtr, GetTimecodeFrameRate_ReturnValue_Offset), 0, GetTimecodeFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:GetTimecode")]
	public unsafe static FTimecode GetTimecode()
	{
		if (!GetTimecode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:GetTimecode");
			return default(FTimecode);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimecode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimecode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTimecode_FunctionAddress, intPtr, GetTimecode_ParamsSize);
		return FTimecode.FromNative(IntPtr.Add(intPtr, GetTimecode_ReturnValue_Offset), 0, GetTimecode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Divide_FrameNumberInteger")]
	public unsafe static FFrameNumber Divide_FrameNumberInteger(FFrameNumber A, int B)
	{
		if (!Divide_FrameNumberInteger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Divide_FrameNumberInteger");
			return default(FFrameNumber);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Divide_FrameNumberInteger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Divide_FrameNumberInteger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Divide_FrameNumberInteger_A_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, Divide_FrameNumberInteger_A_Offset), 0, Divide_FrameNumberInteger_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Divide_FrameNumberInteger_B_Offset), 0, Divide_FrameNumberInteger_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Divide_FrameNumberInteger_FunctionAddress, intPtr, Divide_FrameNumberInteger_ParamsSize);
		return FFrameNumber.FromNative(IntPtr.Add(intPtr, Divide_FrameNumberInteger_ReturnValue_Offset), 0, Divide_FrameNumberInteger_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_TimecodeToString")]
	public unsafe static string Conv_TimecodeToString(FTimecode InTimecode, bool bForceSignDisplay = false)
	{
		if (!Conv_TimecodeToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_TimecodeToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_TimecodeToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_TimecodeToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FTimecode.ToNative(IntPtr.Add(intPtr, Conv_TimecodeToString_InTimecode_Offset), 0, Conv_TimecodeToString_InTimecode_PropertyAddress.Address, InTimecode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Conv_TimecodeToString_bForceSignDisplay_Offset), 0, Conv_TimecodeToString_bForceSignDisplay_PropertyAddress.Address, bForceSignDisplay);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_TimecodeToString_FunctionAddress, intPtr, Conv_TimecodeToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_TimecodeToString_ReturnValue_Offset), 0, Conv_TimecodeToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_TimecodeToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_QualifiedFrameTimeToSeconds")]
	public unsafe static float Conv_QualifiedFrameTimeToSeconds(FQualifiedTime InFrameTime)
	{
		if (!Conv_QualifiedFrameTimeToSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_QualifiedFrameTimeToSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_QualifiedFrameTimeToSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_QualifiedFrameTimeToSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_QualifiedFrameTimeToSeconds_InFrameTime_PropertyAddress.Address, intPtr);
		FQualifiedTime.ToNative(IntPtr.Add(intPtr, Conv_QualifiedFrameTimeToSeconds_InFrameTime_Offset), 0, Conv_QualifiedFrameTimeToSeconds_InFrameTime_PropertyAddress.Address, InFrameTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_QualifiedFrameTimeToSeconds_FunctionAddress, intPtr, Conv_QualifiedFrameTimeToSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, Conv_QualifiedFrameTimeToSeconds_ReturnValue_Offset), 0, Conv_QualifiedFrameTimeToSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_FrameRateToSeconds")]
	public unsafe static float Conv_FrameRateToSeconds(FFrameRate InFrameRate)
	{
		if (!Conv_FrameRateToSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_FrameRateToSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FrameRateToSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FrameRateToSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, Conv_FrameRateToSeconds_InFrameRate_Offset), 0, Conv_FrameRateToSeconds_InFrameRate_PropertyAddress.Address, InFrameRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FrameRateToSeconds_FunctionAddress, intPtr, Conv_FrameRateToSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, Conv_FrameRateToSeconds_ReturnValue_Offset), 0, Conv_FrameRateToSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u, OriginalName = "Conv_FrameNumberToInteger")]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_FrameNumberToInteger")]
	public unsafe static int FrameNumberToInteger(FFrameNumber InFrameNumber)
	{
		if (!FrameNumberToInteger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_FrameNumberToInteger");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FrameNumberToInteger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FrameNumberToInteger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FrameNumberToInteger_InFrameNumber_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, FrameNumberToInteger_InFrameNumber_Offset), 0, FrameNumberToInteger_InFrameNumber_PropertyAddress.Address, InFrameNumber);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FrameNumberToInteger_FunctionAddress, intPtr, FrameNumberToInteger_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FrameNumberToInteger_ReturnValue_Offset), 0, FrameNumberToInteger_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Add_FrameNumberInteger")]
	public unsafe static FFrameNumber Add_FrameNumberInteger(FFrameNumber A, int B)
	{
		if (!Add_FrameNumberInteger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Add_FrameNumberInteger");
			return default(FFrameNumber);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Add_FrameNumberInteger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Add_FrameNumberInteger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Add_FrameNumberInteger_A_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, Add_FrameNumberInteger_A_Offset), 0, Add_FrameNumberInteger_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Add_FrameNumberInteger_B_Offset), 0, Add_FrameNumberInteger_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Add_FrameNumberInteger_FunctionAddress, intPtr, Add_FrameNumberInteger_ParamsSize);
		return FFrameNumber.FromNative(IntPtr.Add(intPtr, Add_FrameNumberInteger_ReturnValue_Offset), 0, Add_FrameNumberInteger_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/TimeManagement.TimeManagementBlueprintLibrary:Add_FrameNumberFrameNumber")]
	public unsafe static FFrameNumber Add_FrameNumberFrameNumber(FFrameNumber A, FFrameNumber B)
	{
		if (!Add_FrameNumberFrameNumber_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TimeManagement.TimeManagementBlueprintLibrary:Add_FrameNumberFrameNumber");
			return default(FFrameNumber);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Add_FrameNumberFrameNumber_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Add_FrameNumberFrameNumber_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Add_FrameNumberFrameNumber_A_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, Add_FrameNumberFrameNumber_A_Offset), 0, Add_FrameNumberFrameNumber_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(Add_FrameNumberFrameNumber_B_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, Add_FrameNumberFrameNumber_B_Offset), 0, Add_FrameNumberFrameNumber_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Add_FrameNumberFrameNumber_FunctionAddress, intPtr, Add_FrameNumberFrameNumber_ParamsSize);
		return FFrameNumber.FromNative(IntPtr.Add(intPtr, Add_FrameNumberFrameNumber_ReturnValue_Offset), 0, Add_FrameNumberFrameNumber_ReturnValue_PropertyAddress.Address);
	}

	static UTimeManagementLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTimeManagementLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTimeManagementLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/TimeManagement.TimeManagementBlueprintLibrary");
		TransformTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TransformTime");
		TransformTime_ParamsSize = NativeReflection.GetFunctionParamsSize(TransformTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransformTime_SourceTime_PropertyAddress, TransformTime_FunctionAddress, "SourceTime");
		TransformTime_SourceTime_Offset = NativeReflectionCached.GetPropertyOffset(TransformTime_FunctionAddress, "SourceTime");
		TransformTime_SourceTime_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformTime_FunctionAddress, "SourceTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformTime_SourceRate_PropertyAddress, TransformTime_FunctionAddress, "SourceRate");
		TransformTime_SourceRate_Offset = NativeReflectionCached.GetPropertyOffset(TransformTime_FunctionAddress, "SourceRate");
		TransformTime_SourceRate_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformTime_FunctionAddress, "SourceRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformTime_DestinationRate_PropertyAddress, TransformTime_FunctionAddress, "DestinationRate");
		TransformTime_DestinationRate_Offset = NativeReflectionCached.GetPropertyOffset(TransformTime_FunctionAddress, "DestinationRate");
		TransformTime_DestinationRate_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformTime_FunctionAddress, "DestinationRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformTime_ReturnValue_PropertyAddress, TransformTime_FunctionAddress, "ReturnValue");
		TransformTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TransformTime_FunctionAddress, "ReturnValue");
		TransformTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		TransformTime_IsValid = TransformTime_FunctionAddress != IntPtr.Zero && TransformTime_SourceTime_IsValid && TransformTime_SourceRate_IsValid && TransformTime_DestinationRate_IsValid && TransformTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:TransformTime", TransformTime_IsValid);
		Subtract_FrameNumberInteger_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Subtract_FrameNumberInteger");
		Subtract_FrameNumberInteger_ParamsSize = NativeReflection.GetFunctionParamsSize(Subtract_FrameNumberInteger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Subtract_FrameNumberInteger_A_PropertyAddress, Subtract_FrameNumberInteger_FunctionAddress, "A");
		Subtract_FrameNumberInteger_A_Offset = NativeReflectionCached.GetPropertyOffset(Subtract_FrameNumberInteger_FunctionAddress, "A");
		Subtract_FrameNumberInteger_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Subtract_FrameNumberInteger_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Subtract_FrameNumberInteger_B_PropertyAddress, Subtract_FrameNumberInteger_FunctionAddress, "B");
		Subtract_FrameNumberInteger_B_Offset = NativeReflectionCached.GetPropertyOffset(Subtract_FrameNumberInteger_FunctionAddress, "B");
		Subtract_FrameNumberInteger_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Subtract_FrameNumberInteger_FunctionAddress, "B", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Subtract_FrameNumberInteger_ReturnValue_PropertyAddress, Subtract_FrameNumberInteger_FunctionAddress, "ReturnValue");
		Subtract_FrameNumberInteger_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Subtract_FrameNumberInteger_FunctionAddress, "ReturnValue");
		Subtract_FrameNumberInteger_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Subtract_FrameNumberInteger_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Subtract_FrameNumberInteger_IsValid = Subtract_FrameNumberInteger_FunctionAddress != IntPtr.Zero && Subtract_FrameNumberInteger_A_IsValid && Subtract_FrameNumberInteger_B_IsValid && Subtract_FrameNumberInteger_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Subtract_FrameNumberInteger", Subtract_FrameNumberInteger_IsValid);
		Subtract_FrameNumberFrameNumber_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Subtract_FrameNumberFrameNumber");
		Subtract_FrameNumberFrameNumber_ParamsSize = NativeReflection.GetFunctionParamsSize(Subtract_FrameNumberFrameNumber_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Subtract_FrameNumberFrameNumber_A_PropertyAddress, Subtract_FrameNumberFrameNumber_FunctionAddress, "A");
		Subtract_FrameNumberFrameNumber_A_Offset = NativeReflectionCached.GetPropertyOffset(Subtract_FrameNumberFrameNumber_FunctionAddress, "A");
		Subtract_FrameNumberFrameNumber_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Subtract_FrameNumberFrameNumber_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Subtract_FrameNumberFrameNumber_B_PropertyAddress, Subtract_FrameNumberFrameNumber_FunctionAddress, "B");
		Subtract_FrameNumberFrameNumber_B_Offset = NativeReflectionCached.GetPropertyOffset(Subtract_FrameNumberFrameNumber_FunctionAddress, "B");
		Subtract_FrameNumberFrameNumber_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Subtract_FrameNumberFrameNumber_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Subtract_FrameNumberFrameNumber_ReturnValue_PropertyAddress, Subtract_FrameNumberFrameNumber_FunctionAddress, "ReturnValue");
		Subtract_FrameNumberFrameNumber_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Subtract_FrameNumberFrameNumber_FunctionAddress, "ReturnValue");
		Subtract_FrameNumberFrameNumber_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Subtract_FrameNumberFrameNumber_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Subtract_FrameNumberFrameNumber_IsValid = Subtract_FrameNumberFrameNumber_FunctionAddress != IntPtr.Zero && Subtract_FrameNumberFrameNumber_A_IsValid && Subtract_FrameNumberFrameNumber_B_IsValid && Subtract_FrameNumberFrameNumber_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Subtract_FrameNumberFrameNumber", Subtract_FrameNumberFrameNumber_IsValid);
		SnapFrameTimeToRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SnapFrameTimeToRate");
		SnapFrameTimeToRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SnapFrameTimeToRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SnapFrameTimeToRate_SourceTime_PropertyAddress, SnapFrameTimeToRate_FunctionAddress, "SourceTime");
		SnapFrameTimeToRate_SourceTime_Offset = NativeReflectionCached.GetPropertyOffset(SnapFrameTimeToRate_FunctionAddress, "SourceTime");
		SnapFrameTimeToRate_SourceTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SnapFrameTimeToRate_FunctionAddress, "SourceTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SnapFrameTimeToRate_SourceRate_PropertyAddress, SnapFrameTimeToRate_FunctionAddress, "SourceRate");
		SnapFrameTimeToRate_SourceRate_Offset = NativeReflectionCached.GetPropertyOffset(SnapFrameTimeToRate_FunctionAddress, "SourceRate");
		SnapFrameTimeToRate_SourceRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SnapFrameTimeToRate_FunctionAddress, "SourceRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SnapFrameTimeToRate_SnapToRate_PropertyAddress, SnapFrameTimeToRate_FunctionAddress, "SnapToRate");
		SnapFrameTimeToRate_SnapToRate_Offset = NativeReflectionCached.GetPropertyOffset(SnapFrameTimeToRate_FunctionAddress, "SnapToRate");
		SnapFrameTimeToRate_SnapToRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SnapFrameTimeToRate_FunctionAddress, "SnapToRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SnapFrameTimeToRate_ReturnValue_PropertyAddress, SnapFrameTimeToRate_FunctionAddress, "ReturnValue");
		SnapFrameTimeToRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SnapFrameTimeToRate_FunctionAddress, "ReturnValue");
		SnapFrameTimeToRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SnapFrameTimeToRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SnapFrameTimeToRate_IsValid = SnapFrameTimeToRate_FunctionAddress != IntPtr.Zero && SnapFrameTimeToRate_SourceTime_IsValid && SnapFrameTimeToRate_SourceRate_IsValid && SnapFrameTimeToRate_SnapToRate_IsValid && SnapFrameTimeToRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:SnapFrameTimeToRate", SnapFrameTimeToRate_IsValid);
		Multiply_SecondsFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Multiply_SecondsFrameRate");
		Multiply_SecondsFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(Multiply_SecondsFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Multiply_SecondsFrameRate_TimeInSeconds_PropertyAddress, Multiply_SecondsFrameRate_FunctionAddress, "TimeInSeconds");
		Multiply_SecondsFrameRate_TimeInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(Multiply_SecondsFrameRate_FunctionAddress, "TimeInSeconds");
		Multiply_SecondsFrameRate_TimeInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(Multiply_SecondsFrameRate_FunctionAddress, "TimeInSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Multiply_SecondsFrameRate_FrameRate_PropertyAddress, Multiply_SecondsFrameRate_FunctionAddress, "FrameRate");
		Multiply_SecondsFrameRate_FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(Multiply_SecondsFrameRate_FunctionAddress, "FrameRate");
		Multiply_SecondsFrameRate_FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(Multiply_SecondsFrameRate_FunctionAddress, "FrameRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Multiply_SecondsFrameRate_ReturnValue_PropertyAddress, Multiply_SecondsFrameRate_FunctionAddress, "ReturnValue");
		Multiply_SecondsFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Multiply_SecondsFrameRate_FunctionAddress, "ReturnValue");
		Multiply_SecondsFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Multiply_SecondsFrameRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Multiply_SecondsFrameRate_IsValid = Multiply_SecondsFrameRate_FunctionAddress != IntPtr.Zero && Multiply_SecondsFrameRate_TimeInSeconds_IsValid && Multiply_SecondsFrameRate_FrameRate_IsValid && Multiply_SecondsFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Multiply_SecondsFrameRate", Multiply_SecondsFrameRate_IsValid);
		Multiply_FrameNumberInteger_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Multiply_FrameNumberInteger");
		Multiply_FrameNumberInteger_ParamsSize = NativeReflection.GetFunctionParamsSize(Multiply_FrameNumberInteger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Multiply_FrameNumberInteger_A_PropertyAddress, Multiply_FrameNumberInteger_FunctionAddress, "A");
		Multiply_FrameNumberInteger_A_Offset = NativeReflectionCached.GetPropertyOffset(Multiply_FrameNumberInteger_FunctionAddress, "A");
		Multiply_FrameNumberInteger_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Multiply_FrameNumberInteger_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Multiply_FrameNumberInteger_B_PropertyAddress, Multiply_FrameNumberInteger_FunctionAddress, "B");
		Multiply_FrameNumberInteger_B_Offset = NativeReflectionCached.GetPropertyOffset(Multiply_FrameNumberInteger_FunctionAddress, "B");
		Multiply_FrameNumberInteger_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Multiply_FrameNumberInteger_FunctionAddress, "B", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Multiply_FrameNumberInteger_ReturnValue_PropertyAddress, Multiply_FrameNumberInteger_FunctionAddress, "ReturnValue");
		Multiply_FrameNumberInteger_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Multiply_FrameNumberInteger_FunctionAddress, "ReturnValue");
		Multiply_FrameNumberInteger_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Multiply_FrameNumberInteger_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Multiply_FrameNumberInteger_IsValid = Multiply_FrameNumberInteger_FunctionAddress != IntPtr.Zero && Multiply_FrameNumberInteger_A_IsValid && Multiply_FrameNumberInteger_B_IsValid && Multiply_FrameNumberInteger_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Multiply_FrameNumberInteger", Multiply_FrameNumberInteger_IsValid);
		IsValid_MultipleOf_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid_MultipleOf");
		IsValid_MultipleOf_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_MultipleOf_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_MultipleOf_InFrameRate_PropertyAddress, IsValid_MultipleOf_FunctionAddress, "InFrameRate");
		IsValid_MultipleOf_InFrameRate_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_MultipleOf_FunctionAddress, "InFrameRate");
		IsValid_MultipleOf_InFrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_MultipleOf_FunctionAddress, "InFrameRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_MultipleOf_OtherFramerate_PropertyAddress, IsValid_MultipleOf_FunctionAddress, "OtherFramerate");
		IsValid_MultipleOf_OtherFramerate_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_MultipleOf_FunctionAddress, "OtherFramerate");
		IsValid_MultipleOf_OtherFramerate_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_MultipleOf_FunctionAddress, "OtherFramerate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_MultipleOf_ReturnValue_PropertyAddress, IsValid_MultipleOf_FunctionAddress, "ReturnValue");
		IsValid_MultipleOf_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_MultipleOf_FunctionAddress, "ReturnValue");
		IsValid_MultipleOf_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_MultipleOf_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_MultipleOf_IsValid = IsValid_MultipleOf_FunctionAddress != IntPtr.Zero && IsValid_MultipleOf_InFrameRate_IsValid && IsValid_MultipleOf_OtherFramerate_IsValid && IsValid_MultipleOf_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:IsValid_MultipleOf", IsValid_MultipleOf_IsValid);
		IsValid_Framerate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid_Framerate");
		IsValid_Framerate_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_Framerate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_Framerate_InFrameRate_PropertyAddress, IsValid_Framerate_FunctionAddress, "InFrameRate");
		IsValid_Framerate_InFrameRate_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_Framerate_FunctionAddress, "InFrameRate");
		IsValid_Framerate_InFrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_Framerate_FunctionAddress, "InFrameRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_Framerate_ReturnValue_PropertyAddress, IsValid_Framerate_FunctionAddress, "ReturnValue");
		IsValid_Framerate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_Framerate_FunctionAddress, "ReturnValue");
		IsValid_Framerate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_Framerate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_Framerate_IsValid = IsValid_Framerate_FunctionAddress != IntPtr.Zero && IsValid_Framerate_InFrameRate_IsValid && IsValid_Framerate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:IsValid_Framerate", IsValid_Framerate_IsValid);
		GetTimecodeFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTimecodeFrameRate");
		GetTimecodeFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimecodeFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimecodeFrameRate_ReturnValue_PropertyAddress, GetTimecodeFrameRate_FunctionAddress, "ReturnValue");
		GetTimecodeFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimecodeFrameRate_FunctionAddress, "ReturnValue");
		GetTimecodeFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimecodeFrameRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTimecodeFrameRate_IsValid = GetTimecodeFrameRate_FunctionAddress != IntPtr.Zero && GetTimecodeFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:GetTimecodeFrameRate", GetTimecodeFrameRate_IsValid);
		GetTimecode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTimecode");
		GetTimecode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimecode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimecode_ReturnValue_PropertyAddress, GetTimecode_FunctionAddress, "ReturnValue");
		GetTimecode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimecode_FunctionAddress, "ReturnValue");
		GetTimecode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimecode_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTimecode_IsValid = GetTimecode_FunctionAddress != IntPtr.Zero && GetTimecode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:GetTimecode", GetTimecode_IsValid);
		Divide_FrameNumberInteger_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Divide_FrameNumberInteger");
		Divide_FrameNumberInteger_ParamsSize = NativeReflection.GetFunctionParamsSize(Divide_FrameNumberInteger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Divide_FrameNumberInteger_A_PropertyAddress, Divide_FrameNumberInteger_FunctionAddress, "A");
		Divide_FrameNumberInteger_A_Offset = NativeReflectionCached.GetPropertyOffset(Divide_FrameNumberInteger_FunctionAddress, "A");
		Divide_FrameNumberInteger_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Divide_FrameNumberInteger_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Divide_FrameNumberInteger_B_PropertyAddress, Divide_FrameNumberInteger_FunctionAddress, "B");
		Divide_FrameNumberInteger_B_Offset = NativeReflectionCached.GetPropertyOffset(Divide_FrameNumberInteger_FunctionAddress, "B");
		Divide_FrameNumberInteger_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Divide_FrameNumberInteger_FunctionAddress, "B", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Divide_FrameNumberInteger_ReturnValue_PropertyAddress, Divide_FrameNumberInteger_FunctionAddress, "ReturnValue");
		Divide_FrameNumberInteger_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Divide_FrameNumberInteger_FunctionAddress, "ReturnValue");
		Divide_FrameNumberInteger_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Divide_FrameNumberInteger_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Divide_FrameNumberInteger_IsValid = Divide_FrameNumberInteger_FunctionAddress != IntPtr.Zero && Divide_FrameNumberInteger_A_IsValid && Divide_FrameNumberInteger_B_IsValid && Divide_FrameNumberInteger_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Divide_FrameNumberInteger", Divide_FrameNumberInteger_IsValid);
		Conv_TimecodeToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_TimecodeToString");
		Conv_TimecodeToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_TimecodeToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_TimecodeToString_InTimecode_PropertyAddress, Conv_TimecodeToString_FunctionAddress, "InTimecode");
		Conv_TimecodeToString_InTimecode_Offset = NativeReflectionCached.GetPropertyOffset(Conv_TimecodeToString_FunctionAddress, "InTimecode");
		Conv_TimecodeToString_InTimecode_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_TimecodeToString_FunctionAddress, "InTimecode", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_TimecodeToString_bForceSignDisplay_PropertyAddress, Conv_TimecodeToString_FunctionAddress, "bForceSignDisplay");
		Conv_TimecodeToString_bForceSignDisplay_Offset = NativeReflectionCached.GetPropertyOffset(Conv_TimecodeToString_FunctionAddress, "bForceSignDisplay");
		Conv_TimecodeToString_bForceSignDisplay_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_TimecodeToString_FunctionAddress, "bForceSignDisplay", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_TimecodeToString_ReturnValue_PropertyAddress, Conv_TimecodeToString_FunctionAddress, "ReturnValue");
		Conv_TimecodeToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_TimecodeToString_FunctionAddress, "ReturnValue");
		Conv_TimecodeToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_TimecodeToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_TimecodeToString_IsValid = Conv_TimecodeToString_FunctionAddress != IntPtr.Zero && Conv_TimecodeToString_InTimecode_IsValid && Conv_TimecodeToString_bForceSignDisplay_IsValid && Conv_TimecodeToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_TimecodeToString", Conv_TimecodeToString_IsValid);
		Conv_QualifiedFrameTimeToSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_QualifiedFrameTimeToSeconds");
		Conv_QualifiedFrameTimeToSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_QualifiedFrameTimeToSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_QualifiedFrameTimeToSeconds_InFrameTime_PropertyAddress, Conv_QualifiedFrameTimeToSeconds_FunctionAddress, "InFrameTime");
		Conv_QualifiedFrameTimeToSeconds_InFrameTime_Offset = NativeReflectionCached.GetPropertyOffset(Conv_QualifiedFrameTimeToSeconds_FunctionAddress, "InFrameTime");
		Conv_QualifiedFrameTimeToSeconds_InFrameTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_QualifiedFrameTimeToSeconds_FunctionAddress, "InFrameTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_QualifiedFrameTimeToSeconds_ReturnValue_PropertyAddress, Conv_QualifiedFrameTimeToSeconds_FunctionAddress, "ReturnValue");
		Conv_QualifiedFrameTimeToSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_QualifiedFrameTimeToSeconds_FunctionAddress, "ReturnValue");
		Conv_QualifiedFrameTimeToSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_QualifiedFrameTimeToSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		Conv_QualifiedFrameTimeToSeconds_IsValid = Conv_QualifiedFrameTimeToSeconds_FunctionAddress != IntPtr.Zero && Conv_QualifiedFrameTimeToSeconds_InFrameTime_IsValid && Conv_QualifiedFrameTimeToSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_QualifiedFrameTimeToSeconds", Conv_QualifiedFrameTimeToSeconds_IsValid);
		Conv_FrameRateToSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FrameRateToSeconds");
		Conv_FrameRateToSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FrameRateToSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FrameRateToSeconds_InFrameRate_PropertyAddress, Conv_FrameRateToSeconds_FunctionAddress, "InFrameRate");
		Conv_FrameRateToSeconds_InFrameRate_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FrameRateToSeconds_FunctionAddress, "InFrameRate");
		Conv_FrameRateToSeconds_InFrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FrameRateToSeconds_FunctionAddress, "InFrameRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FrameRateToSeconds_ReturnValue_PropertyAddress, Conv_FrameRateToSeconds_FunctionAddress, "ReturnValue");
		Conv_FrameRateToSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FrameRateToSeconds_FunctionAddress, "ReturnValue");
		Conv_FrameRateToSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FrameRateToSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		Conv_FrameRateToSeconds_IsValid = Conv_FrameRateToSeconds_FunctionAddress != IntPtr.Zero && Conv_FrameRateToSeconds_InFrameRate_IsValid && Conv_FrameRateToSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_FrameRateToSeconds", Conv_FrameRateToSeconds_IsValid);
		FrameNumberToInteger_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FrameNumberToInteger");
		FrameNumberToInteger_ParamsSize = NativeReflection.GetFunctionParamsSize(FrameNumberToInteger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FrameNumberToInteger_InFrameNumber_PropertyAddress, FrameNumberToInteger_FunctionAddress, "InFrameNumber");
		FrameNumberToInteger_InFrameNumber_Offset = NativeReflectionCached.GetPropertyOffset(FrameNumberToInteger_FunctionAddress, "InFrameNumber");
		FrameNumberToInteger_InFrameNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(FrameNumberToInteger_FunctionAddress, "InFrameNumber", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FrameNumberToInteger_ReturnValue_PropertyAddress, FrameNumberToInteger_FunctionAddress, "ReturnValue");
		FrameNumberToInteger_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FrameNumberToInteger_FunctionAddress, "ReturnValue");
		FrameNumberToInteger_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FrameNumberToInteger_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FrameNumberToInteger_IsValid = FrameNumberToInteger_FunctionAddress != IntPtr.Zero && FrameNumberToInteger_InFrameNumber_IsValid && FrameNumberToInteger_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_FrameNumberToInteger", FrameNumberToInteger_IsValid);
		Add_FrameNumberInteger_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Add_FrameNumberInteger");
		Add_FrameNumberInteger_ParamsSize = NativeReflection.GetFunctionParamsSize(Add_FrameNumberInteger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Add_FrameNumberInteger_A_PropertyAddress, Add_FrameNumberInteger_FunctionAddress, "A");
		Add_FrameNumberInteger_A_Offset = NativeReflectionCached.GetPropertyOffset(Add_FrameNumberInteger_FunctionAddress, "A");
		Add_FrameNumberInteger_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FrameNumberInteger_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Add_FrameNumberInteger_B_PropertyAddress, Add_FrameNumberInteger_FunctionAddress, "B");
		Add_FrameNumberInteger_B_Offset = NativeReflectionCached.GetPropertyOffset(Add_FrameNumberInteger_FunctionAddress, "B");
		Add_FrameNumberInteger_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FrameNumberInteger_FunctionAddress, "B", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Add_FrameNumberInteger_ReturnValue_PropertyAddress, Add_FrameNumberInteger_FunctionAddress, "ReturnValue");
		Add_FrameNumberInteger_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Add_FrameNumberInteger_FunctionAddress, "ReturnValue");
		Add_FrameNumberInteger_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FrameNumberInteger_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Add_FrameNumberInteger_IsValid = Add_FrameNumberInteger_FunctionAddress != IntPtr.Zero && Add_FrameNumberInteger_A_IsValid && Add_FrameNumberInteger_B_IsValid && Add_FrameNumberInteger_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Add_FrameNumberInteger", Add_FrameNumberInteger_IsValid);
		Add_FrameNumberFrameNumber_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Add_FrameNumberFrameNumber");
		Add_FrameNumberFrameNumber_ParamsSize = NativeReflection.GetFunctionParamsSize(Add_FrameNumberFrameNumber_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Add_FrameNumberFrameNumber_A_PropertyAddress, Add_FrameNumberFrameNumber_FunctionAddress, "A");
		Add_FrameNumberFrameNumber_A_Offset = NativeReflectionCached.GetPropertyOffset(Add_FrameNumberFrameNumber_FunctionAddress, "A");
		Add_FrameNumberFrameNumber_A_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FrameNumberFrameNumber_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Add_FrameNumberFrameNumber_B_PropertyAddress, Add_FrameNumberFrameNumber_FunctionAddress, "B");
		Add_FrameNumberFrameNumber_B_Offset = NativeReflectionCached.GetPropertyOffset(Add_FrameNumberFrameNumber_FunctionAddress, "B");
		Add_FrameNumberFrameNumber_B_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FrameNumberFrameNumber_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Add_FrameNumberFrameNumber_ReturnValue_PropertyAddress, Add_FrameNumberFrameNumber_FunctionAddress, "ReturnValue");
		Add_FrameNumberFrameNumber_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Add_FrameNumberFrameNumber_FunctionAddress, "ReturnValue");
		Add_FrameNumberFrameNumber_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FrameNumberFrameNumber_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Add_FrameNumberFrameNumber_IsValid = Add_FrameNumberFrameNumber_FunctionAddress != IntPtr.Zero && Add_FrameNumberFrameNumber_A_IsValid && Add_FrameNumberFrameNumber_B_IsValid && Add_FrameNumberFrameNumber_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TimeManagement.TimeManagementBlueprintLibrary:Add_FrameNumberFrameNumber", Add_FrameNumberFrameNumber_IsValid);
	}
}
