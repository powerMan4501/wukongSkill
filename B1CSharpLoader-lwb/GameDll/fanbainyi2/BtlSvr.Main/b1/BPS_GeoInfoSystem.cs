using System;
using System.Collections.Generic;
using ArchiveB1;
using b1.BGW;
using b1.EventDelDefine;
using b1.Localization;
using BtlB1;
using CommB1;
using ResB1;

namespace b1;

public class BPS_GeoInfoSystem : PlayerControllerSystemBase
{
	private BPC_GeoInfoData GeoInfoData;

	private IBPC_PlayerRoleData PlayerRoleData;

	private IBPC_RebirthPointData RebirthPointData;

	private BPS_GSEventCollection EventCollection { get; set; }

	public override void OnAttach()
	{
		GeoInfoData = RequireWritableLocalPlayerControlData<BPC_GeoInfoData>();
		RebirthPointData = RequireReadOnlyControlledPlayerControlData<IBPC_RebirthPointData, BPC_RebirthPointData>();
		PlayerRoleData = RequireReadOnlyControlledPlayerControlData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
		EventCollection = GetPlayerEventCollection();
		if (EventCollection != null)
		{
			EventCollection.Evt_ActiveRebirthPoint += new Del_Void_IntBool(OnActiveRebirthPoint);
			EventCollection.Evt_ActiveGeoInfoArea += new Del_Void_IntInt(OnActiveGeoInfoArea);
			EventCollection.Evt_ExploreGeoInfoArea += new Del_Void_IntInt(OnExploreGeoInfoArea);
			EventCollection.Evt_AddGeoInfoCustom += new Del_Void_GeoInfoCustom(OnAddGeoInfoCustom);
			EventCollection.Evt_RemoveGeoInfoCustom += new Del_Void_Int(OnRemoveGeoInfoCustom);
			EventCollection.Evt_ClearAllGeoInfoCustom += new Del_Void(OnClearAllGeoInfoCustom);
			EventCollection.Evt_GMClearAllArea += new Del_Void(OnGMClearAllArea);
			EventCollection.Evt_GMActiveRebirthPointArea += new Del_Void_Int(OnGMActiveRebirthPointArea);
			EventCollection.Evt_GMCheckRebirthPointArea += new Del_Void(OnGMCheckRebirthPointArea);
		}
	}

	public override void OnBeginPlay()
	{
		InitGeoInfoData();
	}

	private void OnGMClearAllArea()
	{
		if (GeoInfoData != null && GeoInfoData.AreaPointGeoInfoList != null)
		{
			for (int i = 0; i < GeoInfoData.AreaPointGeoInfoList.Count; i++)
			{
				GeoInfoData.AreaPointGeoInfoList[i].GeoAreaState = EGeoAreaState.Disable;
			}
		}
	}

	private void OnGMActiveRebirthPointArea(int RebirthPointId)
	{
		TBMapAreaConfigDesc tBMapAreaConfigDesc = GameDBRuntime.GetTBMapAreaConfigDesc();
		if (tBMapAreaConfigDesc == null)
		{
			return;
		}
		foreach (MapAreaConfigDesc item in tBMapAreaConfigDesc.List)
		{
			GeoInfoAreaData geoInfoAreaData = new GeoInfoAreaData();
			geoInfoAreaData.LevelId = item.LevelId;
			geoInfoAreaData.AreaId = item.AreaId;
			geoInfoAreaData.MapSpriteId = item.MapSpriteId;
			geoInfoAreaData.GeoAreaState = EGeoAreaState.Disable;
			if (GameDBRuntime.GetLevelDesc(geoInfoAreaData.LevelId) == null)
			{
				continue;
			}
			BGWDataAsset_RebirthGeoInfo rebirthGeoInfo = BGW_PreloadAssetMgr.Get(this).RebirthGeoInfo;
			if (!(rebirthGeoInfo != null))
			{
				continue;
			}
			foreach (KeyValuePair<int, FGeoAreaIdListInfo> item2 in rebirthGeoInfo.RebirthAreaConfig)
			{
				if (item2.Key != RebirthPointId)
				{
					continue;
				}
				foreach (int areaId in item2.Value.AreaIdList)
				{
					int num = areaId % 1000;
					int num2 = areaId / 1000;
					if (num == item.AreaId && num2 == item.AreaId)
					{
						geoInfoAreaData.GeoAreaState = EGeoAreaState.Actived;
					}
				}
			}
		}
	}

	private void OnGMCheckRebirthPointArea()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		BGWDataAsset_RebirthGeoInfo rebirthGeoInfo = BGW_PreloadAssetMgr.Get(this).RebirthGeoInfo;
		if (!(rebirthGeoInfo != null))
		{
			return;
		}
		foreach (KeyValuePair<int, FGeoAreaIdListInfo> item in rebirthGeoInfo.RebirthAreaConfig)
		{
			foreach (int areaId in item.Value.AreaIdList)
			{
				if (dictionary.ContainsKey(areaId))
				{
					BGW_LogUtil.LogError($"OnGMCheckRebirthPointArea ：区域{areaId}同时被土地庙{item.Key}和{dictionary[areaId]}控制");
				}
				else
				{
					dictionary.Add(areaId, item.Key);
				}
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	private void InitGeoInfoData()
	{
		InitRebirthPointData();
		InitAreaData();
	}

	private void InitRebirthPointData()
	{
		TBRebirthPointPosDesc tBRebirthPointPosDesc = GameDBRuntime.GetTBRebirthPointPosDesc();
		if (tBRebirthPointPosDesc == null)
		{
			return;
		}
		foreach (RebirthPointPosDesc item2 in tBRebirthPointPosDesc.List)
		{
			GeoInfoStruct item = new GeoInfoStruct
			{
				Id = item2.Id,
				PosX = item2.PosX,
				PosY = item2.PosY,
				MapSpriteId = item2.MapSpriteId
			};
			FUStRebirthPointDesc fUStRebirthPointDesc = GameDBRuntime.GetFUStRebirthPointDesc(item2.Id);
			if (fUStRebirthPointDesc != null)
			{
				item.Name = fUStRebirthPointDesc.Name.ToFText();
			}
			item.State = EGeoInfoState.Disable;
			if (RebirthPointData.IsRebirthPointActived(item2.Id))
			{
				item.State = EGeoInfoState.Active;
			}
			GeoInfoData.RebirthPointGeoInfoList.Add(item);
		}
	}

	private int CheckIsInChapterChanging(IBPC_PlayerRoleData PlayerRoleData, int CurChapterId)
	{
		ReadOnlyChapterDataList chapterList = PlayerRoleData.RoleData.RoleCs.Chapter.ChapterList;
		if (chapterList != null)
		{
			foreach (ReadOnlyChapterData item in chapterList)
			{
				if (CurChapterId == item.Id && item.Stage != ChapterStage.None)
				{
					ChapterDesc chapterDesc = GameDBRuntime.GetChapterDesc(item.Id);
					if (chapterDesc != null)
					{
						return chapterDesc.NextChapterId;
					}
				}
			}
		}
		return 0;
	}

	private void InitAreaData()
	{
		if (GeoInfoData.AreaPointGeoInfoList.Count != 0)
		{
			return;
		}
		TBMapAreaConfigDesc tBMapAreaConfigDesc = GameDBRuntime.GetTBMapAreaConfigDesc();
		if (tBMapAreaConfigDesc == null)
		{
			return;
		}
		int num = PlayerRoleData.RoleData.RoleCs.Chapter.CurChapter;
		int num2 = CheckIsInChapterChanging(PlayerRoleData, num);
		if (num2 > 0)
		{
			num = num2;
		}
		foreach (MapAreaConfigDesc item in tBMapAreaConfigDesc.List)
		{
			GeoInfoAreaData geoInfoAreaData = new GeoInfoAreaData();
			geoInfoAreaData.LevelId = item.LevelId;
			geoInfoAreaData.AreaId = item.AreaId;
			geoInfoAreaData.MapSpriteId = item.MapSpriteId;
			geoInfoAreaData.GeoAreaState = EGeoAreaState.Disable;
			LevelDesc levelDesc = GameDBRuntime.GetLevelDesc(geoInfoAreaData.LevelId);
			if (levelDesc != null)
			{
				if (levelDesc.LevelChapter > 0 && levelDesc.LevelChapter < num)
				{
					geoInfoAreaData.GeoAreaState = EGeoAreaState.Actived;
				}
				if (levelDesc.LevelChapter > 0 && levelDesc.LevelChapter == num && CheckAreaActiveStateByRebirthPoint(geoInfoAreaData.AreaId, num, geoInfoAreaData.MapSpriteId))
				{
					geoInfoAreaData.GeoAreaState = EGeoAreaState.Actived;
				}
				if (levelDesc.LevelChapter > 0)
				{
					GeoInfoData.AreaPointGeoInfoList.Add(geoInfoAreaData);
				}
			}
		}
	}

	private bool CheckAreaActiveStateByRebirthPoint(int AreaId, int LevelChapter, int MapSpriteId)
	{
		int num = 0;
		BGWDataAsset_RebirthGeoInfo rebirthGeoInfo = BGW_PreloadAssetMgr.Get(this).RebirthGeoInfo;
		if (rebirthGeoInfo != null)
		{
			foreach (KeyValuePair<int, FGeoAreaIdListInfo> item in rebirthGeoInfo.RebirthAreaConfig)
			{
				foreach (int areaId in item.Value.AreaIdList)
				{
					int num2 = areaId % 1000;
					int num3 = areaId / 1000;
					if (num2 != AreaId)
					{
						continue;
					}
					FUStRebirthPointDesc fUStRebirthPointDesc = GameDBRuntime.GetFUStRebirthPointDesc(item.Key);
					if (fUStRebirthPointDesc == null)
					{
						continue;
					}
					LevelDesc levelDesc = GameDBRuntime.GetLevelDesc(fUStRebirthPointDesc.GroupMapID);
					if (levelDesc != null && levelDesc.LevelChapter == LevelChapter)
					{
						num = item.Key;
						if (num > 0 && RebirthPointData.IsRebirthPointActived(num) && num3 == MapSpriteId)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	private void OnActiveRebirthPoint(int RebirthPointID, bool bActive)
	{
		for (int i = 0; i < GeoInfoData.RebirthPointGeoInfoList.Count; i++)
		{
			if (GeoInfoData.RebirthPointGeoInfoList[i].Id == RebirthPointID)
			{
				GeoInfoStruct value = GeoInfoData.RebirthPointGeoInfoList[i];
				value.State = (bActive ? EGeoInfoState.Active : EGeoInfoState.Disable);
				GeoInfoData.RebirthPointGeoInfoList[i] = value;
			}
		}
	}

	private void OnExploreGeoInfoArea(int AreaId, int MapSpriteId)
	{
		for (int i = 0; i < GeoInfoData.AreaPointGeoInfoList.Count; i++)
		{
			GeoInfoAreaData geoInfoAreaData = GeoInfoData.AreaPointGeoInfoList[i];
			if (geoInfoAreaData.MapSpriteId == MapSpriteId && AreaId == geoInfoAreaData.AreaId && GeoInfoData.AreaPointGeoInfoList[i].GeoAreaState == EGeoAreaState.Disable)
			{
				GeoInfoData.AreaPointGeoInfoList[i].GeoAreaState = EGeoAreaState.Explored;
				GeoInfoData.AreaPointGeoInfoList[i].ExploredTime = (DateTime.Now - new DateTime(1970, 1, 1)).TotalSeconds;
			}
		}
		if (MapSpriteId > 0)
		{
			GeoInfoData.CurMapSpriteId = MapSpriteId;
		}
	}

	private void OnActiveGeoInfoArea(int MapSpriteId, int AreaId)
	{
		for (int i = 0; i < GeoInfoData.AreaPointGeoInfoList.Count; i++)
		{
			GeoInfoAreaData geoInfoAreaData = GeoInfoData.AreaPointGeoInfoList[i];
			if (geoInfoAreaData.MapSpriteId == MapSpriteId && AreaId == geoInfoAreaData.AreaId && GeoInfoData.AreaPointGeoInfoList[i].GeoAreaState == EGeoAreaState.Explored)
			{
				GeoInfoData.AreaPointGeoInfoList[i].GeoAreaState = EGeoAreaState.Actived;
			}
		}
	}

	private void OnAddGeoInfoCustom(int MapId, float PosX, float PosY, EGeoInfoCustomType GeoInfoCustomType)
	{
		GeoInfoCustomData geoInfoCustomData = new GeoInfoCustomData();
		geoInfoCustomData.MapId = MapId;
		geoInfoCustomData.PosX = PosX;
		geoInfoCustomData.PosY = PosY;
		geoInfoCustomData.Id = GeoInfoData.CustomGeoInfoList.Count;
		geoInfoCustomData.GeoInfoCustomType = GeoInfoCustomType;
		for (int i = 0; i < GeoInfoData.CustomGeoInfoList.Count; i++)
		{
			bool flag = false;
			foreach (GeoInfoCustomData customGeoInfo in GeoInfoData.CustomGeoInfoList)
			{
				if (customGeoInfo.Id == i)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				geoInfoCustomData.Id = i;
				break;
			}
		}
		GeoInfoData.CustomGeoInfoList.Add(geoInfoCustomData);
	}

	private void OnRemoveGeoInfoCustom(int Id)
	{
		foreach (GeoInfoCustomData customGeoInfo in GeoInfoData.CustomGeoInfoList)
		{
			if (customGeoInfo.Id == Id)
			{
				GeoInfoData.CustomGeoInfoList.Remove(customGeoInfo);
				break;
			}
		}
	}

	private void OnClearAllGeoInfoCustom()
	{
		GeoInfoData.CustomGeoInfoList.Clear();
	}
}
