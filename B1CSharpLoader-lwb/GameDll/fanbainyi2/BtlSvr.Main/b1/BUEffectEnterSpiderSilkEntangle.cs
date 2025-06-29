using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "进入蛛丝缠绕状态" })]
public class BUEffectEnterSpiderSilkEntangle : BUEffectTemplate
{
	public BUEffectEnterSpiderSilkEntangle()
	{
		EffectType = EBuffAndSkillEffectType.EnterSpiderSilkEntangle;
	}

	[TemplateFunNote("进入蛛丝缠绕状态")]
	[ParamInfoS(0, "DAPath")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
		BGWDataAsset_SpiderSilkEntangleConfig bGWDataAsset_SpiderSilkEntangleConfig = new BGWDataAsset_SpiderSilkEntangleConfig();
		bGWDataAsset_SpiderSilkEntangleConfig = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_SpiderSilkEntangleConfig>(stringEffectParam, ELoadResourceType.SyncLoadAndCache);
		if (!(bGWDataAsset_SpiderSilkEntangleConfig == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnSpiderSilkEntangleStateEnter.Invoke(bGWDataAsset_SpiderSilkEntangleConfig);
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnSpiderSilkEntangleStateExit.Invoke();
		}
	}
}
