using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_ActorTransformInfoComp : UActorCompBaseCS
{
	private BUC_ActorTransformInfoData ActorTransformInfoData;

	private bool IsStandAlone;

	private bool IsLocallyControlled;

	protected virtual bool IsNoMoveComp => false;

	public override void OnAttach()
	{
		ActorTransformInfoData = RequireWritableData<BUC_ActorTransformInfoData>();
		ActorTransformInfoData.InitOwnerActor(GetOwner());
		base.BUSEventCollection.Evt_SetActorTransform += new Del_SetActorTransform(OnSetActorTransform);
		base.BUSEventCollection.Evt_SetActorLocation += new Del_SetActorLocation(OnSetActorLocation);
		base.BUSEventCollection.Evt_SetActorRotation += new Del_SetActorRotation(OnSetActorRotation);
		base.BUSEventCollection.Evt_SetActorLocationAndRotation += new Del_SetActorLocationAndRotation(OnSetActorLocationAndRotation);
		base.BUSEventCollection.Evt_ClearActorTransformCache += new Del_Void(OnClearActorTransformCache);
		base.BUSEventCollection.Evt_ActorForceUpdateTransform += new Del_Void(OnForceUpdate);
		base.BUSEventCollection.Evt_SetActorLocationGM += new Del_SetActorLocation(OnSetActorLocation);
	}

	public override void PreBeginPlay()
	{
		IsStandAlone = UGSE_EngineFuncLib.IsStandAlone(Owner.World);
		IsLocallyControlled = OwnerAsCharacterCS != null && OwnerAsCharacterCS.IsLocallyControlled();
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override int GetTickGroupMask()
	{
		return 258;
	}

	private void OnForceUpdate()
	{
		UpdateTransform();
		_ = IsNoMoveComp;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateTransform();
	}

	private void UpdateTransform()
	{
		AActor owner = GetOwner();
		if (owner == null || (!ActorTransformInfoData.NeedUpdate && !IsNoMoveComp))
		{
			return;
		}
		bool flag = true;
		ActorFuncLib.GetActorTransformSimple(owner.Address, out var OutTrans);
		if (ActorTransformInfoData.OriginTransform == OutTrans)
		{
			BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
			if ((!ActorTransformInfoData.bTeleport || !IsStandAlone) && bGUCharacterCS != null && bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent != null)
			{
				flag = false;
			}
			if (flag)
			{
				int iTeleportType = (ActorTransformInfoData.bTeleport ? 1 : 0);
				ActorFuncLib.SetActorTransformSimple(owner.Address, ActorTransformInfoData.NextUpdateTransform, ActorTransformInfoData.bSweep, iTeleportType);
			}
			if (bGUCharacterCS != null)
			{
				UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
				if (uBGUCharacterMovementComponent != null && IsLocallyControlled)
				{
					FVector location = ActorTransformInfoData.NextUpdateTransform.GetLocation();
					FRotator fRotator = ActorTransformInfoData.NextUpdateTransform.Rotator();
					if (location != OutTrans.GetLocation())
					{
						BGW_NativeFuncs.SetCSharpAdjustLocation(uBGUCharacterMovementComponent.Address, location);
					}
					if (fRotator != OutTrans.Rotator())
					{
						BGW_NativeFuncs.SetCSharpAdJustRotation(uBGUCharacterMovementComponent.Address, fRotator);
					}
				}
			}
		}
		OnClearActorTransformCache();
	}

	private void OnClearActorTransformCache()
	{
		ActorTransformInfoData.NeedUpdate = false;
		ActorTransformInfoData.bSweep = false;
		ActorTransformInfoData.bTeleport = false;
	}

	private void OnSetActorTransform(FTransform NewTransform, bool bSweep, bool bTeleport)
	{
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			ActorFuncLib.GetActorTransformSimple(owner.Address, out var OutTrans);
			ActorTransformInfoData.OriginTransform = OutTrans;
			ActorTransformInfoData.NeedUpdate = true;
			ActorTransformInfoData.NextUpdateTransform = NewTransform;
			ActorTransformInfoData.bSweep = bSweep;
			ActorTransformInfoData.bTeleport = bTeleport;
			bool flag = false;
			if (!IsStandAlone && bTeleport)
			{
				flag = true;
				UpdateTransform();
				ActorFuncLib.SetActorTransformSimple(owner.Address, ActorTransformInfoData.NextUpdateTransform, ActorTransformInfoData.bSweep, ActorTransformInfoData.bTeleport ? 1 : 0);
			}
			if (IsNoMoveComp && !flag)
			{
				UpdateTransform();
			}
		}
	}

	private void OnSetActorLocation(FVector NewLocation, bool bSweep, bool bTeleport)
	{
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			ActorFuncLib.GetActorTransformSimple(owner.Address, out var OutTrans);
			FTransform nextUpdateTransform = OutTrans;
			if (ActorTransformInfoData.NeedUpdate && ActorTransformInfoData.OriginTransform == OutTrans)
			{
				nextUpdateTransform = ActorTransformInfoData.NextUpdateTransform;
			}
			nextUpdateTransform.SetLocation(NewLocation);
			ActorTransformInfoData.NeedUpdate = true;
			ActorTransformInfoData.NextUpdateTransform = nextUpdateTransform;
			ActorTransformInfoData.bSweep = bSweep;
			ActorTransformInfoData.bTeleport = bTeleport;
			ActorTransformInfoData.OriginTransform = OutTrans;
			if (IsNoMoveComp)
			{
				UpdateTransform();
			}
		}
	}

	private void OnSetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
	{
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			ActorFuncLib.GetActorTransformSimple(owner.Address, out var OutTrans);
			FTransform nextUpdateTransform = OutTrans;
			if (ActorTransformInfoData.NeedUpdate && ActorTransformInfoData.OriginTransform == OutTrans)
			{
				nextUpdateTransform = ActorTransformInfoData.NextUpdateTransform;
			}
			nextUpdateTransform.SetRotation(NewRotation.Quaternion());
			ActorTransformInfoData.NeedUpdate = true;
			ActorTransformInfoData.NextUpdateTransform = nextUpdateTransform;
			ActorTransformInfoData.bTeleport = bTeleportPhysics;
			ActorTransformInfoData.OriginTransform = OutTrans;
			if (IsNoMoveComp)
			{
				UpdateTransform();
			}
		}
	}

	private void OnSetActorLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, bool bTeleport)
	{
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			ActorFuncLib.GetActorTransformSimple(owner.Address, out var OutTrans);
			FTransform nextUpdateTransform = OutTrans;
			if (ActorTransformInfoData.NeedUpdate && ActorTransformInfoData.OriginTransform == OutTrans)
			{
				nextUpdateTransform = ActorTransformInfoData.NextUpdateTransform;
			}
			nextUpdateTransform.SetRotation(new FQuat(NewRotation));
			nextUpdateTransform.SetLocation(NewLocation);
			ActorTransformInfoData.NeedUpdate = true;
			ActorTransformInfoData.NextUpdateTransform = nextUpdateTransform;
			ActorTransformInfoData.bSweep = bSweep;
			ActorTransformInfoData.bTeleport = bTeleport;
			ActorTransformInfoData.OriginTransform = OutTrans;
			if (IsNoMoveComp)
			{
				UpdateTransform();
			}
		}
	}
}
