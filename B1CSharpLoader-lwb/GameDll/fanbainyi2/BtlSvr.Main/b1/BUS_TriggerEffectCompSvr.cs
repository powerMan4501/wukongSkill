using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_TriggerEffectCompSvr : UActorCompBaseCS
{
	private static float INV1000 = 0.001f;

	private b1.BUC_TriggerEffectData TriggerEffectData;

	private IBUC_MasterData MasterData;

	public override void OnAttach()
	{
		TriggerEffectData = RequireWritableData<b1.BUC_TriggerEffectData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		base.BUSEventCollection.Evt_TriggerSkillEffect += new Del_TriggerSkillEffect(OnTriggerSkillEffect);
		base.BUSEventCollection.Evt_TriggerSkillEffect_Transmit.Cue += new GSDel_TriggerSkillEffect_IPK_Del.Del_Predict(OnTriggerSkillEffect_Cue);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateForTriggerMultiTargetSquenceEffect(DeltaTime);
	}

	private void OnTriggerSkillEffect_Cue(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget, bool bWithRPCEvent, GSPredictionKey PredictionKey)
	{
		OnTriggerSkillEffect(EffectID, EffectInstReq, InnerTarget, bWithRPCEvent);
	}

	private void OnTriggerSkillEffect(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget, bool bWithRPCEvent)
	{
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, GetOwner());
		if (skillEffectDesc == null)
		{
			return;
		}
		string[] splittedConditionParams = skillEffectDesc.EffectActiveCondition.ConditionParams.Split(',');
		if (!BGUFunctionLibraryCS.BGUCheckBuffEffectActiveCondition(EffectID, bIsBuff: false, GetOwner(), skillEffectDesc.EffectActiveCondition.ConditionType, splittedConditionParams))
		{
			return;
		}
		EBuffAndSkillEffectType effectType = skillEffectDesc.EffectType;
		BGW_EffectTemplateList.Get(GetOwner()).EffectTemplatesCS.TryGetValue(effectType, out var value);
		if (value == null)
		{
			return;
		}
		AActor owner = GetOwner();
		FVector OutTargetPos;
		FVector OutAim2TargetDir;
		AActor aActor = BGU_B1TargetFuncs.EffectBaseTargetFuncs[(uint)skillEffectDesc.TargetBase](owner, InnerTarget, out OutTargetPos, out OutAim2TargetDir);
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		List<AActor> list = BGU_B1TargetFuncs.EffectSelectRangeTarget(owner, aActor, EffectID, in EffectInstReq);
		float num = ((skillEffectDesc.Range.RangeParam.Count > 0) ? skillEffectDesc.Range.RangeParam[0] : 0);
		ERangeType rangeType = skillEffectDesc.Range.RangeType;
		if (rangeType == ERangeType.MultiTargetTurn && num > 0f)
		{
			float num2 = num;
			List<AActor> list2 = new List<AActor>();
			foreach (AActor item in list)
			{
				if (item != null)
				{
					list2.Add(item);
				}
			}
			TriggerEffectData.AddTriggerSequence(list2, EffectID, num2 * INV1000, EffectInstReq, bWithRPCEvent);
			UpdateForTriggerMultiTargetSquenceEffect(0f);
			return;
		}
		DebugDrawLogic(owner, aActor, skillEffectDesc);
		foreach (AActor item2 in list)
		{
			if (!(item2 != null))
			{
				continue;
			}
			IBUC_PartMgrData VictimPartMgrData = BGU_DataUtil.GetReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(item2);
			if (VictimPartMgrData != null)
			{
				EffectInstReq.HitPartID = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetHitPartID(item2 as BGUCharacterCS, in VictimPartMgrData, Owner, EffectInstReq.HitBoneName);
			}
			if (rangeType != ERangeType.TargetBaseObj)
			{
				EffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(item2);
			}
			if (bWithRPCEvent)
			{
				if (owner is BGUBulletBaseCS)
				{
					AActor masterActor = MasterData.GetMasterActor();
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(MasterData.GetMasterActor());
					if (bUS_GSEventCollection != null)
					{
						bUS_GSEventCollection.Evt_TriggerSkillEffectBySkill.Invoke(EffectID, masterActor, item2, EffectInstReq);
					}
				}
				else
				{
					base.BUSEventCollection.Evt_TriggerSkillEffectBySkill.Invoke(EffectID, owner, item2, EffectInstReq);
				}
			}
			else
			{
				base.BUSEventCollection.Evt_TriggerSkillEffectBySkill_WithoutRPC.Invoke(EffectID, owner, item2, in EffectInstReq);
			}
		}
	}

	private void UpdateForTriggerMultiTargetSquenceEffect(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		TriggerEffectData.MultiTargetTriggerSequenceArray.BeginItr();
		b1.SequenceTriggerEffectInfo output;
		while (TriggerEffectData.MultiTargetTriggerSequenceArray.NextItr(out output))
		{
			output.SequenceTriggerTimer -= DeltaTime;
			int sequenceEffectID = output.SequenceEffectID;
			FEffectInstReq EffectInstReq = output.EffectInstReq;
			if (!(output.SequenceTriggerTimer <= 0f))
			{
				continue;
			}
			output.SequenceTriggerTimer = output.SequenceDuration;
			while (true)
			{
				if (output.TargetActorQue.Count <= 0)
				{
					TriggerEffectData.MultiTargetTriggerSequenceArray.Remove();
					break;
				}
				AActor aActor = output.TargetActorQue.Dequeue();
				if (!aActor.IsNullOrDestroyed())
				{
					if (output.bWithRPCEvent)
					{
						base.BUSEventCollection.Evt_TriggerSkillEffectBySkill.Invoke(sequenceEffectID, owner, aActor, EffectInstReq);
					}
					else
					{
						base.BUSEventCollection.Evt_TriggerSkillEffectBySkill_WithoutRPC.Invoke(sequenceEffectID, owner, aActor, in EffectInstReq);
					}
					break;
				}
			}
		}
	}

	private void DebugDrawLogic(AActor OwnerActor, AActor SelectTargetBase, FUStSkillEffectDesc SkillEffectDesc)
	{
		AActor aActor = MasterData?.GetMasterActor();
		if (aActor == null)
		{
			aActor = OwnerActor;
		}
		BUC_UnitDebugData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitDebugData>(aActor);
		if (readOnlyData != null && readOnlyData.DrawSkillEffectArea)
		{
			DrawSkillEffectArea(SelectTargetBase, SkillEffectDesc.Range.RangeType, SkillEffectDesc.Range.RangeParam);
		}
	}

	private void DrawSkillEffectArea(AActor TargetBase, ERangeType RangeType, IList<int> Params)
	{
		if (TargetBase == null)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetBase);
		FVector actorForwardVector = TargetBase.GetActorForwardVector();
		switch (RangeType)
		{
		case ERangeType.Circle:
			if (Params.Count >= 1 && (float)Params[0] > 0f)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(GetOwner().World, fVector, Params[0]);
			}
			break;
		case ERangeType.Rect:
			if (Params.Count >= 2 && (float)Params[0] > 0f && (float)Params[1] > 0f)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugRect(GetOwner().World, fVector, actorForwardVector, Params[0], Params[1]);
			}
			break;
		case ERangeType.ForwardRect:
			if (Params.Count >= 2 && (float)Params[0] > 0f && (float)Params[1] > 0f)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugRect(GetOwner().World, fVector + actorForwardVector * Params[1] / 2.0, actorForwardVector, Params[0], Params[1]);
			}
			break;
		case ERangeType.Ring:
			if (Params.Count >= 4)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(GetOwner().World, fVector, Params[0]);
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(GetOwner().World, fVector, Params[1]);
			}
			break;
		case ERangeType.Cylinder:
		case ERangeType.Sphere:
		case ERangeType.Sector:
			break;
		}
	}
}
