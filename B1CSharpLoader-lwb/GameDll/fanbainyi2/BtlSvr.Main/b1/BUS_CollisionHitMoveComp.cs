using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Google.Protobuf.Collections;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_CollisionHitMoveComp : UActorCompBaseCS
{
	private BUC_CollisionHitMoveData CollisionHitMoveData;

	private IBUC_TickRateData TickRateData;

	private IBUC_BattleStateData BattleStateData;

	private UBGUCharacterMovementComponent CharacterMovementComp;

	private ECollisionChannel HitMoveTraceChannel = ECollisionChannel.ECC_GameTraceChannel15;

	public override void OnAttach()
	{
		CollisionHitMoveData = RequireWritableData<BUC_CollisionHitMoveData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		base.BUSEventCollection.Evt_SetHitCollisionUpdateInfo += new Del_SetHitCollisionUpdateInfo(OnSetHitCollisionUpdateInfo);
		base.BUSEventCollection.Evt_ResetHitCollisionScaleInfo += new Del_Void_String(OnResetHitCollisionUpdateInfo);
		base.BUSEventCollection.Evt_UnitSkillBreak += new Del_UnitSkillBreak(OnUnitSkillBreak);
		base.BUSEventCollection.Evt_OnSkillEnd += new Del_Void_Int(OnSkillEnd);
		base.BUSEventCollection.Evt_ModifyCollisionHitWeight += new Del_ModifyCollisionHitWeight(OnModifyCollisionHitWeight);
		base.BUSEventCollection.Evt_ResetCollisionHitWeight += new Del_Void(OnResetCollisionHitWeight);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(OnUnitRebirth);
		base.BUSEventCollection.Evt_PauseUpdate += new Del_Void_Bool(OnPauseUpdate);
		base.BUSEventCollection.Evt_RequestSetEnableHitMoveCollision += new Del_RequestSetEnableHitMoveCollision(RequestSetEnableHitMoveCollision);
		base.BUSEventCollection.Evt_PopRequestSetEnableHitMoveCollision += new Del_PopRequestSetEnableHitMoveCollision(PopRequestSetEnableHitMoveCollision);
		base.BUSEventCollection.Evt_SetHitMoveIgnoreActor += new Del_SetHitMoveIgnoreActor(OnSetHitMoveIgnoreActor);
		base.BUSEventCollection.Evt_ResetHitMoveCollisionInfo += new Del_ResetHitMoveCollisionInfo(ResetHitMoveCollisionInfo);
		base.BUSEventCollection.Evt_SetUnmovable += new Del_Void_Bool(OnSetUnmovable);
		base.BUSEventCollection.Evt_SetHitMoveUnmovable += new Del_Void_Bool(OnSetUnmovable);
		base.BUSEventCollection.Evt_SetIsEnableCollisionHitMove += new Del_SetIsEnableCollisionHitMove(OnSetIsEnableCollisionHitMove);
		base.BUSEventCollection.Evt_ResetIsEnableCollisionHitMove += new Del_ResetIsEnableCollisionHitMove(OnResetIsEnableCollisionHitMove);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		CharacterMovementComp = OwnerAsCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
	}

	public override void OnBeginPlay()
	{
		ResetHitMoveCollisionInfo();
		FUStUnitCollisionHitMoveDesc unitCollisionHitMoveDesc = BGW_GameDB.GetUnitCollisionHitMoveDesc(BGU_DataUtil.GetActorResID(Owner));
		if (unitCollisionHitMoveDesc != null)
		{
			OnModifyCollisionHitWeight(unitCollisionHitMoveDesc.UnitHitMoveWeight);
			CollisionHitMoveData.DisableBattleURO = unitCollisionHitMoveDesc.DisableBattleURO == EGSYesNo.Yes;
		}
		BGUCharacterCS bGUCharacterCS = Owner.GetAttachParentActor() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			base.BUSEventCollection.Evt_SetHitMoveIgnoreActor.Invoke(bGUCharacterCS, NeedIgnore: true);
			BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_SetHitMoveIgnoreActor.Invoke(Owner, NeedIgnore: true);
		}
		BUTamerActor bUTamerActor = (Owner as BGUCharacterCS)?.GetTamerOwner() as BUTamerActor;
		bool value = default(bool);
		if (bUTamerActor != null && bUTamerActor.ConfigInfoComp.FlagConfig.MonsterRejectTags.TryGetValue(EActorCompRejectFlag.TianbingPerf.ToString(), out value) && value)
		{
			OnSetIsEnableCollisionHitMove(IsEnableCollisionHitMove: false, ECollisionHitMoveEnableReqType.Default);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	private void SetHitMoveCanUpdate(bool HitMoveCanUpdate)
	{
		if (CollisionHitMoveData.HitMoveCanUpdate != HitMoveCanUpdate)
		{
			CollisionHitMoveData.HitMoveCanUpdate = HitMoveCanUpdate;
			CharacterMovementComp.HitMoveCanUpdate = HitMoveCanUpdate;
		}
	}

	private bool CheckHitMoveCanTick(ref float DeltaTime)
	{
		if (CollisionHitMoveData.IsUnmovable)
		{
			return false;
		}
		bool flag = true;
		float distanceToPlayer = TickRateData.GetDistanceToPlayer();
		if (!BattleStateData.IsUnitInBattle() && distanceToPlayer > 3000f)
		{
			return false;
		}
		if (!CollisionHitMoveData.DisableBattleURO)
		{
			if (distanceToPlayer > 10000f)
			{
				return false;
			}
			float DifferenceTimeToLast100ms;
			float DifferenceTimeToLast200ms;
			float DifferenceTimeToLast500ms;
			float DifferenceTimeToLast1000ms;
			if (distanceToPlayer > 6000f)
			{
				flag = TickRateData.CanTickFor1000msInterval(out DeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
			}
			else if (distanceToPlayer > 3000f)
			{
				flag = TickRateData.CanTickFor500msInterval(out DeltaTime, out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms);
			}
			else if (distanceToPlayer > 1000f)
			{
				flag = TickRateData.CanTickFor100msInterval(out DeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
			}
		}
		if (!flag)
		{
			return false;
		}
		if (Owner == null)
		{
			return false;
		}
		if (CollisionHitMoveData.HitMoveCollisions.Count <= 0)
		{
			return false;
		}
		return true;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		SetHitMoveCanUpdate(CheckHitMoveCanTick(ref DeltaTime));
		if (CollisionHitMoveData.HitMoveCanUpdate)
		{
			UpdateScaleAndRadiusForHitCollision(DeltaTime);
		}
	}

	private void UpdateScaleAndRadiusForHitCollision(float DeltaTime)
	{
		if (CollisionHitMoveData.NeedUpdateCurveList.Count <= 0)
		{
			return;
		}
		List<UShapeComponent> list = new List<UShapeComponent>();
		foreach (KeyValuePair<UShapeComponent, TStrongObjectPtr<UCurveVector>> needUpdateCurve in CollisionHitMoveData.NeedUpdateCurveList)
		{
			CollisionUpdateInfo value;
			if (needUpdateCurve.Value == null)
			{
				list.Add(needUpdateCurve.Key);
			}
			else if (CollisionHitMoveData.NeedUpdateInfoTimerList.TryGetValue(needUpdateCurve.Key, out value))
			{
				value.CurrTime += DeltaTime;
				if (value.NeedUpdateRadius)
				{
					float y = needUpdateCurve.Value.Get().GetVectorValue(value.CurrTime).Y;
					UpdateCollisionRadius(needUpdateCurve.Key as UCapsuleComponent, y, Owner);
				}
				if (value.NeedUpdateScale)
				{
					float x = needUpdateCurve.Value.Get().GetVectorValue(value.CurrTime).X;
					UpdateCollisionScale(needUpdateCurve.Key as UCapsuleComponent, x, value.NeedSetRelaLocForScale, Owner);
				}
				if (value.CurrTime > value.TotalTime)
				{
					list.Add(needUpdateCurve.Key);
				}
				else
				{
					CollisionHitMoveData.NeedUpdateInfoTimerList[needUpdateCurve.Key] = value;
				}
			}
		}
		foreach (UShapeComponent item in list)
		{
			OnResetHitCollisionUpdateInfo(item);
		}
	}

	private void UpdateCollisionScale(UCapsuleComponent CapsuleComp, float Height, bool NeedSetRelaLocForScale, AActor selfActor)
	{
		if (CapsuleComp != null)
		{
			if (NeedSetRelaLocForScale)
			{
				FVector relativeLocation = CapsuleComp.RelativeLocation;
				relativeLocation.X = Height;
				CapsuleComp.SetRelativeLocation(relativeLocation, bSweep: false, out var _, bTeleport: false);
			}
			CapsuleComp.SetCapsuleHalfHeight(Height, bUpdateOverlaps: false);
		}
	}

	private void UpdateCollisionRadius(UCapsuleComponent CapsuleComp, float Radius, AActor selfActor)
	{
		if (CapsuleComp != null)
		{
			CapsuleComp.SetCapsuleRadius(Radius, bUpdateOverlaps: false);
		}
	}

	private void ResetHitMoveCollisionInfo(List<FName> DefaultDisabledCollisionName = null)
	{
		ClearHitCollisionUpdateInfo();
		CollisionHitMoveData.ClearHitMoveInfo(CharacterMovementComp);
		int actorResID = BGU_DataUtil.GetActorResID(Owner);
		FUStUnitCollisionHitMoveDesc unitCollisionHitMoveDesc = BGW_GameDB.GetUnitCollisionHitMoveDesc(actorResID);
		if (BGW_LogUtil.LogIfNull(unitCollisionHitMoveDesc, "Find UnitCollisionHitMoveDesc failed! ResID: {0}", actorResID))
		{
			return;
		}
		RepeatedField<FUStUnitCollisionConfig> otherCollisions = unitCollisionHitMoveDesc.OtherCollisions;
		List<UActorComponent> componentsByClass = Owner.GetComponentsByClass(UClass.GetClass<UShapeComponent>());
		foreach (FUStUnitCollisionConfig item in otherCollisions)
		{
			if (item.CollisionName == "")
			{
				continue;
			}
			UActorComponent uActorComponent = null;
			foreach (UActorComponent item2 in componentsByClass)
			{
				UShapeComponent uShapeComponent = item2 as UShapeComponent;
				string name = uShapeComponent.GetName();
				if (!(uShapeComponent != null) || name.IndexOf(item.CollisionName, StringComparison.CurrentCultureIgnoreCase) < 0 || CollisionHitMoveData.HitMoveCollisions.Contains(uShapeComponent))
				{
					continue;
				}
				uActorComponent = item2;
				bool flag = uShapeComponent.GetCollisionResponseToChannel(HitMoveTraceChannel) == ECollisionResponseType.ECR_Overlap;
				if (flag && DefaultDisabledCollisionName != null)
				{
					foreach (FName item3 in DefaultDisabledCollisionName)
					{
						if (name.IndexOf(item3.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
						{
							flag = false;
							break;
						}
					}
				}
				uShapeComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
				CollisionHitMoveData.HitMoveCollisions.Add(uShapeComponent);
				CharacterMovementComp.AddOrModifyHitMoveCollision(uShapeComponent, EHitMoveDir.Default, flag);
			}
			if (uActorComponent != null)
			{
				componentsByClass.Remove(uActorComponent);
			}
		}
	}

	private void OnSetHitCollisionUpdateInfo(string CollisionCompName, EHitMoveDir HitMoveDir, UCurveVector UpdateCurve, float TotalUpdateTime, bool NeedUpdateScale, bool NeedUpdateRadius, bool NeedSetRelaLocForScale)
	{
		if (UpdateCurve == null || CollisionHitMoveData == null || CollisionHitMoveData.HitMoveCollisions == null)
		{
			return;
		}
		UShapeComponent uShapeComponent = null;
		foreach (UShapeComponent hitMoveCollision in CollisionHitMoveData.HitMoveCollisions)
		{
			if (hitMoveCollision.GetName().Equals(CollisionCompName, StringComparison.CurrentCultureIgnoreCase))
			{
				uShapeComponent = hitMoveCollision;
				break;
			}
		}
		if (!(uShapeComponent != null))
		{
			return;
		}
		UCapsuleComponent uCapsuleComponent = uShapeComponent as UCapsuleComponent;
		if (uCapsuleComponent != null)
		{
			CollisionUpdateInfo value = default(CollisionUpdateInfo);
			if (CollisionHitMoveData.NeedUpdateInfoTimerList.TryGetValue(uShapeComponent, out var value2))
			{
				value.RollbackLocation = value2.RollbackLocation;
				value.RollbackRadius = value2.RollbackRadius;
				value.RollbackHalfHeight = value2.RollbackHalfHeight;
			}
			else
			{
				value.RollbackLocation = uCapsuleComponent.RelativeLocation;
				value.RollbackRadius = uCapsuleComponent.GetUnscaledCapsuleRadius();
				value.RollbackHalfHeight = uCapsuleComponent.GetUnscaledCapsuleHalfHeight();
			}
			value.RequestID = (ulong)(-4294967296L | uShapeComponent.GetUniqueID());
			value.CurrTime = 0f;
			value.TotalTime = TotalUpdateTime;
			value.NeedUpdateScale = NeedUpdateScale;
			value.NeedSetRelaLocForScale = NeedSetRelaLocForScale;
			value.NeedUpdateRadius = NeedUpdateRadius;
			CollisionHitMoveData.NeedUpdateCurveList[uShapeComponent] = new TStrongObjectPtr_NoCollect<UCurveVector>(UpdateCurve);
			CollisionHitMoveData.NeedUpdateInfoTimerList[uShapeComponent] = value;
			CharacterMovementComp.SetHitMoveCollisionDirection(uShapeComponent, HitMoveDir);
			RequestSetEnableHitMoveCollision(new List<UShapeComponent> { uCapsuleComponent }, Enable: true, value.RequestID);
			if (value.NeedUpdateRadius)
			{
				float y = UpdateCurve.GetVectorValue(value.CurrTime).Y;
				UpdateCollisionRadius(uCapsuleComponent, y, Owner);
			}
			if (value.NeedUpdateScale)
			{
				float x = UpdateCurve.GetVectorValue(value.CurrTime).X;
				UpdateCollisionScale(uCapsuleComponent, x, value.NeedSetRelaLocForScale, Owner);
			}
		}
	}

	private void OnResetHitCollisionUpdateInfo(string CollisionCompName)
	{
		UShapeComponent uShapeComponent = null;
		foreach (UShapeComponent key in CollisionHitMoveData.NeedUpdateInfoTimerList.Keys)
		{
			if (key != null && key.GetName().Equals(CollisionCompName, StringComparison.CurrentCultureIgnoreCase))
			{
				uShapeComponent = key;
				break;
			}
		}
		if (uShapeComponent != null)
		{
			OnResetHitCollisionUpdateInfo(uShapeComponent);
		}
	}

	private void OnResetHitCollisionUpdateInfo(UShapeComponent ShapeComp)
	{
		if (CollisionHitMoveData.NeedUpdateInfoTimerList.TryGetValue(ShapeComp, out var value) && ShapeComp != null)
		{
			UCapsuleComponent uCapsuleComponent = ShapeComp as UCapsuleComponent;
			if (uCapsuleComponent != null)
			{
				CollisionHitMoveData.NeedUpdateCurveList.Remove(ShapeComp);
				CollisionHitMoveData.NeedUpdateInfoTimerList.Remove(ShapeComp);
				PopRequestSetEnableHitMoveCollision(value.RequestID);
				if (value.NeedUpdateRadius)
				{
					uCapsuleComponent.SetCapsuleRadius(value.RollbackRadius, bUpdateOverlaps: false);
				}
				if (value.NeedUpdateScale)
				{
					uCapsuleComponent.SetCapsuleHalfHeight(value.RollbackHalfHeight, bUpdateOverlaps: false);
					uCapsuleComponent.SetRelativeLocation(value.RollbackLocation, bSweep: false, out var _, bTeleport: false);
				}
			}
		}
		CharacterMovementComp.SetHitMoveCollisionDirection(ShapeComp, EHitMoveDir.Default);
	}

	private void OnSkillEnd(int SkillID)
	{
		ClearHitCollisionUpdateInfo();
	}

	private void OnUnitSkillBreak(int SkillID, string Reason)
	{
		ClearHitCollisionUpdateInfo();
	}

	private void ClearHitCollisionUpdateInfo()
	{
		foreach (KeyValuePair<UShapeComponent, CollisionUpdateInfo> item in CollisionHitMoveData.NeedUpdateInfoTimerList.ToList())
		{
			OnResetHitCollisionUpdateInfo(item.Key);
		}
	}

	private void OnModifyCollisionHitWeight(float NewWeight)
	{
		CharacterMovementComp.HitMoveWeight = NewWeight;
	}

	private void OnResetCollisionHitWeight()
	{
		if (!(Owner == null))
		{
			FUStUnitCollisionHitMoveDesc unitCollisionHitMoveDesc = BGW_GameDB.GetUnitCollisionHitMoveDesc(BGU_DataUtil.GetActorResID(Owner));
			OnModifyCollisionHitWeight(unitCollisionHitMoveDesc.UnitHitMoveWeight);
		}
	}

	private void OnSetHitMoveIgnoreActor(AActor Actor, bool NeedIngore)
	{
		CharacterMovementComp.SetHitMoveIgnoredActor(Actor, !NeedIngore);
	}

	public void OnSetIsEnableCollisionHitMove(bool IsEnableCollisionHitMove, ECollisionHitMoveEnableReqType ReqType, int ReqId = 0)
	{
		CollisionHitMoveData.SetIsEnableCollisionHitMove(CharacterMovementComp, IsEnableCollisionHitMove, ReqType, ReqId);
	}

	public void OnResetIsEnableCollisionHitMove(ECollisionHitMoveEnableReqType ReqType, int ReqId = 0)
	{
		CollisionHitMoveData.ResetIsEnableCollisionHitMove(CharacterMovementComp, ReqType, ReqId);
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		OnSetIsEnableCollisionHitMove(IsEnableCollisionHitMove: false, ECollisionHitMoveEnableReqType.Dead);
	}

	private void OnPauseUpdate(bool bShouldPause)
	{
		CollisionHitMoveData.bShouldUpdateHitMove = !bShouldPause;
	}

	private void SetEnableHitMoveCollision(UShapeComponent HitMoveCollision, bool Enable)
	{
		if (CollisionHitMoveData.HitMoveCollisions.Contains(HitMoveCollision))
		{
			CharacterMovementComp.SetHitMoveCollisionEnabled(HitMoveCollision, Enable);
			HitMoveCollision.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		}
	}

	private void RequestSetEnableHitMoveCollision(List<string> HitMoveCollisionNames, bool Enable, ulong RequestID)
	{
		if (CollisionHitMoveData == null)
		{
			return;
		}
		List<UShapeComponent> list = new List<UShapeComponent>();
		foreach (UShapeComponent hitMoveCollision in CollisionHitMoveData.HitMoveCollisions)
		{
			if (hitMoveCollision == null)
			{
				continue;
			}
			foreach (string HitMoveCollisionName in HitMoveCollisionNames)
			{
				if (hitMoveCollision.GetName().IndexOf(HitMoveCollisionName, StringComparison.CurrentCultureIgnoreCase) >= 0)
				{
					list.Add(hitMoveCollision);
					break;
				}
			}
		}
		if (list.Count > 0)
		{
			RequestSetEnableHitMoveCollision(list, Enable, RequestID);
		}
	}

	private void RequestSetEnableHitMoveCollision(List<UShapeComponent> HitMoveShapes, bool Enable, ulong RequestID)
	{
		if (CollisionHitMoveData == null)
		{
			return;
		}
		if (CollisionHitMoveData.HitMoveSetEnableRequestList.Count > 0)
		{
			PopRequestSetEnableHitMoveCollision(RequestID);
		}
		List<UShapeComponent> list = new List<UShapeComponent>();
		List<bool> list2 = new List<bool>();
		foreach (UShapeComponent HitMoveShape in HitMoveShapes)
		{
			if (CharacterMovementComp.GetHitMoveCollisionIsEnabled(HitMoveShape, out var IsEnabled))
			{
				list.Add(HitMoveShape);
				list2.Add(IsEnabled);
				SetEnableHitMoveCollision(HitMoveShape, Enable);
			}
		}
		CollisionHitMoveData.HitMoveSetEnableRequestList.Add(new FHitMoveSetEnableRequest(RequestID, list, list2));
	}

	private void PopRequestSetEnableHitMoveCollision(ulong RequestID)
	{
		if (CollisionHitMoveData == null)
		{
			return;
		}
		int num = CollisionHitMoveData.HitMoveSetEnableRequestList.FindIndex((FHitMoveSetEnableRequest r) => r.RequestID == RequestID);
		if (num < 0)
		{
			return;
		}
		FHitMoveSetEnableRequest fHitMoveSetEnableRequest = CollisionHitMoveData.HitMoveSetEnableRequestList[num];
		CollisionHitMoveData.HitMoveSetEnableRequestList.RemoveAt(num);
		for (int num2 = 0; num2 < fHitMoveSetEnableRequest.TargetCollisions.Count; num2++)
		{
			UShapeComponent Shape = fHitMoveSetEnableRequest.TargetCollisions[num2];
			bool flag = fHitMoveSetEnableRequest.RoolbackCollisionEnabled[num2];
			bool flag2 = true;
			for (int num3 = num; num3 < CollisionHitMoveData.HitMoveSetEnableRequestList.Count; num3++)
			{
				FHitMoveSetEnableRequest fHitMoveSetEnableRequest2 = CollisionHitMoveData.HitMoveSetEnableRequestList[num3];
				int num4 = fHitMoveSetEnableRequest2.TargetCollisions.FindIndex((UShapeComponent x) => x == Shape);
				if (num4 >= 0)
				{
					flag2 = false;
					fHitMoveSetEnableRequest2.RoolbackCollisionEnabled[num4] = flag;
					break;
				}
			}
			if (flag2)
			{
				SetEnableHitMoveCollision(Shape, flag);
			}
		}
	}

	private void OnUnitRebirth(ERebirthType RebirthType = ERebirthType.RebirthPoint)
	{
		OnResetIsEnableCollisionHitMove(ECollisionHitMoveEnableReqType.Dead);
	}

	private void OnSetUnmovable(bool IsUnmovable)
	{
		CollisionHitMoveData.IsUnmovable = IsUnmovable;
		CharacterMovementComp.HitMoveIsUnmovable = IsUnmovable;
	}
}
