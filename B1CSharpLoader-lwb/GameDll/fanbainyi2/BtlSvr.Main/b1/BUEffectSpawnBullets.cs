using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "简单生成子弹" })]
[AffectTarget]
public class BUEffectSpawnBullets : BUEffectTemplate
{
	public BUEffectSpawnBullets()
	{
		EffectType = EBuffAndSkillEffectType.BulletsSimpleSpawn;
	}

	[ParamInfoI(4, "监控BuffID（当子弹创建类型为ScopeMonitor时有效）")]
	[ParamInfoF(2, "直线速度（当子弹创建类型为CircleAround时有效）")]
	[ParamInfoF(1, "高度（当子弹创建类型为CircleAround时有效）")]
	[ParamInfoF(0, "半径（当子弹创建类型为CircleAround时有效）")]
	[ParamInfoI(3, "不为0时适用socket（当子弹创建类型为ScopeMonitor时有效）")]
	[ParamInfoI(2, "子弹数量")]
	[ParamInfoI(1, "子弹ID")]
	[ParamInfoI(0, "子弹创建类型，为CircleAround或ScopeMonitor")]
	[TemplateFunNote("添加Buff时简单生成子弹")]
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
		BulletSimpleCreateType intEffectParam = (BulletSimpleCreateType)buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		FSimpleCreatorInfo creatorInfo = new FSimpleCreatorInfo
		{
			BulletID = buffDescRuntime.GetIntEffectParam(EffectIdx, 1),
			BulletNum = buffDescRuntime.GetIntEffectParam(EffectIdx, 2)
		};
		if (intEffectParam == BulletSimpleCreateType.CircleAround)
		{
			creatorInfo.CircleRadius = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
			creatorInfo.CircleHeight = buffDescRuntime.GetFloatEffectParam(EffectIdx, 1);
			creatorInfo.CircleLineSpd = buffDescRuntime.GetFloatEffectParam(EffectIdx, 2);
		}
		if (intEffectParam == BulletSimpleCreateType.ScopeMonitor)
		{
			if (buffDescRuntime.GetIntEffectParam(EffectIdx, 3) != 0)
			{
				creatorInfo.UseSocket = true;
			}
			creatorInfo.SocketName = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			creatorInfo.MonitorBuffID = buffDescRuntime.GetIntEffectParam(EffectIdx, 4);
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_BulletsSimpleCreator.Invoke(intEffectParam, creatorInfo);
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		b1.EffectTemplateUtil.ReturnIfUnitDead(Target);
	}
}
