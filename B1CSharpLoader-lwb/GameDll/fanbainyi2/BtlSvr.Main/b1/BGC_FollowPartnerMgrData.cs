using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_FollowPartnerMgrData : IBGC_FollowPartnerMgrData, IPersistentECSData
{
	public float TickTimer;

	public bool bCanTick;

	public bool bIsFollowPartnerSpawnFinish;

	public float SpawnCountdownTimer;

	public Dictionary<Entity, int> EnterInteractAreaList = new Dictionary<Entity, int>();

	public List<int> CurrentLevelFollowPartnerConfigIDList = new List<int>();

	public int CurrentLevelIDCache;

	private TStrongObjectPtr<BGWDataAsset_FollowPartnerDisplayConfig> mFollowPartnerDisplayConfig = new TStrongObjectPtr<BGWDataAsset_FollowPartnerDisplayConfig>();

	public bool SeqHiddenFlag { get; set; }

	public string FollowPartnerGUID { get; set; }

	public int CurrentUseFollowPartnerConfigID { get; set; }

	public float WeakAiInteractConversationTimer { get; set; }

	public List<string> WeakAiInteractGUIDList { get; set; } = new List<string>();

	public BGWDataAsset_FollowPartnerDisplayConfig FollowPartnerDisplayConfig
	{
		get
		{
			return mFollowPartnerDisplayConfig.Get();
		}
		set
		{
			mFollowPartnerDisplayConfig.Set(value);
		}
	}

	public void Init(float _SpawnCountdownTimer)
	{
		FollowPartnerGUID = string.Empty;
		bIsFollowPartnerSpawnFinish = false;
		bCanTick = false;
		CurrentUseFollowPartnerConfigID = -1;
		SpawnCountdownTimer = _SpawnCountdownTimer;
		TickTimer = 0f;
		CurrentLevelIDCache = int.MinValue;
		SeqHiddenFlag = false;
	}

	public void GetLastEnterInteractArea(out Entity InteractEntity, out int Step)
	{
		InteractEntity = Entity.Null;
		Step = 0;
		if (EnterInteractAreaList != null)
		{
			List<Entity> list = EnterInteractAreaList.Keys.ToList();
			int count = list.Count;
			if (count > 0 && EnterInteractAreaList.TryGetValue(list[count - 1], out var value))
			{
				InteractEntity = list[count - 1];
				Step = value;
			}
		}
	}

	public int GetInteractAreaStep(Entity InteractEntity)
	{
		if (InteractEntity != Entity.Null && EnterInteractAreaList != null && EnterInteractAreaList.TryGetValue(InteractEntity, out var value))
		{
			return value;
		}
		return -1;
	}
}
