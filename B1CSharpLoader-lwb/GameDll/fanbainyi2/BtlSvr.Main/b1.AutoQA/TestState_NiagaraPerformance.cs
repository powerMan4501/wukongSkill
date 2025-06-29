using System;
using System.Collections.Generic;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_NiagaraPerformance : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		FindEnemy_ByUClass,
		Read_SkillList,
		Pause_BT,
		Cast_Skill_Start,
		Cast_Skill_Monitor,
		Cast_Skill_Wait
	}

	private InnerState CurrentState;

	private BGUCharacterCS Enemy;

	private readonly UClass MonsterClass;

	private readonly UClass TamerClass;

	private readonly int DistanceBetween;

	private List<int> AllSkillID;

	private int CurrentIndexID = -1;

	private int TickCounter;

	private AActor NiagaraStatUI;

	private bool WaitSkillEffect;

	private int CurrentWaitCounter;

	private bool isPlayer;

	private int RoleDataConfig;

	private TArrayReadWrite<int> SkillIDBlackList;

	public TestState_NiagaraPerformance(UObject WorldContext, UClass Class, int DistanceBetween, bool isPlayer = false, int RoleDataConfig = 0, TArrayReadWrite<int> SkillIDBlackList = null)
	{
		base.WorldContext = WorldContext;
		BUTamerActor bUTamerActor = Class.ClassDefaultObject.Cast<BUTamerActor>();
		if (bUTamerActor == null)
		{
			MonsterClass = Class;
		}
		else
		{
			TamerClass = Class;
			MonsterClass = bUTamerActor.GetMonsterClass();
		}
		this.DistanceBetween = DistanceBetween;
		CurrentState = InnerState.FindEnemy_ByUClass;
		this.isPlayer = isPlayer;
		this.RoleDataConfig = RoleDataConfig;
		this.SkillIDBlackList = SkillIDBlackList;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	private SpellType GetSpellTypeBySkillID(int SkillID)
	{
		foreach (SpellDesc item in GameDBRuntime.GetTBSpellDesc().List)
		{
			if (item.SkillId == SkillID)
			{
				return item.Type;
			}
		}
		return SpellType.Min;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.FindEnemy_ByUClass:
			Description = "寻敌中";
			if (TamerClass != null)
			{
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, TamerClass);
				if (allActorsOfClass.Length == 0)
				{
					throw new Exception("在UnitCastAllSkill节点中，未能找到" + TamerClass.GetName());
				}
				Enemy = (allActorsOfClass[0] as BUTamerActor).GetMonster();
			}
			else
			{
				AActor[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass(WorldContext, MonsterClass);
				if (allActorsOfClass2.Length == 0)
				{
					throw new Exception("在UnitCastAllSkill节点中，未能找到" + MonsterClass.GetName());
				}
				Enemy = allActorsOfClass2[0] as BGUCharacterCS;
			}
			Description = $"找到了{MonsterClass.GetName()}";
			TransferState(InnerState.Read_SkillList);
			break;
		case InnerState.Read_SkillList:
		{
			Description = "读取Skill列表";
			AutoTestLoggerLib.QALogInfo(WorldContext, "读取Skill列表");
			AllSkillID = BGUFuncLibAICS.BGUGetUnitAllSkillID(Enemy);
			if (Enemy == UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS)
			{
				List<int> list = new List<int>();
				foreach (int item in AllSkillID)
				{
					if (GetSpellTypeBySkillID(item) != SpellType.BianShen && !SkillIDBlackList.Contains(item))
					{
						list.Add(item);
					}
				}
				AllSkillID = list;
			}
			BUS_EventCollectionCS.Get(Enemy).Evt_AIPauseBT.Invoke(P1: true);
			CurrentIndexID = -1;
			UGameplayStatics.GetAllActorsOfClassWithTag(Enemy, UClass.GetClass<AActor>(), new FName("NiagaraStat"), out var OutActors);
			if (OutActors.Count > 0)
			{
				NiagaraStatUI = OutActors[0];
			}
			TransferState(InnerState.Pause_BT);
			break;
		}
		case InnerState.Pause_BT:
			if (BGUFunctionLibraryCS.BGUHasUnitState(Enemy, EBGUUnitState.Attacking))
			{
				Description = "等待怪物暂停自主AI中";
				break;
			}
			Description = "怪物已经暂停自主AI了";
			TransferState(InnerState.Cast_Skill_Start);
			break;
		case InnerState.Cast_Skill_Start:
		{
			CurrentIndexID++;
			if (CurrentIndexID < AllSkillID.Count)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullMp 1", null);
				if (SkillIDBlackList.Contains(AllSkillID[CurrentIndexID]))
				{
					Description = "技能" + AllSkillID[CurrentIndexID] + "在黑名单中，不予释放";
					break;
				}
				if (CurrentIndexID > 0)
				{
					AutoTestLoggerLib.QALogInfo(WorldContext, "EndSkill");
					NiagaraStatUI?.CallFunctionByNameWithArguments("EndSkill", forceCallWithNonExec: true);
				}
				if (NiagaraStatUI != null)
				{
					string arg = (isPlayer ? (MonsterClass.GetName() + "_" + RoleDataConfig) : MonsterClass.GetName());
					string text = $"StartSkill {arg} {AllSkillID[CurrentIndexID].ToString()} {BGW_GameDB.GetSkillSDesc(AllSkillID[CurrentIndexID], Enemy).TemplatePath}";
					AutoTestLoggerLib.QALogInfo(WorldContext, text);
					NiagaraStatUI.CallFunctionByNameWithArguments(text, forceCallWithNonExec: true);
				}
				FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation();
				FVector fVector = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorRotation()
					.GetForwardVector() * DistanceBetween;
				BGUFuncLibActorTransformCS.BGUSetActorLocation(Enemy, actorLocation + fVector, bSweep: false, bTeleport: false, out var _);
				Description = "命令释放技能" + AllSkillID[CurrentIndexID];
				BGUFunctionLibraryCS.BGUTryCastSpell(Enemy, AllSkillID[CurrentIndexID], ECastSkillSourceType.QA);
				TransferState(InnerState.Cast_Skill_Monitor);
				break;
			}
			AutoTestLoggerLib.QALogInfo(WorldContext, "EndSkill");
			NiagaraStatUI?.CallFunctionByNameWithArguments("EndSkill", forceCallWithNonExec: true);
			BUS_EventCollectionCS.Get(Enemy).Evt_UnitDead.Invoke(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), EDeadReason.SkillDamage);
			Description = MonsterClass.GetName() + "的全部技能释放完毕";
			string text2 = $"SaveStatData {1}";
			AutoTestLoggerLib.QALogInfo(WorldContext, text2);
			NiagaraStatUI?.CallFunctionByNameWithArguments(text2, forceCallWithNonExec: true);
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		case InnerState.Cast_Skill_Monitor:
			if (Enemy != UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS)
			{
				AutoTestHelperLib.CameraLockTarget(WorldContext, Enemy);
			}
			if (TickCounter > 60)
			{
				Description = "技能" + AllSkillID[CurrentIndexID] + "释放不正常，半分钟内没有结束，因此跳过";
				AutoTestLoggerLib.QALogWarning(WorldContext, Description);
				TransferState(InnerState.Cast_Skill_Wait);
			}
			else if (BGUFunctionLibraryCS.BGUHasUnitState(Enemy, EBGUUnitState.Attacking))
			{
				Description = "正在释放技能" + AllSkillID[CurrentIndexID] + " 路径为：" + BGW_GameDB.GetSkillSDesc(AllSkillID[CurrentIndexID], Enemy).TemplatePath;
			}
			else
			{
				Description = "技能" + AllSkillID[CurrentIndexID] + "释放完了";
				TransferState(InnerState.Cast_Skill_Wait);
			}
			break;
		case InnerState.Cast_Skill_Wait:
			if (TickCounter < 10)
			{
				Description = "等待上一个技能的特效完全消失中";
				break;
			}
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.teleportToPosition 0 0 100", null);
			Description = "准备释放下一个技能";
			TransferState(InnerState.Cast_Skill_Start);
			break;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
