using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_MandatoryAITaskComp : UActorCompBaseCS
{
	private IBUC_GuidData GuidData;

	private BUC_MandatoryAITaskData MandatoryAITaskData { get; set; }

	public override void OnAttach()
	{
		MandatoryAITaskData = RequireWritableData<BUC_MandatoryAITaskData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_ExecuteMandatoryTask += new Del_ExecuteMandatoryTask(ExecuteTask);
		base.BUSEventCollection.Evt_BeHitSetInfo += new Del_Void(OnBeHit);
	}

	public override void PreBeginPlay()
	{
		InitTaskList();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateForTask();
	}

	private void InitTaskList()
	{
		MandatoryAITaskData.InitData();
		foreach (FUStMandatoryAITaskDesc item2 in BGW_GameDB.GetMandatoryAITaskDescListByResID(GetActorResID()))
		{
			bool flag = true;
			if (!item2.InstanceGUID.Equals(string.Empty))
			{
				flag = item2.InstanceGUID.Equals(GuidData.GetFinalGuid());
			}
			if (flag)
			{
				FMandatoryTask item = new FMandatoryTask
				{
					TaskCondition = item2.TaskCondition,
					TaskActivationEvent = item2.TaskActivationEvent,
					IsReverseCondition = item2.IsReverseCondition,
					ConditionFloatParams = item2.ConditionFloatParams,
					ConditionIntParams = item2.ConditionIntParams,
					AITaskInfoList = item2.AITaskInfoList,
					IsDone = false
				};
				MandatoryAITaskData.MandatoryTasks.Add(item);
			}
		}
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		InitTaskList();
	}

	private void UpdateForTask()
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		foreach (FMandatoryTask mandatoryTask in MandatoryAITaskData.MandatoryTasks)
		{
			if (mandatoryTask.IsDone)
			{
				continue;
			}
			bool isReverse = mandatoryTask.IsReverseCondition == EGSYesNo.Yes;
			bool flag = false;
			switch (mandatoryTask.TaskCondition)
			{
			case EAITaskCondition.None:
				flag = true;
				break;
			case EAITaskCondition.TargetHpLessThan:
			{
				AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(owner);
				if (aActor == null)
				{
					continue;
				}
				IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(aActor);
				if (readOnlyData == null)
				{
					continue;
				}
				flag = JudgeHpCondition(readOnlyData.GetFloatValue(EBGUAttrFloat.Hp), readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax), mandatoryTask.ConditionFloatParams[0], isReverse);
				break;
			}
			case EAITaskCondition.SelfHasBuff:
				flag = JudgeHasBuffCondition(owner, mandatoryTask.ConditionIntParams[0], isReverse);
				break;
			case EAITaskCondition.TargetHasBuff:
			{
				AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(owner);
				if (aActor == null)
				{
					continue;
				}
				flag = JudgeHasBuffCondition(aActor, mandatoryTask.ConditionIntParams[0], isReverse);
				break;
			}
			}
			if (flag)
			{
				ExecuteTask(mandatoryTask);
			}
		}
	}

	private void ExecuteTask(FMandatoryTask MandatoryTask)
	{
		switch (MandatoryTask.TaskActivationEvent)
		{
		case EAITaskActivationEvent.AtOnce:
			foreach (FUStAITaskInfo aITaskInfo in MandatoryTask.AITaskInfoList)
			{
				ExecuteAtomicTask(aITaskInfo);
			}
			break;
		case EAITaskActivationEvent.BeAttacked:
			MandatoryAITaskData.BeAttackTasks.Add(MandatoryTask);
			break;
		}
		MandatoryTask.IsDone = true;
	}

	private void ExecuteAtomicTask(FUStAITaskInfo AITaskInfo)
	{
		switch (AITaskInfo.AITaskActionType)
		{
		case EAITaskActionType.CastSkill:
			if (AITaskInfo.TaskIntParams.Count >= 1)
			{
				int skillID = AITaskInfo.TaskIntParams[0];
				base.BUSEventCollection?.Evt_BeginPhaseTransitionBySkill.Invoke(skillID);
			}
			break;
		case EAITaskActionType.TriggerSkillEffect:
		{
			FEffectInstReq effectInstReq = new FEffectInstReq(GetOwner());
			{
				foreach (int taskIntParam in AITaskInfo.TaskIntParams)
				{
					base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(taskIntParam, effectInstReq);
				}
				break;
			}
		}
		case EAITaskActionType.TriggerSequence:
		{
			if (AITaskInfo.TaskStringParams.Count < 2)
			{
				break;
			}
			string name = AITaskInfo.TaskStringParams[0];
			string name2 = AITaskInfo.TaskStringParams[1];
			UGameplayStatics.GetAllActorsOfClassWithTag(GetOwner(), UClass.GetClass<AActor>(), new FName(name), out var OutActors);
			{
				foreach (AActor item in OutActors)
				{
					BUS_EventCollectionCS.Get(item).Evt_PlayDynamicSequence.Invoke(GetOwner(), new FName(name2));
				}
				break;
			}
		}
		}
	}

	private bool JudgeHpCondition(float NowHp, float MaxHp, float LimitValue, bool IsReverse)
	{
		float num = NowHp / MaxHp * 100f;
		bool result = false;
		if (IsReverse)
		{
			if (num > LimitValue)
			{
				result = true;
			}
		}
		else if (num <= LimitValue)
		{
			result = true;
		}
		return result;
	}

	private bool JudgeHasBuffCondition(AActor Actor, int BuffID, bool IsReverse)
	{
		return BGUFunctionLibraryCS.BGUHasBuffByID(Actor, BuffID) ^ IsReverse;
	}

	private void OnBeHit()
	{
		if (MandatoryAITaskData.BeAttackTasks == null)
		{
			return;
		}
		foreach (FMandatoryTask beAttackTask in MandatoryAITaskData.BeAttackTasks)
		{
			foreach (FUStAITaskInfo aITaskInfo in beAttackTask.AITaskInfoList)
			{
				ExecuteAtomicTask(aITaskInfo);
			}
		}
		MandatoryAITaskData.BeAttackTasks.Clear();
	}
}
