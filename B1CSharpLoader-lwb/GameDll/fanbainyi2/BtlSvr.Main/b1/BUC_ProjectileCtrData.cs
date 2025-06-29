using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ProjectileCtrData : IPersistentECSDataWithDestroyCB, IPersistentECSData, IBUC_ProjectileCtrlData
{
	public UnorderedDict<uint, GSProjectileSpawnEventBase> ProjectileSpawnEvents;

	public Dictionary<FName, Dictionary<FName, BGUProjectileBaseActor>> SlotBulletPack;

	public bool EnableSwitch;

	public List<BGUProjectileBaseActor> CurSwitchList;

	public int CurBulletSwitchID;

	public float IntervalTime;

	public float IntervalTimer;

	public int CurSwitchIdx;

	public Dictionary<int, EntitySharedRefList> PassiveTargetQueue;

	public Dictionary<int, EntitySharedRefDic<float>> PassiveProtectTimerMap;

	public List<PCSEW_Base> PCSEW_Registry;

	public Dictionary<int, uint> SpawnReqMap_Notify;

	public Dictionary<int, List<uint>> SpawnReqMap_Buff;

	public List<BGUProjectileBaseActor> ProjectileList { get; set; }

	private uint UniqueID_SpawnEvent { get; set; }

	public uint RequestNewUniqueID()
	{
		if (UniqueID_SpawnEvent == uint.MaxValue)
		{
			UniqueID_SpawnEvent = 0u;
		}
		else
		{
			UniqueID_SpawnEvent++;
		}
		return UniqueID_SpawnEvent;
	}

	public BUC_ProjectileCtrData()
	{
		ProjectileSpawnEvents = new UnorderedDict<uint, GSProjectileSpawnEventBase>();
		ProjectileList = new List<BGUProjectileBaseActor>();
		SlotBulletPack = new Dictionary<FName, Dictionary<FName, BGUProjectileBaseActor>>();
		EnableSwitch = false;
		CurSwitchList = new List<BGUProjectileBaseActor>();
		CurBulletSwitchID = 0;
		IntervalTimer = 0f;
		CurSwitchIdx = 0;
		PassiveTargetQueue = new Dictionary<int, EntitySharedRefList>();
		PassiveProtectTimerMap = new Dictionary<int, EntitySharedRefDic<float>>();
		PCSEW_Registry = new List<PCSEW_Base>();
		SpawnReqMap_Notify = new Dictionary<int, uint>();
		SpawnReqMap_Buff = new Dictionary<int, List<uint>>();
	}

	public void OnUnPersistentDestroy()
	{
		PassiveTargetQueue.Clear();
		PassiveProtectTimerMap.Clear();
	}

	public int GetAllCtrableProjectilesByID(int ProjectileID, out List<BGUProjectileBaseActor> OutProjectileList)
	{
		OutProjectileList = new List<BGUProjectileBaseActor>();
		if (ProjectileList == null)
		{
			return 0;
		}
		for (int i = 0; i < ProjectileList.Count; i++)
		{
			if (ProjectileList[i].GetProjectileID() == ProjectileID)
			{
				OutProjectileList.Add(ProjectileList[i]);
			}
		}
		return OutProjectileList.Count;
	}
}
