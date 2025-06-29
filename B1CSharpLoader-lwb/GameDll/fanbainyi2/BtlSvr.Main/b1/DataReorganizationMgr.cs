using System.Collections.Generic;
using ArchiveB1;
using CommB1;
using GurGsPersistent;
using UnrealEngine.Runtime;

namespace b1;

public static class DataReorganizationMgr
{
	private static FUStBEDArchivesData ArchivesDataCache;

	public static void FetchReadonlyRolData(UObject Context, out ReadOnlyRoleData RoleData)
	{
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Context));
		RoleData = readOnlyData.RoleData;
	}

	public static int GetMapIdInArchive(UObject WorldContext)
	{
		return BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(WorldContext)?.GetLevelIDInArchive() ?? 0;
	}

	public static LevelArchiveData FetchReadOnlyLevelData(UObject WorldContext)
	{
		BGW_EventCollection.Get(WorldContext).Evt_RequestUpdateLevelArchiveData();
		IBIC_LevelData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(WorldContext);
		LevelArchiveData levelArchiveData = new LevelArchiveData();
		gameInstanceReadonlyData.GetAllLevelArchiveData(out var BaseDataCollection, out var DetailDataCollection);
		if (BaseDataCollection != null)
		{
			levelArchiveData.LevelBaseData.AddRange(BaseDataCollection);
		}
		if (DetailDataCollection != null)
		{
			levelArchiveData.LevelDetailData.AddRange(DetailDataCollection);
		}
		return levelArchiveData;
	}

	public static WorldTaskArchiveData FetchReadOnlyTaskData(UObject WorldContext)
	{
		BGW_EventCollection.Get(WorldContext).Evt_RequestUpdateTaskArchiveData();
		return BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(WorldContext).TaskArchiveData;
	}

	public static StateMachineArchiveData FetchReadOnlyStateMachineData(UObject WorldContext)
	{
		BGW_EventCollection.Get(WorldContext).Evt_RequestUpdateStateMachineArchiveData();
		return BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_StateMachineData, BIC_StateMachineData>(WorldContext).ArchiveData;
	}

	public static List<int> FetchReadOnlyMovieData(UObject WorldContext)
	{
		BGW_EventCollection.Get(WorldContext).Evt_RequestUpdateMovieArchiveData();
		BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_MovieData, BIC_MovieData>(WorldContext).GetPlayedSequenceList(out var OutPlayedSequenceList);
		return OutPlayedSequenceList;
	}

	public static PersistentECSData FetchAllPersistentECSData(UObject WorldContext)
	{
		return BGW_EventCollection.Get(WorldContext).Evt_SerializePersistentECSData();
	}
}
