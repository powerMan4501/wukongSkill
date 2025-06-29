using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_CollisionProfileMgr : UActorCompBaseCS
{
	private BUC_CollisionProfileMgrData CollisionPresetMgrData;

	public override void OnAttach()
	{
		CollisionPresetMgrData = RequireWritableData<BUC_CollisionProfileMgrData>();
		base.BUSEventCollection.Evt_OnEnableAssistCollision += new Del_Void_Bool(OnEnableAssistCollision);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(ResetActorStatusPre);
		base.BUSEventCollection.Evt_OnSetBodiesCollisionEnable += new Del_OnSetBodiesCollisionEnable(Event_OnSetBodiesCollisionEnable);
		base.BUSEventCollection.Evt_ResetBodiesCollisionEnable += new Del_Void(OnResetBodiesCollisionEnable);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
	}

	public override void OnBeginPlay()
	{
		if (Owner is BGUPlayerCharacterCS)
		{
			OnEnableAssistCollision(Enable: false);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	private void OnEnableAssistCollision(bool Enable)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		foreach (UActorComponent item in owner.GetComponentsByTag(UClass.GetClass<UBoxComponent>(), B1GlobalFNames.AssistCollision))
		{
			UBoxComponent uBoxComponent = item as UBoxComponent;
			if (!(uBoxComponent == null))
			{
				ECollisionEnabled collisionEnabled = (Enable ? ECollisionEnabled.QueryAndPhysics : ECollisionEnabled.NoCollision);
				uBoxComponent.SetCollisionEnabled(collisionEnabled);
				if (!Enable)
				{
					DetachCollisionComp(uBoxComponent);
				}
				else
				{
					ReattachCollisionComp(uBoxComponent);
				}
			}
		}
	}

	private void DetachCollisionComp(UPrimitiveComponent Comp)
	{
		if (!(Comp == null))
		{
			FPrimitiveCompCollisionInfoTemp value = new FPrimitiveCompCollisionInfoTemp(Comp);
			CollisionPresetMgrData.PrimitiveCompCollisionInfoTempDic[Comp] = value;
			Comp.DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			Comp.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			Comp.Deactivate();
		}
	}

	private void ReattachCollisionComp(UPrimitiveComponent Comp)
	{
		if (CollisionPresetMgrData.PrimitiveCompCollisionInfoTempDic.TryGetValue(Comp, out var value))
		{
			Comp.AttachToComponent(value.AttachedComp, value.AttachSocketName, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
			Comp.SetRelativeTransform(value.RelativeTransform, bSweep: false, out var _, bTeleport: true);
			Comp.SetCollisionEnabled(value.CollisionType);
			Comp.Activate();
			CollisionPresetMgrData.PrimitiveCompCollisionInfoTempDic.Remove(Comp);
		}
	}

	private void ResetActorStatusPre(EResetActorReason ResetReason)
	{
		OnResetBodiesCollisionEnable();
	}

	private void Event_OnSetBodiesCollisionEnable(List<FName> BoneNames, bool Enable)
	{
		ECollisionEnabled enabledType = (Enable ? ECollisionEnabled.QueryAndPhysics : ECollisionEnabled.NoCollision);
		OnSetBodiesCollisionEnable(BoneNames, enabledType);
	}

	private bool OnSetBodiesCollisionEnable(List<FName> BoneNames, ECollisionEnabled EnabledType, bool bRecordForReset = true)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return false;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		if (mesh == null)
		{
			return false;
		}
		foreach (FName BoneName in BoneNames)
		{
			ECollisionEnabled bodyInstanceShapeCollisionEnable = UGSE_SkeletalMeshFuncLib.GetBodyInstanceShapeCollisionEnable(mesh, BoneName, 0);
			if (bRecordForReset)
			{
				if (!CollisionPresetMgrData.PortionPACollisionEnable_Temp_ForReset.ContainsKey(bodyInstanceShapeCollisionEnable))
				{
					CollisionPresetMgrData.PortionPACollisionEnable_Temp_ForReset.Add(bodyInstanceShapeCollisionEnable, new List<FName>());
				}
				CollisionPresetMgrData.PortionPACollisionEnable_Temp_ForReset[bodyInstanceShapeCollisionEnable].Add(BoneName);
			}
			UGSE_SkeletalMeshFuncLib.SetBodyInstanceShapeCollisionEnable(mesh, BoneName, 0, EnabledType);
		}
		return true;
	}

	private void OnResetBodiesCollisionEnable()
	{
		foreach (KeyValuePair<ECollisionEnabled, List<FName>> item in CollisionPresetMgrData.PortionPACollisionEnable_Temp_ForReset)
		{
			OnSetBodiesCollisionEnable(item.Value, item.Key, bRecordForReset: false);
		}
		CollisionPresetMgrData.PortionPACollisionEnable_Temp_ForReset.Clear();
	}
}
