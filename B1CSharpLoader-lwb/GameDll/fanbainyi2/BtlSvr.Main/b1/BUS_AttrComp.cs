using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class BUS_AttrComp : UActorCompBaseCS
{
	protected BUC_AttrContainer AttrContainer;

	private IBUC_GuidData GuidData;

	private IBIC_GlobalActorData GlobalActorData;

	private const float RATIO = 10000f;

	public override void OnAttach()
	{
		AttrContainer = RequireWritableData<BUC_AttrContainer>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		base.BUSEventCollection.Evt_IncreaseAttrFloat += new Del_IncreaseAttrFloat(OnIncreaseFloatValue);
		base.BUSEventCollection.Evt_FTB_IncreaseAttrFloat += new Del_IncreaseAttrFloat(OnIncreaseFloatValue);
		base.BUSEventCollection.Evt_SetAttrFloat += new Del_SetAttrFloat(SetFloatValue);
		base.BUSEventCollection.Evt_IncreaseFloatValueDelayTick += new Del_IncreaseFloatValueDelayTick(OnIncreaseFloatValueDelayTick);
		base.BUSEventCollection.Evt_InitAbnormalAttrs += new Del_InitAbnormalAttrs(InitAbnormalAttrs);
		base.BUSEventCollection.Evt_GMInitAttrByMaxAttr += new Del_Void(InitAttrByMaxAttr);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_GMLoadSnapshotAttr += new Del_GMLoadSnapshotAttr(LoadSnapshotAttr);
		base.BUSEventCollection.Evt_RequestCopyAttrFromSnapshot += new Del_CopyAttr(CopyAttrFromSnapshot);
	}

	public override void OnBeginPlay()
	{
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		if (!(aBGUCharacter == null))
		{
			APawn instigator = aBGUCharacter.Instigator;
			ABGPPlayerController aBGPPlayerController = ((instigator != null) ? (instigator.GetController() as ABGPPlayerController) : null);
			if (aBGPPlayerController != null)
			{
				BPS_EventCollectionCS.Get(aBGPPlayerController)?.Evt_PlayerActorSpawn.Invoke();
			}
		}
	}

	public override void LateBeginPlay()
	{
	}

	private void CopyAttrFromSnapshot(FAttrSnapShot AttrSnapshot)
	{
		if (AttrSnapshot != null)
		{
			FUStAttrCopyConfigDesc attrCopyConfigDesc = AttrSnapshot.AttrCopyConfigDesc;
			for (int i = 0; i < AttrSnapshot.FloatAttrs.Count; i++)
			{
				AttrContainer.FloatAttrs[i] = AttrSnapshot.FloatAttrs[i];
			}
			float num = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp) / AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax);
			AttrContainer.SetFloatValue(EBGUAttrFloat.HpMaxBase, AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax) * ((float)attrCopyConfigDesc.HPRatio / 10000f) + (float)attrCopyConfigDesc.HPBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.HpMaxMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.MpMaxBase, AttrContainer.GetFloatValue(EBGUAttrFloat.MpMax) * ((float)attrCopyConfigDesc.MPRatio / 10000f) + (float)attrCopyConfigDesc.MPBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.MpMaxMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.AtkBase, AttrContainer.GetFloatValue(EBGUAttrFloat.Atk) * ((float)attrCopyConfigDesc.AtkRatio / 10000f) + (float)attrCopyConfigDesc.AtkBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.AtkMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.DefBase, AttrContainer.GetFloatValue(EBGUAttrFloat.Def) * ((float)attrCopyConfigDesc.DefRatio / 10000f) + (float)attrCopyConfigDesc.DefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.DefMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.DmgAdditionBase, AttrContainer.GetFloatValue(EBGUAttrFloat.DmgAddition) * ((float)attrCopyConfigDesc.DmgAdditionRatio / 10000f) + (float)attrCopyConfigDesc.DmgAdditionBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.DmgDefBase, AttrContainer.GetFloatValue(EBGUAttrFloat.DmgDef) * ((float)attrCopyConfigDesc.DmgDefRatio / 10000f) + (float)attrCopyConfigDesc.DmgDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.CritRateBase, AttrContainer.GetFloatValue(EBGUAttrFloat.CritRate) * ((float)attrCopyConfigDesc.CritRateRatio / 10000f) + (float)attrCopyConfigDesc.CritRateBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.CritMultiplierBase, AttrContainer.GetFloatValue(EBGUAttrFloat.CritMultiplier) * ((float)attrCopyConfigDesc.CritMultiplierRatio / 10000f) + (float)attrCopyConfigDesc.CritMultiplierBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.FreezeDefBase, AttrContainer.GetFloatValue(EBGUAttrFloat.FreezeDef) * ((float)attrCopyConfigDesc.FreezeDefRatio / 10000f) + (float)attrCopyConfigDesc.FreezeDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.BurnDefBase, AttrContainer.GetFloatValue(EBGUAttrFloat.BurnDef) * ((float)attrCopyConfigDesc.BurnDefRatio / 10000f) + (float)attrCopyConfigDesc.BurnDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.PoisonDefBase, AttrContainer.GetFloatValue(EBGUAttrFloat.PoisonDef) * ((float)attrCopyConfigDesc.PoisonDefRatio / 10000f) + (float)attrCopyConfigDesc.PoisonDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.ThunderDefBase, AttrContainer.GetFloatValue(EBGUAttrFloat.ThunderDef) * ((float)attrCopyConfigDesc.ThunderDefRatio / 10000f) + (float)attrCopyConfigDesc.ThunderDefBase);
			InitAttrByMaxAttr();
			if (attrCopyConfigDesc.IsCopyHpCostRatio == EGSYesNo.Yes)
			{
				AttrContainer.SetFloatValue(EBGUAttrFloat.Hp, AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax) * num);
			}
		}
	}

	private void LoadSnapshotAttr(EffectAttrList EffectAttrList, CustomAttrList CustomAttrList)
	{
		InitAttrByMaxAttr();
		if (EffectAttrList == null)
		{
			return;
		}
		foreach (EffectAttrFloat attr in EffectAttrList.Attrs)
		{
			AttrContainer.SetFloatValue(attr.Type, attr.Value);
		}
	}

	private void InitAttrByMaxAttr()
	{
		if (GetOwner().HasAuthority())
		{
			AttrContainer.SetFloatValue(EBGUAttrFloat.Hp, AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax));
			AttrContainer.SetFloatValue(EBGUAttrFloat.Mp, AttrContainer.GetFloatValue(EBGUAttrFloat.MpMax));
			AttrContainer.SetFloatValue(EBGUAttrFloat.B1Stun, AttrContainer.GetFloatValue(EBGUAttrFloat.B1StunMax));
			AttrContainer.SetFloatValue(EBGUAttrFloat.SkillSuperArmor, AttrContainer.GetFloatValue(EBGUAttrFloat.SkillSuperArmorMax));
			AttrContainer.SetFloatValue(EBGUAttrFloat.BlockCollapseArmor, AttrContainer.GetFloatValue(EBGUAttrFloat.BlockCollapseArmorMax));
			AttrContainer.SetFloatValue(EBGUAttrFloat.Stamina, AttrContainer.GetFloatValue(EBGUAttrFloat.StaminaMax));
			AttrContainer.SetFloatValue(EBGUAttrFloat.BloodBottomNum, AttrContainer.GetFloatValMax(EBGUAttrFloat.BloodBottomNumMax));
		}
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		if (GlobalActorData.GetActorResetType(GuidData.GetFinalGuid(), out var ResetType) && ResetType != EBGUResetType.StatusWithoutHp)
		{
			InitAttrByMaxAttr();
		}
	}

	private void InitAbnormalAttrs(BGWDataAsset_AbnormalAttrConfig AbnormalAttrConfig)
	{
		if (!(AbnormalAttrConfig == null))
		{
			AttrContainer.SetFloatValue(EBGUAttrFloat.FreezeAbnormalAcc, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.FreezeAbnormalAccMaxBase, AbnormalAttrConfig.AbnomalAttrConfigInfo_Freeze.DefaultAccumulatedValue);
			AttrContainer.SetFloatValue(EBGUAttrFloat.FreezeAbnormalAccMaxMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.BurnAbnormalAcc, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.BurnAbnormalAccMaxBase, AbnormalAttrConfig.AbnomalAttrConfigInfo_Burn.DefaultAccumulatedValue);
			AttrContainer.SetFloatValue(EBGUAttrFloat.BurnAbnormalAccMaxMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.PoisonAbnormalAcc, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.PoisonAbnormalAccMaxBase, AbnormalAttrConfig.AbnomalAttrConfigInfo_Poison.DefaultAccumulatedValue);
			AttrContainer.SetFloatValue(EBGUAttrFloat.PoisonAbnormalAccMaxMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.ThunderAbnormalAcc, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.ThunderAbnormalAccMaxBase, AbnormalAttrConfig.AbnomalAttrConfigInfo_Thunder.DefaultAccumulatedValue);
			AttrContainer.SetFloatValue(EBGUAttrFloat.ThunderAbnormalAccMaxMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.YinAbnormalAcc, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.YinAbnormalAccMaxBase, AbnormalAttrConfig.AbnomalAttrConfigInfo_Yin.DefaultAccumulatedValue);
			AttrContainer.SetFloatValue(EBGUAttrFloat.YinAbnormalAccMaxMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.YangAbnormalAcc, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.YangAbnormalAccMaxBase, AbnormalAttrConfig.AbnomalAttrConfigInfo_Yang.DefaultAccumulatedValue);
			AttrContainer.SetFloatValue(EBGUAttrFloat.YangAbnormalAccMaxMul, 0f);
		}
	}

	private void SetFloatValue(EBGUAttrFloat AttrID, float NewValue)
	{
		if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(GetOwner()))
		{
			float floatValue = AttrContainer.GetFloatValue(AttrID);
			AttrContainer.SetFloatValue(AttrID, NewValue);
		}
	}

	private void OnIncreaseFloatValueDelayTick(EBGUAttrFloat AttrID, float NewValue, int DelayTick)
	{
		if (GSEUtil.Ensure(DelayTick >= 0))
		{
			AttrContainer.SetFloatValueDelayTick(AttrID, NewValue, DelayTick);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		AttrContainer.OnTick();
	}

	private void OnIncreaseFloatValue(EBGUAttrFloat AttrID, float IncreaseValue)
	{
		float newValue = AttrContainer.GetFloatValue(AttrID) + IncreaseValue;
		SetFloatValue(AttrID, newValue);
	}

	private float GetFloatValue(EBGUAttrFloat AttrID)
	{
		return AttrContainer.GetFloatValue(AttrID);
	}
}
