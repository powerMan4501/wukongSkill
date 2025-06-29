using System;

namespace b1;

[Flags]
public enum EActorCompAlterFlag : long
{
	DashWall = 1L,
	UnitEnterFight = 4L,
	CoopAI = 0x10L,
	TransPhase = 0x20L,
	Fly = 0x40L,
	MovePhysicsTransform = 0x80L,
	FXDetach = 0x100L,
	GlobalFX = 0x200L,
	MagicallyChange = 0x400L,
	AlwaysCantMove = 0x800L,
	SGD = 0x1000L,
	AssistantAI = 0x2000L,
	PointLight = 0x4000L,
	DamageTransfer = 0x8000L,
	PigsyStory = 0x10000L,
	LifeSaving = 0x20000L,
	IronBody = 0x40000L,
	Facial = 0x80000L
}
