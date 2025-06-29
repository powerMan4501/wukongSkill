namespace b1;

public interface IBIC_LevelStateManageData
{
	BGWDataAsset_SeqLevelLoadRelationInfo SeqLevelLoadRelationInfo { get; }

	int UpdateLevelState(string RequesterID, int LevelID, FGSLevelStateControlInfo LevelManagedInfo, EGSLevelStateInfoLayerType Layer);

	FGSPersistentLevelStateLayerInfo GetCurrentLevelStateInfo(int LevelID);

	int OnBatchingRequestsSent();

	FGSLevelStateRequestBatchInfo OnRequestedBatchFinished(int BatchID);
}
