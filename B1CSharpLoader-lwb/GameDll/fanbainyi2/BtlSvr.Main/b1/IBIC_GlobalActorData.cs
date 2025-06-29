using System.Collections.Generic;
using ArchiveB1;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public interface IBIC_GlobalActorData
{
	List<string> GetActorDataKeys();

	GSInitDataModuleBase GetActorInitData(string UnitGuid, EInitDataModuleType Type);

	bool GetActorOverrideResetType(string UnitGuid, out EBGUResetType ResetType);

	bool GetGroupOverrideResetType(string GroupGuid, out EBGUResetType ResetType);

	bool GetActorResetType(string UnitGuid, out EBGUResetType ResetType);

	bool GetActorEntity(string UnitGuid, out Entity Entity);

	bool GetActorsByResID(int UnitResID, out List<AActor> OutActors);

	bool IsActorInitDataInitialized(string UnitGuid);

	List<DeadUnitData> GetDeadUnitsDataToArchive();

	bool HasActorAliveState(string UnitGuid);

	bool GetActorAliveState(string UnitGuid);

	bool GetActorSetByWorldPackageName(string WorldPackageName, out HashSet<string> ActorSet);

	HashSet<string> GetResetAllActorList();

	int GetActorCastSkillCount(string UnitGuid, int SkillID);

	int GetAllInteractorSet(out HashSet<string> OutInteractorSet);
}
