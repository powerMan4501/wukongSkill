using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_EnvironmentInteractionMgrComp : UActorCompBaseCS
{
	private BUC_EnvironmentInteractionMgrData EnvironmentInteractionMgrData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_MovementData MovementData;

	private IBUC_TickRateData TickRateData;

	private IBGC_EnvMgrData EnvMgrData;

	private bool bFlag = true;

	public override void OnAttach()
	{
		EnvironmentInteractionMgrData = RequireWritableData<BUC_EnvironmentInteractionMgrData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		EnvMgrData = RequireReadOnlyGameStateData<IBGC_EnvMgrData, BGC_EnvMgrData>();
		base.BUSEventCollection.Evt_SamplePointSurfaceType += new Del_Void_FloatBool(OnSamplePointSurfaceType);
		base.BUSEventCollection.Evt_ForceUpdateSurfaceType += new Del_Void(ForceUpdateSurfaceType);
		if (OwnerAsCharacterCS != null && OwnerAsCharacterCS is BGUPlayerCharacterCS)
		{
			base.BGSEventCollection.Evt_BGS_CanEnvironmentInteractLineTrace += new Del_Bool_Void(CanEnvironmentInteractLineTrace);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (OwnerAsCharacterCS != null && OwnerAsCharacterCS is BGUPlayerCharacterCS)
		{
			base.BGSEventCollection.Evt_BGS_CanEnvironmentInteractLineTrace -= new Del_Bool_Void(CanEnvironmentInteractLineTrace);
		}
	}

	private bool CanEnvironmentInteractLineTrace()
	{
		if (EnvironmentInteractionMgrData.LineTraceCount < EnvironmentInteractionMgrData.MaxLineTraceCount)
		{
			EnvironmentInteractionMgrData.LineTraceCount++;
			return true;
		}
		return false;
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!(GetOwner() as BGUCharacterCS == null))
		{
			if (OwnerAsCharacterCS != null && OwnerAsCharacterCS is BGUPlayerCharacterCS)
			{
				EnvironmentInteractionMgrData.LineTraceCount = 0;
			}
			float AccumulatedDeltaTime;
			float DifferenceTimeToLast100ms;
			float DifferenceTimeToLast200ms;
			float DifferenceTimeToLast500ms;
			float DifferenceTimeToLast1000ms;
			if (TickRateData.bDisableLineTraceOptimization)
			{
				DoCheckSurface(DeltaTime);
			}
			else if (TickRateData.CanTickFor1000Distance())
			{
				DoCheckSurface(DeltaTime);
			}
			else if (TickRateData.CanTickFor3000Distance() && TickRateData.CanTickFor200msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms))
			{
				DoCheckSurface(AccumulatedDeltaTime);
			}
			else if (TickRateData.CanTickFor500msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms))
			{
				DoCheckSurface(AccumulatedDeltaTime);
			}
		}
	}

	private bool TryLineTraceSurfaceType(out ESceneItemSurfaceType SurfaceType, out FVector HitPoint, IntPtr WorldContext, ref FVector StartTrace, ref FVector EndTrace, ETraceTypeQuery QueryChannel, bool bDebug = false, bool bTraceComplex = false)
	{
		SurfaceType = ESceneItemSurfaceType.DefaultSurface;
		HitPoint = FVector.ZeroVector;
		FHitResultSimple fHitResultSimple = new FHitResultSimple();
		if (BGW_NativeFuncs.LineTraceSimpleNoIgnores(WorldContext, ref StartTrace, ref EndTrace, QueryChannel, bDebug, fHitResultSimple.Address, bTraceComplex))
		{
			if (bDebug)
			{
				USystemLibrary.DrawDebugSphere(Owner, fHitResultSimple.HitLocation, 20f, 50, FLinearColor.Blue, 10f, 10f);
			}
			SurfaceType = (ESceneItemSurfaceType)fHitResultSimple.SurfaceType;
			HitPoint = fHitResultSimple.HitLocation;
			return true;
		}
		return false;
	}

	private void ForceUpdateSurfaceType()
	{
		DoCheckSurface(0f);
	}

	private void DoCheckSurface(float DeltaTime)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		FVector StartTrace = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter) + aCharacter.GetActorUpVector() * aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
		FVector fVector = aCharacter.GetActorUpVector() * -100.0 - aCharacter.GetActorUpVector() * aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
		FVector EndTrace = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter) + fVector;
		EnvironmentInteractionMgrData.bNearGround = MovementData.CanUseSurfaceTypeFromMovementComp() && BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter).Z - MovementData.CurFloorHitPoint.Z < 0f - fVector.Z;
		BGUEnvironmentSurfaceEffectMgr effectMgr = EnvMgrData.EffectMgr;
		if (EnvironmentInteractionMgrData.bNearGround)
		{
			BUC_EnvironmentInteractionMgrData environmentInteractionMgrData = EnvironmentInteractionMgrData;
			ESceneItemSurfaceType resultSurfaceType = (EnvironmentInteractionMgrData.OriginalSurfaceType = ESceneItemSurfaceType.DefaultSurface);
			environmentInteractionMgrData.ResultSurfaceType = resultSurfaceType;
			EnvironmentInteractionMgrData.OriginalSurfaceType = MovementData.CurSurfaceType;
			EnvironmentInteractionMgrData.SurfaceHitPoint = MovementData.CurFloorHitPoint;
			if (((OwnerAsCharacterCS != null && OwnerAsCharacterCS is BGUPlayerCharacterCS) || (base.BGSEventCollection.Evt_BGS_CanEnvironmentInteractLineTrace.Invoke() && MovementData.NavWalkOptLevel < 2)) && TryLineTraceSurfaceType(out var SurfaceType, out var HitPoint, aCharacter.Address, ref StartTrace, ref EndTrace, ETraceTypeQuery.TraceTypeQuery6))
			{
				EnvironmentInteractionMgrData.OriginalSurfaceType = SurfaceType;
				EnvironmentInteractionMgrData.PhySurfaceHitPoint = HitPoint;
			}
			EnvironmentInteractionMgrData.ResultSurfaceType = ((EnvironmentInteractionMgrData.EnvironmentOverrideSurfaceType != ESceneItemSurfaceType.DefaultSurface) ? EnvironmentInteractionMgrData.EnvironmentOverrideSurfaceType : EnvironmentInteractionMgrData.OriginalSurfaceType);
			ApplyEnvironmentEffects(DeltaTime, effectMgr, EnvironmentInteractionMgrData.SurfaceHitPoint, StartTrace);
			if (UnitStateData.HasState(EBGUUnitState.AttackAlignWholeBodyToSlope))
			{
				EnvironmentInteractionMgrData.ChrRotAlignSurface = BGUFunctionLibraryCS.BGUCalcCharacterRotOnSlope(aCharacter, out var SurfaceNormal_Normalized);
				EnvironmentInteractionMgrData.SurfaceNormal_Normalized = SurfaceNormal_Normalized;
			}
			else
			{
				EnvironmentInteractionMgrData.ChrRotAlignSurface = BGUFuncLibActorTransformCS.BGUGetActorRotation(aCharacter);
				EnvironmentInteractionMgrData.SurfaceNormal_Normalized = MovementData.CurFloorNormal;
			}
			EnvironmentInteractionMgrData.LastResultSurfaceType = EnvironmentInteractionMgrData.ResultSurfaceType;
		}
		else
		{
			BUC_EnvironmentInteractionMgrData environmentInteractionMgrData2 = EnvironmentInteractionMgrData;
			ESceneItemSurfaceType resultSurfaceType = (EnvironmentInteractionMgrData.OriginalSurfaceType = ESceneItemSurfaceType.DefaultSurface);
			environmentInteractionMgrData2.ResultSurfaceType = resultSurfaceType;
			ApplyEnvironmentEffects(DeltaTime, effectMgr, FVector.ZeroVector, StartTrace);
			EnvironmentInteractionMgrData.SurfaceNormal_Normalized = FVector.ZeroVector;
			EnvironmentInteractionMgrData.SurfaceHitPoint = FVector.ZeroVector;
			EnvironmentInteractionMgrData.LastResultSurfaceType = EnvironmentInteractionMgrData.ResultSurfaceType;
		}
	}

	private void ApplyEnvironmentEffects(float DeltaTime, BGUEnvironmentSurfaceEffectMgr EnvironmentSurfaceEffectMgr, FVector HitPoint, FVector StartTracePos)
	{
		if (EnvironmentSurfaceEffectMgr != null)
		{
			ESceneItemSurfaceType eSceneItemSurfaceType = EnvironmentSurfaceEffectMgr.EvaluateSurfaceTypeOverrideByPosition(HitPoint.Conv_VectorToVector2D());
			if (eSceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
			{
				EnvironmentInteractionMgrData.ResultSurfaceType = eSceneItemSurfaceType;
			}
			ABGWEnvironmentSurfaceVolume environmentSurfaceVolumeByLocation = EnvironmentSurfaceEffectMgr.GetEnvironmentSurfaceVolumeByLocation(StartTracePos);
			if (environmentSurfaceVolumeByLocation != null)
			{
				int environmentSurfaceEffectID = environmentSurfaceVolumeByLocation.EnvironmentSurfaceEffectID;
				ApplyEnvironmentAbnormalEffects(DeltaTime, EnvironmentSurfaceEffectMgr, environmentSurfaceEffectID);
				ApplySurfaceEffects(EnvironmentSurfaceEffectMgr, environmentSurfaceEffectID);
			}
			else
			{
				int defaultEnvironmentSurfaceEffectID = EnvironmentSurfaceEffectMgr.DefaultEnvironmentSurfaceEffectID;
				ApplyEnvironmentAbnormalEffects(DeltaTime, EnvironmentSurfaceEffectMgr, defaultEnvironmentSurfaceEffectID);
				ApplySurfaceEffects(EnvironmentSurfaceEffectMgr, defaultEnvironmentSurfaceEffectID);
			}
		}
	}

	private void ApplyEnvironmentAbnormalEffects(float DeltaTime, BGUEnvironmentSurfaceEffectMgr EnvironmentSurfaceEffectMgr, int EffectID)
	{
		if (EnvironmentInteractionMgrData.EnvironmentAbnormalEffectApplyTimer <= 0f)
		{
			EnvironmentInteractionMgrData.ClearLastDisableAutoRecoverSimpleStates(Owner);
			EnvironmentInteractionMgrData.ResetLastAutoRecoverRate();
			EnvironmentSurfaceEffectMgr.ApplyEnvironmentAbnormalEffect(EffectID, Owner, Owner, out var DisableAutoRecoverSSList, out var AbnormalStateAutoRecoverRateMap);
			EnvironmentInteractionMgrData.LastDisableAutoRecoverSSList = DisableAutoRecoverSSList;
			EnvironmentInteractionMgrData.AbnormalStateAutoRecoverRateMap = AbnormalStateAutoRecoverRateMap;
			EnvironmentInteractionMgrData.EnvironmentAbnormalEffectApplyTimer = EnvironmentSurfaceEffectMgr.GetEnvironmentAbnormalEffectTriggerInterval(EffectID);
		}
		else
		{
			EnvironmentInteractionMgrData.EnvironmentAbnormalEffectApplyTimer -= DeltaTime;
		}
	}

	private void ApplySurfaceEffects(BGUEnvironmentSurfaceEffectMgr EnvironmentSurfaceEffectMgr, int EffectID)
	{
		if (EnvironmentInteractionMgrData.ResultSurfaceType != EnvironmentInteractionMgrData.LastResultSurfaceType || EffectID != EnvironmentInteractionMgrData.LastSurfaceEffectID)
		{
			EnvironmentSurfaceEffectMgr.RemoveEffect(EnvironmentInteractionMgrData.LastSurfaceEffectID, EnvironmentInteractionMgrData.LastResultSurfaceType, Owner);
			EnvironmentSurfaceEffectMgr.ApplyEffect(EffectID, EnvironmentInteractionMgrData.ResultSurfaceType, Owner, Owner);
			EnvironmentInteractionMgrData.LastSurfaceEffectID = EffectID;
		}
	}

	private void OnSamplePointSurfaceType(float DetectionRadius = 0f, bool bRingDetection = true)
	{
		ACharacter Owner = GetOwner() as ACharacter;
		if (Owner == null)
		{
			return;
		}
		DoCheckSurface(0f);
		if (!EnvironmentInteractionMgrData.bNearGround)
		{
			EnvironmentInteractionMgrData.SamplePointResultSurfaceType = ESceneItemSurfaceType.DefaultSurface;
			return;
		}
		FVector zeroVector = FVector.ZeroVector;
		FVector CenterStartTracePos = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) + Owner.GetActorUpVector() * (Owner.CapsuleComponent.GetScaledCapsuleHalfHeight() * 2f);
		FVector CenterEndTracePos = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) + Owner.GetActorUpVector() * -100.0 - Owner.GetActorUpVector() * Owner.CapsuleComponent.GetScaledCapsuleHalfHeight();
		Dictionary<ESceneItemSurfaceType, int> SurfaceTypeScore = new Dictionary<ESceneItemSurfaceType, int>();
		ESceneItemSurfaceType CurHighestSurfaceType = ESceneItemSurfaceType.DefaultSurface;
		int CurScore = 0;
		Action<FVector, int> action = delegate(FVector m_ExtendVector, int m_Score)
		{
			bool num9 = m_ExtendVector.IsNearlyZero();
			ESceneItemSurfaceType SurfaceType = ESceneItemSurfaceType.DefaultSurface;
			if (num9)
			{
				SurfaceType = EnvironmentInteractionMgrData.OriginalSurfaceType;
			}
			else
			{
				FVector StartTrace = CenterStartTracePos + m_ExtendVector;
				FVector EndTrace = CenterEndTracePos + m_ExtendVector;
				if (BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(Owner, StartTrace, EndTrace, out var _))
				{
					TryLineTraceSurfaceType(out SurfaceType, out var _, Owner.Address, ref StartTrace, ref EndTrace, ETraceTypeQuery.TraceTypeQuery6);
				}
			}
			if (!SurfaceTypeScore.ContainsKey(SurfaceType))
			{
				SurfaceTypeScore.Add(SurfaceType, m_Score);
				if (CurScore == 0 && SurfaceType != ESceneItemSurfaceType.DefaultSurface)
				{
					CurScore = m_Score;
					CurHighestSurfaceType = SurfaceType;
				}
			}
			else
			{
				SurfaceTypeScore[SurfaceType] += m_Score;
				if (SurfaceTypeScore[SurfaceType] > CurScore && SurfaceType != ESceneItemSurfaceType.DefaultSurface)
				{
					CurHighestSurfaceType = SurfaceType;
					CurScore = SurfaceTypeScore[SurfaceType];
				}
			}
		};
		if (DetectionRadius == 0f)
		{
			EnvironmentInteractionMgrData.SamplePointResultSurfaceType = EnvironmentInteractionMgrData.OriginalSurfaceType;
			return;
		}
		if (bRingDetection)
		{
			zeroVector.X = DetectionRadius;
			action(zeroVector, 1);
			zeroVector.X = 0f - DetectionRadius;
			action(zeroVector, 1);
			zeroVector.X = 0f;
			zeroVector.Y = DetectionRadius;
			action(zeroVector, 1);
			zeroVector.Y = 0f - DetectionRadius;
			action(zeroVector, 1);
			if (CurScore >= 3)
			{
				EnvironmentInteractionMgrData.SamplePointResultSurfaceType = CurHighestSurfaceType;
				return;
			}
			if (CurScore >= 2)
			{
				float num = (zeroVector.Y = (zeroVector.X = DetectionRadius / 2f / 0.71f));
				action(zeroVector, 1);
				zeroVector.X = num;
				zeroVector.Y = 0f - num;
				action(zeroVector, 1);
				zeroVector.X = 0f - num;
				zeroVector.Y = 0f - num;
				action(zeroVector, 1);
				zeroVector.X = 0f - num;
				zeroVector.Y = num;
				action(zeroVector, 1);
				if (CurScore >= 4)
				{
					EnvironmentInteractionMgrData.SamplePointResultSurfaceType = CurHighestSurfaceType;
					return;
				}
			}
			EnvironmentInteractionMgrData.SamplePointResultSurfaceType = ESceneItemSurfaceType.DefaultSurface;
			return;
		}
		action(zeroVector, 2);
		zeroVector.X = DetectionRadius;
		action(zeroVector, 2);
		zeroVector.X = 0f - DetectionRadius;
		action(zeroVector, 2);
		zeroVector.X = 0f;
		zeroVector.Y = DetectionRadius;
		action(zeroVector, 2);
		zeroVector.Y = 0f - DetectionRadius;
		action(zeroVector, 2);
		float num4 = (zeroVector.Y = (zeroVector.X = DetectionRadius / 3f));
		action(zeroVector, 1);
		zeroVector.X = num4;
		zeroVector.Y = 0f - num4;
		action(zeroVector, 1);
		zeroVector.X = 0f - num4;
		zeroVector.Y = 0f - num4;
		action(zeroVector, 1);
		zeroVector.X = 0f - num4;
		zeroVector.Y = num4;
		action(zeroVector, 1);
		if (CurScore > 7)
		{
			EnvironmentInteractionMgrData.SamplePointResultSurfaceType = CurHighestSurfaceType;
			return;
		}
		if (CurScore > 4)
		{
			num4 = (zeroVector.Y = (zeroVector.X = DetectionRadius / 2f / 0.71f));
			action(zeroVector, 1);
			zeroVector.X = num4;
			zeroVector.Y = 0f - num4;
			action(zeroVector, 1);
			zeroVector.X = 0f - num4;
			zeroVector.Y = 0f - num4;
			action(zeroVector, 1);
			zeroVector.X = 0f - num4;
			zeroVector.Y = num4;
			action(zeroVector, 1);
			if (CurScore > 7)
			{
				EnvironmentInteractionMgrData.SamplePointResultSurfaceType = CurHighestSurfaceType;
				return;
			}
		}
		EnvironmentInteractionMgrData.SamplePointResultSurfaceType = ESceneItemSurfaceType.DefaultSurface;
	}
}
