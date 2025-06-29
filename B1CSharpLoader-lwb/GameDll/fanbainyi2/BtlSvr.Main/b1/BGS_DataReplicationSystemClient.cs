using System;
using b1.ECS;
using b1.EventDelDefine;
using GurGsReplicate;
using GurGsStruct;

namespace b1;

public class BGS_DataReplicationSystemClient : GameStateSystemBase
{
	private int LastAckedVersion = -1;

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

	public void ReplicateData(IntPtr ConnectionPtr, byte[] Buffer)
	{
		RepDataAll repDataAll = RepDataAll.Parser.ParseFrom(Buffer);
		if (repDataAll.CircusControlData != null && mCircusControlData != null)
		{
			if (repDataAll.CircusControlData.AlwaysSpawnTamerGuidList != null)
			{
				foreach (ListDeltaMsgString alwaysSpawnTamerGuid in repDataAll.CircusControlData.AlwaysSpawnTamerGuidList)
				{
					if (alwaysSpawnTamerGuid.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (alwaysSpawnTamerGuid.Op)
					{
					case OPType.Add:
					{
						string value = alwaysSpawnTamerGuid.Value;
						mCircusControlData.AlwaysSpawnTamerGuidList.Add(value);
						break;
					}
					case OPType.Remove:
						mCircusControlData.AlwaysSpawnTamerGuidList.RemoveAt((int)alwaysSpawnTamerGuid.Idx);
						break;
					case OPType.Modify:
						mCircusControlData.AlwaysSpawnTamerGuidList[(int)alwaysSpawnTamerGuid.Idx] = alwaysSpawnTamerGuid.Value;
						break;
					case OPType.Clear:
						mCircusControlData.AlwaysSpawnTamerGuidList.Clear();
						break;
					case OPType.SetNull:
						mCircusControlData.AlwaysSpawnTamerGuidList = null;
						break;
					case OPType.ChangeRef:
						if (mCircusControlData.AlwaysSpawnTamerGuidList == null)
						{
							mCircusControlData.AlwaysSpawnTamerGuidList = new BindListString();
						}
						else
						{
							mCircusControlData.AlwaysSpawnTamerGuidList.Clear();
						}
						break;
					}
				}
			}
			if (repDataAll.CircusControlData.NeverSpawnTamerGuidList != null)
			{
				foreach (ListDeltaMsgString neverSpawnTamerGuid in repDataAll.CircusControlData.NeverSpawnTamerGuidList)
				{
					if (neverSpawnTamerGuid.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (neverSpawnTamerGuid.Op)
					{
					case OPType.Add:
					{
						string value2 = neverSpawnTamerGuid.Value;
						mCircusControlData.NeverSpawnTamerGuidList.Add(value2);
						break;
					}
					case OPType.Remove:
						mCircusControlData.NeverSpawnTamerGuidList.RemoveAt((int)neverSpawnTamerGuid.Idx);
						break;
					case OPType.Modify:
						mCircusControlData.NeverSpawnTamerGuidList[(int)neverSpawnTamerGuid.Idx] = neverSpawnTamerGuid.Value;
						break;
					case OPType.Clear:
						mCircusControlData.NeverSpawnTamerGuidList.Clear();
						break;
					case OPType.SetNull:
						mCircusControlData.NeverSpawnTamerGuidList = null;
						break;
					case OPType.ChangeRef:
						if (mCircusControlData.NeverSpawnTamerGuidList == null)
						{
							mCircusControlData.NeverSpawnTamerGuidList = new BindListString();
						}
						else
						{
							mCircusControlData.NeverSpawnTamerGuidList.Clear();
						}
						break;
					}
				}
			}
		}
		if (repDataAll.GameStateTestData != null && mGameStateTestData != null)
		{
			if (repDataAll.GameStateTestData.HasTestID)
			{
				mGameStateTestData.TestID = repDataAll.GameStateTestData.TestID;
			}
			if (repDataAll.GameStateTestData.TestArr != null)
			{
				foreach (ListDeltaMsgInt item in repDataAll.GameStateTestData.TestArr)
				{
					if (item.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (item.Op)
					{
					case OPType.Add:
					{
						int value3 = item.Value;
						mGameStateTestData.TestArr.Add(value3);
						break;
					}
					case OPType.Remove:
						mGameStateTestData.TestArr.RemoveAt((int)item.Idx);
						break;
					case OPType.Modify:
						mGameStateTestData.TestArr[(int)item.Idx] = item.Value;
						break;
					case OPType.Clear:
						mGameStateTestData.TestArr.Clear();
						break;
					case OPType.SetNull:
						mGameStateTestData.TestArr = null;
						break;
					case OPType.ChangeRef:
						if (mGameStateTestData.TestArr == null)
						{
							mGameStateTestData.TestArr = new BindListInt();
						}
						else
						{
							mGameStateTestData.TestArr.Clear();
						}
						break;
					}
				}
			}
		}
		if (repDataAll.LevelAuthorityData != null && mLevelAuthorityData != null && repDataAll.LevelAuthorityData.LevelAuthorityMap != null)
		{
			foreach (DictDeltaMsgString_String item2 in repDataAll.LevelAuthorityData.LevelAuthorityMap)
			{
				if (item2.Version <= LastAckedVersion)
				{
					continue;
				}
				switch (item2.Op)
				{
				case OPType.Add:
				{
					string value4 = item2.Value;
					mLevelAuthorityData.LevelAuthorityMap.Add(item2.Idx, value4);
					break;
				}
				case OPType.Remove:
					mLevelAuthorityData.LevelAuthorityMap.Remove(item2.Idx);
					break;
				case OPType.Modify:
					mLevelAuthorityData.LevelAuthorityMap[item2.Idx] = item2.Value;
					break;
				case OPType.Clear:
					mLevelAuthorityData.LevelAuthorityMap.Clear();
					break;
				case OPType.SetNull:
					mLevelAuthorityData.LevelAuthorityMap = null;
					break;
				case OPType.ChangeRef:
					if (mLevelAuthorityData.LevelAuthorityMap == null)
					{
						mLevelAuthorityData.LevelAuthorityMap = new BindDictString_String();
					}
					else
					{
						mLevelAuthorityData.LevelAuthorityMap.Clear();
					}
					break;
				}
			}
		}
		if (repDataAll.LevelBattleData != null && mLevelBattleData != null)
		{
			if (repDataAll.LevelBattleData.HasGamePlayerNum)
			{
				mLevelBattleData.GamePlayerNum = repDataAll.LevelBattleData.GamePlayerNum;
			}
			if (repDataAll.LevelBattleData.HasDifficultBuffId)
			{
				mLevelBattleData.DifficultBuffId = repDataAll.LevelBattleData.DifficultBuffId;
			}
		}
		if (repDataAll.OnlineChallengeData != null && mOnlineChallengeData != null)
		{
			if (repDataAll.OnlineChallengeData.OnlineChallengeList != null)
			{
				foreach (DictDeltaMsgInt_ChallengeInfo onlineChallenge in repDataAll.OnlineChallengeData.OnlineChallengeList)
				{
					if (onlineChallenge.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (onlineChallenge.Op)
					{
					case OPType.Add:
					{
						ChallengeInfo challengeInfo = new ChallengeInfo();
						foreach (ClassDeltaMsgChallengeInfo item3 in onlineChallenge.Value)
						{
							if (item3.Version <= LastAckedVersion)
							{
								continue;
							}
							switch (item3.Op)
							{
							case OPType.Modify:
								if (item3.Value.HasChallengeId)
								{
									challengeInfo.ChallengeId = item3.Value.ChallengeId;
								}
								if (item3.Value.HasChallengeLevel)
								{
									challengeInfo.ChallengeLevel = item3.Value.ChallengeLevel;
								}
								foreach (ListDeltaMsgEntity challengingPlayer in item3.Value.ChallengingPlayerList)
								{
									if (challengingPlayer.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (challengingPlayer.Op)
									{
									case OPType.Add:
									{
										Entity entityByNetGUID = BGUFuncLibReplication.GetEntityByNetGUID(challengingPlayer.Value, ConnectionPtr);
										challengeInfo.ChallengingPlayerList.Add(entityByNetGUID);
										break;
									}
									case OPType.Remove:
										challengeInfo.ChallengingPlayerList.RemoveAt((int)challengingPlayer.Idx);
										break;
									case OPType.Modify:
										challengeInfo.ChallengingPlayerList[(int)challengingPlayer.Idx] = BGUFuncLibReplication.GetEntityByNetGUID(challengingPlayer.Value, ConnectionPtr);
										break;
									case OPType.Clear:
										challengeInfo.ChallengingPlayerList.Clear();
										break;
									case OPType.SetNull:
										challengeInfo.ChallengingPlayerList = null;
										break;
									case OPType.ChangeRef:
										if (challengeInfo.ChallengingPlayerList == null)
										{
											challengeInfo.ChallengingPlayerList = new BindListEntity();
										}
										else
										{
											challengeInfo.ChallengingPlayerList.Clear();
										}
										break;
									}
								}
								foreach (ListDeltaMsgEntity fallDyingPlayer in item3.Value.FallDyingPlayerList)
								{
									if (fallDyingPlayer.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (fallDyingPlayer.Op)
									{
									case OPType.Add:
									{
										Entity entityByNetGUID2 = BGUFuncLibReplication.GetEntityByNetGUID(fallDyingPlayer.Value, ConnectionPtr);
										challengeInfo.FallDyingPlayerList.Add(entityByNetGUID2);
										break;
									}
									case OPType.Remove:
										challengeInfo.FallDyingPlayerList.RemoveAt((int)fallDyingPlayer.Idx);
										break;
									case OPType.Modify:
										challengeInfo.FallDyingPlayerList[(int)fallDyingPlayer.Idx] = BGUFuncLibReplication.GetEntityByNetGUID(fallDyingPlayer.Value, ConnectionPtr);
										break;
									case OPType.Clear:
										challengeInfo.FallDyingPlayerList.Clear();
										break;
									case OPType.SetNull:
										challengeInfo.FallDyingPlayerList = null;
										break;
									case OPType.ChangeRef:
										if (challengeInfo.FallDyingPlayerList == null)
										{
											challengeInfo.FallDyingPlayerList = new BindListEntity();
										}
										else
										{
											challengeInfo.FallDyingPlayerList.Clear();
										}
										break;
									}
								}
								if (item3.Value.HasChallengeFailed)
								{
									challengeInfo.ChallengeFailed = item3.Value.ChallengeFailed;
								}
								if (item3.Value.HasLimitTime)
								{
									challengeInfo.LimitTime = item3.Value.LimitTime;
								}
								break;
							case OPType.SetNull:
								challengeInfo = null;
								break;
							case OPType.ChangeRef:
								challengeInfo = new ChallengeInfo();
								break;
							}
						}
						mOnlineChallengeData.OnlineChallengeList.Add(onlineChallenge.Idx, challengeInfo);
						break;
					}
					case OPType.Remove:
						mOnlineChallengeData.OnlineChallengeList.Remove(onlineChallenge.Idx);
						break;
					case OPType.Modify:
						foreach (ClassDeltaMsgChallengeInfo item4 in onlineChallenge.Value)
						{
							if (item4.Version <= LastAckedVersion)
							{
								continue;
							}
							switch (item4.Op)
							{
							case OPType.Modify:
								if (item4.Value.HasChallengeId)
								{
									mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengeId = item4.Value.ChallengeId;
								}
								if (item4.Value.HasChallengeLevel)
								{
									mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengeLevel = item4.Value.ChallengeLevel;
								}
								foreach (ListDeltaMsgEntity challengingPlayer2 in item4.Value.ChallengingPlayerList)
								{
									if (challengingPlayer2.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (challengingPlayer2.Op)
									{
									case OPType.Add:
									{
										Entity entityByNetGUID3 = BGUFuncLibReplication.GetEntityByNetGUID(challengingPlayer2.Value, ConnectionPtr);
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengingPlayerList.Add(entityByNetGUID3);
										break;
									}
									case OPType.Remove:
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengingPlayerList.RemoveAt((int)challengingPlayer2.Idx);
										break;
									case OPType.Modify:
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengingPlayerList[(int)challengingPlayer2.Idx] = BGUFuncLibReplication.GetEntityByNetGUID(challengingPlayer2.Value, ConnectionPtr);
										break;
									case OPType.Clear:
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengingPlayerList.Clear();
										break;
									case OPType.SetNull:
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengingPlayerList = null;
										break;
									case OPType.ChangeRef:
										if (mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengingPlayerList == null)
										{
											mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengingPlayerList = new BindListEntity();
										}
										else
										{
											mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengingPlayerList.Clear();
										}
										break;
									}
								}
								foreach (ListDeltaMsgEntity fallDyingPlayer2 in item4.Value.FallDyingPlayerList)
								{
									if (fallDyingPlayer2.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (fallDyingPlayer2.Op)
									{
									case OPType.Add:
									{
										Entity entityByNetGUID4 = BGUFuncLibReplication.GetEntityByNetGUID(fallDyingPlayer2.Value, ConnectionPtr);
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].FallDyingPlayerList.Add(entityByNetGUID4);
										break;
									}
									case OPType.Remove:
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].FallDyingPlayerList.RemoveAt((int)fallDyingPlayer2.Idx);
										break;
									case OPType.Modify:
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].FallDyingPlayerList[(int)fallDyingPlayer2.Idx] = BGUFuncLibReplication.GetEntityByNetGUID(fallDyingPlayer2.Value, ConnectionPtr);
										break;
									case OPType.Clear:
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].FallDyingPlayerList.Clear();
										break;
									case OPType.SetNull:
										mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].FallDyingPlayerList = null;
										break;
									case OPType.ChangeRef:
										if (mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].FallDyingPlayerList == null)
										{
											mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].FallDyingPlayerList = new BindListEntity();
										}
										else
										{
											mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].FallDyingPlayerList.Clear();
										}
										break;
									}
								}
								if (item4.Value.HasChallengeFailed)
								{
									mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].ChallengeFailed = item4.Value.ChallengeFailed;
								}
								if (item4.Value.HasLimitTime)
								{
									mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx].LimitTime = item4.Value.LimitTime;
								}
								break;
							case OPType.SetNull:
								mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx] = null;
								break;
							case OPType.ChangeRef:
								mOnlineChallengeData.OnlineChallengeList[onlineChallenge.Idx] = new ChallengeInfo();
								break;
							}
						}
						break;
					case OPType.Clear:
						mOnlineChallengeData.OnlineChallengeList.Clear();
						break;
					case OPType.SetNull:
						mOnlineChallengeData.OnlineChallengeList = null;
						break;
					case OPType.ChangeRef:
						if (mOnlineChallengeData.OnlineChallengeList == null)
						{
							mOnlineChallengeData.OnlineChallengeList = new BindDictInt_ChallengeInfo();
						}
						else
						{
							mOnlineChallengeData.OnlineChallengeList.Clear();
						}
						break;
					}
				}
			}
			if (repDataAll.OnlineChallengeData.OnlineChallengeStageDict != null)
			{
				foreach (DictDeltaMsgInt_EChallengeState item5 in repDataAll.OnlineChallengeData.OnlineChallengeStageDict)
				{
					if (item5.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (item5.Op)
					{
					case OPType.Add:
					{
						EChallengeState value5 = (EChallengeState)item5.Value;
						mOnlineChallengeData.OnlineChallengeStageDict.Add(item5.Idx, value5);
						break;
					}
					case OPType.Remove:
						mOnlineChallengeData.OnlineChallengeStageDict.Remove(item5.Idx);
						break;
					case OPType.Modify:
						mOnlineChallengeData.OnlineChallengeStageDict[item5.Idx] = (EChallengeState)item5.Value;
						break;
					case OPType.Clear:
						mOnlineChallengeData.OnlineChallengeStageDict.Clear();
						break;
					case OPType.SetNull:
						mOnlineChallengeData.OnlineChallengeStageDict = null;
						break;
					case OPType.ChangeRef:
						if (mOnlineChallengeData.OnlineChallengeStageDict == null)
						{
							mOnlineChallengeData.OnlineChallengeStageDict = new BindDictInt_EChallengeState();
						}
						else
						{
							mOnlineChallengeData.OnlineChallengeStageDict.Clear();
						}
						break;
					}
				}
			}
		}
		LastAckedVersion = repDataAll.Version;
	}

	public void OnAttachHandWritten()
	{
		base.BGSEventCollection.Evt_BGS_DoReplicateData += new Del_DoReplicateData(OnRecvReplicationData);
	}

	protected int OnRecvReplicationData(IntPtr ConnectionPtr, byte[] ReplicationBytes)
	{
		try
		{
			ReplicateData(ConnectionPtr, ReplicationBytes);
			return 0;
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"Replicate Data Error!!! {arg}");
			return -1;
		}
	}
}
