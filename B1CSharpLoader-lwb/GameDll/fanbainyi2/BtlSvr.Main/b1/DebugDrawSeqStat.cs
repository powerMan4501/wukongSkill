using UnrealEngine.LevelSequence;

namespace b1;

public class DebugDrawSeqStat : DebugDataBase
{
	public ALevelSequenceActor SeqActor;

	public DebugDrawSeqStat(float InDestroyTime, ALevelSequenceActor InSeqActor)
		: base(EDebugDrawType.SeqStat, InDestroyTime)
	{
		SeqActor = InSeqActor;
	}
}
