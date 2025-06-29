using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using b1.GameState.Data;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_AudioSystem : GameModeSystemBase
{
	[UClass]
	[USharpPath("/Script/b1-Managed.FunctionBinder_AudioSystem")]
	private class UFunctionBinder_AudioSystem : UObject
	{
		private static bool RoomSetSwitch_IsValid;

		private static IntPtr RoomSetSwitch_FunctionAddress;

		private static int RoomSetSwitch_ParamsSize;

		private static bool RoomSetSwitch_SwitchGroup_IsValid;

		private static int RoomSetSwitch_SwitchGroup_Offset;

		private static FFieldAddress RoomSetSwitch_SwitchGroup_PropertyAddress;

		private static bool RoomSetSwitch_SwitchState_IsValid;

		private static int RoomSetSwitch_SwitchState_Offset;

		private static FFieldAddress RoomSetSwitch_SwitchState_PropertyAddress;

		[UFunction]
		[USharpPath("/Script/b1-Managed.FunctionBinder_AudioSystem:RoomSetSwitch")]
		private void RoomSetSwitch(string SwitchGroup, string SwitchState)
		{
			BGS_EventCollectionCS.Get(this).Evt_AkRoomSetSwitch.Invoke(SwitchGroup, SwitchState);
		}

		[UFunctionInvoker("/Script/b1-Managed.FunctionBinder_AudioSystem:RoomSetSwitch")]
		private static void RoomSetSwitch__Invoker(IntPtr buffer, IntPtr obj)
		{
			UFunctionBinder_AudioSystem uFunctionBinder_AudioSystem = GCHelper.Find<UFunctionBinder_AudioSystem>(obj);
			string switchGroup = FStringMarshaler.FromNative(IntPtr.Add(buffer, RoomSetSwitch_SwitchGroup_Offset));
			string switchState = FStringMarshaler.FromNative(IntPtr.Add(buffer, RoomSetSwitch_SwitchState_Offset));
			uFunctionBinder_AudioSystem.RoomSetSwitch(switchGroup, switchState);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FunctionBinder_AudioSystem");
			RoomSetSwitch_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RoomSetSwitch");
			RoomSetSwitch_ParamsSize = NativeReflection.GetFunctionParamsSize(RoomSetSwitch_FunctionAddress);
			NativeReflection.GetPropertyRef(ref RoomSetSwitch_SwitchGroup_PropertyAddress, RoomSetSwitch_FunctionAddress, "SwitchGroup");
			RoomSetSwitch_SwitchGroup_Offset = NativeReflection.GetPropertyOffset(RoomSetSwitch_FunctionAddress, "SwitchGroup");
			RoomSetSwitch_SwitchGroup_IsValid = NativeReflection.ValidatePropertyClass(RoomSetSwitch_FunctionAddress, "SwitchGroup", Classes.FStrProperty);
			NativeReflection.GetPropertyRef(ref RoomSetSwitch_SwitchState_PropertyAddress, RoomSetSwitch_FunctionAddress, "SwitchState");
			RoomSetSwitch_SwitchState_Offset = NativeReflection.GetPropertyOffset(RoomSetSwitch_FunctionAddress, "SwitchState");
			RoomSetSwitch_SwitchState_IsValid = NativeReflection.ValidatePropertyClass(RoomSetSwitch_FunctionAddress, "SwitchState", Classes.FStrProperty);
			RoomSetSwitch_IsValid = RoomSetSwitch_FunctionAddress != IntPtr.Zero && RoomSetSwitch_SwitchGroup_IsValid && RoomSetSwitch_SwitchState_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FunctionBinder_AudioSystem:RoomSetSwitch", RoomSetSwitch_IsValid);
		}

		static UFunctionBinder_AudioSystem()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UFunctionBinder_AudioSystem)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UFunctionBinder_AudioSystem));
		}
	}

	private BGC_AudioData AudioData { get; set; }

	private TStrongObjectPtr<UFunctionBinder_AudioSystem> FunctionBinderPtr { get; } = new TStrongObjectPtr<UFunctionBinder_AudioSystem>();

	public override void OnAttach()
	{
		AudioData = RequireWritableGameStateData<BGC_AudioData>();
		base.BGSEventCollection.Evt_AkRoomSetSwitch += new Del_Void_StringString(AkRoomSetSwitch);
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		if (!(worldFromObj == null))
		{
			BGW_WorldSettings bGW_WorldSettings = worldFromObj.GetWorldSettings().Cast<BGW_WorldSettings>();
			if (!(bGW_WorldSettings == null))
			{
				AudioData.EnterLevelEvent = bGW_WorldSettings.EnterLevelEvent;
				AudioData.EnterLevelEventLocation = bGW_WorldSettings.EnterLevelEventLocation;
				AudioData.ExitLevelEvent = bGW_WorldSettings.ExitLevelEvent;
				AudioData.bShowListener = bGW_WorldSettings.bShowListener;
				AudioData.bShowMaxAttentionRadius = bGW_WorldSettings.bShowMaxAttentionRadius;
				AudioData.bShowObjectDirectionAxis = bGW_WorldSettings.bShowObjectDirectionAxis;
				AudioData.AxisLength = bGW_WorldSettings.AxisLength;
				AudioData.RefreshInterval = bGW_WorldSettings.GameObjectRefreshInterval;
				AudioData.DebugDurationTime = bGW_WorldSettings.GameObjectRefreshInterval * 1.2f;
				AudioData.ShowDebugRange = bGW_WorldSettings.ShowObjectRangeMeter * 100f;
				AudioData.CurrentIntervalTime = 0f;
				base.BGSEventCollection.Evt_RegisterAudioEmitter += new Del_Void_StringAudioEmitter(RegisterAudioEmitter);
				base.BGSEventCollection.Evt_UnRegisterAudioEmitter += new Del_Void_String(UnregisterAudioEmitter);
			}
		}
	}

	public override void OnBeginPlay()
	{
		AudioData.LevelAudioAkComponent = new TWeakObject<UAkComponent>(UAkGameplayStatics.SpawnAkComponentAtLocation(GetOwner(), null, AudioData.EnterLevelEventLocation, FRotator.ZeroRotator, AutoPost: false, "", AutoDestroy: false));
		UFunctionBinder_AudioSystem uFunctionBinder_AudioSystem = UObject.NewObject<UFunctionBinder_AudioSystem>(Owner);
		FunctionBinderPtr.Set(uFunctionBinder_AudioSystem);
		UAkSettings uAkSettings = UClass.GetClass<UAkSettings>().GetDefaultObject() as UAkSettings;
		if (uAkSettings != null)
		{
			AkRoomSetSwitch(uAkSettings.RoomSwitchGroup, uAkSettings.RoomSwitchState);
			uAkSettings.RoomSetEnvSwitch.Bind(uFunctionBinder_AudioSystem, B1GlobalFNames.RoomSetSwitch);
		}
		if (AudioData.EnterLevelEvent != null && AudioData.LevelAudioAkComponent.IsValid())
		{
			AudioData.LevelAudioAkComponent.Get().PostAkEvent(AudioData.EnterLevelEvent, 0, null, "");
		}
	}

	private void AkRoomSetSwitch(string SwitchGroup, string SwitchState)
	{
		if (AudioData.LevelAudioAkComponent.IsValid())
		{
			AudioData.LevelAudioAkComponent.Get().SetSwitch(null, SwitchGroup, SwitchState);
		}
	}

	public override int GetTickGroupMask()
	{
		return 256;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateAudioEmitters();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (AudioData.ExitLevelEvent != null && AudioData.LevelAudioAkComponent.IsValid())
		{
			AudioData.LevelAudioAkComponent.Get().PostAkEvent(AudioData.ExitLevelEvent, 0, null, "");
		}
		UFunctionBinder_AudioSystem obj = FunctionBinderPtr.Get();
		UAkSettings uAkSettings = UClass.GetClass<UAkSettings>().GetDefaultObject() as UAkSettings;
		if (uAkSettings != null)
		{
			uAkSettings.RoomSetEnvSwitch.Unbind(obj, B1GlobalFNames.RoomSetSwitch);
		}
	}

	private void RegisterAudioEmitter(string InActorGuid, FAudioEmitter AudioEmitter)
	{
		if (AudioEmitter != null)
		{
			AudioEmitter.AkComponent.PostAkEvent(AudioEmitter.AkEventEmitter, 0, null, "");
			AudioEmitter.AkComponent.DisableUpdateSpatialAudioRoom = true;
			AudioData.AudioEmitters[InActorGuid] = AudioEmitter;
		}
	}

	private void UnregisterAudioEmitter(string InActorGuid)
	{
		if (AudioData.AudioEmitters.TryGetValue(InActorGuid, out var value))
		{
			value.AkComponent.Stop();
			value.AkComponent.DisableUpdateSpatialAudioRoom = false;
		}
		AudioData.AudioEmitters.Remove(InActorGuid);
	}

	private void UpdateAudioEmitters()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		ACharacter aCharacter = firstLocalPlayerController.GetControlledPawn() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		bool flag = GSGameplayCVar.CVar_EnableAudioEmitterDebug.GetValueInGameThread() != 0;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
		float z = fVector.Z;
		FRotator rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(firstLocalPlayerController);
		foreach (KeyValuePair<string, FAudioEmitter> audioEmitter in AudioData.AudioEmitters)
		{
			FAudioEmitter value = audioEmitter.Value;
			float num = (value.EmitterLocation - fVector).Size();
			if (num > value.MaxRangeFadeDistance + value.LazyDistance)
			{
				continue;
			}
			FVector fVector2 = BGUFuncLibComponentCS.BGUFindLocationClosestToWorldLocation(value.SplineComponent, fVector, bLocalSpace: false);
			GetIsInsideSpline(value, fVector2, fVector, out var bInsideSpline, out var bInsideSplineRange, out var _, out var bInsideSplineRangeChanged);
			if (bInsideSplineRangeChanged)
			{
				value.bInsideSpline = bInsideSpline;
				value.bInsideSplineRange = bInsideSplineRange;
				if (!value.bInitialized)
				{
					value.bInitialized = true;
				}
				SetAkState(value, bInsideSplineRange);
			}
			else if (!value.bInitialized)
			{
				value.bInitialized = true;
				SetAkState(value, bInsideSplineRange);
			}
			FVector fVector3;
			if (!value.bInsideSpline)
			{
				fVector3 = ((!value.bFollowPlayerElevation) ? (fVector2 + new FVector(0.0, 0.0, value.EmitterHeight)) : new FVector(fVector2.X, fVector2.Y, fVector.Z));
			}
			else
			{
				fVector3 = fVector;
				fVector3.Z = z + value.EmitterHeight;
			}
			fVector3.Z = MathLib.Clamp(fVector3.Z, value.MinHeightLimit, value.MaxHeightLimit);
			BGUFuncLibComponentCS.BGUSetWorldLocationAndRotation(value.AkComponent, fVector3, rotation);
			if (flag && value.bDebug)
			{
				FMath.GetMappedRangeValueClamped(new FVector2D(value.MaxRangeFadeDistance, 0.0), new FVector2D(1.0, 0.0), num);
				USystemLibrary.DrawDebugConeInDegrees(GetOwner(), fVector3, rotation.Vector(), 100f, 45f, 45f, 12, FLinearColor.White, 0f, 2f);
				USystemLibrary.DrawDebugSphere(GetOwner(), fVector3, 10f, 12, FLinearColor.Blue, 0f, 4f);
				_ = value.bDebugLog;
			}
		}
	}

	private void SetAkState(FAudioEmitter AudioEmitter, bool bInInsideSpline)
	{
		if (bInInsideSpline)
		{
			UAkGameplayStatics.SetSwitch(null, GetOwner(), AudioEmitter.StateGroup, AudioEmitter.StateInside);
		}
		else
		{
			UAkGameplayStatics.SetSwitch(null, GetOwner(), AudioEmitter.StateGroup, AudioEmitter.StateOutside);
		}
	}

	private bool IsInsideSpline(FAudioEmitter AudioEmitter, FVector SplineCurveLocationClosestToPlayer, FVector PlayerLocation)
	{
		FVector b = BGUFuncLibComponentCS.BGUFindRightVectorClosestToWorldLocation(AudioEmitter.SplineComponent, PlayerLocation, bLocalSpace: false);
		return (SplineCurveLocationClosestToPlayer - PlayerLocation).Dot_VectorVector(b) > 0.0;
	}

	private void GetIsInsideSpline(FAudioEmitter AudioEmitter, FVector SplineCurveLocationClosestToPlayer, FVector PlayerLocation, out bool bInsideSpline, out bool bInsideSplineRange, out bool bInsideSplineChanged, out bool bInsideSplineRangeChanged)
	{
		bInsideSpline = IsInsideSpline(AudioEmitter, SplineCurveLocationClosestToPlayer, PlayerLocation);
		bInsideSplineRange = bInsideSpline && PlayerLocation.Z <= AudioEmitter.MaxHeightLimit && PlayerLocation.Z >= AudioEmitter.MinHeightLimit;
		bInsideSplineChanged = bInsideSpline != AudioEmitter.bInsideSpline;
		bInsideSplineRangeChanged = bInsideSplineRange != AudioEmitter.bInsideSplineRange;
	}
}
