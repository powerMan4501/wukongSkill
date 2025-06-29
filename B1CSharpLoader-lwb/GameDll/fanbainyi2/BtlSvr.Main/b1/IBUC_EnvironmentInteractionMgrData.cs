using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_EnvironmentInteractionMgrData
{
	bool bNearGround { get; }

	ESceneItemSurfaceType OriginalSurfaceType { get; }

	ESceneItemSurfaceType ResultSurfaceType { get; }

	ESceneItemSurfaceType SamplePointResultSurfaceType { get; }

	FVector SurfaceNormal_Normalized { get; }

	FRotator ChrRotAlignSurface { get; }

	FVector SurfaceHitPoint { get; }

	FVector PhySurfaceHitPoint { get; }

	float GetAbnormalStateAutoRecoverRate(EAbnormalStateType AbnormalStateType);
}
