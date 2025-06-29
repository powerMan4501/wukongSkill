using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase")]
public abstract class BGUEnvironmentItemStateMachineActorBase : BGUActorBaseCS
{
	private static bool OnGSReset_IsValid;

	private static IntPtr OnGSReset_FunctionAddress;

	private static int OnGSReset_ParamsSize;

	private IntPtr OnGSReset_InstanceFunctionAddressInstance;

	private static bool OnEnableOverlap_IsValid;

	private static IntPtr OnEnableOverlap_FunctionAddress;

	private static int OnEnableOverlap_ParamsSize;

	private IntPtr OnEnableOverlap_InstanceFunctionAddressInstance;

	private static bool OnDisableOverlap_IsValid;

	private static IntPtr OnDisableOverlap_FunctionAddress;

	private static int OnDisableOverlap_ParamsSize;

	private IntPtr OnDisableOverlap_InstanceFunctionAddressInstance;

	private static bool OnCollisionEndOverlap_IsValid;

	private static IntPtr OnCollisionEndOverlap_FunctionAddress;

	private static int OnCollisionEndOverlap_ParamsSize;

	private static bool OnCollisionEndOverlap_OtherActor_IsValid;

	private static int OnCollisionEndOverlap_OtherActor_Offset;

	private IntPtr OnCollisionEndOverlap_InstanceFunctionAddressInstance;

	private static bool OnResetToOverlapEnable_IsValid;

	private static IntPtr OnResetToOverlapEnable_FunctionAddress;

	private static int OnResetToOverlapEnable_ParamsSize;

	private IntPtr OnResetToOverlapEnable_InstanceFunctionAddressInstance;

	private static bool OnResetToOverlapDisable_IsValid;

	private static IntPtr OnResetToOverlapDisable_FunctionAddress;

	private static int OnResetToOverlapDisable_ParamsSize;

	private IntPtr OnResetToOverlapDisable_InstanceFunctionAddressInstance;

	private static bool OnCollisionBeginOverlap_IsValid;

	private static IntPtr OnCollisionBeginOverlap_FunctionAddress;

	private static int OnCollisionBeginOverlap_ParamsSize;

	private static bool OnCollisionBeginOverlap_OtherActor_IsValid;

	private static int OnCollisionBeginOverlap_OtherActor_Offset;

	private IntPtr OnCollisionBeginOverlap_InstanceFunctionAddressInstance;

	private static bool PlayAkEventWithDialogue_IsValid;

	private static IntPtr PlayAkEventWithDialogue_FunctionAddress;

	private static int PlayAkEventWithDialogue_ParamsSize;

	private static bool PlayAkEventWithDialogue_AkComp_IsValid;

	private static int PlayAkEventWithDialogue_AkComp_Offset;

	private static bool PlayAkEventWithDialogue_AkEvent_IsValid;

	private static int PlayAkEventWithDialogue_AkEvent_Offset;

	private static bool PlayAkEventWithDialogue_ReturnValue_IsValid;

	private static int PlayAkEventWithDialogue_ReturnValue_Offset;

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnGSReset")]
	public unsafe void OnGSReset()
	{
		CheckDestroyed();
		if (!OnGSReset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnGSReset");
			return;
		}
		if (OnGSReset_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnGSReset_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnGSReset");
		}
		byte* value = stackalloc byte[(int)(uint)OnGSReset_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnGSReset_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnGSReset_InstanceFunctionAddressInstance, intPtr, OnGSReset_ParamsSize);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnResetToOverlapEnable")]
	public unsafe void OnResetToOverlapEnable()
	{
		CheckDestroyed();
		if (!OnResetToOverlapEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnResetToOverlapEnable");
			return;
		}
		if (OnResetToOverlapEnable_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnResetToOverlapEnable_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnResetToOverlapEnable");
		}
		byte* value = stackalloc byte[(int)(uint)OnResetToOverlapEnable_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnResetToOverlapEnable_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnResetToOverlapEnable_InstanceFunctionAddressInstance, intPtr, OnResetToOverlapEnable_ParamsSize);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnResetToOverlapDisable")]
	public unsafe void OnResetToOverlapDisable()
	{
		CheckDestroyed();
		if (!OnResetToOverlapDisable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnResetToOverlapDisable");
			return;
		}
		if (OnResetToOverlapDisable_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnResetToOverlapDisable_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnResetToOverlapDisable");
		}
		byte* value = stackalloc byte[(int)(uint)OnResetToOverlapDisable_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnResetToOverlapDisable_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnResetToOverlapDisable_InstanceFunctionAddressInstance, intPtr, OnResetToOverlapDisable_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnEnableOverlap")]
	public unsafe void OnEnableOverlap()
	{
		CheckDestroyed();
		if (!OnEnableOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnEnableOverlap");
			return;
		}
		if (OnEnableOverlap_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnEnableOverlap_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnEnableOverlap");
		}
		byte* value = stackalloc byte[(int)(uint)OnEnableOverlap_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnEnableOverlap_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnEnableOverlap_InstanceFunctionAddressInstance, intPtr, OnEnableOverlap_ParamsSize);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnDisableOverlap")]
	public unsafe void OnDisableOverlap()
	{
		CheckDestroyed();
		if (!OnDisableOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnDisableOverlap");
			return;
		}
		if (OnDisableOverlap_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnDisableOverlap_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnDisableOverlap");
		}
		byte* value = stackalloc byte[(int)(uint)OnDisableOverlap_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnDisableOverlap_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnDisableOverlap_InstanceFunctionAddressInstance, intPtr, OnDisableOverlap_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnCollisionBeginOverlap")]
	public unsafe void OnCollisionBeginOverlap(AActor OtherActor)
	{
		CheckDestroyed();
		if (!OnCollisionBeginOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnCollisionBeginOverlap");
			return;
		}
		if (OnCollisionBeginOverlap_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnCollisionBeginOverlap_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnCollisionBeginOverlap");
		}
		byte* value = stackalloc byte[(int)(uint)OnCollisionBeginOverlap_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnCollisionBeginOverlap_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnCollisionBeginOverlap_OtherActor_Offset), OtherActor);
		NativeReflection.InvokeFunction(base.Address, OnCollisionBeginOverlap_InstanceFunctionAddressInstance, intPtr, OnCollisionBeginOverlap_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnCollisionEndOverlap")]
	public unsafe void OnCollisionEndOverlap(AActor OtherActor)
	{
		CheckDestroyed();
		if (!OnCollisionEndOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnCollisionEndOverlap");
			return;
		}
		if (OnCollisionEndOverlap_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnCollisionEndOverlap_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnCollisionEndOverlap");
		}
		byte* value = stackalloc byte[(int)(uint)OnCollisionEndOverlap_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnCollisionEndOverlap_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnCollisionEndOverlap_OtherActor_Offset), OtherActor);
		NativeReflection.InvokeFunction(base.Address, OnCollisionEndOverlap_InstanceFunctionAddressInstance, intPtr, OnCollisionEndOverlap_ParamsSize);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:PlayAkEventWithDialogue")]
	public int PlayAkEventWithDialogue(UAkComponent AkComp, UAkAudioEvent AkEvent)
	{
		int result = -1;
		BUS_EventCollectionCS.Get(this)?.Evt_PostAkEvent_OnAkComp.Invoke(AkComp, AkEvent, bPlaySubtitle: true);
		b1.IBUC_AkMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_AkMgrData, BUC_AKMgrData>(this);
		if (readOnlyData != null)
		{
			result = readOnlyData.LastPlayingID;
		}
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:PlayAkEventWithDialogue")]
	private static void PlayAkEventWithDialogue__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUEnvironmentItemStateMachineActorBase bGUEnvironmentItemStateMachineActorBase = GCHelper.Find<BGUEnvironmentItemStateMachineActorBase>(obj);
		UAkComponent akComp = UObjectMarshaler<UAkComponent>.FromNative(IntPtr.Add(buffer, PlayAkEventWithDialogue_AkComp_Offset));
		UAkAudioEvent akEvent = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(buffer, PlayAkEventWithDialogue_AkEvent_Offset));
		int value = bGUEnvironmentItemStateMachineActorBase.PlayAkEventWithDialogue(akComp, akEvent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, PlayAkEventWithDialogue_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase");
		OnGSReset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnGSReset");
		OnGSReset_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGSReset_FunctionAddress);
		OnGSReset_IsValid = OnGSReset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnGSReset", OnGSReset_IsValid);
		OnEnableOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEnableOverlap");
		OnEnableOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnableOverlap_FunctionAddress);
		OnEnableOverlap_IsValid = OnEnableOverlap_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnEnableOverlap", OnEnableOverlap_IsValid);
		OnDisableOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnDisableOverlap");
		OnDisableOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDisableOverlap_FunctionAddress);
		OnDisableOverlap_IsValid = OnDisableOverlap_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnDisableOverlap", OnDisableOverlap_IsValid);
		OnCollisionEndOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCollisionEndOverlap");
		OnCollisionEndOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionEndOverlap_FunctionAddress);
		OnCollisionEndOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherActor");
		OnCollisionEndOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnCollisionEndOverlap_IsValid = OnCollisionEndOverlap_FunctionAddress != IntPtr.Zero && OnCollisionEndOverlap_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
		OnResetToOverlapEnable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnResetToOverlapEnable");
		OnResetToOverlapEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResetToOverlapEnable_FunctionAddress);
		OnResetToOverlapEnable_IsValid = OnResetToOverlapEnable_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnResetToOverlapEnable", OnResetToOverlapEnable_IsValid);
		OnResetToOverlapDisable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnResetToOverlapDisable");
		OnResetToOverlapDisable_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResetToOverlapDisable_FunctionAddress);
		OnResetToOverlapDisable_IsValid = OnResetToOverlapDisable_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnResetToOverlapDisable", OnResetToOverlapDisable_IsValid);
		OnCollisionBeginOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCollisionBeginOverlap");
		OnCollisionBeginOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionBeginOverlap_FunctionAddress);
		OnCollisionBeginOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherActor");
		OnCollisionBeginOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnCollisionBeginOverlap_IsValid = OnCollisionBeginOverlap_FunctionAddress != IntPtr.Zero && OnCollisionBeginOverlap_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:OnCollisionBeginOverlap", OnCollisionBeginOverlap_IsValid);
		PlayAkEventWithDialogue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayAkEventWithDialogue");
		PlayAkEventWithDialogue_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayAkEventWithDialogue_FunctionAddress);
		PlayAkEventWithDialogue_AkComp_Offset = NativeReflection.GetPropertyOffset(PlayAkEventWithDialogue_FunctionAddress, "AkComp");
		PlayAkEventWithDialogue_AkComp_IsValid = NativeReflection.ValidatePropertyClass(PlayAkEventWithDialogue_FunctionAddress, "AkComp", Classes.FObjectProperty);
		PlayAkEventWithDialogue_AkEvent_Offset = NativeReflection.GetPropertyOffset(PlayAkEventWithDialogue_FunctionAddress, "AkEvent");
		PlayAkEventWithDialogue_AkEvent_IsValid = NativeReflection.ValidatePropertyClass(PlayAkEventWithDialogue_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		PlayAkEventWithDialogue_ReturnValue_Offset = NativeReflection.GetPropertyOffset(PlayAkEventWithDialogue_FunctionAddress, "ReturnValue");
		PlayAkEventWithDialogue_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(PlayAkEventWithDialogue_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PlayAkEventWithDialogue_IsValid = PlayAkEventWithDialogue_FunctionAddress != IntPtr.Zero && PlayAkEventWithDialogue_AkComp_IsValid && PlayAkEventWithDialogue_AkEvent_IsValid && PlayAkEventWithDialogue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentItemStateMachineActorBase:PlayAkEventWithDialogue", PlayAkEventWithDialogue_IsValid);
	}

	static BGUEnvironmentItemStateMachineActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUEnvironmentItemStateMachineActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUEnvironmentItemStateMachineActorBase));
	}
}
