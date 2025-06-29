using System.Collections.Generic;
using b1.EventDelDefine;
using OssB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_OSSCollectionMgrSystem : GameModeSystemBase
{
	private List<AActor> BattleTransUnitRecord = new List<AActor>();

	private BGC_OSSCollectionData OSSCollectionData { get; set; }

	private BGS_GSEventCollection EventCollection { get; set; }

	private IBIC_BossRushData BossRushData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		OSSCollectionData = RequireWritableGameStateData<BGC_OSSCollectionData>();
		if (OSSCollectionData != null)
		{
			EventCollection = BGS_GSEventCollection.Get(this);
			if (EventCollection != null)
			{
				EventCollection.Evt_BGS_OnBattlePlayerTransited += new Del_Void_ActorActor(OnBattlePlayerTransited);
				EventCollection.Evt_BGS_SetOSSAiPartnerInfo += new Del_BattleMonsterData(OnSetOSSAiPartnerInfo);
				EventCollection.Evt_BGS_SetOSSMonstInfo += new Del_BattleMonsterData(OnSetOSSMonstInfo);
				EventCollection.Evt_BGS_OnPlayerIntoBattle += new Del_Void_IntActor(OnPlayerIntoBattle);
				EventCollection.Evt_BGS_OnPlayerLeaveBattle += new Del_OnPlayerLeaveBattle(OnPlayerLeaveBattle);
				EventCollection.Evt_BGS_OnTaskStageChange += new Del_OnTaskStageChange(OnTaskStageChange);
				EventCollection.Evt_BGS_Demo820OSSEndLevel += new Del_Void(Demo820OSSEndLevel);
			}
			BossRushData = RequireReadonlyGameInstanceData<IBIC_BossRushData, BIC_BossRushData>();
		}
	}

	private void CheckPlayerInFightNum()
	{
		if (OSSCollectionData.PlayerNum_LastFrame == 0 && OSSCollectionData.CurPlayerNum > 0)
		{
			OSSCollectionData.AiPartnerList = new List<BattleMonster>();
			OSSCollectionData.BattleMonsterList = new List<BattleMonster>();
			OSSCollectionData.UnitTransList = new List<BattlePlayer>();
			OSSCollectionData.BattlePlayerDic = new Dictionary<ulong, BattlePlayer>();
			OSSCollectionData.BattleBeginFightTime = OSSCollectionData.BeginFightTime_Last;
		}
		else if (OSSCollectionData.PlayerNum_LastFrame > 0 && OSSCollectionData.CurPlayerNum == 0)
		{
			Report();
		}
		OSSCollectionData.PlayerNum_LastFrame = OSSCollectionData.CurPlayerNum;
	}

	private void Demo820OSSEndLevel()
	{
		if ((float)OSSCollectionData.BeginFightTime_Last > 0f)
		{
			Report();
		}
	}

	private void Report()
	{
		base.BGSEventCollection.Evt_BGS_EarlyTerminateAiUnitBattleRecord.Invoke();
		ReportEventBattle reportEventBattle = new ReportEventBattle();
		reportEventBattle.PlayType = ((!UGSE_EngineFuncLib.IsStandAlone(Owner.World)) ? PlayType.Online : PlayType.Single);
		if (B1Global.GIsBossRushMode && BossRushData != null)
		{
			switch (BossRushData.BossRushType)
			{
			case EBossRushType.Rechallenge:
				reportEventBattle.PlayType = PlayType.BossrushReChallenge;
				break;
			case EBossRushType.BossIterations:
				reportEventBattle.PlayType = PlayType.BossrushBossIterations;
				break;
			case EBossRushType.IterationsPractise:
				reportEventBattle.PlayType = PlayType.BossrushIterationsPractise;
				break;
			}
			reportEventBattle.HardLevel = BossRushData.BossRushBattleData.Score;
			foreach (int debuff in BossRushData.BossRushBattleData.DebuffList)
			{
				reportEventBattle.DebuffList.Add(debuff);
			}
		}
		reportEventBattle.Dur = OSSCollectionData.LeaveFightTime_Last - OSSCollectionData.BattleBeginFightTime;
		foreach (BattleMonster battleMonster in OSSCollectionData.BattleMonsterList)
		{
			reportEventBattle.Monsts.Add(battleMonster);
		}
		reportEventBattle.TotalMonster = reportEventBattle.Monsts.Count;
		foreach (BattleMonster aiPartner in OSSCollectionData.AiPartnerList)
		{
			reportEventBattle.AiPartners.Add(aiPartner);
		}
		foreach (KeyValuePair<ulong, BattlePlayer> item in OSSCollectionData.BattlePlayerDic)
		{
			reportEventBattle.Players.Add(item.Value);
		}
		foreach (BattlePlayer unitTrans in OSSCollectionData.UnitTransList)
		{
			reportEventBattle.UnitTrans.Add(unitTrans);
		}
		EventReporter.GetInstance(Owner)?.Battle(reportEventBattle);
		OSSCollectionData.BeginFightTime_Last = -1;
	}

	private void OnBattlePlayerTransited(AActor OldActor, AActor NewActor)
	{
		BattleTransUnitRecord.Add(NewActor);
	}

	public void OnPlayerIntoBattle(int BeginFightTime, AActor Player)
	{
		if (!Player.IsNullOrDestroyed())
		{
			if (BattleTransUnitRecord.Contains(Player))
			{
				BattleTransUnitRecord.Remove(Player);
			}
			else
			{
				OSSCollectionData.CurPlayerNum++;
			}
			if (OSSCollectionData.BeginFightTime_Last == -1)
			{
				OSSCollectionData.BeginFightTime_Last = BeginFightTime;
			}
			CheckPlayerInFightNum();
		}
	}

	public void OnPlayerLeaveBattle(ulong RoleId, BattlePlayer Player, int LeaveFightTime, bool bIsTansUnit, bool BecauseOfTrans)
	{
		if (!BecauseOfTrans)
		{
			OSSCollectionData.CurPlayerNum--;
		}
		if (bIsTansUnit)
		{
			RecordUnitTransData(Player);
		}
		else
		{
			RecordPlayerData(RoleId, Player);
		}
		OSSCollectionData.LeaveFightTime_Last = LeaveFightTime;
		CheckPlayerInFightNum();
	}

	private void RecordPlayerData(ulong RoleId, BattlePlayer Player)
	{
		if (OSSCollectionData.BattlePlayerDic.ContainsKey(RoleId))
		{
			BattlePlayer battlePlayer = OSSCollectionData.BattlePlayerDic[RoleId];
			battlePlayer.Player = Player.Player;
			battlePlayer.EndType = Player.EndType;
			foreach (Item item in Player.ItemUse)
			{
				bool flag = false;
				for (int i = 0; i < battlePlayer.ItemUse.Count; i++)
				{
					if (battlePlayer.ItemUse[i].Id == item.Id)
					{
						flag = true;
						battlePlayer.ItemUse[i].Num += item.Num;
					}
				}
				if (!flag)
				{
					battlePlayer.ItemUse.Add(item);
				}
			}
			foreach (Attack item2 in Player.Atk)
			{
				bool flag2 = false;
				for (int j = 0; j < battlePlayer.Atk.Count; j++)
				{
					if (battlePlayer.Atk[j].Id == item2.Id)
					{
						battlePlayer.Atk[j].Num += item2.Num;
						battlePlayer.Atk[j].Dmg += item2.Dmg;
						battlePlayer.Atk[j].Hit += item2.Hit;
						battlePlayer.Atk[j].Target += item2.Target;
						battlePlayer.Atk[j].Call += item2.Call;
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					battlePlayer.Atk.Add(item2);
				}
			}
			foreach (Defence item3 in Player.Def)
			{
				bool flag3 = false;
				for (int k = 0; k < battlePlayer.Def.Count; k++)
				{
					if (battlePlayer.Def[k].Id == item3.Id && battlePlayer.Def[k].IsMonst == item3.IsMonst)
					{
						battlePlayer.Def[k].Num += item3.Num;
						battlePlayer.Def[k].Dmg += item3.Dmg;
						battlePlayer.Def[k].IsKill |= item3.IsKill;
						flag3 = true;
						break;
					}
				}
				if (!flag3)
				{
					battlePlayer.Def.Add(item3);
				}
			}
			battlePlayer.Dur += Player.Dur;
			OSSCollectionData.BattlePlayerDic[RoleId] = battlePlayer;
		}
		else
		{
			BattlePlayer battlePlayer2 = new BattlePlayer();
			battlePlayer2 = Player;
			OSSCollectionData.BattlePlayerDic.Add(RoleId, battlePlayer2);
		}
	}

	private void RecordUnitTransData(BattlePlayer Player)
	{
		BattlePlayer battlePlayer = new BattlePlayer();
		battlePlayer = Player;
		OSSCollectionData.UnitTransList.Add(battlePlayer);
	}

	public void OnTaskStageChange(ulong RoleId, int TaskLineID, int TaskStageID, TaskStageState StageState, string StageNote)
	{
		EventReporter.GetInstance(Owner).Task(new ReportEventTask
		{
			RoleId = RoleId,
			TaskId = TaskLineID,
			Stage = TaskStageID,
			State = StageState,
			StageNote = StageNote
		});
	}

	private void OnSetOSSMonstInfo(BattleMonster BattleMonsterData)
	{
		if (OSSCollectionData.BattleMonsterList != null)
		{
			OSSCollectionData.BattleMonsterList.Add(BattleMonsterData);
		}
	}

	private void OnSetOSSAiPartnerInfo(BattleMonster BattleAiPartnerData)
	{
		if (OSSCollectionData.AiPartnerList != null)
		{
			OSSCollectionData.AiPartnerList.Add(BattleAiPartnerData);
		}
	}
}
