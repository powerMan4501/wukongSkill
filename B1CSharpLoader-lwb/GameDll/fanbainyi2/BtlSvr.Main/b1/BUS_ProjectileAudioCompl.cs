using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProjectileAudioCompl : UActorCompBaseCS
{
	private BUC_ProjectileAudioData ProjectileAudioData { get; set; }

	public override void OnAttach()
	{
		ProjectileAudioData = RequireWritableData<BUC_ProjectileAudioData>();
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnProjectileDead);
	}

	public override void OnBeginPlay()
	{
		DoPlayAudio(ProjectileAudioData.LoopEvent);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DurationTimeAkEventTick(DeltaTime);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		foreach (UAkEventConfig stopWhenDeadAkEvent in ProjectileAudioData.StopWhenDeadAkEvents)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(stopWhenDeadAkEvent.PlayingId, stopWhenDeadAkEvent.FadeOutTimeMs, (int)stopWhenDeadAkEvent.CurveInterpolation);
		}
		foreach (UAkEventConfig key in ProjectileAudioData.StopByTimeAkEvents.Keys)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(key.PlayingId, key.FadeOutTimeMs, (int)key.CurveInterpolation);
		}
		ProjectileAudioData.StopWhenDeadAkEvents.Clear();
		ProjectileAudioData.StopByTimeAkEvents.Clear();
	}

	private void OnProjectileDead(EBGUBulletDestroyReason Reason)
	{
		DoPlayAudio(ProjectileAudioData.DeadEvent);
		foreach (UAkEventConfig stopWhenDeadAkEvent in ProjectileAudioData.StopWhenDeadAkEvents)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(stopWhenDeadAkEvent.PlayingId, stopWhenDeadAkEvent.FadeOutTimeMs, (int)stopWhenDeadAkEvent.CurveInterpolation);
		}
		ProjectileAudioData.StopWhenDeadAkEvents.Clear();
	}

	private void DurationTimeAkEventTick(float InDeltaSeconds)
	{
		ProjectileAudioData.ExpireEvents.Clear();
		foreach (KeyValuePair<UAkEventConfig, float> stopByTimeAkEvent in ProjectileAudioData.StopByTimeAkEvents)
		{
			UAkEventConfig key = stopByTimeAkEvent.Key;
			ProjectileAudioData.StopByTimeAkEvents[key] -= InDeltaSeconds;
			if (stopByTimeAkEvent.Value <= 1E-08f)
			{
				UBGUFunctionLibAK.BGUAKStopPlayingID(key.PlayingId, key.FadeOutTimeMs, (int)key.CurveInterpolation);
				ProjectileAudioData.ExpireEvents.Add(key);
			}
		}
		foreach (UAkEventConfig expireEvent in ProjectileAudioData.ExpireEvents)
		{
			ProjectileAudioData.StopByTimeAkEvents.Remove(expireEvent);
		}
		ProjectileAudioData.StopByTimeAkEvents.Clear();
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
			ProjectileAudioData.StopWhenDeadAkEvents.Add(InAkEventConfig);
			break;
		case EAkEventStopMode.ByTime:
			ProjectileAudioData.StopByTimeAkEvents.Add(InAkEventConfig, (float)InAkEventConfig.StopTimeMs / 1000f);
			break;
		}
	}
}
