using System;
using b1.EventDelDefine;
using Google.Protobuf;
using GurGsReplicate;

namespace b1;

public class BGS_DataReplicationSystemSvr : GameStateSystemBase
{
	private BGC_CircusControlData mCircusControlData;

	private BGC_GameStateTestData mGameStateTestData;

	private BGC_LevelAuthorityData mLevelAuthorityData;

	private BGC_LevelBattleData mLevelBattleData;

	private BGC_OnlineChallengeData mOnlineChallengeData;

	public override void OnAttach()
	{
		mCircusControlData = RequireWritableData<BGC_CircusControlData>();
		mGameStateTestData = RequireWritableData<BGC_GameStateTestData>();
		mLevelAuthorityData = RequireWritableData<BGC_LevelAuthorityData>();
		mLevelBattleData = RequireWritableData<BGC_LevelBattleData>();
		mOnlineChallengeData = RequireWritableData<BGC_OnlineChallengeData>();
		OnAttachHandWritten();
	}

	public byte[] GenerateReplicatedData(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		RepDataAll repDataAll = new RepDataAll();
		repDataAll.Version = BGWGameInstanceCS.sGlobalReplicateVersionAlloc;
		repDataAll.OldVersion = OldGlobalVersion;
		if (mCircusControlData != null)
		{
			repDataAll.CircusControlData = mCircusControlData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mGameStateTestData != null)
		{
			repDataAll.GameStateTestData = mGameStateTestData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mLevelAuthorityData != null)
		{
			repDataAll.LevelAuthorityData = mLevelAuthorityData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mLevelBattleData != null)
		{
			repDataAll.LevelBattleData = mLevelBattleData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mOnlineChallengeData != null)
		{
			repDataAll.OnlineChallengeData = mOnlineChallengeData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		return repDataAll.ToByteArray();
	}

	public void OnAttachHandWritten()
	{
		base.BGSEventCollection.Evt_BGS_CollectReplicateData += new Del_CollectReplicateData(CollectReplicateData);
	}

	public void CollectReplicateData(IntPtr ConnectionPtr, int OldVersion, out byte[] ReplicationBytes)
	{
		try
		{
			ReplicationBytes = GenerateReplicatedData(ConnectionPtr, OldVersion);
		}
		catch (Exception arg)
		{
			ReplicationBytes = null;
			BGW_LogUtil.LogError($"Replicate Data Error!!! {arg}");
		}
	}
}
