using System.Collections.Generic;
using b1.Plugins.AkAudio;

namespace b1;

public class BGWBGMConfigInfo
{
	public List<BGWSingleBGMConfigInfo> DefaultWanderBGMList { get; set; }

	public List<BGWSingleBattleBGMConfigInfo> DefaultMonsterBattleBGMList { get; set; }

	public List<BGWSingleBattleBGMConfigInfo> DefaultEliteBattleBGMList { get; set; }

	public List<BGWSingleBattleBGMConfigInfo> DefaultBossBattleBGMList { get; set; }

	public UAkAudioEvent DefaultSequenceStopBGMEvent { get; set; }

	public BGWSingleBGMConfigInfo DefaultShrineBGM { get; set; }

	public BGWSingleBGMConfigInfo DefaultRoleBGM { get; set; }

	public List<EBGMDisableType> DisabledBGMTypes { get; set; }

	public void InitEmptyConfigInfo()
	{
		DefaultWanderBGMList = new List<BGWSingleBGMConfigInfo>();
		DefaultMonsterBattleBGMList = new List<BGWSingleBattleBGMConfigInfo>();
		DefaultEliteBattleBGMList = new List<BGWSingleBattleBGMConfigInfo>();
		DefaultBossBattleBGMList = new List<BGWSingleBattleBGMConfigInfo>();
		DefaultSequenceStopBGMEvent = null;
		DefaultShrineBGM = new BGWSingleBGMConfigInfo();
		DefaultRoleBGM = new BGWSingleBGMConfigInfo();
		DisabledBGMTypes = new List<EBGMDisableType>();
	}

	public BGWBGMConfigInfo()
	{
		InitEmptyConfigInfo();
	}

	public BGWBGMConfigInfo(BGWBGMConfigInfo ConfigInfo)
	{
		if (ConfigInfo == null)
		{
			InitEmptyConfigInfo();
			return;
		}
		DefaultWanderBGMList = ((ConfigInfo.DefaultWanderBGMList == null) ? new List<BGWSingleBGMConfigInfo>() : new List<BGWSingleBGMConfigInfo>(ConfigInfo.DefaultWanderBGMList));
		DefaultMonsterBattleBGMList = ((ConfigInfo.DefaultMonsterBattleBGMList == null) ? new List<BGWSingleBattleBGMConfigInfo>() : new List<BGWSingleBattleBGMConfigInfo>(ConfigInfo.DefaultMonsterBattleBGMList));
		DefaultEliteBattleBGMList = ((ConfigInfo.DefaultEliteBattleBGMList == null) ? new List<BGWSingleBattleBGMConfigInfo>() : new List<BGWSingleBattleBGMConfigInfo>(ConfigInfo.DefaultEliteBattleBGMList));
		DefaultBossBattleBGMList = ((ConfigInfo.DefaultBossBattleBGMList == null) ? new List<BGWSingleBattleBGMConfigInfo>() : new List<BGWSingleBattleBGMConfigInfo>(ConfigInfo.DefaultBossBattleBGMList));
		DefaultSequenceStopBGMEvent = ConfigInfo.DefaultSequenceStopBGMEvent;
		DefaultShrineBGM = new BGWSingleBGMConfigInfo(ConfigInfo.DefaultShrineBGM);
		DefaultRoleBGM = new BGWSingleBGMConfigInfo(ConfigInfo.DefaultRoleBGM);
		DisabledBGMTypes = ((ConfigInfo.DisabledBGMTypes == null) ? new List<EBGMDisableType>() : new List<EBGMDisableType>(ConfigInfo.DisabledBGMTypes));
	}

	public BGWBGMConfigInfo(UAkAudioEvent WanderBegin, UAkAudioEvent WanderEnd)
	{
		if (WanderBegin != null && WanderEnd != null)
		{
			DefaultWanderBGMList = new List<BGWSingleBGMConfigInfo>
			{
				new BGWSingleBGMConfigInfo(WanderBegin, WanderEnd)
			};
		}
		else
		{
			DefaultWanderBGMList = null;
		}
		DefaultMonsterBattleBGMList = (DefaultEliteBattleBGMList = (DefaultBossBattleBGMList = null));
		DefaultSequenceStopBGMEvent = null;
		DefaultShrineBGM = (DefaultRoleBGM = null);
		DisabledBGMTypes = null;
	}

	public void TryCoverByOtherConfig(BGWBGMConfigInfo OtherConfig)
	{
		if (OtherConfig != null)
		{
			if (OtherConfig.DefaultWanderBGMList != null)
			{
				DefaultWanderBGMList = OtherConfig.DefaultWanderBGMList;
			}
			if (OtherConfig.DefaultMonsterBattleBGMList != null)
			{
				DefaultMonsterBattleBGMList = OtherConfig.DefaultMonsterBattleBGMList;
			}
			if (OtherConfig.DefaultEliteBattleBGMList != null)
			{
				DefaultEliteBattleBGMList = OtherConfig.DefaultEliteBattleBGMList;
			}
			if (OtherConfig.DefaultBossBattleBGMList != null)
			{
				DefaultBossBattleBGMList = OtherConfig.DefaultBossBattleBGMList;
			}
			if (OtherConfig.DefaultSequenceStopBGMEvent != null)
			{
				DefaultSequenceStopBGMEvent = OtherConfig.DefaultSequenceStopBGMEvent;
			}
			if (OtherConfig.DefaultShrineBGM != null)
			{
				DefaultShrineBGM = OtherConfig.DefaultShrineBGM;
			}
			if (OtherConfig.DefaultRoleBGM != null)
			{
				DefaultRoleBGM = OtherConfig.DefaultRoleBGM;
			}
			if (OtherConfig.DisabledBGMTypes != null)
			{
				DisabledBGMTypes = OtherConfig.DisabledBGMTypes;
			}
		}
	}
}
