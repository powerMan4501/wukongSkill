using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820510884uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.TimelineComponent", "Engine", UnrealModuleType.Engine)]
public class UTimelineComponent : UActorComponent
{
	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetVectorCurve_IsValid;

	private static IntPtr SetVectorCurve_FunctionAddress;

	private static int SetVectorCurve_ParamsSize;

	private static bool SetVectorCurve_NewVectorCurve_IsValid;

	private static FFieldAddress SetVectorCurve_NewVectorCurve_PropertyAddress;

	private static int SetVectorCurve_NewVectorCurve_Offset;

	private static bool SetVectorCurve_VectorTrackName_IsValid;

	private static FFieldAddress SetVectorCurve_VectorTrackName_PropertyAddress;

	private static int SetVectorCurve_VectorTrackName_Offset;

	private static bool SetTimelineLengthMode_IsValid;

	private static IntPtr SetTimelineLengthMode_FunctionAddress;

	private static int SetTimelineLengthMode_ParamsSize;

	private static bool SetTimelineLengthMode_NewLengthMode_IsValid;

	private static FFieldAddress SetTimelineLengthMode_NewLengthMode_PropertyAddress;

	private static int SetTimelineLengthMode_NewLengthMode_Offset;

	private static bool SetTimelineLength_IsValid;

	private static IntPtr SetTimelineLength_FunctionAddress;

	private static int SetTimelineLength_ParamsSize;

	private static bool SetTimelineLength_NewLength_IsValid;

	private static FFieldAddress SetTimelineLength_NewLength_PropertyAddress;

	private static int SetTimelineLength_NewLength_Offset;

	private static bool SetPlayRate_IsValid;

	private static IntPtr SetPlayRate_FunctionAddress;

	private static int SetPlayRate_ParamsSize;

	private static bool SetPlayRate_NewRate_IsValid;

	private static FFieldAddress SetPlayRate_NewRate_PropertyAddress;

	private static int SetPlayRate_NewRate_Offset;

	private static bool SetPlaybackPosition_IsValid;

	private static IntPtr SetPlaybackPosition_FunctionAddress;

	private static int SetPlaybackPosition_ParamsSize;

	private static bool SetPlaybackPosition_NewPosition_IsValid;

	private static FFieldAddress SetPlaybackPosition_NewPosition_PropertyAddress;

	private static int SetPlaybackPosition_NewPosition_Offset;

	private static bool SetPlaybackPosition_bFireEvents_IsValid;

	private static FFieldAddress SetPlaybackPosition_bFireEvents_PropertyAddress;

	private static int SetPlaybackPosition_bFireEvents_Offset;

	private static bool SetPlaybackPosition_bFireUpdate_IsValid;

	private static FFieldAddress SetPlaybackPosition_bFireUpdate_PropertyAddress;

	private static int SetPlaybackPosition_bFireUpdate_Offset;

	private static bool SetNewTime_IsValid;

	private static IntPtr SetNewTime_FunctionAddress;

	private static int SetNewTime_ParamsSize;

	private static bool SetNewTime_NewTime_IsValid;

	private static FFieldAddress SetNewTime_NewTime_PropertyAddress;

	private static int SetNewTime_NewTime_Offset;

	private static bool SetLooping_IsValid;

	private static IntPtr SetLooping_FunctionAddress;

	private static int SetLooping_ParamsSize;

	private static bool SetLooping_bNewLooping_IsValid;

	private static FFieldAddress SetLooping_bNewLooping_PropertyAddress;

	private static int SetLooping_bNewLooping_Offset;

	private static bool SetLinearColorCurve_IsValid;

	private static IntPtr SetLinearColorCurve_FunctionAddress;

	private static int SetLinearColorCurve_ParamsSize;

	private static bool SetLinearColorCurve_NewLinearColorCurve_IsValid;

	private static FFieldAddress SetLinearColorCurve_NewLinearColorCurve_PropertyAddress;

	private static int SetLinearColorCurve_NewLinearColorCurve_Offset;

	private static bool SetLinearColorCurve_LinearColorTrackName_IsValid;

	private static FFieldAddress SetLinearColorCurve_LinearColorTrackName_PropertyAddress;

	private static int SetLinearColorCurve_LinearColorTrackName_Offset;

	private static bool SetIgnoreTimeDilation_IsValid;

	private static IntPtr SetIgnoreTimeDilation_FunctionAddress;

	private static int SetIgnoreTimeDilation_ParamsSize;

	private static bool SetIgnoreTimeDilation_bNewIgnoreTimeDilation_IsValid;

	private static FFieldAddress SetIgnoreTimeDilation_bNewIgnoreTimeDilation_PropertyAddress;

	private static int SetIgnoreTimeDilation_bNewIgnoreTimeDilation_Offset;

	private static bool SetFloatCurve_IsValid;

	private static IntPtr SetFloatCurve_FunctionAddress;

	private static int SetFloatCurve_ParamsSize;

	private static bool SetFloatCurve_NewFloatCurve_IsValid;

	private static FFieldAddress SetFloatCurve_NewFloatCurve_PropertyAddress;

	private static int SetFloatCurve_NewFloatCurve_Offset;

	private static bool SetFloatCurve_FloatTrackName_IsValid;

	private static FFieldAddress SetFloatCurve_FloatTrackName_PropertyAddress;

	private static int SetFloatCurve_FloatTrackName_Offset;

	private static bool ReverseFromEnd_IsValid;

	private static IntPtr ReverseFromEnd_FunctionAddress;

	private static int ReverseFromEnd_ParamsSize;

	private static bool Reverse_IsValid;

	private static IntPtr Reverse_FunctionAddress;

	private static int Reverse_ParamsSize;

	private static bool PlayFromStart_IsValid;

	private static IntPtr PlayFromStart_FunctionAddress;

	private static int PlayFromStart_ParamsSize;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool IsReversing_IsValid;

	private static IntPtr IsReversing_FunctionAddress;

	private static int IsReversing_ParamsSize;

	private static bool IsReversing_ReturnValue_IsValid;

	private static FFieldAddress IsReversing_ReturnValue_PropertyAddress;

	private static int IsReversing_ReturnValue_Offset;

	private static bool IsPlaying_IsValid;

	private static IntPtr IsPlaying_FunctionAddress;

	private static int IsPlaying_ParamsSize;

	private static bool IsPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsPlaying_ReturnValue_PropertyAddress;

	private static int IsPlaying_ReturnValue_Offset;

	private static bool IsLooping_IsValid;

	private static IntPtr IsLooping_FunctionAddress;

	private static int IsLooping_ParamsSize;

	private static bool IsLooping_ReturnValue_IsValid;

	private static FFieldAddress IsLooping_ReturnValue_PropertyAddress;

	private static int IsLooping_ReturnValue_Offset;

	private static bool GetTimelineLength_IsValid;

	private static IntPtr GetTimelineLength_FunctionAddress;

	private static int GetTimelineLength_ParamsSize;

	private static bool GetTimelineLength_ReturnValue_IsValid;

	private static FFieldAddress GetTimelineLength_ReturnValue_PropertyAddress;

	private static int GetTimelineLength_ReturnValue_Offset;

	private static bool GetScaledTimelineLength_IsValid;

	private static IntPtr GetScaledTimelineLength_FunctionAddress;

	private static int GetScaledTimelineLength_ParamsSize;

	private static bool GetScaledTimelineLength_ReturnValue_IsValid;

	private static FFieldAddress GetScaledTimelineLength_ReturnValue_PropertyAddress;

	private static int GetScaledTimelineLength_ReturnValue_Offset;

	private static bool GetPlayRate_IsValid;

	private static IntPtr GetPlayRate_FunctionAddress;

	private static int GetPlayRate_ParamsSize;

	private static bool GetPlayRate_ReturnValue_IsValid;

	private static FFieldAddress GetPlayRate_ReturnValue_PropertyAddress;

	private static int GetPlayRate_ReturnValue_Offset;

	private static bool GetPlaybackPosition_IsValid;

	private static IntPtr GetPlaybackPosition_FunctionAddress;

	private static int GetPlaybackPosition_ParamsSize;

	private static bool GetPlaybackPosition_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackPosition_ReturnValue_PropertyAddress;

	private static int GetPlaybackPosition_ReturnValue_Offset;

	private static bool GetIgnoreTimeDilation_IsValid;

	private static IntPtr GetIgnoreTimeDilation_FunctionAddress;

	private static int GetIgnoreTimeDilation_ParamsSize;

	private static bool GetIgnoreTimeDilation_ReturnValue_IsValid;

	private static FFieldAddress GetIgnoreTimeDilation_ReturnValue_PropertyAddress;

	private static int GetIgnoreTimeDilation_ReturnValue_Offset;

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetVectorCurve")]
	public unsafe void SetVectorCurve(UCurveVector NewVectorCurve, FName VectorTrackName)
	{
		CheckDestroyed();
		if (!SetVectorCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetVectorCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(intPtr, SetVectorCurve_NewVectorCurve_Offset), 0, SetVectorCurve_NewVectorCurve_PropertyAddress.Address, NewVectorCurve);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorCurve_VectorTrackName_Offset), 0, SetVectorCurve_VectorTrackName_PropertyAddress.Address, VectorTrackName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVectorCurve_FunctionAddress, intPtr, SetVectorCurve_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetTimelineLengthMode")]
	public unsafe void SetTimelineLengthMode(ETimelineLengthMode NewLengthMode)
	{
		CheckDestroyed();
		if (!SetTimelineLengthMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetTimelineLengthMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTimelineLengthMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTimelineLengthMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETimelineLengthMode>.ToNative(IntPtr.Add(intPtr, SetTimelineLengthMode_NewLengthMode_Offset), 0, SetTimelineLengthMode_NewLengthMode_PropertyAddress.Address, NewLengthMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTimelineLengthMode_FunctionAddress, intPtr, SetTimelineLengthMode_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetTimelineLength")]
	public unsafe void SetTimelineLength(float NewLength)
	{
		CheckDestroyed();
		if (!SetTimelineLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetTimelineLength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTimelineLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTimelineLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTimelineLength_NewLength_Offset), 0, SetTimelineLength_NewLength_PropertyAddress.Address, NewLength);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTimelineLength_FunctionAddress, intPtr, SetTimelineLength_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetPlayRate")]
	public unsafe void SetPlayRate(float NewRate)
	{
		CheckDestroyed();
		if (!SetPlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetPlayRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayRate_NewRate_Offset), 0, SetPlayRate_NewRate_PropertyAddress.Address, NewRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlayRate_FunctionAddress, intPtr, SetPlayRate_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetPlaybackPosition")]
	public unsafe void SetPlaybackPosition(float NewPosition, bool bFireEvents, bool bFireUpdate = true)
	{
		CheckDestroyed();
		if (!SetPlaybackPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetPlaybackPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaybackPosition_NewPosition_Offset), 0, SetPlaybackPosition_NewPosition_PropertyAddress.Address, NewPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPlaybackPosition_bFireEvents_Offset), 0, SetPlaybackPosition_bFireEvents_PropertyAddress.Address, bFireEvents);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPlaybackPosition_bFireUpdate_Offset), 0, SetPlaybackPosition_bFireUpdate_PropertyAddress.Address, bFireUpdate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaybackPosition_FunctionAddress, intPtr, SetPlaybackPosition_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetNewTime")]
	public unsafe void SetNewTime(float NewTime)
	{
		CheckDestroyed();
		if (!SetNewTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetNewTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNewTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNewTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNewTime_NewTime_Offset), 0, SetNewTime_NewTime_PropertyAddress.Address, NewTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNewTime_FunctionAddress, intPtr, SetNewTime_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetLooping")]
	public unsafe void SetLooping(bool bNewLooping)
	{
		CheckDestroyed();
		if (!SetLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetLooping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLooping_bNewLooping_Offset), 0, SetLooping_bNewLooping_PropertyAddress.Address, bNewLooping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLooping_FunctionAddress, intPtr, SetLooping_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetLinearColorCurve")]
	public unsafe void SetLinearColorCurve(UCurveLinearColor NewLinearColorCurve, FName LinearColorTrackName)
	{
		CheckDestroyed();
		if (!SetLinearColorCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetLinearColorCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearColorCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearColorCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(intPtr, SetLinearColorCurve_NewLinearColorCurve_Offset), 0, SetLinearColorCurve_NewLinearColorCurve_PropertyAddress.Address, NewLinearColorCurve);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLinearColorCurve_LinearColorTrackName_Offset), 0, SetLinearColorCurve_LinearColorTrackName_PropertyAddress.Address, LinearColorTrackName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearColorCurve_FunctionAddress, intPtr, SetLinearColorCurve_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetIgnoreTimeDilation")]
	public unsafe void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation)
	{
		CheckDestroyed();
		if (!SetIgnoreTimeDilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetIgnoreTimeDilation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIgnoreTimeDilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIgnoreTimeDilation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIgnoreTimeDilation_bNewIgnoreTimeDilation_Offset), 0, SetIgnoreTimeDilation_bNewIgnoreTimeDilation_PropertyAddress.Address, bNewIgnoreTimeDilation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIgnoreTimeDilation_FunctionAddress, intPtr, SetIgnoreTimeDilation_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:SetFloatCurve")]
	public unsafe void SetFloatCurve(UCurveFloat NewFloatCurve, FName FloatTrackName)
	{
		CheckDestroyed();
		if (!SetFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:SetFloatCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(intPtr, SetFloatCurve_NewFloatCurve_Offset), 0, SetFloatCurve_NewFloatCurve_PropertyAddress.Address, NewFloatCurve);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFloatCurve_FloatTrackName_Offset), 0, SetFloatCurve_FloatTrackName_PropertyAddress.Address, FloatTrackName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFloatCurve_FunctionAddress, intPtr, SetFloatCurve_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:ReverseFromEnd")]
	public unsafe void ReverseFromEnd()
	{
		CheckDestroyed();
		if (!ReverseFromEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:ReverseFromEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReverseFromEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReverseFromEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReverseFromEnd_FunctionAddress, argsSize: ReverseFromEnd_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:Reverse")]
	public unsafe void Reverse()
	{
		CheckDestroyed();
		if (!Reverse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:Reverse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reverse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reverse_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Reverse_FunctionAddress, argsSize: Reverse_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:PlayFromStart")]
	public unsafe void PlayFromStart()
	{
		CheckDestroyed();
		if (!PlayFromStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:PlayFromStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayFromStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayFromStart_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PlayFromStart_FunctionAddress, argsSize: PlayFromStart_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.TimelineComponent:Play")]
	public unsafe void Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Play_FunctionAddress, argsSize: Play_ParamsSize);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.TimelineComponent:IsReversing")]
	public unsafe bool IsReversing()
	{
		CheckDestroyed();
		if (!IsReversing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:IsReversing");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReversing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReversing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsReversing_FunctionAddress, intPtr, IsReversing_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReversing_ReturnValue_Offset), 0, IsReversing_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.TimelineComponent:IsPlaying")]
	public unsafe bool IsPlaying()
	{
		CheckDestroyed();
		if (!IsPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:IsPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlaying_FunctionAddress, intPtr, IsPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlaying_ReturnValue_Offset), 0, IsPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.TimelineComponent:IsLooping")]
	public unsafe bool IsLooping()
	{
		CheckDestroyed();
		if (!IsLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:IsLooping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLooping_FunctionAddress, intPtr, IsLooping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLooping_ReturnValue_Offset), 0, IsLooping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.TimelineComponent:GetTimelineLength")]
	public unsafe float GetTimelineLength()
	{
		CheckDestroyed();
		if (!GetTimelineLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:GetTimelineLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimelineLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimelineLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTimelineLength_FunctionAddress, intPtr, GetTimelineLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTimelineLength_ReturnValue_Offset), 0, GetTimelineLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.TimelineComponent:GetScaledTimelineLength")]
	public unsafe float GetScaledTimelineLength()
	{
		CheckDestroyed();
		if (!GetScaledTimelineLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:GetScaledTimelineLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaledTimelineLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaledTimelineLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaledTimelineLength_FunctionAddress, intPtr, GetScaledTimelineLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScaledTimelineLength_ReturnValue_Offset), 0, GetScaledTimelineLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.TimelineComponent:GetPlayRate")]
	public unsafe float GetPlayRate()
	{
		CheckDestroyed();
		if (!GetPlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:GetPlayRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayRate_FunctionAddress, intPtr, GetPlayRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlayRate_ReturnValue_Offset), 0, GetPlayRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.TimelineComponent:GetPlaybackPosition")]
	public unsafe float GetPlaybackPosition()
	{
		CheckDestroyed();
		if (!GetPlaybackPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:GetPlaybackPosition");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaybackPosition_FunctionAddress, intPtr, GetPlaybackPosition_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlaybackPosition_ReturnValue_Offset), 0, GetPlaybackPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.TimelineComponent:GetIgnoreTimeDilation")]
	public unsafe bool GetIgnoreTimeDilation()
	{
		CheckDestroyed();
		if (!GetIgnoreTimeDilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TimelineComponent:GetIgnoreTimeDilation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIgnoreTimeDilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIgnoreTimeDilation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIgnoreTimeDilation_FunctionAddress, intPtr, GetIgnoreTimeDilation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIgnoreTimeDilation_ReturnValue_Offset), 0, GetIgnoreTimeDilation_ReturnValue_PropertyAddress.Address);
	}

	static UTimelineComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTimelineComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTimelineComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.TimelineComponent");
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:Stop", Stop_IsValid);
		SetVectorCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVectorCurve");
		SetVectorCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorCurve_NewVectorCurve_PropertyAddress, SetVectorCurve_FunctionAddress, "NewVectorCurve");
		SetVectorCurve_NewVectorCurve_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorCurve_FunctionAddress, "NewVectorCurve");
		SetVectorCurve_NewVectorCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorCurve_FunctionAddress, "NewVectorCurve", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorCurve_VectorTrackName_PropertyAddress, SetVectorCurve_FunctionAddress, "VectorTrackName");
		SetVectorCurve_VectorTrackName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorCurve_FunctionAddress, "VectorTrackName");
		SetVectorCurve_VectorTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorCurve_FunctionAddress, "VectorTrackName", Classes.FNameProperty);
		SetVectorCurve_IsValid = SetVectorCurve_FunctionAddress != IntPtr.Zero && SetVectorCurve_NewVectorCurve_IsValid && SetVectorCurve_VectorTrackName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetVectorCurve", SetVectorCurve_IsValid);
		SetTimelineLengthMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTimelineLengthMode");
		SetTimelineLengthMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTimelineLengthMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTimelineLengthMode_NewLengthMode_PropertyAddress, SetTimelineLengthMode_FunctionAddress, "NewLengthMode");
		SetTimelineLengthMode_NewLengthMode_Offset = NativeReflectionCached.GetPropertyOffset(SetTimelineLengthMode_FunctionAddress, "NewLengthMode");
		SetTimelineLengthMode_NewLengthMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTimelineLengthMode_FunctionAddress, "NewLengthMode", Classes.FByteProperty);
		SetTimelineLengthMode_IsValid = SetTimelineLengthMode_FunctionAddress != IntPtr.Zero && SetTimelineLengthMode_NewLengthMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetTimelineLengthMode", SetTimelineLengthMode_IsValid);
		SetTimelineLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTimelineLength");
		SetTimelineLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTimelineLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTimelineLength_NewLength_PropertyAddress, SetTimelineLength_FunctionAddress, "NewLength");
		SetTimelineLength_NewLength_Offset = NativeReflectionCached.GetPropertyOffset(SetTimelineLength_FunctionAddress, "NewLength");
		SetTimelineLength_NewLength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTimelineLength_FunctionAddress, "NewLength", Classes.FFloatProperty);
		SetTimelineLength_IsValid = SetTimelineLength_FunctionAddress != IntPtr.Zero && SetTimelineLength_NewLength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetTimelineLength", SetTimelineLength_IsValid);
		SetPlayRate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPlayRate");
		SetPlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlayRate_NewRate_PropertyAddress, SetPlayRate_FunctionAddress, "NewRate");
		SetPlayRate_NewRate_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayRate_FunctionAddress, "NewRate");
		SetPlayRate_NewRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayRate_FunctionAddress, "NewRate", Classes.FFloatProperty);
		SetPlayRate_IsValid = SetPlayRate_FunctionAddress != IntPtr.Zero && SetPlayRate_NewRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetPlayRate", SetPlayRate_IsValid);
		SetPlaybackPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPlaybackPosition");
		SetPlaybackPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackPosition_NewPosition_PropertyAddress, SetPlaybackPosition_FunctionAddress, "NewPosition");
		SetPlaybackPosition_NewPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackPosition_FunctionAddress, "NewPosition");
		SetPlaybackPosition_NewPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackPosition_FunctionAddress, "NewPosition", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackPosition_bFireEvents_PropertyAddress, SetPlaybackPosition_FunctionAddress, "bFireEvents");
		SetPlaybackPosition_bFireEvents_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackPosition_FunctionAddress, "bFireEvents");
		SetPlaybackPosition_bFireEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackPosition_FunctionAddress, "bFireEvents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackPosition_bFireUpdate_PropertyAddress, SetPlaybackPosition_FunctionAddress, "bFireUpdate");
		SetPlaybackPosition_bFireUpdate_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackPosition_FunctionAddress, "bFireUpdate");
		SetPlaybackPosition_bFireUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackPosition_FunctionAddress, "bFireUpdate", Classes.FBoolProperty);
		SetPlaybackPosition_IsValid = SetPlaybackPosition_FunctionAddress != IntPtr.Zero && SetPlaybackPosition_NewPosition_IsValid && SetPlaybackPosition_bFireEvents_IsValid && SetPlaybackPosition_bFireUpdate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetPlaybackPosition", SetPlaybackPosition_IsValid);
		SetNewTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNewTime");
		SetNewTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNewTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNewTime_NewTime_PropertyAddress, SetNewTime_FunctionAddress, "NewTime");
		SetNewTime_NewTime_Offset = NativeReflectionCached.GetPropertyOffset(SetNewTime_FunctionAddress, "NewTime");
		SetNewTime_NewTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNewTime_FunctionAddress, "NewTime", Classes.FFloatProperty);
		SetNewTime_IsValid = SetNewTime_FunctionAddress != IntPtr.Zero && SetNewTime_NewTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetNewTime", SetNewTime_IsValid);
		SetLooping_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLooping");
		SetLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_bNewLooping_PropertyAddress, SetLooping_FunctionAddress, "bNewLooping");
		SetLooping_bNewLooping_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "bNewLooping");
		SetLooping_bNewLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "bNewLooping", Classes.FBoolProperty);
		SetLooping_IsValid = SetLooping_FunctionAddress != IntPtr.Zero && SetLooping_bNewLooping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetLooping", SetLooping_IsValid);
		SetLinearColorCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLinearColorCurve");
		SetLinearColorCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearColorCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearColorCurve_NewLinearColorCurve_PropertyAddress, SetLinearColorCurve_FunctionAddress, "NewLinearColorCurve");
		SetLinearColorCurve_NewLinearColorCurve_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearColorCurve_FunctionAddress, "NewLinearColorCurve");
		SetLinearColorCurve_NewLinearColorCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearColorCurve_FunctionAddress, "NewLinearColorCurve", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearColorCurve_LinearColorTrackName_PropertyAddress, SetLinearColorCurve_FunctionAddress, "LinearColorTrackName");
		SetLinearColorCurve_LinearColorTrackName_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearColorCurve_FunctionAddress, "LinearColorTrackName");
		SetLinearColorCurve_LinearColorTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearColorCurve_FunctionAddress, "LinearColorTrackName", Classes.FNameProperty);
		SetLinearColorCurve_IsValid = SetLinearColorCurve_FunctionAddress != IntPtr.Zero && SetLinearColorCurve_NewLinearColorCurve_IsValid && SetLinearColorCurve_LinearColorTrackName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetLinearColorCurve", SetLinearColorCurve_IsValid);
		SetIgnoreTimeDilation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIgnoreTimeDilation");
		SetIgnoreTimeDilation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIgnoreTimeDilation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIgnoreTimeDilation_bNewIgnoreTimeDilation_PropertyAddress, SetIgnoreTimeDilation_FunctionAddress, "bNewIgnoreTimeDilation");
		SetIgnoreTimeDilation_bNewIgnoreTimeDilation_Offset = NativeReflectionCached.GetPropertyOffset(SetIgnoreTimeDilation_FunctionAddress, "bNewIgnoreTimeDilation");
		SetIgnoreTimeDilation_bNewIgnoreTimeDilation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIgnoreTimeDilation_FunctionAddress, "bNewIgnoreTimeDilation", Classes.FBoolProperty);
		SetIgnoreTimeDilation_IsValid = SetIgnoreTimeDilation_FunctionAddress != IntPtr.Zero && SetIgnoreTimeDilation_bNewIgnoreTimeDilation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetIgnoreTimeDilation", SetIgnoreTimeDilation_IsValid);
		SetFloatCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFloatCurve");
		SetFloatCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatCurve_NewFloatCurve_PropertyAddress, SetFloatCurve_FunctionAddress, "NewFloatCurve");
		SetFloatCurve_NewFloatCurve_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatCurve_FunctionAddress, "NewFloatCurve");
		SetFloatCurve_NewFloatCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatCurve_FunctionAddress, "NewFloatCurve", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatCurve_FloatTrackName_PropertyAddress, SetFloatCurve_FunctionAddress, "FloatTrackName");
		SetFloatCurve_FloatTrackName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatCurve_FunctionAddress, "FloatTrackName");
		SetFloatCurve_FloatTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatCurve_FunctionAddress, "FloatTrackName", Classes.FNameProperty);
		SetFloatCurve_IsValid = SetFloatCurve_FunctionAddress != IntPtr.Zero && SetFloatCurve_NewFloatCurve_IsValid && SetFloatCurve_FloatTrackName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:SetFloatCurve", SetFloatCurve_IsValid);
		ReverseFromEnd_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReverseFromEnd");
		ReverseFromEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(ReverseFromEnd_FunctionAddress);
		ReverseFromEnd_IsValid = ReverseFromEnd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:ReverseFromEnd", ReverseFromEnd_IsValid);
		Reverse_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Reverse");
		Reverse_ParamsSize = NativeReflection.GetFunctionParamsSize(Reverse_FunctionAddress);
		Reverse_IsValid = Reverse_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:Reverse", Reverse_IsValid);
		PlayFromStart_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayFromStart");
		PlayFromStart_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayFromStart_FunctionAddress);
		PlayFromStart_IsValid = PlayFromStart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:PlayFromStart", PlayFromStart_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:Play", Play_IsValid);
		IsReversing_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsReversing");
		IsReversing_ParamsSize = NativeReflection.GetFunctionParamsSize(IsReversing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsReversing_ReturnValue_PropertyAddress, IsReversing_FunctionAddress, "ReturnValue");
		IsReversing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsReversing_FunctionAddress, "ReturnValue");
		IsReversing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReversing_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsReversing_IsValid = IsReversing_FunctionAddress != IntPtr.Zero && IsReversing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:IsReversing", IsReversing_IsValid);
		IsPlaying_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsPlaying");
		IsPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_ReturnValue_PropertyAddress, IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlaying_IsValid = IsPlaying_FunctionAddress != IntPtr.Zero && IsPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:IsPlaying", IsPlaying_IsValid);
		IsLooping_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLooping");
		IsLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLooping_ReturnValue_PropertyAddress, IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLooping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLooping_IsValid = IsLooping_FunctionAddress != IntPtr.Zero && IsLooping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:IsLooping", IsLooping_IsValid);
		GetTimelineLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTimelineLength");
		GetTimelineLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimelineLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimelineLength_ReturnValue_PropertyAddress, GetTimelineLength_FunctionAddress, "ReturnValue");
		GetTimelineLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimelineLength_FunctionAddress, "ReturnValue");
		GetTimelineLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimelineLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTimelineLength_IsValid = GetTimelineLength_FunctionAddress != IntPtr.Zero && GetTimelineLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:GetTimelineLength", GetTimelineLength_IsValid);
		GetScaledTimelineLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetScaledTimelineLength");
		GetScaledTimelineLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaledTimelineLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaledTimelineLength_ReturnValue_PropertyAddress, GetScaledTimelineLength_FunctionAddress, "ReturnValue");
		GetScaledTimelineLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaledTimelineLength_FunctionAddress, "ReturnValue");
		GetScaledTimelineLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaledTimelineLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScaledTimelineLength_IsValid = GetScaledTimelineLength_FunctionAddress != IntPtr.Zero && GetScaledTimelineLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:GetScaledTimelineLength", GetScaledTimelineLength_IsValid);
		GetPlayRate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlayRate");
		GetPlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayRate_ReturnValue_PropertyAddress, GetPlayRate_FunctionAddress, "ReturnValue");
		GetPlayRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayRate_FunctionAddress, "ReturnValue");
		GetPlayRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlayRate_IsValid = GetPlayRate_FunctionAddress != IntPtr.Zero && GetPlayRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:GetPlayRate", GetPlayRate_IsValid);
		GetPlaybackPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlaybackPosition");
		GetPlaybackPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackPosition_ReturnValue_PropertyAddress, GetPlaybackPosition_FunctionAddress, "ReturnValue");
		GetPlaybackPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackPosition_FunctionAddress, "ReturnValue");
		GetPlaybackPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackPosition_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlaybackPosition_IsValid = GetPlaybackPosition_FunctionAddress != IntPtr.Zero && GetPlaybackPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:GetPlaybackPosition", GetPlaybackPosition_IsValid);
		GetIgnoreTimeDilation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetIgnoreTimeDilation");
		GetIgnoreTimeDilation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIgnoreTimeDilation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIgnoreTimeDilation_ReturnValue_PropertyAddress, GetIgnoreTimeDilation_FunctionAddress, "ReturnValue");
		GetIgnoreTimeDilation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIgnoreTimeDilation_FunctionAddress, "ReturnValue");
		GetIgnoreTimeDilation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIgnoreTimeDilation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIgnoreTimeDilation_IsValid = GetIgnoreTimeDilation_FunctionAddress != IntPtr.Zero && GetIgnoreTimeDilation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TimelineComponent:GetIgnoreTimeDilation", GetIgnoreTimeDilation_IsValid);
	}
}
