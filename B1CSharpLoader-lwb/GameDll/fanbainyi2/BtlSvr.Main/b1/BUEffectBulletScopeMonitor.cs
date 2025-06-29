using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "子弹范围控制器" })]
[CanUseByBulletEffect]
public class BUEffectBulletScopeMonitor : BUEffectTemplate
{
	public BUEffectBulletScopeMonitor()
	{
		EffectType = EBuffAndSkillEffectType.BulletScopeMonitor;
	}

	[ParamInfoI(0, "SkillEffectID")]
	[TemplateFunNote("添加Buff时开启子弹范围控制器")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Target as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(EntitySharedRefFuncLib.Actor(BuffInst.CasterRef));
		if (readOnlyData == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS2 = readOnlyData.GetMasterActor() as BGUCharacterCS;
		if (!(bGUCharacterCS2 == null) && !b1.EffectTemplateUtil.ReturnIfUnitDead(bGUCharacterCS2))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS2);
			if (bUS_GSEventCollection != null)
			{
				BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
				bUS_GSEventCollection.Evt_AddToPassiveQuene.Invoke(buffDescRuntime.GetIntEffectParam(EffectIdx, 0), bGUCharacterCS);
			}
		}
	}
}
