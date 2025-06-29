using System.Collections.Generic;
using b1.BGW;
using b1.UI;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class DSMapWidget : UIBindData
{
	private DS_IBPC_GeoInfoData GeoInfoData;

	private DS_IBPC_MapAreaData MapAreaData;

	private DS_IBPC_PlayerRoleData PlayerRoleData;

	public readonly GSBindProp<int> MapSpriteId = new GSBindProp<int>();

	public readonly GSBindProp<int> SelectedAreaId = new GSBindProp<int>();

	public readonly GSBindProp<FVector2D> MapBasePos = new GSBindProp<FVector2D>();

	public readonly GSBindProp<float> MapScale = new GSBindProp<float>();

	public readonly GSBindProp<string> MapFocusGuid = new GSBindProp<string>();

	public readonly GSBindProp<List<string>> MapSelectedGuidList = new GSBindProp<List<string>>();

	public readonly GSBindDictionary<EMapSymbolType, DSMapSymbolLevel> MapSymbolLevelDic = new GSBindDictionary<EMapSymbolType, DSMapSymbolLevel>();

	private readonly Dictionary<string, DSMapSymbol> MapSymbolDic = new Dictionary<string, DSMapSymbol>();

	public readonly GSBindDictionary<int, DSMapSprite> MapSpriteDic = new GSBindDictionary<int, DSMapSprite>();

	public readonly GSBindProp<int> PinCount = new GSBindProp<int>();

	public readonly GSBindProp<int> PinMaxCount = new GSBindProp<int>();

	public readonly GSBindProp<int> ShowPinCount = new GSBindProp<int>();

	private readonly List<DSMapSymbol> ShowCustomSymbolList = new List<DSMapSymbol>();

	public readonly GSBindProp<FVector2D> CursorPos = new GSBindProp<FVector2D>();

	public readonly GSBindProp<bool> OverrideCursorPos = new GSBindProp<bool>();

	public readonly GSBindProp<bool> CanShowCursor = new GSBindProp<bool>();

	public readonly GSBindProp<bool> ShowCursor = new GSBindProp<bool>();

	public readonly GSBindProp<bool> BlockFocus = new GSBindProp<bool>();

	public readonly GSBindProp<bool> AlwayFocus = new GSBindProp<bool>();

	public readonly GSBindProp<bool> IsBlockImgEffect = new GSBindProp<bool>();

	private FMapSpriteConfig SpriteConfig;

	private BlockInputHelper BlockInputData = new BlockInputHelper();

	public FVector2D GetUpperLeftMapPos(FVector2D OriginMapPos)
	{
		return OriginMapPos + GetMapSpriteHelfSize();
	}

	public FVector2D GetOriginMapPos(FVector2D UpperLeftMapPos)
	{
		return UpperLeftMapPos - GetMapSpriteHelfSize();
	}

	public FVector2D ClampTo1024(FVector2D InMapPos)
	{
		FVector2D fVector2D = GetMapSpriteHelfSize() * 2.0;
		if (fVector2D.IsNearlyZero())
		{
			return FVector2D.ZeroVector;
		}
		return new FVector2D(InMapPos.X / fVector2D.X * 1024f, InMapPos.Y / fVector2D.Y * 1024f);
	}

	public DSMapWidget(BUI_Widget InBindWidget)
		: base(InBindWidget)
	{
		PinMaxCount.InitForEnumBugFix(50);
		CanShowCursor.InitForEnumBugFix(InitValue: true);
		GeoInfoData = B1GSUIActorMgr.Get(RootWidget).GetBattleData<DS_IBPC_GeoInfoData>(B1ActorTag.PlayerController);
		PlayerRoleData = B1GSUIActorMgr.Get(RootWidget).GetBattleData<DS_IBPC_PlayerRoleData>(B1ActorTag.PlayerController);
		MapAreaData = B1GSUIActorMgr.Get(RootWidget).GetBattleData<DS_IBPC_MapAreaData>(B1ActorTag.LocalPlayerState);
		MapBasePos.InitForEnumBugFix(FVector2D.ZeroVector);
		InitData();
		BindValueToCustom(MapSpriteId, OnMapSpriteIdChanged);
		BindValueToCustom(MapFocusGuid, OnChangeMapFocusGuid);
		if (GeoInfoData != null)
		{
			BindListGeoInfoCustomData customGeoInfoList = GeoInfoData.GetCustomGeoInfoList();
			BindListToOnAdd(customGeoInfoList, OnCustomGeoInfoListAdd);
			BindListToOnRemove(customGeoInfoList, OnCustomGeoInfoListRemove);
			PinCount.SetValue(EChangeReason.Init, customGeoInfoList.Count);
		}
	}

	public void InitData()
	{
		MapSymbolLevelDic.Clear();
		for (int i = 1; i < 5; i++)
		{
			EMapSymbolType eMapSymbolType = (EMapSymbolType)i;
			MapSymbolLevelDic.Add(eMapSymbolType, new DSMapSymbolLevel(this, eMapSymbolType));
		}
	}

	private void InitMapSymbol()
	{
		MapSymbolDic.Clear();
		foreach (KeyValuePair<EMapSymbolType, DSMapSymbolLevel> item in MapSymbolLevelDic)
		{
			item.Value.Clear();
		}
		ShowCustomSymbolList.Clear();
		ShowPinCount.SetValue(EChangeReason.Init, 0);
		if (MapAreaData.TryGetMapPositionByPlayer(RootWidget, out var MapSpriteId, out var MapPosition, out var MapRotation) && GameDBRuntime.IsSameAtlas(MapSpriteId, this.MapSpriteId.Value))
		{
			bool flag = MapSpriteId == this.MapSpriteId.Value;
			DSMapSymbol dSMapSymbol = AddMapSymbol(EMapSymbolType.Player, 0, FText.FromString("Player"), MapPosition);
			dSMapSymbol.SetAngle(MapRotation);
			dSMapSymbol.SetStateParams(flag ? 1 : 0);
		}
		List<int> canTeleportRebirthPointList = GSEUtil.GetCanTeleportRebirthPointList(RootWidget);
		if (GeoInfoData != null)
		{
			foreach (GeoInfoStruct rebirthPointGeoInfo in GeoInfoData.GetRebirthPointGeoInfoList())
			{
				if (rebirthPointGeoInfo.MapSpriteId == this.MapSpriteId.Value && canTeleportRebirthPointList.Contains(rebirthPointGeoInfo.Id))
				{
					AddMapSymbol(InPos: new FVector2D(rebirthPointGeoInfo.PosX, rebirthPointGeoInfo.PosY), InSymbolType: EMapSymbolType.RebirthPoint, Id: rebirthPointGeoInfo.Id, InName: rebirthPointGeoInfo.Name);
				}
			}
			foreach (GeoInfoCustomData customGeoInfo in GeoInfoData.GetCustomGeoInfoList())
			{
				CreateCustomSymbol(customGeoInfo);
			}
		}
		Dictionary<int, ShrineShowNpcConfigDesc> dictionary = new Dictionary<int, ShrineShowNpcConfigDesc>();
		foreach (ShrineShowNpcConfigDesc item2 in GameDBRuntime.GetTBShrineShowNpcConfigDesc().List)
		{
			if (item2.MapSpriteId == this.MapSpriteId.Value && GetNpcShowState(item2, out var State))
			{
				if (State == EGeoInfoState.Active)
				{
					dictionary[item2.NpcId] = item2;
				}
				else
				{
					dictionary.Remove(item2.NpcId);
				}
			}
		}
		foreach (ShrineShowNpcConfigDesc value in dictionary.Values)
		{
			AddMapSymbol(InPos: new FVector2D(value.MapPosX, value.MapPosY), InSymbolType: EMapSymbolType.Npc, Id: value.NpcId, InName: FText.GetEmpty());
		}
	}

	public bool TryGetPlayerAngle(out float PlayerAngle)
	{
		PlayerAngle = 0f;
		if (RootWidget.IsNullOrDestroyed())
		{
			return false;
		}
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(RootWidget)?.GetControlledPawn();
		if (aPawn.IsNullOrDestroyed())
		{
			return false;
		}
		PlayerAngle = BGUFuncLibActorTransformCS.BGUGetActorRotation(aPawn).Yaw + 90f;
		return true;
	}

	private bool GetNpcShowState(ShrineShowNpcConfigDesc ShrineShowNpcConfigDesc, out EGeoInfoState State)
	{
		bool result = false;
		State = EGeoInfoState.Disable;
		if (PlayerRoleData != null && PlayerRoleData.RoleData != null && PlayerRoleData.RoleData.RoleCs != null && PlayerRoleData.RoleData.RoleCs.Task != null)
		{
			if (ShrineShowNpcConfigDesc.ShowTaskStageId != 0)
			{
				foreach (ReadOnlyQuestStageOne quest in PlayerRoleData.RoleData.RoleCs.Task.QuestList)
				{
					if (quest.Id == ShrineShowNpcConfigDesc.ShowTaskStageId)
					{
						if ((int)quest.Stage >= ((ShrineShowNpcConfigDesc.ShowStage != 1) ? 1 : 2))
						{
							State = EGeoInfoState.Active;
							result = true;
						}
						break;
					}
				}
			}
			if (ShrineShowNpcConfigDesc.HideTaskStageId != 0)
			{
				foreach (ReadOnlyQuestStageOne quest2 in PlayerRoleData.RoleData.RoleCs.Task.QuestList)
				{
					if (quest2.Id == ShrineShowNpcConfigDesc.HideTaskStageId)
					{
						if ((int)quest2.Stage >= ((ShrineShowNpcConfigDesc.HideStage != 1) ? 1 : 2))
						{
							State = EGeoInfoState.Disable;
							result = true;
						}
						break;
					}
				}
			}
		}
		return result;
	}

	private DSMapSymbol AddMapSymbol(EMapSymbolType InSymbolType, int Id, FText InName, FVector2D InPos)
	{
		DSMapSymbol dSMapSymbol = new DSMapSymbol(this, InSymbolType, Id);
		dSMapSymbol.SetName(InName);
		dSMapSymbol.SetMapPos(InPos);
		dSMapSymbol.SetFocusScale(SpriteConfig.MapLevelCommConfig.SelectedScale);
		if (!MapSymbolDic.ContainsKey(dSMapSymbol.Guid))
		{
			MapSymbolDic.Add(dSMapSymbol.Guid, dSMapSymbol);
			if (MapSymbolLevelDic.TryGetValue(dSMapSymbol.MapSymbolType.Value, out var OutValue))
			{
				OutValue.AddMapSymbol(dSMapSymbol);
			}
		}
		dSMapSymbol.SetIsVisable(InIsVisable: true);
		return dSMapSymbol;
	}

	private void RemoveMapSymbol(DSMapSymbol MapSymbol)
	{
		if (MapSymbol != null)
		{
			MapSymbolDic.Remove(MapSymbol.Guid);
			if (MapSymbolLevelDic.TryGetValue(MapSymbol.MapSymbolType.Value, out var OutValue))
			{
				OutValue.RemoveMapSymbol(MapSymbol);
			}
		}
	}

	private void OnMapSpriteIdChanged(EChangeReason Reason, int OldValue, int NewValue)
	{
		(BGW_PreloadAssetMgr.Get(RootWidget)?.MapConfigDataAsset)?.SpriteConfigMap.TryGetValue(NewValue, out SpriteConfig);
		MapSpriteDic.Remove(OldValue);
		if (!MapSpriteDic.ContainsKey(NewValue))
		{
			DSMapSprite valueItem = new DSMapSprite(this, NewValue);
			MapSpriteDic.Add(NewValue, valueItem);
		}
		MapScale.SetValue(EChangeReason.Init, FMath.Clamp(MapScale.Value, 0f, 1f), Force: true);
		InitMapSymbol();
	}

	private void OnChangeMapFocusGuid(EChangeReason Reason, string OldValue, string NewValue)
	{
		if (!string.IsNullOrEmpty(OldValue))
		{
			GetMapSymbol(OldValue)?.SetIsFocused(InIsFocused: false);
		}
		if (!string.IsNullOrEmpty(NewValue))
		{
			GetMapSymbol(NewValue)?.SetIsFocused(InIsFocused: true);
		}
	}

	private void OnCustomGeoInfoListAdd(GeoInfoCustomData OneItem)
	{
		if (OneItem != null)
		{
			CreateCustomSymbol(OneItem);
			PinCount.SetValue(EChangeReason.ManualSet, PinCount.Value + 1);
		}
	}

	private void OnCustomGeoInfoListRemove(int Idx, GeoInfoCustomData OneItem)
	{
		if (OneItem != null)
		{
			DestroyCustomSymbol(OneItem);
			PinCount.SetValue(EChangeReason.ManualSet, PinCount.Value - 1);
		}
	}

	private void CreateCustomSymbol(GeoInfoCustomData OneItem)
	{
		if (OneItem != null && OneItem.MapId == MapSpriteId.Value)
		{
			DSMapSymbol dSMapSymbol = AddMapSymbol(EMapSymbolType.Pin, OneItem.Id, FText.GetEmpty(), new FVector2D(OneItem.PosX, OneItem.PosY));
			dSMapSymbol.SetStateParams((int)OneItem.GeoInfoCustomType);
			ShowCustomSymbolList.Add(dSMapSymbol);
			ShowPinCount.SetValue(EChangeReason.ManualSet, ShowCustomSymbolList.Count);
		}
	}

	private void DestroyCustomSymbol(GeoInfoCustomData OneItem)
	{
		DSMapSymbol mapSymbol = GetMapSymbol(DSMapSymbol.CalGuid(EMapSymbolType.Pin, OneItem.Id));
		if (mapSymbol != null)
		{
			RemoveMapSymbol(mapSymbol);
			ShowCustomSymbolList.Remove(mapSymbol);
			ShowPinCount.SetValue(EChangeReason.ManualSet, ShowCustomSymbolList.Count);
		}
	}

	public bool TryGetCustomSymbol(int Idx, out DSMapSymbol MapSymbol)
	{
		if (Idx >= 0 && Idx < ShowCustomSymbolList.Count)
		{
			MapSymbol = ShowCustomSymbolList[Idx];
			return true;
		}
		MapSymbol = null;
		return false;
	}

	public float CalMapScale()
	{
		return FMath.Lerp(SpriteConfig.MinScale, SpriteConfig.MaxScale, MapScale.Value);
	}

	public DSMapSymbol TryAddMapSymbol(EMapSymbolType InSymbolType, int Id, FText InName, FVector2D InPos)
	{
		string key = DSMapSymbol.CalGuid(InSymbolType, Id);
		DSMapSymbol mapSymbol = GetMapSymbol(key);
		if (mapSymbol == null)
		{
			return AddMapSymbol(InSymbolType, Id, InName, InPos);
		}
		return mapSymbol;
	}

	public DSMapSymbol GetMapSymbol(string Key)
	{
		if (string.IsNullOrEmpty(Key))
		{
			return null;
		}
		if (MapSymbolDic.ContainsKey(Key))
		{
			return MapSymbolDic[Key];
		}
		return null;
	}

	public void SetMapScale(EChangeReason Reason, float InMapScale)
	{
		MapScale.SetValue(Reason, FMath.Clamp(InMapScale, 0f, 1f));
	}

	public void SetMapBasePos(EChangeReason Reason, FVector2D InMapBasePos)
	{
		FVector2D moveRangeOffset = SpriteConfig.MoveRangeOffset;
		float num = FMath.Clamp(InMapBasePos.X, 0f - moveRangeOffset.X, moveRangeOffset.X);
		float num2 = FMath.Clamp(InMapBasePos.Y, 0f - moveRangeOffset.Y, moveRangeOffset.Y);
		MapBasePos.SetValue(Reason, new FVector2D(num, num2));
	}

	public void SetMapFocusGuid(string InMapFocusGuid)
	{
		MapFocusGuid.SetValue(EChangeReason.ManualSet, InMapFocusGuid);
	}

	public void SetMapSelectedGuidList(List<string> InMapSelectedGuidList)
	{
		MapSelectedGuidList.SetValue(EChangeReason.ManualSet, InMapSelectedGuidList);
	}

	public void SetMapSpriteId(int InMapSpriteId)
	{
		MapSpriteId.SetValue(EChangeReason.ManualSet, InMapSpriteId);
	}

	public void SetCursorPos(bool InOverrideCursorPos, FVector2D InCursorPos)
	{
		OverrideCursorPos.SetValue(EChangeReason.ManualSet, InOverrideCursorPos);
		CursorPos.SetValue(EChangeReason.ManualSet, InCursorPos);
	}

	public void SetCanShowCursor(bool InCanShowCursor)
	{
		CanShowCursor.SetValue(EChangeReason.ManualSet, InCanShowCursor);
	}

	public void SetShowCursor(bool InShowCursor)
	{
		ShowCursor.SetValue(EChangeReason.ManualSet, InShowCursor);
	}

	public void SetBlockFocus(bool InBlockFocus)
	{
		BlockFocus.SetValue(EChangeReason.ManualSet, InBlockFocus);
	}

	public void SetAlwayFocus(bool InAlwayFocus)
	{
		AlwayFocus.SetValue(EChangeReason.ManualSet, InAlwayFocus);
	}

	public void SetIsBlockImgEffect(bool InIsBlockImgEffect)
	{
		IsBlockImgEffect.SetValue(EChangeReason.ManualSet, InIsBlockImgEffect);
	}

	public FMapSpriteConfig GetSpriteConfig()
	{
		return SpriteConfig;
	}

	public FVector2D GetMapSpriteHelfSize()
	{
		if (MapSpriteDic.TryGetValue(MapSpriteId.Value, out var OutValue))
		{
			return OutValue.GetMapSize() / 2.0;
		}
		return FVector2D.ZeroVector;
	}

	public void SetSelectedAreaId(int InSelectedAreaId)
	{
		SelectedAreaId.SetValue(EChangeReason.ManualSet, InSelectedAreaId);
	}

	public void SetBlockInput(EBlockInputReason Reason, bool Value)
	{
		BlockInputData.SetBlockInput(Reason, Value);
	}

	public bool GetIsBlockInput()
	{
		return BlockInputData.BlockInput.Value;
	}

	public string GetBlockReason()
	{
		return BlockInputData.ToString();
	}
}
