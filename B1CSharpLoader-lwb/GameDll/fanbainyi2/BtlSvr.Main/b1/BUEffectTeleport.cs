using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectTeleport : BUEffectTemplate
{
	public BUEffectTeleport()
	{
		EffectType = EBuffAndSkillEffectType.Teleport;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		bool flag = false;
		bool isKeepFacingCurTarget = false;
		bool bFindFloor = false;
		int selectType = -1;
		string actorSocketName = "";
		float minDistInRandom = 0f;
		if (skillEffectDesc.EffectParamsInt.Count >= 2)
		{
			flag = ((skillEffectDesc.EffectParamsInt[0] != 0) ? true : false);
			if (skillEffectDesc.EffectParamsInt.Count > 2 && skillEffectDesc.EffectParamsInt[2] == 1)
			{
				isKeepFacingCurTarget = true;
			}
			if (skillEffectDesc.EffectParamsInt.Count > 3)
			{
				selectType = skillEffectDesc.EffectParamsInt[3];
			}
			int teleportIntParam = ((skillEffectDesc.EffectParamsInt.Count > 4) ? skillEffectDesc.EffectParamsInt[4] : 0);
			if (skillEffectDesc.EffectParamsInt.Count > 5 && skillEffectDesc.EffectParamsInt[5] == 1)
			{
				bFindFloor = true;
			}
			if (skillEffectDesc.EffectParamsStr.Count > 1)
			{
				actorSocketName = skillEffectDesc.EffectParamsStr[1];
			}
			if (skillEffectDesc.EffectParamsFloat.Count > 0)
			{
				minDistInRandom = skillEffectDesc.EffectParamsFloat[0];
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnTeleport.Invoke(Target, skillEffectDesc.EffectParamsInt[1], teleportIntParam, skillEffectDesc.EffectParamsStr[0], actorSocketName, flag, minDistInRandom, isKeepFacingCurTarget, selectType, bFindFloor);
			}
		}
	}

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
		bool flag = false;
		bool isKeepFacingCurTarget = false;
		bool bFindFloor = false;
		int selectType = -1;
		string actorSocketName = "";
		float minDistInRandom = 0f;
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		if (intEffectParamCount >= 2)
		{
			flag = ((buffDescRuntime.GetIntEffectParam(EffectIdx, 0) != 0) ? true : false);
			if (intEffectParamCount > 2 && buffDescRuntime.GetIntEffectParam(EffectIdx, 2) == 1)
			{
				isKeepFacingCurTarget = true;
			}
			if (intEffectParamCount > 3)
			{
				selectType = buffDescRuntime.GetIntEffectParam(EffectIdx, 3);
			}
			int teleportIntParam = ((intEffectParamCount > 4) ? buffDescRuntime.GetIntEffectParam(EffectIdx, 4) : 0);
			if (intEffectParamCount > 5 && buffDescRuntime.GetIntEffectParam(EffectIdx, 5) == 1)
			{
				bFindFloor = true;
			}
			if (buffDescRuntime.GetStringEffectParamCount(EffectIdx) > 1)
			{
				actorSocketName = buffDescRuntime.GetStringEffectParam(EffectIdx, 1);
			}
			if (buffDescRuntime.GetFloatEffectParamCount(EffectIdx) > 0)
			{
				minDistInRandom = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnTeleport.Invoke(Target, buffDescRuntime.GetIntEffectParam(EffectIdx, 1), teleportIntParam, buffDescRuntime.GetStringEffectParam(EffectIdx, 0), actorSocketName, flag, minDistInRandom, isKeepFacingCurTarget, selectType, bFindFloor);
			}
		}
	}
}
