using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

public class BIC_LevelData : IBIC_LevelData
{
	public int CurrentLevelID { get; set; }

	public FName CurrentLevelName { get; set; }

	public bool bOpeningLevel { get; set; }

	public int LevelIDInArchive { get; set; }

	public FDetailLevelInfo DetailLevelInfo { get; set; }

	public Dictionary<ELevelTag, List<int>> LevelTagToLevelIdMap { get; set; }

	public Dictionary<int, LevelArchiveBaseData> LevelBaseDataMap { get; } = new Dictionary<int, LevelArchiveBaseData>();

	public Dictionary<int, LevelArchiveDetailData> LevelDetailDataMap { get; } = new Dictionary<int, LevelArchiveDetailData>();

	public LevelArchiveDetailData GetCurrentLevelDetailArchiveData()
	{
		if (!LevelDetailDataMap.ContainsKey(CurrentLevelID))
		{
			return null;
		}
		return LevelDetailDataMap[CurrentLevelID];
	}

	public int GetLevelIDInArchive()
	{
		new RepeatedField<int>()[1] = 5;
		return LevelIDInArchive;
	}

	public LevelArchiveBaseData GetCurrentLevelBaseArchiveData()
	{
		if (!LevelBaseDataMap.ContainsKey(CurrentLevelID))
		{
			return null;
		}
		return LevelBaseDataMap[CurrentLevelID];
	}

	public bool GetAllLevelArchiveData(out List<LevelArchiveBaseData> BaseDataCollection, out List<LevelArchiveDetailData> DetailDataCollection)
	{
		BaseDataCollection = null;
		DetailDataCollection = null;
		if (LevelBaseDataMap.Count == 0 && LevelDetailDataMap.Count == 0)
		{
			return false;
		}
		BaseDataCollection = LevelBaseDataMap.Values.ToList();
		DetailDataCollection = LevelDetailDataMap.Values.ToList();
		return true;
	}

	public bool IsValidLevel()
	{
		return CurrentLevelID > 0;
	}
}
