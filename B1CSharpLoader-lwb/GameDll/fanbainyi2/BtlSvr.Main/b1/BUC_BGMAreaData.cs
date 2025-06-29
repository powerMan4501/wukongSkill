using System.Collections.Generic;
using b1.Plugins.AkAudio;

namespace b1;

internal class BUC_BGMAreaData : b1.IBUC_BGMAreaData
{
	public bool IsPlayerEnteredVolume;

	public int CurrentVolumeInfoIndex;

	public UAkAudioEvent AkEventBegin;

	public UAkAudioEvent AkEventStop;

	public BGWBGMConfigDataAsset VolumeBGMConfigDA;

	public BGMVolumeGroupInfo VolumeGroupConfig;

	public List<b1.BGMVolumeConditionConfigInfo> VolumeConditionConfigInfos;
}
