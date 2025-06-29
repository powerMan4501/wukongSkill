using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_CricketMgrData : b1.IBUC_CricketMgrData
{
	private TStrongObjectPtr<BGWDataAsset_CricketInteractConfig> mInteractConfig = new TStrongObjectPtr<BGWDataAsset_CricketInteractConfig>();

	private TStrongObjectPtr<UAnimSequence> mASWeakIdle = new TStrongObjectPtr<UAnimSequence>();

	public TSubclassOf<BUTamerActor> CricketTamer { get; set; }

	public float SpawnProbability { get; set; }

	public FVector2D SpawnDelayTimeRange { get; set; }

	public int TrySpawnMaxCount { get; set; }

	public float ReSpawnDelayTime { get; set; }

	public List<b1.CricketMovePointConfig> MovePointConfig { get; set; }

	public float LeaveFightDistance { get; set; }

	public float LeaveFightDelayTime { get; set; }

	public float LeaveFightTimer { get; set; }

	public BGWDataAsset_CricketInteractConfig InteractConfig
	{
		get
		{
			return mInteractConfig.Get();
		}
		set
		{
			mInteractConfig.Set(value);
		}
	}

	public int InteractMaxJumpCount { get; set; }

	public UAnimSequence ASWeakIdle
	{
		get
		{
			return mASWeakIdle.Get();
		}
		set
		{
			mASWeakIdle.Set(value);
		}
	}

	public float WeakDuration { get; set; }

	public int NormalLongPressInteractGroupID { get; set; }

	public int WeakLongPressInteractGroupID { get; set; }

	public int CurPointIndex { get; set; }

	public string CricketGuid { get; set; }

	public string RequestSpawnCricketGuid { get; set; }

	public bool bJumpUp { get; set; }

	public bool bKeepInteracting { get; set; }

	public bool bWeak { get; set; }

	public string InteractActorGuid { get; set; }

	public int InteractJumpCount { get; set; }

	public List<TStrongObjectPtr<UAnimSequence>> DefaultAnimIdleList { get; set; }

	public bool bCricketPrepareInteract { get; set; }

	public int TrySpawnCount { get; set; }

	public float TrySpawnTimer { get; set; }

	public float SpawnDelayTimer { get; set; }

	public int RealDefaultInteractiveGroupID { get; set; }

	public b1.ECricketAliveState AliveState { get; set; }
}
