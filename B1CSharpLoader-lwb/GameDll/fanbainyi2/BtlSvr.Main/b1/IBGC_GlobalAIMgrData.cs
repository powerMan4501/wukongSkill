namespace b1;

public interface IBGC_GlobalAIMgrData
{
	bool CheckSkillIsInGroup(int UnitResID, string UnitGuid, int SkillID, out float GroupLastCastTime);
}
