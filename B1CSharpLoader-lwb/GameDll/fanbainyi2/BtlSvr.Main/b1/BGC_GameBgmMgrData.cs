using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_GameBgmMgrData : IBGC_GameBgmMgrData, IPersistentECSData
{
	public Dictionary<EBGMTrackType, IBGUBgmTrack> BGMTracks;

	public Entity WanderBgmEntity = Entity.Null;

	public int CurrentConfigLevelID = -1;

	public BGWBGMConfigDataAsset LevelBGMConfigDataAsset;

	public BGWBGMConfigInfo LevelBGMConfigInfo;

	public List<BGMVolumeInfo> WanderVolumeInfoStack;

	public List<AActor> WanderVolumeStack;

	public Dictionary<FName, BGMVolumeInfo> VolumeGroupInfo;

	public BGUBgmTrackDefault BattleBGMTrack;

	public bool HasInit { get; set; }

	public BGWBGMConfigInfo BGMConfigInfo { get; set; }

	private BGMWrap GetRandomBGMByType(Entity Entity, EBGMPriority Priority, List<BGWSingleBGMConfigInfo> BattleBGMList)
	{
		if (BattleBGMList != null)
		{
			if (BattleBGMList.Count == 0)
			{
				return new BGMWrap();
			}
			int randomNumberInt = UB1Util.GetRandomNumberInt(0, BattleBGMList.Count - 1);
			BGWSingleBGMConfigInfo bGWSingleBGMConfigInfo = BattleBGMList[randomNumberInt];
			if (bGWSingleBGMConfigInfo.AkEventBegin != null && bGWSingleBGMConfigInfo.AkEventStop != null)
			{
				return new BGMWrap(Entity, Priority, bGWSingleBGMConfigInfo.AkEventBegin, bGWSingleBGMConfigInfo.AkEventStop);
			}
		}
		return null;
	}

	private BGMWrap GetRandomBGMByType(Entity Entity, EBGMPriority Priority, List<BGWSingleBattleBGMConfigInfo> BattleBGMList)
	{
		if (BattleBGMList != null)
		{
			if (BattleBGMList.Count == 0)
			{
				return new BGMWrap();
			}
			int randomNumberInt = UB1Util.GetRandomNumberInt(0, BattleBGMList.Count - 1);
			BGWSingleBattleBGMConfigInfo bGWSingleBattleBGMConfigInfo = BattleBGMList[randomNumberInt];
			if (bGWSingleBattleBGMConfigInfo.AkEventBegin != null && bGWSingleBattleBGMConfigInfo.AkEventStop != null)
			{
				return new BGMWrap(Entity, Priority, bGWSingleBattleBGMConfigInfo.AkEventBegin, bGWSingleBattleBGMConfigInfo.AkEventStop, BGUFunctionLibraryCS.GetConditionStopEvents(bGWSingleBattleBGMConfigInfo.StopEventConditionConfigInfo));
			}
		}
		return null;
	}

	public BGMWrap GetRandomDefaultBGMWrap(Entity Entity, EBGMPriority RandomPriority)
	{
		BGMWrap bGMWrap = null;
		if (BGMConfigInfo == null)
		{
			return null;
		}
		if (BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(ECSExtension.ToActor(Entity)) != null)
		{
			switch (RandomPriority)
			{
			case EBGMPriority.BossBattleBGM:
				bGMWrap = GetRandomBGMByType(Entity, RandomPriority, BGMConfigInfo.DefaultBossBattleBGMList);
				break;
			case EBGMPriority.EliteBattleBGM:
				bGMWrap = GetRandomBGMByType(Entity, RandomPriority, BGMConfigInfo.DefaultEliteBattleBGMList);
				break;
			case EBGMPriority.MonsterBattleBGM:
				bGMWrap = GetRandomBGMByType(Entity, RandomPriority, BGMConfigInfo.DefaultMonsterBattleBGMList);
				break;
			case EBGMPriority.WanderBGM:
				bGMWrap = GetRandomBGMByType(Entity, RandomPriority, BGMConfigInfo.DefaultWanderBGMList);
				break;
			}
		}
		if (bGMWrap != null)
		{
			bGMWrap.IsWrapFromDefaultConfig = true;
		}
		return bGMWrap;
	}

	public BGMWrap GetCurrentWanderBGM()
	{
		return GetRandomDefaultBGMWrap(WanderBgmEntity, EBGMPriority.WanderBGM);
	}

	public bool TryGetCurrentEntityBattleBgmWrap(Entity entity, out BGMWrap BgmWrap)
	{
		return BattleBGMTrack.TryGetCurrentEntityBattleBgmWrap(entity, out BgmWrap);
	}
}
