using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_MFOverlapCompImpl : UActorCompBaseCS
{
	private static ECollisionChannel MFOverlapChannel = ECollisionChannel.ECC_GameTraceChannel18;

	private BUC_MFOverlapData MFOverlapData { get; set; }

	private BUC_ProjectileBasicData ProjectileBasicData { get; set; }

	private IBUC_MFNegativeOverlapData MFNegativeOverlapData { get; set; }

	public override void OnAttach()
	{
		MFOverlapData = RequireWritableData<BUC_MFOverlapData>();
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		if (MFOverlapData.OverlapType == EMagicFieldOverlapType.NegativeOverlap)
		{
			MFNegativeOverlapData = RequireReadOnlyData<IBUC_MFNegativeOverlapData, BUC_MFNegativeOverlapData>();
		}
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnMagicFieldDead);
		base.BUSEventCollection.Evt_ProjectileInitialization += new Del_ProjectileInitialization(OnMagicFieldInit);
		base.BUSEventCollection.Evt_AddAvoidanceMagicField += new Del_Void_Actor(OnAddAvoidanceMagicField);
		base.BUSEventCollection.Evt_RemoveAvoidanceMagicField += new Del_Void_Actor(OnRemoveAvoidanceMagicField);
		MFOverlapData.UpdateOverlapInterval = (float)GSGameplayCVar.CVar_MFOverlapInterval.GetValueInGameThread() / 1000f;
		MFOverlapData.UpdateOverlapIntervalRemainTime = 0f;
	}

	public override void OnBeginPlay()
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdatePhase(DeltaTime);
		if (MFOverlapData.Phase != EMFOverlapPhase.Empty && MFOverlapData.Phase != EMFOverlapPhase.Dead)
		{
			MFOverlapData.UpdateOverlapIntervalRemainTime -= DeltaTime;
			if (MFOverlapData.UpdateOverlapIntervalRemainTime <= 0f)
			{
				UpdateOverlappedActorList();
				MFOverlapData.UpdateOverlapIntervalRemainTime = MFOverlapData.UpdateOverlapInterval;
			}
		}
	}

	private void UpdatePhase(float DeltaTime)
	{
		if (MFOverlapData.Phase != EMFOverlapPhase.Dead)
		{
			MFOverlapData.MagicFieldAge += DeltaTime;
			if (MFOverlapData.MagicFieldAge < MFOverlapData.BornAttackWarningStartTime)
			{
				MFOverlapData.SetPhase(EMFOverlapPhase.Empty);
			}
			else if (MFOverlapData.MagicFieldAge < MFOverlapData.BornEffectDelayTime)
			{
				MFOverlapData.SetPhase(EMFOverlapPhase.AttackWarning);
			}
			else
			{
				MFOverlapData.SetPhase(EMFOverlapPhase.NormalOverlap);
			}
		}
	}

	private UPrimitiveComponent SelectCompForOverlap(EProjectileCheckShapeType ShapeType)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null || bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			return null;
		}
		UPrimitiveComponent result = null;
		switch (ShapeType)
		{
		case EProjectileCheckShapeType.BoxShape:
			result = bGUProjectileBaseActor.GetBoxCollisionComp();
			break;
		case EProjectileCheckShapeType.CapsuleShape:
			result = bGUProjectileBaseActor.GetCapsuleCollisionComp();
			break;
		case EProjectileCheckShapeType.SphereShape:
			result = bGUProjectileBaseActor.GetSphereCollisionComp();
			break;
		case EProjectileCheckShapeType.CustomShape:
			result = bGUProjectileBaseActor.GetCustomCollisionComp();
			break;
		}
		return result;
	}

	private void OnMagicFieldInit(FGSProjectileSpawnInfo ProjectileSpawnInfo, AActor MasterActor)
	{
		MFOverlapData.MagicFieldAge = 0f;
		MFOverlapData.bCanTriggerBornEffect = true;
		MFOverlapData.OverlapComp = SelectCompForOverlap(ProjectileBasicData.CheckShapeType);
		if (Owner as BGUMagicFieldBaseCS == null || MFOverlapData.OverlapComp == null)
		{
			MFOverlapData.SetPhase(EMFOverlapPhase.Dead);
		}
		else
		{
			SoftEdgeInit();
		}
	}

	private void SoftEdgeInit()
	{
		if (!MFOverlapData.bUseSoftEdge)
		{
			return;
		}
		UPrimitiveComponent uPrimitiveComponent = null;
		MFOverlapData.OverlapComp.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
		if (Children.Count > 0)
		{
			foreach (USceneComponent item in Children)
			{
				switch (ProjectileBasicData.CheckShapeType)
				{
				case EProjectileCheckShapeType.BoxShape:
					uPrimitiveComponent = item as UBoxComponent;
					break;
				case EProjectileCheckShapeType.SphereShape:
					uPrimitiveComponent = item as USphereComponent;
					break;
				case EProjectileCheckShapeType.CapsuleShape:
					uPrimitiveComponent = item as UCapsuleComponent;
					break;
				case EProjectileCheckShapeType.CustomShape:
					uPrimitiveComponent = item as UStaticMeshComponent;
					break;
				}
				if (uPrimitiveComponent != null)
				{
					break;
				}
			}
		}
		if (uPrimitiveComponent != null)
		{
			MFOverlapData.SoftEdgeOverlapComp = uPrimitiveComponent;
			MFOverlapData.SoftEdgeOverlapComp.SetCollisionProfileName(MFOverlapData.OverlapComp.GetCollisionProfileName());
		}
		else
		{
			MFOverlapData.bUseSoftEdge = false;
		}
	}

	private void UpdateOverlappedActorList()
	{
		if (MFOverlapData.bUseSoftEdge)
		{
			UpdateOverlappedActorList_WithSoftEdge();
		}
		else
		{
			UpdateOverlappedActorList_Simple();
		}
	}

	private void UpdateOverlappedActorList_Simple()
	{
		UPrimitiveComponent overlapComp = MFOverlapData.OverlapComp;
		UpdateOverlappedActorList(overlapComp, out var OverlapActorList);
		HashSet<AActor> hashSet = new HashSet<AActor>();
		foreach (AActor item in MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin)
		{
			bool flag = false;
			if (!item.IsNullOrDestroyed() && !OverlapActorList.Contains(item))
			{
				flag = TriggerOverlapEnd(item);
			}
			if (flag)
			{
				hashSet.Add(item);
			}
		}
		foreach (AActor item2 in hashSet)
		{
			MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin.Remove(item2);
		}
		bool canTriggerBornEffect = false;
		if (MFOverlapData.Phase == EMFOverlapPhase.NormalOverlap && MFOverlapData.bCanTriggerBornEffect)
		{
			canTriggerBornEffect = true;
			MFOverlapData.bCanTriggerBornEffect = false;
		}
		HashSet<AActor> hashSet2 = new HashSet<AActor>();
		foreach (AActor item3 in OverlapActorList)
		{
			bool flag2 = false;
			if (!item3.IsNullOrDestroyed() && !MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin.Contains(item3))
			{
				flag2 = TriggerOverlapBegin(item3, canTriggerBornEffect);
			}
			if (flag2)
			{
				hashSet2.Add(item3);
				MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin.Add(item3);
			}
		}
	}

	private void UpdateOverlappedActorList_WithSoftEdge()
	{
		Dictionary<AActor, int> dictionary = new Dictionary<AActor, int>();
		UPrimitiveComponent overlapComp = MFOverlapData.OverlapComp;
		UpdateOverlappedActorList(overlapComp, out var OverlapActorList);
		UPrimitiveComponent softEdgeOverlapComp = MFOverlapData.SoftEdgeOverlapComp;
		UpdateOverlappedActorList(softEdgeOverlapComp, out var OverlapActorList2);
		foreach (AActor item in OverlapActorList)
		{
			dictionary.Add(item, 1);
		}
		foreach (AActor item2 in OverlapActorList2)
		{
			if (dictionary.ContainsKey(item2))
			{
				dictionary[item2]++;
			}
			else
			{
				dictionary.Add(item2, 1);
			}
		}
		HashSet<AActor> hashSet = new HashSet<AActor>();
		foreach (AActor item3 in MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin)
		{
			if (!item3.IsNullOrDestroyed() && !dictionary.ContainsKey(item3) && TriggerOverlapEnd(item3))
			{
				hashSet.Add(item3);
			}
		}
		foreach (AActor item4 in hashSet)
		{
			MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin.Remove(item4);
		}
		bool canTriggerBornEffect = false;
		if (MFOverlapData.Phase == EMFOverlapPhase.NormalOverlap && MFOverlapData.bCanTriggerBornEffect)
		{
			canTriggerBornEffect = true;
			MFOverlapData.bCanTriggerBornEffect = false;
		}
		foreach (KeyValuePair<AActor, int> item5 in dictionary)
		{
			AActor key = item5.Key;
			if (!key.IsNullOrDestroyed() && item5.Value == 2 && !MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin.Contains(key) && TriggerOverlapBegin(key, canTriggerBornEffect))
			{
				MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin.Add(key);
			}
		}
	}

	private void UpdateOverlappedActorList(UPrimitiveComponent OverlapComp, out HashSet<AActor> OverlapActorList)
	{
		if (MFOverlapData.OverlapType == EMagicFieldOverlapType.Normal)
		{
			UpdateOverlappedActorList_Active(OverlapComp, out OverlapActorList);
		}
		else if (MFOverlapData.OverlapType == EMagicFieldOverlapType.NegativeOverlap)
		{
			UpdateOverlappedActorList_Negative(OverlapComp, out OverlapActorList);
		}
		else
		{
			OverlapActorList = new HashSet<AActor>();
		}
	}

	private void UpdateOverlappedActorList_Active(UPrimitiveComponent OverlapComp, out HashSet<AActor> OverlapActorList)
	{
		OverlapActorList = new HashSet<AActor>();
		if (OverlapComp == null)
		{
			return;
		}
		FName passMagicFieldCheck = B1GlobalFNames.PassMagicFieldCheck;
		List<UPrimitiveComponent> OutComponents = new List<UPrimitiveComponent>();
		List<AActor> actorsToIgnore = new List<AActor> { Owner };
		UBGUFuncLibSelectTargets.BGUCompOverlapCompsByChannel(OverlapComp, MFOverlapChannel, null, actorsToIgnore, out OutComponents);
		foreach (UPrimitiveComponent item in OutComponents)
		{
			if (!item.ComponentHasTag(passMagicFieldCheck))
			{
				AActor owner = item.GetOwner();
				if (!owner.IsNullOrDestroyed() && (!(owner is IECSWorldObj iECSWorldObj) || iECSWorldObj.IsBeginPlayFinished()))
				{
					OverlapActorList.Add(owner);
				}
			}
		}
	}

	private void UpdateOverlappedActorList_Negative(UPrimitiveComponent OverlapComp, out HashSet<AActor> OverlapActorList)
	{
		OverlapActorList = new HashSet<AActor>();
		if (MFNegativeOverlapData == null)
		{
			return;
		}
		foreach (AActor innerActor in MFNegativeOverlapData.InnerActors)
		{
			OverlapActorList.Add(innerActor);
		}
	}

	private bool TriggerOverlapBegin(AActor OtherActor, bool CanTriggerBornEffect)
	{
		if (OtherActor.IsNullOrDestroyed())
		{
			return false;
		}
		if (BGUFunctionLibraryCS.BGUIsUnitDead(OtherActor))
		{
			return false;
		}
		foreach (KeyValuePair<AActor, IBUC_MFOverlapData> item in MFOverlapData.AvoidanceOverlapDataMap)
		{
			if (item.Value.IsActorInnerRange(OtherActor))
			{
				return false;
			}
		}
		if (MFOverlapData.Phase == EMFOverlapPhase.AttackWarning)
		{
			TriggerAttackWarning(OtherActor, MFOverlapData.BornEffectDelayTime - MFOverlapData.MagicFieldAge, bRepeatable: false);
			return false;
		}
		if (CanTriggerBornEffect)
		{
			OnTriggerBornEffects(OtherActor);
		}
		BGUFXActorBase bGUFXActorBase = OtherActor as BGUFXActorBase;
		if (bGUFXActorBase != null)
		{
			HitDestructibleActor(bGUFXActorBase);
			return true;
		}
		foreach (MFEventForData enterEvent in MFOverlapData.EnterEvents)
		{
			base.BUSEventCollection.Evt_TriggerMagicFieldEffect.Invoke(OtherActor, enterEvent.bIgnoreFilter, enterEvent.TargetTeamFilter, enterEvent.TargetTypeFilter, enterEvent.MFEffectList);
		}
		base.BUSEventCollection.Evt_AddFieldBuff2Target.Invoke(OtherActor, MFOverlapData.FieldBuffList);
		base.BUSEventCollection.Evt_OnTargetEnterMagicField.Invoke(OtherActor);
		return true;
	}

	private bool TriggerOverlapEnd(AActor OtherActor)
	{
		if (MFOverlapData.Phase == EMFOverlapPhase.AttackWarning)
		{
			if (MFOverlapData.AttackWarnedActors.Contains(OtherActor))
			{
				MFOverlapData.AttackWarnedActors.Remove(OtherActor);
			}
			return false;
		}
		if (OtherActor.IsNullOrDestroyed())
		{
			return false;
		}
		foreach (MFEventForData exitEvent in MFOverlapData.ExitEvents)
		{
			base.BUSEventCollection.Evt_TriggerMagicFieldEffect.Invoke(OtherActor, exitEvent.bIgnoreFilter, exitEvent.TargetTeamFilter, exitEvent.TargetTypeFilter, exitEvent.MFEffectList);
		}
		base.BUSEventCollection.Evt_RemoveFieldBuff2Target.Invoke(OtherActor, MFOverlapData.FieldBuffList);
		base.BUSEventCollection.Evt_OnTargetLeaveMagicField.Invoke(OtherActor);
		BUS_EventCollectionCS.Get(OtherActor)?.Evt_LeaveMagicField.Invoke(Owner);
		return true;
	}

	private void OnMagicFieldDead(EBGUBulletDestroyReason Reason)
	{
		if (!(Owner as BGUMagicFieldBaseCS == null) && !(MFOverlapData.OverlapComp == null))
		{
			UpdateOverlappedActorList();
			OnTriggerDeadEffects();
			MFOverlapData.SetPhase(EMFOverlapPhase.Dead);
		}
	}

	private void OnTriggerBornEffects(AActor OverlappedActor)
	{
		if (OverlappedActor.IsNullOrDestroyed())
		{
			return;
		}
		foreach (MFEventForData birthEvent in MFOverlapData.BirthEvents)
		{
			base.BUSEventCollection.Evt_TriggerMagicFieldEffect.Invoke(OverlappedActor, birthEvent.bIgnoreFilter, birthEvent.TargetTeamFilter, birthEvent.TargetTypeFilter, birthEvent.MFEffectList);
		}
		base.BUSEventCollection.Evt_OnTargetExistedWhenMagicFieldBorn.Invoke(OverlappedActor);
	}

	private void OnTriggerDeadEffects()
	{
		foreach (AActor item in MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin)
		{
			if (item.IsNullOrDestroyed())
			{
				continue;
			}
			foreach (MFEventForData dieEvent in MFOverlapData.DieEvents)
			{
				base.BUSEventCollection.Evt_TriggerMagicFieldEffect.Invoke(item, dieEvent.bIgnoreFilter, dieEvent.TargetTeamFilter, dieEvent.TargetTypeFilter, dieEvent.MFEffectList);
			}
			TriggerOverlapEnd(item);
			base.BUSEventCollection.Evt_OnTargetExistedWhenMagicFieldDead.Invoke(item);
		}
	}

	private void TriggerAttackWarning(AActor TriggeredActor, float WarningTime, bool bRepeatable)
	{
		if (!bRepeatable)
		{
			if (MFOverlapData.AttackWarnedActors.Contains(TriggeredActor))
			{
				return;
			}
			MFOverlapData.AttackWarnedActors.Add(TriggeredActor);
		}
		if (MFOverlapData.bAttackWarningTriggerPreciseDodge && (!MFOverlapData.bPreciseDodgeFilterTeammate || BGUFunctionLibraryCS.BGUIsEnemyTeam(Owner, TriggeredActor)))
		{
			BUS_EventCollectionCS.Get(TriggeredActor).Evt_SweepCheckInPreciseDodgeRange.Invoke(Owner, 0, -1, 0, WarningTime);
		}
	}

	private void HitDestructibleActor(BGUFXActorBase DestructibleActor)
	{
		BGUMagicFieldBaseCS bGUMagicFieldBaseCS = Owner as BGUMagicFieldBaseCS;
		if (bGUMagicFieldBaseCS == null)
		{
			return;
		}
		FEffectInstReq fEffectInstReq;
		if ((int)MFOverlapData.HitDestructibleStrengthLevel > 0)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(DestructibleActor);
			if (bUS_GSEventCollection != null)
			{
				fEffectInstReq = new FEffectInstReq(Owner);
				fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(DestructibleActor);
				fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(DestructibleActor);
				fEffectInstReq.HitActionDir = EHitActionDir.Default;
				FEffectInstReq effectInstReq = fEffectInstReq;
				float destructibleImpulse = BGUFunctionLibraryCS.GetDestructibleImpulse(Owner, MFOverlapData.HitDestructibleStrengthLevel);
				bUS_GSEventCollection.Evt_HitDestructible.Invoke(bGUMagicFieldBaseCS, MFOverlapData.HitDestructibleStrengthLevel, MFOverlapData.HitDestructibleDirectionType, effectInstReq, destructibleImpulse);
			}
		}
		fEffectInstReq = new FEffectInstReq(Owner);
		fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUMagicFieldBaseCS);
		fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUMagicFieldBaseCS);
		fEffectInstReq.HitActionDir = EHitActionDir.Default;
		FEffectInstReq effectInstReq2 = fEffectInstReq;
		foreach (int item in MFOverlapData.HitDestructibleEffectsTriggerForSelf)
		{
			base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(item, effectInstReq2, bGUMagicFieldBaseCS);
		}
	}

	private void OnAddAvoidanceMagicField(AActor Actor)
	{
		if (MFOverlapData.bNeedAvoid && !Actor.IsNullOrDestroyed())
		{
			IBUC_MFOverlapData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MFOverlapData>(Actor);
			if (unPersistentReadOnlyData != null && !MFOverlapData.AvoidanceOverlapDataMap.ContainsKey(Actor))
			{
				MFOverlapData.AvoidanceOverlapDataMap.Add(Actor, unPersistentReadOnlyData);
			}
		}
	}

	private void OnRemoveAvoidanceMagicField(AActor Actor)
	{
		if (MFOverlapData.bNeedAvoid && !Actor.IsNullOrDestroyed() && MFOverlapData.AvoidanceOverlapDataMap.ContainsKey(Actor))
		{
			MFOverlapData.AvoidanceOverlapDataMap.Remove(Actor);
		}
	}
}
