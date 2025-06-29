using System.Collections.Generic;
using ArchiveB1;
using UnrealEngine.Runtime;

namespace b1;

public interface IBIC_LevelData
{
	bool bOpeningLevel { get; }

	int CurrentLevelID { get; }

	FName CurrentLevelName { get; set; }

	int LevelIDInArchive { get; }

	FDetailLevelInfo DetailLevelInfo { get; }

	Dictionary<ELevelTag, List<int>> LevelTagToLevelIdMap { get; }

	bool IsValidLevel();

	int GetLevelIDInArchive();

	LevelArchiveBaseData GetCurrentLevelBaseArchiveData();

	LevelArchiveDetailData GetCurrentLevelDetailArchiveData();

	bool GetAllLevelArchiveData(out List<LevelArchiveBaseData> BaseDataCollection, out List<LevelArchiveDetailData> DetailDataCollection);
}
