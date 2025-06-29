using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;

namespace b1;

public class BGMWrap
{
	public Entity RequestorEntity;

	public int PlayingID;

	public DynamicGameObjectWrap GameObjectWrap;

	private UAkAudioEvent mAkEventStop;

	private Dictionary<EBGMStopCondition, BGMStopEventInfo> ConditionStopEvents;

	public bool IsWrapFromDefaultConfig;

	public EBGMPriority BGMPriority { get; set; }

	public UAkAudioEvent AkEventBegin { get; set; }

	public BGMWrap()
	{
		PlayingID = -1;
		RequestorEntity = Entity.Null;
		BGMPriority = EBGMPriority.WanderBGM;
		AkEventBegin = null;
		ConditionStopEvents = null;
		IsWrapFromDefaultConfig = false;
	}

	public BGMWrap(UAkAudioEvent _AkEventBegin, UAkAudioEvent _AkEventStop)
	{
		PlayingID = -1;
		RequestorEntity = Entity.Null;
		BGMPriority = EBGMPriority.WanderBGM;
		AkEventBegin = _AkEventBegin;
		mAkEventStop = _AkEventStop;
		ConditionStopEvents = null;
		IsWrapFromDefaultConfig = false;
	}

	public BGMWrap(Entity Entity, UAkAudioEvent _AkEventBegin, UAkAudioEvent _AkEventStop, Dictionary<EBGMStopCondition, BGMStopEventInfo> _ConditionStopEvents = null)
	{
		PlayingID = -1;
		RequestorEntity = Entity;
		BGMPriority = EBGMPriority.WanderBGM;
		AkEventBegin = _AkEventBegin;
		mAkEventStop = _AkEventStop;
		ConditionStopEvents = _ConditionStopEvents;
		IsWrapFromDefaultConfig = false;
	}

	public BGMWrap(Entity Entity, EBGMPriority _BGMPriority, UAkAudioEvent _AkEventBegin, UAkAudioEvent _AkEventStop, Dictionary<EBGMStopCondition, BGMStopEventInfo> _ConditionStopEvents = null)
	{
		PlayingID = -1;
		RequestorEntity = Entity;
		BGMPriority = _BGMPriority;
		AkEventBegin = _AkEventBegin;
		mAkEventStop = _AkEventStop;
		ConditionStopEvents = _ConditionStopEvents;
		IsWrapFromDefaultConfig = false;
	}

	public UAkAudioEvent GetStopEvent(EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		if (ConditionStopEvents != null && ConditionStopEvents.TryGetValue(StopCondition, out var value))
		{
			return value.StopEvent;
		}
		return mAkEventStop;
	}

	public void SetEventsFromWrap(BGMWrap OtherWrap)
	{
		AkEventBegin = OtherWrap.AkEventBegin;
		mAkEventStop = OtherWrap.mAkEventStop;
		if (OtherWrap.ConditionStopEvents == null)
		{
			ConditionStopEvents = null;
			return;
		}
		ConditionStopEvents = new Dictionary<EBGMStopCondition, BGMStopEventInfo>();
		foreach (KeyValuePair<EBGMStopCondition, BGMStopEventInfo> conditionStopEvent in OtherWrap.ConditionStopEvents)
		{
			ConditionStopEvents.Add(conditionStopEvent.Key, conditionStopEvent.Value);
		}
	}

	private bool IsConditionEventsEqual(Dictionary<EBGMStopCondition, BGMStopEventInfo> _ConditionStopEvents)
	{
		if (ConditionStopEvents == _ConditionStopEvents)
		{
			return true;
		}
		if (ConditionStopEvents == null || _ConditionStopEvents == null)
		{
			return false;
		}
		return ConditionStopEvents.Equals(ConditionStopEvents);
	}

	public bool IsWrapEventEqual(BGMWrap OtherWrap)
	{
		if (OtherWrap != null)
		{
			return IsWrapEventEqual(OtherWrap.AkEventBegin, OtherWrap.GetStopEvent(), OtherWrap.ConditionStopEvents);
		}
		return false;
	}

	public bool IsWrapEventEqual(UAkAudioEvent _AkEventBegin, UAkAudioEvent _AkEventStop, Dictionary<EBGMStopCondition, BGMStopEventInfo> _ConditionStopEvents)
	{
		if (AkEventBegin == _AkEventBegin && GetStopEvent() == _AkEventStop)
		{
			return IsConditionEventsEqual(_ConditionStopEvents);
		}
		return false;
	}

	public void ShareGameObjectWrap(BGMWrap OtherWrap)
	{
		OtherWrap.GameObjectWrap = GameObjectWrap;
	}

	public static bool IsValid(BGMWrap Wrap)
	{
		return Wrap?.IsValid() ?? false;
	}

	public bool IsValid()
	{
		if (AkEventBegin == null || GetStopEvent() == null)
		{
			return false;
		}
		return true;
	}
}
