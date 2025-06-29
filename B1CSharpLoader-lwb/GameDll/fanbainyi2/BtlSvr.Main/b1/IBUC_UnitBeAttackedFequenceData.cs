namespace b1;

internal interface IBUC_UnitBeAttackedFequenceData
{
	bool CheckBeAttackedFequenceData(string SkillTaskUniqueID);

	bool CheckBeAttackedGroupInfo(int GroupID, int FromInstanceID);
}
