using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

internal class BUC_TriggerEffectData
{
	public UnorderedArray<b1.SequenceTriggerEffectInfo> MultiTargetTriggerSequenceArray { get; set; } = new UnorderedArray<b1.SequenceTriggerEffectInfo>();

	public void AddTriggerSequence(List<AActor> TargetList, int SequenceEffectID, float SequenceDuration, FEffectInstReq EffectInstReq, bool bWithRPCEvent)
	{
		Queue<AActor> queue = new Queue<AActor>();
		foreach (AActor Target in TargetList)
		{
			queue.Enqueue(Target);
		}
		MultiTargetTriggerSequenceArray.Add(new b1.SequenceTriggerEffectInfo(queue, SequenceEffectID, SequenceDuration, ref EffectInstReq, bWithRPCEvent));
	}
}
