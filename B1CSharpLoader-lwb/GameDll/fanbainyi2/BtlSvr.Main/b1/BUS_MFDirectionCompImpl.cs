using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MFDirectionCompImpl : UActorCompBaseCS
{
	private b1.BUC_MFDirectionData MFDirectionData { get; set; }

	private IBUC_MFOverlapData MFOverlapData { get; set; }

	public override void OnAttach()
	{
		MFDirectionData = RequireWritableData<b1.BUC_MFDirectionData>();
		MFOverlapData = RequireReadOnlyData<IBUC_MFOverlapData, BUC_MFOverlapData>();
		base.BUSEventCollection.Evt_OnTargetExistedWhenMagicFieldBorn += new Del_Void_Actor(OnTargetExistedWhenMagicFieldBorn);
		base.BUSEventCollection.Evt_OnTargetExistedWhenMagicFieldDead += new Del_Void_Actor(OnTargetExistedWhenMagicFieldDead);
		base.BUSEventCollection.Evt_OnTargetEnterMagicField += new Del_Void_Actor(OnTargetEnterMagicField);
		base.BUSEventCollection.Evt_OnTargetLeaveMagicField += new Del_Void_Actor(OnTargetLeaveMagicField);
	}

	public override void OnBeginPlay()
	{
		InitAnchorPoint();
	}

	private void InitAnchorPoint()
	{
		List<UActorComponent> componentsByTag = GetOwner().GetComponentsByTag(UClass.GetClass<USceneComponent>(), MFDirectionData.AnchorPointTag);
		if (componentsByTag.Count != 0)
		{
			MFDirectionData.AnchorPointComp = componentsByTag[0] as USceneComponent;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (MFOverlapData.OverlapComp == null || MFDirectionData.MFDirectionUsage == EMagicFieldDirectionUsage.None || MFDirectionData.MFDirectionType == EMagicFieldDirectionType.None)
		{
			return;
		}
		foreach (AActor item in MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin)
		{
			if (!(item == null) && item is ACharacter)
			{
				FVector Direction = GetMFDirectionVector(item);
				BUS_EventCollectionCS.Get(item)?.Evt_SetMagicFieldDirection.Invoke(GetOwner(), MFDirectionData.MFDirectionUsage, in Direction);
			}
		}
	}

	private FVector GetMFDirectionVector(AActor OverlapingActor)
	{
		FVector result = FVector.ZeroVector;
		switch (MFDirectionData.MFDirectionType)
		{
		case EMagicFieldDirectionType.Directional:
			result = ((MFDirectionData.AnchorPointComp != null) ? MFDirectionData.AnchorPointComp.GetForwardVector() : FVector.ZeroVector);
			break;
		case EMagicFieldDirectionType.Radial:
			if (MFDirectionData.MFDirectionTypeDetail == EMagicFieldDirectionTypeDetail.Positive)
			{
				result = (BGUFuncLibActorTransformCS.BGUGetActorLocation(OverlapingActor) - MFDirectionData.AnchorPointComp.GetWorldLocation()).GetSafeNormal();
			}
			else if (MFDirectionData.MFDirectionTypeDetail == EMagicFieldDirectionTypeDetail.Negative)
			{
				result = (MFDirectionData.AnchorPointComp.GetWorldLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(OverlapingActor)).GetSafeNormal();
			}
			break;
		case EMagicFieldDirectionType.Spiral:
		{
			FVector safeNormal2D = (BGUFuncLibActorTransformCS.BGUGetActorLocation(OverlapingActor) - MFDirectionData.AnchorPointComp.GetWorldLocation()).GetSafeNormal2D();
			if (MFDirectionData.MFDirectionTypeDetail == EMagicFieldDirectionTypeDetail.Positive)
			{
				result = FVector.CrossProduct(FVector.UpVector, safeNormal2D);
			}
			else if (MFDirectionData.MFDirectionTypeDetail == EMagicFieldDirectionTypeDetail.Negative)
			{
				result = FVector.CrossProduct(safeNormal2D, FVector.UpVector);
			}
			break;
		}
		default:
			result = FVector.ZeroVector;
			break;
		}
		result.Z = 0f;
		return result;
	}

	private void OnTargetExistedWhenMagicFieldBorn(AActor TargetActor)
	{
		FVector mFDirectionVector = GetMFDirectionVector(TargetActor);
		foreach (MFDirectionEffectForData item in MFDirectionData.DirectionEffects.MultiFind(EMagicFieldEffectTriggerEvent.OnBorn))
		{
			TriggerEffectByDirection(TargetActor, mFDirectionVector, item);
		}
	}

	private void OnTargetEnterMagicField(AActor TargetActor)
	{
		FVector mFDirectionVector = GetMFDirectionVector(TargetActor);
		foreach (MFDirectionEffectForData item in MFDirectionData.DirectionEffects.MultiFind(EMagicFieldEffectTriggerEvent.OnEnter))
		{
			TriggerEffectByDirection(TargetActor, mFDirectionVector, item);
		}
	}

	private void OnTargetLeaveMagicField(AActor TargetActor)
	{
		FVector mFDirectionVector = GetMFDirectionVector(TargetActor);
		foreach (MFDirectionEffectForData item in MFDirectionData.DirectionEffects.MultiFind(EMagicFieldEffectTriggerEvent.OnExit))
		{
			TriggerEffectByDirection(TargetActor, mFDirectionVector, item);
		}
	}

	private void OnTargetExistedWhenMagicFieldDead(AActor TargetActor)
	{
		FVector mFDirectionVector = GetMFDirectionVector(TargetActor);
		foreach (MFDirectionEffectForData item in MFDirectionData.DirectionEffects.MultiFind(EMagicFieldEffectTriggerEvent.OnDead))
		{
			TriggerEffectByDirection(TargetActor, mFDirectionVector, item);
		}
	}

	private void TriggerEffectByDirection(AActor TargetActor, FVector Direction, MFDirectionEffectForData DirectionEffect)
	{
		BGUMagicFieldBaseCS bGUMagicFieldBaseCS = GetOwner() as BGUMagicFieldBaseCS;
		if (bGUMagicFieldBaseCS.IsNullOrDestroyed() || TargetActor.IsNullOrDestroyed() || (!DirectionEffect.bIgnoreTypeFilter && (!BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTeamFilter(bGUMagicFieldBaseCS, TargetActor, DirectionEffect.TargetTeamFilter) || !BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTypeFilter(TargetActor, DirectionEffect.TargetTypeFilter))))
		{
			return;
		}
		FVector angleCenterVector = -Direction.GetSafeNormal();
		if (DirectionEffect.EffectDirectionType != EMagicFieldEffectDirectionType.FrontBack && DirectionEffect.EffectDirectionType != EMagicFieldEffectDirectionType.FrontBackLeftRight)
		{
			return;
		}
		FVector safeNormal = TargetActor.GetActorForwardVector().GetSafeNormal();
		FVector direction = safeNormal.Rotation().Add(0.0, 180.0, 0.0).Vector();
		if (IsDirectionInAngleRange(safeNormal, angleCenterVector, DirectionEffect.ForwardAngle))
		{
			base.BUSEventCollection.Evt_TriggerMagicFieldEffect.Invoke(TargetActor, DirectionEffect.bIgnoreTypeFilter, DirectionEffect.TargetTeamFilter, DirectionEffect.TargetTypeFilter, DirectionEffect.ForwardEffects);
		}
		if (IsDirectionInAngleRange(direction, angleCenterVector, DirectionEffect.BackwardAngle))
		{
			base.BUSEventCollection.Evt_TriggerMagicFieldEffect.Invoke(TargetActor, DirectionEffect.bIgnoreTypeFilter, DirectionEffect.TargetTeamFilter, DirectionEffect.TargetTypeFilter, DirectionEffect.BackwardEffects);
		}
		if (DirectionEffect.EffectDirectionType == EMagicFieldEffectDirectionType.FrontBackLeftRight)
		{
			FVector direction2 = safeNormal.Rotation().Add(0.0, -90.0, 0.0).Vector();
			FVector direction3 = safeNormal.Rotation().Add(0.0, 90.0, 0.0).Vector();
			if (IsDirectionInAngleRange(direction2, angleCenterVector, DirectionEffect.LeftSideAngle))
			{
				base.BUSEventCollection.Evt_TriggerMagicFieldEffect.Invoke(TargetActor, DirectionEffect.bIgnoreTypeFilter, DirectionEffect.TargetTeamFilter, DirectionEffect.TargetTypeFilter, DirectionEffect.LeftSideEffects);
			}
			if (IsDirectionInAngleRange(direction3, angleCenterVector, DirectionEffect.RightSideAngle))
			{
				base.BUSEventCollection.Evt_TriggerMagicFieldEffect.Invoke(TargetActor, DirectionEffect.bIgnoreTypeFilter, DirectionEffect.TargetTeamFilter, DirectionEffect.TargetTypeFilter, DirectionEffect.RightSideEffects);
			}
		}
	}

	private bool IsDirectionInAngleRange(FVector Direction, FVector AngleCenterVector, float AngleRangeDeg)
	{
		return MathLib.ClampAxis(MathLib.DegAcos(FVector.DotProduct(Direction, AngleCenterVector))) * 2f < AngleRangeDeg;
	}
}
