using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "用于隐身效果，包括Actor，主Mesh，武器，ModularActors（石先锋这种组装怪）" })]
[AffectTarget]
public class BUEffectInvisible : BUEffectTemplate
{
	public BUEffectInvisible()
	{
		EffectType = EBuffAndSkillEffectType.TriggerHidden;
	}

	[TemplateFunNote("添加Buff时隐藏")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(Target);
		if (readOnlyData != null)
		{
			if (!BuffInst.PropMgrHandleID.ContainsKey(EPropType.Actor_ActorHiddenInGame))
			{
				bUS_GSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Actor_ActorHiddenInGame, Value: true);
				BuffInst.AddPropMgrHandleID(EPropType.Actor_ActorHiddenInGame, readOnlyData.GetLastHandleID());
			}
			if (!BuffInst.PropMgrHandleID.ContainsKey(EPropType.Mesh_Visibility))
			{
				bUS_GSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_Visibility, Value: false);
				BuffInst.AddPropMgrHandleID(EPropType.Mesh_Visibility, readOnlyData.GetLastHandleID());
			}
			bUS_GSEventCollection.Evt_ToggleWeaponsStatus_ByEffect.Invoke(new List<int> { -1 }, TriggerActivate: false, NeedOverride: true, BuffInst.BuffID, EffectIdx, Reset2Default: false);
			bUS_GSEventCollection.Evt_TryHideModularActors.Invoke(IsSelfRescue: true);
		}
	}

	[TemplateFunNote("移除Buff时显示")]
	[ParamInfoI(0, "武器是否恢复默认显隐配置，1：恢复默认配置显隐；0：全部显示")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (BuffInst.PropMgrHandleID.TryGetValue(EPropType.Actor_ActorHiddenInGame, out var OutValue))
		{
			bUS_GSEventCollection.Evt_ResetProperty.Invoke(OutValue);
			BuffInst.RemovePropMgrHandleID(EPropType.Actor_ActorHiddenInGame);
		}
		if (BuffInst.PropMgrHandleID.TryGetValue(EPropType.Mesh_Visibility, out OutValue))
		{
			bUS_GSEventCollection.Evt_ResetProperty.Invoke(OutValue);
			BuffInst.RemovePropMgrHandleID(EPropType.Mesh_Visibility);
		}
		bool reset2Default = false;
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 1)
		{
			reset2Default = buffDescRuntime.GetIntEffectParam(EffectIdx, 0) == 1;
		}
		bUS_GSEventCollection.Evt_ToggleWeaponsStatus_ByEffect.Invoke(new List<int> { -1 }, TriggerActivate: true, NeedOverride: false, BuffInst.BuffID, EffectIdx, reset2Default);
		bUS_GSEventCollection.Evt_TryHideModularActors.Invoke(IsSelfRescue: false);
	}
}
