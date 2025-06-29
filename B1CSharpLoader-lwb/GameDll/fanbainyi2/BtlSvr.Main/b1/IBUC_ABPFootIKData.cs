using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPFootIKData
{
	bool bActiveFootIK { get; }

	bool bRHandUseFBIK { get; }

	bool bLHandUseFBIK { get; }

	bool bActiveForefootIK { get; }

	bool bActiveTouchIK { get; }

	bool bFootUseFBIK { get; }

	FVector IKEffectorLeftFoot { get; }

	FVector IKEffectorRightFoot { get; }

	FVector IKEffectorLFoot_MeshSpace { get; }

	FVector IKEffectorRFoot_MeshSpace { get; }

	FVector IKJoint_LeftFoot { get; }

	FVector IKJoint_RightFoot { get; }

	FVector IKJointLFoot_MeshSpace { get; }

	FVector IKJointRFoot_MeshSpace { get; }

	float IKRightFootAlpha { get; }

	float IKLeftFootAlpha { get; }

	FVector IKEffectorLeftHand { get; }

	FVector IKEffectorLHand_MeshSpace { get; }

	FVector IKEffectorRightHand { get; }

	FVector IKEffectorRHand_MeshSpace { get; }

	FVector IKJointLeftHand { get; }

	FVector IKJointRightHand { get; }

	float IKAlphaLeftHand { get; }

	float IKAlphaRightHand { get; }

	float IKPelvisOffsetScaled { get; }

	float IKNeckOffsetScaled { get; }

	bool bEnableDebug { get; }

	AActor TouchIKTargetActor { get; }

	void ThreadSafeUpdateAnimation(AActor Owner, float DeltaTime);
}
