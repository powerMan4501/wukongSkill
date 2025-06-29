using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MFEffectComp : UActorCompBaseCS
{
	protected BUC_ProjectileBasicData ProjectileBasicData { get; set; }

	protected IBUC_MFOverlapData MFOverlapData { get; set; }

	protected IBUC_MasterData MasterData { get; set; }

	protected IBUC_RenderTargetMgrData RenderTargetMgrData { get; set; }

	private BUC_MFEffectData MFEffectData { get; set; }

	public override void OnAttach()
	{
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		MFOverlapData = RequireReadOnlyData<IBUC_MFOverlapData, BUC_MFOverlapData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		RenderTargetMgrData = RequireReadOnlyData<IBUC_RenderTargetMgrData, BUC_RenderTargetMgrData>();
		MFEffectData = RequireWritableData<BUC_MFEffectData>();
		base.BUSEventCollection.Evt_TriggerMagicFieldEffect += new Del_TriggerMagicFieldEffect(TriggerMagicFieldEffect);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnMagicFieldDead);
		base.BUSEventCollection.Evt_AddFieldBuff2Target += new Del_Void_ActorFieldBuffList(AddFieldBuff);
		base.BUSEventCollection.Evt_RemoveFieldBuff2Target += new Del_Void_ActorFieldBuffList(RemoveFieldBuff);
	}

	private void OnMagicFieldDead(EBGUBulletDestroyReason reason)
	{
	}

	private void TriggerMagicFieldEffect(AActor Target, bool bIgnoreFilter, int TargetTeamFilter, int TargetTypeFilter, List<MFEffectForData> MFEffectList)
	{
		BGUMagicFieldBaseCS bGUMagicFieldBaseCS = GetOwner() as BGUMagicFieldBaseCS;
		if (bGUMagicFieldBaseCS.IsNullOrDestroyed() || Target.IsNullOrDestroyed())
		{
			return;
		}
		if (Target is BGUWeaponBase bGUWeaponBase)
		{
			Target = bGUWeaponBase.GetAttachParentActor();
			if (Target.IsNullOrDestroyed())
			{
				return;
			}
		}
		if (!bIgnoreFilter && (!BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTeamFilter(bGUMagicFieldBaseCS, Target, TargetTeamFilter) || !BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTypeFilter(Target, TargetTypeFilter)))
		{
			return;
		}
		foreach (MFEffectForData MFEffect in MFEffectList)
		{
			switch (MFEffect.OverlapEventType)
			{
			case MFOverlapEventType.AddBuff:
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
				if (!(bUS_GSEventCollection != null))
				{
					break;
				}
				AActor masterActor2 = MasterData.GetMasterActor();
				foreach (GSBuffInfoForData buff in MFEffect.BuffList)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(buff.BuffID, masterActor2, masterActor2, buff.BuffDuration, EBuffSourceType.MFOverlapEvent);
				}
				break;
			}
			case MFOverlapEventType.RemoveBuffWithTriggerRemove:
			{
				BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(Target);
				if (!(bUS_GSEventCollection2 != null))
				{
					break;
				}
				foreach (GSBuffInfoForData buff2 in MFEffect.BuffList)
				{
					bUS_GSEventCollection2.Evt_BuffRemove.Invoke(buff2.BuffID, EBuffEffectTriggerType.None, 1);
				}
				break;
			}
			case MFOverlapEventType.RemoveBuffWithoutTriggerRemove:
			{
				BUS_GSEventCollection bUS_GSEventCollection5 = BUS_EventCollectionCS.Get(Target);
				if (!(bUS_GSEventCollection5 != null))
				{
					break;
				}
				foreach (GSBuffInfoForData buff3 in MFEffect.BuffList)
				{
					bUS_GSEventCollection5.Evt_BuffRemove.Invoke(buff3.BuffID, EBuffEffectTriggerType.None, 1, WithTriggerRemmoveEffect: false);
				}
				break;
			}
			case MFOverlapEventType.TriggerSkillEffect:
			{
				BUS_GSEventCollection bUS_GSEventCollection3 = BUS_EventCollectionCS.Get(bGUMagicFieldBaseCS);
				FEffectInstReq effectInstReq = new FEffectInstReq(GetOwner());
				foreach (int skillEffect in MFEffect.SkillEffectList)
				{
					effectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
					effectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Target);
					effectInstReq.HitActionDir = EHitActionDir.Default;
					bUS_GSEventCollection3.Evt_TriggerSkillEffect.Invoke(skillEffect, effectInstReq, Target);
				}
				break;
			}
			case MFOverlapEventType.DrawSign:
				if (Target == MasterData.GetMasterActor())
				{
					return;
				}
				TriggerDrawSignEffect(Target);
				break;
			case MFOverlapEventType.AddAvoidance:
			{
				BUS_GSEventCollection bUS_GSEventCollection6 = BUS_EventCollectionCS.Get(Target);
				if (bUS_GSEventCollection6 != null)
				{
					bUS_GSEventCollection6.Evt_AddAvoidanceMagicField.Invoke(GetOwner());
				}
				break;
			}
			case MFOverlapEventType.RemoveAvoidance:
			{
				BUS_GSEventCollection bUS_GSEventCollection4 = BUS_EventCollectionCS.Get(Target);
				if (bUS_GSEventCollection4 != null)
				{
					bUS_GSEventCollection4.Evt_RemoveAvoidanceMagicField.Invoke(GetOwner());
				}
				break;
			}
			case MFOverlapEventType.DestroyProjectileByFlag:
				if (Target is BGUProjectileBaseActor)
				{
					BUC_ProjectileBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileBasicData>(Target);
					if ((MFEffect.SpecificFlags & readOnlyData.ProjectileSpecificFlags) != 0)
					{
						BUS_EventCollectionCS.Get(Target).Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.EffectDestroy);
					}
				}
				break;
			case MFOverlapEventType.SetMastersTarget:
			{
				AActor masterActor = MasterData.GetMasterActor();
				if (Target == MasterData.GetMasterActor())
				{
					return;
				}
				BUS_EventCollectionCS.Get(masterActor)?.Evt_AICatchTarget.Invoke(Target, ETargetSourceType.Target_MagicFieldSetOverlapActorAsMasterTarget);
				break;
			}
			}
		}
	}

	protected void TriggerDrawSignEffect(AActor OverlappedActor)
	{
		List<AActor> list = new List<AActor>();
		list.Add(MasterData.GetMasterActor());
		list.Add(GetOwner());
		List<EObjectTypeQuery> list2 = new List<EObjectTypeQuery>();
		list2.Add(EObjectTypeQuery.ObjectTypeQuery3);
		list2.Add(EObjectTypeQuery.ObjectTypeQuery4);
		list2.Add(EObjectTypeQuery.ObjectTypeQuery2);
		FVector worldLocation = MFOverlapData.OverlapComp.GetWorldLocation();
		float? num = null;
		USphereComponent uSphereComponent = MFOverlapData.OverlapComp as USphereComponent;
		if (uSphereComponent != null)
		{
			num = uSphereComponent.GetScaledSphereRadius();
		}
		if (!CheckShapeTraceMultiForObjects(MFOverlapData.OverlapComp, ProjectileBasicData.CheckShapeType, list2, list, out var HitResults))
		{
			return;
		}
		Dictionary<AActor, RTParams> dictionary = new Dictionary<AActor, RTParams>();
		foreach (FHitResult item in HitResults)
		{
			UGameplayStatics.BreakHitResult(item, out var _, out var _, out var _, out var _, out var _, out var ImpactPoint, out var _, out var ImpactNormal, out var _, out var HitActor, out var HitComponent, out var _, out var _, out var _, out var _, out var _, out var _, out var _);
			HitActor = HitComponent.GetOwner();
			if (!(HitActor != OverlappedActor) && !(HitActor.Cast<AStaticMeshActor>() != null) && !(HitActor.Cast<BGUMagicFieldBaseCS>() != null))
			{
				_ = MFEffectData.bDebug;
				FVector translation = ImpactPoint;
				if (num.HasValue)
				{
					translation = (ImpactPoint - worldLocation).GetSafeNormal() * num.Value + worldLocation;
				}
				dictionary.Add(value: new RTParams
				{
					RemainingUpdateTime = 5f,
					HitDir = -1.0 * ImpactNormal,
					HitTransform = new FTransform(ImpactNormal.ToOrientationQuat(), translation),
					BeginAnimTime = GetOwner().World.GetTimeSeconds(),
					Strength = 10f
				}, key: HitActor);
				break;
			}
		}
		if (dictionary.Count == 0)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
		BGUMagicFieldBaseCS bGUMagicFieldBaseCS = Owner as BGUMagicFieldBaseCS;
		foreach (KeyValuePair<AActor, RTParams> item2 in dictionary)
		{
			if (!(bGUMagicFieldBaseCS != null) || bGUMagicFieldBaseCS.CheckDrawSignCondition(item2.Key))
			{
				RTParams value = item2.Value;
				List<FLinearColor> list3 = new List<FLinearColor>();
				List<float> list4 = new List<float>();
				list3.Add((value.HitTransform.GetLocation() - fVector).Conv_VectorToLinearColor());
				list3.Add(value.HitTransform.GetRotation().Vector().GetSafeNormal()
					.Conv_VectorToLinearColor());
				list3.Add(value.HitDir.Conv_VectorToLinearColor());
				list4.Add(value.Strength);
				list4.Add(value.BeginAnimTime);
				base.BUSEventCollection.Evt_PushRenderTargetValuesToGroup.Invoke(RenderTargetType.Shelter, MFEffectData.RtIndex, list3, list4);
				MFEffectData.RtIndex++;
				MFEffectData.RtIndex %= 8;
				if (bGUMagicFieldBaseCS != null)
				{
					bGUMagicFieldBaseCS.OnDrawSign(item2.Key, value.HitTransform);
				}
			}
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection != null)
		{
			FName paramName = RenderTargetMgrData.GetParamName(RenderTargetType.Shelter);
			UTextureRenderTarget2D textureRenderTarget = RenderTargetMgrData.GetTextureRenderTarget(RenderTargetType.Shelter);
			default(BUC_DispLibUtil_DBCTexture).SetCustomData(textureRenderTarget, 10f);
			bUS_DispLibEventCollection.Evt_RequestSetMatTextureParam?.Invoke(out var _, BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.FixDuration, 10f, paramName, textureRenderTarget);
		}
	}

	private bool CheckShapeTraceMultiForObjects(UPrimitiveComponent OverlapComponent, EProjectileCheckShapeType CheckShapeType, List<EObjectTypeQuery> ObjectTypes, List<AActor> IgnoreActors, out List<FHitResult> HitResults)
	{
		HitResults = new List<FHitResult>();
		FVector worldLocation = OverlapComponent.GetWorldLocation();
		switch (CheckShapeType)
		{
		case EProjectileCheckShapeType.BoxShape:
		{
			UBoxComponent uBoxComponent = (UBoxComponent)OverlapComponent;
			USystemLibrary.BoxTraceMultiForObjects(GetOwner(), worldLocation - FVector.UpVector, worldLocation + FVector.UpVector, uBoxComponent.GetScaledBoxExtent(), uBoxComponent.GetWorldRotation(), ObjectTypes, bTraceComplex: false, IgnoreActors, EDrawDebugTrace.None, out HitResults, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 3f);
			break;
		}
		case EProjectileCheckShapeType.SphereShape:
		{
			USphereComponent uSphereComponent = (USphereComponent)OverlapComponent;
			USystemLibrary.SphereTraceMultiForObjects(GetOwner(), worldLocation - FVector.UpVector, worldLocation + FVector.UpVector, uSphereComponent.GetScaledSphereRadius(), ObjectTypes, bTraceComplex: false, IgnoreActors, EDrawDebugTrace.None, out HitResults, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 3f);
			break;
		}
		case EProjectileCheckShapeType.CapsuleShape:
		{
			UCapsuleComponent uCapsuleComponent = (UCapsuleComponent)OverlapComponent;
			USystemLibrary.CapsuleTraceMultiForObjects(GetOwner(), worldLocation - FVector.UpVector, worldLocation + FVector.UpVector, uCapsuleComponent.GetScaledCapsuleRadius(), uCapsuleComponent.GetScaledCapsuleHalfHeight(), ObjectTypes, bTraceComplex: false, IgnoreActors, EDrawDebugTrace.None, out HitResults, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 3f);
			break;
		}
		default:
			return false;
		}
		return true;
	}

	private void AddFieldBuff(AActor Target, List<FFieldBuffInfo> FieldBuffList)
	{
		BGUMagicFieldBaseCS bGUMagicFieldBaseCS = GetOwner() as BGUMagicFieldBaseCS;
		if (bGUMagicFieldBaseCS == null || bGUMagicFieldBaseCS.IsNullOrDestroyed() || Target.IsNullOrDestroyed() || FieldBuffList.Count < 1)
		{
			return;
		}
		if (Target is BGUWeaponBase bGUWeaponBase)
		{
			Target = bGUWeaponBase.GetAttachParentActor();
			if (Target.IsNullOrDestroyed())
			{
				return;
			}
		}
		base.BGSEventCollection.Evt_OnActorIntoField.Invoke(Owner, Target, FieldBuffList);
	}

	private void RemoveFieldBuff(AActor Target, List<FFieldBuffInfo> FieldBuffList)
	{
		BGUMagicFieldBaseCS bGUMagicFieldBaseCS = GetOwner() as BGUMagicFieldBaseCS;
		if (bGUMagicFieldBaseCS == null || bGUMagicFieldBaseCS.IsNullOrDestroyed() || Target.IsNullOrDestroyed() || FieldBuffList.Count < 1)
		{
			return;
		}
		if (Target is BGUWeaponBase bGUWeaponBase)
		{
			Target = bGUWeaponBase.GetAttachParentActor();
			if (Target.IsNullOrDestroyed())
			{
				return;
			}
		}
		base.BGSEventCollection.Evt_OnActorLeaveField.Invoke(Owner, Target);
	}
}
