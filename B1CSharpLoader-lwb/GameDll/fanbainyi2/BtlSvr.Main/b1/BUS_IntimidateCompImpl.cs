using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_IntimidateCompImpl : UActorCompBaseCS
{
	private BUC_IntimidateData IntimidateData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_AIData AIData;

	public override void OnAttach()
	{
		IntimidateData = RequireWritableData<BUC_IntimidateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		base.BUSEventCollection.Evt_TriggerIntimidation += new Del_TriggerIntimidation(OnTriggerIntimidation);
		base.BUSEventCollection.Evt_InitiateIntimidation += new Del_InitiateIntimidation(OnInitiateIntimidation);
	}

	public override void PreBeginPlay()
	{
		IntimidateData.IntimidatedCDTimer = 0f;
		IntimidateData.IntimidatingCDTimer = 0f;
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
		if (!(Owner == null))
		{
			if (IntimidateData.IntimidatingCDTimer > 0f)
			{
				IntimidateData.IntimidatingCDTimer -= DeltaTime;
			}
			if (IntimidateData.IntimidatedCDTimer > 0f)
			{
				IntimidateData.IntimidatedCDTimer -= DeltaTime;
			}
			UpdateForDebug(Owner);
		}
	}

	private void UpdateForDebug(AActor OwnerActor)
	{
		if (AIData.IsAI && DebugConfig.AIInfo)
		{
			string text = "";
			text = ((!(IntimidateData.IntimidatingCDTimer <= 0f)) ? ("发起恐吓倒计时：" + IntimidateData.IntimidatingCDTimer.ToString("F2")) : "现在可发起恐吓！");
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("Intimidation", text);
			string text2 = "";
			if (IntimidateData.IntimidatedCDTimer <= 0f)
			{
				UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
				_ = targetInfo.LockTargetEntity;
				text2 = ((targetInfo.LockTargetWayType == ELockTargetWayType.Auto) ? "没有目标，不能接受恐吓！" : ((!UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.Beatback)) ? "现在可接受恐吓！" : "处于AtkState或者Beatback状态，不能接受恐吓！"));
			}
			else
			{
				text2 = "接受恐吓倒计时：" + IntimidateData.IntimidatedCDTimer.ToString("F2");
			}
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("Intimidation", text2, 1);
		}
	}

	private void OnTriggerIntimidation(int StiffLevel, bool bTriggerByDead)
	{
		AActor owner = GetOwner();
		if (owner == null || !(IntimidateData.IntimidatingMinStiffLevel <= StiffLevel || bTriggerByDead) || !(IntimidateData.IntimidatingCDTimer <= 0f))
		{
			return;
		}
		int intimidatingProbability = IntimidateData.IntimidatingProbability;
		int randomNumberInt = UB1Util.GetRandomNumberInt(1, 10000);
		if (intimidatingProbability < randomNumberInt)
		{
			return;
		}
		IntimidateData.IntimidatingCDTimer = IntimidateData.IntimidatingCD;
		int intimidatingRange = IntimidateData.IntimidatingRange;
		int intimidatingInfluenceMaxNum = IntimidateData.IntimidatingInfluenceMaxNum;
		if (GSGameplayCVar.CVar_IntimidateDebugInfoShowIntimidateRange.GetValueInGameThread() != 0)
		{
			USystemLibrary.DrawDebugSphere(owner, owner.GetActorLocation(), intimidatingRange, 12, FLinearColor.Yellow, 3f, 0f);
		}
		BGUFuncLibSelectTargetsCS.BGUSelectTargetsInShapeForIntimidation(owner, out var OutActors, owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), ERangeType.Circle, 2, 1, 0, (IList<int>)new List<int> { intimidatingRange });
		List<AActor> list = new List<AActor>();
		foreach (AActor item in OutActors)
		{
			if (list.Count >= intimidatingInfluenceMaxNum)
			{
				break;
			}
			IBUC_IntimidateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_IntimidateData, BUC_IntimidateData>(item);
			if (readOnlyData == null || readOnlyData.IntimidatedSkillList == null || readOnlyData.IntimidatedSkillList.Count <= 0)
			{
				continue;
			}
			IBUC_TargetInfoData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(item);
			IBUC_UnitStateData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(item);
			if (readOnlyData2 != null && readOnlyData3 != null && !readOnlyData3.HasState(EBGUUnitState.Attacking) && !readOnlyData3.HasState(EBGUUnitState.Beatback))
			{
				UnitLockTargetInfo targetInfo = readOnlyData2.GetTargetInfo();
				_ = targetInfo.LockTargetEntity;
				if (targetInfo.LockTargetWayType != ELockTargetWayType.Auto)
				{
					list.Add(item);
				}
			}
		}
		foreach (AActor item2 in list)
		{
			if (item2 != null)
			{
				BUS_EventCollectionCS.Get(item2)?.Evt_InitiateIntimidation.Invoke(Owner);
			}
		}
	}

	private void OnInitiateIntimidation(AActor InitiatorsActor)
	{
		if (UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			return;
		}
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		_ = targetInfo.LockTargetEntity;
		if (targetInfo.LockTargetWayType != ELockTargetWayType.Auto && IntimidateData.IntimidatedCDTimer <= 0f && IntimidateData.IntimidatedSkillList != null && IntimidateData.IntimidatedSkillList.Count > 0)
		{
			int intimidatedProbability = IntimidateData.IntimidatedProbability;
			int randomNumberInt = UB1Util.GetRandomNumberInt(1, 10000);
			if (intimidatedProbability >= randomNumberInt)
			{
				IntimidateData.IntimidatedCDTimer = IntimidateData.IntimidatedCD;
				int randomNumberInt2 = UB1Util.GetRandomNumberInt(0, IntimidateData.IntimidatedSkillList.Count - 1);
				FCastSkillInfo cSI = new FCastSkillInfo(IntimidateData.IntimidatedSkillList[randomNumberInt2], ECastSkillSourceType.Intimidate);
				base.BUSEventCollection?.Evt_UnitCastSkillTry.Invoke(cSI);
			}
		}
	}
}
