using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkGameObject", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkGameObject : USceneComponent
{
	private static bool AkAudioEvent_IsValid;

	private static int AkAudioEvent_Offset;

	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetRTPCValue_IsValid;

	private static IntPtr SetRTPCValue_FunctionAddress;

	private static int SetRTPCValue_ParamsSize;

	private static bool SetRTPCValue_RTPCValue_IsValid;

	private static FFieldAddress SetRTPCValue_RTPCValue_PropertyAddress;

	private static int SetRTPCValue_RTPCValue_Offset;

	private static bool SetRTPCValue_Value_IsValid;

	private static FFieldAddress SetRTPCValue_Value_PropertyAddress;

	private static int SetRTPCValue_Value_Offset;

	private static bool SetRTPCValue_InterpolationTimeMs_IsValid;

	private static FFieldAddress SetRTPCValue_InterpolationTimeMs_PropertyAddress;

	private static int SetRTPCValue_InterpolationTimeMs_Offset;

	private static bool SetRTPCValue_RTPC_IsValid;

	private static FFieldAddress SetRTPCValue_RTPC_PropertyAddress;

	private static int SetRTPCValue_RTPC_Offset;

	private static bool PostAssociatedAkEventAsync_IsValid;

	private static IntPtr PostAssociatedAkEventAsync_FunctionAddress;

	private static int PostAssociatedAkEventAsync_ParamsSize;

	private static bool PostAssociatedAkEventAsync_WorldContextObject_IsValid;

	private static FFieldAddress PostAssociatedAkEventAsync_WorldContextObject_PropertyAddress;

	private static int PostAssociatedAkEventAsync_WorldContextObject_Offset;

	private static bool PostAssociatedAkEventAsync_CallbackMask_IsValid;

	private static FFieldAddress PostAssociatedAkEventAsync_CallbackMask_PropertyAddress;

	private static int PostAssociatedAkEventAsync_CallbackMask_Offset;

	private static bool PostAssociatedAkEventAsync_PostEventCallback_IsValid;

	private static FFieldAddress PostAssociatedAkEventAsync_PostEventCallback_PropertyAddress;

	private static int PostAssociatedAkEventAsync_PostEventCallback_Offset;

	private static bool PostAssociatedAkEventAsync_LatentInfo_IsValid;

	private static FFieldAddress PostAssociatedAkEventAsync_LatentInfo_PropertyAddress;

	private static int PostAssociatedAkEventAsync_LatentInfo_Offset;

	private static bool PostAssociatedAkEventAsync_PlayingID_IsValid;

	private static FFieldAddress PostAssociatedAkEventAsync_PlayingID_PropertyAddress;

	private static int PostAssociatedAkEventAsync_PlayingID_Offset;

	private static bool PostAssociatedAkEvent_IsValid;

	private static IntPtr PostAssociatedAkEvent_FunctionAddress;

	private static int PostAssociatedAkEvent_ParamsSize;

	private static bool PostAssociatedAkEvent_CallbackMask_IsValid;

	private static FFieldAddress PostAssociatedAkEvent_CallbackMask_PropertyAddress;

	private static int PostAssociatedAkEvent_CallbackMask_Offset;

	private static bool PostAssociatedAkEvent_PostEventCallback_IsValid;

	private static FFieldAddress PostAssociatedAkEvent_PostEventCallback_PropertyAddress;

	private static int PostAssociatedAkEvent_PostEventCallback_Offset;

	private static bool PostAssociatedAkEvent_ReturnValue_IsValid;

	private static FFieldAddress PostAssociatedAkEvent_ReturnValue_PropertyAddress;

	private static int PostAssociatedAkEvent_ReturnValue_Offset;

	private static bool PostAkEventAsync_IsValid;

	private static IntPtr PostAkEventAsync_FunctionAddress;

	private static int PostAkEventAsync_ParamsSize;

	private static bool PostAkEventAsync_WorldContextObject_IsValid;

	private static FFieldAddress PostAkEventAsync_WorldContextObject_PropertyAddress;

	private static int PostAkEventAsync_WorldContextObject_Offset;

	private static bool PostAkEventAsync_AkEvent_IsValid;

	private static FFieldAddress PostAkEventAsync_AkEvent_PropertyAddress;

	private static int PostAkEventAsync_AkEvent_Offset;

	private static bool PostAkEventAsync_PlayingID_IsValid;

	private static FFieldAddress PostAkEventAsync_PlayingID_PropertyAddress;

	private static int PostAkEventAsync_PlayingID_Offset;

	private static bool PostAkEventAsync_CallbackMask_IsValid;

	private static FFieldAddress PostAkEventAsync_CallbackMask_PropertyAddress;

	private static int PostAkEventAsync_CallbackMask_Offset;

	private static bool PostAkEventAsync_PostEventCallback_IsValid;

	private static FFieldAddress PostAkEventAsync_PostEventCallback_PropertyAddress;

	private static int PostAkEventAsync_PostEventCallback_Offset;

	private static bool PostAkEventAsync_LatentInfo_IsValid;

	private static FFieldAddress PostAkEventAsync_LatentInfo_PropertyAddress;

	private static int PostAkEventAsync_LatentInfo_Offset;

	private static bool PostAkEvent_IsValid;

	private static IntPtr PostAkEvent_FunctionAddress;

	private static int PostAkEvent_ParamsSize;

	private static bool PostAkEvent_AkEvent_IsValid;

	private static FFieldAddress PostAkEvent_AkEvent_PropertyAddress;

	private static int PostAkEvent_AkEvent_Offset;

	private static bool PostAkEvent_CallbackMask_IsValid;

	private static FFieldAddress PostAkEvent_CallbackMask_PropertyAddress;

	private static int PostAkEvent_CallbackMask_Offset;

	private static bool PostAkEvent_PostEventCallback_IsValid;

	private static FFieldAddress PostAkEvent_PostEventCallback_PropertyAddress;

	private static int PostAkEvent_PostEventCallback_Offset;

	private static bool PostAkEvent_InEventName_IsValid;

	private static FFieldAddress PostAkEvent_InEventName_PropertyAddress;

	private static int PostAkEvent_InEventName_Offset;

	private static bool PostAkEvent_ReturnValue_IsValid;

	private static FFieldAddress PostAkEvent_ReturnValue_PropertyAddress;

	private static int PostAkEvent_ReturnValue_Offset;

	private static bool GetRTPCValue_IsValid;

	private static IntPtr GetRTPCValue_FunctionAddress;

	private static int GetRTPCValue_ParamsSize;

	private static bool GetRTPCValue_RTPCValue_IsValid;

	private static FFieldAddress GetRTPCValue_RTPCValue_PropertyAddress;

	private static int GetRTPCValue_RTPCValue_Offset;

	private static bool GetRTPCValue_InputValueType_IsValid;

	private static FFieldAddress GetRTPCValue_InputValueType_PropertyAddress;

	private static int GetRTPCValue_InputValueType_Offset;

	private static bool GetRTPCValue_Value_IsValid;

	private static FFieldAddress GetRTPCValue_Value_PropertyAddress;

	private static int GetRTPCValue_Value_Offset;

	private static bool GetRTPCValue_OutputValueType_IsValid;

	private static FFieldAddress GetRTPCValue_OutputValueType_PropertyAddress;

	private static int GetRTPCValue_OutputValueType_Offset;

	private static bool GetRTPCValue_RTPC_IsValid;

	private static FFieldAddress GetRTPCValue_RTPC_PropertyAddress;

	private static int GetRTPCValue_RTPC_Offset;

	private static bool GetRTPCValue_PlayingID_IsValid;

	private static FFieldAddress GetRTPCValue_PlayingID_PropertyAddress;

	private static int GetRTPCValue_PlayingID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkGameObject:AkAudioEvent")]
	public UAkAudioEvent AkAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!AkAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGameObject:AkAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGameObject:AkAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkAudioEvent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759797487567365uL)]
	[UMetaPath("/Script/AkAudio.AkGameObject:EventName")]
	public string EventName
	{
		get
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGameObject:EventName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EventName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkGameObject:EventName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EventName_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240968u)]
	[UMetaPath("/Script/AkAudio.AkGameObject:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameObject:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 1140982793u)]
	[UMetaPath("/Script/AkAudio.AkGameObject:SetRTPCValue")]
	public unsafe void SetRTPCValue(UAkRtpc RTPCValue, float Value, int InterpolationTimeMs, string RTPC)
	{
		CheckDestroyed();
		if (!SetRTPCValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameObject:SetRTPCValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRTPCValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRTPCValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkRtpc>.ToNative(IntPtr.Add(intPtr, SetRTPCValue_RTPCValue_Offset), 0, SetRTPCValue_RTPCValue_PropertyAddress.Address, RTPCValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRTPCValue_Value_Offset), 0, SetRTPCValue_Value_PropertyAddress.Address, Value);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRTPCValue_InterpolationTimeMs_Offset), 0, SetRTPCValue_InterpolationTimeMs_PropertyAddress.Address, InterpolationTimeMs);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetRTPCValue_RTPC_Offset), 0, SetRTPCValue_RTPC_PropertyAddress.Address, RTPC);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRTPCValue_FunctionAddress, intPtr, SetRTPCValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetRTPCValue_RTPC_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435272u)]
	[UMetaPath("/Script/AkAudio.AkGameObject:PostAssociatedAkEventAsync")]
	public unsafe void PostAssociatedAkEventAsync(UObject WorldContextObject, int CallbackMask, FOnAkPostEventCallback PostEventCallback, FLatentActionInfo LatentInfo, out int PlayingID)
	{
		CheckDestroyed();
		if (!PostAssociatedAkEventAsync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameObject:PostAssociatedAkEventAsync");
			PlayingID = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAssociatedAkEventAsync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAssociatedAkEventAsync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PostAssociatedAkEventAsync_WorldContextObject_Offset), 0, PostAssociatedAkEventAsync_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostAssociatedAkEventAsync_CallbackMask_Offset), 0, PostAssociatedAkEventAsync_CallbackMask_PropertyAddress.Address, CallbackMask);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, PostAssociatedAkEventAsync_PostEventCallback_Offset), 0, PostAssociatedAkEventAsync_PostEventCallback_PropertyAddress.Address, PostEventCallback);
		NativeReflection.InitializeValue_InContainer(PostAssociatedAkEventAsync_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, PostAssociatedAkEventAsync_LatentInfo_Offset), 0, PostAssociatedAkEventAsync_LatentInfo_PropertyAddress.Address, LatentInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostAssociatedAkEventAsync_FunctionAddress, intPtr, PostAssociatedAkEventAsync_ParamsSize);
		PlayingID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAssociatedAkEventAsync_PlayingID_Offset), 0, PostAssociatedAkEventAsync_PlayingID_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435272u)]
	[UMetaPath("/Script/AkAudio.AkGameObject:PostAssociatedAkEvent")]
	public unsafe int PostAssociatedAkEvent(int CallbackMask, FOnAkPostEventCallback PostEventCallback)
	{
		CheckDestroyed();
		if (!PostAssociatedAkEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameObject:PostAssociatedAkEvent");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAssociatedAkEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAssociatedAkEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostAssociatedAkEvent_CallbackMask_Offset), 0, PostAssociatedAkEvent_CallbackMask_PropertyAddress.Address, CallbackMask);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, PostAssociatedAkEvent_PostEventCallback_Offset), 0, PostAssociatedAkEvent_PostEventCallback_PropertyAddress.Address, PostEventCallback);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostAssociatedAkEvent_FunctionAddress, intPtr, PostAssociatedAkEvent_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAssociatedAkEvent_ReturnValue_Offset), 0, PostAssociatedAkEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435272u)]
	[UMetaPath("/Script/AkAudio.AkGameObject:PostAkEventAsync")]
	public unsafe void PostAkEventAsync(UObject WorldContextObject, UAkAudioEvent AkEvent, out int PlayingID, int CallbackMask, FOnAkPostEventCallback PostEventCallback, FLatentActionInfo LatentInfo)
	{
		CheckDestroyed();
		if (!PostAkEventAsync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameObject:PostAkEventAsync");
			PlayingID = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAkEventAsync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAkEventAsync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PostAkEventAsync_WorldContextObject_Offset), 0, PostAkEventAsync_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, PostAkEventAsync_AkEvent_Offset), 0, PostAkEventAsync_AkEvent_PropertyAddress.Address, AkEvent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostAkEventAsync_CallbackMask_Offset), 0, PostAkEventAsync_CallbackMask_PropertyAddress.Address, CallbackMask);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, PostAkEventAsync_PostEventCallback_Offset), 0, PostAkEventAsync_PostEventCallback_PropertyAddress.Address, PostEventCallback);
		NativeReflection.InitializeValue_InContainer(PostAkEventAsync_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, PostAkEventAsync_LatentInfo_Offset), 0, PostAkEventAsync_LatentInfo_PropertyAddress.Address, LatentInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostAkEventAsync_FunctionAddress, intPtr, PostAkEventAsync_ParamsSize);
		PlayingID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAkEventAsync_PlayingID_Offset), 0, PostAkEventAsync_PlayingID_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435272u)]
	[UMetaPath("/Script/AkAudio.AkGameObject:PostAkEvent")]
	public unsafe int PostAkEvent(UAkAudioEvent AkEvent, int CallbackMask, FOnAkPostEventCallback PostEventCallback, string InEventName)
	{
		CheckDestroyed();
		if (!PostAkEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameObject:PostAkEvent");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAkEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAkEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, PostAkEvent_AkEvent_Offset), 0, PostAkEvent_AkEvent_PropertyAddress.Address, AkEvent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostAkEvent_CallbackMask_Offset), 0, PostAkEvent_CallbackMask_PropertyAddress.Address, CallbackMask);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, PostAkEvent_PostEventCallback_Offset), 0, PostAkEvent_PostEventCallback_PropertyAddress.Address, PostEventCallback);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostAkEvent_InEventName_Offset), 0, PostAkEvent_InEventName_PropertyAddress.Address, InEventName);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostAkEvent_FunctionAddress, intPtr, PostAkEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostAkEvent_InEventName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAkEvent_ReturnValue_Offset), 0, PostAkEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612553u)]
	[UMetaPath("/Script/AkAudio.AkGameObject:GetRTPCValue")]
	public unsafe void GetRTPCValue(UAkRtpc RTPCValue, ERTPCValueType InputValueType, out float Value, out ERTPCValueType OutputValueType, string RTPC, int PlayingID = 0)
	{
		CheckDestroyed();
		if (!GetRTPCValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameObject:GetRTPCValue");
			Value = 0f;
			OutputValueType = ERTPCValueType.Default;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRTPCValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRTPCValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkRtpc>.ToNative(IntPtr.Add(intPtr, GetRTPCValue_RTPCValue_Offset), 0, GetRTPCValue_RTPCValue_PropertyAddress.Address, RTPCValue);
		EnumMarshaler<ERTPCValueType>.ToNative(IntPtr.Add(intPtr, GetRTPCValue_InputValueType_Offset), 0, GetRTPCValue_InputValueType_PropertyAddress.Address, InputValueType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetRTPCValue_RTPC_Offset), 0, GetRTPCValue_RTPC_PropertyAddress.Address, RTPC);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRTPCValue_PlayingID_Offset), 0, GetRTPCValue_PlayingID_PropertyAddress.Address, PlayingID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRTPCValue_FunctionAddress, intPtr, GetRTPCValue_ParamsSize);
		Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRTPCValue_Value_Offset), 0, GetRTPCValue_Value_PropertyAddress.Address);
		OutputValueType = EnumMarshaler<ERTPCValueType>.FromNative(IntPtr.Add(intPtr, GetRTPCValue_OutputValueType_Offset), 0, GetRTPCValue_OutputValueType_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetRTPCValue_RTPC_PropertyAddress.Address, intPtr);
	}

	static UAkGameObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkGameObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkGameObject));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkGameObject");
		AkAudioEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AkAudioEvent");
		AkAudioEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AkAudioEvent", Classes.FObjectProperty);
		EventName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EventName", Classes.FStrProperty);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameObject:Stop", Stop_IsValid);
		SetRTPCValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRTPCValue");
		SetRTPCValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRTPCValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValue_RTPCValue_PropertyAddress, SetRTPCValue_FunctionAddress, "RTPCValue");
		SetRTPCValue_RTPCValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValue_FunctionAddress, "RTPCValue");
		SetRTPCValue_RTPCValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValue_FunctionAddress, "RTPCValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValue_Value_PropertyAddress, SetRTPCValue_FunctionAddress, "Value");
		SetRTPCValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValue_FunctionAddress, "Value");
		SetRTPCValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValue_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValue_InterpolationTimeMs_PropertyAddress, SetRTPCValue_FunctionAddress, "InterpolationTimeMs");
		SetRTPCValue_InterpolationTimeMs_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValue_FunctionAddress, "InterpolationTimeMs");
		SetRTPCValue_InterpolationTimeMs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValue_FunctionAddress, "InterpolationTimeMs", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValue_RTPC_PropertyAddress, SetRTPCValue_FunctionAddress, "RTPC");
		SetRTPCValue_RTPC_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValue_FunctionAddress, "RTPC");
		SetRTPCValue_RTPC_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValue_FunctionAddress, "RTPC", Classes.FStrProperty);
		SetRTPCValue_IsValid = SetRTPCValue_FunctionAddress != IntPtr.Zero && SetRTPCValue_RTPCValue_IsValid && SetRTPCValue_Value_IsValid && SetRTPCValue_InterpolationTimeMs_IsValid && SetRTPCValue_RTPC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameObject:SetRTPCValue", SetRTPCValue_IsValid);
		PostAssociatedAkEventAsync_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostAssociatedAkEventAsync");
		PostAssociatedAkEventAsync_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAssociatedAkEventAsync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEventAsync_WorldContextObject_PropertyAddress, PostAssociatedAkEventAsync_FunctionAddress, "WorldContextObject");
		PostAssociatedAkEventAsync_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEventAsync_FunctionAddress, "WorldContextObject");
		PostAssociatedAkEventAsync_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEventAsync_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEventAsync_CallbackMask_PropertyAddress, PostAssociatedAkEventAsync_FunctionAddress, "CallbackMask");
		PostAssociatedAkEventAsync_CallbackMask_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEventAsync_FunctionAddress, "CallbackMask");
		PostAssociatedAkEventAsync_CallbackMask_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEventAsync_FunctionAddress, "CallbackMask", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEventAsync_PostEventCallback_PropertyAddress, PostAssociatedAkEventAsync_FunctionAddress, "PostEventCallback");
		PostAssociatedAkEventAsync_PostEventCallback_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEventAsync_FunctionAddress, "PostEventCallback");
		PostAssociatedAkEventAsync_PostEventCallback_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEventAsync_FunctionAddress, "PostEventCallback", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEventAsync_LatentInfo_PropertyAddress, PostAssociatedAkEventAsync_FunctionAddress, "LatentInfo");
		PostAssociatedAkEventAsync_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEventAsync_FunctionAddress, "LatentInfo");
		PostAssociatedAkEventAsync_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEventAsync_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEventAsync_PlayingID_PropertyAddress, PostAssociatedAkEventAsync_FunctionAddress, "PlayingID");
		PostAssociatedAkEventAsync_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEventAsync_FunctionAddress, "PlayingID");
		PostAssociatedAkEventAsync_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEventAsync_FunctionAddress, "PlayingID", Classes.FIntProperty);
		PostAssociatedAkEventAsync_IsValid = PostAssociatedAkEventAsync_FunctionAddress != IntPtr.Zero && PostAssociatedAkEventAsync_WorldContextObject_IsValid && PostAssociatedAkEventAsync_CallbackMask_IsValid && PostAssociatedAkEventAsync_PostEventCallback_IsValid && PostAssociatedAkEventAsync_LatentInfo_IsValid && PostAssociatedAkEventAsync_PlayingID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameObject:PostAssociatedAkEventAsync", PostAssociatedAkEventAsync_IsValid);
		PostAssociatedAkEvent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostAssociatedAkEvent");
		PostAssociatedAkEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAssociatedAkEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEvent_CallbackMask_PropertyAddress, PostAssociatedAkEvent_FunctionAddress, "CallbackMask");
		PostAssociatedAkEvent_CallbackMask_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEvent_FunctionAddress, "CallbackMask");
		PostAssociatedAkEvent_CallbackMask_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEvent_FunctionAddress, "CallbackMask", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEvent_PostEventCallback_PropertyAddress, PostAssociatedAkEvent_FunctionAddress, "PostEventCallback");
		PostAssociatedAkEvent_PostEventCallback_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEvent_FunctionAddress, "PostEventCallback");
		PostAssociatedAkEvent_PostEventCallback_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEvent_FunctionAddress, "PostEventCallback", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAssociatedAkEvent_ReturnValue_PropertyAddress, PostAssociatedAkEvent_FunctionAddress, "ReturnValue");
		PostAssociatedAkEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostAssociatedAkEvent_FunctionAddress, "ReturnValue");
		PostAssociatedAkEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAssociatedAkEvent_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostAssociatedAkEvent_IsValid = PostAssociatedAkEvent_FunctionAddress != IntPtr.Zero && PostAssociatedAkEvent_CallbackMask_IsValid && PostAssociatedAkEvent_PostEventCallback_IsValid && PostAssociatedAkEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameObject:PostAssociatedAkEvent", PostAssociatedAkEvent_IsValid);
		PostAkEventAsync_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostAkEventAsync");
		PostAkEventAsync_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAkEventAsync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAsync_WorldContextObject_PropertyAddress, PostAkEventAsync_FunctionAddress, "WorldContextObject");
		PostAkEventAsync_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAsync_FunctionAddress, "WorldContextObject");
		PostAkEventAsync_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAsync_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAsync_AkEvent_PropertyAddress, PostAkEventAsync_FunctionAddress, "AkEvent");
		PostAkEventAsync_AkEvent_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAsync_FunctionAddress, "AkEvent");
		PostAkEventAsync_AkEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAsync_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAsync_PlayingID_PropertyAddress, PostAkEventAsync_FunctionAddress, "PlayingID");
		PostAkEventAsync_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAsync_FunctionAddress, "PlayingID");
		PostAkEventAsync_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAsync_FunctionAddress, "PlayingID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAsync_CallbackMask_PropertyAddress, PostAkEventAsync_FunctionAddress, "CallbackMask");
		PostAkEventAsync_CallbackMask_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAsync_FunctionAddress, "CallbackMask");
		PostAkEventAsync_CallbackMask_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAsync_FunctionAddress, "CallbackMask", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAsync_PostEventCallback_PropertyAddress, PostAkEventAsync_FunctionAddress, "PostEventCallback");
		PostAkEventAsync_PostEventCallback_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAsync_FunctionAddress, "PostEventCallback");
		PostAkEventAsync_PostEventCallback_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAsync_FunctionAddress, "PostEventCallback", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEventAsync_LatentInfo_PropertyAddress, PostAkEventAsync_FunctionAddress, "LatentInfo");
		PostAkEventAsync_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEventAsync_FunctionAddress, "LatentInfo");
		PostAkEventAsync_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEventAsync_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		PostAkEventAsync_IsValid = PostAkEventAsync_FunctionAddress != IntPtr.Zero && PostAkEventAsync_WorldContextObject_IsValid && PostAkEventAsync_AkEvent_IsValid && PostAkEventAsync_PlayingID_IsValid && PostAkEventAsync_CallbackMask_IsValid && PostAkEventAsync_PostEventCallback_IsValid && PostAkEventAsync_LatentInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameObject:PostAkEventAsync", PostAkEventAsync_IsValid);
		PostAkEvent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostAkEvent");
		PostAkEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAkEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAkEvent_AkEvent_PropertyAddress, PostAkEvent_FunctionAddress, "AkEvent");
		PostAkEvent_AkEvent_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEvent_FunctionAddress, "AkEvent");
		PostAkEvent_AkEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEvent_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEvent_CallbackMask_PropertyAddress, PostAkEvent_FunctionAddress, "CallbackMask");
		PostAkEvent_CallbackMask_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEvent_FunctionAddress, "CallbackMask");
		PostAkEvent_CallbackMask_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEvent_FunctionAddress, "CallbackMask", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEvent_PostEventCallback_PropertyAddress, PostAkEvent_FunctionAddress, "PostEventCallback");
		PostAkEvent_PostEventCallback_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEvent_FunctionAddress, "PostEventCallback");
		PostAkEvent_PostEventCallback_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEvent_FunctionAddress, "PostEventCallback", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEvent_InEventName_PropertyAddress, PostAkEvent_FunctionAddress, "InEventName");
		PostAkEvent_InEventName_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEvent_FunctionAddress, "InEventName");
		PostAkEvent_InEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEvent_FunctionAddress, "InEventName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAkEvent_ReturnValue_PropertyAddress, PostAkEvent_FunctionAddress, "ReturnValue");
		PostAkEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostAkEvent_FunctionAddress, "ReturnValue");
		PostAkEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAkEvent_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostAkEvent_IsValid = PostAkEvent_FunctionAddress != IntPtr.Zero && PostAkEvent_AkEvent_IsValid && PostAkEvent_CallbackMask_IsValid && PostAkEvent_PostEventCallback_IsValid && PostAkEvent_InEventName_IsValid && PostAkEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameObject:PostAkEvent", PostAkEvent_IsValid);
		GetRTPCValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRTPCValue");
		GetRTPCValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRTPCValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_RTPCValue_PropertyAddress, GetRTPCValue_FunctionAddress, "RTPCValue");
		GetRTPCValue_RTPCValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "RTPCValue");
		GetRTPCValue_RTPCValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "RTPCValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_InputValueType_PropertyAddress, GetRTPCValue_FunctionAddress, "InputValueType");
		GetRTPCValue_InputValueType_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "InputValueType");
		GetRTPCValue_InputValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "InputValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_Value_PropertyAddress, GetRTPCValue_FunctionAddress, "Value");
		GetRTPCValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "Value");
		GetRTPCValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_OutputValueType_PropertyAddress, GetRTPCValue_FunctionAddress, "OutputValueType");
		GetRTPCValue_OutputValueType_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "OutputValueType");
		GetRTPCValue_OutputValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "OutputValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_RTPC_PropertyAddress, GetRTPCValue_FunctionAddress, "RTPC");
		GetRTPCValue_RTPC_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "RTPC");
		GetRTPCValue_RTPC_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "RTPC", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_PlayingID_PropertyAddress, GetRTPCValue_FunctionAddress, "PlayingID");
		GetRTPCValue_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "PlayingID");
		GetRTPCValue_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "PlayingID", Classes.FIntProperty);
		GetRTPCValue_IsValid = GetRTPCValue_FunctionAddress != IntPtr.Zero && GetRTPCValue_RTPCValue_IsValid && GetRTPCValue_InputValueType_IsValid && GetRTPCValue_Value_IsValid && GetRTPCValue_OutputValueType_IsValid && GetRTPCValue_RTPC_IsValid && GetRTPCValue_PlayingID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameObject:GetRTPCValue", GetRTPCValue_IsValid);
	}
}
