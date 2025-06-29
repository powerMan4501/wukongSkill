using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_BattleBGMData : IBUC_BattleBGMData
{
	public bool bDisableBattleBGM;

	public int BGMStopDistance;

	public float BGMEventStopTimer;

	public EBGMPriority BGMPriority;

	private TStrongObjectPtr<UAkAudioEvent> mAkEventBegin = new TStrongObjectPtr<UAkAudioEvent>();

	private TStrongObjectPtr<UAkAudioEvent> mAkEventStop = new TStrongObjectPtr<UAkAudioEvent>();

	public Dictionary<EBGMStopCondition, BGMStopEventInfo> ConditionStopEvents;

	public bool HasTriggerDead;

	public bool HasPlayBGM;

	public Entity OwnerEntity;

	public ETransMusicConfig TransMusicConfig { get; private set; }

	public UAkAudioEvent AkEventBegin
	{
		get
		{
			return mAkEventBegin.Get();
		}
		set
		{
			mAkEventBegin.Set(value);
		}
	}

	public UAkAudioEvent AkEventStop
	{
		get
		{
			return mAkEventStop.Get();
		}
		set
		{
			mAkEventStop.Set(value);
		}
	}

	public void SetBattleBGMBPConfig(FBtlBGMBPConfig BtlBGMBPConfig)
	{
		bDisableBattleBGM = BtlBGMBPConfig.bDisableBattleBGM;
		TransMusicConfig = BtlBGMBPConfig.TransMusicConfig;
		BGMStopDistance = BtlBGMBPConfig.BGMStopDistance;
		AkEventBegin = BtlBGMBPConfig.AkEventBegin;
		AkEventStop = BtlBGMBPConfig.AkEventStop;
		ConditionStopEvents = BGUFunctionLibraryCS.GetConditionStopEvents(BtlBGMBPConfig.StopEventConditionConfig);
	}
}
