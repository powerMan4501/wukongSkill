using b1.Plugins.AkAudio;

namespace b1;

public class BGWSingleBGMConfigInfo
{
	public UAkAudioEvent AkEventBegin;

	public UAkAudioEvent AkEventStop;

	public BGWSingleBGMConfigInfo()
	{
		AkEventBegin = null;
		AkEventStop = null;
	}

	public BGWSingleBGMConfigInfo(UAkAudioEvent AkEventBegin, UAkAudioEvent AkEventStop)
	{
		this.AkEventBegin = AkEventBegin;
		this.AkEventStop = AkEventStop;
	}

	public BGWSingleBGMConfigInfo(BGWSingleBGMConfigInfo SingleBGMConfigInfo)
	{
		if (SingleBGMConfigInfo != null)
		{
			AkEventBegin = SingleBGMConfigInfo.AkEventBegin;
			AkEventStop = SingleBGMConfigInfo.AkEventStop;
		}
	}

	public BGWSingleBGMConfigInfo(FSingleBGMConfig SingleBGMConfig)
	{
		AkEventBegin = SingleBGMConfig.AkEventBegin;
		AkEventStop = SingleBGMConfig.AkEventStop;
	}

	public BGMWrap ToBGMWrap()
	{
		return new BGMWrap(AkEventBegin, AkEventStop);
	}
}
