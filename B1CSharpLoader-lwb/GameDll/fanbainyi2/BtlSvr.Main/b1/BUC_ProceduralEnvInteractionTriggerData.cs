using b1.ECS;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ProceduralEnvInteractionTriggerData : IPersistentECSData
{
	public bool bEnable { get; set; }

	public float TraceDelay { get; set; }

	public float TraceLength { get; set; }

	public float SampleCollectionProtectTime { get; set; }

	public float Size { get; set; }

	public ESceneItemSurfaceType OverrideSurfaceType { get; set; }

	public float OverrideSurfacePersistTime { get; set; }

	public FName OverrideSurfaceFXActorTag { get; set; }

	public bool bDrawDebug { get; set; }

	public float DebugDrawOffset { get; set; }

	public float DelayTimer { get; set; }

	public float HitProtectTimer { get; set; }

	public void CopyBPDataToData(bool InbEnable, float InTraceDelay, float InTraceLength, float InSize, float InSampleCollectionProtectTime, ESceneItemSurfaceType InOverrideSurfaceType, float InOverrideSurfacePersistTime, FName InOverrideSurfaceFXActorTag, bool InDrawDebug, float InDebugDrawOffset)
	{
		bEnable = InbEnable;
		float delayTimer = (TraceDelay = InTraceDelay);
		DelayTimer = delayTimer;
		TraceLength = InTraceLength;
		Size = InSize;
		delayTimer = (SampleCollectionProtectTime = InSampleCollectionProtectTime);
		HitProtectTimer = delayTimer;
		OverrideSurfaceType = InOverrideSurfaceType;
		OverrideSurfacePersistTime = InOverrideSurfacePersistTime;
		OverrideSurfaceFXActorTag = InOverrideSurfaceFXActorTag;
		bDrawDebug = InDrawDebug;
		DebugDrawOffset = InDebugDrawOffset;
	}
}
