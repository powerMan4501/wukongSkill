namespace b1;

public class GSTurnSkillConfig
{
	private int[] PatrolTurnSkillIDs = new int[4];

	private int TurnDegreeThresholdLow;

	private int TurnDegreeThresholdHigh;

	public bool bDisableImmediatePathfinding;

	public GSTurnSkillConfig(in FGSTurnSkillConfig InConfig)
	{
		SetTurnSkillID(TurnSkillType.LeftSmall, InConfig.LeftSmallTurnSkillID);
		SetTurnSkillID(TurnSkillType.RightSmall, InConfig.RightSmallTurnSkillID);
		SetTurnSkillID(TurnSkillType.LeftBig, InConfig.LeftBigTurnSkillID);
		SetTurnSkillID(TurnSkillType.RightBig, InConfig.RightBigTurnSkillID);
		TurnDegreeThresholdLow = InConfig.TurnDegreeThresholdLow;
		TurnDegreeThresholdHigh = InConfig.TurnDegreeThresholdHigh;
		bDisableImmediatePathfinding = InConfig.bDisableImmediatePathfinding;
	}

	public GSTurnSkillConfig()
	{
	}

	private void SetTurnSkillID(TurnSkillType Type, int NewTurnSkillID)
	{
		PatrolTurnSkillIDs[(uint)Type] = NewTurnSkillID;
	}

	private int GetTurnSkillID(TurnSkillType Type)
	{
		return PatrolTurnSkillIDs[(uint)Type];
	}

	public int GetTurnSkillIDByDegree(float Angle)
	{
		if (Angle > (float)TurnDegreeThresholdLow)
		{
			if (Angle < (float)TurnDegreeThresholdHigh)
			{
				return GetTurnSkillID(TurnSkillType.RightSmall);
			}
			return GetTurnSkillID(TurnSkillType.RightBig);
		}
		if (Angle < (float)(-TurnDegreeThresholdLow))
		{
			if (Angle > (float)(-TurnDegreeThresholdHigh))
			{
				return GetTurnSkillID(TurnSkillType.LeftSmall);
			}
			return GetTurnSkillID(TurnSkillType.LeftBig);
		}
		return 0;
	}
}
