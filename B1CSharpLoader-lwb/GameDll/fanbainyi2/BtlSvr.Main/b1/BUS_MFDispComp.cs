using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MFDispComp : UActorCompBaseCS
{
	private BUC_ProjectileBasicData ProjectileBasicData { get; set; }

	private BUC_MFDispData DispData { get; set; }

	private IBUC_MFOverlapData OverlapData { get; set; }

	private IBUC_GuidData GuidData { get; set; }

	public override void OnAttach()
	{
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		DispData = RequireWritableData<BUC_MFDispData>();
		OverlapData = RequireReadOnlyData<IBUC_MFOverlapData, BUC_MFOverlapData>();
		base.BUSEventCollection.Evt_ProjectileInitialization += new Del_ProjectileInitialization(OnMagicFieldInit);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnMagicFieldDead);
		base.BUSEventCollection.Evt_AddAvoidanceMagicField += new Del_Void_Actor(OnAddAvoidanceMagicField);
		base.BUSEventCollection.Evt_RemoveAvoidanceMagicField += new Del_Void_Actor(OnRemoveAvoidanceMagicField);
	}

	private void OnMagicFieldInit(FGSProjectileSpawnInfo ProjectileSpawnInfo, AActor MasterActor)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (!(bGUProjectileBaseActor == null) && !bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			DispData.IsSphereMF = ProjectileBasicData.CheckShapeType == EProjectileCheckShapeType.SphereShape;
			DispData.SphereComp = bGUProjectileBaseActor.GetSphereCollisionComp();
			if (DispData != null && DispData.bUseGlobalFX && DispData.IsSphereMF && DispData.SphereComp != null)
			{
				base.BGSEventCollection.Evt_AddMFSphereInfo2GlobalFX.Invoke(DispData.FXTag, Owner, DispData.SphereComp.GetScaledSphereRadius(), BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner));
			}
		}
	}

	private void OnMagicFieldDead(EBGUBulletDestroyReason Reason)
	{
		if (DispData != null && DispData.bUseGlobalFX && DispData.IsSphereMF && DispData.SphereComp != null)
		{
			base.BGSEventCollection.Evt_RemoveMFSphereInfo2GlobalFX.Invoke(DispData.FXTag, Owner);
		}
	}

	private void OnAddAvoidanceMagicField(AActor Actor)
	{
		if (OverlapData.bNeedAvoid)
		{
			IBUC_MFDispData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MFDispData>(Actor);
			if (unPersistentReadOnlyData != null && Actor != null && unPersistentReadOnlyData.IsSphereMF)
			{
				base.BGSEventCollection.Evt_AddMFAvoidanceSphereInfo2GlobalFX.Invoke(DispData.FXTag, Owner, unPersistentReadOnlyData.SphereComp.GetScaledSphereRadius(), BGUFuncLibActorTransformCS.BGUGetActorLocation(Actor));
			}
		}
	}

	private void OnRemoveAvoidanceMagicField(AActor Actor)
	{
		if (OverlapData.bNeedAvoid && Actor != null)
		{
			base.BGSEventCollection.Evt_RemoveMFAvoidanceSphereInfo2GlobalFX.Invoke(DispData.FXTag, Owner);
		}
	}
}
