using CommB1;

namespace b1;

public class FOneCBGCastSkillInfoCS
{
	public int SkillID;

	public string MontageStartSectionName;

	public bool DontCheckSkillCanCast;

	public bool CanCastWhenDead;

	public float Score;

	public FOneCBGCastSkillInfoCS(OneCBGCastSkillInfo SkillInfo)
	{
		SkillID = SkillInfo.SkillId;
		MontageStartSectionName = SkillInfo.MontageStartSectionName;
		DontCheckSkillCanCast = SkillInfo.DontCheckSkillCanCast;
		CanCastWhenDead = SkillInfo.CanCastWhenDead;
		Score = 0f;
	}
}
