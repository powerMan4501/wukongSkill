using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_FXAkComp : UActorCompBaseCS
{
	private BUC_FXActorAudioData AudioData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		AudioData = RequireWritableData<BUC_FXActorAudioData>();
		base.BUSEventCollection.Evt_DestroyDestructible += new Del_DestroyDestructible(OnDestroyDestructible);
		SetCanTick(Val: false);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		DoPlayAudio(AudioData.LoopEvent);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		foreach (UAkEventConfig stopWhenDeadAkEvent in AudioData.StopWhenDeadAkEvents)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(stopWhenDeadAkEvent.PlayingId, stopWhenDeadAkEvent.FadeOutTimeMs, (int)stopWhenDeadAkEvent.CurveInterpolation);
		}
		foreach (UAkEventConfig key in AudioData.StopByTimeAkEvents.Keys)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(key.PlayingId, key.FadeOutTimeMs, (int)key.CurveInterpolation);
		}
		AudioData.StopWhenDeadAkEvents.Clear();
		AudioData.StopByTimeAkEvents.Clear();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DurationTimeAkEventTick(DeltaTime);
	}

	private void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength)
	{
		DoPlayAudio(AudioData.DestructibleEvent);
		foreach (UAkEventConfig stopWhenDeadAkEvent in AudioData.StopWhenDeadAkEvents)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(stopWhenDeadAkEvent.PlayingId, stopWhenDeadAkEvent.FadeOutTimeMs, (int)stopWhenDeadAkEvent.CurveInterpolation);
		}
		AudioData.StopWhenDeadAkEvents.Clear();
	}

	private void DurationTimeAkEventTick(float InDeltaSeconds)
	{
		AudioData.ExpireEvents.Clear();
		foreach (KeyValuePair<UAkEventConfig, float> stopByTimeAkEvent in AudioData.StopByTimeAkEvents)
		{
			UAkEventConfig key = stopByTimeAkEvent.Key;
			AudioData.StopByTimeAkEvents[key] -= InDeltaSeconds;
			if (stopByTimeAkEvent.Value <= 1E-08f)
			{
				UBGUFunctionLibAK.BGUAKStopPlayingID(key.PlayingId, key.FadeOutTimeMs, (int)key.CurveInterpolation);
				AudioData.ExpireEvents.Add(key);
			}
		}
		foreach (UAkEventConfig expireEvent in AudioData.ExpireEvents)
		{
			AudioData.StopByTimeAkEvents.Remove(expireEvent);
		}
		if (AudioData.StopByTimeAkEvents.Count == 0)
		{
			SetCanTick(Val: false);
		}
	}

	private void DoPlayAudio(UAkEventConfig InAkEventConfig)
	{
		if (InAkEventConfig.AkEvent == null || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.Mute))
		{
			return;
		}
		if (InAkEventConfig.bFollowAttachPoint)
		{
			bool ComponentCreated;
			UAkComponent akComponent = UAkGameplayStatics.GetAkComponent(GetOwner().GetRootComponent(), out ComponentCreated, InAkEventConfig.AttachPointName, FVector.ZeroVector, EAttachLocation.SnapToTarget);
			if (ComponentCreated)
			{
				akComponent.OcclusionCollisionChannel = (EAkCollisionChannel)27;
				akComponent.SetAutoDestroyCS(_bAutoDestory: true);
			}
			if (akComponent == null)
			{
				return;
			}
			InAkEventConfig.PlayingId = akComponent.PostAkEvent(InAkEventConfig.AkEvent, 0, null, null);
		}
		else
		{
			FTransform actorTransform = GetOwner().GetActorTransform();
			InAkEventConfig.PlayingId = UAkGameplayStatics.PostEventAtLocation(InAkEventConfig.AkEvent, actorTransform.GetLocation(), actorTransform.GetRotation().Rotator(), null, GetOwner());
		}
		switch (InAkEventConfig.StopMode)
		{
		case EAkEventStopMode.WhenUnitDead:
			AudioData.StopWhenDeadAkEvents.Add(InAkEventConfig);
			break;
		case EAkEventStopMode.ByTime:
			AudioData.StopByTimeAkEvents.Add(InAkEventConfig, (float)InAkEventConfig.StopTimeMs / 1000f);
			SetCanTick(Val: true);
			break;
		}
	}
}
