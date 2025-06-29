using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_BulletDispManagedComp : UActorCompBaseCS
{
	private List<int> DBCReqIDList;

	public override void OnBeginPlay()
	{
		DBCReqIDList = new List<int>();
		base.BUSEventCollection.Evt_NotifyBulletMarkDBCReqID += new Del_Void_Int(OnNotifyBulletMarkDBCReqID);
		if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(GetOwner()))
		{
			return;
		}
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (!(bGUProjectileBaseActor != null))
		{
			return;
		}
		FUStProjectileDispDesc projectileDispDesc = BGW_GameDB.GetProjectileDispDesc(bGUProjectileBaseActor.GetProjectileID());
		if (projectileDispDesc != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUProjectileBaseActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(projectileDispDesc.ProjectileSelfSpawnDBCPath, out var RequestID, bGUProjectileBaseActor.RootComponent);
				bUS_GSEventCollection.Evt_NotifyBulletMarkDBCReqID.Invoke(RequestID);
			}
		}
	}

	private void OnNotifyBulletIsDead()
	{
		for (int num = DBCReqIDList.Count - 1; num >= 0; num--)
		{
			base.BUSEventCollection?.Evt_RequestDestroyByFXRequestID.Invoke(DBCReqIDList[num]);
			DBCReqIDList.RemoveAt(num);
		}
	}

	private void OnNotifyBulletMarkDBCReqID(int ReqID)
	{
		if (!DBCReqIDList.Contains(ReqID))
		{
			DBCReqIDList.Add(ReqID);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		OnNotifyBulletIsDead();
	}
}
