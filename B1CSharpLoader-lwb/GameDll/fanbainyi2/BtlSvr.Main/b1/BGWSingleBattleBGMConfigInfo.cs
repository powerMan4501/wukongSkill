using b1.ECS;
using b1.Plugins.AkAudio;

namespace b1;

public class BGWSingleBattleBGMConfigInfo
{
	public UAkAudioEvent AkEventBegin;

	public UAkAudioEvent AkEventStop;

	public BGWStopEventConditionConfigInfo StopEventConditionConfigInfo;

	public BGWSingleBattleBGMConfigInfo(FSingleBattleBGMConfig SingleBattleBGMConfig)
	{
		AkEventBegin = SingleBattleBGMConfig.AkEventBegin;
		AkEventStop = SingleBattleBGMConfig.AkEventStop;
		StopEventConditionConfigInfo = new BGWStopEventConditionConfigInfo(SingleBattleBGMConfig.StopEventConditionConfig);
	}

	public BGMWrap ToBGMWrap()
	{
		return new BGMWrap(Entity.Null, EBGMPriority.BossBattleBGM, AkEventBegin, AkEventStop, BGUFunctionLibraryCS.GetConditionStopEvents(StopEventConditionConfigInfo));
	}
}
