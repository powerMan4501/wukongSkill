using System;
using System.Runtime.CompilerServices;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFunctionLibAK", "b1", UnrealModuleType.Game)]
public class UBGUFunctionLibAK : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UnLoadBank_IsValid;

	private static IntPtr UnLoadBank_FunctionAddress;

	private static int UnLoadBank_ParamsSize;

	private static bool UnLoadBank_BankName_IsValid;

	private static FFieldAddress UnLoadBank_BankName_PropertyAddress;

	private static int UnLoadBank_BankName_Offset;

	private static bool SetUnrealGlobalSwitch_IsValid;

	private static IntPtr SetUnrealGlobalSwitch_FunctionAddress;

	private static int SetUnrealGlobalSwitch_ParamsSize;

	private static bool SetUnrealGlobalSwitch_SwitchGroup_IsValid;

	private static FFieldAddress SetUnrealGlobalSwitch_SwitchGroup_PropertyAddress;

	private static int SetUnrealGlobalSwitch_SwitchGroup_Offset;

	private static bool SetUnrealGlobalSwitch_SwitchState_IsValid;

	private static FFieldAddress SetUnrealGlobalSwitch_SwitchState_PropertyAddress;

	private static int SetUnrealGlobalSwitch_SwitchState_Offset;

	private static bool SeekOnEvent_IsValid;

	private static IntPtr SeekOnEvent_FunctionAddress;

	private static int SeekOnEvent_ParamsSize;

	private static bool SeekOnEvent_InEventName_IsValid;

	private static FFieldAddress SeekOnEvent_InEventName_PropertyAddress;

	private static int SeekOnEvent_InEventName_Offset;

	private static bool SeekOnEvent_InComponent_IsValid;

	private static FFieldAddress SeekOnEvent_InComponent_PropertyAddress;

	private static int SeekOnEvent_InComponent_Offset;

	private static bool SeekOnEvent_InPercent_IsValid;

	private static FFieldAddress SeekOnEvent_InPercent_PropertyAddress;

	private static int SeekOnEvent_InPercent_Offset;

	private static bool SeekOnEvent_bInSeekToNearestMarker_IsValid;

	private static FFieldAddress SeekOnEvent_bInSeekToNearestMarker_PropertyAddress;

	private static int SeekOnEvent_bInSeekToNearestMarker_Offset;

	private static bool SeekOnEvent_InPlayingID_IsValid;

	private static FFieldAddress SeekOnEvent_InPlayingID_PropertyAddress;

	private static int SeekOnEvent_InPlayingID_Offset;

	private static bool SeekOnEvent_ReturnValue_IsValid;

	private static FFieldAddress SeekOnEvent_ReturnValue_PropertyAddress;

	private static int SeekOnEvent_ReturnValue_Offset;

	private static bool PostAkEventOnDummyActor_IsValid;

	private static IntPtr PostAkEventOnDummyActor_FunctionAddress;

	private static int PostAkEventOnDummyActor_ParamsSize;

	private static bool PostAkEventOnDummyActor_EventName_IsValid;

	private static FFieldAddress PostAkEventOnDummyActor_EventName_PropertyAddress;

	private static int PostAkEventOnDummyActor_EventName_Offset;

	private static bool PostAkEventOnDummyActor_Event_IsValid;

	private static FFieldAddress PostAkEventOnDummyActor_Event_PropertyAddress;

	private static int PostAkEventOnDummyActor_Event_Offset;

	private static bool PostAkEventOnDummyActor_ReturnValue_IsValid;

	private static FFieldAddress PostAkEventOnDummyActor_ReturnValue_PropertyAddress;

	private static int PostAkEventOnDummyActor_ReturnValue_Offset;

	private static bool LoadBank_IsValid;

	private static IntPtr LoadBank_FunctionAddress;

	private static int LoadBank_ParamsSize;

	private static bool LoadBank_BankName_IsValid;

	private static FFieldAddress LoadBank_BankName_PropertyAddress;

	private static int LoadBank_BankName_Offset;

	private static bool GetSourcePlayPosition_IsValid;

	private static IntPtr GetSourcePlayPosition_FunctionAddress;

	private static int GetSourcePlayPosition_ParamsSize;

	private static bool GetSourcePlayPosition_PlayingID_IsValid;

	private static FFieldAddress GetSourcePlayPosition_PlayingID_PropertyAddress;

	private static int GetSourcePlayPosition_PlayingID_Offset;

	private static bool GetSourcePlayPosition_ReturnValue_IsValid;

	private static FFieldAddress GetSourcePlayPosition_ReturnValue_PropertyAddress;

	private static int GetSourcePlayPosition_ReturnValue_Offset;

	private static bool ExecuteActionOnPlayingID_IsValid;

	private static IntPtr ExecuteActionOnPlayingID_FunctionAddress;

	private static int ExecuteActionOnPlayingID_ParamsSize;

	private static bool ExecuteActionOnPlayingID_ActionType_IsValid;

	private static FFieldAddress ExecuteActionOnPlayingID_ActionType_PropertyAddress;

	private static int ExecuteActionOnPlayingID_ActionType_Offset;

	private static bool ExecuteActionOnPlayingID_PlayingID_IsValid;

	private static FFieldAddress ExecuteActionOnPlayingID_PlayingID_PropertyAddress;

	private static int ExecuteActionOnPlayingID_PlayingID_Offset;

	private static bool ExecuteActionOnPlayingID_FadeOutTimeMs_IsValid;

	private static FFieldAddress ExecuteActionOnPlayingID_FadeOutTimeMs_PropertyAddress;

	private static int ExecuteActionOnPlayingID_FadeOutTimeMs_Offset;

	private static bool ExecuteActionOnPlayingID_FadeOutCurveType_IsValid;

	private static FFieldAddress ExecuteActionOnPlayingID_FadeOutCurveType_PropertyAddress;

	private static int ExecuteActionOnPlayingID_FadeOutCurveType_Offset;

	private static bool BGUAKStopPlayingID_IsValid;

	private static IntPtr BGUAKStopPlayingID_FunctionAddress;

	private static int BGUAKStopPlayingID_ParamsSize;

	private static bool BGUAKStopPlayingID_PlayingID_IsValid;

	private static FFieldAddress BGUAKStopPlayingID_PlayingID_PropertyAddress;

	private static int BGUAKStopPlayingID_PlayingID_Offset;

	private static bool BGUAKStopPlayingID_FadeOutTimeMs_IsValid;

	private static FFieldAddress BGUAKStopPlayingID_FadeOutTimeMs_PropertyAddress;

	private static int BGUAKStopPlayingID_FadeOutTimeMs_Offset;

	private static bool BGUAKStopPlayingID_FadeOutCurveType_IsValid;

	private static FFieldAddress BGUAKStopPlayingID_FadeOutCurveType_PropertyAddress;

	private static int BGUAKStopPlayingID_FadeOutCurveType_Offset;

	private static bool AkEventPinInGarbageCollector_IsValid;

	private static IntPtr AkEventPinInGarbageCollector_FunctionAddress;

	private static int AkEventPinInGarbageCollector_ParamsSize;

	private static bool AkEventPinInGarbageCollector_Event_IsValid;

	private static FFieldAddress AkEventPinInGarbageCollector_Event_PropertyAddress;

	private static int AkEventPinInGarbageCollector_Event_Offset;

	private static bool AkEventPinInGarbageCollector_PlayingID_IsValid;

	private static FFieldAddress AkEventPinInGarbageCollector_PlayingID_PropertyAddress;

	private static int AkEventPinInGarbageCollector_PlayingID_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibAK:UnLoadBank")]
	public unsafe static void UnLoadBank(string BankName)
	{
		if (!UnLoadBank_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibAK:UnLoadBank");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnLoadBank_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnLoadBank_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UnLoadBank_BankName_Offset), 0, UnLoadBank_BankName_PropertyAddress.Address, BankName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnLoadBank_FunctionAddress, intPtr, UnLoadBank_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnLoadBank_BankName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibAK:SetUnrealGlobalSwitch")]
	public unsafe static void SetUnrealGlobalSwitch(FName SwitchGroup, FName SwitchState)
	{
		if (!SetUnrealGlobalSwitch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibAK:SetUnrealGlobalSwitch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUnrealGlobalSwitch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUnrealGlobalSwitch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetUnrealGlobalSwitch_SwitchGroup_Offset), 0, SetUnrealGlobalSwitch_SwitchGroup_PropertyAddress.Address, SwitchGroup);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetUnrealGlobalSwitch_SwitchState_Offset), 0, SetUnrealGlobalSwitch_SwitchState_PropertyAddress.Address, SwitchState);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetUnrealGlobalSwitch_FunctionAddress, intPtr, SetUnrealGlobalSwitch_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibAK:SeekOnEvent")]
	public unsafe static EAkResult SeekOnEvent(string InEventName, UAkComponent InComponent, float InPercent, bool bInSeekToNearestMarker = false, int InPlayingID = 0)
	{
		if (!SeekOnEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibAK:SeekOnEvent");
			return EAkResult.NotImplemented;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SeekOnEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SeekOnEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SeekOnEvent_InEventName_Offset), 0, SeekOnEvent_InEventName_PropertyAddress.Address, InEventName);
		UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(intPtr, SeekOnEvent_InComponent_Offset), 0, SeekOnEvent_InComponent_PropertyAddress.Address, InComponent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SeekOnEvent_InPercent_Offset), 0, SeekOnEvent_InPercent_PropertyAddress.Address, InPercent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SeekOnEvent_bInSeekToNearestMarker_Offset), 0, SeekOnEvent_bInSeekToNearestMarker_PropertyAddress.Address, bInSeekToNearestMarker);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SeekOnEvent_InPlayingID_Offset), 0, SeekOnEvent_InPlayingID_PropertyAddress.Address, InPlayingID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SeekOnEvent_FunctionAddress, intPtr, SeekOnEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SeekOnEvent_InEventName_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EAkResult>.FromNative(IntPtr.Add(intPtr, SeekOnEvent_ReturnValue_Offset), 0, SeekOnEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibAK:PostAkEventOnDummyActor")]
	public unsafe static int PostAkEventOnDummyActor(string EventName, UAkAudioEvent Event)
	{
		if (!PostAkEventOnDummyActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibAK:PostAkEventOnDummyActor");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAkEventOnDummyActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAkEventOnDummyActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostAkEventOnDummyActor_EventName_Offset), 0, PostAkEventOnDummyActor_EventName_PropertyAddress.Address, EventName);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, PostAkEventOnDummyActor_Event_Offset), 0, PostAkEventOnDummyActor_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostAkEventOnDummyActor_FunctionAddress, intPtr, PostAkEventOnDummyActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostAkEventOnDummyActor_EventName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAkEventOnDummyActor_ReturnValue_Offset), 0, PostAkEventOnDummyActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibAK:LoadBank")]
	public unsafe static void LoadBank(string BankName)
	{
		if (!LoadBank_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibAK:LoadBank");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadBank_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadBank_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadBank_BankName_Offset), 0, LoadBank_BankName_PropertyAddress.Address, BankName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadBank_FunctionAddress, intPtr, LoadBank_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadBank_BankName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibAK:GetSourcePlayPosition")]
	public unsafe static int GetSourcePlayPosition(int PlayingID)
	{
		if (!GetSourcePlayPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibAK:GetSourcePlayPosition");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSourcePlayPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSourcePlayPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSourcePlayPosition_PlayingID_Offset), 0, GetSourcePlayPosition_PlayingID_PropertyAddress.Address, PlayingID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSourcePlayPosition_FunctionAddress, intPtr, GetSourcePlayPosition_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSourcePlayPosition_ReturnValue_Offset), 0, GetSourcePlayPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibAK:ExecuteActionOnPlayingID")]
	public unsafe static void ExecuteActionOnPlayingID(int ActionType, int PlayingID, int FadeOutTimeMs = 0, int FadeOutCurveType = 4)
	{
		if (!ExecuteActionOnPlayingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibAK:ExecuteActionOnPlayingID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteActionOnPlayingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteActionOnPlayingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExecuteActionOnPlayingID_ActionType_Offset), 0, ExecuteActionOnPlayingID_ActionType_PropertyAddress.Address, ActionType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExecuteActionOnPlayingID_PlayingID_Offset), 0, ExecuteActionOnPlayingID_PlayingID_PropertyAddress.Address, PlayingID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExecuteActionOnPlayingID_FadeOutTimeMs_Offset), 0, ExecuteActionOnPlayingID_FadeOutTimeMs_PropertyAddress.Address, FadeOutTimeMs);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExecuteActionOnPlayingID_FadeOutCurveType_Offset), 0, ExecuteActionOnPlayingID_FadeOutCurveType_PropertyAddress.Address, FadeOutCurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExecuteActionOnPlayingID_FunctionAddress, intPtr, ExecuteActionOnPlayingID_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibAK:BGUAKStopPlayingID")]
	public unsafe static void BGUAKStopPlayingID(int PlayingID, int FadeOutTimeMs, int FadeOutCurveType)
	{
		if (!BGUAKStopPlayingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibAK:BGUAKStopPlayingID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUAKStopPlayingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUAKStopPlayingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUAKStopPlayingID_PlayingID_Offset), 0, BGUAKStopPlayingID_PlayingID_PropertyAddress.Address, PlayingID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUAKStopPlayingID_FadeOutTimeMs_Offset), 0, BGUAKStopPlayingID_FadeOutTimeMs_PropertyAddress.Address, FadeOutTimeMs);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUAKStopPlayingID_FadeOutCurveType_Offset), 0, BGUAKStopPlayingID_FadeOutCurveType_PropertyAddress.Address, FadeOutCurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUAKStopPlayingID_FunctionAddress, intPtr, BGUAKStopPlayingID_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibAK:AkEventPinInGarbageCollector")]
	public unsafe static void AkEventPinInGarbageCollector(UAkAudioEvent Event, int PlayingID)
	{
		if (!AkEventPinInGarbageCollector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibAK:AkEventPinInGarbageCollector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AkEventPinInGarbageCollector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AkEventPinInGarbageCollector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, AkEventPinInGarbageCollector_Event_Offset), 0, AkEventPinInGarbageCollector_Event_PropertyAddress.Address, Event);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AkEventPinInGarbageCollector_PlayingID_Offset), 0, AkEventPinInGarbageCollector_PlayingID_PropertyAddress.Address, PlayingID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AkEventPinInGarbageCollector_FunctionAddress, intPtr, AkEventPinInGarbageCollector_ParamsSize);
	}

	static UBGUFunctionLibAK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFunctionLibAK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFunctionLibAK));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFunctionLibAK");
		UnLoadBank_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnLoadBank");
		UnLoadBank_ParamsSize = NativeReflection.GetFunctionParamsSize(UnLoadBank_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnLoadBank_BankName_PropertyAddress, UnLoadBank_FunctionAddress, "BankName");
		UnLoadBank_BankName_Offset = NativeReflectionCached.GetPropertyOffset(UnLoadBank_FunctionAddress, "BankName");
		UnLoadBank_BankName_IsValid = NativeReflectionCached.ValidatePropertyClass(UnLoadBank_FunctionAddress, "BankName", Classes.FStrProperty);
		UnLoadBank_IsValid = UnLoadBank_FunctionAddress != IntPtr.Zero && UnLoadBank_BankName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibAK:UnLoadBank", UnLoadBank_IsValid);
		SetUnrealGlobalSwitch_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetUnrealGlobalSwitch");
		SetUnrealGlobalSwitch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUnrealGlobalSwitch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUnrealGlobalSwitch_SwitchGroup_PropertyAddress, SetUnrealGlobalSwitch_FunctionAddress, "SwitchGroup");
		SetUnrealGlobalSwitch_SwitchGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetUnrealGlobalSwitch_FunctionAddress, "SwitchGroup");
		SetUnrealGlobalSwitch_SwitchGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUnrealGlobalSwitch_FunctionAddress, "SwitchGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUnrealGlobalSwitch_SwitchState_PropertyAddress, SetUnrealGlobalSwitch_FunctionAddress, "SwitchState");
		SetUnrealGlobalSwitch_SwitchState_Offset = NativeReflectionCached.GetPropertyOffset(SetUnrealGlobalSwitch_FunctionAddress, "SwitchState");
		SetUnrealGlobalSwitch_SwitchState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUnrealGlobalSwitch_FunctionAddress, "SwitchState", Classes.FNameProperty);
		SetUnrealGlobalSwitch_IsValid = SetUnrealGlobalSwitch_FunctionAddress != IntPtr.Zero && SetUnrealGlobalSwitch_SwitchGroup_IsValid && SetUnrealGlobalSwitch_SwitchState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibAK:SetUnrealGlobalSwitch", SetUnrealGlobalSwitch_IsValid);
		SeekOnEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SeekOnEvent");
		SeekOnEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(SeekOnEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SeekOnEvent_InEventName_PropertyAddress, SeekOnEvent_FunctionAddress, "InEventName");
		SeekOnEvent_InEventName_Offset = NativeReflectionCached.GetPropertyOffset(SeekOnEvent_FunctionAddress, "InEventName");
		SeekOnEvent_InEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekOnEvent_FunctionAddress, "InEventName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SeekOnEvent_InComponent_PropertyAddress, SeekOnEvent_FunctionAddress, "InComponent");
		SeekOnEvent_InComponent_Offset = NativeReflectionCached.GetPropertyOffset(SeekOnEvent_FunctionAddress, "InComponent");
		SeekOnEvent_InComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekOnEvent_FunctionAddress, "InComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SeekOnEvent_InPercent_PropertyAddress, SeekOnEvent_FunctionAddress, "InPercent");
		SeekOnEvent_InPercent_Offset = NativeReflectionCached.GetPropertyOffset(SeekOnEvent_FunctionAddress, "InPercent");
		SeekOnEvent_InPercent_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekOnEvent_FunctionAddress, "InPercent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SeekOnEvent_bInSeekToNearestMarker_PropertyAddress, SeekOnEvent_FunctionAddress, "bInSeekToNearestMarker");
		SeekOnEvent_bInSeekToNearestMarker_Offset = NativeReflectionCached.GetPropertyOffset(SeekOnEvent_FunctionAddress, "bInSeekToNearestMarker");
		SeekOnEvent_bInSeekToNearestMarker_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekOnEvent_FunctionAddress, "bInSeekToNearestMarker", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SeekOnEvent_InPlayingID_PropertyAddress, SeekOnEvent_FunctionAddress, "InPlayingID");
		SeekOnEvent_InPlayingID_Offset = NativeReflectionCached.GetPropertyOffset(SeekOnEvent_FunctionAddress, "InPlayingID");
		SeekOnEvent_InPlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekOnEvent_FunctionAddress, "InPlayingID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SeekOnEvent_ReturnValue_PropertyAddress, SeekOnEvent_FunctionAddress, "ReturnValue");
		SeekOnEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SeekOnEvent_FunctionAddress, "ReturnValue");
		SeekOnEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekOnEvent_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		SeekOnEvent_IsValid = SeekOnEvent_FunctionAddress != IntPtr.Zero && SeekOnEvent_InEventName_IsValid && SeekOnEvent_InComponent_IsValid && SeekOnEvent_InPercent_IsValid && SeekOnEvent_bInSeekToNearestMarker_IsValid && SeekOnEvent_InPlayingID_IsValid && SeekOnEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibAK:SeekOnEvent", SeekOnEvent_IsValid);
		PostAkEventOnDummyActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostAkEventOnDummyActor");
		PostAkEventOnDummyActor_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAkEventOnDummyActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventOnDummyActor_EventName_PropertyAddress, PostAkEventOnDummyActor_FunctionAddress, "EventName");
		PostAkEventOnDummyActor_EventName_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventOnDummyActor_FunctionAddress, "EventName");
		PostAkEventOnDummyActor_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventOnDummyActor_FunctionAddress, "EventName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventOnDummyActor_Event_PropertyAddress, PostAkEventOnDummyActor_FunctionAddress, "Event");
		PostAkEventOnDummyActor_Event_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventOnDummyActor_FunctionAddress, "Event");
		PostAkEventOnDummyActor_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventOnDummyActor_FunctionAddress, "Event", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventOnDummyActor_ReturnValue_PropertyAddress, PostAkEventOnDummyActor_FunctionAddress, "ReturnValue");
		PostAkEventOnDummyActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventOnDummyActor_FunctionAddress, "ReturnValue");
		PostAkEventOnDummyActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventOnDummyActor_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostAkEventOnDummyActor_IsValid = PostAkEventOnDummyActor_FunctionAddress != IntPtr.Zero && PostAkEventOnDummyActor_EventName_IsValid && PostAkEventOnDummyActor_Event_IsValid && PostAkEventOnDummyActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibAK:PostAkEventOnDummyActor", PostAkEventOnDummyActor_IsValid);
		LoadBank_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadBank");
		LoadBank_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadBank_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadBank_BankName_PropertyAddress, LoadBank_FunctionAddress, "BankName");
		LoadBank_BankName_Offset = NativeReflectionCached.GetPropertyOffset(LoadBank_FunctionAddress, "BankName");
		LoadBank_BankName_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadBank_FunctionAddress, "BankName", Classes.FStrProperty);
		LoadBank_IsValid = LoadBank_FunctionAddress != IntPtr.Zero && LoadBank_BankName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibAK:LoadBank", LoadBank_IsValid);
		GetSourcePlayPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSourcePlayPosition");
		GetSourcePlayPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSourcePlayPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSourcePlayPosition_PlayingID_PropertyAddress, GetSourcePlayPosition_FunctionAddress, "PlayingID");
		GetSourcePlayPosition_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(GetSourcePlayPosition_FunctionAddress, "PlayingID");
		GetSourcePlayPosition_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSourcePlayPosition_FunctionAddress, "PlayingID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSourcePlayPosition_ReturnValue_PropertyAddress, GetSourcePlayPosition_FunctionAddress, "ReturnValue");
		GetSourcePlayPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSourcePlayPosition_FunctionAddress, "ReturnValue");
		GetSourcePlayPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSourcePlayPosition_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSourcePlayPosition_IsValid = GetSourcePlayPosition_FunctionAddress != IntPtr.Zero && GetSourcePlayPosition_PlayingID_IsValid && GetSourcePlayPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibAK:GetSourcePlayPosition", GetSourcePlayPosition_IsValid);
		ExecuteActionOnPlayingID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExecuteActionOnPlayingID");
		ExecuteActionOnPlayingID_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteActionOnPlayingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecuteActionOnPlayingID_ActionType_PropertyAddress, ExecuteActionOnPlayingID_FunctionAddress, "ActionType");
		ExecuteActionOnPlayingID_ActionType_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteActionOnPlayingID_FunctionAddress, "ActionType");
		ExecuteActionOnPlayingID_ActionType_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteActionOnPlayingID_FunctionAddress, "ActionType", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteActionOnPlayingID_PlayingID_PropertyAddress, ExecuteActionOnPlayingID_FunctionAddress, "PlayingID");
		ExecuteActionOnPlayingID_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteActionOnPlayingID_FunctionAddress, "PlayingID");
		ExecuteActionOnPlayingID_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteActionOnPlayingID_FunctionAddress, "PlayingID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteActionOnPlayingID_FadeOutTimeMs_PropertyAddress, ExecuteActionOnPlayingID_FunctionAddress, "FadeOutTimeMs");
		ExecuteActionOnPlayingID_FadeOutTimeMs_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteActionOnPlayingID_FunctionAddress, "FadeOutTimeMs");
		ExecuteActionOnPlayingID_FadeOutTimeMs_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteActionOnPlayingID_FunctionAddress, "FadeOutTimeMs", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteActionOnPlayingID_FadeOutCurveType_PropertyAddress, ExecuteActionOnPlayingID_FunctionAddress, "FadeOutCurveType");
		ExecuteActionOnPlayingID_FadeOutCurveType_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteActionOnPlayingID_FunctionAddress, "FadeOutCurveType");
		ExecuteActionOnPlayingID_FadeOutCurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteActionOnPlayingID_FunctionAddress, "FadeOutCurveType", Classes.FIntProperty);
		ExecuteActionOnPlayingID_IsValid = ExecuteActionOnPlayingID_FunctionAddress != IntPtr.Zero && ExecuteActionOnPlayingID_ActionType_IsValid && ExecuteActionOnPlayingID_PlayingID_IsValid && ExecuteActionOnPlayingID_FadeOutTimeMs_IsValid && ExecuteActionOnPlayingID_FadeOutCurveType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibAK:ExecuteActionOnPlayingID", ExecuteActionOnPlayingID_IsValid);
		BGUAKStopPlayingID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUAKStopPlayingID");
		BGUAKStopPlayingID_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAKStopPlayingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUAKStopPlayingID_PlayingID_PropertyAddress, BGUAKStopPlayingID_FunctionAddress, "PlayingID");
		BGUAKStopPlayingID_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(BGUAKStopPlayingID_FunctionAddress, "PlayingID");
		BGUAKStopPlayingID_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUAKStopPlayingID_FunctionAddress, "PlayingID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUAKStopPlayingID_FadeOutTimeMs_PropertyAddress, BGUAKStopPlayingID_FunctionAddress, "FadeOutTimeMs");
		BGUAKStopPlayingID_FadeOutTimeMs_Offset = NativeReflectionCached.GetPropertyOffset(BGUAKStopPlayingID_FunctionAddress, "FadeOutTimeMs");
		BGUAKStopPlayingID_FadeOutTimeMs_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUAKStopPlayingID_FunctionAddress, "FadeOutTimeMs", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUAKStopPlayingID_FadeOutCurveType_PropertyAddress, BGUAKStopPlayingID_FunctionAddress, "FadeOutCurveType");
		BGUAKStopPlayingID_FadeOutCurveType_Offset = NativeReflectionCached.GetPropertyOffset(BGUAKStopPlayingID_FunctionAddress, "FadeOutCurveType");
		BGUAKStopPlayingID_FadeOutCurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUAKStopPlayingID_FunctionAddress, "FadeOutCurveType", Classes.FIntProperty);
		BGUAKStopPlayingID_IsValid = BGUAKStopPlayingID_FunctionAddress != IntPtr.Zero && BGUAKStopPlayingID_PlayingID_IsValid && BGUAKStopPlayingID_FadeOutTimeMs_IsValid && BGUAKStopPlayingID_FadeOutCurveType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibAK:BGUAKStopPlayingID", BGUAKStopPlayingID_IsValid);
		AkEventPinInGarbageCollector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AkEventPinInGarbageCollector");
		AkEventPinInGarbageCollector_ParamsSize = NativeReflection.GetFunctionParamsSize(AkEventPinInGarbageCollector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AkEventPinInGarbageCollector_Event_PropertyAddress, AkEventPinInGarbageCollector_FunctionAddress, "Event");
		AkEventPinInGarbageCollector_Event_Offset = NativeReflectionCached.GetPropertyOffset(AkEventPinInGarbageCollector_FunctionAddress, "Event");
		AkEventPinInGarbageCollector_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(AkEventPinInGarbageCollector_FunctionAddress, "Event", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AkEventPinInGarbageCollector_PlayingID_PropertyAddress, AkEventPinInGarbageCollector_FunctionAddress, "PlayingID");
		AkEventPinInGarbageCollector_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(AkEventPinInGarbageCollector_FunctionAddress, "PlayingID");
		AkEventPinInGarbageCollector_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(AkEventPinInGarbageCollector_FunctionAddress, "PlayingID", Classes.FIntProperty);
		AkEventPinInGarbageCollector_IsValid = AkEventPinInGarbageCollector_FunctionAddress != IntPtr.Zero && AkEventPinInGarbageCollector_Event_IsValid && AkEventPinInGarbageCollector_PlayingID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibAK:AkEventPinInGarbageCollector", AkEventPinInGarbageCollector_IsValid);
	}
}
