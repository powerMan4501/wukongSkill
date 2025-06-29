using b1.Plugins.AkAudio;

namespace b1;

public class BGWStopEventConditionConfigInfo
{
	public UAkAudioEvent LeaveBattleEventStop;

	public UAkAudioEvent PlayerDeadEventStop;

	public BGWStopEventConditionConfigInfo(FStopEventConditionConfig StopEventConditionConfig)
	{
		LeaveBattleEventStop = StopEventConditionConfig.LeaveBattleEventStop;
		PlayerDeadEventStop = StopEventConditionConfig.PlayerDeadEventStop;
	}
}
