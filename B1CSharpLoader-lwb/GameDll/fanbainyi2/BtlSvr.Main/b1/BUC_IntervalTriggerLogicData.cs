using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;

namespace b1;

public class BUC_IntervalTriggerLogicData : IPersistentECSData
{
	public bool bEventActive { get; set; }

	public float TriggerInterval { get; set; }

	public float RemainInterval { get; set; }

	public float DuringTime { get; set; }

	public float RemainDuringTime { get; set; }

	public List<int> AddBuffList { get; set; }

	public List<int> PlayerAddBuffList { get; set; }

	public BGWDataAsset_AIPerceptionConfig AIPerceptionConfig { get; set; }

	public BGWDataAsset_PostProcessMatSetting PostProcessMatConfig { get; set; }

	public UAkAudioEvent AkEventBegin { get; set; }

	public UAkAudioEvent AkEventStop { get; set; }

	public BGWBGMConfigDataAsset VolumeBGMConfigDA { get; set; }

	public BGMVolumeGroupInfo VolumeGroupConfig { get; set; }

	public List<string> IgnoredGuidList { get; set; } = new List<string>();

	public List<string> IgnoredPerceptionSettingGuidList { get; set; } = new List<string>();

	public List<AActor> InnerActors { get; set; }
}
