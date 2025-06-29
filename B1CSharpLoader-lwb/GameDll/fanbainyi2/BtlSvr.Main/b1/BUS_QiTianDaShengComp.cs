using System.Linq;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUS_QiTianDaShengComp : UActorCompBaseCS
{
	private static int NORMAL_DASHENG_CONFIG_ID = 1;

	private static int HGS_DASHENG_CONFIG_ID = 2;

	private static int HGS_LEVEL_ID = 98;

	private static int HGS_SHI_ZHONG_JING_LEVEL_ID = 61;

	private BUC_QiTianDaShengData QiTianDaShengData;

	private IBUC_EquipData EquipData;

	private IBUC_BuffData BuffData;

	private IBUC_PassiveSkillData PassiveSkillData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBPC_RoleBaseData RoleBaseData;

	private IBIC_LevelData LevelData;

	private bool bHasInit;

	public override void OnAttach()
	{
		QiTianDaShengData = RequireWritableData<BUC_QiTianDaShengData>();
		EquipData = RequireReadOnlyData<IBUC_EquipData, BUC_EquipData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		PassiveSkillData = RequireReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		RoleBaseData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>((GetOwner() as APawn)?.PlayerState);
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		base.BUSEventCollection.Evt_TriggerTrans2DaSheng += new Del_Void(OnTriggerTrans2DaSheng);
		base.BUSEventCollection.Evt_TriggerBanTrans2DaSheng += new Del_Void(OnTriggerBanTrans2DaSheng);
		base.BUSEventCollection.Evt_ResetDaShengStatus += new Del_Void(OnResetDaShengStatus);
		base.BUSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(OnAfterUnitRebirth);
	}

	public override void OnBeginPlay()
	{
		QiTianDaShengData.bIsBanTrans2DaSheng = false;
		QiTianDaShengData.DaShengDurationTimer = -1f;
		QiTianDaShengData.DaShengDurationTotalTime = -1f;
	}

	public override int GetTickGroupMask()
	{
		return 1;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!bHasInit)
		{
			bHasInit = true;
			int configID = (IsInHGSLevel() ? HGS_DASHENG_CONFIG_ID : NORMAL_DASHENG_CONFIG_ID);
			InitDaShengConfig(configID);
		}
		if (!bHasInit)
		{
			return;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.BanTrans2DaSheng) || QiTianDaShengData.bIsBanTrans2DaSheng)
		{
			Reset2LittleMonkey();
			return;
		}
		switch (QiTianDaShengData.DaShengStage)
		{
		case EDaShengStage.LittleMonkey:
			if (QiTianDaShengData.HasValidDescInfo && CheckCanKeepDaShengMode())
			{
				if (IsInHGSLevel())
				{
					TrySwitch2DaShengMode(EDaShengStage.LittleMonkey);
				}
				else
				{
					TrySwitch2PreStage(EDaShengStage.LittleMonkey);
				}
			}
			break;
		case EDaShengStage.PreStage:
			if (!CheckCanKeepDaShengMode())
			{
				TrySwitch2LittleMonkey(EDaShengStage.PreStage);
			}
			break;
		case EDaShengStage.DaShengMode:
		{
			bool flag = CheckCanKeepDaShengMode();
			if (!IsInHGSLevel())
			{
				QiTianDaShengData.DaShengDurationTimer += DeltaTime;
				FUStTransQiTianDaShengConfigDesc transQiTianDaShengConfigDesc = BGW_GameDB.GetTransQiTianDaShengConfigDesc(NORMAL_DASHENG_CONFIG_ID, Owner);
				if (transQiTianDaShengConfigDesc != null)
				{
					QiTianDaShengData.DaShengDurationTotalTime = transQiTianDaShengConfigDesc.Duration;
					if (QiTianDaShengData.DaShengDurationTimer >= (float)transQiTianDaShengConfigDesc.Duration)
					{
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				TrySwitch2LittleMonkey(EDaShengStage.DaShengMode);
			}
			break;
		}
		}
	}

	private void InitDaShengConfig(int ConfigID)
	{
		FUStTransQiTianDaShengConfigDesc transQiTianDaShengConfigDesc = BGW_GameDB.GetTransQiTianDaShengConfigDesc(ConfigID, Owner);
		if (transQiTianDaShengConfigDesc != null)
		{
			QiTianDaShengData.PreDaSheng_BeginTriggerEffectIDList = transQiTianDaShengConfigDesc.PreDaShengBeginTriggerEffectIDList.ToList();
			QiTianDaShengData.PreDaSheng_BeginTriggerBuffIDList = transQiTianDaShengConfigDesc.PreDaShengBeginTriggerBuffIDList.ToList();
			QiTianDaShengData.PreDaSheng_SustainTriggerBuffIDList = transQiTianDaShengConfigDesc.PreDaShengSustainTriggerBuffIDList.ToList();
			QiTianDaShengData.DaSheng_BeginTriggerEffectIDList = transQiTianDaShengConfigDesc.DaShengBeginTriggerEffectIDList.ToList();
			QiTianDaShengData.DaSheng_BeginTriggerBuffIDList = transQiTianDaShengConfigDesc.DaShengBeginTriggerBuffIDList.ToList();
			QiTianDaShengData.DaSheng_SustainTriggerBuffIDList = transQiTianDaShengConfigDesc.DaShengSustainTriggerBuffIDList.ToList();
			QiTianDaShengData.RelatedTalentIDList = transQiTianDaShengConfigDesc.RelatedTalentIDList.ToList();
			QiTianDaShengData.RelatedEquipIDList = transQiTianDaShengConfigDesc.RelatedEquipIDList.ToList();
			if (QiTianDaShengData.RelatedTalentIDList.Count > 0 || QiTianDaShengData.RelatedEquipIDList.Count > 0)
			{
				QiTianDaShengData.HasValidDescInfo = true;
			}
		}
	}

	private bool CheckCanKeepDaShengMode()
	{
		if (IsInHGSLevel())
		{
			bool result = false;
			if (QiTianDaShengData.RelatedEquipIDList.Count > 0)
			{
				result = QiTianDaShengData.RelatedEquipIDList.All((int item) => EquipData.SelfEquipMap.Values.Contains(item));
			}
			return result;
		}
		bool flag = false;
		bool flag2 = false;
		if (QiTianDaShengData.RelatedEquipIDList.Count > 0)
		{
			flag = QiTianDaShengData.RelatedEquipIDList.All((int item) => EquipData.SelfEquipMap.Values.Contains(item));
		}
		if (QiTianDaShengData.RelatedTalentIDList.Count > 0)
		{
			flag2 = QiTianDaShengData.RelatedTalentIDList.All((int item) => RoleBaseData.TalenList.Keys.Contains(item));
		}
		return flag && flag2;
	}

	private bool IsInHGSLevel()
	{
		if (LevelData.CurrentLevelID == HGS_LEVEL_ID || LevelData.CurrentLevelID == HGS_SHI_ZHONG_JING_LEVEL_ID)
		{
			return true;
		}
		return false;
	}

	private void TrySwitch2LittleMonkey(EDaShengStage LastStage)
	{
		QiTianDaShengData.DaShengStage = EDaShengStage.LittleMonkey;
		QiTianDaShengData.DaShengDurationTimer = -1f;
		QiTianDaShengData.DaShengDurationTotalTime = -1f;
		switch (LastStage)
		{
		case EDaShengStage.PreStage:
			foreach (int preDaSheng_BeginTriggerBuffID in QiTianDaShengData.PreDaSheng_BeginTriggerBuffIDList)
			{
				if (BuffData.HasBuff(preDaSheng_BeginTriggerBuffID))
				{
					base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(preDaSheng_BeginTriggerBuffID, EBuffEffectTriggerType.None);
				}
			}
			{
				foreach (int preDaSheng_SustainTriggerBuffID in QiTianDaShengData.PreDaSheng_SustainTriggerBuffIDList)
				{
					if (BuffData.HasBuff(preDaSheng_SustainTriggerBuffID))
					{
						base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(preDaSheng_SustainTriggerBuffID, EBuffEffectTriggerType.None);
					}
				}
				break;
			}
		case EDaShengStage.DaShengMode:
			base.BUSEventCollection.Evt_ComboGraphTryTriggerChargeSkillTimeOut.Invoke();
			base.BUSEventCollection.Evt_ComboGraphReset.Invoke();
			foreach (int daSheng_BeginTriggerBuffID in QiTianDaShengData.DaSheng_BeginTriggerBuffIDList)
			{
				if (BuffData.HasBuff(daSheng_BeginTriggerBuffID))
				{
					base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(daSheng_BeginTriggerBuffID, EBuffEffectTriggerType.None);
				}
			}
			{
				foreach (int daSheng_SustainTriggerBuffID in QiTianDaShengData.DaSheng_SustainTriggerBuffIDList)
				{
					if (BuffData.HasBuff(daSheng_SustainTriggerBuffID))
					{
						base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(daSheng_SustainTriggerBuffID, EBuffEffectTriggerType.None);
					}
				}
				break;
			}
		}
	}

	private void TrySwitch2PreStage(EDaShengStage LastStage)
	{
		QiTianDaShengData.DaShengStage = EDaShengStage.PreStage;
		QiTianDaShengData.DaShengDurationTimer = -1f;
		QiTianDaShengData.DaShengDurationTotalTime = -1f;
		if (LastStage == EDaShengStage.LittleMonkey)
		{
			EnterPreDaSheng();
		}
	}

	private void TrySwitch2DaShengMode(EDaShengStage LastStage)
	{
		QiTianDaShengData.DaShengStage = EDaShengStage.DaShengMode;
		QiTianDaShengData.DaShengDurationTimer = -1f;
		QiTianDaShengData.DaShengDurationTotalTime = -1f;
		switch (LastStage)
		{
		case EDaShengStage.LittleMonkey:
			EnterDaShengMode(NeedRemovePreStageBuff: false);
			break;
		case EDaShengStage.PreStage:
			EnterDaShengMode(NeedRemovePreStageBuff: true);
			break;
		}
	}

	private void EnterPreDaSheng()
	{
		if (QiTianDaShengData.PreDaSheng_BeginTriggerEffectIDList != null && QiTianDaShengData.PreDaSheng_BeginTriggerEffectIDList.Count > 0)
		{
			FEffectInstReq fEffectInstReq = new FEffectInstReq(Owner);
			fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			fEffectInstReq.HitActionDir = EHitActionDir.Default;
			FEffectInstReq effectInstReq = fEffectInstReq;
			foreach (int preDaSheng_BeginTriggerEffectID in QiTianDaShengData.PreDaSheng_BeginTriggerEffectIDList)
			{
				base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(preDaSheng_BeginTriggerEffectID, effectInstReq);
			}
		}
		foreach (int preDaSheng_BeginTriggerBuffID in QiTianDaShengData.PreDaSheng_BeginTriggerBuffIDList)
		{
			BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(preDaSheng_BeginTriggerBuffID, PassiveSkillData);
			if (buffDescRuntime != null)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(preDaSheng_BeginTriggerBuffID, Owner, Owner, buffDescRuntime.GetDuration(), EBuffSourceType.Trans2DaSheng);
			}
		}
		foreach (int preDaSheng_SustainTriggerBuffID in QiTianDaShengData.PreDaSheng_SustainTriggerBuffIDList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(preDaSheng_SustainTriggerBuffID, Owner, Owner, -1f, EBuffSourceType.Trans2DaSheng);
		}
	}

	private void EnterDaShengMode(bool NeedRemovePreStageBuff)
	{
		base.BUSEventCollection.Evt_ComboGraphReset.Invoke();
		if (!IsInHGSLevel())
		{
			QiTianDaShengData.DaShengDurationTimer = 0f;
		}
		if (NeedRemovePreStageBuff)
		{
			foreach (int preDaSheng_BeginTriggerBuffID in QiTianDaShengData.PreDaSheng_BeginTriggerBuffIDList)
			{
				if (BuffData.HasBuff(preDaSheng_BeginTriggerBuffID))
				{
					base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(preDaSheng_BeginTriggerBuffID, EBuffEffectTriggerType.None);
				}
			}
			foreach (int preDaSheng_SustainTriggerBuffID in QiTianDaShengData.PreDaSheng_SustainTriggerBuffIDList)
			{
				if (BuffData.HasBuff(preDaSheng_SustainTriggerBuffID))
				{
					base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(preDaSheng_SustainTriggerBuffID, EBuffEffectTriggerType.None);
				}
			}
		}
		if (QiTianDaShengData.DaSheng_BeginTriggerEffectIDList != null && QiTianDaShengData.DaSheng_BeginTriggerEffectIDList.Count > 0)
		{
			FEffectInstReq fEffectInstReq = new FEffectInstReq(Owner);
			fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			fEffectInstReq.HitActionDir = EHitActionDir.Default;
			FEffectInstReq effectInstReq = fEffectInstReq;
			foreach (int daSheng_BeginTriggerEffectID in QiTianDaShengData.DaSheng_BeginTriggerEffectIDList)
			{
				base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(daSheng_BeginTriggerEffectID, effectInstReq);
			}
		}
		foreach (int daSheng_BeginTriggerBuffID in QiTianDaShengData.DaSheng_BeginTriggerBuffIDList)
		{
			BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(daSheng_BeginTriggerBuffID, PassiveSkillData);
			if (buffDescRuntime != null)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(daSheng_BeginTriggerBuffID, Owner, Owner, buffDescRuntime.GetDuration(), EBuffSourceType.Trans2DaSheng);
			}
		}
		foreach (int daSheng_SustainTriggerBuffID in QiTianDaShengData.DaSheng_SustainTriggerBuffIDList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(daSheng_SustainTriggerBuffID, Owner, Owner, -1f, EBuffSourceType.Trans2DaSheng);
		}
	}

	private void Reset2LittleMonkey()
	{
		TrySwitch2LittleMonkey(QiTianDaShengData.DaShengStage);
	}

	private void OnTriggerTrans2DaSheng()
	{
		if (QiTianDaShengData.DaShengStage == EDaShengStage.PreStage)
		{
			TrySwitch2DaShengMode(QiTianDaShengData.DaShengStage);
		}
	}

	private void OnTriggerBanTrans2DaSheng()
	{
		QiTianDaShengData.bIsBanTrans2DaSheng = true;
		QiTianDaShengData.DaShengDurationTimer = -1f;
		QiTianDaShengData.DaShengDurationTotalTime = -1f;
		Reset2LittleMonkey();
	}

	private void OnResetDaShengStatus()
	{
		QiTianDaShengData.bIsBanTrans2DaSheng = false;
		QiTianDaShengData.DaShengDurationTimer = -1f;
		QiTianDaShengData.DaShengDurationTotalTime = -1f;
		Reset2LittleMonkey();
	}

	private void OnAfterUnitRebirth(ERebirthType RebirthType)
	{
		QiTianDaShengData.bIsBanTrans2DaSheng = false;
		QiTianDaShengData.DaShengDurationTimer = -1f;
		QiTianDaShengData.DaShengDurationTotalTime = -1f;
		Reset2LittleMonkey();
	}
}
