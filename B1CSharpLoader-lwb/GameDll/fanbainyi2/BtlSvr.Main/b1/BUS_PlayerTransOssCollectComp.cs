using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using OssB1;
using UnrealEngine.Engine;

namespace b1;

public class BUS_PlayerTransOssCollectComp : UActorCompBaseCS
{
	private IBPC_PlayerTagData PlayerTagData;

	private IBUC_SkillInstsData SkillInstsData;

	private IBUC_UnitStateData UnitStateData;

	private BUC_PlayerTransData PlayerTransData { get; set; }

	public override void OnAttach()
	{
		PlayerTransData = RequireWritableData<BUC_PlayerTransData>();
		PlayerTagData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerTagData, BPC_PlayerTagData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		base.BUSEventCollection.Evt_UpdateOSSAttackData += new Del_OSSBattle(OnUpdateOSSAttackData);
	}

	public override void OnBeginPlay()
	{
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BUSEventCollection.Evt_UpdateOSSAttackData -= new Del_OSSBattle(OnUpdateOSSAttackData);
	}

	private void OnUpdateOSSAttackData(int SkillId, AActor Victim, int DamageValue, bool bIsCrit, bool bIsElemDot)
	{
		if (PlayerTagData == null || !PlayerTagData.HasTag(EBGPPlayerTag.Transforming) || !(Victim != null))
		{
			return;
		}
		string actorGuid = BGU_DataUtil.GetActorGuid(Victim);
		int finalBattleInfoExtendID = (Victim as BGUCharacterCS).GetFinalBattleInfoExtendID();
		IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Victim);
		if (PlayerTransData.TransDmgDict.TryGetValue(actorGuid, out var value))
		{
			bool flag = false;
			foreach (PlayerTransDmgInfo item in value.TransDmgInfo)
			{
				if (item.SkillId == SkillId)
				{
					item.DmgValue += DamageValue;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				PlayerTransDmgInfo playerTransDmgInfo = new PlayerTransDmgInfo();
				playerTransDmgInfo.SkillId = SkillId;
				playerTransDmgInfo.DmgValue = DamageValue;
				value.TransDmgInfo.Add(playerTransDmgInfo);
			}
		}
		else
		{
			TransDmgStruct value2 = new TransDmgStruct
			{
				ExtendId = finalBattleInfoExtendID,
				HpMax = (int)readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax)
			};
			PlayerTransDmgInfo playerTransDmgInfo2 = new PlayerTransDmgInfo();
			playerTransDmgInfo2.SkillId = SkillId;
			playerTransDmgInfo2.DmgValue = DamageValue;
			value2.TransDmgInfo = new List<PlayerTransDmgInfo>();
			value2.TransDmgInfo.Add(playerTransDmgInfo2);
			PlayerTransData.TransDmgDict.Add(actorGuid, value2);
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickTransAttackState(DeltaTime);
	}

	private void TickTransAttackState(float DeltaTime)
	{
		if (!PlayerTagData.HasTag(EBGPPlayerTag.Transforming) || SkillInstsData.CurrentCastingSkillID == 0)
		{
			return;
		}
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillInstsData.CurrentCastingSkillID, GetOwner());
		if (skillSDesc != null && UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			if (skillSDesc.SkillType == ESkillType.RollSkill)
			{
				PlayerTransData.RollDur += DeltaTime;
			}
			else
			{
				PlayerTransData.AttackDur += DeltaTime;
			}
		}
	}
}
