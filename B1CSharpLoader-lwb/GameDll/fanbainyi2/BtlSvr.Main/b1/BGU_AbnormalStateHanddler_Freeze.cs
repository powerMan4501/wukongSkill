using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_AbnormalStateHanddler_Freeze : BGU_AbnormalStateHandlerBase
{
	private UCurveFloat AccMatPamarmCurve;

	public override void HandlerInit(BGUCharacterCS _OwnerChr)
	{
		AbnormalType = EAbnormalStateType.Abnormal_Freeze;
		AbnormalImmueSS = EBGUSimpleState.FreezeImmue;
		DisableAutoRecoverSS = EBGUSimpleState.DisableAutoRecoverFreeze;
		AttrFloatMap = new Dictionary<EAbnormalAttrFloatMap, EBGUAttrFloat>();
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAcc, EBGUAttrFloat.FreezeAbnormalAcc);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMax, EBGUAttrFloat.FreezeAbnormalAccMax);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxBase, EBGUAttrFloat.FreezeAbnormalAccMaxBase);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalAccMaxMul, EBGUAttrFloat.FreezeAbnormalAccMaxMul);
		AttrFloatMap.Add(EAbnormalAttrFloatMap.AbnormalDef, EBGUAttrFloat.FreezeDef);
		ProgressBuffID = AbnormalStateGlobleParam.AccProcessBuffID_Frozen;
		AccTriggerProcessAbnormalPercent = AbnormalStateGlobleParam.AccTriggerProcessAbnormalPercent_Frozen;
	}

	protected override void OnFinalEffectRemainTimeAutoOut()
	{
		base.OnFinalEffectRemainTimeAutoOut();
		PlayAutoReleaseFX();
	}

	protected override void EnterFinalState()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_TriggerFrozen.Invoke();
		}
	}

	private void PlayDBC_ByType_FreezeExt(BGW_GameDB.EAbnromalDispActionType_FreezeExt ActionType, FTransform DBCTransform = default(FTransform))
	{
		int lastAttackerAbormalStateDispID = LastAttackerAbormalStateDispID;
		int finalAbnormalDispID_AsVictim = OwnerChr.GetFinalAbnormalDispID_AsVictim();
		string text = "";
		string text2 = "";
		string text3 = "";
		int attackerABID = ((finalAbnormalDispID_AsVictim == 10) ? 1 : 0);
		if (BGW_GameDB.GetAbnormalDispModifyInfo_FreezeExt_Attacker(ActionType, attackerABID, out var _, out var DBCPath))
		{
			text = DBCPath;
		}
		if (lastAttackerAbormalStateDispID != 0 && BGW_GameDB.GetAbnormalDispModifyInfo_FreezeExt_Attacker(ActionType, lastAttackerAbormalStateDispID, out var ModifyType2, out var DBCPath2))
		{
			switch (ModifyType2)
			{
			case EAbnormalDispModifyType.Modify:
				text2 = DBCPath2;
				break;
			case EAbnormalDispModifyType.Override:
				text = DBCPath2;
				break;
			}
		}
		if (BGW_GameDB.GetAbnormalDispModifyInfo_FreezeExt_Victim(ActionType, finalAbnormalDispID_AsVictim, out var ModifyType3, out var DBCPath3) && ModifyType3 == EAbnormalDispModifyType.Modify)
		{
			text3 = DBCPath3;
		}
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		BE_Owner.Evt_RequestSpawnFXByDispConfig.Invoke(text, out var RequestID, null, NeedSetSpawnTransform: true, DBCTransform);
		if (RequestID >= 0)
		{
			if (!string.IsNullOrEmpty(text2))
			{
				BE_Owner.Evt_RequestSpawnFXByDispConfig.Invoke(text2, out var _, null, NeedSetSpawnTransform: true, DBCTransform);
			}
			if (!string.IsNullOrEmpty(text3))
			{
				BE_Owner.Evt_RequestSpawnFXByDispConfig.Invoke(text3, out var _, null, NeedSetSpawnTransform: true, DBCTransform);
			}
		}
	}

	public void PlayBrokenFX()
	{
		PlayDBC_ByType_FreezeExt(BGW_GameDB.EAbnromalDispActionType_FreezeExt.Broken);
	}

	public void PlayAutoReleaseFX()
	{
		PlayDBC_ByType_FreezeExt(BGW_GameDB.EAbnromalDispActionType_FreezeExt.AutoRelease);
	}

	public void PlayShakeFX()
	{
		PlayDBC_ByType_FreezeExt(BGW_GameDB.EAbnromalDispActionType_FreezeExt.ShakeFreeze);
	}

	protected override void ProgressDispLogic(float Progress)
	{
		base.ProgressDispLogic(Progress);
		if (NeedShowUI())
		{
			if (AccMatPamarmCurve == null)
			{
				AccMatPamarmCurve = BGW_PreloadAssetMgr.Get(OwnerChr).FrozenAccMatCurve;
			}
			if (!(AccMatPamarmCurve == null))
			{
				float floatValue = AccMatPamarmCurve.GetFloatValue(Progress);
				DispLibEventCollection.Evt_RequestSetMatScalarParam(out var _, BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.FixDuration, 0.01f, B1GlobalFNames.IceAmount, floatValue);
			}
		}
	}

	protected override void OnAbnormalEnded()
	{
		base.OnAbnormalEnded();
		ParentComp.OnFrozenEnded();
	}
}
