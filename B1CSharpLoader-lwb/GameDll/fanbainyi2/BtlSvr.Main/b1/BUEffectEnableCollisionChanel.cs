using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "用于开关角色或子弹的碰撞", "可以指定要开启或关闭的碰撞通道ID" })]
[CanUseByBulletEffect]
[AffectTarget]
public class BUEffectEnableCollisionChanel : BUEffectTemplate
{
	public BUEffectEnableCollisionChanel()
	{
		EffectType = EBuffAndSkillEffectType.EnableCollisionChanel;
	}

	[ParamInfoF(0, "0：Capsule，1：Mesh")]
	[ParamInfoI(4, "碰撞通道ID")]
	[ParamInfoI(5, "碰撞通道ID")]
	[ParamInfoI(2, "碰撞通道ID")]
	[ParamInfoI(1, "开关（0：关闭，1：打开）")]
	[ParamInfoI(0, "作用对象（0：子弹，1：角色）")]
	[TemplateFunNote("添加Buff时开关碰撞")]
	[ParamInfoI(3, "碰撞通道ID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		List<int> list = new List<int>();
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		for (int i = 2; i < intEffectParamCount; i++)
		{
			list.Add(buffDescRuntime.GetIntEffectParam(EffectIdx, i));
		}
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		bool flag = buffDescRuntime.GetIntEffectParam(EffectIdx, 1) == 1;
		switch (intEffectParam)
		{
		case 0:
			bUS_GSEventCollection.Evt_EnableBulletCollision.Invoke(flag, list);
			break;
		case 1:
		{
			EPropType ePropType = EPropType.Capsule_CollisionResponseToChannels;
			if (buffDescRuntime.GetFloatEffectParamCount(EffectIdx) > 0 && buffDescRuntime.GetFloatEffectParam(EffectIdx, 0) == 1f)
			{
				ePropType = EPropType.Mesh_CollisionResponseToChannels;
			}
			if (BuffInst.PropMgrHandleID.ContainsKey(ePropType))
			{
				break;
			}
			IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(Target);
			if (readOnlyData == null)
			{
				break;
			}
			Dictionary<ECollisionChannel, ECollisionResponseType> dictionary = new Dictionary<ECollisionChannel, ECollisionResponseType>();
			foreach (int item in list)
			{
				dictionary.Add((ECollisionChannel)item, flag ? ECollisionResponseType.ECR_Block : ECollisionResponseType.ECR_Ignore);
			}
			bUS_GSEventCollection.Evt_SetCollisionResponseProperty.Invoke(ePropType, dictionary);
			BuffInst.AddPropMgrHandleID(ePropType, readOnlyData.GetLastHandleID());
			break;
		}
		}
	}

	[TemplateFunNote("移除Buff时恢复碰撞")]
	[ParamInfoI(0, "作用对象（0：子弹，1：角色）")]
	[ParamInfoI(1, "开关（0：关闭，1：打开）")]
	[ParamInfoI(2, "碰撞通道ID")]
	[ParamInfoI(3, "碰撞通道ID")]
	[ParamInfoF(0, "0：Capsule，1：Mesh")]
	[ParamInfoI(5, "碰撞通道ID")]
	[ParamInfoI(4, "碰撞通道ID")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		List<int> list = new List<int>();
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		for (int i = 1; i < intEffectParamCount; i++)
		{
			list.Add(buffDescRuntime.GetIntEffectParam(EffectIdx, i));
		}
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		bool flag = buffDescRuntime.GetIntEffectParam(EffectIdx, 1) == 1;
		switch (intEffectParam)
		{
		case 0:
			bUS_GSEventCollection.Evt_EnableBulletCollision.Invoke(!flag, list);
			break;
		case 1:
		{
			EPropType ePropType = EPropType.Capsule_CollisionResponseToChannels;
			if (buffDescRuntime.GetFloatEffectParamCount(EffectIdx) > 0 && buffDescRuntime.GetFloatEffectParam(EffectIdx, 0) == 1f)
			{
				ePropType = EPropType.Mesh_CollisionResponseToChannels;
			}
			if (BuffInst.PropMgrHandleID.TryGetValue(ePropType, out var OutValue))
			{
				bUS_GSEventCollection.Evt_ResetProperty.Invoke(OutValue);
				BuffInst.RemovePropMgrHandleID(ePropType);
			}
			break;
		}
		}
	}
}
