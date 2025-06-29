using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioMixer.QuartzClockHandle", "AudioMixer", UnrealModuleType.Engine)]
public class UQuartzClockHandle : UObject
{
	private static bool UnsubscribeFromTimeDivision_IsValid;

	private static IntPtr UnsubscribeFromTimeDivision_FunctionAddress;

	private static int UnsubscribeFromTimeDivision_ParamsSize;

	private static bool UnsubscribeFromTimeDivision_WorldContextObject_IsValid;

	private static FFieldAddress UnsubscribeFromTimeDivision_WorldContextObject_PropertyAddress;

	private static int UnsubscribeFromTimeDivision_WorldContextObject_Offset;

	private static bool UnsubscribeFromTimeDivision_InQuantizationBoundary_IsValid;

	private static FFieldAddress UnsubscribeFromTimeDivision_InQuantizationBoundary_PropertyAddress;

	private static int UnsubscribeFromTimeDivision_InQuantizationBoundary_Offset;

	private static bool UnsubscribeFromTimeDivision_ClockHandle_IsValid;

	private static FFieldAddress UnsubscribeFromTimeDivision_ClockHandle_PropertyAddress;

	private static int UnsubscribeFromTimeDivision_ClockHandle_Offset;

	private static bool UnsubscribeFromAllTimeDivisions_IsValid;

	private static IntPtr UnsubscribeFromAllTimeDivisions_FunctionAddress;

	private static int UnsubscribeFromAllTimeDivisions_ParamsSize;

	private static bool UnsubscribeFromAllTimeDivisions_WorldContextObject_IsValid;

	private static FFieldAddress UnsubscribeFromAllTimeDivisions_WorldContextObject_PropertyAddress;

	private static int UnsubscribeFromAllTimeDivisions_WorldContextObject_Offset;

	private static bool UnsubscribeFromAllTimeDivisions_ClockHandle_IsValid;

	private static FFieldAddress UnsubscribeFromAllTimeDivisions_ClockHandle_PropertyAddress;

	private static int UnsubscribeFromAllTimeDivisions_ClockHandle_Offset;

	private static bool SubscribeToQuantizationEvent_IsValid;

	private static IntPtr SubscribeToQuantizationEvent_FunctionAddress;

	private static int SubscribeToQuantizationEvent_ParamsSize;

	private static bool SubscribeToQuantizationEvent_WorldContextObject_IsValid;

	private static FFieldAddress SubscribeToQuantizationEvent_WorldContextObject_PropertyAddress;

	private static int SubscribeToQuantizationEvent_WorldContextObject_Offset;

	private static bool SubscribeToQuantizationEvent_InQuantizationBoundary_IsValid;

	private static FFieldAddress SubscribeToQuantizationEvent_InQuantizationBoundary_PropertyAddress;

	private static int SubscribeToQuantizationEvent_InQuantizationBoundary_Offset;

	private static bool SubscribeToQuantizationEvent_OnQuantizationEvent_IsValid;

	private static FFieldAddress SubscribeToQuantizationEvent_OnQuantizationEvent_PropertyAddress;

	private static int SubscribeToQuantizationEvent_OnQuantizationEvent_Offset;

	private static bool SubscribeToQuantizationEvent_ClockHandle_IsValid;

	private static FFieldAddress SubscribeToQuantizationEvent_ClockHandle_PropertyAddress;

	private static int SubscribeToQuantizationEvent_ClockHandle_Offset;

	private static bool SubscribeToAllQuantizationEvents_IsValid;

	private static IntPtr SubscribeToAllQuantizationEvents_FunctionAddress;

	private static int SubscribeToAllQuantizationEvents_ParamsSize;

	private static bool SubscribeToAllQuantizationEvents_WorldContextObject_IsValid;

	private static FFieldAddress SubscribeToAllQuantizationEvents_WorldContextObject_PropertyAddress;

	private static int SubscribeToAllQuantizationEvents_WorldContextObject_Offset;

	private static bool SubscribeToAllQuantizationEvents_OnQuantizationEvent_IsValid;

	private static FFieldAddress SubscribeToAllQuantizationEvents_OnQuantizationEvent_PropertyAddress;

	private static int SubscribeToAllQuantizationEvents_OnQuantizationEvent_Offset;

	private static bool SubscribeToAllQuantizationEvents_ClockHandle_IsValid;

	private static FFieldAddress SubscribeToAllQuantizationEvents_ClockHandle_PropertyAddress;

	private static int SubscribeToAllQuantizationEvents_ClockHandle_Offset;

	private static bool StopClock_IsValid;

	private static IntPtr StopClock_FunctionAddress;

	private static int StopClock_ParamsSize;

	private static bool StopClock_WorldContextObject_IsValid;

	private static FFieldAddress StopClock_WorldContextObject_PropertyAddress;

	private static int StopClock_WorldContextObject_Offset;

	private static bool StopClock_CancelPendingEvents_IsValid;

	private static FFieldAddress StopClock_CancelPendingEvents_PropertyAddress;

	private static int StopClock_CancelPendingEvents_Offset;

	private static bool StopClock_ClockHandle_IsValid;

	private static FFieldAddress StopClock_ClockHandle_PropertyAddress;

	private static int StopClock_ClockHandle_Offset;

	private static bool StartOtherClock_IsValid;

	private static IntPtr StartOtherClock_FunctionAddress;

	private static int StartOtherClock_ParamsSize;

	private static bool StartOtherClock_WorldContextObject_IsValid;

	private static FFieldAddress StartOtherClock_WorldContextObject_PropertyAddress;

	private static int StartOtherClock_WorldContextObject_Offset;

	private static bool StartOtherClock_OtherClockName_IsValid;

	private static FFieldAddress StartOtherClock_OtherClockName_PropertyAddress;

	private static int StartOtherClock_OtherClockName_Offset;

	private static bool StartOtherClock_InQuantizationBoundary_IsValid;

	private static FFieldAddress StartOtherClock_InQuantizationBoundary_PropertyAddress;

	private static int StartOtherClock_InQuantizationBoundary_Offset;

	private static bool StartOtherClock_InDelegate_IsValid;

	private static FFieldAddress StartOtherClock_InDelegate_PropertyAddress;

	private static int StartOtherClock_InDelegate_Offset;

	private static bool StartClock_IsValid;

	private static IntPtr StartClock_FunctionAddress;

	private static int StartClock_ParamsSize;

	private static bool StartClock_WorldContextObject_IsValid;

	private static FFieldAddress StartClock_WorldContextObject_PropertyAddress;

	private static int StartClock_WorldContextObject_Offset;

	private static bool StartClock_ClockHandle_IsValid;

	private static FFieldAddress StartClock_ClockHandle_PropertyAddress;

	private static int StartClock_ClockHandle_Offset;

	private static bool SetTicksPerSecond_IsValid;

	private static IntPtr SetTicksPerSecond_FunctionAddress;

	private static int SetTicksPerSecond_ParamsSize;

	private static bool SetTicksPerSecond_WorldContextObject_IsValid;

	private static FFieldAddress SetTicksPerSecond_WorldContextObject_PropertyAddress;

	private static int SetTicksPerSecond_WorldContextObject_Offset;

	private static bool SetTicksPerSecond_QuantizationBoundary_IsValid;

	private static FFieldAddress SetTicksPerSecond_QuantizationBoundary_PropertyAddress;

	private static int SetTicksPerSecond_QuantizationBoundary_Offset;

	private static bool SetTicksPerSecond_Delegate_IsValid;

	private static FFieldAddress SetTicksPerSecond_Delegate_PropertyAddress;

	private static int SetTicksPerSecond_Delegate_Offset;

	private static bool SetTicksPerSecond_ClockHandle_IsValid;

	private static FFieldAddress SetTicksPerSecond_ClockHandle_PropertyAddress;

	private static int SetTicksPerSecond_ClockHandle_Offset;

	private static bool SetTicksPerSecond_TicksPerSecond_IsValid;

	private static FFieldAddress SetTicksPerSecond_TicksPerSecond_PropertyAddress;

	private static int SetTicksPerSecond_TicksPerSecond_Offset;

	private static bool SetThirtySecondNotesPerMinute_IsValid;

	private static IntPtr SetThirtySecondNotesPerMinute_FunctionAddress;

	private static int SetThirtySecondNotesPerMinute_ParamsSize;

	private static bool SetThirtySecondNotesPerMinute_WorldContextObject_IsValid;

	private static FFieldAddress SetThirtySecondNotesPerMinute_WorldContextObject_PropertyAddress;

	private static int SetThirtySecondNotesPerMinute_WorldContextObject_Offset;

	private static bool SetThirtySecondNotesPerMinute_QuantizationBoundary_IsValid;

	private static FFieldAddress SetThirtySecondNotesPerMinute_QuantizationBoundary_PropertyAddress;

	private static int SetThirtySecondNotesPerMinute_QuantizationBoundary_Offset;

	private static bool SetThirtySecondNotesPerMinute_Delegate_IsValid;

	private static FFieldAddress SetThirtySecondNotesPerMinute_Delegate_PropertyAddress;

	private static int SetThirtySecondNotesPerMinute_Delegate_Offset;

	private static bool SetThirtySecondNotesPerMinute_ClockHandle_IsValid;

	private static FFieldAddress SetThirtySecondNotesPerMinute_ClockHandle_PropertyAddress;

	private static int SetThirtySecondNotesPerMinute_ClockHandle_Offset;

	private static bool SetThirtySecondNotesPerMinute_ThirtySecondsNotesPerMinute_IsValid;

	private static FFieldAddress SetThirtySecondNotesPerMinute_ThirtySecondsNotesPerMinute_PropertyAddress;

	private static int SetThirtySecondNotesPerMinute_ThirtySecondsNotesPerMinute_Offset;

	private static bool SetSecondsPerTick_IsValid;

	private static IntPtr SetSecondsPerTick_FunctionAddress;

	private static int SetSecondsPerTick_ParamsSize;

	private static bool SetSecondsPerTick_WorldContextObject_IsValid;

	private static FFieldAddress SetSecondsPerTick_WorldContextObject_PropertyAddress;

	private static int SetSecondsPerTick_WorldContextObject_Offset;

	private static bool SetSecondsPerTick_QuantizationBoundary_IsValid;

	private static FFieldAddress SetSecondsPerTick_QuantizationBoundary_PropertyAddress;

	private static int SetSecondsPerTick_QuantizationBoundary_Offset;

	private static bool SetSecondsPerTick_Delegate_IsValid;

	private static FFieldAddress SetSecondsPerTick_Delegate_PropertyAddress;

	private static int SetSecondsPerTick_Delegate_Offset;

	private static bool SetSecondsPerTick_ClockHandle_IsValid;

	private static FFieldAddress SetSecondsPerTick_ClockHandle_PropertyAddress;

	private static int SetSecondsPerTick_ClockHandle_Offset;

	private static bool SetSecondsPerTick_SecondsPerTick_IsValid;

	private static FFieldAddress SetSecondsPerTick_SecondsPerTick_PropertyAddress;

	private static int SetSecondsPerTick_SecondsPerTick_Offset;

	private static bool SetMillisecondsPerTick_IsValid;

	private static IntPtr SetMillisecondsPerTick_FunctionAddress;

	private static int SetMillisecondsPerTick_ParamsSize;

	private static bool SetMillisecondsPerTick_WorldContextObject_IsValid;

	private static FFieldAddress SetMillisecondsPerTick_WorldContextObject_PropertyAddress;

	private static int SetMillisecondsPerTick_WorldContextObject_Offset;

	private static bool SetMillisecondsPerTick_QuantizationBoundary_IsValid;

	private static FFieldAddress SetMillisecondsPerTick_QuantizationBoundary_PropertyAddress;

	private static int SetMillisecondsPerTick_QuantizationBoundary_Offset;

	private static bool SetMillisecondsPerTick_Delegate_IsValid;

	private static FFieldAddress SetMillisecondsPerTick_Delegate_PropertyAddress;

	private static int SetMillisecondsPerTick_Delegate_Offset;

	private static bool SetMillisecondsPerTick_ClockHandle_IsValid;

	private static FFieldAddress SetMillisecondsPerTick_ClockHandle_PropertyAddress;

	private static int SetMillisecondsPerTick_ClockHandle_Offset;

	private static bool SetMillisecondsPerTick_MillisecondsPerTick_IsValid;

	private static FFieldAddress SetMillisecondsPerTick_MillisecondsPerTick_PropertyAddress;

	private static int SetMillisecondsPerTick_MillisecondsPerTick_Offset;

	private static bool SetBeatsPerMinute_IsValid;

	private static IntPtr SetBeatsPerMinute_FunctionAddress;

	private static int SetBeatsPerMinute_ParamsSize;

	private static bool SetBeatsPerMinute_WorldContextObject_IsValid;

	private static FFieldAddress SetBeatsPerMinute_WorldContextObject_PropertyAddress;

	private static int SetBeatsPerMinute_WorldContextObject_Offset;

	private static bool SetBeatsPerMinute_QuantizationBoundary_IsValid;

	private static FFieldAddress SetBeatsPerMinute_QuantizationBoundary_PropertyAddress;

	private static int SetBeatsPerMinute_QuantizationBoundary_Offset;

	private static bool SetBeatsPerMinute_Delegate_IsValid;

	private static FFieldAddress SetBeatsPerMinute_Delegate_PropertyAddress;

	private static int SetBeatsPerMinute_Delegate_Offset;

	private static bool SetBeatsPerMinute_ClockHandle_IsValid;

	private static FFieldAddress SetBeatsPerMinute_ClockHandle_PropertyAddress;

	private static int SetBeatsPerMinute_ClockHandle_Offset;

	private static bool SetBeatsPerMinute_BeatsPerMinute_IsValid;

	private static FFieldAddress SetBeatsPerMinute_BeatsPerMinute_PropertyAddress;

	private static int SetBeatsPerMinute_BeatsPerMinute_Offset;

	private static bool ResumeClock_IsValid;

	private static IntPtr ResumeClock_FunctionAddress;

	private static int ResumeClock_ParamsSize;

	private static bool ResumeClock_WorldContextObject_IsValid;

	private static FFieldAddress ResumeClock_WorldContextObject_PropertyAddress;

	private static int ResumeClock_WorldContextObject_Offset;

	private static bool ResumeClock_ClockHandle_IsValid;

	private static FFieldAddress ResumeClock_ClockHandle_PropertyAddress;

	private static int ResumeClock_ClockHandle_Offset;

	private static bool ResetTransportQuantized_IsValid;

	private static IntPtr ResetTransportQuantized_FunctionAddress;

	private static int ResetTransportQuantized_ParamsSize;

	private static bool ResetTransportQuantized_WorldContextObject_IsValid;

	private static FFieldAddress ResetTransportQuantized_WorldContextObject_PropertyAddress;

	private static int ResetTransportQuantized_WorldContextObject_Offset;

	private static bool ResetTransportQuantized_InQuantizationBoundary_IsValid;

	private static FFieldAddress ResetTransportQuantized_InQuantizationBoundary_PropertyAddress;

	private static int ResetTransportQuantized_InQuantizationBoundary_Offset;

	private static bool ResetTransportQuantized_InDelegate_IsValid;

	private static FFieldAddress ResetTransportQuantized_InDelegate_PropertyAddress;

	private static int ResetTransportQuantized_InDelegate_Offset;

	private static bool ResetTransportQuantized_ClockHandle_IsValid;

	private static FFieldAddress ResetTransportQuantized_ClockHandle_PropertyAddress;

	private static int ResetTransportQuantized_ClockHandle_Offset;

	private static bool PauseClock_IsValid;

	private static IntPtr PauseClock_FunctionAddress;

	private static int PauseClock_ParamsSize;

	private static bool PauseClock_WorldContextObject_IsValid;

	private static FFieldAddress PauseClock_WorldContextObject_PropertyAddress;

	private static int PauseClock_WorldContextObject_Offset;

	private static bool PauseClock_ClockHandle_IsValid;

	private static FFieldAddress PauseClock_ClockHandle_PropertyAddress;

	private static int PauseClock_ClockHandle_Offset;

	private static bool IsClockRunning_IsValid;

	private static IntPtr IsClockRunning_FunctionAddress;

	private static int IsClockRunning_ParamsSize;

	private static bool IsClockRunning_WorldContextObject_IsValid;

	private static FFieldAddress IsClockRunning_WorldContextObject_PropertyAddress;

	private static int IsClockRunning_WorldContextObject_Offset;

	private static bool IsClockRunning_ReturnValue_IsValid;

	private static FFieldAddress IsClockRunning_ReturnValue_PropertyAddress;

	private static int IsClockRunning_ReturnValue_Offset;

	private static bool GetTicksPerSecond_IsValid;

	private static IntPtr GetTicksPerSecond_FunctionAddress;

	private static int GetTicksPerSecond_ParamsSize;

	private static bool GetTicksPerSecond_WorldContextObject_IsValid;

	private static FFieldAddress GetTicksPerSecond_WorldContextObject_PropertyAddress;

	private static int GetTicksPerSecond_WorldContextObject_Offset;

	private static bool GetTicksPerSecond_ReturnValue_IsValid;

	private static FFieldAddress GetTicksPerSecond_ReturnValue_PropertyAddress;

	private static int GetTicksPerSecond_ReturnValue_Offset;

	private static bool GetThirtySecondNotesPerMinute_IsValid;

	private static IntPtr GetThirtySecondNotesPerMinute_FunctionAddress;

	private static int GetThirtySecondNotesPerMinute_ParamsSize;

	private static bool GetThirtySecondNotesPerMinute_WorldContextObject_IsValid;

	private static FFieldAddress GetThirtySecondNotesPerMinute_WorldContextObject_PropertyAddress;

	private static int GetThirtySecondNotesPerMinute_WorldContextObject_Offset;

	private static bool GetThirtySecondNotesPerMinute_ReturnValue_IsValid;

	private static FFieldAddress GetThirtySecondNotesPerMinute_ReturnValue_PropertyAddress;

	private static int GetThirtySecondNotesPerMinute_ReturnValue_Offset;

	private static bool GetSecondsPerTick_IsValid;

	private static IntPtr GetSecondsPerTick_FunctionAddress;

	private static int GetSecondsPerTick_ParamsSize;

	private static bool GetSecondsPerTick_WorldContextObject_IsValid;

	private static FFieldAddress GetSecondsPerTick_WorldContextObject_PropertyAddress;

	private static int GetSecondsPerTick_WorldContextObject_Offset;

	private static bool GetSecondsPerTick_ReturnValue_IsValid;

	private static FFieldAddress GetSecondsPerTick_ReturnValue_PropertyAddress;

	private static int GetSecondsPerTick_ReturnValue_Offset;

	private static bool GetMillisecondsPerTick_IsValid;

	private static IntPtr GetMillisecondsPerTick_FunctionAddress;

	private static int GetMillisecondsPerTick_ParamsSize;

	private static bool GetMillisecondsPerTick_WorldContextObject_IsValid;

	private static FFieldAddress GetMillisecondsPerTick_WorldContextObject_PropertyAddress;

	private static int GetMillisecondsPerTick_WorldContextObject_Offset;

	private static bool GetMillisecondsPerTick_ReturnValue_IsValid;

	private static FFieldAddress GetMillisecondsPerTick_ReturnValue_PropertyAddress;

	private static int GetMillisecondsPerTick_ReturnValue_Offset;

	private static bool GetEstimatedRunTime_IsValid;

	private static IntPtr GetEstimatedRunTime_FunctionAddress;

	private static int GetEstimatedRunTime_ParamsSize;

	private static bool GetEstimatedRunTime_WorldContextObject_IsValid;

	private static FFieldAddress GetEstimatedRunTime_WorldContextObject_PropertyAddress;

	private static int GetEstimatedRunTime_WorldContextObject_Offset;

	private static bool GetEstimatedRunTime_ReturnValue_IsValid;

	private static FFieldAddress GetEstimatedRunTime_ReturnValue_PropertyAddress;

	private static int GetEstimatedRunTime_ReturnValue_Offset;

	private static bool GetDurationOfQuantizationTypeInSeconds_IsValid;

	private static IntPtr GetDurationOfQuantizationTypeInSeconds_FunctionAddress;

	private static int GetDurationOfQuantizationTypeInSeconds_ParamsSize;

	private static bool GetDurationOfQuantizationTypeInSeconds_WorldContextObject_IsValid;

	private static FFieldAddress GetDurationOfQuantizationTypeInSeconds_WorldContextObject_PropertyAddress;

	private static int GetDurationOfQuantizationTypeInSeconds_WorldContextObject_Offset;

	private static bool GetDurationOfQuantizationTypeInSeconds_QuantizationType_IsValid;

	private static FFieldAddress GetDurationOfQuantizationTypeInSeconds_QuantizationType_PropertyAddress;

	private static int GetDurationOfQuantizationTypeInSeconds_QuantizationType_Offset;

	private static bool GetDurationOfQuantizationTypeInSeconds_Multiplier_IsValid;

	private static FFieldAddress GetDurationOfQuantizationTypeInSeconds_Multiplier_PropertyAddress;

	private static int GetDurationOfQuantizationTypeInSeconds_Multiplier_Offset;

	private static bool GetDurationOfQuantizationTypeInSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetDurationOfQuantizationTypeInSeconds_ReturnValue_PropertyAddress;

	private static int GetDurationOfQuantizationTypeInSeconds_ReturnValue_Offset;

	private static bool GetCurrentTimestamp_IsValid;

	private static IntPtr GetCurrentTimestamp_FunctionAddress;

	private static int GetCurrentTimestamp_ParamsSize;

	private static bool GetCurrentTimestamp_WorldContextObject_IsValid;

	private static FFieldAddress GetCurrentTimestamp_WorldContextObject_PropertyAddress;

	private static int GetCurrentTimestamp_WorldContextObject_Offset;

	private static bool GetCurrentTimestamp_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentTimestamp_ReturnValue_PropertyAddress;

	private static int GetCurrentTimestamp_ReturnValue_Offset;

	private static bool GetBeatsPerMinute_IsValid;

	private static IntPtr GetBeatsPerMinute_FunctionAddress;

	private static int GetBeatsPerMinute_ParamsSize;

	private static bool GetBeatsPerMinute_WorldContextObject_IsValid;

	private static FFieldAddress GetBeatsPerMinute_WorldContextObject_PropertyAddress;

	private static int GetBeatsPerMinute_WorldContextObject_Offset;

	private static bool GetBeatsPerMinute_ReturnValue_IsValid;

	private static FFieldAddress GetBeatsPerMinute_ReturnValue_PropertyAddress;

	private static int GetBeatsPerMinute_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:UnsubscribeFromTimeDivision")]
	public unsafe void UnsubscribeFromTimeDivision(UObject WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary, out UQuartzClockHandle ClockHandle)
	{
		CheckDestroyed();
		if (!UnsubscribeFromTimeDivision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:UnsubscribeFromTimeDivision");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnsubscribeFromTimeDivision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnsubscribeFromTimeDivision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, UnsubscribeFromTimeDivision_WorldContextObject_Offset), 0, UnsubscribeFromTimeDivision_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		EnumMarshaler<EQuartzCommandQuantization>.ToNative(IntPtr.Add(intPtr, UnsubscribeFromTimeDivision_InQuantizationBoundary_Offset), 0, UnsubscribeFromTimeDivision_InQuantizationBoundary_PropertyAddress.Address, InQuantizationBoundary);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnsubscribeFromTimeDivision_FunctionAddress, intPtr, UnsubscribeFromTimeDivision_ParamsSize);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, UnsubscribeFromTimeDivision_ClockHandle_Offset), 0, UnsubscribeFromTimeDivision_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:UnsubscribeFromAllTimeDivisions")]
	public unsafe void UnsubscribeFromAllTimeDivisions(UObject WorldContextObject, out UQuartzClockHandle ClockHandle)
	{
		CheckDestroyed();
		if (!UnsubscribeFromAllTimeDivisions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:UnsubscribeFromAllTimeDivisions");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnsubscribeFromAllTimeDivisions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnsubscribeFromAllTimeDivisions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, UnsubscribeFromAllTimeDivisions_WorldContextObject_Offset), 0, UnsubscribeFromAllTimeDivisions_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnsubscribeFromAllTimeDivisions_FunctionAddress, intPtr, UnsubscribeFromAllTimeDivisions_ParamsSize);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, UnsubscribeFromAllTimeDivisions_ClockHandle_Offset), 0, UnsubscribeFromAllTimeDivisions_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:SubscribeToQuantizationEvent")]
	public unsafe void SubscribeToQuantizationEvent(UObject WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary, FOnQuartzMetronomeEventBP OnQuantizationEvent, out UQuartzClockHandle ClockHandle)
	{
		CheckDestroyed();
		if (!SubscribeToQuantizationEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:SubscribeToQuantizationEvent");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SubscribeToQuantizationEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SubscribeToQuantizationEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SubscribeToQuantizationEvent_WorldContextObject_Offset), 0, SubscribeToQuantizationEvent_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		EnumMarshaler<EQuartzCommandQuantization>.ToNative(IntPtr.Add(intPtr, SubscribeToQuantizationEvent_InQuantizationBoundary_Offset), 0, SubscribeToQuantizationEvent_InQuantizationBoundary_PropertyAddress.Address, InQuantizationBoundary);
		FDelegateMarshaler<FOnQuartzMetronomeEventBP>.ToNative(IntPtr.Add(intPtr, SubscribeToQuantizationEvent_OnQuantizationEvent_Offset), 0, SubscribeToQuantizationEvent_OnQuantizationEvent_PropertyAddress.Address, OnQuantizationEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SubscribeToQuantizationEvent_FunctionAddress, intPtr, SubscribeToQuantizationEvent_ParamsSize);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, SubscribeToQuantizationEvent_ClockHandle_Offset), 0, SubscribeToQuantizationEvent_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:SubscribeToAllQuantizationEvents")]
	public unsafe void SubscribeToAllQuantizationEvents(UObject WorldContextObject, FOnQuartzMetronomeEventBP OnQuantizationEvent, out UQuartzClockHandle ClockHandle)
	{
		CheckDestroyed();
		if (!SubscribeToAllQuantizationEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:SubscribeToAllQuantizationEvents");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SubscribeToAllQuantizationEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SubscribeToAllQuantizationEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SubscribeToAllQuantizationEvents_WorldContextObject_Offset), 0, SubscribeToAllQuantizationEvents_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FDelegateMarshaler<FOnQuartzMetronomeEventBP>.ToNative(IntPtr.Add(intPtr, SubscribeToAllQuantizationEvents_OnQuantizationEvent_Offset), 0, SubscribeToAllQuantizationEvents_OnQuantizationEvent_PropertyAddress.Address, OnQuantizationEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SubscribeToAllQuantizationEvents_FunctionAddress, intPtr, SubscribeToAllQuantizationEvents_ParamsSize);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, SubscribeToAllQuantizationEvents_ClockHandle_Offset), 0, SubscribeToAllQuantizationEvents_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:StopClock")]
	public unsafe void StopClock(UObject WorldContextObject, bool CancelPendingEvents, out UQuartzClockHandle ClockHandle)
	{
		CheckDestroyed();
		if (!StopClock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:StopClock");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopClock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopClock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StopClock_WorldContextObject_Offset), 0, StopClock_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopClock_CancelPendingEvents_Offset), 0, StopClock_CancelPendingEvents_PropertyAddress.Address, CancelPendingEvents);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopClock_FunctionAddress, intPtr, StopClock_ParamsSize);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, StopClock_ClockHandle_Offset), 0, StopClock_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:StartOtherClock")]
	public unsafe void StartOtherClock(UObject WorldContextObject, FName OtherClockName, FQuartzQuantizationBoundary InQuantizationBoundary, FOnQuartzCommandEventBP InDelegate)
	{
		CheckDestroyed();
		if (!StartOtherClock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:StartOtherClock");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartOtherClock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartOtherClock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartOtherClock_WorldContextObject_Offset), 0, StartOtherClock_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, StartOtherClock_OtherClockName_Offset), 0, StartOtherClock_OtherClockName_PropertyAddress.Address, OtherClockName);
		NativeReflection.InitializeValue_InContainer(StartOtherClock_InQuantizationBoundary_PropertyAddress.Address, intPtr);
		FQuartzQuantizationBoundary.ToNative(IntPtr.Add(intPtr, StartOtherClock_InQuantizationBoundary_Offset), 0, StartOtherClock_InQuantizationBoundary_PropertyAddress.Address, InQuantizationBoundary);
		FDelegateMarshaler<FOnQuartzCommandEventBP>.ToNative(IntPtr.Add(intPtr, StartOtherClock_InDelegate_Offset), 0, StartOtherClock_InDelegate_PropertyAddress.Address, InDelegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartOtherClock_FunctionAddress, intPtr, StartOtherClock_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartOtherClock_InQuantizationBoundary_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:StartClock")]
	public unsafe void StartClock(UObject WorldContextObject, out UQuartzClockHandle ClockHandle)
	{
		CheckDestroyed();
		if (!StartClock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:StartClock");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartClock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartClock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartClock_WorldContextObject_Offset), 0, StartClock_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartClock_FunctionAddress, intPtr, StartClock_ParamsSize);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, StartClock_ClockHandle_Offset), 0, StartClock_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:SetTicksPerSecond")]
	public unsafe void SetTicksPerSecond(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, out UQuartzClockHandle ClockHandle, float TicksPerSecond = 10f)
	{
		CheckDestroyed();
		if (!SetTicksPerSecond_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:SetTicksPerSecond");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTicksPerSecond_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTicksPerSecond_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetTicksPerSecond_WorldContextObject_Offset), 0, SetTicksPerSecond_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(SetTicksPerSecond_QuantizationBoundary_PropertyAddress.Address, intPtr);
		FQuartzQuantizationBoundary.ToNative(IntPtr.Add(intPtr, SetTicksPerSecond_QuantizationBoundary_Offset), 0, SetTicksPerSecond_QuantizationBoundary_PropertyAddress.Address, QuantizationBoundary);
		FDelegateMarshaler<FOnQuartzCommandEventBP>.ToNative(IntPtr.Add(intPtr, SetTicksPerSecond_Delegate_Offset), 0, SetTicksPerSecond_Delegate_PropertyAddress.Address, Delegate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTicksPerSecond_TicksPerSecond_Offset), 0, SetTicksPerSecond_TicksPerSecond_PropertyAddress.Address, TicksPerSecond);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTicksPerSecond_FunctionAddress, intPtr, SetTicksPerSecond_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTicksPerSecond_QuantizationBoundary_PropertyAddress.Address, intPtr);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, SetTicksPerSecond_ClockHandle_Offset), 0, SetTicksPerSecond_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:SetThirtySecondNotesPerMinute")]
	public unsafe void SetThirtySecondNotesPerMinute(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, out UQuartzClockHandle ClockHandle, float ThirtySecondsNotesPerMinute = 960f)
	{
		CheckDestroyed();
		if (!SetThirtySecondNotesPerMinute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:SetThirtySecondNotesPerMinute");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetThirtySecondNotesPerMinute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetThirtySecondNotesPerMinute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetThirtySecondNotesPerMinute_WorldContextObject_Offset), 0, SetThirtySecondNotesPerMinute_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(SetThirtySecondNotesPerMinute_QuantizationBoundary_PropertyAddress.Address, intPtr);
		FQuartzQuantizationBoundary.ToNative(IntPtr.Add(intPtr, SetThirtySecondNotesPerMinute_QuantizationBoundary_Offset), 0, SetThirtySecondNotesPerMinute_QuantizationBoundary_PropertyAddress.Address, QuantizationBoundary);
		FDelegateMarshaler<FOnQuartzCommandEventBP>.ToNative(IntPtr.Add(intPtr, SetThirtySecondNotesPerMinute_Delegate_Offset), 0, SetThirtySecondNotesPerMinute_Delegate_PropertyAddress.Address, Delegate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetThirtySecondNotesPerMinute_ThirtySecondsNotesPerMinute_Offset), 0, SetThirtySecondNotesPerMinute_ThirtySecondsNotesPerMinute_PropertyAddress.Address, ThirtySecondsNotesPerMinute);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetThirtySecondNotesPerMinute_FunctionAddress, intPtr, SetThirtySecondNotesPerMinute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetThirtySecondNotesPerMinute_QuantizationBoundary_PropertyAddress.Address, intPtr);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, SetThirtySecondNotesPerMinute_ClockHandle_Offset), 0, SetThirtySecondNotesPerMinute_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:SetSecondsPerTick")]
	public unsafe void SetSecondsPerTick(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, out UQuartzClockHandle ClockHandle, float SecondsPerTick = 0.25f)
	{
		CheckDestroyed();
		if (!SetSecondsPerTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:SetSecondsPerTick");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSecondsPerTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSecondsPerTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSecondsPerTick_WorldContextObject_Offset), 0, SetSecondsPerTick_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(SetSecondsPerTick_QuantizationBoundary_PropertyAddress.Address, intPtr);
		FQuartzQuantizationBoundary.ToNative(IntPtr.Add(intPtr, SetSecondsPerTick_QuantizationBoundary_Offset), 0, SetSecondsPerTick_QuantizationBoundary_PropertyAddress.Address, QuantizationBoundary);
		FDelegateMarshaler<FOnQuartzCommandEventBP>.ToNative(IntPtr.Add(intPtr, SetSecondsPerTick_Delegate_Offset), 0, SetSecondsPerTick_Delegate_PropertyAddress.Address, Delegate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSecondsPerTick_SecondsPerTick_Offset), 0, SetSecondsPerTick_SecondsPerTick_PropertyAddress.Address, SecondsPerTick);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSecondsPerTick_FunctionAddress, intPtr, SetSecondsPerTick_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSecondsPerTick_QuantizationBoundary_PropertyAddress.Address, intPtr);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, SetSecondsPerTick_ClockHandle_Offset), 0, SetSecondsPerTick_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:SetMillisecondsPerTick")]
	public unsafe void SetMillisecondsPerTick(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, out UQuartzClockHandle ClockHandle, float MillisecondsPerTick = 100f)
	{
		CheckDestroyed();
		if (!SetMillisecondsPerTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:SetMillisecondsPerTick");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMillisecondsPerTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMillisecondsPerTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetMillisecondsPerTick_WorldContextObject_Offset), 0, SetMillisecondsPerTick_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(SetMillisecondsPerTick_QuantizationBoundary_PropertyAddress.Address, intPtr);
		FQuartzQuantizationBoundary.ToNative(IntPtr.Add(intPtr, SetMillisecondsPerTick_QuantizationBoundary_Offset), 0, SetMillisecondsPerTick_QuantizationBoundary_PropertyAddress.Address, QuantizationBoundary);
		FDelegateMarshaler<FOnQuartzCommandEventBP>.ToNative(IntPtr.Add(intPtr, SetMillisecondsPerTick_Delegate_Offset), 0, SetMillisecondsPerTick_Delegate_PropertyAddress.Address, Delegate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMillisecondsPerTick_MillisecondsPerTick_Offset), 0, SetMillisecondsPerTick_MillisecondsPerTick_PropertyAddress.Address, MillisecondsPerTick);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMillisecondsPerTick_FunctionAddress, intPtr, SetMillisecondsPerTick_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMillisecondsPerTick_QuantizationBoundary_PropertyAddress.Address, intPtr);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, SetMillisecondsPerTick_ClockHandle_Offset), 0, SetMillisecondsPerTick_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:SetBeatsPerMinute")]
	public unsafe void SetBeatsPerMinute(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, out UQuartzClockHandle ClockHandle, float BeatsPerMinute = 60f)
	{
		CheckDestroyed();
		if (!SetBeatsPerMinute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:SetBeatsPerMinute");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBeatsPerMinute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBeatsPerMinute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetBeatsPerMinute_WorldContextObject_Offset), 0, SetBeatsPerMinute_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(SetBeatsPerMinute_QuantizationBoundary_PropertyAddress.Address, intPtr);
		FQuartzQuantizationBoundary.ToNative(IntPtr.Add(intPtr, SetBeatsPerMinute_QuantizationBoundary_Offset), 0, SetBeatsPerMinute_QuantizationBoundary_PropertyAddress.Address, QuantizationBoundary);
		FDelegateMarshaler<FOnQuartzCommandEventBP>.ToNative(IntPtr.Add(intPtr, SetBeatsPerMinute_Delegate_Offset), 0, SetBeatsPerMinute_Delegate_PropertyAddress.Address, Delegate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBeatsPerMinute_BeatsPerMinute_Offset), 0, SetBeatsPerMinute_BeatsPerMinute_PropertyAddress.Address, BeatsPerMinute);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBeatsPerMinute_FunctionAddress, intPtr, SetBeatsPerMinute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBeatsPerMinute_QuantizationBoundary_PropertyAddress.Address, intPtr);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, SetBeatsPerMinute_ClockHandle_Offset), 0, SetBeatsPerMinute_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:ResumeClock")]
	public unsafe void ResumeClock(UObject WorldContextObject, out UQuartzClockHandle ClockHandle)
	{
		CheckDestroyed();
		if (!ResumeClock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:ResumeClock");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResumeClock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResumeClock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ResumeClock_WorldContextObject_Offset), 0, ResumeClock_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResumeClock_FunctionAddress, intPtr, ResumeClock_ParamsSize);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, ResumeClock_ClockHandle_Offset), 0, ResumeClock_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:ResetTransportQuantized")]
	public unsafe void ResetTransportQuantized(UObject WorldContextObject, FQuartzQuantizationBoundary InQuantizationBoundary, FOnQuartzCommandEventBP InDelegate, out UQuartzClockHandle ClockHandle)
	{
		CheckDestroyed();
		if (!ResetTransportQuantized_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:ResetTransportQuantized");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetTransportQuantized_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetTransportQuantized_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ResetTransportQuantized_WorldContextObject_Offset), 0, ResetTransportQuantized_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(ResetTransportQuantized_InQuantizationBoundary_PropertyAddress.Address, intPtr);
		FQuartzQuantizationBoundary.ToNative(IntPtr.Add(intPtr, ResetTransportQuantized_InQuantizationBoundary_Offset), 0, ResetTransportQuantized_InQuantizationBoundary_PropertyAddress.Address, InQuantizationBoundary);
		FDelegateMarshaler<FOnQuartzCommandEventBP>.ToNative(IntPtr.Add(intPtr, ResetTransportQuantized_InDelegate_Offset), 0, ResetTransportQuantized_InDelegate_PropertyAddress.Address, InDelegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetTransportQuantized_FunctionAddress, intPtr, ResetTransportQuantized_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResetTransportQuantized_InQuantizationBoundary_PropertyAddress.Address, intPtr);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, ResetTransportQuantized_ClockHandle_Offset), 0, ResetTransportQuantized_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:PauseClock")]
	public unsafe void PauseClock(UObject WorldContextObject, out UQuartzClockHandle ClockHandle)
	{
		CheckDestroyed();
		if (!PauseClock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:PauseClock");
			ClockHandle = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PauseClock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PauseClock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PauseClock_WorldContextObject_Offset), 0, PauseClock_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, PauseClock_FunctionAddress, intPtr, PauseClock_ParamsSize);
		ClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, PauseClock_ClockHandle_Offset), 0, PauseClock_ClockHandle_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:IsClockRunning")]
	public unsafe bool IsClockRunning(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!IsClockRunning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:IsClockRunning");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsClockRunning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsClockRunning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsClockRunning_WorldContextObject_Offset), 0, IsClockRunning_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsClockRunning_FunctionAddress, intPtr, IsClockRunning_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsClockRunning_ReturnValue_Offset), 0, IsClockRunning_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:GetTicksPerSecond")]
	public unsafe float GetTicksPerSecond(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!GetTicksPerSecond_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:GetTicksPerSecond");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTicksPerSecond_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTicksPerSecond_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetTicksPerSecond_WorldContextObject_Offset), 0, GetTicksPerSecond_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTicksPerSecond_FunctionAddress, intPtr, GetTicksPerSecond_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTicksPerSecond_ReturnValue_Offset), 0, GetTicksPerSecond_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:GetThirtySecondNotesPerMinute")]
	public unsafe float GetThirtySecondNotesPerMinute(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!GetThirtySecondNotesPerMinute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:GetThirtySecondNotesPerMinute");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetThirtySecondNotesPerMinute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetThirtySecondNotesPerMinute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetThirtySecondNotesPerMinute_WorldContextObject_Offset), 0, GetThirtySecondNotesPerMinute_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetThirtySecondNotesPerMinute_FunctionAddress, intPtr, GetThirtySecondNotesPerMinute_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetThirtySecondNotesPerMinute_ReturnValue_Offset), 0, GetThirtySecondNotesPerMinute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:GetSecondsPerTick")]
	public unsafe float GetSecondsPerTick(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!GetSecondsPerTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:GetSecondsPerTick");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSecondsPerTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSecondsPerTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetSecondsPerTick_WorldContextObject_Offset), 0, GetSecondsPerTick_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSecondsPerTick_FunctionAddress, intPtr, GetSecondsPerTick_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSecondsPerTick_ReturnValue_Offset), 0, GetSecondsPerTick_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:GetMillisecondsPerTick")]
	public unsafe float GetMillisecondsPerTick(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!GetMillisecondsPerTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:GetMillisecondsPerTick");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMillisecondsPerTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMillisecondsPerTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetMillisecondsPerTick_WorldContextObject_Offset), 0, GetMillisecondsPerTick_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMillisecondsPerTick_FunctionAddress, intPtr, GetMillisecondsPerTick_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMillisecondsPerTick_ReturnValue_Offset), 0, GetMillisecondsPerTick_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:GetEstimatedRunTime")]
	public unsafe float GetEstimatedRunTime(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!GetEstimatedRunTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:GetEstimatedRunTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEstimatedRunTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEstimatedRunTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetEstimatedRunTime_WorldContextObject_Offset), 0, GetEstimatedRunTime_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEstimatedRunTime_FunctionAddress, intPtr, GetEstimatedRunTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEstimatedRunTime_ReturnValue_Offset), 0, GetEstimatedRunTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:GetDurationOfQuantizationTypeInSeconds")]
	public unsafe float GetDurationOfQuantizationTypeInSeconds(UObject WorldContextObject, EQuartzCommandQuantization QuantizationType, float Multiplier = 1f)
	{
		CheckDestroyed();
		if (!GetDurationOfQuantizationTypeInSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:GetDurationOfQuantizationTypeInSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDurationOfQuantizationTypeInSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDurationOfQuantizationTypeInSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetDurationOfQuantizationTypeInSeconds_WorldContextObject_Offset), 0, GetDurationOfQuantizationTypeInSeconds_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		EnumMarshaler<EQuartzCommandQuantization>.ToNative(IntPtr.Add(intPtr, GetDurationOfQuantizationTypeInSeconds_QuantizationType_Offset), 0, GetDurationOfQuantizationTypeInSeconds_QuantizationType_PropertyAddress.Address, QuantizationType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDurationOfQuantizationTypeInSeconds_Multiplier_Offset), 0, GetDurationOfQuantizationTypeInSeconds_Multiplier_PropertyAddress.Address, Multiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDurationOfQuantizationTypeInSeconds_FunctionAddress, intPtr, GetDurationOfQuantizationTypeInSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDurationOfQuantizationTypeInSeconds_ReturnValue_Offset), 0, GetDurationOfQuantizationTypeInSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:GetCurrentTimestamp")]
	public unsafe FQuartzTransportTimeStamp GetCurrentTimestamp(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!GetCurrentTimestamp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:GetCurrentTimestamp");
			return default(FQuartzTransportTimeStamp);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentTimestamp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentTimestamp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetCurrentTimestamp_WorldContextObject_Offset), 0, GetCurrentTimestamp_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentTimestamp_FunctionAddress, intPtr, GetCurrentTimestamp_ParamsSize);
		return FQuartzTransportTimeStamp.FromNative(IntPtr.Add(intPtr, GetCurrentTimestamp_ReturnValue_Offset), 0, GetCurrentTimestamp_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AudioMixer.QuartzClockHandle:GetBeatsPerMinute")]
	public unsafe float GetBeatsPerMinute(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!GetBeatsPerMinute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.QuartzClockHandle:GetBeatsPerMinute");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBeatsPerMinute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBeatsPerMinute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetBeatsPerMinute_WorldContextObject_Offset), 0, GetBeatsPerMinute_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBeatsPerMinute_FunctionAddress, intPtr, GetBeatsPerMinute_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetBeatsPerMinute_ReturnValue_Offset), 0, GetBeatsPerMinute_ReturnValue_PropertyAddress.Address);
	}

	static UQuartzClockHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UQuartzClockHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UQuartzClockHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AudioMixer.QuartzClockHandle");
		UnsubscribeFromTimeDivision_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UnsubscribeFromTimeDivision");
		UnsubscribeFromTimeDivision_ParamsSize = NativeReflection.GetFunctionParamsSize(UnsubscribeFromTimeDivision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnsubscribeFromTimeDivision_WorldContextObject_PropertyAddress, UnsubscribeFromTimeDivision_FunctionAddress, "WorldContextObject");
		UnsubscribeFromTimeDivision_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(UnsubscribeFromTimeDivision_FunctionAddress, "WorldContextObject");
		UnsubscribeFromTimeDivision_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(UnsubscribeFromTimeDivision_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UnsubscribeFromTimeDivision_InQuantizationBoundary_PropertyAddress, UnsubscribeFromTimeDivision_FunctionAddress, "InQuantizationBoundary");
		UnsubscribeFromTimeDivision_InQuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(UnsubscribeFromTimeDivision_FunctionAddress, "InQuantizationBoundary");
		UnsubscribeFromTimeDivision_InQuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(UnsubscribeFromTimeDivision_FunctionAddress, "InQuantizationBoundary", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UnsubscribeFromTimeDivision_ClockHandle_PropertyAddress, UnsubscribeFromTimeDivision_FunctionAddress, "ClockHandle");
		UnsubscribeFromTimeDivision_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(UnsubscribeFromTimeDivision_FunctionAddress, "ClockHandle");
		UnsubscribeFromTimeDivision_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(UnsubscribeFromTimeDivision_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		UnsubscribeFromTimeDivision_IsValid = UnsubscribeFromTimeDivision_FunctionAddress != IntPtr.Zero && UnsubscribeFromTimeDivision_WorldContextObject_IsValid && UnsubscribeFromTimeDivision_InQuantizationBoundary_IsValid && UnsubscribeFromTimeDivision_ClockHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:UnsubscribeFromTimeDivision", UnsubscribeFromTimeDivision_IsValid);
		UnsubscribeFromAllTimeDivisions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UnsubscribeFromAllTimeDivisions");
		UnsubscribeFromAllTimeDivisions_ParamsSize = NativeReflection.GetFunctionParamsSize(UnsubscribeFromAllTimeDivisions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnsubscribeFromAllTimeDivisions_WorldContextObject_PropertyAddress, UnsubscribeFromAllTimeDivisions_FunctionAddress, "WorldContextObject");
		UnsubscribeFromAllTimeDivisions_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(UnsubscribeFromAllTimeDivisions_FunctionAddress, "WorldContextObject");
		UnsubscribeFromAllTimeDivisions_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(UnsubscribeFromAllTimeDivisions_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UnsubscribeFromAllTimeDivisions_ClockHandle_PropertyAddress, UnsubscribeFromAllTimeDivisions_FunctionAddress, "ClockHandle");
		UnsubscribeFromAllTimeDivisions_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(UnsubscribeFromAllTimeDivisions_FunctionAddress, "ClockHandle");
		UnsubscribeFromAllTimeDivisions_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(UnsubscribeFromAllTimeDivisions_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		UnsubscribeFromAllTimeDivisions_IsValid = UnsubscribeFromAllTimeDivisions_FunctionAddress != IntPtr.Zero && UnsubscribeFromAllTimeDivisions_WorldContextObject_IsValid && UnsubscribeFromAllTimeDivisions_ClockHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:UnsubscribeFromAllTimeDivisions", UnsubscribeFromAllTimeDivisions_IsValid);
		SubscribeToQuantizationEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SubscribeToQuantizationEvent");
		SubscribeToQuantizationEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(SubscribeToQuantizationEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToQuantizationEvent_WorldContextObject_PropertyAddress, SubscribeToQuantizationEvent_FunctionAddress, "WorldContextObject");
		SubscribeToQuantizationEvent_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToQuantizationEvent_FunctionAddress, "WorldContextObject");
		SubscribeToQuantizationEvent_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToQuantizationEvent_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToQuantizationEvent_InQuantizationBoundary_PropertyAddress, SubscribeToQuantizationEvent_FunctionAddress, "InQuantizationBoundary");
		SubscribeToQuantizationEvent_InQuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToQuantizationEvent_FunctionAddress, "InQuantizationBoundary");
		SubscribeToQuantizationEvent_InQuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToQuantizationEvent_FunctionAddress, "InQuantizationBoundary", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToQuantizationEvent_OnQuantizationEvent_PropertyAddress, SubscribeToQuantizationEvent_FunctionAddress, "OnQuantizationEvent");
		SubscribeToQuantizationEvent_OnQuantizationEvent_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToQuantizationEvent_FunctionAddress, "OnQuantizationEvent");
		SubscribeToQuantizationEvent_OnQuantizationEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToQuantizationEvent_FunctionAddress, "OnQuantizationEvent", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToQuantizationEvent_ClockHandle_PropertyAddress, SubscribeToQuantizationEvent_FunctionAddress, "ClockHandle");
		SubscribeToQuantizationEvent_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToQuantizationEvent_FunctionAddress, "ClockHandle");
		SubscribeToQuantizationEvent_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToQuantizationEvent_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		SubscribeToQuantizationEvent_IsValid = SubscribeToQuantizationEvent_FunctionAddress != IntPtr.Zero && SubscribeToQuantizationEvent_WorldContextObject_IsValid && SubscribeToQuantizationEvent_InQuantizationBoundary_IsValid && SubscribeToQuantizationEvent_OnQuantizationEvent_IsValid && SubscribeToQuantizationEvent_ClockHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:SubscribeToQuantizationEvent", SubscribeToQuantizationEvent_IsValid);
		SubscribeToAllQuantizationEvents_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SubscribeToAllQuantizationEvents");
		SubscribeToAllQuantizationEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(SubscribeToAllQuantizationEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToAllQuantizationEvents_WorldContextObject_PropertyAddress, SubscribeToAllQuantizationEvents_FunctionAddress, "WorldContextObject");
		SubscribeToAllQuantizationEvents_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToAllQuantizationEvents_FunctionAddress, "WorldContextObject");
		SubscribeToAllQuantizationEvents_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToAllQuantizationEvents_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToAllQuantizationEvents_OnQuantizationEvent_PropertyAddress, SubscribeToAllQuantizationEvents_FunctionAddress, "OnQuantizationEvent");
		SubscribeToAllQuantizationEvents_OnQuantizationEvent_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToAllQuantizationEvents_FunctionAddress, "OnQuantizationEvent");
		SubscribeToAllQuantizationEvents_OnQuantizationEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToAllQuantizationEvents_FunctionAddress, "OnQuantizationEvent", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToAllQuantizationEvents_ClockHandle_PropertyAddress, SubscribeToAllQuantizationEvents_FunctionAddress, "ClockHandle");
		SubscribeToAllQuantizationEvents_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToAllQuantizationEvents_FunctionAddress, "ClockHandle");
		SubscribeToAllQuantizationEvents_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToAllQuantizationEvents_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		SubscribeToAllQuantizationEvents_IsValid = SubscribeToAllQuantizationEvents_FunctionAddress != IntPtr.Zero && SubscribeToAllQuantizationEvents_WorldContextObject_IsValid && SubscribeToAllQuantizationEvents_OnQuantizationEvent_IsValid && SubscribeToAllQuantizationEvents_ClockHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:SubscribeToAllQuantizationEvents", SubscribeToAllQuantizationEvents_IsValid);
		StopClock_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopClock");
		StopClock_ParamsSize = NativeReflection.GetFunctionParamsSize(StopClock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopClock_WorldContextObject_PropertyAddress, StopClock_FunctionAddress, "WorldContextObject");
		StopClock_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StopClock_FunctionAddress, "WorldContextObject");
		StopClock_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StopClock_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopClock_CancelPendingEvents_PropertyAddress, StopClock_FunctionAddress, "CancelPendingEvents");
		StopClock_CancelPendingEvents_Offset = NativeReflectionCached.GetPropertyOffset(StopClock_FunctionAddress, "CancelPendingEvents");
		StopClock_CancelPendingEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(StopClock_FunctionAddress, "CancelPendingEvents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StopClock_ClockHandle_PropertyAddress, StopClock_FunctionAddress, "ClockHandle");
		StopClock_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(StopClock_FunctionAddress, "ClockHandle");
		StopClock_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(StopClock_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		StopClock_IsValid = StopClock_FunctionAddress != IntPtr.Zero && StopClock_WorldContextObject_IsValid && StopClock_CancelPendingEvents_IsValid && StopClock_ClockHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:StopClock", StopClock_IsValid);
		StartOtherClock_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartOtherClock");
		StartOtherClock_ParamsSize = NativeReflection.GetFunctionParamsSize(StartOtherClock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartOtherClock_WorldContextObject_PropertyAddress, StartOtherClock_FunctionAddress, "WorldContextObject");
		StartOtherClock_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartOtherClock_FunctionAddress, "WorldContextObject");
		StartOtherClock_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartOtherClock_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartOtherClock_OtherClockName_PropertyAddress, StartOtherClock_FunctionAddress, "OtherClockName");
		StartOtherClock_OtherClockName_Offset = NativeReflectionCached.GetPropertyOffset(StartOtherClock_FunctionAddress, "OtherClockName");
		StartOtherClock_OtherClockName_IsValid = NativeReflectionCached.ValidatePropertyClass(StartOtherClock_FunctionAddress, "OtherClockName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref StartOtherClock_InQuantizationBoundary_PropertyAddress, StartOtherClock_FunctionAddress, "InQuantizationBoundary");
		StartOtherClock_InQuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(StartOtherClock_FunctionAddress, "InQuantizationBoundary");
		StartOtherClock_InQuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(StartOtherClock_FunctionAddress, "InQuantizationBoundary", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StartOtherClock_InDelegate_PropertyAddress, StartOtherClock_FunctionAddress, "InDelegate");
		StartOtherClock_InDelegate_Offset = NativeReflectionCached.GetPropertyOffset(StartOtherClock_FunctionAddress, "InDelegate");
		StartOtherClock_InDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(StartOtherClock_FunctionAddress, "InDelegate", Classes.FDelegateProperty);
		StartOtherClock_IsValid = StartOtherClock_FunctionAddress != IntPtr.Zero && StartOtherClock_WorldContextObject_IsValid && StartOtherClock_OtherClockName_IsValid && StartOtherClock_InQuantizationBoundary_IsValid && StartOtherClock_InDelegate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:StartOtherClock", StartOtherClock_IsValid);
		StartClock_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartClock");
		StartClock_ParamsSize = NativeReflection.GetFunctionParamsSize(StartClock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartClock_WorldContextObject_PropertyAddress, StartClock_FunctionAddress, "WorldContextObject");
		StartClock_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartClock_FunctionAddress, "WorldContextObject");
		StartClock_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartClock_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartClock_ClockHandle_PropertyAddress, StartClock_FunctionAddress, "ClockHandle");
		StartClock_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(StartClock_FunctionAddress, "ClockHandle");
		StartClock_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(StartClock_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		StartClock_IsValid = StartClock_FunctionAddress != IntPtr.Zero && StartClock_WorldContextObject_IsValid && StartClock_ClockHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:StartClock", StartClock_IsValid);
		SetTicksPerSecond_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTicksPerSecond");
		SetTicksPerSecond_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTicksPerSecond_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTicksPerSecond_WorldContextObject_PropertyAddress, SetTicksPerSecond_FunctionAddress, "WorldContextObject");
		SetTicksPerSecond_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetTicksPerSecond_FunctionAddress, "WorldContextObject");
		SetTicksPerSecond_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTicksPerSecond_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTicksPerSecond_QuantizationBoundary_PropertyAddress, SetTicksPerSecond_FunctionAddress, "QuantizationBoundary");
		SetTicksPerSecond_QuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(SetTicksPerSecond_FunctionAddress, "QuantizationBoundary");
		SetTicksPerSecond_QuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTicksPerSecond_FunctionAddress, "QuantizationBoundary", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTicksPerSecond_Delegate_PropertyAddress, SetTicksPerSecond_FunctionAddress, "Delegate");
		SetTicksPerSecond_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(SetTicksPerSecond_FunctionAddress, "Delegate");
		SetTicksPerSecond_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTicksPerSecond_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTicksPerSecond_ClockHandle_PropertyAddress, SetTicksPerSecond_FunctionAddress, "ClockHandle");
		SetTicksPerSecond_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(SetTicksPerSecond_FunctionAddress, "ClockHandle");
		SetTicksPerSecond_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTicksPerSecond_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTicksPerSecond_TicksPerSecond_PropertyAddress, SetTicksPerSecond_FunctionAddress, "TicksPerSecond");
		SetTicksPerSecond_TicksPerSecond_Offset = NativeReflectionCached.GetPropertyOffset(SetTicksPerSecond_FunctionAddress, "TicksPerSecond");
		SetTicksPerSecond_TicksPerSecond_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTicksPerSecond_FunctionAddress, "TicksPerSecond", Classes.FFloatProperty);
		SetTicksPerSecond_IsValid = SetTicksPerSecond_FunctionAddress != IntPtr.Zero && SetTicksPerSecond_WorldContextObject_IsValid && SetTicksPerSecond_QuantizationBoundary_IsValid && SetTicksPerSecond_Delegate_IsValid && SetTicksPerSecond_ClockHandle_IsValid && SetTicksPerSecond_TicksPerSecond_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:SetTicksPerSecond", SetTicksPerSecond_IsValid);
		SetThirtySecondNotesPerMinute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetThirtySecondNotesPerMinute");
		SetThirtySecondNotesPerMinute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetThirtySecondNotesPerMinute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetThirtySecondNotesPerMinute_WorldContextObject_PropertyAddress, SetThirtySecondNotesPerMinute_FunctionAddress, "WorldContextObject");
		SetThirtySecondNotesPerMinute_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetThirtySecondNotesPerMinute_FunctionAddress, "WorldContextObject");
		SetThirtySecondNotesPerMinute_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThirtySecondNotesPerMinute_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetThirtySecondNotesPerMinute_QuantizationBoundary_PropertyAddress, SetThirtySecondNotesPerMinute_FunctionAddress, "QuantizationBoundary");
		SetThirtySecondNotesPerMinute_QuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(SetThirtySecondNotesPerMinute_FunctionAddress, "QuantizationBoundary");
		SetThirtySecondNotesPerMinute_QuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThirtySecondNotesPerMinute_FunctionAddress, "QuantizationBoundary", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetThirtySecondNotesPerMinute_Delegate_PropertyAddress, SetThirtySecondNotesPerMinute_FunctionAddress, "Delegate");
		SetThirtySecondNotesPerMinute_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(SetThirtySecondNotesPerMinute_FunctionAddress, "Delegate");
		SetThirtySecondNotesPerMinute_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThirtySecondNotesPerMinute_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SetThirtySecondNotesPerMinute_ClockHandle_PropertyAddress, SetThirtySecondNotesPerMinute_FunctionAddress, "ClockHandle");
		SetThirtySecondNotesPerMinute_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(SetThirtySecondNotesPerMinute_FunctionAddress, "ClockHandle");
		SetThirtySecondNotesPerMinute_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThirtySecondNotesPerMinute_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetThirtySecondNotesPerMinute_ThirtySecondsNotesPerMinute_PropertyAddress, SetThirtySecondNotesPerMinute_FunctionAddress, "ThirtySecondsNotesPerMinute");
		SetThirtySecondNotesPerMinute_ThirtySecondsNotesPerMinute_Offset = NativeReflectionCached.GetPropertyOffset(SetThirtySecondNotesPerMinute_FunctionAddress, "ThirtySecondsNotesPerMinute");
		SetThirtySecondNotesPerMinute_ThirtySecondsNotesPerMinute_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThirtySecondNotesPerMinute_FunctionAddress, "ThirtySecondsNotesPerMinute", Classes.FFloatProperty);
		SetThirtySecondNotesPerMinute_IsValid = SetThirtySecondNotesPerMinute_FunctionAddress != IntPtr.Zero && SetThirtySecondNotesPerMinute_WorldContextObject_IsValid && SetThirtySecondNotesPerMinute_QuantizationBoundary_IsValid && SetThirtySecondNotesPerMinute_Delegate_IsValid && SetThirtySecondNotesPerMinute_ClockHandle_IsValid && SetThirtySecondNotesPerMinute_ThirtySecondsNotesPerMinute_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:SetThirtySecondNotesPerMinute", SetThirtySecondNotesPerMinute_IsValid);
		SetSecondsPerTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSecondsPerTick");
		SetSecondsPerTick_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSecondsPerTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSecondsPerTick_WorldContextObject_PropertyAddress, SetSecondsPerTick_FunctionAddress, "WorldContextObject");
		SetSecondsPerTick_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetSecondsPerTick_FunctionAddress, "WorldContextObject");
		SetSecondsPerTick_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSecondsPerTick_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSecondsPerTick_QuantizationBoundary_PropertyAddress, SetSecondsPerTick_FunctionAddress, "QuantizationBoundary");
		SetSecondsPerTick_QuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(SetSecondsPerTick_FunctionAddress, "QuantizationBoundary");
		SetSecondsPerTick_QuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSecondsPerTick_FunctionAddress, "QuantizationBoundary", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSecondsPerTick_Delegate_PropertyAddress, SetSecondsPerTick_FunctionAddress, "Delegate");
		SetSecondsPerTick_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(SetSecondsPerTick_FunctionAddress, "Delegate");
		SetSecondsPerTick_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSecondsPerTick_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSecondsPerTick_ClockHandle_PropertyAddress, SetSecondsPerTick_FunctionAddress, "ClockHandle");
		SetSecondsPerTick_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(SetSecondsPerTick_FunctionAddress, "ClockHandle");
		SetSecondsPerTick_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSecondsPerTick_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSecondsPerTick_SecondsPerTick_PropertyAddress, SetSecondsPerTick_FunctionAddress, "SecondsPerTick");
		SetSecondsPerTick_SecondsPerTick_Offset = NativeReflectionCached.GetPropertyOffset(SetSecondsPerTick_FunctionAddress, "SecondsPerTick");
		SetSecondsPerTick_SecondsPerTick_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSecondsPerTick_FunctionAddress, "SecondsPerTick", Classes.FFloatProperty);
		SetSecondsPerTick_IsValid = SetSecondsPerTick_FunctionAddress != IntPtr.Zero && SetSecondsPerTick_WorldContextObject_IsValid && SetSecondsPerTick_QuantizationBoundary_IsValid && SetSecondsPerTick_Delegate_IsValid && SetSecondsPerTick_ClockHandle_IsValid && SetSecondsPerTick_SecondsPerTick_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:SetSecondsPerTick", SetSecondsPerTick_IsValid);
		SetMillisecondsPerTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMillisecondsPerTick");
		SetMillisecondsPerTick_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMillisecondsPerTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMillisecondsPerTick_WorldContextObject_PropertyAddress, SetMillisecondsPerTick_FunctionAddress, "WorldContextObject");
		SetMillisecondsPerTick_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetMillisecondsPerTick_FunctionAddress, "WorldContextObject");
		SetMillisecondsPerTick_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMillisecondsPerTick_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMillisecondsPerTick_QuantizationBoundary_PropertyAddress, SetMillisecondsPerTick_FunctionAddress, "QuantizationBoundary");
		SetMillisecondsPerTick_QuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(SetMillisecondsPerTick_FunctionAddress, "QuantizationBoundary");
		SetMillisecondsPerTick_QuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMillisecondsPerTick_FunctionAddress, "QuantizationBoundary", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMillisecondsPerTick_Delegate_PropertyAddress, SetMillisecondsPerTick_FunctionAddress, "Delegate");
		SetMillisecondsPerTick_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(SetMillisecondsPerTick_FunctionAddress, "Delegate");
		SetMillisecondsPerTick_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMillisecondsPerTick_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMillisecondsPerTick_ClockHandle_PropertyAddress, SetMillisecondsPerTick_FunctionAddress, "ClockHandle");
		SetMillisecondsPerTick_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(SetMillisecondsPerTick_FunctionAddress, "ClockHandle");
		SetMillisecondsPerTick_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMillisecondsPerTick_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMillisecondsPerTick_MillisecondsPerTick_PropertyAddress, SetMillisecondsPerTick_FunctionAddress, "MillisecondsPerTick");
		SetMillisecondsPerTick_MillisecondsPerTick_Offset = NativeReflectionCached.GetPropertyOffset(SetMillisecondsPerTick_FunctionAddress, "MillisecondsPerTick");
		SetMillisecondsPerTick_MillisecondsPerTick_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMillisecondsPerTick_FunctionAddress, "MillisecondsPerTick", Classes.FFloatProperty);
		SetMillisecondsPerTick_IsValid = SetMillisecondsPerTick_FunctionAddress != IntPtr.Zero && SetMillisecondsPerTick_WorldContextObject_IsValid && SetMillisecondsPerTick_QuantizationBoundary_IsValid && SetMillisecondsPerTick_Delegate_IsValid && SetMillisecondsPerTick_ClockHandle_IsValid && SetMillisecondsPerTick_MillisecondsPerTick_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:SetMillisecondsPerTick", SetMillisecondsPerTick_IsValid);
		SetBeatsPerMinute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBeatsPerMinute");
		SetBeatsPerMinute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBeatsPerMinute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBeatsPerMinute_WorldContextObject_PropertyAddress, SetBeatsPerMinute_FunctionAddress, "WorldContextObject");
		SetBeatsPerMinute_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetBeatsPerMinute_FunctionAddress, "WorldContextObject");
		SetBeatsPerMinute_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeatsPerMinute_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeatsPerMinute_QuantizationBoundary_PropertyAddress, SetBeatsPerMinute_FunctionAddress, "QuantizationBoundary");
		SetBeatsPerMinute_QuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(SetBeatsPerMinute_FunctionAddress, "QuantizationBoundary");
		SetBeatsPerMinute_QuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeatsPerMinute_FunctionAddress, "QuantizationBoundary", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeatsPerMinute_Delegate_PropertyAddress, SetBeatsPerMinute_FunctionAddress, "Delegate");
		SetBeatsPerMinute_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(SetBeatsPerMinute_FunctionAddress, "Delegate");
		SetBeatsPerMinute_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeatsPerMinute_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeatsPerMinute_ClockHandle_PropertyAddress, SetBeatsPerMinute_FunctionAddress, "ClockHandle");
		SetBeatsPerMinute_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(SetBeatsPerMinute_FunctionAddress, "ClockHandle");
		SetBeatsPerMinute_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeatsPerMinute_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeatsPerMinute_BeatsPerMinute_PropertyAddress, SetBeatsPerMinute_FunctionAddress, "BeatsPerMinute");
		SetBeatsPerMinute_BeatsPerMinute_Offset = NativeReflectionCached.GetPropertyOffset(SetBeatsPerMinute_FunctionAddress, "BeatsPerMinute");
		SetBeatsPerMinute_BeatsPerMinute_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeatsPerMinute_FunctionAddress, "BeatsPerMinute", Classes.FFloatProperty);
		SetBeatsPerMinute_IsValid = SetBeatsPerMinute_FunctionAddress != IntPtr.Zero && SetBeatsPerMinute_WorldContextObject_IsValid && SetBeatsPerMinute_QuantizationBoundary_IsValid && SetBeatsPerMinute_Delegate_IsValid && SetBeatsPerMinute_ClockHandle_IsValid && SetBeatsPerMinute_BeatsPerMinute_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:SetBeatsPerMinute", SetBeatsPerMinute_IsValid);
		ResumeClock_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResumeClock");
		ResumeClock_ParamsSize = NativeReflection.GetFunctionParamsSize(ResumeClock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResumeClock_WorldContextObject_PropertyAddress, ResumeClock_FunctionAddress, "WorldContextObject");
		ResumeClock_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ResumeClock_FunctionAddress, "WorldContextObject");
		ResumeClock_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ResumeClock_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResumeClock_ClockHandle_PropertyAddress, ResumeClock_FunctionAddress, "ClockHandle");
		ResumeClock_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(ResumeClock_FunctionAddress, "ClockHandle");
		ResumeClock_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(ResumeClock_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		ResumeClock_IsValid = ResumeClock_FunctionAddress != IntPtr.Zero && ResumeClock_WorldContextObject_IsValid && ResumeClock_ClockHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:ResumeClock", ResumeClock_IsValid);
		ResetTransportQuantized_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetTransportQuantized");
		ResetTransportQuantized_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetTransportQuantized_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetTransportQuantized_WorldContextObject_PropertyAddress, ResetTransportQuantized_FunctionAddress, "WorldContextObject");
		ResetTransportQuantized_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ResetTransportQuantized_FunctionAddress, "WorldContextObject");
		ResetTransportQuantized_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetTransportQuantized_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetTransportQuantized_InQuantizationBoundary_PropertyAddress, ResetTransportQuantized_FunctionAddress, "InQuantizationBoundary");
		ResetTransportQuantized_InQuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(ResetTransportQuantized_FunctionAddress, "InQuantizationBoundary");
		ResetTransportQuantized_InQuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetTransportQuantized_FunctionAddress, "InQuantizationBoundary", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetTransportQuantized_InDelegate_PropertyAddress, ResetTransportQuantized_FunctionAddress, "InDelegate");
		ResetTransportQuantized_InDelegate_Offset = NativeReflectionCached.GetPropertyOffset(ResetTransportQuantized_FunctionAddress, "InDelegate");
		ResetTransportQuantized_InDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetTransportQuantized_FunctionAddress, "InDelegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetTransportQuantized_ClockHandle_PropertyAddress, ResetTransportQuantized_FunctionAddress, "ClockHandle");
		ResetTransportQuantized_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(ResetTransportQuantized_FunctionAddress, "ClockHandle");
		ResetTransportQuantized_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetTransportQuantized_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		ResetTransportQuantized_IsValid = ResetTransportQuantized_FunctionAddress != IntPtr.Zero && ResetTransportQuantized_WorldContextObject_IsValid && ResetTransportQuantized_InQuantizationBoundary_IsValid && ResetTransportQuantized_InDelegate_IsValid && ResetTransportQuantized_ClockHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:ResetTransportQuantized", ResetTransportQuantized_IsValid);
		PauseClock_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PauseClock");
		PauseClock_ParamsSize = NativeReflection.GetFunctionParamsSize(PauseClock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PauseClock_WorldContextObject_PropertyAddress, PauseClock_FunctionAddress, "WorldContextObject");
		PauseClock_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(PauseClock_FunctionAddress, "WorldContextObject");
		PauseClock_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseClock_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PauseClock_ClockHandle_PropertyAddress, PauseClock_FunctionAddress, "ClockHandle");
		PauseClock_ClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(PauseClock_FunctionAddress, "ClockHandle");
		PauseClock_ClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseClock_FunctionAddress, "ClockHandle", Classes.FObjectProperty);
		PauseClock_IsValid = PauseClock_FunctionAddress != IntPtr.Zero && PauseClock_WorldContextObject_IsValid && PauseClock_ClockHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:PauseClock", PauseClock_IsValid);
		IsClockRunning_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsClockRunning");
		IsClockRunning_ParamsSize = NativeReflection.GetFunctionParamsSize(IsClockRunning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsClockRunning_WorldContextObject_PropertyAddress, IsClockRunning_FunctionAddress, "WorldContextObject");
		IsClockRunning_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(IsClockRunning_FunctionAddress, "WorldContextObject");
		IsClockRunning_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(IsClockRunning_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsClockRunning_ReturnValue_PropertyAddress, IsClockRunning_FunctionAddress, "ReturnValue");
		IsClockRunning_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsClockRunning_FunctionAddress, "ReturnValue");
		IsClockRunning_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsClockRunning_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsClockRunning_IsValid = IsClockRunning_FunctionAddress != IntPtr.Zero && IsClockRunning_WorldContextObject_IsValid && IsClockRunning_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:IsClockRunning", IsClockRunning_IsValid);
		GetTicksPerSecond_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTicksPerSecond");
		GetTicksPerSecond_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTicksPerSecond_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTicksPerSecond_WorldContextObject_PropertyAddress, GetTicksPerSecond_FunctionAddress, "WorldContextObject");
		GetTicksPerSecond_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetTicksPerSecond_FunctionAddress, "WorldContextObject");
		GetTicksPerSecond_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTicksPerSecond_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTicksPerSecond_ReturnValue_PropertyAddress, GetTicksPerSecond_FunctionAddress, "ReturnValue");
		GetTicksPerSecond_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTicksPerSecond_FunctionAddress, "ReturnValue");
		GetTicksPerSecond_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTicksPerSecond_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTicksPerSecond_IsValid = GetTicksPerSecond_FunctionAddress != IntPtr.Zero && GetTicksPerSecond_WorldContextObject_IsValid && GetTicksPerSecond_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:GetTicksPerSecond", GetTicksPerSecond_IsValid);
		GetThirtySecondNotesPerMinute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetThirtySecondNotesPerMinute");
		GetThirtySecondNotesPerMinute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetThirtySecondNotesPerMinute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetThirtySecondNotesPerMinute_WorldContextObject_PropertyAddress, GetThirtySecondNotesPerMinute_FunctionAddress, "WorldContextObject");
		GetThirtySecondNotesPerMinute_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetThirtySecondNotesPerMinute_FunctionAddress, "WorldContextObject");
		GetThirtySecondNotesPerMinute_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetThirtySecondNotesPerMinute_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetThirtySecondNotesPerMinute_ReturnValue_PropertyAddress, GetThirtySecondNotesPerMinute_FunctionAddress, "ReturnValue");
		GetThirtySecondNotesPerMinute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetThirtySecondNotesPerMinute_FunctionAddress, "ReturnValue");
		GetThirtySecondNotesPerMinute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetThirtySecondNotesPerMinute_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetThirtySecondNotesPerMinute_IsValid = GetThirtySecondNotesPerMinute_FunctionAddress != IntPtr.Zero && GetThirtySecondNotesPerMinute_WorldContextObject_IsValid && GetThirtySecondNotesPerMinute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:GetThirtySecondNotesPerMinute", GetThirtySecondNotesPerMinute_IsValid);
		GetSecondsPerTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSecondsPerTick");
		GetSecondsPerTick_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSecondsPerTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSecondsPerTick_WorldContextObject_PropertyAddress, GetSecondsPerTick_FunctionAddress, "WorldContextObject");
		GetSecondsPerTick_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetSecondsPerTick_FunctionAddress, "WorldContextObject");
		GetSecondsPerTick_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSecondsPerTick_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSecondsPerTick_ReturnValue_PropertyAddress, GetSecondsPerTick_FunctionAddress, "ReturnValue");
		GetSecondsPerTick_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSecondsPerTick_FunctionAddress, "ReturnValue");
		GetSecondsPerTick_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSecondsPerTick_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSecondsPerTick_IsValid = GetSecondsPerTick_FunctionAddress != IntPtr.Zero && GetSecondsPerTick_WorldContextObject_IsValid && GetSecondsPerTick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:GetSecondsPerTick", GetSecondsPerTick_IsValid);
		GetMillisecondsPerTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMillisecondsPerTick");
		GetMillisecondsPerTick_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMillisecondsPerTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMillisecondsPerTick_WorldContextObject_PropertyAddress, GetMillisecondsPerTick_FunctionAddress, "WorldContextObject");
		GetMillisecondsPerTick_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetMillisecondsPerTick_FunctionAddress, "WorldContextObject");
		GetMillisecondsPerTick_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMillisecondsPerTick_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMillisecondsPerTick_ReturnValue_PropertyAddress, GetMillisecondsPerTick_FunctionAddress, "ReturnValue");
		GetMillisecondsPerTick_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMillisecondsPerTick_FunctionAddress, "ReturnValue");
		GetMillisecondsPerTick_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMillisecondsPerTick_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMillisecondsPerTick_IsValid = GetMillisecondsPerTick_FunctionAddress != IntPtr.Zero && GetMillisecondsPerTick_WorldContextObject_IsValid && GetMillisecondsPerTick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:GetMillisecondsPerTick", GetMillisecondsPerTick_IsValid);
		GetEstimatedRunTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEstimatedRunTime");
		GetEstimatedRunTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEstimatedRunTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEstimatedRunTime_WorldContextObject_PropertyAddress, GetEstimatedRunTime_FunctionAddress, "WorldContextObject");
		GetEstimatedRunTime_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetEstimatedRunTime_FunctionAddress, "WorldContextObject");
		GetEstimatedRunTime_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEstimatedRunTime_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEstimatedRunTime_ReturnValue_PropertyAddress, GetEstimatedRunTime_FunctionAddress, "ReturnValue");
		GetEstimatedRunTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEstimatedRunTime_FunctionAddress, "ReturnValue");
		GetEstimatedRunTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEstimatedRunTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEstimatedRunTime_IsValid = GetEstimatedRunTime_FunctionAddress != IntPtr.Zero && GetEstimatedRunTime_WorldContextObject_IsValid && GetEstimatedRunTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:GetEstimatedRunTime", GetEstimatedRunTime_IsValid);
		GetDurationOfQuantizationTypeInSeconds_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDurationOfQuantizationTypeInSeconds");
		GetDurationOfQuantizationTypeInSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDurationOfQuantizationTypeInSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDurationOfQuantizationTypeInSeconds_WorldContextObject_PropertyAddress, GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "WorldContextObject");
		GetDurationOfQuantizationTypeInSeconds_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "WorldContextObject");
		GetDurationOfQuantizationTypeInSeconds_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDurationOfQuantizationTypeInSeconds_QuantizationType_PropertyAddress, GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "QuantizationType");
		GetDurationOfQuantizationTypeInSeconds_QuantizationType_Offset = NativeReflectionCached.GetPropertyOffset(GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "QuantizationType");
		GetDurationOfQuantizationTypeInSeconds_QuantizationType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "QuantizationType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDurationOfQuantizationTypeInSeconds_Multiplier_PropertyAddress, GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "Multiplier");
		GetDurationOfQuantizationTypeInSeconds_Multiplier_Offset = NativeReflectionCached.GetPropertyOffset(GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "Multiplier");
		GetDurationOfQuantizationTypeInSeconds_Multiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "Multiplier", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDurationOfQuantizationTypeInSeconds_ReturnValue_PropertyAddress, GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "ReturnValue");
		GetDurationOfQuantizationTypeInSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "ReturnValue");
		GetDurationOfQuantizationTypeInSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDurationOfQuantizationTypeInSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDurationOfQuantizationTypeInSeconds_IsValid = GetDurationOfQuantizationTypeInSeconds_FunctionAddress != IntPtr.Zero && GetDurationOfQuantizationTypeInSeconds_WorldContextObject_IsValid && GetDurationOfQuantizationTypeInSeconds_QuantizationType_IsValid && GetDurationOfQuantizationTypeInSeconds_Multiplier_IsValid && GetDurationOfQuantizationTypeInSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:GetDurationOfQuantizationTypeInSeconds", GetDurationOfQuantizationTypeInSeconds_IsValid);
		GetCurrentTimestamp_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCurrentTimestamp");
		GetCurrentTimestamp_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentTimestamp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentTimestamp_WorldContextObject_PropertyAddress, GetCurrentTimestamp_FunctionAddress, "WorldContextObject");
		GetCurrentTimestamp_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentTimestamp_FunctionAddress, "WorldContextObject");
		GetCurrentTimestamp_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentTimestamp_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentTimestamp_ReturnValue_PropertyAddress, GetCurrentTimestamp_FunctionAddress, "ReturnValue");
		GetCurrentTimestamp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentTimestamp_FunctionAddress, "ReturnValue");
		GetCurrentTimestamp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentTimestamp_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentTimestamp_IsValid = GetCurrentTimestamp_FunctionAddress != IntPtr.Zero && GetCurrentTimestamp_WorldContextObject_IsValid && GetCurrentTimestamp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:GetCurrentTimestamp", GetCurrentTimestamp_IsValid);
		GetBeatsPerMinute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBeatsPerMinute");
		GetBeatsPerMinute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBeatsPerMinute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBeatsPerMinute_WorldContextObject_PropertyAddress, GetBeatsPerMinute_FunctionAddress, "WorldContextObject");
		GetBeatsPerMinute_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetBeatsPerMinute_FunctionAddress, "WorldContextObject");
		GetBeatsPerMinute_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeatsPerMinute_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeatsPerMinute_ReturnValue_PropertyAddress, GetBeatsPerMinute_FunctionAddress, "ReturnValue");
		GetBeatsPerMinute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBeatsPerMinute_FunctionAddress, "ReturnValue");
		GetBeatsPerMinute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeatsPerMinute_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetBeatsPerMinute_IsValid = GetBeatsPerMinute_FunctionAddress != IntPtr.Zero && GetBeatsPerMinute_WorldContextObject_IsValid && GetBeatsPerMinute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.QuartzClockHandle:GetBeatsPerMinute", GetBeatsPerMinute_IsValid);
	}
}
