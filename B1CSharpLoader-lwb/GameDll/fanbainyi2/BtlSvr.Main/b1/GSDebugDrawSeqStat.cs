using System;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSDebugDrawSeqStat")]
public class GSDebugDrawSeqStat : GSDebugDrawBase
{
	private URichTextBlock TxtMessage;

	protected override void Init()
	{
		base.Init();
		TxtMessage = FindChildWidget("TxtMessage") as URichTextBlock;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (Data is DebugDrawSeqStat debugDrawSeqStat && !debugDrawSeqStat.SeqActor.IsNullOrDestroyed())
		{
			ULevelSequencePlayer sequencePlayer = debugDrawSeqStat.SeqActor.GetSequencePlayer();
			ULevelSequence sequence = debugDrawSeqStat.SeqActor.GetSequence();
			if (!sequencePlayer.IsNullOrDestroyed() && !sequence.IsNullOrDestroyed())
			{
				FQualifiedTime currentTime = sequencePlayer.GetCurrentTime();
				TxtMessage?.SetText(FText.FromString(string.Format("{0} : {1} ({2:D5})", sequencePlayer.GetSequenceName(), sequencePlayer.IsPlaying() ? "Playing" : "Stop", currentTime.Time.FrameNumber.Value)));
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSDebugDrawSeqStat");
	}

	static GSDebugDrawSeqStat()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDebugDrawSeqStat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDebugDrawSeqStat));
	}
}
