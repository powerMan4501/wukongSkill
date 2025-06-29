using System.Collections.Generic;
using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "（停止维护）亢金龙巡游随机闪电" })]
[StopMaintenance]
public class BUEffectPCSEW_KJLRandomLightning : BUEffectTemplate
{
	public BUEffectPCSEW_KJLRandomLightning()
	{
		EffectType = EBuffAndSkillEffectType.KjlrandomLightning;
	}

	[ParamInfoS(0, "DA_PCSEW_KJLRandomLightningConfig 路径")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Target);
		if (skillEffectDesc.EffectParamsStr.Count >= 1)
		{
			string path = skillEffectDesc.EffectParamsStr[0];
			DA_PCSEW_KJLRandomLightningConfig dA_PCSEW_KJLRandomLightningConfig = new DA_PCSEW_KJLRandomLightningConfig();
			dA_PCSEW_KJLRandomLightningConfig = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<DA_PCSEW_KJLRandomLightningConfig>(path, ELoadResourceType.SyncLoadAndCache);
			if (!(dA_PCSEW_KJLRandomLightningConfig == null))
			{
				AActor controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Caster).GetControlledPawn();
				KJLSpawnProjectile(Target, controlledPawn, dA_PCSEW_KJLRandomLightningConfig.PointGeneratorTag, dA_PCSEW_KJLRandomLightningConfig.BulletID, dA_PCSEW_KJLRandomLightningConfig.LimitDistance_ToPlayer, dA_PCSEW_KJLRandomLightningConfig.LightningBeam, dA_PCSEW_KJLRandomLightningConfig.LightningEndParamName, dA_PCSEW_KJLRandomLightningConfig.SocketList.ToList(), dA_PCSEW_KJLRandomLightningConfig.DummyBulletNum, dA_PCSEW_KJLRandomLightningConfig.EndPos_Noise, dA_PCSEW_KJLRandomLightningConfig.DummyFXCompTag, null, dA_PCSEW_KJLRandomLightningConfig.DummyActiveDistance, dA_PCSEW_KJLRandomLightningConfig.RandomInterval);
			}
		}
	}

	[ParamInfoS(0, "DA_PCSEW_KJLRandomLightningConfig 路径")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			DA_PCSEW_KJLRandomLightningConfig dA_PCSEW_KJLRandomLightningConfig = new DA_PCSEW_KJLRandomLightningConfig();
			dA_PCSEW_KJLRandomLightningConfig = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<DA_PCSEW_KJLRandomLightningConfig>(stringEffectParam, ELoadResourceType.SyncLoadAndCache);
			if (!(dA_PCSEW_KJLRandomLightningConfig == null))
			{
				AActor controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Target).GetControlledPawn();
				KJLSpawnProjectile(Target, controlledPawn, dA_PCSEW_KJLRandomLightningConfig.PointGeneratorTag, dA_PCSEW_KJLRandomLightningConfig.BulletID, dA_PCSEW_KJLRandomLightningConfig.LimitDistance_ToPlayer, dA_PCSEW_KJLRandomLightningConfig.LightningBeam, dA_PCSEW_KJLRandomLightningConfig.LightningEndParamName, dA_PCSEW_KJLRandomLightningConfig.SocketList.ToList(), dA_PCSEW_KJLRandomLightningConfig.DummyBulletNum, dA_PCSEW_KJLRandomLightningConfig.EndPos_Noise, dA_PCSEW_KJLRandomLightningConfig.DummyFXCompTag, null, dA_PCSEW_KJLRandomLightningConfig.DummyActiveDistance, dA_PCSEW_KJLRandomLightningConfig.RandomInterval);
			}
		}
	}

	public static void KJLSpawnProjectile(AActor BulletSpawner, AActor Target, string PointGeneratorTag, int BulletID, float LimitDistance_ToPlayer, UNiagaraSystem LightningBeam, string LightningEndParamName, List<string> SocketList, int DummyBulletNum, FVector EndPos_Noise, FName DummyNiagaraTag, UNiagaraComponent DummyNiagara, float DummyActiveDistance, FVector2D RandomInterval)
	{
		if (BulletSpawner == null || Target == null)
		{
			return;
		}
		FVector actorLocation = BulletSpawner.GetActorLocation();
		FVector actorLocation2 = Target.GetActorLocation();
		float num = FVector.Distance(actorLocation, actorLocation2);
		List<UActorComponent> componentsByTag = BulletSpawner.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), DummyNiagaraTag);
		if (num > DummyActiveDistance)
		{
			foreach (UActorComponent item in componentsByTag)
			{
				UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
				if (uNiagaraComponent != null && !uNiagaraComponent.IsVisible())
				{
					uNiagaraComponent.Visible = true;
				}
			}
			return;
		}
		foreach (UActorComponent item2 in componentsByTag)
		{
			UNiagaraComponent uNiagaraComponent2 = item2 as UNiagaraComponent;
			if (uNiagaraComponent2 != null && uNiagaraComponent2.IsVisible())
			{
				uNiagaraComponent2.Visible = false;
			}
		}
		Target.World.GetAllActorsOfClassWithTag(UClass.GetClass<BGU_EQSPointRecorderActor>(), new FName(PointGeneratorTag), out var OutActors);
		if (OutActors.Count < 1)
		{
			return;
		}
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = OutActors[0] as BGU_EQSPointRecorderActor;
		if (bGU_EQSPointRecorderActor == null)
		{
			return;
		}
		List<FVector> list = new List<FVector>();
		foreach (FVector eQSPoint in bGU_EQSPointRecorderActor.EQSPoints)
		{
			list.Add(eQSPoint);
		}
		foreach (FVector customPoint in bGU_EQSPointRecorderActor.CustomPoints)
		{
			list.Add(customPoint);
		}
		if (list.Count < 1)
		{
			return;
		}
		List<FVector> list2 = new List<FVector>();
		LimitDistance_ToPlayer = FMath.Max(100f, LimitDistance_ToPlayer);
		FVector fVector = Target.GetActorLocation();
		if (bGU_EQSPointRecorderActor.InLocalMode())
		{
			FTransform actorTransform = bGU_EQSPointRecorderActor.RelativeTarget.GetActorTransform();
			actorTransform.Scale3D = FVector.OneVector;
			fVector = actorTransform.InverseTransformLocation(fVector);
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (FVector.Distance(list[i], fVector) < LimitDistance_ToPlayer)
			{
				list2.Add(list[i]);
			}
		}
		if (list2.Count < 1)
		{
			return;
		}
		List<FVector> list3 = new List<FVector>();
		list3.Add(FVector.ZeroVector);
		for (int j = 0; j < DummyBulletNum; j++)
		{
			if (list2.Count < 1)
			{
				break;
			}
			int index = FMath.RandRange(0, list2.Count - 1);
			if (bGU_EQSPointRecorderActor.InLocalMode())
			{
				FTransform actorTransform2 = bGU_EQSPointRecorderActor.RelativeTarget.GetActorTransform();
				actorTransform2.Scale3D = FVector.OneVector;
				list3.Add(actorTransform2.TransformLocation(list2[index]));
			}
			else
			{
				list3.Add(list2[index]);
			}
			list2.RemoveAt(index);
		}
		float num2 = 0f;
		int num3 = list3.Count;
		while (num3 > 0)
		{
			num3--;
			if (list3.Count < 1)
			{
				break;
			}
			string lightningStartSocketName = "root";
			if (SocketList.Count > 0)
			{
				int index2 = FMath.RandRange(0, SocketList.Count - 1);
				lightningStartSocketName = SocketList[index2];
				SocketList.RemoveAt(index2);
			}
			int index3 = FMath.RandRange(0, list3.Count - 1);
			FVector fVector2 = list3[index3];
			list3.RemoveAt(index3);
			FTimerManager fTimerManager = FTimerManager.PIEWorld ?? FTimerManager.GameInstance;
			if (fTimerManager != null)
			{
				PCSEW_KJLRandomLightning pCSEW_KJLRandomLightning = UObject.NewObject<PCSEW_KJLRandomLightning>(BulletSpawner);
				pCSEW_KJLRandomLightning.Init(BulletSpawner);
				pCSEW_KJLRandomLightning.InitData(BulletID, fVector2, EndPos_Noise, lightningStartSocketName, LightningBeam, LightningEndParamName, fVector2 != FVector.ZeroVector, Target);
				if (num2 <= 0f)
				{
					pCSEW_KJLRandomLightning.MainThread();
				}
				else
				{
					fTimerManager.SetTimer(pCSEW_KJLRandomLightning, "MainThread", num2);
				}
				num2 += FMath.FRandRange(RandomInterval.X, RandomInterval.Y);
			}
		}
	}
}
