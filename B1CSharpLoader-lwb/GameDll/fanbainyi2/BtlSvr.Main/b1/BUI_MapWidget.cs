using System;
using System.Collections.Generic;
using b1.Plugins.GSInput;
using b1.UI;
using b1.UI.Comm;
using B1UI.GSUI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_MapWidget")]
public class BUI_MapWidget : BUI_CursorMap
{
	private Dictionary<EMapSymbolType, MapSymbolLevelData> MapSymbolLevelConDic = new Dictionary<EMapSymbolType, MapSymbolLevelData>();

	private Dictionary<int, BUI_MapSprite> MapSpriteDic = new Dictionary<int, BUI_MapSprite>();

	private List<MapDescData> MapDescDataList = new List<MapDescData>();

	private UPanelWidget ScaleCon;

	private UPanelWidget MapCon;

	private UWidget PosCon;

	private UCanvasPanelSlot PosConSlot;

	private BUI_Widget DescWidget;

	private BUI_Widget MapDescWidget;

	private UCanvasPanel CursorCon;

	private UCanvasPanelSlot SlotCursor;

	public Action<DSMapSymbol> OnClickSymbolEvent;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ScaleCon = FindChildWidget("ScaleCon") as UPanelWidget;
		MapCon = FindChildWidget("MapCon") as UPanelWidget;
		PosCon = FindChildWidget("PosCon");
		PosConSlot = PosCon?.Slot as UCanvasPanelSlot;
		DescWidget = FindChildWidget("Desc_Widget") as BUI_Widget;
		MapDescWidget = UGSE_UMGFuncLib.GetWidgetFromName(DescWidget, B1GlobalFNames.BI_MapDesc) as BUI_Widget;
		MapDescWidget.SetVisibility(ESlateVisibility.Collapsed);
		CursorCon = FindChildWidget("CursorCon") as UCanvasPanel;
		CursorCon.SetRenderOpacity(0f);
		SlotCursor = CursorCon.Slot as UCanvasPanelSlot;
	}

	protected override void OnClickItem(string InMapFocusGuid)
	{
		base.OnClickItem(InMapFocusGuid);
		DSMapSymbol mapSymbol = DataStore.GetMapSymbol(InMapFocusGuid);
		if (mapSymbol != null)
		{
			OnClickSymbolEvent?.Invoke(mapSymbol);
		}
	}

	public override void InitDataStore(DSMapWidget InDataStore)
	{
		ClearData();
		ReleaseBindAction();
		DataStore = InDataStore;
		BindValueToCustom(DataStore.MapBasePos, OnChangeMapBasePos);
		BindValueToCustom(DataStore.MapScale, OnChangeMapScale);
		BindValueToCustom(DataStore.MapFocusGuid, OnChangeMapFocusGuid);
		BindValueToCustom(DataStore.MapSelectedGuidList, OnChangeMapSelectedGuidList);
		BindValueToCustom(DataStore.OverrideCursorPos, OnChangeOverrideCursorPos);
		BindValueToCustom(DataStore.CursorPos, OnChangeCursorPos);
		BindValueToCustom(DataStore.CanShowCursor, OnChangeShowCursor);
		BindValueToCustom(DataStore.ShowCursor, OnChangeShowCursor);
		BindDicToOnAdd(DataStore.MapSymbolLevelDic, OnMapSymbolTypeDicAdd);
		BindDicToOnRemove(DataStore.MapSymbolLevelDic, OnMapSymbolTypeDicRemove);
		BindDicToOnClear(DataStore.MapSymbolLevelDic, OnMapSymbolTypeDicClear);
		foreach (KeyValuePair<EMapSymbolType, DSMapSymbolLevel> item in DataStore.MapSymbolLevelDic)
		{
			MapSymbolLevelConDic.Add(item.Key, new MapSymbolLevelData(DataStore, this, item.Value));
		}
		BindDicToOnAdd(DataStore.MapSpriteDic, OnMapSpriteDicAdd);
		BindDicToOnRemove(DataStore.MapSpriteDic, OnMapSpriteDicRemove);
		BindDicToOnClear(DataStore.MapSpriteDic, OnMapSpriteDicClear);
		foreach (KeyValuePair<int, DSMapSprite> item2 in DataStore.MapSpriteDic)
		{
			OnMapSpriteDicAdd(item2.Key, item2.Value);
		}
	}

	private void OnMapSpriteDicAdd(int MapSpriteId, DSMapSprite Value)
	{
		if (MapSpriteDic.ContainsKey(MapSpriteId))
		{
			return;
		}
		BUI_MapSprite bUI_MapSprite = UGSE_UMGFuncLib.CreateUserWidget(this, GSUIResPathUtil.GetMapSpritePath(Value.MapSpriteId)) as BUI_MapSprite;
		if (!bUI_MapSprite.IsNullOrDestroyed())
		{
			MapCon.AddChild(bUI_MapSprite);
			if (bUI_MapSprite.Slot is UCanvasPanelSlot uCanvasPanelSlot)
			{
				uCanvasPanelSlot.SetAutoSize(InbAutoSize: true);
			}
			bUI_MapSprite.InitDataStore(Value);
			MapSpriteDic.Add(MapSpriteId, bUI_MapSprite);
		}
	}

	private void OnMapSpriteDicRemove(int MapSpriteId, DSMapSprite Value)
	{
		if (MapSpriteDic.TryGetValue(MapSpriteId, out var value))
		{
			MapCon.RemoveChild(value);
			MapSpriteDic.Remove(MapSpriteId);
		}
	}

	private void OnMapSpriteDicClear()
	{
		foreach (BUI_MapSprite value in MapSpriteDic.Values)
		{
			MapCon.RemoveChild(value);
		}
		MapSpriteDic.Clear();
	}

	private void OnMapSymbolTypeDicAdd(EMapSymbolType Key, DSMapSymbolLevel Value)
	{
		if (!MapSymbolLevelConDic.ContainsKey(Key))
		{
			MapSymbolLevelConDic.Add(Key, new MapSymbolLevelData(DataStore, this, Value));
		}
	}

	private void OnMapSymbolTypeDicRemove(EMapSymbolType Key, DSMapSymbolLevel Value)
	{
		if (MapSymbolLevelConDic.TryGetValue(Key, out var value))
		{
			value.GSOnDestruct();
		}
		MapSymbolLevelConDic.Remove(Key);
	}

	private void OnMapSymbolTypeDicClear()
	{
		foreach (MapSymbolLevelData value in MapSymbolLevelConDic.Values)
		{
			value.GSOnDestruct();
		}
		MapSymbolLevelConDic.Clear();
	}

	private UWidget GetMapSymbolWidget(string Guid)
	{
		DSMapSymbol mapSymbol = DataStore.GetMapSymbol(Guid);
		if (MapSymbolLevelConDic.TryGetValue(mapSymbol.MapSymbolType.Value, out var value))
		{
			return value.GetMapSymbolWidget(mapSymbol);
		}
		return null;
	}

	private void OnChangeMapFocusGuid(EChangeReason Reason, string OldValue, string NewValue)
	{
		if (!string.IsNullOrEmpty(NewValue))
		{
			DescWidget?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			DSMapSymbol mapSymbol = DataStore.GetMapSymbol(NewValue);
			if (mapSymbol != null)
			{
				DataStore.SetCursorPos(InOverrideCursorPos: true, DataStore.GetOriginMapPos(mapSymbol.MapPos.Value));
			}
			else
			{
				DataStore.SetCursorPos(InOverrideCursorPos: false, FVector2D.ZeroVector);
			}
		}
		else
		{
			DescWidget?.SetVisibility(ESlateVisibility.Collapsed);
			DataStore.SetCursorPos(InOverrideCursorPos: false, FVector2D.ZeroVector);
		}
	}

	private void OnChangeMapSelectedGuidList(EChangeReason Reason, List<string> OldValue, List<string> NewValue)
	{
		if (NewValue != null)
		{
			int num = 0;
			for (int i = 0; i < NewValue.Count; i++)
			{
				DSMapSymbol mapSymbol = DataStore.GetMapSymbol(NewValue[i]);
				if (mapSymbol != null && mapSymbol.GetCanShowDesc())
				{
					if (num >= MapDescDataList.Count)
					{
						MapDescData item = new MapDescData(MapDescWidget);
						MapDescDataList.Add(item);
					}
					MapDescDataList[num].InitDataStore(mapSymbol);
					MapDescDataList[num].GetWidget().SetVisibility(ESlateVisibility.SelfHitTestInvisible);
					num++;
				}
			}
			for (int j = num; j < MapDescDataList.Count; j++)
			{
				MapDescDataList[j].GetWidget().SetVisibility(ESlateVisibility.Collapsed);
			}
		}
		else
		{
			for (int k = 0; k < MapDescDataList.Count; k++)
			{
				MapDescDataList[k].GetWidget().SetVisibility(ESlateVisibility.Collapsed);
			}
		}
	}

	private void OnChangeMapBasePos(EChangeReason Reason, FVector2D OldValue, FVector2D NewValue)
	{
		PosConSlot?.SetPosition(DataStore.MapBasePos.Value);
		UpdateCursorPos();
	}

	private void OnChangeMapScale(EChangeReason Reason, float OldValue, float NewValue)
	{
		ScaleCon?.SetRenderScale(FVector2D.UnitVector * DataStore.CalMapScale());
		UpdateCursorPos();
	}

	private void OnChangeOverrideCursorPos(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UpdateShowCursor();
	}

	private void OnChangeCursorPos(EChangeReason Reason, FVector2D OldValue, FVector2D NewValue)
	{
		UpdateShowCursor();
	}

	private void OnChangeShowCursor(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		CursorCon?.SetRenderOpacity((DataStore.CanShowCursor.Value && DataStore.ShowCursor.Value) ? 1f : 0f);
	}

	private void UpdateCursorPos()
	{
		if (IsMouse && DataStore != null && DataStore.OverrideCursorPos.Value)
		{
			FVector2D fVector2D = DataStore.CursorPos.Value + DataStore.MapBasePos.Value;
			SlotCursor?.SetPosition(fVector2D * DataStore.CalMapScale());
		}
		else
		{
			SlotCursor?.SetPosition(FVector2D.ZeroVector);
		}
	}

	protected override void UpdateShowCursor()
	{
		UpdateCursorPos();
		base.UpdateShowCursor();
	}

	private void ClearData()
	{
		if (MapSymbolLevelConDic == null)
		{
			return;
		}
		foreach (KeyValuePair<EMapSymbolType, MapSymbolLevelData> item in MapSymbolLevelConDic)
		{
			item.Value.GSOnDestruct();
		}
		MapSymbolLevelConDic.Clear();
	}

	public BUI_MapSprite GetShowMapSprite()
	{
		if (MapSpriteDic.TryGetValue(DataStore.MapSpriteId.Value, out var value))
		{
			return value;
		}
		return null;
	}

	public void ForceUpdateData()
	{
		if (DataStore == null)
		{
			return;
		}
		if (MapAreaData.TryGetMapPositionByPlayer(this, out var MapSpriteId, out var MapPosition, out var MapRotation))
		{
			DataStore.SetMapSpriteId(MapSpriteId);
			string key = DSMapSymbol.CalGuid(EMapSymbolType.Player, 0);
			DSMapSymbol mapSymbol = DataStore.GetMapSymbol(key);
			if (mapSymbol != null)
			{
				mapSymbol.SetMapPos(MapPosition);
				mapSymbol.SetAngle(MapRotation);
				ResetToMapSymbol(mapSymbol, IsForce: true);
			}
		}
		GetShowMapSprite()?.UnlockAllArea();
	}

	protected override void OnSwitchInput(EGSInputType InputType)
	{
		base.OnSwitchInput(InputType);
		UpdateCursorPos();
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		ClearData();
		DataStore = null;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_MapWidget");
	}

	static BUI_MapWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_MapWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_MapWidget));
	}
}
