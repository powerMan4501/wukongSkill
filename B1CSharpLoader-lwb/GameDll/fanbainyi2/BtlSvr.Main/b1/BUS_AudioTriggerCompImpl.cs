using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_AudioTriggerCompImpl : BUS_TriggerBaseComp
{
	[UClass]
	[USharpPath("/Script/b1-Managed.AudioTriggerCompFunctionBinder")]
	private class UAudioTriggerCompFunctionBinder : UObject
	{
		private b1.BUS_AudioTriggerCompImpl OwnerComp;

		private static bool AudioCallback_IsValid;

		private static IntPtr AudioCallback_FunctionAddress;

		private static int AudioCallback_ParamsSize;

		private static bool AudioCallback_CallbackType_IsValid;

		private static int AudioCallback_CallbackType_Offset;

		private static FFieldAddress AudioCallback_CallbackType_PropertyAddress;

		private static bool AudioCallback_CallbackInfo_IsValid;

		private static int AudioCallback_CallbackInfo_Offset;

		public void Init(b1.BUS_AudioTriggerCompImpl Component)
		{
			OwnerComp = Component;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.AudioTriggerCompFunctionBinder:AudioCallback")]
		internal void AudioCallback(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
		{
			if (OwnerComp != null)
			{
				OwnerComp.AudioCallback(CallbackType, CallbackInfo);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.AudioTriggerCompFunctionBinder:AudioCallback")]
		private static void AudioCallback__Invoker(IntPtr buffer, IntPtr obj)
		{
			UAudioTriggerCompFunctionBinder uAudioTriggerCompFunctionBinder = GCHelper.Find<UAudioTriggerCompFunctionBinder>(obj);
			EAkCallbackType callbackType = EnumMarshaler<EAkCallbackType>.FromNative(IntPtr.Add(buffer, AudioCallback_CallbackType_Offset), 0, AudioCallback_CallbackType_PropertyAddress.Address);
			UAkCallbackInfo callbackInfo = UObjectMarshaler<UAkCallbackInfo>.FromNative(IntPtr.Add(buffer, AudioCallback_CallbackInfo_Offset));
			uAudioTriggerCompFunctionBinder.AudioCallback(callbackType, callbackInfo);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.AudioTriggerCompFunctionBinder");
			AudioCallback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AudioCallback");
			AudioCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(AudioCallback_FunctionAddress);
			NativeReflection.GetPropertyRef(ref AudioCallback_CallbackType_PropertyAddress, AudioCallback_FunctionAddress, "CallbackType");
			AudioCallback_CallbackType_Offset = NativeReflection.GetPropertyOffset(AudioCallback_FunctionAddress, "CallbackType");
			AudioCallback_CallbackType_IsValid = NativeReflection.ValidatePropertyClass(AudioCallback_FunctionAddress, "CallbackType", Classes.FEnumProperty);
			AudioCallback_CallbackInfo_Offset = NativeReflection.GetPropertyOffset(AudioCallback_FunctionAddress, "CallbackInfo");
			AudioCallback_CallbackInfo_IsValid = NativeReflection.ValidatePropertyClass(AudioCallback_FunctionAddress, "CallbackInfo", Classes.FObjectProperty);
			AudioCallback_IsValid = AudioCallback_FunctionAddress != IntPtr.Zero && AudioCallback_CallbackType_IsValid && AudioCallback_CallbackInfo_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AudioTriggerCompFunctionBinder:AudioCallback", AudioCallback_IsValid);
		}

		static UAudioTriggerCompFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UAudioTriggerCompFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UAudioTriggerCompFunctionBinder));
		}
	}

	private b1.BUC_AudioTriggerData AudioTriggerData;

	private b1.BUC_AudioTriggerConfigData AudioTriggerConfigData;

	private TStrongObjectPtr<UAudioTriggerCompFunctionBinder> mFunctionBinder = new TStrongObjectPtr<UAudioTriggerCompFunctionBinder>();

	private UAudioTriggerCompFunctionBinder FunctionBinder
	{
		get
		{
			return mFunctionBinder.Get();
		}
		set
		{
			mFunctionBinder.Set(value);
		}
	}

	public override void OnAttach()
	{
		base.OnAttach();
		AudioTriggerData = RequireWritableData<b1.BUC_AudioTriggerData>();
		AudioTriggerConfigData = RequireWritableData<b1.BUC_AudioTriggerConfigData>();
		FunctionBinder = UObject.NewObject<UAudioTriggerCompFunctionBinder>(base.Owner);
		FunctionBinder.Init(this);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!AudioTriggerData.bEnableNextAudio)
		{
			return;
		}
		AudioTriggerData.Timer += DeltaTime;
		if (AudioTriggerData.Timer >= AudioTriggerConfigData.AudioList[AudioTriggerData.NextAudioIdx - 1].DelayTime)
		{
			AudioTriggerData.bEnableNextAudio = false;
			AudioTriggerData.Timer = 0f;
			UAkAudioEvent audioEvent = AudioTriggerConfigData.AudioList[AudioTriggerData.NextAudioIdx - 1].AudioEvent;
			if (audioEvent != null)
			{
				UAkGameplayStatics.PostEvent(audioEvent, GetOwner(), 7, AudioTriggerData.PostEventCallback);
			}
		}
	}

	public override void OnEnter_TriggeredEvent()
	{
		AudioTriggerData.PostEventCallback = new FOnAkPostEventCallback();
		AudioTriggerData.PostEventCallback.Bind(FunctionBinder.AudioCallback);
		TriggerAudio(base.TriggerBoxData.OverlappedOtherActor);
	}

	private void TriggerAudio(AActor OtherActor)
	{
		UpdateAudioData();
	}

	private void UpdateAudioData()
	{
		int count = AudioTriggerConfigData.AudioList.Count;
		if (count > 0 && AudioTriggerData.NextAudioIdx < count)
		{
			AudioTriggerData.bEnableNextAudio = true;
			AudioTriggerData.NextAudioIdx++;
		}
	}

	private void AudioCallback(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
	{
		if (CallbackType == EAkCallbackType.EndOfEvent)
		{
			UpdateAudioData();
		}
	}
}
