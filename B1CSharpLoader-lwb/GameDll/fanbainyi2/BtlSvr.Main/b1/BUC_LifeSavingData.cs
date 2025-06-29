using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_LifeSavingData : b1.IBUC_LifeSavingData, IPersistentECSData
{
	public List<int> BuffIDList_DurLifeSaving { get; set; }

	public bool bEnable { get; set; }

	public int SpellID { get; set; }

	public float CoolDownRemainTimer { get; set; }

	public float DefaultCD { get; set; }

	public bool bAlreadyCast { get; set; }

	public bool bRebirthPrepare { get; set; }

	public float RebirthRemainTimer { get; set; }

	public bool bActive_ExtLifeSaving { get; set; }

	public bool CanUseLifeSavingHair(IBUC_UnitStateData UnitStateData, IBUC_SimpleStateData SimpleStateData)
	{
		if (UnitStateData == null || SimpleStateData == null)
		{
			return false;
		}
		if (UnitStateData.HasState(EBGUUnitState.LifeSavingHairBlocking))
		{
			return false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.ForbidAllLifeSavingHair))
		{
			return false;
		}
		if (bActive_ExtLifeSaving)
		{
			return true;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.ForbidAllLifeSavingHairExceptJZHHD))
		{
			return false;
		}
		if (!bEnable)
		{
			return false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CancelLifeSavingCD))
		{
			return true;
		}
		return CoolDownRemainTimer <= 0f;
	}

	public float GetCDTimePercent()
	{
		if (DefaultCD <= 0f)
		{
			return 0f;
		}
		return FMath.Clamp(CoolDownRemainTimer / DefaultCD, 0f, 1f);
	}

	public BUC_LifeSavingData()
	{
		BuffIDList_DurLifeSaving = new List<int>();
		bEnable = false;
		SpellID = -1;
		CoolDownRemainTimer = -1f;
	}
}
