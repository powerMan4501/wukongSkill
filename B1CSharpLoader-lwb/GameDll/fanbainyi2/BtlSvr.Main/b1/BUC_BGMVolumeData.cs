using System.Collections.Generic;
using b1.Plugins.AkAudio;

namespace b1;

internal class BUC_BGMVolumeData : b1.IBUC_BGMVolumeData
{
	public bool HasInit;

	public bool IsPlayerEnteredVolume;

	public int CurrentVolumeInfoIndex;

	public UAkAudioEvent AkEventBegin;

	public UAkAudioEvent AkEventStop;

	public BGWBGMConfigDataAsset VolumeBGMConfigDA;

	public BGMVolumeGroupInfo VolumeGroupConfig;

	public List<b1.BGMVolumeConditionConfigInfo> VolumeConditionConfigInfos;
}
