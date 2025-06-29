using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPFootIKData : IBUC_ABPFootIKData
{
	private TWeakObject<AActor> mTouchIKTargetActor;

	private float IKScale;

	private readonly float HeightFixed = 10f;

	private readonly float FootLockInterpSpeed = 8f;

	private readonly float IKFootUpSpeed = 10f;

	private readonly float IKFootDownSpeed = 5f;

	private readonly float IKPelvisUpSpeed = 15f;

	private readonly float IKPelvisDownSpeed = 10f;

	private FName RootSocketName = B1GlobalFNames.root;

	private FName FootLSocketName = B1GlobalFNames.foot_l;

	private FName FootRSocketName = B1GlobalFNames.foot_r;

	private FName IKFootLSocketName = B1GlobalFNames.VB_root_foot_l;

	private FName IKFootRSocketName = B1GlobalFNames.VB_root_foot_r;

	private FName IKCalfLSocketName = B1GlobalFNames.VB_root_calf_l;

	private FName IKCalfRSocketName = B1GlobalFNames.VB_root_calf_r;

	private FName IKCalfLFanZuSocketName = B1GlobalFNames.VB_root_calf_l_fanzu;

	private FName IKCalfRFanZuSocketName = B1GlobalFNames.VB_root_calf_r_fanzu;

	private FName ThighLSocketName = B1GlobalFNames.thigh_l;

	private FName ThighRSocketName = B1GlobalFNames.thigh_r;

	private FName HandLSocketName = B1GlobalFNames.hand_l;

	private FName HandRSocketName = B1GlobalFNames.hand_r;

	private FName IKHandLSocketName = B1GlobalFNames.VB_root_hand_l;

	private FName IKHandRSocketName = B1GlobalFNames.VB_root_hand_r;

	private FName IKLowerarmLSocketName = B1GlobalFNames.VB_root_lowerarm_l;

	private FName IKLowerarmRSocketName = B1GlobalFNames.VB_root_lowerarm_r;

	private FName UpperarmLSocketName = B1GlobalFNames.upperarm_l;

	private FName UpperarmRSocketName = B1GlobalFNames.upperarm_r;

	private string OwnerName;

	private bool bFootFanZu;

	private FVector IKOffsetRightFoot = FVector.ZeroVector;

	private FVector IKOffsetLeftFoot = FVector.ZeroVector;

	private FVector IKOffsetRightForefoot = FVector.ZeroVector;

	private FVector IKOffsetLeftForefoot = FVector.ZeroVector;

	private bool bRightFootOffsetValid;

	private bool bLeftFootOffsetValid;

	private bool bRightForefootOffsetValid;

	private bool bLeftForefootOffsetValid;

	private FVector IKOffsetRightFootTarget = FVector.ZeroVector;

	private FVector IKOffsetLeftFootTarget = FVector.ZeroVector;

	private FVector IKOffsetRightForefootTarget = FVector.ZeroVector;

	private FVector IKOffsetLeftForefootTarget = FVector.ZeroVector;

	private FVector IKHitLocationRightFoot = FVector.ZeroVector;

	private FVector IKHitLocationLeftFoot = FVector.ZeroVector;

	private FVector IKEffectorLeftForefoot;

	private FVector IKEffectorRightForefoot;

	private FVector IKJoint_LeftForefoot;

	private FVector IKJoint_RightForefoot;

	private float IKRightForefootAlpha;

	private float IKLeftForefootAlpha;

	private UnorderedDict<ETouchIKType, FTouchIKInfo> MapTouchIKInfo;

	private Dictionary<int, b1.FFootIKLineTraceInfo> MapLineTraceInfo;

	private bool EnableSpineIK;

	public bool bEnableIK { get; set; }

	public bool bEnableForefootIK { get; set; }

	public bool bEnableQuadrupedIK { get; set; }

	public bool bActiveFootIK { get; set; }

	public bool bActiveForefootIK { get; set; }

	public bool bActiveTouchIK { get; set; }

	public bool bRHandUseFBIK { get; set; }

	public bool bLHandUseFBIK { get; set; }

	public bool bFootUseFBIK { get; set; }

	public bool bLeftFootLock { get; set; }

	public bool bRightFootLock { get; set; }

	public float IKTraceDistance { get; set; }

	public float IKCheckDistance { get; set; }

	public EFootIKType FootIKType { get; set; }

	public FVector IKEffectorLeftFoot { get; set; }

	public FVector IKEffectorRightFoot { get; set; }

	public FVector IKEffectorLFoot_MeshSpace { get; set; }

	public FVector IKEffectorRFoot_MeshSpace { get; set; }

	public FVector IKEffectorLFoot_WorldSpace { get; set; }

	public FVector IKEffectorRFoot_WorldSpace { get; set; }

	public FVector IKJoint_LeftFoot { get; set; }

	public FVector IKJoint_RightFoot { get; set; }

	public FVector IKJointLFoot_MeshSpace { get; set; }

	public FVector IKJointRFoot_MeshSpace { get; set; }

	public float IKRightFootAlpha { get; set; }

	public float IKLeftFootAlpha { get; set; }

	public FVector LeftFootLockPos { get; set; }

	public FVector RightFootLockPos { get; set; }

	public float LeftFootLockAlpha { get; set; }

	public float RightFootLockAlpha { get; set; }

	public float LeftFootLockZAlpha { get; set; }

	public float RightFootLockZAlpha { get; set; }

	public float LeftFootLockTargetAlpha { get; set; }

	public float RightFootLockTargetAlpha { get; set; }

	public float IKFootHeight { get; set; }

	public float IKPelvisOffset { get; set; }

	public float IKPelvisOffsetScaled { get; set; }

	public float IKNeckOffset { get; set; }

	public float IKNeckOffsetScaled { get; set; }

	public FVector IKEffectorLeftHand { get; set; }

	public FVector IKEffectorLHand_MeshSpace { get; set; }

	public FVector IKEffectorRightHand { get; set; }

	public FVector IKEffectorRHand_MeshSpace { get; set; }

	public FVector IKJointLeftHand { get; set; }

	public FVector IKJointRightHand { get; set; }

	public float IKAlphaLeftHand { get; set; }

	public float IKAlphaRightHand { get; set; }

	public bool bIKOffsetValid { get; set; }

	public bool bCanGameThreadUpdateByOptimize { get; set; }

	public bool bCanThreadSafeUpdateAnimationByOptimize { get; set; }

	public bool bFirstTimeThreadSafeUpdateAnimation { get; set; }

	public bool bEnableDebug { get; set; }

	public bool bFootIKManualUpdateMode { get; set; }

	public AActor TouchIKTargetActor
	{
		get
		{
			return mTouchIKTargetActor.Get();
		}
		set
		{
			mTouchIKTargetActor.Set(value);
		}
	}

	public void Init(AActor Owner, BUABPSettingData Setting)
	{
		BUABPFootIKSettingData footIKSetting = Setting.FootIKSetting;
		BUABPSpineIKSettingData spineIKSetting = Setting.SpineIKSetting;
		OwnerName = Owner.GetName();
		bIKOffsetValid = false;
		bFirstTimeThreadSafeUpdateAnimation = true;
		bEnableDebug = GSGameplayCVar.CVar_AnimEnableFootIKDebug.GetValueInGameThread() == 1;
		bEnableQuadrupedIK = footIKSetting.bEnableQuadrupedIK;
		bEnableIK = footIKSetting.bEnableIK || bEnableQuadrupedIK;
		bEnableForefootIK = footIKSetting.bEnableForefootIK || bEnableQuadrupedIK;
		bFootUseFBIK = footIKSetting.bFootUseFBIK;
		EnableSpineIK = spineIKSetting.bEnableSpineIK;
		FootIKType = (EnableSpineIK ? EFootIKType.SurfaceNormal : EFootIKType.Normal);
		IKTraceDistance = 15f;
		IKLeftFootAlpha = 1f;
		IKRightFootAlpha = 1f;
		IKLeftForefootAlpha = 1f;
		IKRightForefootAlpha = 1f;
		IKScale = 1f;
		MapTouchIKInfo = new UnorderedDict<ETouchIKType, FTouchIKInfo>();
		MapLineTraceInfo = new Dictionary<int, b1.FFootIKLineTraceInfo>();
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		UCapsuleComponent capsuleComponent = aCharacter.CapsuleComponent;
		if (capsuleComponent != null)
		{
			float scaledCapsuleHalfHeight = capsuleComponent.GetScaledCapsuleHalfHeight();
			float num = 0.6f;
			IKTraceDistance = scaledCapsuleHalfHeight * num + HeightFixed;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		if (!(mesh == null))
		{
			if (IKFootHeight == 0f)
			{
				IKFootHeight = mesh.GetRefPosePosition(mesh.GetBoneIndex(IKFootRSocketName)).Z;
			}
			bFootFanZu = !mesh.GetParentBone(mesh.GetParentBone(FootLSocketName)).Equals(ThighLSocketName);
		}
	}

	public void Update(AActor Owner, IBUC_ABPCharacterData ChrData, IBUC_ABPSpecialMoveData SpecialMoveData, float DeltaTime)
	{
		bEnableDebug = GSGameplayCVar.CVar_AnimEnableFootIKDebug.GetValueInGameThread() == 1;
		IKScale = ChrData.ActorScale3D.Z;
		if (IKScale == 0f)
		{
			IKScale = 1f;
		}
		UpdateActiveState();
		UpdateFootIKType(SpecialMoveData);
		UpdateLockFootAlpha(DeltaTime);
	}

	public void GameThreadUpdate(AActor Owner, float DeltaTime)
	{
		if (!bCanGameThreadUpdateByOptimize || bFootIKManualUpdateMode)
		{
			return;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		if (!(mesh == null))
		{
			if (bActiveFootIK)
			{
				ReqeustIKFootLineTrace(EBUHandFootType.RightFoot, ref IKFootRSocketName, mesh, IKTraceDistance, IKTraceDistance);
				ReqeustIKFootLineTrace(EBUHandFootType.LeftFoot, ref IKFootLSocketName, mesh, IKTraceDistance, IKTraceDistance);
			}
			else
			{
				bRightFootOffsetValid = true;
				bLeftFootOffsetValid = true;
			}
			if (bActiveForefootIK)
			{
				ReqeustIKFootLineTrace(EBUHandFootType.RightHand, ref IKHandRSocketName, mesh, IKTraceDistance, IKTraceDistance);
				ReqeustIKFootLineTrace(EBUHandFootType.LeftHand, ref IKHandLSocketName, mesh, IKTraceDistance, IKTraceDistance);
			}
			else
			{
				bRightForefootOffsetValid = true;
				bLeftForefootOffsetValid = true;
			}
			if (bEnableDebug)
			{
				float radius = aCharacter.CapsuleComponent.GetScaledCapsuleRadius() / 4f;
				FLinearColor lineColor = (bLeftFootLock ? FLinearColor.DarkRed : FLinearColor.Red);
				FLinearColor lineColor2 = (bRightFootLock ? FLinearColor.DarkRed : FLinearColor.Red);
				USystemLibrary.DrawDebugSphere(Owner, IKEffectorLFoot_WorldSpace, radius, 8, lineColor, 0f, 3f);
				USystemLibrary.DrawDebugSphere(Owner, IKEffectorRFoot_WorldSpace, radius, 8, lineColor2, 0f, 3f);
			}
		}
	}

	public void ThreadSafeUpdateAnimation(AActor Owner, float DeltaTime)
	{
		if ((!bFirstTimeThreadSafeUpdateAnimation && !bCanThreadSafeUpdateAnimationByOptimize) || bFootIKManualUpdateMode)
		{
			return;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		if (!(mesh == null))
		{
			UpdateFootIK(Owner, mesh, DeltaTime);
			UpdateTouchIK(mesh);
			UpdateHandIK();
			if (bRightFootOffsetValid && bLeftFootOffsetValid && bRightForefootOffsetValid && bLeftForefootOffsetValid)
			{
				bIKOffsetValid = true;
			}
			bFirstTimeThreadSafeUpdateAnimation = false;
		}
	}

	private void UpdateFootIKType(IBUC_ABPSpecialMoveData SpecialMoveData)
	{
		if (bActiveFootIK)
		{
			if (SpecialMoveData.SpecialMovementMode == ESpecialMovementMode.GlideMove)
			{
				FootIKType = EFootIKType.StickToSurface;
			}
			else if (EnableSpineIK)
			{
				FootIKType = EFootIKType.SurfaceNormal;
			}
			else
			{
				FootIKType = EFootIKType.Normal;
			}
		}
	}

	private void UpdateLockFootAlpha(float DeltaTime)
	{
		LeftFootLockAlpha = FMath.FInterpConstantTo(LeftFootLockAlpha, LeftFootLockTargetAlpha, DeltaTime, FootLockInterpSpeed);
		RightFootLockAlpha = FMath.FInterpConstantTo(RightFootLockAlpha, RightFootLockTargetAlpha, DeltaTime, FootLockInterpSpeed);
	}

	public void SetTouchIKInfo(ETouchIKType Type, FVector IKOffset, FVector EffectorOffset, float Alpha)
	{
		FTouchIKInfo value = new FTouchIKInfo
		{
			MeshSpaceIKOffset = IKOffset,
			WorldSpaceEffectorOffset = EffectorOffset,
			TouchIKAlpha = Alpha
		};
		MapTouchIKInfo.Set(Type, value);
	}

	public void SetLeftFootLockAlpha(USkeletalMeshComponent Mesh, float FootLockAlpha)
	{
		bool flag = FootLockAlpha >= 0.5f;
		LeftFootLockTargetAlpha = ((FootLockAlpha >= 0.5f) ? FootLockAlpha : 0f);
		if (bLeftFootLock != flag)
		{
			bLeftFootLock = flag;
			if (bLeftFootLock)
			{
				LeftFootLockPos = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref FootLSocketName);
			}
		}
	}

	public void SetRightFootLockAlpha(USkeletalMeshComponent Mesh, float FootLockAlpha)
	{
		bool flag = FootLockAlpha >= 0.5f;
		RightFootLockTargetAlpha = ((FootLockAlpha >= 0.5f) ? FootLockAlpha : 0f);
		if (bRightFootLock != flag)
		{
			bRightFootLock = flag;
			if (bRightFootLock)
			{
				RightFootLockPos = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref FootRSocketName);
			}
		}
	}

	public void ManualUpdateFootIKByZOffset(ACharacter OwnerChr, in FVector Offset)
	{
		USkeletalMeshComponent mesh = OwnerChr.Mesh;
		if (bActiveFootIK)
		{
			IKPelvisOffset -= Offset.Z;
			IKNeckOffset -= Offset.Z;
			IKPelvisOffsetScaled = IKPelvisOffset / IKScale;
			IKNeckOffsetScaled = IKNeckOffset / IKScale;
			IKOffsetLeftFoot -= Offset;
			IKOffsetRightFoot -= Offset;
			IKOffsetLeftFootTarget -= Offset;
			IKOffsetRightFootTarget -= Offset;
			IKOffsetLeftForefoot -= Offset;
			IKOffsetRightForefoot -= Offset;
			IKOffsetLeftForefootTarget -= Offset;
			IKOffsetRightForefootTarget -= Offset;
			FTransform t = BGUFuncLibComponentCS.BGUGetSocketTransform(mesh, ref IKFootRSocketName);
			FTransform t2 = BGUFuncLibComponentCS.BGUGetSocketTransform(mesh, ref IKFootLSocketName);
			FVector fVector = MathLib.TransformLocation(t, IKEffectorRightFoot);
			FVector fVector2 = MathLib.TransformLocation(t2, IKEffectorLeftFoot);
			IKEffectorRightFoot = MathLib.InverseTransformLocation(t, fVector - Offset);
			IKEffectorLeftFoot = MathLib.InverseTransformLocation(t2, fVector2 - Offset);
			IKJoint_RightFoot -= Offset;
			IKJoint_LeftFoot -= Offset;
			IKEffectorRFoot_MeshSpace -= Offset;
			IKEffectorLFoot_MeshSpace -= Offset;
			IKJointRFoot_MeshSpace -= Offset;
			IKJointLFoot_MeshSpace -= Offset;
			IKEffectorRFoot_WorldSpace -= Offset;
			IKEffectorLFoot_WorldSpace -= Offset;
		}
		if (bActiveForefootIK)
		{
			FTransform t3 = BGUFuncLibComponentCS.BGUGetSocketTransform(mesh, ref IKHandRSocketName);
			FTransform t4 = BGUFuncLibComponentCS.BGUGetSocketTransform(mesh, ref IKHandLSocketName);
			FVector fVector3 = MathLib.TransformLocation(t3, IKEffectorRightForefoot);
			FVector fVector4 = MathLib.TransformLocation(t4, IKEffectorLeftForefoot);
			IKEffectorRightForefoot = MathLib.InverseTransformLocation(t3, fVector3 - Offset);
			IKEffectorLeftForefoot = MathLib.InverseTransformLocation(t4, fVector4 - Offset);
			IKJoint_RightForefoot -= Offset;
			IKJoint_LeftForefoot -= Offset;
			IKEffectorRightHand = IKEffectorRightForefoot;
			IKEffectorLeftHand = IKEffectorLeftForefoot;
			IKJointRightHand = IKJoint_RightForefoot;
			IKJointLeftHand = IKJoint_LeftForefoot;
		}
	}

	private void ReqeustIKFootLineTrace(EBUHandFootType HandFootType, ref FName IKFootSocketName, USkeletalMeshComponent Mesh, float TraceDisUp, float TraceDisDown)
	{
		FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKFootSocketName);
		FVector fVector2 = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref RootSocketName);
		EFootIKType footIKType = FootIKType;
		FVector traceCenterPos = ((footIKType == EFootIKType.Normal || (uint)(footIKType - 1) > 1u) ? new FVector(fVector.X, fVector.Y, fVector2.Z) : new FVector(fVector.X, fVector.Y, fVector.Z - IKFootHeight));
		FVector start = new FVector(traceCenterPos.X, traceCenterPos.Y, traceCenterPos.Z + TraceDisUp);
		FVector end = new FVector(traceCenterPos.X, traceCenterPos.Y, traceCenterPos.Z - TraceDisDown);
		b1.FFootIKLineTraceInfo value = new b1.FFootIKLineTraceInfo
		{
			HandFootType = HandFootType,
			TraceCenterPos = traceCenterPos
		};
		int num = b1.BGS_LineTraceMgr.RequestNewUniqueID_Sync();
		BGS_EventCollectionCS.Get(Mesh)?.Evt_RequestAsyncLineTrace_ByChannelSingle.Invoke(num, start, end, ECollisionChannel.ECC_GameTraceChannel17, null, bTraceComplex: true, OnLineTraceFinished);
		MapLineTraceInfo.Add(num, value);
	}

	private void OnLineTraceFinished(Result_LineTrace Result)
	{
		if (!bFootIKManualUpdateMode && MapLineTraceInfo.TryGetValue(Result.ReqID, out var value))
		{
			FVector fVector;
			if (!Result.bHasResult())
			{
				fVector = value.TraceCenterPos;
			}
			else
			{
				FHitResult fHitResult = Result.HitResults[0];
				fVector = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in fHitResult.ImpactPoint);
			}
			FVector fVector2 = fVector;
			FVector fVector3 = fVector2 - value.TraceCenterPos;
			float x = (fVector3.Y = 0f);
			fVector3.X = x;
			switch (value.HandFootType)
			{
			case EBUHandFootType.LeftHand:
				IKOffsetLeftForefootTarget = fVector3;
				bLeftForefootOffsetValid = true;
				break;
			case EBUHandFootType.RightHand:
				IKOffsetRightForefootTarget = fVector3;
				bRightForefootOffsetValid = true;
				break;
			case EBUHandFootType.LeftFoot:
				IKOffsetLeftFootTarget = fVector3;
				IKHitLocationLeftFoot = fVector2;
				bLeftFootOffsetValid = true;
				break;
			case EBUHandFootType.RightFoot:
				IKOffsetRightFootTarget = fVector3;
				IKHitLocationRightFoot = fVector2;
				bRightFootOffsetValid = true;
				break;
			}
			_ = bEnableDebug;
			MapLineTraceInfo.Remove(Result.ReqID);
		}
	}

	private FVector CalcIKFootOffset(in FVector IKFootOffsetTarget, in FVector CurIKFootOffset, float DeltaTime)
	{
		float num = ((IKFootOffsetTarget.Z > CurIKFootOffset.Z) ? IKFootUpSpeed : IKFootDownSpeed);
		if (bEnableQuadrupedIK)
		{
			num *= 2f;
		}
		if (FootIKType == EFootIKType.StickToSurface)
		{
			num = 30f;
		}
		if (!bIKOffsetValid)
		{
			return IKFootOffsetTarget;
		}
		return FMath.VInterpTo(CurIKFootOffset, IKFootOffsetTarget, DeltaTime, num);
	}

	private void UpdateIKEffectorAndJointTarget(out FVector IKEffector, out FVector IKJointTarget, out FVector IKEffectorMeshSpace, out FVector IKJointTargetMeshSpace, out FVector IKEffectorWorldSpace, ref FVector IKFootOffset, in FVector IKFootOffsetTarget, float InIKPelvisOffset, in FVector FootLockPos, float FootLockAlpha, ref FName IKFootSocketName, ref FName IKKneeSocketName, ref FName IKFanZuSocketName, ref FName ThighSocketName, bool bUseFanZu, AActor Owner, USkeletalMeshComponent Mesh, float DeltaTime)
	{
		FName SocketName = (bUseFanZu ? IKFanZuSocketName : IKFootSocketName);
		FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref ThighSocketName);
		FVector fVector2 = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref SocketName);
		FVector fVector3 = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKKneeSocketName);
		fVector2.Set(fVector2.X, fVector2.Y, fVector2.Z + InIKPelvisOffset);
		fVector3.Set(fVector3.X, fVector3.Y, fVector3.Z + InIKPelvisOffset);
		FVector fVector4 = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKFootSocketName) + IKFootOffset;
		_ = bEnableDebug;
		if (FootLockAlpha > 0f)
		{
			FVector fVector5 = FootLockPos;
			fVector5.Z = fVector4.Z;
			float num = FVector.Dist(fVector, fVector3) + FVector.Dist(fVector3, fVector2);
			if (FVector.Dist(fVector, fVector5) > num)
			{
				FVector fVector6 = fVector;
				fVector6.Z = fVector4.Z;
				float value = fVector.Z - fVector4.Z;
				fVector5 = fVector6 + (fVector5 - fVector6).GetSafeNormal2D() * FMath.Sqrt(FMath.Abs(FMath.Square(num) - FMath.Square(value)));
			}
			if (FootLockAlpha >= 1f)
			{
				fVector4 = fVector5;
			}
			else if (FootLockAlpha > 0f)
			{
				fVector4 += (fVector5 - fVector4) * FootLockAlpha;
			}
		}
		FVector fVector7 = MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), fVector4);
		IKEffectorMeshSpace = fVector7;
		IKEffectorWorldSpace = fVector4;
		_ = bEnableDebug;
		IKEffector = MathLib.InverseTransformLocation(BGUFuncLibComponentCS.BGUGetSocketTransform(Mesh, ref IKFootSocketName), fVector4);
		_ = bEnableDebug;
		FVector fVector8 = FVector.CrossProduct(FVector.CrossProduct(fVector - fVector2, fVector3 - fVector2), fVector - fVector2).Normal();
		FVector fVector9 = (fVector + fVector2) / 2.0 + fVector8 * 1000.0;
		fVector9.Set(fVector9.X, fVector9.Y, fVector9.Z + 100f);
		IKJointTarget = fVector9;
		IKJointTargetMeshSpace = MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), IKJointTarget);
	}

	private void UpdateActiveState()
	{
		bActiveFootIK = bEnableIK;
		bActiveForefootIK = bEnableForefootIK && !bActiveTouchIK;
	}

	private void UpdateFootIK(AActor Owner, USkeletalMeshComponent Mesh, float DeltaTime)
	{
		float num = 0f;
		float num2 = 0f;
		FVector IKFootOffsetTarget = IKOffsetRightFootTarget;
		FVector IKFootOffsetTarget2 = IKOffsetLeftFootTarget;
		if (bActiveFootIK)
		{
			if (!IKOffsetRightFootTarget.IsZero() || !IKOffsetLeftFootTarget.IsZero())
			{
				if (IKOffsetRightFootTarget.IsZero())
				{
					IKFootOffsetTarget = (IKOffsetRightFootTarget = new FVector(0.0, 0.0, IKPelvisOffset));
				}
				if (IKOffsetLeftFootTarget.IsZero())
				{
					IKFootOffsetTarget2 = (IKOffsetLeftFootTarget = new FVector(0.0, 0.0, IKPelvisOffset));
				}
			}
			if (RightFootLockZAlpha > 0f)
			{
				float num3 = (IKHitLocationRightFoot - BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKFootRSocketName)).Z + IKFootHeight;
				if (RightFootLockZAlpha >= 1f)
				{
					IKFootOffsetTarget.Z = num3;
				}
				else
				{
					IKFootOffsetTarget.Z = IKOffsetRightFootTarget.Z + (num3 - IKOffsetRightFootTarget.Z) * RightFootLockZAlpha;
				}
			}
			if (LeftFootLockZAlpha > 0f)
			{
				float num4 = (IKHitLocationLeftFoot - BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref IKFootLSocketName)).Z + IKFootHeight;
				if (LeftFootLockZAlpha >= 1f)
				{
					IKFootOffsetTarget2.Z = num4;
				}
				else
				{
					IKFootOffsetTarget2.Z = IKOffsetLeftFootTarget.Z + (num4 - IKOffsetLeftFootTarget.Z) * LeftFootLockZAlpha;
				}
			}
			if (FMath.Abs(IKFootOffsetTarget.Z - IKFootOffsetTarget2.Z) > IKTraceDistance)
			{
				float z = (IKFootOffsetTarget.Z = FMath.Min(IKFootOffsetTarget.Z, IKFootOffsetTarget2.Z));
				IKFootOffsetTarget2.Z = z;
			}
			IKOffsetRightFoot = CalcIKFootOffset(in IKFootOffsetTarget, in IKOffsetRightFoot, DeltaTime);
			IKOffsetLeftFoot = CalcIKFootOffset(in IKFootOffsetTarget2, in IKOffsetLeftFoot, DeltaTime);
			num = FMath.Min(IKOffsetLeftFoot.Z, IKOffsetRightFoot.Z);
			if (!bEnableDebug)
			{
			}
		}
		else
		{
			IKOffsetRightFoot = (IKOffsetRightFootTarget = FVector.ZeroVector);
			IKOffsetLeftFoot = (IKOffsetLeftFootTarget = FVector.ZeroVector);
			num = 0f;
		}
		if (bActiveForefootIK)
		{
			if (!IKOffsetRightForefootTarget.IsZero() || !IKOffsetLeftForefootTarget.IsZero())
			{
				if (IKOffsetRightForefootTarget.IsZero())
				{
					IKOffsetRightForefootTarget = new FVector(0.0, 0.0, IKNeckOffset);
				}
				if (IKOffsetLeftForefootTarget.IsZero())
				{
					IKOffsetLeftForefootTarget = new FVector(0.0, 0.0, IKNeckOffset);
				}
			}
			if (FMath.Abs(IKOffsetRightForefootTarget.Z - IKOffsetLeftForefootTarget.Z) > IKTraceDistance)
			{
				float z2 = FMath.Min(IKOffsetRightForefootTarget.Z, IKOffsetLeftForefootTarget.Z);
				IKOffsetRightForefootTarget.Z = z2;
				IKOffsetLeftForefootTarget.Z = z2;
			}
			IKOffsetRightForefoot = CalcIKFootOffset(in IKOffsetRightForefootTarget, in IKOffsetRightForefoot, DeltaTime);
			IKOffsetLeftForefoot = CalcIKFootOffset(in IKOffsetLeftForefootTarget, in IKOffsetLeftForefoot, DeltaTime);
			num2 = FMath.Min(IKOffsetLeftForefoot.Z, IKOffsetRightForefoot.Z);
		}
		else
		{
			IKOffsetRightForefoot = (IKOffsetRightForefootTarget = FVector.ZeroVector);
			IKOffsetLeftForefoot = (IKOffsetLeftForefootTarget = FVector.ZeroVector);
			num2 = 0f;
		}
		float num6;
		float num7;
		if (bEnableQuadrupedIK)
		{
			num6 = num;
			num7 = num2;
		}
		else
		{
			num6 = ((bEnableIK && bEnableForefootIK) ? FMath.Min(num, num2) : (bEnableIK ? num : (bEnableForefootIK ? num2 : 0f)));
			num7 = num6;
		}
		float num8 = ((num6 > IKPelvisOffset) ? IKPelvisUpSpeed : IKPelvisDownSpeed);
		float num9 = ((num7 > IKNeckOffset) ? IKPelvisUpSpeed : IKPelvisDownSpeed);
		if (bEnableQuadrupedIK)
		{
			num8 *= 2f;
			num9 *= 2f;
		}
		IKPelvisOffset = (bIKOffsetValid ? FMath.FInterpTo(IKPelvisOffset, num6, DeltaTime, num8) : num6);
		IKNeckOffset = (bIKOffsetValid ? FMath.FInterpTo(IKNeckOffset, num7, DeltaTime, num9) : num7);
		IKPelvisOffsetScaled = IKPelvisOffset / IKScale;
		IKNeckOffsetScaled = IKNeckOffset / IKScale;
		if (bActiveFootIK)
		{
			UpdateIKEffectorAndJointTarget(out var IKEffector, out var IKJointTarget, out var IKEffectorMeshSpace, out var IKJointTargetMeshSpace, out var IKEffectorWorldSpace, ref IKOffsetRightFoot, in IKFootOffsetTarget, IKPelvisOffset, RightFootLockPos, RightFootLockAlpha, ref IKFootRSocketName, ref IKCalfRSocketName, ref IKCalfRFanZuSocketName, ref ThighRSocketName, bFootFanZu, Owner, Mesh, DeltaTime);
			UpdateIKEffectorAndJointTarget(out var IKEffector2, out var IKJointTarget2, out var IKEffectorMeshSpace2, out var IKJointTargetMeshSpace2, out var IKEffectorWorldSpace2, ref IKOffsetLeftFoot, in IKFootOffsetTarget2, IKPelvisOffset, LeftFootLockPos, LeftFootLockAlpha, ref IKFootLSocketName, ref IKCalfLSocketName, ref IKCalfLFanZuSocketName, ref ThighLSocketName, bFootFanZu, Owner, Mesh, DeltaTime);
			IKEffectorRightFoot = IKEffector;
			IKEffectorLeftFoot = IKEffector2;
			IKJoint_RightFoot = IKJointTarget;
			IKJoint_LeftFoot = IKJointTarget2;
			IKEffectorRFoot_MeshSpace = IKEffectorMeshSpace;
			IKEffectorLFoot_MeshSpace = IKEffectorMeshSpace2;
			IKJointRFoot_MeshSpace = IKJointTargetMeshSpace;
			IKJointLFoot_MeshSpace = IKJointTargetMeshSpace2;
			IKEffectorRFoot_WorldSpace = IKEffectorWorldSpace;
			IKEffectorLFoot_WorldSpace = IKEffectorWorldSpace2;
		}
		if (bActiveForefootIK)
		{
			UpdateIKEffectorAndJointTarget(out var IKEffector3, out var IKJointTarget3, out var _, out var _, out var _, ref IKOffsetRightForefoot, in IKOffsetRightForefootTarget, IKNeckOffset, in FVector.ZeroVector, 0f, ref IKHandRSocketName, ref IKLowerarmRSocketName, ref IKHandRSocketName, ref UpperarmRSocketName, bUseFanZu: false, Owner, Mesh, DeltaTime);
			UpdateIKEffectorAndJointTarget(out var IKEffector4, out var IKJointTarget4, out var _, out var _, out var _, ref IKOffsetLeftForefoot, in IKOffsetLeftForefootTarget, IKNeckOffset, in FVector.ZeroVector, 0f, ref IKHandLSocketName, ref IKLowerarmLSocketName, ref IKHandLSocketName, ref UpperarmLSocketName, bUseFanZu: false, Owner, Mesh, DeltaTime);
			IKEffectorRightForefoot = IKEffector3;
			IKEffectorLeftForefoot = IKEffector4;
			IKJoint_RightForefoot = IKJointTarget3;
			IKJoint_LeftForefoot = IKJointTarget4;
		}
	}

	private void UpdateTouchIK(USkeletalMeshComponent Mesh)
	{
		if (!bActiveTouchIK)
		{
			return;
		}
		MapTouchIKInfo.BeginItr();
		ETouchIKType oKey;
		FTouchIKInfo oVal;
		while (MapTouchIKInfo.NextItr(out oKey, out oVal))
		{
			FName SocketName;
			FName SocketName2;
			FName SocketName3;
			if (oKey == ETouchIKType.LeftHand || oKey != ETouchIKType.RightHand)
			{
				SocketName = IKHandLSocketName;
				SocketName2 = IKLowerarmLSocketName;
				SocketName3 = UpperarmLSocketName;
			}
			else
			{
				SocketName = IKHandRSocketName;
				SocketName2 = IKLowerarmRSocketName;
				SocketName3 = UpperarmRSocketName;
			}
			FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref SocketName);
			FVector fVector2 = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref SocketName2);
			FVector fVector3 = BGUFuncLibComponentCS.BGUGetSocketLocation(Mesh, ref SocketName3);
			FVector fVector4 = MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), fVector);
			FVector fVector5 = MathLib.TransformLocation(Mesh.GetWorldTransform(), fVector4 + oVal.MeshSpaceIKOffset);
			FVector fVector6 = FVector.CrossProduct(FVector.CrossProduct(fVector3 - fVector, fVector2 - fVector), fVector3 - fVector);
			fVector6.Normalize();
			FVector touchIKJointTargetLocation = (fVector3 + fVector) / 2.0 + fVector6 * (fVector - fVector2).Size();
			FVector location = fVector5 + oVal.WorldSpaceEffectorOffset;
			oVal.TouchIKEffectorLocation = MathLib.InverseTransformLocation(BGUFuncLibComponentCS.BGUGetSocketTransform(Mesh, ref SocketName), location);
			oVal.TouchIKJointTargetLocation = touchIKJointTargetLocation;
			oVal.MeshSpaceIKOffset = MathLib.InverseTransformLocation(Mesh.GetWorldTransform(), location);
			MapTouchIKInfo.Set(oKey, oVal);
		}
	}

	private void UpdateHandIK()
	{
		if (bActiveTouchIK)
		{
			MapTouchIKInfo.Find(ETouchIKType.LeftHand, out var output);
			IKEffectorLeftHand = output.TouchIKEffectorLocation;
			IKEffectorLHand_MeshSpace = output.MeshSpaceIKOffset;
			IKJointLeftHand = output.TouchIKJointTargetLocation;
			IKAlphaLeftHand = output.TouchIKAlpha;
			MapTouchIKInfo.Find(ETouchIKType.RightHand, out var output2);
			IKEffectorRightHand = output2.TouchIKEffectorLocation;
			IKEffectorRHand_MeshSpace = output2.MeshSpaceIKOffset;
			IKJointRightHand = output2.TouchIKJointTargetLocation;
			IKAlphaRightHand = output2.TouchIKAlpha;
		}
		else if (bActiveForefootIK)
		{
			IKEffectorLeftHand = IKEffectorLeftForefoot;
			IKEffectorRightHand = IKEffectorRightForefoot;
			IKJointLeftHand = IKJoint_LeftForefoot;
			IKJointRightHand = IKJoint_RightForefoot;
			IKAlphaLeftHand = IKLeftForefootAlpha;
			IKAlphaRightHand = IKRightForefootAlpha;
		}
	}
}
