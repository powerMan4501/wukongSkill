using ArchiveB1;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class PlayerWukongSkillCDInit : ECSDataInitTemplate, IPlayerDataInitTemplate, IWukongDataInitTemplate
{
	public PlayerWukongSkillCDInit(Entity InitEntity, int AActorNetRole)
		: base(InitEntity, AActorNetRole)
	{
	}

	public override void InitDataLateBeginPlay()
	{
	}

	public override void InitDataOnNew()
	{
	}

	public override void InitDataPreBeginPlay()
	{
	}

	public void PostLogin(RoleData RoleData)
	{
		ResetSkillCD();
	}

	public void PostTrans(AActor OldActor)
	{
		ResetSkillCD();
	}

	public void BossRushRecoverCD()
	{
		ResetSkillCD();
	}

	private void ResetSkillCD()
	{
		IBPC_PlayerAttrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerAttrData, BPC_PlayerAttrData>((Owner as APawn)?.PlayerState);
		if (readOnlyData == null)
		{
			return;
		}
		if (readOnlyData.PlayerMagicSkillCd != null)
		{
			BUC_SkillInstsData data = GetData<BUC_SkillInstsData>();
			if (data != null)
			{
				foreach (PlayerMagicSkillCd item in readOnlyData.PlayerMagicSkillCd)
				{
					if (item.CoolDown > 0f)
					{
						data.SetLastSkillCastTime(item.SkillId, Owner.World.GetTimeSeconds() - item.CoolDown);
						data.SkillCanCastCooldownRemainingTime[item.SkillId] = item.CoolDown;
					}
				}
			}
		}
		BUC_LifeSavingData data2 = GetData<BUC_LifeSavingData>();
		if (data2 != null)
		{
			data2.CoolDownRemainTimer = readOnlyData.PlayerLifeSavingCoolDownRemainTime;
		}
	}
}
