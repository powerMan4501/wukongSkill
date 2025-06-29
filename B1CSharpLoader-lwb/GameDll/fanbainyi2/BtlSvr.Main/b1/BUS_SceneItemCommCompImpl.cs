using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SceneItemCommCompImpl : UActorCompBaseCS
{
	private BUC_SceneItemCommData SceneItemCommData;

	public override void OnAttach()
	{
		SceneItemCommData = RequireWritableData<BUC_SceneItemCommData>();
		base.BUSEventCollection.Evt_SceneItemAddImpulse += new Del_SceneItemAddImpulse(OnSceneItemAddImpulse);
		base.BUSEventCollection.Evt_SceneItemSetDelayEnableCollTime += new Del_Void_Float(OnSceneItemSetDelayEnableCollTime);
		base.BUSEventCollection.Evt_SceneItemAttach += new Del_SceneItemAttach(OnSceneItemAttach);
		base.BUSEventCollection.Evt_SetSceneItemCanBeSelected += new Del_Void_Bool(OnSetSceneItemCanBeSelected);
		base.BUSEventCollection.Evt_ResetActorStatus += new Del_Void_ResetActorReason(OnResetActorStatus);
	}

	public override void OnBeginPlay()
	{
		BGUSceneItemBase bGUSceneItemBase = GetOwner() as BGUSceneItemBase;
		if (bGUSceneItemBase != null)
		{
			base.BGSEventCollection.Evt_RegisterSceneItem.Invoke(bGUSceneItemBase);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForEnableCollision(DeltaTime);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGUSceneItemBase bGUSceneItemBase = GetOwner() as BGUSceneItemBase;
		if (bGUSceneItemBase != null)
		{
			base.BGSEventCollection.Evt_UnregisterSceneItem.Invoke(bGUSceneItemBase);
		}
	}

	private void TickForEnableCollision(float DeltaTime)
	{
		if (SceneItemCommData.DelayEnableCollisionTimer > 0f)
		{
			SceneItemCommData.DelayEnableCollisionTimer -= DeltaTime;
			if (SceneItemCommData.DelayEnableCollisionTimer <= 0f)
			{
				BGUSceneItemBase obj = GetOwner() as BGUSceneItemBase;
				obj.StaticMeshComp.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponseType.ECR_Block);
				obj.StaticMeshComp.SetCollisionResponseToChannel(ECollisionChannel.ECC_PhysicsBody, ECollisionResponseType.ECR_Block);
			}
		}
	}

	private void OnSceneItemAttach(USceneComponent Parent, FName SocketName)
	{
		AActor owner = GetOwner();
		if (owner != null)
		{
			BGUSceneItemBase bGUSceneItemBase = owner as BGUSceneItemBase;
			if (bGUSceneItemBase != null)
			{
				bGUSceneItemBase.StaticMeshComp.SetSimulatePhysics(bSimulate: false);
				bGUSceneItemBase.StaticMeshComp.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponseType.ECR_Ignore);
				bGUSceneItemBase.StaticMeshComp.SetCollisionResponseToChannel(ECollisionChannel.ECC_PhysicsBody, ECollisionResponseType.ECR_Ignore);
				bGUSceneItemBase.AttachToComponent(Parent, SocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
			}
		}
	}

	private void OnSetSceneItemCanBeSelected(bool CanBeSelect)
	{
	}

	private void OnResetActorStatus(EResetActorReason ResetReason)
	{
		AActor owner = GetOwner();
		if (!(owner == null) && SceneItemCommData.NeedClosePhysicWhenReset)
		{
			BGUSceneItemBase bGUSceneItemBase = owner as BGUSceneItemBase;
			if (bGUSceneItemBase != null)
			{
				bGUSceneItemBase.StaticMeshComp.SetSimulatePhysics(bSimulate: false);
				bGUSceneItemBase.StaticMeshComp.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponseType.ECR_Block);
				bGUSceneItemBase.StaticMeshComp.SetCollisionResponseToChannel(ECollisionChannel.ECC_PhysicsBody, ECollisionResponseType.ECR_Block);
			}
		}
	}

	private void OnSceneItemSetDelayEnableCollTime(float DelayEnableeCollisionTime)
	{
		SceneItemCommData.DelayEnableCollisionTimer = DelayEnableeCollisionTime;
		if (SceneItemCommData.DelayEnableCollisionTimer > 0f)
		{
			BGUSceneItemBase bGUSceneItemBase = GetOwner() as BGUSceneItemBase;
			if (bGUSceneItemBase != null)
			{
				bGUSceneItemBase.StaticMeshComp.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponseType.ECR_Ignore);
				bGUSceneItemBase.StaticMeshComp.SetCollisionResponseToChannel(ECollisionChannel.ECC_PhysicsBody, ECollisionResponseType.ECR_Ignore);
			}
		}
	}

	private void OnSceneItemAddImpulse(FVector FinalImpulse)
	{
		AActor owner = GetOwner();
		if (owner != null)
		{
			(owner as BGUSceneItemBase).StaticMeshComp.AddImpulse(FinalImpulse, FName.None, bVelChange: true);
		}
	}
}
