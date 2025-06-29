using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

public static class UAnimPoseExtensions_CsExtensions
{
	public static void SetBonePose(this ref FAnimPose Pose, FTransform Transform, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		UAnimPoseExtensions.SetBonePose(ref Pose, Transform, BoneName, Space);
	}

	public static bool IsValid(this FAnimPose Pose)
	{
		return UAnimPoseExtensions.IsValid(Pose);
	}

	public static FTransform GetRelativeTransform(this FAnimPose Pose, FName FromBoneName, FName ToBoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		return UAnimPoseExtensions.GetRelativeTransform(Pose, FromBoneName, ToBoneName, Space);
	}

	public static FTransform GetRelativeToRefPoseTransform(this FAnimPose Pose, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		return UAnimPoseExtensions.GetRelativeToRefPoseTransform(Pose, BoneName, Space);
	}

	public static FTransform GetRefPoseRelativeTransform(this FAnimPose Pose, FName FromBoneName, FName ToBoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		return UAnimPoseExtensions.GetRefPoseRelativeTransform(Pose, FromBoneName, ToBoneName, Space);
	}

	public static void GetReferencePose(this USkeleton Skeleton, out FAnimPose OutPose)
	{
		UAnimPoseExtensions.GetReferencePose(Skeleton, out OutPose);
	}

	public static FTransform GetRefBonePose(this FAnimPose Pose, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		return UAnimPoseExtensions.GetRefBonePose(Pose, BoneName, Space);
	}

	public static FTransform GetBonePose(this FAnimPose Pose, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		return UAnimPoseExtensions.GetBonePose(Pose, BoneName, Space);
	}

	public static void GetBoneNames(this FAnimPose Pose, out List<FName> Bones)
	{
		UAnimPoseExtensions.GetBoneNames(Pose, out Bones);
	}

	public static void GetAnimPoseAtTime(this UAnimSequenceBase AnimationSequenceBase, float Time, FAnimPoseEvaluationOptions EvaluationOptions, out FAnimPose Pose)
	{
		UAnimPoseExtensions.GetAnimPoseAtTime(AnimationSequenceBase, Time, EvaluationOptions, out Pose);
	}

	public static void GetAnimPoseAtFrame(this UAnimSequenceBase AnimationSequenceBase, int FrameIndex, FAnimPoseEvaluationOptions EvaluationOptions, out FAnimPose Pose)
	{
		UAnimPoseExtensions.GetAnimPoseAtFrame(AnimationSequenceBase, FrameIndex, EvaluationOptions, out Pose);
	}

	public static void EvaluateAnimationBlueprintWithInputPose(this FAnimPose InputPose, USkeletalMesh TargetSkeletalMesh, UAnimBlueprint AnimationBlueprint, out FAnimPose OutPose)
	{
		UAnimPoseExtensions.EvaluateAnimationBlueprintWithInputPose(InputPose, TargetSkeletalMesh, AnimationBlueprint, out OutPose);
	}
}
