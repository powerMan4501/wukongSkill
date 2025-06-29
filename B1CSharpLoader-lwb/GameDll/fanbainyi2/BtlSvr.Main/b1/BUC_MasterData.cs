using b1.ECS;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1;

public class BUC_MasterData : IBUC_MasterData, IPersistentECSDataWithDestroyCB, IPersistentECSData
{
	[GSGameDataSnapShot]
	private EntitySharedRef _Master { get; set; }

	public int _MasterResID { get; set; }

	private int _MasterBattleInfoID { get; set; }

	public bool IsMasterHiddenInGame()
	{
		AActor masterActor = GetMasterActor();
		if (masterActor != null && USystemLibrary.IsValid(masterActor))
		{
			return masterActor.Hidden;
		}
		return true;
	}

	public AActor GetMasterActor()
	{
		return EntitySharedRefFuncLib.Actor(_Master);
	}

	public IBGUActorI GetMaster()
	{
		return GetMasterActor() as IBGUActorI;
	}

	public void SetMaster(AActor MasterActor)
	{
		_Master = new EntitySharedRef(MasterActor);
		_MasterResID = BGU_DataUtil.GetActorResID(MasterActor);
		_MasterBattleInfoID = BGU_DataUtil.GetFinalBattleInfoExtendID(MasterActor);
	}

	public void OnUnPersistentDestroy()
	{
		_Master = null;
	}

	public int GetMasterResID()
	{
		return _MasterResID;
	}

	public int GetMasterBattleInfoID()
	{
		return _MasterBattleInfoID;
	}
}
