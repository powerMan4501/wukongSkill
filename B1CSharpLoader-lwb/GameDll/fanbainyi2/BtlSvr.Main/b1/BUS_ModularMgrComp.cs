using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_ModularMgrComp : UActorCompBaseCS
{
	private b1.BUC_ModularMgrData ModularMgrData;

	public override void OnAttach()
	{
		ModularMgrData = RequireWritableData<b1.BUC_ModularMgrData>();
		base.BUSEventCollection.Evt_ResetModularActor += new Del_Void(OnResetModularActor);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(this);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_NotifyTamerSpawnUnit += new Del_Void_String(OnTamerSpawnUnit);
		}
	}

	public override void OnBeginPlay()
	{
		BGUModularMgrActor bGUModularMgrActor = GetOwner() as BGUModularMgrActor;
		if (!(bGUModularMgrActor == null))
		{
			bGUModularMgrActor.ClearSpawnedModularActors();
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(this);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_NotifyTamerSpawnUnit -= new Del_Void_String(OnTamerSpawnUnit);
		}
	}

	private void OnResetModularActor()
	{
		BGUModularMgrActor bGUModularMgrActor = GetOwner() as BGUModularMgrActor;
		if (!(bGUModularMgrActor == null))
		{
			bGUModularMgrActor.SpawnModularActorsRuntime();
			SyncModularData(bGUModularMgrActor);
		}
	}

	private void SyncModularData(BGUModularMgrActor ModularMgrActor)
	{
		BUS_EventCollectionCS.Get(ModularMgrData.ContextTamerActor.GetMonster())?.Evt_SyncModularData.Invoke(ModularMgrActor.SpawnedModularActors.ToList(), ModularMgrData.bAutoAttachModularActors, ModularMgrData.bAutoSnapToGround, ModularMgrData.bDestroyAfterOwnerDeath, ModularMgrData.bNeedsCopyPose, ModularMgrData.ModularBreakDownProjectileMap);
	}

	private void OnTamerSpawnUnit(string TamerGuid)
	{
		BGUModularMgrActor bGUModularMgrActor = GetOwner() as BGUModularMgrActor;
		if (!(bGUModularMgrActor == null) && !(TamerGuid != ModularMgrData.ContextTamerActor.GetFinalGuid()))
		{
			OnResetModularActor();
			BUS_EventCollectionCS.Get(ModularMgrData.ContextTamerActor.GetMonster())?.Evt_SyncModularMgr.Invoke(bGUModularMgrActor);
		}
	}
}
