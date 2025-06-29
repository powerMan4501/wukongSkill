using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_BulletDonutAudioComp : UActorCompBaseCS
{
	private BUC_BulletDonutAudioData DonutAudioData { get; set; }

	public override void OnAttach()
	{
		DonutAudioData = RequireWritableData<BUC_BulletDonutAudioData>();
		base.BUSEventCollection.Evt_OnUpdateBulletRingFX += new Del_Void_FloatFloat(OnUpdateRingFX);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnProjectileDead);
	}

	public override void OnBeginPlay()
	{
		if ((!(DonutAudioData.DonutAudio == null) || DonutAudioData.DonutAudioLocationType == EDonutBulletAudioLocationType.None) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.Mute))
		{
			DoPlayAudio();
		}
	}

	private void OnUpdateRingFX(float RingInnerRadius, float RingOuterRadius)
	{
		if (!IsAudioValid())
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn() as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			FVector safeNormal = (BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) - fVector).GetSafeNormal();
			float num = 0f;
			switch (DonutAudioData.DonutAudioLocationType)
			{
			case EDonutBulletAudioLocationType.InnerBorder:
				num = RingInnerRadius;
				break;
			case EDonutBulletAudioLocationType.OuterBorder:
				num = RingOuterRadius;
				break;
			case EDonutBulletAudioLocationType.Between:
				num = (RingInnerRadius + RingOuterRadius) / 2f;
				break;
			}
			FVector newLocation = fVector + safeNormal * num;
			FVector newLocation2 = fVector - safeNormal * num;
			DonutAudioData.NearestAkCompPtr.Get().SetWorldLocation(newLocation, bSweep: false, out var SweepHitResult, bTeleport: false);
			DonutAudioData.FarthestAkCompPtr.Get().SetWorldLocation(newLocation2, bSweep: false, out SweepHitResult, bTeleport: false);
		}
	}

	private void OnProjectileDead(EBGUBulletDestroyReason Reason)
	{
		if (IsAudioValid() && DonutAudioData.StopMode == EAkEventStopMode.WhenUnitDead)
		{
			StopAudio();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!IsAudioValid())
		{
			return;
		}
		if (DonutAudioData.StopMode == EAkEventStopMode.ByTime)
		{
			DonutAudioData.RemainPlayingTime -= DeltaTime;
			if (DonutAudioData.RemainPlayingTime <= 1E-08f)
			{
				StopAudio();
			}
		}
		if (DebugConfig.DebugDonutAudio)
		{
			DrawDebugPosition(DonutAudioData.NearestAkCompPtr.Get());
			DrawDebugPosition(DonutAudioData.FarthestAkCompPtr.Get());
		}
	}

	private void DrawDebugPosition(UAkComponent InAkComponent)
	{
		if (!(InAkComponent == null))
		{
			BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn() as BGUCharacterCS;
			if (!(bGUCharacterCS == null))
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
				FVector worldLocation = InAkComponent.GetWorldLocation();
				USystemLibrary.DrawDebugConeInDegrees(GetOwner(), worldLocation, fVector - worldLocation, 100f, 45f, 45f, 12, FLinearColor.White, 0f, 2f);
				USystemLibrary.DrawDebugSphere(GetOwner(), worldLocation, 10f, 12, FLinearColor.Blue, 0f, 4f);
			}
		}
	}

	private void StopAudio()
	{
		UBGUFunctionLibAK.BGUAKStopPlayingID(DonutAudioData.NearestPlayingID, DonutAudioData.FadeOutTimeMs, (int)DonutAudioData.CurveInterpolation);
		UBGUFunctionLibAK.BGUAKStopPlayingID(DonutAudioData.FarthestPlayingID, DonutAudioData.FadeOutTimeMs, (int)DonutAudioData.CurveInterpolation);
		DonutAudioData.NearestAkCompPtr = TWeakObject<UAkComponent>.Null;
		DonutAudioData.FarthestAkCompPtr = TWeakObject<UAkComponent>.Null;
	}

	private void DoPlayAudio()
	{
		UAkComponent uAkComponent = UGSE_ActorFuncLib.AddComponentByClass(Owner, UClass.GetClass<UAkComponent>(), bManualAttachment: false, FTransform.Identity, bDeferredFinish: false) as UAkComponent;
		UAkComponent uAkComponent2 = UGSE_ActorFuncLib.AddComponentByClass(Owner, UClass.GetClass<UAkComponent>(), bManualAttachment: false, FTransform.Identity, bDeferredFinish: false) as UAkComponent;
		if (!(uAkComponent == null) && !(uAkComponent2 == null))
		{
			uAkComponent.SetAutoDestroyCS(_bAutoDestory: true);
			uAkComponent2.SetAutoDestroyCS(_bAutoDestory: true);
			DonutAudioData.NearestPlayingID = uAkComponent.PostAkEvent(DonutAudioData.DonutAudio, 0, null, null);
			DonutAudioData.FarthestPlayingID = uAkComponent2.PostAkEvent(DonutAudioData.DonutAudio, 0, null, null);
			DonutAudioData.NearestAkCompPtr = new TWeakObject<UAkComponent>(uAkComponent);
			DonutAudioData.FarthestAkCompPtr = new TWeakObject<UAkComponent>(uAkComponent2);
			if (DonutAudioData.StopMode == EAkEventStopMode.ByTime)
			{
				DonutAudioData.RemainPlayingTime = (float)DonutAudioData.StopTimeMs / 1000f;
			}
		}
	}

	private bool IsAudioValid()
	{
		if (DonutAudioData.NearestAkCompPtr.IsValid())
		{
			return DonutAudioData.FarthestAkCompPtr.IsValid();
		}
		return false;
	}
}
