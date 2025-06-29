using System.Collections.Generic;
using b1.Plugins.AkAudio;

namespace b1;

internal class BGMVolumeConditionConfigInfo
{
	public List<b1.BGMVolumeConditionGroupInfo> ConditionGroups;

	public UAkAudioEvent AkEventBegin;

	public UAkAudioEvent AkEventStop;

	public BGWBGMConfigDataAsset VolumeBGMConfigDA;

	public BGMVolumeGroupInfo VolumeGroupConfig;

	public BGMVolumeConditionConfigInfo(FBGMVolumeConditionConfig ConditionConfig)
	{
		ConditionGroups = new List<b1.BGMVolumeConditionGroupInfo>();
		foreach (FBGMVolumeConditionGroup conditionGroup in ConditionConfig.ConditionGroups)
		{
			ConditionGroups.Add(new b1.BGMVolumeConditionGroupInfo(conditionGroup));
		}
		AkEventBegin = ConditionConfig.AkEventBegin;
		AkEventStop = ConditionConfig.AkEventStop;
		VolumeBGMConfigDA = ConditionConfig.VolumeBGMConfigDA;
		VolumeGroupConfig = ConditionConfig.VolumeGroupConfig.GetBGMVolumeGroupInfo();
	}

	public BGMVolumeInfo GetVolumeInfo()
	{
		return new BGMVolumeInfo(AkEventBegin, AkEventStop, VolumeBGMConfigDA, VolumeGroupConfig);
	}
}
