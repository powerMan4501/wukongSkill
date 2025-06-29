using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUEffectSwitchCLSEnvironment : BUEffectTemplate
{
	public BUEffectSwitchCLSEnvironment()
	{
		EffectType = EBuffAndSkillEffectType.SwitchEnvironment;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		BGUCharacterCS bGUCharacterCS = Target as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null)
		{
			return;
		}
		b1.BUC_EnvironmentData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.BUC_EnvironmentData>(Target);
		if (readOnlyData == null)
		{
			return;
		}
		b1.BGUEnvironmentControllerBase envMgrActor = readOnlyData.EnvMgrActor;
		if (envMgrActor.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(envMgrActor);
		if (!(bUS_GSEventCollection == null))
		{
			if (skillEffectDesc.EffectParamsInt.Count > 0 && skillEffectDesc.EffectParamsInt[0] == -1)
			{
				bUS_GSEventCollection.Evt_ReleaseEnvironment.Invoke(bGUCharacterCS, bNeedRollBack: true);
			}
			else if (skillEffectDesc.EffectParamsStr.Count >= 1 && skillEffectDesc.EffectParamsFloat.Count >= 1)
			{
				string levelSequencePath = skillEffectDesc.EffectParamsStr[0];
				float addtiveTargetPercentage = skillEffectDesc.EffectParamsFloat[0];
				bUS_GSEventCollection.Evt_OnSwitchEnvironment.Invoke(bGUCharacterCS, levelSequencePath, addtiveTargetPercentage);
			}
		}
	}
}
