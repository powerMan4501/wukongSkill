using System;
using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_TransEffectSystem : GameStateSystemBase
{
	private BGC_TransEffectData TransEffectData { get; set; }

	public override void OnAttach()
	{
		TransEffectData = RequireWritableData<BGC_TransEffectData>();
		base.BGSEventCollection.Evt_TriggerTransEffect += new Del_BGS_TriggerTransEffect(OnTriggerTransEffect);
		base.BGSEventCollection.Evt_BGS_OnUnitTransited += new Del_BGS_OnUnitTransited(OnTransEffectUnitChange);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_TriggerAttackStiff = (Del_Void_ActorActorInt)Delegate.Combine(bGWEventCollection.Evt_BGW_TriggerAttackStiff, new Del_Void_ActorActorInt(OnTriggerAttackStiff));
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_TriggerAttackStiff = (Del_Void_ActorActorInt)Delegate.Remove(bGWEventCollection.Evt_BGW_TriggerAttackStiff, new Del_Void_ActorActorInt(OnTriggerAttackStiff));
	}

	public override void OnBeginPlay()
	{
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		for (int num = TransEffectData.TransEffectInfo.Count - 1; num >= 0; num--)
		{
			FGSTransEffectInfo fGSTransEffectInfo = TransEffectData.TransEffectInfo[num];
			fGSTransEffectInfo.Duration -= DeltaTime;
			if (fGSTransEffectInfo.Duration < 0f)
			{
				DeactivateTransEffect(fGSTransEffectInfo);
			}
			else
			{
				UpdateUnitLocation(fGSTransEffectInfo);
			}
		}
	}

	private void UpdateUnitLocation(FGSTransEffectInfo Info)
	{
		if (!(Info.TransEffect == null))
		{
			FVector inValue = FVector.ZeroVector;
			if (Info != null && Info.Unit != null)
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Info.Unit);
				inValue = fVector - Info.UnitLocation;
				Info.UnitLocation = fVector;
			}
			Info.TransEffect.SetVariableVec3(B1GlobalFNames.DeltaPosition, inValue);
		}
	}

	private void OnTriggerTransEffect(ACharacter Unit, string DataAssetPath, FVector EffectOffset)
	{
		BGWDataAsset_TransEffectSetting bGWDataAsset_TransEffectSetting = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_TransEffectSetting>(DataAssetPath, ELoadResourceType.SyncLoadAndCache);
		if (!(Unit == null) && !(bGWDataAsset_TransEffectSetting == null) && !(bGWDataAsset_TransEffectSetting.TransEffect == null))
		{
			CheckAndRefreshCurPreExposure(Unit);
			FVector location = Unit.Mesh.GetWorldLocation() + Unit.Mesh.GetWorldRotation().RotateVector(EffectOffset);
			UNiagaraComponent uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAtLocation(Unit, bGWDataAsset_TransEffectSetting.TransEffect, location, FRotator.ZeroRotator, FVector.OneVector, bAutoDestroy: true, bAutoActivate: false, ENCPoolMethod.None, bPreCullCheck: true);
			if (!(uNiagaraComponent == null))
			{
				uNiagaraComponent.SetFloatParameter(new FName("GS_FixedExposure"), TransEffectData.CurPreExposure);
				FGSTransEffectInfo fGSTransEffectInfo = new FGSTransEffectInfo(uNiagaraComponent);
				TransEffectData.TransEffectInfo.Add(fGSTransEffectInfo);
				SetTransEffectParam(fGSTransEffectInfo, Unit, WaitingDestinationUnit: true, bGWDataAsset_TransEffectSetting);
			}
		}
	}

	private void OnTransEffectUnitChange(AActor OldUnit, AActor NewUnit)
	{
		ACharacter OriginUnit = OldUnit as ACharacter;
		ACharacter aCharacter = NewUnit as ACharacter;
		if (!(OriginUnit == null) && !(aCharacter == null))
		{
			FGSTransEffectInfo fGSTransEffectInfo = TransEffectData.TransEffectInfo.Find((FGSTransEffectInfo r) => r.Unit == OriginUnit && !r.WaitingDestinationUnit);
			if (fGSTransEffectInfo != null)
			{
				DeactivateTransEffect(fGSTransEffectInfo);
			}
			fGSTransEffectInfo = TransEffectData.TransEffectInfo.Find((FGSTransEffectInfo r) => r.Unit == OriginUnit && r.WaitingDestinationUnit);
			if (fGSTransEffectInfo != null)
			{
				SetTransEffectParam(fGSTransEffectInfo, aCharacter, WaitingDestinationUnit: false);
			}
		}
	}

	private void SetTransEffectParam(FGSTransEffectInfo Info, ACharacter Unit, bool WaitingDestinationUnit, BGWDataAsset_TransEffectSetting TransEffectSetting = null)
	{
		UNiagaraComponent transEffect = Info.TransEffect;
		if (transEffect == null || Unit == null || Unit.Mesh == null)
		{
			return;
		}
		Info.Unit = Unit;
		Info.UnitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
		UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(transEffect, "SampledMesh", Unit.Mesh);
		transEffect.AttachToComponent(Unit.Mesh, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
		transEffect.Activate();
		if (TransEffectSetting != null)
		{
			Info.Duration = TransEffectSetting.Duration;
			transEffect.SetFloatParameter(B1GlobalFNames.Duration, TransEffectSetting.Duration);
			TArrayReadWrite<FGSNiagaraSysParam> niagaraParams = TransEffectSetting.NiagaraParams;
			for (int i = 0; i < niagaraParams.Count; i++)
			{
				FName name = niagaraParams[i].Name;
				switch (niagaraParams[i].ParamType)
				{
				case EGSNiagaraSysParamType.GSNPT_Float:
					transEffect.SetVariableFloat(name, niagaraParams[i].FloatValue);
					break;
				case EGSNiagaraSysParamType.GSNPT_Int:
					transEffect.SetVariableInt(name, niagaraParams[i].IntValue);
					break;
				case EGSNiagaraSysParamType.GSNPT_Vector:
					transEffect.SetVariableVec3(name, niagaraParams[i].VectorValue);
					break;
				case EGSNiagaraSysParamType.GSNPT_Bool:
					transEffect.SetVariableBool(name, niagaraParams[i].BoolValue);
					break;
				case EGSNiagaraSysParamType.GSNPT_LinearColor:
					transEffect.SetVariableLinearColor(name, niagaraParams[i].LinearColorValue);
					break;
				}
			}
		}
		Info.WaitingDestinationUnit = WaitingDestinationUnit;
	}

	private void DeactivateTransEffect(FGSTransEffectInfo Info)
	{
		if (Info.TransEffect != null)
		{
			Info.TransEffect.Deactivate();
			Info.TransEffect.DestroyComponent(Info.TransEffect);
		}
		TransEffectData.TransEffectInfo.Remove(Info);
	}

	private void OnTriggerAttackStiff(AActor Victim, AActor Attacker, int StiffLevel)
	{
		if (TransEffectData.TransEffectInfo.Count != 0)
		{
			FGSTransEffectInfo fGSTransEffectInfo = TransEffectData.TransEffectInfo.Find((FGSTransEffectInfo r) => r.Unit == Victim);
			if (fGSTransEffectInfo != null && fGSTransEffectInfo.TransEffect != null)
			{
				fGSTransEffectInfo.TransEffect.SetVariableInt(B1GlobalFNames.BeAttacked, 1);
			}
		}
	}

	private void CheckAndRefreshCurPreExposure(AActor Unit)
	{
		if (TransEffectData.TransEffectInfo.Count == 0)
		{
			float sceneViewPreExposure = UGSE_RenderUtilFuncLib.GetSceneViewPreExposure(Unit);
			TransEffectData.CurPreExposure = ((sceneViewPreExposure <= 0.001f) ? 1f : sceneViewPreExposure);
		}
	}
}
