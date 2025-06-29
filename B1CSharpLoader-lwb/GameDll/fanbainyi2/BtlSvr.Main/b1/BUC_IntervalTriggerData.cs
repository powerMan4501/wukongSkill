using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_IntervalTriggerData : IBUC_IntervalTriggerData, IPersistentECSData
{
	public float Timer { get; set; }

	public float DuringTimer { get; set; }

	public float CachedIntervalTriggerTime { get; set; }

	public float CachedIntervalTriggerDuringTime { get; set; }

	public bool OverlapEnabled { get; set; } = true;

	public List<int> AddBuffList { get; set; }

	public int SpBuffID { get; set; }

	public List<int> PlayerAddBuffList { get; set; }

	public BGWDataAsset_AIPerceptionConfig AIPerceptionConfig { get; set; }

	public BGWDataAsset_PostProcessMatSetting PostProcessMatConfig { get; set; }

	public List<string> IgnoredGuidList { get; set; } = new List<string>();

	public List<string> SpGuidList { get; set; } = new List<string>();

	public List<string> IgnoredPerceptionSettingGuidList { get; set; } = new List<string>();

	public bool bIsActive { get; set; }

	public List<string> InVolumeActors { get; set; } = new List<string>();

	public float WarningTime { get; set; }

	public int WarningBuffID { get; set; }

	public bool IsNotifiedWarning { get; set; }

	public AActor InVolumePlayer { get; set; }
}
