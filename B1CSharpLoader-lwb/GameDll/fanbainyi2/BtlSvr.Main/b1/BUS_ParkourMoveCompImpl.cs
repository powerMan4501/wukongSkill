using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ParkourMoveCompImpl : UActorCompBaseCS
{
	private b1.BUC_ParkourMoveData ParkourMoveData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_MovementData MovementData;

	private IBUC_TickRateData TickRateData;

	private IBUC_BuffData BuffData;

	private IBUC_ABPBasicData BasicData;

	private UCapsuleComponent CapsuleComp;

	private UCharacterMovementComponent MovementComp;

	private const float Start_Highest_MaxDistanceRatio = 0.5f;

	private const float HeightTypeLowRatio = 1f;

	private const float HeightTypeHighRatio = 3f;

	private const int LandCheckSphereCount = 10;

	private const bool bDrawDebug = false;

	private EDrawDebugTrace bDrawDebugType;

	public override void OnAttach()
	{
		ParkourMoveData = RequireWritableData<b1.BUC_ParkourMoveData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		BasicData = RequireReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>();
		base.BUSEventCollection.Evt_SetParkourMoveEnabled += new Del_Void_Bool(OnSetParkourMoveEnabled);
		base.BUSEventCollection.Evt_ParkourCurveMove += new Del_Void_FloatFloatFloat(OnParkourCurveMove);
		base.BUSEventCollection.Evt_SetParkourAnimTotalMovement += new Del_Void_FloatFloatFloat(OnSetCurParkourAnimTotalMovement);
		base.BUSEventCollection.Evt_SetParkourMoveAnimState += new Del_SetParkourMoveAnimState(OnSetParkourMoveAnimState);
	}

	public override void PreBeginPlay()
	{
		Init();
		InitParkourMoveData();
	}

	private void InitParkourMoveData()
	{
		if (!(GetOwner() as ACharacter == null))
		{
			if (MovementComp != null)
			{
				_ = MovementComp.MaxStepHeight;
			}
			ParkourMoveData.ParkourMaxDistance = 300f;
			float num = 3f;
			ParkourMoveData.ParkourStartMaxHeight -= num;
			ParkourMoveData.ParkourStartMinHeight -= num;
			ParkourMoveData.ParkourStartMinHeight = FMath.Max(ParkourMoveData.ParkourStartMinHeight, ParkourMoveData.CapsuleRadius - 5f);
			ParkourMoveData.ListLandCheckInfo = new List<b1.FParkourLandCheckInfo>();
			ParkourMoveData.LandCheckSphereRadius = ParkourMoveData.ParkourMaxDistance / 10f / 2f;
		}
	}

	private void Init()
	{
		OnSetParkourMoveEnabled(bIsEnabled: true);
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null))
		{
			MovementComp = aCharacter.GetMovementComponent() as UCharacterMovementComponent;
			CapsuleComp = aCharacter.GetRootComponent() as UCapsuleComponent;
			ParkourMoveData.CapsuleRadius = ((CapsuleComp != null) ? CapsuleComp.GetScaledCapsuleRadius() : 0f);
			ParkourMoveData.CapsuleHalfHeight = ((CapsuleComp != null) ? CapsuleComp.GetScaledCapsuleHalfHeight() : 0f);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (ParkourMoveData.IsCanParkourMove && !BuffData.HasBuff(907) && !BGU_NormalMoveMode.GMFlyMode)
		{
			if (TickRateData.CanTickFor100msInterval(out var _, out var _, out var _, out var _, out var _))
			{
				bDrawDebugType = ((GSGameplayCVar.CVar_DebugParkour.GetValueInGameThread() != 0) ? EDrawDebugTrace.ForOneFrame : EDrawDebugTrace.None);
				CheckParkour(bCheckContinue: false);
			}
			CheckStrideDown();
		}
	}

	private void OnSetParkourMoveEnabled(bool bIsEnabled)
	{
		ParkourMoveData.IsCanParkourMove = bIsEnabled;
	}

	private void CheckStrideDown()
	{
		if (!ParkourMoveData.bEnableStrideDown || !(GetOwner() is ACharacter aCharacter) || aCharacter.IsNullOrDestroyed() || UnitStateData.HasState(EBGUUnitState.JumpMoving) || MovementData.bWalkOnDitch || CapsuleComp == null || MovementComp == null || MovementComp.IsFalling())
		{
			return;
		}
		FVector lastMovementInputVector = aCharacter.GetLastMovementInputVector();
		if (lastMovementInputVector.Size() < 0.1f || FVector.DotProduct(lastMovementInputVector.GetSafeNormal(), Owner.GetActorForwardVector()) <= FMath.Cos(FMath.DegreesToRadians(30f)))
		{
			return;
		}
		float capsuleHalfHeight = ParkourMoveData.CapsuleHalfHeight;
		float capsuleRadius = ParkourMoveData.CapsuleRadius;
		float maxStepHeight = MovementComp.MaxStepHeight;
		float mappedRangeValueClamped = FMath.GetMappedRangeValueClamped(new FVector2D(BasicData.JogBaseSpeed, BasicData.SprintSpeed), new FVector2D(0.0, capsuleRadius), BasicData.Speed);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
		fVector += aCharacter.GetActorForwardVector() * mappedRangeValueClamped;
		fVector.Z = fVector.Z - capsuleHalfHeight + capsuleRadius;
		FVector end = fVector;
		end.Z -= maxStepHeight + capsuleRadius + 1f;
		if (USystemLibrary.LineTraceSingleByProfile(aCharacter, fVector, end, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), bDrawDebugType, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 5f))
		{
			if (MovementComp.IsWalkable(OutHit))
			{
				return;
			}
			UPrimitiveComponent uPrimitiveComponent = OutHit.Component.Get();
			if (uPrimitiveComponent != null && uPrimitiveComponent.GetOwner() is ACharacter aCharacter2 && aCharacter2.CapsuleComponent == uPrimitiveComponent)
			{
				return;
			}
		}
		fVector += aCharacter.GetActorForwardVector() * capsuleRadius + 1.0;
		end = fVector;
		end.Z -= maxStepHeight + capsuleRadius + 1f;
		if (!USystemLibrary.LineTraceSingleByProfile(aCharacter, fVector, end, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), bDrawDebugType, out OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 5f) || !MovementComp.IsWalkable(OutHit))
		{
			float gameTimeInSeconds = Owner.World.GetGameTimeInSeconds();
			if (!(gameTimeInSeconds - ParkourMoveData.LastStrideDownTime <= 0.5f))
			{
				base.BUSEventCollection.Evt_TriggerStrideJump.Invoke(0f);
				ParkourMoveData.LastStrideDownTime = gameTimeInSeconds;
			}
		}
	}

	private void CheckParkour(bool bCheckContinue)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null || ParkourMoveData.CheckParkourStartDistance <= 0f || ParkourMoveData.ParkourStartMaxHeight <= 0f || ParkourMoveData.IsPakourMoving || UnitStateData.HasState(EBGUUnitState.JumpMoving) || aCharacter.CharacterMovement.IsFalling())
		{
			return;
		}
		ParkourMoveData.ParkourCheckInput = (bCheckContinue ? MovementData.GetCurrentWorldInputVec(aCharacter) : aCharacter.GetLastMovementInputVector());
		if (ParkourMoveData.ParkourCheckInput.Size() < 0.1f || FVector.DotProduct(ParkourMoveData.ParkourCheckInput.GetSafeNormal(), aCharacter.GetActorForwardVector()) <= FMath.Cos(FMath.DegreesToRadians(30f)) || BGW_GameDB.GetUnitCommDesc(GetActorResID()) == null || !CheckCanStartParkour())
		{
			return;
		}
		CheckParkourLandInfo();
		if (ParkourMoveData.ListLandCheckInfo.Count != 0 && !(ParkourMoveData.ListLandCheckInfo[0].Location.Z - ParkourMoveData.CapsuleBasicLocation.Z > ParkourMoveData.ParkourStartMaxHeight))
		{
			UpdateParkourPointIndex();
			if (ParkourMoveData.TargetPointIndex < 0)
			{
				ResetParkourData();
				return;
			}
			StartParkour();
			DrawDebug();
		}
	}

	private void DrawDebug()
	{
	}

	private void TickParkour()
	{
		if (ParkourMoveData.IsPakourMoving)
		{
			if (ParkourMoveData.ParkourProcessType == EParkourProcessType.None)
			{
				StopParkour();
			}
			else if (ParkourMoveData.bNeedStopParkour)
			{
				StopParkour();
			}
			else if (ParkourMoveData.bParkourAnimMovementInited)
			{
				UpdateParkourMovement();
			}
		}
	}

	private void InitParkourAnimMovement()
	{
		if (ParkourMoveData.IsPakourMoving)
		{
			float capsuleHalfHeight = ParkourMoveData.CapsuleHalfHeight;
			float capsuleRadius = ParkourMoveData.CapsuleRadius;
			float num = ParkourMoveData.ListLandCheckInfo[ParkourMoveData.TargetPointIndex].Location.Z + capsuleHalfHeight - ParkourMoveData.ParkourStartActorLocation.Z;
			float num2 = 0f;
			float num3 = ParkourMoveData.ParkourPathDistance.TargetPoint + capsuleRadius / 2f;
			float num4 = num + num2;
			ParkourMoveData.ParkourForwardMovementRate = ((ParkourMoveData.CurParkourAnimTotalMovement.X == 0f) ? 1f : (num3 / ParkourMoveData.CurParkourAnimTotalMovement.X));
			ParkourMoveData.ParkourUpMovementRate = ((ParkourMoveData.CurParkourAnimTotalMovement.Z == 0f) ? 1f : (num4 / ParkourMoveData.CurParkourAnimTotalMovement.Z));
			FVector fVector = new FVector(num3, ParkourMoveData.CurParkourAnimTotalMovement.Y, num4);
			ParkourMoveData.ParkourMoveTargetLocation = ParkourMoveData.ParkourStartActorLocation + MathLib.TransformDirection(BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner), fVector.GetSafeNormal()) * fVector.Size();
			ParkourMoveData.bParkourAnimMovementInited = true;
		}
	}

	private bool CheckParkourMoveEnd()
	{
		return FVector.Dist(ParkourMoveData.ParkourMoveTargetLocation, ParkourMoveData.ParkourMoveCurLocation) <= 1f;
	}

	private void UpdateParkourMovement()
	{
		if (CheckParkourMoveEnd())
		{
			StopParkour();
			CheckParkour(bCheckContinue: true);
			ParkourMoveData.bContinue = ParkourMoveData.IsPakourMoving;
			return;
		}
		AActor owner = GetOwner();
		FVector fVector = new FVector(ParkourMoveData.ParkourCurveMoveValue.X * ParkourMoveData.ParkourForwardMovementRate, ParkourMoveData.ParkourCurveMoveValue.Y, ParkourMoveData.ParkourCurveMoveValue.Z * ParkourMoveData.ParkourUpMovementRate);
		FVector fVector2 = MathLib.TransformDirection(BGUFuncLibActorTransformCS.BGUGetActorTransform(owner), fVector.GetSafeNormal()) * fVector.Size();
		FVector fVector3 = ParkourMoveData.ParkourStartActorLocation + fVector2;
		ParkourMoveData.ParkourDeltaMove = fVector3 - ParkourMoveData.ParkourMoveCurLocation;
		ParkourMoveData.ParkourMoveCurLocation = fVector3;
	}

	private bool CheckParkourMoveBlockInfo(in FVector ParkourCurveMovement)
	{
		FVector actorForwardVector = GetOwner().GetActorForwardVector();
		float capsuleRadius = ParkourMoveData.CapsuleRadius;
		float capsuleHalfHeight = ParkourMoveData.CapsuleHalfHeight;
		FVector fVector = ParkourMoveData.ParkourStartActorLocation + ParkourCurveMovement;
		FVector end = fVector + actorForwardVector * 1.0;
		if (!USystemLibrary.CapsuleTraceSingleByProfile(GetOwner(), fVector, end, capsuleRadius, capsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), bDrawDebugType, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 5f))
		{
			return false;
		}
		FVector fVector2 = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in OutHit.ImpactPoint) - fVector;
		fVector2.Z = 0f;
		if (fVector2.Size() == 0f || fVector2.Size() > capsuleRadius)
		{
			return false;
		}
		float num = FVector.DotProduct(fVector2.GetSafeNormal(), actorForwardVector);
		if (num > 0f)
		{
			ParkourMoveData.ParkourMoveAdjuestDistance = (capsuleRadius - fVector2.Size()) / num;
		}
		else if (num < 0f)
		{
			ParkourMoveData.ParkourMoveAdjuestDistance = (capsuleRadius + fVector2.Size()) / (0f - num);
		}
		else
		{
			num = FVector.DotProduct(actorForwardVector, -new FVector(OutHit.ImpactNormal.X, OutHit.ImpactNormal.Y, OutHit.ImpactNormal.Z));
			if (num != 0f)
			{
				ParkourMoveData.ParkourMoveAdjuestDistance = capsuleRadius / num;
			}
		}
		return true;
	}

	private void ExecCurParkourProcess()
	{
		switch (ParkourMoveData.ParkourProcessType)
		{
		case EParkourProcessType.None:
			StopParkour();
			break;
		case EParkourProcessType.Pivot:
		case EParkourProcessType.Climb:
		case EParkourProcessType.Across:
			break;
		}
	}

	private void StartParkour()
	{
		AActor owner = GetOwner();
		b1.BUC_ParkourMoveData parkourMoveData = ParkourMoveData;
		FVector parkourStartActorLocation = (ParkourMoveData.ParkourMoveCurLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner));
		parkourMoveData.ParkourStartActorLocation = parkourStartActorLocation;
		ParkourMoveData.ParkourDeltaMove = FVector.ZeroVector;
		FVector location = ParkourMoveData.ListLandCheckInfo[ParkourMoveData.TargetPointIndex].Location;
		FVector fVector2 = location - BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
		fVector2.Z = 0f;
		if (fVector2.Size() > 30f)
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, fVector2.Rotation(), bTeleportPhysics: true);
		}
		float p = location.Z - ParkourMoveData.CapsuleBasicLocation.Z;
		base.BUSEventCollection.Evt_TriggerStrideJump.Invoke(p);
	}

	private void StopParkour()
	{
		ParkourMoveData.IsPakourMoving = false;
		ResetParkourData();
	}

	private void ResetParkourData()
	{
		ParkourMoveData.ParkourActionType = default(b1.FParkourActionType);
		ParkourMoveData.HighestPointIndex = -1;
		ParkourMoveData.FirstStandablePointIndex = -1;
		ParkourMoveData.TargetPointIndex = -1;
		ParkourMoveData.ParkourProcessType = EParkourProcessType.None;
		ParkourMoveData.ParkourMoveCurLocation = FVector.ZeroVector;
		ParkourMoveData.ParkourMoveTargetLocation = FVector.ZeroVector;
		ParkourMoveData.ParkourDeltaMove = FVector.ZeroVector;
		ParkourMoveData.CurParkourAnimTotalMovement = FVector.ZeroVector;
		ParkourMoveData.ParkourCheckInput = FVector.ZeroVector;
		ParkourMoveData.bParkourAnimMovementInited = false;
		ParkourMoveData.bNeedStopParkour = false;
	}

	private void RefreshParkourPathDistance()
	{
		List<b1.FParkourLandCheckInfo> listLandCheckInfo = ParkourMoveData.ListLandCheckInfo;
		b1.FParkourPathDistance parkourPathDistance = new b1.FParkourPathDistance
		{
			StartPoint = FVector.Dist2D(ParkourMoveData.ParkourStartActorLocation, listLandCheckInfo[0].Location),
			TargetPoint = FVector.Dist2D(ParkourMoveData.ParkourStartActorLocation, listLandCheckInfo[ParkourMoveData.TargetPointIndex].Location),
			HighestPoint = FVector.Dist2D(ParkourMoveData.ParkourStartActorLocation, listLandCheckInfo[ParkourMoveData.HighestPointIndex].Location),
			AfterTargetPoint = FVector.Dist2D(ParkourMoveData.ParkourStartActorLocation, listLandCheckInfo[ParkourMoveData.AfterTargetPointIndex].Location)
		};
		ParkourMoveData.ParkourPathDistance = parkourPathDistance;
	}

	private void RefreshParkourProcessType()
	{
		if (ParkourMoveData.ParkourActionType.AfterTargetType == b1.EParkourAfterTargetType.ClimbToTarget)
		{
			ParkourMoveData.ParkourProcessType = EParkourProcessType.Climb;
		}
		if (ParkourMoveData.ParkourActionType.AfterTargetType == b1.EParkourAfterTargetType.AcrossTarget)
		{
			ParkourMoveData.ParkourProcessType = EParkourProcessType.Across;
		}
	}

	private void UpdateParkourActionType()
	{
		b1.FParkourActionType parkourActionType = default(b1.FParkourActionType);
		switch (ParkourMoveData.ParkourStartToTargetAngleType)
		{
		case b1.EParkourStartToTargetAngleType.Flat:
			parkourActionType.StartPoint = b1.EParkourStartPointActionType.NoPivot;
			break;
		case b1.EParkourStartToTargetAngleType.Slope:
			if (ParkourMoveData.ParkourStartHeightType == EParkourHeightType.Low)
			{
				parkourActionType.StartPoint = b1.EParkourStartPointActionType.FootPivot_Low;
			}
			if (ParkourMoveData.ParkourStartHeightType == EParkourHeightType.Normal)
			{
				parkourActionType.StartPoint = b1.EParkourStartPointActionType.FootPivot_High;
			}
			if (ParkourMoveData.ParkourStartHeightType == EParkourHeightType.High)
			{
				parkourActionType.StartPoint = b1.EParkourStartPointActionType.HandPivot;
			}
			break;
		}
		parkourActionType.StartPoint = b1.EParkourStartPointActionType.NoPivot;
		float num = ((parkourActionType.StartPoint == b1.EParkourStartPointActionType.NoPivot) ? ParkourMoveData.CapsuleBasicLocation.Z : ParkourMoveData.ListLandCheckInfo[0].Location.Z);
		float num2 = ((CapsuleComp != null) ? CapsuleComp.GetScaledCapsuleHalfHeight() : 0f);
		float num3 = ParkourMoveData.ListLandCheckInfo[ParkourMoveData.TargetPointIndex].Location.Z - num;
		if (num3 <= num2 * 1f)
		{
			parkourActionType.TargetPoint = EParkourHeightType.Low;
		}
		else if (num3 >= num2 * 3f)
		{
			parkourActionType.TargetPoint = EParkourHeightType.High;
		}
		else
		{
			parkourActionType.TargetPoint = EParkourHeightType.Normal;
		}
		if (ParkourMoveData.ParkourStartToTargetAngleType == b1.EParkourStartToTargetAngleType.Slope)
		{
			parkourActionType.StartPointAcrossOrClibmType = b1.EParkourStartPointAcrossOrClimbType.Across;
		}
		int num4 = 0;
		float capsuleRadius = ParkourMoveData.CapsuleRadius;
		float num5 = ParkourMoveData.LandCheckSphereRadius * 2f;
		List<b1.FParkourLandCheckInfo> listLandCheckInfo = ParkourMoveData.ListLandCheckInfo;
		if (ParkourMoveData.ParkourStartToTargetAngleType == b1.EParkourStartToTargetAngleType.Flat)
		{
			if ((float)ParkourMoveData.TargetPointIndex * num5 + ParkourMoveData.LandCheckSphereRadius >= capsuleRadius)
			{
				for (int i = 0; i < ParkourMoveData.TargetPointIndex; i++)
				{
					num4 = (listLandCheckInfo[i].bWalkable ? (num4 + 1) : 0);
				}
			}
			else
			{
				for (int j = ParkourMoveData.TargetPointIndex; j < listLandCheckInfo.Count && IsParkourLandPointFlat(listLandCheckInfo, j); j++)
				{
					num4++;
					if ((float)num4 * num5 >= capsuleRadius)
					{
						break;
					}
				}
			}
			parkourActionType.StartPointAcrossOrClibmType = ((!((float)num4 * num5 >= capsuleRadius)) ? b1.EParkourStartPointAcrossOrClimbType.Across : b1.EParkourStartPointAcrossOrClimbType.Climb);
		}
		num4 = 0;
		for (int k = ParkourMoveData.TargetPointIndex; k < listLandCheckInfo.Count && IsParkourLandPointFlat(listLandCheckInfo, k); k++)
		{
			num4++;
			if ((float)num4 * num5 >= capsuleRadius)
			{
				break;
			}
		}
		parkourActionType.AfterTargetType = (((float)num4 * num5 >= capsuleRadius) ? b1.EParkourAfterTargetType.ClimbToTarget : b1.EParkourAfterTargetType.AcrossTarget);
		ParkourMoveData.ParkourActionType = parkourActionType;
	}

	private bool IsParkourLandPointFlat(List<b1.FParkourLandCheckInfo> CheckInfo, int PointIndex)
	{
		float value = ((PointIndex > 0) ? CheckInfo[PointIndex - 1].ZOffsetToNext : 0f);
		if (CheckInfo[PointIndex].bWalkable)
		{
			return FMath.Abs(value) <= ParkourMoveData.LandCheckSphereRadius * 2f;
		}
		return false;
	}

	private void UpdateParkourStartToTargetAngleType()
	{
		if (!(GetOwner() as ACharacter == null))
		{
			List<b1.FParkourLandCheckInfo> listLandCheckInfo = ParkourMoveData.ListLandCheckInfo;
			FVector a = listLandCheckInfo[ParkourMoveData.TargetPointIndex].Location - listLandCheckInfo[0].Location;
			a.Normalize();
			float num = MathLib.DegAcos(FVector.DotProduct(a, ParkourMoveData.ParkourCheckInput.GetSafeNormal2D()));
			ParkourMoveData.ParkourStartToTargetAngleType = ((!(num < 15f) && num != 90f) ? b1.EParkourStartToTargetAngleType.Slope : b1.EParkourStartToTargetAngleType.Flat);
		}
	}

	private void UpdateParkourPointIndex()
	{
		List<b1.FParkourLandCheckInfo> listLandCheckInfo = ParkourMoveData.ListLandCheckInfo;
		FVector location = listLandCheckInfo[0].Location;
		int num = 0;
		float capsuleRadius = ParkourMoveData.CapsuleRadius;
		float num2 = ParkourMoveData.LandCheckSphereRadius * 2f;
		int num3 = -1;
		int num4 = 0;
		float num5 = 0f;
		for (int i = 0; i < listLandCheckInfo.Count; i++)
		{
			FVector location2 = listLandCheckInfo[i].Location;
			if (FVector.Dist2D(location, location2) > ParkourMoveData.ParkourMaxDistance * 0.5f || location2.Z - ParkourMoveData.CapsuleBasicLocation.Z > ParkourMoveData.ParkourStartMaxHeight)
			{
				break;
			}
			if (i == 0)
			{
				num5 = location2.Z;
				num4 = i;
			}
			else if (location2.Z > num5)
			{
				num5 = location2.Z;
				num4 = i;
			}
			if (num3 == -1)
			{
				num = (IsParkourLandPointFlat(listLandCheckInfo, i) ? (num + 1) : 0);
				if ((float)num * num2 >= capsuleRadius)
				{
					num3 = i - num + 1;
				}
			}
		}
		ParkourMoveData.HighestPointIndex = num4;
		ParkourMoveData.FirstStandablePointIndex = num3;
		if (num3 == -1)
		{
			ParkourMoveData.TargetPointIndex = -1;
		}
		else
		{
			ParkourMoveData.TargetPointIndex = ((num3 < num4) ? num3 : num4);
		}
	}

	private void UpdateParkourAfterTargetPoint()
	{
		float num = float.MinValue;
		int afterTargetPointIndex = 0;
		List<b1.FParkourLandCheckInfo> listLandCheckInfo = ParkourMoveData.ListLandCheckInfo;
		for (int i = ParkourMoveData.TargetPointIndex; i < listLandCheckInfo.Count; i++)
		{
			float zOffsetToNext = listLandCheckInfo[i].ZOffsetToNext;
			if (zOffsetToNext > num)
			{
				num = zOffsetToNext;
				afterTargetPointIndex = i;
			}
		}
		ParkourMoveData.AfterTargetPointIndex = afterTargetPointIndex;
	}

	private void UpdateParkourStartHeightType(float ParkourStartHeight)
	{
		float num = ((CapsuleComp != null) ? CapsuleComp.GetScaledCapsuleHalfHeight() : 0f);
		if (ParkourStartHeight <= num * 1f)
		{
			ParkourMoveData.ParkourStartHeightType = EParkourHeightType.Low;
		}
		else if (ParkourStartHeight >= num * 3f)
		{
			ParkourMoveData.ParkourStartHeightType = EParkourHeightType.High;
		}
		else
		{
			ParkourMoveData.ParkourStartHeightType = EParkourHeightType.Normal;
		}
	}

	private bool CheckCanStartParkour()
	{
		ACharacter worldContextObject = GetOwner() as ACharacter;
		if (CapsuleComp == null || MovementComp == null)
		{
			return false;
		}
		float capsuleRadius = ParkourMoveData.CapsuleRadius;
		float capsuleHalfHeight = ParkourMoveData.CapsuleHalfHeight;
		FVector worldLocation = CapsuleComp.GetWorldLocation();
		ParkourMoveData.CapsuleBasicLocation = new FVector(worldLocation.X, worldLocation.Y, worldLocation.Z - capsuleHalfHeight);
		FVector fVector = worldLocation;
		fVector.Z += ParkourMoveData.ParkourStartMinHeight / 2f;
		fVector.Z -= (capsuleHalfHeight * 2f - ParkourMoveData.ParkourStartMaxHeight) / 2f;
		float num = (ParkourMoveData.ParkourStartMaxHeight - ParkourMoveData.ParkourStartMinHeight) / 2f;
		float num2 = capsuleRadius / 4f;
		FVector safeNormal2D = ParkourMoveData.ParkourCheckInput.GetSafeNormal2D();
		FVector fVector2 = fVector + safeNormal2D * ParkourMoveData.CheckParkourStartDistance;
		FHitResult OutHit;
		bool flag = USystemLibrary.CapsuleTraceSingleByProfile(worldContextObject, fVector, fVector2, num2, num, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), bDrawDebugType, out OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 0.05f);
		UPrimitiveComponent uPrimitiveComponent = OutHit.Component.Get();
		if (flag)
		{
			FVector fVector3 = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in OutHit.Location);
			fVector3.Z -= num;
			FVector end = fVector3;
			end.Z = ParkourMoveData.CapsuleBasicLocation.Z;
			int num3 = 0;
			float num4 = 0f;
			FHitResult OutHit2;
			while (num3++ < 100 && USystemLibrary.LineTraceSingleByProfile(worldContextObject, fVector3, end, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), bDrawDebugType, out OutHit2, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 1f) && MovementComp.IsWalkable(OutHit2) && !OutHit2.StartPenetrating)
			{
				float num5 = (float)OutHit2.ImpactPoint.Z - ParkourMoveData.CapsuleBasicLocation.Z;
				if (num5 == num4)
				{
					break;
				}
				num4 = num5;
				FVector start = fVector;
				FVector end2 = fVector2;
				start.Z += num5;
				end2.Z += num5;
				flag = USystemLibrary.CapsuleTraceSingleByProfile(worldContextObject, start, end2, num2, num, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), bDrawDebugType, out OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 1f);
				uPrimitiveComponent = OutHit.Component.Get();
				if (!flag)
				{
					break;
				}
				fVector3 = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in OutHit.Location);
				fVector3.Z -= num;
				end = fVector3;
				end.Z = ParkourMoveData.CapsuleBasicLocation.Z;
			}
		}
		if (!flag)
		{
			return false;
		}
		if (!uPrimitiveComponent.IsNullOrDestroyed() && !uPrimitiveComponent.GetOwner().IsNullOrDestroyed() && uPrimitiveComponent.GetOwner().ActorHasTag(B1GlobalFNames.DisableStride))
		{
			return false;
		}
		if (MovementComp.IsWalkable(OutHit))
		{
			return false;
		}
		FVector start2 = fVector;
		start2.Z = ParkourMoveData.CapsuleBasicLocation.Z + capsuleHalfHeight * 2f;
		FVector end3 = fVector;
		end3.Z = ParkourMoveData.CapsuleBasicLocation.Z + capsuleHalfHeight * 2f + ParkourMoveData.ParkourStartMaxHeight + ParkourMoveData.LandCheckSphereRadius;
		if (USystemLibrary.LineTraceSingleByProfile(worldContextObject, start2, end3, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), bDrawDebugType, out var OutHit3, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 5f))
		{
			return false;
		}
		start2.Z = end3.Z;
		end3 = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in OutHit.ImpactPoint);
		end3.Z = start2.Z;
		end3 -= safeNormal2D * num2 * 2.0;
		if (USystemLibrary.SphereTraceSingleByProfile(worldContextObject, start2, end3, num2, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), bDrawDebugType, out OutHit3, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 5f))
		{
			return false;
		}
		ParkourMoveData.ParkourStartCheckPoint = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in OutHit.ImpactPoint);
		return true;
	}

	private void CheckParkourLandInfo()
	{
		ParkourMoveData.ListLandCheckInfo.Clear();
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		float num = ((CapsuleComp != null) ? CapsuleComp.GetScaledCapsuleHalfHeight() : 0f);
		FVector safeNormal2D = ParkourMoveData.ParkourCheckInput.GetSafeNormal2D();
		FVector parkourStartCheckPoint = ParkourMoveData.ParkourStartCheckPoint;
		parkourStartCheckPoint.Z = ParkourMoveData.CapsuleBasicLocation.Z + num * 2f + ParkourMoveData.ParkourStartMaxHeight - ParkourMoveData.LandCheckSphereRadius;
		FVector fVector = parkourStartCheckPoint;
		fVector.Z = ParkourMoveData.CapsuleBasicLocation.Z;
		fVector += safeNormal2D;
		b1.FParkourLandCheckInfo fParkourLandCheckInfo = default(b1.FParkourLandCheckInfo);
		bool flag = true;
		for (int i = 0; i < 10; i++)
		{
			FVector fVector2 = safeNormal2D * ParkourMoveData.LandCheckSphereRadius * 2.0;
			if (USystemLibrary.SphereTraceSingleByProfile(aCharacter, parkourStartCheckPoint + fVector2 * i, fVector + fVector2 * i, ParkourMoveData.LandCheckSphereRadius, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), bDrawDebugType, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 5f))
			{
				if (!flag)
				{
					b1.FParkourLandCheckInfo item = fParkourLandCheckInfo;
					item.ZOffsetToNext = (float)OutHit.ImpactPoint.Z - fParkourLandCheckInfo.ZOffsetToNext;
					ParkourMoveData.ListLandCheckInfo.Add(item);
				}
				fParkourLandCheckInfo.CheckPointIndex = i;
				fParkourLandCheckInfo.Location = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in OutHit.ImpactPoint);
				fParkourLandCheckInfo.bWalkable = MovementComp != null && MovementComp.IsWalkable(OutHit);
				fParkourLandCheckInfo.ZOffsetToNext = (float)OutHit.ImpactPoint.Z;
				flag = false;
			}
		}
		if (ParkourMoveData.ListLandCheckInfo.Count > 0 && ParkourMoveData.ListLandCheckInfo[ParkourMoveData.ListLandCheckInfo.Count - 1].CheckPointIndex != fParkourLandCheckInfo.CheckPointIndex)
		{
			b1.FParkourLandCheckInfo item2 = fParkourLandCheckInfo;
			item2.ZOffsetToNext = fParkourLandCheckInfo.ZOffsetToNext - 1f;
			ParkourMoveData.ListLandCheckInfo.Add(item2);
		}
	}

	private void OnParkourCurveMove(float Forward, float Right, float Up)
	{
		ParkourMoveData.ParkourCurveMoveValue = new FVector(Forward, Right, Up);
	}

	private void OnSetCurParkourAnimTotalMovement(float Forward, float Right, float Up)
	{
		ParkourMoveData.CurParkourAnimTotalMovement = new FVector(Forward, Right, Up);
		InitParkourAnimMovement();
	}

	private void OnSetParkourMoveAnimState(EParkourMoveAnimState State)
	{
		if (State == EParkourMoveAnimState.ParkourStartFinished && ParkourMoveData.CurParkourMoveAnimState != EParkourMoveAnimState.ParkourStartFinished)
		{
			ParkourMoveData.bNeedStopParkour = true;
		}
		ParkourMoveData.CurParkourMoveAnimState = State;
	}
}
