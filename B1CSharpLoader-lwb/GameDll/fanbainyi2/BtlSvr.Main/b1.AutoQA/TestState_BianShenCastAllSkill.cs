using System.Collections.Generic;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_BianShenCastAllSkill : AutoTestNodeLib.TestState_Node
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

	private List<int> AllSkillID;

	private int CurrentIndexID = -1;

	private int TickCounter;

	private AActor NiagaraStatUI;

	private int TransSkillID;

	public TestState_BianShenCastAllSkill(UObject WorldContext, int TransSkillID)
	{
		base.WorldContext = WorldContext;
		this.TransSkillID = TransSkillID;
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

	private bool SkillIsSpell(int SkillID)
	{
		foreach (SpellDesc item in GameDBRuntime.GetTBSpellDesc().List)
		{
			if (item.SkillId == SkillID)
			{
				return true;
			}
		}
		return false;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.FindEnemy_ByUClass:
		{
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullTransEnergy 1", null);
			BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
			BGUFunctionLibraryCS.BGUTryCastSpell(bGUCharacterCS, TransSkillID, ECastSkillSourceType.QA);
			Description = $"使用{TransSkillID}变身";
			TransferState(InnerState.Read_SkillList);
			break;
		}
		case InnerState.Read_SkillList:
		{
			if (TickCounter < 20)
			{
				Description = "等待变身完成中";
				break;
			}
			Description = "读取Skill列表";
			AutoTestLoggerLib.QALogInfo(WorldContext, "读取Skill列表");
			BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
			AllSkillID = BGUFuncLibAICS.BGUGetUnitAllSkillID(bGUCharacterCS);
			List<int> list = new List<int>();
			foreach (int item in AllSkillID)
			{
				if (!SkillIsSpell(item))
				{
					list.Add(item);
				}
			}
			AllSkillID = list;
			CurrentIndexID = -1;
			UGameplayStatics.GetAllActorsOfClassWithTag(bGUCharacterCS, UClass.GetClass<AActor>(), new FName("NiagaraStat"), out var OutActors);
			if (OutActors.Count > 0)
			{
				NiagaraStatUI = OutActors[0];
			}
			TransferState(InnerState.Cast_Skill_Start);
			break;
		}
		case InnerState.Cast_Skill_Start:
		{
			CurrentIndexID++;
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullMp 1", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.FullTransEnergy 1", null);
			BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
			if (CurrentIndexID < AllSkillID.Count)
			{
				if (CurrentIndexID > 0)
				{
					AutoTestLoggerLib.QALogInfo(WorldContext, "EndSkill");
					NiagaraStatUI?.CallFunctionByNameWithArguments("EndSkill", forceCallWithNonExec: true);
				}
				if (NiagaraStatUI != null)
				{
					int resID = bGUCharacterCS.GetResID();
					string text = $"StartSkill {resID} {AllSkillID[CurrentIndexID].ToString()} {BGW_GameDB.GetSkillSDesc(AllSkillID[CurrentIndexID], bGUCharacterCS).TemplatePath}";
					AutoTestLoggerLib.QALogInfo(WorldContext, text);
					NiagaraStatUI.CallFunctionByNameWithArguments(text, forceCallWithNonExec: true);
				}
				FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation();
				FVector fVector = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorRotation()
					.GetForwardVector() * 0.0;
				BGUFuncLibActorTransformCS.BGUSetActorLocation(bGUCharacterCS, actorLocation + fVector, bSweep: false, bTeleport: false, out var _);
				Description = "命令释放技能" + AllSkillID[CurrentIndexID];
				BGUFunctionLibraryCS.BGUTryCastSpell(bGUCharacterCS, AllSkillID[CurrentIndexID], ECastSkillSourceType.QA);
				TransferState(InnerState.Cast_Skill_Monitor);
				break;
			}
			AutoTestLoggerLib.QALogInfo(WorldContext, "EndSkill");
			NiagaraStatUI?.CallFunctionByNameWithArguments("EndSkill", forceCallWithNonExec: true);
			bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
			BPS_EventCollectionCS.Get(bGUCharacterCS.PlayerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CastSpell, default(PlayerTransParam));
			Description = bGUCharacterCS.GetResID() + "的全部技能释放完毕";
			string text2 = $"SaveStatData {1}";
			AutoTestLoggerLib.QALogInfo(WorldContext, text2);
			NiagaraStatUI?.CallFunctionByNameWithArguments(text2, forceCallWithNonExec: true);
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		case InnerState.Cast_Skill_Monitor:
		{
			if (TickCounter > 60)
			{
				Description = "技能" + AllSkillID[CurrentIndexID] + "释放不正常，半分钟内没有结束，因此跳过";
				AutoTestLoggerLib.QALogWarning(WorldContext, Description);
				TransferState(InnerState.Cast_Skill_Wait);
				break;
			}
			BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
			if (BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS, EBGUUnitState.Attacking))
			{
				Description = "正在释放技能" + AllSkillID[CurrentIndexID] + " 路径为：" + BGW_GameDB.GetSkillSDesc(AllSkillID[CurrentIndexID], bGUCharacterCS).TemplatePath;
				break;
			}
			Description = "技能" + AllSkillID[CurrentIndexID] + "释放完了";
			TransferState(InnerState.Cast_Skill_Wait);
			break;
		}
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
