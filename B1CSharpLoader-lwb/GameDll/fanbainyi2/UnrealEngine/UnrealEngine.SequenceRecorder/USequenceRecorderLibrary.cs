using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.SequenceRecorder;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary", "SequenceRecorder", UnrealModuleType.Engine)]
public class USequenceRecorderLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StopRecordingSequence_IsValid;

	private static IntPtr StopRecordingSequence_FunctionAddress;

	private static int StopRecordingSequence_ParamsSize;

	private static bool StartRecordingSequence_IsValid;

	private static IntPtr StartRecordingSequence_FunctionAddress;

	private static int StartRecordingSequence_ParamsSize;

	private static bool StartRecordingSequence_ActorsToRecord_IsValid;

	private static FFieldAddress StartRecordingSequence_ActorsToRecord_PropertyAddress;

	private static int StartRecordingSequence_ActorsToRecord_Offset;

	private static bool IsRecordingSequence_IsValid;

	private static IntPtr IsRecordingSequence_FunctionAddress;

	private static int IsRecordingSequence_ParamsSize;

	private static bool IsRecordingSequence_ReturnValue_IsValid;

	private static FFieldAddress IsRecordingSequence_ReturnValue_PropertyAddress;

	private static int IsRecordingSequence_ReturnValue_Offset;

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary:StopRecordingSequence")]
	public unsafe static void StopRecordingSequence()
	{
		if (!StopRecordingSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary:StopRecordingSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopRecordingSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopRecordingSequence_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StopRecordingSequence_FunctionAddress, argsSize: StopRecordingSequence_ParamsSize);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary:StartRecordingSequence")]
	public unsafe static void StartRecordingSequence(List<AActor> ActorsToRecord)
	{
		if (!StartRecordingSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary:StartRecordingSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartRecordingSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartRecordingSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, StartRecordingSequence_ActorsToRecord_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, StartRecordingSequence_ActorsToRecord_Offset), ActorsToRecord);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartRecordingSequence_FunctionAddress, intPtr, StartRecordingSequence_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartRecordingSequence_ActorsToRecord_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335815681u)]
	[UMetaPath("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary:IsRecordingSequence")]
	public unsafe static bool IsRecordingSequence()
	{
		if (!IsRecordingSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary:IsRecordingSequence");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRecordingSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRecordingSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRecordingSequence_FunctionAddress, intPtr, IsRecordingSequence_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRecordingSequence_ReturnValue_Offset), 0, IsRecordingSequence_ReturnValue_PropertyAddress.Address);
	}

	static USequenceRecorderLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USequenceRecorderLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USequenceRecorderLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary");
		StopRecordingSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopRecordingSequence");
		StopRecordingSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(StopRecordingSequence_FunctionAddress);
		StopRecordingSequence_IsValid = StopRecordingSequence_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary:StopRecordingSequence", StopRecordingSequence_IsValid);
		StartRecordingSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartRecordingSequence");
		StartRecordingSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(StartRecordingSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartRecordingSequence_ActorsToRecord_PropertyAddress, StartRecordingSequence_FunctionAddress, "ActorsToRecord");
		StartRecordingSequence_ActorsToRecord_Offset = NativeReflectionCached.GetPropertyOffset(StartRecordingSequence_FunctionAddress, "ActorsToRecord");
		StartRecordingSequence_ActorsToRecord_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecordingSequence_FunctionAddress, "ActorsToRecord", Classes.FArrayProperty);
		StartRecordingSequence_IsValid = StartRecordingSequence_FunctionAddress != IntPtr.Zero && StartRecordingSequence_ActorsToRecord_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary:StartRecordingSequence", StartRecordingSequence_IsValid);
		IsRecordingSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRecordingSequence");
		IsRecordingSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRecordingSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRecordingSequence_ReturnValue_PropertyAddress, IsRecordingSequence_FunctionAddress, "ReturnValue");
		IsRecordingSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRecordingSequence_FunctionAddress, "ReturnValue");
		IsRecordingSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRecordingSequence_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRecordingSequence_IsValid = IsRecordingSequence_FunctionAddress != IntPtr.Zero && IsRecordingSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary:IsRecordingSequence", IsRecordingSequence_IsValid);
	}
}
