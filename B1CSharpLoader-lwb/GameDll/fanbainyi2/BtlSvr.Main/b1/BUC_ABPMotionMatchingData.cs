using System;
using System.Collections.Generic;
using b1.BGU.BUAnim;
using b1.Plugins.MM;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPMotionMatchingData : IBUC_ABPMotionMatchingData
{
	private FRotator InputRotationForLockState;

	private FRotator LastInputRotationForRotateState;

	private FRotator LastFrameInputRotation;

	private FTransform LastRecordMMInput;

	private FVector CachedInput;

	private EMoveSpeedLevel MMMoveSpeedState;

	private float MoveSpeedStateChangeTimer;

	private HashSet<FName> MMReferencedJoints;

	private UAnimationAnalyzer Walk2RunAA;

	private bool bLastWalk;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_PlayerCameraData CameraData;

	private IBUC_ActorBasicData ActorBasicData;

	private IBUC_MovementData MovementData;

	private IBUC_HardMoveData HardMoveData;

	public FTransform MMInputDesiredTransform { get; set; }

	public FTransform MMInputRootTransform { get; set; }

	public float MMInputStrength { get; set; }

	public EState_MM TargetMMState { get; set; }

	public EState_MM MotionMatchingState { get; set; }

	public EState_MM MotionMatchingStateForABP { get; set; }

	public EState_MM DefaultMMState { get; set; }

	public FRotator RotatorforMM { get; set; }

	public EABPMoveMode SpareMoveMode { get; set; }

	public UAnimationAnalyzer CurrentAA { get; set; }

	public BUAnimationAnalyzer CurrentAACS { get; set; }

	public float AnimationAnalyzerBlendTime { get; set; }

	public float MotionBlendTime { get; set; }

	public float MMPlayRate { get; set; }

	public float ForceSetRotAnimSpeed { get; set; }

	public float DisableRotVerifyAnimSpeed { get; set; }

	public bool bRecordMMAnimData { get; set; }

	public bool bDisableLocomotionIdle { get; set; }

	public bool bForceMMToIdle { get; set; }

	public float MMUpBodyStateAlpha { get; set; }

	public float RotateBSX { get; set; }

	public bool bMMLockUseFreeMode { get; set; }

	public bool bNeedFixMM { get; set; }

	public UAnimSequence MMAdditivePose { get; set; }

	public UAnimSequence MMTransAnim { get; set; }

	public float MMTransAnimStartPos { get; set; }

	public float MMTransAlpha { get; set; }

	public bool bMMTransFinish { get; set; }

	public bool bMMTransStart { get; set; }

	public bool bKeepMMInputUnchanged { get; set; }

	public bool bUseLMAnim { get; set; }

	public FSoftObjectPath CurUsingAnimSoftPath { get; set; }

	public Dictionary<FSoftObjectPath, Action<int, UObject>> RequestAnimationAsycLoadMap { get; set; }

	public Dictionary<FName, FVector> LastSocketLocation { get; set; }

	public Dictionary<FName, FVector> SocketLocation { get; set; }

	public Dictionary<FName, FVector> LastSocketVelocity { get; set; }

	public Dictionary<EState_MM, BUAnimationAnalyzer> MMState2AACS { get; set; }

	public bool IsInLockState()
	{
		if (MotionMatchingState != EState_MM.Lock && MotionMatchingState != EState_MM.LockWalk && MotionMatchingState != EState_MM.LockRun)
		{
			return MotionMatchingState == EState_MM.LockSprint;
		}
		return true;
	}

	public void Init(AActor Owner, BUABPSettingData Setting, IBUC_UnitStateData InUnitStateData, IBUC_PlayerCameraData InCameraData, IBUC_ActorBasicData InActorBasicData, IBUC_MovementData InMovementData, IBUC_HardMoveData InHardMoveData, IBUC_TargetInfoData InTargetInfoData)
	{
		UnitStateData = InUnitStateData;
		CameraData = InCameraData;
		ActorBasicData = InActorBasicData;
		MovementData = InMovementData;
		HardMoveData = InHardMoveData;
		TargetInfoData = InTargetInfoData;
		if (b1.BGU.BUAnim.AbpHelperUtil.ShouldInitABPMoveModeData(Owner, EABPMoveMode.MotionMatching, Setting))
		{
			BUABPMotionMatchingSettingData motionMatchingSetting = Setting.MotionMatchingSetting;
			Walk2RunAA = motionMatchingSetting.Walk2RunAA;
			bMMLockUseFreeMode = motionMatchingSetting.bMMLockUseFreeMode;
			MMUpBodyStateAlpha = motionMatchingSetting.MMUpBodyStateAlpha;
			SpareMoveMode = motionMatchingSetting.SpareMoveMode;
			MMState2AACS = motionMatchingSetting.MMState2AACS;
			MMTransAnim = null;
			MMTransAnimStartPos = 0f;
			MMTransAlpha = 0f;
			bMMTransStart = false;
			bMMTransFinish = false;
			bForceMMToIdle = false;
			MMMoveSpeedState = EMoveSpeedLevel.Run;
			MoveSpeedStateChangeTimer = 0f;
			InitCurrentAA();
			InitReferencedJoints();
			AnimationAnalyzerBlendTime = motionMatchingSetting.AnimationAnalyzerBlendTime;
			MotionBlendTime = motionMatchingSetting.MotionBlendTime;
			MMPlayRate = 1f;
			ForceSetRotAnimSpeed = motionMatchingSetting.ForceSetRotAnimSpeed;
			DisableRotVerifyAnimSpeed = motionMatchingSetting.DisableRotVerifyAnimSpeed;
			TargetMMState = motionMatchingSetting.DefaultMMState;
			LastSocketLocation = new Dictionary<FName, FVector>();
			SocketLocation = new Dictionary<FName, FVector>();
			LastSocketVelocity = new Dictionary<FName, FVector>();
			RequestAnimationAsycLoadMap = new Dictionary<FSoftObjectPath, Action<int, UObject>>();
			MMInputDesiredTransform = FTransform.Identity;
			MMInputRootTransform = FTransform.Identity;
		}
	}

	private void InitCurrentAA()
	{
		bool flag = MMState2AACS.TryGetValue(EState_MM.FreeRun, out var value);
		if (flag)
		{
			DefaultMMState = EState_MM.FreeRun;
		}
		if (!flag)
		{
			flag = MMState2AACS.TryGetValue(EState_MM.FreeWalk, out value);
			DefaultMMState = EState_MM.FreeWalk;
		}
		if (!flag)
		{
			flag = MMState2AACS.TryGetValue(EState_MM.FreeSprint, out value);
			DefaultMMState = EState_MM.FreeSprint;
		}
		if (!flag)
		{
			flag = MMState2AACS.TryGetValue(EState_MM.Free, out value);
			DefaultMMState = EState_MM.Free;
		}
		if (!flag)
		{
			flag = MMState2AACS.TryGetValue(EState_MM.LockRun, out value);
			DefaultMMState = EState_MM.LockRun;
		}
		if (!flag)
		{
			flag = MMState2AACS.TryGetValue(EState_MM.LockWalk, out value);
			DefaultMMState = EState_MM.LockWalk;
		}
		if (!flag)
		{
			flag = MMState2AACS.TryGetValue(EState_MM.LockSprint, out value);
			DefaultMMState = EState_MM.LockSprint;
		}
		if (!flag)
		{
			flag = MMState2AACS.TryGetValue(EState_MM.Lock, out value);
			DefaultMMState = EState_MM.Lock;
		}
		CurrentAA = ((value != null) ? value : null);
		CurrentAACS = value;
		bUseLMAnim = CurrentAA != null && CurrentAA.IsUseLMAnim();
		if (bUseLMAnim)
		{
			DefaultMMState = EState_MM.None;
		}
	}

	private void InitReferencedJoints()
	{
		MMReferencedJoints = new HashSet<FName>();
		foreach (KeyValuePair<EState_MM, BUAnimationAnalyzer> mMState2AAC in MMState2AACS)
		{
			if (mMState2AAC.Value == null)
			{
				continue;
			}
			foreach (FName referencedJoint in mMState2AAC.Value.ReferencedJoints)
			{
				MMReferencedJoints.Add(referencedJoint);
			}
		}
	}

	public void Update1(AActor Owner, IBUC_ABPHelperData HelperData, IBUC_ABPBasicData BasicData, float DeltaTime)
	{
		if (!(Owner == null) && HelperData.ABPSettingData.CommonSetting.ABPMoveMode == EABPMoveMode.MotionMatching)
		{
			UpdateMoveSpeedState(BasicData, DeltaTime);
			UpdatePlayerMotionMatchingState(Owner);
			UpdateMotionMatchingState(HelperData.ABPSettingData.MotionMatchingSetting);
		}
	}

	public void Update2(AActor Owner, IBUC_ABPHelperData HelperData, IBUC_ABPCommonSettingData CommonData, IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		if (Owner == null || HelperData.ABPSettingData.CommonSetting.ABPMoveMode != EABPMoveMode.MotionMatching)
		{
			return;
		}
		RecordSocketLocationForMM(Owner, DeltaTime);
		if (MotionMatchingState != EState_MM.None)
		{
			UpdateAnimationAnalyzer(BasicData);
			if (CommonData.FinalABPMoveMode == EABPMoveMode.MotionMatching)
			{
				UpdateLockStateRotation(Owner, ChrData);
				SetMMInputPlayerDirectionData(Owner, BasicData, ChrData, DeltaTime);
				UpdateRotateBSX(BasicData, DeltaTime);
			}
		}
	}

	private void RecordSocketLocationForMM(AActor Owner, float DeltaTime)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter != null) || MMReferencedJoints == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		if (mesh == null)
		{
			return;
		}
		foreach (FName mMReferencedJoint in MMReferencedJoints)
		{
			FName SocketName = mMReferencedJoint;
			FVector value = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref SocketName);
			if (!SocketLocation.ContainsKey(mMReferencedJoint))
			{
				SocketLocation.Add(mMReferencedJoint, value);
			}
			if (!LastSocketLocation.ContainsKey(mMReferencedJoint))
			{
				LastSocketLocation.Add(mMReferencedJoint, value);
			}
			if (!LastSocketVelocity.ContainsKey(mMReferencedJoint))
			{
				LastSocketVelocity.Add(mMReferencedJoint, FVector.ZeroVector);
			}
			FVector fVector = SocketLocation[mMReferencedJoint] - LastSocketLocation[mMReferencedJoint];
			LastSocketVelocity[mMReferencedJoint] = fVector / DeltaTime;
			LastSocketLocation[mMReferencedJoint] = SocketLocation[mMReferencedJoint];
			SocketLocation[mMReferencedJoint] = value;
		}
	}

	private void UpdateMoveSpeedState(IBUC_ABPBasicData BasicData, float DeltaTime)
	{
		if (MMMoveSpeedState != EMoveSpeedLevel.Sprint)
		{
			MoveSpeedStateChangeTimer = 0f;
			MMMoveSpeedState = BasicData.MoveSpeedState;
			return;
		}
		if (BasicData.MoveSpeedState != MMMoveSpeedState && MoveSpeedStateChangeTimer <= 0f)
		{
			MoveSpeedStateChangeTimer = 0.1f;
		}
		if (MoveSpeedStateChangeTimer > 0f)
		{
			MoveSpeedStateChangeTimer -= DeltaTime;
			if (MoveSpeedStateChangeTimer <= 0f)
			{
				MoveSpeedStateChangeTimer = 0f;
				MMMoveSpeedState = BasicData.MoveSpeedState;
			}
		}
	}

	private void UpdatePlayerMotionMatchingState(AActor Owner)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null || !aCharacter.IsPlayerControlled())
		{
			return;
		}
		bool flag = false;
		if (TargetInfoData != null)
		{
			UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
			if (targetInfo != null && targetInfo.LockTargetActor != null && targetInfo.LockTargetWayType == ELockTargetWayType.Manual)
			{
				flag = true;
			}
		}
		if (UnitStateData != null && UnitStateData.HasState(EBGUUnitState.ShooterMode))
		{
			flag = true;
		}
		if (CameraData != null && CameraData.IsInG4Mode())
		{
			flag = true;
		}
		switch (MMMoveSpeedState)
		{
		case EMoveSpeedLevel.Walk:
			TargetMMState = (flag ? EState_MM.LockWalk : EState_MM.FreeWalk);
			break;
		case EMoveSpeedLevel.Run:
			TargetMMState = (flag ? EState_MM.LockRun : EState_MM.FreeRun);
			break;
		case EMoveSpeedLevel.Sprint:
			TargetMMState = (flag ? EState_MM.LockSprint : EState_MM.FreeSprint);
			break;
		default:
			TargetMMState = (flag ? EState_MM.Lock : EState_MM.Free);
			break;
		}
	}

	private void UpdateMotionMatchingState(BUABPMotionMatchingSettingData MMSetting)
	{
		if (HardMoveData != null && HardMoveData.bFrozenHardMoving)
		{
			TargetMMState = EState_MM.FrozenMove;
		}
		if (HardMoveData != null && HardMoveData.bMuddyHardMoving)
		{
			TargetMMState = EState_MM.MuddyMove;
		}
		if (HardMoveData != null && HardMoveData.bWindyHardMoving)
		{
			TargetMMState = EState_MM.WindyMove;
		}
		if (HardMoveData != null && HardMoveData.bSpiderSilkyHardMoving)
		{
			TargetMMState = EState_MM.SpiderSilkyMove;
		}
		MotionMatchingState = (IsMMStateValid(MMSetting, TargetMMState) ? TargetMMState : EState_MM.None);
		MotionMatchingStateForABP = MotionMatchingState;
		if (MotionMatchingState == EState_MM.None && MMState2AACS.Count > 0)
		{
			using Dictionary<EState_MM, BUAnimationAnalyzer>.Enumerator enumerator = MMSetting.MMState2AACS.GetEnumerator();
			if (enumerator.MoveNext())
			{
				MotionMatchingStateForABP = enumerator.Current.Key;
			}
		}
		if (bMMLockUseFreeMode)
		{
			switch (MotionMatchingStateForABP)
			{
			case EState_MM.Lock:
				MotionMatchingStateForABP = EState_MM.Free;
				break;
			case EState_MM.LockWalk:
				MotionMatchingStateForABP = EState_MM.FreeWalk;
				break;
			case EState_MM.LockRun:
				MotionMatchingStateForABP = EState_MM.FreeRun;
				break;
			case EState_MM.LockSprint:
				MotionMatchingStateForABP = EState_MM.FreeSprint;
				break;
			}
		}
	}

	private bool IsMMStateValid(BUABPMotionMatchingSettingData MMSetting, EState_MM MMState)
	{
		bool result = false;
		if (MMSetting.MMState2AACS.Count > 0)
		{
			result = MMState switch
			{
				EState_MM.None => true, 
				EState_MM.FreeWalk => MMSetting.MMState2AACS.ContainsKey(EState_MM.FreeWalk) || MMSetting.MMState2AACS.ContainsKey(EState_MM.Free), 
				EState_MM.FreeRun => MMSetting.MMState2AACS.ContainsKey(EState_MM.FreeRun) || MMSetting.MMState2AACS.ContainsKey(EState_MM.Free), 
				EState_MM.FreeSprint => MMSetting.MMState2AACS.ContainsKey(EState_MM.FreeSprint) || MMSetting.MMState2AACS.ContainsKey(EState_MM.Free), 
				EState_MM.LockWalk => MMSetting.MMState2AACS.ContainsKey(EState_MM.LockWalk) || MMSetting.MMState2AACS.ContainsKey(EState_MM.Lock), 
				EState_MM.LockRun => MMSetting.MMState2AACS.ContainsKey(EState_MM.LockRun) || MMSetting.MMState2AACS.ContainsKey(EState_MM.Lock), 
				EState_MM.LockSprint => MMSetting.MMState2AACS.ContainsKey(EState_MM.LockSprint) || MMSetting.MMState2AACS.ContainsKey(EState_MM.Lock), 
				_ => MMSetting.MMState2AACS.ContainsKey(MMState), 
			};
		}
		return result;
	}

	public void GetDefaultLocalMotionJointData(AActor Owner, out List<FVector> JointLocation, out List<FVector> JointVelocity)
	{
		JointLocation = new List<FVector>();
		JointVelocity = new List<FVector>();
		if ((CurrentAA == null && CurrentAACS == null) || LastSocketLocation.Count == 0)
		{
			return;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		if (mesh == null)
		{
			return;
		}
		FTransform worldTransform = mesh.GetWorldTransform();
		if (!(CurrentAACS != null))
		{
			return;
		}
		foreach (FName referencedJoint in CurrentAACS.ReferencedJoints)
		{
			FVector item = (LastSocketLocation.ContainsKey(referencedJoint) ? MathLib.InverseTransformLocation(worldTransform, LastSocketLocation[referencedJoint]) : FVector.ZeroVector);
			LastSocketLocation.ContainsKey(referencedJoint);
			JointLocation.Add(item);
			FVector item2 = (LastSocketVelocity.ContainsKey(referencedJoint) ? (MathLib.InverseTransformDirection(worldTransform, LastSocketVelocity[referencedJoint].GetSafeNormal()) * LastSocketVelocity[referencedJoint].Size()) : FVector.ZeroVector);
			JointVelocity.Add(item2);
		}
	}

	private List<FSkeletonStructure> GetMotionJointData(UAnimSequence AnimSequence, float Position, in TArrayReadOnly<FName> ReferencedJoints)
	{
		List<FSkeletonStructure> list = new List<FSkeletonStructure>();
		list.Capacity = ReferencedJoints.Count;
		for (int i = 0; i < ReferencedJoints.Count; i++)
		{
			UMotionMatchingHelpers.GetAnimJointData(AnimSequence, Position, ReferencedJoints[i], out var DeliveredAnimationReferencesForSkelRef);
			list.Add(DeliveredAnimationReferencesForSkelRef);
		}
		return list;
	}

	private void UpdateAnimationAnalyzer(IBUC_ABPBasicData BasicData)
	{
		if ((CurrentAA != null || CurrentAACS != null) && !BasicData.bHasMoveInput)
		{
			return;
		}
		EState_MM eState_MM = MotionMatchingState;
		if (MMState2AACS.Count > 0)
		{
			if (eState_MM == EState_MM.FreeWalk || eState_MM == EState_MM.FreeRun || eState_MM == EState_MM.FreeSprint)
			{
				eState_MM = (MMState2AACS.ContainsKey(eState_MM) ? eState_MM : EState_MM.Free);
			}
			if (eState_MM == EState_MM.LockWalk || eState_MM == EState_MM.LockRun || eState_MM == EState_MM.LockSprint)
			{
				eState_MM = ((!MMState2AACS.ContainsKey(eState_MM)) ? EState_MM.Lock : eState_MM);
			}
			CurrentAACS = (MMState2AACS.ContainsKey(eState_MM) ? MMState2AACS[eState_MM] : null);
			CurrentAA = CurrentAACS;
		}
		else
		{
			CurrentAA = null;
			CurrentAACS = null;
		}
		bUseLMAnim = CurrentAA != null && CurrentAA.IsUseLMAnim();
	}

	private void UpdateRotateBSX(IBUC_ABPBasicData BasicData, float DeltaTime)
	{
		float num = (RotatorforMM.Yaw - LastFrameInputRotation.Yaw) / DeltaTime;
		if (FMath.Abs(num) <= 300f)
		{
			num *= FMath.Abs(BasicData.Speed) / BasicData.RunSpeed;
			RotateBSX = FMath.FInterpTo(RotateBSX, num / 200f, DeltaTime, 6f);
			RotateBSX = FMath.Clamp(RotateBSX, -1f, 1f);
		}
	}

	private void SetMMInputPlayerDirectionData(AActor Owner, IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null || bGUCharacterCS.World == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		if (mesh == null)
		{
			return;
		}
		MMPlayRate = 1f;
		float num = ChrData.MaxSpeed;
		FTransform worldTransform = mesh.GetWorldTransform();
		FVector accelerationVec = BasicData.AccelerationVec;
		UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.GetMovementComponent() as UBGUCharacterMovementComponent;
		if (uBGUCharacterMovementComponent != null && uBGUCharacterMovementComponent.IsInFollowState && bGUCharacterCS.AnimCapsule != null)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) - bGUCharacterCS.AnimCapsule.GetWorldLocation();
			FVector fVector2 = MathLib.InverseTransformDirection(new FTransform(BasicData.AccelerationVec.Rotation()), fVector.GetSafeNormal());
			if (IsInLockState() && FMath.Abs(fVector2.Y) >= 0.5f)
			{
				accelerationVec += fVector.GetSafeNormal() * 0.5;
			}
			num = (BasicData.AccelerationVec.IsNearlyZero() ? 0f : num);
			float num2 = ((uBGUCharacterMovementComponent.FollowClampDistanceOverride > 0f) ? uBGUCharacterMovementComponent.FollowClampDistanceOverride : uBGUCharacterMovementComponent.DefaultFollowClampDistance);
			float num3 = FMath.Clamp(fVector2.X * fVector.Size() / num2 * 0.5f, -0.5f, 0.5f);
			MMPlayRate = (BasicData.AccelerationVec.IsNearlyZero() ? 1f : (1f + num3));
		}
		float num4 = 400f;
		if (num != -1f)
		{
			num4 = num;
		}
		accelerationVec.Normalize();
		CachedInput = accelerationVec * num4;
		FVector location = worldTransform.GetLocation();
		FVector translation = location + CachedInput;
		bool flag = false;
		FRotator fRotator;
		if (IsInLockState() && !bMMLockUseFreeMode)
		{
			fRotator = InputRotationForLockState;
			flag = true;
		}
		else if (translation.Equals(location, 0.0010000000474974513))
		{
			USceneComponent attachParent = mesh.GetAttachParent();
			if (attachParent == null)
			{
				BGW_LogUtil.LogError("Mesh [{0}] has no attached component! Check PA config!!!", mesh.GetPathName());
			}
			fRotator = attachParent.GetWorldRotation();
		}
		else
		{
			fRotator = MathLib.Conv_VectorToRotator(CachedInput);
		}
		LastFrameInputRotation = RotatorforMM;
		FRotator relativeRotation = mesh.RelativeRotation;
		fRotator.Yaw += relativeRotation.Yaw;
		RotatorforMM = fRotator;
		FTransform mMInputDesiredTransform = new FTransform(fRotator, translation, FVector.OneVector);
		worldTransform.Scale3D = FVector.OneVector;
		mMInputDesiredTransform.NormalizeRotation();
		if (bUseLMAnim)
		{
			FTransform MMInput;
			if (flag)
			{
				FRotator rotation = MathLib.InverseTransformRotation(worldTransform, fRotator);
				MMInput = new FTransform(rotation, CachedInput);
			}
			else
			{
				MMInput = new FTransform(fRotator, CachedInput);
			}
			CheckInputChanged(Owner, in MMInput, DeltaTime);
		}
		MMInputDesiredTransform = mMInputDesiredTransform;
		MMInputRootTransform = worldTransform;
		MMInputStrength = num4;
	}

	private void CheckInputChanged(AActor Owner, in FTransform MMInput, float DeltaTime)
	{
		float num = FMath.Abs(MMInput.GetLocation().Size() - LastRecordMMInput.GetLocation().Size());
		float num2 = FMath.Abs((MMInput.GetLocation().Rotation() - LastRecordMMInput.GetLocation().Rotation()).GetNormalized().Yaw);
		float num3 = FMath.Abs((MMInput.Rotator() - LastRecordMMInput.Rotator()).GetNormalized().Yaw);
		bKeepMMInputUnchanged = num < 10f && num2 < 10f && num3 < 10f;
		if (!bKeepMMInputUnchanged)
		{
			LastRecordMMInput = MMInput;
		}
	}

	private void UpdateLockStateRotation(AActor Owner, IBUC_ABPCharacterData ChrData)
	{
		if (MovementData != null)
		{
			InputRotationForLockState = MovementData.TargetRot;
		}
	}
}
