using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;

namespace b1;

public class BGC_LevelAuthorityData : IBGC_LevelAuthorityData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public LevelAuthorityData[] _RepData = new LevelAuthorityData[64];

	private BindDictString_String __LevelAuthorityMap_Raw;

	[CompilerGenerated]
	private BindDictString_String _003CLevelAuthorityMap_003Ek__BackingField = new BindDictString_String();

	[GSReplicated]
	public BindDictString_String LevelAuthorityMap
	{
		get
		{
			return __LevelAuthorityMap_Raw;
		}
		set
		{
			BindDictString_String _LevelAuthorityMap_Raw = __LevelAuthorityMap_Raw;
			__LevelAuthorityMap_Raw = value;
			OnLevelAuthorityMapChg_Invoke(_LevelAuthorityMap_Raw, value);
		}
	}

	public event Action<BindDictString_String, BindDictString_String> OnLevelAuthorityMapChg;

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
		if (IsActive)
		{
			LevelAuthorityMap?.RegGetDeltaDataFunc(AllocRepDataForLevelAuthorityMap);
		}
		else
		{
			LevelAuthorityMap?.RegGetDeltaDataFunc(null);
		}
		LevelAuthorityMap?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<DictDeltaMsgString_String> AllocRepDataForLevelAuthorityMap()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().LevelAuthorityMap;
		}
		return null;
	}

	public LevelAuthorityData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		LevelAuthorityData levelAuthorityData = _RepData[__LocalRepVersion % 64];
		if (levelAuthorityData == null)
		{
			levelAuthorityData = new LevelAuthorityData();
			LevelAuthorityMap?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = levelAuthorityData;
		}
		else if (flag)
		{
			levelAuthorityData.LevelAuthorityMap.Clear();
			LevelAuthorityMap?.ClearDeltaData();
		}
		return levelAuthorityData;
	}

	public LevelAuthorityData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			LevelAuthorityMap?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		LevelAuthorityData levelAuthorityData = new LevelAuthorityData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"LevelAuthorityData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (LevelAuthorityMap == null)
			{
				levelAuthorityData.LevelAuthorityMap.Add(new DictDeltaMsgString_String
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				LevelAuthorityMap.DumpFull(levelAuthorityData.LevelAuthorityMap);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					LevelAuthorityData other = _RepData[i % 64];
					levelAuthorityData.MergeFrom(other);
				}
			}
		}
		return levelAuthorityData;
	}

	private void OnLevelAuthorityMapChg_Invoke(BindDictString_String OldValue, BindDictString_String NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			LevelAuthorityData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.LevelAuthorityMap.Clear();
			if (NewValue == null)
			{
				orAllocRepData.LevelAuthorityMap.Add(new DictDeltaMsgString_String
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.LevelAuthorityMap);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForLevelAuthorityMap);
		this.OnLevelAuthorityMapChg?.Invoke(OldValue, NewValue);
	}
}
