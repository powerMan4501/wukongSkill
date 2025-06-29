using System;
using System.Collections.Generic;
using b1.ECS;
using GUR.Runtime;
using GurGsReplicate;

namespace b1;

public class BGC_LevelBattleData : IBGC_LevelBattleData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public LevelBattleData[] _RepData = new LevelBattleData[64];

	private int __GamePlayerNum_Raw;

	private int __DifficultBuffId_Raw;

	public Dictionary<string, int> OnlineItemTempList { get; set; }

	public int KillMonsterCount { get; set; }

	public Dictionary<int, int> ItemNumDict { get; set; } = new Dictionary<int, int>();

	[GSGameDataSnapShot]
	[GSReplicated]
	public int GamePlayerNum
	{
		get
		{
			return __GamePlayerNum_Raw;
		}
		set
		{
			int _GamePlayerNum_Raw = __GamePlayerNum_Raw;
			__GamePlayerNum_Raw = value;
			OnGamePlayerNumChg_Invoke(_GamePlayerNum_Raw, value);
		}
	}

	[GSReplicated]
	public int DifficultBuffId
	{
		get
		{
			return __DifficultBuffId_Raw;
		}
		set
		{
			int _DifficultBuffId_Raw = __DifficultBuffId_Raw;
			__DifficultBuffId_Raw = value;
			OnDifficultBuffIdChg_Invoke(_DifficultBuffId_Raw, value);
		}
	}

	public bool IsInPartyLevel { get; set; }

	public int LevelId { get; set; }

	public event Action<int, int> OnGamePlayerNumChg;

	public event Action<int, int> OnDifficultBuffIdChg;

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
	}

	public LevelBattleData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		LevelBattleData levelBattleData = _RepData[__LocalRepVersion % 64];
		if (levelBattleData == null)
		{
			levelBattleData = new LevelBattleData();
			_RepData[__LocalRepVersion % 64] = levelBattleData;
		}
		else if (flag)
		{
			levelBattleData.ClearGamePlayerNum();
			levelBattleData.ClearDifficultBuffId();
		}
		return levelBattleData;
	}

	public LevelBattleData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		LevelBattleData levelBattleData = new LevelBattleData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"LevelBattleData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			levelBattleData.GamePlayerNum = GamePlayerNum;
			levelBattleData.DifficultBuffId = DifficultBuffId;
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					LevelBattleData other = _RepData[i % 64];
					levelBattleData.MergeFrom(other);
				}
			}
		}
		return levelBattleData;
	}

	private void OnGamePlayerNumChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().GamePlayerNum = NewValue;
			}
			this.OnGamePlayerNumChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnDifficultBuffIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().DifficultBuffId = NewValue;
			}
			this.OnDifficultBuffIdChg?.Invoke(OldValue, NewValue);
		}
	}

	public BGC_LevelBattleData()
	{
		GamePlayerNum = 1;
	}

	public int GetGamePlayerNum()
	{
		return GamePlayerNum;
	}

	public int GetGameDifficultBuffId()
	{
		return DifficultBuffId;
	}
}
