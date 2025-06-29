using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_SkillMappingData
{
	int GetCurResultSkillID(int MainSkillID);

	string GetCurResultMontagePath(int MainSkillID);

	FName GetCurResultSectionName(int MainSkillID, FName MontageStartSectionName);
}
