using System;
using System.Linq;
using ArchiveB1;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using GurGsPersistent;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BIS_PersistentECSDataSystem : GameInstanceSystemBase
{
	private BIC_PersistentECSData PersistentECSData;

	private BIC_LevelData LevelData;

	public void BindAllBUCDataChange(Entity Entity, int LevelId, string Guid)
	{
		PersistentECSData.FindOrAllocBUCDataByGuid(Guid, out var ProtobufDataAll);
		BUC_ActorInitData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorInitData>(Entity);
		if (readOnlyData != null)
		{
			if (ProtobufDataAll.BUCActorInitData == null)
			{
				ProtobufDataAll.BUCActorInitData = new GurGsPersistent.BUC_ActorInitData();
			}
			readOnlyData.OnPersistentDataDontResetOnNewGamePlusChg += delegate(bool OldValue, bool NewValue)
			{
				ProtobufDataAll.BUCActorInitData.PersistentDataDontResetOnNewGamePlus = NewValue;
			};
		}
		if (BGU_DataUtil.GetReadOnlyData<BUC_LifeSavingData>(Entity) != null && ProtobufDataAll.BUCLifeSavingData == null)
		{
			ProtobufDataAll.BUCLifeSavingData = new GurGsPersistent.BUC_LifeSavingData();
		}
		if (BGU_DataUtil.GetReadOnlyData<BUC_ReplicateTestData>(Entity) != null && ProtobufDataAll.BUCReplicateTestData == null)
		{
			ProtobufDataAll.BUCReplicateTestData = new GurGsPersistent.BUC_ReplicateTestData();
		}
		BUC_CollectionData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_CollectionData>(Entity);
		if (readOnlyData2 != null)
		{
			if (ProtobufDataAll.BUCCollectionData == null)
			{
				ProtobufDataAll.BUCCollectionData = new GurGsPersistent.BUC_CollectionData();
			}
			readOnlyData2.OnGroupIdChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BUCCollectionData.GroupId = NewValue;
			};
			readOnlyData2.OnCollectionQualityChg += delegate(ECollectionQualityType OldValue, ECollectionQualityType NewValue)
			{
				ProtobufDataAll.BUCCollectionData.CollectionQuality = (int)NewValue;
			};
			readOnlyData2.OnCollectiontTypeChg += delegate(ECollectionInteractType OldValue, ECollectionInteractType NewValue)
			{
				ProtobufDataAll.BUCCollectionData.CollectiontType = (int)NewValue;
			};
			readOnlyData2.OnIsRandomedChg += delegate(bool OldValue, bool NewValue)
			{
				ProtobufDataAll.BUCCollectionData.IsRandomed = NewValue;
			};
			readOnlyData2.OnBeCollectedChg += delegate(bool OldValue, bool NewValue)
			{
				ProtobufDataAll.BUCCollectionData.BeCollected = NewValue;
			};
			readOnlyData2.OnNeedReBirthMonsterChg += delegate(bool OldValue, bool NewValue)
			{
				ProtobufDataAll.BUCCollectionData.NeedReBirthMonster = NewValue;
			};
		}
		BUC_InteractData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(Entity);
		if (readOnlyData3 != null)
		{
			if (ProtobufDataAll.BUCInteractData == null)
			{
				ProtobufDataAll.BUCInteractData = new GurGsPersistent.BUC_InteractData();
			}
			readOnlyData3.OnInteractUnitStatePersistentChg += delegate(EBGUInteractUnitState OldValue, EBGUInteractUnitState NewValue)
			{
				BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.InteractStateChanged, "GSPersistent BUC_InteractData.InteractUnitStatePersistent Changed");
				ProtobufDataAll.BUCInteractData.InteractUnitStatePersistent = (int)NewValue;
			};
			readOnlyData3.OnActionGroupIDPersistentChg += delegate(int OldValue, int NewValue)
			{
				BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.InteractStateChanged, "GSPersistent BUC_InteractData.ActionGroupIDPersistent Changed");
				ProtobufDataAll.BUCInteractData.ActionGroupIDPersistent = NewValue;
			};
		}
		BUC_GamePlusSpawnData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BUC_GamePlusSpawnData>(Entity);
		if (readOnlyData4 != null)
		{
			if (ProtobufDataAll.BUCGamePlusSpawnData == null)
			{
				ProtobufDataAll.BUCGamePlusSpawnData = new GurGsPersistent.BUC_GamePlusSpawnData();
			}
			readOnlyData4.OnDestoryForeverChg += delegate(bool OldValue, bool NewValue)
			{
				ProtobufDataAll.BUCGamePlusSpawnData.DestoryForever = NewValue;
			};
			readOnlyData4.OnLastCollectTimeChg += delegate(double OldValue, double NewValue)
			{
				ProtobufDataAll.BUCGamePlusSpawnData.LastCollectTime = NewValue;
			};
			readOnlyData4.OnCurCDChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BUCGamePlusSpawnData.CurCD = NewValue;
			};
			readOnlyData4.OnLastCollectGamePlayCountChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BUCGamePlusSpawnData.LastCollectGamePlayCount = NewValue;
			};
			readOnlyData4.OnCollectionCountChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BUCGamePlusSpawnData.CollectionCount = NewValue;
			};
		}
		if (BGU_DataUtil.GetReadOnlyData<BUC_TaskCollectionData>(Entity) != null && ProtobufDataAll.BUCTaskCollectionData == null)
		{
			ProtobufDataAll.BUCTaskCollectionData = new GurGsPersistent.BUC_TaskCollectionData();
		}
	}

	public void BindAllBPCDataChange(Entity Entity)
	{
		PersistentBPCData ProtobufDataAll = PersistentECSData.GetPersistentBPCData();
		BPC_GeoInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_GeoInfoData>(Entity);
		if (readOnlyData != null)
		{
			if (ProtobufDataAll.BPCGeoInfoData == null)
			{
				ProtobufDataAll.BPCGeoInfoData = new GurGsPersistent.BPC_GeoInfoData();
			}
			for (int i = 0; i < readOnlyData.AreaPointGeoInfoList.Count; i++)
			{
				ListDeltaMsgGeoInfoAreaData AreaPointGeoInfoListProrobufItemOne = ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList[i];
				GeoInfoAreaData geoInfoAreaData = readOnlyData.AreaPointGeoInfoList[i];
				geoInfoAreaData.OnLevelIdChg += delegate(int OldValue, int NewValue)
				{
					AreaPointGeoInfoListProrobufItemOne.Value.LevelId = NewValue;
				};
				geoInfoAreaData.OnAreaIdChg += delegate(int OldValue, int NewValue)
				{
					AreaPointGeoInfoListProrobufItemOne.Value.AreaId = NewValue;
				};
				geoInfoAreaData.OnMapSpriteIdChg += delegate(int OldValue, int NewValue)
				{
					AreaPointGeoInfoListProrobufItemOne.Value.MapSpriteId = NewValue;
				};
				geoInfoAreaData.OnGeoAreaStateChg += delegate(EGeoAreaState OldValue, EGeoAreaState NewValue)
				{
					AreaPointGeoInfoListProrobufItemOne.Value.GeoAreaState = (int)NewValue;
				};
				geoInfoAreaData.OnExploredTimeChg += delegate(double OldValue, double NewValue)
				{
					AreaPointGeoInfoListProrobufItemOne.Value.ExploredTime = NewValue;
				};
			}
			readOnlyData.AreaPointGeoInfoList.OnAdd += delegate(GeoInfoAreaData AreaPointGeoInfoListItemAdd)
			{
				ListDeltaMsgGeoInfoAreaData AreaPointGeoInfoListProrobufAddItem = new ListDeltaMsgGeoInfoAreaData();
				if (AreaPointGeoInfoListProrobufAddItem.Value == null)
				{
					AreaPointGeoInfoListProrobufAddItem.Value = new GurGsPersistent.GeoInfoAreaData();
				}
				if (AreaPointGeoInfoListItemAdd != null)
				{
					AreaPointGeoInfoListProrobufAddItem.Value.LevelId = AreaPointGeoInfoListItemAdd.LevelId;
					AreaPointGeoInfoListProrobufAddItem.Value.AreaId = AreaPointGeoInfoListItemAdd.AreaId;
					AreaPointGeoInfoListProrobufAddItem.Value.MapSpriteId = AreaPointGeoInfoListItemAdd.MapSpriteId;
					AreaPointGeoInfoListProrobufAddItem.Value.GeoAreaState = (int)AreaPointGeoInfoListItemAdd.GeoAreaState;
					AreaPointGeoInfoListProrobufAddItem.Value.ExploredTime = AreaPointGeoInfoListItemAdd.ExploredTime;
				}
				ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList.Add(AreaPointGeoInfoListProrobufAddItem);
				AreaPointGeoInfoListItemAdd.OnLevelIdChg += delegate(int OldValue, int NewValue)
				{
					AreaPointGeoInfoListProrobufAddItem.Value.LevelId = NewValue;
				};
				AreaPointGeoInfoListItemAdd.OnAreaIdChg += delegate(int OldValue, int NewValue)
				{
					AreaPointGeoInfoListProrobufAddItem.Value.AreaId = NewValue;
				};
				AreaPointGeoInfoListItemAdd.OnMapSpriteIdChg += delegate(int OldValue, int NewValue)
				{
					AreaPointGeoInfoListProrobufAddItem.Value.MapSpriteId = NewValue;
				};
				AreaPointGeoInfoListItemAdd.OnGeoAreaStateChg += delegate(EGeoAreaState OldValue, EGeoAreaState NewValue)
				{
					AreaPointGeoInfoListProrobufAddItem.Value.GeoAreaState = (int)NewValue;
				};
				AreaPointGeoInfoListItemAdd.OnExploredTimeChg += delegate(double OldValue, double NewValue)
				{
					AreaPointGeoInfoListProrobufAddItem.Value.ExploredTime = NewValue;
				};
			};
			readOnlyData.AreaPointGeoInfoList.OnRemove += delegate(int AreaPointGeoInfoListKeyRemove, GeoInfoAreaData AreaPointGeoInfoListItemRemove)
			{
				ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList.RemoveAt(AreaPointGeoInfoListKeyRemove);
			};
			BindListGeoInfoAreaData areaPointGeoInfoList = readOnlyData.AreaPointGeoInfoList;
			areaPointGeoInfoList.OnClear = (Action)Delegate.Combine(areaPointGeoInfoList.OnClear, (Action)delegate
			{
				ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList.Clear();
			});
			readOnlyData.AreaPointGeoInfoList.OnSetIdxValue += delegate(int AreaPointGeoInfoListKeyChange, GeoInfoAreaData AreaPointGeoInfoListItemKeyChangeOld, GeoInfoAreaData AreaPointGeoInfoListItemKeyChangeNew)
			{
				if (ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList[AreaPointGeoInfoListKeyChange].Value == null)
				{
					ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList[AreaPointGeoInfoListKeyChange].Value = new GurGsPersistent.GeoInfoAreaData();
				}
				if (AreaPointGeoInfoListItemKeyChangeNew != null)
				{
					ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList[AreaPointGeoInfoListKeyChange].Value.LevelId = AreaPointGeoInfoListItemKeyChangeNew.LevelId;
					ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList[AreaPointGeoInfoListKeyChange].Value.AreaId = AreaPointGeoInfoListItemKeyChangeNew.AreaId;
					ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList[AreaPointGeoInfoListKeyChange].Value.MapSpriteId = AreaPointGeoInfoListItemKeyChangeNew.MapSpriteId;
					ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList[AreaPointGeoInfoListKeyChange].Value.GeoAreaState = (int)AreaPointGeoInfoListItemKeyChangeNew.GeoAreaState;
					ProtobufDataAll.BPCGeoInfoData.AreaPointGeoInfoList[AreaPointGeoInfoListKeyChange].Value.ExploredTime = AreaPointGeoInfoListItemKeyChangeNew.ExploredTime;
				}
			};
			for (int num = 0; num < readOnlyData.CustomGeoInfoList.Count; num++)
			{
				ListDeltaMsgGeoInfoCustomData CustomGeoInfoListProrobufItemOne = ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList[num];
				GeoInfoCustomData geoInfoCustomData = readOnlyData.CustomGeoInfoList[num];
				geoInfoCustomData.OnIdChg += delegate(int OldValue, int NewValue)
				{
					CustomGeoInfoListProrobufItemOne.Value.Id = NewValue;
				};
				geoInfoCustomData.OnMapIdChg += delegate(int OldValue, int NewValue)
				{
					CustomGeoInfoListProrobufItemOne.Value.MapId = NewValue;
				};
				geoInfoCustomData.OnPosXChg += delegate(float OldValue, float NewValue)
				{
					CustomGeoInfoListProrobufItemOne.Value.PosX = NewValue;
				};
				geoInfoCustomData.OnPosYChg += delegate(float OldValue, float NewValue)
				{
					CustomGeoInfoListProrobufItemOne.Value.PosY = NewValue;
				};
				geoInfoCustomData.OnGeoInfoCustomTypeChg += delegate(EGeoInfoCustomType OldValue, EGeoInfoCustomType NewValue)
				{
					CustomGeoInfoListProrobufItemOne.Value.GeoInfoCustomType = (int)NewValue;
				};
			}
			readOnlyData.CustomGeoInfoList.OnAdd += delegate(GeoInfoCustomData CustomGeoInfoListItemAdd)
			{
				ListDeltaMsgGeoInfoCustomData CustomGeoInfoListProrobufAddItem = new ListDeltaMsgGeoInfoCustomData();
				if (CustomGeoInfoListProrobufAddItem.Value == null)
				{
					CustomGeoInfoListProrobufAddItem.Value = new GurGsPersistent.GeoInfoCustomData();
				}
				if (CustomGeoInfoListItemAdd != null)
				{
					CustomGeoInfoListProrobufAddItem.Value.Id = CustomGeoInfoListItemAdd.Id;
					CustomGeoInfoListProrobufAddItem.Value.MapId = CustomGeoInfoListItemAdd.MapId;
					CustomGeoInfoListProrobufAddItem.Value.PosX = CustomGeoInfoListItemAdd.PosX;
					CustomGeoInfoListProrobufAddItem.Value.PosY = CustomGeoInfoListItemAdd.PosY;
					CustomGeoInfoListProrobufAddItem.Value.GeoInfoCustomType = (int)CustomGeoInfoListItemAdd.GeoInfoCustomType;
				}
				ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList.Add(CustomGeoInfoListProrobufAddItem);
				CustomGeoInfoListItemAdd.OnIdChg += delegate(int OldValue, int NewValue)
				{
					CustomGeoInfoListProrobufAddItem.Value.Id = NewValue;
				};
				CustomGeoInfoListItemAdd.OnMapIdChg += delegate(int OldValue, int NewValue)
				{
					CustomGeoInfoListProrobufAddItem.Value.MapId = NewValue;
				};
				CustomGeoInfoListItemAdd.OnPosXChg += delegate(float OldValue, float NewValue)
				{
					CustomGeoInfoListProrobufAddItem.Value.PosX = NewValue;
				};
				CustomGeoInfoListItemAdd.OnPosYChg += delegate(float OldValue, float NewValue)
				{
					CustomGeoInfoListProrobufAddItem.Value.PosY = NewValue;
				};
				CustomGeoInfoListItemAdd.OnGeoInfoCustomTypeChg += delegate(EGeoInfoCustomType OldValue, EGeoInfoCustomType NewValue)
				{
					CustomGeoInfoListProrobufAddItem.Value.GeoInfoCustomType = (int)NewValue;
				};
			};
			readOnlyData.CustomGeoInfoList.OnRemove += delegate(int CustomGeoInfoListKeyRemove, GeoInfoCustomData CustomGeoInfoListItemRemove)
			{
				ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList.RemoveAt(CustomGeoInfoListKeyRemove);
			};
			BindListGeoInfoCustomData customGeoInfoList = readOnlyData.CustomGeoInfoList;
			customGeoInfoList.OnClear = (Action)Delegate.Combine(customGeoInfoList.OnClear, (Action)delegate
			{
				ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList.Clear();
			});
			readOnlyData.CustomGeoInfoList.OnSetIdxValue += delegate(int CustomGeoInfoListKeyChange, GeoInfoCustomData CustomGeoInfoListItemKeyChangeOld, GeoInfoCustomData CustomGeoInfoListItemKeyChangeNew)
			{
				if (ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList[CustomGeoInfoListKeyChange].Value == null)
				{
					ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList[CustomGeoInfoListKeyChange].Value = new GurGsPersistent.GeoInfoCustomData();
				}
				if (CustomGeoInfoListItemKeyChangeNew != null)
				{
					ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList[CustomGeoInfoListKeyChange].Value.Id = CustomGeoInfoListItemKeyChangeNew.Id;
					ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList[CustomGeoInfoListKeyChange].Value.MapId = CustomGeoInfoListItemKeyChangeNew.MapId;
					ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList[CustomGeoInfoListKeyChange].Value.PosX = CustomGeoInfoListItemKeyChangeNew.PosX;
					ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList[CustomGeoInfoListKeyChange].Value.PosY = CustomGeoInfoListItemKeyChangeNew.PosY;
					ProtobufDataAll.BPCGeoInfoData.CustomGeoInfoList[CustomGeoInfoListKeyChange].Value.GeoInfoCustomType = (int)CustomGeoInfoListItemKeyChangeNew.GeoInfoCustomType;
				}
			};
			readOnlyData.OnCurMapSpriteIdChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCGeoInfoData.CurMapSpriteId = NewValue;
			};
		}
		BPC_MapSymbolData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BPC_MapSymbolData>(Entity);
		if (readOnlyData2 != null)
		{
			if (ProtobufDataAll.BPCMapSymbolData == null)
			{
				ProtobufDataAll.BPCMapSymbolData = new GurGsPersistent.BPC_MapSymbolData();
			}
			readOnlyData2.MapSymbolStateDict.OnAdd += delegate(string MapSymbolStateDictKeyAdd, EMapSymbolState MapSymbolStateDictItemAdd)
			{
				DictDeltaMsgString_EMapSymbolState item = new DictDeltaMsgString_EMapSymbolState
				{
					Key = MapSymbolStateDictKeyAdd,
					Value = (int)MapSymbolStateDictItemAdd
				};
				ProtobufDataAll.BPCMapSymbolData.MapSymbolStateDict.Add(item);
			};
			BindDictString_EMapSymbolState mapSymbolStateDict = readOnlyData2.MapSymbolStateDict;
			mapSymbolStateDict.OnRemove = (Action<string, EMapSymbolState>)Delegate.Combine(mapSymbolStateDict.OnRemove, (Action<string, EMapSymbolState>)delegate(string MapSymbolStateDictKeyRemove, EMapSymbolState MapSymbolStateDictItemRemove)
			{
				foreach (DictDeltaMsgString_EMapSymbolState item2 in ProtobufDataAll.BPCMapSymbolData.MapSymbolStateDict)
				{
					if (item2.Key == MapSymbolStateDictKeyRemove)
					{
						ProtobufDataAll.BPCMapSymbolData.MapSymbolStateDict.Remove(item2);
						break;
					}
				}
			});
			readOnlyData2.MapSymbolStateDict.OnClear += delegate
			{
				ProtobufDataAll.BPCMapSymbolData.MapSymbolStateDict.Clear();
			};
			readOnlyData2.MapSymbolStateDict.OnAnyValueChanged += delegate(string MapSymbolStateDictKeyChange, EMapSymbolState MapSymbolStateDictItemKeyChangeOld, EMapSymbolState MapSymbolStateDictItemKeyChangeNew)
			{
				foreach (DictDeltaMsgString_EMapSymbolState item3 in ProtobufDataAll.BPCMapSymbolData.MapSymbolStateDict)
				{
					if (item3.Key == MapSymbolStateDictKeyChange)
					{
						item3.Value = (int)MapSymbolStateDictItemKeyChangeNew;
						break;
					}
				}
			};
		}
		BPC_PlayerAttrData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerAttrData>(Entity);
		if (readOnlyData3 != null)
		{
			if (ProtobufDataAll.BPCPlayerAttrData == null)
			{
				ProtobufDataAll.BPCPlayerAttrData = new GurGsPersistent.BPC_PlayerAttrData();
			}
			readOnlyData3.OnPlayerLifeSavingCoolDownRemainTimeChg += delegate(float OldValue, float NewValue)
			{
				ProtobufDataAll.BPCPlayerAttrData.PlayerLifeSavingCoolDownRemainTime = NewValue;
			};
			for (int num2 = 0; num2 < readOnlyData3.PlayerPersistentAttr.Count; num2++)
			{
				ListDeltaMsgPlayerPersistentAttr PlayerPersistentAttrProrobufItemOne = ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr[num2];
				PlayerPersistentAttr playerPersistentAttr = readOnlyData3.PlayerPersistentAttr[num2];
				playerPersistentAttr.OnAttrIdChg += delegate(int OldValue, int NewValue)
				{
					PlayerPersistentAttrProrobufItemOne.Value.AttrId = NewValue;
				};
				playerPersistentAttr.OnAttrMaxIdChg += delegate(int OldValue, int NewValue)
				{
					PlayerPersistentAttrProrobufItemOne.Value.AttrMaxId = NewValue;
				};
				playerPersistentAttr.OnAttrValueChg += delegate(float OldValue, float NewValue)
				{
					PlayerPersistentAttrProrobufItemOne.Value.AttrValue = NewValue;
				};
				playerPersistentAttr.OnAttrValueTypeChg += delegate(EPlayerAttrRecoverType OldValue, EPlayerAttrRecoverType NewValue)
				{
					PlayerPersistentAttrProrobufItemOne.Value.AttrValueType = (int)NewValue;
				};
			}
			readOnlyData3.PlayerPersistentAttr.OnAdd += delegate(PlayerPersistentAttr PlayerPersistentAttrItemAdd)
			{
				ListDeltaMsgPlayerPersistentAttr PlayerPersistentAttrProrobufAddItem = new ListDeltaMsgPlayerPersistentAttr();
				if (PlayerPersistentAttrProrobufAddItem.Value == null)
				{
					PlayerPersistentAttrProrobufAddItem.Value = new GurGsPersistent.PlayerPersistentAttr();
				}
				if (PlayerPersistentAttrItemAdd != null)
				{
					PlayerPersistentAttrProrobufAddItem.Value.AttrId = PlayerPersistentAttrItemAdd.AttrId;
					PlayerPersistentAttrProrobufAddItem.Value.AttrMaxId = PlayerPersistentAttrItemAdd.AttrMaxId;
					PlayerPersistentAttrProrobufAddItem.Value.AttrValue = PlayerPersistentAttrItemAdd.AttrValue;
					PlayerPersistentAttrProrobufAddItem.Value.AttrValueType = (int)PlayerPersistentAttrItemAdd.AttrValueType;
				}
				ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr.Add(PlayerPersistentAttrProrobufAddItem);
				PlayerPersistentAttrItemAdd.OnAttrIdChg += delegate(int OldValue, int NewValue)
				{
					PlayerPersistentAttrProrobufAddItem.Value.AttrId = NewValue;
				};
				PlayerPersistentAttrItemAdd.OnAttrMaxIdChg += delegate(int OldValue, int NewValue)
				{
					PlayerPersistentAttrProrobufAddItem.Value.AttrMaxId = NewValue;
				};
				PlayerPersistentAttrItemAdd.OnAttrValueChg += delegate(float OldValue, float NewValue)
				{
					PlayerPersistentAttrProrobufAddItem.Value.AttrValue = NewValue;
				};
				PlayerPersistentAttrItemAdd.OnAttrValueTypeChg += delegate(EPlayerAttrRecoverType OldValue, EPlayerAttrRecoverType NewValue)
				{
					PlayerPersistentAttrProrobufAddItem.Value.AttrValueType = (int)NewValue;
				};
			};
			readOnlyData3.PlayerPersistentAttr.OnRemove += delegate(int PlayerPersistentAttrKeyRemove, PlayerPersistentAttr PlayerPersistentAttrItemRemove)
			{
				ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr.RemoveAt(PlayerPersistentAttrKeyRemove);
			};
			BindListPlayerPersistentAttr playerPersistentAttr2 = readOnlyData3.PlayerPersistentAttr;
			playerPersistentAttr2.OnClear = (Action)Delegate.Combine(playerPersistentAttr2.OnClear, (Action)delegate
			{
				ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr.Clear();
			});
			readOnlyData3.PlayerPersistentAttr.OnSetIdxValue += delegate(int PlayerPersistentAttrKeyChange, PlayerPersistentAttr PlayerPersistentAttrItemKeyChangeOld, PlayerPersistentAttr PlayerPersistentAttrItemKeyChangeNew)
			{
				if (ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr[PlayerPersistentAttrKeyChange].Value == null)
				{
					ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr[PlayerPersistentAttrKeyChange].Value = new GurGsPersistent.PlayerPersistentAttr();
				}
				if (PlayerPersistentAttrItemKeyChangeNew != null)
				{
					ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr[PlayerPersistentAttrKeyChange].Value.AttrId = PlayerPersistentAttrItemKeyChangeNew.AttrId;
					ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr[PlayerPersistentAttrKeyChange].Value.AttrMaxId = PlayerPersistentAttrItemKeyChangeNew.AttrMaxId;
					ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr[PlayerPersistentAttrKeyChange].Value.AttrValue = PlayerPersistentAttrItemKeyChangeNew.AttrValue;
					ProtobufDataAll.BPCPlayerAttrData.PlayerPersistentAttr[PlayerPersistentAttrKeyChange].Value.AttrValueType = (int)PlayerPersistentAttrItemKeyChangeNew.AttrValueType;
				}
			};
			for (int num3 = 0; num3 < readOnlyData3.PlayerMagicSkillCd.Count; num3++)
			{
				ListDeltaMsgPlayerMagicSkillCd PlayerMagicSkillCdProrobufItemOne = ProtobufDataAll.BPCPlayerAttrData.PlayerMagicSkillCd[num3];
				PlayerMagicSkillCd playerMagicSkillCd = readOnlyData3.PlayerMagicSkillCd[num3];
				playerMagicSkillCd.OnSkillIdChg += delegate(int OldValue, int NewValue)
				{
					PlayerMagicSkillCdProrobufItemOne.Value.SkillId = NewValue;
				};
				playerMagicSkillCd.OnCoolDownChg += delegate(float OldValue, float NewValue)
				{
					PlayerMagicSkillCdProrobufItemOne.Value.CoolDown = NewValue;
				};
			}
			readOnlyData3.PlayerMagicSkillCd.OnAdd += delegate(PlayerMagicSkillCd PlayerMagicSkillCdItemAdd)
			{
				ListDeltaMsgPlayerMagicSkillCd PlayerMagicSkillCdProrobufAddItem = new ListDeltaMsgPlayerMagicSkillCd();
				if (PlayerMagicSkillCdProrobufAddItem.Value == null)
				{
					PlayerMagicSkillCdProrobufAddItem.Value = new GurGsPersistent.PlayerMagicSkillCd();
				}
				if (PlayerMagicSkillCdItemAdd != null)
				{
					PlayerMagicSkillCdProrobufAddItem.Value.SkillId = PlayerMagicSkillCdItemAdd.SkillId;
					PlayerMagicSkillCdProrobufAddItem.Value.CoolDown = PlayerMagicSkillCdItemAdd.CoolDown;
				}
				ProtobufDataAll.BPCPlayerAttrData.PlayerMagicSkillCd.Add(PlayerMagicSkillCdProrobufAddItem);
				PlayerMagicSkillCdItemAdd.OnSkillIdChg += delegate(int OldValue, int NewValue)
				{
					PlayerMagicSkillCdProrobufAddItem.Value.SkillId = NewValue;
				};
				PlayerMagicSkillCdItemAdd.OnCoolDownChg += delegate(float OldValue, float NewValue)
				{
					PlayerMagicSkillCdProrobufAddItem.Value.CoolDown = NewValue;
				};
			};
			readOnlyData3.PlayerMagicSkillCd.OnRemove += delegate(int PlayerMagicSkillCdKeyRemove, PlayerMagicSkillCd PlayerMagicSkillCdItemRemove)
			{
				ProtobufDataAll.BPCPlayerAttrData.PlayerMagicSkillCd.RemoveAt(PlayerMagicSkillCdKeyRemove);
			};
			BindListPlayerMagicSkillCd playerMagicSkillCd2 = readOnlyData3.PlayerMagicSkillCd;
			playerMagicSkillCd2.OnClear = (Action)Delegate.Combine(playerMagicSkillCd2.OnClear, (Action)delegate
			{
				ProtobufDataAll.BPCPlayerAttrData.PlayerMagicSkillCd.Clear();
			});
			readOnlyData3.PlayerMagicSkillCd.OnSetIdxValue += delegate(int PlayerMagicSkillCdKeyChange, PlayerMagicSkillCd PlayerMagicSkillCdItemKeyChangeOld, PlayerMagicSkillCd PlayerMagicSkillCdItemKeyChangeNew)
			{
				if (ProtobufDataAll.BPCPlayerAttrData.PlayerMagicSkillCd[PlayerMagicSkillCdKeyChange].Value == null)
				{
					ProtobufDataAll.BPCPlayerAttrData.PlayerMagicSkillCd[PlayerMagicSkillCdKeyChange].Value = new GurGsPersistent.PlayerMagicSkillCd();
				}
				if (PlayerMagicSkillCdItemKeyChangeNew != null)
				{
					ProtobufDataAll.BPCPlayerAttrData.PlayerMagicSkillCd[PlayerMagicSkillCdKeyChange].Value.SkillId = PlayerMagicSkillCdItemKeyChangeNew.SkillId;
					ProtobufDataAll.BPCPlayerAttrData.PlayerMagicSkillCd[PlayerMagicSkillCdKeyChange].Value.CoolDown = PlayerMagicSkillCdItemKeyChangeNew.CoolDown;
				}
			};
			readOnlyData3.KeyMonsterMeetCount.OnAdd += delegate(string KeyMonsterMeetCountKeyAdd, int KeyMonsterMeetCountItemAdd)
			{
				DictDeltaMsgString_Int item = new DictDeltaMsgString_Int
				{
					Key = KeyMonsterMeetCountKeyAdd,
					Value = KeyMonsterMeetCountItemAdd
				};
				ProtobufDataAll.BPCPlayerAttrData.KeyMonsterMeetCount.Add(item);
			};
			BindDictString_Int keyMonsterMeetCount = readOnlyData3.KeyMonsterMeetCount;
			keyMonsterMeetCount.OnRemove = (Action<string, int>)Delegate.Combine(keyMonsterMeetCount.OnRemove, (Action<string, int>)delegate(string KeyMonsterMeetCountKeyRemove, int KeyMonsterMeetCountItemRemove)
			{
				foreach (DictDeltaMsgString_Int item4 in ProtobufDataAll.BPCPlayerAttrData.KeyMonsterMeetCount)
				{
					if (item4.Key == KeyMonsterMeetCountKeyRemove)
					{
						ProtobufDataAll.BPCPlayerAttrData.KeyMonsterMeetCount.Remove(item4);
						break;
					}
				}
			});
			readOnlyData3.KeyMonsterMeetCount.OnClear += delegate
			{
				ProtobufDataAll.BPCPlayerAttrData.KeyMonsterMeetCount.Clear();
			};
			readOnlyData3.KeyMonsterMeetCount.OnAnyValueChanged += delegate(string KeyMonsterMeetCountKeyChange, int KeyMonsterMeetCountItemKeyChangeOld, int KeyMonsterMeetCountItemKeyChangeNew)
			{
				foreach (DictDeltaMsgString_Int item5 in ProtobufDataAll.BPCPlayerAttrData.KeyMonsterMeetCount)
				{
					if (item5.Key == KeyMonsterMeetCountKeyChange)
					{
						item5.Value = KeyMonsterMeetCountItemKeyChangeNew;
						break;
					}
				}
			};
			readOnlyData3.KeyMonsterBattlePlayerDieTimes.OnAdd += delegate(string KeyMonsterBattlePlayerDieTimesKeyAdd, int KeyMonsterBattlePlayerDieTimesItemAdd)
			{
				DictDeltaMsgString_Int item = new DictDeltaMsgString_Int
				{
					Key = KeyMonsterBattlePlayerDieTimesKeyAdd,
					Value = KeyMonsterBattlePlayerDieTimesItemAdd
				};
				ProtobufDataAll.BPCPlayerAttrData.KeyMonsterBattlePlayerDieTimes.Add(item);
			};
			BindDictString_Int keyMonsterBattlePlayerDieTimes = readOnlyData3.KeyMonsterBattlePlayerDieTimes;
			keyMonsterBattlePlayerDieTimes.OnRemove = (Action<string, int>)Delegate.Combine(keyMonsterBattlePlayerDieTimes.OnRemove, (Action<string, int>)delegate(string KeyMonsterBattlePlayerDieTimesKeyRemove, int KeyMonsterBattlePlayerDieTimesItemRemove)
			{
				foreach (DictDeltaMsgString_Int keyMonsterBattlePlayerDieTime in ProtobufDataAll.BPCPlayerAttrData.KeyMonsterBattlePlayerDieTimes)
				{
					if (keyMonsterBattlePlayerDieTime.Key == KeyMonsterBattlePlayerDieTimesKeyRemove)
					{
						ProtobufDataAll.BPCPlayerAttrData.KeyMonsterBattlePlayerDieTimes.Remove(keyMonsterBattlePlayerDieTime);
						break;
					}
				}
			});
			readOnlyData3.KeyMonsterBattlePlayerDieTimes.OnClear += delegate
			{
				ProtobufDataAll.BPCPlayerAttrData.KeyMonsterBattlePlayerDieTimes.Clear();
			};
			readOnlyData3.KeyMonsterBattlePlayerDieTimes.OnAnyValueChanged += delegate(string KeyMonsterBattlePlayerDieTimesKeyChange, int KeyMonsterBattlePlayerDieTimesItemKeyChangeOld, int KeyMonsterBattlePlayerDieTimesItemKeyChangeNew)
			{
				foreach (DictDeltaMsgString_Int keyMonsterBattlePlayerDieTime2 in ProtobufDataAll.BPCPlayerAttrData.KeyMonsterBattlePlayerDieTimes)
				{
					if (keyMonsterBattlePlayerDieTime2.Key == KeyMonsterBattlePlayerDieTimesKeyChange)
					{
						keyMonsterBattlePlayerDieTime2.Value = KeyMonsterBattlePlayerDieTimesItemKeyChangeNew;
						break;
					}
				}
			};
		}
		BPC_PlayerRoleData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(Entity);
		if (readOnlyData4 != null)
		{
			if (ProtobufDataAll.BPCPlayerRoleData == null)
			{
				ProtobufDataAll.BPCPlayerRoleData = new GurGsPersistent.BPC_PlayerRoleData();
			}
			readOnlyData4.OnBeginAreaStayTimeChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCPlayerRoleData.BeginAreaStayTime = NewValue;
			};
			readOnlyData4.OnLastRebirthPointTimeChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCPlayerRoleData.LastRebirthPointTime = NewValue;
			};
			readOnlyData4.OnMapAreaIdChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCPlayerRoleData.MapAreaId = NewValue;
			};
			readOnlyData4.OnMaxMapAreaIdChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCPlayerRoleData.MaxMapAreaId = NewValue;
			};
			readOnlyData4.OnMaxMapIdChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCPlayerRoleData.MaxMapId = NewValue;
			};
			readOnlyData4.OnMapIdChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCPlayerRoleData.MapId = NewValue;
			};
			readOnlyData4.OnDemo820MapIdxChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCPlayerRoleData.Demo820MapIdx = NewValue;
			};
			readOnlyData4.OnDefaultShortcutsPositionChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCPlayerRoleData.DefaultShortcutsPosition = NewValue;
			};
			for (int num4 = 0; num4 < readOnlyData4.UnitBookDataDic.Count; num4++)
			{
				DictDeltaMsgInt_GSUnitBookData UnitBookDataDicProrobufItemOne = ProtobufDataAll.BPCPlayerRoleData.UnitBookDataDic[num4];
				GSUnitBookData gSUnitBookData = readOnlyData4.UnitBookDataDic[UnitBookDataDicProrobufItemOne.Key];
				gSUnitBookData.OnIsFirstSightReadChg += delegate(bool OldValue, bool NewValue)
				{
					UnitBookDataDicProrobufItemOne.Value.IsFirstSightRead = NewValue;
				};
				gSUnitBookData.OnIsStory1ReadChg += delegate(bool OldValue, bool NewValue)
				{
					UnitBookDataDicProrobufItemOne.Value.IsStory1Read = NewValue;
				};
				gSUnitBookData.OnMIParamFirstChg += delegate(int OldValue, int NewValue)
				{
					UnitBookDataDicProrobufItemOne.Value.MIParamFirst = NewValue;
				};
				gSUnitBookData.OnMIParamFullChg += delegate(int OldValue, int NewValue)
				{
					UnitBookDataDicProrobufItemOne.Value.MIParamFull = NewValue;
				};
			}
			readOnlyData4.UnitBookDataDic.OnAdd += delegate(int UnitBookDataDicKeyAdd, GSUnitBookData UnitBookDataDicItemAdd)
			{
				DictDeltaMsgInt_GSUnitBookData UnitBookDataDicProrobufAddItem = new DictDeltaMsgInt_GSUnitBookData();
				UnitBookDataDicProrobufAddItem.Key = UnitBookDataDicKeyAdd;
				if (UnitBookDataDicProrobufAddItem.Value == null)
				{
					UnitBookDataDicProrobufAddItem.Value = new GurGsPersistent.GSUnitBookData();
				}
				if (UnitBookDataDicItemAdd != null)
				{
					UnitBookDataDicProrobufAddItem.Value.IsFirstSightRead = UnitBookDataDicItemAdd.IsFirstSightRead;
					UnitBookDataDicProrobufAddItem.Value.IsStory1Read = UnitBookDataDicItemAdd.IsStory1Read;
					UnitBookDataDicProrobufAddItem.Value.MIParamFirst = UnitBookDataDicItemAdd.MIParamFirst;
					UnitBookDataDicProrobufAddItem.Value.MIParamFull = UnitBookDataDicItemAdd.MIParamFull;
				}
				ProtobufDataAll.BPCPlayerRoleData.UnitBookDataDic.Add(UnitBookDataDicProrobufAddItem);
				UnitBookDataDicItemAdd.OnIsFirstSightReadChg += delegate(bool OldValue, bool NewValue)
				{
					UnitBookDataDicProrobufAddItem.Value.IsFirstSightRead = NewValue;
				};
				UnitBookDataDicItemAdd.OnIsStory1ReadChg += delegate(bool OldValue, bool NewValue)
				{
					UnitBookDataDicProrobufAddItem.Value.IsStory1Read = NewValue;
				};
				UnitBookDataDicItemAdd.OnMIParamFirstChg += delegate(int OldValue, int NewValue)
				{
					UnitBookDataDicProrobufAddItem.Value.MIParamFirst = NewValue;
				};
				UnitBookDataDicItemAdd.OnMIParamFullChg += delegate(int OldValue, int NewValue)
				{
					UnitBookDataDicProrobufAddItem.Value.MIParamFull = NewValue;
				};
			};
			BindDictInt_GSUnitBookData unitBookDataDic = readOnlyData4.UnitBookDataDic;
			unitBookDataDic.OnRemove = (Action<int, GSUnitBookData>)Delegate.Combine(unitBookDataDic.OnRemove, (Action<int, GSUnitBookData>)delegate(int UnitBookDataDicKeyRemove, GSUnitBookData UnitBookDataDicItemRemove)
			{
				foreach (DictDeltaMsgInt_GSUnitBookData item6 in ProtobufDataAll.BPCPlayerRoleData.UnitBookDataDic)
				{
					if (item6.Key == UnitBookDataDicKeyRemove)
					{
						ProtobufDataAll.BPCPlayerRoleData.UnitBookDataDic.Remove(item6);
						break;
					}
				}
			});
			readOnlyData4.UnitBookDataDic.OnClear += delegate
			{
				ProtobufDataAll.BPCPlayerRoleData.UnitBookDataDic.Clear();
			};
			readOnlyData4.UnitBookDataDic.OnAnyValueChanged += delegate(int UnitBookDataDicKeyChange, GSUnitBookData UnitBookDataDicItemKeyChangeOld, GSUnitBookData UnitBookDataDicItemKeyChangeNew)
			{
				foreach (DictDeltaMsgInt_GSUnitBookData item7 in ProtobufDataAll.BPCPlayerRoleData.UnitBookDataDic)
				{
					if (item7.Key == UnitBookDataDicKeyChange)
					{
						if (item7.Value == null)
						{
							item7.Value = new GurGsPersistent.GSUnitBookData();
						}
						if (UnitBookDataDicItemKeyChangeNew != null)
						{
							item7.Value.IsFirstSightRead = UnitBookDataDicItemKeyChangeNew.IsFirstSightRead;
							item7.Value.IsStory1Read = UnitBookDataDicItemKeyChangeNew.IsStory1Read;
							item7.Value.MIParamFirst = UnitBookDataDicItemKeyChangeNew.MIParamFirst;
							item7.Value.MIParamFull = UnitBookDataDicItemKeyChangeNew.MIParamFull;
						}
						break;
					}
				}
			};
			readOnlyData4.SurprisePerformedList.OnAdd += delegate(int SurprisePerformedListItemAdd)
			{
				ListDeltaMsgInt item = new ListDeltaMsgInt
				{
					Value = SurprisePerformedListItemAdd
				};
				ProtobufDataAll.BPCPlayerRoleData.SurprisePerformedList.Add(item);
			};
			readOnlyData4.SurprisePerformedList.OnRemove += delegate(int SurprisePerformedListKeyRemove, int SurprisePerformedListItemRemove)
			{
				ProtobufDataAll.BPCPlayerRoleData.SurprisePerformedList.RemoveAt(SurprisePerformedListKeyRemove);
			};
			BindListInt surprisePerformedList = readOnlyData4.SurprisePerformedList;
			surprisePerformedList.OnClear = (Action)Delegate.Combine(surprisePerformedList.OnClear, (Action)delegate
			{
				ProtobufDataAll.BPCPlayerRoleData.SurprisePerformedList.Clear();
			});
			readOnlyData4.SurprisePerformedList.OnSetIdxValue += delegate(int SurprisePerformedListKeyChange, int SurprisePerformedListItemKeyChangeOld, int SurprisePerformedListItemKeyChangeNew)
			{
				ProtobufDataAll.BPCPlayerRoleData.SurprisePerformedList[SurprisePerformedListKeyChange].Value = SurprisePerformedListItemKeyChangeNew;
			};
		}
		BPC_TransData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<BPC_TransData>(Entity);
		if (readOnlyData5 != null)
		{
			if (ProtobufDataAll.BPCTransData == null)
			{
				ProtobufDataAll.BPCTransData = new GurGsPersistent.BPC_TransData();
			}
			readOnlyData5.OnCurActorResIdChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BPCTransData.CurActorResId = NewValue;
			};
		}
		BPC_RebirthPointData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BPC_RebirthPointData>(Entity);
		if (readOnlyData6 == null)
		{
			return;
		}
		if (ProtobufDataAll.BPCRebirthPointData == null)
		{
			ProtobufDataAll.BPCRebirthPointData = new GurGsPersistent.BPC_RebirthPointData();
		}
		readOnlyData6.OnCurrentBirthPointChg += delegate(FBirthPointInfo OldValue, FBirthPointInfo NewValue)
		{
			BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.SafePointChanged, "GSPersistent BPC_RebirthPointData.CurrentBirthPoint Changed");
			if (ProtobufDataAll.BPCRebirthPointData.CurrentBirthPoint == null)
			{
				ProtobufDataAll.BPCRebirthPointData.CurrentBirthPoint = new GurGsPersistent.FBirthPointInfo();
			}
			if (NewValue != null)
			{
				ProtobufDataAll.BPCRebirthPointData.CurrentBirthPoint.PointType = (int)NewValue.PointType;
				ProtobufDataAll.BPCRebirthPointData.CurrentBirthPoint.PointID = NewValue.PointID;
			}
		};
		readOnlyData6.ActivedRebirthPointList.OnAdd += delegate(int ActivedRebirthPointListItemAdd)
		{
			ListDeltaMsgInt item = new ListDeltaMsgInt
			{
				Value = ActivedRebirthPointListItemAdd
			};
			ProtobufDataAll.BPCRebirthPointData.ActivedRebirthPointList.Add(item);
		};
		readOnlyData6.ActivedRebirthPointList.OnRemove += delegate(int ActivedRebirthPointListKeyRemove, int ActivedRebirthPointListItemRemove)
		{
			ProtobufDataAll.BPCRebirthPointData.ActivedRebirthPointList.RemoveAt(ActivedRebirthPointListKeyRemove);
		};
		BindListInt activedRebirthPointList = readOnlyData6.ActivedRebirthPointList;
		activedRebirthPointList.OnClear = (Action)Delegate.Combine(activedRebirthPointList.OnClear, (Action)delegate
		{
			ProtobufDataAll.BPCRebirthPointData.ActivedRebirthPointList.Clear();
		});
		readOnlyData6.ActivedRebirthPointList.OnSetIdxValue += delegate(int ActivedRebirthPointListKeyChange, int ActivedRebirthPointListItemKeyChangeOld, int ActivedRebirthPointListItemKeyChangeNew)
		{
			ProtobufDataAll.BPCRebirthPointData.ActivedRebirthPointList[ActivedRebirthPointListKeyChange].Value = ActivedRebirthPointListItemKeyChangeNew;
		};
		readOnlyData6.BlockedRebirthPointList.OnAdd += delegate(int BlockedRebirthPointListItemAdd)
		{
			ListDeltaMsgInt item = new ListDeltaMsgInt
			{
				Value = BlockedRebirthPointListItemAdd
			};
			ProtobufDataAll.BPCRebirthPointData.BlockedRebirthPointList.Add(item);
		};
		readOnlyData6.BlockedRebirthPointList.OnRemove += delegate(int BlockedRebirthPointListKeyRemove, int BlockedRebirthPointListItemRemove)
		{
			ProtobufDataAll.BPCRebirthPointData.BlockedRebirthPointList.RemoveAt(BlockedRebirthPointListKeyRemove);
		};
		BindListInt blockedRebirthPointList = readOnlyData6.BlockedRebirthPointList;
		blockedRebirthPointList.OnClear = (Action)Delegate.Combine(blockedRebirthPointList.OnClear, (Action)delegate
		{
			ProtobufDataAll.BPCRebirthPointData.BlockedRebirthPointList.Clear();
		});
		readOnlyData6.BlockedRebirthPointList.OnSetIdxValue += delegate(int BlockedRebirthPointListKeyChange, int BlockedRebirthPointListItemKeyChangeOld, int BlockedRebirthPointListItemKeyChangeNew)
		{
			ProtobufDataAll.BPCRebirthPointData.BlockedRebirthPointList[BlockedRebirthPointListKeyChange].Value = BlockedRebirthPointListItemKeyChangeNew;
		};
		readOnlyData6.CurrentRebirthPointIDMap.OnAdd += delegate(int CurrentRebirthPointIDMapKeyAdd, int CurrentRebirthPointIDMapItemAdd)
		{
			BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.SafePointChanged, "GSPersistent BPC_RebirthPointData.CurrentRebirthPointIDMap Changed");
			DictDeltaMsgInt_Int item = new DictDeltaMsgInt_Int
			{
				Key = CurrentRebirthPointIDMapKeyAdd,
				Value = CurrentRebirthPointIDMapItemAdd
			};
			ProtobufDataAll.BPCRebirthPointData.CurrentRebirthPointIDMap.Add(item);
		};
		BindDictInt_Int currentRebirthPointIDMap = readOnlyData6.CurrentRebirthPointIDMap;
		currentRebirthPointIDMap.OnRemove = (Action<int, int>)Delegate.Combine(currentRebirthPointIDMap.OnRemove, (Action<int, int>)delegate(int CurrentRebirthPointIDMapKeyRemove, int CurrentRebirthPointIDMapItemRemove)
		{
			BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.SafePointChanged, "GSPersistent BPC_RebirthPointData.CurrentRebirthPointIDMap Changed");
			foreach (DictDeltaMsgInt_Int item8 in ProtobufDataAll.BPCRebirthPointData.CurrentRebirthPointIDMap)
			{
				if (item8.Key == CurrentRebirthPointIDMapKeyRemove)
				{
					ProtobufDataAll.BPCRebirthPointData.CurrentRebirthPointIDMap.Remove(item8);
					break;
				}
			}
		});
		readOnlyData6.CurrentRebirthPointIDMap.OnClear += delegate
		{
			BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.SafePointChanged, "GSPersistent BPC_RebirthPointData.CurrentRebirthPointIDMap Changed");
			ProtobufDataAll.BPCRebirthPointData.CurrentRebirthPointIDMap.Clear();
		};
		readOnlyData6.CurrentRebirthPointIDMap.OnAnyValueChanged += delegate(int CurrentRebirthPointIDMapKeyChange, int CurrentRebirthPointIDMapItemKeyChangeOld, int CurrentRebirthPointIDMapItemKeyChangeNew)
		{
			BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.SafePointChanged, "GSPersistent BPC_RebirthPointData.CurrentRebirthPointIDMap Changed");
			foreach (DictDeltaMsgInt_Int item9 in ProtobufDataAll.BPCRebirthPointData.CurrentRebirthPointIDMap)
			{
				if (item9.Key == CurrentRebirthPointIDMapKeyChange)
				{
					BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.SafePointChanged, "GSPersistent BPC_RebirthPointData.CurrentRebirthPointIDMap Changed");
					item9.Value = CurrentRebirthPointIDMapItemKeyChangeNew;
					break;
				}
			}
		};
		readOnlyData6.OnLastRebirthPointTimeChg += delegate(int OldValue, int NewValue)
		{
			ProtobufDataAll.BPCRebirthPointData.LastRebirthPointTime = NewValue;
		};
	}

	public void BindAllBGCDataChange(Entity Entity)
	{
		PersistentBGCData ProtobufDataAll = PersistentECSData.GetPersistentBGCData();
		BGC_CollectionGroupData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_CollectionGroupData>(Entity);
		if (readOnlyData != null)
		{
			if (ProtobufDataAll.BGCCollectionGroupData == null)
			{
				ProtobufDataAll.BGCCollectionGroupData = new GurGsPersistent.BGC_CollectionGroupData();
			}
			for (int i = 0; i < readOnlyData.CollectionGroupDataInfo.Count; i++)
			{
				DictDeltaMsgInt_CollectionGroupDataInfo CollectionGroupDataInfoProrobufItemOne = ProtobufDataAll.BGCCollectionGroupData.CollectionGroupDataInfo[i];
				CollectionGroupDataInfo collectionGroupDataInfo = readOnlyData.CollectionGroupDataInfo[CollectionGroupDataInfoProrobufItemOne.Key];
				collectionGroupDataInfo.OnFreshTimeChg += delegate(int OldValue, int NewValue)
				{
					CollectionGroupDataInfoProrobufItemOne.Value.FreshTime = NewValue;
				};
				collectionGroupDataInfo.OnFreshCountChg += delegate(int OldValue, int NewValue)
				{
					CollectionGroupDataInfoProrobufItemOne.Value.FreshCount = NewValue;
				};
			}
			readOnlyData.CollectionGroupDataInfo.OnAdd += delegate(int CollectionGroupDataInfoKeyAdd, CollectionGroupDataInfo CollectionGroupDataInfoItemAdd)
			{
				DictDeltaMsgInt_CollectionGroupDataInfo CollectionGroupDataInfoProrobufAddItem = new DictDeltaMsgInt_CollectionGroupDataInfo();
				CollectionGroupDataInfoProrobufAddItem.Key = CollectionGroupDataInfoKeyAdd;
				if (CollectionGroupDataInfoProrobufAddItem.Value == null)
				{
					CollectionGroupDataInfoProrobufAddItem.Value = new GurGsPersistent.CollectionGroupDataInfo();
				}
				if (CollectionGroupDataInfoItemAdd != null)
				{
					CollectionGroupDataInfoProrobufAddItem.Value.FreshTime = CollectionGroupDataInfoItemAdd.FreshTime;
					CollectionGroupDataInfoProrobufAddItem.Value.FreshCount = CollectionGroupDataInfoItemAdd.FreshCount;
				}
				ProtobufDataAll.BGCCollectionGroupData.CollectionGroupDataInfo.Add(CollectionGroupDataInfoProrobufAddItem);
				CollectionGroupDataInfoItemAdd.OnFreshTimeChg += delegate(int OldValue, int NewValue)
				{
					CollectionGroupDataInfoProrobufAddItem.Value.FreshTime = NewValue;
				};
				CollectionGroupDataInfoItemAdd.OnFreshCountChg += delegate(int OldValue, int NewValue)
				{
					CollectionGroupDataInfoProrobufAddItem.Value.FreshCount = NewValue;
				};
			};
			BindDictInt_CollectionGroupDataInfo collectionGroupDataInfo2 = readOnlyData.CollectionGroupDataInfo;
			collectionGroupDataInfo2.OnRemove = (Action<int, CollectionGroupDataInfo>)Delegate.Combine(collectionGroupDataInfo2.OnRemove, (Action<int, CollectionGroupDataInfo>)delegate(int CollectionGroupDataInfoKeyRemove, CollectionGroupDataInfo CollectionGroupDataInfoItemRemove)
			{
				foreach (DictDeltaMsgInt_CollectionGroupDataInfo item2 in ProtobufDataAll.BGCCollectionGroupData.CollectionGroupDataInfo)
				{
					if (item2.Key == CollectionGroupDataInfoKeyRemove)
					{
						ProtobufDataAll.BGCCollectionGroupData.CollectionGroupDataInfo.Remove(item2);
						break;
					}
				}
			});
			readOnlyData.CollectionGroupDataInfo.OnClear += delegate
			{
				ProtobufDataAll.BGCCollectionGroupData.CollectionGroupDataInfo.Clear();
			};
			readOnlyData.CollectionGroupDataInfo.OnAnyValueChanged += delegate(int CollectionGroupDataInfoKeyChange, CollectionGroupDataInfo CollectionGroupDataInfoItemKeyChangeOld, CollectionGroupDataInfo CollectionGroupDataInfoItemKeyChangeNew)
			{
				foreach (DictDeltaMsgInt_CollectionGroupDataInfo item3 in ProtobufDataAll.BGCCollectionGroupData.CollectionGroupDataInfo)
				{
					if (item3.Key == CollectionGroupDataInfoKeyChange)
					{
						if (item3.Value == null)
						{
							item3.Value = new GurGsPersistent.CollectionGroupDataInfo();
						}
						if (CollectionGroupDataInfoItemKeyChangeNew != null)
						{
							item3.Value.FreshTime = CollectionGroupDataInfoItemKeyChangeNew.FreshTime;
							item3.Value.FreshCount = CollectionGroupDataInfoItemKeyChangeNew.FreshCount;
						}
						break;
					}
				}
			};
		}
		BGC_GameStateTestData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BGC_GameStateTestData>(Entity);
		if (readOnlyData2 != null)
		{
			if (ProtobufDataAll.BGCGameStateTestData == null)
			{
				ProtobufDataAll.BGCGameStateTestData = new GurGsPersistent.BGC_GameStateTestData();
			}
			readOnlyData2.TestIDList.OnAdd += delegate(int TestIDListItemAdd)
			{
				ListDeltaMsgInt item = new ListDeltaMsgInt
				{
					Value = TestIDListItemAdd
				};
				ProtobufDataAll.BGCGameStateTestData.TestIDList.Add(item);
			};
			readOnlyData2.TestIDList.OnRemove += delegate(int TestIDListKeyRemove, int TestIDListItemRemove)
			{
				ProtobufDataAll.BGCGameStateTestData.TestIDList.RemoveAt(TestIDListKeyRemove);
			};
			BindListInt testIDList = readOnlyData2.TestIDList;
			testIDList.OnClear = (Action)Delegate.Combine(testIDList.OnClear, (Action)delegate
			{
				ProtobufDataAll.BGCGameStateTestData.TestIDList.Clear();
			});
			readOnlyData2.TestIDList.OnSetIdxValue += delegate(int TestIDListKeyChange, int TestIDListItemKeyChangeOld, int TestIDListItemKeyChangeNew)
			{
				ProtobufDataAll.BGCGameStateTestData.TestIDList[TestIDListKeyChange].Value = TestIDListItemKeyChangeNew;
			};
			readOnlyData2.TestPropIDDict.OnAdd += delegate(EPropType TestPropIDDictKeyAdd, uint TestPropIDDictItemAdd)
			{
				DictDeltaMsgEPropType_UInt item = new DictDeltaMsgEPropType_UInt
				{
					Key = (int)TestPropIDDictKeyAdd,
					Value = TestPropIDDictItemAdd
				};
				ProtobufDataAll.BGCGameStateTestData.TestPropIDDict.Add(item);
			};
			BindDictEPropType_UInt testPropIDDict = readOnlyData2.TestPropIDDict;
			testPropIDDict.OnRemove = (Action<EPropType, uint>)Delegate.Combine(testPropIDDict.OnRemove, (Action<EPropType, uint>)delegate(EPropType TestPropIDDictKeyRemove, uint TestPropIDDictItemRemove)
			{
				foreach (DictDeltaMsgEPropType_UInt item4 in ProtobufDataAll.BGCGameStateTestData.TestPropIDDict)
				{
					if (item4.Key == (int)TestPropIDDictKeyRemove)
					{
						ProtobufDataAll.BGCGameStateTestData.TestPropIDDict.Remove(item4);
						break;
					}
				}
			});
			readOnlyData2.TestPropIDDict.OnClear += delegate
			{
				ProtobufDataAll.BGCGameStateTestData.TestPropIDDict.Clear();
			};
			readOnlyData2.TestPropIDDict.OnAnyValueChanged += delegate(EPropType TestPropIDDictKeyChange, uint TestPropIDDictItemKeyChangeOld, uint TestPropIDDictItemKeyChangeNew)
			{
				foreach (DictDeltaMsgEPropType_UInt item5 in ProtobufDataAll.BGCGameStateTestData.TestPropIDDict)
				{
					if (item5.Key == (int)TestPropIDDictKeyChange)
					{
						item5.Value = TestPropIDDictItemKeyChangeNew;
						break;
					}
				}
			};
			for (int num = 0; num < readOnlyData2.TestInnerClassList.Count; num++)
			{
				_ = ProtobufDataAll.BGCGameStateTestData.TestInnerClassList[num];
				_ = readOnlyData2.TestInnerClassList[num];
			}
			readOnlyData2.TestInnerClassList.OnAdd += delegate
			{
				ListDeltaMsgFRepInnerClass listDeltaMsgFRepInnerClass = new ListDeltaMsgFRepInnerClass();
				if (listDeltaMsgFRepInnerClass.Value == null)
				{
					listDeltaMsgFRepInnerClass.Value = new GurGsPersistent.FRepInnerClass();
				}
				ProtobufDataAll.BGCGameStateTestData.TestInnerClassList.Add(listDeltaMsgFRepInnerClass);
			};
			readOnlyData2.TestInnerClassList.OnRemove += delegate(int TestInnerClassListKeyRemove, FRepInnerClass TestInnerClassListItemRemove)
			{
				ProtobufDataAll.BGCGameStateTestData.TestInnerClassList.RemoveAt(TestInnerClassListKeyRemove);
			};
			BindListFRepInnerClass testInnerClassList = readOnlyData2.TestInnerClassList;
			testInnerClassList.OnClear = (Action)Delegate.Combine(testInnerClassList.OnClear, (Action)delegate
			{
				ProtobufDataAll.BGCGameStateTestData.TestInnerClassList.Clear();
			});
			readOnlyData2.TestInnerClassList.OnSetIdxValue += delegate(int TestInnerClassListKeyChange, FRepInnerClass TestInnerClassListItemKeyChangeOld, FRepInnerClass TestInnerClassListItemKeyChangeNew)
			{
				if (ProtobufDataAll.BGCGameStateTestData.TestInnerClassList[TestInnerClassListKeyChange].Value == null)
				{
					ProtobufDataAll.BGCGameStateTestData.TestInnerClassList[TestInnerClassListKeyChange].Value = new GurGsPersistent.FRepInnerClass();
				}
			};
			readOnlyData2.OnTestIDChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BGCGameStateTestData.TestID = NewValue;
			};
		}
		BGC_OnlineAssistData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BGC_OnlineAssistData>(Entity);
		if (readOnlyData3 != null)
		{
			if (ProtobufDataAll.BGCOnlineAssistData == null)
			{
				ProtobufDataAll.BGCOnlineAssistData = new GurGsPersistent.BGC_OnlineAssistData();
			}
			for (int num2 = 0; num2 < readOnlyData3.CrusadeMonsterInfos.Count; num2++)
			{
				DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo = ProtobufDataAll.BGCOnlineAssistData.CrusadeMonsterInfos[num2];
				_ = readOnlyData3.CrusadeMonsterInfos[dictDeltaMsgString_FCrusadeUnitInfo.Key];
			}
			readOnlyData3.CrusadeMonsterInfos.OnAdd += delegate(string CrusadeMonsterInfosKeyAdd, FCrusadeUnitInfo CrusadeMonsterInfosItemAdd)
			{
				DictDeltaMsgString_FCrusadeUnitInfo dictDeltaMsgString_FCrusadeUnitInfo2 = new DictDeltaMsgString_FCrusadeUnitInfo
				{
					Key = CrusadeMonsterInfosKeyAdd
				};
				if (dictDeltaMsgString_FCrusadeUnitInfo2.Value == null)
				{
					dictDeltaMsgString_FCrusadeUnitInfo2.Value = new GurGsPersistent.FCrusadeUnitInfo();
				}
				ProtobufDataAll.BGCOnlineAssistData.CrusadeMonsterInfos.Add(dictDeltaMsgString_FCrusadeUnitInfo2);
			};
			BindDictString_FCrusadeUnitInfo crusadeMonsterInfos = readOnlyData3.CrusadeMonsterInfos;
			crusadeMonsterInfos.OnRemove = (Action<string, FCrusadeUnitInfo>)Delegate.Combine(crusadeMonsterInfos.OnRemove, (Action<string, FCrusadeUnitInfo>)delegate(string CrusadeMonsterInfosKeyRemove, FCrusadeUnitInfo CrusadeMonsterInfosItemRemove)
			{
				foreach (DictDeltaMsgString_FCrusadeUnitInfo crusadeMonsterInfo in ProtobufDataAll.BGCOnlineAssistData.CrusadeMonsterInfos)
				{
					if (crusadeMonsterInfo.Key == CrusadeMonsterInfosKeyRemove)
					{
						ProtobufDataAll.BGCOnlineAssistData.CrusadeMonsterInfos.Remove(crusadeMonsterInfo);
						break;
					}
				}
			});
			readOnlyData3.CrusadeMonsterInfos.OnClear += delegate
			{
				ProtobufDataAll.BGCOnlineAssistData.CrusadeMonsterInfos.Clear();
			};
			readOnlyData3.CrusadeMonsterInfos.OnAnyValueChanged += delegate(string CrusadeMonsterInfosKeyChange, FCrusadeUnitInfo CrusadeMonsterInfosItemKeyChangeOld, FCrusadeUnitInfo CrusadeMonsterInfosItemKeyChangeNew)
			{
				foreach (DictDeltaMsgString_FCrusadeUnitInfo crusadeMonsterInfo2 in ProtobufDataAll.BGCOnlineAssistData.CrusadeMonsterInfos)
				{
					if (crusadeMonsterInfo2.Key == CrusadeMonsterInfosKeyChange)
					{
						if (crusadeMonsterInfo2.Value == null)
						{
							crusadeMonsterInfo2.Value = new GurGsPersistent.FCrusadeUnitInfo();
						}
						if (CrusadeMonsterInfosItemKeyChangeNew == null)
						{
						}
						break;
					}
				}
			};
		}
		BGC_PigsyStoryData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BGC_PigsyStoryData>(Entity);
		if (readOnlyData4 != null)
		{
			if (ProtobufDataAll.BGCPigsyStoryData == null)
			{
				ProtobufDataAll.BGCPigsyStoryData = new GurGsPersistent.BGC_PigsyStoryData();
			}
			readOnlyData4.FinishedStoryMemory.OnAdd += delegate(int FinishedStoryMemoryItemAdd)
			{
				ListDeltaMsgInt item = new ListDeltaMsgInt
				{
					Value = FinishedStoryMemoryItemAdd
				};
				ProtobufDataAll.BGCPigsyStoryData.FinishedStoryMemory.Add(item);
			};
			readOnlyData4.FinishedStoryMemory.OnRemove += delegate(int FinishedStoryMemoryKeyRemove, int FinishedStoryMemoryItemRemove)
			{
				ProtobufDataAll.BGCPigsyStoryData.FinishedStoryMemory.RemoveAt(FinishedStoryMemoryKeyRemove);
			};
			BindListInt finishedStoryMemory = readOnlyData4.FinishedStoryMemory;
			finishedStoryMemory.OnClear = (Action)Delegate.Combine(finishedStoryMemory.OnClear, (Action)delegate
			{
				ProtobufDataAll.BGCPigsyStoryData.FinishedStoryMemory.Clear();
			});
			readOnlyData4.FinishedStoryMemory.OnSetIdxValue += delegate(int FinishedStoryMemoryKeyChange, int FinishedStoryMemoryItemKeyChangeOld, int FinishedStoryMemoryItemKeyChangeNew)
			{
				ProtobufDataAll.BGCPigsyStoryData.FinishedStoryMemory[FinishedStoryMemoryKeyChange].Value = FinishedStoryMemoryItemKeyChangeNew;
			};
		}
		BGC_PlayerDeathData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<BGC_PlayerDeathData>(Entity);
		if (readOnlyData5 != null)
		{
			if (ProtobufDataAll.BGCPlayerDeathData == null)
			{
				ProtobufDataAll.BGCPlayerDeathData = new GurGsPersistent.BGC_PlayerDeathData();
			}
			readOnlyData5.OnPlayerDeathCountChg += delegate(int OldValue, int NewValue)
			{
				ProtobufDataAll.BGCPlayerDeathData.PlayerDeathCount = NewValue;
			};
			readOnlyData5.ChapterDeathDict.OnAdd += delegate(int ChapterDeathDictKeyAdd, int ChapterDeathDictItemAdd)
			{
				DictDeltaMsgInt_Int item = new DictDeltaMsgInt_Int
				{
					Key = ChapterDeathDictKeyAdd,
					Value = ChapterDeathDictItemAdd
				};
				ProtobufDataAll.BGCPlayerDeathData.ChapterDeathDict.Add(item);
			};
			BindDictInt_Int chapterDeathDict = readOnlyData5.ChapterDeathDict;
			chapterDeathDict.OnRemove = (Action<int, int>)Delegate.Combine(chapterDeathDict.OnRemove, (Action<int, int>)delegate(int ChapterDeathDictKeyRemove, int ChapterDeathDictItemRemove)
			{
				foreach (DictDeltaMsgInt_Int item6 in ProtobufDataAll.BGCPlayerDeathData.ChapterDeathDict)
				{
					if (item6.Key == ChapterDeathDictKeyRemove)
					{
						ProtobufDataAll.BGCPlayerDeathData.ChapterDeathDict.Remove(item6);
						break;
					}
				}
			});
			readOnlyData5.ChapterDeathDict.OnClear += delegate
			{
				ProtobufDataAll.BGCPlayerDeathData.ChapterDeathDict.Clear();
			};
			readOnlyData5.ChapterDeathDict.OnAnyValueChanged += delegate(int ChapterDeathDictKeyChange, int ChapterDeathDictItemKeyChangeOld, int ChapterDeathDictItemKeyChangeNew)
			{
				foreach (DictDeltaMsgInt_Int item7 in ProtobufDataAll.BGCPlayerDeathData.ChapterDeathDict)
				{
					if (item7.Key == ChapterDeathDictKeyChange)
					{
						item7.Value = ChapterDeathDictItemKeyChangeNew;
						break;
					}
				}
			};
		}
		BGC_PlayerGuideData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BGC_PlayerGuideData>(Entity);
		if (readOnlyData6 != null)
		{
			if (ProtobufDataAll.BGCPlayerGuideData == null)
			{
				ProtobufDataAll.BGCPlayerGuideData = new GurGsPersistent.BGC_PlayerGuideData();
			}
			readOnlyData6.FinishedGroupGuideList.OnAdd += delegate(int FinishedGroupGuideListItemAdd)
			{
				BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.FinishPlayerGuide, "GSPersistent BGC_PlayerGuideData.FinishedGroupGuideList Changed");
				ListDeltaMsgInt item = new ListDeltaMsgInt
				{
					Value = FinishedGroupGuideListItemAdd
				};
				ProtobufDataAll.BGCPlayerGuideData.FinishedGroupGuideList.Add(item);
			};
			readOnlyData6.FinishedGroupGuideList.OnRemove += delegate(int FinishedGroupGuideListKeyRemove, int FinishedGroupGuideListItemRemove)
			{
				BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.FinishPlayerGuide, "GSPersistent BGC_PlayerGuideData.FinishedGroupGuideList Changed");
				ProtobufDataAll.BGCPlayerGuideData.FinishedGroupGuideList.RemoveAt(FinishedGroupGuideListKeyRemove);
			};
			BindListInt finishedGroupGuideList = readOnlyData6.FinishedGroupGuideList;
			finishedGroupGuideList.OnClear = (Action)Delegate.Combine(finishedGroupGuideList.OnClear, (Action)delegate
			{
				BGW_GameArchiveMgr.Get(Entity).MarkDelaySaveArchive(EArchiveDelaySaveSource.FinishPlayerGuide, "GSPersistent BGC_PlayerGuideData.FinishedGroupGuideList Changed");
				ProtobufDataAll.BGCPlayerGuideData.FinishedGroupGuideList.Clear();
			});
			readOnlyData6.FinishedGroupGuideList.OnSetIdxValue += delegate(int FinishedGroupGuideListKeyChange, int FinishedGroupGuideListItemKeyChangeOld, int FinishedGroupGuideListItemKeyChangeNew)
			{
				ProtobufDataAll.BGCPlayerGuideData.FinishedGroupGuideList[FinishedGroupGuideListKeyChange].Value = FinishedGroupGuideListItemKeyChangeNew;
			};
		}
	}

	public override void OnAttach()
	{
		PersistentECSData = RequireWritableGameInstanceData<BIC_PersistentECSData>();
		LevelData = RequireWritableGameInstanceData<BIC_LevelData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(bGW_EventCollection.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnResetGameData));
			bGW_EventCollection.Evt_RecoverArchiveData = (BGW_EventCollection.Del_BGW_Void_ArchiveData)Delegate.Combine(bGW_EventCollection.Evt_RecoverArchiveData, new BGW_EventCollection.Del_BGW_Void_ArchiveData(OnRecoverArchiveData));
			bGW_EventCollection.Evt_SerializePersistentECSData = (Func<PersistentECSData>)Delegate.Combine(bGW_EventCollection.Evt_SerializePersistentECSData, new Func<PersistentECSData>(OnSerializePersistentECSData));
			bGW_EventCollection.Evt_NotifyActorGuid2EntityOnDataConvert = (Del_Void_ActorString)Delegate.Combine(bGW_EventCollection.Evt_NotifyActorGuid2EntityOnDataConvert, new Del_Void_ActorString(OnNotifyActorGuid2Entity));
			bGW_EventCollection.Evt_PreECSWorldBeginPlay = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PreECSWorldBeginPlay, new Del_Void(OnPreECSWorldBeginPlay));
		}
	}

	private void OnPreECSWorldBeginPlay()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		ECSPersistentDataSerializeFuncLib.DeSerializeBPCEntity(firstLocalPlayerController, ECSExtension.ToEntity(firstLocalPlayerController));
		BindAllBPCDataChange(ECSExtension.ToEntity(firstLocalPlayerController));
		ECSPersistentDataSerializeFuncLib.DeSerializeBPCEntity(firstLocalPlayerController.PlayerState, ECSExtension.ToEntity(firstLocalPlayerController.PlayerState));
		BindAllBPCDataChange(ECSExtension.ToEntity(firstLocalPlayerController.PlayerState));
		AGameStateBase gameState = UGameplayStatics.GetGameState(base.Owner);
		ECSPersistentDataSerializeFuncLib.DeSerializeBGCEntity(gameState, ECSExtension.ToEntity(gameState));
		BindAllBGCDataChange(ECSExtension.ToEntity(gameState));
	}

	private PersistentECSData OnSerializePersistentECSData()
	{
		return PersistentECSData.PersistentECSData.Clone();
	}

	private void OnNotifyActorGuid2Entity(AActor Actor, string Guid)
	{
		if (Actor is ABGUCharacter aBGUCharacter)
		{
			ABGUTamerBase tamerOwner = aBGUCharacter.GetTamerOwner();
			if (tamerOwner.IsNullOrDestroyed() || !tamerOwner.BeginPlayFromLevelStreaming)
			{
				return;
			}
		}
		else if (!(Actor is ABGUActorBase { BeginPlayFromLevelStreaming: not false }))
		{
			return;
		}
		if (GSEUtil.Ensure(!string.IsNullOrEmpty(Guid), "OnSetActorGuid2Entity IsNullOrEmpty(Guid)", DebugOpenDialog: false))
		{
			string CurrentLevelName = UGameplayStatics.GetCurrentLevelName(base.Owner);
			int num = GameDBRuntime.GetTBLevelDesc().List.FirstOrDefault((LevelDesc item) => item.Path == CurrentLevelName)?.Id ?? 0;
			ECSPersistentDataSerializeFuncLib.DeSerializeBUCEntity(Actor, num, Guid, ECSExtension.ToEntity(Actor));
			BindAllBUCDataChange(ECSExtension.ToEntity(Actor), num, Guid);
		}
	}

	private void OnRecoverArchiveData(FUStBEDArchivesData ArchivesData)
	{
		PersistentECSData.RecoverECSData(ArchivesData.PersistentECSData);
	}

	private void OnResetGameData(EGameInstanceResetType ResetType)
	{
		switch (ResetType)
		{
		case EGameInstanceResetType.QuitGame:
		case EGameInstanceResetType.StartNewGame:
			PersistentECSData.Reset();
			break;
		case EGameInstanceResetType.NewGamePlus:
			PersistentECSData.ResetOnNewGamePlus();
			break;
		}
	}
}
