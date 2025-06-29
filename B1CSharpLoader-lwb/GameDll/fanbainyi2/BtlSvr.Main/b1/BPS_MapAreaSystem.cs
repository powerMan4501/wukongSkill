using System.Linq;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_MapAreaSystem : PlayerControllerSystemBase
{
	private BPC_MapAreaData MapAreaData { get; set; }

	private APawn Player => base.PlayerController?.GetControlledPawn();

	public override void OnAttach()
	{
		MapAreaData = RequireWritableLocalPlayerStateData<BPC_MapAreaData>();
		GetBPSEventCollection().Evt_ExploreGeoInfoArea += new Del_Void_IntInt(OnExploreGeoInfoArea);
	}

	public override void OnBeginPlay()
	{
		UpdateAreaId();
		BGW_EventCollection.Get(Owner).Evt_RegisterFetchDebugInfoFunc("MapArea", FetchDebugInfo);
	}

	private void FetchDebugInfo(out FGSDisplayDebugInfo Info)
	{
		Info = new FGSDisplayDebugInfo();
		if (MapAreaData.TryGetMapAreaInfoByPlayer(Owner, out var Param))
		{
			Info.AppendInfo($"玩家坐标【X:{Param.Location.X:F2}, Y:{Param.Location.Y:F2}, Z:{Param.Location.Z:F2}】");
			Info.AppendInfo($"玩家所在关卡【{Param.LevelId}】");
			if (Param.IsSupportMapLayer)
			{
				Info.AppendInfo($"玩家所在层级【{Param.MapLayer}】");
			}
			Info.AppendInfo($"玩家所在区域【{Param.AreaId}】");
		}
		else
		{
			Info.AppendInfo($"玩家坐标【X:{Param.Location.X:F2}, Y:{Param.Location.Y:F2}, Z:{Param.Location.Z:F2}】");
			Info.AppendInfo($"玩家所在关卡【{Param.LevelId}】");
			if (Param.IsSupportMapLayer)
			{
				Info.AppendInfo($"玩家所在层级【{Param.MapLayer}】");
			}
			Info.AppendInfo("玩家所在地方未配置区域", FColor.IndianRed);
		}
		if (MapAreaData.TryGetMapPositionByPlayer(Owner, out var MapSpriteId, out var MapPosition, out var MapRotation))
		{
			Info.AppendInfo($"玩家所在MapSprite为【{MapSpriteId}】");
			Info.AppendInfo($"玩家所在地图位置为【X:{MapPosition.X:F2}, Y:{MapPosition.Y:F2}】");
			Info.AppendInfo($"玩家在地图中的方向为【{MapRotation}】");
			Info.AppendInfo($"玩家实际方向为【{BGUFuncLibActorTransformCS.BGUGetActorRotation(Player).Yaw}】");
			ABGU3rdCameraBase aBGU3rdCameraBase = UGameplayStatics.GetAllActorsOfClass<ABGU3rdCameraBase>(Owner).FirstOrDefault();
			if (!aBGU3rdCameraBase.IsNullOrDestroyed())
			{
				Info.AppendInfo($"玩家摄像头的方向为【{BGUFuncLibActorTransformCS.BGUGetActorRotation(aBGU3rdCameraBase).Yaw}】");
			}
			if (MapAreaData.TryGetAreaId(Owner, MapSpriteId, MapPosition, out var AreaId))
			{
				Info.AppendInfo($"玩家通过地图位置换算为的Area Id为【{AreaId}】");
			}
			else
			{
				Info.AppendInfo("玩家无法通过地图位置换算为的Area Id");
			}
		}
		else
		{
			Info.AppendInfo("当前玩家所处地图不支持获取地图位置", FColor.IndianRed);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		MapAreaData.Reset();
		BGW_EventCollection.Get(Owner).Evt_UnRegisterFetchDebugInfoFunc("MapArea");
	}

	private void OnExploreGeoInfoArea(int NewAreaId, int NewMapSpriteId)
	{
		if (DebugConfig.DebugMap)
		{
			SendMessage($"在关卡【{BGUFuncLibMap.GetCurLevelId(Owner)}】中进入了区域【{NewAreaId}】，对应的SpriteId为【{NewMapSpriteId}】");
		}
	}

	private void SendMessage(string Message)
	{
		BGW_UIEventCollection.Get(Owner).Evt_UI_ShowGMTips(Message);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CheckCanUpdate())
		{
			UpdateAreaId();
		}
		if (DebugConfig.DebugMap)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Player);
			BUS_EventCollectionCS.Get(Player)?.Evt_UpdateDebugUIInfo.Invoke("DebugMap", $"玩家坐标【X:{fVector.X:F2}, Y:{fVector.Y:F2}, Z:{fVector.Z:F2}】", 1);
			BUS_EventCollectionCS.Get(Player)?.Evt_UpdateDebugUIInfo.Invoke("DebugMap", $"玩家所在关卡【{BGUFuncLibMap.GetCurLevelId(Owner)}】，玩家所在区域【{MapAreaData.CurrentAreaId.Value}】", 2);
		}
		bool CheckCanUpdate()
		{
			if (MapAreaData.CurrentUpdateTimer > 0)
			{
				BPC_MapAreaData mapAreaData = MapAreaData;
				int currentUpdateTimer = mapAreaData.CurrentUpdateTimer - 1;
				mapAreaData.CurrentUpdateTimer = currentUpdateTimer;
				return false;
			}
			MapAreaData.CurrentUpdateTimer = 10;
			return true;
		}
	}

	private void UpdateAreaId()
	{
		using (new b1.FMapSpriteScope())
		{
			if (MapAreaData.TryGetAreaId(Player, out var AreaId))
			{
				int mapSpriteId = MapAreaData.GetMapSpriteId();
				if (MapAreaData.CurrentAreaId.Value != AreaId || MapAreaData.CurrentSpriteId.Value != mapSpriteId)
				{
					MapAreaData.CurrentAreaId.SetValue(EChangeReason.InnerOp, AreaId);
					MapAreaData.CurrentSpriteId.SetValue(EChangeReason.InnerOp, mapSpriteId);
					GetBPSEventCollection().Evt_ExploreGeoInfoArea.Invoke(AreaId, mapSpriteId);
				}
			}
		}
	}
}
