using System;
using System.Collections.Generic;
using b1.BGU.BUAnim;
using b1.Plugins.MM;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPMotionMatchingData
{
	FTransform MMInputDesiredTransform { get; }

	FTransform MMInputRootTransform { get; }

	float MMInputStrength { get; }

	EState_MM MotionMatchingState { get; }

	EState_MM MotionMatchingStateForABP { get; }

	FRotator RotatorforMM { get; }

	EABPMoveMode SpareMoveMode { get; }

	UAnimationAnalyzer CurrentAA { get; }

	BUAnimationAnalyzer CurrentAACS { get; }

	EState_MM DefaultMMState { get; }

	float AnimationAnalyzerBlendTime { get; }

	float MotionBlendTime { get; }

	float MMPlayRate { get; }

	float ForceSetRotAnimSpeed { get; }

	float DisableRotVerifyAnimSpeed { get; }

	bool bRecordMMAnimData { get; }

	bool bDisableLocomotionIdle { get; }

	bool bForceMMToIdle { get; }

	float MMUpBodyStateAlpha { get; }

	float RotateBSX { get; }

	bool bMMLockUseFreeMode { get; }

	UAnimSequence MMTransAnim { get; }

	float MMTransAnimStartPos { get; }

	float MMTransAlpha { get; }

	bool bMMTransFinish { get; }

	bool bMMTransStart { get; }

	bool bKeepMMInputUnchanged { get; }

	bool bUseLMAnim { get; }

	FSoftObjectPath CurUsingAnimSoftPath { get; }

	Dictionary<FSoftObjectPath, Action<int, UObject>> RequestAnimationAsycLoadMap { get; }

	Dictionary<EState_MM, BUAnimationAnalyzer> MMState2AACS { get; }

	bool IsInLockState();

	void GetDefaultLocalMotionJointData(AActor Owner, out List<FVector> JointLocation, out List<FVector> JointVelocity);
}
