using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

internal class SequenceTriggerEffectInfo
{
	public Queue<AActor> TargetActorQue;

	public int SequenceEffectID;

	public float SequenceDuration;

	public float SequenceTriggerTimer;

	public FEffectInstReq EffectInstReq;

	public bool bWithRPCEvent;

	public SequenceTriggerEffectInfo(Queue<AActor> _TargetIDQue, int _SequenceEffectID, float _SequenceDuration, ref FEffectInstReq _EffectInstReq, bool _bWithRPCEvent)
	{
		TargetActorQue = _TargetIDQue;
		SequenceEffectID = _SequenceEffectID;
		SequenceDuration = _SequenceDuration;
		EffectInstReq = _EffectInstReq;
		SequenceTriggerTimer = 0f;
		bWithRPCEvent = _bWithRPCEvent;
	}
}
