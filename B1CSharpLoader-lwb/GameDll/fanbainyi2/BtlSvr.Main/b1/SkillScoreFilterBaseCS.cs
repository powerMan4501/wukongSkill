using UnrealEngine.Engine;

namespace b1;

public class SkillScoreFilterBaseCS
{
	public virtual bool CalculateScore(AActor BGUActor, int SkillID, bool UsePursuitAnyWhere, out float Score)
	{
		Score = 0f;
		return true;
	}
}
