using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_MapSymbolSystem : PlayerControllerSystemBase
{
	private BPC_MapSymbolData MapSymbolData;

	private BPS_GSEventCollection EventCollection { get; set; }

	public override void OnAttach()
	{
		MapSymbolData = RequireWritableLocalPlayerStateData<BPC_MapSymbolData>();
		EventCollection = GetPlayerEventCollection();
		if (EventCollection != null)
		{
			EventCollection.Evt_SetMapSymbolState += new Del_SetMapSymbolState(OnSetMapSymbolState);
			EventCollection.Evt_SetMapSymbolActiveState += new Del_SetMapSymbolActiveState(OnSetMapSymbolActiveState);
			EventCollection.Evt_SetSelfDestination += new Del_Void_FVector(OnSetSelfDestination);
			EventCollection.Evt_TeamerSetDestination += new Del_TeamerSetDestination(OnTeamerSetDestination);
		}
	}

	public override void OnBeginPlay()
	{
		if (!UGSE_EngineFuncLib.IsStandAlone(Owner.World) && BGW_GameArchiveMgr.IsNetClient(Owner.World))
		{
			List<string> list = MapSymbolData.MapSymbolStateDict.Keys.ToList();
			for (int i = 0; i < list.Count; i++)
			{
				FUStMapSymbolDesc mapSymbolDesc = BGW_GameDB.GetMapSymbolDesc(list[i]);
				if (mapSymbolDesc != null && mapSymbolDesc.Type == BtlB1.EMapSymbolType.RebirthPoint)
				{
					MapSymbolData.MapSymbolStateDict.Remove(list[i]);
				}
			}
		}
		if (BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(Owner).CurrentLevelID == 98)
		{
			MapSymbolData.NeedCheckUnLock = true;
		}
	}

	public void OnSetMapSymbolState(string MapSymbolStateGuid, EMapSymbolState MapSymbolState)
	{
		MapSymbolData.SetMapSymbolState(MapSymbolStateGuid, MapSymbolState);
	}

	public void OnSetMapSymbolActiveState(string MapSymbolStateGuid, EMapSymbolActiveState MapSymbolState)
	{
		MapSymbolData.SetMapSymbolActiveDict(MapSymbolStateGuid, MapSymbolState);
	}

	public void OnSetSelfDestination(FVector DestinationPos)
	{
		MapSymbolData.SetDestinationPos(DestinationPos);
	}

	public void OnTeamerSetDestination(FVector DestinationPos)
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!MapSymbolData.NeedCheckUnLock)
		{
			return;
		}
		Dictionary<int, FUStMapSymbolDesc> allFUStMapSymbolDesc = BGW_GameDB.GetAllFUStMapSymbolDesc();
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation((GetOwner() as BGP_PlayerControllerB1).GetControlledPawn());
		foreach (KeyValuePair<int, FUStMapSymbolDesc> item in allFUStMapSymbolDesc)
		{
			FUStMapSymbolDesc value = item.Value;
			if (value.Type != BtlB1.EMapSymbolType.RebirthPoint && !MapSymbolData.MapSymbolStateDict.ContainsKey(value.Guid) && fVector.Z > value.SymbolPosZ && fVector.Z - value.SymbolPosZ < (float)value.UnlockHeight)
			{
				float num = fVector.X - value.SymbolPosX;
				float num2 = fVector.Y - value.SymbolPosY;
				if (num * num + num2 * num2 < (float)(value.UnlockRadius * value.UnlockRadius))
				{
					OnSetMapSymbolState(value.Guid, EMapSymbolState.Compelte);
				}
			}
		}
	}
}
