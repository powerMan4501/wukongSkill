using System.Collections.Generic;
using b1;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUC_DispLibDBCBaseData : BUC_DispLibDataBase, IPersistentECSData
{
	public Dictionary<FName, FName> InterfaceSockets;

	public AActor OwnerActor { get; protected set; }

	public DispLibDBCActorGroup ActorGroup { get; protected set; }

	public bool isSyncDispOwnerActorHiddenState { get; protected set; }

	public int RequestSyncDispOwnerActorHiddenStateATKPriority { get; protected set; }

	public USceneComponent DispOwnerComp { get; protected set; }

	public uint DispOwnerCompUniqueID { get; protected set; }

	public int ResID { get; protected set; }

	internal bool Init(USceneComponent _DispOwnerComp, DispLibDBCActorGroup _ActorGroup, AActor _OwnerActor = null)
	{
		DispOwnerComp = _DispOwnerComp;
		DispOwnerCompUniqueID = DispOwnerComp.GetUniqueID();
		InterfaceSockets = new Dictionary<FName, FName>();
		OwnerActor = _OwnerActor;
		ActorGroup = _ActorGroup;
		if (DispOwnerComp.IsNullOrDestroyed() && OwnerActor.IsNullOrDestroyed())
		{
			return false;
		}
		ResID = -1;
		if (OwnerActor is BGUCharacterCS unit)
		{
			ResID = BGU_DataUtil.GetActorResID(unit);
		}
		base.DataInitOver = true;
		return true;
	}

	internal void SetListenDispOwnerActorHiddenState(bool isListening, int ATKPriority)
	{
		isSyncDispOwnerActorHiddenState = isListening;
		RequestSyncDispOwnerActorHiddenStateATKPriority = ATKPriority;
	}

	internal void Reset()
	{
		base.DataInitOver = false;
		DispOwnerComp = null;
		OwnerActor = null;
		ActorGroup = DispLibDBCActorGroup.None;
		isSyncDispOwnerActorHiddenState = false;
		InterfaceSockets.Clear();
	}
}
