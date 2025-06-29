using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using b1.Plugins.DonAINavigation;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_JJSObstacleComp : UActorCompBaseCS
{
	private int LastLoopAudioHandle;

	private BUC_JJSObstacleData JJSObstacleData { get; set; }

	private List<TWeakObject<UPrimitiveComponent>> OpenStateComponents { get; } = new List<TWeakObject<UPrimitiveComponent>>();

	private List<TWeakObject<UPrimitiveComponent>> CloseStateComponents { get; } = new List<TWeakObject<UPrimitiveComponent>>();

	public override void OnAttach()
	{
		base.OnAttach();
		base.BUSEventCollection.Evt_HitJJSObstacle += new Del_Void_Int(OnHitJJSObstacle);
		base.BUSEventCollection.Evt_SwitchJJSObstacleState += new Del_Void_Bool(OnSwitchJJSObstacleState);
		base.BUSEventCollection.Evt_CircusRootDead += new Del_Void(OnCircusRootDead);
		JJSObstacleData = RequireWritableData<BUC_JJSObstacleData>();
		List<UActorComponent> componentsByClass = Owner.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>());
		OpenStateComponents.Clear();
		CloseStateComponents.Clear();
		foreach (UActorComponent item in componentsByClass)
		{
			if (item.ComponentHasTag(JJSObstacleData.OpenState))
			{
				OpenStateComponents.Add(new TWeakObject<UPrimitiveComponent>(item as UPrimitiveComponent));
			}
			if (item.ComponentHasTag(JJSObstacleData.CloseState))
			{
				CloseStateComponents.Add(new TWeakObject<UPrimitiveComponent>(item as UPrimitiveComponent));
			}
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		EnterStateForce(JJSObstacleData.bDefaultEnable);
	}

	private void OnCircusRootDead()
	{
		EnterStateForce(JJSObstacleData.bDefaultEnable);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		OpenStateComponents.Clear();
		CloseStateComponents.Clear();
		base.OnEndPlay(EndPlayReason);
	}

	private void OnHitJJSObstacle(int EffectID)
	{
		if (JJSObstacleData.bOpenWhenSpecialSkillHit && JJSObstacleData.SpecialSkillList.Contains(EffectID))
		{
			EnterState(IsEnable: true);
		}
	}

	private void OnSwitchJJSObstacleState(bool IsEnable)
	{
		EnterState(IsEnable);
	}

	private void EnterState(bool IsEnable)
	{
		if (JJSObstacleData.bEnable != IsEnable)
		{
			EnterStateForce(IsEnable);
		}
	}

	private void EnterStateForce(bool IsEnable)
	{
		JJSObstacleData.bEnable = IsEnable;
		foreach (TWeakObject<UPrimitiveComponent> openStateComponent in OpenStateComponents)
		{
			if (!openStateComponent.IsValid())
			{
				continue;
			}
			UPrimitiveComponent uPrimitiveComponent = openStateComponent.Get();
			if (uPrimitiveComponent is UNiagaraComponent uNiagaraComponent)
			{
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, !IsEnable);
				continue;
			}
			uPrimitiveComponent?.SetCollisionEnabled(IsEnable ? ECollisionEnabled.QueryAndPhysics : ECollisionEnabled.NoCollision);
			if (uPrimitiveComponent is UShapeComponent collision)
			{
				UGSE_NavigationFuncLib.SetCollisionNavAreaClass(collision, IsEnable ? UClass.GetClass<UNavArea_Obstacle>() : UClass.GetClass<UNavArea_Default>());
			}
			UDonNavigationHelper.OnUpdateDynamicCollision(uPrimitiveComponent, JJSObstacleData.bEnableDebug);
			uPrimitiveComponent.SetVisibility(IsEnable);
		}
		foreach (TWeakObject<UPrimitiveComponent> closeStateComponent in CloseStateComponents)
		{
			if (!closeStateComponent.IsValid())
			{
				continue;
			}
			UPrimitiveComponent uPrimitiveComponent2 = closeStateComponent.Get();
			if (uPrimitiveComponent2 is UNiagaraComponent uNiagaraComponent2)
			{
				uNiagaraComponent2.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, IsEnable);
				continue;
			}
			uPrimitiveComponent2?.SetCollisionEnabled((!IsEnable) ? ECollisionEnabled.QueryAndPhysics : ECollisionEnabled.NoCollision);
			if (uPrimitiveComponent2 is UShapeComponent collision2)
			{
				UGSE_NavigationFuncLib.SetCollisionNavAreaClass(collision2, IsEnable ? UClass.GetClass<UNavArea_Default>() : UClass.GetClass<UNavArea_Obstacle>());
			}
			UDonNavigationHelper.OnUpdateDynamicCollision(uPrimitiveComponent2, JJSObstacleData.bEnableDebug);
			uPrimitiveComponent2.SetVisibility(!IsEnable);
		}
		Owner.GetAttachedActors(out var OutActors);
		foreach (AActor item in OutActors)
		{
			if (item.ActorHasTag(JJSObstacleData.OpenState))
			{
				if (item is ABGWEnvironmentSurfaceVolume obj)
				{
					TSoftObject<ABGWEnvironmentSurfaceVolume> volumeRef = new TSoftObject<ABGWEnvironmentSurfaceVolume>(obj);
					base.BGSEventCollection.Evt_BGS_SetEnvironmentSurfaceVolumeEnabled.Invoke(volumeRef, IsEnable, IsDisableVolume: false);
				}
			}
			else if (item.ActorHasTag(JJSObstacleData.CloseState) && item is ABGWEnvironmentSurfaceVolume obj2)
			{
				TSoftObject<ABGWEnvironmentSurfaceVolume> volumeRef2 = new TSoftObject<ABGWEnvironmentSurfaceVolume>(obj2);
				base.BGSEventCollection.Evt_BGS_SetEnvironmentSurfaceVolumeEnabled.Invoke(volumeRef2, !IsEnable, IsDisableVolume: false);
			}
		}
		if (LastLoopAudioHandle != 0)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(LastLoopAudioHandle, 0, 0);
		}
		if (IsEnable)
		{
			if (JJSObstacleData.OpenStateFx != null)
			{
				UNiagaraFunctionLibrary.SpawnSystemAttached(JJSObstacleData.OpenStateFx, Owner.GetRootComponent(), FName.None, JJSObstacleData.OpenFxTransform.Translation, JJSObstacleData.OpenFxTransform.Rotation.Quat_Rotator(), EAttachLocation.SnapToTarget, bAutoDestroy: true).SetRelativeScale3D(JJSObstacleData.OpenFxTransform.Scale3D);
			}
			if (JJSObstacleData.OpenStateAudio != null)
			{
				UAkGameplayStatics.PostEvent(JJSObstacleData.OpenStateAudio, Owner, 0, null);
			}
			if (JJSObstacleData.OpenStateLoopAudio != null)
			{
				LastLoopAudioHandle = UAkGameplayStatics.PostEvent(JJSObstacleData.OpenStateLoopAudio, Owner, 0, null);
			}
		}
		else
		{
			if (JJSObstacleData.CloseStateFx != null)
			{
				UNiagaraFunctionLibrary.SpawnSystemAttached(JJSObstacleData.CloseStateFx, Owner.GetRootComponent(), FName.None, JJSObstacleData.CloseFxTransform.Translation, JJSObstacleData.CloseFxTransform.Rotation.Quat_Rotator(), EAttachLocation.SnapToTarget, bAutoDestroy: true).SetRelativeScale3D(JJSObstacleData.CloseFxTransform.Scale3D);
			}
			if (JJSObstacleData.CloseStateAudio != null)
			{
				UAkGameplayStatics.PostEvent(JJSObstacleData.CloseStateAudio, Owner, 0, null);
			}
			if (JJSObstacleData.CloseStateLoopAudio != null)
			{
				LastLoopAudioHandle = UAkGameplayStatics.PostEvent(JJSObstacleData.CloseStateLoopAudio, Owner, 0, null);
			}
		}
	}
}
