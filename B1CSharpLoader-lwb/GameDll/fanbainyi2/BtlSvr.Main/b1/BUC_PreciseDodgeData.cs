using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_PreciseDodgeData : IBUC_PreciseDodgeData
{
	public bool CanPreciseDodge { get; set; }

	public int DefaultAwardsLevel { get; set; }

	public int CurrentAwardsLevel { get; set; }

	public List<PreciseDodgeAwardsForData> Awards { get; } = new List<PreciseDodgeAwardsForData>();

	public bool bEnableDebugInConfig { get; set; }

	public bool bShowDebugDraw
	{
		get
		{
			if (!bEnableDebugInConfig)
			{
				return GSGameplayCVar.CVar_ShowPreciseDodgeDebugDraw.GetValueInGameThread() != 0;
			}
			return true;
		}
	}

	public bool bShowDebugText
	{
		get
		{
			if (!bEnableDebugInConfig)
			{
				return GSGameplayCVar.CVar_ShowPreciseDodgeDebugText.GetValueInGameThread() != 0;
			}
			return true;
		}
	}

	public int CurrentAwardCount { get; set; }

	public ESkillDirection PreciseDodgeDirection { get; set; }

	public float PreciseDodgeTolerantTimeSeconds { get; set; }

	public float CurrentPreciseDodgeTimeSeconds { get; set; }

	public int PreciseDodgeStartSkillId { get; set; }

	public int CurStateIndex { get; set; }

	public List<int> PreciseDodgeCombo { get; } = new List<int>();

	public FAnimNotifyTriggerList AnimTriggerList { get; } = new FAnimNotifyTriggerList();

	public Dictionary<string, FVector> DefaultScale_PreciseDodgeCollision { get; set; }

	public PreciseDodgeAwardsForData GetCurrentLevelAwards()
	{
		if (CurrentAwardsLevel > Awards.Count)
		{
			return null;
		}
		return Awards[CurrentAwardsLevel - 1];
	}

	public bool InPreciseDodgeWindow()
	{
		if (!(CurrentPreciseDodgeTimeSeconds > 1E-08f))
		{
			return GSGameplayCVar.CVar_PreciseDodgeAlwaysSuccess.GetValueInGameThread() == 1;
		}
		return true;
	}

	public BUC_PreciseDodgeData()
	{
		DefaultScale_PreciseDodgeCollision = new Dictionary<string, FVector>();
	}
}
