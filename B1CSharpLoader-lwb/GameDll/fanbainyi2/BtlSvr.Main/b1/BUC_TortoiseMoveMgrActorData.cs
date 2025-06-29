using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_TortoiseMoveMgrActorData
{
	public AActor Tortoise;

	public FName LevelMoveAttachedBone;

	public bool IsOnInverseAnim;

	public bool ShouldStopInverseAnim;

	public UAnimSequence InverseAnimationSequence;

	public bool bInverseAnimLoop;

	public bool AnimReversed;

	public float AnimCurrentTime;

	public float AnimLastTime;

	public UAnimSequence RealTortoiseAnim;

	public bool bTortoiseWantToPlayAnim;

	public List<FName> FakeMoveLevels;

	public BUC_TortoiseMoveMgrActorData()
	{
		FakeMoveLevels = new List<FName>();
	}
}
