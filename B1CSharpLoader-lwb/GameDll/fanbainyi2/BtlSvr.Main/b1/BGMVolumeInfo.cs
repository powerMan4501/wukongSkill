using b1.Plugins.AkAudio;

namespace b1;

public class BGMVolumeInfo
{
	public EBGMVolumePriority VolumePriority { get; private set; }

	public UAkAudioEvent WanderEventBegin { get; }

	public UAkAudioEvent WanderEventEnd { get; }

	public BGWBGMConfigInfo BgmConfigInfo { get; }

	public BGMVolumeGroupInfo VolumeGroupInfo { get; }

	public BGMVolumeInfo(UAkAudioEvent WanderEventBegin, UAkAudioEvent WanderEventEnd, BGWBGMConfigDataAsset VolumeBGMConfigDA, BGMVolumeGroupInfo VolumeGroupInfo, EBGMVolumePriority Priority = EBGMVolumePriority.BGMWanderVolume)
	{
		this.WanderEventBegin = WanderEventBegin;
		this.WanderEventEnd = WanderEventEnd;
		if (VolumeBGMConfigDA == null)
		{
			BgmConfigInfo = new BGWBGMConfigInfo(WanderEventBegin, WanderEventEnd);
		}
		else
		{
			BgmConfigInfo = VolumeBGMConfigDA.GetConfigInfo();
			BgmConfigInfo.TryCoverByOtherConfig(new BGWBGMConfigInfo(WanderEventBegin, WanderEventEnd));
		}
		this.VolumeGroupInfo = VolumeGroupInfo;
		VolumePriority = Priority;
	}

	public BGMVolumeInfo(BGWBGMConfigDataAsset VolumeBGMConfigDA, BGMVolumeGroupInfo VolumeGroupInfo = null, EBGMVolumePriority Priority = EBGMVolumePriority.BGMWanderVolume)
	{
		BgmConfigInfo = ((VolumeBGMConfigDA != null) ? VolumeBGMConfigDA.GetConfigInfo() : new BGWBGMConfigInfo());
		this.VolumeGroupInfo = ((VolumeGroupInfo != null) ? VolumeGroupInfo : new BGMVolumeGroupInfo());
		VolumePriority = Priority;
	}

	public BGMVolumeInfo(BGWBGMConfigDataAsset VolumeBGMConfigDA, EBGMVolumePriority Priority = EBGMVolumePriority.BGMWanderVolume)
	{
		BgmConfigInfo = ((VolumeBGMConfigDA != null) ? VolumeBGMConfigDA.GetConfigInfo() : new BGWBGMConfigInfo());
		VolumeGroupInfo = new BGMVolumeGroupInfo();
		VolumePriority = Priority;
	}

	public void SetPriority(EBGMVolumePriority Priority)
	{
		VolumePriority = Priority;
	}
}
